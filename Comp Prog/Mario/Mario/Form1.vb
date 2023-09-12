Public Class Form1
    Dim firstStep As Boolean = True
    Dim dir As String
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Up
        If e.KeyCode = Keys.W And mario.Location.Y > 0 Then
            mario.Location = New Point(mario.Location.X, mario.Location.Y - 4)
            If firstStep = True Then
                mario.Image = Image.FromFile("up1.png")
            Else
                mario.Image = Image.FromFile("up2.png")
            End If
        End If
        'Left
        If e.KeyCode = Keys.A And mario.Location.X > 0 Then
            mario.Location = New Point(mario.Location.X - 4, mario.Location.Y)
            If firstStep = True Then
                mario.Image = Image.FromFile("left1.png")
            Else
                mario.Image = Image.FromFile("left2.png")
            End If
        End If
        'Down
        If e.KeyCode = Keys.S And mario.Location.Y < 436 Then
            mario.Location = New Point(mario.Location.X, mario.Location.Y + 4)
            If firstStep = True Then
                mario.Image = Image.FromFile("down1.png")
            Else
                mario.Image = Image.FromFile("down2.png")
            End If
        End If
        'Right
        If e.KeyCode = Keys.D And mario.Location.X < 460 Then
            mario.Location = New Point(mario.Location.X + 4, mario.Location.Y)
            If firstStep = True Then
                mario.Image = Image.FromFile("right1.png")
            Else
                mario.Image = Image.FromFile("right2.png")
            End If
        End If
        'UpLeft
        If e.KeyCode = Keys.Q And mario.Location.X > 0 And mario.Location.Y > 0 Then
            mario.Location = New Point(mario.Location.X - 4, mario.Location.Y - 4)
        End If
        'UpRight
        If e.KeyCode = Keys.E And mario.Location.X > 0 And mario.Location.Y > 0 Then
            mario.Location = New Point(mario.Location.X + 4, mario.Location.Y - 4)
        End If
        'DownLeft
        If e.KeyCode = Keys.Z And mario.Location.X > 0 And mario.Location.Y < 436 Then
            mario.Location = New Point(mario.Location.X - 4, mario.Location.Y + 4)
        End If
        'DownRight
        If e.KeyCode = Keys.C And mario.Location.X < 460 And mario.Location.Y < 436 Then
            mario.Location = New Point(mario.Location.X + 4, mario.Location.Y + 4)
        End If

        firstStep = Not firstStep
        checkCollisions()

    End Sub
    Public Sub checkCollisions()
        If mario.Bounds.IntersectsWith(lava.Bounds) Then
            MsgBox("L bozo imagine getting burnt💀")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Left and Right
        If mario.Location.X < bowser.Location.X Then
            bowser.Location = New Point(bowser.Location.X - 4, bowser.Location.Y)
        Else
            bowser.Location = New Point(bowser.Location.X + 4, bowser.Location.Y)
        End If
        'Up and Down
        If mario.Location.Y < bowser.Location.Y Then
            bowser.Location = New Point(bowser.Location.X, bowser.Location.Y - 4)
        Else
            bowser.Location = New Point(bowser.Location.X, bowser.Location.Y + 4)
        End If

        If bowser.Bounds.IntersectsWith(mario.Bounds) Then
            Timer1.Stop()
            MsgBox("NOM NOM")
        End If
    End Sub
End Class
