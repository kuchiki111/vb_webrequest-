Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Public Class Class1

    Public Shared Sub Main()
        Dim url As String = "http://www.kuchiki111.com:8080/ssh_war/UserDelete?"

        Dim id As String = "id=18"

        url = url & id

        '创建url请求并设定凭据
        Dim request As WebRequest = WebRequest.Create(url)
        request.Credentials = CredentialCache.DefaultCredentials

        '获取服务器响应
        Dim response As WebResponse = request.GetResponse()
        '显示状态
        'Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)

        '获取服务器返回的流并使用StreamReader打开
        Dim dataStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)

        '读取内容并打印
        Dim responseString As String = reader.ReadToEnd()
        Console.WriteLine(responseString)

        'Return responseString

        '关闭StreamReader和WebResponse
        reader.Close()
        response.Close()
    End Sub
End Class