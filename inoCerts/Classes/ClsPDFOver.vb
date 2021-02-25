Imports System
Imports System.Text

Public Class ClsPDFOver
    Public PDFOverPath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\.pdf-over"

    Public Function WriteConfig(CertAlias As String, CertFile As String, Password As String) As Boolean
        Dim file As String = PDFOverPath & "\PDF-Over.config"
        Dim blnKeyPass As Boolean = False
        Dim blnStorePass As Boolean = False
        Dim lines() As String = System.IO.File.ReadAllLines(file)
        For intCount As Int16 = 0 To lines.Count - 1
            Dim p() As String = lines(intCount).Split("=")
            If p.Count = 1 Then Continue For
            Select Case p(0)
                Case "KEYSTORE_ALIAS"
                    lines(intCount) = "KEYSTORE_ALIAS=" & ConvertText(CertAlias)
                Case "KEYSTORE_FILE"
                    lines(intCount) = "KEYSTORE_FILE=" & ConvertText(CertFile)
                Case "KEYSTORE_KEYPASS"
                    lines(intCount) = "KEYSTORE_KEYPASS=" & Password
                    blnKeyPass = True
                Case "KEYSTORE_STOREPASS"
                    lines(intCount) = "KEYSTORE_STOREPASS=" & Password
                    blnStorePass = True
                'TODO check if needed
                Case "KEYSTORE_ENABLED" 'True
                Case "KEYSTORE_TYPE" 'PKCS12 
            End Select
        Next
        If Password <> vbNullString Then
            If blnKeyPass = False Then
                ReDim Preserve lines(lines.Count)
                lines(lines.Count - 1) = "KEYSTORE_KEYPASS=" & Password
            End If
            If blnStorePass = False Then
                ReDim Preserve lines(lines.Count)
                lines(lines.Count - 1) = "KEYSTORE_STOREPASS=" & Password
            End If
        End If
        System.IO.File.WriteAllLines(file, lines)
        Return True
    End Function

    Private Function ConvertText(Giventext As String) As String
        Giventext = Giventext.Replace("\", "\\").Replace(":", "\:")
        Dim Result As String = vbNullString
        For Each c As Char In Giventext.ToCharArray
            If Asc(c) > 127 Then
                Result &= "\u00" & Hex(Asc(c))
            Else
                Result &= c
            End If
        Next
        Return Result
    End Function
End Class
