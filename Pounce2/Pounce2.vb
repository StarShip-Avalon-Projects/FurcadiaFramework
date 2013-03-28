Imports Pounce2.SM_Pounce
Imports System.Text.RegularExpressions

Public Class Pounce2
    Dim pnc As New SM_Pounce
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        pnc.Clearlist()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim str As String = TextBox2.Text
        str = Regex.Replace(str, "[^a-zA-Z0-9\0x0020_.]+", "").ToLower()
        pnc.RemoveFurre(str)
    End Sub

    '30 second timer to scan List

    'Fresh online list after Pounce response processed
    Private Sub RefreshList()
        ' pnc.ScanList()
        Dim cr As TreeNode
        Dim cr2 As TreeNode
        pnc.ReadList()
        TreeView1.BeginUpdate()
        TreeView1.Nodes.Clear()
        cr = TreeView1.Nodes.Add("Online")
        cr2 = TreeView1.Nodes.Add("Offline")
        For Each p As Furre2 In pnc.FriendList
            Dim newnode As New TreeNode(p.name)
            If p.on_last Then
                cr.Nodes.Add(p.name)
                cr.Nodes.Item(p.name).ImageIndex = 1
            Else
                cr2.Nodes.Add(p.name)
                cr2.Nodes.Item(p.name).ImageIndex = 2
            End If
        Next
        TreeView1.EndUpdate()
    End Sub


End Class
