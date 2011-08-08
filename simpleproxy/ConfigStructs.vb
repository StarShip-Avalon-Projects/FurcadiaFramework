
Imports System.IO

Public Class ConfigStructs

    Public Structure cMain
        Public Shared lPort As Integer = 6700
        Public Shared sPort As Integer = 6500
        Public Shared Host As String = "lightbringer.furcadia.com"

    End Structure

    Public Structure cBot
        Public Shared IniFile As String = "-pick"

    End Structure

    Public Function pPath() As String
        Return Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                                      "Furcadia Framework/Simple Proxy")
    End Function

End Class
