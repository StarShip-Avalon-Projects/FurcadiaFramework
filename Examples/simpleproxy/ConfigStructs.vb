Imports System.IO
Imports SimpleProxy2.ConfigStructs
Imports Furcadia.IO

Public Class ConfigStructs
#Region "Properties"

#End Region

#Region "Public Fields"

    Public Shared SetFile As String = pPath() & "/Settings.Ini"

#End Region

#Region "Public Methods"

    Public Shared Function mPath() As String
        mPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Simple Proxy")

        If Not Directory.Exists(mPath) Then

            Directory.CreateDirectory(mPath)
        End If
        Return mPath
    End Function

    Public Shared Function pPath() As String
        Return Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                                      "Furcadia Framework/Simple Proxy")
    End Function

#End Region

#Region "Public Classes"

    Public Class cBot

#Region "Public Fields"

        Public BotFile As String = ""

#End Region

#Region "Private Fields"

        Private Shared _IniFile As String

        Private _log As Boolean

        Private _logIdx As Integer

        Private _logNamebase As String = "Default"

        Private _logOption As Short

        Private _logPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\Silver Monkey\Logs"

        Private _lPort As Integer = 6700

#End Region

#Region "Public Constructors"

        Public Sub New()
            'do nothing for defaults
        End Sub

        Public Sub New(ByRef BFile As String)
            If File.Exists(BFile) Then BotIni.Load(BFile)
            BotFile = BFile
            Dim s As String = ""

            s = BotIni.GetKeyValue("Main", "Log")
            If Not String.IsNullOrEmpty(s) Then _log = Convert.ToBoolean(s)

            s = BotIni.GetKeyValue("Main", "LogOption")
            If Not String.IsNullOrEmpty(s) Then _logOption = Convert.ToInt16(s)

            s = BotIni.GetKeyValue("Main", "LogNameBase")
            If Not String.IsNullOrEmpty(s) Then _logNamebase = s

            s = BotIni.GetKeyValue("Main", "LogNamePath")
            If Not String.IsNullOrEmpty(s) Then _logPath = s

            s = BotIni.GetKeyValue("Bot", "BotIni")
            If Not String.IsNullOrEmpty(s) Then _IniFile = s

            s = BotIni.GetKeyValue("Bot", "LPort")
            If Not String.IsNullOrEmpty(s) Then _lPort = s.ToInteger

        End Sub

#End Region

#Region "Public Properties"

        Public Property IniFile() As String
            Get
                Return _IniFile
            End Get
            Set(ByVal value As String)
                _IniFile = value
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

        Public Property LogIdx As Integer
            Get
                Return _logIdx
            End Get
            Set(value As Integer)
                _logIdx = value
            End Set
        End Property

        Public Property LogNameBase As String
            Get
                Return _logNamebase
            End Get
            Set(value As String)
                _logNamebase = value
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

        Public Property LogPath As String
            Get
                Return _logPath
            End Get
            Set(value As String)
                _logPath = value
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

#End Region

#Region "Public Methods"

        Public Sub SaveBotSettings()
            BotIni.SetKeyValue("Main", "Log", _log.ToString)
            BotIni.SetKeyValue("Main", "LogNameBase", _logNamebase)
            BotIni.SetKeyValue("Main", "LogOption", _logOption.ToString)
            BotIni.SetKeyValue("Main", "LogNamePath", _logPath)
            BotIni.SetKeyValue("Bot", "BotIni", _IniFile)

            BotIni.Save(BotFile)
        End Sub

#End Region

    End Class

    Public Class cMain

#Region "Private Fields"

        Private Shared _AppFont As New Font(_FontFace, _FontSize, FontStyle.Regular)
        Private Shared _debug As Boolean = False
        Private Shared _defaultColor As Color = Color.Black
        Private Shared _emitColor As Color = Color.Blue
        Private Shared _emoteColor As Color = Color.DarkCyan
        Private Shared _FontFace As String = "Microsoft Sans Serif"
        'Display Settings
        Private Shared _FontSize As Integer = 10

        Private Shared _Host As String = ""
        'Logging Options
        Private Shared _log As Boolean = False

        Private Shared _logIdx As UInt32 = 0
        Private Shared _logNamebase As String = "Default"
        Private Shared _logOption As Short = 0
        Private Shared _logPath As String = mPath()
        Private Shared _LogType As String = "rtf"
        Private Shared _lPort As Integer = 0
        Private Shared _sayColor As Color = Color.DarkGoldenrod
        Private Shared _shoutColor As Color = Color.DarkRed
        Private Shared _sPort As Integer = 0
        Private Shared _StandAlone As Boolean = False
        Private Shared _TimeStamp As UShort = 0
        Private Shared _whColor As Color = Color.Purple

#End Region

