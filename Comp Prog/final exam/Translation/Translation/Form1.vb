Public Class Form1
    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        PictureBox1.Image = Image.FromFile("usflag.jpg")
        Label1.Text = "Hello"
    End Sub
    Private Sub FrenchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrenchToolStripMenuItem.Click
        PictureBox1.Image = Image.FromFile("frenchflag.jpg")
        Label1.Text = "Bonjour"
    End Sub
    Private Sub SpanishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpanishToolStripMenuItem.Click
        PictureBox1.Image = Image.FromFile("spanishflag.jpg")
        Label1.Text = "Hola"
    End Sub
End Class
