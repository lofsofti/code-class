Public Class Form1
    Dim Box As Label
    Dim T1, T2 As Label
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Box = New Label
        'Box.AutoSize = False
        'Box.Size = New Size(75, 100)
        'Box.Location = New Point(100, 50)
        'Box.BackColor = Color.Orange
        'Box.Text = "Box"
        'Box.ForeColor = Color.Purple
        'Box.TextAlign = ContentAlignment.MiddleCenter
        'Box.BorderStyle = BorderStyle.FixedSingle
        'Controls.Add(Box)

        T1 = New Label
        T1.AutoSize = False
        T1.BackColor = Color.Black
        T1.Location = New Point(30, 20)
        T1.Size = New Size(70, 10)
        Controls.Add(T1)

        T2 = New Label
        T2.AutoSize = False
        T2.BackColor = Color.Black
        T2.Location = New Point(60, 30)
        T2.Size = New Size(10, 70)
        Controls.Add(T2)

    End Sub
End Class
