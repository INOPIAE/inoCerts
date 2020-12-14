Imports System.IO
Imports System.Net
Imports System.Security.Cryptography.X509Certificates

Public Class FrmWPIACerts
    Private strStoreLocation As String = "LocalMachine"
    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles CmdOK.Click

        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) = False And RbLocalMachine.Checked Then
            MyMessage("Das Programm muss als Administrator gestartet werden.")
            Exit Sub
        End If

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
                If FindCertificateInTrustsore(cert).Contains(":") Then
                    MyMessage("Root-Zertifikat ist schon importiert.")
                Else
                    AddCertificate(cert, [Enum].Parse(GetType(StoreLocation), strStoreLocation), StoreName.Root)
                    MyMessage("Root-Zertifikat wurde erfolgreich importiert.")
                End If
            End If
            If ChkIntermediate.Checked Then
                client.DownloadFile(URLIntermediate, IntermediateFile)
                Dim frm As New FrmCertificate
                With frm
                    .TxtFile.Text = IntermediateFile
                    .MdiParent = frmMain
                    .Show()
                    .WindowState = FormWindowState.Maximized
                    .strRoot = "intermediate"
                    .strStoreLocation = strStoreLocation
                    .CmdAnalyse.PerformClick()
                End With
            End If
        End Using

    End Sub

    Private Sub FrmWPIACerts_Load(sender As Object, e As EventArgs) Handles Me.Load
        With CbCA
            .Items.Add("InterimCA")
            .Items.Add("Test1")
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub RbLocalMachine_Click(sender As Object, e As EventArgs) Handles RbLocalMachine.Click
        strStoreLocation = "LocalMachine"
    End Sub

    Private Sub RbUser_Click(sender As Object, e As EventArgs) Handles RbUser.Click
        strStoreLocation = "CurrentUser"
    End Sub
End Class