<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.saveButton = New System.Windows.Forms.Button()
        Me.trouserListBox = New System.Windows.Forms.ListBox()
        Me.tabPage9 = New System.Windows.Forms.TabPage()
        Me.markingListBox = New System.Windows.Forms.ListBox()
        Me.tabPage8 = New System.Windows.Forms.TabPage()
        Me.hairListBox = New System.Windows.Forms.ListBox()
        Me.tabPage10 = New System.Windows.Forms.TabPage()
        Me.vestListBox = New System.Windows.Forms.ListBox()
        Me.aboutButton = New System.Windows.Forms.Button()
        Me.saveIniFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.chooseIniFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.setButton = New System.Windows.Forms.Button()
        Me.colourCodeTextBox = New System.Windows.Forms.TextBox()
        Me.tabPage7 = New System.Windows.Forms.TabPage()
        Me.furListBox = New System.Windows.Forms.ListBox()
        Me.bracerListBox = New System.Windows.Forms.ListBox()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.badgeListBox = New System.Windows.Forms.ListBox()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.bootsListBox = New System.Windows.Forms.ListBox()
        Me.tabPage4 = New System.Windows.Forms.TabPage()
        Me.capeListBox = New System.Windows.Forms.ListBox()
        Me.tabPage5 = New System.Windows.Forms.TabPage()
        Me.eyeListBox = New System.Windows.Forms.ListBox()
        Me.tabPage6 = New System.Windows.Forms.TabPage()
        Me.loadButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBxDescription = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DreamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectPatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CustomFurrePreview1 = New FurEdVB.CustomFurrePreview()
        Me.PatchBrowser = New FurEdVB.FileFolderDialog()
        Me.tabPage9.SuspendLayout()
        Me.tabPage8.SuspendLayout()
        Me.tabPage10.SuspendLayout()
        Me.tabPage7.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPage3.SuspendLayout()
        Me.tabPage4.SuspendLayout()
        Me.tabPage5.SuspendLayout()
        Me.tabPage6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(601, 38)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(42, 21)
        Me.saveButton.TabIndex = 15
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'trouserListBox
        '
        Me.trouserListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trouserListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.trouserListBox.FormattingEnabled = True
        Me.trouserListBox.IntegralHeight = False
        Me.trouserListBox.Items.AddRange(New Object() {"Red", "Horse Brown", "Gray Brown", "Fox Orange", "Cream Brown", "Yellow", "Pea Green", "Grass Green", "Avocado", "Sea Blue", "Blue Gray", "Wolf Gray", "Arctic", "Violet Blue", "Spring Green", "Burgundy", "Green Yellow", "Light Chocolate", "Dark Chocolate", "Light Navy", "Dark Navy", "Light Dust", "Dark Dust", "Gray", "Black", "Light Mule", "Dark Mule", "Violet", "Royal Blue", "White"})
        Me.trouserListBox.Location = New System.Drawing.Point(3, 3)
        Me.trouserListBox.Name = "trouserListBox"
        Me.trouserListBox.Size = New System.Drawing.Size(229, 416)
        Me.trouserListBox.TabIndex = 4
        Me.trouserListBox.Tag = ""
        '
        'tabPage9
        '
        Me.tabPage9.Controls.Add(Me.trouserListBox)
        Me.tabPage9.Location = New System.Drawing.Point(4, 40)
        Me.tabPage9.Name = "tabPage9"
        Me.tabPage9.Size = New System.Drawing.Size(235, 422)
        Me.tabPage9.TabIndex = 8
        Me.tabPage9.Text = "Trousers"
        Me.tabPage9.UseVisualStyleBackColor = True
        '
        'markingListBox
        '
        Me.markingListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.markingListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.markingListBox.FormattingEnabled = True
        Me.markingListBox.IntegralHeight = False
        Me.markingListBox.Items.AddRange(New Object() {"Cat Gray", "Arctic", "Black", "Mule Tan", "Dust", "Chocolate", "Lavender", "Wolf Gray", "Fox Orange", "Horse Brown", "Tawny", "Mocha", "Ruddy", "Cream", "Yellow", "Grass Green", "Burgundy", "Pinewood", "Sea Blue", "Violet", "Red", "White", "Navy", "Cloudy Gray", "Royal Blue"})
        Me.markingListBox.Location = New System.Drawing.Point(3, 3)
        Me.markingListBox.Name = "markingListBox"
        Me.markingListBox.Size = New System.Drawing.Size(229, 416)
        Me.markingListBox.TabIndex = 5
        Me.markingListBox.Tag = ""
        '
        'tabPage8
        '
        Me.tabPage8.Controls.Add(Me.markingListBox)
        Me.tabPage8.Location = New System.Drawing.Point(4, 40)
        Me.tabPage8.Name = "tabPage8"
        Me.tabPage8.Size = New System.Drawing.Size(235, 422)
        Me.tabPage8.TabIndex = 7
        Me.tabPage8.Text = "Markings"
        Me.tabPage8.UseVisualStyleBackColor = True
        '
        'hairListBox
        '
        Me.hairListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hairListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.hairListBox.FormattingEnabled = True
        Me.hairListBox.IntegralHeight = False
        Me.hairListBox.Items.AddRange(New Object() {"Blood Red", "Courage Red", "Merry Red", "Ember Orange", "Hearty Brown", "Burnt Orange", "Busy Orange", "August Orange", "Noble Brown", "Mahogany", "Clever Maize", "Pure Gold", "Moon Yellow", "Sun Yellow", "Tan", "Woodland Green", "Friendly Green", "Lucky Green", "Travelers Green", "Aquacyan", "Deepsea Blue", "Proud Blue", "Lightsky Blue", "Syndira Blue", "Straight Blue", "Royal Purple", "Lonely Orchid", "Spiritual Purple", "Mad Green", "Royal Blue", "Passion", "Bliss Red", "Blush Pink", "Twilight Sigh", "Dreamer Blue", "Shadow Gray", "Neutral Gray", "Tragic Gray", "Winter Gray", "Indigo", "Black", "Cloudy Gray", "White", "Pinewood", "Green Yellow"})
        Me.hairListBox.Location = New System.Drawing.Point(3, 3)
        Me.hairListBox.Name = "hairListBox"
        Me.hairListBox.Size = New System.Drawing.Size(229, 416)
        Me.hairListBox.TabIndex = 5
        Me.hairListBox.Tag = ""
        '
        'tabPage10
        '
        Me.tabPage10.Controls.Add(Me.vestListBox)
        Me.tabPage10.Location = New System.Drawing.Point(4, 40)
        Me.tabPage10.Name = "tabPage10"
        Me.tabPage10.Size = New System.Drawing.Size(235, 422)
        Me.tabPage10.TabIndex = 9
        Me.tabPage10.Text = "Vest"
        Me.tabPage10.UseVisualStyleBackColor = True
        '
        'vestListBox
        '
        Me.vestListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vestListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.vestListBox.FormattingEnabled = True
        Me.vestListBox.IntegralHeight = False
        Me.vestListBox.Items.AddRange(New Object() {"Red", "Horse Brown", "Gray Brown", "Fox Orange", "Cream Brown", "Yellow", "Pea Green", "Grass Green", "Avocado", "Sea Blue", "Blue Gray", "Wolf Gray", "Arctic", "Violet Blue", "Spring Green", "Burgundy", "Green Yellow", "Light Chocolate", "Dark Chocolate", "Light Navy", "Dark Navy", "Light Dust", "Dark Dust", "Gray", "Black", "Light Mule", "Dark Mule", "Violet", "Royal Blue", "White"})
        Me.vestListBox.Location = New System.Drawing.Point(3, 3)
        Me.vestListBox.Name = "vestListBox"
        Me.vestListBox.Size = New System.Drawing.Size(229, 416)
        Me.vestListBox.TabIndex = 5
        Me.vestListBox.Tag = ""
        '
        'aboutButton
        '
        Me.aboutButton.Location = New System.Drawing.Point(643, 38)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(21, 21)
        Me.aboutButton.TabIndex = 19
        Me.aboutButton.Text = "?"
        Me.aboutButton.UseVisualStyleBackColor = True
        '
        'saveIniFileDialog
        '
        Me.saveIniFileDialog.Filter = "Furcadia Characters (*.ini)|*.ini|All files (*.*)|*.*"
        Me.saveIniFileDialog.Title = "Choose a filename for this INI"
        '
        'chooseIniFileDialog
        '
        Me.chooseIniFileDialog.Filter = "Furcadia Characters (*.ini)|*.ini|All files (*.*)|*.*"
        Me.chooseIniFileDialog.Title = "Choose a Furcadia character to edit its colours"
        '
        'setButton
        '
        Me.setButton.Location = New System.Drawing.Point(569, 38)
        Me.setButton.Name = "setButton"
        Me.setButton.Size = New System.Drawing.Size(32, 21)
        Me.setButton.TabIndex = 18
        Me.setButton.Text = "Set"
        Me.setButton.UseVisualStyleBackColor = True
        '
        'colourCodeTextBox
        '
        Me.colourCodeTextBox.Location = New System.Drawing.Point(463, 39)
        Me.colourCodeTextBox.Name = "colourCodeTextBox"
        Me.colourCodeTextBox.Size = New System.Drawing.Size(105, 20)
        Me.colourCodeTextBox.TabIndex = 17
        '
        'tabPage7
        '
        Me.tabPage7.Controls.Add(Me.hairListBox)
        Me.tabPage7.Location = New System.Drawing.Point(4, 40)
        Me.tabPage7.Name = "tabPage7"
        Me.tabPage7.Size = New System.Drawing.Size(235, 422)
        Me.tabPage7.TabIndex = 6
        Me.tabPage7.Text = "Hair"
        Me.tabPage7.UseVisualStyleBackColor = True
        '
        'furListBox
        '
        Me.furListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.furListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.furListBox.FormattingEnabled = True
        Me.furListBox.IntegralHeight = False
        Me.furListBox.Items.AddRange(New Object() {"Cat Gray", "Arctic", "Black", "Mule Tan", "Dust", "Chocolate", "Lavender", "Wolf Gray", "Fox Orange", "Horse Brown", "Tawny", "Mocha", "Ruddy", "Cream", "Yellow", "Grass Green", "Burgundy", "Pinewood", "Sea Blue", "Violet", "Red", "White", "Navy", "Cloudy Gray", "Royal Blue"})
        Me.furListBox.Location = New System.Drawing.Point(3, 3)
        Me.furListBox.Name = "furListBox"
        Me.furListBox.Size = New System.Drawing.Size(229, 416)
        Me.furListBox.TabIndex = 4
        Me.furListBox.Tag = ""
        '
        'bracerListBox
        '
        Me.bracerListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bracerListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.bracerListBox.FormattingEnabled = True
        Me.bracerListBox.IntegralHeight = False
        Me.bracerListBox.Items.AddRange(New Object() {"Red", "Horse Brown", "Gray Brown", "Fox Orange", "Cream Brown", "Yellow", "Pea Green", "Grass Green", "Avocado", "Sea Blue", "Blue Gray", "Wolf Gray", "Arctic", "Violet Blue", "Spring Green", "Burgundy", "Green Yellow", "Light Chocolate", "Dark Chocolate", "Light Navy", "Dark Navy", "Light Dust", "Dark Dust", "Gray", "Black", "Light Mule", "Dark Mule", "Violet", "Royal Blue", "White"})
        Me.bracerListBox.Location = New System.Drawing.Point(3, 3)
        Me.bracerListBox.Name = "bracerListBox"
        Me.bracerListBox.Size = New System.Drawing.Size(229, 2036)
        Me.bracerListBox.TabIndex = 1
        Me.bracerListBox.Tag = ""
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.bracerListBox)
        Me.tabPage2.Location = New System.Drawing.Point(4, 40)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(235, 422)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Bracers"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'badgeListBox
        '
        Me.badgeListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.badgeListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.badgeListBox.FormattingEnabled = True
        Me.badgeListBox.IntegralHeight = False
        Me.badgeListBox.Items.AddRange(New Object() {"Blood Red", "Courage Red", "Merry Red", "Ember Orange", "Hearty Brown", "Burnt Orange", "Busy Orange", "August Orange", "Noble Brown", "Mahogany", "Clever Maize", "Pure Gold", "Moon Yellow", "Sun Yellow", "Tan", "Woodland Green", "Friendly Green", "Lucky Green", "Travelers Green", "Aquacyan", "Deepsea Blue", "Proud Blue", "Lightsky Blue", "Syndira Blue", "Straight Blue", "Royal Purple", "Lonely Orchid", "Spiritual Purple", "Mad Green", "Royal Blue", "Passion", "Bliss Red", "Blush Pink", "Twilight Sigh", "Dreamer Blue", "Shadow Gray", "Neutral Gray", "Tragic Gray", "Winter Gray", "Indigo"})
        Me.badgeListBox.Location = New System.Drawing.Point(3, 3)
        Me.badgeListBox.Name = "badgeListBox"
        Me.badgeListBox.Size = New System.Drawing.Size(229, 356)
        Me.badgeListBox.TabIndex = 0
        Me.badgeListBox.Tag = ""
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.badgeListBox)
        Me.tabPage1.Location = New System.Drawing.Point(4, 40)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(235, 422)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Badge"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'tabControl1
        '
        Me.tabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Controls.Add(Me.tabPage4)
        Me.tabControl1.Controls.Add(Me.tabPage5)
        Me.tabControl1.Controls.Add(Me.tabPage6)
        Me.tabControl1.Controls.Add(Me.tabPage7)
        Me.tabControl1.Controls.Add(Me.tabPage8)
        Me.tabControl1.Controls.Add(Me.tabPage9)
        Me.tabControl1.Controls.Add(Me.tabPage10)
        Me.tabControl1.Location = New System.Drawing.Point(13, 39)
        Me.tabControl1.Multiline = True
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(243, 466)
        Me.tabControl1.TabIndex = 16
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.bootsListBox)
        Me.tabPage3.Location = New System.Drawing.Point(4, 40)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Size = New System.Drawing.Size(235, 422)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Boots"
        Me.tabPage3.UseVisualStyleBackColor = True
        '
        'bootsListBox
        '
        Me.bootsListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bootsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.bootsListBox.FormattingEnabled = True
        Me.bootsListBox.IntegralHeight = False
        Me.bootsListBox.Items.AddRange(New Object() {"Red", "Horse Brown", "Gray Brown", "Fox Orange", "Cream Brown", "Yellow", "Pea Green", "Grass Green", "Avocado", "Sea Blue", "Blue Gray", "Wolf Gray", "Arctic", "Violet Blue", "Spring Green", "Burgundy", "Green Yellow", "Light Chocolate", "Dark Chocolate", "Light Navy", "Dark Navy", "Light Dust", "Dark Dust", "Gray", "Black", "Light Mule", "Dark Mule", "Violet", "Royal Blue", "White"})
        Me.bootsListBox.Location = New System.Drawing.Point(3, 3)
        Me.bootsListBox.Name = "bootsListBox"
        Me.bootsListBox.Size = New System.Drawing.Size(229, 2036)
        Me.bootsListBox.TabIndex = 2
        Me.bootsListBox.Tag = ""
        '
        'tabPage4
        '
        Me.tabPage4.Controls.Add(Me.capeListBox)
        Me.tabPage4.Location = New System.Drawing.Point(4, 40)
        Me.tabPage4.Name = "tabPage4"
        Me.tabPage4.Size = New System.Drawing.Size(235, 422)
        Me.tabPage4.TabIndex = 3
        Me.tabPage4.Text = "Cape"
        Me.tabPage4.UseVisualStyleBackColor = True
        '
        'capeListBox
        '
        Me.capeListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.capeListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.capeListBox.FormattingEnabled = True
        Me.capeListBox.IntegralHeight = False
        Me.capeListBox.Items.AddRange(New Object() {"Red", "Horse Brown", "Gray Brown", "Fox Orange", "Cream Brown", "Yellow", "Pea Green", "Grass Green", "Avocado", "Sea Blue", "Blue Gray", "Wolf Gray", "Arctic", "Violet Blue", "Spring Green", "Burgundy", "Green Yellow", "Light Chocolate", "Dark Chocolate", "Light Navy", "Dark Navy", "Light Dust", "Dark Dust", "Gray", "Black", "Light Mule", "Dark Mule", "Violet", "Royal Blue", "White"})
        Me.capeListBox.Location = New System.Drawing.Point(3, 3)
        Me.capeListBox.Name = "capeListBox"
        Me.capeListBox.Size = New System.Drawing.Size(229, 2036)
        Me.capeListBox.TabIndex = 3
        Me.capeListBox.Tag = ""
        '
        'tabPage5
        '
        Me.tabPage5.Controls.Add(Me.eyeListBox)
        Me.tabPage5.Location = New System.Drawing.Point(4, 40)
        Me.tabPage5.Name = "tabPage5"
        Me.tabPage5.Size = New System.Drawing.Size(235, 422)
        Me.tabPage5.TabIndex = 4
        Me.tabPage5.Text = "Eyes"
        Me.tabPage5.UseVisualStyleBackColor = True
        '
        'eyeListBox
        '
        Me.eyeListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.eyeListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.eyeListBox.FormattingEnabled = True
        Me.eyeListBox.IntegralHeight = False
        Me.eyeListBox.Items.AddRange(New Object() {"Mahogany", "Tiger Orange", "Moon Yellow", "Warm Gold", "Pond Green", "Light Blue", "Sea Blue", "Storm Gray", "Dust", "China Blue", "Medium Blue", "Dark Blue", "Hazel", "Blue Green", "Royal Blue", "Light Brown", "Medium Brown", "Dark Brown", "Black", "Albino Pink", "Mink Mauve", "Chocolate", "Silver", "Amethyst", "Ember Orange", "Sunshine", "Mad Green", "Gloomy Grey", "Minty Green", "Navy Blue"})
        Me.eyeListBox.Location = New System.Drawing.Point(3, 3)
        Me.eyeListBox.Name = "eyeListBox"
        Me.eyeListBox.Size = New System.Drawing.Size(229, 2036)
        Me.eyeListBox.TabIndex = 4
        Me.eyeListBox.Tag = ""
        '
        'tabPage6
        '
        Me.tabPage6.Controls.Add(Me.furListBox)
        Me.tabPage6.Location = New System.Drawing.Point(4, 40)
        Me.tabPage6.Name = "tabPage6"
        Me.tabPage6.Size = New System.Drawing.Size(235, 422)
        Me.tabPage6.TabIndex = 5
        Me.tabPage6.Text = "Fur"
        Me.tabPage6.UseVisualStyleBackColor = True
        '
        'loadButton
        '
        Me.loadButton.Location = New System.Drawing.Point(364, 38)
        Me.loadButton.Name = "loadButton"
        Me.loadButton.Size = New System.Drawing.Size(93, 21)
        Me.loadButton.TabIndex = 20
        Me.loadButton.Text = "Load Character"
        Me.loadButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(259, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = " Description"
        '
        'TxtBxDescription
        '
        Me.TxtBxDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBxDescription.Location = New System.Drawing.Point(258, 300)
        Me.TxtBxDescription.MaxLength = 1000
        Me.TxtBxDescription.Multiline = True
        Me.TxtBxDescription.Name = "TxtBxDescription"
        Me.TxtBxDescription.Size = New System.Drawing.Size(436, 205)
        Me.TxtBxDescription.TabIndex = 25
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.DreamToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(696, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DreamToolStripMenuItem
        '
        Me.DreamToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem, Me.SelectPatchToolStripMenuItem})
        Me.DreamToolStripMenuItem.Name = "DreamToolStripMenuItem"
        Me.DreamToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.DreamToolStripMenuItem.Text = "Dream"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'SelectPatchToolStripMenuItem
        '
        Me.SelectPatchToolStripMenuItem.Name = "SelectPatchToolStripMenuItem"
        Me.SelectPatchToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SelectPatchToolStripMenuItem.Text = "Select Patch"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(283, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 21)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Load Dream"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(262, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(262, 261)
        Me.TextBox1.MaxLength = 75
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 20)
        Me.TextBox1.TabIndex = 32
        '
        'CustomFurrePreview1
        '
        Me.CustomFurrePreview1.CurrentRemap = 0
        Me.CustomFurrePreview1.Location = New System.Drawing.Point(260, 65)
        Me.CustomFurrePreview1.Name = "CustomFurrePreview1"
        Me.CustomFurrePreview1.PatchPath = Nothing
        Me.CustomFurrePreview1.Size = New System.Drawing.Size(436, 160)
        Me.CustomFurrePreview1.TabIndex = 28
        '
        'PatchBrowser
        '
        Me.PatchBrowser.SelectedPath = ""
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 507)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CustomFurrePreview1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBxDescription)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.aboutButton)
        Me.Controls.Add(Me.setButton)
        Me.Controls.Add(Me.colourCodeTextBox)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.loadButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "FurEdVB"
        Me.tabPage9.ResumeLayout(False)
        Me.tabPage8.ResumeLayout(False)
        Me.tabPage10.ResumeLayout(False)
        Me.tabPage7.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage3.ResumeLayout(False)
        Me.tabPage4.ResumeLayout(False)
        Me.tabPage5.ResumeLayout(False)
        Me.tabPage6.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents saveButton As System.Windows.Forms.Button
    Private WithEvents trouserListBox As System.Windows.Forms.ListBox
    Private WithEvents tabPage9 As System.Windows.Forms.TabPage
    Private WithEvents markingListBox As System.Windows.Forms.ListBox
    Private WithEvents tabPage8 As System.Windows.Forms.TabPage
    Private WithEvents hairListBox As System.Windows.Forms.ListBox
    Private WithEvents tabPage10 As System.Windows.Forms.TabPage
    Private WithEvents vestListBox As System.Windows.Forms.ListBox
    Private WithEvents aboutButton As System.Windows.Forms.Button
    Private WithEvents saveIniFileDialog As System.Windows.Forms.SaveFileDialog
    Private WithEvents chooseIniFileDialog As System.Windows.Forms.OpenFileDialog
    Private WithEvents setButton As System.Windows.Forms.Button
    Private WithEvents colourCodeTextBox As System.Windows.Forms.TextBox
    Private WithEvents tabPage7 As System.Windows.Forms.TabPage
    Private WithEvents furListBox As System.Windows.Forms.ListBox
    Private WithEvents bracerListBox As System.Windows.Forms.ListBox
    Private WithEvents tabPage2 As System.Windows.Forms.TabPage
    Private WithEvents badgeListBox As System.Windows.Forms.ListBox
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tabPage3 As System.Windows.Forms.TabPage
    Private WithEvents bootsListBox As System.Windows.Forms.ListBox
    Private WithEvents tabPage4 As System.Windows.Forms.TabPage
    Private WithEvents capeListBox As System.Windows.Forms.ListBox
    Private WithEvents tabPage5 As System.Windows.Forms.TabPage
    Private WithEvents eyeListBox As System.Windows.Forms.ListBox
    Private WithEvents tabPage6 As System.Windows.Forms.TabPage
    Private WithEvents loadButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtBxDescription As System.Windows.Forms.TextBox
    Friend WithEvents CustomFurrePreview1 As FurEdVB.CustomFurrePreview
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DreamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectPatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PatchBrowser As FurEdVB.FileFolderDialog

End Class
