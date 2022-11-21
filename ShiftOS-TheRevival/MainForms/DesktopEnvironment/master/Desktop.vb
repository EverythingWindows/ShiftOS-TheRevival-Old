Public Class Desktop
    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Desktop_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.T AndAlso Keys.Control Then
            MsgBox("dangit")
            DuWM_FirstWindowSet(Console)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'DuWM_FirstWindowSet(Console)
    End Sub
End Class