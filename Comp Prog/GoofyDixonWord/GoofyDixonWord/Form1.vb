﻿Imports System.Net.Http.Headers

Public Class Form1
    Dim c1, c2, c3, c4, c5, c6, c7, c8, c9 As Label
    Dim a1, a2, a3, a4, a5, a6 As Label
    Dim b1, b2, b3, b4, b5 b6 As Label
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cable
        Me.Size = New Size(316, 239)
        LetterC()
        LetterA()
    End Sub
    Public Sub LetterC()
        c1 = New Label
        c2 = New Label
        c3 = New Label
        c4 = New Label
        c5 = New Label
        c6 = New Label
        c7 = New Label
        c8 = New Label
        c9 = New Label

        c1.BackColor = Color.DarkSlateGray
        c2.BackColor = Color.DarkSlateGray
        c3.BackColor = Color.DarkSlateGray
        c4.BackColor = Color.DarkSlateGray
        c5.BackColor = Color.DarkSlateGray
        c6.BackColor = Color.DarkSlateGray
        c7.BackColor = Color.DarkSlateGray
        c8.BackColor = Color.DarkSlateGray
        c9.BackColor = Color.DarkSlateGray

        c1.AutoSize = False
        c2.AutoSize = False
        c3.AutoSize = False
        c4.AutoSize = False
        c5.AutoSize = False
        c6.AutoSize = False
        c7.AutoSize = False
        c8.AutoSize = False
        c9.AutoSize = False

        c1.Size = New Size(10, 10)
        c1.Location = New Point(60, 60)
        c2.Size = New Size(20, 10)
        c2.Location = New Point(40, 50)
        c3.Size = New Size(20, 10)
        c3.Location = New Point(20, 60)
        c4.Size = New Size(10, 10)
        c4.Location = New Point(20, 70)
        c5.Size = New Size(10, 40)
        c5.Location = New Point(10, 80)
        c6.Size = New Size(10, 10)
        c6.Location = New Point(20, 120)
        c7.Size = New Size(20, 10)
        c7.Location = New Point(20, 130)
        c8.Size = New Size(20, 10)
        c8.Location = New Point(40, 140)
        c9.Size = New Size(10, 10)
        c9.Location = New Point(60, 130)

        Controls.Add(c1)
        Controls.Add(c2)
        Controls.Add(c3)
        Controls.Add(c4)
        Controls.Add(c5)
        Controls.Add(c6)
        Controls.Add(c7)
        Controls.Add(c8)
        Controls.Add(c9)
    End Sub
    Public Sub LetterA()
        a1 = New Label
        a2 = New Label
        a3 = New Label
        a4 = New Label
        a5 = New Label
        a6 = New Label

        a1.BackColor = Color.DarkSlateGray
        a2.BackColor = Color.DarkSlateGray
        a3.BackColor = Color.DarkSlateGray
        a4.BackColor = Color.DarkSlateGray
        a5.BackColor = Color.DarkSlateGray
        a6.BackColor = Color.DarkSlateGray

        a1.AutoSize = False
        a2.AutoSize = False
        a3.AutoSize = False
        a4.AutoSize = False
        a5.AutoSize = False
        a6.AutoSize = False

        a1.Size = New Size(10, 40)
        a1.Location = New Point(90, 110)
        a2.Size = New Size(10, 40)
        a2.Location = New Point(95, 70)
        a3.Size = New Size(40, 10)
        a3.Location = New Point(105, 60)
        a4.Size = New Size(10, 40)
        a4.Location = New Point(145, 70)
        a5.Size = New Size(10, 40)
        a5.Location = New Point(150, 110)
        a6.Size = New Size(50, 10)
        a6.Location = New Point(100, 110)

        Controls.Add(a1)
        Controls.Add(a2)
        Controls.Add(a3)
        Controls.Add(a4)
        Controls.Add(a5)
        Controls.Add(a6)
    End Sub
    Public Sub LetterB()
        b1 = New Label
        b2 = New Label
        b3 = New Label
        b4 = New Label
        b5 = New Label
        b6 = New Label

        b1.BackColor = Color.DarkSlateGray
        b2.BackColor = Color.DarkSlateGray
        b3.BackColor = Color.DarkSlateGray
        b4.BackColor = Color.DarkSlateGray
        b5.BackColor = Color.DarkSlateGray
        b6.BackColor = Color.DarkSlateGray

        b1.AutoSize = False
        b2.AutoSize = False
        b3.AutoSize = False
        b4.AutoSize = False
        b5.AutoSize = False
        b6.AutoSize = False

        b1.Size = New Size(10, 40)
        b1.Location = New Point(90, 110)
        b2.Size = New Size(10, 40)
        b2.Location = New Point(95, 70)
        b3.Size = New Size(40, 10)
        b3.Location = New Point(105, 60)
        b4.Size = New Size(10, 40)
        b4.Location = New Point(145, 70)
        b5.Size = New Size(10, 40)
        b5.Location = New Point(150, 110)
        b6.Size = New Size(50, 10)
        b6.Location = New Point(100, 110)

        Controls.Add(a1)
        Controls.Add(a2)
        Controls.Add(a3)
        Controls.Add(a4)
        Controls.Add(a5)
        Controls.Add(a6)
    End Sub
End Class
