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
    Public Shared Function mPath() As String
        mPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Simple Proxy")

        If Not Directory.Exists(mPath) Then

            Directory.CreateDirectory(mPath)
        End If
        Return mPath
    End Function

   


    Public Structure cMain

        Private Shared MyIni As New IniMod

        Private Shared _lPort As Integer = 0
        Private Shared _sPort As Integer = 0
        Private Shared _Host As String = ""
        Private Shared _StandAlone As Boolean = False

        'Logging Options
        Private Shared _log As Boolean = False
        Private Shared _LogType As String = "rtf"
        Private Shared _logNamebase As String = "Default"
        Private Shared _logPath As String = mPath()
        Private Shared _logOption As Short = 0
        Private Shared _logIdx As UInt32 = 0

        Private Shared _debug As Boolean = False
        Private Shared _TimeStamp As UShort = 0

        'Display Settings
        Private Shared _FontSize As Integer = 10
        Private Shared _FontFace As String = "Microsoft Sans Serif"
        Private Shared _AppFont As New Font(_FontFace, _FontSize, FontStyle.Regular)

        Private Shared _emitColor As Color = Color.Blue
        Private Shared _sayColor As Color = Color.DarkGoldenrod
        Private Shared _shoutColor As Color = Color.DarkRed
        Private Shared _whColor As Color = Color.Purple
        Private Shared _defaultColor As Color = Color.Black
        Private Shared _emoteColor As Color = Color.DarkCyan

        Public Property LogNameBase As String
            Get
                Return _logNamebase
            End Get
            Set(value As String)
                _logNamebase = value
            End Set
        End Property
        Public Property LogPath As String
            Get
                Return _logPath
            End Get
            Set(value As String)
                _logPath = value
            End Set
        End Property
        Public Property LogOption As Short
            Get
                Return _logOption
            End Get
            Set(value As Short)
                _logOption = value
            End Set
        End Property
        Public Property LogIdx As UInt32
            Get
                If MyIni.IniRead(SetFile, "Main", "LogIdx") <> "" Then
                    _logIdx = Convert.ToUInt32(MyIni.IniRead(SetFile, "Main", "LogIdx"))
                End If
                Return _logIdx
            End Get
            Set(value As UInt32)
                _logIdx = value
                MyIni.IniWrite(SetFile, "Main", "LogType", _logIdx.ToString)

            End Set
        End Property

        Public Property LogType As String
            Get
                Return _LogType
            End Get
            Set(value As String)
                _LogType = value
            End Set
        End Property

        Public Property ApFont As Font
            Get
                Return _AppFont
            End Get
            Set(value As Font)
                _AppFont = value
            End Set
        End Property


        Public Property EmitColor() As Color
            Get
                Return _emitColor
            End Get
            Set(ByVal value As Color)
                _emitColor = value
            End Set
        End Property
        Public Property SayColor() As Color
            Get
                Return _sayColor
            End Get
            Set(ByVal value As Color)
                _sayColor = value
            End Set
        End Property
        Public Property ShoutColor() As Color
            Get
                Return _shoutColor
            End Get
            Set(ByVal value As Color)
                _shoutColor = value
            End Set
        End Property
        Public Property WhColor() As Color
            Get
                Return _whColor
            End Get
            Set(ByVal value As Color)
                _whColor = value
            End Set
        End Property
        Public Property DefaultColor() As Color
            Get
                Return _defaultColor
            End Get
            Set(ByVal value As Color)
                _defaultColor = value
            End Set
        End Property
        Public Property EmoteColor() As Color
            Get
                Return _emoteColor
            End Get
            Set(ByVal value As Color)
                _emoteColor = value
            End Set
        End Property

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
            End If
            If MyIni.IniRead(SetFile, "Main", "LogOption") <> "" Then
                _logOption = Convert.ToUInt16(MyIni.IniRead(SetFile, "Main", "LogOption"))
            End If
            If MyIni.IniRead(SetFile, "Main", "LogNameBase") <> "" Then
                _logNamebase = MyIni.IniRead(SetFile, "Main", "LogNameBase")
            End If
            If MyIni.IniRead(SetFile, "Main", "LogNamePath") <> "" Then
                _logNamebase = MyIni.IniRead(SetFile, "Main", "LogNamePath")
            End If
            If MyIni.IniRead(SetFile, "Main", "Debug") <> "" Then
                _debug = Convert.ToBoolean(MyIni.IniRead(SetFile, "Main", "Debug"))
            Else
                _debug = False
            End If
            If MyIni.IniRead(SetFile, "Main", "TimeStamp") <> "" Then
                _TimeStamp = Convert.ToInt16(MyIni.IniRead(SetFile, "Main", "TimeStamp"))
            Else
                _TimeStamp = 0
            End If
            If MyIni.IniRead(SetFile, "Main", "FontFace") <> "" Then
                _FontFace = MyIni.IniRead(SetFile, "Main", "FontFace")
            End If
            If MyIni.IniRead(SetFile, "Main", "FontSize") <> "" Then
                _FontSize = Convert.ToUInt32(MyIni.IniRead(SetFile, "Main", "FontSize"))
            End If
            If MyIni.IniRead(SetFile, "Main", "FontSize") <> "" OrElse MyIni.IniRead(SetFile, "Main", "FontFace") <> "" Then
                _AppFont = New Font(_FontFace, _FontSize)
            End If
            If MyIni.IniRead(SetFile, "Main", "EmitColor") <> "" Then
                _emitColor = ColorTranslator.FromHtml(MyIni.IniRead(SetFile, "Main", "EmitColor"))
            End If
            If MyIni.IniRead(SetFile, "Main", "SayColor") <> "" Then
                _sayColor = ColorTranslator.FromHtml(MyIni.IniRead(SetFile, "Main", "SayColor"))
            End If
            If MyIni.IniRead(SetFile, "Main", "ShoutColor") <> "" Then
                _shoutColor = ColorTranslator.FromHtml(MyIni.IniRead(SetFile, "Main", "ShoutColor"))
            End If
            If MyIni.IniRead(SetFile, "Main", "WhColor") <> "" Then
                _whColor = ColorTranslator.FromHtml(MyIni.IniRead(SetFile, "Main", "WhColor"))
            End If
            If MyIni.IniRead(SetFile, "Main", "DefaultColor") <> "" Then
                _defaultColor = ColorTranslator.FromHtml(MyIni.IniRead(SetFile, "Main", "DefaultColor"))
            End If
            If MyIni.IniRead(SetFile, "Main", "EmoteColor") <> "" Then
                _emoteColor = ColorTranslator.FromHtml(MyIni.IniRead(SetFile, "Main", "EmoteColor"))
            End If
            If MyIni.IniRead(SetFile, "Main", "LogType") <> "" Then
                _LogType = MyIni.IniRead(SetFile, "Main", "LogType")
            End If
        End Sub
        Public Sub SaveMainSettings()
            MyIni.IniWrite(SetFile, "Main", "Host", _Host)
            MyIni.IniWrite(SetFile, "Main", "SPort", _sPort.ToString)
            MyIni.IniWrite(SetFile, "Main", "LPort", _lPort.ToString)
            MyIni.IniWrite(SetFile, "Main", "StandAlone", _StandAlone.ToString)
            MyIni.IniWrite(SetFile, "Main", "Debug", _debug.ToString)
            MyIni.IniWrite(SetFile, "Main", "Log", _log.ToString)
            MyIni.IniWrite(SetFile, "Main", "LogType", _LogType)
            MyIni.IniWrite(SetFile, "Main", "LogNameBase", _logNamebase)
            MyIni.IniWrite(SetFile, "Main", "LogPath", _logPath)
            MyIni.IniWrite(SetFile, "Main", "LogOption", _logOption.ToString)
            MyIni.IniWrite(SetFile, "Main", "TimeStamp", _TimeStamp.ToString)
            MyIni.IniWrite(SetFile, "Main", "FontFace", ApFont.Name)
            MyIni.IniWrite(SetFile, "Main", "FontSize", ApFont.Size.ToString)
            MyIni.IniWrite(SetFile, "Main", "EmitColor", ColorTranslator.ToHtml(_emitColor).ToString)
            MyIni.IniWrite(SetFile, "Main", "SayColor", ColorTranslator.ToHtml(_sayColor).ToString)
            MyIni.IniWrite(SetFile, "Main", "ShoutColor", ColorTranslator.ToHtml(_shoutColor).ToString)
            MyIni.IniWrite(SetFile, "Main", "WhColor", ColorTranslator.ToHtml(_whColor).ToString)
            MyIni.IniWrite(SetFile, "Main", "DefaultColor", ColorTranslator.ToHtml(_defaultColor).ToString)
            MyIni.IniWrite(SetFile, "Main", "EmoteColor", ColorTranslator.ToHtml(_emoteColor).ToString)
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
