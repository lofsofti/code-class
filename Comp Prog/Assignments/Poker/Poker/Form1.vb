﻿Public Class Form1
    Dim c1, c2, c3, c4, c5 As Integer
    Dim pairs As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
redeal:
        Randomize()
        c1 = Int(Rnd() * 52) + 1
        c2 = Int(Rnd() * 52) + 1
        c3 = Int(Rnd() * 52) + 1
        c4 = Int(Rnd() * 52) + 1
        c5 = Int(Rnd() * 52) + 1

        If c1 = c2 Then GoTo redeal
        If c1 = c3 Then GoTo redeal
        If c1 = c4 Then GoTo redeal
        If c1 = c5 Then GoTo redeal
        If c2 = c3 Then GoTo redeal
        If c2 = c4 Then GoTo redeal
        If c2 = c5 Then GoTo redeal
        If c3 = c4 Then GoTo redeal
        If c3 = c5 Then GoTo redeal
        If c4 = c5 Then GoTo redeal

        showCard1()
        showCard2()
        showCard3()
        showCard4()
        showCard5()

        calculateHand()
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        card1.Image = Image.FromFile("redback.png")
        card2.Image = Image.FromFile("redback.png")
        card3.Image = Image.FromFile("redback.png")
        card4.Image = Image.FromFile("redback.png")
        card5.Image = Image.FromFile("redback.png")
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        card1.Image = Image.FromFile("blueback.png")
        card2.Image = Image.FromFile("blueback.png")
        card3.Image = Image.FromFile("blueback.png")
        card4.Image = Image.FromFile("blueback.png")
        card5.Image = Image.FromFile("blueback.png")
    End Sub

    Private Sub FancyRedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FancyRedToolStripMenuItem.Click
        card1.Image = Image.FromFile("fancyredback.png")
        card2.Image = Image.FromFile("fancyredback.png")
        card3.Image = Image.FromFile("fancyredback.png")
        card4.Image = Image.FromFile("fancyredback.png")
        card5.Image = Image.FromFile("fancyredback.png")
    End Sub

    Private Sub FancyBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FancyBlueToolStripMenuItem.Click
        card1.Image = Image.FromFile("fancyblueback.png")
        card2.Image = Image.FromFile("fancyblueback.png")
        card3.Image = Image.FromFile("fancyblueback.png")
        card4.Image = Image.FromFile("fancyblueback.png")
        card5.Image = Image.FromFile("fancyblueback.png")
    End Sub

    Public Sub showCard1()
        'Clubs 1 to 13
        If c1 = 1 Then card1.Image = Image.FromFile("ac.png")
        If c1 = 2 Then card1.Image = Image.FromFile("2c.png")
        If c1 = 3 Then card1.Image = Image.FromFile("3c.png")
        If c1 = 4 Then card1.Image = Image.FromFile("4c.png")
        If c1 = 5 Then card1.Image = Image.FromFile("5c.png")
        If c1 = 6 Then card1.Image = Image.FromFile("6c.png")
        If c1 = 7 Then card1.Image = Image.FromFile("7c.png")
        If c1 = 8 Then card1.Image = Image.FromFile("8c.png")
        If c1 = 9 Then card1.Image = Image.FromFile("9c.png")
        If c1 = 10 Then card1.Image = Image.FromFile("10c.png")
        If c1 = 11 Then card1.Image = Image.FromFile("jc.png")
        If c1 = 12 Then card1.Image = Image.FromFile("qc.png")
        If c1 = 13 Then card1.Image = Image.FromFile("kc.png")

        'Diamonds 14 to 26
        If c1 = 14 Then card1.Image = Image.FromFile("ad.png")
        If c1 = 15 Then card1.Image = Image.FromFile("2d.png")
        If c1 = 16 Then card1.Image = Image.FromFile("3d.png")
        If c1 = 17 Then card1.Image = Image.FromFile("4d.png")
        If c1 = 18 Then card1.Image = Image.FromFile("5d.png")
        If c1 = 19 Then card1.Image = Image.FromFile("6d.png")
        If c1 = 20 Then card1.Image = Image.FromFile("7d.png")
        If c1 = 21 Then card1.Image = Image.FromFile("8d.png")
        If c1 = 22 Then card1.Image = Image.FromFile("9d.png")
        If c1 = 23 Then card1.Image = Image.FromFile("10d.png")
        If c1 = 24 Then card1.Image = Image.FromFile("jd.png")
        If c1 = 25 Then card1.Image = Image.FromFile("qd.png")
        If c1 = 26 Then card1.Image = Image.FromFile("kd.png")

        'Hearts 27 to 39
        If c1 = 27 Then card1.Image = Image.FromFile("ah.png")
        If c1 = 28 Then card1.Image = Image.FromFile("2h.png")
        If c1 = 29 Then card1.Image = Image.FromFile("3h.png")
        If c1 = 30 Then card1.Image = Image.FromFile("4h.png")
        If c1 = 31 Then card1.Image = Image.FromFile("5h.png")
        If c1 = 32 Then card1.Image = Image.FromFile("6h.png")
        If c1 = 33 Then card1.Image = Image.FromFile("7h.png")
        If c1 = 34 Then card1.Image = Image.FromFile("8h.png")
        If c1 = 35 Then card1.Image = Image.FromFile("9h.png")
        If c1 = 36 Then card1.Image = Image.FromFile("10h.png")
        If c1 = 37 Then card1.Image = Image.FromFile("jh.png")
        If c1 = 38 Then card1.Image = Image.FromFile("qh.png")
        If c1 = 39 Then card1.Image = Image.FromFile("kh.png")

        'Spades 40 to 52
        If c1 = 40 Then card1.Image = Image.FromFile("as.png")
        If c1 = 41 Then card1.Image = Image.FromFile("2s.png")
        If c1 = 42 Then card1.Image = Image.FromFile("3s.png")
        If c1 = 43 Then card1.Image = Image.FromFile("4s.png")
        If c1 = 44 Then card1.Image = Image.FromFile("5s.png")
        If c1 = 45 Then card1.Image = Image.FromFile("6s.png")
        If c1 = 46 Then card1.Image = Image.FromFile("7s.png")
        If c1 = 47 Then card1.Image = Image.FromFile("8s.png")
        If c1 = 48 Then card1.Image = Image.FromFile("9s.png")
        If c1 = 49 Then card1.Image = Image.FromFile("10s.png")
        If c1 = 50 Then card1.Image = Image.FromFile("js.png")
        If c1 = 51 Then card1.Image = Image.FromFile("qs.png")
        If c1 = 52 Then card1.Image = Image.FromFile("ks.png")
    End Sub

    Public Sub showCard2()
        'Clubs 1 to 13
        If c2 = 1 Then card2.Image = Image.FromFile("ac.png")
        If c2 = 2 Then card2.Image = Image.FromFile("2c.png")
        If c2 = 3 Then card2.Image = Image.FromFile("3c.png")
        If c2 = 4 Then card2.Image = Image.FromFile("4c.png")
        If c2 = 5 Then card2.Image = Image.FromFile("5c.png")
        If c2 = 6 Then card2.Image = Image.FromFile("6c.png")
        If c2 = 7 Then card2.Image = Image.FromFile("7c.png")
        If c2 = 8 Then card2.Image = Image.FromFile("8c.png")
        If c2 = 9 Then card2.Image = Image.FromFile("9c.png")
        If c2 = 10 Then card2.Image = Image.FromFile("10c.png")
        If c2 = 11 Then card2.Image = Image.FromFile("jc.png")
        If c2 = 12 Then card2.Image = Image.FromFile("qc.png")
        If c2 = 13 Then card2.Image = Image.FromFile("kc.png")

        'Diamonds 14 to 26
        If c2 = 14 Then card2.Image = Image.FromFile("ad.png")
        If c2 = 15 Then card2.Image = Image.FromFile("2d.png")
        If c2 = 16 Then card2.Image = Image.FromFile("3d.png")
        If c2 = 17 Then card2.Image = Image.FromFile("4d.png")
        If c2 = 18 Then card2.Image = Image.FromFile("5d.png")
        If c2 = 19 Then card2.Image = Image.FromFile("6d.png")
        If c2 = 20 Then card2.Image = Image.FromFile("7d.png")
        If c2 = 21 Then card2.Image = Image.FromFile("8d.png")
        If c2 = 22 Then card2.Image = Image.FromFile("9d.png")
        If c2 = 23 Then card2.Image = Image.FromFile("10d.png")
        If c2 = 24 Then card2.Image = Image.FromFile("jd.png")
        If c2 = 25 Then card2.Image = Image.FromFile("qd.png")
        If c2 = 26 Then card2.Image = Image.FromFile("kd.png")

        'Hearts 27 to 39
        If c2 = 27 Then card2.Image = Image.FromFile("ah.png")
        If c2 = 28 Then card2.Image = Image.FromFile("2h.png")
        If c2 = 29 Then card2.Image = Image.FromFile("3h.png")
        If c2 = 30 Then card2.Image = Image.FromFile("4h.png")
        If c2 = 31 Then card2.Image = Image.FromFile("5h.png")
        If c2 = 32 Then card2.Image = Image.FromFile("6h.png")
        If c2 = 33 Then card2.Image = Image.FromFile("7h.png")
        If c2 = 34 Then card2.Image = Image.FromFile("8h.png")
        If c2 = 35 Then card2.Image = Image.FromFile("9h.png")
        If c2 = 36 Then card2.Image = Image.FromFile("10h.png")
        If c2 = 37 Then card2.Image = Image.FromFile("jh.png")
        If c2 = 38 Then card2.Image = Image.FromFile("qh.png")
        If c2 = 39 Then card2.Image = Image.FromFile("kh.png")

        'Spades 40 to 52
        If c2 = 40 Then card2.Image = Image.FromFile("as.png")
        If c2 = 41 Then card2.Image = Image.FromFile("2s.png")
        If c2 = 42 Then card2.Image = Image.FromFile("3s.png")
        If c2 = 43 Then card2.Image = Image.FromFile("4s.png")
        If c2 = 44 Then card2.Image = Image.FromFile("5s.png")
        If c2 = 45 Then card2.Image = Image.FromFile("6s.png")
        If c2 = 46 Then card2.Image = Image.FromFile("7s.png")
        If c2 = 47 Then card2.Image = Image.FromFile("8s.png")
        If c2 = 48 Then card2.Image = Image.FromFile("9s.png")
        If c2 = 49 Then card2.Image = Image.FromFile("10s.png")
        If c2 = 50 Then card2.Image = Image.FromFile("js.png")
        If c2 = 51 Then card2.Image = Image.FromFile("qs.png")
        If c2 = 52 Then card2.Image = Image.FromFile("ks.png")
    End Sub

    Public Sub showCard3()
        'Clubs 1 to 13
        If c3 = 1 Then card3.Image = Image.FromFile("ac.png")
        If c3 = 2 Then card3.Image = Image.FromFile("2c.png")
        If c3 = 3 Then card3.Image = Image.FromFile("3c.png")
        If c3 = 4 Then card3.Image = Image.FromFile("4c.png")
        If c3 = 5 Then card3.Image = Image.FromFile("5c.png")
        If c3 = 6 Then card3.Image = Image.FromFile("6c.png")
        If c3 = 7 Then card3.Image = Image.FromFile("7c.png")
        If c3 = 8 Then card3.Image = Image.FromFile("8c.png")
        If c3 = 9 Then card3.Image = Image.FromFile("9c.png")
        If c3 = 10 Then card3.Image = Image.FromFile("10c.png")
        If c3 = 11 Then card3.Image = Image.FromFile("jc.png")
        If c3 = 12 Then card3.Image = Image.FromFile("qc.png")
        If c3 = 13 Then card3.Image = Image.FromFile("kc.png")

        'Diamonds 14 to 26
        If c3 = 14 Then card3.Image = Image.FromFile("ad.png")
        If c3 = 15 Then card3.Image = Image.FromFile("2d.png")
        If c3 = 16 Then card3.Image = Image.FromFile("3d.png")
        If c3 = 17 Then card3.Image = Image.FromFile("4d.png")
        If c3 = 18 Then card3.Image = Image.FromFile("5d.png")
        If c3 = 19 Then card3.Image = Image.FromFile("6d.png")
        If c3 = 20 Then card3.Image = Image.FromFile("7d.png")
        If c3 = 21 Then card3.Image = Image.FromFile("8d.png")
        If c3 = 22 Then card3.Image = Image.FromFile("9d.png")
        If c3 = 23 Then card3.Image = Image.FromFile("10d.png")
        If c3 = 24 Then card3.Image = Image.FromFile("jd.png")
        If c3 = 25 Then card3.Image = Image.FromFile("qd.png")
        If c3 = 26 Then card3.Image = Image.FromFile("kd.png")

        'Hearts 27 to 39
        If c3 = 27 Then card3.Image = Image.FromFile("ah.png")
        If c3 = 28 Then card3.Image = Image.FromFile("2h.png")
        If c3 = 29 Then card3.Image = Image.FromFile("3h.png")
        If c3 = 30 Then card3.Image = Image.FromFile("4h.png")
        If c3 = 31 Then card3.Image = Image.FromFile("5h.png")
        If c3 = 32 Then card3.Image = Image.FromFile("6h.png")
        If c3 = 33 Then card3.Image = Image.FromFile("7h.png")
        If c3 = 34 Then card3.Image = Image.FromFile("8h.png")
        If c3 = 35 Then card3.Image = Image.FromFile("9h.png")
        If c3 = 36 Then card3.Image = Image.FromFile("10h.png")
        If c3 = 37 Then card3.Image = Image.FromFile("jh.png")
        If c3 = 38 Then card3.Image = Image.FromFile("qh.png")
        If c3 = 39 Then card3.Image = Image.FromFile("kh.png")

        'Spades 40 to 52
        If c3 = 40 Then card3.Image = Image.FromFile("as.png")
        If c3 = 41 Then card3.Image = Image.FromFile("2s.png")
        If c3 = 42 Then card3.Image = Image.FromFile("3s.png")
        If c3 = 43 Then card3.Image = Image.FromFile("4s.png")
        If c3 = 44 Then card3.Image = Image.FromFile("5s.png")
        If c3 = 45 Then card3.Image = Image.FromFile("6s.png")
        If c3 = 46 Then card3.Image = Image.FromFile("7s.png")
        If c3 = 47 Then card3.Image = Image.FromFile("8s.png")
        If c3 = 48 Then card3.Image = Image.FromFile("9s.png")
        If c3 = 49 Then card3.Image = Image.FromFile("10s.png")
        If c3 = 50 Then card3.Image = Image.FromFile("js.png")
        If c3 = 51 Then card3.Image = Image.FromFile("qs.png")
        If c3 = 52 Then card3.Image = Image.FromFile("ks.png")
    End Sub

    Public Sub showCard4()
        'Clubs 1 to 13
        If c4 = 1 Then card4.Image = Image.FromFile("ac.png")
        If c4 = 2 Then card4.Image = Image.FromFile("2c.png")
        If c4 = 3 Then card4.Image = Image.FromFile("3c.png")
        If c4 = 4 Then card4.Image = Image.FromFile("4c.png")
        If c4 = 5 Then card4.Image = Image.FromFile("5c.png")
        If c4 = 6 Then card4.Image = Image.FromFile("6c.png")
        If c4 = 7 Then card4.Image = Image.FromFile("7c.png")
        If c4 = 8 Then card4.Image = Image.FromFile("8c.png")
        If c4 = 9 Then card4.Image = Image.FromFile("9c.png")
        If c4 = 10 Then card4.Image = Image.FromFile("10c.png")
        If c4 = 11 Then card4.Image = Image.FromFile("jc.png")
        If c4 = 12 Then card4.Image = Image.FromFile("qc.png")
        If c4 = 13 Then card4.Image = Image.FromFile("kc.png")

        'Diamonds 14 to 26
        If c4 = 14 Then card4.Image = Image.FromFile("ad.png")
        If c4 = 15 Then card4.Image = Image.FromFile("2d.png")
        If c4 = 16 Then card4.Image = Image.FromFile("3d.png")
        If c4 = 17 Then card4.Image = Image.FromFile("4d.png")
        If c4 = 18 Then card4.Image = Image.FromFile("5d.png")
        If c4 = 19 Then card4.Image = Image.FromFile("6d.png")
        If c4 = 20 Then card4.Image = Image.FromFile("7d.png")
        If c4 = 21 Then card4.Image = Image.FromFile("8d.png")
        If c4 = 22 Then card4.Image = Image.FromFile("9d.png")
        If c4 = 23 Then card4.Image = Image.FromFile("10d.png")
        If c4 = 24 Then card4.Image = Image.FromFile("jd.png")
        If c4 = 25 Then card4.Image = Image.FromFile("qd.png")
        If c4 = 26 Then card4.Image = Image.FromFile("kd.png")

        'Hearts 27 to 39
        If c4 = 27 Then card4.Image = Image.FromFile("ah.png")
        If c4 = 28 Then card4.Image = Image.FromFile("2h.png")
        If c4 = 29 Then card4.Image = Image.FromFile("3h.png")
        If c4 = 30 Then card4.Image = Image.FromFile("4h.png")
        If c4 = 31 Then card4.Image = Image.FromFile("5h.png")
        If c4 = 32 Then card4.Image = Image.FromFile("6h.png")
        If c4 = 33 Then card4.Image = Image.FromFile("7h.png")
        If c4 = 34 Then card4.Image = Image.FromFile("8h.png")
        If c4 = 35 Then card4.Image = Image.FromFile("9h.png")
        If c4 = 36 Then card4.Image = Image.FromFile("10h.png")
        If c4 = 37 Then card4.Image = Image.FromFile("jh.png")
        If c4 = 38 Then card4.Image = Image.FromFile("qh.png")
        If c4 = 39 Then card4.Image = Image.FromFile("kh.png")

        'Spades 40 to 52
        If c4 = 40 Then card4.Image = Image.FromFile("as.png")
        If c4 = 41 Then card4.Image = Image.FromFile("2s.png")
        If c4 = 42 Then card4.Image = Image.FromFile("3s.png")
        If c4 = 43 Then card4.Image = Image.FromFile("4s.png")
        If c4 = 44 Then card4.Image = Image.FromFile("5s.png")
        If c4 = 45 Then card4.Image = Image.FromFile("6s.png")
        If c4 = 46 Then card4.Image = Image.FromFile("7s.png")
        If c4 = 47 Then card4.Image = Image.FromFile("8s.png")
        If c4 = 48 Then card4.Image = Image.FromFile("9s.png")
        If c4 = 49 Then card4.Image = Image.FromFile("10s.png")
        If c4 = 50 Then card4.Image = Image.FromFile("js.png")
        If c4 = 51 Then card4.Image = Image.FromFile("qs.png")
        If c4 = 52 Then card4.Image = Image.FromFile("ks.png")
    End Sub

    Public Sub showCard5()
        'Clubs 1 to 13
        If c5 = 1 Then card5.Image = Image.FromFile("ac.png")
        If c5 = 2 Then card5.Image = Image.FromFile("2c.png")
        If c5 = 3 Then card5.Image = Image.FromFile("3c.png")
        If c5 = 4 Then card5.Image = Image.FromFile("4c.png")
        If c5 = 5 Then card5.Image = Image.FromFile("5c.png")
        If c5 = 6 Then card5.Image = Image.FromFile("6c.png")
        If c5 = 7 Then card5.Image = Image.FromFile("7c.png")
        If c5 = 8 Then card5.Image = Image.FromFile("8c.png")
        If c5 = 9 Then card5.Image = Image.FromFile("9c.png")
        If c5 = 10 Then card5.Image = Image.FromFile("10c.png")
        If c5 = 11 Then card5.Image = Image.FromFile("jc.png")
        If c5 = 12 Then card5.Image = Image.FromFile("qc.png")
        If c5 = 13 Then card5.Image = Image.FromFile("kc.png")

        'Diamonds 14 to 26
        If c5 = 14 Then card5.Image = Image.FromFile("ad.png")
        If c5 = 15 Then card5.Image = Image.FromFile("2d.png")
        If c5 = 16 Then card5.Image = Image.FromFile("3d.png")
        If c5 = 17 Then card5.Image = Image.FromFile("4d.png")
        If c5 = 18 Then card5.Image = Image.FromFile("5d.png")
        If c5 = 19 Then card5.Image = Image.FromFile("6d.png")
        If c5 = 20 Then card5.Image = Image.FromFile("7d.png")
        If c5 = 21 Then card5.Image = Image.FromFile("8d.png")
        If c5 = 22 Then card5.Image = Image.FromFile("9d.png")
        If c5 = 23 Then card5.Image = Image.FromFile("10d.png")
        If c5 = 24 Then card5.Image = Image.FromFile("jd.png")
        If c5 = 25 Then card5.Image = Image.FromFile("qd.png")
        If c5 = 26 Then card5.Image = Image.FromFile("kd.png")

        'Hearts 27 to 39
        If c5 = 27 Then card5.Image = Image.FromFile("ah.png")
        If c5 = 28 Then card5.Image = Image.FromFile("2h.png")
        If c5 = 29 Then card5.Image = Image.FromFile("3h.png")
        If c5 = 30 Then card5.Image = Image.FromFile("4h.png")
        If c5 = 31 Then card5.Image = Image.FromFile("5h.png")
        If c5 = 32 Then card5.Image = Image.FromFile("6h.png")
        If c5 = 33 Then card5.Image = Image.FromFile("7h.png")
        If c5 = 34 Then card5.Image = Image.FromFile("8h.png")
        If c5 = 35 Then card5.Image = Image.FromFile("9h.png")
        If c5 = 36 Then card5.Image = Image.FromFile("10h.png")
        If c5 = 37 Then card5.Image = Image.FromFile("jh.png")
        If c5 = 38 Then card5.Image = Image.FromFile("qh.png")
        If c5 = 39 Then card5.Image = Image.FromFile("kh.png")

        'Spades 40 to 52
        If c5 = 40 Then card5.Image = Image.FromFile("as.png")
        If c5 = 41 Then card5.Image = Image.FromFile("2s.png")
        If c5 = 42 Then card5.Image = Image.FromFile("3s.png")
        If c5 = 43 Then card5.Image = Image.FromFile("4s.png")
        If c5 = 44 Then card5.Image = Image.FromFile("5s.png")
        If c5 = 45 Then card5.Image = Image.FromFile("6s.png")
        If c5 = 46 Then card5.Image = Image.FromFile("7s.png")
        If c5 = 47 Then card5.Image = Image.FromFile("8s.png")
        If c5 = 48 Then card5.Image = Image.FromFile("9s.png")
        If c5 = 49 Then card5.Image = Image.FromFile("10s.png")
        If c5 = 50 Then card5.Image = Image.FromFile("js.png")
        If c5 = 51 Then card5.Image = Image.FromFile("qs.png")
        If c5 = 52 Then card5.Image = Image.FromFile("ks.png")
    End Sub

    Public Sub calculateHand()
        pairs = 0
        If c1 Mod 13 = c2 Mod 13 Then pairs += 1
        If c1 Mod 13 = c3 Mod 13 Then pairs += 1
        If c1 Mod 13 = c4 Mod 13 Then pairs += 1
        If c1 Mod 13 = c5 Mod 13 Then pairs += 1
        If c2 Mod 13 = c3 Mod 13 Then pairs += 1
        If c2 Mod 13 = c4 Mod 13 Then pairs += 1
        If c2 Mod 13 = c5 Mod 13 Then pairs += 1
        If c3 Mod 13 = c4 Mod 13 Then pairs += 1
        If c3 Mod 13 = c5 Mod 13 Then pairs += 1
        If c4 Mod 13 = c5 Mod 13 Then pairs += 1

        'high and pairs and full house
        If pairs = 0 Then handRank.Text = "High Card"
        If pairs = 1 Then handRank.Text = "One Pair"
        If pairs = 2 Then handRank.Text = "Two Pair"
        If pairs = 3 Then handRank.Text = "3 of a kind"
        If pairs = 6 Then handRank.Text = "4 of a kind"
        If pairs = 4 Then handRank.Text = "Full House"

        'flushes
        If c1 < 14 And c2 < 14 And c3 < 14 And c4 < 14 And c5 < 14 Then handRank.Text = "Flush"
        If c1 < 27 And c1 > 13 And c2 < 27 And c2 > 13 And c3 < 27 And c3 > 13 And c4 < 27 And c4 > 13 And c5 < 27 And c5 > 13 Then handRank.Text = "Flush"
        If c1 < 40 And c1 > 26 And c2 < 40 And c2 > 26 And c3 < 40 And c3 > 26 And c4 < 40 And c4 > 26 And c5 < 40 And c5 > 26 Then handRank.Text = "Flush"
        If c1 < 53 And c1 > 39 And c2 < 53 And c2 > 39 And c3 < 53 And c3 > 39 And c4 < 53 And c4 > 39 And c5 < 53 And c5 > 39 Then handRank.Text = "Flush"
    End Sub
End Class
