Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports FurEdVB.FurEd
'Imports Furcadia.Graphics
Imports Furcadia.Drawing.Graphics
Imports System.IO
Imports Furcadia.IO


Partial Public Class FurrePreview
    Inherits UserControl
    Public Sub New()
        InitializeComponent()

        Dim cr As TreeNode

        speciesChooser.BeginUpdate()

        cr = speciesChooser.Nodes.Add("Default Species")
        AddSpecies(cr, "Rodent", 1, 1, 1, 1, _
         2, 15, 20, 0)
        AddSpecies(cr, "Equine", 1, 21, 1, 1, _
         2, 16, 21, 1)
        AddSpecies(cr, "Feline", 1, 41, 1, 1, _
         2, 17, 22, 2)
        AddSpecies(cr, "Canine", 1, 61, 1, 1, _
         2, 18, 23, 3)
        AddSpecies(cr, "Musteline", 1, 81, 1, 1, _
         2, 19, 24, 4)
        AddSpecies(cr, "Lapine", 5, 0, 5, 5, _
         5, 2, 1, 0)
        AddSpecies(cr, "Squirrel", 14, 0, 8, 8, _
         8, 2, 1, 0)
        AddSpecies(cr, "Bovine", 15, 0, 10, 10, _
         10, 2, 1, 0)
        AddSpecies(cr, "Ursine", 20, 0, 12, 12, _
         12, 2, 1, 0)
        AddSpecies(cr, "Bugge", 33, 0, 25, 25, _
         25, 2, 1, 0)

        cr = speciesChooser.Nodes.Add("Classic Wings")
        AddSpecies(cr, "Rodent", 2, 0, 1, 1, _
         2, 15, 20, 0)
        AddSpecies(cr, "Equine", 2, 20, 1, 1, _
         2, 16, 21, 1)
        AddSpecies(cr, "Feline", 2, 40, 1, 1, _
         2, 17, 22, 2)
        AddSpecies(cr, "Canine", 2, 60, 1, 1, _
         2, 18, 23, 3)
        AddSpecies(cr, "Musteline", 2, 80, 1, 1, _
         2, 19, 24, 4)
        AddSpecies(cr, "Lapine", 6, 0, 5, 5, _
         5, 2, 1, 0)
        AddSpecies(cr, "Squirrel", 14, 20, 8, 8, _
         8, 2, 1, 0)
        AddSpecies(cr, "Bovine", 15, 20, 10, 10, _
         10, 2, 1, 0)
        AddSpecies(cr, "Ursine", 20, 20, 12, 12, _
         12, 2, 1, 0)

        cr = speciesChooser.Nodes.Add("Tri Wings")
        AddSpecies(cr, "Rodent", 7, 1, 1, 1, _
         2, 15, 20, 0)
        AddSpecies(cr, "Equine", 7, 21, 1, 1, _
         2, 16, 21, 1)
        AddSpecies(cr, "Feline", 7, 41, 1, 1, _
         2, 17, 22, 2)
        AddSpecies(cr, "Canine", 7, 61, 1, 1, _
         2, 18, 23, 3)
        AddSpecies(cr, "Musteline", 7, 81, 1, 1, _
         2, 19, 24, 4)
        AddSpecies(cr, "Lapine", 8, 0, 5, 5, _
         5, 2, 1, 0)
        AddSpecies(cr, "Squirrel", 14, 40, 8, 8, _
         8, 2, 1, 0)
        AddSpecies(cr, "Bovine", 15, 40, 10, 10, _
         10, 2, 1, 0)
        AddSpecies(cr, "Ursine", 20, 40, 12, 12, _
         12, 2, 1, 0)

        cr = speciesChooser.Nodes.Add("Butterfly Wings")
        AddSpecies(cr, "Rodent", 9, 1, 1, 1, _
         2, 15, 20, 0)
        AddSpecies(cr, "Equine", 9, 21, 1, 1, _
         2, 16, 21, 1)
        AddSpecies(cr, "Feline", 9, 41, 1, 1, _
         2, 17, 22, 2)
        AddSpecies(cr, "Canine", 9, 61, 1, 1, _
         2, 18, 23, 3)
        AddSpecies(cr, "Musteline", 9, 81, 1, 1, _
         2, 19, 24, 4)
        AddSpecies(cr, "Lapine", 10, 0, 5, 5, _
         5, 2, 1, 0)
        AddSpecies(cr, "Squirrel", 14, 60, 8, 8, _
         8, 2, 1, 0)
        AddSpecies(cr, "Bovine", 15, 60, 10, 10, _
         10, 2, 1, 0)
        AddSpecies(cr, "Ursine", 20, 60, 12, 12, _
         12, 2, 1, 0)

        cr = speciesChooser.Nodes.Add("Bat Wings")
        AddSpecies(cr, "Rodent", 13, 0, 1, 1, _
         2, 15, 20, 0)
        AddSpecies(cr, "Equine", 13, 20, 1, 1, _
         2, 16, 21, 1)
        AddSpecies(cr, "Feline", 13, 40, 1, 1, _
         2, 17, 22, 2)
        AddSpecies(cr, "Canine", 13, 60, 1, 1, _
         2, 18, 23, 3)
        AddSpecies(cr, "Musteline", 13, 80, 1, 1, _
         2, 19, 24, 4)
        AddSpecies(cr, "Lapine", 13, 100, 5, 5, _
         5, 2, 1, 0)
        AddSpecies(cr, "Squirrel", 14, 80, 8, 8, _
         8, 2, 1, 0)
        AddSpecies(cr, "Bovine", 15, 80, 10, 10, _
         10, 2, 1, 0)
        AddSpecies(cr, "Ursine", 20, 80, 12, 12, _
         12, 2, 1, 0)

        cr = speciesChooser.Nodes.Add("Prime Wings")
        AddSpecies(cr, "Rodent", 16, 0, 1, 1, _
         2, 15, 20, 0)
        AddSpecies(cr, "Equine", 16, 20, 1, 1, _
         2, 16, 21, 1)
        AddSpecies(cr, "Feline", 16, 40, 1, 1, _
         2, 17, 22, 2)
        AddSpecies(cr, "Canine", 16, 60, 1, 1, _
         2, 18, 23, 3)
        AddSpecies(cr, "Musteline", 16, 80, 1, 1, _
         2, 19, 24, 4)
        AddSpecies(cr, "Lapine", 16, 100, 5, 5, _
         5, 2, 1, 0)
        AddSpecies(cr, "Squirrel", 16, 120, 8, 8, _
         8, 2, 1, 0)
        AddSpecies(cr, "Bovine", 16, 140, 10, 10, _
         10, 2, 1, 0)
        AddSpecies(cr, "Ursine", 20, 100, 12, 12, _
         12, 2, 1, 0)

        cr = speciesChooser.Nodes.Add("Mythicals")
        AddSpecies(cr, "Dragon", 3, 0, 3, 3, _
         3, 2, 1, 0)
        AddSpecies(cr, "Phoenix", 4, 0, 4, 4, _
         4, 2, 1, 0)
        AddSpecies(cr, "Gryffe", 11, 0, 6, 6, _
         6, 2, 1, 0)
        AddSpecies(cr, "Eagle", 12, 0, 7, 7, _
         7, 2, 1, 0)
        AddSpecies(cr, "Kitterwing", 18, 0, 9, 9, _
         9, 2, 1, 0)
        AddSpecies(cr, "Mini Kitter", 17, 0, 9, 9, _
         9, 2, 1, 0)
        AddSpecies(cr, "Unicorn", 28, 0, 21, 21, _
         21, 2, 1, 0)
        AddSpecies(cr, "Kirin", 34, 0, 26, 26, _
         26, 2, 1, 0)
        AddSpecies(cr, "Naga", 55, 0, 41, 41, _
         41, 2, 1, 0)
        AddDynamicSpecies(cr, "Ferian Dragon", 10)
        AddDynamicSpecies(cr, "Ferian Dragon (Fly)", 11)
        AddDynamicSpecies(cr, "Ferian Purrwing", 19)
        AddDynamicSpecies(cr, "Ferian Purrwing (Fly)", 20)

        cr = speciesChooser.Nodes.Add("Ferians")
        AddSpecies(cr, "Wolven", 19, 0, 11, 11, _
         11, 2, 1, 0)
        AddSpecies(cr, "Tygard", 21, 0, 13, 13, _
         13, 2, 1, 0)
        AddSpecies(cr, "Leonen", 22, 0, 14, 14, _
         14, 2, 1, 0)
        AddSpecies(cr, "Foxen", 26, 0, 19, 19, _
         19, 2, 1, 0)
        AddSpecies(cr, "Catten", 41, 0, 30, 30, _
         30, 2, 1, 0)
        AddSpecies(cr, "Owlen", 42, 0, 31, 31, _
         31, 2, 1, 0)
        AddSpecies(cr, "Panooki", 54, 0, 40, 40, _
         40, 2, 1, 0)
        AddDynamicSpecies(cr, "Ottifet", 3)
        AddDynamicSpecies(cr, "Canen", 6)
        AddDynamicSpecies(cr, "Lynxen", 9)
        AddDynamicSpecies(cr, "Squeeken", 13)
        AddDynamicSpecies(cr, "Poneigh", 17)

        cr = speciesChooser.Nodes.Add("Male Avatars")
        AddSpecies(cr, "Furling", 29, 0, 22, 22, _
         22, 2, 1, 0)
        AddSpecies(cr, "Noble Canine", 36, 0, 27, 27, _
         27, 2, 1, 0)
        AddSpecies(cr, "Noble Feline", 38, 0, 28, 28, _
         28, 2, 1, 0)
        AddSpecies(cr, "Noble Equine", 45, 0, 34, 34, _
         34, 2, 1, 0)
        AddSpecies(cr, "Noble Rodent", 50, 0, 38, 38, _
         38, 2, 1, 0)
        AddDynamicSpecies(cr, "Noble Musteline", 4)
        AddDynamicSpecies(cr, "Noble Lapine", 14)
        AddSpecies(cr, "Noble Hyooman", 52, 0, 39, 39, _
         39, 2, 1, 0)

        cr = speciesChooser.Nodes.Add("Female Avatars")
        AddSpecies(cr, "Furling", 30, 0, 22, 22, _
         22, 2, 1, 0)
        AddSpecies(cr, "Noble Canine", 37, 0, 27, 27, _
         27, 2, 1, 0)
        AddSpecies(cr, "Noble Feline", 39, 0, 28, 28, _
         28, 2, 1, 0)
        AddSpecies(cr, "Noble Equine", 46, 0, 34, 34, _
         34, 2, 1, 0)
        AddSpecies(cr, "Noble Rodent", 51, 0, 38, 38, _
         38, 2, 1, 0)
        AddDynamicSpecies(cr, "Noble Musteline", 5)
        AddDynamicSpecies(cr, "Noble Lapine", 15)
        AddSpecies(cr, "Noble Hyooman", 53, 0, 39, 39, _
         39, 2, 1, 0)

        cr = speciesChooser.Nodes.Add("Seasonals")
        AddSpecies(cr, "Kiwi", 2, 100, 18, 18, _
         18, 2, 1, 0)
        AddSpecies(cr, "Werewolf", 23, 0, 15, 15, _
         15, 2, 1, 0)
        AddSpecies(cr, "Penguin", 24, 0, 16, 16, _
         16, 2, 1, 0)
        AddSpecies(cr, "Bat", 25, 0, 17, 17, _
         17, 2, 1, 0)
        AddSpecies(cr, "Flox", 27, 0, 20, 20, _
         20, 2, 1, 0)
        AddSpecies(cr, "Chinchilla", 31, 0, 23, 23, _
         23, 2, 1, 0)
        AddSpecies(cr, "Toasterwing", 32, 0, 24, 24, _
         24, 2, 1, 0)
        AddSpecies(cr, "Reindeer", 40, 0, 29, 29, _
         29, 2, 1, 0)
        AddSpecies(cr, "Lovebird", 43, 0, 32, 32, _
         32, 2, 1, 0)
        AddSpecies(cr, "Woolie", 47, 0, 35, 35, _
         35, 2, 1, 0)
        AddSpecies(cr, "Toytle", 48, 0, 36, 36, _
         36, 2, 1, 0)
        AddSpecies(cr, "Tusker", 49, 0, 37, 37, _
         37, 2, 1, 0)
        AddDynamicSpecies(cr, "Flynx", 7)
        AddDynamicSpecies(cr, "Snayle", 8)
        AddDynamicSpecies(cr, "Fluff", 1)
        AddDynamicSpecies(cr, "Floof", 2)
        AddDynamicSpecies(cr, "Flutterphin", 12)
        AddDynamicSpecies(cr, "Pookie", 16)
        AddDynamicSpecies(cr, "Orchimodo", 18)
        AddDynamicSpecies(cr, "M. Leprechaun", 21)
        AddDynamicSpecies(cr, "F. Leprechaun", 22)
        AddDynamicSpecies(cr, "Love Puppy", 23)
        AddDynamicSpecies(cr, "Pillow", 24)
        AddDynamicSpecies(cr, "M. Easter Bunny", 25)
        AddDynamicSpecies(cr, "F. Easter Bunny", 26)
        speciesChooser.EndUpdate()

        ColourCode = "t##########"
        Gender = 0
    End Sub

    Public Shared PalLoaded As Boolean = False
    Public Shared Palette As Color()
    Public Shared Players As FurcadiaShapes()
    Public Shared Portraits As FurcadiaShapes()

    Public Shared Function CleanupPath(path__1 As String) As String
        Dim sepString As String = Path.DirectorySeparatorChar.ToString()
        If path__1.EndsWith(sepString) Then
            Return path__1
        Else
            Return path__1 & sepString
        End If
    End Function

    Public Shared Sub Prepare()
        If PalLoaded Then
            Return
        End If
        PalLoaded = True

        Dim RawPal As Byte() = My.Resources.furc
        Dim ConvPal As Color() = New Color(255) {}
        Dim FilePos As Integer = 0

        For i As Integer = 0 To 255
            ConvPal(i) = Color.FromArgb(RawPal(FilePos), RawPal(FilePos + 1), RawPal(FilePos + 2))
            FilePos += 3
        Next

        ConvPal(0) = Color.Transparent
        Palette = ConvPal

        Dim DefaultPatchPath As String = CleanupPath(FurcPath.GetDefaultPatchPath())

        Dim DynamicAvatarPath As String = CleanupPath(FurcPath.GetDynAvatarPath())

        Players = New FurcadiaShapes(126) {}
        For i As Integer = 1 To 55
            If i = 35 Then
                Continue For
            End If
            If i = 1 Then
                Players(i) = New FurcadiaShapes(DefaultPatchPath & "player.fsh")
            ElseIf i = 48 Then
                Players(i) = New FurcadiaShapes(DefaultPatchPath & "player48.fox")
            Else
                Players(i) = New FurcadiaShapes(DefaultPatchPath & "player" & i.ToString() & ".fsh")
            End If
        Next

        For i As Integer = 1 To 26
            Players(100 + i) = New FurcadiaShapes(DynamicAvatarPath & "DPlayer" & i.ToString() & ".fox")
        Next

        Portraits = New FurcadiaShapes(126) {}
        For i As Integer = 1 To 41
            If i = 1 Then
                Portraits(i) = New FurcadiaShapes(DefaultPatchPath & "portrait.fsh")
            Else
                Portraits(i) = New FurcadiaShapes(DefaultPatchPath & "portrt" & i.ToString() & ".fsh")
            End If
        Next

        For i As Integer = 1 To 26
            Portraits(100 + i) = New FurcadiaShapes(DynamicAvatarPath & "DPort" & i.ToString() & ".fox")
        Next
    End Sub

    Public Sub LoadStart(species As Integer, gender__1 As Integer)
        If Not Initialised Then
            speciesChooser.SelectedNode = speciesChooser.Nodes(0).Nodes(species)
            Gender = gender__1
            Initialised = True
        End If
    End Sub

    Private _CurrentRemap As Integer

    Public Property CurrentRemap() As Integer
        Get
            Return _CurrentRemap
        End Get
        Set(value As Integer)
            If value = _CurrentRemap Then
                Return
            End If
            _CurrentRemap = value
            If remapMaskCheckBox.Checked Then
                RecreateRemaps()
            End If
        End Set
    End Property

    Private Initialised As Boolean = False
    Private Gender As Integer
    Private PortBitmap As Bitmap
    Private AvatarBitmap As Bitmap
    Private AvatarX As Integer
    Private AvatarY As Integer
    Private AvatarFile As Integer
    Private AvatarOffset As Integer
    Private PortraitMaleFile As Integer
    Private PortraitFemaleFile As Integer
    Private PortraitUnspecFile As Integer
    Private PortraitMaleOffset As Integer
    Private PortraitFemaleOffset As Integer
    Private PortraitUnspecOffset As Integer
    Private AvatarFrame As Integer = 0
    Private ColourCode As String


    'cr = speciesChooser.Nodes.Add("Prime Wings")
    'AddSpecies(cr, "Rodent", 16, 0, 1, 1, _
    '2, 15, 20, 0)
    Private Sub AddSpecies(parent As TreeNode, name As String, afile As Integer, aoffset As Integer, pmfile As Integer, pffile As Integer, _
     pufile As Integer, pm As Integer, pf As Integer, pu As Integer)
        Dim newnode As New TreeNode(name)
        newnode.Tag = String.Format("{0},{1},{2},{3},{4},{5},{6},{7}", afile, aoffset, pmfile, pffile, pufile, _
         pm, pf, pu)
        parent.Nodes.Add(newnode)
    End Sub

    Private Sub AddDynamicSpecies(parent As TreeNode, name As String, number As Integer)
        AddSpecies(parent, name, 100 + number, 0, 100 + number, 100 + number, _
         100 + number, 2, 1, 0)
    End Sub

    Private Sub RecreateRemaps()
        RecreateRemaps(True, True)
    End Sub

    Private Sub RecreateRemaps(doav As Boolean, doport As Boolean)
        If Not PalLoaded Then
            Return
        End If

        If doav Then
            Dim AvatarShape As Shape = Players(AvatarFile).Shapes(AvatarOffset + AvatarFrame)
            Dim oAvatarFrame As Frame = AvatarShape.Frames(0)

            AvatarBitmap = Remapper.Remap(oAvatarFrame.ImageData, oAvatarFrame.Width, oAvatarFrame.Height, ColourCode, If(remapMaskCheckBox.Checked, CurrentRemap, -1))
            AvatarX = oAvatarFrame.FramePos.X + 46
            AvatarY = oAvatarFrame.FramePos.Y + 31
            avatarPreview.Invalidate()
        End If

        If doport Then
            Dim PortShape As Shape = Portraits(1).Shapes(0)
            Select Case Gender
                Case 0
                    PortShape = Portraits(PortraitFemaleFile).Shapes(PortraitFemaleOffset)
                    Exit Select
                Case 1
                    PortShape = Portraits(PortraitMaleFile).Shapes(PortraitMaleOffset)
                    Exit Select
                Case 2
                    PortShape = Portraits(PortraitUnspecFile).Shapes(PortraitUnspecOffset)
                    Exit Select
            End Select

            Dim PortFrame As Frame = PortShape.Frames(0)

            PortBitmap = Remapper.Remap(PortFrame.ImageData, PortFrame.Width, PortFrame.Height, ColourCode, If(remapMaskCheckBox.Checked, CurrentRemap, -1))
            pictureBox2.Image = PortBitmap
        End If
    End Sub

    Private Sub pictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles avatarPreview.Paint
        If AvatarBitmap IsNot Nothing Then
            e.Graphics.DrawImage(AvatarBitmap, AvatarX, AvatarY)
        End If
    End Sub

    Private Sub speciesChooser_AfterSelect1(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles speciesChooser.AfterSelect
        If e.Node.Tag Is Nothing Then
            Return
        End If

        Dim getit As String() = DirectCast(e.Node.Tag, String).Split(","c)
        AvatarFile = Integer.Parse(getit(0))
        AvatarOffset = Integer.Parse(getit(1))
        PortraitMaleFile = Integer.Parse(getit(2))
        PortraitFemaleFile = Integer.Parse(getit(3))
        PortraitUnspecFile = Integer.Parse(getit(4))
        PortraitMaleOffset = Integer.Parse(getit(5))
        PortraitFemaleOffset = Integer.Parse(getit(6))
        PortraitUnspecOffset = Integer.Parse(getit(7))
        RecreateRemaps()
    End Sub


    Public Sub UpdateColourCode(newcc As String)
        ColourCode = newcc
        RecreateRemaps()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Gender = 1
        RecreateRemaps(False, True)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Gender = 0
        RecreateRemaps(False, True)
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Gender = 2
        RecreateRemaps(False, True)
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        AvatarFrame -= 1
        If AvatarFrame < 0 Then
            AvatarFrame = 19
        End If
        RecreateRemaps(True, False)
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        AvatarFrame += 1
        If AvatarFrame > 19 Then
            AvatarFrame = 0
        End If
        RecreateRemaps(True, False)
    End Sub

    Private Sub remapMaskCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles remapMaskCheckBox.CheckedChanged
        RecreateRemaps()
    End Sub


End Class

