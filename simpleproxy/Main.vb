
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms
Imports System.IO
Imports System.Text
Imports System.Drawing

Imports Furcadia.IO
Imports Furcadia.Net
Imports Furcadia.Base220
Imports Furcadia.Base95
Imports Furcadia.Character
Imports Furcadia.Net.Movement
Imports SimpleProxy2.ConfigStructs
Imports System.Text.RegularExpressions
Imports Furcadia
Imports SimpleProxy2.RTFtoHTML
Imports System.Timers
Imports SimpleProxy2.ErrorLogging

Public Class Main
    Inherits Form

#Region "Propertes"
    Dim Player As New FURRE
    Public loggingIn As UShort = 0
    Dim DREAM As New DREAM
    Dim ActionCMD As String = ""
    Public bConnected As Boolean = False
    Dim Bot As New FURRE
    Public cMain As cMain
    Public cBot As cBot
    Public BotUID As String
    Public BotName As String
    Public Look As Boolean = False
    Dim newData As Boolean = False



    'Global Loging Options
    Public NewLogFile As Boolean = False
    Dim fname As String = ""
#End Region

#Region "Events"
    Private WithEvents simpleProxy As NetProxy
    Private ControlThread As Thread = Nothing
    Dim _FormClose As Boolean

    'UpDate Btn-Go Text and Actions Group Enable
    Delegate Sub UpDateBtn_GoCallback(ByRef [text] As Object)
    Delegate Sub UpDateBtn_StandCallback(ByRef [furre] As FURRE)
    Delegate Sub LogSave(ByRef path As String, ByRef filename As String)
    Delegate Sub AddDataToListCaller(ByRef lb As Object, ByRef obj As Object, ByRef NewColor As fColorEnum)
    Delegate Sub UpDateDreamListCaller(ByRef [dummy] As String) 'ByVal [dummy] As String

    Dim LogTimer As New System.Timers.Timer()
    Dim DreamUpdateTimer As New System.Timers.Timer()
#End Region
    Public LogStream As LogStream
    Public NewBot As Boolean
    Public writer As TextBoxWriter = Nothing

    Public Enum fColorEnum
        DefaultColor
        Say
        Shout
        Whisper
        Emote
        Emit
    End Enum

    Public Function fColor(Optional ByVal MyColor As fColorEnum = fColorEnum.DefaultColor) As System.Drawing.Color
        Try
            Select Case MyColor
                Case fColorEnum.DefaultColor
                    Return cMain.DefaultColor
                Case fColorEnum.Emit
                    Return cMain.EmitColor
                Case fColorEnum.Say
                    Return cMain.SayColor
                Case fColorEnum.Shout
                    Return cMain.ShoutColor
                Case fColorEnum.Whisper
                    Return cMain.WhColor
                Case fColorEnum.Emote
                    Return cMain.EmoteColor
                Case Else
                    Return cMain.DefaultColor
            End Select
        Catch Ex As Exception
            Dim logError As New ErrorLogging(Ex, Me)
        End Try
        ' Return 
    End Function


#Region "RegEx filters"
    Private Const EntryFilter As String = "^<font color='([^']*?)'>(.*?)</font>$"
    Private Const NameFilter As String = "<name shortname='([^']*)'(.*)>([\x21-\x3B\=\x3F-\x7E]+)</name>"
    Private Const DescFilter As String = "<desc shortname='([^']*)' />(.*)"
    Private Const ChannelNameFilter As String = "<channel name='([^']*)' />"
    Private Const Iconfilter As String = "<img src='fsh://system.fsh:([^']*)'(.*?)/>"
    Private Const YouSayFilter As String = "You ([\x21-\x3B\=\x3F-\x7E]+), ""([^']*)"""

#End Region



