namespace FurEd {
    partial class FurrePreview {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.avatarPreview = new System.Windows.Forms.PictureBox();
			this.speciesChooser = new System.Windows.Forms.TreeView();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.remapMaskCheckBox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.avatarPreview)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(341, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(95, 95);
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// avatarPreview
			// 
			this.avatarPreview.BackColor = System.Drawing.Color.Snow;
			this.avatarPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.avatarPreview.Location = new System.Drawing.Point(175, 0);
			this.avatarPreview.Name = "avatarPreview";
			this.avatarPreview.Size = new System.Drawing.Size(160, 160);
			this.avatarPreview.TabIndex = 9;
			this.avatarPreview.TabStop = false;
			this.avatarPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			// 
			// speciesChooser
			// 
			this.speciesChooser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.speciesChooser.Location = new System.Drawing.Point(0, 0);
			this.speciesChooser.Name = "speciesChooser";
			this.speciesChooser.Size = new System.Drawing.Size(169, 160);
			this.speciesChooser.TabIndex = 11;
			this.speciesChooser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.speciesChooser_AfterSelect);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(407, 101);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(28, 23);
			this.button3.TabIndex = 14;
			this.button3.Text = "U";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(374, 101);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(28, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "F";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(341, 101);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(28, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "M";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(374, 130);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(28, 23);
			this.button5.TabIndex = 16;
			this.button5.Text = ">";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(341, 130);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(28, 23);
			this.button6.TabIndex = 15;
			this.button6.Text = "<";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// remapMaskCheckBox
			// 
			this.remapMaskCheckBox.AutoSize = true;
			this.remapMaskCheckBox.Location = new System.Drawing.Point(413, 136);
			this.remapMaskCheckBox.Name = "remapMaskCheckBox";
			this.remapMaskCheckBox.Size = new System.Drawing.Size(15, 14);
			this.remapMaskCheckBox.TabIndex = 17;
			this.remapMaskCheckBox.UseVisualStyleBackColor = true;
			this.remapMaskCheckBox.CheckedChanged += new System.EventHandler(this.remapMaskCheckBox_CheckedChanged);
			// 
			// FurrePreview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.remapMaskCheckBox);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.speciesChooser);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.avatarPreview);
			this.Name = "FurrePreview";
			this.Size = new System.Drawing.Size(436, 160);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.avatarPreview)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox avatarPreview;
        private System.Windows.Forms.TreeView speciesChooser;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.CheckBox remapMaskCheckBox;
    }
}
