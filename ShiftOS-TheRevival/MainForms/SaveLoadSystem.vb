Module SaveLoadSystem

    Public Sub NewGameMode()
        Strings.AvailableFeature(0) = "0"
        Strings.AvailableFeature(1) = "0"
        Strings.AvailableFeature(2) = "2"
        Strings.AvailableFeature(3) = "2"
    End Sub

    Public Sub FreeRoamMode()
        Strings.AvailableFeature(0) = "1"
        Strings.AvailableFeature(1) = "1"
        Strings.AvailableFeature(2) = "1"
        Strings.AvailableFeature(3) = "1"
    End Sub

    Public Sub GodMode()
        Strings.ComputerInfo(2) = 9999
        Strings.AvailableFeature(0) = "0"
        Strings.AvailableFeature(1) = "0"
        Strings.AvailableFeature(2) = "2"
        Strings.AvailableFeature(3) = "2"
    End Sub
End Module
