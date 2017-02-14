Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports Furcadia.IO
Imports Furcadia.Net
Imports Furcadia.Base220
Imports Furcadia.Base95
Imports Furcadia.Net.Movement
Imports SimpleProxy2.ConfigStructs
Imports SimpleProxy2.Main
Imports System.Timers
Imports SimpleProxy2.ErrorLogging

Public Class Debug


#Region "Properties"

#End Region

#Region "Delegate"
    Delegate Sub AddDataToListCaller(ByRef lb As Object, ByRef obj As Object, ByRef NewColor As fColorEnum)

#End Region




    Private Sub Debug_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Debug = Me.Location
        Me.Dispose()

    End Sub

    Private Sub Debug_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Location = My.Settings.Debug
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
    Public Sub AddDataToList(ByRef lb As Object, ByRef obj As Object, ByRef newColor As Main.fColorEnum)
        If InvokeRequired Then
            Dim dataArray() As Object = {lb, obj, newColor}
            Me.Invoke(New AddDataToListCaller(AddressOf AddDataToList), dataArray)
        Else
            If lb.GetType().ToString = "SimpleProxy2.Controls.RichTextBoxEx" Then
                Dim myColor As System.Drawing.Color = Main.fColor(newColor)
                Dim data As String = obj
                Dim build As New System.Text.StringBuilder(data)
                lb.SelectionStart = lb.TextLength
                lb.BeginUpdate()
                build = build.Replace("<b>", "\b ")
                build = build.Replace("</b>", "\b0 ")
                build = build.Replace("<i>", "\i ")
                build = build.Replace("</i>", "\i0 ")
                build = build.Replace("<ul>", "\ul ")
                build = build.Replace("</ul>", "\ul0 ")
                Dim Images As MatchCollection = Regex.Matches(data, "<img .*?src=[""']?([^'"">]+)[""']?.*?>", RegexOptions.IgnoreCase)
                For Each Image As Match In Images
                    Dim img As String = Image.Groups(1).Value
                    Dim alt As String = Image.Groups(2).Value
                    build = build.Replace(Image.ToString, "IMG:" & img & "::")
                Next
                build = build.Replace("&lt;", "<")
                build = build.Replace("&gt;", ">")
                lb.SelectedRtf = Main.FormatText(build.ToString, newColor)


                'since we Put the Data in the RTB now we Finish Setting the Links
                Dim param() As String = {"<a.*?href=['""](.*?)['""].*?>(.*?)</a>", "<a.*?href=(.*?)>(.*?)</a>"}
                For i As Integer = 0 To param.Length - 1
                    Dim links As MatchCollection = Regex.Matches(lb.Text, param(i), RegexOptions.IgnoreCase)
                    ' links = links & Regex.Matches(lb.Text, "<a.*?href='(.*?)'.*?>(.*?)</a>", RegexOptions.IgnoreCase)
                    For Each match As Match In links
                        Dim matchUrl As String = match.Groups(1).Value
                        Dim matchText As String = match.Groups(2).Value
                        If match.Success Then
                            With lb
                                .Find(match.ToString)
                                .SelectedRtf = Main.FormatURL(matchText & "\v #" & matchUrl & "\v0 ")
                                .find(matchText & "#" & matchUrl)
                                .SetSelectionLink(True)
                            End With
                        End If
                    Next
                Next
                lb.EndUpdate()
            End If
        End If
    End Sub
End Class