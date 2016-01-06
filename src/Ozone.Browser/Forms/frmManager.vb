Imports System.Drawing.Imaging
Imports System.IO

Public Class frmManager

#Region "Methods"

    Public Sub SetActiveForm(ByVal doc As XDockContent)
        doc.Activate()
    End Sub

#End Region

#Region "frmManager"

    Private Sub frmManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Manager.InitializeBrowser()
    End Sub

#End Region

End Class
