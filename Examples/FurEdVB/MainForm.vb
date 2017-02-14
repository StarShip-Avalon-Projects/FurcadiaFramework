Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Furcadia.Drawing.Graphics


Partial Public Class MainForm
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private lastINIPath As String = ""

  

    Private Sub loadButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click
        LoadINI()
    End Sub

    Private Function LoadINI() As Boolean
        If chooseIniFileDialog.ShowDialog() <> DialogResult.OK Then
            Return False
        End If

        Dim IniText As String() = System.IO.File.ReadAllLines(chooseIniFileDialog.FileName)
        For Each line As String In IniText
            If line.StartsWith("Colors=") Then
                LoadColourCode(line.Substring(7))
            End If
            If line.StartsWith("Desc=") Then
                TxtBxDescription.Text = line.Substring(5)
            End If

        Next

        lastINIPath = chooseIniFileDialog.FileName
        saveButton.Enabled = True

        Return True
    End Function

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        saveIniFileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(lastINIPath)
        saveIniFileDialog.FileName = System.IO.Path.GetFileName(lastINIPath)

        If saveIniFileDialog.ShowDialog() = DialogResult.OK Then
            Dim IniText As String() = System.IO.File.ReadAllLines(chooseIniFileDialog.FileName)
            Dim idx As Integer = 0
            Dim linenum As Integer = -1
            For Each line As String In IniText
                If line.StartsWith("Colors=") Then
                    linenum = idx
                    Exit For
                End If
                idx += 1
            Next
            If linenum <> -1 Then
                IniText(linenum) = "Colors=" & ColourCode & SpeciesBlock
            End If
            System.IO.File.WriteAllLines(saveIniFileDialog.FileName, IniText)
        End If
    End Sub

    Private ColourCode As String
    Private SpeciesBlock As String

    Private Function LoadColourCode(colourcode__1 As String) As Boolean
        If colourcode__1.Length <> 14 OrElse colourcode__1(0) <> "t"c Then
            System.Windows.Forms.MessageBox.Show("Invalid colour code!")
            Return False
        End If

        ColourCode = colourcode__1.Substring(0, 11)
        SpeciesBlock = colourcode__1.Substring(11)
        'FurrePreview1.LoadStart(AscW(colourcode__1.Chars(12)) - 35, AscW(colourcode__1.Chars(11)) - 35)
        CustomFurrePreview1.LoadStart(AscW(colourcode__1.Chars(12)) - 35, AscW(colourcode__1.Chars(11)) - 35)
        Dim FurColour As Integer = AscW(colourcode__1.Chars(1)) - 35
        Dim MarkingsColour As Integer = AscW(colourcode__1.Chars(2)) - 35
        Dim HairColour As Integer = AscW(colourcode__1.Chars(3)) - 35
        Dim EyeColour As Integer = AscW(colourcode__1.Chars(4)) - 35
        Dim BadgeColour As Integer = AscW(colourcode__1.Chars(5)) - 35
        Dim VestColour As Integer = AscW(colourcode__1.Chars(6)) - 35
        Dim BracerColour As Integer = AscW(colourcode__1.Chars(7)) - 35
        Dim CapeColour As Integer = AscW(colourcode__1.Chars(8)) - 35
        Dim BootColour As Integer = AscW(colourcode__1.Chars(9)) - 35
        Dim TrousersColour As Integer = AscW(colourcode__1.Chars(10)) - 35

        UpdatingColours = True
        furListBox.SelectedIndex = FurColour
        markingListBox.SelectedIndex = MarkingsColour
        hairListBox.SelectedIndex = HairColour
        eyeListBox.SelectedIndex = EyeColour
        badgeListBox.SelectedIndex = BadgeColour
        vestListBox.SelectedIndex = VestColour
        bracerListBox.SelectedIndex = BracerColour
        capeListBox.SelectedIndex = CapeColour
        bootsListBox.SelectedIndex = BootColour
        trouserListBox.SelectedIndex = TrousersColour
        UpdatingColours = False

        'FurrePreview1.UpdateColourCode(ColourCode)
        CustomFurrePreview1.UpdateColourCode(ColourCode)
        colourCodeTextBox.Text = ColourCode & SpeciesBlock
        Return True
    End Function

    Private UpdatingColours As Boolean = False

    Private Sub RenderColourChoice(sender As Object, e As DrawItemEventArgs) _
        Handles badgeListBox.DrawItem, bootsListBox.DrawItem, bracerListBox.DrawItem, _
        capeListBox.DrawItem, eyeListBox.DrawItem, furListBox.DrawItem, hairListBox.DrawItem, _
        markingListBox.DrawItem, trouserListBox.DrawItem, vestListBox.DrawItem
        'bool big = !(sender == badgeListBox || sender == hairListBox);
        Dim big As Boolean = True

        e.DrawBackground()
        e.DrawFocusRectangle()

        Dim giver As ListBox = TryCast(sender, ListBox)
        Dim TextArea As Rectangle = e.Bounds
        TextArea.X += (If(big, 68, 34))
        'e.Graphics.DrawString((string)giver.Items[e.Index], e.Font, new SolidBrush(e.ForeColor), e.Bounds.Location);
        TextRenderer.DrawText(e.Graphics, DirectCast(giver.Items(e.Index), String), e.Font, TextArea, e.ForeColor, e.BackColor, _
         TextFormatFlags.Left)

        Dim Target As Byte() = Nothing

        If giver.Name = badgeListBox.Name Then
            Target = New Byte(7) {}
            For i As Integer = 0 To 7
                Target(i) = Remapper.BadgeRemap(e.Index)
            Next
        ElseIf giver.Name = bracerListBox.Name Then
            Target = Remapper.BracersRemap(e.Index)
        ElseIf giver.Name = bootsListBox.Name Then
            Target = Remapper.BootRemap(e.Index)
        ElseIf giver.Name = capeListBox.Name Then
            Target = Remapper.CapeRemap(e.Index)
        ElseIf giver.Name = eyeListBox.Name Then
            Target = New Byte(7) {}
            For i As Integer = 0 To 7
                Target(i) = Remapper.EyeRemap(e.Index)
            Next
        ElseIf giver.Name = furListBox.Name Then
            Target = Remapper.FurRemap(e.Index)
        ElseIf giver.Name = hairListBox.Name Then
            Target = Remapper.HairRemap(e.Index)
        ElseIf giver.Name = markingListBox.Name Then
            Target = Remapper.MarkingsRemap(e.Index)
        ElseIf giver.Name = trouserListBox.Name Then
            Target = Remapper.TrousersRemap(e.Index)
        ElseIf giver.Name = vestListBox.Name Then
            Target = Remapper.VestRemap(e.Index)
        End If

        Dim dX As Integer = e.Bounds.X + 2
        Dim dY As Integer = e.Bounds.Y + 3
        'For i As Integer = 0 To 7
        '    e.Graphics.FillRectangle(New SolidBrush(FurrePreview.Palette(Target(i))), dX, dY, (If(big, 8, 4)), 8)
        '    dX += (If(big, 8, 4))
        'Next
        For i As Integer = 0 To 7
            e.Graphics.FillRectangle(New SolidBrush(CustomFurrePreview1.Palette(Target(i))), dX, dY, (If(big, 8, 4)), 8)
            dX += (If(big, 8, 4))
        Next
        Dim BorderBrush As Brush = New SolidBrush(e.BackColor)
        e.Graphics.FillRectangle(BorderBrush, e.Bounds.X + 2, e.Bounds.Y + 3, 1, 1)
        e.Graphics.FillRectangle(BorderBrush, e.Bounds.X + 2, e.Bounds.Y + 10, 1, 1)
        e.Graphics.FillRectangle(BorderBrush, e.Bounds.X + (If(big, 65, 33)), e.Bounds.Y + 3, 1, 1)
        e.Graphics.FillRectangle(BorderBrush, e.Bounds.X + (If(big, 65, 33)), e.Bounds.Y + 10, 1, 1)
    End Sub

    Private Function GetNumberForListBox(giver As ListBox) As Integer
        If giver.Name = furListBox.Name Then
            Return 0
        ElseIf giver.Name = markingListBox.Name Then
            Return 1
        ElseIf giver.Name = hairListBox.Name Then
            Return 2
        ElseIf giver.Name = eyeListBox.Name Then
            Return 3
        ElseIf giver.Name = badgeListBox.Name Then
            Return 4
        ElseIf giver.Name = vestListBox.Name Then
            Return 5
        ElseIf giver.Name = bracerListBox.Name Then
            Return 6
        ElseIf giver.Name = capeListBox.Name Then
            Return 7
        ElseIf giver.Name = bootsListBox.Name Then
            Return 8
        ElseIf giver.Name = trouserListBox.Name Then
            Return 9
        End If

        Return -1
    End Function

    Private Sub ChangeColourChoice(sender As Object, e As EventArgs) _
        Handles badgeListBox.SelectedIndexChanged, bootsListBox.SelectedIndexChanged, bracerListBox.SelectedIndexChanged, _
        capeListBox.SelectedIndexChanged, eyeListBox.SelectedIndexChanged, furListBox.SelectedIndexChanged, hairListBox.SelectedIndexChanged, _
        markingListBox.SelectedIndexChanged, trouserListBox.SelectedIndexChanged, vestListBox.SelectedIndexChanged

        If UpdatingColours Then
            Return
        End If

        Dim giver As ListBox = TryCast(sender, ListBox)
        Dim modify As Integer = GetNumberForListBox(giver) + 1

        ColourCode = ColourCode.Substring(0, modify) & (ChrW(giver.SelectedIndex + 35)).ToString() & ColourCode.Substring(modify + 1)
        'FurrePreview1.UpdateColourCode(ColourCode)
        CustomFurrePreview1.UpdateColourCode(ColourCode)
        colourCodeTextBox.Text = ColourCode & SpeciesBlock
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles loadButton.Click
        LoadColourCode(colourCodeTextBox.Text)
    End Sub

    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click

        MessageBox.Show("Treeki's Extended Colour Code Editor" & vbLf & vbLf & "Originally created October 2009." & vbLf & "Updated and re-released December 2011" & vbLf & vbLf & "Thanks to Kylix for the FOX code which I cannibalised :p", "About")
    End Sub

    ' Badge
    ' Bracers
    ' Boots
    ' Cape
    ' Eyes
    ' Fur
    ' Hair
    ' Markings
    ' Trousers
    ' Vest
    Shared tabIndicesToNumbers As Integer() = New Integer() {
        4,
        6,
        8,
        7,
        3,
        0,
        2,
        1,
        9,
        5}

    Private Sub tabControl1_SelectedIndexChanged1(sender As Object, e As System.EventArgs) Handles tabControl1.SelectedIndexChanged
        Dim number As Integer = tabIndicesToNumbers(tabControl1.SelectedIndex)

        'FurrePreview1.CurrentRemap = number
        CustomFurrePreview1.CurrentRemap = number
    End Sub

    Private Sub MainForm_Load1(sender As Object, e As System.EventArgs) Handles Me.Load
        Furcpath = New Furcadia.IO.Paths()

        'FurrePreview.Prepare()
        CustomFurrePreview1.Prepare()

        chooseIniFileDialog.InitialDirectory = FurcPath.GetFurcadiaDocPath + "Furcadia Characters"



        LoadColourCode("t#############")
        saveButton.Enabled = False


        'LoadColourCode("t89J,I@,,&;$%#");

        tabControl1.SelectTab(5)
    End Sub

    Private Sub DreamToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DreamToolStripMenuItem.Click

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        With PatchBrowser
            .SelectedPath = FurcPath.GetFurcadiaDocPath()
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                CustomFurrePreview1.PatchPath = .SelectedPath
                CustomFurrePreview1.Prepare()
            End If
        End With
    End Sub
End Class

