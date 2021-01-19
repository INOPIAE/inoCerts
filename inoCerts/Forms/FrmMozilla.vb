Imports System.IO
Imports System.Net
Imports System.Security.Cryptography.X509Certificates

Public Class FrmMozilla
    Private cMozilla As New ClsMozilla

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmMozilla_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each item As String In cMozilla.ListThunderbird().Keys
            ClbThunderbird.Items.Add(item)
            If item.Equals(clsLang.rm.getString("NotFound")) Then
                ClbThunderbird.Enabled = False
            End If
        Next

        For Each item As String In cMozilla.ListFirefox().Keys
            ClbFirefox.Items.Add(item)
            If item.Equals(clsLang.rm.getString("NotFound")) Then
                ClbFirefox.Enabled = False
            End If
        Next

        For Each item As String In cMozilla.ListPalemoon().Keys
            ClbPalemoon.Items.Add(item)
            If item.Equals(clsLang.rm.getString("NotFound")) Then
                ClbPalemoon.Enabled = False
            End If
        Next

        With CbCA
            .Items.Add("InterimCA")
            .Items.Add("Test1")
            .SelectedIndex = 0
        End With

        Me.Text = clsLang.rm.getstring("MozillaTitle")
        Me.LblCA.Text = clsLang.rm.getString("CertWPIACA")
        Me.LblFirefox.Text = clsLang.rm.getstring("MozillaFirefoxProfiles")
        Me.LblThunderbird.Text = clsLang.rm.getstring("MozillaThunderbirdProfiles")
        Me.LblPalemoon.Text = clsLang.rm.getstring("MozillaPalemoonProfiles")
        Me.ChkRoot.Text = clsLang.rm.getString("CertWPIARoot")
        Me.ChkIntermediate.Text = clsLang.rm.getString("CertWPIAIntermediate")
        Me.CmdCancel.Text = clsLang.rm.getstring("CmdCancel")
        Me.CmdOK.Text = clsLang.rm.getstring("CmdOK")
    End Sub

    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles CmdOK.Click
        Dim URLRoot As String = ""
        Dim URLIntermediate As String = ""

        Select Case CbCA.Text
            Case "InterimCA"
                URLRoot = "https://www.interimca-tc.xyz/roots?cer"
                URLIntermediate = "https://www.interimca-tc.xyz/roots?bundle"
            Case "Test1"
                URLRoot = "https://www.test1.backup.dogcraft.de/roots?cer"
                URLIntermediate = "https://www.test1.backup.dogcraft.de/roots?bundle"
        End Select

        If Directory.Exists(My.Settings.CertFolder) = False Then
            FrmSettings.Show()
            Exit Sub
        End If
        Dim RootFile As String = My.Settings.CertFolder & "\" & CbCA.Text & "_roots.cer"
        Dim IntermediateFile As String = My.Settings.CertFolder & "\" & CbCA.Text & "intermediate_bundle.p7b"
        Using client As New WebClient()
            If ChkRoot.Checked Then
                client.DownloadFile(URLRoot, RootFile)
                Dim cert As X509Certificate2 = CertFromFile(RootFile)
                Dim CertName As String = GetCertName(cert)

                For Each item In ClbThunderbird.CheckedItems
                    cMozilla.ImportRootCertificate(cMozilla.ListThunderbird().Item(item), CertName, RootFile)
                Next

                For Each item In ClbFirefox.CheckedItems
                    cMozilla.ImportRootCertificate(cMozilla.ListFirefox().Item(item), CertName, RootFile)
                Next

                For Each item In ClbPalemoon.CheckedItems
                    cMozilla.ImportRootCertificate(cMozilla.ListPalemoon().Item(item), CertName, RootFile)
                Next
            End If
            If ChkIntermediate.Checked Then
                client.DownloadFile(URLIntermediate, IntermediateFile)
                Dim cCerts As New ClsCertificates(IntermediateFile, vbNullString, "intermediate")
                For Each cert In cCerts.certs
                    Dim CertName As String = GetCertName(cert.cert)
                    Dim CertFile As String = My.Settings.CertFolder & "\" & CertName & ".cer"
                    File.WriteAllBytes(CertFile, cert.cert.Export(X509ContentType.Cert))
                    For Each item In ClbThunderbird.CheckedItems
                        cMozilla.ImportRootCertificate(cMozilla.ListThunderbird().Item(item), CertName, CertFile)
                    Next

                    For Each item In ClbFirefox.CheckedItems
                        cMozilla.ImportRootCertificate(cMozilla.ListFirefox().Item(item), CertName, CertFile)
                    Next

                    For Each item In ClbPalemoon.CheckedItems
                        cMozilla.ImportRootCertificate(cMozilla.ListPalemoon().Item(item), CertName, CertFile)
                    Next
                Next
            End If
        End Using
    End Sub

    Private Shared Function GetCertName(cert As X509Certificate2) As String
        Dim CertName As String = vbNullString
        Dim certSubject As String() = cert.Subject.Split(",")
        For i As Int16 = certSubject.Count - 1 To 0 Step -1
            Dim certPart As String() = certSubject(i).Split("=")
            If certPart(0).Trim.Equals("CN") Then
                CertName = certPart(1).Trim
            End If
            If certPart(0).Trim.Equals("O") Then
                CertName &= " - " & certPart(1).Trim
            End If
        Next

        Return CertName
    End Function
End Class