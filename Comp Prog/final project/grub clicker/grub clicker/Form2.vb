Public Class Form2
    Dim clicks, AC, KS, HH, AZ, SoB, R As Integer
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Form1.Close()
    End Sub
    Private Sub GRUBBBB_Click(sender As Object, e As EventArgs) Handles GRUBBBB.Click
        clicks += 1
        lblClicks.Text = "Clicks: " & clicks
    End Sub
End Class