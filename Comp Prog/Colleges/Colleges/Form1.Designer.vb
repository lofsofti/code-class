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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUmich = New System.Windows.Forms.Button()
        Me.btnMsu = New System.Windows.Forms.Button()
        Me.btnKettering = New System.Windows.Forms.Button()
        Me.btnMtec = New System.Windows.Forms.Button()
        Me.btnGvsu = New System.Windows.Forms.Button()
        Me.lblMascot = New System.Windows.Forms.Label()
        Me.lblAlum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("NSimSun", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Colleges"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUmich
        '
        Me.btnUmich.BackColor = System.Drawing.Color.Blue
        Me.btnUmich.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUmich.ForeColor = System.Drawing.Color.Yellow
        Me.btnUmich.Location = New System.Drawing.Point(90, 116)
        Me.btnUmich.Name = "btnUmich"
        Me.btnUmich.Size = New System.Drawing.Size(260, 71)
        Me.btnUmich.TabIndex = 1
        Me.btnUmich.Text = "University of Michigan"
        Me.btnUmich.UseVisualStyleBackColor = False
        '
        'btnMsu
        '
        Me.btnMsu.BackColor = System.Drawing.Color.DarkGreen
        Me.btnMsu.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMsu.ForeColor = System.Drawing.Color.White
        Me.btnMsu.Location = New System.Drawing.Point(494, 116)
        Me.btnMsu.Name = "btnMsu"
        Me.btnMsu.Size = New System.Drawing.Size(260, 71)
        Me.btnMsu.TabIndex = 2
        Me.btnMsu.Text = "Michigan State University"
        Me.btnMsu.UseVisualStyleBackColor = False
        '
        'btnKettering
        '
        Me.btnKettering.BackColor = System.Drawing.Color.DarkBlue
        Me.btnKettering.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKettering.ForeColor = System.Drawing.Color.Gold
        Me.btnKettering.Location = New System.Drawing.Point(289, 193)
        Me.btnKettering.Name = "btnKettering"
        Me.btnKettering.Size = New System.Drawing.Size(260, 71)
        Me.btnKettering.TabIndex = 3
        Me.btnKettering.Text = "Kettering University"
        Me.btnKettering.UseVisualStyleBackColor = False
        '
        'btnMtec
        '
        Me.btnMtec.BackColor = System.Drawing.Color.Gold
        Me.btnMtec.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMtec.ForeColor = System.Drawing.Color.Black
        Me.btnMtec.Location = New System.Drawing.Point(90, 270)
        Me.btnMtec.Name = "btnMtec"
        Me.btnMtec.Size = New System.Drawing.Size(260, 71)
        Me.btnMtec.TabIndex = 4
        Me.btnMtec.Text = " Michigan Technological University"
        Me.btnMtec.UseVisualStyleBackColor = False
        '
        'btnGvsu
        '
        Me.btnGvsu.BackColor = System.Drawing.Color.MediumBlue
        Me.btnGvsu.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGvsu.ForeColor = System.Drawing.Color.White
        Me.btnGvsu.Location = New System.Drawing.Point(494, 270)
        Me.btnGvsu.Name = "btnGvsu"
        Me.btnGvsu.Size = New System.Drawing.Size(260, 71)
        Me.btnGvsu.TabIndex = 5
        Me.btnGvsu.Text = "Grand Valley State University"
        Me.btnGvsu.UseVisualStyleBackColor = False
        '
        'lblMascot
        '
        Me.lblMascot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMascot.Font = New System.Drawing.Font("NSimSun", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMascot.Location = New System.Drawing.Point(84, 416)
        Me.lblMascot.Name = "lblMascot"
        Me.lblMascot.Size = New System.Drawing.Size(266, 83)
        Me.lblMascot.TabIndex = 6
        Me.lblMascot.Text = "Mascot"
        Me.lblMascot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlum
        '
        Me.lblAlum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlum.Font = New System.Drawing.Font("NSimSun", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlum.Location = New System.Drawing.Point(488, 416)
        Me.lblAlum.Name = "lblAlum"
        Me.lblAlum.Size = New System.Drawing.Size(266, 83)
        Me.lblAlum.TabIndex = 7
        Me.lblAlum.Text = "Alumni"
        Me.lblAlum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 569)
        Me.Controls.Add(Me.lblAlum)
        Me.Controls.Add(Me.lblMascot)
        Me.Controls.Add(Me.btnGvsu)
        Me.Controls.Add(Me.btnMtec)
        Me.Controls.Add(Me.btnKettering)
        Me.Controls.Add(Me.btnMsu)
        Me.Controls.Add(Me.btnUmich)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnUmich As Button
    Friend WithEvents btnMsu As Button
    Friend WithEvents btnKettering As Button
    Friend WithEvents btnMtec As Button
    Friend WithEvents btnGvsu As Button
    Friend WithEvents lblMascot As Label
    Friend WithEvents lblAlum As Label
End Class
