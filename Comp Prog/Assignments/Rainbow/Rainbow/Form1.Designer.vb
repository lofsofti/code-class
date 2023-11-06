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
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnOrange = New System.Windows.Forms.Button()
        Me.btnYellow = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnIndigo = New System.Windows.Forms.Button()
        Me.btnViolet = New System.Windows.Forms.Button()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRed
        '
        Me.btnRed.BackColor = System.Drawing.Color.Red
        Me.btnRed.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRed.ForeColor = System.Drawing.Color.Black
        Me.btnRed.Location = New System.Drawing.Point(12, 12)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(102, 44)
        Me.btnRed.TabIndex = 0
        Me.btnRed.Text = "Red"
        Me.btnRed.UseVisualStyleBackColor = False
        '
        'btnOrange
        '
        Me.btnOrange.BackColor = System.Drawing.Color.Orange
        Me.btnOrange.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrange.ForeColor = System.Drawing.Color.DimGray
        Me.btnOrange.Location = New System.Drawing.Point(12, 62)
        Me.btnOrange.Name = "btnOrange"
        Me.btnOrange.Size = New System.Drawing.Size(102, 44)
        Me.btnOrange.TabIndex = 1
        Me.btnOrange.Text = "Orange"
        Me.btnOrange.UseVisualStyleBackColor = False
        '
        'btnYellow
        '
        Me.btnYellow.BackColor = System.Drawing.Color.Yellow
        Me.btnYellow.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYellow.ForeColor = System.Drawing.Color.Gray
        Me.btnYellow.Location = New System.Drawing.Point(12, 112)
        Me.btnYellow.Name = "btnYellow"
        Me.btnYellow.Size = New System.Drawing.Size(102, 44)
        Me.btnYellow.TabIndex = 2
        Me.btnYellow.Text = "Yellow"
        Me.btnYellow.UseVisualStyleBackColor = False
        '
        'btnGreen
        '
        Me.btnGreen.BackColor = System.Drawing.Color.Green
        Me.btnGreen.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGreen.ForeColor = System.Drawing.Color.DarkGray
        Me.btnGreen.Location = New System.Drawing.Point(12, 162)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(102, 44)
        Me.btnGreen.TabIndex = 3
        Me.btnGreen.Text = "Green"
        Me.btnGreen.UseVisualStyleBackColor = False
        '
        'btnBlue
        '
        Me.btnBlue.BackColor = System.Drawing.Color.Blue
        Me.btnBlue.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlue.ForeColor = System.Drawing.Color.Silver
        Me.btnBlue.Location = New System.Drawing.Point(12, 212)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(102, 44)
        Me.btnBlue.TabIndex = 4
        Me.btnBlue.Text = "Blue"
        Me.btnBlue.UseVisualStyleBackColor = False
        '
        'btnIndigo
        '
        Me.btnIndigo.BackColor = System.Drawing.Color.Indigo
        Me.btnIndigo.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIndigo.ForeColor = System.Drawing.Color.LightGray
        Me.btnIndigo.Location = New System.Drawing.Point(12, 262)
        Me.btnIndigo.Name = "btnIndigo"
        Me.btnIndigo.Size = New System.Drawing.Size(102, 44)
        Me.btnIndigo.TabIndex = 5
        Me.btnIndigo.Text = "Indigo"
        Me.btnIndigo.UseVisualStyleBackColor = False
        '
        'btnViolet
        '
        Me.btnViolet.BackColor = System.Drawing.Color.Violet
        Me.btnViolet.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViolet.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnViolet.Location = New System.Drawing.Point(12, 312)
        Me.btnViolet.Name = "btnViolet"
        Me.btnViolet.Size = New System.Drawing.Size(102, 44)
        Me.btnViolet.TabIndex = 6
        Me.btnViolet.Text = "Violet"
        Me.btnViolet.UseVisualStyleBackColor = False
        '
        'lblColor
        '
        Me.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColor.Font = New System.Drawing.Font("MV Boli", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(181, 112)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(158, 144)
        Me.lblColor.TabIndex = 7
        Me.lblColor.Text = "Color"
        Me.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 370)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.btnViolet)
        Me.Controls.Add(Me.btnIndigo)
        Me.Controls.Add(Me.btnBlue)
        Me.Controls.Add(Me.btnGreen)
        Me.Controls.Add(Me.btnYellow)
        Me.Controls.Add(Me.btnOrange)
        Me.Controls.Add(Me.btnRed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRed As Button
    Friend WithEvents btnOrange As Button
    Friend WithEvents btnYellow As Button
    Friend WithEvents btnGreen As Button
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnIndigo As Button
    Friend WithEvents btnViolet As Button
    Friend WithEvents lblColor As Label
End Class
