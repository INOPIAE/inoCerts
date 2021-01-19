Public Class FrmSettings

    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles CmdOK.Click
        My.Settings.CertFolder = Me.TxtFolder.Text
        My.Settings.CertUtilFolder = Me.TxtCertUtil.Text
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TxtFolder.Text = My.Settings.CertFolder
        Me.TxtCertUtil.Text = My.Settings.CertUtilFolder
        Me.Text = clsLang.rm.getString("SettingsTitle")
        Me.LblFolder.Text = clsLang.rm.getString("SettingsCertFolder")
        Me.CmdCancel.Text = clsLang.rm.getString("CmdCancel")
        Me.CmdOK.Text = clsLang.rm.getString("CmdOK")
    End Sub

    Private Sub CmdFolder_Click(sender As Object, e As EventArgs) Handles CmdFolder.Click
        Dim fbd As New FolderBrowserDialog
        With fbd
            If .ShowDialog = DialogResult.OK Then
                Me.TxtFolder.Text = .SelectedPath
            End If
        End With
    End Sub

    Private Sub CmdCertUtil_Click(sender As Object, e As EventArgs) Handles CmdCertUtil.Click
        Dim fbd As New FolderBrowserDialog
        With fbd
            If .ShowDialog = DialogResult.OK Then
                Me.TxtCertUtil.Text = .SelectedPath
            End If
        End With
    End Sub
End Class