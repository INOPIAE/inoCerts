

Imports System.Security.Cryptography.X509Certificates

Public Class ClsCertificates
    Public certs() As ClsCertificate
    Public password As String

    Public Sub New(strFile As String, strPassword As String)
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
        For Each cert As X509Certificate2 In certfile
            ReDim Preserve certs(intCount)
            certs(intCount) = New ClsCertificate(cert)
            intCount += 1
        Next
    End Sub
End Class
