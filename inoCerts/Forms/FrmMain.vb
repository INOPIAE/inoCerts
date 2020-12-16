Imports System.Windows.Forms

Public Class FrmMain
    Private clsLang = New ClsLanguage

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Neue Instanz des untergeordneten Formulars erstellen.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Vor der Anzeige dem MDI-Formular unterordnen.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = String.Format("{0} {1}", clsLang.rm.getString("MainWindowEntry"), m_ChildFormNumber)

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Hier Code zum Öffnen der Datei hinzufügen
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Hier Code einfügen, um den aktuellen Inhalt des Formulars in einer Datei zu speichern
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Mithilfe von My.Computer.Clipboard den ausgewählten Text bzw. die ausgewählten Bilder in die Zwischenablage kopieren
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Mithilfe von My.Computer.Clipboard den ausgewählten Text bzw. die ausgewählten Bilder in die Zwischenablage kopieren
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Mithilfe von My.Computer.Clipboard.GetText() oder My.Computer.Clipboard.GetData Informationen aus der Zwischenablage abrufen
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Alle untergeordneten Formulare des übergeordneten Formulars schließen
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ImportWindowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportWindowsToolStripMenuItem.Click
        Dim frm As New FrmCertificate
        With frm
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        FrmSettings.Show()
    End Sub

    Private Sub WPIARootzertifikateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WPIARootzertifikateToolStripMenuItem.Click
        Dim frm As New FrmWPIACerts
        With frm
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) = True Then
            Me.Text = String.Format("{0} ({1})", Me.Text, clsLang.rm.getString("MainRunAsAdmin"))
        End If
        Me.TslbCert.Text = ""

        Me.FileMenu.Text = clsLang.rm.getString("MainFile")
        Me.ExitToolStripMenuItem.Text = clsLang.rm.getString("MainQuit")
        Me.ViewMenu.Text = clsLang.rm.getString("MainView")
        Me.StatusBarToolStripMenuItem.Text = clsLang.rm.getString("MainStatusbar")
        Me.ZertifikateToolStripMenuItem.Text = clsLang.rm.getString("MainCertificates")
        Me.ImportWindowsToolStripMenuItem.Text = clsLang.rm.getString("MainImportWindows")
        Me.WPIARootzertifikateToolStripMenuItem.Text = clsLang.rm.getString("MainWPIARoot")
        Me.ToolsMenu.Text = clsLang.rm.getString("MainTools")
        Me.OptionsToolStripMenuItem.Text = clsLang.rm.getString("MainOptions")
        Me.WindowsMenu.Text = clsLang.rm.getString("MainWindow")
        Me.NewWindowToolStripMenuItem.Text = clsLang.rm.getString("MainNewWindow")
        Me.CascadeToolStripMenuItem.Text = clsLang.rm.getString("MainWindowsCascade")
        Me.TileVerticalToolStripMenuItem.Text = clsLang.rm.getString("MainWindowsVertical")
        Me.TileHorizontalToolStripMenuItem.Text = clsLang.rm.getString("MainWindowsHorizontal")
        Me.CloseAllToolStripMenuItem.Text = clsLang.rm.getString("MainWindowsCloseAll")
        Me.ArrangeIconsToolStripMenuItem.Text = clsLang.rm.getString("MainWindowsArrangeIcons")
        Me.HelpMenu.Text = clsLang.rm.getString("MainTools")
        Me.AboutToolStripMenuItem.Text = clsLang.rm.getString("MainAbout")

        Me.ToolStripStatusLabel.Text = clsLang.rm.getString("MainStatus")
    End Sub
End Class
