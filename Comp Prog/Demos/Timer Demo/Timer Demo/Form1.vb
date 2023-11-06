Public Class Form1
    Dim dir As String 'Control the direction of the Box
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If dir = "right" Then
            Box.Location = New Point(Box.Location.X + 5, Box.Location.Y)
        End If
        If dir = "left" Then
            Box.Location = New Point(Box.Location.X - 5, Box.Location.Y)
        End If
        If dir = "up" Then
            Box.Location = New Point(Box.Location.X, Box.Location.Y - 5)
        End If
        If dir = "down" Then
            Box.Location = New Point(Box.Location.X, Box.Location.Y + 5)
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.D Then
            dir = "right"
        End If
        If e.KeyCode = Keys.A Then
            dir = "left"
        End If
        If e.KeyCode = Keys.W Then
            dir = "up"
        End If
        If e.KeyCode = Keys.S Then
            dir = "down"
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        dir = "kfjsahfdlkjh"
    End Sub
End Class
