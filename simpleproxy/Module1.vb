Imports SimpleProxy2.IniFile
Imports SimpleProxy2.ConfigStructs

Module Module1
    Public FurcPath As Furcadia.IO.Paths

    Public SettingsIni As New IniFile
    Public BotIni As New IniFile
    Public cMain As cMain
    Public cBot As cBot
    Public callbk As Main
    <System.Runtime.CompilerServices.Extension()> _
    Public Function IsInteger(ByVal value As String) As Boolean
        If String.IsNullOrEmpty(value) Then
            Return False
        Else
            Return Integer.TryParse(value, Nothing)
        End If
    End Function

    <System.Runtime.CompilerServices.Extension()> _
    Public Function ToInteger(ByVal value As String) As Integer
        If value.IsInteger() Then
            Return Integer.Parse(value)
        Else
            Return 0
        End If
    End Function
End Module
