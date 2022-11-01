Public Class TerminalPrompt
    Private Sub Terminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
        If Strings.GameState(0) = "Free" Then
            Strings.ComputerInfo(0) = "shiftos"
            Strings.ComputerInfo(1) = "user"
            PrintPrompt()
        End If
    End Sub

    Public Sub PrintPrompt()
        If TextBox1.Text = Nothing Then
            If Strings.OnceInfo(0) = "No" Then
                TextBox1.Text = "root@" & Strings.ComputerInfo(0) & " #> "
            Else
                TextBox1.Text = Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> "
            End If
        Else
            If Strings.OnceInfo(0) = "No" Then
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "root@" & Strings.ComputerInfo(0) & " #> "
            Else
                TextBox1.Text = TextBox1.Text & Environment.NewLine & Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> "
            End If
        End If
    End Sub
End Class