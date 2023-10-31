Public Class Form1
    Dim board(7, 6) As PictureBox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buildBoard()
    End Sub
    Public Sub buildBoard()
        For c = 1 To 7
            For r = 1 To 6
                board(c, r) = New PictureBox
                board(c, r).Size = New Size(50, 50)
                board(c, r).Image = Image.FromFile("Empty.png")
                board(c, r).Location = New Point(c * 50, r * 50)
                board(c, r).Tag = "empty"
                Controls.Add(board(c, r))
            Next
        Next
    End Sub
End Class
