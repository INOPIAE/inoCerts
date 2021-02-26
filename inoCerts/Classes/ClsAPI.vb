Imports System.IO
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Imports System.Text

Public Class ClsAPI
    Public Function SendApi(URL As String, CertFile As String, Password As String, Postdata As String) As String
        Dim myResp As WebResponse
        Try
            Dim myReq As HttpWebRequest

            Dim myReader As StreamReader
            myReq = HttpWebRequest.Create(URL)
            Dim myCert As New X509Certificate(CertFile, Password)
            myReq.ClientCertificates.Add(myCert)
            myReq.Method = "POST"
            myReq.ContentType = "application/x-www-form-urlencoded"
            myReq.Accept = "text/plain"

            Dim postBytes As Byte() = Encoding.UTF8.GetBytes(Postdata)
            myReq.ContentLength = postBytes.Length

            Dim postStream As Stream = myReq.GetRequestStream()
            postStream.Write(postBytes, 0, postBytes.Length)
            postStream.Flush()
            postStream.Close()

            Try
                myResp = myReq.GetResponse
            Catch ex As WebException
                myResp = ex.Response
            End Try

            myReader = New System.IO.StreamReader(myResp.GetResponseStream)

            Return myReader.ReadToEnd

        Catch ex As Exception
            MessageBox.Show(ex.Message & " " & ex.StackTrace)
            Return "error occured"
        End Try

    End Function

    Public Function SendAPICertRequest(URL As String, CertFile As String, Password As String, CSR As String, Profile As String, Optional OrgNo As Long = 0) As String

        Dim strCR As String = CSR
        If strCR.EndsWith(vbNewLine) Then
            strCR = strCR.Substring(0, strCR.Length - 1)
        End If

        'add urlencoding manully for csr
        strCR = strCR.Trim.Replace(vbCr, "")
        strCR = strCR.Replace(vbLf, "%0A")
        strCR = strCR.Replace("+", "%2B")
        Dim postData As String = "csr=" & strCR & "&chain&profile=" & Profile
        If OrgNo > 0 Then
            postData &= "&asOrg=" & OrgNo
        End If

        Return SendApi(URL, CertFile, Password, postData)
    End Function

    Public Function SendAPIEmailPing(URL As String, CertFile As String, Password As String, email As String) As String

        Dim postData As String = "email=" & email

        Return SendApi(URL, CertFile, Password, postData)
    End Function
End Class
