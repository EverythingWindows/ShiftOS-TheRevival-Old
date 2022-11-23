Public Class DuWM_Shifter_Desktop
    Private Sub DuWM_Shifter_Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckAvailability()
    End Sub

    Private Sub CheckAvailability()

    End Sub

    Private Sub cmb_DesktopColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_DesktopColor.SelectedIndexChanged
        Select Case cmb_DesktopColor.SelectedItem
            Case "Black"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Black
            Case "White"
                DuWM_Shifter_Configs.DesktopBackColor = Color.White
            Case "Light Gray"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Silver
            Case "Dark Gray"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Gray
        End Select
    End Sub
End Class
