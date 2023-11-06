Public Class Form1
    Dim a, b, c As Double 'goofy numbers for triangle
    Dim perimeterT, areaT, s As Double 'answer for triangle
    Dim lR, wR As Double '# for rect
    Dim perimeterR, areaR As Double 'answer for rect
    Dim r As Double 'circle goofy radius
    Dim circumferenceC, areaC As Double 'answer for circle
    Dim sideA, sideB As Double 'goofy tba for pythaaaaaaa
    Dim hypot As Double 'pythhaaaa idc answer
    Dim sR As Double 'radius for circleeeeeeee
    Dim v, surfA As Double 'circleee answer
    Dim sidenum, sideL As Double 'poly gona info
    Dim areaP, diagonalnum, apothem As Double 'polygona answera
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblShape.Text = "Choose a Shape(top left)"
        lblA.Visible = False
        lblA.Text = ""
        lblB.Visible = False
        lblB.Text = ""
        lblC.Visible = False
        lblC.Text = ""
        tbA.Visible = False
        tbA.Text = ""
        tbB.Visible = False
        tbB.Text = ""
        tbC.Visible = False
        tbC.Text = ""
        lblAns1.Visible = True
        lblAns1.Text = "Answer 1"
        lblAns2.Visible = True
        lblAns2.Text = "Answer 2"
        lblAns2.Visible = True
        lblAns3.Text = "Answer 3"
        btnCalcTriangle.Visible = False
        btnCalcRect.Visible = False
        btnCircleCalc.Visible = False
        btnCalcPythagorean.Visible = False
        btnCalcSphere.Visible = False
        btnCalcPolygon.Visible = False
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
        tbA.Text = ""
        tbB.Visible = True
        tbB.Text = ""
        tbC.Visible = True
        tbC.Text = ""
        lblAns1.Visible = True
        lblAns1.Text = "Area"
        lblAns2.Visible = True
        lblAns2.Text = "Perimeter"
        lblAns3.Visible = False
        btnCalcRect.Visible = False
        btnCircleCalc.Visible = False
        btnCalcPythagorean.Visible = False
        btnCalcSphere.Visible = False
        btnCalcPolygon.Visible = False
        btnCalcTriangle.Visible = True
    End Sub
    Private Sub RectangleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RectangleToolStripMenuItem.Click
        lblShape.Text = "Rectangle"
        lblA.Visible = True
        lblA.Text = "Length"
        lblB.Visible = True
        lblB.Text = "Width"
        lblC.Visible = False
        tbA.Visible = True
        tbA.Text = ""
        tbB.Visible = True
        tbB.Text = ""
        tbC.Visible = False
        tbC.Text = ""
        lblAns1.Visible = True
        lblAns1.Text = "Area"
        lblAns2.Visible = True
        lblAns2.Text = "Perimeter"
        lblAns3.Visible = False
        btnCalcTriangle.Visible = False
        btnCircleCalc.Visible = False
        btnCalcPythagorean.Visible = False
        btnCalcSphere.Visible = False
        btnCalcPolygon.Visible = False
        btnCalcRect.Visible = True
    End Sub
    Private Sub CircleToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CircleToolStripMenuItem.Click
        lblShape.Text = "Circle"
        lblA.Visible = False
        lblB.Visible = True
        lblB.Text = "Radius"
        lblC.Visible = False
        tbA.Visible = False
        tbA.Text = ""
        tbB.Visible = True
        tbB.Text = ""
        tbC.Visible = False
        tbC.Text = ""
        lblAns1.Visible = True
        lblAns1.Text = "Area"
        lblAns2.Visible = True
        lblAns2.Text = "Circumference"
        lblAns3.Visible = False
        btnCalcTriangle.Visible = False
        btnCalcRect.Visible = False
        btnCalcPythagorean.Visible = False
        btnCalcSphere.Visible = False
        btnCalcPolygon.Visible = False
        btnCircleCalc.Visible = True
    End Sub
    Private Sub PythaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PythaToolStripMenuItem.Click
        lblShape.Text = "Pythagorean"
        lblA.Visible = True
        lblA.Text = "Side A"
        lblB.Visible = True
        lblB.Text = "Side B"
        lblC.Visible = False
        tbA.Visible = True
        tbA.Text = ""
        tbB.Visible = True
        tbB.Text = ""
        tbC.Visible = False
        tbC.Text = ""
        lblAns1.Visible = False
        lblAns2.Visible = True
        lblAns2.Text = "Hypotenuse"
        lblAns3.Visible = False
        btnCalcTriangle.Visible = False
        btnCalcRect.Visible = False
        btnCalcSphere.Visible = False
        btnCircleCalc.Visible = False
        btnCalcPolygon.Visible = False
        btnCalcPythagorean.Visible = True
    End Sub
    Private Sub SphereToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SphereToolStripMenuItem.Click
        lblShape.Text = "Sphere"
        lblA.Visible = False
        lblB.Visible = True
        lblB.Text = "Radius"
        lblC.Visible = False
        tbA.Visible = False
        tbA.Text = ""
        tbB.Visible = True
        tbB.Text = ""
        tbC.Visible = False
        tbC.Text = ""
        lblAns1.Visible = True
        lblAns1.Text = "Volume"
        lblAns2.Visible = True
        lblAns2.Text = "Surface Area"
        lblAns3.Visible = False
        btnCalcTriangle.Visible = False
        btnCalcRect.Visible = False
        btnCalcPythagorean.Visible = False
        btnCircleCalc.Visible = False
        btnCalcPolygon.Visible = False
        btnCalcSphere.Visible = True
    End Sub
    Private Sub PolygonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PolygonToolStripMenuItem.Click
        lblShape.Text = "Polygon"
        lblA.Visible = True
        lblA.Text = "# of Sides"
        lblB.Visible = True
        lblB.Text = "Side Length"
        lblC.Visible = False
        tbA.Visible = True
        tbA.Text = ""
        tbB.Visible = True
        tbB.Text = ""
        tbC.Visible = False
        tbC.Text = ""
        lblAns1.Visible = True
        lblAns1.Text = "Area"
        lblAns2.Visible = True
        lblAns2.Text = "# of Diagonals"
        lblAns3.Visible = True
        lblAns3.Text = "Apothem"
        btnCalcTriangle.Visible = False
        btnCalcRect.Visible = False
        btnCalcPythagorean.Visible = False
        btnCircleCalc.Visible = False
        btnCalcSphere.Visible = False
        btnCalcPolygon.Visible = True
    End Sub
    Public Sub triangleCalc()
        a = tbA.Text
        b = tbB.Text
        c = tbC.Text

        perimeterT = a + b + c
        s = perimeterT / 2
        areaT = Math.Sqrt(s * (s - a) * (s - b) * (s - c))

        lblAns1.Text = "Area = " & Math.Round(areaT, 2)
        lblAns2.Text = "Perimeter = " & Math.Round(perimeterT, 2)
    End Sub
    Public Sub rectangleCalc()
        lR = tbA.Text
        wR = tbB.Text

        perimeterR = (2 * wR) + (2 * lR)
        areaR = lR * wR

        lblAns1.Text = "Area = " & Math.Round(areaR, 2)
        lblAns2.Text = "Perimeter = " & Math.Round(perimeterR, 2)
    End Sub
    Public Sub circleCalc()
        r = tbB.Text

        circumferenceC = 2 * Math.PI * r
        areaC = Math.PI * r * r

        lblAns1.Text = "Area = " & Math.Round(areaC, 2)
        lblAns2.Text = "Circumference = " & Math.Round(circumferenceC, 2)
    End Sub
    Public Sub pythagoreanCalc()
        sideA = tbA.Text
        sideB = tbB.Text

        hypot = Math.Sqrt((sideA * sideA) + (sideB * sideB))

        lblAns2.Text = "Hypotenuse = " & Math.Round(hypot, 2)
    End Sub
    Public Sub sphereCalc()
        sR = tbB.Text

        v = 4 / 3 * Math.PI * Math.Pow(sR, 3)
        surfA = 4 * Math.PI * (sR * sR)

        lblAns1.Text = "Volume = " & Math.Round(v, 2)
        lblAns2.Text = "Surface Area = " & Math.Round(surfA, 2)
    End Sub
    Public Sub polygonCalc()
        sidenum = tbA.Text
        sideL = tbB.Text

        areaP = (Math.Pow(sideL, 2) * sidenum) / (4 * Math.Tan(180 / sidenum * Math.PI / 180))
        diagonalnum = (sidenum * (sidenum - 3)) / 2
        apothem = 1 / 2 * sideL * Math.Tan((Math.PI * (sidenum - 2)) / (2 * sidenum))

        lblAns1.Text = "Area = " & Math.Round(areaP, 2)
        lblAns2.Text = "# of Diagonals = " & Math.Round(diagonalnum, 2)
        lblAns3.Text = "Apothem = " & Math.Round(apothem, 2)
    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalcTriangle.Click
        triangleCalc()
    End Sub
    Private Sub btnCalcRect_Click(sender As Object, e As EventArgs) Handles btnCalcRect.Click
        rectangleCalc()
    End Sub
    Private Sub btnCircleCalc_Click(sender As Object, e As EventArgs) Handles btnCircleCalc.Click
        circleCalc()
    End Sub
    Private Sub btnCalcPythagorean_Click(sender As Object, e As EventArgs) Handles btnCalcPythagorean.Click
        pythagoreanCalc()
    End Sub
    Private Sub btnCalcSphere_Click(sender As Object, e As EventArgs) Handles btnCalcSphere.Click
        sphereCalc()
    End Sub
    Private Sub btnCalcPolygon_Click(sender As Object, e As EventArgs) Handles btnCalcPolygon.Click
        polygonCalc()
    End Sub
End Class