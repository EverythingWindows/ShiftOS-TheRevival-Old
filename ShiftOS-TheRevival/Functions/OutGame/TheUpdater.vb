Imports System.IO

Module TheUpdater

    Public WhatVersion As String
    Public Sub UpdateToNew()
        Dim AvailableFeatureHere As String() = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\AvailableFeature.sos")
        Dim ComputerInfoHere As String() = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\ComputerInfo.sos")
        Select Case WhatVersion
            Case "0.2.3"
                Strings.AvailableFeature(0) = AvailableFeatureHere(0)
                Strings.AvailableFeature(1) = AvailableFeatureHere(1)
                Strings.AvailableFeature(2) = AvailableFeatureHere(2)
                Strings.AvailableFeature(3) = AvailableFeatureHere(3)
                Strings.AvailableFeature(4) = AvailableFeatureHere(4)
                Strings.AvailableFeature(5) = AvailableFeatureHere(5)
                Strings.AvailableFeature(6) = AvailableFeatureHere(6)
                Strings.AvailableFeature(7) = AvailableFeatureHere(7)
                Strings.AvailableFeature(8) = AvailableFeatureHere(8)
                Strings.AvailableFeature(9) = AvailableFeatureHere(9)
                Strings.AvailableFeature(10) = AvailableFeatureHere(10)
                Strings.AvailableFeature(11) = AvailableFeatureHere(11)
                Strings.AvailableFeature(12) = AvailableFeatureHere(12)
                Strings.AvailableFeature(13) = AvailableFeatureHere(13)
                Strings.AvailableFeature(14) = AvailableFeatureHere(14)
                Strings.AvailableFeature(15) = AvailableFeatureHere(15)
                Strings.AvailableFeature(16) = "0"
                Strings.AvailableFeature(17) = "0"
                Strings.AvailableFeature(18) = "0"
                Strings.AvailableFeature(19) = "0"
                Strings.AvailableFeature(20) = "0"
                Strings.AvailableFeature(21) = "0"
                Strings.AvailableFeature(22) = "0"
                If Strings.AvailableFeature(15) = 1 Then
                    Strings.AvailableFeature(16) = "0"
                Else
                    Strings.AvailableFeature(16) = "2"
                End If
                Strings.AvailableFeature(17) = "2"
                If Strings.AvailableFeature(2) = 1 Then
                    Strings.AvailableFeature(18) = "0"
                    Strings.AvailableFeature(21) = "0"
                Else
                    Strings.AvailableFeature(18) = "2"
                    Strings.AvailableFeature(21) = "2"
                End If
                If Strings.AvailableFeature(0) = 1 Then
                    Strings.AvailableFeature(19) = "0"
                    Strings.AvailableFeature(20) = "0"
                Else
                    Strings.AvailableFeature(19) = "2"
                    Strings.AvailableFeature(20) = "2"
                End If
                Strings.AvailableFeature(22) = "2"
                Strings.ComputerInfo(0) = ComputerInfoHere(0)
                Strings.ComputerInfo(1) = ComputerInfoHere(1)
                Strings.ComputerInfo(2) = ComputerInfoHere(2)
                Strings.ComputerInfo(3) = ComputerInfoHere(3)
                Strings.ComputerInfo(4) = ComputerInfoHere(4)
                Strings.ComputerInfo(5) = "0F"
                Strings.ComputerInfo(6) = "F0"
                ShiftOSUpdater.Button2.Text = "Updated!"
            Case "0.2.4"
                Strings.AvailableFeature(0) = AvailableFeatureHere(0)
                Strings.AvailableFeature(1) = AvailableFeatureHere(1)
                Strings.AvailableFeature(2) = AvailableFeatureHere(2)
                Strings.AvailableFeature(3) = AvailableFeatureHere(3)
                Strings.AvailableFeature(4) = AvailableFeatureHere(4)
                Strings.AvailableFeature(5) = AvailableFeatureHere(5)
                Strings.AvailableFeature(6) = AvailableFeatureHere(6)
                Strings.AvailableFeature(7) = AvailableFeatureHere(7)
                Strings.AvailableFeature(8) = AvailableFeatureHere(8)
                Strings.AvailableFeature(9) = AvailableFeatureHere(9)
                Strings.AvailableFeature(10) = AvailableFeatureHere(10)
                Strings.AvailableFeature(11) = AvailableFeatureHere(11)
                Strings.AvailableFeature(12) = AvailableFeatureHere(12)
                Strings.AvailableFeature(13) = AvailableFeatureHere(13)
                Strings.AvailableFeature(14) = AvailableFeatureHere(14)
                Strings.AvailableFeature(15) = AvailableFeatureHere(15)
                Strings.AvailableFeature(16) = AvailableFeatureHere(16)
                Strings.AvailableFeature(17) = AvailableFeatureHere(17)
                Strings.AvailableFeature(18) = AvailableFeatureHere(18)
                Strings.AvailableFeature(19) = AvailableFeatureHere(19)
                Strings.AvailableFeature(20) = AvailableFeatureHere(20)
                Strings.AvailableFeature(21) = AvailableFeatureHere(21)
                Strings.AvailableFeature(22) = AvailableFeatureHere(22)
                If Strings.AvailableFeature(12) = "1" Then
                    Strings.AvailableFeature(23) = "0"
                Else
                    Strings.AvailableFeature(23) = "2"
                End If
                Strings.AvailableFeature(24) = "2"
                Strings.AvailableFeature(25) = "2"
                Strings.AvailableFeature(26) = "2"
                Strings.AvailableFeature(27) = "2"
                Strings.AvailableFeature(28) = "2"
                Strings.AvailableFeature(29) = "2"
                If Strings.AvailableFeature(17) = 1 Then
                    Strings.AvailableFeature(30) = "0"
                Else
                    Strings.AvailableFeature(30) = "2"
                End If
                If Strings.AvailableFeature(16) = 1 Then
                    Strings.AvailableFeature(31) = 0
                    Strings.AvailableFeature(32) = 0
                    Strings.AvailableFeature(33) = 0
                Else
                    Strings.AvailableFeature(31) = 2
                    Strings.AvailableFeature(32) = 2
                    Strings.AvailableFeature(33) = 2
                End If
                If Strings.AvailableFeature(9) = 1 Then
                    Strings.AvailableFeature(34) = 0
                Else
                    Strings.AvailableFeature(34) = 2
                End If
                Strings.AvailableFeature(35) = 2
                Strings.AvailableFeature(36) = 2
                Strings.AvailableFeature(37) = 2
                Strings.AvailableFeature(38) = 2
                Strings.AvailableFeature(39) = 2
                Strings.AvailableFeature(40) = 2
                Strings.AvailableFeature(41) = 2
                Strings.ComputerInfo(0) = ComputerInfoHere(0)
                Strings.ComputerInfo(1) = ComputerInfoHere(1)
                Strings.ComputerInfo(2) = ComputerInfoHere(2)
                Strings.ComputerInfo(3) = ComputerInfoHere(3)
                Strings.ComputerInfo(4) = ComputerInfoHere(4)
                Strings.ComputerInfo(5) = "0F"
                Strings.ComputerInfo(6) = "F0"
                If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS") = True Then

                Else
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS")
                End If
                ShiftOSUpdater.Button2.Text = "Updated!"
            Case "0.2.5"
                Strings.AvailableFeature(0) = AvailableFeatureHere(0)
                Strings.AvailableFeature(1) = AvailableFeatureHere(1)
                Strings.AvailableFeature(2) = AvailableFeatureHere(2)
                Strings.AvailableFeature(3) = AvailableFeatureHere(3)
                Strings.AvailableFeature(4) = AvailableFeatureHere(4)
                Strings.AvailableFeature(5) = AvailableFeatureHere(5)
                Strings.AvailableFeature(6) = AvailableFeatureHere(6)
                Strings.AvailableFeature(7) = AvailableFeatureHere(7)
                Strings.AvailableFeature(8) = AvailableFeatureHere(8)
                Strings.AvailableFeature(9) = AvailableFeatureHere(9)
                Strings.AvailableFeature(10) = AvailableFeatureHere(10)
                Strings.AvailableFeature(11) = AvailableFeatureHere(11)
                Strings.AvailableFeature(12) = AvailableFeatureHere(12)
                Strings.AvailableFeature(13) = AvailableFeatureHere(13)
                Strings.AvailableFeature(14) = AvailableFeatureHere(14)
                Strings.AvailableFeature(15) = AvailableFeatureHere(15)
                Strings.AvailableFeature(16) = AvailableFeatureHere(16)
                Strings.AvailableFeature(17) = AvailableFeatureHere(17)
                Strings.AvailableFeature(18) = AvailableFeatureHere(18)
                Strings.AvailableFeature(19) = AvailableFeatureHere(19)
                Strings.AvailableFeature(20) = AvailableFeatureHere(20)
                Strings.AvailableFeature(21) = AvailableFeatureHere(21)
                Strings.AvailableFeature(22) = AvailableFeatureHere(22)
                Strings.AvailableFeature(23) = AvailableFeatureHere(23)
                Strings.AvailableFeature(24) = AvailableFeatureHere(24)
                Strings.AvailableFeature(25) = AvailableFeatureHere(25)
                Strings.AvailableFeature(26) = AvailableFeatureHere(26)
                Strings.AvailableFeature(27) = AvailableFeatureHere(27)
                Strings.AvailableFeature(28) = AvailableFeatureHere(28)
                Strings.AvailableFeature(29) = AvailableFeatureHere(29)
                Strings.AvailableFeature(30) = AvailableFeatureHere(30)
                If Strings.AvailableFeature(16) = 1 Then
                    Strings.AvailableFeature(31) = 0
                    Strings.AvailableFeature(32) = 0
                    Strings.AvailableFeature(33) = 0
                Else
                    Strings.AvailableFeature(31) = 2
                    Strings.AvailableFeature(32) = 2
                    Strings.AvailableFeature(33) = 2
                End If
                If Strings.AvailableFeature(9) = 1 Then
                    Strings.AvailableFeature(34) = 0
                Else
                    Strings.AvailableFeature(34) = 2
                End If
                Strings.AvailableFeature(35) = 2
                Strings.AvailableFeature(36) = 2
                Strings.AvailableFeature(37) = 2
                Strings.AvailableFeature(38) = 2
                Strings.AvailableFeature(39) = 2
                Strings.AvailableFeature(40) = 2
                Strings.AvailableFeature(41) = 2
                Strings.ComputerInfo(0) = ComputerInfoHere(0)
                Strings.ComputerInfo(1) = ComputerInfoHere(1)
                Strings.ComputerInfo(2) = ComputerInfoHere(2)
                Strings.ComputerInfo(3) = ComputerInfoHere(3)
                Strings.ComputerInfo(4) = ComputerInfoHere(4)
                Strings.ComputerInfo(5) = "0F"
                Strings.ComputerInfo(6) = "F0"
                If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS") = True Then

                Else
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS")
                End If
                ShiftOSUpdater.Button2.Text = "Updated!"
            Case "0.2.6"
                Strings.AvailableFeature(0) = AvailableFeatureHere(0)
                Strings.AvailableFeature(1) = AvailableFeatureHere(1)
                Strings.AvailableFeature(2) = AvailableFeatureHere(2)
                Strings.AvailableFeature(3) = AvailableFeatureHere(3)
                Strings.AvailableFeature(4) = AvailableFeatureHere(4)
                Strings.AvailableFeature(5) = AvailableFeatureHere(5)
                Strings.AvailableFeature(6) = AvailableFeatureHere(6)
                Strings.AvailableFeature(7) = AvailableFeatureHere(7)
                Strings.AvailableFeature(8) = AvailableFeatureHere(8)
                Strings.AvailableFeature(9) = AvailableFeatureHere(9)
                Strings.AvailableFeature(10) = AvailableFeatureHere(10)
                Strings.AvailableFeature(11) = AvailableFeatureHere(11)
                Strings.AvailableFeature(12) = AvailableFeatureHere(12)
                Strings.AvailableFeature(13) = AvailableFeatureHere(13)
                Strings.AvailableFeature(14) = AvailableFeatureHere(14)
                Strings.AvailableFeature(15) = AvailableFeatureHere(15)
                Strings.AvailableFeature(16) = AvailableFeatureHere(16)
                Strings.AvailableFeature(17) = AvailableFeatureHere(17)
                Strings.AvailableFeature(18) = AvailableFeatureHere(18)
                Strings.AvailableFeature(19) = AvailableFeatureHere(19)
                Strings.AvailableFeature(20) = AvailableFeatureHere(20)
                Strings.AvailableFeature(21) = AvailableFeatureHere(21)
                Strings.AvailableFeature(22) = AvailableFeatureHere(22)
                Strings.AvailableFeature(23) = AvailableFeatureHere(23)
                Strings.AvailableFeature(24) = AvailableFeatureHere(24)
                Strings.AvailableFeature(25) = AvailableFeatureHere(25)
                Strings.AvailableFeature(26) = AvailableFeatureHere(26)
                Strings.AvailableFeature(27) = AvailableFeatureHere(27)
                Strings.AvailableFeature(28) = AvailableFeatureHere(28)
                Strings.AvailableFeature(29) = AvailableFeatureHere(29)
                Strings.AvailableFeature(30) = AvailableFeatureHere(30)
                Strings.AvailableFeature(31) = AvailableFeatureHere(31)
                Strings.AvailableFeature(32) = AvailableFeatureHere(32)
                Strings.AvailableFeature(33) = AvailableFeatureHere(33)
                If Strings.AvailableFeature(9) = 1 Then
                    Strings.AvailableFeature(34) = 0
                Else
                    Strings.AvailableFeature(34) = 2
                End If
                Strings.AvailableFeature(35) = 2
                Strings.AvailableFeature(36) = 2
                Strings.AvailableFeature(37) = 2
                Strings.AvailableFeature(38) = 2
                Strings.AvailableFeature(39) = 2
                Strings.AvailableFeature(40) = 2
                Strings.AvailableFeature(41) = 2
                Strings.ComputerInfo(0) = ComputerInfoHere(0)
                Strings.ComputerInfo(1) = ComputerInfoHere(1)
                Strings.ComputerInfo(2) = ComputerInfoHere(2)
                Strings.ComputerInfo(3) = ComputerInfoHere(3)
                Strings.ComputerInfo(4) = ComputerInfoHere(4)
                Strings.ComputerInfo(5) = "0F"
                Strings.ComputerInfo(6) = "F0"
                If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS") = True Then

                Else
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS")
                End If
                ShiftOSUpdater.Button2.Text = "Updated!"
        End Select
        File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\version.txt", My.Resources.CurrentVersion)
        File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\AvailableFeature.sos", Strings.AvailableFeature)
        File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved\ComputerInfo.sos", Strings.ComputerInfo)
        ShiftOSMenu.ShouldUpdate = False
    End Sub
End Module