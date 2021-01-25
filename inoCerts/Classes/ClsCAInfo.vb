Public Class ClsCAInfo

    Public Structure CAInfo
        Public CAName As String
        Public CAURL As String
        Public CAOrg As String
        Public CAWotUser As String
    End Structure

    Public CAInfos() As CAInfo

    Public Sub New()

        Dim intCount As Int16 = 0
        Dim filename As String = Application.StartupPath & "\Settings\ca.ini"

        Dim TextLine() As String

        Dim objReader As New System.IO.StreamReader(filename)

        Do While objReader.Peek() <> -1

            TextLine = objReader.ReadLine().Split(",")
            ReDim Preserve CAInfos(intCount)
            Dim cInfos As New CAInfo With {
                .CAName = TextLine(0).Trim,
                .CAURL = TextLine(1).Trim,
                .CAOrg = TextLine(2).Trim,
                .CAWotUser = TextLine(3).Trim
            }
            CAInfos(intCount) = cInfos
            intCount += 1
        Loop

        objReader.Close()


    End Sub

    Public Function GetURLByName(caname As String) As String
        For Each ca As CAInfo In CAInfos
            If ca.CAName.Equals(caname) Then Return ca.CAURL
        Next
        Return vbNullString
    End Function

    Public Function GetOrgByName(caname As String) As String
        For Each ca As CAInfo In CAInfos
            If ca.CAName.Equals(caname) Then Return ca.CAOrg
        Next
        Return vbNullString
    End Function

    Public Function GetCAByOrg(Org As String) As String
        For Each ca As CAInfo In CAInfos
            If ca.CAOrg.Equals(Org) Then Return ca.CAName
        Next
        Return vbNullString
    End Function

    Public Function GetWotUserByName(caname As String) As String
        For Each ca As CAInfo In CAInfos
            If ca.CAName.Equals(caname) Then Return ca.CAWotUser
        Next
        Return vbNullString
    End Function
End Class
