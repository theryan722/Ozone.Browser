Public Class frmMenu

#Region "Methods"

    Public Sub SetWebControl(ByVal wc As Awesomium.Windows.Forms.WebControl)
        AddressBox1.WebControl = wc
    End Sub

    Public Function GetWebControl() As Awesomium.Windows.Forms.WebControl
        Return AddressBox1.WebControl
    End Function

    Public Sub UpdateMenu()
        If BookmarkManager.IsBookmark(AddressBox1.URL.ToString) Then
            btn_bookmark.BackgroundImage = My.Resources.bookmark_checked
        Else
            btn_bookmark.BackgroundImage = My.Resources.bookmark_unchecked
        End If
        btn_back.Enabled = AddressBox1.WebControl.CanGoBack
        btn_forward.Enabled = AddressBox1.WebControl.CanGoForward
        If AddressBox1.WebControl.IsLoading Then
            btn_refresh_stop.BackgroundImage = My.Resources._32_stop
        Else
            btn_refresh_stop.BackgroundImage = My.Resources._32_refresh
        End If
    End Sub

#End Region

#Region "Buttons"

    Private Sub btn_forward_Click(sender As Object, e As EventArgs) Handles btn_forward.Click

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click

    End Sub

    Private Sub btn_refresh_stop_Click(sender As Object, e As EventArgs) Handles btn_refresh_stop.Click

    End Sub

    Private Sub btn_bookmark_Click(sender As Object, e As EventArgs) Handles btn_bookmark.Click
        If BookmarkManager.IsBookmark(AddressBox1.URL.ToString) Then
            BookmarkManager.RemoveBookmark(AddressBox1.URL.ToString)
        Else
            BookmarkManager.AddBookmark(AddressBox1.URL.ToString)
        End If
        UpdateMenu()
    End Sub

#End Region

#Region "frmMenu"

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class