Public Class DuWM_Shifter_Desktop
    Private Sub DuWM_Shifter_Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckAvailability()
    End Sub

    Private Sub cmb_DesktopColor_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cmb_DesktopColor.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
        End If
        Dim sf As New StringFormat
        Using b As New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(cmb_DesktopColor.GetItemText(cmb_DesktopColor.Items(e.Index)), e.Font, b, e.Bounds, sf)
        End Using
        e.DrawFocusRectangle()
    End Sub

    Private Sub CheckAvailability()
        If Strings.AvailableFeature(40) = 1 Then
            cmb_DesktopColor.Items.Remove("Yellow")
            cmb_DesktopColor.Items.Remove("Dark Yellow")
            cmb_DesktopColor.Items.Remove("Purple")
            cmb_DesktopColor.Items.Remove("Light Purple")
            cmb_DesktopColor.Items.Remove("Aqua")
            cmb_DesktopColor.Items.Remove("Light Aqua")
        ElseIf Strings.AvailableFeature(40) = 3 Then
            If Strings.AvailableFeature(41) = 1 Then
                'NOTHING
            Else
                'NOTHING
            End If
        Else
            cmb_DesktopColor.Items.Remove("Red")
            cmb_DesktopColor.Items.Remove("Dark Red")
            cmb_DesktopColor.Items.Remove("Green")
            cmb_DesktopColor.Items.Remove("Light Green")
            cmb_DesktopColor.Items.Remove("Blue")
            cmb_DesktopColor.Items.Remove("Dark Blue")
            cmb_DesktopColor.Items.Remove("Yellow")
            cmb_DesktopColor.Items.Remove("Dark Yellow")
            cmb_DesktopColor.Items.Remove("Purple")
            cmb_DesktopColor.Items.Remove("Light Purple")
            cmb_DesktopColor.Items.Remove("Aqua")
            cmb_DesktopColor.Items.Remove("Light Aqua")
        End If
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
            Case "Red"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Red
            Case "Dark Red"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Maroon
            Case "Green"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Green
            Case "Light Green"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Lime
            Case "Blue"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Navy
            Case "Dark Blue"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Blue
            Case "Yellow"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Yellow
            Case "Dark Yellow"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Brown
            Case "Purple"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Magenta
            Case "Light Purple"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Fuchsia
            Case "Aqua"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Aqua
            Case "Light Aqua"
                DuWM_Shifter_Configs.DesktopBackColor = Color.Cyan
        End Select
    End Sub
End Class
