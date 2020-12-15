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
        Me.IsInTruststore = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Truststore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Certstore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CertType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmdImport = New System.Windows.Forms.Button()
        Me.CmdDelete = New System.Windows.Forms.Button()
        Me.LblDGVInfo = New System.Windows.Forms.Label()
        Me.CmdSelectAll = New System.Windows.Forms.Button()
        Me.CmdDeselectAll = New System.Windows.Forms.Button()
        CType(Me.DgvCertificate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(657, 387)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.CmdCancel.TabIndex = 0
        Me.CmdCancel.Text = "Schließen"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdFile
        '
        Me.CmdFile.Location = New System.Drawing.Point(443, 16)
        Me.CmdFile.Name = "CmdFile"
        Me.CmdFile.Size = New System.Drawing.Size(27, 23)
        Me.CmdFile.TabIndex = 1
        Me.CmdFile.Text = "..."
        Me.CmdFile.UseVisualStyleBackColor = True
        '
        'CmdAnalyse
        '
        Me.CmdAnalyse.Location = New System.Drawing.Point(657, 61)
        Me.CmdAnalyse.Name = "CmdAnalyse"
        Me.CmdAnalyse.Size = New System.Drawing.Size(75, 23)
        Me.CmdAnalyse.TabIndex = 1
        Me.CmdAnalyse.Text = "Analysieren"
        Me.CmdAnalyse.UseVisualStyleBackColor = True
        '
        'LblFile
        '
        Me.LblFile.AutoSize = True
        Me.LblFile.Location = New System.Drawing.Point(9, 22)
        Me.LblFile.Name = "LblFile"
        Me.LblFile.Size = New System.Drawing.Size(76, 13)
        Me.LblFile.TabIndex = 2
        Me.LblFile.Text = "Zertifikatsdatei"
        '
        'TxtFile
        '
        Me.TxtFile.Location = New System.Drawing.Point(117, 18)
        Me.TxtFile.Name = "TxtFile"
        Me.TxtFile.Size = New System.Drawing.Size(320, 20)
        Me.TxtFile.TabIndex = 3
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(9, 61)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(50, 13)
        Me.LblPassword.TabIndex = 2
        Me.LblPassword.Text = "Passwort"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(117, 57)
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
        Me.DgvCertificate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkBox, Me.Subject, Me.Issuer, Me.IsInTruststore, Me.Truststore, Me.Certstore, Me.CertType})
        Me.DgvCertificate.Location = New System.Drawing.Point(12, 124)
        Me.DgvCertificate.Name = "DgvCertificate"
        Me.DgvCertificate.Size = New System.Drawing.Size(531, 166)
        Me.DgvCertificate.TabIndex = 7
        '
        'chkBox
        '
        Me.chkBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.chkBox.HeaderText = "Select"
        Me.chkBox.Name = "chkBox"
        Me.chkBox.Width = 43
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
        'IsInTruststore
        '
        Me.IsInTruststore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IsInTruststore.HeaderText = "In Truststore"
        Me.IsInTruststore.Name = "IsInTruststore"
        Me.IsInTruststore.ReadOnly = True
        Me.IsInTruststore.Width = 72
        '
        'Truststore
        '
        Me.Truststore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Truststore.HeaderText = "Truststore"
        Me.Truststore.Name = "Truststore"
        Me.Truststore.ReadOnly = True
        Me.Truststore.Width = 79
        '
        'Certstore
        '
        Me.Certstore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Certstore.HeaderText = "Certstore"
        Me.Certstore.Name = "Certstore"
        Me.Certstore.ReadOnly = True
        Me.Certstore.Width = 74
        '
        'CertType
        '
        Me.CertType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CertType.HeaderText = "Certificate type"
        Me.CertType.Name = "CertType"
        Me.CertType.ReadOnly = True
        Me.CertType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CertType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CertType.Width = 83
        '
        'CmdImport
        '
        Me.CmdImport.Location = New System.Drawing.Point(657, 124)
        Me.CmdImport.Name = "CmdImport"
        Me.CmdImport.Size = New System.Drawing.Size(75, 25)
        Me.CmdImport.TabIndex = 8
        Me.CmdImport.Text = "Importieren"
        Me.CmdImport.UseVisualStyleBackColor = True
        '
        'CmdDelete
        '
        Me.CmdDelete.Location = New System.Drawing.Point(657, 155)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.Size = New System.Drawing.Size(75, 25)
        Me.CmdDelete.TabIndex = 8
        Me.CmdDelete.Text = "Löschen"
        Me.CmdDelete.UseVisualStyleBackColor = True
        '
        'LblDGVInfo
        '
        Me.LblDGVInfo.AutoSize = True
        Me.LblDGVInfo.Location = New System.Drawing.Point(12, 308)
        Me.LblDGVInfo.Name = "LblDGVInfo"
        Me.LblDGVInfo.Size = New System.Drawing.Size(39, 13)
        Me.LblDGVInfo.TabIndex = 9
        Me.LblDGVInfo.Text = "Label1"
        '
        'CmdSelectAll
        '
        Me.CmdSelectAll.Location = New System.Drawing.Point(12, 93)
        Me.CmdSelectAll.Name = "CmdSelectAll"
        Me.CmdSelectAll.Size = New System.Drawing.Size(88, 25)
        Me.CmdSelectAll.TabIndex = 8
        Me.CmdSelectAll.Text = "Alle auswählen"
        Me.CmdSelectAll.UseVisualStyleBackColor = True
        '
        'CmdDeselectAll
        '
        Me.CmdDeselectAll.Location = New System.Drawing.Point(117, 93)
        Me.CmdDeselectAll.Name = "CmdDeselectAll"
        Me.CmdDeselectAll.Size = New System.Drawing.Size(88, 25)
        Me.CmdDeselectAll.TabIndex = 8
        Me.CmdDeselectAll.Text = "Alle abwählen"
        Me.CmdDeselectAll.UseVisualStyleBackColor = True
        '
        'FrmCertificate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblDGVInfo)
        Me.Controls.Add(Me.CmdDeselectAll)
        Me.Controls.Add(Me.CmdSelectAll)
        Me.Controls.Add(Me.CmdDelete)
        Me.Controls.Add(Me.CmdImport)
        Me.Controls.Add(Me.DgvCertificate)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.TxtFile)
        Me.Controls.Add(Me.LblFile)
        Me.Controls.Add(Me.CmdAnalyse)
        Me.Controls.Add(Me.CmdFile)
        Me.Controls.Add(Me.CmdCancel)
        Me.MinimumSize = New System.Drawing.Size(500, 350)
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
    Friend WithEvents CmdImport As Button
    Friend WithEvents CmdDelete As Button
    Friend WithEvents LblDGVInfo As Label
    Friend WithEvents chkBox As DataGridViewCheckBoxColumn
    Friend WithEvents Subject As DataGridViewTextBoxColumn
    Friend WithEvents Issuer As DataGridViewTextBoxColumn
    Friend WithEvents IsInTruststore As DataGridViewCheckBoxColumn
    Friend WithEvents Truststore As DataGridViewTextBoxColumn
    Friend WithEvents Certstore As DataGridViewTextBoxColumn
    Friend WithEvents CertType As DataGridViewTextBoxColumn
    Friend WithEvents CmdSelectAll As Button
    Friend WithEvents CmdDeselectAll As Button
End Class
