Public Class Light
    Inherits PictureBox
    Dim l As Boolean
    Dim p As Boolean
    Dim r, c As Integer

    Public Sub New()
        Me.Size = New Size(75, 75)
        Me.SizeMode = PictureBoxSizeMode.StretchImage
        Me.Image = Image.FromFile("unlit.png")
        Me.lit = False
        Me.picked = False
    End Sub
    Public Property lit As Boolean
        Get
            Return l
        End Get
        Set(value As Boolean)
            l = value
        End Set
    End Property
    Public Property picked As Boolean
        Get
            Return p
        End Get
        Set(value As Boolean)
            p = value
        End Set
    End Property
    Public Property row As Integer
        Get
            Return r
        End Get
        Set(value As Integer)
            r = value
        End Set
    End Property
    Public Property column As Integer
        Get
            Return c
        End Get
        Set(value As Integer)
            c = value
        End Set
    End Property

    Public Sub flip()
        If Me.lit = True Then
            Me.lit = False
            Me.Image = Image.FromFile("unlit.png")
        Else
            Me.lit = False
            Me.Image = Image.FromFile("lit.png")
        End If
    End Sub
End Class
