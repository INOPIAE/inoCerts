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
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.ClbFirefox = New System.Windows.Forms.CheckedListBox()
        Me.ClbThunderbird = New System.Windows.Forms.CheckedListBox()
        Me.ChkIntermediate = New System.Windows.Forms.CheckBox()
        Me.ChkRoot = New System.Windows.Forms.CheckBox()
        Me.CbCA = New System.Windows.Forms.ComboBox()
        Me.LblCA = New System.Windows.Forms.Label()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.LblFirefox = New System.Windows.Forms.Label()
        Me.LblThunderbird = New System.Windows.Forms.Label()
        Me.ClbPalemoon = New System.Windows.Forms.CheckedListBox()
        Me.LblPalemoon = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(429, 402)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(85, 31)
        Me.CmdCancel.TabIndex = 11
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'ClbFirefox
        '
        Me.ClbFirefox.FormattingEnabled = True
        Me.ClbFirefox.Location = New System.Drawing.Point(21, 22)
        Me.ClbFirefox.Name = "ClbFirefox"
        Me.ClbFirefox.Size = New System.Drawing.Size(257, 94)
        Me.ClbFirefox.TabIndex = 1
        '
        'ClbThunderbird
        '
        Me.ClbThunderbird.FormattingEnabled = True
        Me.ClbThunderbird.Location = New System.Drawing.Point(21, 138)
        Me.ClbThunderbird.Name = "ClbThunderbird"
        Me.ClbThunderbird.Size = New System.Drawing.Size(257, 94)
        Me.ClbThunderbird.TabIndex = 3
        '
        'ChkIntermediate
        '
        Me.ChkIntermediate.AutoSize = True
        Me.ChkIntermediate.Location = New System.Drawing.Point(500, 87)
        Me.ChkIntermediate.Name = "ChkIntermediate"
        Me.ChkIntermediate.Size = New System.Drawing.Size(151, 17)
        Me.ChkIntermediate.TabIndex = 9
        Me.ChkIntermediate.Text = "Zwischenzertifikate (*.p7b)"
        Me.ChkIntermediate.UseVisualStyleBackColor = True
        '
        'ChkRoot
        '
        Me.ChkRoot.AutoSize = True
        Me.ChkRoot.Location = New System.Drawing.Point(500, 64)
        Me.ChkRoot.Name = "ChkRoot"
        Me.ChkRoot.Size = New System.Drawing.Size(93, 17)
        Me.ChkRoot.TabIndex = 8
        Me.ChkRoot.Text = "Root Zertifikat"
        Me.ChkRoot.UseVisualStyleBackColor = True
        '
        'CbCA
        '
        Me.CbCA.FormattingEnabled = True
        Me.CbCA.Location = New System.Drawing.Point(498, 22)
        Me.CbCA.Name = "CbCA"
        Me.CbCA.Size = New System.Drawing.Size(157, 21)
        Me.CbCA.TabIndex = 7
        '
        'LblCA
        '
        Me.LblCA.AutoSize = True
        Me.LblCA.Location = New System.Drawing.Point(404, 25)
        Me.LblCA.Name = "LblCA"
        Me.LblCA.Size = New System.Drawing.Size(21, 13)
        Me.LblCA.TabIndex = 6
        Me.LblCA.Text = "CA"
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(609, 401)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(88, 31)
        Me.CmdOK.TabIndex = 10
        Me.CmdOK.Text = "OK"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'LblFirefox
        '
        Me.LblFirefox.AutoSize = True
        Me.LblFirefox.Location = New System.Drawing.Point(18, 6)
        Me.LblFirefox.Name = "LblFirefox"
        Me.LblFirefox.Size = New System.Drawing.Size(39, 13)
        Me.LblFirefox.TabIndex = 0
        Me.LblFirefox.Text = "Label1"
        '
        'LblThunderbird
        '
        Me.LblThunderbird.AutoSize = True
        Me.LblThunderbird.Location = New System.Drawing.Point(18, 122)
        Me.LblThunderbird.Name = "LblThunderbird"
        Me.LblThunderbird.Size = New System.Drawing.Size(39, 13)
        Me.LblThunderbird.TabIndex = 2
        Me.LblThunderbird.Text = "Label1"
        '
        'ClbPalemoon
        '
        Me.ClbPalemoon.FormattingEnabled = True
        Me.ClbPalemoon.Location = New System.Drawing.Point(21, 255)
        Me.ClbPalemoon.Name = "ClbPalemoon"
        Me.ClbPalemoon.Size = New System.Drawing.Size(257, 94)
        Me.ClbPalemoon.TabIndex = 5
        '
        'LblPalemoon
        '
        Me.LblPalemoon.AutoSize = True
        Me.LblPalemoon.Location = New System.Drawing.Point(18, 239)
        Me.LblPalemoon.Name = "LblPalemoon"
        Me.LblPalemoon.Size = New System.Drawing.Size(39, 13)
        Me.LblPalemoon.TabIndex = 4
        Me.LblPalemoon.Text = "Label1"
        '
        'FrmMozilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.LblPalemoon)
        Me.Controls.Add(Me.LblThunderbird)
        Me.Controls.Add(Me.LblFirefox)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.ChkIntermediate)
        Me.Controls.Add(Me.ChkRoot)
        Me.Controls.Add(Me.CbCA)
        Me.Controls.Add(Me.LblCA)
        Me.Controls.Add(Me.ClbPalemoon)
        Me.Controls.Add(Me.ClbThunderbird)
        Me.Controls.Add(Me.ClbFirefox)
        Me.Controls.Add(Me.CmdCancel)
        Me.Name = "FrmMozilla"
        Me.Text = "FrmMozilla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdCancel As Button
    Friend WithEvents ClbFirefox As CheckedListBox
    Friend WithEvents ClbThunderbird As CheckedListBox
    Friend WithEvents ChkIntermediate As CheckBox
    Friend WithEvents ChkRoot As CheckBox
    Friend WithEvents CbCA As ComboBox
    Friend WithEvents LblCA As Label
    Friend WithEvents CmdOK As Button
    Friend WithEvents LblFirefox As Label
    Friend WithEvents LblThunderbird As Label
    Friend WithEvents ClbPalemoon As CheckedListBox
    Friend WithEvents LblPalemoon As Label
End Class
