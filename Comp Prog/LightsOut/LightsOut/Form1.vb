Public Class Form1
    Dim board(5, 5) As Light
    Dim r, c, z As Integer
    Dim lightsOn As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        buildForm()
    End Sub
    Public Sub buildForm()
        Me.Size = New Size(589, 639)
        buildBoard()
    End Sub
    Public Sub buildBoard()
        For Me.r = 0 To 4
            For Me.c = 0 To 4
                board(c, r) = New Light
                board(c, r).row = r
                board(c, r).column = c
                board(c, r).Location = New Point(c * 75 + 100, r * 75 + 100)
                Controls.Add(board(c, r))
                AddHandler board(c, r).Click, AddressOf FlipLights
            Next
        Next
    End Sub
    Public Sub FlipLights(ByVal sender As Object, ByVal e As EventArgs)
        sender.flip()
        If sender.column > 0 Then board(sender.column - 1, sender.row).flip()
        If sender.column < 4 Then board(sender.column + 1, sender.row).flip()
        If sender.row > 0 Then board(sender.column, sender.row - 1).flip()
        If sender.row < 4 Then board(sender.column, sender.row + 1).flip()
        checkWin()
    End Sub
    Public Sub checkWin()
        lightsOn = 0
        countLights()
        If lightsOn = 0 Then MsgBox("winnnnn")
    End Sub
    Public Sub countLights()
        For Me.r = 0 To 4
            For Me.c = 0 To 4
                If board(c, r).lit = True Then lightsOn += 1
            Next
        Next
    End Sub
End Class
