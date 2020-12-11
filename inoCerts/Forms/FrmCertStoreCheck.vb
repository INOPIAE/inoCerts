Imports System.Security.Cryptography.X509Certificates

Public Class FrmCertStoreCheck
    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles CmdOK.Click
        Me.Close()
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmCertStoreCheck_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me.LbStore
            .Items.Add([Enum].GetName(GetType(StoreName), StoreName.AddressBook))
            .Items.Add([Enum].GetName(GetType(StoreName), StoreName.Disallowed))
            .Items.Add([Enum].GetName(GetType(StoreName), StoreName.TrustedPeople))
            .Items.Add([Enum].GetName(GetType(StoreName), StoreName.TrustedPublisher))
            .SelectedIndex() = 0
        End With
    End Sub
End Class