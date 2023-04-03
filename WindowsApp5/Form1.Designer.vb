<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FtpTXT
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FtpTXT))
        Me.DownloadBtn = New System.Windows.Forms.Button()
        Me.InstalBtn = New System.Windows.Forms.Button()
        Me.ErrLbl = New System.Windows.Forms.Label()
        Me.BtnPanel = New System.Windows.Forms.Panel()
        Me.SourceListBtn = New System.Windows.Forms.Button()
        Me.FolderListPanel = New System.Windows.Forms.Panel()
        Me.TextBoxPanel = New System.Windows.Forms.Panel()
        Me.TipLabelFtp = New System.Windows.Forms.Label()
        Me.TipLabelFolder = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HasloTxt = New System.Windows.Forms.TextBox()
        Me.LoginTxt = New System.Windows.Forms.TextBox()
        Me.FolderTxt = New System.Windows.Forms.TextBox()
        Me.FtpTextbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LoginLbl = New System.Windows.Forms.Label()
        Me.FolderZapisuDyskLBL = New System.Windows.Forms.Label()
        Me.ScieżkaFtpLBL = New System.Windows.Forms.Label()
        Me.BtnBoxPanel = New System.Windows.Forms.Panel()
        Me.BtnPanel.SuspendLayout()
        Me.TextBoxPanel.SuspendLayout()
        Me.BtnBoxPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DownloadBtn
        '
        Me.DownloadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.DownloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DownloadBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DownloadBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.DownloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DownloadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!, System.Drawing.FontStyle.Bold)
        Me.DownloadBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.DownloadBtn.Location = New System.Drawing.Point(436, 0)
        Me.DownloadBtn.MinimumSize = New System.Drawing.Size(333, 113)
        Me.DownloadBtn.Name = "DownloadBtn"
        Me.DownloadBtn.Size = New System.Drawing.Size(428, 121)
        Me.DownloadBtn.TabIndex = 3
        Me.DownloadBtn.Text = "Pobierz pliki aktualizacji"
        Me.DownloadBtn.UseVisualStyleBackColor = False
        Me.DownloadBtn.Visible = False
        '
        'InstalBtn
        '
        Me.InstalBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.InstalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.InstalBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InstalBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.InstalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.InstalBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!, System.Drawing.FontStyle.Bold)
        Me.InstalBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.InstalBtn.Location = New System.Drawing.Point(0, 0)
        Me.InstalBtn.MinimumSize = New System.Drawing.Size(333, 113)
        Me.InstalBtn.Name = "InstalBtn"
        Me.InstalBtn.Size = New System.Drawing.Size(436, 121)
        Me.InstalBtn.TabIndex = 4
        Me.InstalBtn.Text = "Instalacja aktualizacji"
        Me.InstalBtn.UseVisualStyleBackColor = False
        Me.InstalBtn.Visible = False
        '
        'ErrLbl
        '
        Me.ErrLbl.AutoSize = True
        Me.ErrLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.ErrLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.ErrLbl.ForeColor = System.Drawing.Color.Red
        Me.ErrLbl.Location = New System.Drawing.Point(0, 0)
        Me.ErrLbl.Name = "ErrLbl"
        Me.ErrLbl.Size = New System.Drawing.Size(0, 29)
        Me.ErrLbl.TabIndex = 5
        '
        'BtnPanel
        '
        Me.BtnPanel.Controls.Add(Me.SourceListBtn)
        Me.BtnPanel.Controls.Add(Me.DownloadBtn)
        Me.BtnPanel.Controls.Add(Me.InstalBtn)
        Me.BtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnPanel.Location = New System.Drawing.Point(0, 158)
        Me.BtnPanel.Name = "BtnPanel"
        Me.BtnPanel.Size = New System.Drawing.Size(1630, 121)
        Me.BtnPanel.TabIndex = 6
        '
        'SourceListBtn
        '
        Me.SourceListBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.SourceListBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SourceListBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.SourceListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SourceListBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!, System.Drawing.FontStyle.Bold)
        Me.SourceListBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.SourceListBtn.Location = New System.Drawing.Point(864, 0)
        Me.SourceListBtn.MinimumSize = New System.Drawing.Size(333, 113)
        Me.SourceListBtn.Name = "SourceListBtn"
        Me.SourceListBtn.Size = New System.Drawing.Size(424, 121)
        Me.SourceListBtn.TabIndex = 0
        Me.SourceListBtn.Text = "Wybierz listę plików"
        Me.SourceListBtn.UseVisualStyleBackColor = False
        '
        'FolderListPanel
        '
        Me.FolderListPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.FolderListPanel.Location = New System.Drawing.Point(5, 32)
        Me.FolderListPanel.Name = "FolderListPanel"
        Me.FolderListPanel.Size = New System.Drawing.Size(1613, 686)
        Me.FolderListPanel.TabIndex = 7
        '
        'TextBoxPanel
        '
        Me.TextBoxPanel.Controls.Add(Me.TipLabelFtp)
        Me.TextBoxPanel.Controls.Add(Me.TipLabelFolder)
        Me.TextBoxPanel.Controls.Add(Me.Label3)
        Me.TextBoxPanel.Controls.Add(Me.Label2)
        Me.TextBoxPanel.Controls.Add(Me.HasloTxt)
        Me.TextBoxPanel.Controls.Add(Me.LoginTxt)
        Me.TextBoxPanel.Controls.Add(Me.FolderTxt)
        Me.TextBoxPanel.Controls.Add(Me.FtpTextbox)
        Me.TextBoxPanel.Controls.Add(Me.Label5)
        Me.TextBoxPanel.Controls.Add(Me.LoginLbl)
        Me.TextBoxPanel.Controls.Add(Me.FolderZapisuDyskLBL)
        Me.TextBoxPanel.Controls.Add(Me.ScieżkaFtpLBL)
        Me.TextBoxPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBoxPanel.Location = New System.Drawing.Point(0, 3)
        Me.TextBoxPanel.Name = "TextBoxPanel"
        Me.TextBoxPanel.Size = New System.Drawing.Size(1283, 144)
        Me.TextBoxPanel.TabIndex = 8
        '
        'TipLabelFtp
        '
        Me.TipLabelFtp.AutoSize = True
        Me.TipLabelFtp.BackColor = System.Drawing.SystemColors.Window
        Me.TipLabelFtp.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.TipLabelFtp.Location = New System.Drawing.Point(12, 85)
        Me.TipLabelFtp.Name = "TipLabelFtp"
        Me.TipLabelFtp.Size = New System.Drawing.Size(526, 17)
        Me.TipLabelFtp.TabIndex = 10
        Me.TipLabelFtp.Text = "Uzupełnij scieżke do folderu FTP np. ftp://Nazwa_serwera.pl/FolderPliki"
        '
        'TipLabelFolder
        '
        Me.TipLabelFolder.AutoSize = True
        Me.TipLabelFolder.BackColor = System.Drawing.SystemColors.Window
        Me.TipLabelFolder.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.TipLabelFolder.Location = New System.Drawing.Point(12, 31)
        Me.TipLabelFolder.Name = "TipLabelFolder"
        Me.TipLabelFolder.Size = New System.Drawing.Size(564, 17)
        Me.TipLabelFolder.TabIndex = 9
        Me.TipLabelFolder.Text = "Uzupełnij scieżke do folderu zapisu na dysku np. C:\Program Files\MojFolder"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(986, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "◎"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(986, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "◎"
        '
        'HasloTxt
        '
        Me.HasloTxt.Location = New System.Drawing.Point(687, 85)
        Me.HasloTxt.Name = "HasloTxt"
        Me.HasloTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.HasloTxt.Size = New System.Drawing.Size(328, 22)
        Me.HasloTxt.TabIndex = 7
        '
        'LoginTxt
        '
        Me.LoginTxt.Location = New System.Drawing.Point(687, 31)
        Me.LoginTxt.Name = "LoginTxt"
        Me.LoginTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LoginTxt.Size = New System.Drawing.Size(328, 22)
        Me.LoginTxt.TabIndex = 6
        '
        'FolderTxt
        '
        Me.FolderTxt.Location = New System.Drawing.Point(3, 31)
        Me.FolderTxt.Name = "FolderTxt"
        Me.FolderTxt.Size = New System.Drawing.Size(675, 22)
        Me.FolderTxt.TabIndex = 5
        '
        'FtpTextbox
        '
        Me.FtpTextbox.Location = New System.Drawing.Point(3, 85)
        Me.FtpTextbox.Name = "FtpTextbox"
        Me.FtpTextbox.Size = New System.Drawing.Size(675, 22)
        Me.FtpTextbox.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(684, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Haslo:"
        '
        'LoginLbl
        '
        Me.LoginLbl.AutoSize = True
        Me.LoginLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LoginLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LoginLbl.Location = New System.Drawing.Point(684, 11)
        Me.LoginLbl.Name = "LoginLbl"
        Me.LoginLbl.Size = New System.Drawing.Size(53, 17)
        Me.LoginLbl.TabIndex = 2
        Me.LoginLbl.Text = "Login:"
        '
        'FolderZapisuDyskLBL
        '
        Me.FolderZapisuDyskLBL.AutoSize = True
        Me.FolderZapisuDyskLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FolderZapisuDyskLBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FolderZapisuDyskLBL.Location = New System.Drawing.Point(3, 11)
        Me.FolderZapisuDyskLBL.Name = "FolderZapisuDyskLBL"
        Me.FolderZapisuDyskLBL.Size = New System.Drawing.Size(181, 17)
        Me.FolderZapisuDyskLBL.TabIndex = 1
        Me.FolderZapisuDyskLBL.Text = "Folder zapisu na dysku:"
        '
        'ScieżkaFtpLBL
        '
        Me.ScieżkaFtpLBL.AutoSize = True
        Me.ScieżkaFtpLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ScieżkaFtpLBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ScieżkaFtpLBL.Location = New System.Drawing.Point(3, 65)
        Me.ScieżkaFtpLBL.Name = "ScieżkaFtpLBL"
        Me.ScieżkaFtpLBL.Size = New System.Drawing.Size(120, 17)
        Me.ScieżkaFtpLBL.TabIndex = 0
        Me.ScieżkaFtpLBL.Text = "Scieżka do Ftp:"
        '
        'BtnBoxPanel
        '
        Me.BtnBoxPanel.Controls.Add(Me.TextBoxPanel)
        Me.BtnBoxPanel.Controls.Add(Me.BtnPanel)
        Me.BtnBoxPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnBoxPanel.Location = New System.Drawing.Point(0, 1046)
        Me.BtnBoxPanel.Name = "BtnBoxPanel"
        Me.BtnBoxPanel.Size = New System.Drawing.Size(1630, 279)
        Me.BtnBoxPanel.TabIndex = 8
        '
        'FtpTXT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1630, 1325)
        Me.Controls.Add(Me.BtnBoxPanel)
        Me.Controls.Add(Me.FolderListPanel)
        Me.Controls.Add(Me.ErrLbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1300, 1000)
        Me.Name = "FtpTXT"
        Me.Text = "Aktualizacja"
        Me.BtnPanel.ResumeLayout(False)
        Me.TextBoxPanel.ResumeLayout(False)
        Me.TextBoxPanel.PerformLayout()
        Me.BtnBoxPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DownloadBtn As Button
    Friend WithEvents InstalBtn As Button
    Friend WithEvents ErrLbl As Label
    Friend WithEvents BtnPanel As Panel
    Friend WithEvents FolderListPanel As Panel
    Friend WithEvents SourceListBtn As Button
    Friend WithEvents TextBoxPanel As Panel
    Friend WithEvents HasloTxt As TextBox
    Friend WithEvents LoginTxt As TextBox
    Friend WithEvents FolderTxt As TextBox
    Friend WithEvents FtpTextbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LoginLbl As Label
    Friend WithEvents FolderZapisuDyskLBL As Label
    Friend WithEvents ScieżkaFtpLBL As Label
    Friend WithEvents BtnBoxPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TipLabelFolder As Label
    Friend WithEvents TipLabelFtp As Label
End Class
