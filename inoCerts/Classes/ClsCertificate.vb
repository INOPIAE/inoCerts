Imports System.Security.Cryptography.X509Certificates

Public Class ClsCertificate
    Public cert As New X509Certificate2
    Public isInTruststore As Boolean

    Public Sub New(certificate As X509Certificate2)
        cert = certificate

    End Sub
End Class
