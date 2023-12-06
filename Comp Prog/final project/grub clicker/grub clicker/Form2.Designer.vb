<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GRUBBBB = New System.Windows.Forms.PictureBox()
        Me.lblClicks = New System.Windows.Forms.Label()
        Me.lblRule = New System.Windows.Forms.Label()
        Me.lblStore = New System.Windows.Forms.Label()
        Me.lblAC = New System.Windows.Forms.Label()
        Me.lblKnightAttack = New System.Windows.Forms.Label()
        Me.lblHornetAttack = New System.Windows.Forms.Label()
        Me.lblAngyZote = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBuyAC = New System.Windows.Forms.Label()
        Me.lblBuyKS = New System.Windows.Forms.Label()
        Me.lblBuyHH = New System.Windows.Forms.Label()
        Me.lblBuyAZ = New System.Windows.Forms.Label()
        Me.lblBuySoB = New System.Windows.Forms.Label()
        Me.lblBuyR = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.GRUBBBB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1762, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(146, 103)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'GRUBBBB
        '
        Me.GRUBBBB.BackColor = System.Drawing.Color.Transparent
        Me.GRUBBBB.Image = CType(resources.GetObject("GRUBBBB.Image"), System.Drawing.Image)
        Me.GRUBBBB.Location = New System.Drawing.Point(553, 340)
        Me.GRUBBBB.Name = "GRUBBBB"
        Me.GRUBBBB.Size = New System.Drawing.Size(304, 402)
        Me.GRUBBBB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GRUBBBB.TabIndex = 1
        Me.GRUBBBB.TabStop = False
        '
        'lblClicks
        '
        Me.lblClicks.BackColor = System.Drawing.Color.Transparent
        Me.lblClicks.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClicks.Location = New System.Drawing.Point(411, 265)
        Me.lblClicks.Name = "lblClicks"
        Me.lblClicks.Size = New System.Drawing.Size(564, 72)
        Me.lblClicks.TabIndex = 2
        Me.lblClicks.Text = "Clicks: 0"
        Me.lblClicks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRule
        '
        Me.lblRule.BackColor = System.Drawing.Color.Transparent
        Me.lblRule.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRule.Location = New System.Drawing.Point(599, 81)
        Me.lblRule.Name = "lblRule"
        Me.lblRule.Size = New System.Drawing.Size(704, 84)
        Me.lblRule.TabIndex = 3
        Me.lblRule.Text = "CLICK THE GRUB!!!!"
        Me.lblRule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStore
        '
        Me.lblStore.BackColor = System.Drawing.Color.Transparent
        Me.lblStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStore.Location = New System.Drawing.Point(1220, 186)
        Me.lblStore.Name = "lblStore"
        Me.lblStore.Size = New System.Drawing.Size(473, 72)
        Me.lblStore.TabIndex = 4
        Me.lblStore.Text = "Store"
        Me.lblStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAC
        '
        Me.lblAC.BackColor = System.Drawing.Color.Transparent
        Me.lblAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAC.Location = New System.Drawing.Point(1222, 277)
        Me.lblAC.Name = "lblAC"
        Me.lblAC.Size = New System.Drawing.Size(196, 72)
        Me.lblAC.TabIndex = 5
        Me.lblAC.Text = "AutoClicker: 15"
        Me.lblAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKnightAttack
        '
        Me.lblKnightAttack.BackColor = System.Drawing.Color.Transparent
        Me.lblKnightAttack.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKnightAttack.Location = New System.Drawing.Point(1224, 349)
        Me.lblKnightAttack.Name = "lblKnightAttack"
        Me.lblKnightAttack.Size = New System.Drawing.Size(196, 72)
        Me.lblKnightAttack.TabIndex = 6
        Me.lblKnightAttack.Text = "Knight Slash: 30"
        Me.lblKnightAttack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHornetAttack
        '
        Me.lblHornetAttack.BackColor = System.Drawing.Color.Transparent
        Me.lblHornetAttack.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHornetAttack.Location = New System.Drawing.Point(1224, 430)
        Me.lblHornetAttack.Name = "lblHornetAttack"
        Me.lblHornetAttack.Size = New System.Drawing.Size(196, 72)
        Me.lblHornetAttack.TabIndex = 7
        Me.lblHornetAttack.Text = "Hornet Hit: 50"
        Me.lblHornetAttack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAngyZote
        '
        Me.lblAngyZote.BackColor = System.Drawing.Color.Transparent
        Me.lblAngyZote.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngyZote.Location = New System.Drawing.Point(1224, 502)
        Me.lblAngyZote.Name = "lblAngyZote"
        Me.lblAngyZote.Size = New System.Drawing.Size(196, 72)
        Me.lblAngyZote.TabIndex = 8
        Me.lblAngyZote.Text = "Angry Zote: 150"
        Me.lblAngyZote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1188, 574)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 72)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Sisters of Battle: 200"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1193, 659)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 72)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "The Radiance: 500"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBuyAC
        '
        Me.lblBuyAC.BackColor = System.Drawing.Color.Transparent
        Me.lblBuyAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBuyAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuyAC.Location = New System.Drawing.Point(1500, 284)
        Me.lblBuyAC.Name = "lblBuyAC"
        Me.lblBuyAC.Size = New System.Drawing.Size(82, 39)
        Me.lblBuyAC.TabIndex = 11
        Me.lblBuyAC.Text = "Buy"
        Me.lblBuyAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBuyKS
        '
        Me.lblBuyKS.BackColor = System.Drawing.Color.Transparent
        Me.lblBuyKS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBuyKS.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuyKS.Location = New System.Drawing.Point(1500, 366)
        Me.lblBuyKS.Name = "lblBuyKS"
        Me.lblBuyKS.Size = New System.Drawing.Size(82, 39)
        Me.lblBuyKS.TabIndex = 12
        Me.lblBuyKS.Text = "Buy"
        Me.lblBuyKS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBuyHH
        '
        Me.lblBuyHH.BackColor = System.Drawing.Color.Transparent
        Me.lblBuyHH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBuyHH.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuyHH.Location = New System.Drawing.Point(1500, 447)
        Me.lblBuyHH.Name = "lblBuyHH"
        Me.lblBuyHH.Size = New System.Drawing.Size(82, 39)
        Me.lblBuyHH.TabIndex = 13
        Me.lblBuyHH.Text = "Buy"
        Me.lblBuyHH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBuyAZ
        '
        Me.lblBuyAZ.BackColor = System.Drawing.Color.Transparent
        Me.lblBuyAZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBuyAZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuyAZ.Location = New System.Drawing.Point(1500, 519)
        Me.lblBuyAZ.Name = "lblBuyAZ"
        Me.lblBuyAZ.Size = New System.Drawing.Size(82, 39)
        Me.lblBuyAZ.TabIndex = 14
        Me.lblBuyAZ.Text = "Buy"
        Me.lblBuyAZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBuySoB
        '
        Me.lblBuySoB.BackColor = System.Drawing.Color.Transparent
        Me.lblBuySoB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBuySoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuySoB.Location = New System.Drawing.Point(1500, 591)
        Me.lblBuySoB.Name = "lblBuySoB"
        Me.lblBuySoB.Size = New System.Drawing.Size(82, 39)
        Me.lblBuySoB.TabIndex = 15
        Me.lblBuySoB.Text = "Buy"
        Me.lblBuySoB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBuyR
        '
        Me.lblBuyR.BackColor = System.Drawing.Color.Transparent
        Me.lblBuyR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBuyR.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuyR.Location = New System.Drawing.Point(1500, 667)
        Me.lblBuyR.Name = "lblBuyR"
        Me.lblBuyR.Size = New System.Drawing.Size(82, 39)
        Me.lblBuyR.TabIndex = 16
        Me.lblBuyR.Text = "Buy"
        Me.lblBuyR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1029, 677)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 39)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "x0"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1029, 592)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 39)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "x0"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1029, 521)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 39)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "x0"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1029, 450)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 39)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "x0"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1029, 369)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 39)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "x0"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1029, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 39)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "x0"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1920, 1061)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblBuyR)
        Me.Controls.Add(Me.lblBuySoB)
        Me.Controls.Add(Me.lblBuyAZ)
        Me.Controls.Add(Me.lblBuyHH)
        Me.Controls.Add(Me.lblBuyKS)
        Me.Controls.Add(Me.lblBuyAC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAngyZote)
        Me.Controls.Add(Me.lblHornetAttack)
        Me.Controls.Add(Me.lblKnightAttack)
        Me.Controls.Add(Me.lblAC)
        Me.Controls.Add(Me.lblStore)
        Me.Controls.Add(Me.lblRule)
        Me.Controls.Add(Me.lblClicks)
        Me.Controls.Add(Me.GRUBBBB)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GRUBBBB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents GRUBBBB As PictureBox
    Friend WithEvents lblClicks As Label
    Friend WithEvents lblRule As Label
    Friend WithEvents lblStore As Label
    Friend WithEvents lblAC As Label
    Friend WithEvents lblKnightAttack As Label
    Friend WithEvents lblHornetAttack As Label
    Friend WithEvents lblAngyZote As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBuyAC As Label
    Friend WithEvents lblBuyKS As Label
    Friend WithEvents lblBuyHH As Label
    Friend WithEvents lblBuyAZ As Label
    Friend WithEvents lblBuySoB As Label
    Friend WithEvents lblBuyR As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
