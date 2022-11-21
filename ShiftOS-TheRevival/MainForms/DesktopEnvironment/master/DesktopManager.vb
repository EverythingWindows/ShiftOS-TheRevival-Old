Module DesktopManager
    Public Sub StartX()
        Desktop.Show()
        Desktop.FormBorderStyle = FormBorderStyle.None
        Desktop.WindowState = FormWindowState.Maximized
        Desktop.TopMost = False
        IsConsoleParent = False
        OnlyOne = True
        Console.Close()
        Cursor.Show()
    End Sub

    Public Sub StopX()
        Desktop.Close()
        Cursor.Hide()
        Console_Full()
        IsConsoleParent = True
    End Sub
End Module
