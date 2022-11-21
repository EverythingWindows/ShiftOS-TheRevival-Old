Module DesktopManager
    Public Sub StartG()
        Desktop.Show()
        Desktop.FormBorderStyle = FormBorderStyle.None
        Desktop.WindowState = FormWindowState.Maximized
        Desktop.TopMost = False
        IsConsoleParent = False
        Console.Close()
        WindowManagerChoose()
        Cursor.Show()
    End Sub

    Public Sub StopG()
        DuWM_CurrentProcess = 0
        Strings.ProcessID(0) = 0
        Strings.ProcessID(1) = 0
        Cursor.Hide()
        IsConsoleParent = True
        Console.Show()
        Desktop.Close()
    End Sub

    Public Sub WindowManagerChoose()
        Select Case Strings.ComputerInfo(7)
            Case 1
                DuWM_Initiate()
        End Select
    End Sub
End Module
