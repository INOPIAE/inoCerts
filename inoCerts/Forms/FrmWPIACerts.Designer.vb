<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWPIACerts
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
        Me.LblCA = New System.Windows.Forms.Label()
        Me.CbCA = New System.Windows.Forms.ComboBox()
        Me.ChkRoot = New System.Windows.Forms.CheckBox()
        Me.ChkIntermediate = New System.Windows.Forms.CheckBox()
        Me.GrpTruststore = New System.Windows.Forms.GroupBox()
        Me.RbUser = New System.Windows.Forms.RadioButton()
        Me.RbLocalMachine = New System.Windows.Forms.RadioButton()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.GrpTruststore.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblCA
        '
        Me.LblCA.AutoSize = True
        Me.LblCA.Location = New System.Drawing.Point(61, 47)
        Me.LblCA.Name = "LblCA"
        Me.LblCA.Size = New System.Drawing.Size(21, 13)
        Me.LblCA.TabIndex = 0
        Me.LblCA.Text = "CA"
        '
        'CbCA
        '
        Me.CbCA.FormattingEnabled = True
        Me.CbCA.Location = New System.Drawing.Point(155, 44)
        Me.CbCA.Name = "CbCA"
        Me.CbCA.Size = New System.Drawing.Size(157, 21)
        Me.CbCA.TabIndex = 1
        '
        'ChkRoot
        '
        Me.ChkRoot.AutoSize = True
        Me.ChkRoot.Location = New System.Drawing.Point(157, 86)
        Me.ChkRoot.Name = "ChkRoot"
        Me.ChkRoot.Size = New System.Drawing.Size(93, 17)
        Me.ChkRoot.TabIndex = 2
        Me.ChkRoot.Text = "Root Zertifikat"
        Me.ChkRoot.UseVisualStyleBackColor = True
        '
        'ChkIntermediate
        '
        Me.ChkIntermediate.AutoSize = True
        Me.ChkIntermediate.Location = New System.Drawing.Point(157, 109)
        Me.ChkIntermediate.Name = "ChkIntermediate"
        Me.ChkIntermediate.Size = New System.Drawing.Size(151, 17)
        Me.ChkIntermediate.TabIndex = 2
        Me.ChkIntermediate.Text = "Zwischenzertifikate (*.p7b)"
        Me.ChkIntermediate.UseVisualStyleBackColor = True
        '
        'GrpTruststore
        '
        Me.GrpTruststore.Controls.Add(Me.RbUser)
        Me.GrpTruststore.Controls.Add(Me.RbLocalMachine)
        Me.GrpTruststore.Location = New System.Drawing.Point(155, 148)
        Me.GrpTruststore.Name = "GrpTruststore"
        Me.GrpTruststore.Size = New System.Drawing.Size(200, 79)
        Me.GrpTruststore.TabIndex = 3
        Me.GrpTruststore.TabStop = False
        Me.GrpTruststore.Text = "Truststore"
        '
        'RbUser
        '
        Me.RbUser.AutoSize = True
        Me.RbUser.Location = New System.Drawing.Point(17, 43)
        Me.RbUser.Name = "RbUser"
        Me.RbUser.Size = New System.Drawing.Size(67, 17)
        Me.RbUser.TabIndex = 0
        Me.RbUser.Text = "Benutzer"
        Me.RbUser.UseVisualStyleBackColor = True
        '
        'RbLocalMachine
        '
        Me.RbLocalMachine.AutoSize = True
        Me.RbLocalMachine.Checked = True
        Me.RbLocalMachine.Location = New System.Drawing.Point(17, 20)
        Me.RbLocalMachine.Name = "RbLocalMachine"
        Me.RbLocalMachine.Size = New System.Drawing.Size(95, 17)
        Me.RbLocalMachine.TabIndex = 0
        Me.RbLocalMachine.TabStop = True
        Me.RbLocalMachine.Text = "Local Machine"
        Me.RbLocalMachine.UseVisualStyleBackColor = True
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(64, 268)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.CmdCancel.TabIndex = 4
        Me.CmdCancel.Text = "Abbrechen"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(280, 268)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(75, 23)
        Me.CmdOK.TabIndex = 4
        Me.CmdOK.Text = "OK"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'FrmWPIACerts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 372)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.GrpTruststore)
        Me.Controls.Add(Me.ChkIntermediate)
        Me.Controls.Add(Me.ChkRoot)
        Me.Controls.Add(Me.CbCA)
        Me.Controls.Add(Me.LblCA)
        Me.Name = "FrmWPIACerts"
        Me.ShowIcon = False
        Me.Text = "FrmWPIACerts"
        Me.GrpTruststore.ResumeLayout(False)
        Me.GrpTruststore.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCA As Label
    Friend WithEvents CbCA As ComboBox
    Friend WithEvents ChkRoot As CheckBox
    Friend WithEvents ChkIntermediate As CheckBox
    Friend WithEvents GrpTruststore As GroupBox
    Friend WithEvents RbUser As RadioButton
    Friend WithEvents RbLocalMachine As RadioButton
    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdOK As Button
End Class
