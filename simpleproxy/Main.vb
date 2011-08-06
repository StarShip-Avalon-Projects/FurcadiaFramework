
Imports System
Imports System.IO

Imports Furcadia.IO
Imports Furcadia.Net



Public Class Main

    Private WithEvents simpleProxy As netproxy

    Delegate Sub AddDataToListCaller(ByVal lb As ListBox, ByVal obj As Object)

    Public Sub AddDataToList(ByVal lb As ListBox, ByVal obj As Object)
        If InvokeRequired Then
            Dim dataArray() As Object = {lb, obj}
            Me.Invoke(New AddDataToListCaller(AddressOf AddDataToList), dataArray)
        Else
            While lb.PreferredHeight > lb.Height
                lb.Items.RemoveAt(0)
            End While
            lb.Items.Add(obj)
        End If
    End Sub

    Private Sub browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browse.Click

        ' Search for the Furcadia path manually
        browseDialog.FileName = furcadiaPath.Text
        browseDialog.ShowDialog()
        furcadiaPath.Text = browseDialog.FileName.Substring(0, InStrRev(browseDialog.FileName, "\"))

    End Sub

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Try to get Furcadia's path from the registry
        furcadiaPath.Text = Paths.GetInstallPath

    End Sub

    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        simpleProxy = New NetProxy(Convert.ToInt32(localPort.Text))
        simpleProxy.Connect()
        configGroup.Enabled = False
    End Sub

    Private Function onClientDataReceived(ByVal data As String) Handles simpleProxy.ClientData
        AddDataToList(clientList, data)

        If data.Length > 4 Then If data.Substring(0, 4) = "desc" Or data.Substring(0, 6) = "chdesc" Then data += " [SimpleProxy with Furcadia Framework for Third Party Programs]"

        Return data
    End Function

    Private Function onServerDataReceived(ByVal data As String) Handles simpleProxy.ServerData
        AddDataToList(serverList, data)

        Return data
    End Function

    Protected Overrides Sub Finalize()
        Try
            simpleProxy.Kill()
        Catch
        End Try
        MyBase.Finalize()
    End Sub

    Private Sub sendToClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendToClient.Click
        Try
            simpleProxy.SendClient(toClient.Text & Chr(10)) : toClient.Text = ""
        Catch
        End Try
    End Sub

    Private Sub sendToServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendToServer.Click
        Try
            simpleProxy.SendServer(toServer.Text & Chr(10)) : toServer.Text = ""
        Catch
        End Try
    End Sub
End Class
