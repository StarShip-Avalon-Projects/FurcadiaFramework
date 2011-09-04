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
        Me.TxtBx_CharIni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StandAloneChkBx = New System.Windows.Forms.CheckBox()
        Me.BTN_Browse = New System.Windows.Forms.Button()
        Me.BTN_Ok = New System.Windows.Forms.Button()
        Me.BTN_Cancel = New System.Windows.Forms.Button()
        Me.TxtHPort = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.browseDialog = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.TxtBx_Server.Size = New System.Drawing.Size(214, 20)
        Me.TxtBx_Server.TabIndex = 4
        Me.TxtBx_Server.Text = "lightbringer.furcadia.com"
        '
        'TxtBx_CharIni
        '
        Me.TxtBx_CharIni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBx_CharIni.Location = New System.Drawing.Point(96, 24)
        Me.TxtBx_CharIni.Name = "TxtBx_CharIni"
        Me.TxtBx_CharIni.Size = New System.Drawing.Size(214, 20)
        Me.TxtBx_CharIni.TabIndex = 3
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Character Ini:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.StandAloneChkBx)
        Me.GroupBox1.Controls.Add(Me.BTN_Browse)
        Me.GroupBox1.Controls.Add(Me.TxtHPort)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtSPort)
        Me.GroupBox1.Controls.Add(Me.TxtBx_Server)
        Me.GroupBox1.Controls.Add(Me.TxtBx_CharIni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 154)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuration"
        '
        'StandAloneChkBx
        '
        Me.StandAloneChkBx.AutoSize = True
        Me.StandAloneChkBx.Location = New System.Drawing.Point(26, 121)
        Me.StandAloneChkBx.Name = "StandAloneChkBx"
        Me.StandAloneChkBx.Size = New System.Drawing.Size(84, 17)
        Me.StandAloneChkBx.TabIndex = 50
        Me.StandAloneChkBx.Text = "Stand Alone"
        Me.StandAloneChkBx.UseVisualStyleBackColor = True
        '
        'BTN_Browse
        '
        Me.BTN_Browse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Browse.Location = New System.Drawing.Point(316, 24)
        Me.BTN_Browse.Name = "BTN_Browse"
        Me.BTN_Browse.Size = New System.Drawing.Size(24, 19)
        Me.BTN_Browse.TabIndex = 11
        Me.BTN_Browse.Text = "..."
        Me.BTN_Browse.UseVisualStyleBackColor = True
        '
        'BTN_Ok
        '
        Me.BTN_Ok.Location = New System.Drawing.Point(211, 236)
        Me.BTN_Ok.Name = "BTN_Ok"
        Me.BTN_Ok.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Ok.TabIndex = 10
        Me.BTN_Ok.Text = "Ok"
        Me.BTN_Ok.UseVisualStyleBackColor = True
        '
        'BTN_Cancel
        '
        Me.BTN_Cancel.Location = New System.Drawing.Point(297, 236)
        Me.BTN_Cancel.Name = "BTN_Cancel"
        Me.BTN_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Cancel.TabIndex = 9
        Me.BTN_Cancel.Text = "Cancel"
        Me.BTN_Cancel.UseVisualStyleBackColor = True
        '
        'TxtHPort
        '
        Me.TxtHPort.Location = New System.Drawing.Point(252, 86)
        Me.TxtHPort.MaxLength = 5
        Me.TxtHPort.Name = "TxtHPort"
        Me.TxtHPort.Size = New System.Drawing.Size(58, 20)
        Me.TxtHPort.TabIndex = 8
        Me.TxtHPort.Text = "6500"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(183, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Local Port:"
        '
        'browseDialog
        '
        Me.browseDialog.DefaultExt = "ini"
        Me.browseDialog.Filter = "Furcadia Character Files)|*.ini"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 64)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(86, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(269, 19)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(73, 21)
        Me.ComboBox2.TabIndex = 3
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(110, 121)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox1.TabIndex = 51
        Me.CheckBox1.Text = "Time Stamp"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 272)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_Ok)
        Me.Controls.Add(Me.BTN_Cancel)
        Me.Name = "Config"
        Me.Text = "Config"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtSPort As System.Windows.Forms.TextBox
    Friend WithEvents TxtBx_Server As System.Windows.Forms.TextBox
    Friend WithEvents TxtBx_CharIni As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_Ok As System.Windows.Forms.Button
    Friend WithEvents BTN_Cancel As System.Windows.Forms.Button
    Friend WithEvents TxtHPort As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents BTN_Browse As System.Windows.Forms.Button
    Friend WithEvents browseDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents StandAloneChkBx As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

