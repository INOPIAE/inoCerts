Public Class FrmSettings
    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles CmdOK.Click
        My.Settings.CertFolder = Me.TxtFolder.Text
        Me.Close()
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TxtFolder.Text = My.Settings.CertFolder
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