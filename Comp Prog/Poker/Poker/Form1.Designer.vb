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
        Me.handRank = New System.Windows.Forms.Label()
        Me.card1 = New System.Windows.Forms.PictureBox()
        Me.card2 = New System.Windows.Forms.PictureBox()
        Me.card3 = New System.Windows.Forms.PictureBox()
        Me.card4 = New System.Windows.Forms.PictureBox()
        Me.card5 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CardBacksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FancyRedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FancyBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.card1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
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
        'handRank
        '
        Me.handRank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.handRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.handRank.Location = New System.Drawing.Point(311, 370)
        Me.handRank.Name = "handRank"
        Me.handRank.Size = New System.Drawing.Size(171, 47)
        Me.handRank.TabIndex = 1
        Me.handRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CardBacksToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CardBacksToolStripMenuItem
        '
        Me.CardBacksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedToolStripMenuItem, Me.BlueToolStripMenuItem, Me.FancyRedToolStripMenuItem, Me.FancyBlueToolStripMenuItem})
        Me.CardBacksToolStripMenuItem.Name = "CardBacksToolStripMenuItem"
        Me.CardBacksToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.CardBacksToolStripMenuItem.Text = "CardBacks"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'FancyRedToolStripMenuItem
        '
        Me.FancyRedToolStripMenuItem.Name = "FancyRedToolStripMenuItem"
        Me.FancyRedToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FancyRedToolStripMenuItem.Text = "Fancy Red"
        '
        'FancyBlueToolStripMenuItem
        '
        Me.FancyBlueToolStripMenuItem.Name = "FancyBlueToolStripMenuItem"
        Me.FancyBlueToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FancyBlueToolStripMenuItem.Text = "Fancy Blue"
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
        Me.Controls.Add(Me.handRank)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.card1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents handRank As Label
    Friend WithEvents card1 As PictureBox
    Friend WithEvents card2 As PictureBox
    Friend WithEvents card3 As PictureBox
    Friend WithEvents card4 As PictureBox
    Friend WithEvents card5 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CardBacksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FancyRedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FancyBlueToolStripMenuItem As ToolStripMenuItem
End Class
