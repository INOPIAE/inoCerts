<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPDFOver
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
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtFile = New System.Windows.Forms.TextBox()
        Me.LblFile = New System.Windows.Forms.Label()
        Me.CmdFile = New System.Windows.Forms.Button()
        Me.LblAlias = New System.Windows.Forms.Label()
        Me.CboAlias = New System.Windows.Forms.ComboBox()
        Me.ChkPassword = New System.Windows.Forms.CheckBox()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdCertLoad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(669, 382)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(78, 32)
        Me.CmdClose.TabIndex = 9
        Me.CmdClose.Text = "OK"
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(144, 67)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(320, 20)
        Me.TxtPassword.TabIndex = 4
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(36, 71)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(53, 13)
        Me.LblPassword.TabIndex = 3
        Me.LblPassword.Text = "Password"
        '
        'TxtFile
        '
        Me.TxtFile.Location = New System.Drawing.Point(144, 28)
        Me.TxtFile.Name = "TxtFile"
        Me.TxtFile.Size = New System.Drawing.Size(320, 20)
        Me.TxtFile.TabIndex = 1
        '
        'LblFile
        '
        Me.LblFile.AutoSize = True
        Me.LblFile.Location = New System.Drawing.Point(36, 32)
        Me.LblFile.Name = "LblFile"
        Me.LblFile.Size = New System.Drawing.Size(42, 13)
        Me.LblFile.TabIndex = 0
        Me.LblFile.Text = "Cert file"
        '
        'CmdFile
        '
        Me.CmdFile.Location = New System.Drawing.Point(470, 26)
        Me.CmdFile.Name = "CmdFile"
        Me.CmdFile.Size = New System.Drawing.Size(27, 23)
        Me.CmdFile.TabIndex = 2
        Me.CmdFile.Text = "..."
        Me.CmdFile.UseVisualStyleBackColor = True
        '
        'LblAlias
        '
        Me.LblAlias.AutoSize = True
        Me.LblAlias.Location = New System.Drawing.Point(36, 108)
        Me.LblAlias.Name = "LblAlias"
        Me.LblAlias.Size = New System.Drawing.Size(78, 13)
        Me.LblAlias.TabIndex = 6
        Me.LblAlias.Text = "Certificate alais"
        '
        'CboAlias
        '
        Me.CboAlias.FormattingEnabled = True
        Me.CboAlias.Location = New System.Drawing.Point(144, 105)
        Me.CboAlias.Name = "CboAlias"
        Me.CboAlias.Size = New System.Drawing.Size(320, 21)
        Me.CboAlias.TabIndex = 7
        '
        'ChkPassword
        '
        Me.ChkPassword.AutoSize = True
        Me.ChkPassword.Location = New System.Drawing.Point(144, 147)
        Me.ChkPassword.Name = "ChkPassword"
        Me.ChkPassword.Size = New System.Drawing.Size(254, 17)
        Me.ChkPassword.TabIndex = 8
        Me.ChkPassword.Text = "Save Password (in clear text, not recommended)"
        Me.ChkPassword.UseVisualStyleBackColor = True
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(499, 382)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(75, 32)
        Me.CmdCancel.TabIndex = 10
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdCertLoad
        '
        Me.CmdCertLoad.Location = New System.Drawing.Point(470, 66)
        Me.CmdCertLoad.Name = "CmdCertLoad"
        Me.CmdCertLoad.Size = New System.Drawing.Size(122, 23)
        Me.CmdCertLoad.TabIndex = 5
        Me.CmdCertLoad.Text = "Load Cert"
        Me.CmdCertLoad.UseVisualStyleBackColor = True
        '
        'FrmPDFOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.ChkPassword)
        Me.Controls.Add(Me.CboAlias)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblAlias)
        Me.Controls.Add(Me.TxtFile)
        Me.Controls.Add(Me.LblFile)
        Me.Controls.Add(Me.CmdCertLoad)
        Me.Controls.Add(Me.CmdFile)
        Me.Controls.Add(Me.CmdClose)
        Me.Name = "FrmPDFOver"
        Me.Text = "FrmPDFOver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdClose As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtFile As TextBox
    Friend WithEvents LblFile As Label
    Friend WithEvents CmdFile As Button
    Friend WithEvents LblAlias As Label
    Friend WithEvents CboAlias As ComboBox
    Friend WithEvents ChkPassword As CheckBox
    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdCertLoad As Button
End Class
