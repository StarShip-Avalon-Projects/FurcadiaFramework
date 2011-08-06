
Imports System
Imports System.IO

Imports Furcadia.IO
Imports Furcadia.Net
Imports ConfigStructs


Public Class Main

    Private WithEvents simpleProxy As NetProxy

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



    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Try to get Furcadia's path from the registry
        Loadconfig()

    End Sub

    Public Sub Loadconfig()

    End Sub

    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        simpleProxy = New NetProxy()
        simpleProxy.Connect()
    End Sub

    Private Function onClientDataReceived(ByVal data As String) Handles simpleProxy.ClientData
        AddDataToList(clientList, data)

        If data.StartsWith("desc") = True Or data.StartsWith("chdesc") = True Then
            data += " [SimpleProxy with <a href='http://furcadia.codeplex.com'>Furcadia Framework</a> for Third Party Programs]"

        ElseIf data = "quit" Then

        End If
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
            simpleProxy.SendClient(toClient.Text) : toClient.Text = ""
        Catch
        End Try
    End Sub

    Private Sub sendToServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendToServer.Click
        Try
            simpleProxy.SendServer(toServer.Text) : toServer.Text = ""
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub BTN_Config_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Config.Click
        ' Config.Show()
    End Sub

    Private Function InvokeRequired() As Boolean
        Throw New NotImplementedException
    End Function

    Private Sub Invoke(ByVal addDataToListCaller As SimpleProxy2.Main.AddDataToListCaller, ByVal dataArray As Object())
        Throw New NotImplementedException
    End Sub

End Class

