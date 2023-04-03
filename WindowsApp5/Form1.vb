Public Class FtpTXT
    Dim MainFolder As String
    Dim FTPstring As String
    Dim HasloString As String
    Dim LoginString As String
    Dim InputValidation As New InputValidation

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DownloadBtn.Click
        Try
            ErrLbl.Text = "Trwa pobieranie plików do aktualizacji"
            Cursor = Cursors.WaitCursor
            Dim FtpSet As New FileDownloadFTP(FTPstring, LoginString, HasloString, MainFolder)
            Dim FolderPth As String
            Dim FolderArr() As String
            Dim folderSet As New FolderSetings(MainFolder)
            FtpSet.CheckedFolderList.Add("")

            For Each txt As CheckBox In FolderListPanel.Controls
                FolderPth = ""
                If txt.Checked Then
                    txt.Text = txt.Text.Replace("/", "\")
                    FtpSet.CheckedFolderList.Add("\" & txt.Text)
                    FolderArr = txt.Text.Split("\")
                    For i = FolderArr.GetLowerBound(0) To FolderArr.GetUpperBound(0)
                        FolderPth = FolderPth & FolderArr(i)
                        folderSet.Directory = FolderPth
                        folderSet.CreateFolders()
                        FolderPth = FolderPth & "/"
                    Next
                End If
            Next

            FtpSet.FileDownload()
            ErrLbl.Text = "Pobrano pliki instalacyjne - kliknij przycisk by rozpocząć instalacje aktualizacji"
            ErrLbl.ForeColor = Color.Green
            Cursor = Cursors.Default
            DownloadBtn.BackColor = Color.FromArgb(0, 82, 165)
            InstalBtn.Visible = True
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
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles InstalBtn.Click
        Try
            Process.Start(MainFolder & "\setup.exe")
            MessageBox.Show("Aplikacja zakualizowana")
            Application.Exit()
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
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        FtpTextbox.Text = "ftp://pliki.inwemer.pl/Logowanie"
        LoginTxt.Text = "msaccess"
        HasloTxt.Text = "TBF49$#1ksXq2A"
        FolderTxt.Text = "C:\Program Files\Koordynator\Logowanie"


    End Sub

    Private Sub SourceListBtn_Click(sender As Object, e As EventArgs) Handles SourceListBtn.Click
        Try
            If String.IsNullOrEmpty(FolderTxt.Text) Or String.IsNullOrEmpty(FtpTextbox.Text) Then
                ErrLbl.Visible = True
                ErrLbl.Text = "Uzupełnij ścieżki!"
                Exit Sub
            Else
                ErrLbl.Visible = True
                ErrLbl.Text = ""
            End If
            MainFolder = FolderTxt.Text
            FTPstring = FtpTextbox.Text
            HasloString = HasloTxt.Text
            LoginString = LoginTxt.Text
            FolderListPanel.Controls.Clear()

            Dim FtpSet As New FileDownloadFTP(FTPstring, LoginString, HasloString, MainFolder)

            Dim PanelsText As New List(Of String)
            PanelsText = FtpSet.GetDirectories()

            Dim Position As Integer = 1
            For Each LabelText As String In PanelsText
                Dim MyCheckbox As New CheckBox() With
                {
                    .Name = "FolderCheck" & Position,
                    .Text = LabelText,
                    .Location = New Point(10, 25 * Position),
                    .Height = 23,
                    .Width = 2200,
                    .Checked = True
                }
                FolderListPanel.Controls.Add(MyCheckbox)
                Position += 1
            Next

            SourceListBtn.BackColor = Color.FromArgb(0, 82, 165)
            ErrLbl.Text = "Wybierz ścieżki z których chcesz pobrać pliki"
            ErrLbl.ForeColor = Color.Green
            DownloadBtn.Visible = True
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
    End Sub



    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        HasloTxt.PasswordChar = ""
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        HasloTxt.PasswordChar = "*"
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        LoginTxt.PasswordChar = ""
    End Sub
    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        LoginTxt.PasswordChar = "*"
    End Sub

    Private Sub FolderTxt_TextChanged(sender As Object, e As EventArgs) Handles FolderTxt.GotFocus
        TipLabelFolder.Visible = False
    End Sub

    Private Sub FolderTxt_Leave(sender As Object, e As EventArgs) Handles FolderTxt.LostFocus
        InputValidation.AssignValidation(FolderTxt, InputValidation.ValidationType2.Not_Null, ErrLbl)
    End Sub
    Private Sub TipLabelFolder_Click(sender As Object, e As EventArgs) Handles TipLabelFolder.Click
        FolderTxt.Focus()
        TipLabelFolder.Visible = False

    End Sub
    Private Sub FtpTextbox_TextChanged(sender As Object, e As EventArgs) Handles FtpTextbox.GotFocus
        TipLabelFtp.Visible = False
    End Sub
    Private Sub FtpTextbox_Leave(sender As Object, e As EventArgs) Handles FtpTextbox.LostFocus
        InputValidation.AssignValidation(FtpTextbox, InputValidation.ValidationType2.Not_Null, ErrLbl)
    End Sub
    Private Sub TipLabelFtp_Click(sender As Object, e As EventArgs) Handles TipLabelFtp.Click
        FtpTextbox.Focus()
        TipLabelFtp.Visible = False
    End Sub
End Class
