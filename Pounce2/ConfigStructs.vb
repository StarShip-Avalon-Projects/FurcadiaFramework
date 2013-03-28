Imports System.IO
Imports Pounce2.IniMod
Imports Pounce2.ConfigStructs
Imports Furcadia.IO

Public Class ConfigStructs
#Region "Properties"


#End Region

    Public Shared Function pPath() As String
        Return Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                                      "Furcadia Framework/Pounce2")
    End Function
    Public Shared SetFile As String = pPath() & "/Settings.Ini"
    Public Shared Function mPath() As String
        mPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Silver Monkey")

        If Not Directory.Exists(mPath) Then

            Directory.CreateDirectory(mPath)
        End If
        Return mPath
    End Function

    Private Shared _BotName As String = ""

    'Public Shared Property BotFile As String
    '    Get
    '        Return pPath() & "/" & _BotName
    '    End Get
    '    Set(value As String)
    '        _BotName = value
    '    End Set
    'End Property
    ''Public Shared BotFile As String = pPath() & "/" & BotName & ".ini"




    Public Structure cMain

        Private Shared MyIni As New IniMod


        Private Shared _sPort As Integer = 0

        Private Shared _Host As String = ""
        Private Shared _StandAlone As Boolean = False
        Private Shared _CloseProc As Boolean = False
        Private Shared _reconnectMax As Integer = 0
        'Logging Options
        Private Shared _log As Boolean = False
        Private Shared _LogType As String = "rtf"
        Private Shared _logNamebase As String = "Default"
        Private Shared _logPath As String = mPath()
        Private Shared _logOption As Short = 0
        Private Shared _logIdx As UInt32 = 0

        Private Shared _debug As Boolean = False
        Private Shared _TimeStamp As UShort = 0
        Private Shared _AutoReconnect As Boolean = False

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

        'systray Status
        Private Shared _TrayIcon As CheckState = CheckState.Indeterminate
        Public Property AutoReconnect As Boolean
            Get
                Return _AutoReconnect
            End Get
            Set(value As Boolean)
                _AutoReconnect = value
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
        Public Property CloseProc As Boolean
            Get
                Return _CloseProc
            End Get
            Set(value As Boolean)
                _CloseProc = value
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


        Public Property ReconnectMax() As Integer
            Get
                Return _reconnectMax
            End Get
            Set(ByVal value As Integer)
                _reconnectMax = value
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

        'systray Status
        Public Property SysTray As CheckState
            Get
                Return _TrayIcon
            End Get
            Set(value As CheckState)
                _TrayIcon = value
            End Set
        End Property

        Public Sub SetDefault()
            _debug = False
            _TimeStamp = 0
        End Sub


        Public Sub LoadMainSettings()
            System.IO.Directory.CreateDirectory(pPath())
            Try
                _Host = MyIni.IniRead(SetFile, "Main", "Host")
            Catch
                _Host = "lightbringer.Furcadia.com"
            End Try
            Try
                _sPort = Convert.ToInt32(MyIni.IniRead(SetFile, "Main", "SPort"))
            Catch
                _sPort = 6500
            End Try
            If MyIni.IniRead(SetFile, "Main", "StandAlone") <> "" Then
                _StandAlone = Convert.ToBoolean(MyIni.IniRead(SetFile, "Main", "StandAlone"))
            Else
                _StandAlone = False
            End If

            If MyIni.IniRead(SetFile, "Main", "Time Out") <> "" Then
                _reconnectMax = MyIni.IniRead(SetFile, "Main", "Time Out")
            Else
                _reconnectMax = 0
            End If
            If MyIni.IniRead(SetFile, "Main", "Auto Reconnect") <> "" Then
                _AutoReconnect = Convert.ToBoolean(MyIni.IniRead(SetFile, "Main", "Auto Reconnect"))
            Else
                _AutoReconnect = False
            End If
            If MyIni.IniRead(SetFile, "Main", "AutoCloseProc") <> "" Then
                _CloseProc = Convert.ToBoolean(MyIni.IniRead(SetFile, "Main", "AutoCloseProc"))
            Else
                _CloseProc = False
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
            If MyIni.IniRead(SetFile, "Main", "SysTray") <> "" Then

                Select Case MyIni.IniRead(SetFile, "Main", "SysTray").ToLower
                    Case "checked"
                        _TrayIcon = CheckState.Checked
                    Case "unchecked"
                        _TrayIcon = CheckState.Unchecked
                    Case Else
                        _TrayIcon = CheckState.Indeterminate
                End Select


            End If

        End Sub
        Public Sub SaveMainSettings()
            MyIni.IniWrite(SetFile, "Main", "Host", _Host)
            '_reconnectMax
            MyIni.IniWrite(SetFile, "Main", "Time Out", _reconnectMax.ToString)
            MyIni.IniWrite(SetFile, "Main", "SPort", _sPort.ToString)
            MyIni.IniWrite(SetFile, "Main", "StandAlone", _StandAlone.ToString)
            MyIni.IniWrite(SetFile, "Main", "AutoCloseProc", _CloseProc.ToString)
            MyIni.IniWrite(SetFile, "Main", "Auto Reconnect", _AutoReconnect.ToString)
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
            MyIni.IniWrite(SetFile, "Main", "SysTray", _TrayIcon.ToString)

        End Sub

    End Structure

    Public Structure cBot
        Public Shared BotFile As String
        Private Shared MyIni As New IniMod
        Private Shared _IniFile As String
        Private Shared _lPort As Integer = 0
        Private Shared _MS_Engine_Enable As Boolean
        Private Shared _MS_File As String
        Private Shared _MS_Script As String
        Private Shared _BotController As String
        'Web Interface
        Private Shared _Domain As String = ""
        Private Shared _Path As String = ""
        Private Shared _UserName As String = ""
        Private Shared _Passwd As String = ""
        Private Shared _options() As String
        Private Shared _FormattedOptions As String = ""
        Private Shared _Proto As String = "HTTP"

        Private Shared _TT_TimeOut As Integer = 0
        Private Shared _TT_TimeInterval As Integer = 0
        Private Shared _NoEndurance As Boolean = False

        Public Property Proto As String
            Get
                Return _Proto

            End Get
            Set(value As String)
                _Proto = value

            End Set
        End Property
        Public Property TT_TimeOut As Integer
            Get
                Return _TT_TimeOut
            End Get
            Set(value As Integer)
                _TT_TimeOut = value
            End Set
        End Property
        Public Property TT_TimeInterval As Integer
            Get
                Return _TT_TimeInterval
            End Get
            Set(value As Integer)
                _TT_TimeInterval = value
            End Set
        End Property
        Public Property NoEndurance As Boolean
            Get
                Return _NoEndurance
            End Get
            Set(value As Boolean)
                _NoEndurance = value
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

        Public Property IniFile() As String
            Get
                Return _IniFile
            End Get
            Set(ByVal value As String)
                _IniFile = value
            End Set
        End Property

        Public Property MS_Engine_Enable As Boolean
            Get
                Return _MS_Engine_Enable
            End Get
            Set(ByVal value As Boolean)
                _MS_Engine_Enable = value
            End Set
        End Property

        Public Property MS_File As String
            Get
                Return _MS_File
            End Get
            Set(value As String)
                _MS_File = value
            End Set
        End Property

        Public Property MS_Script As String
            Get
                Return _MS_Script
            End Get
            Set(value As String)
                _MS_Script = value
            End Set
        End Property

        Public Property BotController As String
            Get
                Return _BotController
            End Get
            Set(value As String)
                _BotController = value
            End Set
        End Property
        'Web Interface
        Public Property Domain As String
            Get
                Dim str As String = _Domain
                If str.ToLower.StartsWith("http://") Then
                    str = str.Substring(7)
                End If
                _Domain = str
                Return _Domain
            End Get
            Set(value As String)
                _Domain = value
            End Set
        End Property
        Public Property Path As String
            Get
                Return _Path
            End Get
            Set(value As String)
                _Path = value
            End Set
        End Property
        Public Property UserName As String
            Get
                Return _UserName
            End Get
            Set(value As String)
                _UserName = value
            End Set
        End Property
        Public Property Passwd As String
            Get
                Return _Passwd
            End Get
            Set(value As String)
                _Passwd = value
            End Set
        End Property
        Public Property Options() As String()
            Get
                Return _options
            End Get
            Set(Value() As String)
                _options = Value
            End Set
        End Property

        Public Sub loadNew()
            _IniFile = "-pick"
            _lPort = 6700
            _MS_File = ""
            _MS_Engine_Enable = False
            _BotController = ""
        End Sub

        Public Sub LoadBotSettings()
            loadNew()
            'If BotFile = "" Then Exit Sub
            Try
                _IniFile = MyIni.IniRead(BotFile, "Bot", "BotIni")
            Catch

            End Try
            Try
                _lPort = Convert.ToInt32(MyIni.IniRead(BotFile, "Bot", "LPort"))
            Catch

            End Try
            If MyIni.IniRead(BotFile, "Bot", "MS_File") <> "" Then
                _MS_File = MyIni.IniRead(BotFile, "Bot", "MS_File")
            End If
            If MyIni.IniRead(BotFile, "Bot", "MSEngineEnable") <> "" Then
                _MS_Engine_Enable = Convert.ToBoolean(MyIni.IniRead(BotFile, "Bot", "MSEngineEnable"))

            End If

            If MyIni.IniRead(BotFile, "Bot", "BotController") <> "" Then
                _BotController = MyIni.IniRead(BotFile, "Bot", "BotController")
            End If
        End Sub

        Public Sub LoadBotSettings(ByRef BFile As String)
            loadNew()
            BotFile = BFile
            Try
                _IniFile = MyIni.IniRead(BotFile, "Bot", "BotIni")
            Catch
                Try
                    _TT_TimeInterval = Convert.ToInt32(MyIni.IniRead(SetFile, "Bot", "TT Interval"))
                Catch
                    _TT_TimeInterval = 500
                End Try
                Try
                    _TT_TimeOut = Convert.ToInt32(MyIni.IniRead(SetFile, "Bot", "TT TimeOut"))
                Catch
                    _TT_TimeOut = 90
                End Try

                If MyIni.IniRead(SetFile, "Bot", "NoEndurance") <> "" Then
                    _NoEndurance = Convert.ToBoolean(MyIni.IniRead(SetFile, "Main", "NoEndurance"))
                Else
                    _NoEndurance = False
                End If
            End Try
            Try
                ' _lPort = Convert.ToInt32(MyIni.IniRead(BotFile, "Bot", "LPort"))
                _lPort = CInt(MyIni.IniRead(BotFile, "Bot", "LPort"))
            Catch
                _lPort = 6700
            End Try
            If MyIni.IniRead(BotFile, "Bot", "MS_File") <> "" Then
                _MS_File = MyIni.IniRead(BotFile, "Bot", "MS_File")
            End If
            If MyIni.IniRead(BotFile, "Bot", "MSEngineEnable") <> "" Then
                _MS_Engine_Enable = Convert.ToBoolean(MyIni.IniRead(BotFile, "Bot", "MSEngineEnable"))
            End If
            If MyIni.IniRead(BotFile, "Bot", "BotController") <> "" Then
                _BotController = MyIni.IniRead(BotFile, "Bot", "BotController")
            End If
        End Sub
        Public Sub LoadWebSettings()
            _Domain = MyIni.IniRead(BotFile, "Web", "Domain")
            _Path = MyIni.IniRead(BotFile, "Web", "Path")
            _UserName = MyIni.IniRead(BotFile, "Web", "Username")
            _Passwd = MyIni.IniRead(BotFile, "Web", "Password")
            Try
                _Proto = MyIni.IniRead(BotFile, "Web", "Protocol")
            Catch

            End Try
            '  _options()

        End Sub
        Public Sub SaveBotSettings()
            MyIni.IniWrite(BotFile, "Bot", "BotIni", _IniFile)
            MyIni.IniWrite(SetFile, "Bot", "TT Interval", _TT_TimeInterval.ToString)
            MyIni.IniWrite(SetFile, "Bot", "TT TimeOut", _TT_TimeOut.ToString)
            MyIni.IniWrite(BotFile, "Bot", "NoEndurance", _NoEndurance.ToString)
            MyIni.IniWrite(BotFile, "Bot", "MS_File", _MS_File)
            MyIni.IniWrite(BotFile, "Bot", "LPort", _lPort.ToString)
            MyIni.IniWrite(BotFile, "Bot", "MSEngineEnable", _MS_Engine_Enable.ToString)
            MyIni.IniWrite(BotFile, "Bot", "BotController", _BotController)
        End Sub
        Public Sub saveWebSettings()
            MyIni.IniWrite(BotFile, "Web", "Domain", _Domain)
            MyIni.IniWrite(BotFile, "Web", "Path", _Path)
            MyIni.IniWrite(BotFile, "Web", "Username", _UserName)
            MyIni.IniWrite(BotFile, "Web", "Password", _Passwd)
            MyIni.IniWrite(BotFile, "Web", "Protocol", _Proto)
        End Sub
    End Structure

    Public Structure EditSettings
        Private Shared MyIni As New IniMod
        Private Shared _ConditionIndent As Integer
        Private Shared _EffectsIndent As Integer
        Private Shared _CauseIndent As Integer

        Private Shared _IDcolor As Color = Color.Blue
        Private Shared _CommentColor As Color = Color.Green
        Private Shared _StringColor As Color = Color.DarkCyan
        Private Shared _NumberColor As Color = Color.Violet
        Private Shared _VariableColor As Color = Color.Tan


        Public Property ConditionIndent As Integer
            Get
                Return _ConditionIndent
            End Get
            Set(value As Integer)
                _ConditionIndent = value
            End Set
        End Property

        Public Property EffectsIndent As Integer
            Get
                Return _EffectsIndent
            End Get
            Set(value As Integer)
                _EffectsIndent = value
            End Set
        End Property

        Public Property CauseIndent As Integer
            Get
                Return _CauseIndent
            End Get
            Set(value As Integer)
                _CauseIndent = value
            End Set
        End Property
        Public Property IDColor() As Color
            Get
                Return _IDcolor
            End Get
            Set(ByVal value As Color)
                _IDcolor = value
            End Set
        End Property
        Public Property StringColor() As Color
            Get
                Return _StringColor
            End Get
            Set(ByVal value As Color)
                _StringColor = value
            End Set
        End Property
        Public Property VariableColor() As Color
            Get
                Return _VariableColor
            End Get
            Set(ByVal value As Color)
                _VariableColor = value
            End Set
        End Property
        Public Property NumberColor() As Color
            Get
                Return _NumberColor
            End Get
            Set(ByVal value As Color)
                _NumberColor = value
            End Set
        End Property
        Public Property CommentColor() As Color
            Get
                Return _CommentColor
            End Get
            Set(ByVal value As Color)
                _CommentColor = value
            End Set
        End Property

        Public Sub LoadEditorSettings()
            If MyIni.IniRead(SetFile, "Editor", "ConIndent") <> "" Then
                _ConditionIndent = Convert.ToInt32(MyIni.IniRead(SetFile, "Editor", "ConIndent"))
            Else
                _ConditionIndent = 4
            End If
            If MyIni.IniRead(SetFile, "Editor", "EffectIndent") <> "" Then
                _EffectsIndent = Convert.ToInt32(MyIni.IniRead(SetFile, "Editor", "EffectIndent"))
            Else
                _EffectsIndent = 8
            End If
            If MyIni.IniRead(SetFile, "Editor", "CauseIndent") <> "" Then
                _CauseIndent = Convert.ToInt32(MyIni.IniRead(SetFile, "Editor", "CauseIndent"))
            Else
                _CauseIndent = 0
            End If
            If MyIni.IniRead(SetFile, "Editor", "IDColor") <> "" Then
                _IDcolor = ColorTranslator.FromHtml(MyIni.IniRead(SetFile, "Editor", "IDColor"))

            End If
            If MyIni.IniRead(SetFile, "Editor", "CommentColor") <> "" Then
                _CommentColor = ColorTranslator.FromHtml(MyIni.IniRead(SetFile, "Editor", "CommentColor"))
            End If
            If MyIni.IniRead(SetFile, "Editor", "StringColor") <> "" Then
                _StringColor = ColorTranslator.FromHtml(MyIni.IniRead(SetFile, "Editor", "StringColor"))
            End If
            If MyIni.IniRead(SetFile, "Editor", "VariableColor") <> "" Then
                _VariableColor = ColorTranslator.FromHtml(MyIni.IniRead(SetFile, "Editor", "VariableColor"))
            End If
            If MyIni.IniRead(SetFile, "Editor", "NumberColor") <> "" Then
                _NumberColor = ColorTranslator.FromHtml(MyIni.IniRead(SetFile, "Editor", "NumberColor"))
            End If
        End Sub

        Public Sub SaveEditorSettings()
            MyIni.IniWrite(SetFile, "Editor", "ConIndent", _ConditionIndent.ToString)
            MyIni.IniWrite(SetFile, "Editor", "EffectIndent", _EffectsIndent.ToString)
            MyIni.IniWrite(SetFile, "Editor", "CauseIndent", _CauseIndent.ToString)
            MyIni.IniWrite(SetFile, "Editor", "IDColor", ColorTranslator.ToHtml(_IDcolor).ToString)
            MyIni.IniWrite(SetFile, "Editor", "NumberColor", ColorTranslator.ToHtml(_NumberColor).ToString)
            MyIni.IniWrite(SetFile, "Editor", "StringColor", ColorTranslator.ToHtml(_StringColor).ToString)
            MyIni.IniWrite(SetFile, "Editor", "VariableColor", ColorTranslator.ToHtml(_VariableColor).ToString)
            MyIni.IniWrite(SetFile, "Editor", "CommentColor", ColorTranslator.ToHtml(_CommentColor).ToString)

        End Sub

    End Structure


End Class
