<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Me.LblFolder = New System.Windows.Forms.Label()
        Me.TxtFolder = New System.Windows.Forms.TextBox()
        Me.CmdFolder = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblFolder
        '
        Me.LblFolder.AutoSize = True
        Me.LblFolder.Location = New System.Drawing.Point(45, 36)
        Me.LblFolder.Name = "LblFolder"
        Me.LblFolder.Size = New System.Drawing.Size(83, 13)
        Me.LblFolder.TabIndex = 0
        Me.LblFolder.Text = "Zertifikatsordner"
        '
        'TxtFolder
        '
        Me.TxtFolder.Location = New System.Drawing.Point(133, 33)
        Me.TxtFolder.Name = "TxtFolder"
        Me.TxtFolder.Size = New System.Drawing.Size(278, 20)
        Me.TxtFolder.TabIndex = 1
        '
        'CmdFolder
        '
        Me.CmdFolder.Location = New System.Drawing.Point(417, 32)
        Me.CmdFolder.Name = "CmdFolder"
        Me.CmdFolder.Size = New System.Drawing.Size(43, 20)
        Me.CmdFolder.TabIndex = 2
        Me.CmdFolder.Text = "..."
        Me.CmdFolder.UseVisualStyleBackColor = True
        '
        'CmdCancel
        '
        Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancel.Location = New System.Drawing.Point(203, 158)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(104, 30)
        Me.CmdCancel.TabIndex = 3
        Me.CmdCancel.Text = "Abbrechen"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(356, 158)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(104, 30)
        Me.CmdOK.TabIndex = 4
        Me.CmdOK.Text = "OK"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'FrmSettings
        '
        Me.AcceptButton = Me.CmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CmdCancel
        Me.ClientSize = New System.Drawing.Size(577, 243)
        Me.ControlBox = False
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdFolder)
        Me.Controls.Add(Me.TxtFolder)
        Me.Controls.Add(Me.LblFolder)
        Me.Name = "FrmSettings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblFolder As Label
    Friend WithEvents TxtFolder As TextBox
    Friend WithEvents CmdFolder As Button
    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdOK As Button
End Class
