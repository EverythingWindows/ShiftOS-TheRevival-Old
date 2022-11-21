Public Class DuWM_WindowContainer
    Public ChildForm As Form
    Public DuWM_PID As Integer

    Private Sub DuWM_WindowContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DuWM_WMCheck.Start()
        DuWM_ChildSize.Start()
    End Sub

    Private Sub DuWM_WMCheck_Tick(sender As Object, e As EventArgs) Handles DuWM_WMCheck.Tick
        If ChildForm.Visible = False Then
            Strings.ProcessID(DuWM_PID) = 0
            Close()
        End If
        If Strings.ProcessID(DuWM_PID) = 0 Then
            Close()
        End If
    End Sub

    Private Sub ChildSize_Tick(sender As Object, e As EventArgs) Handles DuWM_ChildSize.Tick
        ChildForm.Size = DuWM_ContainerPanel.Size
    End Sub
End Class