Imports System.Windows.Forms
Imports SimpleProxy2.ConfigStructs
Imports Furcadia.IO
Imports System.IO

Public Class BotSetup

    Dim pPath As String = ConfigStructs.pPath()

    Public BFile As New cBot


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        BFile.BotFile = TxtBxBotIni.Text
        Dim BotFileName As String = ""

        BFile.lPort = Convert.ToInt32(TxtHPort.Text)
        BFile.IniFile = TxtBx_CharIni.Text



        BFile.LogOption = LogOption()
        BFile.LogNameBase = TxtBxLogName.Text
        BFile.LogPath = TxtBxLogPath.Text
        BFile.log = ChckSaveToLog.Checked
        If BFile.log And IsNothing(callbk.LogStream) Then
            callbk.LogStream = New LogStream(callbk.setLogName(), BFile.LogPath)
        End If
        BFile.SaveBotSettings()

        Me.Close()

    End Sub



    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


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
        Select Case BFile.LogOption
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


    Private Sub BotSetup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

 

        TxtHPort.Text = BFile.lPort.ToString
        TxtBx_CharIni.Text = BFile.IniFile
        TxtBxBotIni.Text = BFile.BotFile


        ChckSaveToLog.Checked = BFile.log
        setLogOptions()
        TxtBxLogName.Text = BFile.LogNameBase
        TxtBxLogPath.Text = BFile.LogPath
    End Sub

    Private Sub BTN_Browse_Click(sender As System.Object, e As System.EventArgs) Handles BTN_Browse.Click
        With IniBrowseDialog
            ' Select Character ini file
            If Directory.Exists(FurcPath.GetFurcadiaDocPath & "Furcadia Characters") Then
                .InitialDirectory = FurcPath.GetFurcadiaDocPath & "Furcadia Characters"
            Else
                .InitialDirectory = FurcPath.GetFurcadiaDocPath
            End If
            If .ShowDialog = DialogResult.OK Then
                Dim slashPosition As Integer = .FileName.LastIndexOf("/")
                Dim filenameOnly As String = .FileName.Substring(slashPosition + 1)
                TxtBx_CharIni.Text = filenameOnly
            End If
        End With
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        With IniBrowse
            ' Select Character ini file
            .InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
         "/Simple Proxy/Logs")
            .RestoreDirectory = True
            If .ShowDialog = DialogResult.OK Then
                Dim filenameOnly As String = Path.GetFileNameWithoutExtension(.FileName)
                TxtBxLogName.Text = filenameOnly
                TxtBxLogPath.Text = Path.GetFullPath(.FileName)
            End If
        End With
    End Sub


    Private Sub RadioNewFile_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioNewFile.CheckedChanged
        ChkBxTimeStampLog.Enabled = RadioNewFile.Checked
    End Sub

End Class
