Imports System.Security.Cryptography.X509Certificates

Public Class FrmCertStoreCheck
    Private toolTips As New List(Of String)

    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles CmdOK.Click
        Me.Close()
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmCertStoreCheck_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me.LbStore
            .Items.Add([Enum].GetName(GetType(StoreName), StoreName.AddressBook))
            toolTips.Add(clsLang.rm.getString("CertStoreAdressbook"))
            .Items.Add([Enum].GetName(GetType(StoreName), StoreName.Disallowed))
            toolTips.Add(clsLang.rm.getString("CertStoreDisallowed"))
            .Items.Add([Enum].GetName(GetType(StoreName), StoreName.TrustedPeople))
            toolTips.Add(clsLang.rm.getString("CertStoreTrustedPeople"))
            .Items.Add([Enum].GetName(GetType(StoreName), StoreName.TrustedPublisher))
            toolTips.Add(clsLang.rm.getString("CertStoreTrustedPublisher"))
            .SelectedIndex() = 0
        End With
        Me.Text = clsLang.rm.getString("CertStoreTitle")
        Me.CmdOK.Text = clsLang.rm.getString("CmdOK")
        Me.CmdCancel.Text = clsLang.rm.getString("CmdCancel")
    End Sub

    Private Sub LbStore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbStore.SelectedIndexChanged
        ttCerts.SetToolTip(LbStore, toolTips(LbStore.SelectedIndex))
        ttCerts.ToolTipTitle = String.Format(clsLang.rm.getString("CertStoreToolTipTitle"), LbStore.SelectedItem)
    End Sub
End Class