Imports System.Net
Imports System.IO

Public Class Form1

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Try
			Label1.Visible = True
			Cursor = Cursors.WaitCursor
			Dim FtpSet As New FileDownloadFTP("ftp://pliki.inwemer.pl/Logowanie", "msaccess", "TBF49$#1ksXq2A", "C:\Program Files\Koordynator\Logowanie")
			FtpSet.FileDownload()
			Label1.Text = "Pobrano pliki instalacyjne - kliknij przycisk by rozpocząć instalacje aktualizacji"
			Label1.ForeColor = Color.Green
			Cursor = Cursors.Default
			Button1.Visible = True
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
	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		Try
			Process.Start("C:\Program Files\Koordynator\Logowanie\setup.exe")
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
			End
		End Try
	End Sub





End Class
