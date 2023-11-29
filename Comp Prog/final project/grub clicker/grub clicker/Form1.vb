Public Class Form1
    Private Sub lblStartbtn_Click(sender As Object, e As EventArgs) Handles lblStartbtn.Click
        Me.Hide()
        Form2.ShowDialog()
    End Sub
End Class
