Public Class Form1
    Dim num As Integer
    Dim num2 As Integer
    Dim player As Integer
    Dim computer As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        player = 0
        computer = 0
        Randomize()
        num = Int(Rnd() * 6) + 1
        If num = 1 Then die1.Image = Image.FromFile("1.png")
        If num = 2 Then die1.Image = Image.FromFile("2.png")
        If num = 3 Then die1.Image = Image.FromFile("3.png")
        If num = 4 Then die1.Image = Image.FromFile("4.png")
        If num = 5 Then die1.Image = Image.FromFile("5.png")
        If num = 6 Then die1.Image = Image.FromFile("6.png")
        Randomize()
        num2 = Int(Rnd() * 6) + 1
        If num2 = 1 Then die2.Image = Image.FromFile("one.jpg")
        If num2 = 2 Then die2.Image = Image.FromFile("two.jpg")
        If num2 = 3 Then die2.Image = Image.FromFile("three.jpg")
        If num2 = 4 Then die2.Image = Image.FromFile("four.jpg")
        If num2 = 5 Then die2.Image = Image.FromFile("five.jpg")
        If num2 = 6 Then die2.Image = Image.FromFile("six.jpg")

        If num > num2 Then lblplaywin.Text = player + 1
        If num < num2 Then lblcompwin.Text = computer + 1
        If num > num2 Then lblwin.Text = "Player Wins!"
        If num < num2 Then lblwin.Text = "Computer Wins!"
        If num = num2 Then lblwin.Text = "It's a Tie!"
    End Sub
End Class
