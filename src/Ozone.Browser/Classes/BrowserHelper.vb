Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Net

Public Class BrowserHelper

    Public Shared Function FixUrl(ByVal url As String, Optional forcehttps As Boolean = False)
        Dim ret As String = ""
        If url.StartsWith("http://") Or url.StartsWith("https://") Then
            ret = url
        Else
            ret = If(forcehttps, "https://", "http://")
        End If
        Return ret
    End Function

    Public Shared Function GetFavicon(longUrl As String) As Image
        Dim url = New Uri(longUrl)
        Try
            If url.HostNameType = UriHostNameType.Dns Then
                Dim iconUrl As Object = "http://" + url.Host + "/favicon.ico"
                Dim request As WebRequest = HttpWebRequest.Create(iconUrl)
                Dim response = DirectCast(request.GetResponse(), HttpWebResponse)
                Dim stream As Stream = response.GetResponseStream()
                If stream IsNot Nothing Then
                    Dim rawfavicon As Object = Image.FromStream(stream)
                    Application.DoEvents()
                    Const width As Integer = 15
                    Const height As Integer = 15
                    Dim favicon = New Bitmap(width, height)
                    Dim g As Graphics = Graphics.FromImage(favicon)
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic
                    g.DrawImage(rawfavicon, New Rectangle(0, 0, width, height), New Rectangle(0, 0, rawfavicon.Width, rawfavicon.Height), GraphicsUnit.Pixel)
                    g.Dispose()
                    rawfavicon.Dispose()
                    stream.Dispose()
                    Return favicon
                End If
            End If
        Catch generatedExceptionName As Exception
            Return My.Resources.blanktab
        End Try
        Return My.Resources.blanktab
    End Function

End Class
