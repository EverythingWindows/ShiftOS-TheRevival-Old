Public Class DuWM_WindowContainer
    Public ChildForm As Form
    Public DuWM_PID As Integer

    Private Sub DuWM_WindowContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DuWM_WMCheck_Tick(sender As Object, e As EventArgs) Handles DuWM_WMCheck.Tick
        If Strings.ProcessID(DuWM_PID) = 0 Then
            Close()
        End If
    End Sub
End Class