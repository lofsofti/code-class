Public Class Form1
    Dim topWall, leftWall, rightWall, paddle As PictureBox
    Dim ball As Label
    Dim block(98) As Label
    Dim x As Integer
    Dim ballV As String = "up"
    Dim ballH As String = "left"
    Dim paddleDir As String
    Dim blackCounter As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeObjects()
        makeBlocks()
        placeBlocks()
    End Sub
    Private Sub paddleTimer_Tick(sender As Object, e As EventArgs) Handles paddleTimer.Tick
        If paddleDir = "left" Then
            paddle.Location = New Point(paddle.Location.X - 4, paddle.Location.Y)
        End If
        If paddleDir = "right" Then
            paddle.Location = New Point(paddle.Location.X + 4, paddle.Location.Y)
        End If
        If paddle.Location.X < 20 Then paddleDir = "right"
        If paddle.Location.X > 508 Then paddleDir = "left"
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then paddleDir = "left"
        If e.KeyCode = Keys.Right Then paddleDir = "right"
        If e.KeyCode = Keys.Space Then ballTimer.Start()
    End Sub
    Private Sub ballTimer_Tick(sender As Object, e As EventArgs) Handles ballTimer.Tick
        If ballV = "up" Then ball.Location = New Point(ball.Location.X, ball.Location.Y - 4)
        If ballV = "down" Then ball.Location = New Point(ball.Location.X, ball.Location.Y + 4)
        If ballH = "left" Then ball.Location = New Point(ball.Location.X - 4, ball.Location.Y)
        If ballH = "right" Then ball.Location = New Point(ball.Location.X + 4, ball.Location.Y)
    End Sub
    Public Sub placeBlocks()
        'column 1
        For x = 1 To 6
            block(x).Location = New Point(80, 280 + (x - 1) * 20)
        Next
        'column 2
        For x = 7 To 11
            block(x).Location = New Point(120, 220 + (x - 7) * 20)
        Next
        'column 3
        block(12).Location = New Point(160, 120)
        block(13).Location = New Point(160, 140)
        For x = 14 To 23
            block(x).Location = New Point(160, 200 + (x - 14) * 20)
        Next
        'column 4
        For x = 24 To 33
            block(x).Location = New Point(200, 160 + (x - 24) * 20)
        Next
        block(34).Location = New Point(200, 400)
        block(35).Location = New Point(200, 420)
        'column 5
        For x = 36 To 43
            block(x).Location = New Point(240, 200 + (x - 36) * 20)
        Next
        block(44).Location = New Point(240, 400)
        block(45).Location = New Point(240, 420)
        'column 6
        For x = 46 To 53
            block(x).Location = New Point(280, 200 + (x - 46) * 20)
        Next
        'column 7
        For x = 54 To 61
            block(x).Location = New Point(320, 200 + (x - 54) * 20)
        Next
        block(62).Location = New Point(320, 400)
        block(63).Location = New Point(320, 420)
        'column 8
        For x = 64 To 73
            block(x).Location = New Point(360, 160 + (x - 64) * 20)
        Next
        block(74).Location = New Point(360, 400)
        block(75).Location = New Point(360, 420)
        'column 9
        block(76).Location = New Point(400, 120)
        block(77).Location = New Point(400, 140)
        For x = 78 To 87
            block(x).Location = New Point(400, 200 + (x - 78) * 20)
        Next
        'column 10
        For x = 88 To 92
            block(x).Location = New Point(440, 240 + (x - 88) * 20)
        Next
        'column 11
        For x = 93 To 98
            block(x).Location = New Point(480, 280 + (x - 93) * 20)
        Next
    End Sub
    Public Sub makeBlocks()
        For x = 1 To 98
            block(x) = New Label
            block(x).AutoSize = False
            block(x).Size = New Size(40, 20)
            block(x).BackColor = Color.Gray
            block(x).BorderStyle = BorderStyle.FixedSingle
            Controls.Add(block(x))
        Next
        block(12).BackColor = Color.Yellow
        block(13).BackColor = Color.Yellow
        block(24).BackColor = Color.Yellow
        block(25).BackColor = Color.Yellow
        block(28).BackColor = Color.Red
        block(29).BackColor = Color.Red
        block(64).BackColor = Color.Yellow
        block(65).BackColor = Color.Yellow
        block(68).BackColor = Color.Red
        block(69).BackColor = Color.Red
        block(76).BackColor = Color.Yellow
        block(77).BackColor = Color.Yellow
    End Sub
    Public Sub makeObjects()
        topWall = New PictureBox
        topWall.SizeMode = PictureBoxSizeMode.StretchImage
        topWall.Image = Image.FromFile("topwall.png")
        topWall.Location = New Point(0, 60)
        topWall.Size = New Size(600, 20)
        Controls.Add(topWall)
        leftWall = New PictureBox
        leftWall.SizeMode = PictureBoxSizeMode.StretchImage
        leftWall.Image = Image.FromFile("sidewall.png")
        leftWall.Location = New Point(0, 80)
        leftWall.Size = New Size(20, 600)
        Controls.Add(leftWall)
        rightWall = New PictureBox
        rightWall.SizeMode = PictureBoxSizeMode.StretchImage
        rightWall.Image = Image.FromFile("sidewall.png")
        rightWall.Location = New Point(580, 80)
        rightWall.Size = New Size(20, 600)
        Controls.Add(rightWall)
        paddle = New PictureBox
        paddle.SizeMode = PictureBoxSizeMode.StretchImage
        paddle.Image = Image.FromFile("paddle.png")
        paddle.Location = New Point(320, 600)
        paddle.Size = New Size(80, 20)
        Controls.Add(paddle)
        ball = New Label
        ball.BackColor = Color.Cyan
        ball.Size = New Size(10, 10)
        ball.Location = New Point(350, 590)
        Controls.Add(ball)
    End Sub
End Class