Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim g As System.Drawing.Graphics
        g = Me.CreateGraphics

        'Pens
        Dim blackPen As New Pen(Color.Black, 3) 'Color, Line Width
        Dim redPen As New Pen(Color.Red, 1) 'Red Pen, 1 pixel wide
        Dim bluePen As New Pen(Color.Blue, 5) 'Blue Pen, 5 pixels wide

        'Draw Lines (Pen, X1, Y1, X2, Y2)
        'g.DrawLine(blackPen, 0, 0, 400, 400)
        'g.DrawLine(blackPen, 0, 400, 400, 0)
        'g.DrawLine(bluePen, 0, 200, 400, 200)
        'g.DrawLine(bluePen, 200, 0, 200, 400)

        ''Rectangles (Pen/Brush, X, Y, Width, Height)
        'g.FillRectangle(Brushes.Orange, 0, 0, 200, 200)
        'g.FillRectangle(Brushes.Violet, 200, 0, 200, 200)
        'g.FillRectangle(Brushes.Red, 0, 200, 200, 200)
        'g.FillRectangle(Brushes.Yellow, 200, 200, 200, 200)

        ''Ellipses - Same AS Rectengle
        'g.FillEllipse(Brushes.White, 0, 0, 200, 200)

        'g.FillRectangle(Brushes.Red, 140, 140, 120, 120)

        'g.FillRectangle(Brushes.Blue, 0, 0, 100, 200)
        'g.FillRectangle(Brushes.Red, 200, 0, 100, 200)
        'g.DrawLine(blackPen, 0, 200, 300, 200)
        'g.DrawLine(blackPen, 300, 200, 300, 0)

        g.FillPie(Brushes.Green, 0, 0, 400, 400, 270, 180)
    End Sub
End Class
