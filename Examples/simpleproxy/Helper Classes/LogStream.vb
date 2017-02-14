Imports System.Text.RegularExpressions

Public Class LogStream

    Private Const Iconfilter As String = "<img src='fsh://system.fsh:([^']*)'(.*?)/>"
    Private Const NameFilter As String = "<name shortname='([^']*)' ?(.*?)?>([\x21-\x3B\=\x3F-\x7E]+)</name>"
    Private Const URLFILTER As String = "<a href='?""?(.*?)'?""?>(.*?)</a>"
    Private Const IMGFILTER As String = "<img src='?""?(.*?)'?""? ?/?>"
#Region "logging functions"
    Dim strErrorFilePath As String
    Dim Stack As New ArrayList
    Public Sub New(FileName As String, FilePath As String)

        strErrorFilePath = FilePath & "\" & FileName & ".log"
        System.IO.Directory.CreateDirectory(FilePath)

    End Sub
    Public Function IsFileInUse(ByVal filePath As String) As Boolean
        Try
            Dim contents() As String = IO.File.ReadAllLines(filePath)
        Catch ex As IO.IOException
            Return (ex.Message.StartsWith("The process cannot access the file") AndAlso _
                    ex.Message.EndsWith("because it is being used by another process."))
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Public Sub Writeline(Message As String)
        Dim build As New System.Text.StringBuilder(Message)
        Dim Names As MatchCollection = Regex.Matches(Message, NameFilter)
        For Each Name As Match In Names
            build = build.Replace(Name.ToString, Name.Groups(3).Value)
        Next
        '<name shortname='acuara' forced>
        Dim MyIcon As MatchCollection = Regex.Matches(Message, Iconfilter)

        For Each Icon As Match In MyIcon
            Select Case Icon.Groups(1).Value
                Case "91"
                    build = build.Replace(Icon.ToString, "[#]")
                Case Else
                    build = build.Replace(Icon.ToString, "[" + Icon.Groups(1).Value + "]")
            End Select

        Next

        Dim URLS As MatchCollection = Regex.Matches(Message, URLFILTER)
        For Each URL As Match In URLS
            build = build.Replace(URL.ToString, "URL:" + URL.Groups(2).Value + "(" + URL.Groups(1).Value + ")")
        Next
        Dim IMGS As MatchCollection = Regex.Matches(Message, IMGFILTER)
        For Each IMG As Match In IMGS
            build = build.Replace(IMG.ToString, "img")
        Next
        Message = build.ToString

        Dim Now As String = Date.Now().ToString("MM/dd/yyyy H:mm:ss")
        Message = Now & ": " & Message
        Dim ioFile As System.IO.StreamWriter = Nothing
        Try

            ioFile = New System.IO.StreamWriter(strErrorFilePath, True)
            For Each line As String In Stack.ToArray
                ioFile.WriteLine(line)
            Next
            Stack.Clear()
            ioFile.WriteLine(Message)

            ioFile.Close()
        Catch ex As IO.IOException
            If (ex.Message.StartsWith("The process cannot access the file") AndAlso _
                    ex.Message.EndsWith("because it is being used by another process.")) Then
                Stack.Add(Message)
            End If

        Catch exLog As Exception
            If Not IsNothing(ioFile) Then
                ioFile.Close()
            End If
        End Try
    End Sub



#End Region
End Class
