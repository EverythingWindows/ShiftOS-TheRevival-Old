Public Class DuWM_Shifter_About
    Private Sub DuWM_Shifter_Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_ShiftOSVersion.Text = lbl_ShiftOSVersion.Text & My.Resources.CurrentVersion
    End Sub
End Class
