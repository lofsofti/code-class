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
        Me.lblpWinRate = New System.Windows.Forms.Label()
        Me.lblcWInRate = New System.Windows.Forms.Label()
        Me.lblWinRate = New System.Windows.Forms.Label()
        CType(Me.die1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.die2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Name = "Label1"
        '
        'die1
        '
        resources.ApplyResources(Me.die1, "die1")
        Me.die1.Name = "die1"
        Me.die1.TabStop = False
        '
        'die2
        '
        resources.ApplyResources(Me.die2, "die2")
        Me.die2.Name = "die2"
        Me.die2.TabStop = False
        '
        'lblplayer
        '
        resources.ApplyResources(Me.lblplayer, "lblplayer")
        Me.lblplayer.ForeColor = System.Drawing.Color.Indigo
        Me.lblplayer.Name = "lblplayer"
        '
        'lblcomp
        '
        resources.ApplyResources(Me.lblcomp, "lblcomp")
        Me.lblcomp.ForeColor = System.Drawing.Color.Indigo
        Me.lblcomp.Name = "lblcomp"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.ForeColor = System.Drawing.Color.Indigo
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblwin
        '
        resources.ApplyResources(Me.lblwin, "lblwin")
        Me.lblwin.Name = "lblwin"
        '
        'lblpwin
        '
        resources.ApplyResources(Me.lblpwin, "lblpwin")
        Me.lblpwin.ForeColor = System.Drawing.Color.Indigo
        Me.lblpwin.Name = "lblpwin"
        '
        'lblcwin
        '
        resources.ApplyResources(Me.lblcwin, "lblcwin")
        Me.lblcwin.ForeColor = System.Drawing.Color.Indigo
        Me.lblcwin.Name = "lblcwin"
        '
        'lblplaywin
        '
        Me.lblplaywin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblplaywin, "lblplaywin")
        Me.lblplaywin.ForeColor = System.Drawing.Color.Indigo
        Me.lblplaywin.Name = "lblplaywin"
        '
        'lblcompwin
        '
        Me.lblcompwin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblcompwin, "lblcompwin")
        Me.lblcompwin.ForeColor = System.Drawing.Color.Indigo
        Me.lblcompwin.Name = "lblcompwin"
        '
        'pArrow
        '
        resources.ApplyResources(Me.pArrow, "pArrow")
        Me.pArrow.Name = "pArrow"
        Me.pArrow.TabStop = False
        '
        'cArrow
        '
        resources.ApplyResources(Me.cArrow, "cArrow")
        Me.cArrow.Name = "cArrow"
        Me.cArrow.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 850
        '
        'lblpWins
        '
        resources.ApplyResources(Me.lblpWins, "lblpWins")
        Me.lblpWins.ForeColor = System.Drawing.Color.Indigo
        Me.lblpWins.Name = "lblpWins"
        '
        'lblcWins
        '
        resources.ApplyResources(Me.lblcWins, "lblcWins")
        Me.lblcWins.ForeColor = System.Drawing.Color.Indigo
        Me.lblcWins.Name = "lblcWins"
        '
        'lblTotalWins
        '
        resources.ApplyResources(Me.lblTotalWins, "lblTotalWins")
        Me.lblTotalWins.ForeColor = System.Drawing.Color.Indigo
        Me.lblTotalWins.Name = "lblTotalWins"
        '
        'lblgame
        '
        resources.ApplyResources(Me.lblgame, "lblgame")
        Me.lblgame.ForeColor = System.Drawing.Color.Indigo
        Me.lblgame.Name = "lblgame"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Name = "Label2"
        '
        'lblpWinRate
        '
        resources.ApplyResources(Me.lblpWinRate, "lblpWinRate")
        Me.lblpWinRate.ForeColor = System.Drawing.Color.Indigo
        Me.lblpWinRate.Name = "lblpWinRate"
        '
        'lblcWInRate
        '
        resources.ApplyResources(Me.lblcWInRate, "lblcWInRate")
        Me.lblcWInRate.ForeColor = System.Drawing.Color.Indigo
        Me.lblcWInRate.Name = "lblcWInRate"
        '
        'lblWinRate
        '
        resources.ApplyResources(Me.lblWinRate, "lblWinRate")
        Me.lblWinRate.ForeColor = System.Drawing.Color.Indigo
        Me.lblWinRate.Name = "lblWinRate"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.Controls.Add(Me.lblWinRate)
        Me.Controls.Add(Me.lblcWInRate)
        Me.Controls.Add(Me.lblpWinRate)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
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
    Friend WithEvents lblpWinRate As Label
    Friend WithEvents lblcWInRate As Label
    Friend WithEvents lblWinRate As Label
End Class
