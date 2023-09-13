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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.die1 = New System.Windows.Forms.PictureBox()
        Me.die2 = New System.Windows.Forms.PictureBox()
        Me.lblplayer = New System.Windows.Forms.Label()
        Me.lblcomp = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblwin = New System.Windows.Forms.Label()
        Me.lblpwin = New System.Windows.Forms.Label()
        Me.lblcwin = New System.Windows.Forms.Label()
        Me.lblplaywin = New System.Windows.Forms.Label()
        Me.lblcompwin = New System.Windows.Forms.Label()
        Me.pArrow = New System.Windows.Forms.PictureBox()
        Me.cArrow = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblpWins = New System.Windows.Forms.Label()
        Me.lblcWins = New System.Windows.Forms.Label()
        Me.lblTotalWins = New System.Windows.Forms.Label()
        Me.lblgame = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.die1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.die2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dice Wars!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'die1
        '
        Me.die1.Image = CType(resources.GetObject("die1.Image"), System.Drawing.Image)
        Me.die1.Location = New System.Drawing.Point(31, 125)
        Me.die1.Name = "die1"
        Me.die1.Size = New System.Drawing.Size(150, 150)
        Me.die1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.die1.TabIndex = 1
        Me.die1.TabStop = False
        '
        'die2
        '
        Me.die2.Image = CType(resources.GetObject("die2.Image"), System.Drawing.Image)
        Me.die2.Location = New System.Drawing.Point(321, 125)
        Me.die2.Name = "die2"
        Me.die2.Size = New System.Drawing.Size(150, 150)
        Me.die2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.die2.TabIndex = 2
        Me.die2.TabStop = False
        '
        'lblplayer
        '
        Me.lblplayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblplayer.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblplayer.Location = New System.Drawing.Point(31, 36)
        Me.lblplayer.Name = "lblplayer"
        Me.lblplayer.Size = New System.Drawing.Size(150, 38)
        Me.lblplayer.TabIndex = 3
        Me.lblplayer.Text = "player"
        Me.lblplayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcomp
        '
        Me.lblcomp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomp.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblcomp.Location = New System.Drawing.Point(321, 36)
        Me.lblcomp.Name = "lblcomp"
        Me.lblcomp.Size = New System.Drawing.Size(150, 38)
        Me.lblcomp.TabIndex = 4
        Me.lblcomp.Text = "computer"
        Me.lblcomp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(191, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 38)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "roll"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblwin
        '
        Me.lblwin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwin.Location = New System.Drawing.Point(187, 135)
        Me.lblwin.Name = "lblwin"
        Me.lblwin.Size = New System.Drawing.Size(128, 133)
        Me.lblwin.TabIndex = 6
        Me.lblwin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpwin
        '
        Me.lblpwin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpwin.ForeColor = System.Drawing.Color.Silver
        Me.lblpwin.Location = New System.Drawing.Point(31, 447)
        Me.lblpwin.Name = "lblpwin"
        Me.lblpwin.Size = New System.Drawing.Size(150, 23)
        Me.lblpwin.TabIndex = 7
        Me.lblpwin.Text = "player wins"
        Me.lblpwin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcwin
        '
        Me.lblcwin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcwin.ForeColor = System.Drawing.Color.Silver
        Me.lblcwin.Location = New System.Drawing.Point(321, 447)
        Me.lblcwin.Name = "lblcwin"
        Me.lblcwin.Size = New System.Drawing.Size(150, 23)
        Me.lblcwin.TabIndex = 8
        Me.lblcwin.Text = "computer wins"
        Me.lblcwin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblplaywin
        '
        Me.lblplaywin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblplaywin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblplaywin.Location = New System.Drawing.Point(57, 480)
        Me.lblplaywin.Name = "lblplaywin"
        Me.lblplaywin.Size = New System.Drawing.Size(100, 50)
        Me.lblplaywin.TabIndex = 9
        Me.lblplaywin.Text = "0"
        Me.lblplaywin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcompwin
        '
        Me.lblcompwin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcompwin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompwin.Location = New System.Drawing.Point(352, 480)
        Me.lblcompwin.Name = "lblcompwin"
        Me.lblcompwin.Size = New System.Drawing.Size(100, 50)
        Me.lblcompwin.TabIndex = 10
        Me.lblcompwin.Text = "0"
        Me.lblcompwin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pArrow
        '
        Me.pArrow.Image = CType(resources.GetObject("pArrow.Image"), System.Drawing.Image)
        Me.pArrow.Location = New System.Drawing.Point(57, 281)
        Me.pArrow.Name = "pArrow"
        Me.pArrow.Size = New System.Drawing.Size(100, 153)
        Me.pArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pArrow.TabIndex = 11
        Me.pArrow.TabStop = False
        Me.pArrow.Visible = False
        '
        'cArrow
        '
        Me.cArrow.Image = CType(resources.GetObject("cArrow.Image"), System.Drawing.Image)
        Me.cArrow.Location = New System.Drawing.Point(352, 281)
        Me.cArrow.Name = "cArrow"
        Me.cArrow.Size = New System.Drawing.Size(100, 153)
        Me.cArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cArrow.TabIndex = 12
        Me.cArrow.TabStop = False
        Me.cArrow.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 850
        '
        'lblpWins
        '
        Me.lblpWins.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpWins.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblpWins.Location = New System.Drawing.Point(31, 84)
        Me.lblpWins.Name = "lblpWins"
        Me.lblpWins.Size = New System.Drawing.Size(150, 38)
        Me.lblpWins.TabIndex = 13
        Me.lblpWins.Text = "0"
        Me.lblpWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcWins
        '
        Me.lblcWins.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcWins.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblcWins.Location = New System.Drawing.Point(321, 78)
        Me.lblcWins.Name = "lblcWins"
        Me.lblcWins.Size = New System.Drawing.Size(150, 38)
        Me.lblcWins.TabIndex = 14
        Me.lblcWins.Text = "0"
        Me.lblcWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalWins
        '
        Me.lblTotalWins.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWins.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTotalWins.Location = New System.Drawing.Point(175, 80)
        Me.lblTotalWins.Name = "lblTotalWins"
        Me.lblTotalWins.Size = New System.Drawing.Size(150, 38)
        Me.lblTotalWins.TabIndex = 15
        Me.lblTotalWins.Text = "<- Total WIns ->"
        Me.lblTotalWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblgame
        '
        Me.lblgame.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgame.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblgame.Location = New System.Drawing.Point(89, 4)
        Me.lblgame.Name = "lblgame"
        Me.lblgame.Size = New System.Drawing.Size(30, 38)
        Me.lblgame.TabIndex = 16
        Me.lblgame.Text = "1"
        Me.lblgame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(9, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 38)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "game "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkMagenta
        Me.ClientSize = New System.Drawing.Size(503, 578)
        Me.Controls.Add(Me.lblgame)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalWins)
        Me.Controls.Add(Me.lblcWins)
        Me.Controls.Add(Me.lblpWins)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cArrow)
        Me.Controls.Add(Me.pArrow)
        Me.Controls.Add(Me.lblcompwin)
        Me.Controls.Add(Me.lblplaywin)
        Me.Controls.Add(Me.lblcwin)
        Me.Controls.Add(Me.lblpwin)
        Me.Controls.Add(Me.lblwin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblcomp)
        Me.Controls.Add(Me.lblplayer)
        Me.Controls.Add(Me.die2)
        Me.Controls.Add(Me.die1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.die1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.die2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cArrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents die1 As PictureBox
    Friend WithEvents die2 As PictureBox
    Friend WithEvents lblplayer As Label
    Friend WithEvents lblcomp As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblwin As Label
    Friend WithEvents lblpwin As Label
    Friend WithEvents lblcwin As Label
    Friend WithEvents lblplaywin As Label
    Friend WithEvents lblcompwin As Label
    Friend WithEvents pArrow As PictureBox
    Friend WithEvents cArrow As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblpWins As Label
    Friend WithEvents lblcWins As Label
    Friend WithEvents lblTotalWins As Label
    Friend WithEvents lblgame As Label
    Friend WithEvents Label2 As Label
End Class
