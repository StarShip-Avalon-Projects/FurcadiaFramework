
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms
Imports System.IO
Imports System.Text
Imports System.Timers
Imports Furcadia.IO
Imports Furcadia.Net
Imports Furcadia.Base220
Imports Furcadia.Base95
Imports Furcadia.Character
Imports Furcadia.Net.Movement
Imports SimpleProxy2.ConfigStructs
Imports System.Text.RegularExpressions
Imports Furcadia

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
    Public AppFont As New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
    Public DreamCounter As Integer = 0

#End Region

#Region "Events"
    Private WithEvents simpleProxy As NetProxy
    Private ControlThread As Thread = Nothing
    'UpDate Btn-Go Text and Actions Group Enable
    Delegate Sub UpDateBtn_GoCallback(ByVal [text] As Object)
    Delegate Sub UpDateBtn_StandCallback(ByVal [furre] As FURRE)
    Delegate Sub AddDataToListCaller(ByVal lb As Object, ByVal obj As Object)
    Delegate Sub UpDateDreamListCaller(ByVal [dummy] As String)
#End Region

#Region "RegEx filters"
    Private Const EntryFilter As String = "^<font color='([^']*?)'>(.*?)</font>$"
    Private Const NameFilter As String = "<name shortname='([^']*)'(.*)>([\x21-\x3B\=\x3F-\x7E]+)</name>"
    Private Const DescFilter As String = "<desc shortname='([^']*)' />(.*)"
    Private Const ChannelNameFilter As String = "<channel name='([^']*)' />"
    Private Const Iconfilter As String = "<img src='fsh://system.fsh:([^']*)'(.*?)/>"
    Private Const YouSayFilter As String = "You ([\x21-\x3B\=\x3F-\x7E]+), ""([^']*)"""

#End Region

#Region "Helper Functions"
    Public Function fFindNthOccur(ByVal pStr As String, _
                                    ByVal pFind As String, _
                                    ByVal pNth As Integer) As Integer
        '------------------------------------------------------------------
        ' Purpose:   Return location of nth occurence of item in a string.
        ' Coded by:  raskew
        ' Arguments: pStr: The string to be searched.
        '            pFind: The item to search for.
        '            pNth:  The occurence of the item in string.
        ' Input:     From the debug (immediate) window:
        '            x = "The quick brown fox jumped over the lazy dog"
        '            1) ? fFindNthOccur(x, " ", 3)
        '            2) ? left(x, fFindNthOccur(x, " ", 3))
        '            3) ? mid(x, fFindNthOccur(x, " ", 3)+1)
        ' Output:    1) 16
        '            2) The quick brown
        '            3) fox jumped over the lazy dog
        '------------------------------------------------------------------
        Dim strHold As String
        Dim strFind As String
        Dim intHold As Integer
        Dim intSay As Integer
        Dim intKeep As Integer
        Dim n As Integer

        strHold = pStr
        strFind = pFind
        intHold = pNth
        intKeep = 0
        n = 0

        Do While n < intHold
            If InStr(strHold, strFind) = 0 Then
                fFindNthOccur = 0
                Exit Do
            Else
                intSay = InStr(1, strHold, strFind)
                intKeep = intKeep + intSay
                n = n + 1
                strHold = Mid(strHold, intSay + Len(strFind))
                fFindNthOccur = intKeep
            End If
        Loop

    End Function
#End Region


