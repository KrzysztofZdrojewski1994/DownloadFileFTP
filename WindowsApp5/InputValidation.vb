
Imports System.Text.RegularExpressions
    Public Class InputValidation
        Private Errlbl As Windows.Forms.Label
        Public Enum ValidationType1
            Only_Numbers = 1
            Only_Characters = 2
        End Enum
        Public Enum ValidationType2
            Not_Null = 3
            Only_Email = 4
            Postal_Code = 5
            NIP = 6
        End Enum
        Public Sub AssignValidation(ByRef CTRL As Windows.Forms.TextBox, ByVal Validation_Type As ValidationType1)
            Dim txt As Windows.Forms.TextBox = CTRL
            Select Case Validation_Type
                Case ValidationType1.Only_Numbers
                    AddHandler txt.KeyPress, AddressOf number_Leave
                Case ValidationType1.Only_Characters
                    AddHandler txt.KeyPress, AddressOf OCHAR_Leave
            End Select
        End Sub
        Public Sub AssignValidation(ByRef CTRL As Windows.Forms.TextBox, ByVal Validation_Type As ValidationType2, ByRef SetErrLbl As Windows.Forms.Label)
            Dim txt As Windows.Forms.TextBox = CTRL
            Select Case Validation_Type
                Case ValidationType2.Not_Null
                    Errlbl = SetErrLbl
                    AddHandler txt.Leave, AddressOf NotNull_Leave
                Case ValidationType2.Only_Email
                    Errlbl = SetErrLbl
                    AddHandler txt.Leave, AddressOf Email_Leave
                Case ValidationType2.Postal_Code
                    Errlbl = SetErrLbl
                    AddHandler txt.Leave, AddressOf PostalCode_Leave
                Case ValidationType2.NIP
                    Errlbl = SetErrLbl
                    AddHandler txt.Leave, AddressOf NIP_Leave
            End Select
        End Sub
        Public Sub number_Leave(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
            Dim numbers As Windows.Forms.TextBox = sender
            If InStr("1234567890,", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "," And InStr(numbers.Text, ",") > 0) Then
                e.KeyChar = Chr(0)
                e.Handled = True
            End If
        End Sub
        Public Sub OCHAR_Leave(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
            If InStr("1234567890!@#$%^&*()_+=-", e.KeyChar) > 0 Then
                e.KeyChar = Chr(0)
                e.Handled = True
            End If
        End Sub
        Public Sub NotNull_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim No As Windows.Forms.TextBox = sender
            If No.Text.Trim = "" Then
                No.BackColor = Color.Red
                Errlbl.Text = "Uzupełnij to pole!"
                Errlbl.Visible = True
                No.Focus()
            Else
                Errlbl.Text = ""
                Errlbl.Visible = False
                No.BackColor = Color.White
            End If
        End Sub
        Public Sub Email_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim Email As Windows.Forms.TextBox = sender
            If Email.Text <> "" Then
                Dim rex As Match = Regex.Match(Trim(Email.Text), "^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,3})$", RegexOptions.IgnoreCase)
                If rex.Success = False Then
                    Errlbl.Text = "Popraw adres e-mail na prawidłowy!"
                    Errlbl.Visible = True
                    Email.BackColor = Color.Red
                    Email.Focus()
                    Exit Sub
                Else
                    Email.BackColor = Color.White
                    Errlbl.Text = ""
                    Errlbl.Visible = False
                End If
            End If
        End Sub
        Public Sub PostalCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim Kod As Windows.Forms.TextBox = sender
            If Kod.Text <> "" Then
                Dim rex As Match = Regex.Match(Trim(Kod.Text), "[0-9][0-9]-[0-9]{3}$", RegexOptions.IgnoreCase)
                If rex.Success = False Then
                    Errlbl.Text = "Popraw kod pocztowy na prawidłowy! np 10-123"
                    Errlbl.Visible = True
                    Kod.BackColor = Color.Red
                    Kod.Focus()
                    Exit Sub
                Else
                    Kod.BackColor = Color.White
                    Errlbl.Text = ""
                    Errlbl.Visible = False
                End If
            End If
        End Sub

        Public Sub NIP_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim Nip As Windows.Forms.TextBox = sender
            Dim err As String
            If Nip.Text <> "" Then
                Dim rex As Match = Regex.Match(Trim(Nip.Text), "[0-9]{10}$", RegexOptions.IgnoreCase)
                If rex.Success = False Or Len(Nip.Text) > 10 Then
                    err = "NIP ma nie poprawną ilość znaków!"
                    GoTo Wrong
                End If
                If CzyNIPPoprawny(Nip.Text) Then
                    Nip.BackColor = Color.White
                    Errlbl.Text = ""
                    Errlbl.Visible = False
                Else
                    err = "Cyfra kontrolna wskazuje błąd!"
                    GoTo Wrong
                End If

            End If
            Exit Sub
Wrong:
            Errlbl.Text = "Błędny NIP: " & err
            Errlbl.Visible = True
            Nip.BackColor = Color.Red
            Nip.Focus()
            Exit Sub
        End Sub

        Private Function CzyNIPPoprawny(sNIP As String) As Boolean
            Dim iWagi = New Integer() {6, 5, 7, 2, 3, 4, 5, 6, 7}
            Dim i As Integer
            Dim iSumaKon As Integer

            On Error GoTo Err_CzyNIPPoprawny

            If Len(sNIP) <> 10 Then
                Return CzyNIPPoprawny = False
            End If
            For i = LBound(iWagi) To UBound(iWagi)
                iSumaKon = iSumaKon + (iWagi(i) * CInt(Mid(sNIP, i + 1, 1)))
            Next i

            iSumaKon = iSumaKon Mod 11
            CzyNIPPoprawny = CBool(CInt(Mid(sNIP, 10, 1)) = iSumaKon)
            Exit Function

Err_CzyNIPPoprawny:
            CzyNIPPoprawny = False
            Err.Clear()
        End Function

    End Class

