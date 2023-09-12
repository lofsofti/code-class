Imports Microsoft.VisualBasic.Devices

Public Class Form1
    Private Sub btnUmich_Click(sender As Object, e As EventArgs) Handles btnUmich.Click
        lblMascot.Text = "Biff the Wolverine"
        lblMascot.ForeColor = Color.Blue
        lblMascot.BackColor = Color.Yellow
        lblAlum.Text = "Jim Buckmaster"
        lblAlum.ForeColor = Color.Yellow
        lblAlum.BackColor = Color.Blue
    End Sub
    Private Sub btnMsu_Click(sender As Object, e As EventArgs) Handles btnMsu.Click
        lblMascot.Text = "Spartans"
        lblMascot.ForeColor = Color.DarkGreen
        lblMascot.BackColor = Color.White
        lblAlum.Text = "Magic Johnson"
        lblAlum.ForeColor = Color.White
        lblAlum.BackColor = Color.DarkGreen
    End Sub
    Private Sub btnKettering_Click(sender As Object, e As EventArgs) Handles btnKettering.Click
        lblMascot.Text = "Bulldog"
        lblMascot.ForeColor = Color.DarkBlue
        lblMascot.BackColor = Color.Gold
        lblAlum.Text = "Mary Barra"
        lblAlum.ForeColor = Color.Gold
        lblAlum.BackColor = Color.DarkBlue
    End Sub
    Private Sub btnMtec_Click(sender As Object, e As EventArgs) Handles btnMtec.Click
        lblMascot.Text = "Blizzard T. Husky"
        lblMascot.ForeColor = Color.Gold
        lblMascot.BackColor = Color.Black
        lblAlum.Text = "Joe Berger"
        lblAlum.ForeColor = Color.Black
        lblAlum.BackColor = Color.Gold
    End Sub

    Private Sub btnGvsu_Click(sender As Object, e As EventArgs) Handles btnGvsu.Click
        lblMascot.Text = "Louie the Laker"
        lblMascot.ForeColor = Color.MediumBlue
        lblMascot.BackColor = Color.White
        lblAlum.Text = "Matthew Judon"
        lblAlum.ForeColor = Color.White
        lblAlum.BackColor = Color.MediumBlue
    End Sub
End Class