#Region " Methods"
    Public Sub AddDataToList(ByVal lb As Object, ByVal obj As Object)
        If InvokeRequired Then
            Dim dataArray() As Object = {lb, obj}
            Me.Invoke(New AddDataToListCaller(AddressOf AddDataToList), dataArray)
        Else
            If lb.GetType().ToString = "SimpleProxy2.Controls.RichTextBoxEx" Then
                Dim data As String = obj
                Dim build As New System.Text.StringBuilder(data)
                build = build.Replace("<b>", "\b ")
                build = build.Replace("</b>", "\b0 ")
                build = build.Replace("<i>", "\i ")
                build = build.Replace("</i>", "\i0 ")
                build = build.Replace("<ul>", "\ul ")
                build = build.Replace("</ul>", "\ul0 ")

                Dim Images As MatchCollection = Regex.Matches(data, "<img .*?src=[""']?([^'"">]+)[""']?.*?>", RegexOptions.IgnoreCase)
                For Each Image As Match In Images
                    Dim img As String = Image.Groups(1).Value
                    Dim alt As String = Image.Groups(2).Value
                    build = build.Replace(Image.ToString, "IMG:" & img & "::")
                Next
                lb.SelectionStart = lb.TextLength
                lb.SelectedRtf = FormatText(build.ToString)

                lb.BeginUpdate()
                'since we Put the Data in the RTB now we Finish Setting the Links
                Dim links As MatchCollection = Regex.Matches(lb.Text, "<a.*?href=[""']?(.*?)[""']?.*?>(.*?)</a>", RegexOptions.IgnoreCase)
                For Each match As Match In links
                    Dim matchUrl As String = match.Groups(1).Value
                    Dim matchText As String = match.Groups(2).Value
                    If match.Success Then
                        With lb
                            .Find(match.ToString)
                            .SelectedRtf = FormatURL(matchText & "\v #" & matchUrl & "\v0")
                            .find(matchText & "#" & matchUrl)
                            .SetSelectionLink(True)
                        End With
                    End If
                Next
                lb.EndUpdate()
            End If
        End If
    End Sub

    Private Sub log__LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs)
        MsgBox(e.LinkText)
    End Sub

    Public Sub UpDateDreamList(ByVal [dummy] As String)

        If Me.DreamList.InvokeRequired Then
            'Dim dataArray() As Object = {lb, obj}
            Me.Invoke(New UpDateDreamListCaller(AddressOf UpDateDreamList), [dummy])
        Else
            If DreamCounter >= 2 Then Exit Sub
            Dim p As KeyValuePair(Of UInteger, FURRE)
            DreamList.Items.Clear()
            DreamList.BeginUpdate()
            DreamList.Sorted = True
            For Each p In DREAM.List
                DreamList.Items.Add(DREAM.List.Item(p.Key).Name)
            Next
            DreamList.EndUpdate()
            DreamCountTxtBx.Text = DREAM.List.Count.ToString

        End If
    End Sub

    Private Sub DreamListRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DreamListRefresh.Tick
        DreamCounter = 0
    End Sub

    Public Sub sndDisplay(ByVal data As String)
        data = data.Replace(vbLf, vbCrLf)
        If cMain.log Then
            AddDataToList(log_, Microsoft.VisualBasic.TimeString & ": " & data)
        Else
            AddDataToList(log_, data)
        End If
    End Sub

    Public Sub sndServer(ByVal data As String)

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

    End Sub

    Private Sub TextToServer(ByVal arg As String)
        Dim result As String = ""
        'Clean Text input to match Client 
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
    End Sub

    Private Sub ParseServerData(ByVal data As String)
        Player.Clear()
        'Dim emitColor As Color = Color.Blue
        'Dim sayColor As Color = Color.DarkGoldenrod
        'Dim shoutColor As Color = Color.DarkRed
        'Dim whColor As Color = Color.Purple

        Try
            If data = "Dragonroar" Then
                loggingIn = 1
                '  Login Sucessful
            ElseIf data = "&&&&&&&&&&&&&" Then
                loggingIn = 2

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
            ElseIf data.StartsWith("]f") Then
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

        Catch e As Exception
            Console.WriteLine(e.Message & vbCr & e.StackTrace)
            'ErrLog(e.Message & vbLf & e.StackTrace)
        End Try

    End Sub

    ''' <summary>
    ''' Channel Parser
    ''' RegEx Style Processing here
    ''' </summary>
    ''' <param name="data"></param>
    ''' <remarks></remarks>
    Public Sub ChannelProcess(ByVal data As String)
        'Strip the trigger Character
        data = data.Remove(0, 1)
        Dim Channel As String = Regex.Match(data, EntryFilter).Groups(1).ToString()
        Dim Text As String = Regex.Match(data, EntryFilter).Groups(2).ToString()
        Dim ShortUser As String = Regex.Match(data, NameFilter).Groups(1).ToString()
        Dim User As String = Regex.Match(data, NameFilter).Groups(3).ToString()
        If User <> "" Then
            Player = ShortNametoFurre(ShortUser)
        End If
        Dim Desc As String = Regex.Match(data, DescFilter).Groups(2).ToString()
        Dim r As New Regex(Iconfilter)
        Text = r.Replace(Text, "")
        Dim s As New Regex(ChannelNameFilter)
        Text = s.Replace(Text, "")

        If Channel = "success" Then
            sndDisplay("[" & fIcon(data) & "> " & Text)

        ElseIf Channel = "dragonspeak" OrElse Channel = "emit" Then
            sndDisplay("[" & fIcon(data) & "] " & Text)
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
            Dim u As Match = Regex.Match(data, "[(.*?)](.*?)</")
            sndDisplay("[" & fIcon(data) & "> [" & u.Groups(1).Value & "]" & u.Groups(2).Value)

            ''SAY
        ElseIf Channel = "myspeech" Then
            Dim t As New Regex(YouSayFilter)
            Dim u As String = t.Match(data).Groups(1).ToString
            Text = t.Match(data).Groups(2).ToString
            sndDisplay("You " & u & ", """ & Text & """")
        ElseIf User <> "" And Channel = "" Then
            Dim tt As Match = Regex.Match(data, "\(you see(.*?)\)", RegexOptions.IgnoreCase)
            Dim t As New Regex(NameFilter)
            If Not tt.Success Then
                Text = t.Replace(data, "")
                Text = Text.Remove(0, 2)
                sndDisplay(User & " says, """ & Text & """")
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
                    sndDisplay("You " & u & ", """ & Text & """")
                Else
                    Text = Regex.Match(data, "shouts: (.*)</font>").Groups(1).ToString()
                    sndDisplay(User & " shouts, """ & Text & """")
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
                Dim QCMD As String = Regex.Match(data, "href='command://(.*)'>").Groups(1).ToString
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
                    sndDisplay(User & " whispers""" & WhisperFrom & """ to you.")
                    '    TriggerCmd(MS0_WHISPER)
                    '    TriggerCmd(MS0_WHISPEREX)
                    '   TriggerCmd(MS0_WHISPERMSG)
                    '    TriggerCmd(MS0_WHISPERMSGEX)
                    '    TriggerCmd(MS0_WHISPERANY)
                    '   TriggerCmd(MS0_WHISPERANYEX)
                Else
                    WhisperTo = WhisperTo.Replace("<wnd>", "")
                    sndDisplay("You whisper""" & WhisperTo & """ to " & User & ".")
                End If

            ElseIf Channel = "emote" Then
                ' ''EMOTE
                sndDisplay(User & " emotes: " & Text)
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
                    'UpDateDreamList("")
                    'bdreamenter = True
                Else
                    ' If bClientOpen = False Then sndServer("vascodagama")
                    'TriggerCmd(MS0_LOGIN)
                    ' loggingIn = False
                    ' bdreamenter = True
                End If


            Else
                sndDisplay("## Unknown Command ## " & data)
            End If
    End Sub

    Private Function ShortNametoFurre(ByVal sname As String) As FURRE
        Dim Character As KeyValuePair(Of UInteger, FURRE)
        For Each Character In DREAM.List
            If Character.Value.ShortName = sname Then
                Return Character.Value
            End If
        Next
    End Function

    Private Function LongNameToShortName(ByVal Name As String) As String
        Return Regex.Replace(Name.ToLower(), "[^a-zA-Z0-9\0x0020_.]+", "")
    End Function

    Private Function fIcon(ByVal data As String) As String
        Dim MyIcon As String = Regex.Match(data, Iconfilter).Groups(1).ToString()
        Select Case MyIcon
            Case "86"
                MyIcon = "#"
            Case "91"
                MyIcon = "+"
        End Select
        Return MyIcon
    End Function

    Public Function IsBot(ByVal player As FURRE) As Boolean
        If player.ShortName <> BotName Then Return False
        Bot = player
        If BtnSit_stand_Lie.InvokeRequired Then
            Dim d As New UpDateBtn_StandCallback(AddressOf IsBot)
            Me.Invoke(d, [player])
        Else
            'Update inteface
            Select Case Bot.Position
                Case 0
                    BtnSit_stand_Lie.Text = "Stand"
                Case 1
                    BtnSit_stand_Lie.Text = "Lay"
                Case 2
                    BtnSit_stand_Lie.Text = "Lay"
                Case 3
                    BtnSit_stand_Lie.Text = "Lay"
                Case 4
                    BtnSit_stand_Lie.Text = "Stand"
                Case 5
                    BtnSit_stand_Lie.Text = "Lay"
                Case 6
                    BtnSit_stand_Lie.Text = "Lay"
                Case 7
                    BtnSit_stand_Lie.Text = "Lay"
                Case 8
                    BtnSit_stand_Lie.Text = "Stand"
                Case 9
                    BtnSit_stand_Lie.Text = "Lay"
                Case 10
                    BtnSit_stand_Lie.Text = "Lay"
                Case 11
                    BtnSit_stand_Lie.Text = "Lay"
                Case 12
                    BtnSit_stand_Lie.Text = "Stand"
                Case 13
                    BtnSit_stand_Lie.Text = "Lay"
                Case 14
                    BtnSit_stand_Lie.Text = "Lay"
                Case 15
                    BtnSit_stand_Lie.Text = "Lay"
                Case 16
                    BtnSit_stand_Lie.Text = "Sit"
                Case 17
                    BtnSit_stand_Lie.Text = "Sit"
                Case 18
                    BtnSit_stand_Lie.Text = "Sit"
                Case 19
                    BtnSit_stand_Lie.Text = "Sit"
                Case Else

            End Select
            Return True
        End If
    End Function

#End Region

    Private Function onClientDataReceived(ByVal data As String) Handles simpleProxy.ClientData
        If data.StartsWith("desc") = True Or data.StartsWith("chdesc") = True Then
            data += " [SimpleProxy with <a href='http://furcadia.codeplex.com'>Furcadia Framework</a> for Third Party Programs]"
        End If
        If data = "vascodagama" Then
            loggingIn = 2
        End If

        'Capture The Bots Name
        If data.StartsWith("connect") Then
            Dim test As String = data.Replace("connect ", "")
            test = test.TrimStart(" ")
            BotName = test.Substring(0, test.IndexOf(" "))
            BotName = BotName.Replace("|", "")
            BotName = BotName.Replace("[^a-zA-Z0-9\0x0020_.]+", "").ToLower()
        End If

        Return data
    End Function

    Private Sub ClientExit() Handles simpleProxy.ClientExited
        If cMain.StandAlone = False Then test3()

    End Sub
    Private Sub ServerClose() Handles simpleProxy.ServerDisConnected
        test3()
        simpleProxy.Kill()
        bConnected = False
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
        bConnected = True
    End Sub

    Private Sub sendToServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextToServer(toServer.Text)
        toServer.Text = ""
    End Sub

    Sub test3()

        If Me.BTN_Go.InvokeRequired Then
            Dim d As New UpDateBtn_GoCallback(AddressOf test3)
            Me.Invoke(d, New Object() {[Text]})
        Else
            If BTN_Go.Text = "Connected." Then
                '  bConnected = True
                sndDisplay("Connecting...")
                BTN_Go.Text = "Go!"
            ElseIf BTN_Go.Text = "Connecting..." Then 'bConnected = True And
                BTN_Go.Text = "Connected."
            End If
        End If

    End Sub

    Public Function FormatText(ByVal data As String) As String

        Dim FontSize As Integer = AppFont.Size
        Dim FontFace As String = AppFont.Name
        FontSize *= 2
        Return "{\rtf1\ansi\ansicpg1252\deff0\deflang1044{\fonttbl{\f0\fcharset0 " & FontFace & ";}}\viewkind4\uc1\fs" & FontSize.ToString & " " & data & " \par}"
    End Function
    Public Function FormatURL(ByVal data As String) As String
        Dim FontSize As Integer = AppFont.Size
        Dim FontFace As String = AppFont.Name
        FontSize *= 2
        Return "{\rtf1\ansi\ansicpg1252\deff0\deflang1044{\fonttbl{\f0\fcharset0 " & FontFace & ";}}\viewkind4\uc1\fs" & FontSize.ToString & " " & data & "}"
    End Function

    Private Sub BTN_Config_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Config.Click
        Config.Show()
    End Sub

    Private Sub BTN_Go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Go.Click
        Me.ControlThread = New Thread(New ThreadStart(AddressOf Me.test3))
        If BTN_Go.Text = "Go!" Then
            simpleProxy = New NetProxy(cMain.Host, cMain.sPort, cMain.lPort)
            With simpleProxy
                .ProcessCMD = cBot.IniFile
                .StandAloneMode = False 'cMain.StandAlone
                .Connect()
                Look = False
                BTN_Go.Text = "Connecting..."
            End With
            loggingIn = 1
        Else
            sndServer("`quit")
            bConnected = False
        End If
        Me.ControlThread.Start()
    End Sub

    Private Sub Main_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Try to get Furcadia's path from the registry
        cMain.LoadMainSettings()
        cBot.LoadBotSettings()
        InitializeTextControls()
    End Sub

    Public Sub InitializeTextControls()
        toServer.Font = AppFont
        DreamList.Font = AppFont
        DreamCountTxtBx.Font = AppFont
    End Sub

    Private Sub toServer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles toServer.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Try
                TextToServer(toServer.Text)
                toServer.Text = ""
            Catch
            End Try
            e.Handled = True
        End If
    End Sub

#Region "Action Controls"

    Private Sub ActionTmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionTmr.Tick
        sndServer(ActionCMD)
    End Sub

    Private Sub _ne_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _ne.MouseUp
        If Not bConnected Then Exit Sub
        Me.ActionTmr.Enabled = False
        ActionCMD = ""
    End Sub

    Private Sub _ne_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _ne.Click
        If Not bConnected Then Exit Sub
        sndServer("`m 9")
    End Sub

    Private Sub _ne_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _ne.MouseDown
        If Not bConnected Then Exit Sub
        Me.ActionTmr.Enabled = True
        ActionCMD = "`m 9"
    End Sub

    Private Sub _nw_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _nw.Click
        If Not bConnected Then Exit Sub
        sndServer("`m 7")
    End Sub

    Private Sub _nw_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _nw.MouseDown
        If Not bConnected Then Exit Sub
        Me.ActionTmr.Enabled = True
        ActionCMD = "`m 7"
    End Sub

    Private Sub _nw_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _nw.MouseUp
        If Not bConnected Then Exit Sub
        Me.ActionTmr.Enabled = False
        ActionCMD = ""
    End Sub

    Private Sub se__MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles se_.MouseDown
        If Not bConnected Then Exit Sub
        Me.ActionTmr.Enabled = True
        ActionCMD = "`m 3"
    End Sub

    Private Sub se__MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles se_.MouseUp
        If Not bConnected Then Exit Sub
        Me.ActionTmr.Enabled = False
        ActionCMD = ""
    End Sub

    Private Sub se__Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles se_.Click
        If Not bConnected Then Exit Sub
        sndServer("`m 3")
    End Sub

    Private Sub sw__Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sw_.Click
        If Not bConnected Then Exit Sub
        sndServer("`m 1")
    End Sub
    Private Sub sw__MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sw_.MouseDown
        If Not bConnected Then Exit Sub
        Me.ActionTmr.Enabled = True
        ActionCMD = "`m 1"
    End Sub

    Private Sub sw__MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sw_.MouseUp
        If Not bConnected Then Exit Sub
        Me.ActionTmr.Enabled = False
        ActionCMD = ""
    End Sub

    Private Sub get__Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles get_.Click
        If Not bConnected Then Exit Sub
        sndServer("`get")
    End Sub

    Private Sub use__Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles use_.Click
        If Not bConnected Then Exit Sub
        sndServer("`use")
    End Sub

    Private Sub BTN_TurnL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_TurnL.Click
        If Not bConnected Then Exit Sub
        sndServer("`<")
    End Sub

    Private Sub BTN_TurnR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_TurnR.Click
        If Not bConnected Then Exit Sub
        sndServer("`>")
    End Sub

    Private Sub BtnSit_stand_Lie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSit_stand_Lie.Click
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


#End Region

End Class

