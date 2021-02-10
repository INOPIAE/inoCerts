<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMozilla
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.ClbFirefox = New System.Windows.Forms.CheckedListBox()
        Me.ClbThunderbird = New System.Windows.Forms.CheckedListBox()
        Me.ChkIntermediate = New System.Windows.Forms.CheckBox()
        Me.ChkRoot = New System.Windows.Forms.CheckBox()
        Me.CbCA = New System.Windows.Forms.ComboBox()
        Me.LblCA = New System.Windows.Forms.Label()
        Me.LblFirefox = New System.Windows.Forms.Label()
        Me.LblThunderbird = New System.Windows.Forms.Label()
        Me.ClbPalemoon = New System.Windows.Forms.CheckedListBox()
        Me.LblPalemoon = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtFile = New System.Windows.Forms.TextBox()
        Me.LblFile = New System.Windows.Forms.Label()
        Me.CmdFile = New System.Windows.Forms.Button()
        Me.CmdImportRoot = New System.Windows.Forms.Button()
        Me.CmdImportUser = New System.Windows.Forms.Button()
        Me.ClbInterlink = New System.Windows.Forms.CheckedListBox()
        Me.LblInterlink = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(697, 401)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(85, 31)
        Me.CmdClose.TabIndex = 0
        Me.CmdClose.Text = "Close"
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'ClbFirefox
        '
        Me.ClbFirefox.FormattingEnabled = True
        Me.ClbFirefox.Location = New System.Drawing.Point(21, 22)
        Me.ClbFirefox.Name = "ClbFirefox"
        Me.ClbFirefox.Size = New System.Drawing.Size(257, 79)
        Me.ClbFirefox.TabIndex = 2
        '
        'ClbThunderbird
        '
        Me.ClbThunderbird.FormattingEnabled = True
        Me.ClbThunderbird.Location = New System.Drawing.Point(21, 122)
        Me.ClbThunderbird.Name = "ClbThunderbird"
        Me.ClbThunderbird.Size = New System.Drawing.Size(257, 79)
        Me.ClbThunderbird.TabIndex = 4
        '
        'ChkIntermediate
        '
        Me.ChkIntermediate.AutoSize = True
        Me.ChkIntermediate.Location = New System.Drawing.Point(500, 87)
        Me.ChkIntermediate.Name = "ChkIntermediate"
        Me.ChkIntermediate.Size = New System.Drawing.Size(151, 17)
        Me.ChkIntermediate.TabIndex = 12
        Me.ChkIntermediate.Text = "Zwischenzertifikate (*.p7b)"
        Me.ChkIntermediate.UseVisualStyleBackColor = True
        '
        'ChkRoot
        '
        Me.ChkRoot.AutoSize = True
        Me.ChkRoot.Location = New System.Drawing.Point(500, 64)
        Me.ChkRoot.Name = "ChkRoot"
        Me.ChkRoot.Size = New System.Drawing.Size(93, 17)
        Me.ChkRoot.TabIndex = 11
        Me.ChkRoot.Text = "Root Zertifikat"
        Me.ChkRoot.UseVisualStyleBackColor = True
        '
        'CbCA
        '
        Me.CbCA.FormattingEnabled = True
        Me.CbCA.Location = New System.Drawing.Point(498, 22)
        Me.CbCA.Name = "CbCA"
        Me.CbCA.Size = New System.Drawing.Size(157, 21)
        Me.CbCA.TabIndex = 10
        '
        'LblCA
        '
        Me.LblCA.AutoSize = True
        Me.LblCA.Location = New System.Drawing.Point(402, 25)
        Me.LblCA.Name = "LblCA"
        Me.LblCA.Size = New System.Drawing.Size(21, 13)
        Me.LblCA.TabIndex = 9
        Me.LblCA.Text = "CA"
        '
        'LblFirefox
        '
        Me.LblFirefox.AutoSize = True
        Me.LblFirefox.Location = New System.Drawing.Point(18, 6)
        Me.LblFirefox.Name = "LblFirefox"
        Me.LblFirefox.Size = New System.Drawing.Size(39, 13)
        Me.LblFirefox.TabIndex = 1
        Me.LblFirefox.Text = "Label1"
        '
        'LblThunderbird
        '
        Me.LblThunderbird.AutoSize = True
        Me.LblThunderbird.Location = New System.Drawing.Point(18, 106)
        Me.LblThunderbird.Name = "LblThunderbird"
        Me.LblThunderbird.Size = New System.Drawing.Size(39, 13)
        Me.LblThunderbird.TabIndex = 3
        Me.LblThunderbird.Text = "Label1"
        '
        'ClbPalemoon
        '
        Me.ClbPalemoon.FormattingEnabled = True
        Me.ClbPalemoon.Location = New System.Drawing.Point(21, 221)
        Me.ClbPalemoon.Name = "ClbPalemoon"
        Me.ClbPalemoon.Size = New System.Drawing.Size(257, 79)
        Me.ClbPalemoon.TabIndex = 6
        '
        'LblPalemoon
        '
        Me.LblPalemoon.AutoSize = True
        Me.LblPalemoon.Location = New System.Drawing.Point(18, 205)
        Me.LblPalemoon.Name = "LblPalemoon"
        Me.LblPalemoon.Size = New System.Drawing.Size(39, 13)
        Me.LblPalemoon.TabIndex = 5
        Me.LblPalemoon.Text = "Label1"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(429, 294)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(320, 20)
        Me.TxtPassword.TabIndex = 18
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(321, 297)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(50, 13)
        Me.LblPassword.TabIndex = 17
        Me.LblPassword.Text = "Passwort"
        '
        'TxtFile
        '
        Me.TxtFile.Location = New System.Drawing.Point(429, 255)
        Me.TxtFile.Name = "TxtFile"
        Me.TxtFile.Size = New System.Drawing.Size(320, 20)
        Me.TxtFile.TabIndex = 15
        '
        'LblFile
        '
        Me.LblFile.AutoSize = True
        Me.LblFile.Location = New System.Drawing.Point(321, 258)
        Me.LblFile.Name = "LblFile"
        Me.LblFile.Size = New System.Drawing.Size(76, 13)
        Me.LblFile.TabIndex = 14
        Me.LblFile.Text = "Zertifikatsdatei"
        '
        'CmdFile
        '
        Me.CmdFile.Location = New System.Drawing.Point(755, 253)
        Me.CmdFile.Name = "CmdFile"
        Me.CmdFile.Size = New System.Drawing.Size(27, 23)
        Me.CmdFile.TabIndex = 16
        Me.CmdFile.Text = "..."
        Me.CmdFile.UseVisualStyleBackColor = True
        '
        'CmdImportRoot
        '
        Me.CmdImportRoot.Location = New System.Drawing.Point(532, 122)
        Me.CmdImportRoot.Name = "CmdImportRoot"
        Me.CmdImportRoot.Size = New System.Drawing.Size(88, 31)
        Me.CmdImportRoot.TabIndex = 13
        Me.CmdImportRoot.Text = "Importieren"
        Me.CmdImportRoot.UseVisualStyleBackColor = True
        '
        'CmdImportUser
        '
        Me.CmdImportUser.Location = New System.Drawing.Point(532, 331)
        Me.CmdImportUser.Name = "CmdImportUser"
        Me.CmdImportUser.Size = New System.Drawing.Size(88, 31)
        Me.CmdImportUser.TabIndex = 19
        Me.CmdImportUser.Text = "Importieren"
        Me.CmdImportUser.UseVisualStyleBackColor = True
        '
        'ClbInterlink
        '
        Me.ClbInterlink.FormattingEnabled = True
        Me.ClbInterlink.Location = New System.Drawing.Point(21, 321)
        Me.ClbInterlink.Name = "ClbInterlink"
        Me.ClbInterlink.Size = New System.Drawing.Size(257, 79)
        Me.ClbInterlink.TabIndex = 8
        '
        'LblInterlink
        '
        Me.LblInterlink.AutoSize = True
        Me.LblInterlink.Location = New System.Drawing.Point(18, 305)
        Me.LblInterlink.Name = "LblInterlink"
        Me.LblInterlink.Size = New System.Drawing.Size(39, 13)
        Me.LblInterlink.TabIndex = 7
        Me.LblInterlink.Text = "Label1"
        '
        'FrmMozilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 444)
        Me.Controls.Add(Me.CmdImportUser)
        Me.Controls.Add(Me.CmdImportRoot)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.TxtFile)
        Me.Controls.Add(Me.LblFile)
        Me.Controls.Add(Me.CmdFile)
        Me.Controls.Add(Me.LblInterlink)
        Me.Controls.Add(Me.LblPalemoon)
        Me.Controls.Add(Me.LblThunderbird)
        Me.Controls.Add(Me.LblFirefox)
        Me.Controls.Add(Me.ChkIntermediate)
        Me.Controls.Add(Me.ChkRoot)
        Me.Controls.Add(Me.CbCA)
        Me.Controls.Add(Me.LblCA)
        Me.Controls.Add(Me.ClbInterlink)
        Me.Controls.Add(Me.ClbPalemoon)
        Me.Controls.Add(Me.ClbThunderbird)
        Me.Controls.Add(Me.ClbFirefox)
        Me.Controls.Add(Me.CmdClose)
        Me.Name = "FrmMozilla"
        Me.Text = "FrmMozilla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdClose As Button
    Friend WithEvents ClbFirefox As CheckedListBox
    Friend WithEvents ClbThunderbird As CheckedListBox
    Friend WithEvents ChkIntermediate As CheckBox
    Friend WithEvents ChkRoot As CheckBox
    Friend WithEvents CbCA As ComboBox
    Friend WithEvents LblCA As Label
    Friend WithEvents LblFirefox As Label
    Friend WithEvents LblThunderbird As Label
    Friend WithEvents ClbPalemoon As CheckedListBox
    Friend WithEvents LblPalemoon As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtFile As TextBox
    Friend WithEvents LblFile As Label
    Friend WithEvents CmdFile As Button
    Friend WithEvents CmdImportRoot As Button
    Friend WithEvents CmdImportUser As Button
    Friend WithEvents ClbInterlink As CheckedListBox
    Friend WithEvents LblInterlink As Label
End Class
