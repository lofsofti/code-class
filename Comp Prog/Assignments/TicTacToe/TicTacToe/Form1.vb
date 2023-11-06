Public Class Form1
    Dim xWins, oWins, ties As Integer
    Dim playerSymbol As String = "x"
    Dim gameOver As Boolean = False

    Private Sub Spot1_Click(sender As Object, e As EventArgs) Handles Spot1.Click
        If Spot1.Text = "" Then
            Spot1.Text = playerSymbol
            checkWin()
            checkTie()
            switchPlayer()
        Else
            MsgBox("This spot is filled")
        End If
    End Sub
    Private Sub Spot2_Click(sender As Object, e As EventArgs) Handles Spot2.Click
        If Spot2.Text = "" And gameOver = False Then
            Spot2.Text = playerSymbol
            checkWin()
            switchPlayer()
        End If
    End Sub
    Private Sub Spot3_Click(sender As Object, e As EventArgs) Handles Spot3.Click
        If Spot3.Text = "" And gameOver = False Then
            Spot3.Text = playerSymbol
            checkWin()
            checkTie()
            switchPlayer()
        Else
            MsgBox("This spot is filled")
        End If
    End Sub
    Private Sub Spot4_Click(sender As Object, e As EventArgs) Handles Spot4.Click
        If Spot4.Text = "" And gameOver = False Then
            Spot4.Text = playerSymbol
            checkWin()
            checkTie()
            switchPlayer()
        Else
            MsgBox("This spot is filled")
        End If
    End Sub
    Private Sub Spot5_Click(sender As Object, e As EventArgs) Handles Spot5.Click
        If Spot5.Text = "" And gameOver = False Then
            Spot5.Text = playerSymbol
            checkWin()
            checkTie()
            switchPlayer()
        Else
            MsgBox("This spot is filled")
        End If
    End Sub
    Private Sub Spot6_Click(sender As Object, e As EventArgs) Handles Spot6.Click
        If Spot6.Text = "" And gameOver = False Then
            Spot6.Text = playerSymbol
            checkWin()
            checkTie()
            switchPlayer()
        Else
            MsgBox("This spot is filled")
        End If
    End Sub
    Private Sub Spot7_Click(sender As Object, e As EventArgs) Handles Spot7.Click
        If Spot7.Text = "" And gameOver = False Then
            Spot7.Text = playerSymbol
            checkWin()
            checkTie()
            switchPlayer()
        Else
            MsgBox("This spot is filled")
        End If
    End Sub
    Private Sub Spot8_Click(sender As Object, e As EventArgs) Handles Spot8.Click
        If Spot8.Text = "" And gameOver = False Then
            Spot8.Text = playerSymbol
            checkWin()
            checkTie()
            switchPlayer()
        Else
            MsgBox("This spot is filled")
        End If
    End Sub
    Private Sub Spot9_Click(sender As Object, e As EventArgs) Handles Spot9.Click
        If Spot9.Text = "" And gameOver = False Then
            Spot9.Text = playerSymbol
            checkWin()
            checkTie()
            switchPlayer()
        Else
            MsgBox("This spot is filled")
        End If
    End Sub
    Public Sub switchPlayer()
        If playerSymbol = "x" Then
            playerSymbol = "o"
        Else
            playerSymbol = "x"
        End If
    End Sub
    Public Sub checkWin()
        If Spot1.Text = playerSymbol And Spot2.Text = playerSymbol And Spot3.Text = playerSymbol Then
            Spot1.BackColor = Color.LightBlue
            Spot2.BackColor = Color.LightBlue
            Spot3.BackColor = Color.LightBlue
            gameOver = True
            MsgBox(playerSymbol & " wins!")
            updateWins()
        End If
        If Spot4.Text = playerSymbol And Spot5.Text = playerSymbol And Spot6.Text = playerSymbol Then
            Spot4.BackColor = Color.LightBlue
            Spot5.BackColor = Color.LightBlue
            Spot6.BackColor = Color.LightBlue
            gameOver = True
            MsgBox(playerSymbol & " wins!")
            updateWins()
        End If
        If Spot7.Text = playerSymbol And Spot8.Text = playerSymbol And Spot9.Text = playerSymbol Then
            Spot7.BackColor = Color.LightBlue
            Spot8.BackColor = Color.LightBlue
            Spot9.BackColor = Color.LightBlue
            gameOver = True
            MsgBox(playerSymbol & " wins!")
            updateWins()
        End If
        If Spot1.Text = playerSymbol And Spot4.Text = playerSymbol And Spot7.Text = playerSymbol Then
            Spot1.BackColor = Color.LightBlue
            Spot4.BackColor = Color.LightBlue
            Spot7.BackColor = Color.LightBlue
            gameOver = True
            MsgBox(playerSymbol & " wins!")
            updateWins()
        End If
        If Spot2.Text = playerSymbol And Spot5.Text = playerSymbol And Spot8.Text = playerSymbol Then
            Spot2.BackColor = Color.LightBlue
            Spot5.BackColor = Color.LightBlue
            Spot8.BackColor = Color.LightBlue
            gameOver = True
            MsgBox(playerSymbol & " wins!")
            updateWins()
        End If
        If Spot3.Text = playerSymbol And Spot6.Text = playerSymbol And Spot9.Text = playerSymbol Then
            Spot3.BackColor = Color.LightBlue
            Spot6.BackColor = Color.LightBlue
            Spot9.BackColor = Color.LightBlue
            gameOver = True
            MsgBox(playerSymbol & " wins!")
            updateWins()
        End If
        If Spot1.Text = playerSymbol And Spot5.Text = playerSymbol And Spot9.Text = playerSymbol Then
            Spot1.BackColor = Color.LightBlue
            Spot5.BackColor = Color.LightBlue
            Spot9.BackColor = Color.LightBlue
            gameOver = True
            MsgBox(playerSymbol & " wins!")
            updateWins()
        End If
        If Spot3.Text = playerSymbol And Spot5.Text = playerSymbol And Spot7.Text = playerSymbol Then
            Spot3.BackColor = Color.LightBlue
            Spot5.BackColor = Color.LightBlue
            Spot7.BackColor = Color.LightBlue
            gameOver = True
            MsgBox(playerSymbol & " wins!")
            updateWins()
        End If
    End Sub
    Public Sub checkTie()
        If gameOver = False And Spot1.Text <> "" And Spot2.Text <> "" And Spot3.Text <> "" And Spot4.Text <> "" And Spot5.Text <> "" And Spot6.Text <> "" And Spot7.Text <> "" And Spot8.Text <> "" And Spot9.Text <> "" Then
            MsgBox("Cat's game")
            ties += 1
            lblTies.Text = "Ties: " & ties
            gameOver = True
        End If
    End Sub
    Public Sub updateWins()
        If playerSymbol = "x" Then
            xWins += 1
            lblXwins.Text = "X Wins: " & xWins
        End If
        If playerSymbol = "o" Then
            oWins += 1
            lblOwins.Text = "O Wins: " & oWins
        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.R And gameOver = True Then
            Spot1.Text = ""
            Spot2.Text = ""
            Spot3.Text = ""
            Spot4.Text = ""
            Spot5.Text = ""
            Spot6.Text = ""
            Spot7.Text = ""
            Spot8.Text = ""
            Spot9.Text = ""
            Spot1.BackColor = Color.White
            Spot2.BackColor = Color.White
            Spot3.BackColor = Color.White
            Spot4.BackColor = Color.White
            Spot5.BackColor = Color.White
            Spot6.BackColor = Color.White
            Spot7.BackColor = Color.White
            Spot8.BackColor = Color.White
            Spot9.BackColor = Color.White
            gameOver = False
        End If
    End Sub
End Class
