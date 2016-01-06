Imports System.Drawing.Imaging
Imports System.IO

Public Class frmManager

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
