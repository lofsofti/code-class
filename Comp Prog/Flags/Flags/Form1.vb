Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim g As System.Drawing.Graphics
        g = Me.CreateGraphics

        'Pens
        Dim blackPen As New Pen(Color.Black, 2) 'Color, Line Width
        Dim redPen As New Pen(Color.Red, 1) 'Red Pen, 1 pixel wide
        Dim bluePen As New Pen(Color.Blue, 5) 'Blue Pen, 5 pixels wide

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
        g.FillEllipse(Brushes.White, 726, 246, 50, 51)
        g.FillEllipse(Brushes.Black, 726, 293, 50, 51)
        g.FillEllipse(Brushes.Black, 740, 263, 17, 17)
        g.FillEllipse(Brushes.White, 741, 309, 17, 17)

        'Flag Boxes
        g.DrawLine(blackPen, 0, 200, 900, 200)
        g.DrawLine(blackPen, 0, 400, 900, 400)
        g.DrawLine(blackPen, 300, 0, 300, 600)
        g.DrawLine(blackPen, 600, 0, 600, 600)
    End Sub
End Class
