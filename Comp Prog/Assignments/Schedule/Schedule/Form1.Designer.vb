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
        Me.lblSchedule = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblTeach = New System.Windows.Forms.Label()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSchedule
        '
        Me.lblSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSchedule.Font = New System.Drawing.Font("MS Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchedule.ForeColor = System.Drawing.Color.Red
        Me.lblSchedule.Location = New System.Drawing.Point(113, 12)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(180, 35)
        Me.lblSchedule.TabIndex = 0
        Me.lblSchedule.Text = "Schedule"
        Me.lblSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(30, 12)
        Me.TrackBar1.Maximum = 6
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 314)
        Me.TrackBar1.TabIndex = 1
        Me.TrackBar1.Value = 1
        '
        'lblHour
        '
        Me.lblHour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHour.Font = New System.Drawing.Font("MS Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHour.ForeColor = System.Drawing.Color.Red
        Me.lblHour.Location = New System.Drawing.Point(113, 108)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(180, 35)
        Me.lblHour.TabIndex = 2
        Me.lblHour.Text = "1st Hour"
        Me.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClass
        '
        Me.lblClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClass.Font = New System.Drawing.Font("MS Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.ForeColor = System.Drawing.Color.Red
        Me.lblClass.Location = New System.Drawing.Point(113, 182)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(180, 35)
        Me.lblClass.TabIndex = 3
        Me.lblClass.Text = "French 2"
        Me.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTeach
        '
        Me.lblTeach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTeach.Font = New System.Drawing.Font("MS Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeach.ForeColor = System.Drawing.Color.Red
        Me.lblTeach.Location = New System.Drawing.Point(113, 252)
        Me.lblTeach.Name = "lblTeach"
        Me.lblTeach.Size = New System.Drawing.Size(180, 35)
        Me.lblTeach.TabIndex = 4
        Me.lblTeach.Text = "Mr.LaBelle"
        Me.lblTeach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(383, 356)
        Me.Controls.Add(Me.lblTeach)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblHour)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.lblSchedule)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSchedule As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents lblHour As Label
    Friend WithEvents lblClass As Label
    Friend WithEvents lblTeach As Label
End Class
