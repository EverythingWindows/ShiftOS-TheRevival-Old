Module SaveLoadSystem

    Public Sub NewGameMode()
        Strings.ComputerInfo(2) = "0"
        Strings.ComputerInfo(4) = "0"
        Strings.AvailableFeature(0) = "0"
        Strings.AvailableFeature(1) = "0"
        Strings.AvailableFeature(2) = "2"
        Strings.AvailableFeature(3) = "2"
        Strings.AvailableFeature(4) = "2"
        Strings.AvailableFeature(5) = "2"
        Strings.AvailableFeature(6) = "2"
        Strings.AvailableFeature(7) = "2"
        Strings.AvailableFeature(8) = "2"
        Strings.AvailableFeature(9) = "2"
        Strings.AvailableFeature(10) = "2"
    End Sub

    Public Sub FreeRoamMode()
        Strings.ComputerInfo(2) = "0"
        Strings.ComputerInfo(4) = "11"
        Strings.AvailableFeature(0) = "1"
        Strings.AvailableFeature(1) = "1"
        Strings.AvailableFeature(2) = "1"
        Strings.AvailableFeature(3) = "1"
        Strings.AvailableFeature(4) = "1"
        Strings.AvailableFeature(5) = "3"
        Strings.AvailableFeature(6) = "3"
        Strings.AvailableFeature(7) = "1"
        Strings.AvailableFeature(8) = "1"
        Strings.AvailableFeature(9) = "1"
        Strings.AvailableFeature(10) = "1"
    End Sub

    Public Sub GodMode()
        Strings.ComputerInfo(2) = 9999
        Strings.ComputerInfo(4) = "0"
        Strings.AvailableFeature(0) = "0"
        Strings.AvailableFeature(1) = "0"
        Strings.AvailableFeature(2) = "2"
        Strings.AvailableFeature(3) = "2"
        Strings.AvailableFeature(4) = "2"
        Strings.AvailableFeature(5) = "2"
        Strings.AvailableFeature(6) = "2"
        Strings.AvailableFeature(7) = "2"
        Strings.AvailableFeature(8) = "2"
        Strings.AvailableFeature(9) = "2"
        Strings.AvailableFeature(10) = "2"
    End Sub
End Module
