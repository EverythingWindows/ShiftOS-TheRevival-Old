Module Shiftoriums
    Public prompt As String

    Public Sub Shiftorium_ListFeatures()
        'Shows available installable feature on Shiftorium
        'Only AvailableFeature that are in the value of 0 can be displayed in the list
        NewLine("Shiftorium Available Feature(s)")
        NewLine(Nothing)
        If Strings.AvailableFeature(11) = 0 Then
            NewLine("(key | 5 CP) ShiftOS Key")
        Else
            If Strings.AvailableFeature(0) = 0 Then
                NewLine("(man | 10 CP) ShiftOS Help Manual")
            Else
                If Strings.AvailableFeature(19) = 0 Then
                    NewLine("(username | 15 CP) Custom Username")
                End If
                If Strings.AvailableFeature(20) = 0 Then
                    NewLine("(hostname | 15 CP) Custom hostname")
                End If
            End If
            If Strings.AvailableFeature(1) = 0 Then
                NewLine("(clear | 20 CP) Clear Terminal Screen")
            Else
                If Strings.AvailableFeature(2) = 0 Then
                    NewLine("(print | 25 CP) Print Terminal Screen")
                Else
                    If Strings.AvailableFeature(3) = 0 Then
                        NewLine("(termdspdrv | 40 CP) Terminal Display Driver")
                    Else
                        If Strings.AvailableFeature(4) = 0 Then
                            NewLine("(infobar | 50 CP) Terminal InfoBar")
                        End If
                        If Strings.AvailableFeature(8) = 0 Then
                            NewLine("(shiftfetch | 55 CP) Shiftfetch")
                        End If
                        If Strings.AvailableFeature(10) = 0 Then
                            NewLine("(2bitcolor | 60 CP) 2-bit Color Support")
                        Else
                            If Strings.AvailableFeature(13) = 0 Then
                                NewLine("(rgb | 70 CP) Red, Green, and Blue")
                            Else
                                If Strings.AvailableFeature(14) = 0 Then
                                    NewLine("(rgb2 | 75 CP) RGB Variant")
                                Else
                                    If Strings.AvailableFeature(15) = 0 Then
                                        NewLine("(4bitcolor | 80 CP) 4-bit Color Support")
                                    Else
                                        If Strings.AvailableFeature(16) = 0 Then
                                            NewLine("(romdriver | 90 CP) Terminal Read-Only Memory Support")
                                        Else
                                            If Strings.AvailableFeature(17) = 0 Then
                                                NewLine("(textpad | 100 CP) TextPad")
                                            Else
                                                If Strings.AvailableFeature(30) = 0 Then
                                                    NewLine("(batchscript | 100 CP) ShiftOS Batch Script Support")
                                                End If
                                            End If
                                            If Strings.AvailableFeature(31) = 0 Then
                                                NewLine("(rename | 95 CP) Rename command")
                                            End If
                                            If Strings.AvailableFeature(32) = 0 Then
                                                NewLine("(zip | 95 CP) Zip command")
                                            End If
                                            If Strings.AvailableFeature(33) = 0 Then
                                                NewLine("(unzip | 95 CP) Unzip command")
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If Strings.AvailableFeature(18) = 0 Then
                        NewLine("(shiftkey | 45 CP) ShiftKey")
                    End If
                    If Strings.AvailableFeature(21) = 0 Then
                        NewLine("(rev | 30 CP) Reverse String")
                    Else
                        If Strings.AvailableFeature(22) = 0 Then
                            NewLine("(cowsay | 50 CP) Cowsay")
                        End If
                    End If
                End If
                If Strings.AvailableFeature(5) = 0 Then
                    NewLine("(stime | 10 CP) Time by Seconds")
                Else
                    If Strings.AvailableFeature(6) = 0 Then
                        NewLine("(mtime | 20 CP) Time by Minutes")
                    Else
                        If Strings.AvailableFeature(7) = 0 Then
                            NewLine("(htime | 30 CP) Time by Hours")
                        Else
                            If Strings.AvailableFeature(12) = 0 Then
                                NewLine("(pmam | 40 CP) PM and AM")
                            Else
                                If Strings.AvailableFeature(23) = 0 Then
                                    NewLine("(hhmm | 50 CP) Time by Hours and Minutes")
                                Else
                                    If Strings.AvailableFeature(24) = 0 Then
                                        NewLine("(date | 70 CP) Date command")
                                    Else
                                        If Strings.AvailableFeature(25) = 0 Then
                                            NewLine("(woy | 75 CP) Date by week of year")
                                        Else
                                            If Strings.AvailableFeature(26) = 0 Then
                                                NewLine("(moy | 80 CP) Date by month of year")
                                            Else
                                                If Strings.AvailableFeature(27) = 0 Then
                                                    NewLine("(year | 85 CP) Date by year")
                                                Else
                                                    If Strings.AvailableFeature(28) = 0 Then
                                                        NewLine("(mmyyyy | 90 CP) Date by month and year")
                                                    Else
                                                        If Strings.AvailableFeature(29) = 0 Then
                                                            NewLine("(generaldate | 95 CP) Date by general format")
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If Strings.AvailableFeature(9) = 0 Then
                    NewLine("(bc | 55 CP) Basic Calculator")
                Else
                    If Strings.AvailableFeature(34) = 0 Then
                        NewLine("(mathquiz | 60 CP) MathQuiz")
                    End If
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
                If Strings.AvailableFeature(0) = 0 Then
                    ManHeader(0) = "ShiftOS Help Manual (command: man)"
                    ManHeader(1) = "10 CP"
                    NewLine(ManHeader(0))
                    NewLine(Nothing)
                    NewLine("Shows up any further help instruction on each command, its corresponding action and its example if necessary")
                    NewLine(Nothing)
                    NewLine(ManHeader(1))
                    NormalCommand()
                End If
            Case "clear"
                If Strings.AvailableFeature(1) = 0 Then
                    ManHeader(0) = "Clear Terminal Screen (command: clear)"
                    ManHeader(1) = "20 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Clears the terminal screen" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "print"
                If Strings.AvailableFeature(2) = 0 Then
                    ManHeader(0) = "Print Command (command: print)"
                    ManHeader(1) = "25 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Prints a corresponding text entered in the command" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "termdspdrv"
                If Strings.AvailableFeature(3) = 0 Then
                    ManHeader(0) = "Terminal Display Driver"
                    ManHeader(1) = "40 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Display driver for ShiftOS' Terminal to utilize advantages such as Infobar, ASCII-based applications" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "infobar"
                If Strings.AvailableFeature(4) = 0 Then
                    ManHeader(0) = "Terminal InfoBar"
                    ManHeader(1) = "50 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Panel bar at the bottom of the terminal to display basic informations" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "stime"
                If Strings.AvailableFeature(5) = 0 Then
                    ManHeader(0) = "Time by Seconds"
                    ManHeader(1) = "10 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Shows time in seconds form since midnight" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "stime"
                If Strings.AvailableFeature(6) = 0 Then
                    ManHeader(0) = "Time by Minutes"
                    ManHeader(1) = "20 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Shows time in minutes form since midnight" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "htime"
                If Strings.AvailableFeature(7) = 0 Then
                    ManHeader(0) = "Time by Hours"
                    ManHeader(1) = "30 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Shows time in hours form since midnight" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "shiftfetch"
                If Strings.AvailableFeature(8) = 0 Then
                    ManHeader(0) = "Shiftfetch"
                    ManHeader(1) = "55 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "ShiftOS port of Neofetch, A command-line system information tool" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "bc"
                If Strings.AvailableFeature(9) = 0 Then
                    ManHeader(0) = "Basic Calculator"
                    ManHeader(1) = "55 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Basic Calculator for simple calculation" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "2bitcolor"
                If Strings.AvailableFeature(10) = 0 Then
                    ManHeader(0) = "2-bit Color Support"
                    ManHeader(1) = "60 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Adds 2 colours (Dark Gray, Light Gray) supports to the terminal" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "key"
                If Strings.AvailableFeature(11) = 0 Then
                    ManHeader(0) = "ShiftOS Key"
                    ManHeader(1) = "5 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "An encryption key to unlock advanced terminal feature for ShiftOS" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "pmam"
                If Strings.AvailableFeature(12) = 0 Then
                    ManHeader(0) = "PM and AM"
                    ManHeader(1) = "40 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Shows time in PM and AM format" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "rgb"
                If Strings.AvailableFeature(13) = 0 Then
                    ManHeader(0) = "Red, Green, and Blue"
                    ManHeader(1) = "70 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Adds Red, Green, and Blue support to the Display Driver" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "rgb2"
                If Strings.AvailableFeature(14) = 0 Then
                    ManHeader(0) = "RGB Variant"
                    ManHeader(1) = "75 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Adds lighter or darker variant of Red, Green, and Blue" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "4bitcolor"
                If Strings.AvailableFeature(15) = 0 Then
                    ManHeader(0) = "4-bit Color Display"
                    ManHeader(1) = "80 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Adds to 16 colours support to the Display Driver" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "romdriver"
                If Strings.AvailableFeature(16) = 0 Then
                    ManHeader(0) = "Terminal Read-Only Memory Driver"
                    ManHeader(1) = "90 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "ShiftOS Read-Only Memory support for ShiftOS such as writing and reading permanent memory such as HDD, SDD, etc." & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "textpad"
                If Strings.AvailableFeature(17) = 0 Then
                    ManHeader(0) = "TextPad"
                    ManHeader(1) = "100 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "A simple text-editor for ShiftOS" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "shiftkey"
                If Strings.AvailableFeature(18) = 0 Then
                    ManHeader(0) = "ShiftKey"
                    ManHeader(1) = "45 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Recall the previous command on terminal" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "username"
                If Strings.AvailableFeature(19) = 0 Then
                    ManHeader(0) = "Custom Username"
                    ManHeader(1) = "15 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Set custom username for ShfitOS" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "hostname"
                If Strings.AvailableFeature(20) = 0 Then
                    ManHeader(0) = "Custom Hostname"
                    ManHeader(1) = "15 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Set custom hostname/computer name for ShfitOS" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "rev"
                If Strings.AvailableFeature(21) = 0 Then
                    ManHeader(0) = "Reverse String"
                    ManHeader(1) = "30 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Reverse any text you entered in the terminal" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "cowsay"
                If Strings.AvailableFeature(22) = 0 Then
                    ManHeader(0) = "Cowsay"
                    ManHeader(1) = "50 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Make the ASCII cow say anything you want to" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "hhmm"
                If Strings.AvailableFeature(23) = 0 Then
                    ManHeader(0) = "Time by Hours and Minutes"
                    ManHeader(1) = "50 CP"
                    Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Shows time in Hours and Minutes format" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    NormalCommand()
                End If
            Case "date"
                If Strings.AvailableFeature(24) = 0 Then
                    ManHeader(0) = "Date command"
                    ManHeader(1) = "70 CP"
                    NewLine(ManHeader(0))
                    NewLine(Nothing)
                    NewLine("Displays date in days format since first day of the year")
                    NewLine(Nothing)
                    NewLine(ManHeader(1))
                    NormalCommand()
                End If
            Case "woy"
                If Strings.AvailableFeature(25) = 0 Then
                    ManHeader(0) = "Date by week of year"
                    ManHeader(1) = "75 CP"
                    NewLine(ManHeader(0))
                    NewLine(Nothing)
                    NewLine("Displays date in week format since first week of the year")
                    NewLine(Nothing)
                    NewLine(ManHeader(1))
                    NormalCommand()
                End If
            Case "moy"
                If Strings.AvailableFeature(26) = 0 Then
                    ManHeader(0) = "Date by month of year"
                    ManHeader(1) = "80 CP"
                    NewLine(ManHeader(0))
                    NewLine(Nothing)
                    NewLine("Displays date in month format since first month of the year")
                    NewLine(Nothing)
                    NewLine(ManHeader(1))
                    NormalCommand()
                End If
            Case "year"
                If Strings.AvailableFeature(27) = 0 Then
                    ManHeader(0) = "Date by year"
                    ManHeader(1) = "85 CP"
                    NewLine(ManHeader(0))
                    NewLine(Nothing)
                    NewLine("Displays date in year format")
                    NewLine(Nothing)
                    NewLine(ManHeader(1))
                    NormalCommand()
                End If
            Case "mmyyyy"
                If Strings.AvailableFeature(28) = 0 Then
                    ManHeader(0) = "Date by month and year"
                    ManHeader(1) = "90 CP"
                    NewLine(ManHeader(0))
                    NewLine(Nothing)
                    NewLine("Displays date in month and year format")
                    NewLine(Nothing)
                    NewLine(ManHeader(1))
                    NormalCommand()
                End If
            Case "generaldate"
                If Strings.AvailableFeature(29) = 0 Then
                    ManHeader(0) = "Date by general format"
                    ManHeader(1) = "95 CP"
                    NewLine(ManHeader(0))
                    NewLine(Nothing)
                    NewLine("Displays date in DD/MM/YYYY format")
                    NewLine(Nothing)
                    NewLine(ManHeader(1))
                    NormalCommand()
                End If
            Case "batchscript"
                If Strings.AvailableFeature(30) = 0 Then
                    ManHeader(0) = "ShiftOS Batch Script Support"
                    ManHeader(1) = "100 CP"
                    NewLine(ManHeader(0))
                    NewLine(Nothing)
                    NewLine("Adds the supports for ShiftOS Batch Script")
                    NewLine(Nothing)
                    NewLine(ManHeader(1))
                    NormalCommand()
                End If
            Case "rename"
                If Strings.AvailableFeature(31) = 0 Then
                    ManHeader(0) = "Rename command"
                    ManHeader(1) = "95 CP"
                    NewLine(ManHeader(0))
                    NewLine(Nothing)
                    NewLine("Gives ability to rename a file")
                    NewLine(Nothing)
                    NewLine(ManHeader(1))
                    NormalCommand()
                End If
            Case "zip"
                If Strings.AvailableFeature(32) = 0 Then
                    ManHeader(0) = "Zip command"
                    ManHeader(1) = "95 CP"
                    NewLine(ManHeader(0))
                    NewLine(Nothing)
                    NewLine("Gives ShiftOS support for compressing a file or directory into a ZIP file")
                    NewLine(Nothing)
                    NewLine(ManHeader(1))
                    NormalCommand()
                End If
            Case "unzip"
                If Strings.AvailableFeature(33) = 0 Then
                    ManHeader(0) = "Unzip command"
                    ManHeader(1) = "95 CP"
                    NewLine(ManHeader(0))
                    NewLine(Nothing)
                    NewLine("Gives ShiftOS support for compressing extracting a file or directory from a ZIP file")
                    NewLine(Nothing)
                    NewLine(ManHeader(1))
                    NormalCommand()
                End If
            Case "mathquiz"
                If Strings.AvailableFeature(34) = 0 Then
                    ManHeader(0) = "MathQuiz"
                    ManHeader(1) = "60 CP"
                    NewLine(ManHeader(0))
                    NewLine(Nothing)
                    NewLine("Simple puzzle game to solve simple arithmatical question to get codepoints")
                    NewLine(Nothing)
                    NewLine(ManHeader(1))
                    NormalCommand()
                End If
            Case Else
                NormalCommand()
                Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & "Shiftorium: Bad command or not available"
        End Select
    End Sub

    Public Sub Shiftorium_DetectInstallFeatures()
        NewLine("Installing feature...")
        Select Case prompt
            Case "man"
                Shiftorium_InstallFeatures(True, "man", 0, 10)
                NormalCommand()
            Case "clear"
                Shiftorium_InstallFeatures(True, "clear", 1, 20)
                NormalCommand()
            Case "print"
                Shiftorium_InstallFeatures(True, "print", 2, 25)
                NormalCommand()
            Case "termdspdrv"
                Shiftorium_InstallFeatures(True, "termdspdrv", 3, 40)
                NormalCommand()
            Case "infobar"
                Shiftorium_InstallFeatures(True, "infobar", 4, 50)
                NormalCommand()
            Case "stime"
                Shiftorium_InstallFeatures(True, "stime", 5, 10)
                NormalCommand()
            Case "mtime"
                Shiftorium_InstallFeatures(True, "mtime", 6, 20)
                NormalCommand()
            Case "htime"
                Shiftorium_InstallFeatures(True, "htime", 7, 30)
                NormalCommand()
            Case "shiftfetch"
                Shiftorium_InstallFeatures(True, "shiftfetch", 8, 55)
                NormalCommand()
            Case "bc"
                Shiftorium_InstallFeatures(True, "bc", 9, 55)
                NormalCommand()
            Case "2bitcolor"
                Shiftorium_InstallFeatures(True, "2bitcolor", 10, 60)
                NormalCommand()
            Case "key"
                Shiftorium_InstallFeatures(True, "key", 11, 5)
                NormalCommand()
            Case "pmam"
                Shiftorium_InstallFeatures(True, "pmam", 12, 40)
                NormalCommand()
            Case "rgb"
                Shiftorium_InstallFeatures(True, "rgb", 13, 70)
                NormalCommand()
            Case "rgb2"
                Shiftorium_InstallFeatures(True, "rgb2", 14, 75)
                NormalCommand()
            Case "4bitcolor"
                Shiftorium_InstallFeatures(True, "4bitcolor", 15, 80)
                NormalCommand()
            Case "romdriver"
                Shiftorium_InstallFeatures(True, "romdriver", 16, 90)
                NormalCommand()
            Case "textpad"
                Shiftorium_InstallFeatures(True, "textpad", 17, 100)
                NormalCommand()
            Case "shiftkey"
                Shiftorium_InstallFeatures(True, "shiftkey", 18, 45)
                NormalCommand()
            Case "username"
                Shiftorium_InstallFeatures(True, "username", 19, 15)
                NormalCommand()
            Case "hostname"
                Shiftorium_InstallFeatures(True, "hostname", 20, 15)
                NormalCommand()
            Case "rev"
                Shiftorium_InstallFeatures(True, "rev", 21, 30)
                NormalCommand()
            Case "cowsay"
                Shiftorium_InstallFeatures(True, "cowsay", 22, 50)
                NormalCommand()
            Case "hhmm"
                Shiftorium_InstallFeatures(True, "hhmm", 23, 50)
                NormalCommand()
            Case "date"
                Shiftorium_InstallFeatures(True, "date", 24, 70)
                NormalCommand()
            Case "woy"
                Shiftorium_InstallFeatures(True, "woy", 25, 75)
                NormalCommand()
            Case "moy"
                Shiftorium_InstallFeatures(True, "moy", 26, 80)
                NormalCommand()
            Case "year"
                Shiftorium_InstallFeatures(True, "year", 27, 85)
                NormalCommand()
            Case "mmyyyy"
                Shiftorium_InstallFeatures(True, "mmyyyy", 28, 90)
                NormalCommand()
            Case "generaldate"
                Shiftorium_InstallFeatures(True, "generaldate", 29, 95)
                NormalCommand()
            Case "batchscript"
                Shiftorium_InstallFeatures(True, "batchscript", 30, 100)
                NormalCommand()
            Case "rename"
                Shiftorium_InstallFeatures(True, "rename", 31, 95)
                NormalCommand()
            Case "zip"
                Shiftorium_InstallFeatures(True, "zip", 32, 95)
                NormalCommand()
            Case "unzip"
                Shiftorium_InstallFeatures(True, "unzip", 33, 95)
                NormalCommand()
            Case "mathquiz"
                Shiftorium_InstallFeatures(True, "mathquiz", 34, 60)
                NormalCommand()
            Case Else
                NormalCommand()
                NewLine("Shiftorium: Bad command or not available")
        End Select
    End Sub

    Public Sub Shiftorium_InstallFeatures(IsCLI As Boolean, Feature As String, FeatureRow As Integer, Codepoint As Integer)
        'Import the current CP as an Integer
        Dim TempCP As Integer = Convert.ToInt32(Strings.ComputerInfo(2))
        'See what feature that are going to be installed
        Select Case Strings.AvailableFeature(FeatureRow)
            Case "0"
                If TempCP >= Codepoint Then
                    Dim success As Boolean = False
                    Select Case Feature
                        Case "man"
                            Strings.AvailableFeature(0) = "1"
                            Strings.AvailableFeature(19) = "0"
                            Strings.AvailableFeature(20) = "0"
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
                            Strings.AvailableFeature(18) = "0"
                            Strings.AvailableFeature(21) = "0"
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
                            Strings.AvailableFeature(34) = "0"
                            success = True
                        Case "2bitcolor"
                            Strings.AvailableFeature(10) = "1"
                            Strings.AvailableFeature(13) = "0"
                            success = True
                        Case "key"
                            Strings.AvailableFeature(11) = "1"
                            Strings.AvailableFeature(0) = "0"
                            Strings.AvailableFeature(1) = "0"
                            success = True
                        Case "pmam"
                            Strings.AvailableFeature(7) = "3"
                            Strings.AvailableFeature(12) = "1"
                            Strings.AvailableFeature(23) = "0"
                            success = True
                        Case "rgb"
                            Strings.AvailableFeature(13) = "1"
                            Strings.AvailableFeature(14) = "0"
                            success = True
                        Case "rgb2"
                            Strings.AvailableFeature(14) = "1"
                            Strings.AvailableFeature(15) = "0"
                            success = True
                        Case "4bitcolor"
                            Strings.AvailableFeature(15) = "1"
                            Strings.AvailableFeature(16) = "0"
                            success = True
                        Case "romdriver"
                            Strings.AvailableFeature(16) = "1"
                            Strings.AvailableFeature(17) = "0"
                            Strings.AvailableFeature(31) = "0"
                            Strings.AvailableFeature(32) = "0"
                            Strings.AvailableFeature(33) = "0"
                            success = True
                        Case "textpad"
                            Strings.AvailableFeature(17) = "1"
                            Strings.AvailableFeature(30) = "0"
                            success = True
                        Case "shiftkey"
                            Strings.AvailableFeature(18) = "1"
                            success = True
                        Case "username"
                            Strings.AvailableFeature(19) = "1"
                            success = True
                        Case "hostname"
                            Strings.AvailableFeature(20) = "1"
                            success = True
                        Case "rev"
                            Strings.AvailableFeature(21) = "1"
                            Strings.AvailableFeature(22) = "0"
                            success = True
                        Case "cowsay"
                            Strings.AvailableFeature(22) = "1"
                            success = True
                        Case "hhmm"
                            Strings.AvailableFeature(12) = "3"
                            Strings.AvailableFeature(23) = "1"
                            Strings.AvailableFeature(24) = "0"
                            success = True
                        Case "date"
                            Strings.AvailableFeature(24) = "1"
                            Strings.AvailableFeature(25) = "0"
                            success = True
                        Case "woy"
                            Strings.AvailableFeature(24) = "3"
                            Strings.AvailableFeature(25) = "1"
                            Strings.AvailableFeature(26) = "0"
                            success = True
                        Case "moy"
                            Strings.AvailableFeature(25) = "3"
                            Strings.AvailableFeature(26) = "1"
                            Strings.AvailableFeature(27) = "0"
                            success = True
                        Case "year"
                            Strings.AvailableFeature(26) = "3"
                            Strings.AvailableFeature(27) = "1"
                            Strings.AvailableFeature(28) = "0"
                            success = True
                        Case "mmyyyy"
                            Strings.AvailableFeature(27) = "3"
                            Strings.AvailableFeature(28) = "1"
                            Strings.AvailableFeature(29) = "0"
                            success = True
                        Case "generaldate"
                            Strings.AvailableFeature(28) = "3"
                            Strings.AvailableFeature(29) = "1"
                            success = True
                        Case "batchscript"
                            Strings.AvailableFeature(30) = "1"
                            success = True
                        Case "rename"
                            Strings.AvailableFeature(31) = "1"
                            success = True
                        Case "zip"
                            Strings.AvailableFeature(32) = "1"
                            success = True
                        Case "unzip"
                            Strings.AvailableFeature(33) = "1"
                            success = True
                        Case "mathquiz"
                            Strings.AvailableFeature(34) = "1"
                            success = True
                    End Select
                    If success = False Then
                        If IsCLI = True Then
                            NewLine("Shiftorium: Invalid command or feature already installed")
                        End If
                    Else
                        'It will deduct the current codepoint to the modified codepoint and exporting it back to ComputerInfo(2)
                        Strings.ComputerInfo(4) = Strings.ComputerInfo(4) + 1
                        TempCP = TempCP - Codepoint
                        Strings.ComputerInfo(2) = Convert.ToString(TempCP)
                        If IsCLI = True Then
                            NewLine("Feature has been install succesfully")
                        End If
                    End If
                Else
                    If IsCLI = True Then
                        NewLine("Shiftorium: Insufficent Codepoint")
                    End If
                End If
            Case "1"
                If IsCLI = True Then
                    NewLine("Shiftorium: Feature has already been installed")
                End If
            Case "2"
                If IsCLI = True Then
                    NewLine("Shiftorium: Feature is not available")
                End If
            Case "3"
                If IsCLI = True Then
                    NewLine("Shiftorium: Feature is already upgraded to a newer one")
                End If
        End Select
    End Sub
End Module
