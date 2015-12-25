Public Class Locator

    Public Shared Function GetAppPath() As String
        Dim i As Integer
        Dim strAppPath As String
        strAppPath = System.Reflection.Assembly.GetExecutingAssembly.Location()
        i = strAppPath.Length - 1
        Do Until strAppPath.Substring(i, 1) = "\"
            i = i - 1
        Loop
        strAppPath = strAppPath.Substring(0, i)
        Return strAppPath
    End Function

End Class
