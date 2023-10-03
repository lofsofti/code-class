Public Class Form1
    Dim a, b, c As Double 'goofy numbers for triangle
    Dim perimeter, area, s As Double 'answer for triangle
    Dim aR, br As Double '# for rect

    Dim L, W As Double 'answer for rect

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        triangleCalc()
    End Sub
    Private Sub TriangleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculationsToolStripMenuItem.Click
        lblShape.Text = "Triangle"
        lblA.Visible = True
        lblA.Text = "Side A length:"
        lblB.Visible = True
        lblB.Text = "Side B length:"
        lblC.Visible = True
        lblC.Text = "Side C length:"
        tbA.Visible = True
        tbB.Visible = True
        tbC.Visible = True
        lblAns1.Visible = True
        lblAns1.Text = "Perimeter"
        lblAns2.Visible = True
        lblAns2.Text = "Area"
        lblAns3.Visible = False
    End Sub

    Private Sub RectangleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RectangleToolStripMenuItem.Click
        lblShape.Text = "Rectangle"
        lblA.Visible = True
        lblA.Text = "Length"
        lblb.Visible = True
        lblB.Text = "Width"
        lblC.Visible = False
        tbA.Visible = True
        tbB.Visible = True
        tbC.Visible = False

    End Sub

     Private Sub CircleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RectangleToolStripMenuItem.Click
        lblShape.Text = "Circle"
        lblA.Visible = False
        lblB.Text = "Radius:"
        lblC.Visible = False
        tbA.Visible = False
        tbB.Visible = True
        tbC.Visible = False
        End Sub
    Public Sub triangleCalc()
        a = tbA.Text
        b = tbB.Text
        c = tbC.Text

        perimeter = a + b + c
        s = perimeter / 2
        area = Math.Sqrt(s * (s - a) * (s - b) * (s - c))

        lblAns1.Text = "Perimeter = " & Math.Round(perimeter, 2)
        lblAns2.Text = "Area = " & Math.Round(area, 2)
    End Sub
End Class
