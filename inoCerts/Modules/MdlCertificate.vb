Imports System.Security.Cryptography.X509Certificates

Module MdlCertificate

    Public Sub AddCertificate(cert As X509Certificate2, truststore As StoreLocation, certstore As StoreName)
        Dim store As New X509Store(certstore, truststore)
        store.Open(OpenFlags.ReadWrite)
        store.Add(cert)
    End Sub

    Public Sub RemoveCertificate(cert As X509Certificate2, truststore As StoreLocation, certstore As StoreName)
        Dim store As New X509Store(certstore, truststore)
        store.Open(OpenFlags.ReadWrite)
        store.Remove(cert)
    End Sub

End Module
