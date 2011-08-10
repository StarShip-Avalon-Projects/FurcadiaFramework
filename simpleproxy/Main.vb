
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms
Imports System.IO
Imports System.Timers
Imports Furcadia.IO
Imports Furcadia.Net
Imports Furcadia.Base220
Imports Furcadia.Net.Movement
Imports SimpleProxy2.ConfigStructs
Imports System.Text.RegularExpressions

Public Class Main
    Inherits Form

#Region "Propertes"
    Dim Player As New FURRE
    Dim loggingIn As Boolean = False
    Dim DREAM As New DREAM

#End Region

#Region "Events"
    Private WithEvents simpleProxy As NetProxy
    Private ControlThread As Thread = Nothing

    'UpDate Btn-Go Text and Actions Group Enable
    Delegate Sub UpDateBtn_GoCallback(ByVal [text] As String)
    Delegate Sub AddDataToListCaller(ByVal lb As ListBox, ByVal obj As Object)
#End Region
#Region " Methods"
    Public Sub AddDataToList(ByVal lb As ListBox, ByVal obj As Object)
        If InvokeRequired Then
            Dim dataArray() As Object = {lb, obj}
            Me.Invoke(New AddDataToListCaller(AddressOf AddDataToList), dataArray)
        Else
            While lb.PreferredHeight > 100
                lb.Items.RemoveAt(0)
            End While
            lb.Items.Add(obj)
        End If
    End Sub

    Public Sub sndServer(ByVal data As String)

        If data.StartsWith("m ") Then
            ' TriggerCmd(MS0_MOVE)
            Select Case data.Substring(0, 2)
                Case "7"
                    '     TriggerCmd(MS0_MOVENW)
                Case "9"
                    '   TriggerCmd(MS0_MOVENE)
                Case "1"
                    '  TriggerCmd(MS0_MOVESW)
                Case "3"
                    '  TriggerCmd(MS0_MOVESE)
            End Select
        End If

        TextToServer(data)

    End Sub

    Private Sub TextToServer(ByVal arg As String)
        Dim result As String = ""
        'Clean Text input to match Client 
        Select Case arg.Substring(0, 1)
            Case "`"
                result = arg
            Case "/"
                result = "wh %" & arg
            Case ":"
                result = ":" & arg
            Case "-"
                result = "-" & arg
            Case Else
                result = Chr(34) & arg
        End Select
        simpleProxy.SendServer(result & Chr(10))
    End Sub

    Private Sub ParseServerData(ByVal data As String)
        'Variable Clearage
        Player.Clear()
        'sayMsg = ""
        'sayName = ""
        'emoteMsg = ""
        'emoteName = ""
        'shoutMsg = ""
        'shoutName = ""
        'whName = ""
        'whMsg = ""
        'emitName = ""
        'emitMsg = ""
        'onlnName = ""
        ' followRequester = ""
        ' joinRequester = ""
        ' leadRequester = ""
        ' summonRequester = ""

        'End Variable Clearage
        'Dim emitColor As Color = Color.Blue
        'Dim sayColor As Color = Color.DarkGoldenrod
        'Dim shoutColor As Color = Color.DarkRed
        'Dim whColor As Color = Color.Purple


        '//-- MODIFICATION: Command implementation (using RegEx to tag whispers).
        '  $match = preg_match( "/^\\(<font color='([a-z0-9]+)'>\\[ <name shortname='([a-z0-9]+)' src='whisper-from'>([^<]+)<\\/name> whispers, \"(.*)\" to you\\. \\]<\\/font>$/", $line, $matches );


        Try
            If data = "Dragonroar" Then
                loggingIn = True
            ElseIf data.StartsWith("(<img src='fsh://system.fsh:") = True And InStr(data, "Lines of DragonSpeak") <> 0 Then
                'data = data.Replace("\<(.*)\>", "")
                'DREAM.Lines = Integer.Parse(StrTrimLeft(data, data.LastIndexOf(":") + 1).Trim)
                'sndServer(Chr(34) & "dreamurl")
                'bdreamenter = False
            ElseIf InStr(data, "<A HREF=" & Chr(34) & "furc://") Then
                'DREAM.URL = StrBetween(data, Chr(34), Chr(34))
                'DREAM.URL = StrTrimRight(DREAM.URL, DREAM.URL.Length - InStr(DREAM.URL, Chr(34)) + 1)
                'DREAM.Name = DREAM.URL.Replace("furc://", "")
                'If InStr(DREAM.Name, ":") <> 0 Then
                '    DREAM.Name = StrLeft(DREAM.Name, InStr(DREAM.Name, ":"))
                'Else
                '    DREAM.Name = DREAM.Name.Remove(DREAM.Name.LastIndexOf("/"), 1)
                'End If
            ElseIf data.StartsWith("(<img src='fsh://system.fsh:86'  />") = True And InStr(data, "players in the dream of ") <> 0 Then

                'Deprciated.. Furre list tracking now Handled Client Side via 
                ' Spawn and remove triggers

                'data = RegExpReplace(data, "\<(.*?)\>", "").Replace("(", "").TrimStart(" ")
                'DREAM.Name = StrTrimLeft(data, InStr(data, "of") + 2).Replace(".", "")
                'data = data.Replace(DREAM.Name, "")
                'dNumFurres = Integer.Parse(RegExp(data, "\d*").Replace(" ", ""))

            ElseIf data.StartsWith("<") And loggingIn = True Then
                Player.ID = ConvertFromBase220(data.Substring(1, 4))
                Player.X = ConvertFromBase220(data.Substring(5, 2))
                Player.Y = ConvertFromBase220(data.Substring(7, 2))
                Player.Shape = ConvertFromBase220(data.Substring(8, 2))
                Dim NameLength As UInteger = ConvertFromBase220(data.Substring(11, 1))
                Player.Name = data.Substring(12, NameLength).Replace("|", " ")
                Dim ColTypePos As UInteger = 12 + NameLength
                Player.ColorType = data.Substring(ColTypePos, 1)
                Dim ColorSize As UInteger = 12
                If Player.ColorType <> "t" Then
                    ColorSize = 30
                End If
                Dim sColorPos As UInteger = ColTypePos + 1
                Dim sColor As String = data.Substring(ColTypePos, ColorSize)
                Dim FlagPos As UInteger = sColorPos + 1
                Player.Flag = ConvertFromBase220(data.Substring(FlagPos, 1))
                Dim AFK_Pos As UInteger = FlagPos + 1
                Player.AFK = New TimeSpan(ConvertFromBase220(ConvertFromBase220(data.Substring(AFK_Pos, 1))) * TimeSpan.TicksPerSecond)

                ' Add New Arrivals to Dream List
                If DREAM.List.ContainsKey(Player.ID) = False And (Player.Flag - Flags.CHAR_FLAG_NEW_AVATAR = 0) Then
                    DREAM.List.Add(Player.ID, Player)
                End If

                '     TriggerCmd(MS0_FENTER)
                '   TriggerCmd(MS0_FENTEREX)

                'Remove Furre
            ElseIf data.StartsWith(")") <> 0 And loggingIn = False Then
                Dim remID As UInteger = ConvertFromBase220(data.Substring(2, 4))
                ' remove departure from List
                If DREAM.List.ContainsKey(remID) = True Then
                    DREAM.List.Remove(remID)
                    'Player.Name = DREAM.List.Item(remID).Name
                    'Player.ID = DREAM.List.Item(remID).ID
                    'Player.Color = DREAM.List.Item(remID).Color
                    'Player.X = DREAM.List.Item(remID).X
                    'Player.Y = DREAM.List.Item(remID).Y
                    '  TriggerCmd(MS0_FLEAVE)
                    '  TriggerCmd(MS0_FLEAVEEX)
                End If

                'Animated Move
            ElseIf data.StartsWith("/") <> 0 And loggingIn = False Then
                Player.ID = ConvertFromBase220(data.Substring(1, 4))
                Player.X = ConvertFromBase220(data.Substring(5, 2))
                Player.Y = ConvertFromBase220(data.Substring(7, 2))
                Player.Shape = ConvertFromBase220(data.Substring(8, 2))
                Dim found As Boolean = False
                If DREAM.List.ContainsKey(Player.ID) = True Then
                    found = True
                    DREAM.List.Item(Player.ID) = Player
                    '     TriggerCmd(MS0_FMOVE)
                    '    TriggerCmd(MS0_FMOVEEX)
                End If


                ' Move Avatar
            ElseIf data.StartsWith("A") <> 0 And loggingIn = False Then
                Player.ID = ConvertFromBase220(data.Substring(1, 4))
                Player.X = ConvertFromBase220(data.Substring(5, 2))
                Player.Y = ConvertFromBase220(data.Substring(7, 2))
                Player.Shape = ConvertFromBase220(data.Substring(8, 2))
                Dim found As Boolean = False
                'If Player.X = X And Player.Y = Y Then Exit Sub
                If DREAM.List.ContainsKey(Player.ID) = True Then
                    found = True
                    DREAM.List.Item(Player.ID) = Player
                End If
                'If found = True And X <= BOT.X + 10 And Y <= BOT.Y + 10 Then
                '    '  TriggerCmd(MS0_FVIEW)
                '    '  TriggerCmd(MS0_FVIEWEX)
                'End If
                ' Update Color Code
            ElseIf data.StartsWith("B") <> 0 And loggingIn = False Then
                Player.ID = ConvertFromBase220(data.Substring(1, 4))
                Player.X = ConvertFromBase220(data.Substring(5, 2))
                Player.Y = ConvertFromBase220(data.Substring(7, 2))
                Dim ColTypePos As UInteger = 17
                Player.ColorType = data.Substring(ColTypePos, 1)
                Dim ColorSize As UInteger = 14
                If Player.ColorType <> "t" Then
                    ColorSize = 30
                End If
                Dim sColorPos As UInteger = ColTypePos + 1
                Player.Color = data.Substring(sColorPos, ColorSize)
                DREAM.List.Item(Player.ID) = Player

                'Hide Avatar
            ElseIf data.StartsWith("C") <> 0 And loggingIn = False Then
                Player.ID = ConvertFromBase220(data.Substring(1, 4))
                Player.X = ConvertFromBase220(data.Substring(5, 2))
                Player.Y = ConvertFromBase220(data.Substring(7, 2))

                Dim found As Boolean = False
                If DREAM.List.ContainsKey(Player.ID) = True Then
                    found = True
                    DREAM.List.Item(Player.ID) = Player
                End If


                'If found = True And X <= UInteger.Parse(BOT.X) + 10 And Y <= UInteger.Parse(BOT.Y) + 10 Then
                '    '  TriggerCmd(MS0_FNVIEW)
                '    ' TriggerCmd(MS0_FNVIEWEX)
                'End If

            ElseIf data.StartsWith(";") = True OrElse data.StartsWith("]q") Then
                DREAM.List.Clear()
            ElseIf data.StartsWith("(<img src='fsh://system.fsh:86'  /> Dream Standard:") <> 0 Then
                If loggingIn = False Then
                    ' If bClientOpen = False Then sndServer("vascodagama")
                    DREAM.List.Clear()
                    'bdreamenter = True
                Else
                    ' If bClientOpen = False Then sndServer("vascodagama")
                    'TriggerCmd(MS0_LOGIN)
                    loggingIn = False
                    ' bdreamenter = True
                End If
            ElseIf data.StartsWith("]%1") = True Then
                'Player.Name = data.Substring(3)
                'sndDisplay(Player.Name & " is Online")
                'TriggerCmd(MS0_ONLINE)
                'TriggerCmd(MS0_ONLINEEX)
                'TODO: Add a timer for online checking then complete this dang thing
            ElseIf data.StartsWith("]%0") = True Then
                'Player.Name = data.Substring(3)
                'sndDisplay(Player.Name & " is Offline")
                'TriggerCmd(MS0_OFFLINE)
                'TriggerCmd(MS0_OFFLINEEX)
                'TODO: Add a timer for online checking then complete this dang thing
            ElseIf data.StartsWith("(<font color='emit'><img src='fsh://system.fsh:91' alt='@emit' /><channel name='@emit' />") = True Then
                ''EMIT
                'emitMsg = StrTrimLeft(StrTrimLeft(data, InStr(data, "<channel name='@emit' />")), 23).Replace("</font>", "")
                'Player.Msg = emitMsg
                ' TriggerCmd(MS0_EMIT)
                ' TriggerCmd(MS0_EMITANY)
                ' TriggerCmd(MS0_EMITMSG)
            ElseIf data.StartsWith("(<font color='dragonspeak'><img src='fsh://system.fsh:91' alt='@emit' /><channel name='@emit' />") = True Then
                ''EMIT
                'emitMsg = StrTrimLeft(StrTrimLeft(data, InStr(data, "<channel name='@emit' />")), 23).Replace("</font>", "")
                'Player.Msg = emitMsg
                '  TriggerCmd(MS0_EMIT)
                '  TriggerCmd(MS0_EMITANY)
                '  TriggerCmd(MS0_EMITMSG)
            ElseIf InStr(data, "</name>:") Then
                ''SAY
                'sayName = StrTrimRight(StrTrimLeft(RegExp(data, "'>(.*?)</"), 2), 2)
                'sayMsg = StrTrimLeft(StrTrimLeft(data, InStr(data, "</name>")), 8).Replace("</font>", "")
                'Player.Msg = sayMsg
                'Player.Name = sayName
                'sndDisplay(Player.Name & " says: " & Player.Msg)
            ElseIf InStr(data, "(<font color='shout'>{S}") Then
                ''SHOUT
                'shoutMsg = StrTrimRight(StrTrimLeft(RegExp(data, "</name>(.*?)</font>"), 16), 7)
                'shoutName = StrTrimRight(RegExpReplace(RegExp(data, "\<name (.*?)\<\/n"), "\<(.*?)\>", ""), 3)
                'Player.Msg = shoutMsg
                'Player.Name = shoutName
                'sndDisplay(Player.Name & " shouts: " & Player.Msg)
                'If String.Compare(Player.Name, BOT.Name) <> 0 Then
                '    '    TriggerCmd(MS0_SAY)
                '    '    TriggerCmd(MS0_SAYEX)
                '    '    TriggerCmd(MS0_SAYANY)
                '    ''    TriggerCmd(MS0_SAYANYEX)
                '    '    TriggerCmd(MS0_SAYMSG)
                '    '    TriggerCmd(MS0_SAYMSGEX)
                'End If
            ElseIf InStr(data, "<a href='command://join'>click here</a>") Then
                ''JOIN
                'joinRequester = StrTrimRight(RegExpReplace(RegExp(data, "\<name (.*?)\<\/n"), "\<(.*?)\>", ""), 3)
                'PLAYER.Name = joinRequester
                'sndDisplay(PLAYER.Name & " requests to join.")
                'If String.Compare(PLAYER.Name, BOT.Name) <> 0 Then
                '    '   TriggerCmd(MS0_JOIN)
                '    '   TriggerCmd(MS0_JOINEX)
                'End If
            ElseIf InStr(data, "<a href='command://summon'>click here</a>") Then
                ''SUMMON
                'summonRequester = StrTrimRight(RegExpReplace(RegExp(data, "\<name (.*?)\<\/n"), "\<(.*?)\>", ""), 3)
                'PLAYER.Name = summonRequester
                'sndDisplay(PLAYER.Name & " requests a summon.")
                'If String.Compare(PLAYER.Name, BOT.Name) <> 0 Then
                '    '  TriggerCmd(MS0_SUMMON)
                '    '  TriggerCmd(MS0_SUMMONEX)
                'End If
            ElseIf InStr(data, "<a href='command://follow'>click here</a>") Then
                ''LEAD
                'followRequester = StrTrimRight(RegExpReplace(RegExp(data, "\<name (.*?)\<\/n"), "\<(.*?)\>", ""), 3)
                'PLAYER.Name = followRequester
                'sndDisplay(PLAYER.Name & " requests to lead.")
                'If String.Compare(PLAYER.Name, BOT.Name) <> 0 Then
                '    PLAYER.Name = ""
                '    ' TriggerCmd(MS0_LEAD)
                '    PLAYER.Name = followRequester
                '    '  TriggerCmd(MS0_LEADEX)
                'End If
            ElseIf InStr(data, "<a href='command://lead'>click here</a>") Then
                ''FOLLOW
                'leadRequester = StrTrimRight(RegExpReplace(RegExp(data, "\<name (.*?)\<\/n"), "\<(.*?)\>", ""), 3)
                'PLAYER.Name = leadRequester
                'sndDisplay(PLAYER.Name & " requests the bot to follow.")
                'If String.Compare(PLAYER.Name, BOT.Name) <> 0 Then
                '    PLAYER.Name = ""
                '    '  TriggerCmd(MS0_FOLLOW)
                '    PLAYER.Name = leadRequester
                '    ' TriggerCmd(MS0_FOLLOWEX)
                'End If
            ElseIf data.StartsWith("(<font color='whisper'>[ <name shortname=") = True Then
                ''WHISPER
                'whName = RegExpReplace(data, "\<(.*?)\>", "")
                'whName = RegExpReplace(whName, "whispers\,(.*) to you\. \]", "$1").Replace("([ ", "")
                'whName = RegExpReplace(whName, Chr(&H22) & "(.*?)" & Chr(&H22), "").Trim()
                'Player.Name = whName.Trim
                'whMsg = RegExpReplace(data, "\<(.*?)\>", "")
                'whMsg = RegExpReplace(whMsg, "whispers\,(.*) to you\. \]", "$1").Replace("([ ", "")
                'whMsg = RegExp(whMsg, Chr(&H22) & "(.*?)" & Chr(&H22)).Replace(Chr(&H22), "")
                'Player.Msg = whMsg
                'sndDisplay(Player.Name.Trim & " whispers: " & Player.Msg)
                'If String.Compare(Player.Name, BOT.Name) <> 0 Then
                '    '    TriggerCmd(MS0_WHISPER)
                '    '    TriggerCmd(MS0_WHISPEREX)
                '    '   TriggerCmd(MS0_WHISPERMSG)
                '    '    TriggerCmd(MS0_WHISPERMSGEX)
                '    '    TriggerCmd(MS0_WHISPERANY)
                '    '   TriggerCmd(MS0_WHISPERANYEX)
                'End If
            ElseIf data.StartsWith("(<font color='emote'>") = True Then
                ' ''EMOTE
                'emoteName = RegExpReplace(StrTrimRight(StrTrimLeft(RegExp(data, "'>(.*?)</"), 2), 2), "\<(.*?)\>", "")
                'emoteMsg = StrTrimLeft(StrTrimLeft(data, InStr(data, "</name>")), 7).Replace("</font>", "")
                'Player.Name = emoteName
                'Player.Msg = emoteMsg
                'sndDisplay(Player.Name & " emotes: " & Player.Msg)
                'If String.Compare(Player.Name, BOT.Name) <> 0 Then
                '    '    TriggerCmd(MS0_EMOTE)
                '    '    TriggerCmd(MS0_EMOTEEX)
                '    '    TriggerCmd(MS0_EMOTEANY)
                '    '    TriggerCmd(MS0_EMOTEANYEX)
                '    '    TriggerCmd(MS0_EMOTEMSG)
                '    '    TriggerCmd(MS0_EMOTEMSGEX)
                'End If
            ElseIf data.StartsWith("(<img src='fsh://system.fsh:86'  /> Furcadia Standard Time:") = True Then
                'Dim temp As String
                'temp = RegExpReplace(data, "\(\<(.*?)\>\s", "")
                'temp = StrTrimLeft(temp, InStr(temp, ":") + 1)
                'furcTime = Date.UtcNow.AddHours(5).ToLongTimeString().Split(" "c)
                'MS.TriggerCmd(MS.MS0_FURCTIME)
                '*************ERRORS***************
            ElseIf data.StartsWith("(Communication") Then
                'sndDisplay("Error: Communication Error.  Aborting connection.")
                'Disconnect()
            ElseIf data.StartsWith("(<font color='error'>Please use at least one letter (a-z, A-Z, 0-9) of the name so I can tell exactly who you mean!  -- Beekin the Help Dragon</font>") Then
                'sndDisplay("Error: Whisper attempt failed.")
            End If
        Catch e As Exception
            Console.WriteLine(e.Message & vbCr & e.StackTrace)
            'ErrLog(e.Message & vbLf & e.StackTrace)
        End Try

    End Sub

