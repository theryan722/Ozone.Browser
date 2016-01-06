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

#End Region

#Region "frmManager"

    Private Sub frmManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Manager.InitializeBrowser()
    End Sub

#End Region

End Class
