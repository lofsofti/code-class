Public Class Form2
    Dim clicks As Integer
    Dim AC, KS, HH, AZ, SoB, R As Integer
    Private Sub lblBuyAC_Click(sender As Object, e As EventArgs) Handles lblBuyAC.Click
        If clicks >= 15 Then
            ACtimer.Enabled = True
            clicks -= 15
            lblClicks.Text = "Clicks: " & clicks
            AC += 1
            lblACamount.Text = "x" & AC
        End If
    End Sub
    Private Sub ACtimer_Tick(sender As Object, e As EventArgs) Handles ACtimer.Tick
        clicks += 1 * AC
        lblClicks.Text = "Clicks: " & clicks
    End Sub
    Private Sub lblBuyKS_Click(sender As Object, e As EventArgs) Handles lblBuyKS.Click
        If clicks >= 100 Then
            KStimer.Enabled = True
            clicks -= 100
            lblClicks.Text = "Clicks: " & clicks
            KS += 1
            lblKSamount.Text = "x" & KS
        End If
    End Sub
    Private Sub KStimer_Tick(sender As Object, e As EventArgs) Handles KStimer.Tick
        clicks += 10 * KS
        lblClicks.Text = "Clicks: " & clicks
    End Sub
    Private Sub lblBuyHH_Click(sender As Object, e As EventArgs) Handles lblBuyHH.Click
        If clicks >= 300 Then
            HHtimer.Enabled = True
            clicks -= 300
            lblClicks.Text = "Clicks: " & clicks
            HH += 1
            lblHHamount.Text = "x" & HH
        End If
    End Sub
    Private Sub HHtimer_Tick(sender As Object, e As EventArgs) Handles HHtimer.Tick
        clicks += 50 * HH
        lblClicks.Text = "Clicks: " & clicks
    End Sub
    Private Sub lblBuyAZ_Click(sender As Object, e As EventArgs) Handles lblBuyAZ.Click
        If clicks >= 750 Then
            AZtimer.Enabled = True
            clicks -= 750
            lblClicks.Text = "Clicks: " & clicks
            AZ += 1
            lblAZamount.Text = "x" & AZ
        End If
    End Sub
    Private Sub AZtimer_Tick(sender As Object, e As EventArgs) Handles AZtimer.Tick
        clicks += 100 * AZ
        lblClicks.Text = "Clicks: " & clicks
    End Sub
    Private Sub lblBuySoB_Click(sender As Object, e As EventArgs) Handles lblBuySoB.Click
        If clicks >= 2000 Then
            SoBtimer.Enabled = True
            clicks -= 2000
            lblClicks.Text = "Clicks: " & clicks
            SoB += 1
            lblSoBamount.Text = "x" & SoB
        End If
    End Sub
    Private Sub SoBtimer_Tick(sender As Object, e As EventArgs) Handles SoBtimer.Tick
        clicks += 250 * AZ
        lblClicks.Text = "Clicks: " & clicks
    End Sub
    Private Sub lblBuyR_Click(sender As Object, e As EventArgs) Handles lblBuyR.Click
        If clicks >= 2000 Then
            Rtimer.Enabled = True
            clicks -= 2000
            lblClicks.Text = "Clicks: " & clicks
            R += 1
            lblRamount.Text = "x" & R
        End If
    End Sub
    Private Sub Rtimer_Tick(sender As Object, e As EventArgs) Handles Rtimer.Tick
        clicks += 500 * AZ
        lblClicks.Text = "Clicks: " & clicks
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Form1.Close()
    End Sub
    Private Sub GRUBBBB_Click(sender As Object, e As EventArgs) Handles GRUBBBB.Click
        clicks += 1
        lblClicks.Text = "Clicks: " & clicks
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblClicks.Text = "Clicks: " & clicks
    End Sub
End Class