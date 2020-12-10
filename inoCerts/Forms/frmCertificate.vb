Public Class FrmCertificate
    Private Sub CmdFile_Click(sender As Object, e As EventArgs) Handles CmdFile.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Multiselect = False
            .Filter = "Zertifikate (*.p12)|*.p12|Alle Dateien (*.*)|*.*"
            .InitialDirectory = My.Settings.lastPath
            If .ShowDialog = DialogResult.OK Then
                My.Settings.lastPath = System.IO.Path.GetFullPath(.FileName)
                Me.TxtFile.Text = .FileName
            End If
        End With
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub CmdAnalyse_Click(sender As Object, e As EventArgs) Handles CmdAnalyse.Click
        Dim certfile As New ClsCertificates(Me.TxtFile.Text, Me.TxtPassword.Text)

        DgvCertificate.Rows.Clear()
        Dim intCount As Integer = 0
        If certfile.certs Is Nothing = False Then
            For Each cert As ClsCertificate In certfile.certs
                Me.DgvCertificate.Rows.Add(False, cert.cert.Subject, cert.cert.Issuer, cert.isInTruststore, cert.Truststore.ToString, cert.CertStore.ToString, cert.isRoot)
            Next
        End If
    End Sub

    Private Sub FrmCertificate_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TxtPassword.Text = My.Settings.lastPassword
    End Sub

    Private Sub FrmCertificate_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'My.Settings.lastPassword = Me.TxtPassword.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
