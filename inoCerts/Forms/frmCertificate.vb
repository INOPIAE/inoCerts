Imports System.Security.Cryptography.X509Certificates

Public Class FrmCertificate

    Private certfile As ClsCertificates

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
        certfile = New ClsCertificates(Me.TxtFile.Text, Me.TxtPassword.Text)

        fillDatagrid()
    End Sub

    Private Sub fillDatagrid()
        DgvCertificate.Rows.Clear()
        Dim intCount As Integer = 0
        If certfile.certs Is Nothing = False Then
            For Each cert As ClsCertificate In certfile.certs
                Me.DgvCertificate.Rows.Add(False, cert.cert.Subject, cert.cert.Issuer, cert.isInTruststore, cert.Truststore.ToString, cert.CertStore.ToString, cert.CurrentCertType.ToString)
            Next
        End If
    End Sub

    Private Sub FrmCertificate_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TxtPassword.Text = My.Settings.lastPassword
    End Sub

    Private Sub FrmCertificate_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'My.Settings.lastPassword = Me.TxtPassword.Text
    End Sub

    Private Sub CmdImport_Click(sender As Object, e As EventArgs) Handles CmdImport.Click
        Dim blnImport As Boolean = False
        For Each r As DataGridViewRow In Me.DgvCertificate.Rows
            If r.Cells("chkBox").Value = True Then
                If r.Cells("IsInTruststore").Value = True Then
                    MessageBox.Show("Zertifikat schon im Truststore")
                    Continue For
                End If
                Dim storeL As StoreLocation = StoreLocation.LocalMachine
                Dim storeN As StoreName = StoreName.My
                Select Case [Enum].Parse(GetType(ClsCertificate.CertType), r.Cells("CertType").Value)
                    Case ClsCertificate.CertType.EndCertificate
                        'TODO check correct store
                        storeN = StoreName.My
                        storeL = StoreLocation.CurrentUser
                    Case ClsCertificate.CertType.IntermediateCertificate
                        storeN = StoreName.CertificateAuthority
                        storeL = StoreLocation.LocalMachine
                    Case ClsCertificate.CertType.RootCertificate
                        storeN = StoreName.Root
                        storeL = StoreLocation.LocalMachine
                    Case Else
                        'TODO check correct store
                        storeN = StoreName.My
                        storeL = StoreLocation.CurrentUser
                        MessageBox.Show("Zertifikatstore not defined")
                        Continue For
                End Select

                AddCertificate(certfile.GetCertBySubject(r.Cells("Subject").Value), storeL, storeN)
                blnImport = True
            End If
        Next
        If blnImport = True Then
            CmdAnalyse.PerformClick()
        End If
    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles CmdDelete.Click
        Dim blnDelete As Boolean = False
        For Each r As DataGridViewRow In Me.DgvCertificate.Rows
            If r.Cells("chkBox").Value = True Then
                Dim storeN As StoreName = [Enum].Parse(GetType(StoreName), r.Cells("CertStore").Value)
                Dim storeL As StoreLocation = [Enum].Parse(GetType(StoreLocation), r.Cells("TrustStore").Value)
                RemoveCertificate(certfile.GetCertBySubject(r.Cells("Subject").Value), storeL, storeN)
                blnDelete = True
            End If
        Next
        If blnDelete = True Then
            CmdAnalyse.PerformClick()
        End If
    End Sub
End Class
