Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim graphics As System.Drawing.Graphics
        graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black, 2)
        Dim white As New SolidBrush(Color.White)

        graphics.FillRectangle(Brushes.Black, 85, 250, 40, 80)
        graphics.FillPie(Brushes.Black, 70, 170, 130, 160, 180, 180)
        graphics.FillEllipse(Brushes.Black, 100, 100, 70, 70)
        graphics.FillRectangle(Brushes.Black, 148, 250, 40, 80)
        graphics.FillRectangle(Brushes.White, 131, 170, 10, 10)
    End Sub
End Class
