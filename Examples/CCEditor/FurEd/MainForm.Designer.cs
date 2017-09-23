namespace FurEd {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.saveButton = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.badgeListBox = new System.Windows.Forms.ListBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.bracerListBox = new System.Windows.Forms.ListBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.bootsListBox = new System.Windows.Forms.ListBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.capeListBox = new System.Windows.Forms.ListBox();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.eyeListBox = new System.Windows.Forms.ListBox();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.furListBox = new System.Windows.Forms.ListBox();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.hairListBox = new System.Windows.Forms.ListBox();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.markingListBox = new System.Windows.Forms.ListBox();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.trouserListBox = new System.Windows.Forms.ListBox();
			this.tabPage10 = new System.Windows.Forms.TabPage();
			this.vestListBox = new System.Windows.Forms.ListBox();
			this.colourCodeTextBox = new System.Windows.Forms.TextBox();
			this.setButton = new System.Windows.Forms.Button();
			this.chooseIniFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveIniFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.aboutButton = new System.Windows.Forms.Button();
			this.furrePreview3 = new FurEd.FurrePreview();
			this.furrePreview2 = new FurEd.FurrePreview();
			this.furrePreview1 = new FurEd.FurrePreview();
			this.loadButton = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.tabPage7.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.tabPage9.SuspendLayout();
			this.tabPage10.SuspendLayout();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(193, 12);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(42, 21);
			this.saveButton.TabIndex = 5;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.button4_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Controls.Add(this.tabPage8);
			this.tabControl1.Controls.Add(this.tabPage9);
			this.tabControl1.Controls.Add(this.tabPage10);
			this.tabControl1.Location = new System.Drawing.Point(13, 39);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(243, 466);
			this.tabControl1.TabIndex = 6;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.badgeListBox);
			this.tabPage1.Location = new System.Drawing.Point(4, 40);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(235, 422);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Badge";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// badgeListBox
			// 
			this.badgeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.badgeListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.badgeListBox.FormattingEnabled = true;
			this.badgeListBox.IntegralHeight = false;
			this.badgeListBox.Items.AddRange(new object[] {
            "Blood Red",
            "Courage Red",
            "Merry Red",
            "Ember Orange",
            "Hearty Brown",
            "Burnt Orange",
            "Busy Orange",
            "August Orange",
            "Noble Brown",
            "Mahogany",
            "Clever Maize",
            "Pure Gold",
            "Moon Yellow",
            "Sun Yellow",
            "Tan",
            "Woodland Green",
            "Friendly Green",
            "Lucky Green",
            "Travelers Green",
            "Aquacyan",
            "Deepsea Blue",
            "Proud Blue",
            "Lightsky Blue",
            "Syndira Blue",
            "Straight Blue",
            "Royal Purple",
            "Lonely Orchid",
            "Spiritual Purple",
            "Mad Green",
            "Royal Blue",
            "Passion",
            "Bliss Red",
            "Blush Pink",
            "Twilight Sigh",
            "Dreamer Blue",
            "Shadow Gray",
            "Neutral Gray",
            "Tragic Gray",
            "Winter Gray",
            "Indigo"});
			this.badgeListBox.Location = new System.Drawing.Point(3, 3);
			this.badgeListBox.Name = "badgeListBox";
			this.badgeListBox.Size = new System.Drawing.Size(229, 416);
			this.badgeListBox.TabIndex = 0;
			this.badgeListBox.Tag = "";
			this.badgeListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.RenderColourChoice);
			this.badgeListBox.SelectedIndexChanged += new System.EventHandler(this.ChangeColourChoice);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.bracerListBox);
			this.tabPage2.Location = new System.Drawing.Point(4, 40);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(235, 422);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Bracers";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// bracerListBox
			// 
			this.bracerListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bracerListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.bracerListBox.FormattingEnabled = true;
			this.bracerListBox.IntegralHeight = false;
			this.bracerListBox.Items.AddRange(new object[] {
            "Red",
            "Horse Brown",
            "Gray Brown",
            "Fox Orange",
            "Cream Brown",
            "Yellow",
            "Pea Green",
            "Grass Green",
            "Avocado",
            "Sea Blue",
            "Blue Gray",
            "Wolf Gray",
            "Arctic",
            "Violet Blue",
            "Spring Green",
            "Burgundy",
            "Green Yellow",
            "Light Chocolate",
            "Dark Chocolate",
            "Light Navy",
            "Dark Navy",
            "Light Dust",
            "Dark Dust",
            "Gray",
            "Black",
            "Light Mule",
            "Dark Mule",
            "Violet",
            "Royal Blue",
            "White"});
			this.bracerListBox.Location = new System.Drawing.Point(3, 3);
			this.bracerListBox.Name = "bracerListBox";
			this.bracerListBox.Size = new System.Drawing.Size(229, 1622);
			this.bracerListBox.TabIndex = 1;
			this.bracerListBox.Tag = "";
			this.bracerListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.RenderColourChoice);
			this.bracerListBox.SelectedIndexChanged += new System.EventHandler(this.ChangeColourChoice);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.bootsListBox);
			this.tabPage3.Location = new System.Drawing.Point(4, 40);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(235, 422);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Boots";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// bootsListBox
			// 
			this.bootsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bootsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.bootsListBox.FormattingEnabled = true;
			this.bootsListBox.IntegralHeight = false;
			this.bootsListBox.Items.AddRange(new object[] {
            "Red",
            "Horse Brown",
            "Gray Brown",
            "Fox Orange",
            "Cream Brown",
            "Yellow",
            "Pea Green",
            "Grass Green",
            "Avocado",
            "Sea Blue",
            "Blue Gray",
            "Wolf Gray",
            "Arctic",
            "Violet Blue",
            "Spring Green",
            "Burgundy",
            "Green Yellow",
            "Light Chocolate",
            "Dark Chocolate",
            "Light Navy",
            "Dark Navy",
            "Light Dust",
            "Dark Dust",
            "Gray",
            "Black",
            "Light Mule",
            "Dark Mule",
            "Violet",
            "Royal Blue",
            "White"});
			this.bootsListBox.Location = new System.Drawing.Point(3, 3);
			this.bootsListBox.Name = "bootsListBox";
			this.bootsListBox.Size = new System.Drawing.Size(229, 1622);
			this.bootsListBox.TabIndex = 2;
			this.bootsListBox.Tag = "";
			this.bootsListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.RenderColourChoice);
			this.bootsListBox.SelectedIndexChanged += new System.EventHandler(this.ChangeColourChoice);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.capeListBox);
			this.tabPage4.Location = new System.Drawing.Point(4, 40);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(235, 422);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Cape";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// capeListBox
			// 
			this.capeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.capeListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.capeListBox.FormattingEnabled = true;
			this.capeListBox.IntegralHeight = false;
			this.capeListBox.Items.AddRange(new object[] {
            "Red",
            "Horse Brown",
            "Gray Brown",
            "Fox Orange",
            "Cream Brown",
            "Yellow",
            "Pea Green",
            "Grass Green",
            "Avocado",
            "Sea Blue",
            "Blue Gray",
            "Wolf Gray",
            "Arctic",
            "Violet Blue",
            "Spring Green",
            "Burgundy",
            "Green Yellow",
            "Light Chocolate",
            "Dark Chocolate",
            "Light Navy",
            "Dark Navy",
            "Light Dust",
            "Dark Dust",
            "Gray",
            "Black",
            "Light Mule",
            "Dark Mule",
            "Violet",
            "Royal Blue",
            "White"});
			this.capeListBox.Location = new System.Drawing.Point(3, 3);
			this.capeListBox.Name = "capeListBox";
			this.capeListBox.Size = new System.Drawing.Size(229, 1622);
			this.capeListBox.TabIndex = 3;
			this.capeListBox.Tag = "";
			this.capeListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.RenderColourChoice);
			this.capeListBox.SelectedIndexChanged += new System.EventHandler(this.ChangeColourChoice);
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.eyeListBox);
			this.tabPage5.Location = new System.Drawing.Point(4, 40);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(235, 422);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Eyes";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// eyeListBox
			// 
			this.eyeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.eyeListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.eyeListBox.FormattingEnabled = true;
			this.eyeListBox.IntegralHeight = false;
			this.eyeListBox.Items.AddRange(new object[] {
            "Mahogany",
            "Tiger Orange",
            "Moon Yellow",
            "Warm Gold",
            "Pond Green",
            "Light Blue",
            "Sea Blue",
            "Storm Gray",
            "Dust",
            "China Blue",
            "Medium Blue",
            "Dark Blue",
            "Hazel",
            "Blue Green",
            "Royal Blue",
            "Light Brown",
            "Medium Brown",
            "Dark Brown",
            "Black",
            "Albino Pink",
            "Mink Mauve",
            "Chocolate",
            "Silver",
            "Amethyst",
            "Ember Orange",
            "Sunshine",
            "Mad Green",
            "Gloomy Grey",
            "Minty Green",
            "Navy Blue"});
			this.eyeListBox.Location = new System.Drawing.Point(3, 3);
			this.eyeListBox.Name = "eyeListBox";
			this.eyeListBox.Size = new System.Drawing.Size(229, 1622);
			this.eyeListBox.TabIndex = 4;
			this.eyeListBox.Tag = "";
			this.eyeListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.RenderColourChoice);
			this.eyeListBox.SelectedIndexChanged += new System.EventHandler(this.ChangeColourChoice);
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.furListBox);
			this.tabPage6.Location = new System.Drawing.Point(4, 40);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(235, 422);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Fur";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// furListBox
			// 
			this.furListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.furListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.furListBox.FormattingEnabled = true;
			this.furListBox.IntegralHeight = false;
			this.furListBox.Items.AddRange(new object[] {
            "Cat Gray",
            "Arctic",
            "Black",
            "Mule Tan",
            "Dust",
            "Chocolate",
            "Lavender",
            "Wolf Gray",
            "Fox Orange",
            "Horse Brown",
            "Tawny",
            "Mocha",
            "Ruddy",
            "Cream",
            "Yellow",
            "Grass Green",
            "Burgundy",
            "Pinewood",
            "Sea Blue",
            "Violet",
            "Red",
            "White",
            "Navy",
            "Cloudy Gray",
            "Royal Blue"});
			this.furListBox.Location = new System.Drawing.Point(3, 3);
			this.furListBox.Name = "furListBox";
			this.furListBox.Size = new System.Drawing.Size(229, 416);
			this.furListBox.TabIndex = 4;
			this.furListBox.Tag = "";
			this.furListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.RenderColourChoice);
			this.furListBox.SelectedIndexChanged += new System.EventHandler(this.ChangeColourChoice);
			// 
			// tabPage7
			// 
			this.tabPage7.Controls.Add(this.hairListBox);
			this.tabPage7.Location = new System.Drawing.Point(4, 40);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Size = new System.Drawing.Size(235, 422);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "Hair";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// hairListBox
			// 
			this.hairListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hairListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.hairListBox.FormattingEnabled = true;
			this.hairListBox.IntegralHeight = false;
			this.hairListBox.Items.AddRange(new object[] {
            "Blood Red",
            "Courage Red",
            "Merry Red",
            "Ember Orange",
            "Hearty Brown",
            "Burnt Orange",
            "Busy Orange",
            "August Orange",
            "Noble Brown",
            "Mahogany",
            "Clever Maize",
            "Pure Gold",
            "Moon Yellow",
            "Sun Yellow",
            "Tan",
            "Woodland Green",
            "Friendly Green",
            "Lucky Green",
            "Travelers Green",
            "Aquacyan",
            "Deepsea Blue",
            "Proud Blue",
            "Lightsky Blue",
            "Syndira Blue",
            "Straight Blue",
            "Royal Purple",
            "Lonely Orchid",
            "Spiritual Purple",
            "Mad Green",
            "Royal Blue",
            "Passion",
            "Bliss Red",
            "Blush Pink",
            "Twilight Sigh",
            "Dreamer Blue",
            "Shadow Gray",
            "Neutral Gray",
            "Tragic Gray",
            "Winter Gray",
            "Indigo",
            "Black",
            "Cloudy Gray",
            "White",
            "Pinewood",
            "Green Yellow"});
			this.hairListBox.Location = new System.Drawing.Point(3, 3);
			this.hairListBox.Name = "hairListBox";
			this.hairListBox.Size = new System.Drawing.Size(229, 416);
			this.hairListBox.TabIndex = 5;
			this.hairListBox.Tag = "";
			this.hairListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.RenderColourChoice);
			this.hairListBox.SelectedIndexChanged += new System.EventHandler(this.ChangeColourChoice);
			// 
			// tabPage8
			// 
			this.tabPage8.Controls.Add(this.markingListBox);
			this.tabPage8.Location = new System.Drawing.Point(4, 40);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Size = new System.Drawing.Size(235, 422);
			this.tabPage8.TabIndex = 7;
			this.tabPage8.Text = "Markings";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// markingListBox
			// 
			this.markingListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.markingListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.markingListBox.FormattingEnabled = true;
			this.markingListBox.IntegralHeight = false;
			this.markingListBox.Items.AddRange(new object[] {
            "Cat Gray",
            "Arctic",
            "Black",
            "Mule Tan",
            "Dust",
            "Chocolate",
            "Lavender",
            "Wolf Gray",
            "Fox Orange",
            "Horse Brown",
            "Tawny",
            "Mocha",
            "Ruddy",
            "Cream",
            "Yellow",
            "Grass Green",
            "Burgundy",
            "Pinewood",
            "Sea Blue",
            "Violet",
            "Red",
            "White",
            "Navy",
            "Cloudy Gray",
            "Royal Blue"});
			this.markingListBox.Location = new System.Drawing.Point(3, 3);
			this.markingListBox.Name = "markingListBox";
			this.markingListBox.Size = new System.Drawing.Size(229, 416);
			this.markingListBox.TabIndex = 5;
			this.markingListBox.Tag = "";
			this.markingListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.RenderColourChoice);
			this.markingListBox.SelectedIndexChanged += new System.EventHandler(this.ChangeColourChoice);
			// 
			// tabPage9
			// 
			this.tabPage9.Controls.Add(this.trouserListBox);
			this.tabPage9.Location = new System.Drawing.Point(4, 40);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Size = new System.Drawing.Size(235, 422);
			this.tabPage9.TabIndex = 8;
			this.tabPage9.Text = "Trousers";
			this.tabPage9.UseVisualStyleBackColor = true;
			// 
			// trouserListBox
			// 
			this.trouserListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.trouserListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.trouserListBox.FormattingEnabled = true;
			this.trouserListBox.IntegralHeight = false;
			this.trouserListBox.Items.AddRange(new object[] {
            "Red",
            "Horse Brown",
            "Gray Brown",
            "Fox Orange",
            "Cream Brown",
            "Yellow",
            "Pea Green",
            "Grass Green",
            "Avocado",
            "Sea Blue",
            "Blue Gray",
            "Wolf Gray",
            "Arctic",
            "Violet Blue",
            "Spring Green",
            "Burgundy",
            "Green Yellow",
            "Light Chocolate",
            "Dark Chocolate",
            "Light Navy",
            "Dark Navy",
            "Light Dust",
            "Dark Dust",
            "Gray",
            "Black",
            "Light Mule",
            "Dark Mule",
            "Violet",
            "Royal Blue",
            "White"});
			this.trouserListBox.Location = new System.Drawing.Point(3, 3);
			this.trouserListBox.Name = "trouserListBox";
			this.trouserListBox.Size = new System.Drawing.Size(229, 416);
			this.trouserListBox.TabIndex = 4;
			this.trouserListBox.Tag = "";
			this.trouserListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.RenderColourChoice);
			this.trouserListBox.SelectedIndexChanged += new System.EventHandler(this.ChangeColourChoice);
			// 
			// tabPage10
			// 
			this.tabPage10.Controls.Add(this.vestListBox);
			this.tabPage10.Location = new System.Drawing.Point(4, 40);
			this.tabPage10.Name = "tabPage10";
			this.tabPage10.Size = new System.Drawing.Size(235, 422);
			this.tabPage10.TabIndex = 9;
			this.tabPage10.Text = "Vest";
			this.tabPage10.UseVisualStyleBackColor = true;
			// 
			// vestListBox
			// 
			this.vestListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.vestListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.vestListBox.FormattingEnabled = true;
			this.vestListBox.IntegralHeight = false;
			this.vestListBox.Items.AddRange(new object[] {
            "Red",
            "Horse Brown",
            "Gray Brown",
            "Fox Orange",
            "Cream Brown",
            "Yellow",
            "Pea Green",
            "Grass Green",
            "Avocado",
            "Sea Blue",
            "Blue Gray",
            "Wolf Gray",
            "Arctic",
            "Violet Blue",
            "Spring Green",
            "Burgundy",
            "Green Yellow",
            "Light Chocolate",
            "Dark Chocolate",
            "Light Navy",
            "Dark Navy",
            "Light Dust",
            "Dark Dust",
            "Gray",
            "Black",
            "Light Mule",
            "Dark Mule",
            "Violet",
            "Royal Blue",
            "White"});
			this.vestListBox.Location = new System.Drawing.Point(3, 3);
			this.vestListBox.Name = "vestListBox";
			this.vestListBox.Size = new System.Drawing.Size(229, 416);
			this.vestListBox.TabIndex = 5;
			this.vestListBox.Tag = "";
			this.vestListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.RenderColourChoice);
			this.vestListBox.SelectedIndexChanged += new System.EventHandler(this.ChangeColourChoice);
			// 
			// colourCodeTextBox
			// 
			this.colourCodeTextBox.Location = new System.Drawing.Point(55, 13);
			this.colourCodeTextBox.Name = "colourCodeTextBox";
			this.colourCodeTextBox.Size = new System.Drawing.Size(105, 20);
			this.colourCodeTextBox.TabIndex = 9;
			// 
			// setButton
			// 
			this.setButton.Location = new System.Drawing.Point(161, 12);
			this.setButton.Name = "setButton";
			this.setButton.Size = new System.Drawing.Size(32, 21);
			this.setButton.TabIndex = 10;
			this.setButton.Text = "Set";
			this.setButton.UseVisualStyleBackColor = true;
			this.setButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// chooseIniFileDialog
			// 
			this.chooseIniFileDialog.Filter = "Furcadia Characters (*.ini)|*.ini|All files (*.*)|*.*";
			this.chooseIniFileDialog.Title = "Choose a Furcadia character to edit its colours";
			// 
			// saveIniFileDialog
			// 
			this.saveIniFileDialog.Filter = "Furcadia Characters (*.ini)|*.ini|All files (*.*)|*.*";
			this.saveIniFileDialog.Title = "Choose a filename for this INI";
			// 
			// aboutButton
			// 
			this.aboutButton.Location = new System.Drawing.Point(235, 12);
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(21, 21);
			this.aboutButton.TabIndex = 13;
			this.aboutButton.Text = "?";
			this.aboutButton.UseVisualStyleBackColor = true;
			this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// furrePreview3
			// 
			this.furrePreview3.CurrentRemap = 0;
			this.furrePreview3.Location = new System.Drawing.Point(262, 344);
			this.furrePreview3.Name = "furrePreview3";
			this.furrePreview3.Size = new System.Drawing.Size(436, 160);
			this.furrePreview3.TabIndex = 12;
			// 
			// furrePreview2
			// 
			this.furrePreview2.CurrentRemap = 0;
			this.furrePreview2.Location = new System.Drawing.Point(262, 178);
			this.furrePreview2.Name = "furrePreview2";
			this.furrePreview2.Size = new System.Drawing.Size(436, 160);
			this.furrePreview2.TabIndex = 11;
			// 
			// furrePreview1
			// 
			this.furrePreview1.CurrentRemap = 0;
			this.furrePreview1.Location = new System.Drawing.Point(262, 12);
			this.furrePreview1.Name = "furrePreview1";
			this.furrePreview1.Size = new System.Drawing.Size(436, 160);
			this.furrePreview1.TabIndex = 8;
			// 
			// loadButton
			// 
			this.loadButton.Location = new System.Drawing.Point(12, 12);
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(42, 21);
			this.loadButton.TabIndex = 14;
			this.loadButton.Text = "Load";
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(706, 517);
			this.Controls.Add(this.loadButton);
			this.Controls.Add(this.aboutButton);
			this.Controls.Add(this.furrePreview3);
			this.Controls.Add(this.furrePreview2);
			this.Controls.Add(this.setButton);
			this.Controls.Add(this.colourCodeTextBox);
			this.Controls.Add(this.furrePreview1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.saveButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Treeki\'s Extended Colour Code Editor [Furcadia v29; April 2012]";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.tabPage7.ResumeLayout(false);
			this.tabPage8.ResumeLayout(false);
			this.tabPage9.ResumeLayout(false);
			this.tabPage10.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.ListBox badgeListBox;
        private System.Windows.Forms.ListBox bracerListBox;
        private System.Windows.Forms.ListBox bootsListBox;
        private System.Windows.Forms.ListBox capeListBox;
        private System.Windows.Forms.ListBox eyeListBox;
        private System.Windows.Forms.ListBox furListBox;
        private System.Windows.Forms.ListBox hairListBox;
        private System.Windows.Forms.ListBox markingListBox;
        private System.Windows.Forms.ListBox trouserListBox;
        private System.Windows.Forms.ListBox vestListBox;
        private FurrePreview furrePreview1;
        private System.Windows.Forms.TextBox colourCodeTextBox;
        private System.Windows.Forms.Button setButton;
        private FurrePreview furrePreview2;
        private FurrePreview furrePreview3;
        private System.Windows.Forms.OpenFileDialog chooseIniFileDialog;
        private System.Windows.Forms.SaveFileDialog saveIniFileDialog;
		private System.Windows.Forms.Button aboutButton;
		private System.Windows.Forms.Button loadButton;
    }
}

