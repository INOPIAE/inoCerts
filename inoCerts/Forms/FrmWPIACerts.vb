Imports System.IO
Imports System.Net
Imports System.Security.Cryptography.X509Certificates

Public Class FrmWPIACerts
    Private strStoreLocation As String = "LocalMachine"
    Private cCA As New ClsCAInfo

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles CmdOK.Click

        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) = False And RbLocalMachine.Checked Then
            MyMessage(clsLang.rm.getString("MsgStartAdmin"))
            Exit Sub
        End If

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
                If FindCertificateInTrustsore(cert).Contains(":") Then
                    MyMessage(clsLang.rm.getString("MsgRootExist"))
                Else
                    AddCertificate(cert, [Enum].Parse(GetType(StoreLocation), strStoreLocation), StoreName.Root)
                    MyMessage(clsLang.rm.getString("MsgRootImported"))
                End If
            End If
            If ChkIntermediate.Checked Then
                client.DownloadFile(URLIntermediate, IntermediateFile)
                Dim frm As New FrmCertificate
                With frm
                    .TxtFile.Text = IntermediateFile
                    .MdiParent = FrmMain
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
            For Each ca As ClsCAInfo.CAInfo In cCA.CAInfos
                .Items.Add(ca.CAName)
            Next
            .SelectedIndex = 0
        End With
        Me.Text = clsLang.rm.getString("CertWPIATitle")
        Me.CmdCancel.Text = clsLang.rm.getString("CmdCancel")
        Me.CmdOK.Text = clsLang.rm.getString("CmdOK")
        Me.LblCA.Text = clsLang.rm.getString("CertWPIACA")
        Me.ChkRoot.Text = clsLang.rm.getString("CertWPIARoot")
        Me.ChkIntermediate.Text = clsLang.rm.getString("CertWPIAIntermediate")
        Me.RbLocalMachine.Text = clsLang.rm.getString("CertWPIALocalMachine")
        Me.RbUser.Text = clsLang.rm.getString("CertWPIACurrentUser")
    End Sub

    Private Sub RbLocalMachine_Click(sender As Object, e As EventArgs) Handles RbLocalMachine.Click
        strStoreLocation = "LocalMachine"
    End Sub

    Private Sub RbUser_Click(sender As Object, e As EventArgs) Handles RbUser.Click
        strStoreLocation = "CurrentUser"
    End Sub
End Class