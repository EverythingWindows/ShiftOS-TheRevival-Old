Public Class DuWM_Shifter_Console
    Private Sub DuWM_Shifter_Console_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_ConsoleExample.Font = Console.TextBox1.Font
        cmb_ConsoleFont.Text = GUISCustomizations.GUIConsoleFont.Name
        cmb_ConsoleFontSize.Text = GUISCustomizations.GUIConsoleFont.Size
    End Sub

    Private Sub cmb_ConsoleFont_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cmb_ConsoleFont.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
        End If
        Dim sf As New StringFormat
        Using b As New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(cmb_ConsoleFont.GetItemText(cmb_ConsoleFont.Items(e.Index)), e.Font, b, e.Bounds, sf)
        End Using
        e.DrawFocusRectangle()
    End Sub

    Private Sub cmb_ConsoleFontSize_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cmb_ConsoleFontSize.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
        End If
        Dim sf As New StringFormat
        Using b As New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(cmb_ConsoleFontSize.GetItemText(cmb_ConsoleFontSize.Items(e.Index)), e.Font, b, e.Bounds, sf)
        End Using
        e.DrawFocusRectangle()
    End Sub

    Private Sub cmb_ConsoleFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ConsoleFont.SelectedIndexChanged
        Select Case cmb_ConsoleFont.SelectedItem
            Case "Consolas"
                txt_ConsoleExample.Font = New Font("Consolas", txt_ConsoleExample.Font.Size)
            Case "Courier New"
                txt_ConsoleExample.Font = New Font("Courier New", txt_ConsoleExample.Font.Size)
            Case "Lucida Console"
                txt_ConsoleExample.Font = New Font("Lucida Console", txt_ConsoleExample.Font.Size)
        End Select
        DuWM_Shifter_Configs.ConsoleFont = txt_ConsoleExample.Font
    End Sub

    Private Sub cmb_ConsoleFontSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ConsoleFontSize.SelectedIndexChanged
        txt_ConsoleExample.Font = New Font(txt_ConsoleExample.Font.Name, cmb_ConsoleFontSize.SelectedItem)
        DuWM_Shifter_Configs.ConsoleFont = txt_ConsoleExample.Font
    End Sub
End Class
