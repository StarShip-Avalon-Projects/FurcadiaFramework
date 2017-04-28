namespace BugProxy
{
    partial class CharacterSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstVwSelectCharacter = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.CharacterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IniFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstVwSelectCharacter
            // 
            this.lstVwSelectCharacter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CharacterName,
            this.IniFileName,
            this.LastLogin});
            this.lstVwSelectCharacter.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstVwSelectCharacter.HideSelection = false;
            this.lstVwSelectCharacter.Location = new System.Drawing.Point(40, 12);
            this.lstVwSelectCharacter.Name = "lstVwSelectCharacter";
            this.lstVwSelectCharacter.Size = new System.Drawing.Size(359, 183);
            this.lstVwSelectCharacter.TabIndex = 0;
            this.lstVwSelectCharacter.UseCompatibleStateImageBehavior = false;
            this.lstVwSelectCharacter.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Character";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CharacterName
            // 
            this.CharacterName.Text = "CharacterName";
            // 
            // IniFileName
            // 
            this.IniFileName.Text = "Character Ini File";
            // 
            // LastLogin
            // 
            this.LastLogin.Text = "Last Log In";
            // 
            // CharacterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstVwSelectCharacter);
            this.Name = "CharacterSelect";
            this.Text = "CharacterSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstVwSelectCharacter;
        private System.Windows.Forms.ColumnHeader CharacterName;
        private System.Windows.Forms.ColumnHeader IniFileName;
        private System.Windows.Forms.ColumnHeader LastLogin;
        private System.Windows.Forms.Button button1;
    }
}