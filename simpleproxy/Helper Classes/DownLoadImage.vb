Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net

Public Class DownloadImage
    Private imageUrl As String
    Private bitmap As Bitmap
    Public Sub New(ByVal imageUrl As String)
        Me.imageUrl = imageUrl
    End Sub
    Public Sub Download()
        Try
            Dim client As New WebClient()
            Dim stream As Stream = client.OpenRead(imageUrl)
            bitmap = New Bitmap(stream)
            stream.Flush()
            stream.Close()
        Catch e As Exception
            Console.WriteLine(e.Message)
        End Try
    End Sub
    Public Function GetImage() As Bitmap
        Return bitmap
    End Function
    Public Sub SaveImage(ByVal filename As String, ByVal format As ImageFormat)
        If bitmap IsNot Nothing Then
            bitmap.Save(filename, format)
        End If
    End Sub
End Class
