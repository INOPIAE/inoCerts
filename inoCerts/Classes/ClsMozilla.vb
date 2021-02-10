Imports System.IO
Imports System.Text

Public Class ClsMozilla
    Public ThunderbirdPath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\AppData\Roaming\Thunderbird\"
    Public FirefoxPath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\AppData\Roaming\Mozilla\Firefox\"
    Public PaleMoonPath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\AppData\Roaming\Moonchild Productions\Pale Moon\"
    Public InterlinkPath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\AppData\Roaming\Binary Outcast\Interlink\"

    Public Function ListThunderbird() As Dictionary(Of String, String)
        Return GetProfiles(ThunderbirdPath)
    End Function

    Public Function ListFirefox() As Dictionary(Of String, String)
        Return GetProfiles(FirefoxPath)
    End Function

    Public Function ListPalemoon() As Dictionary(Of String, String)
        Return GetProfiles(PaleMoonPath)
    End Function

    Public Function ListInterlink() As Dictionary(Of String, String)
        Return GetProfiles(InterlinkPath)
    End Function

    Private Shared Function GetProfiles(path As String) As Dictionary(Of String, String)
        Dim result As New Dictionary(Of String, String)

        If Directory.Exists(path) = False Then
            result.Add(clsLang.rm.getString("NotFound"), clsLang.rm.getString("NotFound"))
            Return result
        End If

        Dim result1 As New Dictionary(Of String, String)
        Return ReadProfiles(path)

    End Function

    Public Function CertInProfile(Profile As String, Certname As String) As Boolean
        Dim Arguments As String = "-L -n """ & Certname & """"
        Dim sOutput As String = UseCertutil(Profile, Arguments)

        If sOutput.Contains(": File not found") Then
            Return False
        ElseIf sOutput.Contains("certutil.exe:") Then
            Debug.Print(sOutput)
            Return False
        Else
            Return True
        End If
    End Function

    Public Function ImportRootCertificate(Profile As String, Certname As String, CertFile As String) As Boolean
        Return ImportCertificate(Profile, Certname, CertFile, "CT,CT,CT")
    End Function

    Public Function ImportUserCertificate(Profile As String, Certname As String, CertFile As String) As Boolean
        Return ImportCertificate(Profile, Certname, CertFile, ",,")
    End Function

    Private Shared Function ImportCertificate(Profile As String, Certname As String, CertFile As String, Trust As String) As Boolean
        Dim Arguments As String = "-A -n """ & Certname & """ -t """ & Trust & """ -i """ & CertFile & """"
        Dim sOutput As String = UseCertutil(Profile, Arguments)
        If sOutput.Contains("certutil.exe:") Then
            Debug.Print(sOutput)
            Return False
        Else
            Return True
        End If
    End Function

    Private Shared Function UseCertutil(Profile As String, Arguments As String) As String
        Dim CertUtilPath As String = Application.StartupPath & "\lib\nss\"
        Dim startInfo As New ProcessStartInfo
        Dim myProcess As New Process()
        startInfo.UseShellExecute = False
        startInfo.RedirectStandardOutput = True
        startInfo.RedirectStandardError = True
        startInfo.CreateNoWindow = True
        startInfo.FileName = CertUtilPath & "certutil.exe"
        startInfo.Arguments = " -d sql:""" & Profile & """ " & Arguments
        myProcess.StartInfo = startInfo
        myProcess.Start()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = myProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using

        Dim sOutputError As String
        Using oStreamReader As System.IO.StreamReader = myProcess.StandardError
            sOutputError = oStreamReader.ReadToEnd()
        End Using

        If sOutputError.Count = 0 Then
            Return sOutput
        Else
            Return sOutputError
        End If
    End Function

    Private Shared Function UsePK12util(Profile As String, Arguments As String) As String
        Dim CertUtilPath As String = Application.StartupPath & "\lib\nss\"
        Dim startInfo As New ProcessStartInfo
        Dim myProcess As New Process()
        startInfo.UseShellExecute = False
        startInfo.RedirectStandardOutput = True
        startInfo.RedirectStandardError = True
        startInfo.CreateNoWindow = True
        startInfo.FileName = CertUtilPath & "pk12util.exe"
        startInfo.Arguments = " -d sql:""" & Profile & """ " & Arguments
        myProcess.StartInfo = startInfo
        myProcess.Start()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = myProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using

        Dim sOutputError As String
        Using oStreamReader As System.IO.StreamReader = myProcess.StandardError
            sOutputError = oStreamReader.ReadToEnd()
        End Using

        If sOutputError.Count = 0 Then
            Return sOutput
        Else
            Return sOutputError
        End If
    End Function

    Public Function ImportP12(Profile As String, CertFile As String, Password As String) As Boolean
        Dim Arguments As String = "-W """ & Password & """ -i """ & CertFile & """"
        Dim sOutput As String = UsePK12util(Profile, Arguments)

        If sOutput.Contains("pk12util.exe: PKCS12 IMPORT SUCCESSFUL") Then
            Return True
        Else
            Debug.Print(sOutput)
            Dim strMessage As String() = sOutput.Split(".exe")
            MessageBox.Show(clsLang.rm.getstring("MsgEorrorOccurs") & vbNewLine & strMessage(1).Substring(4).Trim, clsLang.rm.getstring("MsgError"))
            Return False
        End If
    End Function

    Private Shared Function ReadProfiles(Path As String) As Dictionary(Of String, String)
        Dim reader As New StreamReader(Path & "profiles.ini", Encoding.Default)
        Dim strLine As String
        Dim strLines() As String
        Dim ProfileName As String = vbNullString
        Dim ProfilePath As String = vbNullString
        Dim isRelative As Int16 = 0
        Dim result As New Dictionary(Of String, String)

        strLine = reader.ReadLine
        Do Until strLine Is Nothing
            strLines = strLine.Split("=")
            Select Case strLines(0).Trim
                Case Is >= "[Profile"
                    If ProfileName <> vbNullString Then
                        If isRelative = 1 Then
                            ProfilePath = Path & ProfilePath
                        End If
                        result.Add(ProfileName, ProfilePath)
                        ProfileName = vbNullString
                        ProfilePath = vbNullString
                        isRelative = 0
                    End If
                Case "Name"
                    ProfileName = strLines(1).Trim
                Case "IsRelative"
                    isRelative = CInt(strLines(1).Trim)
                Case "Path"
                    ProfilePath = strLines(1).Trim.Replace("/", "\")
            End Select
            strLine = reader.ReadLine
        Loop

        If isRelative = 1 Then
            ProfilePath = Path & "\" & ProfilePath
        End If
        result.Add(ProfileName, ProfilePath)

        reader.Close()
        Return result
    End Function
End Class
