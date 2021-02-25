Public Class FrmPDFOver
    Private cPOver As New ClsPDFOver
    Private certfile As ClsCertificates

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        If CboAlias.Items.Count = 0 Then
            MessageBox.Show(clsLang.rm.getString("MsgNoAlias"))
            Exit Sub
        End If
        If ChkPassword.Checked = True Then
            If MessageBox.Show(clsLang.rm.getString("MsgPDFOverPassword"), clsLang.rm.getString("MsgSecurityAlert"), MessageBoxButtons.YesNo) = DialogResult.No Then
                Exit Sub
            End If
        End If
        cPOver.WriteConfig(CboAlias.Text, TxtFile.Text, IIf(ChkPassword.Checked, TxtPassword.Text, vbNullString))
        My.Settings.PDFOverPassword = ChkPassword.Checked
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub FrmPDFOver_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChkPassword.Checked = My.Settings.PDFOverPassword
        Text = clsLang.rm.getString("PDFOverTitle")
        LblFile.Text = clsLang.rm.getString("CertImportCertFile")
        LblPassword.Text = clsLang.rm.getString("CertImportPassword")
        LblAlias.Text = clsLang.rm.getString("PDFOverAlias")
        ChkPassword.Text = clsLang.rm.getString("PDFOverPasswordCheck")
        CmdCancel.Text = clsLang.rm.getString("CmdClose")
        CmdClose.Text = clsLang.rm.getString("CmdOK")
        CmdCertLoad.Text = clsLang.rm.getString("CmdLoadCert")

    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub CmdFile_Click(sender As Object, e As EventArgs) Handles CmdFile.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Multiselect = False
            .Filter = String.Format(clsLang.rm.getString("CertImportFileFilter"), "(*.cer, *.p7b, *.p12)|*.p12;*.cer;*.p7b", "*.*", "*.*")
            .InitialDirectory = My.Settings.lastPath
            If .ShowDialog = DialogResult.OK Then
                My.Settings.lastPath = System.IO.Path.GetFullPath(.FileName)
                Me.TxtFile.Text = .FileName
            End If
        End With
    End Sub

    Private Sub CmdCertLoad_Click(sender As Object, e As EventArgs) Handles CmdCertLoad.Click
        certfile = New ClsCertificates(Me.TxtFile.Text, Me.TxtPassword.Text, vbNullString, vbNullString)
        If certfile.certs Is Nothing = False Then
            Me.CboAlias.Items.Clear()
            For Each cert As ClsCertificate In certfile.certs
                Dim cn() As String = cert.cert.Subject.Split(",")
                For Each entry In cn
                    If entry.Trim.ToUpper.StartsWith("CN") Then
                        Me.CboAlias.Items.Add(entry.Trim.Substring(3))
                    End If
                Next
            Next
            CboAlias.SelectedIndex = 0
        End If
    End Sub
End Class