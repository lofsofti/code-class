<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubtractionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbloperation = New System.Windows.Forms.Label()
        Me.lblans = New System.Windows.Forms.Label()
        Me.number1 = New System.Windows.Forms.TextBox()
        Me.number2 = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.tnclear = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdditionToolStripMenuItem, Me.SubtractionToolStripMenuItem, Me.MultiplicationToolStripMenuItem, Me.DivisionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(376, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdditionToolStripMenuItem
        '
        Me.AdditionToolStripMenuItem.Name = "AdditionToolStripMenuItem"
        Me.AdditionToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.AdditionToolStripMenuItem.Text = "Addition"
        '
        'SubtractionToolStripMenuItem
        '
        Me.SubtractionToolStripMenuItem.Name = "SubtractionToolStripMenuItem"
        Me.SubtractionToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.SubtractionToolStripMenuItem.Text = "Subtraction"
        '
        'MultiplicationToolStripMenuItem
        '
        Me.MultiplicationToolStripMenuItem.Name = "MultiplicationToolStripMenuItem"
        Me.MultiplicationToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.MultiplicationToolStripMenuItem.Text = "Multiplication"
        '
        'DivisionToolStripMenuItem
        '
        Me.DivisionToolStripMenuItem.Name = "DivisionToolStripMenuItem"
        Me.DivisionToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.DivisionToolStripMenuItem.Text = "Division"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(53, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Calculator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter first number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 36)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter second number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblnum1
        '
        Me.lblnum1.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnum1.Location = New System.Drawing.Point(220, 57)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(94, 78)
        Me.lblnum1.TabIndex = 4
        Me.lblnum1.Text = "0"
        Me.lblnum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblnum2
        '
        Me.lblnum2.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnum2.Location = New System.Drawing.Point(220, 123)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(94, 78)
        Me.lblnum2.TabIndex = 5
        Me.lblnum2.Text = "0"
        Me.lblnum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(149, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 12)
        Me.Label6.TabIndex = 6
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbloperation
        '
        Me.lbloperation.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloperation.Location = New System.Drawing.Point(158, 147)
        Me.lbloperation.Name = "lbloperation"
        Me.lbloperation.Size = New System.Drawing.Size(56, 48)
        Me.lbloperation.TabIndex = 7
        Me.lbloperation.Text = "+"
        Me.lbloperation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblans
        '
        Me.lblans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblans.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblans.Location = New System.Drawing.Point(149, 223)
        Me.lblans.Name = "lblans"
        Me.lblans.Size = New System.Drawing.Size(192, 65)
        Me.lblans.TabIndex = 8
        Me.lblans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'number1
        '
        Me.number1.BackColor = System.Drawing.Color.RosyBrown
        Me.number1.Location = New System.Drawing.Point(12, 96)
        Me.number1.Name = "number1"
        Me.number1.Size = New System.Drawing.Size(112, 33)
        Me.number1.TabIndex = 9
        '
        'number2
        '
        Me.number2.BackColor = System.Drawing.Color.RosyBrown
        Me.number2.Location = New System.Drawing.Point(12, 168)
        Me.number2.Name = "number2"
        Me.number2.Size = New System.Drawing.Size(112, 33)
        Me.number2.TabIndex = 10
        '
        'btncalc
        '
        Me.btncalc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalc.Location = New System.Drawing.Point(28, 211)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(96, 34)
        Me.btncalc.TabIndex = 11
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'tnclear
        '
        Me.tnclear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnclear.Location = New System.Drawing.Point(28, 251)
        Me.tnclear.Name = "tnclear"
        Me.tnclear.Size = New System.Drawing.Size(96, 34)
        Me.tnclear.TabIndex = 12
        Me.tnclear.Text = "Clear "
        Me.tnclear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(376, 297)
        Me.Controls.Add(Me.tnclear)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.number2)
        Me.Controls.Add(Me.number1)
        Me.Controls.Add(Me.lblans)
        Me.Controls.Add(Me.lbloperation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.lblnum1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdditionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubtractionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultiplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DivisionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblnum1 As Label
    Friend WithEvents lblnum2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbloperation As Label
    Friend WithEvents lblans As Label
    Friend WithEvents number1 As TextBox
    Friend WithEvents number2 As TextBox
    Friend WithEvents btncalc As Button
    Friend WithEvents tnclear As Button
End Class
