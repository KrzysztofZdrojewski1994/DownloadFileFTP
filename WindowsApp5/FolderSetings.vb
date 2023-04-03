Imports System.IO
Imports System.Text


Public Class FolderSetings
    Private _root As String
    Private _Directory As String
    Public Sub New()
        'init
    End Sub
    Public Sub New(root As String)
        _root = root
        _Directory = Directory
    End Sub
    Public Sub New(root As String, Directory As String)
        _root = root
        _Directory = Directory
    End Sub
    Public Property Root As String
        Set(value As String)
            If value <> "" Then
                _root = ClearLastChar(value)
            End If

        End Set
        Get
            Return _root
        End Get
    End Property

    Public Property Directory As String
        Set(value As String)
            If value <> "" Then
                _Directory = value
            End If
        End Set
        Get
            Return _Directory
        End Get
    End Property

    Function CreateFolders()
        Try
            If Not System.IO.Directory.Exists(_root) Then
                System.IO.Directory.CreateDirectory(_root)
            End If
            If Not System.IO.Directory.Exists(_root & "/" & _Directory) Then
                System.IO.Directory.CreateDirectory(_root & "/" & _Directory)
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
