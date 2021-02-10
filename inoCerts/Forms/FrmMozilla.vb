Imports System.IO
Imports System.Net
Imports System.Security.Cryptography.X509Certificates

Public Class FrmMozilla
    Private cMozilla As New ClsMozilla
    Private cCA As New ClsCAInfo

    Enum ImportType
        Root
        User
        P12
    End Enum

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
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


        For Each item As String In cMozilla.ListInterlink().Keys
            ClbInterlink.Items.Add(item)
            If item.Equals(clsLang.rm.getString("NotFound")) Then
                ClbInterlink.Enabled = False
            End If
        Next

        With CbCA
            For Each ca As ClsCAInfo.CAInfo In cCA.CAInfos
                .Items.Add(ca.CAName)
            Next
            .SelectedIndex = 0
        End With

        Me.Text = clsLang.rm.getstring("MozillaTitle")
        Me.LblCA.Text = clsLang.rm.getString("CertWPIACA")
        Me.LblFirefox.Text = clsLang.rm.getstring("MozillaFirefoxProfiles")
        Me.LblThunderbird.Text = clsLang.rm.getstring("MozillaThunderbirdProfiles")
        Me.LblPalemoon.Text = clsLang.rm.getstring("MozillaPalemoonProfiles")
        Me.LblInterlink.Text = clsLang.rm.getstring("MozillaInterlinkProfiles")
        Me.LblFile.Text = clsLang.rm.getString("CertImportCertFile")
        Me.LblPassword.Text = clsLang.rm.getString("CertImportPassword")
        Me.ChkRoot.Text = clsLang.rm.getString("CertWPIARoot")
        Me.ChkIntermediate.Text = clsLang.rm.getString("CertWPIAIntermediate")
        Me.CmdClose.Text = clsLang.rm.getstring("CmdClose")
        Me.CmdImportRoot.Text = clsLang.rm.getstring("CmdImport")
        Me.CmdImportUser.Text = clsLang.rm.getstring("CmdImport")

    End Sub

    Private Sub CmdOK_Click(sender As Object, e As EventArgs)
        Dim URL As String = cCA.GetURLByName(CbCA.Text)
        Dim URLRoot As String = "http://www." & URL & "/roots?cer"
        Dim URLIntermediate As String = "http://www." & URL & "/roots?bundle"

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

                For Each item In ClbInterlink.CheckedItems
                    cMozilla.ImportRootCertificate(cMozilla.ListInterlink().Item(item), CertName, RootFile)
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

                    For Each item In ClbInterlink.CheckedItems
                        cMozilla.ImportRootCertificate(cMozilla.ListInterlink().Item(item), CertName, CertFile)
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

    Private Sub CmdImportRoot_Click(sender As Object, e As EventArgs) Handles CmdImportRoot.Click
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
                ProcessTrustStores(CertName, RootFile, ImportType.Root)
            End If
            If ChkIntermediate.Checked Then
                client.DownloadFile(URLIntermediate, IntermediateFile)
                Dim cCerts As New ClsCertificates(IntermediateFile, vbNullString, "intermediate")
                For Each cert In cCerts.certs
                    Dim CertName As String = GetCertName(cert.cert)
                    Dim CertFile As String = My.Settings.CertFolder & "\" & CertName & ".cer"
                    File.WriteAllBytes(CertFile, cert.cert.Export(X509ContentType.Cert))
                    ProcessTrustStores(CertName, CertFile, ImportType.Root)
                Next
            End If
        End Using
    End Sub

    Private Sub ProcessTrustStores(CertName As String, CertFile As String, import As ImportType, Optional password As String = vbNullString)

        If ProcessFunction(ClbThunderbird, cMozilla.ListThunderbird(), CertName, CertFile, import, password) = False Then Exit Sub

        If ProcessFunction(ClbFirefox, cMozilla.ListFirefox(), CertName, CertFile, import, password) = False Then Exit Sub

        If ProcessFunction(ClbPalemoon, cMozilla.ListPalemoon(), CertName, CertFile, import, password) = False Then Exit Sub

        If ProcessFunction(ClbInterlink, cMozilla.ListInterlink(), CertName, CertFile, import, password) = False Then Exit Sub
    End Sub

    Private Function ProcessFunction(cbl As CheckedListBox, dict As Dictionary(Of String, String), CertName As String, CertFile As String, import As ImportType, Optional password As String = vbNullString) As Boolean
        For Each item In cbl.CheckedItems
            Select Case import
                Case ImportType.Root
                    If cMozilla.ImportRootCertificate(dict.Item(item), CertName, CertFile) = False Then Return False
                Case ImportType.User
                    If cMozilla.ImportUserCertificate(dict.Item(item), CertName, CertFile) = False Then Return False
                Case ImportType.P12
                    If cMozilla.ImportP12(dict.Item(item), CertFile, password) = False Then Return False
            End Select

        Next

        Return True
    End Function

    Private Sub CmdImportUser_Click(sender As Object, e As EventArgs) Handles CmdImportUser.Click

        Dim strFile As String = Me.TxtFile.Text.Trim
        If File.Exists(strFile) = False Then
            MessageBox.Show(clsLang.rm.getstring("MsgFileMissing"), clsLang.rm.getstring("MsgError"))
            Exit Sub
        End If
        If strFile.EndsWith(".p12") Then
            If Me.TxtPassword.Text.Trim = vbNullString Then
                MessageBox.Show(clsLang.rm.getstring("MsgPassword"), clsLang.rm.getstring("MsgError"))
                Exit Sub
            End If
            ProcessTrustStores("", strFile, ImportType.P12, Me.TxtPassword.Text)
        Else
            Dim cert As X509Certificate2 = CertFromFile(strFile)
            Dim CertName As String = GetCertName(cert)
            ProcessTrustStores(CertName, strFile, ImportType.User)
        End If
    End Sub
End Class