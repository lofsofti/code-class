Public Class Form1
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = 1 Then
            lblHour.Text = "1st Hour"
            lblClass.Text = "French 2"
            lblTeach.Text = "Mr. LaBelle"
        End If
        If TrackBar1.Value = 2 Then
            lblHour.Text = "2nd Hour"
            lblClass.Text = "Ap Gov"
            lblTeach.Text = "Mr.Robbins"
        End If
        If TrackBar1.Value = 3 Then
            lblHour.Text = "3rd Hour"
            lblClass.Text = "Ap Chem"
            lblTeach.Text = "Mr.Koenig"
        End If
        If TrackBar1.Value = 4 Then
            lblHour.Text = "4th Hour"
            lblClass.Text = "Comp Prog"
            lblTeach.Text = "Mr.Dixon"
        End If
        If TrackBar1.Value = 5 Then
            lblHour.Text = "5th Hour"
            lblClass.Text = "Algebra 2"
            lblTeach.Text = "Mrs.Beemer"
        End If
        If TrackBar1.Value = 6 Then
            lblHour.Text = "6th Hour"
            lblClass.Text = "Ap Lang"
            lblTeach.Text = "Mrs.Endres"
        End If
    End Sub
End Class
