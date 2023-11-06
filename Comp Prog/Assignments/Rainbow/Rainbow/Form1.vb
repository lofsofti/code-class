Public Class Form1
    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        '  Object.Property = Value
        lblColor.BackColor = Color.Red
        lblColor.ForeColor = Color.Black
        lblColor.Text = "Red"
    End Sub

    Private Sub btnOrange_Click(sender As Object, e As EventArgs) Handles btnOrange.Click
        lblColor.BackColor = Color.Orange
        lblColor.ForeColor = Color.DimGray
        lblColor.Text = "Orange"
    End Sub

    Private Sub btnYellow_Click(sender As Object, e As EventArgs) Handles btnYellow.Click
        lblColor.BackColor = Color.Yellow
        lblColor.ForeColor = Color.Gray
        lblColor.Text = "Yellow"
    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        lblColor.BackColor = Color.Green
        lblColor.ForeColor = Color.DarkGray
        lblColor.Text = "Green"
    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        lblColor.BackColor = Color.Blue
        lblColor.ForeColor = Color.Silver
        lblColor.Text = "Blue"
    End Sub

    Private Sub btnIndigo_Click(sender As Object, e As EventArgs) Handles btnIndigo.Click
        lblColor.BackColor = Color.Indigo
        lblColor.ForeColor = Color.LightGray
        lblColor.Text = "Indigo"
    End Sub

    Private Sub btnViolet_Click(sender As Object, e As EventArgs) Handles btnViolet.Click
        lblColor.BackColor = Color.Violet
        lblColor.ForeColor = Color.Gainsboro
        lblColor.Text = "Violet"
    End Sub
End Class
