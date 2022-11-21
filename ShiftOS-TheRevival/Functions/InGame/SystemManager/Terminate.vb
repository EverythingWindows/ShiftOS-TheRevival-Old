Module Terminate
    Public Sub TerminateShiftOS()
        NewLine("Stopping the Window Manager...")
        StopX()
        Console_Full()
        If Strings.OnceInfo(6) = "story" Then
            NewLine("Saving game...")
            SaveGame()
        End If
        Cursor.Show()
        NewLine("Shutting down...")
        ShiftOSMenu.Show()
        Console.Close()
        Shifter.Close()
    End Sub
End Module
