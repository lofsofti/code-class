Public Class Form1
    Dim hdir As String = "right"
    Dim vdir As String = "down"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If hdir = "right" Then
            box.Location = New Point(box.Location.X + 5, box.Location.Y)
        End If
        If hdir = "left" Then
            box.Location = New Point(box.Location.X - 5, box.Location.Y)
        End If
        If vdir = "up" Then
            box.Location = New Point(box.Location.X, box.Location.Y - 5)
        End If
        If vdir = "down" Then
            box.Location = New Point(box.Location.X, box.Location.Y + 5)
        End If
        'starts at 100, 50 (down and right)
        'turn left at 150, 100
        '50, 100 - turn up and right

        If box.Location.X = 250 And box.Location.Y = 150 Then
            hdir = "left"
            vdir = "nothing"
        End If
        If box.Location.X = 50 And box.Location.Y = 150 Then
            hdir = "right"
            vdir = "up"
        End If
        If box.Location.X = 150 And box.Location.Y = 50 Then
            hdir = "right"
            vdir = "down"
        End If
    End Sub
End Class