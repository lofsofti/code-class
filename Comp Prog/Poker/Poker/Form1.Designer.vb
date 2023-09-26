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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.card1 = New System.Windows.Forms.PictureBox()
        Me.card2 = New System.Windows.Forms.PictureBox()
        Me.card3 = New System.Windows.Forms.PictureBox()
        Me.card4 = New System.Windows.Forms.PictureBox()
        Me.card5 = New System.Windows.Forms.PictureBox()
        CType(Me.card1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Deal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 370)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'card1
        '
        Me.card1.Image = CType(resources.GetObject("card1.Image"), System.Drawing.Image)
        Me.card1.Location = New System.Drawing.Point(39, 75)
        Me.card1.Name = "card1"
        Me.card1.Size = New System.Drawing.Size(110, 148)
        Me.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.card1.TabIndex = 2
        Me.card1.TabStop = False
        '
        'card2
        '
        Me.card2.Image = CType(resources.GetObject("card2.Image"), System.Drawing.Image)
        Me.card2.Location = New System.Drawing.Point(190, 75)
        Me.card2.Name = "card2"
        Me.card2.Size = New System.Drawing.Size(110, 148)
        Me.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.card2.TabIndex = 3
        Me.card2.TabStop = False
        '
        'card3
        '
        Me.card3.Image = CType(resources.GetObject("card3.Image"), System.Drawing.Image)
        Me.card3.Location = New System.Drawing.Point(350, 75)
        Me.card3.Name = "card3"
        Me.card3.Size = New System.Drawing.Size(110, 148)
        Me.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.card3.TabIndex = 4
        Me.card3.TabStop = False
        '
        'card4
        '
        Me.card4.Image = CType(resources.GetObject("card4.Image"), System.Drawing.Image)
        Me.card4.Location = New System.Drawing.Point(506, 75)
        Me.card4.Name = "card4"
        Me.card4.Size = New System.Drawing.Size(110, 148)
        Me.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.card4.TabIndex = 5
        Me.card4.TabStop = False
        '
        'card5
        '
        Me.card5.Image = CType(resources.GetObject("card5.Image"), System.Drawing.Image)
        Me.card5.Location = New System.Drawing.Point(648, 75)
        Me.card5.Name = "card5"
        Me.card5.Size = New System.Drawing.Size(110, 148)
        Me.card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.card5.TabIndex = 6
        Me.card5.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.card5)
        Me.Controls.Add(Me.card4)
        Me.Controls.Add(Me.card3)
        Me.Controls.Add(Me.card2)
        Me.Controls.Add(Me.card1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.card1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents card1 As PictureBox
    Friend WithEvents card2 As PictureBox
    Friend WithEvents card3 As PictureBox
    Friend WithEvents card4 As PictureBox
    Friend WithEvents card5 As PictureBox
End Class
