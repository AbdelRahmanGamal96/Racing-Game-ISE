﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.Left_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Right_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.EnemyCar3 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar2 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar1 = New System.Windows.Forms.PictureBox()
        Me.Car = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Enemy1_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy2_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy3_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.End_Text = New System.Windows.Forms.Label()
        Me.score_Text = New System.Windows.Forms.Label()
        Me.Repaly_Butten = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoadMover
        '
        Me.RoadMover.Enabled = True
        Me.RoadMover.Interval = 10
        '
        'Left_Mover
        '
        Me.Left_Mover.Interval = 10
        '
        'Right_Mover
        '
        Me.Right_Mover.Interval = 10
        '
        'EnemyCar3
        '
        Me.EnemyCar3.Image = Global.Racing_Game_ISE.My.Resources.Resources.enemy3
        Me.EnemyCar3.Location = New System.Drawing.Point(178, 26)
        Me.EnemyCar3.Name = "EnemyCar3"
        Me.EnemyCar3.Size = New System.Drawing.Size(34, 70)
        Me.EnemyCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar3.TabIndex = 11
        Me.EnemyCar3.TabStop = False
        '
        'EnemyCar2
        '
        Me.EnemyCar2.Image = Global.Racing_Game_ISE.My.Resources.Resources.enemy2
        Me.EnemyCar2.Location = New System.Drawing.Point(90, -26)
        Me.EnemyCar2.Name = "EnemyCar2"
        Me.EnemyCar2.Size = New System.Drawing.Size(34, 70)
        Me.EnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar2.TabIndex = 10
        Me.EnemyCar2.TabStop = False
        '
        'EnemyCar1
        '
        Me.EnemyCar1.Image = Global.Racing_Game_ISE.My.Resources.Resources.enemy1
        Me.EnemyCar1.Location = New System.Drawing.Point(6, 162)
        Me.EnemyCar1.Name = "EnemyCar1"
        Me.EnemyCar1.Size = New System.Drawing.Size(34, 70)
        Me.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar1.TabIndex = 9
        Me.EnemyCar1.TabStop = False
        '
        'Car
        '
        Me.Car.Image = Global.Racing_Game_ISE.My.Resources.Resources.Car
        Me.Car.Location = New System.Drawing.Point(90, 278)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(39, 71)
        Me.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Car.TabIndex = 8
        Me.Car.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(52, 314)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 95)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Location = New System.Drawing.Point(154, 314)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 95)
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(154, 85)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 95)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Location = New System.Drawing.Point(154, 195)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 95)
        Me.PictureBox7.TabIndex = 4
        Me.PictureBox7.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(52, 85)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 95)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(52, 195)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 95)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(154, -26)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 95)
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(52, -26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 95)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Enemy1_Mover
        '
        Me.Enemy1_Mover.Enabled = True
        Me.Enemy1_Mover.Interval = 10
        '
        'Enemy2_Mover
        '
        Me.Enemy2_Mover.Enabled = True
        Me.Enemy2_Mover.Interval = 10
        '
        'Enemy3_Mover
        '
        Me.Enemy3_Mover.Enabled = True
        Me.Enemy3_Mover.Interval = 10
        '
        'End_Text
        '
        Me.End_Text.AutoSize = True
        Me.End_Text.BackColor = System.Drawing.Color.Black
        Me.End_Text.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_Text.ForeColor = System.Drawing.Color.Red
        Me.End_Text.Location = New System.Drawing.Point(32, 99)
        Me.End_Text.Name = "End_Text"
        Me.End_Text.Size = New System.Drawing.Size(140, 30)
        Me.End_Text.TabIndex = 12
        Me.End_Text.Text = "GAME OVER"
        Me.End_Text.Visible = False
        '
        'score_Text
        '
        Me.score_Text.AutoSize = True
        Me.score_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score_Text.ForeColor = System.Drawing.SystemColors.Control
        Me.score_Text.Location = New System.Drawing.Point(3, 9)
        Me.score_Text.Name = "score_Text"
        Me.score_Text.Size = New System.Drawing.Size(59, 16)
        Me.score_Text.TabIndex = 13
        Me.score_Text.Text = "score 0"
        '
        'Repaly_Butten
        '
        Me.Repaly_Butten.BackColor = System.Drawing.Color.Black
        Me.Repaly_Butten.Font = New System.Drawing.Font("Ink Free", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Repaly_Butten.ForeColor = System.Drawing.Color.Red
        Me.Repaly_Butten.Location = New System.Drawing.Point(68, 138)
        Me.Repaly_Butten.Name = "Repaly_Butten"
        Me.Repaly_Butten.Size = New System.Drawing.Size(80, 38)
        Me.Repaly_Butten.TabIndex = 14
        Me.Repaly_Butten.Text = " REPLAY"
        Me.Repaly_Butten.UseVisualStyleBackColor = False
        Me.Repaly_Butten.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(153, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "speed 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(224, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Repaly_Butten)
        Me.Controls.Add(Me.score_Text)
        Me.Controls.Add(Me.End_Text)
        Me.Controls.Add(Me.EnemyCar3)
        Me.Controls.Add(Me.EnemyCar2)
        Me.Controls.Add(Me.EnemyCar1)
        Me.Controls.Add(Me.Car)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(240, 400)
        Me.MinimumSize = New System.Drawing.Size(240, 400)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents Car As PictureBox
    Friend WithEvents Left_Mover As Timer
    Friend WithEvents Right_Mover As Timer
    Friend WithEvents EnemyCar1 As PictureBox
    Friend WithEvents EnemyCar2 As PictureBox
    Friend WithEvents EnemyCar3 As PictureBox
    Friend WithEvents Enemy1_Mover As Timer
    Friend WithEvents Enemy2_Mover As Timer
    Friend WithEvents Enemy3_Mover As Timer
    Friend WithEvents End_Text As Label
    Friend WithEvents score_Text As Label
    Friend WithEvents Repaly_Butten As Button
    Friend WithEvents Label1 As Label
End Class
