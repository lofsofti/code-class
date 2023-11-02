Public Class Form1
    Dim board(7, 6) As PictureBox
    Dim r, c As Integer
    Dim player As String = "red"
    Dim gameOver As Boolean = False
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
                AddHandler board(c, r).Click, AddressOf DropToken
            Next
        Next
    End Sub
    Public Sub switchPlayer()
        If player = "red" Then
            player = "yellow"
        Else
            player = "red"
        End If
    End Sub
    Public Sub DropToken(sender As Object, e As EventArgs)
        If gameOver = False Then
            c = sender.location.x / 50
            r = findRow(c)
            If r = 0 Then
                MsgBox("that column is full, go to another")
            Else
                If player = "red" Then
                    board(c, r).Tag = "red"
                    board(c, r).Image = Image.FromFile("red.png")
                Else
                    board(c, r).Tag = "yellow"
                    board(c, r).Image = Image.FromFile("yellow.png")
                End If
                checkWin()
                switchPlayer()
            End If
        End If
    End Sub
    Public Sub checkWin()
        For r = 1 To 6
            For c = 1 To 4
                If board(c, r).Tag = player And board(c + 1, r).Tag = player And board(c + 2, r).Tag = player And board(c + 3, r).Tag = player Then MsgBox(player & " wins!!")
            Next
        Next
        For r = 1 To 3
            For c = 1 To 4
                If board(c, r).Tag = player And board(c, r + 1).Tag = player And board(c, r + 2).Tag = player And board(c, r + 3).Tag = player Then MsgBox(player & " wins!!")
            Next
        Next
        For r = 1 To 3
            For c = 1 To 4
                If board(c, r).Tag = player And board(c + 1, r + 1).Tag = player And board(c + 2, r + 2).Tag = player And board(c + 3, r + 3).Tag = player Then MsgBox(player & " wins!!")
            Next
        Next
        For r = 4 To 6
            For c = 1 To 4
                If board(c, r).Tag = player And board(c + 1, r - 1).Tag = player And board(c + 2, r - 2).Tag = player And board(c + 3, r - 3).Tag = player Then MsgBox(player & " wins!!")
            Next
        Next
    End Sub
    Public Function findRow(ByVal colummn As Integer) As Integer
        For r = 6 To 1 Step -1
            If board(colummn, r).Tag = "empty" Then Return r
        Next
        Return 0
    End Function
End Class
