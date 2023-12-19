Public Class Form1
    Dim hdir As String = "right"
    Dim vdir As String = "up"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If hdir = "right" Then
            Box.Location = New Point(Box.Location.X + 5, Box.Location.Y)
        End If
        If hdir = "left" Then
            Box.Location = New Point(Box.Location.X - 5, Box.Location.Y)
        End If
        If vdir = "up" Then
            Box.Location = New Point(Box.Location.X, Box.Location.Y - 5)
        End If
        If vdir = "down" Then
            Box.Location = New Point(Box.Location.X, Box.Location.Y + 5)
        End If

        'check top
        If Box.Location.Y = 0 Then
            vdir = "down"
        End If
        'check left
        If Box.Location.X = 0 Then
            hdir = "right"
        End If
        'check right side
        If Box.Location.X = 280 Then
            hdir = "left"
        End If
        'check bottom
        If Box.Location.Y = 380 Then
            vdir = "up"
        End If
    End Sub
End Class