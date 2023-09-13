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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mario = New System.Windows.Forms.PictureBox()
        Me.lava = New System.Windows.Forms.Label()
        Me.bowser = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.mario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bowser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mario
        '
        Me.mario.Image = CType(resources.GetObject("mario.Image"), System.Drawing.Image)
        Me.mario.Location = New System.Drawing.Point(100, 100)
        Me.mario.Name = "mario"
        Me.mario.Size = New System.Drawing.Size(40, 64)
        Me.mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mario.TabIndex = 0
        Me.mario.TabStop = False
        '
        'lava
        '
        Me.lava.BackColor = System.Drawing.Color.OrangeRed
        Me.lava.Font = New System.Drawing.Font("Ravie", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lava.Location = New System.Drawing.Point(236, 252)
        Me.lava.Name = "lava"
        Me.lava.Size = New System.Drawing.Size(161, 92)
        Me.lava.TabIndex = 1
        Me.lava.Text = "Lava"
        Me.lava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bowser
        '
        Me.bowser.Image = CType(resources.GetObject("bowser.Image"), System.Drawing.Image)
        Me.bowser.Location = New System.Drawing.Point(296, 40)
        Me.bowser.Name = "bowser"
        Me.bowser.Size = New System.Drawing.Size(100, 104)
        Me.bowser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bowser.TabIndex = 2
        Me.bowser.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.bowser)
        Me.Controls.Add(Me.lava)
        Me.Controls.Add(Me.mario)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.mario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bowser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mario As PictureBox
    Friend WithEvents lava As Label
    Friend WithEvents bowser As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
