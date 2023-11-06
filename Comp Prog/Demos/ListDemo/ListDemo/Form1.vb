Public Class Form1
    Dim nums As New List(Of Integer)
    Dim n, r As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For n = 1 To 20
            nums.Add(n)
        Next
        'MsgBox(nums.Count)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For n = 0 To nums.Count - 1
            ListBox1.Items.Add(nums.Item(n))
        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For n = nums.Count - 1 To 0 Step -1
            ListBox1.Items.Add(nums.Item(n))
        Next
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Randomize()
        While nums.Count > 0
            r = Int(Rnd() * nums.Count)
            ListBox1.Items.Add(nums.Item(r))
            nums.RemoveAt(r)
        End While
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        nums.Clear()
        ListBox1.Items.Clear()
    End Sub
End Class
