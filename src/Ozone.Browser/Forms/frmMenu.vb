Imports System.Drawing.Imaging
Imports System.IO

Public Class frmMenu

#Region "Methods"

    Public Function AreSameImage(ByVal I1 As Image, ByVal I2 As Image) As Boolean
        Dim MS1 As New MemoryStream
        Dim MS2 As New MemoryStream
        I1.Save(MS1, ImageFormat.Bmp)
        I2.Save(MS2, ImageFormat.Bmp)
        For I As Integer = 0 To CInt(MS1.Length) - 1
            If MS1.ReadByte() <> MS2.ReadByte Then Return False
        Next
        Return True
    End Function

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
        If AddressBox1.WebControl.CanGoForward Then
            AddressBox1.WebControl.GoForward()
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        If AddressBox1.WebControl.CanGoBack Then
            AddressBox1.WebControl.GoBack()
        End If
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        Dim newb As New frmMenuExtended
        Dim p As Point = Cursor.Position
        p.Offset(-frmMenuExtended.Width \ 2, -frmMenuExtended.Height \ 2)
        frmMenuExtended.Location = p
        frmMenuExtended.Show()
    End Sub

    Private Sub btn_refresh_stop_Click(sender As Object, e As EventArgs) Handles btn_refresh_stop.Click
        If AreSameImage(My.Resources._32_refresh, btn_refresh_stop.BackgroundImage) Then
            AddressBox1.WebControl.Reload(My.Computer.Keyboard.ShiftKeyDown)
        Else
            AddressBox1.WebControl.Stop()
        End If
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