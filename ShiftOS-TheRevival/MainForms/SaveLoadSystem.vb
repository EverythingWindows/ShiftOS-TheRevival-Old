Imports System.IO

Module SaveLoadSystem

    Public Sub NewGameMode()
        Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS", True)
        Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved", True)
        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS")
        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved")
        Strings.ComputerInfo(0) = "shiftos"
        Strings.ComputerInfo(1) = "user"
        Strings.ComputerInfo(2) = "0"
        Strings.ComputerInfo(4) = "0"
        Strings.AvailableFeature(0) = "2"
        Strings.AvailableFeature(1) = "2"
        Strings.AvailableFeature(2) = "2"
        Strings.AvailableFeature(3) = "2"
        Strings.AvailableFeature(4) = "2"
        Strings.AvailableFeature(5) = "2"
        Strings.AvailableFeature(6) = "2"
        Strings.AvailableFeature(7) = "2"
        Strings.AvailableFeature(8) = "2"
        Strings.AvailableFeature(9) = "2"
        Strings.AvailableFeature(10) = "2"
        Strings.AvailableFeature(11) = "0"
        Strings.AvailableFeature(12) = "2"
        Strings.AvailableFeature(13) = "2"
        Strings.AvailableFeature(14) = "2"
        Strings.AvailableFeature(15) = "2"
        '0.2.4 Features
        Strings.AvailableFeature(16) = "2"
        Strings.AvailableFeature(17) = "2"
        Strings.AvailableFeature(18) = "2"
        Strings.AvailableFeature(19) = "2"
        Strings.AvailableFeature(20) = "2"
    End Sub

    Public Sub FreeRoamMode()
        Strings.ComputerInfo(0) = "shiftos"
        Strings.ComputerInfo(1) = "user"
        Strings.ComputerInfo(2) = "0"
        Strings.ComputerInfo(4) = "19"
        Strings.AvailableFeature(0) = "1"
        Strings.AvailableFeature(1) = "1"
        Strings.AvailableFeature(2) = "1"
        Strings.AvailableFeature(3) = "1"
        Strings.AvailableFeature(4) = "1"
        Strings.AvailableFeature(5) = "3"
        Strings.AvailableFeature(6) = "3"
        Strings.AvailableFeature(7) = "3"
        Strings.AvailableFeature(8) = "1"
        Strings.AvailableFeature(9) = "1"
        Strings.AvailableFeature(10) = "1"
        Strings.AvailableFeature(11) = "1"
        Strings.AvailableFeature(12) = "1"
        Strings.AvailableFeature(13) = "1"
        Strings.AvailableFeature(14) = "1"
        Strings.AvailableFeature(15) = "1"
        '0.2.4 Features
        Strings.AvailableFeature(16) = "1"
        Strings.AvailableFeature(17) = "1"
        Strings.AvailableFeature(18) = "1"
        Strings.AvailableFeature(19) = "1"
        Strings.AvailableFeature(20) = "1"
    End Sub

    Public Sub GodMode()
        Strings.ComputerInfo(0) = "shiftos"
        Strings.ComputerInfo(1) = "user"
        Strings.ComputerInfo(2) = 9999
        Strings.ComputerInfo(4) = "0"
        Strings.AvailableFeature(0) = "2"
        Strings.AvailableFeature(1) = "2"
        Strings.AvailableFeature(2) = "2"
        Strings.AvailableFeature(3) = "2"
        Strings.AvailableFeature(4) = "2"
        Strings.AvailableFeature(5) = "2"
        Strings.AvailableFeature(6) = "2"
        Strings.AvailableFeature(7) = "2"
        Strings.AvailableFeature(8) = "2"
        Strings.AvailableFeature(9) = "2"
        Strings.AvailableFeature(10) = "2"
        Strings.AvailableFeature(11) = "0"
        Strings.AvailableFeature(12) = "2"
        Strings.AvailableFeature(14) = "2"
        Strings.AvailableFeature(15) = "2"
        '0.2.4 Features
        Strings.AvailableFeature(16) = "2"
        Strings.AvailableFeature(17) = "2"
        Strings.AvailableFeature(18) = "2"
        Strings.AvailableFeature(19) = "2"
        Strings.AvailableFeature(20) = "2"
    End Sub

    Public Sub SaveGame()
        If Strings.OnceInfo(6) = "story" Then
            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\ComputerInfo.sos", Strings.ComputerInfo)
            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\AvailableFeature.sos", Strings.AvailableFeature)
        End If
    End Sub

    Public Sub LoadGame()
        If Strings.OnceInfo(6) = "story" Then
            Strings.ComputerInfo = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\ComputerInfo.sos")
            Strings.AvailableFeature = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\AvailableFeature.sos")
        End If
    End Sub
End Module