#Region " Methods"

    Public Sub AddDataToList(ByRef lb As Controls.RichTextBoxEx, ByRef obj As String, ByRef newColor As fColorEnum)
        If InvokeRequired Then
            Dim dataArray() As Object = {lb, obj, newColor}
            Me.Invoke(New AddDataToListCaller(AddressOf AddDataToList), dataArray)
        Else
            If lb.GetType().ToString.Contains("Controls.RichTextBoxEx") Then
                'Pos_Old = GetScrollPos(lb.Handle, SBS_VERT)
                Dim build As New System.Text.StringBuilder(obj)
                build = build.Replace("</b>", "\b0 ")
                build = build.Replace("<b>", "\b ")
                build = build.Replace("</i>", "\i0 ")
                build = build.Replace("<i>", "\i ")
                build = build.Replace("</ul>", "\ul0 ")
                build = build.Replace("<ul>", "\ul ")

                build = build.Replace("&lt;", "<")
                build = build.Replace("&gt;", ">")


                Dim Names As MatchCollection = Regex.Matches(obj, NameFilter)
                For Each Name As System.Text.RegularExpressions.Match In Names
                    build = build.Replace(Name.ToString, Name.Groups(3).Value)
                Next
                '<name shortname='acuara' forced>
                Dim MyIcon As MatchCollection = Regex.Matches(obj, Iconfilter)
                For Each Icon As System.Text.RegularExpressions.Match In MyIcon
                    Select Case Icon.Groups(1).Value
                        Case "91"
                            build = build.Replace(Icon.ToString, "[#]")
                        Case Else
                            build = build.Replace(Icon.ToString, "[" + Icon.Groups(1).Value + "]")
                    End Select

                Next

                'Dim myColor As System.Drawing.Color = fColor(newColor)
                lb.ReadOnly = False
                lb.BeginUpdate()

                lb.SelectionStart = lb.TextLength
                lb.SelectedRtf = FormatText(build.ToString, newColor)

                'since we Put the Data in the RTB now we Finish Setting the Links
                Dim param() As String = {"<a.*?href=['""](.*?)['""].*?>(.*?)</a>", "<a.*?href=(.*?)>(.*?)</a>"}
                For i As Integer = 0 To param.Length - 1
                    Dim links As MatchCollection = Regex.Matches(lb.Text, param(i), RegexOptions.IgnoreCase)
                    ' links = links & Regex.Matches(lb.Text, "<a.*?href='(.*?)'.*?>(.*?)</a>", RegexOptions.IgnoreCase)
                    For Each mmatch As System.Text.RegularExpressions.Match In links
                        Dim matchUrl As String = mmatch.Groups(1).Value
                        Dim matchText As String = mmatch.Groups(2).Value
                        If mmatch.Success Then
                            With lb
                                .Find(mmatch.ToString)
                                'WAIT Snag Image Links first!
                                'Dim snag As Match = Regex.Match(matchText, "IMG:(.*?)::")
                                'If snag.Success Then
                                '    Dim RTFimg As New RTFBuilder
                                '    RTFimg.InsertImage(LoadImageFromUrl(snag.Groups(1).ToString))
                                '    .SelectedRtf = RTFimg.ToString
                                'Else
                                .SelectedRtf = FormatURL(matchText & "\v #" & matchUrl & "\v0 ")
                                .Find(matchText & "#" & matchUrl, RichTextBoxFinds.WholeWord)
                                .SetSelectionLink(True)
                                'End If
                                'Put the Link in

                            End With
                        End If
                    Next
                Next
                'Dim Images As MatchCollection = Regex.Matches(lb.Text, "<img .*?src=[""']?([^'"">]+)[""']?.*?>", RegexOptions.IgnoreCase)
                'For Each Image As Match In Images
                '    Dim img As String = Image.Groups(1).Value
                '    Dim alt As String = Image.Groups(2).Value
                '    With lb
                '        .SelectionStart = lb.Text.IndexOf(Image.ToString)
                '        .SelectionLength = Image.ToString.Length
                '        Dim RTFimg As New RTFBuilder
                '        'RTFimg.Append("IMG:" & img & "::")
                '        RTFimg.InsertImage(LoadImageFromUrl(img))
                '        .SelectedRtf = RTFimg.ToString
                '    End With
                'Next

                'Dim SysImages As MatchCollection = Regex.Matches(lb.Text, "\$(.[0-9]+)\$")
                'For Each SysMatch As Match In SysImages
                '    Dim idx As Integer = Convert.ToInt32(SysMatch.Groups(1).ToString)
                '    With lb
                '        .Find(SysMatch.ToString)
                '        Dim RTFimg As New RTFBuilder
                '        RTFimg.InsertImage(IMGresize(GetFrame(idx), log_))
                '        .SelectedRtf = RTFimg.ToString
                '    End With
                'Next
                '' 
                'SysImages = Regex.Matches(lb.Text, "#C(.?)?")
                'For Each SysMatch As Match In SysImages
                '    Dim idx As Integer = Helper.CharToDescTag(SysMatch.Groups(1).ToString)
                '    With lb
                '        .Find(SysMatch.ToString)
                '        Dim RTFimg As New RTFBuilder
                '        RTFimg.InsertImage(IMGresize(GetFrame(idx, "desctags.fox"), log_))
                '        .SelectedRtf = RTFimg.ToString
                '    End With
                'Next
                'SysImages = Regex.Matches(lb.Text, "#S(.?)?")
                'For Each SysMatch As Match In SysImages
                '    With lb
                '        .Find(SysMatch.ToString)
                '        .SelectedRtf = GetSmily(SysMatch.Groups(1).Value)
                '    End With
                'Next


                Try
                    Dim SelStart As Integer = 0
                    While (lb.Lines.Length > 350)
                        'Array.Copy(lb.Lines, 1, lb.Lines, 0, lb.Lines.Length - 1)
                        SelStart = lb.SelectionStart
                        lb.SelectionStart = 0
                        lb.SelectionLength = lb.Text.IndexOf(vbLf, 0) + 1
                        lb.SelectedText = ""
                        lb.SelectionStart = SelStart
                    End While
                Catch
                    lb.Clear()
                    Console.WriteLine("Reset Log box due to over flow")
                End Try
                lb.EndUpdate()
                lb.ReadOnly = True

            End If



        End If
    End Sub

    Private Sub log__LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs)
        MsgBox(e.LinkText)
    End Sub

    Public Sub UpDateDreamList(ByRef [dummy] As String) '
        Try
            If Me.DreamList.InvokeRequired OrElse DreamCountTxtBx.InvokeRequired Then
                Me.Invoke(New UpDateDreamListCaller(AddressOf UpDateDreamList), "")
            Else
                Dim fList As New Dictionary(Of UInteger, FURRE)
                fList = DREAM.List
                Dim p As KeyValuePair(Of UInteger, FURRE)
                DreamList.BeginUpdate()
                DreamList.Items.Clear()
                For Each p In fList
                    DreamList.Items.Add(fList.Item(p.Key).Name)
                Next
                DreamCountTxtBx.Text = fList.Count.ToString
                DreamList.EndUpdate()
            End If
        Catch eX As Exception
            Dim logError As New ErrorLogging(eX, Me, DREAM.List.ToString)
            'logError = New ErrorLogging(eX, p)
        End Try
    End Sub

    Public Sub sndDisplay(ByRef data As String, Optional ByRef newColor As fColorEnum = fColorEnum.DefaultColor)
        Try
            'data = data.Replace(vbLf, vbCrLf)
            If cBot.log Then LogStream.Writeline(data)
            If cMain.TimeStamp Then
                Dim Now As String = DateTime.Now.ToLongTimeString
                data = Now.ToString & ": " & data
            End If
            AddDataToList(log_, data, newColor)
        Catch eX As Exception
            Dim logError As New ErrorLogging(eX, Me)
        End Try
    End Sub

    Public Sub sndServer(ByRef data As String)
        Try
            If Not bConnected Then Exit Sub
            If data.StartsWith("`m ") Then
                ' TriggerCmd(MS0_MOVE)
                Select Case data.Substring(2, 1)
                    Case "7"
                        '     TriggerCmd(MS0_MOVENW)
                    Case "9"
                        '   TriggerCmd(MS0_MOVENE)
                    Case "1"
                        '  TriggerCmd(MS0_MOVESW)
                    Case "3"
                        '  TriggerCmd(MS0_MOVESE)
                End Select
            ElseIf data = "`use" Then

            ElseIf data = "`get" Then

            ElseIf data = "`>" Then

            ElseIf data = "`<" Then

            ElseIf data = "`lie" Then

            ElseIf data = "`liedown" Then

            ElseIf data = "`sit" Then

            ElseIf data = "`stand" Then

            End If

            TextToServer(data)
        Catch eX As Exception
            Dim logError As New ErrorLogging(eX, Me)
        End Try
    End Sub

    Private Sub TextToServer(ByRef arg As String)
        Try
            Dim result As String = ""
            'Clean Text input to match Client 
            If arg <> vbNullString Then
                Select Case arg.Substring(0, 1)
                    Case "`"
                        result = arg.Remove(0, 1)
                    Case "/"
                        result = "wh %" & arg
                    Case ":"
                        result = ":" & arg
                    Case "-"
                        result = "-" & arg
                    Case Else
                        result = Chr(34) & arg
                End Select
                simpleProxy.SendServer(result & vbLf)
            End If
        Catch eX As Exception
            Dim logError As New ErrorLogging(eX, Me)
        End Try
    End Sub

    Private Sub ParseServerData(ByVal data As String)

        Player.Clear()
        Try
            If data = "Dragonroar" Then
                loggingIn = 1
                '  Login Sucessful
            ElseIf data = "&&&&&&&&&&&&&" Then
                ' loggingIn = 2

                ' Species Tags
            ElseIf data.StartsWith("]-") Then

                'DS Variables
            ElseIf data.StartsWith("0") Then

                'Phoenix Speak event
            ElseIf data.StartsWith("3") Then

                'self Induced Dradon Speak Event
            ElseIf data.StartsWith("6") Then

                'Dragon Speak event
            ElseIf data.StartsWith("7") Then

                'Dragon Speak Addon (Follows Instructions 6 and 7
            ElseIf data.StartsWith("8") Then

                'Look responce
            ElseIf data.StartsWith("]f") And loggingIn = 2 Then
                Dim length As Short = 14
                Look = True
                If data.Substring(2, 1) <> "t" Then
                    length = 30
                Else
                    length = 14
                End If
                Player = ShortNametoFurre(LongNameToShortName(data.Remove(0, length + 2)))
                Player.Color = data.Substring(2, length)
                If IsBot(Player) Then Look = False
                DREAM.List.Item(Player.ID) = Player

            ElseIf data.StartsWith("<") And loggingIn = 2 Then 'And loggingIn = True
                Player.ID = ConvertFromBase220(data.Substring(1, 4))
                If DREAM.List.ContainsKey(Player.ID) Then
                    Player = DREAM.List.Item(Player.ID)
                End If
                Player.X = ConvertFromBase220(data.Substring(5, 2))
                Player.Y = ConvertFromBase220(data.Substring(7, 2))
                Player.Shape = ConvertFromBase220(data.Substring(9, 2))
                Dim NameLength As UInteger = ConvertFromBase220(data.Substring(11, 1))
                Player.Name = data.Substring(12, NameLength).Replace("|", " ")
                Dim ColTypePos As UInteger = 12 + NameLength
                Player.ColorType = data.Substring(ColTypePos, 1)
                Dim ColorSize As UInteger = 10
                If Player.ColorType <> "t" Then
                    ColorSize = 30
                End If
                Dim sColorPos As UInteger = ColTypePos + 1
                Player.Color = data.Substring(sColorPos, ColorSize)
                Dim FlagPos As UInteger = data.Length - 5
                Player.Flag = ConvertFromBase220(data.Substring(FlagPos, 1))
                Dim AFK_Pos As UInteger = data.Length - 4
                Player.AFK = New TimeSpan(ConvertFromBase220(ConvertFromBase220(data.Substring(AFK_Pos, 4))) * TimeSpan.TicksPerSecond)
                Dim FlagCheck As Integer = CType(Flags.CHAR_FLAG_NEW_AVATAR, Integer) - Player.Flag

                ' Add New Arrivals to Dream List
                ' One or the other will trigger it
                IsBot(Player)
                If FlagCheck <> 0 And Not DREAM.List.ContainsKey(Player.ID) Then
                    DREAM.List.Add(Player.ID, Player)
                    UpDateDreamList("")
                Else
                    'Update existing furre with the new data
                    DREAM.List.Item(Player.ID) = Player
                End If
                '     TriggerCmd(MS0_FENTER)
                '   TriggerCmd(MS0_FENTEREX)

                'Remove Furre
            ElseIf data.StartsWith(")") = True And loggingIn = 2 Then 'And loggingIn = False
                Dim remID As UInteger = ConvertFromBase220(data.Substring(1, 4))
                ' remove departure from List
                If DREAM.List.ContainsKey(remID) = True And loggingIn = 2 Then
                    DREAM.List.Remove(remID)
                    UpDateDreamList("")
                    '  TriggerCmd(MS0_FLEAVE)
                    '  TriggerCmd(MS0_FLEAVEEX)
                End If

                'Animated Move
            ElseIf data.StartsWith("/") <> 0 And loggingIn = 2 Then 'And loggingIn = False
                Player.ID = ConvertFromBase220(data.Substring(1, 4))
                Player = DREAM.List.Item(Player.ID)
                Player.X = ConvertFromBase220(data.Substring(5, 2))
                Player.Y = ConvertFromBase220(data.Substring(7, 2))
                Player.Shape = ConvertFromBase220(data.Substring(8, 2))
                DREAM.List.Item(Player.ID) = Player
                IsBot(Player)
                '     TriggerCmd(MS0_FMOVE)
                '    TriggerCmd(MS0_FMOVEEX)

                ' Move Avatar
            ElseIf data.StartsWith("A") <> 0 And loggingIn = 2 Then 'And loggingIn = False
                Player.ID = ConvertFromBase220(data.Substring(1, 4))
                Player = DREAM.List.Item(Player.ID)
                Player.X = ConvertFromBase220(data.Substring(5, 2))
                Player.Y = ConvertFromBase220(data.Substring(7, 2))
                Player.Shape = ConvertFromBase220(data.Substring(8, 2))
                'If Player.X = X And Player.Y = Y Then Exit Sub

                DREAM.List.Item(Player.ID) = Player
                IsBot(Player)
                'If found = True And X <= BOT.X + 10 And Y <= BOT.Y + 10 Then
                '    '  TriggerCmd(MS0_FVIEW)
                '    '  TriggerCmd(MS0_FVIEWEX)
                'End If

                ' Update Color Code
            ElseIf data.StartsWith("B") <> 0 And loggingIn = 2 Then 'And loggingIn = False
                Player.ID = ConvertFromBase220(data.Substring(1, 4))
                Player = DREAM.List.Item(Player.ID)
                Player.Shape = ConvertFromBase220(data.Substring(5, 2))
                Dim ColTypePos As UInteger = 7
                Player.ColorType = data.Substring(ColTypePos, 1)
                Dim ColorSize As UInteger = 10
                If Player.ColorType <> "t" Then
                    ColorSize = 30
                End If
                Dim sColorPos As UInteger = ColTypePos + 1
                Player.Color = data.Substring(sColorPos, ColorSize)
                DREAM.List.Item(Player.ID) = Player
                IsBot(Player)

                'Hide Avatar
            ElseIf data.StartsWith("C") <> 0 And loggingIn = 2 Then 'And loggingIn = False
                Player.ID = ConvertFromBase220(data.Substring(1, 4))
                Player = DREAM.List.Item(Player.ID)
                Player.X = ConvertFromBase220(data.Substring(5, 2))
                Player.Y = ConvertFromBase220(data.Substring(7, 2))
                DREAM.List.Item(Player.ID) = Player
                IsBot(Player)
                'If found = True And X <= UInteger.Parse(BOT.X) + 10 And Y <= UInteger.Parse(BOT.Y) + 10 Then
                '    '  TriggerCmd(MS0_FNVIEW)
                '    ' TriggerCmd(MS0_FNVIEWEX)
                'End If

            ElseIf data.StartsWith(";") = True OrElse data.StartsWith("]q") Then
                DREAM.List.Clear()
                UpDateDreamList("")

                'Snag out UID
            ElseIf data.StartsWith("]B") Then
                BotUID = data.Remove(0, 2)
                Bot.ID = ConvertFromBase220(BotUID)
                'Process Channels Seperatly
            ElseIf data.StartsWith("(") Then
                ChannelProcess(data)
            End If

        Catch eX As Exception
            Dim logError As New ErrorLogging(eX, Me)
        End Try

    End Sub

    ''' <summary>
    ''' Channel Parser
    ''' RegEx Style Processing here
    ''' </summary>
    ''' <param name="data"></param>
    ''' <remarks></remarks>
    Public Sub ChannelProcess(ByRef data As String)
        'Strip the trigger Character
        Try
            data = data.Remove(0, 1)
            Dim Channel As String = Regex.Match(data, EntryFilter).Groups(1).Value
            Dim Text As String = Regex.Match(data, EntryFilter).Groups(2).Value
            Dim ShortUser As String = Regex.Match(data, NameFilter).Groups(1).Value
            Dim User As String = Regex.Match(data, NameFilter).Groups(3).Value
            If User <> "" Then
                Player = ShortNametoFurre(ShortUser)
            End If
            Dim Desc As String = Regex.Match(data, DescFilter).Groups(2).Value
            Dim r As New Regex(Iconfilter)
            Text = r.Replace(Text, "")
            Dim s As New Regex(ChannelNameFilter)
            Text = s.Replace(Text, "")

            If Channel = "success" Then
                sndDisplay("[" & fIcon(data) & "> " & Text)

            ElseIf Channel = "dragonspeak" OrElse Channel = "emit" Then
                sndDisplay("[" & fIcon(data) & "] " & Text, fColorEnum.Emit)
                ' TriggerCmd(MS0_EMIT)
                ' TriggerCmd(MS0_EMITANY)
                ' TriggerCmd(MS0_EMITMSG)

            ElseIf InStr(data, "<A HREF=""furc://") Then
                'DREAM.URL = StrBetween(data, Chr(34), Chr(34))
                'DREAM.URL = StrTrimRight(DREAM.URL, DREAM.URL.Length - InStr(DREAM.URL, Chr(34)) + 1)
                'DREAM.Name = DREAM.URL.Replace("furc://", "")
                'If InStr(DREAM.Name, ":") <> 0 Then
                '    DREAM.Name = StrLeft(DREAM.Name, InStr(DREAM.Name, ":"))
                'Else
                '    DREAM.Name = DREAM.Name.Remove(DREAM.Name.LastIndexOf("/"), 1)
                'End If

                ''BCast (Advertisments, Announcments)
            ElseIf Channel = "bcast" Then
                Dim u As Match = Regex.Match(data, "\[(.*?)\](.*?)</font>")
                sndDisplay("[" & fIcon(data) & "> [" & u.Groups(1).Value & "]" & u.Groups(2).Value)

                ''SAY
            ElseIf Channel = "myspeech" Then
                Dim t As New Regex(YouSayFilter)
                Dim u As String = t.Match(data).Groups(1).ToString
                Text = t.Match(data).Groups(2).ToString
                sndDisplay("You " & u & ", """ & Text & """", fColorEnum.Say)
            ElseIf User <> "" And Channel = "" Then
                Dim tt As Match = Regex.Match(data, "\(you see(.*?)\)", RegexOptions.IgnoreCase)
                Dim t As New Regex(NameFilter)
                If Not tt.Success Then
                    Text = t.Replace(data, "")
                    Text = Text.Remove(0, 2)
                    sndDisplay(User & " says, """ & Text & """", fColorEnum.Say)
                Else
                    sndDisplay("You See '" & User & " '")
                End If

            ElseIf Desc <> "" Then
                Dim DescName As String = Regex.Match(data, DescFilter).Groups(1).ToString()
                sndDisplay(Desc)
                Look = False
            ElseIf Channel = "shout" Then
                ''SHOUT
                Dim t As New Regex(YouSayFilter)
                Dim u As String = t.Match(data).Groups(1).ToString
                Text = t.Match(data).Groups(2).ToString
                If User = "" Then
                    sndDisplay("You " & u & ", """ & Text & """", fColorEnum.Shout)
                Else
                    Text = Regex.Match(data, "shouts: (.*)</font>").Groups(1).ToString()
                    sndDisplay(User & " shouts, """ & Text & """", fColorEnum.Shout)
                End If
                If Not IsBot(Player) Then
                    '    '    TriggerCmd(MS0_SAY)
                    '    '    TriggerCmd(MS0_SAYEX)
                    '    '    TriggerCmd(MS0_SAYANY)
                    '    ''    TriggerCmd(MS0_SAYANYEX)
                    '    '    TriggerCmd(MS0_SAYMSG)
                    '    '    TriggerCmd(MS0_SAYMSGEX)
                End If

            ElseIf Channel = "query" Then
                Dim QCMD As String = Regex.Match(data, "<a.*?href='command://(.*)'>").Groups(1).ToString
                Select Case QCMD
                    Case "join"
                        ''JOIN
                        sndDisplay(User & " requests to join.")
                        If Not IsBot(Player) Then
                            '    '   TriggerCmd(MS0_JOIN)
                            '    '   TriggerCmd(MS0_JOINEX)
                        End If
                    Case "summon"
                        ''SUMMON
                        sndDisplay(User & " requests a summon.")
                        If Not IsBot(Player) Then
                            '    '  TriggerCmd(MS0_SUMMON)
                            '    '  TriggerCmd(MS0_SUMMONEX)
                        End If
                    Case "follow"
                        ''LEAD
                        sndDisplay(User & " requests to lead.")
                        If Not IsBot(Player) Then
                            '    PLAYER.Name = ""
                            '    ' TriggerCmd(MS0_LEAD)
                            '    PLAYER.Name = followRequester
                            '    '  TriggerCmd(MS0_LEADEX)
                        End If
                    Case "lead"
                        ''FOLLOW
                        sndDisplay(User & " requests the bot to follow.")
                        If Not IsBot(Player) Then
                            '    PLAYER.Name = ""
                            '    '  TriggerCmd(MS0_FOLLOW)
                            '    PLAYER.Name = leadRequester
                            '    ' TriggerCmd(MS0_FOLLOWEX)
                        End If
                    Case Else
                        sndDisplay("## Unknown " & Channel & "## " & data)
                End Select

                'NameFilter
            ElseIf Channel = "whisper" Then
                ''WHISPER

                Dim WhisperFrom As String = Regex.Match(data, "whispers, ""(.*)"" to you").Groups(1).ToString()
                Dim WhisperTo As String = Regex.Match(data, "You whisper ""(.*)"" to").Groups(1).ToString()
                Dim WhisperDir As String = Regex.Match(data, "src='whisper-(.*)'").Groups(1).ToString()
                If WhisperDir = "from" Then
                    sndDisplay(User & " whispers""" & WhisperFrom & """ to you.", fColorEnum.Whisper)
                    '    TriggerCmd(MS0_WHISPER)
                    '    TriggerCmd(MS0_WHISPEREX)
                    '   TriggerCmd(MS0_WHISPERMSG)
                    '    TriggerCmd(MS0_WHISPERMSGEX)
                    '    TriggerCmd(MS0_WHISPERANY)
                    '   TriggerCmd(MS0_WHISPERANYEX)
                Else
                    WhisperTo = WhisperTo.Replace("<wnd>", "")
                    sndDisplay("You whisper""" & WhisperTo & """ to " & User & ".", fColorEnum.Whisper)
                End If

            ElseIf Channel = "emote" Then
                ' ''EMOTE
                Dim usr As Regex = New Regex(NameFilter)
                Text = usr.Replace(Text, "")
                sndDisplay(User & " " & Text, fColorEnum.Emote)
                If Not IsBot(Player) Then
                    '    '    TriggerCmd(MS0_EMOTE)
                    '    '    TriggerCmd(MS0_EMOTEEX)
                    '    '    TriggerCmd(MS0_EMOTEANY)
                    '    '    TriggerCmd(MS0_EMOTEANYEX)
                    '    '    TriggerCmd(MS0_EMOTEMSG)
                    '    '    TriggerCmd(MS0_EMOTEMSGEX)
                End If

            ElseIf Channel = "error" Then
                sndDisplay("Error:>> " & Text)
            ElseIf data.StartsWith("Communication") Then
                sndDisplay("Error: Communication Error.  Aborting connection.")
                simpleProxy.Kill()
                'LogSaveTmr.Enabled = False

            ElseIf data.StartsWith("<img src='fsh://system.fsh:") And InStr(data, "Lines of DragonSpeak") Then
                Dim t As New Regex(Iconfilter)
                Text = t.Replace(data, "")
                sndDisplay("[" & fIcon(data) & "> " & Text)
                'DREAM.Lines = Integer.Parse(StrTrimLeft(data, data.LastIndexOf(":") + 1).Trim)
                'sndServer(Chr(34) & "dreamurl")
                'bdreamenter = False
            ElseIf data.StartsWith("<img src='fsh://system.fsh:86' /> Furcadia Standard Time:") Then
                Dim t As New Regex(Iconfilter)
                Text = t.Replace(data, "")
                sndDisplay("[" & fIcon(data) & "> " & Text)
                'furcTime = Date.UtcNow.AddHours(5).ToLongTimeString().Split(" "c)
                'MS.TriggerCmd(MS.MS0_FURCTIME)
                '**********       
            ElseIf data.StartsWith("<img src='fsh://system.fsh:86' />") = True And InStr(data, "players in the dream of ") Then
                Dim t As New Regex(Iconfilter)
                Text = t.Replace(data, "")
                sndDisplay("[" & fIcon(data) & "> " & Text)
                'DREAM.Name = StrTrimLeft(data, InStr(data, "of") + 2).Replace(".", "")
                'data = data.Replace(DREAM.Name, "")
                'dNumFurres = Integer.Parse(RegExp(data, "\d*").Replace(" ", ""))***ERRORS***************
            ElseIf data.StartsWith("<img src='fsh://system.fsh:86' />") Then
                Dim t As New Regex(Iconfilter)
                Text = t.Replace(data, "")
                sndDisplay("[" & fIcon(data) & "> " & Text)
                If loggingIn = 2 Then
                    ' If bClientOpen = False Then sndServer("vascodagama")
                    ' DREAM.List.Clear()
                    'TimerDreamList()
                    'bdreamenter = True
                Else
                    ' If bClientOpen = False Then sndServer("vascodagama")
                    'TriggerCmd(MS0_LOGIN)
                    ' loggingIn = False
                    ' bdreamenter = True
                End If


            Else
                sndDisplay(data)
            End If
        Catch eX As Exception
            Dim logError As New ErrorLogging(eX, Me)
        End Try
    End Sub

    Private Function fIDtoFurre(ByRef ID As String) As FURRE
        Dim Character As KeyValuePair(Of UInteger, FURRE)
        For Each Character In DREAM.List
            If Character.Value.ID = ID Then
                Return Character.Value
            End If
        Next
    End Function

    Private Function ShortNametoFurre(ByRef sname As String) As FURRE
        Dim Character As KeyValuePair(Of UInteger, FURRE)
        For Each Character In DREAM.List
            If Character.Value.ShortName = sname Then
                Return Character.Value
            End If
        Next
    End Function

    Private Function LongNameToShortName(ByRef Name As String) As String
        Return Regex.Replace(Name.ToLower(), "[^a-zA-Z0-9\0x0020_.]+", "")
    End Function

    Private Function fIcon(ByRef data As String) As String
        Dim MyIcon As String = Regex.Match(data, Iconfilter).Groups(1).Value
        Select Case MyIcon
            Case "86"
                MyIcon = "#"
            Case "91"
                MyIcon = "+"
        End Select
        Return MyIcon
    End Function

    Public Function IsBot(ByRef player As FURRE) As Boolean
        If player.ShortName <> BotName Then Return False
        Bot = player
        If BtnSit_stand_Lie.InvokeRequired Then
            Dim d As New UpDateBtn_StandCallback(AddressOf IsBot)
            Me.Invoke(d, [player])
        Else
            'Update inteface
            Try
                                Select Case Bot.FrameInfo.pose
                    Case 0
                        BtnSit_stand_Lie.Text = "Stand"
                    Case 1 To 3
                        BtnSit_stand_Lie.Text = "Lay"
                    Case 4
                        BtnSit_stand_Lie.Text = "Sit"
                End Select
            Catch eX As Exception
                Dim logError As New ErrorLogging(eX, Me)
            End Try
            Return True
        End If
    End Function

#End Region

    Private Function onClientDataReceived(ByVal data As String) Handles simpleProxy.ClientData
        Try
            If data.StartsWith("desc") = True Or data.StartsWith("chdesc") = True Then
                data += " [SimpleProxy with <a href='http://furcadia.codeplex.com'>Furcadia Framework</a> for Third Party Programs]"
            End If
            If data = "vascodagama" Then
                loggingIn = 2
                TS_Status_Client.Image = My.Resources.images3
            End If

            'Capture The Bots Name
            If data.StartsWith("connect") Then
                Dim test As String = data.Replace("connect ", "")
                test = test.TrimStart(" ")
                BotName = test.Substring(0, test.IndexOf(" "))
                BotName = BotName.Replace("|", "")
                BotName = BotName.Replace("[^a-zA-Z0-9\0x0020_.]+", "").ToLower()
            End If
        Catch eX As Exception
            Dim logError As New ErrorLogging(eX, Me)
        End Try
        Return data

    End Function

    Private Sub ClientExit() Handles simpleProxy.ClientExited
        TS_Status_Client.Image = My.Resources.images2
        simpleProxy.Kill()
        bConnected = False
        If cMain.StandAlone = False Then test3()

        '    LogSaveTmr.Enabled = False
    End Sub
    Private Sub ServerClose() Handles simpleProxy.ServerDisConnected
        test3()
        simpleProxy.Kill()
        bConnected = False
        '  LogSaveTmr.Enabled = False
    End Sub

    Private Function onServerDataReceived(ByVal data As String) Handles simpleProxy.ServerData
        ParseServerData(data)
        Return data
    End Function

    Protected Overrides Sub Finalize()
        Try
            simpleProxy.Kill()
            bConnected = False

        Catch
        End Try
        MyBase.Finalize()
    End Sub

    Public Sub OnConnected() Handles simpleProxy.Connected
        test3()
        '  LogSaveTmr.Enabled = True
        bConnected = True
    End Sub

    Public Function setLogName() As String
        Select Case cBot.LogOption
            Case 0
                Return cBot.LogNameBase
            Case 1
                cBot.LogIdx += 1
                cBot.SaveBotSettings()
                Return cBot.LogNameBase & cBot.LogIdx.ToString
            Case 2
                Return cBot.LogNameBase & Date.Now().ToString("MM_dd_yyyy_H-mm-ss")

        End Select
        Return "Default"
    End Function



    Public Sub SaveRTF(ByRef path As String, ByRef fName As String)
        If log_.InvokeRequired Then
            Dim d As New LogSave(AddressOf SaveRTF)
            Me.Invoke(d, path, fName)
        Else
            ' You should replace the bold file name in the 
            ' sample below with a file name of your own choosing.
            log_.SaveFile(path & "/" & fName, RichTextBoxStreamType.RichText)
        End If
    End Sub
    Public Sub SavePlainTxt(ByRef path As String, ByRef fName As String)
        If log_.InvokeRequired Then
            Dim d As New LogSave(AddressOf SavePlainTxt)
            Me.Invoke(d, path, fName)
        Else
            ' You should replace the bold file name in the 
            ' sample below with a file name of your own choosing.
            log_.SaveFile(path & "/" & fName, RichTextBoxStreamType.PlainText)
        End If
    End Sub
    Public Sub SaveHTML(ByRef path As String, ByRef fName As String)
        If log_.InvokeRequired Then
            Dim d As New LogSave(AddressOf SavePlainTxt)
            Me.Invoke(d, path, fName)
        Else
            Dim r2h As New RTFtoHTML
            r2h.rtf = log_.Rtf
            File.WriteAllText(path & "/" & fName, r2h.html)
        End If
    End Sub
    Sub test3()

        If Me.BTN_Go.InvokeRequired Then
            Dim d As New UpDateBtn_GoCallback(AddressOf test3)
            Me.Invoke(d, New Object() {[Text]})
        Else
            If BTN_Go.Text = "Connected." And loggingIn = 2 Then
                '  bConnected = True
                sndDisplay("Connecting...")
                BTN_Go.Text = "Go!"
            ElseIf BTN_Go.Text = "Connecting..." And loggingIn = 1 Then
                BTN_Go.Text = "Connected."
                loggingIn = 2
                BTN_Go.Text = "Go!"
                TS_Status_Server.Image = My.Resources.images3
                'TS_Status_Client.Image = My.Resources.images3
            End If
        End If

    End Sub

    Public Function FormatText(ByVal data As String, ByVal newColor As fColorEnum) As String

        Dim myColor As System.Drawing.Color = fColor(newColor)
        Dim ColorString = "{\colortbl ;"
        ColorString += "\red" & myColor.R & "\green" & myColor.G & "\blue" & myColor.B & ";}"
        Dim FontSize As Integer = cMain.ApFont.Size
        Dim FontFace As String = cMain.ApFont.Name
        FontSize *= 2
        Return "{\rtf1\ansi\ansicpg1252\deff0\deflang1033" & ColorString & "{\fonttbl{\f0\fcharset0 " & FontFace & ";}}\viewkind4\uc1\fs" & FontSize.ToString & " \cf1 " & data & "\cf0 \par}"
    End Function
    Public Function FormatURL(ByVal data As String) As String
        Dim FontSize As Integer = cMain.ApFont.Size
        Dim FontFace As String = cMain.ApFont.Name
        FontSize *= 2
        Return "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fcharset0 " & FontFace & ";}}\viewkind4\uc1\fs" & FontSize.ToString & " " & data & "}"
    End Function

    Private Sub Main_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            'Set my user setting MainFormLocation to
            'the current form's location
            My.Settings.MainFormLocation = Me.Location

            'Save the user settings so next time the
            'window will be the same size and location
            My.Settings.Save()

        Catch eX As Exception
            Dim logError As New ErrorLogging(eX, Me)
        End Try
    End Sub

    Private Sub Main_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Try to get Furcadia's path from the registry
        FurcPath = New Paths()
        writer = New TextBoxWriter(log_)
        cMain = New cMain
        'cBot.LoadBotSettings()
        InitializeTextControls()
        'Me.Size = My.Settings.MainFormSize
        Me.Location = My.Settings.MainFormLocation
        Me.Text = Application.ProductName + ": V" + Application.ProductVersion
        Me.Visible = True
    End Sub

    Public Sub InitializeTextControls()
        toServer.Font = cMain.ApFont
        DreamList.Font = cMain.ApFont
        DreamCountTxtBx.Font = cMain.ApFont
    End Sub

#Region "Action Controls"

    Private Sub ActionTmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionTmr.Tick
        If Not bConnected Then Exit Sub
        sndServer(ActionCMD)
    End Sub
    Private Sub _ne_Click(sender As System.Object, e As System.EventArgs) Handles _ne.Click
        sndServer("`m 9")
    End Sub

    Private Sub _nw_Click(sender As System.Object, e As System.EventArgs) Handles _nw.Click
        sndServer("`m 7")
    End Sub

    Private Sub BtnSit_stand_Lie_Click(sender As System.Object, e As System.EventArgs) Handles BtnSit_stand_Lie.Click
        If Not bConnected Then Exit Sub
        If BtnSit_stand_Lie.Text = "Stand" Then
            BtnSit_stand_Lie.Text = "Lay"
        ElseIf BtnSit_stand_Lie.Text = "Lay" Then
            BtnSit_stand_Lie.Text = "Sit"
        ElseIf BtnSit_stand_Lie.Text = "Sit" Then
            BtnSit_stand_Lie.Text = "Stand"
        End If
        sndServer("`lie")
    End Sub

    Private Sub BTN_TurnR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_TurnR.Click
        sndServer("`>")
    End Sub

    Private Sub BTN_TurnL_Click(sender As System.Object, e As System.EventArgs) Handles BTN_TurnL.Click
        sndServer("`<")
    End Sub

    Private Sub use__Click(sender As Object, e As System.EventArgs) Handles use_.Click
        sndServer("`use")
    End Sub

    Private Sub get__Click(sender As Object, e As System.EventArgs) Handles get_.Click
        sndServer("`get")
    End Sub

    Private Sub sw__Click(sender As Object, e As System.EventArgs) Handles sw_.Click
        sndServer("`m 1")
    End Sub

    Private Sub sw__MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles sw_.MouseDown
        Me.ActionTmr.Enabled = bConnected
        ActionCMD = "`m 1"
    End Sub

    Private Sub sw__MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles sw_.MouseUp
        Me.ActionTmr.Enabled = False
        ActionCMD = ""
    End Sub

    Private Sub _ne_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles _ne.MouseDown
        Me.ActionTmr.Enabled = bConnected
        ActionCMD = "`m 9"
    End Sub

    Private Sub _ne_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles _ne.MouseUp
        Me.ActionTmr.Enabled = False
        ActionCMD = ""
    End Sub

    Private Sub _nw_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles _nw.MouseDown
        Me.ActionTmr.Enabled = bConnected
        ActionCMD = "`m 7"
    End Sub

    Private Sub _nw_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles _nw.MouseUp
        Me.ActionTmr.Enabled = False
        ActionCMD = ""
    End Sub

    Private Sub se__Click(sender As Object, e As System.EventArgs) Handles se_.Click
        sndServer("`m 3")
    End Sub

    Private Sub se__MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles se_.MouseDown
        Me.ActionTmr.Enabled = bConnected
        ActionCMD = "`m 3"
    End Sub

    Private Sub se__MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles se_.MouseUp
        Me.ActionTmr.Enabled = False
        ActionCMD = ""
    End Sub
#End Region

    Private Sub ConfigToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigToolStripMenuItem.Click
        Config.Show()
    End Sub

    Private Sub DebugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebugToolStripMenuItem.Click
        Debug.Show()
    End Sub

    Private Sub BTN_Go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Go.Click
        If IsNothing(cBot) Then Exit Sub
        If BTN_Go.Text = "Go!" Then
            If cBot.log Then
                LogStream = New LogStream(setLogName(), cBot.LogPath)
            End If
            simpleProxy = New NetProxy(cMain.Host, cMain.sPort, cBot.lPort)
            With simpleProxy
                .ProcessCMD = cBot.IniFile
                .StandAloneMode = False 'cMain.StandAlone
                .Connect()
                loggingIn = 1
                NewLogFile = True
                ' LogSaveTmr.Enabled = True
                TS_Status_Server.Image = My.Resources.images5
                TS_Status_Client.Image = My.Resources.images5
                BTN_Go.Text = "Connecting..."
            End With

        Else
            sndServer("`quit")
            bConnected = False

            TS_Status_Server.Image = My.Resources.images2
            TS_Status_Client.Image = My.Resources.images2
        End If
    End Sub

    Private Sub toServer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles toServer.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) And bConnected = True Then
            SendTxtToServer()
            e.Handled = True
        End If
    End Sub

    Private Sub sendToServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendToServer.Click
        SendTxtToServer()
    End Sub

    Private Sub SendTxtToServer()
        Dim Txt As String = toServer.Rtf
        Txt = Txt.Replace("\b ", "<b>")
        Txt = Txt.Replace("\b0 ", "</b>")
        Txt = Txt.Replace("\i ", "<i>")
        Txt = Txt.Replace("\i0 ", "</i> ")
        Txt = Txt.Replace("\ul ", "<ul>")
        Txt = Txt.Replace("\ul0 ", "</ul>")
        toServer.Rtf = Txt
        TextToServer(toServer.Text)
        toServer.Text = ""
    End Sub

    Private Sub BTN_Underline_Click(sender As System.Object, e As System.EventArgs) Handles BTN_Underline.Click
        FormatRichTectBox(Me.toServer, FontStyle.Underline)
    End Sub

    Private Sub Btn_Bold_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Bold.Click
        FormatRichTectBox(Me.toServer, FontStyle.Bold)
    End Sub

    Private Sub BTN_Italic_Click(sender As System.Object, e As System.EventArgs) Handles BTN_Italic.Click
        FormatRichTectBox(Me.toServer, FontStyle.Italic)
    End Sub

    Public Sub FormatRichTectBox(ByRef TB As SimpleProxy2.Controls.RichTextBoxEx, _
                          ByRef style As System.Drawing.FontStyle)
        With TB
            If .SelectionFont IsNot Nothing Then
                Dim currentFont As System.Drawing.Font = .SelectionFont
                Dim newFontStyle As System.Drawing.FontStyle

                If .SelectionFont.Bold = True Then
                    newFontStyle = currentFont.Style - style
                ElseIf .SelectionFont.Italic = True Then
                    newFontStyle = currentFont.Style - System.Drawing.FontStyle.Italic
                ElseIf .SelectionFont.Underline = True Then
                    newFontStyle = currentFont.Style - System.Drawing.FontStyle.Underline
                Else
                    newFontStyle = currentFont.Style + style
                End If
                .SelectionFont = New System.Drawing.Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
            End If
        End With
    End Sub

    Private Sub NewBotToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewBotToolStripMenuItem.Click
        With BotSetup
            .BFile = New cBot
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                cBot = .BFile
            End If
        End With


    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        With BotIniOpen
            ' Select Bot ini file
            .InitialDirectory = mPath()
            If .ShowDialog = DialogResult.OK Then
                cBot = New cBot(.FileName)
                ' BotSetup.BotFile = .FileName
                ' BotSetup.ShowDialog()
                Me.EditBotToolStripMenuItem.Enabled = True
            End If

        End With
    End Sub

    Private Sub EditBotToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditBotToolStripMenuItem.Click

        With BotSetup
            .BFile = cBot
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                cBot = .BFile
            End If
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        FormClose()
    End Sub

    Private Sub FormClose()
        _FormClose = True
        My.Settings.MainFormLocation = Me.Location

        'Timers.DestroyTimers()
        'Save the user settings so next time the
        'window will be the same size and location
        SettingsIni.Save(SetFile)
        My.Settings.Save()
        NotifyIcon1.Visible = False

        Me.Dispose()
    End Sub

End Class

