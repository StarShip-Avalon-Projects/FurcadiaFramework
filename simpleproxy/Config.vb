Imports System.IO
Imports SimpleProxy2.IniMod
Imports SimpleProxy2.ConfigStructs
Imports Furcadia.IO


Public Class Config
    Dim MyConfig As New ConfigStructs
    Dim pPath As String = MyConfig.pPath()
    Dim MyIni As New IniMod



    Private Sub BTN_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Cancel.Click
        'Close with out Saving
        Me.Close()
    End Sub

    Private Sub BTN_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Ok.Click
        'apply the Settings
        cMain.Host = TxtBx_CharIni.Text
        cMain.sPort = Convert.ToInt32(TxtSPort.Text)
        cMain.lPort = Convert.ToInt32(TxtHPort.Text)
        cBot.IniFile = TxtBx_CharIni.Text
        'Save the settings to the ini file
        MyIni.IniWrite(pPath & "/Settings.Ini", "Main", "Host", cMain.Host)
        MyIni.IniWrite(pPath & "/Settings.Ini", "Main", "SPort", cMain.sPort)
        MyIni.IniWrite(pPath & "/Settings.Ini", "Main", "LPort", cMain.lPort)
        MyIni.IniWrite(pPath & "/Settings.Ini", "Bot", "BotIni", cBot.IniFile)
        Me.Close()

    End Sub

    Private Sub Config_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LoadConfig()


    End Sub

    Public Sub Loadconfig()
        If (Not System.IO.Directory.Exists(pPath)) Then
            System.IO.Directory.CreateDirectory(pPath)
        End If
        If File.Exists(pPath & "/Settings.Ini") Then
            cMain.Host = MyIni.IniRead(pPath & "/Settings.Ini", "Main", "Host")
            cMain.sPort = MyIni.IniRead(pPath & "/Settings.Ini", "Main", "SPort")
            cMain.lPort = MyIni.IniRead(pPath & "/Settings.Ini", "Main", "LPort")
            cBot.IniFile = MyIni.IniRead(pPath & "/Settings.Ini", "Bot", "BotIni")
        End If
        TxtBx_CharIni.Text = cMain.Host
        TxtSPort.Text = cMain.sPort.ToString
        TxtHPort.Text = cMain.lPort.ToString
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
