﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCertUtil = New System.Windows.Forms.TextBox()
        Me.CmdCertUtil = New System.Windows.Forms.Button()
        Me.LblLanguage = New System.Windows.Forms.Label()
        Me.CboLanguage = New System.Windows.Forms.ComboBox()
        Me.CmdSave = New System.Windows.Forms.Button()
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
        Me.CmdCancel.Location = New System.Drawing.Point(48, 158)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(129, 30)
        Me.CmdCancel.TabIndex = 10
        Me.CmdCancel.Text = "Abbrechen"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(330, 158)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(129, 30)
        Me.CmdOK.TabIndex = 8
        Me.CmdOK.Text = "OK"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Zertifikatsordner"
        Me.Label1.Visible = False
        '
        'TxtCertUtil
        '
        Me.TxtCertUtil.Location = New System.Drawing.Point(133, 59)
        Me.TxtCertUtil.Name = "TxtCertUtil"
        Me.TxtCertUtil.Size = New System.Drawing.Size(278, 20)
        Me.TxtCertUtil.TabIndex = 4
        Me.TxtCertUtil.Visible = False
        '
        'CmdCertUtil
        '
        Me.CmdCertUtil.Location = New System.Drawing.Point(417, 58)
        Me.CmdCertUtil.Name = "CmdCertUtil"
        Me.CmdCertUtil.Size = New System.Drawing.Size(43, 20)
        Me.CmdCertUtil.TabIndex = 5
        Me.CmdCertUtil.Text = "..."
        Me.CmdCertUtil.UseVisualStyleBackColor = True
        Me.CmdCertUtil.Visible = False
        '
        'LblLanguage
        '
        Me.LblLanguage.AutoSize = True
        Me.LblLanguage.Location = New System.Drawing.Point(45, 88)
        Me.LblLanguage.Name = "LblLanguage"
        Me.LblLanguage.Size = New System.Drawing.Size(39, 13)
        Me.LblLanguage.TabIndex = 6
        Me.LblLanguage.Text = "Label2"
        '
        'CboLanguage
        '
        Me.CboLanguage.FormattingEnabled = True
        Me.CboLanguage.Location = New System.Drawing.Point(133, 85)
        Me.CboLanguage.Name = "CboLanguage"
        Me.CboLanguage.Size = New System.Drawing.Size(131, 21)
        Me.CboLanguage.TabIndex = 7
        '
        'CmdSave
        '
        Me.CmdSave.Location = New System.Drawing.Point(189, 158)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(129, 30)
        Me.CmdSave.TabIndex = 9
        Me.CmdSave.Text = "Übernehmen"
        Me.CmdSave.UseVisualStyleBackColor = True
        '
        'FrmSettings
        '
        Me.AcceptButton = Me.CmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CmdCancel
        Me.ClientSize = New System.Drawing.Size(577, 243)
        Me.ControlBox = False
        Me.Controls.Add(Me.CmdSave)
        Me.Controls.Add(Me.CboLanguage)
        Me.Controls.Add(Me.LblLanguage)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdCertUtil)
        Me.Controls.Add(Me.CmdFolder)
        Me.Controls.Add(Me.TxtCertUtil)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCertUtil As TextBox
    Friend WithEvents CmdCertUtil As Button
    Friend WithEvents LblLanguage As Label
    Friend WithEvents CboLanguage As ComboBox
    Friend WithEvents CmdSave As Button
End Class
