Public Class frmMenu

#Region "Methods"

    Public Sub SetWebControl(ByVal wc As Awesomium.Windows.Forms.WebControl)
        AddressBox1.WebControl = wc
    End Sub

    Public Function GetWebControl() As Awesomium.Windows.Forms.WebControl
        Return AddressBox1.WebControl
    End Function

#End Region

#Region "frmMenu"

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class