Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Dim board(8, 8) As Label
    Dim r, c As Integer
    Dim spacesLeft As Integer = 64
    Dim temp As Color

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(516, 539)
        Me.StartPosition = FormStartPosition.CenterScreen
        buildBoard()
    End Sub
    Public Sub buildBoard()
        For r = 1 To 8
            For c = 1 To 8
                board(c, r) = New Label
                board(c, r).Size = New Size(50, 50)
                board(c, r).BorderStyle = BorderStyle.FixedSingle
                board(c, r).Location = New Point(c * 50, r * 50)
                If (c + r) Mod 2 = 0 Then
                    board(c, r).BackColor = Color.Black
                Else
                    board(c, r).BackColor = Color.Red
                End If
                Controls.Add(board(c, r))
                AddHandler board(c, r).Click, AddressOf destroy
                AddHandler board(c, r).MouseEnter, AddressOf highlight
                AddHandler board(c, r).MouseLeave, AddressOf backToNormal
            Next
        Next
    End Sub
    Public Sub destroy(sender As Object, e As EventArgs)
        Controls.Remove(sender)
        sender = Nothing
        spacesLeft -= 1
        If spacesLeft = 0 Then MsgBox("board is empty")
    End Sub
    Public Sub highlight(sender As Object, e As EventArgs)
        temp = sender.backcolor
        sender.backcolor = Color.White
    End Sub
    Public Sub backToNormal(sender As Object, e As EventArgs)
        sender.backcolor = temp
    End Sub
End Class
