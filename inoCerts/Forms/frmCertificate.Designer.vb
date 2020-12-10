<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCertificate
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdFile = New System.Windows.Forms.Button()
        Me.CmdAnalyse = New System.Windows.Forms.Button()
        Me.LblFile = New System.Windows.Forms.Label()
        Me.TxtFile = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.DgvCertificate = New System.Windows.Forms.DataGridView()
        Me.chkBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Issuer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsInTrusstore = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Truststore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Certstore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsRoot = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DgvCertificate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(657, 387)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.CmdCancel.TabIndex = 0
        Me.CmdCancel.Text = "Abbrechen"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdFile
        '
        Me.CmdFile.Location = New System.Drawing.Point(657, 34)
        Me.CmdFile.Name = "CmdFile"
        Me.CmdFile.Size = New System.Drawing.Size(75, 23)
        Me.CmdFile.TabIndex = 1
        Me.CmdFile.Text = "..."
        Me.CmdFile.UseVisualStyleBackColor = True
        '
        'CmdAnalyse
        '
        Me.CmdAnalyse.Location = New System.Drawing.Point(657, 78)
        Me.CmdAnalyse.Name = "CmdAnalyse"
        Me.CmdAnalyse.Size = New System.Drawing.Size(75, 23)
        Me.CmdAnalyse.TabIndex = 1
        Me.CmdAnalyse.Text = "Analysieren"
        Me.CmdAnalyse.UseVisualStyleBackColor = True
        '
        'LblFile
        '
        Me.LblFile.AutoSize = True
        Me.LblFile.Location = New System.Drawing.Point(39, 39)
        Me.LblFile.Name = "LblFile"
        Me.LblFile.Size = New System.Drawing.Size(76, 13)
        Me.LblFile.TabIndex = 2
        Me.LblFile.Text = "Zertifikatsdatei"
        '
        'TxtFile
        '
        Me.TxtFile.Location = New System.Drawing.Point(147, 35)
        Me.TxtFile.Name = "TxtFile"
        Me.TxtFile.Size = New System.Drawing.Size(320, 20)
        Me.TxtFile.TabIndex = 3
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(39, 78)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(50, 13)
        Me.LblPassword.TabIndex = 2
        Me.LblPassword.Text = "Passwort"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(147, 74)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(320, 20)
        Me.TxtPassword.TabIndex = 3
        '
        'DgvCertificate
        '
        Me.DgvCertificate.AllowUserToAddRows = False
        Me.DgvCertificate.AllowUserToDeleteRows = False
        Me.DgvCertificate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCertificate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkBox, Me.Subject, Me.Issuer, Me.IsInTrusstore, Me.Truststore, Me.Certstore, Me.IsRoot})
        Me.DgvCertificate.Location = New System.Drawing.Point(42, 141)
        Me.DgvCertificate.Name = "DgvCertificate"
        Me.DgvCertificate.Size = New System.Drawing.Size(531, 151)
        Me.DgvCertificate.TabIndex = 7
        '
        'chkBox
        '
        Me.chkBox.HeaderText = "Select"
        Me.chkBox.Name = "chkBox"
        '
        'Subject
        '
        Me.Subject.HeaderText = "Subject"
        Me.Subject.Name = "Subject"
        Me.Subject.ReadOnly = True
        '
        'Issuer
        '
        Me.Issuer.HeaderText = "Issuer"
        Me.Issuer.Name = "Issuer"
        Me.Issuer.ReadOnly = True
        '
        'IsInTrusstore
        '
        Me.IsInTrusstore.HeaderText = "Truststore"
        Me.IsInTrusstore.Name = "IsInTrusstore"
        Me.IsInTrusstore.ReadOnly = True
        '
        'Truststore
        '
        Me.Truststore.HeaderText = "Truststore"
        Me.Truststore.Name = "Truststore"
        Me.Truststore.ReadOnly = True
        '
        'Certstore
        '
        Me.Certstore.HeaderText = "Certstore"
        Me.Certstore.Name = "Certstore"
        Me.Certstore.ReadOnly = True
        '
        'IsRoot
        '
        Me.IsRoot.HeaderText = "Root"
        Me.IsRoot.Name = "IsRoot"
        Me.IsRoot.ReadOnly = True
        '
        'FrmCertificate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DgvCertificate)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.TxtFile)
        Me.Controls.Add(Me.LblFile)
        Me.Controls.Add(Me.CmdAnalyse)
        Me.Controls.Add(Me.CmdFile)
        Me.Controls.Add(Me.CmdCancel)
        Me.Name = "FrmCertificate"
        Me.Text = "Zertifikatsimport in Windowstruststore"
        CType(Me.DgvCertificate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdFile As Button
    Friend WithEvents CmdAnalyse As Button
    Friend WithEvents LblFile As Label
    Friend WithEvents TxtFile As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents DgvCertificate As DataGridView
    Friend WithEvents chkBox As DataGridViewCheckBoxColumn
    Friend WithEvents Subject As DataGridViewTextBoxColumn
    Friend WithEvents Issuer As DataGridViewTextBoxColumn
    Friend WithEvents IsInTrusstore As DataGridViewCheckBoxColumn
    Friend WithEvents Truststore As DataGridViewTextBoxColumn
    Friend WithEvents Certstore As DataGridViewTextBoxColumn
    Friend WithEvents IsRoot As DataGridViewCheckBoxColumn
End Class
