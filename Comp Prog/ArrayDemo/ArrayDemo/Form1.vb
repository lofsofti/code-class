Public Class Form1
    Dim x As Integer
    Dim names(6) As String
    Dim boxes(15) As Label
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x = 1 To 15
            boxes(x) = New Label
            boxes(x).Size = New Size(30, 30)
            boxes(x).Location = New Point(40 * x, 100)
            boxes(x).BackColor = Color.Orange
            Controls.Add(boxes(x))
        Next

        'names(1) = "Dixon"
        'names(2) = "Dom"
        'names(3) = "Van"
        'names(4) = "Lucy"
        'names(5) = "Annie"
        'names(6) = "Ayuel"

        'For x = 1 To 6
        '    ListBox1.Items.Add(names(x))
        'Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
