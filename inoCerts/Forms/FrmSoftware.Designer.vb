<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSoftware
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
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.DgvSoftware = New System.Windows.Forms.DataGridView()
        Me.State = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Software = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Installed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WindowsTruststore = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DgvSoftware, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(680, 391)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(78, 27)
        Me.CmdOK.TabIndex = 0
        Me.CmdOK.Text = "OK"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'DgvSoftware
        '
        Me.DgvSoftware.AllowUserToAddRows = False
        Me.DgvSoftware.AllowUserToDeleteRows = False
        Me.DgvSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSoftware.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.State, Me.Software, Me.Installed, Me.WindowsTruststore})
        Me.DgvSoftware.Location = New System.Drawing.Point(28, 50)
        Me.DgvSoftware.Name = "DgvSoftware"
        Me.DgvSoftware.RowHeadersWidth = 20
        Me.DgvSoftware.Size = New System.Drawing.Size(607, 325)
        Me.DgvSoftware.TabIndex = 2
        '
        'State
        '
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        '
        'Software
        '
        Me.Software.HeaderText = "Software"
        Me.Software.Name = "Software"
        Me.Software.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Installed
        '
        Me.Installed.HeaderText = "Installed"
        Me.Installed.Name = "Installed"
        Me.Installed.ReadOnly = True
        '
        'WindowsTruststore
        '
        Me.WindowsTruststore.HeaderText = "WindowsTruststore"
        Me.WindowsTruststore.Name = "WindowsTruststore"
        Me.WindowsTruststore.ReadOnly = True
        Me.WindowsTruststore.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WindowsTruststore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'FrmSoftware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DgvSoftware)
        Me.Controls.Add(Me.CmdOK)
        Me.Name = "FrmSoftware"
        Me.Text = "FrmSoftware"
        CType(Me.DgvSoftware, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CmdOK As Button
    Friend WithEvents DgvSoftware As DataGridView
    Friend WithEvents State As DataGridViewCheckBoxColumn
    Friend WithEvents Software As DataGridViewTextBoxColumn
    Friend WithEvents Installed As DataGridViewCheckBoxColumn
    Friend WithEvents WindowsTruststore As DataGridViewCheckBoxColumn
End Class
