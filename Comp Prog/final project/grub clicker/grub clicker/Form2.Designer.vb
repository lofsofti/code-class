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
        Me.components = New System.ComponentModel.Container()
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
        Me.lblRamount = New System.Windows.Forms.Label()
        Me.lblSoBamount = New System.Windows.Forms.Label()
        Me.lblAZamount = New System.Windows.Forms.Label()
        Me.lblHHamount = New System.Windows.Forms.Label()
        Me.lblKSamount = New System.Windows.Forms.Label()
        Me.lblACamount = New System.Windows.Forms.Label()
        Me.ACtimer = New System.Windows.Forms.Timer(Me.components)
        Me.KStimer = New System.Windows.Forms.Timer(Me.components)
        Me.HHtimer = New System.Windows.Forms.Timer(Me.components)
        Me.AZtimer = New System.Windows.Forms.Timer(Me.components)
        Me.SoBtimer = New System.Windows.Forms.Timer(Me.components)
        Me.Rtimer = New System.Windows.Forms.Timer(Me.components)
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
        Me.lblClicks.ForeColor = System.Drawing.Color.White
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
        Me.lblRule.ForeColor = System.Drawing.Color.White
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
        Me.lblStore.ForeColor = System.Drawing.Color.White
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
        Me.lblAC.ForeColor = System.Drawing.Color.White
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
        Me.lblKnightAttack.ForeColor = System.Drawing.Color.White
        Me.lblKnightAttack.Location = New System.Drawing.Point(1224, 349)
        Me.lblKnightAttack.Name = "lblKnightAttack"
        Me.lblKnightAttack.Size = New System.Drawing.Size(213, 72)
        Me.lblKnightAttack.TabIndex = 6
        Me.lblKnightAttack.Text = "Knight Slash: 100"
        Me.lblKnightAttack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHornetAttack
        '
        Me.lblHornetAttack.BackColor = System.Drawing.Color.Transparent
        Me.lblHornetAttack.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHornetAttack.ForeColor = System.Drawing.Color.White
        Me.lblHornetAttack.Location = New System.Drawing.Point(1224, 430)
        Me.lblHornetAttack.Name = "lblHornetAttack"
        Me.lblHornetAttack.Size = New System.Drawing.Size(196, 72)
        Me.lblHornetAttack.TabIndex = 7
        Me.lblHornetAttack.Text = "Hornet Hit: 300"
        Me.lblHornetAttack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAngyZote
        '
        Me.lblAngyZote.BackColor = System.Drawing.Color.Transparent
        Me.lblAngyZote.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngyZote.ForeColor = System.Drawing.Color.White
        Me.lblAngyZote.Location = New System.Drawing.Point(1224, 502)
        Me.lblAngyZote.Name = "lblAngyZote"
        Me.lblAngyZote.Size = New System.Drawing.Size(196, 72)
        Me.lblAngyZote.TabIndex = 8
        Me.lblAngyZote.Text = "Angry Zote: 750"
        Me.lblAngyZote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1188, 574)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 72)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Sisters of Battle: 2000"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1193, 659)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 72)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "The Radiance: 5000"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBuyAC
        '
        Me.lblBuyAC.BackColor = System.Drawing.Color.Transparent
        Me.lblBuyAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBuyAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuyAC.ForeColor = System.Drawing.Color.White
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
        Me.lblBuyKS.ForeColor = System.Drawing.Color.White
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
        Me.lblBuyHH.ForeColor = System.Drawing.Color.White
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
        Me.lblBuyAZ.ForeColor = System.Drawing.Color.White
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
        Me.lblBuySoB.ForeColor = System.Drawing.Color.White
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
        Me.lblBuyR.ForeColor = System.Drawing.Color.White
        Me.lblBuyR.Location = New System.Drawing.Point(1500, 667)
        Me.lblBuyR.Name = "lblBuyR"
        Me.lblBuyR.Size = New System.Drawing.Size(82, 39)
        Me.lblBuyR.TabIndex = 16
        Me.lblBuyR.Text = "Buy"
        Me.lblBuyR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRamount
        '
        Me.lblRamount.BackColor = System.Drawing.Color.Transparent
        Me.lblRamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRamount.ForeColor = System.Drawing.Color.White
        Me.lblRamount.Location = New System.Drawing.Point(1029, 677)
        Me.lblRamount.Name = "lblRamount"
        Me.lblRamount.Size = New System.Drawing.Size(166, 39)
        Me.lblRamount.TabIndex = 22
        Me.lblRamount.Text = "x0"
        Me.lblRamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSoBamount
        '
        Me.lblSoBamount.BackColor = System.Drawing.Color.Transparent
        Me.lblSoBamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoBamount.ForeColor = System.Drawing.Color.White
        Me.lblSoBamount.Location = New System.Drawing.Point(1029, 592)
        Me.lblSoBamount.Name = "lblSoBamount"
        Me.lblSoBamount.Size = New System.Drawing.Size(156, 39)
        Me.lblSoBamount.TabIndex = 21
        Me.lblSoBamount.Text = "x0"
        Me.lblSoBamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAZamount
        '
        Me.lblAZamount.BackColor = System.Drawing.Color.Transparent
        Me.lblAZamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAZamount.ForeColor = System.Drawing.Color.White
        Me.lblAZamount.Location = New System.Drawing.Point(1029, 521)
        Me.lblAZamount.Name = "lblAZamount"
        Me.lblAZamount.Size = New System.Drawing.Size(197, 39)
        Me.lblAZamount.TabIndex = 20
        Me.lblAZamount.Text = "x0"
        Me.lblAZamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHHamount
        '
        Me.lblHHamount.BackColor = System.Drawing.Color.Transparent
        Me.lblHHamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHHamount.ForeColor = System.Drawing.Color.White
        Me.lblHHamount.Location = New System.Drawing.Point(1029, 450)
        Me.lblHHamount.Name = "lblHHamount"
        Me.lblHHamount.Size = New System.Drawing.Size(205, 39)
        Me.lblHHamount.TabIndex = 19
        Me.lblHHamount.Text = "x0"
        Me.lblHHamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKSamount
        '
        Me.lblKSamount.BackColor = System.Drawing.Color.Transparent
        Me.lblKSamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKSamount.ForeColor = System.Drawing.Color.White
        Me.lblKSamount.Location = New System.Drawing.Point(1029, 369)
        Me.lblKSamount.Name = "lblKSamount"
        Me.lblKSamount.Size = New System.Drawing.Size(188, 39)
        Me.lblKSamount.TabIndex = 18
        Me.lblKSamount.Text = "x0"
        Me.lblKSamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblACamount
        '
        Me.lblACamount.BackColor = System.Drawing.Color.Transparent
        Me.lblACamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACamount.ForeColor = System.Drawing.Color.White
        Me.lblACamount.Location = New System.Drawing.Point(1029, 295)
        Me.lblACamount.Name = "lblACamount"
        Me.lblACamount.Size = New System.Drawing.Size(181, 39)
        Me.lblACamount.TabIndex = 17
        Me.lblACamount.Text = "x0"
        Me.lblACamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ACtimer
        '
        Me.ACtimer.Interval = 1000
        '
        'KStimer
        '
        Me.KStimer.Interval = 1000
        '
        'HHtimer
        '
        Me.HHtimer.Interval = 1000
        '
        'AZtimer
        '
        Me.AZtimer.Interval = 1000
        '
        'SoBtimer
        '
        Me.SoBtimer.Interval = 1000
        '
        'Rtimer
        '
        Me.Rtimer.Interval = 1000
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1920, 1061)
        Me.Controls.Add(Me.lblRamount)
        Me.Controls.Add(Me.lblSoBamount)
        Me.Controls.Add(Me.lblAZamount)
        Me.Controls.Add(Me.lblHHamount)
        Me.Controls.Add(Me.lblKSamount)
        Me.Controls.Add(Me.lblACamount)
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
    Friend WithEvents lblRamount As Label
    Friend WithEvents lblSoBamount As Label
    Friend WithEvents lblAZamount As Label
    Friend WithEvents lblHHamount As Label
    Friend WithEvents lblKSamount As Label
    Friend WithEvents lblACamount As Label
    Friend WithEvents ACtimer As Timer
    Friend WithEvents KStimer As Timer
    Friend WithEvents HHtimer As Timer
    Friend WithEvents AZtimer As Timer
    Friend WithEvents SoBtimer As Timer
    Friend WithEvents Rtimer As Timer
End Class
