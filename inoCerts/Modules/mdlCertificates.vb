Imports System.Security.Cryptography.X509Certificates

Module mdlCertificates
    Public Function GetPublicKey(strFile As String, strPassword As String) As String
        Dim cert As New X509Certificate2(strFile, strPassword)
        Console.WriteLine("{0}Subject: {1}{0}", Environment.NewLine, cert.Subject)
        Console.WriteLine("{0}Issuer: {1}{0}", Environment.NewLine, cert.Issuer)
        Console.WriteLine("{0}Version: {1}{0}", Environment.NewLine, cert.Version)
        Console.WriteLine("{0}Valid Date: {1}{0}", Environment.NewLine, cert.NotBefore)
        Console.WriteLine("{0}Expiry Date: {1}{0}", Environment.NewLine, cert.NotAfter)
        Console.WriteLine("{0}Thumbprint: {1}{0}", Environment.NewLine, cert.Thumbprint)
        Console.WriteLine("{0}Serial Number: {1}{0}", Environment.NewLine, cert.SerialNumber)
        Console.WriteLine("{0}Friendly Name: {1}{0}", Environment.NewLine, cert.PublicKey.Oid.FriendlyName)
        Console.WriteLine("{0}Public Key Format: {1}{0}", Environment.NewLine, cert.PublicKey.EncodedKeyValue.Format(True))
        Console.WriteLine("{0}Raw Data Length: {1}{0}", Environment.NewLine, cert.RawData.Length)
        Console.WriteLine("{0}Certificate to string: {1}{0}", Environment.NewLine, cert.ToString(True))
        Console.WriteLine("{0}Certificate to XML String: {1}{0}", Environment.NewLine, cert.PublicKey.Key.ToXmlString(False))
        Return cert.GetPublicKeyString
        'Return cert.PublicKey.Key.ToString
    End Function

    Public Sub getCertificatesFromP12(strFile As String, strPassword As String)

        Dim certs As New X509Certificate2Collection()
        certs.Import(strFile, strPassword, X509KeyStorageFlags.PersistKeySet)

        For Each cert As X509Certificate2 In certs
            Console.WriteLine("Subject is: '{0}'", cert.Subject)
            Console.WriteLine("Issuer is:  '{0}'", cert.Issuer)
        Next


    End Sub
End Module
