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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.fire1 = New System.Windows.Forms.PictureBox()
        Me.fire2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fire3 = New System.Windows.Forms.PictureBox()
        Me.fire4 = New System.Windows.Forms.PictureBox()
        CType(Me.fire1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fire2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fire3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fire4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'fire1
        '
        Me.fire1.Image = CType(resources.GetObject("fire1.Image"), System.Drawing.Image)
        Me.fire1.Location = New System.Drawing.Point(12, 12)
        Me.fire1.Name = "fire1"
        Me.fire1.Size = New System.Drawing.Size(25, 40)
        Me.fire1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fire1.TabIndex = 0
        Me.fire1.TabStop = False
        '
        'fire2
        '
        Me.fire2.Image = CType(resources.GetObject("fire2.Image"), System.Drawing.Image)
        Me.fire2.Location = New System.Drawing.Point(120, 85)
        Me.fire2.Name = "fire2"
        Me.fire2.Size = New System.Drawing.Size(25, 40)
        Me.fire2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fire2.TabIndex = 1
        Me.fire2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 300)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(140, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 140)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 10)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(140, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 10)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'fire3
        '
        Me.fire3.Image = CType(resources.GetObject("fire3.Image"), System.Drawing.Image)
        Me.fire3.Location = New System.Drawing.Point(170, 265)
        Me.fire3.Name = "fire3"
        Me.fire3.Size = New System.Drawing.Size(40, 25)
        Me.fire3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fire3.TabIndex = 6
        Me.fire3.TabStop = False
        '
        'fire4
        '
        Me.fire4.Image = CType(resources.GetObject("fire4.Image"), System.Drawing.Image)
        Me.fire4.Location = New System.Drawing.Point(240, 155)
        Me.fire4.Name = "fire4"
        Me.fire4.Size = New System.Drawing.Size(40, 25)
        Me.fire4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fire4.TabIndex = 7
        Me.fire4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.fire4)
        Me.Controls.Add(Me.fire3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fire2)
        Me.Controls.Add(Me.fire1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.fire1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fire2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fire3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fire4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents fire1 As PictureBox
    Friend WithEvents fire2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fire3 As PictureBox
    Friend WithEvents fire4 As PictureBox
End Class
