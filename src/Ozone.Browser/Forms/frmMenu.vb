﻿Public Class frmMenu

#Region "Methods"

    Public Sub SetWebControl(ByVal wc As Awesomium.Windows.Forms.WebControl)
        AddressBox1.WebControl = wc
    End Sub

    Public Function GetWebControl() As Awesomium.Windows.Forms.WebControl
        Return AddressBox1.WebControl
    End Function

    Public Sub UpdateMenu()
        If BookmarkManager.IsBookmarked(AddressBox1.URL.ToString) Then
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

#Region "frmMenu"

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class