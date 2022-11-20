Public Class Shifter
    Public DuWM_PID As Integer                          'DuWM Process ID

    Private Sub Shifter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DuWM_Tick(sender As Object, e As EventArgs) 
        If Strings.ProcessID(DuWM_PID) = 0 Then
            Close()
        End If
    End Sub
End Class