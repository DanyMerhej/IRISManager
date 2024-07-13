Public Class ColorProgressBar
    Inherits ProgressBar

    Private _progressBarColor As Color = Color.FromArgb(20, 237, 251)

    Public Sub New()
        SetStyle(ControlStyles.UserPaint Or
                 ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    Public Property ProgressBarColor As Color
        Get
            Return _progressBarColor
        End Get
        Set(value As Color)
            _progressBarColor = value
            ' Redraw the control when the color changes
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        Dim progressBarRectangle As Rectangle = New Rectangle(0, 0, Width, Height)

        ' Draw the background of the progress bar
        g.FillRectangle(SystemBrushes.Control, progressBarRectangle)

        ' Draw the progress bar with the specified color
        progressBarRectangle.Width = CInt(progressBarRectangle.Width * (CDbl(Value) / Maximum)) - 1
        g.FillRectangle(New SolidBrush(_progressBarColor), 1, 1, progressBarRectangle.Width, Height - 1)

        ' Draw the progress bar border
        g.DrawRectangle(SystemPens.ControlDark, 0, 0, Width - 1, Height - 1)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        ' Redraw the control when the form is resized
        Me.Invalidate()
    End Sub
End Class
