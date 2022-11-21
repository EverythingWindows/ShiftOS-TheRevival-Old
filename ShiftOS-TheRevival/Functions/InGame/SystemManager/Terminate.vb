Module Terminate
    Public Sub TerminateShiftOS()
        If IsStartG = True Then
            NewLine("Stopping the Window Manager...")
            StopG()
        End If
        Console_Full()
        If Strings.OnceInfo(6) = "story" Then
            NewLine("Saving game...")
            SaveGame()
        End If
        Cursor.Show()
        NewLine("Shutting down...")
        ShiftOSMenu.Show()
        If IsStartG = False Then
            Console.Close()
        End If
    End Sub
End Module
