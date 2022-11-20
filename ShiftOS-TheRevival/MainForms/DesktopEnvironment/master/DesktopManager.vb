Module DesktopManager
    Public Sub StartX()
        Desktop.Show()
        Desktop.TopMost = False
        Desktop.FormBorderStyle = FormBorderStyle.None
        Desktop.WindowState = FormWindowState.Maximized
        Cursor.Show()
    End Sub

    Public Sub StopX()
        Desktop.Close()
        Cursor.Hide()
        Console_Full()
    End Sub
End Module
