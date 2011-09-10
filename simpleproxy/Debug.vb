Public Class Debug

    Private Sub Debug_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Debug = Me.Location
    End Sub

    Private Sub Debug_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Location = My.Settings.Debug
    End Sub
End Class