#End Region
    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs)

        ' Try to get Furcadia's path from the registry
        Config.Loadconfig()

    End Sub


    Private Function onClientDataReceived(ByVal data As String) Handles simpleProxy.ClientData
        AddDataToList(ServerList, data)

        If data.StartsWith("desc") = True Or data.StartsWith("chdesc") = True Then
            data += " [SimpleProxy with <a href='http://furcadia.codeplex.com'>Furcadia Framework</a> for Third Party Programs]"
        End If
        Return data
    End Function

    Private Sub ClientExit() Handles simpleProxy.ClientExited
        If cMain.StandAlone = False Then test3()
    End Sub
    Private Sub ServerClose() Handles simpleProxy.ServerDisConnected
        test3()
        'simpleProxy.ClientKill()
    End Sub

    Private Function onServerDataReceived(ByVal data As String) Handles simpleProxy.ServerData
        AddDataToList(ServerList, data)

        Return data
    End Function

    Protected Overrides Sub Finalize()
        Try
            simpleProxy.Kill()
        Catch
        End Try
        MyBase.Finalize()
    End Sub



    Private Sub toServer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Try
                TextToServer(toServer.Text)
                toServer.Text = ""
            Catch
            End Try
            'This tells the system not to process
            'the key, as you've already taken care 
            'of it 
            e.Handled = True
        End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub GrpAction_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub GrpAction_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GrpAction.MouseDown

    End Sub

    Public Sub OnConnected() Handles simpleProxy.Connected

        test3()
    End Sub

    Private Sub BTN_Go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ControlThread = New Thread(New ThreadStart(AddressOf Me.test3))
        If BTN_Go.Text = "Go!" Then
            simpleProxy = New NetProxy(cMain.Host, cMain.sPort, cMain.lPort)
            simpleProxy.ProcessCMD = cBot.IniFile
            simpleProxy.StandAloneMode = cMain.StandAlone
            simpleProxy.Connect()
            BTN_Go.Text = "Connecting..."
        Else
            simpleProxy.SendServer("quit" & vbLf)

        End If
        Me.ControlThread.Start()
    End Sub


    Private Sub sendToServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        TextToServer(toServer.Text)
        toServer.Text = ""

    End Sub

    Private Sub BTN_Config_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Config.Show()
    End Sub


    Sub test3()

        If Me.BTN_Go.InvokeRequired Then
            Dim d As New UpDateBtn_GoCallback(AddressOf test3)
            Me.Invoke(d, New Object() {[Text]})
        Else
            If BTN_Go.Text = "Connected." Then
                BTN_Go.Text = "Go!"
            ElseIf simpleProxy.IsServerConnected = True And BTN_Go.Text = "Connecting..." Then
                BTN_Go.Text = "Connected."
            End If
        End If

    End Sub

    Private Sub StandAloneChkBx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StandAloneChkBx.CheckedChanged
        cMain.StandAlone = StandAloneChkBx.Checked
        If simpleProxy Is DBNull.Value = True Then
            simpleProxy.StandAloneMode = cMain.StandAlone
        End If
    End Sub
End Class

