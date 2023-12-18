Public Class Form1
    Dim x, num, sum As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num = TextBox1.Text
        sum = 0
        For x = 1 To num
            sum = sum + x
        Next
        Label1.Text = sum
    End Sub
End Class
