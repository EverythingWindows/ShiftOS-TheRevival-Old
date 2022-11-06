Module Shiftoriums
    Public prompt As String

    Public Sub Shiftorium_ListFeatures()
        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium Available Feature(s)" & Environment.NewLine
        If Strings.AvailableFeature(11) = "0" Then
            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "(key | 5 CP) ShiftOS Key"
        Else
            If Strings.AvailableFeature(0) = "0" Then
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "(man | 20 CP) ShiftOS Help Manual"
            End If
            If Strings.AvailableFeature(1) = "0" Then
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "(clear | 25 CP) Clear Terminal Screen"
            Else
                If Strings.AvailableFeature(2) = "0" Then
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "(print | 30 CP) Print Terminal Screen"
                Else
                    If Strings.AvailableFeature(3) = "0" Then
                        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "(termdspdrv | 50 CP) Terminal Display Driver"
                    Else
                        If Strings.AvailableFeature(4) = "0" Then
                            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "(infobar | 55 CP) Terminal InfoBar"
                        End If
                        If Strings.AvailableFeature(8) = "0" Then
                            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "(shiftfetch | 75 CP) Shiftfetch"
                        End If
                    End If
                End If
                If Strings.AvailableFeature(5) = "0" Then
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "(stime | 10 CP) Time by Seconds"
                Else
                    If Strings.AvailableFeature(6) = "0" Then
                        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "(mtime | 20 CP) Time by Minutes"
                    Else
                        If Strings.AvailableFeature(7) = "0" Then
                            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "(htime | 40 CP) Time by Hours"
                        Else
                            If Strings.AvailableFeature(12) = "0" Then
                                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "(pmam | 60 CP) PM and AM"
                            End If
                        End If
                    End If
                End If
                If Strings.AvailableFeature(9) = "0" Then
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "(bc | 10 CP) Basic Calculator"
                End If
                If Strings.AvailableFeature(10) = "0" Then
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "(2bitcolor | 100 CP) 2-bit Color Support"
                End If
            End If
        End If
    End Sub

    Public Sub Shiftorium_InformationFeatures()
        'ManHeader is for the ShiftOS Help Manual header and the 'Cost' footer, kinda like template-ish
        Dim ManHeader(1) As String
        'ManHeader(0) = Insert any feature here for the Case prompt
        ManHeader(1) = "Cost: "
        Select Case prompt
            Case "man"
                If Strings.AvailableFeature(0) = "0" Then
                    ManHeader(0) = "ShiftOS Help Manual (command: man)"
                    ManHeader(1) = "20 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Shows up any further help instruction on each command, its corresponding action and its example if necessary" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "clear"
                If Strings.AvailableFeature(1) = "0" Then
                    ManHeader(0) = "Clear Terminal Screen (command: clear)"
                    ManHeader(1) = "25 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Clears the terminal screen" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "print"
                If Strings.AvailableFeature(2) = "0" Then
                    ManHeader(0) = "Print Command (command: print)"
                    ManHeader(1) = "30 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Prints a corresponding text entered in the command" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "termdspdrv"
                If Strings.AvailableFeature(3) = "0" Then
                    ManHeader(0) = "Terminal Display Driver"
                    ManHeader(1) = "50 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Display driver for ShiftOS' Terminal to utilize advantages such as Infobar, ASCII-based applications" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "infobar"
                If Strings.AvailableFeature(4) = "0" Then
                    ManHeader(0) = "Terminal InfoBar"
                    ManHeader(1) = "55 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Panel bar at the bottom of the terminal to display basic informations" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "stime"
                If Strings.AvailableFeature(5) = "0" Then
                    ManHeader(0) = "Time by Seconds"
                    ManHeader(1) = "10 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Shows time in seconds form since midnight" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "stime"
                If Strings.AvailableFeature(6) = "0" Then
                    ManHeader(0) = "Time by Minutes"
                    ManHeader(1) = "20 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Shows time in minutes form since midnight" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "htime"
                If Strings.AvailableFeature(7) = "0" Then
                    ManHeader(0) = "Time by Hours"
                    ManHeader(1) = "40 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Shows time in hours form since midnight" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "shiftfetch"
                If Strings.AvailableFeature(8) = "0" Then
                    ManHeader(0) = "Shiftfetch"
                    ManHeader(1) = "75 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "ShiftOS port of Neofetch, A command-line system information tool" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "bc"
                If Strings.AvailableFeature(9) = "0" Then
                    ManHeader(0) = "Basic Calculator"
                    ManHeader(1) = "75 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Basic Calculator for simple calculation" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "2bitcolor"
                If Strings.AvailableFeature(10) = "0" Then
                    ManHeader(0) = "2-bit Color Support"
                    ManHeader(1) = "100 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Adds 2 colours (Dark Gray, Light Gray) supports to the terminal" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "key"
                If Strings.AvailableFeature(11) = "0" Then
                    ManHeader(0) = "ShiftOS Key"
                    ManHeader(1) = "5 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "An encryption key to unlock advanced terminal feature for ShiftOS" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "pmam"
                If Strings.AvailableFeature(12) = "0" Then
                    ManHeader(0) = "PM and AM"
                    ManHeader(1) = "60 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Shows time in PM and AM format" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case Else
                Terminal.BadCommand = False
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium: Bad command or not available"
        End Select
    End Sub

    Public Sub Shiftorium_DetectInstallFeatures()
        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Installing feature..."
        Select Case prompt
            Case "man"
                Shiftorium_InstallFeatures(True, "man", 0, 20)
                Terminal.BadCommand = False
            Case "clear"
                Shiftorium_InstallFeatures(True, "clear", 1, 25)
                Terminal.BadCommand = False
            Case "print"
                Shiftorium_InstallFeatures(True, "print", 2, 30)
                Terminal.BadCommand = False
            Case "termdspdrv"
                Shiftorium_InstallFeatures(True, "termdspdrv", 3, 50)
                Terminal.BadCommand = False
            Case "infobar"
                Shiftorium_InstallFeatures(True, "infobar", 4, 50)
                Terminal.BadCommand = False
            Case "stime"
                Shiftorium_InstallFeatures(True, "stime", 5, 10)
                Terminal.BadCommand = False
            Case "mtime"
                Shiftorium_InstallFeatures(True, "mtime", 6, 20)
                Terminal.BadCommand = False
            Case "htime"
                Shiftorium_InstallFeatures(True, "htime", 7, 40)
                Terminal.BadCommand = False
            Case "shiftfetch"
                Shiftorium_InstallFeatures(True, "shiftfetch", 8, 75)
                Terminal.BadCommand = False
            Case "bc"
                Shiftorium_InstallFeatures(True, "bc", 9, 75)
                Terminal.BadCommand = False
            Case "2bitcolor"
                Shiftorium_InstallFeatures(True, "2bitcolor", 10, 100)
                Terminal.BadCommand = False
            Case "key"
                Shiftorium_InstallFeatures(True, "key", 11, 5)
                Terminal.BadCommand = False
            Case "pmam"
                Shiftorium_InstallFeatures(True, "pmam", 12, 60)
                Terminal.BadCommand = False
            Case Else
                Terminal.BadCommand = False
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium: Bad command or not available"
        End Select
    End Sub

    Public Sub Shiftorium_InstallFeatures(IsCLI As Boolean, Feature As String, FeatureRow As Integer, Codepoint As Integer)
        Dim TempCP As Integer = Convert.ToInt32(Strings.ComputerInfo(2))
        Select Case Strings.AvailableFeature(FeatureRow)
            Case "0"
                If TempCP >= Codepoint Then
                    Dim success As Boolean = False
                    Select Case Feature
                        Case "man"
                            Strings.AvailableFeature(0) = "1"
                            success = True
                        Case "clear"
                            Strings.AvailableFeature(1) = "1"
                            Strings.AvailableFeature(2) = "0"
                            Strings.AvailableFeature(5) = "0"
                            Strings.AvailableFeature(9) = "0"
                            success = True
                        Case "print"
                            Strings.AvailableFeature(2) = "1"
                            Strings.AvailableFeature(3) = "0"
                            success = True
                        Case "termdspdrv"
                            Strings.AvailableFeature(3) = "1"
                            Strings.AvailableFeature(4) = "0"
                            Strings.AvailableFeature(8) = "0"
                            Strings.AvailableFeature(10) = "0"
                            success = True
                        Case "infobar"
                            Strings.AvailableFeature(4) = "1"
                            success = True
                        Case "stime"
                            Strings.AvailableFeature(5) = "1"
                            Strings.AvailableFeature(6) = "0"
                            success = True
                        Case "mtime"
                            Strings.AvailableFeature(5) = "3"
                            Strings.AvailableFeature(6) = "1"
                            Strings.AvailableFeature(7) = "0"
                            success = True
                        Case "htime"
                            Strings.AvailableFeature(6) = "3"
                            Strings.AvailableFeature(7) = "1"
                            Strings.AvailableFeature(12) = "0"
                            success = True
                        Case "shiftfetch"
                            Strings.AvailableFeature(8) = "1"
                            success = True
                        Case "bc"
                            Strings.AvailableFeature(9) = "1"
                            success = True
                        Case "2bitcolor"
                            Strings.AvailableFeature(10) = "1"
                            success = True
                        Case "key"
                            Strings.AvailableFeature(11) = "1"
                            Strings.AvailableFeature(0) = "0"
                            Strings.AvailableFeature(1) = "0"
                            success = True
                        Case "pmam"
                            Strings.AvailableFeature(7) = "3"
                            Strings.AvailableFeature(12) = "1"
                            'Strings.AvailableFeature(13) = "0"
                    End Select
                    If success = False Then
                        If IsCLI = True Then
                            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium: Invalid command or feature already installed"
                        End If
                    Else
                        Strings.ComputerInfo(4) = Strings.ComputerInfo(4) + 1
                        TempCP = TempCP - Codepoint
                        Strings.ComputerInfo(2) = Convert.ToString(TempCP)
                        If IsCLI = True Then
                            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Feature has been install succesfully"
                        End If
                    End If
                Else
                    If IsCLI = True Then
                        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium: Insufficent Codepoint"
                    End If
                End If
            Case "1"
                If IsCLI = True Then
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium: Feature has already been installed"
                End If
            Case "2"
                If IsCLI = True Then
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium: Feature is not available"
                End If
            Case "3"
                If IsCLI = True Then
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium: Feature is already upgraded to a newer one"
                End If
        End Select
    End Sub
End Module
