<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIntro
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
        Me.components = New System.ComponentModel.Container()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnInstruction = New System.Windows.Forms.Button()
        Me.btnLeaderboards = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.Image = Global.Radwan_AdhamSnake.My.Resources.Resources.Start1
        Me.btnStart.Location = New System.Drawing.Point(143, 100)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(227, 61)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "&S"
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.btnStart, "Press here to start game.")
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.Radwan_AdhamSnake.My.Resources.Resources.Welcome
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(500, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Radwan_AdhamSnake.My.Resources.Resources.Skull
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(523, 464)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnInstruction
        '
        Me.btnInstruction.BackColor = System.Drawing.Color.Transparent
        Me.btnInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInstruction.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstruction.Location = New System.Drawing.Point(21, 381)
        Me.btnInstruction.Name = "btnInstruction"
        Me.btnInstruction.Size = New System.Drawing.Size(129, 33)
        Me.btnInstruction.TabIndex = 2
        Me.btnInstruction.Text = "&Instructions"
        Me.ToolTip1.SetToolTip(Me.btnInstruction, "Click here for instructions on how to play the game!")
        Me.btnInstruction.UseVisualStyleBackColor = False
        '
        'btnLeaderboards
        '
        Me.btnLeaderboards.BackColor = System.Drawing.Color.Transparent
        Me.btnLeaderboards.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLeaderboards.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeaderboards.Location = New System.Drawing.Point(385, 381)
        Me.btnLeaderboards.Name = "btnLeaderboards"
        Me.btnLeaderboards.Size = New System.Drawing.Size(129, 33)
        Me.btnLeaderboards.TabIndex = 3
        Me.btnLeaderboards.Text = "&Leaderboards"
        Me.ToolTip1.SetToolTip(Me.btnLeaderboards, "Click here to check out the leaderboards for this game.")
        Me.btnLeaderboards.UseVisualStyleBackColor = False
        '
        'FormIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(518, 426)
        Me.Controls.Add(Me.btnLeaderboards)
        Me.Controls.Add(Me.btnInstruction)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "FormIntro"
        Me.Text = "Welcome To Snake"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnInstruction As System.Windows.Forms.Button
    Friend WithEvents btnLeaderboards As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
