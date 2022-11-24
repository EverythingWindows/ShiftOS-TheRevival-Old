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
        IsConsoleParent = True
        TerminateWindowApps()
        Cursor.Hide()
        If Strings.OnceInfo(6) = "story" Then
            SaveGame()
        End If
        MsgBox("this is not a bug, this is a feature") 'Use this messagebox to hold Console to stay open, because removing this line closes Console all together for some reason
        Console.Show()
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
