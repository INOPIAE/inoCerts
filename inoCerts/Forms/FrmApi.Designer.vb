<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApi
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
        Me.CmdCSR = New System.Windows.Forms.Button()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.LblCertFile = New System.Windows.Forms.Label()
        Me.TxtCertFile = New System.Windows.Forms.TextBox()
        Me.LblPW = New System.Windows.Forms.Label()
        Me.TxtPW = New System.Windows.Forms.TextBox()
        Me.LblCSR = New System.Windows.Forms.Label()
        Me.TxtCSR = New System.Windows.Forms.TextBox()
        Me.LblCert = New System.Windows.Forms.Label()
        Me.TxtCert = New System.Windows.Forms.TextBox()
        Me.LblProfile = New System.Windows.Forms.Label()
        Me.CboProfile = New System.Windows.Forms.ComboBox()
        Me.CmdCertificate = New System.Windows.Forms.Button()
        Me.CmdP12 = New System.Windows.Forms.Button()
        Me.LblFilename = New System.Windows.Forms.Label()
        Me.TxtFilename = New System.Windows.Forms.TextBox()
        Me.LblCN = New System.Windows.Forms.Label()
        Me.TxtCN = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.CmdFile = New System.Windows.Forms.Button()
        Me.CbCA = New System.Windows.Forms.ComboBox()
        Me.LblCA = New System.Windows.Forms.Label()
        Me.CmdAllSteps = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmdCSR
        '
        Me.CmdCSR.Location = New System.Drawing.Point(658, 27)
        Me.CmdCSR.Name = "CmdCSR"
        Me.CmdCSR.Size = New System.Drawing.Size(130, 24)
        Me.CmdCSR.TabIndex = 15
        Me.CmdCSR.Text = "CSR"
        Me.CmdCSR.UseVisualStyleBackColor = True
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(658, 405)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(130, 24)
        Me.CmdClose.TabIndex = 23
        Me.CmdClose.Text = "Button1"
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'LblCertFile
        '
        Me.LblCertFile.AutoSize = True
        Me.LblCertFile.Location = New System.Drawing.Point(24, 41)
        Me.LblCertFile.Name = "LblCertFile"
        Me.LblCertFile.Size = New System.Drawing.Size(39, 13)
        Me.LblCertFile.TabIndex = 2
        Me.LblCertFile.Text = "Label1"
        '
        'TxtCertFile
        '
        Me.TxtCertFile.Location = New System.Drawing.Point(155, 38)
        Me.TxtCertFile.Name = "TxtCertFile"
        Me.TxtCertFile.Size = New System.Drawing.Size(412, 20)
        Me.TxtCertFile.TabIndex = 3
        Me.TxtCertFile.Text = "D:\Daten\INOPIAE\zertifikate\gigi\Marcus_M_800000007.p12"
        '
        'LblPW
        '
        Me.LblPW.AutoSize = True
        Me.LblPW.Location = New System.Drawing.Point(24, 15)
        Me.LblPW.Name = "LblPW"
        Me.LblPW.Size = New System.Drawing.Size(53, 13)
        Me.LblPW.TabIndex = 0
        Me.LblPW.Text = "Password"
        '
        'TxtPW
        '
        Me.TxtPW.Location = New System.Drawing.Point(155, 12)
        Me.TxtPW.Name = "TxtPW"
        Me.TxtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPW.Size = New System.Drawing.Size(151, 20)
        Me.TxtPW.TabIndex = 1
        '
        'LblCSR
        '
        Me.LblCSR.AutoSize = True
        Me.LblCSR.Location = New System.Drawing.Point(24, 190)
        Me.LblCSR.Name = "LblCSR"
        Me.LblCSR.Size = New System.Drawing.Size(39, 13)
        Me.LblCSR.TabIndex = 19
        Me.LblCSR.Text = "Label1"
        '
        'TxtCSR
        '
        Me.TxtCSR.Location = New System.Drawing.Point(155, 187)
        Me.TxtCSR.Multiline = True
        Me.TxtCSR.Name = "TxtCSR"
        Me.TxtCSR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtCSR.Size = New System.Drawing.Size(412, 112)
        Me.TxtCSR.TabIndex = 20
        '
        'LblCert
        '
        Me.LblCert.AutoSize = True
        Me.LblCert.Location = New System.Drawing.Point(24, 320)
        Me.LblCert.Name = "LblCert"
        Me.LblCert.Size = New System.Drawing.Size(39, 13)
        Me.LblCert.TabIndex = 21
        Me.LblCert.Text = "Label1"
        '
        'TxtCert
        '
        Me.TxtCert.Location = New System.Drawing.Point(155, 317)
        Me.TxtCert.Multiline = True
        Me.TxtCert.Name = "TxtCert"
        Me.TxtCert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtCert.Size = New System.Drawing.Size(412, 112)
        Me.TxtCert.TabIndex = 22
        '
        'LblProfile
        '
        Me.LblProfile.AutoSize = True
        Me.LblProfile.Location = New System.Drawing.Point(24, 68)
        Me.LblProfile.Name = "LblProfile"
        Me.LblProfile.Size = New System.Drawing.Size(39, 13)
        Me.LblProfile.TabIndex = 5
        Me.LblProfile.Text = "Label6"
        '
        'CboProfile
        '
        Me.CboProfile.FormattingEnabled = True
        Me.CboProfile.Location = New System.Drawing.Point(155, 65)
        Me.CboProfile.Name = "CboProfile"
        Me.CboProfile.Size = New System.Drawing.Size(151, 21)
        Me.CboProfile.TabIndex = 6
        '
        'CmdCertificate
        '
        Me.CmdCertificate.Location = New System.Drawing.Point(658, 62)
        Me.CmdCertificate.Name = "CmdCertificate"
        Me.CmdCertificate.Size = New System.Drawing.Size(130, 24)
        Me.CmdCertificate.TabIndex = 16
        Me.CmdCertificate.Text = "Certificate"
        Me.CmdCertificate.UseVisualStyleBackColor = True
        '
        'CmdP12
        '
        Me.CmdP12.Location = New System.Drawing.Point(658, 99)
        Me.CmdP12.Name = "CmdP12"
        Me.CmdP12.Size = New System.Drawing.Size(130, 24)
        Me.CmdP12.TabIndex = 17
        Me.CmdP12.Text = "P12"
        Me.CmdP12.UseVisualStyleBackColor = True
        '
        'LblFilename
        '
        Me.LblFilename.AutoSize = True
        Me.LblFilename.Location = New System.Drawing.Point(24, 147)
        Me.LblFilename.Name = "LblFilename"
        Me.LblFilename.Size = New System.Drawing.Size(61, 13)
        Me.LblFilename.TabIndex = 13
        Me.LblFilename.Text = "Neue Datei"
        '
        'TxtFilename
        '
        Me.TxtFilename.Location = New System.Drawing.Point(155, 144)
        Me.TxtFilename.Name = "TxtFilename"
        Me.TxtFilename.Size = New System.Drawing.Size(151, 20)
        Me.TxtFilename.TabIndex = 14
        '
        'LblCN
        '
        Me.LblCN.AutoSize = True
        Me.LblCN.Location = New System.Drawing.Point(24, 95)
        Me.LblCN.Name = "LblCN"
        Me.LblCN.Size = New System.Drawing.Size(22, 13)
        Me.LblCN.TabIndex = 9
        Me.LblCN.Text = "CN"
        '
        'TxtCN
        '
        Me.TxtCN.Location = New System.Drawing.Point(155, 92)
        Me.TxtCN.Name = "TxtCN"
        Me.TxtCN.Size = New System.Drawing.Size(151, 20)
        Me.TxtCN.TabIndex = 10
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(24, 121)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(32, 13)
        Me.LblEmail.TabIndex = 11
        Me.LblEmail.Text = "Email"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(155, 118)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(151, 20)
        Me.TxtEmail.TabIndex = 12
        '
        'CmdFile
        '
        Me.CmdFile.Location = New System.Drawing.Point(573, 36)
        Me.CmdFile.Name = "CmdFile"
        Me.CmdFile.Size = New System.Drawing.Size(27, 23)
        Me.CmdFile.TabIndex = 4
        Me.CmdFile.Text = "..."
        Me.CmdFile.UseVisualStyleBackColor = True
        '
        'CbCA
        '
        Me.CbCA.FormattingEnabled = True
        Me.CbCA.Location = New System.Drawing.Point(410, 65)
        Me.CbCA.Name = "CbCA"
        Me.CbCA.Size = New System.Drawing.Size(157, 21)
        Me.CbCA.TabIndex = 8
        '
        'LblCA
        '
        Me.LblCA.AutoSize = True
        Me.LblCA.Location = New System.Drawing.Point(312, 68)
        Me.LblCA.Name = "LblCA"
        Me.LblCA.Size = New System.Drawing.Size(21, 13)
        Me.LblCA.TabIndex = 7
        Me.LblCA.Text = "CA"
        '
        'CmdAllSteps
        '
        Me.CmdAllSteps.Location = New System.Drawing.Point(658, 147)
        Me.CmdAllSteps.Name = "CmdAllSteps"
        Me.CmdAllSteps.Size = New System.Drawing.Size(130, 24)
        Me.CmdAllSteps.TabIndex = 18
        Me.CmdAllSteps.Text = "Button1"
        Me.CmdAllSteps.UseVisualStyleBackColor = True
        '
        'FrmApi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmdAllSteps)
        Me.Controls.Add(Me.CbCA)
        Me.Controls.Add(Me.LblCA)
        Me.Controls.Add(Me.CmdFile)
        Me.Controls.Add(Me.CmdP12)
        Me.Controls.Add(Me.CmdCertificate)
        Me.Controls.Add(Me.CboProfile)
        Me.Controls.Add(Me.LblProfile)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.CmdCSR)
        Me.Controls.Add(Me.TxtCert)
        Me.Controls.Add(Me.LblCert)
        Me.Controls.Add(Me.TxtCSR)
        Me.Controls.Add(Me.LblCSR)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.TxtCN)
        Me.Controls.Add(Me.LblCN)
        Me.Controls.Add(Me.TxtFilename)
        Me.Controls.Add(Me.LblFilename)
        Me.Controls.Add(Me.TxtPW)
        Me.Controls.Add(Me.LblPW)
        Me.Controls.Add(Me.TxtCertFile)
        Me.Controls.Add(Me.LblCertFile)
        Me.Name = "FrmApi"
        Me.Text = "FrmApi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdCSR As Button
    Friend WithEvents CmdClose As Button
    Friend WithEvents LblCertFile As Label
    Friend WithEvents TxtCertFile As TextBox
    Friend WithEvents LblPW As Label
    Friend WithEvents TxtPW As TextBox
    Friend WithEvents LblCSR As Label
    Friend WithEvents TxtCSR As TextBox
    Friend WithEvents LblCert As Label
    Friend WithEvents TxtCert As TextBox
    Friend WithEvents LblProfile As Label
    Friend WithEvents CboProfile As ComboBox
    Friend WithEvents CmdCertificate As Button
    Friend WithEvents CmdP12 As Button
    Friend WithEvents LblFilename As Label
    Friend WithEvents TxtFilename As TextBox
    Friend WithEvents LblCN As Label
    Friend WithEvents TxtCN As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents CmdFile As Button
    Friend WithEvents CbCA As ComboBox
    Friend WithEvents LblCA As Label
    Friend WithEvents CmdAllSteps As Button
End Class
