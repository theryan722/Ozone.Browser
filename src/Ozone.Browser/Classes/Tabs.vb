Imports MetroFramework
Imports WeifenLuo.WinFormsUI.Docking

Public Class Tabs

#Region "Browser"

    Public Shared Sub AddBrowser()
        Dim newtab As New Tab_Browser
        newtab.Show(frmManager.DockPanel1, DockState.Document)
        frmManager.SetActiveForm(newtab)
    End Sub

#End Region

    Public Shared Sub AddBookmarks()
        Dim newtab As New Tab_Bookmarks
        newtab.Show(frmManager.DockPanel1, DockState.Document)
        frmManager.SetActiveForm(newtab)
    End Sub

    Public Shared Sub AddExtensions()
        Dim newtab As New Tab_Extensions
        newtab.Show(frmManager.DockPanel1, DockState.Document)
        frmManager.SetActiveForm(newtab)
    End Sub

    Public Shared Sub AddHelp()
        Dim newtab As New Tab_Help
        newtab.Show(frmManager.DockPanel1, DockState.Document)
        frmManager.SetActiveForm(newtab)
    End Sub

    Public Shared Sub AddThemes()
        Dim newtab As New Tab_Themes
        newtab.Show(frmManager.DockPanel1, DockState.Document)
        frmManager.SetActiveForm(newtab)
    End Sub

    Public Shared Sub AddOptions()
        Dim newtab As New Tab_Options
        newtab.Show(frmManager.DockPanel1, DockState.Document)
        frmManager.SetActiveForm(newtab)
    End Sub

End Class

