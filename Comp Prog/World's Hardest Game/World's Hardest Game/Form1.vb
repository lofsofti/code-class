Public Class Form1
    Dim boxDir As String
    Dim ballDir As String = "left"
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Then boxDir = "up"
        If e.KeyCode = Keys.A Then boxDir = "left"
        If e.KeyCode = Keys.S Then boxDir = "down"
        If e.KeyCode = Keys.D Then boxDir = "right"
    End Sub

    Private Sub boxTimer_Tick(sender As Object, e As EventArgs) Handles boxTimer.Tick
        moveBox()
        checkBallCollisions()
        checkWallCollisions()
    End Sub

    Public Sub moveBox()
        If boxDir = "up" Then Box.Location = New Point(Box.Location.X, Box.Location.Y - 5)
        If boxDir = "left" Then Box.Location = New Point(Box.Location.X - 5, Box.Location.Y)
        If boxDir = "down" Then Box.Location = New Point(Box.Location.X, Box.Location.Y + 5)
        If boxDir = "right" Then Box.Location = New Point(Box.Location.X + 5, Box.Location.Y)
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        boxDir = "ahdsfhsjjda;lkfgjh"
    End Sub

    Private Sub ballTimer_Tick(sender As Object, e As EventArgs) Handles ballTimer.Tick
        If ballDir = "left" Then
            Ball1.Location = New Point(Ball1.Location.X - 4, Ball1.Location.Y)
            Ball3.Location = New Point(Ball3.Location.X - 4, Ball3.Location.Y)
            Ball2.Location = New Point(Ball2.Location.X + 4, Ball2.Location.Y)
            Ball4.Location = New Point(Ball4.Location.X + 4, Ball4.Location.Y)
        Else
            Ball1.Location = New Point(Ball1.Location.X + 4, Ball1.Location.Y)
            Ball3.Location = New Point(Ball3.Location.X + 4, Ball3.Location.Y)
            Ball2.Location = New Point(Ball2.Location.X - 4, Ball2.Location.Y)
            Ball4.Location = New Point(Ball4.Location.X - 4, Ball4.Location.Y)
        End If
        If Ball1.Location.X = 120 Then ballDir = "right"
        If Ball1.Location.X = 308 Then ballDir = "left"
    End Sub

    Public Sub checkBallCollisions()
        If Box.Bounds.IntersectsWith(Ball1.Bounds) Then
            Box.Location = New Point(62, 172)
        End If
        If Box.Bounds.IntersectsWith(Ball2.Bounds) Then
            Box.Location = New Point(62, 172)
        End If
        If Box.Bounds.IntersectsWith(Ball3.Bounds) Then
            Box.Location = New Point(62, 172)
        End If
        If Box.Bounds.IntersectsWith(Ball4.Bounds) Then
            Box.Location = New Point(62, 172)
        End If
    End Sub

    Public Sub checkWallCollision()
        If Box.Bounds.IntersectsWith(Wall1.Bounds) Then

        End If
    End Sub
End Class
