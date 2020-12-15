Imports System.IO
Imports System.Security.Cryptography.X509Certificates

Module MdlCertificate

    Public Sub AddCertificate(cert As X509Certificate2, truststore As StoreLocation, certstore As StoreName)
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) = False And truststore = StoreLocation.LocalMachine Then
            MyMessage("Das Programm muss als Administrator gestartet werden.")
            Exit Sub
        End If
        Dim store As New X509Store(certstore, truststore)
        store.Open(OpenFlags.ReadWrite)
        store.Add(cert)
        store.Close()
    End Sub

    Public Sub RemoveCertificate(cert As X509Certificate2, truststore As StoreLocation, certstore As StoreName)
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) = False And truststore = StoreLocation.LocalMachine Then
            MyMessage("Das Programm muss als Administrator gestartet werden.")
            Exit Sub
        End If
        Dim store As New X509Store(certstore, truststore)
        store.Open(OpenFlags.ReadWrite)
        store.Remove(cert)
        store.Close()
    End Sub

    Public Function CheckChain(cert As X509Certificate2) As String
        Dim ch As X509Chain = New X509Chain()
        ch.ChainPolicy.RevocationMode = X509RevocationMode.Online
        ch.Build(cert)
        Console.WriteLine("Number of chain elements: {0}", ch.ChainElements.Count)
        Dim intCount As Integer = 0
        For Each element As X509ChainElement In ch.ChainElements
            If element.Certificate.Subject.Equals(element.Certificate.Issuer) Then

                Exit For
            End If
            If intCount = 0 Then

                Exit For
            End If

            Exit For

            intCount = +1
        Next
    End Function

    Public Function FindCertificateInTrustsore(cert As X509Certificate2) As String
        Dim store As X509Store
        For Each storeL As StoreLocation In System.Enum.GetValues(GetType(StoreLocation))
            For Each storeN As StoreName In System.Enum.GetValues(GetType(StoreName))
                store = New X509Store(storeN, storeL)
                store.Open(OpenFlags.ReadOnly)
                For Each certF As X509Certificate2 In store.Certificates
                    If certF.Equals(cert) Then
                        Return [Enum].Parse(GetType(StoreLocation), storeL) & ":" & [Enum].Parse(GetType(StoreName), storeN)
                    End If
                Next
                store.Close()
            Next
        Next
        Return "Nicht in einem Trusstrore gefunden."
    End Function

    Public Function CertFromFile(strFile As String)
        Dim cert As New X509Certificate2

        Dim f As FileStream = New FileStream(strFile, FileMode.Open, FileAccess.Read)
        Dim size As Integer = CInt(f.Length)
        Dim data As Byte() = New Byte(size - 1) {}
        size = f.Read(data, 0, size)
        f.Close()
        cert.Import(data)
        Return cert
    End Function
End Module
