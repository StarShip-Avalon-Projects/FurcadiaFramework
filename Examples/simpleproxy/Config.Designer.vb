<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Config
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
        Me.TxtSPort = New System.Windows.Forms.TextBox()
        Me.TxtBx_Server = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTN_Ok = New System.Windows.Forms.Button()
        Me.BTN_Cancel = New System.Windows.Forms.Button()
        Me.browseDialog = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkTimeStamp = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboFontSize = New System.Windows.Forms.ComboBox()
        Me.ComboFontFace = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EmoteColorBox = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DefaultColorBox = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.WhisperColorBox = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ShoutColorBox = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SayColorBox = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EmitColorBox = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.EmoteColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefaultColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WhisperColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShoutColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SayColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmitColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtSPort
        '
        Me.TxtSPort.Location = New System.Drawing.Point(96, 86)
        Me.TxtSPort.MaxLength = 5
        Me.TxtSPort.Name = "TxtSPort"
        Me.TxtSPort.Size = New System.Drawing.Size(58, 20)
        Me.TxtSPort.TabIndex = 5
        Me.TxtSPort.Text = "6500"
        '
        'TxtBx_Server
        '
        Me.TxtBx_Server.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBx_Server.Location = New System.Drawing.Point(96, 50)
        Me.TxtBx_Server.Name = "TxtBx_Server"
        Me.TxtBx_Server.Size = New System.Drawing.Size(213, 20)
        Me.TxtBx_Server.TabIndex = 4
        Me.TxtBx_Server.Text = "lightbringer.furcadia.com"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Server Port:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destination:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSPort)
        Me.GroupBox1.Controls.Add(Me.TxtBx_Server)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 154)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuration"
        '
        'BTN_Ok
        '
        Me.BTN_Ok.Location = New System.Drawing.Point(201, 274)
        Me.BTN_Ok.Name = "BTN_Ok"
        Me.BTN_Ok.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Ok.TabIndex = 10
        Me.BTN_Ok.Text = "Ok"
        Me.BTN_Ok.UseVisualStyleBackColor = True
        '
        'BTN_Cancel
        '
        Me.BTN_Cancel.Location = New System.Drawing.Point(287, 274)
        Me.BTN_Cancel.Name = "BTN_Cancel"
        Me.BTN_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Cancel.TabIndex = 9
        Me.BTN_Cancel.Text = "Cancel"
        Me.BTN_Cancel.UseVisualStyleBackColor = True
        '
        'browseDialog
        '
        Me.browseDialog.DefaultExt = "ini"
        Me.browseDialog.Filter = "Furcadia Character Files)|*.ini"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkTimeStamp)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ComboFontSize)
        Me.GroupBox2.Controls.Add(Me.ComboFontFace)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 75)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Font Style"
        '
        'ChkTimeStamp
        '
        Me.ChkTimeStamp.AutoSize = True
        Me.ChkTimeStamp.Location = New System.Drawing.Point(86, 46)
        Me.ChkTimeStamp.Name = "ChkTimeStamp"
        Me.ChkTimeStamp.Size = New System.Drawing.Size(82, 17)
        Me.ChkTimeStamp.TabIndex = 5
        Me.ChkTimeStamp.Text = "Time Stamp"
        Me.ChkTimeStamp.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Font Size"
        '
        'ComboFontSize
        '
        Me.ComboFontSize.FormattingEnabled = True
        Me.ComboFontSize.Location = New System.Drawing.Point(269, 19)
        Me.ComboFontSize.Name = "ComboFontSize"
        Me.ComboFontSize.Size = New System.Drawing.Size(73, 21)
        Me.ComboFontSize.TabIndex = 3
        '
        'ComboFontFace
        '
        Me.ComboFontFace.FormattingEnabled = True
        Me.ComboFontFace.Location = New System.Drawing.Point(86, 19)
        Me.ComboFontFace.Name = "ComboFontFace"
        Me.ComboFontFace.Size = New System.Drawing.Size(121, 21)
        Me.ComboFontFace.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Font Face"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(379, 256)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(371, 230)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Connection"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(371, 230)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Display"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.EmoteColorBox)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.DefaultColorBox)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.WhisperColorBox)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.ShoutColorBox)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.SayColorBox)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.EmitColorBox)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(359, 137)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Color Options"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(118, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Emote Color"
        '
        'EmoteColorBox
        '
        Me.EmoteColorBox.BackColor = System.Drawing.Color.Lime
        Me.EmoteColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EmoteColorBox.Location = New System.Drawing.Point(192, 23)
        Me.EmoteColorBox.Name = "EmoteColorBox"
        Me.EmoteColorBox.Size = New System.Drawing.Size(15, 14)
        Me.EmoteColorBox.TabIndex = 14
        Me.EmoteColorBox.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Default Color"
        '
        'DefaultColorBox
        '
        Me.DefaultColorBox.BackColor = System.Drawing.Color.Lime
        Me.DefaultColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DefaultColorBox.Location = New System.Drawing.Point(86, 101)
        Me.DefaultColorBox.Name = "DefaultColorBox"
        Me.DefaultColorBox.Size = New System.Drawing.Size(15, 14)
        Me.DefaultColorBox.TabIndex = 12
        Me.DefaultColorBox.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Whisper Color"
        '
        'WhisperColorBox
        '
        Me.WhisperColorBox.BackColor = System.Drawing.Color.Lime
        Me.WhisperColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WhisperColorBox.Location = New System.Drawing.Point(86, 23)
        Me.WhisperColorBox.Name = "WhisperColorBox"
        Me.WhisperColorBox.Size = New System.Drawing.Size(15, 14)
        Me.WhisperColorBox.TabIndex = 10
        Me.WhisperColorBox.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Shout Color"
        '
        'ShoutColorBox
        '
        Me.ShoutColorBox.BackColor = System.Drawing.Color.Lime
        Me.ShoutColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShoutColorBox.Location = New System.Drawing.Point(86, 41)
        Me.ShoutColorBox.Name = "ShoutColorBox"
        Me.ShoutColorBox.Size = New System.Drawing.Size(15, 14)
        Me.ShoutColorBox.TabIndex = 8
        Me.ShoutColorBox.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Say Color"
        '
        'SayColorBox
        '
        Me.SayColorBox.BackColor = System.Drawing.Color.Lime
        Me.SayColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SayColorBox.Location = New System.Drawing.Point(86, 81)
        Me.SayColorBox.Name = "SayColorBox"
        Me.SayColorBox.Size = New System.Drawing.Size(15, 14)
        Me.SayColorBox.TabIndex = 6
        Me.SayColorBox.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Emit Color"
        '
        'EmitColorBox
        '
        Me.EmitColorBox.BackColor = System.Drawing.Color.Lime
        Me.EmitColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EmitColorBox.Location = New System.Drawing.Point(86, 61)
        Me.EmitColorBox.Name = "EmitColorBox"
        Me.EmitColorBox.Size = New System.Drawing.Size(15, 14)
        Me.EmitColorBox.TabIndex = 4
        Me.EmitColorBox.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(371, 230)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Debug"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 309)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BTN_Ok)
        Me.Controls.Add(Me.BTN_Cancel)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.SimpleProxy2.My.MySettings.Default, "ConfigFormLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.SimpleProxy2.My.MySettings.Default.ConfigFormLocation
        Me.Name = "Config"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.EmoteColorBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefaultColorBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WhisperColorBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShoutColorBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SayColorBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmitColorBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtSPort As System.Windows.Forms.TextBox
    Friend WithEvents TxtBx_Server As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_Ok As System.Windows.Forms.Button
    Friend WithEvents BTN_Cancel As System.Windows.Forms.Button
    Friend WithEvents browseDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboFontSize As System.Windows.Forms.ComboBox
    Friend WithEvents ComboFontFace As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents EmitColorBox As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ShoutColorBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SayColorBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DefaultColorBox As System.Windows.Forms.PictureBox
    Friend WithEvents WhisperColorBox As System.Windows.Forms.PictureBox
    Friend WithEvents ChkTimeStamp As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents EmoteColorBox As System.Windows.Forms.PictureBox
End Class

