Imports System.Net.Security

Public Class Form1
    Dim pRoll, cRoll, pWins, cWins As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pWins = 0
        cWins = 0
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        pRoll = Int(Rnd() * 6) + 1
        cRoll = Int(Rnd() * 6) + 1

        ShowDice()
        ShowResults()
        CheckWinner()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pArrow.Visible = True Then pArrow.Visible = False
        If cArrow.Visible = True Then cArrow.Visible = False
        lblwin.Text = " "
    End Sub

    Public Sub ShowDice()
        If pRoll = 1 Then die1.Image = Image.FromFile("1.png")
        If pRoll = 2 Then die1.Image = Image.FromFile("2.png")
        If pRoll = 3 Then die1.Image = Image.FromFile("3.png")
        If pRoll = 4 Then die1.Image = Image.FromFile("4.png")
        If pRoll = 5 Then die1.Image = Image.FromFile("5.png")
        If pRoll = 6 Then die1.Image = Image.FromFile("6.png")

        If cRoll = 1 Then die2.Image = Image.FromFile("one.jpg")
        If cRoll = 2 Then die2.Image = Image.FromFile("two.jpg")
        If cRoll = 3 Then die2.Image = Image.FromFile("three.jpg")
        If cRoll = 4 Then die2.Image = Image.FromFile("four.jpg")
        If cRoll = 5 Then die2.Image = Image.FromFile("five.jpg")
        If cRoll = 6 Then die2.Image = Image.FromFile("six.jpg")
    End Sub
    Public Sub ShowResults()
        If pRoll = cRoll Then lblwin.Text = "It's a tie"
        If pRoll > cRoll Then
            pArrow.Visible = True
            Timer1.Start()
            lblwin.Text = "Player Wins!"
            pWins = pWins + 1
        End If
        If pRoll < cRoll Then
            cArrow.Visible = True
            Timer1.Start()
            lblwin.Text = "Computer Wins!"
            cWins = cWins + 1
        End If
        lblplaywin.Text = pWins
        lblcompwin.Text = cWins
    End Sub
    Public Sub CheckWinner()
        If pWins = 10 Then
            MsgBox("Player Wins the Dice War!")
            pWins = 0
            cWins = 0
            lblplaywin.Text = "0"
            lblcompwin.Text = "0"
        End If
        If cWins = 10 Then
            MsgBox("Computer Wins the Dice War!")
            pWins = 0
            cWins = 0
            lblplaywin.Text = "0"
            lblcompwin.Text = "0"
        End If
    End Sub
End Class
