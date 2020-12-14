Imports System.Security.Cryptography.X509Certificates

Public Class ClsCertificates
    Public certs() As ClsCertificate
    Public password As String

    Public Sub New(strFile As String, strPassword As String, Optional strRoot As String = vbNullString,
                   Optional strStoreLocation As String = vbNullString)

        Dim certfile As New X509Certificate2Collection()

        Try
            certfile.Import(strFile, strPassword, X509KeyStorageFlags.PersistKeySet)
        Catch exception As System.Security.Cryptography.CryptographicException
            Select Case exception.HResult
                Case -2147024810
                    MessageBox.Show("Das Password fehlt oder ist falsch.", "Fehler")
                Case -2147024894
                    MessageBox.Show("Die angegegeben Datei is nicht vorhanden.", "Fehler")
                Case Else
                    MessageBox.Show(exception.HResult & " " & exception.Message)
                    Debug.Print(exception.HResult)
            End Select
            Exit Sub
        End Try

        password = strPassword

        Dim intCount As Integer = 0
        Dim lastSubject As String = vbNullString
        For Each cert As X509Certificate2 In certfile
            ReDim Preserve certs(intCount)
            certs(intCount) = New ClsCertificate(cert)
            Select Case strRoot
                Case "root"
                    certs(intCount).CurrentCertType = ClsCertificate.CertType.RootCertificate
                    certs(intCount).CertStore = StoreName.Root
                Case "intermediate"
                    certs(intCount).CurrentCertType = ClsCertificate.CertType.IntermediateCertificate
                    certs(intCount).CertStore = StoreName.CertificateAuthority
            End Select
            If strStoreLocation <> vbNullString Then
                certs(intCount).Truststore = [Enum].Parse(GetType(StoreLocation), strStoreLocation)
            End If
            lastSubject = cert.Subject
            intCount += 1
        Next
        If lastSubject.Length > 0 Then
            CheckChain(GetCertBySubject(lastSubject))
        End If
    End Sub

    Public Function GetCertBySubject(subject As String) As X509Certificate2
        For Each cert As ClsCertificate In certs
            If cert.cert.Subject.Equals(subject) Then
                Return cert.cert
            End If
        Next
        Return Nothing
    End Function

    Public Sub CheckChain(cert As X509Certificate2)
        Dim ch As X509Chain = New X509Chain()
        ch.ChainPolicy.RevocationMode = X509RevocationMode.Online
        ch.Build(cert)
        Console.WriteLine("Number of chain elements: {0}", ch.ChainElements.Count)
        Dim intCount As Integer = 0
        For Each element As X509ChainElement In ch.ChainElements

            For Each clsCert As ClsCertificate In certs
                If clsCert.cert.Subject.Equals(element.Certificate.Subject) Then
                    If element.Certificate.Subject.Equals(element.Certificate.Issuer) Then
                        clsCert.CurrentCertType = ClsCertificate.CertType.RootCertificate
                        Exit For
                    End If
                    If intCount = 0 Then
                        clsCert.CurrentCertType = ClsCertificate.CertType.EndCertificate
                        Exit For
                    End If
                    clsCert.CurrentCertType = ClsCertificate.CertType.IntermediateCertificate
                    Exit For
                End If
            Next
            intCount = +1
        Next
    End Sub

End Class
