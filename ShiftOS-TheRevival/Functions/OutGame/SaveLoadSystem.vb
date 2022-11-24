Imports System.IO

Module SaveLoadSystem

    Public Sub NewGameMode()
        'Sets all features to 2 (Unavailable for Shiftorium) except ShiftOS Key (AvailableFeatures(11))
        Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS", True)
        Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS", True)
        Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved", True)
        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS")
        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS")
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
        Strings.AvailableFeature(21) = "2"
        Strings.AvailableFeature(22) = "2"
        '0.2.5 Features
        Strings.AvailableFeature(23) = "2"
        Strings.AvailableFeature(24) = "2"
        Strings.AvailableFeature(25) = "2"
        Strings.AvailableFeature(26) = "2"
        Strings.AvailableFeature(27) = "2"
        Strings.AvailableFeature(28) = "2"
        Strings.AvailableFeature(29) = "2"
        Strings.AvailableFeature(30) = "2"
        '0.2.6 Features
        Strings.AvailableFeature(31) = "2"
        Strings.AvailableFeature(32) = "2"
        Strings.AvailableFeature(33) = "2"
        '0.2.7 Features
        Strings.AvailableFeature(34) = "2"
        Strings.AvailableFeature(35) = "2"
        Strings.AvailableFeature(36) = "2"
        Strings.AvailableFeature(37) = "2"
        Strings.AvailableFeature(38) = "2"
        Strings.AvailableFeature(39) = "2"
        Strings.AvailableFeature(40) = "2"
        Strings.AvailableFeature(41) = "2"
    End Sub

    Public Sub FreeRoamMode()
        IsConsoleParent = True
        'Sets all features to as bought or either upgraded, Complete ShiftOS should have been like this
        Strings.ComputerInfo(0) = "shiftos"
        Strings.ComputerInfo(1) = "user"
        Strings.ComputerInfo(2) = "0"
        Strings.ComputerInfo(4) = "42"
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
        Strings.AvailableFeature(12) = "3"
        Strings.AvailableFeature(13) = "1"
        Strings.AvailableFeature(14) = "1"
        Strings.AvailableFeature(15) = "1"
        '0.2.4 Features
        Strings.AvailableFeature(16) = "1"
        Strings.AvailableFeature(17) = "1"
        Strings.AvailableFeature(18) = "1"
        Strings.AvailableFeature(19) = "1"
        Strings.AvailableFeature(20) = "1"
        Strings.AvailableFeature(21) = "1"
        Strings.AvailableFeature(22) = "1"
        '0.2.5 Features
        Strings.AvailableFeature(23) = "1"
        Strings.AvailableFeature(24) = "3"
        Strings.AvailableFeature(25) = "3"
        Strings.AvailableFeature(26) = "3"
        Strings.AvailableFeature(27) = "3"
        Strings.AvailableFeature(28) = "3"
        Strings.AvailableFeature(29) = "1"
        Strings.AvailableFeature(30) = "1"
        '0.2.6 Features
        Strings.AvailableFeature(31) = "1"
        Strings.AvailableFeature(32) = "1"
        Strings.AvailableFeature(33) = "1"
        '0.2.7 Features
        Strings.AvailableFeature(34) = "1"
        Strings.AvailableFeature(35) = "1"
        Strings.AvailableFeature(36) = "1"
        Strings.AvailableFeature(37) = "1"
        Strings.AvailableFeature(38) = "1"
        Strings.AvailableFeature(39) = "1"
        Strings.AvailableFeature(40) = "3"
        Strings.AvailableFeature(41) = "1"
    End Sub

    Public Sub GodMode()
        'Same as new game but codepoints automatically assigned to 9999 and not saved into the FS
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
        Strings.AvailableFeature(21) = "2"
        Strings.AvailableFeature(22) = "2"
        '0.2.5 Features
        Strings.AvailableFeature(23) = "2"
        Strings.AvailableFeature(24) = "2"
        Strings.AvailableFeature(25) = "2"
        Strings.AvailableFeature(26) = "2"
        Strings.AvailableFeature(27) = "2"
        Strings.AvailableFeature(28) = "2"
        Strings.AvailableFeature(29) = "2"
        Strings.AvailableFeature(30) = "2"
        '0.2.6 Features
        Strings.AvailableFeature(31) = "2"
        Strings.AvailableFeature(32) = "2"
        Strings.AvailableFeature(33) = "2"
        '0.2.7 Features
        Strings.AvailableFeature(34) = "2"
        Strings.AvailableFeature(35) = "2"
        Strings.AvailableFeature(36) = "2"
        Strings.AvailableFeature(37) = "2"
        Strings.AvailableFeature(38) = "2"
        Strings.AvailableFeature(39) = "2"
        Strings.AvailableFeature(40) = "2"
        Strings.AvailableFeature(41) = "2"
    End Sub

    Public Sub SaveGame()
        If Strings.OnceInfo(6) = "story" Then
            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\ComputerInfo.sos", Strings.ComputerInfo)
            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\AvailableFeature.sos", Strings.AvailableFeature)
            If Strings.AvailableFeature(35) Then
                Select Case Strings.ComputerInfo(7)
                    Case 1
                        Dim DesktopColor As Integer = GUISCustomizations.DesktopColor.ToArgb()
                        File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\Shifter_Desktop.sos", DesktopColor.ToString)
                End Select
            End If
        End If
    End Sub

    Public Sub LoadGame()
        If Strings.OnceInfo(6) = "story" Then
            Strings.ComputerInfo = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\ComputerInfo.sos")
            Strings.AvailableFeature = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\AvailableFeature.sos")
            If Strings.AvailableFeature(35) Then
                Select Case Strings.ComputerInfo(7)
                    Case 1
                        Dim DesktopColor As Integer
                        If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\Shifter_Desktop.sos") = True Then
                            DesktopColor = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\Shifter_Desktop.sos")
                            GUISCustomizations.DesktopColor = Color.FromArgb(DesktopColor)
                        Else
                            GUISCustomizations.DesktopColor = Color.Black
                        End If
                End Select
            End If
        End If
    End Sub
End Module