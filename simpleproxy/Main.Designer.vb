<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ActionTmr = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TS_Main = New System.Windows.Forms.StatusStrip()
        Me.TS_Status_BotName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TS_Filler = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TS_Status_Server = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TS_Status_Client = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DreamCountTxtBx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DreamList = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_Bold = New System.Windows.Forms.Button()
        Me.BTN_Underline = New System.Windows.Forms.Button()
        Me.BTN_Italic = New System.Windows.Forms.Button()
        Me.sendToServer = New System.Windows.Forms.Button()
        Me.clientGroup = New System.Windows.Forms.GroupBox()
        Me.GrpAction = New System.Windows.Forms.GroupBox()
        Me.BtnSit_stand_Lie = New System.Windows.Forms.Button()
        Me.BTN_TurnL = New System.Windows.Forms.Button()
        Me.BTN_TurnR = New System.Windows.Forms.Button()
        Me._ne = New System.Windows.Forms.PictureBox()
        Me._nw = New System.Windows.Forms.PictureBox()
        Me.use_ = New System.Windows.Forms.Button()
        Me.get_ = New System.Windows.Forms.Button()
        Me.se_ = New System.Windows.Forms.PictureBox()
        Me.sw_ = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_Go = New System.Windows.Forms.Button()
        Me.log_ = New SimpleProxy2.Controls.RichTextBoxEx()
        Me.toServer = New SimpleProxy2.Controls.RichTextBoxEx()
        Me.TS_Main.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.clientGroup.SuspendLayout()
        Me.GrpAction.SuspendLayout()
        CType(Me._ne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._nw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.se_, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sw_, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ActionTmr
        '
        Me.ActionTmr.Interval = 250
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TS_Main
        '
        Me.TS_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_Status_BotName, Me.TS_Filler, Me.TS_Status_Server, Me.TS_Status_Client})
        Me.TS_Main.Location = New System.Drawing.Point(0, 340)
        Me.TS_Main.Name = "TS_Main"
        Me.TS_Main.Size = New System.Drawing.Size(429, 22)
        Me.TS_Main.TabIndex = 50
        Me.TS_Main.Text = "StatusStrip1"
        '
        'TS_Status_BotName
        '
        Me.TS_Status_BotName.AutoSize = False
        Me.TS_Status_BotName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TS_Status_BotName.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TS_Status_BotName.Name = "TS_Status_BotName"
        Me.TS_Status_BotName.Size = New System.Drawing.Size(0, 17)
        Me.TS_Status_BotName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TS_Filler
        '
        Me.TS_Filler.Name = "TS_Filler"
        Me.TS_Filler.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always
        Me.TS_Filler.Size = New System.Drawing.Size(203, 17)
        Me.TS_Filler.Spring = True
        '
        'TS_Status_Server
        '
        Me.TS_Status_Server.Image = Global.SimpleProxy2.My.Resources.Resources.images2
        Me.TS_Status_Server.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TS_Status_Server.Name = "TS_Status_Server"
        Me.TS_Status_Server.Size = New System.Drawing.Size(106, 17)
        Me.TS_Status_Server.Text = "Server Status"
        Me.TS_Status_Server.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TS_Status_Server.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.TS_Status_Server.ToolTipText = "Disconnected"
        '
        'TS_Status_Client
        '
        Me.TS_Status_Client.AutoSize = False
        Me.TS_Status_Client.Image = Global.SimpleProxy2.My.Resources.Resources.images2
        Me.TS_Status_Client.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TS_Status_Client.Name = "TS_Status_Client"
        Me.TS_Status_Client.Size = New System.Drawing.Size(105, 17)
        Me.TS_Status_Client.Text = "Client Status"
        Me.TS_Status_Client.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TS_Status_Client.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.TS_Status_Client.ToolTipText = "Disconnected"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DreamCountTxtBx)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DreamList)
        Me.GroupBox1.Location = New System.Drawing.Point(281, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 151)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dream List"
        '
        'DreamCountTxtBx
        '
        Me.DreamCountTxtBx.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DreamCountTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DreamCountTxtBx.Location = New System.Drawing.Point(93, 125)
        Me.DreamCountTxtBx.Name = "DreamCountTxtBx"
        Me.DreamCountTxtBx.Size = New System.Drawing.Size(33, 23)
        Me.DreamCountTxtBx.TabIndex = 14
        Me.DreamCountTxtBx.Text = "###"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Furres in Dream:"
        '
        'DreamList
        '
        Me.DreamList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DreamList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DreamList.FormattingEnabled = True
        Me.DreamList.HorizontalScrollbar = True
        Me.DreamList.ItemHeight = 16
        Me.DreamList.Location = New System.Drawing.Point(5, 16)
        Me.DreamList.Name = "DreamList"
        Me.DreamList.Size = New System.Drawing.Size(124, 100)
        Me.DreamList.Sorted = True
        Me.DreamList.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.toServer)
        Me.GroupBox3.Controls.Add(Me.Btn_Bold)
        Me.GroupBox3.Controls.Add(Me.BTN_Underline)
        Me.GroupBox3.Controls.Add(Me.BTN_Italic)
        Me.GroupBox3.Controls.Add(Me.sendToServer)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(263, 142)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chat"
        '
        'Btn_Bold
        '
        Me.Btn_Bold.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Bold.Location = New System.Drawing.Point(180, 7)
        Me.Btn_Bold.Name = "Btn_Bold"
        Me.Btn_Bold.Size = New System.Drawing.Size(18, 19)
        Me.Btn_Bold.TabIndex = 60
        Me.Btn_Bold.Text = "B"
        Me.Btn_Bold.UseVisualStyleBackColor = True
        '
        'BTN_Underline
        '
        Me.BTN_Underline.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Underline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Underline.Location = New System.Drawing.Point(228, 7)
        Me.BTN_Underline.Name = "BTN_Underline"
        Me.BTN_Underline.Size = New System.Drawing.Size(29, 19)
        Me.BTN_Underline.TabIndex = 59
        Me.BTN_Underline.Text = "UL"
        Me.BTN_Underline.UseVisualStyleBackColor = True
        '
        'BTN_Italic
        '
        Me.BTN_Italic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Italic.Location = New System.Drawing.Point(204, 7)
        Me.BTN_Italic.Name = "BTN_Italic"
        Me.BTN_Italic.Size = New System.Drawing.Size(18, 19)
        Me.BTN_Italic.TabIndex = 58
        Me.BTN_Italic.Text = "I"
        Me.BTN_Italic.UseVisualStyleBackColor = True
        '
        'sendToServer
        '
        Me.sendToServer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sendToServer.Location = New System.Drawing.Point(222, 116)
        Me.sendToServer.Name = "sendToServer"
        Me.sendToServer.Size = New System.Drawing.Size(35, 20)
        Me.sendToServer.TabIndex = 4
        Me.sendToServer.Text = "->"
        Me.sendToServer.UseVisualStyleBackColor = True
        '
        'clientGroup
        '
        Me.clientGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clientGroup.Controls.Add(Me.log_)
        Me.clientGroup.Location = New System.Drawing.Point(12, 27)
        Me.clientGroup.Name = "clientGroup"
        Me.clientGroup.Size = New System.Drawing.Size(263, 151)
        Me.clientGroup.TabIndex = 51
        Me.clientGroup.TabStop = False
        Me.clientGroup.Text = "Log"
        '
        'GrpAction
        '
        Me.GrpAction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpAction.Controls.Add(Me.BtnSit_stand_Lie)
        Me.GrpAction.Controls.Add(Me.BTN_TurnL)
        Me.GrpAction.Controls.Add(Me.BTN_TurnR)
        Me.GrpAction.Controls.Add(Me._ne)
        Me.GrpAction.Controls.Add(Me._nw)
        Me.GrpAction.Controls.Add(Me.use_)
        Me.GrpAction.Controls.Add(Me.get_)
        Me.GrpAction.Controls.Add(Me.se_)
        Me.GrpAction.Controls.Add(Me.sw_)
        Me.GrpAction.Location = New System.Drawing.Point(281, 180)
        Me.GrpAction.Name = "GrpAction"
        Me.GrpAction.Size = New System.Drawing.Size(136, 116)
        Me.GrpAction.TabIndex = 54
        Me.GrpAction.TabStop = False
        Me.GrpAction.Text = "Actios"
        '
        'BtnSit_stand_Lie
        '
        Me.BtnSit_stand_Lie.Location = New System.Drawing.Point(19, 62)
        Me.BtnSit_stand_Lie.Name = "BtnSit_stand_Lie"
        Me.BtnSit_stand_Lie.Size = New System.Drawing.Size(33, 23)
        Me.BtnSit_stand_Lie.TabIndex = 44
        Me.BtnSit_stand_Lie.Text = "Sit"
        Me.BtnSit_stand_Lie.UseVisualStyleBackColor = True
        '
        'BTN_TurnL
        '
        Me.BTN_TurnL.Location = New System.Drawing.Point(19, 12)
        Me.BTN_TurnL.Name = "BTN_TurnL"
        Me.BTN_TurnL.Size = New System.Drawing.Size(33, 23)
        Me.BTN_TurnL.TabIndex = 43
        Me.BTN_TurnL.Text = "<="
        Me.BTN_TurnL.UseVisualStyleBackColor = True
        '
        'BTN_TurnR
        '
        Me.BTN_TurnR.Location = New System.Drawing.Point(19, 36)
        Me.BTN_TurnR.Name = "BTN_TurnR"
        Me.BTN_TurnR.Size = New System.Drawing.Size(33, 23)
        Me.BTN_TurnR.TabIndex = 42
        Me.BTN_TurnR.Text = "=>"
        Me.BTN_TurnR.UseVisualStyleBackColor = True
        '
        '_ne
        '
        Me._ne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._ne.Cursor = System.Windows.Forms.Cursors.Hand
        Me._ne.Image = CType(resources.GetObject("_ne.Image"), System.Drawing.Image)
        Me._ne.Location = New System.Drawing.Point(93, 12)
        Me._ne.Name = "_ne"
        Me._ne.Size = New System.Drawing.Size(36, 36)
        Me._ne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._ne.TabIndex = 41
        Me._ne.TabStop = False
        Me._ne.WaitOnLoad = True
        '
        '_nw
        '
        Me._nw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._nw.Cursor = System.Windows.Forms.Cursors.Hand
        Me._nw.Image = CType(resources.GetObject("_nw.Image"), System.Drawing.Image)
        Me._nw.Location = New System.Drawing.Point(57, 12)
        Me._nw.Name = "_nw"
        Me._nw.Size = New System.Drawing.Size(36, 36)
        Me._nw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._nw.TabIndex = 40
        Me._nw.TabStop = False
        Me._nw.WaitOnLoad = True
        '
        'use_
        '
        Me.use_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.use_.FlatAppearance.BorderSize = 0
        Me.use_.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.use_.Location = New System.Drawing.Point(78, 87)
        Me.use_.Name = "use_"
        Me.use_.Size = New System.Drawing.Size(35, 23)
        Me.use_.TabIndex = 38
        Me.use_.Text = "Use"
        Me.use_.UseVisualStyleBackColor = True
        '
        'get_
        '
        Me.get_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.get_.FlatAppearance.BorderSize = 0
        Me.get_.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.get_.Location = New System.Drawing.Point(40, 87)
        Me.get_.Name = "get_"
        Me.get_.Size = New System.Drawing.Size(32, 23)
        Me.get_.TabIndex = 37
        Me.get_.Text = "Get"
        Me.get_.UseVisualStyleBackColor = True
        '
        'se_
        '
        Me.se_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.se_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.se_.Image = CType(resources.GetObject("se_.Image"), System.Drawing.Image)
        Me.se_.Location = New System.Drawing.Point(93, 49)
        Me.se_.Name = "se_"
        Me.se_.Size = New System.Drawing.Size(36, 36)
        Me.se_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.se_.TabIndex = 36
        Me.se_.TabStop = False
        Me.se_.WaitOnLoad = True
        '
        'sw_
        '
        Me.sw_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sw_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sw_.Image = CType(resources.GetObject("sw_.Image"), System.Drawing.Image)
        Me.sw_.Location = New System.Drawing.Point(57, 49)
        Me.sw_.Name = "sw_"
        Me.sw_.Size = New System.Drawing.Size(36, 36)
        Me.sw_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.sw_.TabIndex = 35
        Me.sw_.TabStop = False
        Me.sw_.WaitOnLoad = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.WindowsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(429, 24)
        Me.MenuStrip1.TabIndex = 57
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ConfigToolStripMenuItem
        '
        Me.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem"
        Me.ConfigToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ConfigToolStripMenuItem.Text = "Config"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DebugToolStripMenuItem})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.WindowsToolStripMenuItem.Text = "Windows"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'BTN_Go
        '
        Me.BTN_Go.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Go.Location = New System.Drawing.Point(346, 300)
        Me.BTN_Go.Name = "BTN_Go"
        Me.BTN_Go.Size = New System.Drawing.Size(71, 26)
        Me.BTN_Go.TabIndex = 52
        Me.BTN_Go.Text = "Go!"
        Me.BTN_Go.UseVisualStyleBackColor = True
        '
        'log_
        '
        Me.log_.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.log_.Location = New System.Drawing.Point(3, 18)
        Me.log_.Name = "log_"
        Me.log_.Size = New System.Drawing.Size(254, 127)
        Me.log_.TabIndex = 49
        Me.log_.Text = ""
        '
        'toServer
        '
        Me.toServer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toServer.Location = New System.Drawing.Point(3, 28)
        Me.toServer.Name = "toServer"
        Me.toServer.Size = New System.Drawing.Size(254, 84)
        Me.toServer.TabIndex = 58
        Me.toServer.Text = ""
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 362)
        Me.Controls.Add(Me.clientGroup)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TS_Main)
        Me.Controls.Add(Me.BTN_Go)
        Me.Controls.Add(Me.GrpAction)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.SimpleProxy2.My.MySettings.Default, "MainFormLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.SimpleProxy2.My.MySettings.Default.MainFormLocation
        Me.MinimumSize = New System.Drawing.Size(445, 400)
        Me.Name = "Main"
        Me.Text = "Simple Proxy 2.0"
        Me.TS_Main.ResumeLayout(false)
        Me.TS_Main.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
        Me.clientGroup.ResumeLayout(false)
        Me.GrpAction.ResumeLayout(false)
        Me.GrpAction.PerformLayout
        CType(Me._ne,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me._nw,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.se_,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.sw_,System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ActionTmr As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TS_Main As System.Windows.Forms.StatusStrip
    Friend WithEvents TS_Status_BotName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TS_Status_Server As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TS_Status_Client As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TS_Filler As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DreamCountTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DreamList As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents sendToServer As System.Windows.Forms.Button
    Friend WithEvents clientGroup As System.Windows.Forms.GroupBox
    Friend WithEvents log_ As SimpleProxy2.Controls.RichTextBoxEx
    Friend WithEvents GrpAction As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSit_stand_Lie As System.Windows.Forms.Button
    Friend WithEvents BTN_TurnL As System.Windows.Forms.Button
    Friend WithEvents BTN_TurnR As System.Windows.Forms.Button
    Friend WithEvents _ne As System.Windows.Forms.PictureBox
    Friend WithEvents _nw As System.Windows.Forms.PictureBox
    Friend WithEvents use_ As System.Windows.Forms.Button
    Friend WithEvents get_ As System.Windows.Forms.Button
    Friend WithEvents se_ As System.Windows.Forms.PictureBox
    Friend WithEvents sw_ As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_Go As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Bold As System.Windows.Forms.Button
    Friend WithEvents BTN_Underline As System.Windows.Forms.Button
    Friend WithEvents BTN_Italic As System.Windows.Forms.Button
    Friend WithEvents DebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toServer As SimpleProxy2.Controls.RichTextBoxEx

End Class
