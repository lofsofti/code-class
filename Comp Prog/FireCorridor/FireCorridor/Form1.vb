Public Class Form1
    Dim fireGrow As String = "bigger"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If fireGrow = "bigger" Then
            fire1.Size = New Size(fire1.Size.Width + 5, fire1.Size.Height)
            fire2.size = New Size(fire2.size.width + 5, fire2.size.height)
            fire2.Location = New Point(fire2.Location.X - 5, fire2.Location.Y)
            fire3.Size = New Size(fire3.Size.Width, fire3.Size.Height + 5)
            fire3.Location = New Point(fire3.Location.X, fire3.Location.Y - 5)
            fire4.Size = New Size(fire4.Size.Width, fire4.Size.Height + 5)
        Else
            fire1.Size = New Size(fire1.Size.Width - 5, fire1.Size.Height)
            fire2.Size = New Size(fire2.Size.Width - 5, fire2.Size.Height)
            fire2.Location = New Point(fire2.Location.X + 5, fire2.Location.Y)
            fire3.Size = New Size(fire3.Size.Width, fire3.Size.Height - 5)
            fire3.Location = New Point(fire3.Location.X, fire3.Location.Y + 5)
            fire4.Size = New Size(fire4.Size.Width, fire4.Size.Height - 5)
        End If
        If fire1.Size.Width = 135 Then fireGrow = "smaller"
        If fire1.Size.Width = 25 Then fireGrow = "bigger"

    End Sub
End Class
