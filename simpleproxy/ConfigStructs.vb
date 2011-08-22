Imports System.IO
Imports SimpleProxy2.IniMod
Imports SimpleProxy2.ConfigStructs
Imports Furcadia.IO

Public Class ConfigStructs
#Region "Properties"


#End Region

    Public Shared Function pPath() As String
        Return Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                                      "Furcadia Framework/Simple Proxy")
    End Function
    Public Shared SetFile As String = pPath() & "/Settings.Ini"


    Public Structure cMain

        Private Shared MyIni As New IniMod

        Private Shared _lPort As Integer = 0
        Private Shared _sPort As Integer = 0
        Private Shared _Host As String = ""
        Private Shared _StandAlone As Boolean = False
        Private Shared _log As Boolean = False
        Private Shared _debug As Boolean = False
        Private Shared _TimeStamp As UShort = 0



        Public Property lPort() As Integer
            Get
                Return _lPort
            End Get
            Set(ByVal value As Integer)
                _lPort = value
            End Set
        End Property

        Public Property sPort() As Integer
            Get
                Return _sPort
            End Get
            Set(ByVal value As Integer)
                _sPort = value
            End Set
        End Property


        Public Property Host() As String
            Get
                Return _Host
            End Get
            Set(ByVal value As String)
                _Host = value
            End Set
        End Property

        Public Property StandAlone() As Boolean
            Get
                Return _StandAlone
            End Get
            Set(ByVal value As Boolean)
                _StandAlone = value
            End Set
        End Property

        Public Property log() As Boolean
            Get
                Return _log
            End Get
            Set(ByVal value As Boolean)
                _log = value
            End Set
        End Property
        Public Property debug() As Boolean
            Get
                Return _debug
            End Get
            Set(ByVal value As Boolean)
                _debug = value
            End Set
        End Property

        'Time Stamp mode
        ' 0 = off
        ' 1 = time
        ' 2 = Date Time
        Public Property TimeStamp() As UShort
            Get
                Return _TimeStamp
            End Get
            Set(ByVal value As UShort)
                _TimeStamp = value
            End Set
        End Property

        Public Sub SetDefault()
            _debug = False
            _TimeStamp = 0
        End Sub
        Public Sub LoadMainSettings()
            System.IO.Directory.CreateDirectory(pPath())
            If MyIni.IniRead(SetFile, "Main", "Host") <> "" Then
                _Host = MyIni.IniRead(SetFile, "Main", "Host")
            Else
                _Host = "lightbringer.furcadia.com"
            End If
                If MyIni.IniRead(SetFile, "Main", "SPort") <> "" Then
                    _sPort = Convert.ToInt32(MyIni.IniRead(SetFile, "Main", "SPort"))
                Else
                    _sPort = 6500
                End If
                If MyIni.IniRead(SetFile, "Main", "LPort") <> "" Then
                    _lPort = Convert.ToInt32(MyIni.IniRead(SetFile, "Main", "LPort"))
                Else
                    _lPort = 6700
                End If
                If MyIni.IniRead(SetFile, "Main", "StandAlone") <> "" Then
                    _StandAlone = Convert.ToBoolean(MyIni.IniRead(SetFile, "Main", "StandAlone"))
                Else
                    _StandAlone = False
                End If

                If MyIni.IniRead(SetFile, "Main", "Log") <> "" Then
                    _log = Convert.ToBoolean(MyIni.IniRead(SetFile, "Main", "Log"))
                Else
                    _log = False
                End If
                If MyIni.IniRead(SetFile, "Main", "Debug") <> "" Then
                    _debug = Convert.ToBoolean(MyIni.IniRead(SetFile, "Main", "Debug"))
                Else
                    _debug = False
                End If

                If MyIni.IniRead(SetFile, "Main", "TimeStamp") <> "" Then
                    _TimeStamp = Convert.ToUInt16(MyIni.IniRead(SetFile, "Main", "TimeStamp"))
                Else
                    _TimeStamp = 0
                End If

        End Sub
        Public Sub SaveMainSettings()
            MyIni.IniWrite(SetFile, "Main", "Host", _Host)
            MyIni.IniWrite(SetFile, "Main", "SPort", _sPort.ToString)
            MyIni.IniWrite(SetFile, "Main", "LPort", _lPort.ToString)
            MyIni.IniWrite(SetFile, "Main", "StandAlone", _StandAlone.ToString)
            MyIni.IniWrite(SetFile, "Main", "Debug", _debug.ToString)
            MyIni.IniWrite(SetFile, "Main", "Log", _log.ToString)
            MyIni.IniWrite(SetFile, "Main", "TimeStamp", _TimeStamp.ToString)

        End Sub

    End Structure

    Public Structure cBot
        Private Shared MyIni As New IniMod
        Private Shared _IniFile As String

        Public Property IniFile() As String
            Get
                Return _IniFile
            End Get
            Set(ByVal value As String)
                _IniFile = value
            End Set
        End Property

        Public Sub LoadBotSettings()
            If MyIni.IniRead(SetFile, "Bot", "BotIni") <> "" Then
                _IniFile = MyIni.IniRead(SetFile, "Bot", "BotIni")
            Else
                _IniFile = "-pick"
            End If
        End Sub

        Public Sub SaveBotSettings()
            MyIni.IniWrite(SetFile, "Bot", "BotIni", _IniFile)
        End Sub
    End Structure

End Class
