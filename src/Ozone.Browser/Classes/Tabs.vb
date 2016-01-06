Imports MetroFramework
Imports WeifenLuo.WinFormsUI.Docking

Public Class Tabs

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
