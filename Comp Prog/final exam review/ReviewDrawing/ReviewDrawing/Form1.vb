Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim g As System.Drawing.Graphics
        g = Me.CreateGraphics
        Dim p As New Pen(Color.Black, 2)
        Dim blueBrush As New SolidBrush(Color.Cyan)

        g.FillRectangle(Brushes.Cyan, 100, 100, 60, 60)
        g.DrawRectangle(Pens.Black, 100, 100, 60, 60)
        g.FillEllipse(Brushes.Cyan, 100, 90, 60, 20)
        g.DrawEllipse(Pens.Black, 100, 90, 60, 20)
        g.FillEllipse(Brushes.Cyan, 100, 150, 60, 20)
        g.DrawEllipse(Pens.Black, 100, 150, 60, 20)

    End Sub
End Class