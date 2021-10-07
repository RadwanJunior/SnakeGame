<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.picZone = New System.Windows.Forms.PictureBox()
        Me.TimeMover = New System.Windows.Forms.Timer(Me.components)
        Me.picApple = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFood = New System.Windows.Forms.Label()
        CType(Me.picZone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picApple, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picZone
        '
        Me.picZone.BackColor = System.Drawing.Color.Black
        Me.picZone.Location = New System.Drawing.Point(12, 12)
        Me.picZone.Name = "picZone"
        Me.picZone.Size = New System.Drawing.Size(460, 430)
        Me.picZone.TabIndex = 0
        Me.picZone.TabStop = False
        '
        'TimeMover
        '
        Me.TimeMover.Interval = 50
        '
        'picApple
        '
        Me.picApple.BackColor = System.Drawing.Color.Transparent
        Me.picApple.Image = Global.Radwan_AdhamSnake.My.Resources.Resources.apple
        Me.picApple.Location = New System.Drawing.Point(222, 162)
        Me.picApple.Name = "picApple"
        Me.picApple.Size = New System.Drawing.Size(15, 15)
        Me.picApple.TabIndex = 1
        Me.picApple.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 453)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "# of food collected:"
        '
        'lblFood
        '
        Me.lblFood.AutoSize = True
        Me.lblFood.Location = New System.Drawing.Point(114, 453)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(0, 13)
        Me.lblFood.TabIndex = 3
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(486, 475)
        Me.Controls.Add(Me.lblFood)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picApple)
        Me.Controls.Add(Me.picZone)
        Me.Name = "Game"
        Me.Text = "Game"
        CType(Me.picZone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picApple, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picZone As System.Windows.Forms.PictureBox
    Friend WithEvents TimeMover As System.Windows.Forms.Timer
    Friend WithEvents picApple As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFood As System.Windows.Forms.Label
End Class
