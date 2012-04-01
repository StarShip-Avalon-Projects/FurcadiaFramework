Imports System.IO
Imports SimpleProxy2.IniMod
Imports SimpleProxy2.ConfigStructs
Imports System.Drawing.Text
Imports System.Drawing
Imports Furcadia.IO


Public Class Config

    Dim MyConfig As New ConfigStructs
    Dim pPath As String = ConfigStructs.pPath()
    Dim MyIni As New IniMod
    Public cMain As cMain
    Public cBot As cBot

    Private Sub BTN_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Cancel.Click
        'Close with out Saving
        Me.Close()
    End Sub

    Private Sub BTN_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Ok.Click
        'apply the Settings
        cMain.Host = TxtBx_Server.Text
        cMain.sPort = Convert.ToInt32(TxtSPort.Text)
        cMain.lPort = Convert.ToInt32(TxtHPort.Text)
        cMain.StandAlone = Convert.ToBoolean(StandAloneChkBx.Checked)
        cBot.IniFile = TxtBx_CharIni.Text
        cMain.TimeStamp = ChkTimeStamp.CheckState
        Dim face As String = ComboFontFace.SelectedItem
        Dim size As Integer = Convert.ToInt32(ComboFontSize.SelectedItem)
        cMain.ApFont = New Font(face, size)
        cMain.EmitColor = EmitColorBox.BackColor
        cMain.SayColor = SayColorBox.BackColor
        cMain.ShoutColor = ShoutColorBox.BackColor
        cMain.WhColor = WhisperColorBox.BackColor
        cMain.DefaultColor = DefaultColorBox.BackColor
        cMain.LogType = FileExt()
        cMain.LogOption = LogOption()
        cMain.LogNameBase = TxtBxLogName.Text
        cMain.LogPath = TxtBxLogPath.Text
        'Save the settings to the ini file
        cMain.SaveMainSettings()
        cBot.SaveBotSettings()

        Main.InitializeTextControls()
        Me.Dispose()

    End Sub

    Private Sub Config_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.ConfigFormLocation = Me.Location
    End Sub

    Private Sub Config_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Loadconfig()
    End Sub

    Public Sub Loadconfig()
        cMain.LoadMainSettings()
        cBot.LoadBotSettings()
        TxtBx_Server.Text = cMain.Host
        TxtSPort.Text = cMain.sPort.ToString
        TxtHPort.Text = cMain.lPort.ToString
        StandAloneChkBx.Checked = cMain.StandAlone
        TxtBx_CharIni.Text = cBot.IniFile
        ChkTimeStamp.Checked = cMain.TimeStamp
        ' Get the installed fonts collection.
        Dim installed_fonts As New InstalledFontCollection
        ' Get an array of the system's font familiies.
        Dim font_families() As FontFamily = installed_fonts.Families()
        ' Display the font families.
        For Each font_family As FontFamily In font_families
            ComboFontFace.Items.Add(font_family.Name)
        Next (font_family)
        ComboFontFace.SelectedItem = cMain.ApFont.Name
        For i As Integer = 3 To 50
            ComboFontSize.Items.Add(i.ToString)
        Next
        ComboFontSize.SelectedItem = cMain.ApFont.Size.ToString

        EmitColorBox.BackColor = cMain.EmitColor
        SayColorBox.BackColor = cMain.SayColor
        ShoutColorBox.BackColor = cMain.ShoutColor
        WhisperColorBox.BackColor = cMain.WhColor
        DefaultColorBox.BackColor = cMain.DefaultColor
        EmoteColorBox.BackColor = cMain.EmoteColor
        ChckSaveToLog.Checked = cMain.log
        setRadioExt()
        setLogOptions()
        TxtBxLogName.Text = cMain.LogNameBase
        TxtBxLogPath.Text = cMain.LogPath
        Me.Location = My.Settings.ConfigFormLocation
    End Sub

    Public Function FileExt() As String
        If RadioRTF.Checked Then
            Return "rtf"
        ElseIf RadioHTML.Checked Then
            Return "html"
        ElseIf RadioTXT.Checked Then
            Return "txt"
        End If
        Return ""
    End Function

    Public Function LogOption() As Short
        Dim Opt As Short = 0
        If RadioOverwriteLog.Checked Then
            Return Opt
        ElseIf RadioNewFile.Checked Then
            Opt = 1
            If ChkBxTimeStampLog.Checked Then
                Opt = 2
                Return Opt
            End If
            Return Opt
        End If
        Return Opt
    End Function

    Public Sub setLogOptions()
        Select Case cMain.LogOption
            Case 0
                RadioOverwriteLog.Checked = True
                ChkBxTimeStampLog.Checked = False
                ChkBxTimeStampLog.Enabled = False
            Case 1
                RadioNewFile.Checked = True
                ChkBxTimeStampLog.Checked = False
                ChkBxTimeStampLog.Enabled = True
            Case 2
                RadioNewFile.Checked = True
                ChkBxTimeStampLog.Checked = True
                ChkBxTimeStampLog.Enabled = True
        End Select
    End Sub

    Public Sub setRadioExt()
        Select Case cMain.LogType
            Case "rtf"
                RadioRTF.Checked = True
            Case "html"
                RadioHTML.Checked = True
            Case "txt"
                RadioTXT.Checked = True
        End Select
    End Sub


    Private Sub BTN_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Browse.Click

        With browseDialog
            ' Select Character ini file
            .InitialDirectory = Paths.GetFurcadiaDocPath & "\Furcadia Characters\"
            If .ShowDialog = DialogResult.OK Then
                Dim slashPosition As Integer = .FileName.LastIndexOf("\")
                Dim filenameOnly As String = .FileName.Substring(slashPosition + 1)
                TxtBx_CharIni.Text = filenameOnly
            End If
        End With

    End Sub

    Private Sub WhisperColorBox_Click(sender As System.Object, e As System.EventArgs) Handles WhisperColorBox.Click
        GetColor(WhisperColorBox)
    End Sub

    Private Sub ShoutColorBox_Click(sender As System.Object, e As System.EventArgs) Handles ShoutColorBox.Click
        GetColor(ShoutColorBox)
    End Sub

    Private Sub EmitColorBox_Click(sender As System.Object, e As System.EventArgs) Handles EmitColorBox.Click
        GetColor(EmitColorBox)
    End Sub

    Private Sub SayColorBox_Click(sender As System.Object, e As System.EventArgs) Handles SayColorBox.Click
        GetColor(SayColorBox)
    End Sub

    Private Sub DefaultColorBox_Click(sender As System.Object, e As System.EventArgs) Handles DefaultColorBox.Click
        GetColor(DefaultColorBox)
    End Sub

    Private Sub EmoteColorBox_Click(sender As System.Object, e As System.EventArgs) Handles EmoteColorBox.Click
        GetColor(EmoteColorBox)
    End Sub

    Public Sub GetColor(ByRef ColorBX As System.Windows.Forms.PictureBox)
        Dim dlg As New ColorDialog
        dlg.Color = ColorBX.BackColor
        If dlg.ShowDialog() = DialogResult.OK Then
            ColorBX.BackColor = dlg.Color
        End If
    End Sub

    Private Sub ChkTimeStamp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkTimeStamp.CheckedChanged
        cMain.TimeStamp = ChkTimeStamp.CheckState
    End Sub

    Private Sub ChckSaveToLog_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChckSaveToLog.CheckedChanged
        cMain.log = ChckSaveToLog.CheckState
    End Sub

    Private Sub RadioNewFile_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioNewFile.CheckedChanged
        ChkBxTimeStampLog.Enabled = RadioNewFile.Checked
    End Sub
End Class
