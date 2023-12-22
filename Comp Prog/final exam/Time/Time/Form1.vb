Public Class Form1
    Dim days As Integer
    Dim hours As Integer = 24
    Dim minutes As Integer = 1440
    Dim seconds As Integer = 86400
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        calculate()
        Label1.Text = "Hours: " & hours
        Label2.Text = "Minutes: " & minutes
        Label3.Text = "Seconds: " & seconds
    End Sub
    Public Sub calculate()
        days = TextBox1.Text
        hours *= days
        minutes *= days
        seconds *= days
    End Sub
End Class
