Option Strict On
Imports System.IO
Imports System.Diagnostics
Imports Nini.Config

Public Class IniMod
    'Requires Nini.dll

    Private source As IniConfigSource

    Public Function IniRead(ByVal iniFile As String, ByVal sect As String, ByVal key As String, Optional ByVal def As String = "") As String
        Dim ret As String
        If File.Exists(iniFile) = False Then
            Return def
        End If
        Try
            source = New IniConfigSource(iniFile)
            ret = source.Configs(sect).Get(key)
            If ret = "" Then

                Return def
            Else
                Return ret
            End If
        Catch
            Return def
        End Try

    End Function

    Public Sub IniWrite(ByVal iniFile As String, ByVal sect As String, ByVal key As String, ByVal data As String)
        If File.Exists(iniFile) = False Then
            File.Create(iniFile).Dispose()
        End If
        source = New IniConfigSource(iniFile)
        Try
            source.AddConfig(sect)
            source.Configs(sect).Set(key, data)
        Catch
            source.Configs(sect).Set(key, data)
        End Try
        source.Save()
    End Sub

End Class
