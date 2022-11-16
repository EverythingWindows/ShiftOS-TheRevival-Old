Module DesktopManager
    Public Sub StartX()
        Desktop.Show()
        Desktop.TopMost = False
        Desktop.FormBorderStyle = FormBorderStyle.None
        Desktop.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub StopX()
        Desktop.Close()
    End Sub
End Module
