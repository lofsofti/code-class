Public Class Form1
    Dim age As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        age = TextBox2.Text
        If age < 18 Then
            Label2.Text = "He/She is a minor"
        ElseIf age >= 18 Then
            Label2.Text = "He/she is an adult"
        ElseIf age >= 65 Then
            Label2.Text = "He/she is a senior citizen"
        End If
        Label1.Text = TextBox1.Text & " is " & age & " years old"
    End Sub
End Class
