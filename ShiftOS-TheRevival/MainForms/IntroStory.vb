Public Class IntroStory
    Dim TimerDisplay As Integer = 1
    Private Sub IntroStory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
        OpacityPlay.Start()
    End Sub

    Private Sub OpacityPlay_Tick(sender As Object, e As EventArgs) Handles OpacityPlay.Tick
        Select Case TimerDisplay
            Case 1, 9, 17, 25
                BackColor = Color.White
                Label1.ForeColor = Color.Black
                Visible = True
                TimerDisplay = TimerDisplay + 1
            Case 3, 7, 11, 15, 19, 23, 27
                Visible = False
                TimerDisplay = TimerDisplay + 1
            Case 5, 13, 21
                BackColor = Color.Black
                Label1.ForeColor = Color.White
                Visible = True
                TimerDisplay = TimerDisplay + 1
            Case 29
                BackColor = Color.Black
                Label1.ForeColor = Color.Black
                Visible = True
                Opacity = 0.1
                TimerDisplay = 30
            Case 30
                If Opacity = 1 Then
                    Strings.ComputerInfo(3) = "0"
                    Strings.IsFree = False
                    Console.Show()
                    Close()
                Else
                    Opacity = Opacity + 0.05
                End If
            Case Else
                TimerDisplay = TimerDisplay + 1
        End Select
    End Sub
End Class