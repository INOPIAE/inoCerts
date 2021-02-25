Imports System.ComponentModel

Public Class FrmSoftware

    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles CmdOK.Click
        Me.Close()
    End Sub

    Private Sub FrmSoftware_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim intCount As Int16 = 0
        For Each item As KeyValuePair(Of String, Boolean()) In FrmMain.cSoftware.ListSoftware()
            DgvSoftware.Rows.Add(FrmMain.cSoftware.IsSoftwareProcessed(item.Key), item.Key, item.Value(0), item.Value(1))
            DgvSoftware.Rows(intCount).ReadOnly = (Not item.Value(0) Or item.Value(1))
            intCount += 1
        Next

        DgvSoftware.Columns("State").HeaderText = clsLang.rm.getString("SoftwareState")
        DgvSoftware.Columns("Software").HeaderText = clsLang.rm.getString("SoftwareSoftware")
        DgvSoftware.Columns("Installed").HeaderText = clsLang.rm.getString("CertImportInTruststore")
        DgvSoftware.Columns("WindowsTruststore").HeaderText = clsLang.rm.getString("SoftwareTruststore")

        CmdOK.Text = clsLang.rm.getString("CmdOK")
        Me.Text = clsLang.rm.getString("SoftwareTitle")
    End Sub

    Private Sub FrmSoftware_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim strSettings As String = vbNullString
        Dim strDelimiter As String = vbNullString
        For Each row As DataGridViewRow In DgvSoftware.Rows
            If row.Cells("State").Value = True Then
                strSettings &= strDelimiter & row.Cells("Software").Value
                strDelimiter = "|"
            End If
        Next
        My.Settings.Software = strSettings
        My.Settings.Save()
    End Sub
End Class