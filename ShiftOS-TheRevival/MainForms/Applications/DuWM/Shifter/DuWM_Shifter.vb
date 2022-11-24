Public Class DuWM_Shifter
    Private PrevHeight As Integer = Height
    Private PrevWidth As Integer = Width
    Private FeatureGap As Integer = 450 - 400
    Private ChildFeature As String

    Private Sub Shifter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lst_Features_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles lst_Features.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
        End If
        Dim sf As New StringFormat
        Using b As New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(lst_Features.GetItemText(lst_Features.Items(e.Index)), e.Font, b, e.Bounds, sf)
        End Using
        e.DrawFocusRectangle()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Close()
    End Sub

    Private Sub DuWM_Shifter_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim WidthRatio As Double = (Width / PrevWidth)
        Dim HeightRatio As Double = (Height / PrevHeight)
        lst_Features.Height = Height - FeatureGap
        PrevHeight = Height
        PrevWidth = Width
    End Sub

    Private Sub lst_Features_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Features.SelectedIndexChanged
        If lst_Features.SelectedItem = ChildFeature Then

        Else
            Select Case lst_Features.SelectedItem
                Case "Desktop"
                    Dim Shifter_Desktop As New DuWM_Shifter_Desktop
                    Shifter_Desktop.Size = pnl_Content.Size
                    ChildFeature = "Desktop"
                    pnl_Content.Controls.Clear()
                    pnl_Content.Controls.Add(Shifter_Desktop)
                Case "About"
                    ChildFeature = "About"
                    Dim Shifter_About As New DuWM_Shifter_About
                    Shifter_About.Size = pnl_Content.Size
                    pnl_Content.Controls.Clear()
                    pnl_Content.Controls.Add(Shifter_About)
            End Select
        End If
    End Sub

    Private Sub btn_Apply_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case lst_Features.SelectedItem
            Case "Desktop"
                Desktop.BackColor = DuWM_Shifter_Configs.DesktopBackColor
        End Select
    End Sub
End Class