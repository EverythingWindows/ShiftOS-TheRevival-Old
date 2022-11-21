Imports System.Threading

Module DesktopManager
    Public IsStartG As Boolean

    Public Sub StartG()
        IsStartG = True
        Desktop.Show()
        Desktop.FormBorderStyle = FormBorderStyle.None
        Desktop.WindowState = FormWindowState.Maximized
        Desktop.TopMost = False
        IsConsoleParent = False
        Console.Dispose()
        WindowManagerChoose()
        Cursor.Show()
    End Sub

    Public Sub StopG()
        IsStartG = False
        'MsgBox("IsConsoleParent should be true!")
        IsConsoleParent = True
        ''MsgBox("PID 0 0")
        'Strings.ProcessID(0) = 0
        ''MsgBox("PID 1 0")
        'Strings.ProcessID(1) = 0
        TerminateWindowApps()
        'MsgBox("Hide!")
        Cursor.Hide()
        MsgBox("this is not a bug, this is a feature") 'Use this messagebox to hold Console to stay open, because removing this line closes Console all together for some reason
        Console.Show()
        'MsgBox("ADIOS!")
        Desktop.Hide()
    End Sub

    Public Sub TerminateWindowApps()
        Dim MaxPID As Integer = 0
        Do
            If MaxPID = 2 Then
                Exit Do
            Else
                Strings.ProcessID(MaxPID) = 0
                MaxPID = MaxPID + 1
            End If
        Loop
    End Sub

    Public Sub WindowManagerChoose()
        Select Case Strings.ComputerInfo(7)
            Case 1
                DuWM_Initiate()
        End Select
    End Sub
End Module
