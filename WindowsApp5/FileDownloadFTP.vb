Imports System.IO
Imports System.Net


Public Class FileDownloadFTP
	Private _PathFTP As String
	Private _Login As String
	Private _Haslo As String
	Private _SavePath As String


	Public Sub New()

	End Sub
	Public Sub New(FtpPath As String, Login As String, Haslo As String, SavePath As String)
		_PathFTP = FtpPath
		_Haslo = Haslo
		_Login = Login
		_SavePath = SavePath
	End Sub
	Property SavePath As String
		Set(value As String)
			If value <> "" Then
				_SavePath = ClearLastChar(value)
			End If

		End Set
		Get
			Return _SavePath
		End Get
	End Property
	Property PathFTP As String
		Set(value As String)
			If value <> "" Then
				_PathFTP = ClearLastChar(value)
			End If

		End Set
		Get
			Return _PathFTP
		End Get
	End Property
	Property Login As String
		Set(value As String)
			If value <> "" Then
				_Login = value
			End If

		End Set
		Get
			Return _Login
		End Get
	End Property

	Property Haslo As String
		Set(value As String)
			If value <> "" Then
				_Haslo = value
			End If

		End Set
		Get
			Return _Haslo
		End Get
	End Property


	Function connectToFTP() As StreamReader
		Try
			Dim ftpRequest As FtpWebRequest = DirectCast(WebRequest.Create(_PathFTP & "/"), FtpWebRequest)
			ftpRequest.Credentials = New NetworkCredential(_Login, _Haslo)
			ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory
			Dim response As FtpWebResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)
			Dim streamReader As New StreamReader(response.GetResponseStream())
			Return streamReader
		Catch ex As Exception
			MessageBox.Show(
					"Wystąpił błąd: " & vbCr &
							"Number: " & Err.Number & vbCr &
							"Description: " & Err.Description & vbCr &
							"Source: " & Err.Source & vbCr &
							"Line: " & Err.Erl & vbCr, "Wystąpił bład",
							MessageBoxButtons.OK, MessageBoxIcon.Error
			)
			End
		End Try
	End Function


	Function connectToFTP(Path As String) As StreamReader
		Try
			Dim ftpRequest As FtpWebRequest = DirectCast(WebRequest.Create(Path), FtpWebRequest)
			ftpRequest.Credentials = New NetworkCredential(_Login, _Haslo)
			ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory
			Dim response As FtpWebResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)
			Dim streamReader As New StreamReader(response.GetResponseStream())
			Return streamReader

		Catch ex As Exception

			MessageBox.Show(
							"Wystąpił błąd: " & vbCr &
							"Number: " & Err.Number & vbCr &
							"Description: " & Err.Description & vbCr &
							"Source: " & Err.Source & vbCr &
							"Line: " & Err.Erl & vbCr, "Wystąpił bład",
							MessageBoxButtons.OK, MessageBoxIcon.Error
		)
			End
		End Try
	End Function


	Function GetDirectories() As List(Of String)
		Try
			Dim CunterOfDir As Integer
			Dim i As Integer
			i = 0
			Dim Sr As StreamReader
			Sr = connectToFTP()
			Dim directories As New List(Of String)()
			Dim line As String
			line = Sr.ReadLine()
			While Not String.IsNullOrEmpty(line)
				If Not line.Contains(".") Then
					directories.Add(line)
					line = Sr.ReadLine()
				Else
					line = Sr.ReadLine()
				End If
			End While

			CunterOfDir = directories.Count

			While i < CunterOfDir
				Sr = connectToFTP(_PathFTP & "/" & directories(i) & "/")
				line = Sr.ReadLine()
				While Not String.IsNullOrEmpty(line)
					If Not line.Contains(".") Then
						directories.Add(directories(i) & "/" & line)
						line = Sr.ReadLine()
						CunterOfDir = CunterOfDir + 1
					Else
						line = Sr.ReadLine()
					End If
				End While
				i = i + 1
			End While
			Sr.Close()
			Return directories
		Catch ex As Exception

			MessageBox.Show(
						"Wystąpił błąd: " & vbCr &
						"Number: " & Err.Number & vbCr &
						"Description: " & Err.Description & vbCr &
						"Source: " & Err.Source & vbCr &
						"Line: " & Err.Erl & vbCr, "Wystąpił bład",
						MessageBoxButtons.OK, MessageBoxIcon.Error
	)
		End
		End Try

	End Function
	Function GetDirectories(DirFTP As String) As List(Of String) 'Pobieranie listy folderów pod wskazaną ściezką
		Try
			Dim ftpRequest As FtpWebRequest = DirectCast(WebRequest.Create(DirFTP), FtpWebRequest)
			ftpRequest.Credentials = New NetworkCredential(_Login, _Haslo)
			ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory
			Dim response As FtpWebResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)
			Dim streamReader As New StreamReader(response.GetResponseStream())
			Dim directories As New List(Of String)()

			Dim line As String = streamReader.ReadLine()
			While Not String.IsNullOrEmpty(line)
				directories.Add(line)
				line = streamReader.ReadLine()
			End While
			streamReader.Close()
			Return directories
		Catch ex As Exception

			MessageBox.Show(
					"Wystąpił błąd: " & vbCr &
					"Number: " & Err.Number & vbCr &
					"Description: " & Err.Description & vbCr &
					"Source: " & Err.Source & vbCr &
					"Line: " & Err.Erl & vbCr, "Wystąpił bład",
					MessageBoxButtons.OK, MessageBoxIcon.Error
)
			End
		End Try
	End Function


	Function AfterDir(SearchWithinThis As String) As String 'Zostawienie tylko nazwy pliku z pełnej ścieżki
		Try
			Dim SearchForThis As String
			Dim LastCharacter As Integer
			If SearchWithinThis.Contains("/") Then
				SearchForThis = "/"
				LastCharacter = SearchWithinThis.LastIndexOf(SearchForThis)
				Return Mid(SearchWithinThis, LastCharacter + 1, Len(SearchWithinThis) - LastCharacter)
			ElseIf SearchWithinThis.Contains("\") Then
				SearchForThis = "\"
				LastCharacter = SearchWithinThis.LastIndexOf(SearchForThis)
				Return Mid(SearchWithinThis, LastCharacter + 1, Len(SearchWithinThis) - LastCharacter)
			Else
				Return SearchWithinThis
			End If

		Catch ex As Exception

			MessageBox.Show(
				"Wystąpił błąd: " & vbCr &
				"Number: " & Err.Number & vbCr &
				"Description: " & Err.Description & vbCr &
				"Source: " & Err.Source & vbCr &
				"Line: " & Err.Erl & vbCr, "Wystąpił bład",
				MessageBoxButtons.OK, MessageBoxIcon.Error
)
			End
		End Try
	End Function


	Function FileDownload()
		Try
			'Tworzenie Folderów na Dysku
			Dim FolderList As New List(Of String)()
			Dim folderSet As New FolderSetings
			folderSet.Root = _SavePath & "/" 'Scieżka
			FolderList.Add("")
			For Each directory In GetDirectories() 'Pobranie Listy scieżek na serwerze ftp do utworzenie folderów na dysku
				folderSet.Directory = directory
				folderSet.CreateFolders() 'Utworzenie folderu
				FolderList.Add("/" & directory) 'Dodanie do listy folderów
			Next

			'Pobranie plików z Pierwszego folderu FTP
			Using ftpClient As New WebClient()
				ftpClient.Credentials = New System.Net.NetworkCredential(_Login, _Haslo) 'Logowanie do serwera
				For Each directory In FolderList 'Pętla po folderach
					For Each file In GetDirectories(_PathFTP & directory) 'Petla po plikach w folderze
						If file.Contains(".") Then

							Dim path As String = _PathFTP & directory & AfterDir(file.ToString()) 'Przypisanie ścieżki FTP
							Dim trnsfrpth As String = _SavePath & directory & AfterDir(file.ToString()) 'Przypisanie scieżki zapisu
							trnsfrpth = trnsfrpth.Replace("/", "\") 'Zamiana shlashy  
							ftpClient.DownloadFile(path, trnsfrpth) 'Pobranie pliku
						End If
					Next
				Next
			End Using

		Catch ex As Exception
			MessageBox.Show(
			"Wystąpił błąd: " & vbCr &
			"Number: " & Err.Number & vbCr &
			"Description: " & Err.Description & vbCr &
			"Source: " & Err.Source & vbCr &
			"Line: " & Err.Erl & vbCr, "Wystąpił bład",
			MessageBoxButtons.OK, MessageBoxIcon.Error
)
			End
		End Try
	End Function
	Function ClearLastChar(SearchWithinThis As String) As String
		Dim SearchForThis As String
		Dim LastCharacter As Integer
		If SearchWithinThis.Contains("/") Then
			SearchForThis = "/"
			LastCharacter = SearchWithinThis.LastIndexOf(SearchForThis)
			If LastCharacter + 1 = Len(SearchWithinThis) Then
				Return Mid(SearchWithinThis, 1, LastCharacter)
			Else
				Return SearchWithinThis

			End If
		ElseIf SearchWithinThis.Contains("\") Then
			SearchForThis = "\"
			LastCharacter = SearchWithinThis.LastIndexOf(SearchForThis)
			If LastCharacter + 1 = Len(SearchWithinThis) Then
				Return Mid(SearchWithinThis, 1, LastCharacter)
			Else
				Return SearchWithinThis
			End If
		Else
			Return SearchWithinThis
		End If

	End Function



End Class
