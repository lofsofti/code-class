Public Class Form1
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = 1 Then Label1.Text = "Easy"
        If TrackBar1.Value = 2 Then Label1.Text = "Normal"
        If TrackBar1.Value = 3 Then Label1.Text = "Hard"
        If TrackBar1.Value = 4 Then Label1.Text = "Nightmare"
    End Sub
End Class
