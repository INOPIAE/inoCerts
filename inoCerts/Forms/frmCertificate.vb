﻿Imports System.Security.Cryptography.X509Certificates

Public Class FrmCertificate

    Private certfile As ClsCertificates
    Public strRoot As String = vbNullString
    Public strStoreLocation As String = vbNullString
    Private intSelected As Int16

    Private Sub CmdFile_Click(sender As Object, e As EventArgs) Handles CmdFile.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Multiselect = False
            .Filter = "Zertifikate (*.cer, *. p7b, *.p12, )|*.p12; *.cer; *.p7b|Alle Dateien (*.*)|*.*"
            .InitialDirectory = My.Settings.lastPath
            If .ShowDialog = DialogResult.OK Then
                My.Settings.lastPath = System.IO.Path.GetFullPath(.FileName)
                Me.TxtFile.Text = .FileName
            End If
        End With
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub CmdAnalyse_Click(sender As Object, e As EventArgs) Handles CmdAnalyse.Click
        LblDGVInfo.Text = "Zertifikate werden eingelesen"
        LblDGVInfo.BackColor = Color.Coral
        Application.DoEvents()
        certfile = New ClsCertificates(Me.TxtFile.Text, Me.TxtPassword.Text, strRoot, strStoreLocation)

        fillDatagrid()
        LblDGVInfo.Text = String.Format("Datei enthält {0} Zertifikate", certfile.certs.Count)
        LblDGVInfo.BackColor = Me.BackColor
    End Sub

    Private Sub fillDatagrid()
        DgvCertificate.Rows.Clear()
        Dim intCount As Integer = 0
        If certfile.certs Is Nothing = False Then
            For Each cert As ClsCertificate In certfile.certs
                Me.DgvCertificate.Rows.Add(False, cert.cert.Subject, cert.cert.Issuer, cert.isInTruststore, cert.Truststore.ToString, cert.CertStore.ToString, cert.CurrentCertType.ToString)
                If cert.isInTruststore Then
                    DgvCertificate.Rows(intCount).Cells("IsInTruststore").Style.BackColor = Color.LightGreen
                End If
                intCount += 1
            Next
        End If
        intSelected = 0
        UpdateStatusbar()
    End Sub

    Private Sub FrmCertificate_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TxtPassword.Text = My.Settings.lastPassword
        Me.LblDGVInfo.Text = vbNullString
    End Sub

    Private Sub FrmCertificate_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'My.Settings.lastPassword = Me.TxtPassword.Text
    End Sub

    Private Sub CmdImport_Click(sender As Object, e As EventArgs) Handles CmdImport.Click
        Dim blnImport As Boolean = False
        For Each r As DataGridViewRow In Me.DgvCertificate.Rows
            If r.Cells("chkBox").Value = True Then
                If r.Cells("IsInTruststore").Value = True Then
                    MyMessage("Zertifikat schon im Truststore")
                    Continue For
                End If
                Dim storeL As StoreLocation = StoreLocation.LocalMachine
                Dim storeN As StoreName = StoreName.My
                Dim cert As X509Certificate2 = certfile.GetCertBySubject(r.Cells("Subject").Value)
                Select Case [Enum].Parse(GetType(ClsCertificate.CertType), r.Cells("CertType").Value)
                    Case ClsCertificate.CertType.EndCertificate
                        'TODO check correct store
                        If cert.HasPrivateKey = True Then
                            storeN = StoreName.My
                        Else
                            Dim frm As New FrmCertStoreCheck
                            frm.LblCertStore.Text = "Zertifikatsstore für" & vbNewLine & r.Cells("Subject").Value & ":"
                            If frm.ShowDialog = DialogResult.OK Then
                                storeN = [Enum].Parse(GetType(StoreName), frm.LbStore.SelectedItem)
                            Else
                                MyMessage("Import abgebrochen")
                                Continue For
                            End If
                        End If
                        storeL = StoreLocation.CurrentUser
                    Case ClsCertificate.CertType.IntermediateCertificate
                        storeN = StoreName.CertificateAuthority
                        storeL = StoreLocation.LocalMachine
                    Case ClsCertificate.CertType.RootCertificate
                        storeN = StoreName.Root
                        storeL = StoreLocation.LocalMachine
                    Case Else
                        'TODO check correct store
                        storeN = StoreName.My
                        storeL = StoreLocation.CurrentUser
                        MyMessage("Zertifikatstore not defined")
                        Continue For
                End Select

                AddCertificate(cert, storeL, storeN)
                blnImport = True
            End If
        Next
        If blnImport = True Then
            CmdAnalyse.PerformClick()
        End If
    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles CmdDelete.Click
        Dim blnDelete As Boolean = False
        For Each r As DataGridViewRow In Me.DgvCertificate.Rows
            If r.Cells("chkBox").Value = True Then
                Dim storeN As StoreName = [Enum].Parse(GetType(StoreName), r.Cells("CertStore").Value)
                Dim storeL As StoreLocation = [Enum].Parse(GetType(StoreLocation), r.Cells("TrustStore").Value)
                RemoveCertificate(certfile.GetCertBySubject(r.Cells("Subject").Value), storeL, storeN)
                blnDelete = True
            End If
        Next
        If blnDelete = True Then
            CmdAnalyse.PerformClick()
        End If
    End Sub

    Private Sub DgvCertificate_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCertificate.CellValueChanged
        If DgvCertificate.Columns(e.ColumnIndex).Name = "chkBox" Then
            Dim checkCell As DataGridViewCheckBoxCell = CType(DgvCertificate.Rows(e.RowIndex).Cells("chkBox"), DataGridViewCheckBoxCell)

            If checkCell.Value = True Then
                checkCell.Style.BackColor = Color.LightGoldenrodYellow
                intSelected += 1
            Else
                checkCell.Style.BackColor = Color.White
                intSelected -= 1
            End If
            DgvCertificate.Invalidate()
            UpdateStatusbar()
        End If
    End Sub

    Private Sub CmdSelectAll_Click(sender As Object, e As EventArgs) Handles CmdSelectAll.Click
        For Each row As DataGridViewRow In DgvCertificate.Rows
            Dim cell As DataGridViewCheckBoxCell = CType(row.Cells("chkBox"), DataGridViewCheckBoxCell)
            cell.Value = True
            UpdateStatusbar()
        Next
    End Sub

    Private Sub CmdDeselectAll_Click(sender As Object, e As EventArgs) Handles CmdDeselectAll.Click
        For Each row As DataGridViewRow In DgvCertificate.Rows
            Dim cell As DataGridViewCheckBoxCell = CType(row.Cells("chkBox"), DataGridViewCheckBoxCell)
            cell.Value = False
        Next
        UpdateStatusbar()
    End Sub

    Private Sub UpdateStatusbar()
        If Me.DgvCertificate.RowCount > 0 Then
            frmMain.TslbCert.Text = String.Format("{0} Zertifikat(e) ausgewählt", intSelected)
        Else
            frmMain.TslbCert.Text = vbNullString
        End If
    End Sub

    Private Sub FrmCertificate_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus

    End Sub

    Private Sub FrmCertificate_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateStatusbar()
    End Sub

    Private Sub FrmCertificate_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        frmMain.TslbCert.Text = vbNullString
    End Sub

    Private Sub FrmCertificate_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim intPadding = 20
        If Me.Width < Me.MinimumSize.Width Then Me.Width = Me.MinimumSize.Width
        Me.CmdAnalyse.Left = Me.Width - intPadding - Me.CmdAnalyse.Width
        Me.CmdCancel.Left = Me.Width - intPadding - Me.CmdCancel.Width
        Me.CmdDelete.Left = Me.Width - intPadding - Me.CmdDelete.Width
        Me.CmdImport.Left = Me.Width - intPadding - Me.CmdImport.Width

        Me.DgvCertificate.Width = Me.Width - (Me.Width - CmdImport.Left) - intPadding

        If Me.Height < Me.MinimumSize.Height Then Me.Height = Me.MinimumSize.Height
        Me.CmdCancel.Top = Me.Height - intPadding - Me.CmdCancel.Height - frmMain.StatusStrip.Height
        Me.DgvCertificate.Height = Me.Height - (Me.Height - CmdCancel.Top) - Me.DgvCertificate.Top - 50
        Me.LblDGVInfo.Top = Me.DgvCertificate.Top + Me.DgvCertificate.Height + intPadding
    End Sub
End Class