#Region "Public Constructors"

        Public Sub New()
            System.IO.Directory.CreateDirectory(pPath())
            If File.Exists(SetFile) Then SettingsIni.Load(SetFile, True)

            Dim s As String = ""
            s = SettingsIni.GetKeyValue("Main", "Host")
            If Not String.IsNullOrEmpty(s) Then _Host = s.Trim

            s = SettingsIni.GetKeyValue("Main", "SPort")
            If Not String.IsNullOrEmpty(s) Then _sPort = s.ToInteger

            s = SettingsIni.GetKeyValue("Main", "Debug")
            If Not String.IsNullOrEmpty(s) Then _debug = Convert.ToBoolean(s)

            s = SettingsIni.GetKeyValue("Main", "TimeStamp")
            If Not String.IsNullOrEmpty(s) Then _TimeStamp = CUShort(Convert.ToInt16(s))

            s = SettingsIni.GetKeyValue("Main", "FontFace")
            If Not String.IsNullOrEmpty(s) Then _FontFace = s
            s = SettingsIni.GetKeyValue("Main", "FontSize")
            If Not String.IsNullOrEmpty(s) Then _FontSize = s.ToInteger
            _AppFont = New Font(_FontFace, _FontSize)

            s = SettingsIni.GetKeyValue("Main", "EmitColor")
            If Not String.IsNullOrEmpty(s) Then _emitColor = ColorTranslator.FromHtml(s)

            s = SettingsIni.GetKeyValue("Main", "SayColor")
            If Not String.IsNullOrEmpty(s) Then _sayColor = ColorTranslator.FromHtml(s)

            s = SettingsIni.GetKeyValue("Main", "ShoutColor")
            If Not String.IsNullOrEmpty(s) Then _shoutColor = ColorTranslator.FromHtml(s)

            s = SettingsIni.GetKeyValue("Main", "WhColor")
            If Not String.IsNullOrEmpty(s) Then _whColor = ColorTranslator.FromHtml(s)

            s = SettingsIni.GetKeyValue("Main", "DefaultColor")
            If Not String.IsNullOrEmpty(s) Then _defaultColor = ColorTranslator.FromHtml(s)

            s = SettingsIni.GetKeyValue("Main", "EmoteColor")
            If Not String.IsNullOrEmpty(s) Then _emoteColor = ColorTranslator.FromHtml(s)

        End Sub

#End Region

#Region "Public Properties"

        Public Property ApFont As Font
            Get
                Return _AppFont
            End Get
            Set(value As Font)
                _AppFont = value
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

        Public Property DefaultColor() As Color
            Get
                Return _defaultColor
            End Get
            Set(ByVal value As Color)
                _defaultColor = value
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
        Public Property EmoteColor() As Color
            Get
                Return _emoteColor
            End Get
            Set(ByVal value As Color)
                _emoteColor = value
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

        Public Property log() As Boolean
            Get
                Return _log
            End Get
            Set(ByVal value As Boolean)
                _log = value
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
        Public Property sPort() As Integer
            Get
                Return _sPort
            End Get
            Set(ByVal value As Integer)
                _sPort = value
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

        Public Property WhColor() As Color
            Get
                Return _whColor
            End Get
            Set(ByVal value As Color)
                _whColor = value
            End Set
        End Property

#End Region

#Region "Public Methods"

        Public Sub SaveMainSettings()
            SettingsIni.SetKeyValue("Main", "Host", _Host)
            '_reconnectMax
            SettingsIni.SetKeyValue("Main", "SPort", _sPort.ToString)
            SettingsIni.SetKeyValue("Main", "Debug", _debug.ToString)
            SettingsIni.SetKeyValue("Main", "TimeStamp", _TimeStamp.ToString)
            SettingsIni.SetKeyValue("Main", "FontFace", ApFont.Name)
            SettingsIni.SetKeyValue("Main", "FontSize", ApFont.Size.ToString)
            SettingsIni.SetKeyValue("Main", "EmitColor", ColorTranslator.ToHtml(_emitColor).ToString)
            SettingsIni.SetKeyValue("Main", "SayColor", ColorTranslator.ToHtml(_sayColor).ToString)
            SettingsIni.SetKeyValue("Main", "ShoutColor", ColorTranslator.ToHtml(_shoutColor).ToString)
            SettingsIni.SetKeyValue("Main", "WhColor", ColorTranslator.ToHtml(_whColor).ToString)
            SettingsIni.SetKeyValue("Main", "DefaultColor", ColorTranslator.ToHtml(_defaultColor).ToString)
            SettingsIni.SetKeyValue("Main", "EmoteColor", ColorTranslator.ToHtml(_emoteColor).ToString)

            SettingsIni.Save(SetFile)
        End Sub

        Public Sub SetDefault()
            _debug = False
            _TimeStamp = 0
        End Sub

#End Region

    End Class

#End Region

End Class