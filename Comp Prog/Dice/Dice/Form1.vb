Public Class Form1
    Dim num As Integer
    Dim num2 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        num = Int(Rnd() * 6) + 1
        If num = 1 Then die1.Image = Image.FromFile("one.jpg")
        If num = 2 Then die1.Image = Image.FromFile("two.jpg")
        If num = 3 Then die1.Image = Image.FromFile("three.jpg")
        If num = 4 Then die1.Image = Image.FromFile("four.jpg")
        If num = 5 Then die1.Image = Image.FromFile("five.jpg")
        If num = 6 Then die1.Image = Image.FromFile("six.jpg")
        Randomize()
        num2 = Int(Rnd() * 6) + 1
        If num2 = 1 Then die2.Image = Image.FromFile("one.jpg")
        If num2 = 2 Then die2.Image = Image.FromFile("two.jpg")
        If num2 = 3 Then die2.Image = Image.FromFile("three.jpg")
        If num2 = 4 Then die2.Image = Image.FromFile("four.jpg")
        If num2 = 5 Then die2.Image = Image.FromFile("five.jpg")
        If num2 = 6 Then die2.Image = Image.FromFile("six.jpg")
        Label1.Text = num + num2
        If num + num2 = 2 Then Label1.Text = "snake eyes"
        If num + num2 = 12 Then Label1.Text = "box cars"
    End Sub
End Class
