Public Class Form1
    Private Sub btnJan_Click(sender As Object, e As EventArgs) Handles btnJan.Click
        PictureBox1.Image = Image.FromFile("ali.png")
        lblPpl.Text = "Muhammad Ali"
        lblDOB.Text = "January 17th, 1942"
    End Sub
End Class
