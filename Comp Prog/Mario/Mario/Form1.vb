Public Class Form1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W And mario.Location.Y > 0 Then
            mario.Location = New Point(mario.Location.X, mario.Location.Y - 4)
            mario.Image = Image.FromFile("up1.png")
        End If
        If e.KeyCode = Keys.A And mario.Location.X > 0 Then
            mario.Location = New Point(mario.Location.X - 4, mario.Location.Y)
            mario.Image = Image.FromFile("left1.png")
        End If
        If e.KeyCode = Keys.S And mario.Location.Y < 436 Then
            mario.Location = New Point(mario.Location.X, mario.Location.Y + 4)
            mario.Image = Image.FromFile("down1.png")
        End If
        If e.KeyCode = Keys.D And mario.Location.X < 460 Then
            mario.Location = New Point(mario.Location.X + 4, mario.Location.Y)
            mario.Image = Image.FromFile("right1.png")
        End If
        If e.KeyCode = Keys.Q And mario.Location.X > 0 And mario.Location.Y > 0 Then
            mario.Location = New Point(mario.Location.X - 4, mario.Location.Y - 4)
        End If
        If e.KeyCode = Keys.E And mario.Location.X < 460 And mario.Location.Y < 0 Then
            mario.Location = New Point(mario.Location.X + 4, mario.Location.Y - 4)
        End If
        If e.KeyCode = Keys.W And Keys.A And mario.Location.X > 0 And mario.Location.Y > 0 Then
            mario.Location = New Point(mario.Location.X - 4, mario.Location.Y - 4)
        End If
    End Sub
End Class
