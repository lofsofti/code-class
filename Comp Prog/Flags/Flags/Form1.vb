Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim g As System.Drawing.Graphics
        g = Me.CreateGraphics

        'Pens
        Dim blackPen As New Pen(Color.Black, 2) 'Color, Line Width
        Dim redPen As New Pen(Color.Red, 1) 'Red Pen, 1 pixel wide
        Dim bluePen As New Pen(Color.Blue, 5) 'Blue Pen, 5 pixels wide
        Dim BLACK As New Pen(Color.Black, 7)
        Dim blacke As New Pen(Color.Black, 8)

        'French
        g.FillRectangle(Brushes.Blue, 0, 0, 100, 200)
        g.FillRectangle(Brushes.White, 100, 0, 100, 200)
        g.FillRectangle(Brushes.Red, 200, 0, 100, 200)

        'Japan
        g.FillRectangle(Brushes.White, 300, 0, 300, 200)
        g.FillEllipse(Brushes.Red, 400, 45, 100, 100)

        'Swiss
        g.FillRectangle(Brushes.Red, 600, 0, 300, 200)
        g.FillRectangle(Brushes.White, 725, 45, 40, 110)
        g.FillRectangle(Brushes.White, 685, 80, 120, 40)

        'Greenland
        g.FillRectangle(Brushes.White, 0, 200, 300, 100)
        g.FillRectangle(Brushes.Red, 0, 300, 300, 100)
        g.FillPie(Brushes.Red, 45, 250, 100, 100, 180, 180)
        g.FillPie(Brushes.White, 45, 250, 100, 100, 0, 180)

        'Norway
        g.FillRectangle(Brushes.Red, 300, 200, 300, 200)
        g.FillRectangle(Brushes.White, 360, 200, 60, 200)
        g.FillRectangle(Brushes.White, 300, 280, 300, 40)
        g.FillRectangle(Brushes.Blue, 380, 200, 20, 200)
        g.FillRectangle(Brushes.Blue, 300, 290, 300, 20)

        'Ying Yang
        g.FillRectangle(Brushes.White, 600, 200, 300, 200)
        g.FillPie(Brushes.White, 700, 245, 100, 100, 270, 180)
        g.FillPie(Brushes.Black, 700, 245, 100, 100, 90, 180)
        g.DrawEllipse(blackPen, 700, 245, 100, 100)
        g.FillEllipse(Brushes.White, 725, 245, 50, 50)
        g.FillEllipse(Brushes.Black, 725, 295, 50, 50)
        g.FillEllipse(Brushes.Black, 740, 263, 17, 17)
        g.FillEllipse(Brushes.White, 741, 309, 17, 17)

        'Custom
        g.FillRectangle(Brushes.Green, 0, 400, 90, 90)
        g.FillRectangle(Brushes.Yellow, 0, 510, 90, 90)
        g.FillRectangle(Brushes.Yellow, 110, 400, 190, 90)
        g.FillRectangle(Brushes.Green, 110, 510, 190, 90)
        g.FillPie(Brushes.Yellow, 38, 438, 124, 124, 180, 90)
        g.FillPie(Brushes.Green, 38, 438, 124, 124, 270, 90)
        g.FillPie(Brushes.Yellow, 38, 438, 124, 124, 0, 90)
        g.FillPie(Brushes.Green, 38, 438, 124, 124, 90, 90)
        g.FillRectangle(Brushes.Black, 0, 490, 300, 20)
        g.FillRectangle(Brushes.Black, 90, 400, 20, 200)
        g.DrawEllipse(BLACK, 38, 438, 124, 124)
        g.FillEllipse(Brushes.Black, 50, 450, 100, 100)
        g.FillRectangle(Brushes.Yellow, 90, 470, 20, 60)
        g.FillRectangle(Brushes.Yellow, 70, 490, 60, 20)

        'Peace
        g.FillRectangle(Brushes.Green, 300, 400, 300, 67)
        g.FillRectangle(Brushes.Yellow, 300, 467, 300, 67)
        g.FillRectangle(Brushes.Red, 300, 533, 300, 67)
        g.FillEllipse(Brushes.White, 390, 440, 125, 125)
        g.DrawEllipse(blacke, 390, 440, 125, 125)
        g.DrawLine(blacke, 453, 440, 453, 562)
        g.DrawLine(blacke, 453, 510, 500, 540)
        g.DrawLine(blacke, 453, 510, 400, 540)

        'Flag Boxes
        g.DrawLine(blackPen, 0, 200, 900, 200)
        g.DrawLine(blackPen, 0, 400, 900, 400)
        g.DrawLine(blackPen, 300, 0, 300, 600)
        g.DrawLine(blackPen, 600, 0, 600, 600)
    End Sub
End Class
