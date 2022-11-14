Module Com_05tray
    Public Sub _05tray()
        Dim TempCP As Integer = Convert.ToInt32(Strings.ComputerInfo(2))
        TempCP = TempCP + 50
        Strings.ComputerInfo(2) = Convert.ToString(TempCP)
    End Sub
End Module
