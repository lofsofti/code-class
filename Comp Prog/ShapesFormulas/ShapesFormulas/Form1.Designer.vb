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
        Me.lblShape = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.tbA = New System.Windows.Forms.TextBox()
        Me.tbB = New System.Windows.Forms.TextBox()
        Me.tbC = New System.Windows.Forms.TextBox()
        Me.lblAns1 = New System.Windows.Forms.Label()
        Me.lblAns2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TriangleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectangleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CircleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PythaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SphereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PolygonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblAns3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblShape
        '
        Me.lblShape.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShape.Location = New System.Drawing.Point(93, 72)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(181, 43)
        Me.lblShape.TabIndex = 0
        Me.lblShape.Text = "Traingle"
        Me.lblShape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(145, 289)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'tbA
        '
        Me.tbA.Location = New System.Drawing.Point(160, 147)
        Me.tbA.Name = "tbA"
        Me.tbA.Size = New System.Drawing.Size(114, 20)
        Me.tbA.TabIndex = 4
        Me.tbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbB
        '
        Me.tbB.Location = New System.Drawing.Point(160, 194)
        Me.tbB.Name = "tbB"
        Me.tbB.Size = New System.Drawing.Size(114, 20)
        Me.tbB.TabIndex = 5
        Me.tbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbC
        '
        Me.tbC.Location = New System.Drawing.Point(160, 243)
        Me.tbC.Name = "tbC"
        Me.tbC.Size = New System.Drawing.Size(114, 20)
        Me.tbC.TabIndex = 6
        Me.tbC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAns1
        '
        Me.lblAns1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAns1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAns1.Location = New System.Drawing.Point(93, 332)
        Me.lblAns1.Name = "lblAns1"
        Me.lblAns1.Size = New System.Drawing.Size(199, 34)
        Me.lblAns1.TabIndex = 7
        Me.lblAns1.Text = "Perimeter"
        Me.lblAns1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAns2
        '
        Me.lblAns2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAns2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAns2.Location = New System.Drawing.Point(93, 377)
        Me.lblAns2.Name = "lblAns2"
        Me.lblAns2.Size = New System.Drawing.Size(199, 34)
        Me.lblAns2.TabIndex = 8
        Me.lblAns2.Text = "Area"
        Me.lblAns2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TriangleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(386, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TriangleToolStripMenuItem
        '
        Me.TriangleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculationsToolStripMenuItem, Me.RectangleToolStripMenuItem, Me.CircleToolStripMenuItem, Me.PythaToolStripMenuItem, Me.SphereToolStripMenuItem, Me.PolygonToolStripMenuItem})
        Me.TriangleToolStripMenuItem.Name = "TriangleToolStripMenuItem"
        Me.TriangleToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TriangleToolStripMenuItem.Text = "Formulas"
        '
        'CalculationsToolStripMenuItem
        '
        Me.CalculationsToolStripMenuItem.Name = "CalculationsToolStripMenuItem"
        Me.CalculationsToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CalculationsToolStripMenuItem.Text = "Triangle"
        '
        'RectangleToolStripMenuItem
        '
        Me.RectangleToolStripMenuItem.Name = "RectangleToolStripMenuItem"
        Me.RectangleToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.RectangleToolStripMenuItem.Text = "Rectangle"
        '
        'CircleToolStripMenuItem
        '
        Me.CircleToolStripMenuItem.Name = "CircleToolStripMenuItem"
        Me.CircleToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CircleToolStripMenuItem.Text = "Circle"
        '
        'PythaToolStripMenuItem
        '
        Me.PythaToolStripMenuItem.Name = "PythaToolStripMenuItem"
        Me.PythaToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PythaToolStripMenuItem.Text = "Pythagorean"
        '
        'SphereToolStripMenuItem
        '
        Me.SphereToolStripMenuItem.Name = "SphereToolStripMenuItem"
        Me.SphereToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.SphereToolStripMenuItem.Text = "Sphere"
        '
        'PolygonToolStripMenuItem
        '
        Me.PolygonToolStripMenuItem.Name = "PolygonToolStripMenuItem"
        Me.PolygonToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PolygonToolStripMenuItem.Text = "Polygon"
        '
        'lblA
        '
        Me.lblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(49, 147)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(105, 20)
        Me.lblA.TabIndex = 10
        Me.lblA.Text = "Side A length:"
        Me.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblB
        '
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(49, 194)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(105, 20)
        Me.lblB.TabIndex = 11
        Me.lblB.Text = "Side B length:"
        Me.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC
        '
        Me.lblC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(49, 242)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(105, 20)
        Me.lblC.TabIndex = 12
        Me.lblC.Text = "Side C length:"
        Me.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAns3
        '
        Me.lblAns3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAns3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAns3.Location = New System.Drawing.Point(93, 421)
        Me.lblAns3.Name = "lblAns3"
        Me.lblAns3.Size = New System.Drawing.Size(199, 34)
        Me.lblAns3.TabIndex = 13
        Me.lblAns3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAns3.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 487)
        Me.Controls.Add(Me.lblAns3)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblAns2)
        Me.Controls.Add(Me.lblAns1)
        Me.Controls.Add(Me.tbC)
        Me.Controls.Add(Me.tbB)
        Me.Controls.Add(Me.tbA)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblShape)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblShape As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents tbA As TextBox
    Friend WithEvents tbB As TextBox
    Friend WithEvents tbC As TextBox
    Friend WithEvents lblAns1 As Label
    Friend WithEvents lblAns2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TriangleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RectangleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CircleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PythaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SphereToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PolygonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblA As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblC As Label
    Friend WithEvents lblAns3 As Label
End Class
