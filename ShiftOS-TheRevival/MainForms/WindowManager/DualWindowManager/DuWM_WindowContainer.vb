Public Class DuWM_WindowContainer
    Public ChildForm As New Form
    Public DuWM_PID As Integer

    Private Sub DuWM_WindowContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DuWM_WMCheck.Start()
        DuWM_ChildSize.Start()
        DuWM_LayoutCheck.Start()
    End Sub

    Private Sub DuWM_WMCheck_Tick(sender As Object, e As EventArgs) Handles DuWM_WMCheck.Tick
        If ChildForm.Visible = False Then
            Strings.ProcessID(DuWM_PID) = 0
        End If
        If Strings.ProcessID(DuWM_PID) = 0 Then
            DuWM_CurrentProcess = DuWM_CurrentProcess - 1
            DuWM_ChangeLayout = True
            DuWM_WMCheck.Stop()
            Close()
        End If
    End Sub

    Private Sub ChildSize_Tick(sender As Object, e As EventArgs) Handles DuWM_ChildSize.Tick
        ChildForm.Size = DuWM_ContainerPanel.Size
    End Sub

    Private Sub DuWM_LayoutCheck_Tick(sender As Object, e As EventArgs) Handles DuWM_LayoutCheck.Tick
        If DuWM_ChangeLayout = True Then
            Select Case DuWM_CurrentProcess
                Case 1
                    Height = Desktop.Height - 20
                    Width = Desktop.Width - 20
                    Location = New Point(10, 10)
                Case 2
                    Select Case DuWM_PID
                        Case 0
                            Height = Desktop.Height - 20
                            Width = (Desktop.Width / 2) - 20
                            Location = New Point(10, 10)
                    End Select
            End Select
            DuWM_ChangeLayout = False
        End If
    End Sub
End Class