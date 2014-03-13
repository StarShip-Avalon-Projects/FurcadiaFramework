Imports System.IO
Imports SimpleProxy2.ConfigStructs
Imports SimpleProxy2.IniFile
Imports System.Drawing.Text
Imports System.Drawing
Imports Furcadia.IO


Public Class Config

    Dim MyConfig As New ConfigStructs
    Dim pPath As String = ConfigStructs.pPath()
    Dim MyIni As New IniFile
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
        cMain.TimeStamp = ChkTimeStamp.CheckState
        Dim face As String = ComboFontFace.SelectedItem
        Dim size As Integer = Convert.ToInt32(ComboFontSize.SelectedItem)
        cMain.ApFont = New Font(face, size)
        cMain.EmitColor = EmitColorBox.BackColor
        cMain.SayColor = SayColorBox.BackColor
        cMain.ShoutColor = ShoutColorBox.BackColor
        cMain.WhColor = WhisperColorBox.BackColor
        cMain.DefaultColor = DefaultColorBox.BackColor

        'Save the settings to the ini file
        cMain.SaveMainSettings()
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
        cMain = New cMain
        TxtBx_Server.Text = cMain.Host
        TxtSPort.Text = cMain.sPort.ToString


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

        Me.Location = My.Settings.ConfigFormLocation
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


End Class
