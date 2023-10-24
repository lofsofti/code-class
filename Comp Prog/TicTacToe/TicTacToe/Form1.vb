Public Class Form1
    Dim xWins, oWins, ties As Integer
    Dim playerSymbol As String = "x"
    Dim gameOver As Boolean = False

    Private Sub Spot1_Click(sender As Object, e As EventArgs) Handles Spot1.Click
        If Spot1.Text = "" Then
            Spot1.Text = playerSymbol
            checkWin()
            switchPlayer()
        End If
    End Sub
    Private Sub Spot2_Click(sender As Object, e As EventArgs) Handles Spot2.Click
        If Spot2.Text = "" Then
            Spot2.Text = playerSymbol
            checkWin()
            switchPlayer()
        End If
    End Sub
    Private Sub Spot3_Click(sender As Object, e As EventArgs) Handles Spot3.Click
        If Spot3.Text = "" Then
            Spot3.Text = playerSymbol
            checkWin()
            switchPlayer()
        End If
    End Sub
    Private Sub Spot4_Click(sender As Object, e As EventArgs) Handles Spot4.Click
        If Spot4.Text = "" Then
            Spot4.Text = playerSymbol
            checkWin()
            switchPlayer()
        End If
    End Sub
    Private Sub Spot5_Click(sender As Object, e As EventArgs) Handles Spot5.Click
        If Spot5.Text = "" Then
            Spot5.Text = playerSymbol
            checkWin()
            switchPlayer()
        End If
    End Sub
    Private Sub Spot6_Click(sender As Object, e As EventArgs) Handles Spot6.Click
        If Spot6.Text = "" Then
            Spot6.Text = playerSymbol
            checkWin()
            switchPlayer()
        End If
    End Sub
    Private Sub Spot7_Click(sender As Object, e As EventArgs) Handles Spot7.Click
        If Spot7.Text = "" Then
            Spot7.Text = playerSymbol
            checkWin()
            switchPlayer()
        End If
    End Sub
    Private Sub Spot8_Click(sender As Object, e As EventArgs) Handles Spot8.Click
        If Spot8.Text = "" Then
            Spot8.Text = playerSymbol
            checkWin()
            switchPlayer()
        End If
    End Sub
    Private Sub Spot9_Click(sender As Object, e As EventArgs) Handles Spot9.Click
        If Spot9.Text = "" Then
            Spot9.Text = playerSymbol
            checkWin()
            switchPlayer()
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
            MsgBox(playerSymbol & " wins!")
        End If
        If Spot4.Text = playerSymbol And Spot5.Text = playerSymbol And Spot6.Text = playerSymbol Then
            Spot4.BackColor = Color.LightBlue
            Spot5.BackColor = Color.LightBlue
            Spot6.BackColor = Color.LightBlue
            MsgBox(playerSymbol & " wins!")
        End If
        If Spot7.Text = playerSymbol And Spot8.Text = playerSymbol And Spot9.Text = playerSymbol Then
            Spot7.BackColor = Color.LightBlue
            Spot8.BackColor = Color.LightBlue
            Spot9.BackColor = Color.LightBlue
            MsgBox(playerSymbol & " wins!")
        End If
        If Spot1.Text = playerSymbol And Spot4.Text = playerSymbol And Spot7.Text = playerSymbol Then
            Spot1.BackColor = Color.LightBlue
            Spot4.BackColor = Color.LightBlue
            Spot7.BackColor = Color.LightBlue
            MsgBox(playerSymbol & " wins!")
        End If
        If Spot2.Text = playerSymbol And Spot5.Text = playerSymbol And Spot8.Text = playerSymbol Then
            Spot2.BackColor = Color.LightBlue
            Spot5.BackColor = Color.LightBlue
            Spot8.BackColor = Color.LightBlue
            MsgBox(playerSymbol & " wins!")
        End If
        If Spot3.Text = playerSymbol And Spot6.Text = playerSymbol And Spot9.Text = playerSymbol Then
            Spot3.BackColor = Color.LightBlue
            Spot6.BackColor = Color.LightBlue
            Spot9.BackColor = Color.LightBlue
            MsgBox(playerSymbol & " wins!")
        End If
        If Spot1.Text = playerSymbol And Spot5.Text = playerSymbol And Spot9.Text = playerSymbol Then
            Spot1.BackColor = Color.LightBlue
            Spot5.BackColor = Color.LightBlue
            Spot9.BackColor = Color.LightBlue
            MsgBox(playerSymbol & " wins!")
        End If
        If Spot3.Text = playerSymbol And Spot5.Text = playerSymbol And Spot7.Text = playerSymbol Then
            Spot3.BackColor = Color.LightBlue
            Spot5.BackColor = Color.LightBlue
            Spot7.BackColor = Color.LightBlue
            MsgBox(playerSymbol & " wins!")
        End If
    End Sub
    Public Sub checkTie()

    End Sub
    Public Sub restartGame()

    End Sub
End Class
