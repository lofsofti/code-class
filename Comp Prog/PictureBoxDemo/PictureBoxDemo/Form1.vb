Public Class Form1
    Private Sub btnSponge_Click(sender As Object, e As EventArgs) Handles btnSponge.Click
        PictureBox1.Image = Image.FromFile("spongebob.png")
    End Sub
    Private Sub btnPat_Click(sender As Object, e As EventArgs) Handles btnPat.Click
        PictureBox1.Image = Image.FromFile("patrick.png")
    End Sub
End Class
