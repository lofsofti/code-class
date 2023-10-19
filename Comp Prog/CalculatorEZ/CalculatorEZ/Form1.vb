Public Class Form1
    Dim num1, num2 As Double
    Dim answer As Double
    Dim opp As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opp = "Add"
    End Sub
    Private Sub AdditionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdditionToolStripMenuItem.Click
        opp = "Add"
        lblnum1.Text = "0"
        lblnum2.Text = "0"
        number1.Text = ""
        number2.Text = ""
        lbloperation.Text = "+"
        lblans.Text = ""
    End Sub
    Public Sub calcAdd()
        num1 = number1.Text
        num2 = number2.Text
        lblnum1.Text = number1.Text
        lblnum2.Text = number2.Text
        answer = num1 + num2
        lblans.Text = Math.Round(answer, 2)
    End Sub
    Private Sub SubtractionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubtractionToolStripMenuItem.Click
        opp = "Sub"
        lblnum1.Text = "0"
        lblnum2.Text = "0"
        number1.Text = ""
        number2.Text = ""
        lbloperation.Text = "-"
        lblans.Text = ""
    End Sub
    Public Sub calcSub()
        num1 = number1.Text
        num2 = number2.Text
        lblnum1.Text = number1.Text
        lblnum2.Text = number2.Text
        answer = num1 - num2
        lblans.Text = Math.Round(answer, 2)
    End Sub
    Private Sub MultiplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplicationToolStripMenuItem.Click
        opp = "Multiply"
        lblnum1.Text = "0"
        lblnum2.Text = "0"
        number1.Text = ""
        number2.Text = ""
        lbloperation.Text = "X"
        lblans.Text = ""
    End Sub
    Public Sub calcMultip()
        num1 = number1.Text
        num2 = number2.Text
        lblnum1.Text = number1.Text
        lblnum2.Text = number2.Text
        answer = num1 * num2
        lblans.Text = Math.Round(answer, 2)
    End Sub
    Private Sub DivisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivisionToolStripMenuItem.Click
        opp = "Div"
        lblnum1.Text = "0"
        lblnum2.Text = "0"
        number1.Text = ""
        number2.Text = ""
        lbloperation.Text = "÷"
        lblans.Text = ""
    End Sub
    Public Sub calcDiv()
        num1 = number1.Text
        num2 = number2.Text
        lblnum1.Text = number1.Text
        lblnum2.Text = number2.Text
        answer = num1 / num2
        lblans.Text = Math.Round(answer, 2)
    End Sub
    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        If opp = "Add" Then calcAdd()
        If opp = "Sub" Then calcSub()
        If opp = "Multiply" Then calcMultip()
        If opp = "Div" Then calcDiv()
    End Sub
    Private Sub number1_TextChanged(sender As Object, e As EventArgs) Handles number1.TextChanged
        lblnum1.Text = number1.Text
    End Sub
    Private Sub number2_TextChanged(sender As Object, e As EventArgs) Handles number2.TextChanged
        lblnum2.Text = number2.Text
    End Sub
    Private Sub tnclear_Click(sender As Object, e As EventArgs) Handles tnclear.Click
        lblnum1.Text = "0"
        lblnum2.Text = "0"
        number1.Text = ""
        number2.Text = ""
        lblans.Text = ""
        If opp = "Add" Then lbloperation.Text = "+"
        If opp = "Sub" Then lbloperation.Text = "-"
        If opp = "Multiply" Then lbloperation.Text = "X"
        If opp = "Div" Then lbloperation.Text = "÷"
    End Sub
End Class
