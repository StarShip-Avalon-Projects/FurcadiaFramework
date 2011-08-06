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
        Me.clientGroup = New System.Windows.Forms.GroupBox()
        Me.sendToClient = New System.Windows.Forms.Button()
        Me.toClient = New System.Windows.Forms.TextBox()
        Me.clientList = New System.Windows.Forms.ListBox()
        Me.serverGroup = New System.Windows.Forms.GroupBox()
        Me.sendToServer = New System.Windows.Forms.Button()
        Me.toServer = New System.Windows.Forms.TextBox()
        Me.serverList = New System.Windows.Forms.ListBox()
        Me.configGroup = New System.Windows.Forms.GroupBox()
        Me.go = New System.Windows.Forms.Button()
        Me.browse = New System.Windows.Forms.Button()
        Me.localPort = New System.Windows.Forms.TextBox()
        Me.destination = New System.Windows.Forms.TextBox()
        Me.furcadiaPath = New System.Windows.Forms.TextBox()
        Me.portLabel = New System.Windows.Forms.Label()
        Me.destLabel = New System.Windows.Forms.Label()
        Me.pathLabel = New System.Windows.Forms.Label()
        Me.ioConfigContainer = New System.Windows.Forms.SplitContainer()
        Me.clientServerContainer = New System.Windows.Forms.SplitContainer()
        Me.browseDialog = New System.Windows.Forms.OpenFileDialog()
        Me.clientGroup.SuspendLayout()
        Me.serverGroup.SuspendLayout()
        Me.configGroup.SuspendLayout()
        Me.ioConfigContainer.Panel1.SuspendLayout()
        Me.ioConfigContainer.Panel2.SuspendLayout()
        Me.ioConfigContainer.SuspendLayout()
        Me.clientServerContainer.Panel1.SuspendLayout()
        Me.clientServerContainer.Panel2.SuspendLayout()
        Me.clientServerContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'clientGroup
        '
        Me.clientGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clientGroup.Controls.Add(Me.sendToClient)
        Me.clientGroup.Controls.Add(Me.toClient)
        Me.clientGroup.Controls.Add(Me.clientList)
        Me.clientGroup.Location = New System.Drawing.Point(11, 3)
        Me.clientGroup.Name = "clientGroup"
        Me.clientGroup.Size = New System.Drawing.Size(180, 194)
        Me.clientGroup.TabIndex = 0
        Me.clientGroup.TabStop = False
        Me.clientGroup.Text = "From Client"
        '
        'sendToClient
        '
        Me.sendToClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sendToClient.Location = New System.Drawing.Point(127, 163)
        Me.sendToClient.Name = "sendToClient"
        Me.sendToClient.Size = New System.Drawing.Size(35, 20)
        Me.sendToClient.TabIndex = 2
        Me.sendToClient.Text = "->"
        Me.sendToClient.UseVisualStyleBackColor = True
        '
        'toClient
        '
        Me.toClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toClient.Location = New System.Drawing.Point(18, 163)
        Me.toClient.Name = "toClient"
        Me.toClient.Size = New System.Drawing.Size(103, 20)
        Me.toClient.TabIndex = 1
        '
        'clientList
        '
        Me.clientList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clientList.FormattingEnabled = True
        Me.clientList.Location = New System.Drawing.Point(18, 19)
        Me.clientList.Name = "clientList"
        Me.clientList.Size = New System.Drawing.Size(144, 134)
        Me.clientList.TabIndex = 0
        '
        'serverGroup
        '
        Me.serverGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.serverGroup.Controls.Add(Me.sendToServer)
        Me.serverGroup.Controls.Add(Me.toServer)
        Me.serverGroup.Controls.Add(Me.serverList)
        Me.serverGroup.Location = New System.Drawing.Point(12, 3)
        Me.serverGroup.Name = "serverGroup"
        Me.serverGroup.Size = New System.Drawing.Size(180, 194)
        Me.serverGroup.TabIndex = 1
        Me.serverGroup.TabStop = False
        Me.serverGroup.Text = "From Server"
        '
        'sendToServer
        '
        Me.sendToServer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sendToServer.Location = New System.Drawing.Point(127, 163)
        Me.sendToServer.Name = "sendToServer"
        Me.sendToServer.Size = New System.Drawing.Size(35, 20)
        Me.sendToServer.TabIndex = 2
        Me.sendToServer.Text = "->"
        Me.sendToServer.UseVisualStyleBackColor = True
        '
        'toServer
        '
        Me.toServer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toServer.Location = New System.Drawing.Point(18, 163)
        Me.toServer.Name = "toServer"
        Me.toServer.Size = New System.Drawing.Size(103, 20)
        Me.toServer.TabIndex = 1
        '
        'serverList
        '
        Me.serverList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.serverList.FormattingEnabled = True
        Me.serverList.Location = New System.Drawing.Point(18, 19)
        Me.serverList.Name = "serverList"
        Me.serverList.Size = New System.Drawing.Size(144, 134)
        Me.serverList.TabIndex = 0
        '
        'configGroup
        '
        Me.configGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.configGroup.Controls.Add(Me.go)
        Me.configGroup.Controls.Add(Me.browse)
        Me.configGroup.Controls.Add(Me.localPort)
        Me.configGroup.Controls.Add(Me.destination)
        Me.configGroup.Controls.Add(Me.furcadiaPath)
        Me.configGroup.Controls.Add(Me.portLabel)
        Me.configGroup.Controls.Add(Me.destLabel)
        Me.configGroup.Controls.Add(Me.pathLabel)
        Me.configGroup.Location = New System.Drawing.Point(11, 7)
        Me.configGroup.Name = "configGroup"
        Me.configGroup.Size = New System.Drawing.Size(388, 128)
        Me.configGroup.TabIndex = 2
        Me.configGroup.TabStop = False
        Me.configGroup.Text = "Configuration"
        '
        'go
        '
        Me.go.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.go.Location = New System.Drawing.Point(277, 85)
        Me.go.Name = "go"
        Me.go.Size = New System.Drawing.Size(93, 27)
        Me.go.TabIndex = 8
        Me.go.Text = "Go!"
        Me.go.UseVisualStyleBackColor = True
        '
        'browse
        '
        Me.browse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.browse.Location = New System.Drawing.Point(344, 24)
        Me.browse.Name = "browse"
        Me.browse.Size = New System.Drawing.Size(24, 19)
        Me.browse.TabIndex = 6
        Me.browse.Text = "..."
        Me.browse.UseVisualStyleBackColor = True
        '
        'localPort
        '
        Me.localPort.Location = New System.Drawing.Point(96, 76)
        Me.localPort.MaxLength = 5
        Me.localPort.Name = "localPort"
        Me.localPort.Size = New System.Drawing.Size(58, 20)
        Me.localPort.TabIndex = 5
        Me.localPort.Text = "6500"
        '
        'destination
        '
        Me.destination.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.destination.Location = New System.Drawing.Point(96, 50)
        Me.destination.Name = "destination"
        Me.destination.Size = New System.Drawing.Size(242, 20)
        Me.destination.TabIndex = 4
        Me.destination.Text = "lightbringer.furcadia.com:6500"
        '
        'furcadiaPath
        '
        Me.furcadiaPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.furcadiaPath.Location = New System.Drawing.Point(96, 24)
        Me.furcadiaPath.Name = "furcadiaPath"
        Me.furcadiaPath.Size = New System.Drawing.Size(242, 20)
        Me.furcadiaPath.TabIndex = 3
        '
        'portLabel
        '
        Me.portLabel.AutoSize = True
        Me.portLabel.Location = New System.Drawing.Point(27, 79)
        Me.portLabel.Name = "portLabel"
        Me.portLabel.Size = New System.Drawing.Size(58, 13)
        Me.portLabel.TabIndex = 2
        Me.portLabel.Text = "Local Port:"
        '
        'destLabel
        '
        Me.destLabel.AutoSize = True
        Me.destLabel.Location = New System.Drawing.Point(27, 53)
        Me.destLabel.Name = "destLabel"
        Me.destLabel.Size = New System.Drawing.Size(63, 13)
        Me.destLabel.TabIndex = 1
        Me.destLabel.Text = "Destination:"
        '
        'pathLabel
        '
        Me.pathLabel.AutoSize = True
        Me.pathLabel.Location = New System.Drawing.Point(27, 27)
        Me.pathLabel.Name = "pathLabel"
        Me.pathLabel.Size = New System.Drawing.Size(32, 13)
        Me.pathLabel.TabIndex = 0
        Me.pathLabel.Text = "Path:"
        '
        'ioConfigContainer
        '
        Me.ioConfigContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ioConfigContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ioConfigContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.ioConfigContainer.IsSplitterFixed = True
        Me.ioConfigContainer.Location = New System.Drawing.Point(12, 12)
        Me.ioConfigContainer.Name = "ioConfigContainer"
        Me.ioConfigContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ioConfigContainer.Panel1
        '
        Me.ioConfigContainer.Panel1.Controls.Add(Me.clientServerContainer)
        '
        'ioConfigContainer.Panel2
        '
        Me.ioConfigContainer.Panel2.Controls.Add(Me.configGroup)
        Me.ioConfigContainer.Size = New System.Drawing.Size(413, 358)
        Me.ioConfigContainer.SplitterDistance = 207
        Me.ioConfigContainer.TabIndex = 3
        '
        'clientServerContainer
        '
        Me.clientServerContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clientServerContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clientServerContainer.Location = New System.Drawing.Point(0, 0)
        Me.clientServerContainer.Name = "clientServerContainer"
        '
        'clientServerContainer.Panel1
        '
        Me.clientServerContainer.Panel1.Controls.Add(Me.clientGroup)
        Me.clientServerContainer.Panel1MinSize = 128
        '
        'clientServerContainer.Panel2
        '
        Me.clientServerContainer.Panel2.Controls.Add(Me.serverGroup)
        Me.clientServerContainer.Panel2MinSize = 128
        Me.clientServerContainer.Size = New System.Drawing.Size(413, 207)
        Me.clientServerContainer.SplitterDistance = 203
        Me.clientServerContainer.TabIndex = 0
        '
        'browseDialog
        '
        Me.browseDialog.DefaultExt = "exe"
        Me.browseDialog.Filter = "Furcadia Client (Furcadia.exe)|Furcadia.exe"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 383)
        Me.Controls.Add(Me.ioConfigContainer)
        Me.MinimumSize = New System.Drawing.Size(445, 400)
        Me.Name = "Main"
        Me.Text = "Simple Proxy"
        Me.clientGroup.ResumeLayout(False)
        Me.clientGroup.PerformLayout()
        Me.serverGroup.ResumeLayout(False)
        Me.serverGroup.PerformLayout()
        Me.configGroup.ResumeLayout(False)
        Me.configGroup.PerformLayout()
        Me.ioConfigContainer.Panel1.ResumeLayout(False)
        Me.ioConfigContainer.Panel2.ResumeLayout(False)
        Me.ioConfigContainer.ResumeLayout(False)
        Me.clientServerContainer.Panel1.ResumeLayout(False)
        Me.clientServerContainer.Panel2.ResumeLayout(False)
        Me.clientServerContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents clientGroup As System.Windows.Forms.GroupBox
    Friend WithEvents toClient As System.Windows.Forms.TextBox
    Friend WithEvents clientList As System.Windows.Forms.ListBox
    Friend WithEvents sendToClient As System.Windows.Forms.Button
    Friend WithEvents serverGroup As System.Windows.Forms.GroupBox
    Friend WithEvents sendToServer As System.Windows.Forms.Button
    Friend WithEvents toServer As System.Windows.Forms.TextBox
    Friend WithEvents serverList As System.Windows.Forms.ListBox
    Friend WithEvents configGroup As System.Windows.Forms.GroupBox
    Friend WithEvents localPort As System.Windows.Forms.TextBox
    Friend WithEvents destination As System.Windows.Forms.TextBox
    Friend WithEvents furcadiaPath As System.Windows.Forms.TextBox
    Friend WithEvents portLabel As System.Windows.Forms.Label
    Friend WithEvents destLabel As System.Windows.Forms.Label
    Friend WithEvents pathLabel As System.Windows.Forms.Label
    Friend WithEvents browse As System.Windows.Forms.Button
    Friend WithEvents go As System.Windows.Forms.Button
    Friend WithEvents ioConfigContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents clientServerContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents browseDialog As System.Windows.Forms.OpenFileDialog

End Class
