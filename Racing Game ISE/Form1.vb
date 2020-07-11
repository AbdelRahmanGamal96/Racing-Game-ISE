﻿Public Class Form1
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top > Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            Right_Mover.Start()
        End If
        If e.KeyCode = Keys.Left Then
            Left_Mover.Start()
        End If
    End Sub

    Private Sub Right_Mover_Tick(sender As Object, e As EventArgs) Handles Right_Mover.Tick
        If (Car.Location.X < 181) Then
            Car.Left += 5
        End If
    End Sub
End Class