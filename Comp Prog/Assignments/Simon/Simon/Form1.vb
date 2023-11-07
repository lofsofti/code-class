Public Class Form1
    Dim r As Integer
    Dim currentRound As Integer
    Dim stepNum As Integer
    Dim highScore As Integer = 0
    Dim gameOver As Boolean = True
    Dim delay As Boolean = False
    Dim gameDifficulty As String = "easy"
    Dim pattern As New List(Of String)
    Private Sub EasyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EasyToolStripMenuItem.Click
        If gameOver = True Then
            gameDifficulty = "easy"
            updateTimer()
        End If
    End Sub
    Private Sub MediumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediumToolStripMenuItem.Click
        If gameOver = True Then
            gameDifficulty = "medium"
            updateTimer()
        End If
    End Sub
    Private Sub HardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DifficultToolStripMenuItem.Click
        If gameOver = True Then
            gameDifficulty = "hard"
            updateTimer()
        End If
    End Sub
    Public Sub updateTimer()
        If gameDifficulty = "easy" Then patternTimer.Interval = 1000
        If gameDifficulty = "medium" Then patternTimer.Interval = 750
        If gameDifficulty = "hard" Then patternTimer.Interval = 500
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.N And gameOver = True Then
            startGame()
        End If
        'If e.KeyCode = Keys.P Then addToPattern()
        'If e.KeyCode = Keys.S Then showPattern()
    End Sub
    Public Sub showPattern()
        stepNum = 0
        currentRound = pattern.Count
        patternTimer.Start()
    End Sub
    Public Sub addToPattern()
        Randomize()
        r = Int(Rnd() * 4) + 1
        If r = 1 Then pattern.Add("blue")
        If r = 2 Then pattern.Add("green")
        If r = 3 Then pattern.Add("red")
        If r = 4 Then pattern.Add("yellow")
    End Sub
    Public Sub startGame()
        Randomize()
        gameOver = False
        pattern.Clear()
        stepNum = 0
        currentRound = 0
        lblScore.Text = "0"
        addToPattern()
        patternTimer.Start()
    End Sub
    Private Sub patternTimer_Tick(sender As Object, e As EventArgs) Handles patternTimer.Tick
        If stepNum = pattern.Count Then
            patternTimer.Stop()
            resetColors()
            stepNum = 0
        Else
            If delay = False Then
                If pattern.Item(stepNum) = "blue" Then blueL.BackColor = Color.Cyan
                If pattern.Item(stepNum) = "green" Then greenL.BackColor = Color.LightGreen
                If pattern.Item(stepNum) = "red" Then redL.BackColor = Color.Pink
                If pattern.Item(stepNum) = "yellow" Then yellowL.BackColor = Color.White
                stepNum += 1
                delay = True
            Else
                resetColors()
                delay = False
            End If
        End If
    End Sub
    Public Sub resetColors()
        blueL.BackColor = Color.Blue
        greenL.BackColor = Color.Green
        redL.BackColor = Color.Red
        yellowL.BackColor = Color.Yellow
    End Sub
End Class
