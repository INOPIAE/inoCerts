

Imports System.Security.Cryptography.X509Certificates

Public Class ClsCertificates
    Public certs() As ClsCertificate
    Public password As String

    Public Sub New(strFile As String, strPassword As String)
        Dim certfile As New X509Certificate2Collection()
        password = strPassword
        certfile.Import(strFile, strPassword, X509KeyStorageFlags.PersistKeySet)
        Dim intCount As Integer = 0
        For Each cert As X509Certificate2 In certfile
            ReDim Preserve certs(intCount)
            certs(intCount) = New ClsCertificate(cert)
            intCount += 1
        Next
    End Sub
End Class
