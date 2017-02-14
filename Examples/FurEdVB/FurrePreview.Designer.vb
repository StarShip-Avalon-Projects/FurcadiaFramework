<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FurrePreview
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.remapMaskCheckBox = New System.Windows.Forms.CheckBox()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.speciesChooser = New System.Windows.Forms.TreeView()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.avatarPreview = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.avatarPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'remapMaskCheckBox
        '
        Me.remapMaskCheckBox.AutoSize = True
        Me.remapMaskCheckBox.Location = New System.Drawing.Point(413, 136)
        Me.remapMaskCheckBox.Name = "remapMaskCheckBox"
        Me.remapMaskCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.remapMaskCheckBox.TabIndex = 26
        Me.remapMaskCheckBox.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(374, 130)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(28, 23)
        Me.button5.TabIndex = 25
        Me.button5.Text = ">"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(341, 130)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(28, 23)
        Me.button6.TabIndex = 24
        Me.button6.Text = "<"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(407, 101)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(28, 23)
        Me.button3.TabIndex = 23
        Me.button3.Text = "U"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(374, 101)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(28, 23)
        Me.button2.TabIndex = 22
        Me.button2.Text = "F"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(341, 101)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(28, 23)
        Me.button1.TabIndex = 21
        Me.button1.Text = "M"
        Me.button1.UseVisualStyleBackColor = True
        '
        'speciesChooser
        '
        Me.speciesChooser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.speciesChooser.Location = New System.Drawing.Point(0, 0)
        Me.speciesChooser.Name = "speciesChooser"
        Me.speciesChooser.Size = New System.Drawing.Size(169, 160)
        Me.speciesChooser.TabIndex = 20
        '
        'pictureBox2
        '
        Me.pictureBox2.Location = New System.Drawing.Point(341, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(95, 95)
        Me.pictureBox2.TabIndex = 19
        Me.pictureBox2.TabStop = False
        '
        'avatarPreview
        '
        Me.avatarPreview.BackColor = System.Drawing.Color.Snow
        Me.avatarPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.avatarPreview.Location = New System.Drawing.Point(175, 0)
        Me.avatarPreview.Name = "avatarPreview"
        Me.avatarPreview.Size = New System.Drawing.Size(160, 160)
        Me.avatarPreview.TabIndex = 18
        Me.avatarPreview.TabStop = False
        '
        'FurrePreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.remapMaskCheckBox)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.speciesChooser)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.avatarPreview)
        Me.Name = "FurrePreview"
        Me.Size = New System.Drawing.Size(436, 160)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.avatarPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents remapMaskCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents button5 As System.Windows.Forms.Button
    Private WithEvents button6 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents speciesChooser As System.Windows.Forms.TreeView
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents avatarPreview As System.Windows.Forms.PictureBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument

End Class
