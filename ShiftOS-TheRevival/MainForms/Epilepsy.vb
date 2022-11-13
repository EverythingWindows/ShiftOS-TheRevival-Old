Public Class Epilepsy
    Dim AutoClosed As Integer = 0

    Private Sub Epilepsy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoClose.Start()
    End Sub

    Private Sub AutoClose_Tick(sender As Object, e As EventArgs) Handles AutoClose.Tick
        AutoClosed = AutoClosed + 1
        Select Case AutoClosed
            Case 6, 18, 30, 42, 54, 66, 78, 90, 102, 114
                Label1.Visible = False
            Case 12, 24, 36, 48, 60, 72, 84, 96, 108, 120
                Label1.Visible = True
            Case 125
                Strings.IsFree = False
                Strings.OnceInfo(6) = "story"
                IntroStory.Show()
                ShiftOSMenu.Close()
                NewGameMode()
                Close()
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class