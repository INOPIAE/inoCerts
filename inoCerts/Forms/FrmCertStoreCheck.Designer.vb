<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCertStoreCheck
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
        Me.components = New System.ComponentModel.Container()
        Me.LblCertStore = New System.Windows.Forms.Label()
        Me.LbStore = New System.Windows.Forms.ListBox()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.ttCerts = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'LblCertStore
        '
        Me.LblCertStore.Location = New System.Drawing.Point(12, 21)
        Me.LblCertStore.Name = "LblCertStore"
        Me.LblCertStore.Size = New System.Drawing.Size(279, 59)
        Me.LblCertStore.TabIndex = 0
        Me.LblCertStore.Text = "Label1"
        '
        'LbStore
        '
        Me.LbStore.FormattingEnabled = True
        Me.LbStore.Location = New System.Drawing.Point(12, 83)
        Me.LbStore.Name = "LbStore"
        Me.LbStore.Size = New System.Drawing.Size(279, 147)
        Me.LbStore.TabIndex = 1
        '
        'CmdCancel
        '
        Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancel.Location = New System.Drawing.Point(12, 264)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(70, 25)
        Me.CmdCancel.TabIndex = 2
        Me.CmdCancel.Text = "Abbrechen"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdOK
        '
        Me.CmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmdOK.Location = New System.Drawing.Point(221, 264)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(70, 25)
        Me.CmdOK.TabIndex = 3
        Me.CmdOK.Text = "OK"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'FrmCertStoreCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 339)
        Me.ControlBox = False
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.LbStore)
        Me.Controls.Add(Me.LblCertStore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmCertStoreCheck"
        Me.Text = "Auswahl des Zertifikatsstores"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblCertStore As Label
    Friend WithEvents LbStore As ListBox
    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdOK As Button
    Friend WithEvents ttCerts As ToolTip
End Class
