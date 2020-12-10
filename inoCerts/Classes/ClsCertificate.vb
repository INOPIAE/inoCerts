Imports System.Security.Cryptography.X509Certificates

Public Class ClsCertificate
    Public cert As New X509Certificate2
    Public isInTruststore As Boolean
    Public Truststore As StoreLocation
    Public CertStore As StoreName
    Public isRoot As Boolean

    Public Sub New(certificate As X509Certificate2)
        cert = certificate
        isRoot = (cert.Issuer.Equals(cert.Subject))
        FindCertificateInTrustsore()
    End Sub

    Public Sub FindCertificateInTrustsore()

        Dim store As X509Store
        For Each storeL As StoreLocation In System.Enum.GetValues(GetType(StoreLocation))
            For Each storeN As StoreName In System.Enum.GetValues(GetType(StoreName))
                store = New X509Store(storeN, storeL)
                store.Open(OpenFlags.ReadOnly)
                For Each certF As X509Certificate2 In store.Certificates
                    If certF.Equals(cert) Then
                        isInTruststore = True
                        Truststore = store.Location
                        CertStore = storeN
                    End If
                Next
            Next
        Next
    End Sub
End Class
