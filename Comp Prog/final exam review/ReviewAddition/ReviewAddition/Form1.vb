Public Class Form1
    Dim num1, num2, answer, guess As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        guess = TextBox1.Text
        If guess = answer Then
            MsgBox("Correct!")
        Else
            MsgBox("wrong. the answer is " & answer)
        End If
        makeProblem()
        TextBox1.Text = ""
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeProblem()
    End Sub
    Public Sub makeProblem()
        Randomize()
        num1 = Int(Rnd() * 10) + 1
        num2 = Int(Rnd() * 10) + 1
        answer = num1 + num2
        Label1.Text = num1 & " + " & num2 & " = ?"
    End Sub
End Class
