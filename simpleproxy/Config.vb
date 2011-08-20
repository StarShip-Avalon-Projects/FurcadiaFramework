Imports System.IO
Imports SimpleProxy2.IniMod
Imports SimpleProxy2.ConfigStructs
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
        'Save the settings to the ini file
        cMain.SaveMainSettings()
        cBot.SaveBotSettings()
        Me.Close()

    End Sub

    Private Sub Config_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LoadConfig()


    End Sub

    Public Sub Loadconfig()
        cMain.LoadMainSettings()
        cBot.LoadBotSettings()
        TxtBx_Server.Text = cMain.Host
        TxtSPort.Text = cMain.sPort.ToString
        TxtHPort.Text = cMain.lPort.ToString
        StandAloneChkBx.Checked = cMain.StandAlone
        TxtBx_CharIni.Text = cBot.IniFile
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

End Class
