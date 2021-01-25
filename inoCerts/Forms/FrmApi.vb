Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Security.Authentication
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Text.RegularExpressions

Public Class FrmApi

    Private cOpen As New ClsOpenSSL
    Private cCA As New ClsCAInfo
    Private cApi As New ClsAPI
    Private username As String

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub SendApi(URL As String)
        Dim result As String = cApi.SendAPICertRequest(URL, Me.TxtCertFile.Text, Me.TxtPW.Text, Me.TxtCSR.Text, CboProfile.SelectedValue)
        Me.TxtCert.Text = getResult(result)
    End Sub

    Private Sub FrmApi_Load(sender As Object, e As EventArgs) Handles Me.Load
        With CbCA
            For Each ca As ClsCAInfo.CAInfo In cCA.CAInfos
                .Items.Add(ca.CAName)
            Next
            .SelectedIndex = 0
        End With

        Dim comboSource As New Dictionary(Of String, String) From {
            {"client", "ssl - client(unassured)"},
            {"mail", "Mail(unassured)"},
            {"client-mail", "ssl - client + Mail(unassured)"},
            {"server", "ssl - server(unassured)"},
            {"client-a", "ssl - client(assured)"},
            {"mail-a", "mail (assured)"},
            {"client-mail-a", "ssl - client + Mail(assured)"},
            {"server-a", "ssl - server(assured)"},
            {"code-a", "codesign(assured)"},
            {"client-orga", "ssl - client(orga)"},
            {"mail-orga", "mail (orga)"},
            {"client-mail-orga", "ssl - client + Mail(orga)"},
            {"server-orga", "ssl - server(orga)"},
            {"code-orga", "codesign(orga)"}
        }

        Me.CboProfile.DataSource = New BindingSource(comboSource, Nothing)
        Me.CboProfile.DisplayMember = "Value"
        Me.CboProfile.ValueMember = "Key"

        CboProfile.SelectedValue = "client-mail-a"

        Me.CbCA.Text = My.Settings.lastCA

        Me.LblPW.Text = clsLang.rm.getString("CertImportPassword")
        Me.TxtPW.Text = MdlHelper.lastPassword
        Me.LblCertFile.Text = clsLang.rm.getString("CertImportCertFile")
        Me.LblProfile.Text = clsLang.rm.getString("ApiProfile")
        Me.LblCA.Text = clsLang.rm.getString("CertWPIACA")
        Me.LblCN.Text = clsLang.rm.getString("ApiCN")
        Me.LblEmail.Text = clsLang.rm.getString("ApiEmail")
        Me.LblFilename.Text = clsLang.rm.getString("ApiFile")
        Me.TxtFilename.Text = MdlHelper.lastFilename
        Me.LblCSR.Text = clsLang.rm.getString("ApiCSR")
        Me.LblCert.Text = clsLang.rm.getString("ApiCertificate")
        Me.CmdCSR.Text = clsLang.rm.getString("CmdCSR")
        Me.CmdCertificate.Text = clsLang.rm.getString("CmdCertificate")
        Me.CmdP12.Text = clsLang.rm.getString("CmdP12")
        Me.CmdAllSteps.Text = clsLang.rm.getString("CmdCertAll")
        Me.CmdClose.Text = clsLang.rm.getString("CmdClose")
        Me.CmdReping.Text = clsLang.rm.getString("CmdReping")

        Me.Text = clsLang.rm.getString("ApiTitle")
    End Sub

    Private Function getResult(input As String) As String
        Dim result As String = vbNullString

        If input.Contains("-----BEGIN CERTIFICATE-----") And input.Contains("-----END CERTIFICATE-----") Then
            Return input
        End If


        Dim rxErrorMessage As Regex = New Regex("<pre>(.*?)<\/pre>", RegexOptions.Multiline)
        Dim matches As MatchCollection = rxErrorMessage.Matches(input)

        For Each match As Match In matches
            Dim groups As GroupCollection = match.Groups
            result &= groups(1).Value.ToString.Trim & vbNewLine
        Next

        If result = vbNullString Then
            Return clsLang.rm.getString("MsgError") & ":" & vbNewLine & input
        Else
            Return clsLang.rm.getString("MsgError") & ":" & vbNewLine & result
        End If

    End Function

    Private Sub CmdCSR_Click(sender As Object, e As EventArgs) Handles CmdCSR.Click
        If Me.TxtPW.Text.Trim = vbNullString Then
            MessageBox.Show(clsLang.rm.getString("MsgPassword"), clsLang.rm.getString("MsgError"))
            Me.TxtPW.Select()
            Exit Sub
        End If
        If Me.TxtCN.Text.Trim = vbNullString Then
            MessageBox.Show(clsLang.rm.getString("MsgNoName"), clsLang.rm.getString("MsgError"))
            Me.TxtCN.Select()
            Exit Sub
        End If
        If Me.TxtEmail.Text.Trim = vbNullString Then
            MessageBox.Show(clsLang.rm.getString("MsgEmail"), clsLang.rm.getString("MsgError"))
            Me.TxtEmail.Select()
            Exit Sub
        End If

        If Me.TxtFilename.Text.Trim = vbNullString Then
            MessageBox.Show("No Filename", clsLang.rm.getString("MsgError"))
            Me.TxtFilename.Select()
            Exit Sub
        End If
        cOpen.CreateCSRConfig(Me.TxtCN.Text.Trim, Me.TxtEmail.Text.Trim)
        cOpen.CreateCSR(Me.TxtFilename.Text.Trim, Me.TxtPW.Text)
        Me.TxtCSR.Text = File.ReadAllText(My.Settings.CertFolder & "\" & Me.TxtFilename.Text.Trim & ".csr")
    End Sub

    Private Sub CmdCertificate_Click(sender As Object, e As EventArgs) Handles CmdCertificate.Click
        If CheckCertRequirements() = False Then Exit Sub
        If Me.TxtFilename.Text.Trim = vbNullString Then
            MessageBox.Show("No Filename", clsLang.rm.getString("MsgError"))
            Me.TxtFilename.Select()
            Exit Sub
        End If
        Dim URL As String = cCA.GetURLByName(CbCA.Text)
        Dim URLApi As String = "https://api." & URL & "/account/certs/new"
        SendApi(URLApi)
        If Me.TxtCert.Text.StartsWith("-----BEGIN CERTIFICATE-----") Then
            Dim path As String = My.Settings.CertFolder & "\" & Me.TxtFilename.Text.Trim & ".pem"
            File.WriteAllText(path, Me.TxtCert.Text)
        End If
    End Sub

    Private Sub CmdP12_Click(sender As Object, e As EventArgs) Handles CmdP12.Click
        If Me.TxtPW.Text.Trim = vbNullString Then
            MessageBox.Show(clsLang.rm.getString("MsgPassword"), clsLang.rm.getString("MsgError"))
            Me.TxtPW.Select()
            Exit Sub
        End If
        If Me.TxtFilename.Text.Trim = vbNullString Then
            MessageBox.Show("No Filename", clsLang.rm.getString("MsgError"))
            Me.TxtFilename.Select()
            Exit Sub
        End If
        cOpen.CreateP12(Me.TxtPW.Text, Me.TxtFilename.Text.Trim)
    End Sub

    Private Sub FillDataFromCert()
        Try
            ControllCmdCertButtons(True)
            Dim myCert As New X509Certificate2(Me.TxtCertFile.Text, Me.TxtPW.Text)
            With myCert
                Dim strTest As String() = .Subject.ToString.Split(",")
                For Each str As String In strTest
                    Dim parts As String() = str.Split("=")
                    Select Case parts(0).Trim.ToLower
                        Case "e"
                            Me.TxtEmail.Text = parts(1).Trim
                        Case "cn"
                            Me.TxtCN.Text = parts(1).Trim
                    End Select
                Next

                Dim certProfile As String = vbNullString

                For Each ext In .Extensions
                    Dim eku = TryCast(ext, X509EnhancedKeyUsageExtension)

                    If eku IsNot Nothing Then

                        For Each oid In eku.EnhancedKeyUsages
                            Select Case oid.Value.ToString
                                Case "1.3.6.1.5.5.7.3.2"
                                    'Client Auth
                                    certProfile = "client"
                                Case "1.3.6.1.5.5.7.3.4"
                                    'email protection
                                    certProfile &= "-mail"
                                Case Else
                                    Debug.Print(oid.FriendlyName)
                                    Debug.Print(oid.Value.ToString)
                            End Select
                        Next
                    End If
                Next

                If certProfile.StartsWith("-") Then
                    certProfile = certProfile.Substring(1)
                End If
                strTest = .Issuer.ToString.Split(",")
                For Each str As String In strTest
                    Dim parts As String() = str.Split("=")
                    Select Case parts(0).Trim.ToLower
                        Case "cn"
                            If parts(1).ToLower.Contains("assured") Then
                                certProfile &= "-a"
                            End If
                            If parts(1).ToLower.Contains("orga") Then
                                certProfile &= "-o"
                            End If
                        Case "o"
                            Dim ca As String = cCA.GetCAByOrg(parts(1).Trim)
                            If ca Is vbNullString Then
                                MessageBox.Show(clsLang.rm.getString("MsgNoCA"), clsLang.rm.getString("MsgError"))
                                ControllCmdCertButtons(False)
                            Else
                                CbCA.Text = ca

                            End If
                    End Select
                Next
                Me.CboProfile.SelectedValue = certProfile


                Dim startDate As DateTime = Convert.ToDateTime(.GetEffectiveDateString())
                Dim endDate As DateTime = Convert.ToDateTime(.GetExpirationDateString())
                If startDate > Now And endDate < Now Then
                    MessageBox.Show(clsLang.rm.getString("MsgInvalidCert"), clsLang.rm.getString("MsgError"))
                    ControllCmdCertButtons(False)
                End If
            End With


        Catch ex As System.Security.Cryptography.CryptographicException
            MessageBox.Show(clsLang.rm.getString("MsgPassword"), clsLang.rm.getString("MsgError"))
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace, clsLang.rm.getString("MsgError"))
        End Try
    End Sub

    Private Sub CmdFile_Click(sender As Object, e As EventArgs) Handles CmdFile.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Multiselect = False
            .Filter = String.Format(clsLang.rm.getString("CertImportFileFilter"), "(*.cer, *.p7b, *.p12)|*.p12;*.cer;*.p7b", "*.*", "*.*")
            .InitialDirectory = My.Settings.lastPath
            If .ShowDialog = DialogResult.OK Then
                My.Settings.lastPath = System.IO.Path.GetFullPath(.FileName)
                Me.TxtCertFile.Text = .FileName
                FillDataFromCert()
            End If
        End With
    End Sub

    Private Sub FrmApi_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.lastCA = Me.CbCA.Text
        My.Settings.Save()
        MdlHelper.lastPassword = Me.TxtPW.Text
        MdlHelper.lastFilename = Me.TxtFilename.Text
    End Sub

    Private Sub CmdAllSteps_Click(sender As Object, e As EventArgs) Handles CmdAllSteps.Click
        If Me.TxtPW.Text.Trim = vbNullString Then
            MessageBox.Show(clsLang.rm.getString("MsgPassword"), clsLang.rm.getString("MsgError"))
            Me.TxtPW.Select()
            Exit Sub
        End If

        If Me.TxtCN.Text.Trim = vbNullString Then
            MessageBox.Show(clsLang.rm.getString("MsgNoName"), clsLang.rm.getString("MsgError"))
            Me.TxtCN.Select()
            Exit Sub
        End If

        If Me.TxtEmail.Text.Trim = vbNullString Then
            MessageBox.Show(clsLang.rm.getString("MsgEmail"), clsLang.rm.getString("MsgError"))
            Me.TxtEmail.Select()
            Exit Sub
        End If

        If Me.TxtFilename.Text.Trim = vbNullString Then
            MessageBox.Show(clsLang.rm.getString("MsgNoFilename"), clsLang.rm.getString("MsgError"))
            Me.TxtFilename.Select()
            Exit Sub
        End If

        CmdCSR.PerformClick()
        CmdCertificate.PerformClick()

        If Me.TxtCert.Text.StartsWith("-----BEGIN CERTIFICATE-----") Then
            CmdP12.PerformClick()
        End If
    End Sub

    Private Sub CmdReping_Click(sender As Object, e As EventArgs) Handles CmdReping.Click
        If CheckCertRequirements() = False Then Exit Sub
        If Me.TxtEmail.Text.Trim = vbNullString Then
            MessageBox.Show(clsLang.rm.getString("MsgEmail"), clsLang.rm.getString("MsgError"))
            Me.TxtEmail.Select()
            Exit Sub
        End If
        Dim URL As String = cCA.GetURLByName(CbCA.Text)
        Dim URLApi As String = "https://api." & URL & "/account/emails/reping"
        Dim result As String = cApi.SendAPIEmailPing(URLApi, Me.TxtCertFile.Text, Me.TxtPW.Text, Me.TxtEmail.Text)
        If result = "" Then
            Me.TxtCert.Text = clsLang.rm.getString("ApiEmailCheck")
        Else
            Me.TxtCert.Text = getResult(result)
        End If

    End Sub

    Private Function CheckCertRequirements() As Boolean
        If Me.TxtPW.Text.Trim = vbNullString Then
            MessageBox.Show(clsLang.rm.getString("MsgPassword"), clsLang.rm.getString("MsgError"))
            Me.TxtPW.Select()
            Return False
        End If
        If File.Exists(Me.TxtCertFile.Text.Trim) = False Then
            MessageBox.Show("No Certificate given", clsLang.rm.getString("MsgError"))
            Me.CmdFile.Select()
            Return False
        End If

        Return True
    End Function

    Private Sub TxtCert_TextChanged(sender As Object, e As EventArgs) Handles TxtCert.TextChanged
        With Me.TxtCert
            If .Text.Contains(clsLang.rm.getString("MsgError")) Then
                .BackColor = Color.Coral
            ElseIf .Text.Contains(clsLang.rm.getString("ApiEmailCheck")) Then
                .BackColor = Color.LightYellow
            Else
                .BackColor = Color.White
            End If
        End With
    End Sub

    Private Sub ControllCmdCertButtons(value As Boolean)
        Me.CmdAllSteps.Enabled = value
        Me.CmdCertificate.Enabled = value
        Me.CmdP12.Enabled = value
        Me.CmdReping.Enabled = value
    End Sub

    Private Sub CboProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboProfile.SelectedIndexChanged
        If CboProfile.SelectedValue.ToString.Contains("-a") Or CboProfile.SelectedValue.ToString.Contains("-orga") Then
            If Me.TxtCN.Text = cCA.GetWotUserByName(Me.CbCA.Text) Then
                Me.TxtCN.Text = username
            End If
        Else
            If Me.TxtCN.Text <> cCA.GetWotUserByName(Me.CbCA.Text) Then
                username = Me.TxtCN.Text
                Me.TxtCN.Text = cCA.GetWotUserByName(Me.CbCA.Text)
            End If
        End If
    End Sub
End Class