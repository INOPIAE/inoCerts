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
            toolTips.Add("Wird genutzt für die E-Mail-Zertifikate von Kommunikationspartneren.")
            .Items.Add([Enum].GetName(GetType(StoreName), StoreName.Disallowed))
            toolTips.Add("Wird genutzt für Zertifikate, denen mistraut wird.")
            .Items.Add([Enum].GetName(GetType(StoreName), StoreName.TrustedPeople))
            toolTips.Add("Wird genutzt für Zertifikate, denen vertraut wird.")
            .Items.Add([Enum].GetName(GetType(StoreName), StoreName.TrustedPublisher))
            toolTips.Add("Wird genutzt für Zertifikate, die als vertrauenswürdige Herausgaber von Software gelten sollen.")
            .SelectedIndex() = 0
        End With
    End Sub

    Private Sub LbStore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbStore.SelectedIndexChanged
        ttCerts.SetToolTip(LbStore, toolTips(LbStore.SelectedIndex))
        ttCerts.ToolTipTitle = "Nutzung von " & LbStore.SelectedItem
    End Sub
End Class