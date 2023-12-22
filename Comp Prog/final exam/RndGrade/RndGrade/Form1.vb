Public Class Form1
    Dim num1 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        num1 = Int(Rnd() * 50) + 50
        Label1.Text = num1
        If num1 > 49 Then Label2.Text = "F"
        If num1 > 59 Then Label2.Text = "D"
        If num1 > 69 Then Label2.Text = "C"
        If num1 > 79 Then Label2.Text = "B"
        If num1 > 89 Then Label2.Text = "A"
    End Sub
End Class
