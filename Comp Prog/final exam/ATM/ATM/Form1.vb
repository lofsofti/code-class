Public Class Form1
    Dim balance As Integer = 95
    Dim amount As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If balance > 0 < 95 Then
            amount = TextBox1.Text
            balance -= amount
        Else
            MsgBox("1")
        End If
        Label2.Text = "$" & balance
    End Sub
End Class
