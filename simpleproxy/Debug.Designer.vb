<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debug
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
        Me.clientGroup = New System.Windows.Forms.GroupBox()
        Me.log_ = New System.Windows.Forms.RichTextBox()
        Me.ChkBxDebug = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.clientGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'clientGroup
        '
        Me.clientGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clientGroup.Controls.Add(Me.log_)
        Me.clientGroup.Location = New System.Drawing.Point(9, 12)
        Me.clientGroup.Name = "clientGroup"
        Me.clientGroup.Size = New System.Drawing.Size(263, 184)
        Me.clientGroup.TabIndex = 1
        Me.clientGroup.TabStop = False
        Me.clientGroup.Text = "Log"
        '
        'log_
        '
        Me.log_.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.log_.Location = New System.Drawing.Point(3, 16)
        Me.log_.Name = "log_"
        Me.log_.Size = New System.Drawing.Size(257, 162)
        Me.log_.TabIndex = 1
        Me.log_.Text = ""
        '
        'ChkBxDebug
        '
        Me.ChkBxDebug.AutoSize = True
        Me.ChkBxDebug.Location = New System.Drawing.Point(12, 202)
        Me.ChkBxDebug.Name = "ChkBxDebug"
        Me.ChkBxDebug.Size = New System.Drawing.Size(94, 17)
        Me.ChkBxDebug.TabIndex = 2
        Me.ChkBxDebug.Text = "Enable Debug"
        Me.ChkBxDebug.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 225)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(76, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Everything"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 248)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(95, 17)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "Dragon Speak"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(112, 202)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox3.TabIndex = 5
        Me.CheckBox3.Text = "Emits"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(112, 225)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(76, 17)
        Me.CheckBox4.TabIndex = 6
        Me.CheckBox4.Text = "Everything"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'Debug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 280)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ChkBxDebug)
        Me.Controls.Add(Me.clientGroup)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.SimpleProxy2.My.MySettings.Default, "Debug", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.SimpleProxy2.My.MySettings.Default.Debug
        Me.Name = "Debug"
        Me.Text = "Debug"
        Me.clientGroup.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clientGroup As System.Windows.Forms.GroupBox
    Friend WithEvents log_ As System.Windows.Forms.RichTextBox
    Friend WithEvents ChkBxDebug As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
End Class
