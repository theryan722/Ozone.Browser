Public Class frmManager

#Region "Methods"

    Public Sub SetActiveForm(ByVal doc As XDockContent)
        doc.Activate()
    End Sub

#End Region

#Region "pnl_extendedmenu"

    Private Sub pnl_menuextended_LostFocus(sender As Object, e As EventArgs) Handles pnl_menuextended.LostFocus
        pnl_menuextended.Hide()
    End Sub

    Private Sub btn_newtab_Click(sender As Object, e As EventArgs) Handles btn_newtab.Click
        Tabs.AddBrowser()
    End Sub

    Private Sub btn_newprivatetab_Click(sender As Object, e As EventArgs) Handles btn_newprivatetab.Click

    End Sub

    Private Sub btn_newwindow_Click(sender As Object, e As EventArgs) Handles btn_newwindow.Click

    End Sub

    Private Sub btn_downloads_Click(sender As Object, e As EventArgs) Handles btn_downloads.Click
        Tabs.AddDownloads()
    End Sub

    Private Sub btn_bookmarks_Click(sender As Object, e As EventArgs) Handles btn_bookmarks.Click

    End Sub

    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click

    End Sub

    Private Sub btn_extensions_Click(sender As Object, e As EventArgs) Handles btn_extensions.Click
        Tabs.AddExtensions()
    End Sub

    Private Sub btn_cut_Click(sender As Object, e As EventArgs) Handles btn_cut.Click

    End Sub

    Private Sub btn_copy_Click(sender As Object, e As EventArgs) Handles btn_copy.Click

    End Sub

    Private Sub btn_paste_Click(sender As Object, e As EventArgs) Handles btn_paste.Click

    End Sub

    Private Sub trackbar_zoom_Scroll(sender As Object, e As EventArgs) Handles trackbar_zoom.Scroll

    End Sub

    Private Sub btn_resetzoom_Click(sender As Object, e As EventArgs) Handles btn_resetzoom.Click

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

    End Sub

    Private Sub btn_find_Click(sender As Object, e As EventArgs) Handles btn_find.Click

    End Sub

    Private Sub btn_more_Click(sender As Object, e As EventArgs) Handles btn_more.Click

    End Sub

    Private Sub btn_help_Click(sender As Object, e As EventArgs) Handles btn_help.Click
        Tabs.AddHelp()
    End Sub

    Private Sub btn_options_Click(sender As Object, e As EventArgs) Handles btn_options.Click
        Tabs.AddOptions()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Manager.ShutdownBrowser()
    End Sub

#End Region

#Region "frmManager"

    Private Sub frmManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Manager.InitializeBrowser()
    End Sub

#End Region

End Class
