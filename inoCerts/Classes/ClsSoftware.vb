Imports System.IO
Imports Microsoft.Win32

Public Class ClsSoftware
    Public processedSoftware() As String
    Public installedSoftware As SortedDictionary(Of String, Boolean())

    Public Sub New()
        ReadSoftware()
        installedSoftware = ListSoftware()
    End Sub

    Public Function ListSoftware() As SortedDictionary(Of String, Boolean())
        Dim result As New SortedDictionary(Of String, Boolean()) From {
            {"Firefox", {SoftwareInstalled("firefox.exe"), False}},
            {"PaleMoon", {SoftwareInstalled("palemoon.exe"), False}},
            {"Thunderbird", {SoftwareInstalled("thunderbird.exe"), False}},
            {"Interlink", {SoftwareInstalled("interlink.exe"), False}},
            {"Outlook", {SoftwareInstalled("OUTLOOK.EXE"), False}},
            {"Adobe Reader", {SoftwareInstalled("AcroRd32.exe"), True}},
            {"Google Chrome", {SoftwareInstalled("chrome.exe"), True}},
            {"Internet Explorer", {SoftwareInstalled("IEXPLORE.EXE"), True}},
            {"MS Edge", {SoftwareInstalled("msedge.exe"), True}},
            {"PDF-Over", {Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\.pdf-over"), False}}
        }
        Return result
    End Function

    Public Sub ReadSoftware()
        processedSoftware = My.Settings.Software.Split("|")
    End Sub

    Public Function IsSoftwareProcessed(Software As String) As Boolean
        Return Array.IndexOf(processedSoftware, Software) >= 0
    End Function

    Public Function IsSoftwareInstalled(Software As String) As Boolean
        Dim value() As Boolean = installedSoftware.Item(Software)
        Return value(0)
    End Function

    Private Function SoftwareInstalled(Software As String) As Boolean
        Dim key As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\App Paths")
        Dim productKey As RegistryKey = key.OpenSubKey(Software)

        If productKey IsNot Nothing Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
