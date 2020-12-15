Public Class FrmSettings
    Private clsLang = New ClsLanguage

    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles CmdOK.Click
        My.Settings.CertFolder = Me.TxtFolder.Text
        Me.Close()
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TxtFolder.Text = My.Settings.CertFolder

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
End Class