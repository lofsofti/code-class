<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DifficultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifficultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.showColorTimer = New System.Windows.Forms.Timer(Me.components)
        Me.patternTimer = New System.Windows.Forms.Timer(Me.components)
        Me.redL = New System.Windows.Forms.Label()
        Me.yellowL = New System.Windows.Forms.Label()
        Me.blueL = New System.Windows.Forms.Label()
        Me.greenL = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblHscore = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DifficultyToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(519, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DifficultyToolStripMenuItem
        '
        Me.DifficultyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasyToolStripMenuItem, Me.MediumToolStripMenuItem, Me.DifficultToolStripMenuItem})
        Me.DifficultyToolStripMenuItem.Name = "DifficultyToolStripMenuItem"
        Me.DifficultyToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DifficultyToolStripMenuItem.Text = "Difficulty"
        '
        'EasyToolStripMenuItem
        '
        Me.EasyToolStripMenuItem.Name = "EasyToolStripMenuItem"
        Me.EasyToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.EasyToolStripMenuItem.Text = "Easy"
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.MediumToolStripMenuItem.Text = "Medium"
        '
        'DifficultToolStripMenuItem
        '
        Me.DifficultToolStripMenuItem.Name = "DifficultToolStripMenuItem"
        Me.DifficultToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.DifficultToolStripMenuItem.Text = "Hard"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'showColorTimer
        '
        '
        'patternTimer
        '
        Me.patternTimer.Interval = 1000
        '
        'redL
        '
        Me.redL.BackColor = System.Drawing.Color.Red
        Me.redL.Location = New System.Drawing.Point(103, 76)
        Me.redL.Name = "redL"
        Me.redL.Size = New System.Drawing.Size(134, 116)
        Me.redL.TabIndex = 1
        '
        'yellowL
        '
        Me.yellowL.BackColor = System.Drawing.Color.Yellow
        Me.yellowL.Location = New System.Drawing.Point(286, 76)
        Me.yellowL.Name = "yellowL"
        Me.yellowL.Size = New System.Drawing.Size(134, 116)
        Me.yellowL.TabIndex = 2
        '
        'blueL
        '
        Me.blueL.BackColor = System.Drawing.Color.Blue
        Me.blueL.Location = New System.Drawing.Point(286, 213)
        Me.blueL.Name = "blueL"
        Me.blueL.Size = New System.Drawing.Size(134, 116)
        Me.blueL.TabIndex = 3
        '
        'greenL
        '
        Me.greenL.BackColor = System.Drawing.Color.Green
        Me.greenL.Location = New System.Drawing.Point(103, 213)
        Me.greenL.Name = "greenL"
        Me.greenL.Size = New System.Drawing.Size(134, 116)
        Me.greenL.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(-3, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Current Score"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(426, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "High Score"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore
        '
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(-3, 103)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(100, 23)
        Me.lblScore.TabIndex = 7
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHscore
        '
        Me.lblHscore.ForeColor = System.Drawing.Color.White
        Me.lblHscore.Location = New System.Drawing.Point(426, 103)
        Me.lblHscore.Name = "lblHscore"
        Me.lblHscore.Size = New System.Drawing.Size(100, 23)
        Me.lblHscore.TabIndex = 8
        Me.lblHscore.Text = "0"
        Me.lblHscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(217, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Simon"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(519, 392)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblHscore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.greenL)
        Me.Controls.Add(Me.blueL)
        Me.Controls.Add(Me.yellowL)
        Me.Controls.Add(Me.redL)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DifficultyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EasyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DifficultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents showColorTimer As Timer
    Friend WithEvents patternTimer As Timer
    Friend WithEvents redL As Label
    Friend WithEvents yellowL As Label
    Friend WithEvents blueL As Label
    Friend WithEvents greenL As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblHscore As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
End Class
