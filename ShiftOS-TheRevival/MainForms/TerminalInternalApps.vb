Module TerminalInternalApps
    Public Sub Cowsay_Say(Say As String)
        Select Case Say.Length
            Case 1 To 40
                Dim SubtractLength As Integer = Say.Length + 1
                NewLine(" ")
                Do
                    AddLine("_")
                    SubtractLength = SubtractLength - 1
                    If SubtractLength = 0 Then
                        AddLine("_")
                        SubtractLength = Say.Length + 1
                        Exit Do
                    End If
                Loop
                NewLine("< " & Say & " >")
                NewLine(" ")
                Do
                    AddLine("-")
                    SubtractLength = SubtractLength - 1
                    If SubtractLength = 0 Then
                        AddLine("-")
                        SubtractLength = Say.Length + 1
                        Exit Do
                    End If
                Loop
                NewLine("        \   ^__^")
                NewLine("         \  (oo)\_______")
                NewLine("            (__)\       )\/\")
                NewLine("                ||----w |")
                NewLine("                ||     ||")
            Case 41 To 80
                NewLine(" __________________________________________ ")
                NewLine("/ " & Say.Substring(0, 40) & " \")
                Say = Say.Substring(40, Say.Length - 40)
                NewLine("\ " & Say)
                Dim Spaces As Integer = 40 - Say.Length
                Do
                    AddLine(" ")
                    If Spaces = 0 Then
                        AddLine("/")
                        Exit Do
                    End If
                    Spaces = Spaces - 1
                Loop
                NewLine(" ------------------------------------------ ")
                NewLine("        \   ^__^")
                NewLine("         \  (oo)\_______")
                NewLine("            (__)\       )\/\")
                NewLine("                ||----w |")
                NewLine("                ||     ||")
            Case >= 81
                NewLine("cowsay: Character limit exceeded")
                'Dim SubtractLength As Integer = Say.Length + 1
                'Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & " __________________________________________ "
                'Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "/ " & Say.Substring(0, 40) & " \"
                'Dim CurrentLength As Integer = 40
                'Dim WhatSay As String
                'Dim Spaces As Integer
                'Do
                '    Try
                '        WhatSay = Say.Substring(CurrentLength, 40)
                '    Catch ex As Exception
                '        WhatSay = Say.Substring(CurrentLength, (CurrentLength + 40) - Say.Length)
                '    End Try
                '    Spaces = 40 - WhatSay.Length
                '    If Spaces > 0 Then
                '        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "\ " & WhatSay
                '        Do
                '            Terminal.TextBox1.Text = Terminal.TextBox1.Text & " "
                '            If Spaces = 0 Then
                '                Terminal.TextBox1.Text = Terminal.TextBox1.Text & "/"
                '                Exit Do
                '            End If
                '            Spaces = Spaces - 1
                '        Loop
                '        Exit Do
                '    Else
                '        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "| " & WhatSay & " |"
                '        CurrentLength = CurrentLength + 40
                '    End If
                'Loop
        End Select
    End Sub

    Public Sub DateTerm()
        If Strings.AvailableFeature(24) = 1 Then
            NewLine("The date is " & Date.Now.DayOfYear & " days since the first day of the year")
            AdvancedCommand = False
            Console.BadCommand = False
        ElseIf Strings.AvailableFeature(24) = 3 Then
            If Strings.AvailableFeature(25) = 1 Then
                Dim TheWeek As String = Date.Now.DayOfYear / 7
                NewLine("The date is " & TheWeek.Substring(0, 2) & " weeks since the first week of the year")
                AdvancedCommand = False
                Console.BadCommand = False
            ElseIf Strings.AvailableFeature(25) = 3 Then
                If Strings.AvailableFeature(26) = 1 Then
                    NewLine("The date is " & Date.Now.Month & " months since the first month of the year")
                    AdvancedCommand = False
                    Console.BadCommand = False
                ElseIf Strings.AvailableFeature(26) = 3 Then
                    If Strings.AvailableFeature(27) = 1 Then
                        NewLine("The year is " & Date.Now.Year)
                        AdvancedCommand = False
                        Console.BadCommand = False
                    ElseIf Strings.AvailableFeature(27) = 3 Then
                        If Strings.AvailableFeature(28) = 1 Then
                            NewLine("The date is " & Date.Now.Day & "/" & Date.Now.Month)
                            AdvancedCommand = False
                            Console.BadCommand = False
                        ElseIf Strings.AvailableFeature(28) = 3 Then
                            If Strings.AvailableFeature(29) = 1 Then
                                NewLine("The date is " & Date.Now.Day & "/" & Date.Now.Month & "/" & Date.Now.Year)
                                AdvancedCommand = False
                                Console.BadCommand = False
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub Help()
        NewLine("ShiftOS Help Manual")
        NewLine(Nothing)
        NewLine("You can type 'help' to get all available commands and its corresponding action.")
        If Strings.AvailableFeature(0) = 1 Then
            NewLine("To get help on each command, you can type 'man [command]'")
            NewLine(Nothing)
        Else
            NewLine(Nothing)
        End If
        If Strings.AvailableFeature(9) = 1 Then
            NewLine("BC          Basic Calculator for simple calculation")
        End If
        If Strings.AvailableFeature(16) = 1 Then
            NewLine("CD          Changes directory to a selected one")
        End If
        If Strings.AvailableFeature(1) = 1 Then
            NewLine("CLEAR       Clear the terminal")
        End If
        NewLine("CODEPOINT   Display Codepoint(s) from your wallet")
        NewLine("COLOR       Changes Terminal Text And Background color To the corresponding choice")
        NewLine("COLORS      Shows available colors support For the terminal")
        If Strings.AvailableFeature(22) = 1 Then
            NewLine("COWSAY      Spawn a cow And saying anything you want")
        End If
        If Strings.AvailableFeature(24) = 1 Then
            NewLine("DATE        Displays date in days since first day of the year format")
        ElseIf Strings.AvailableFeature(24) = 3 Then
            If Strings.AvailableFeature(25) = 1 Then
                NewLine("DATE        Displays date in weeks since first week of the year format")
            ElseIf Strings.AvailableFeature(25) = 3 Then
                If Strings.AvailableFeature(26) = 1 Then
                    NewLine("DATE        Displays date in months since first month of the year format")
                ElseIf Strings.AvailableFeature(26) = 3 Then
                    If Strings.AvailableFeature(27) = 1 Then
                        NewLine("DATE        Displays date in year format format")
                    ElseIf Strings.AvailableFeature(27) = 3 Then
                        If Strings.AvailableFeature(28) = 1 Then
                            NewLine("DATE        Displays date in MM/YYYY format")
                        ElseIf Strings.AvailableFeature(28) = 3 Then
                            If Strings.AvailableFeature(29) = 1 Then
                                NewLine("DATE        Displays date in general DD/MM/YYYY format")
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If Strings.AvailableFeature(16) = 1 Then
            NewLine("DEL         Delete a selected file from the directory")
            NewLine("DIR         Displays subdirectories And files In a directory")
        End If
        NewLine("GUESS       Runs 'Guess the Number' application")
        NewLine("HELP        Shows all commands available and its corresponding action")
        If Strings.AvailableFeature(20) = 1 Then
            NewLine("HOSTNAME    Sets the name of current hostname/computer name with a new one")
        End If
        If Strings.AvailableFeature(4) = 1 Then
            NewLine("INFOBAR     Displays informations about current session such as current app, current user, current time, etc.")
        End If
        If Strings.AvailableFeature(0) = 1 Then
            NewLine("MAN         Shows a command, its corresponding action, and its example usage")
        End If
        If Strings.AvailableFeature(16) = 1 Then
            NewLine("MKDIR       Creating a directory")
        End If
        If Strings.AvailableFeature(16) = 1 Then
            NewLine("PWD         Display current directory navigated on ShiftOS")
        End If
        If Strings.AvailableFeature(2) = 1 Then
            NewLine("PRINT       Prints a corresponding text entered in the command")
        End If
        NewLine("REBOOT      Terminate and re-run ShiftOS session")
        If Strings.AvailableFeature(21) = 1 Then
            NewLine("REV         Turn any sentences you want and making it reversed")
        End If
        If Strings.AvailableFeature(16) = 1 Then
            NewLine("RMDIR       Deleting a directory")
        End If
        If Strings.AvailableFeature(8) = 1 Then
            NewLine("SHIFTFETCH  Shows informations about your computer")
        End If
        NewLine("SHIFTORIUM  A software center for upgrading features on ShiftOS")
        NewLine("SHUTDOWN    Terminate ShiftOS session")
        NewLine("SU          Runs terminal as super user")
        If Strings.AvailableFeature(17) = 1 Then
            NewLine("TEXTPAD     Simple text-editor for ShiftOS")
        End If
        If Strings.AvailableFeature(5) = 1 Then
            NewLine("TIME        Display the current time in the form of seconds since midnight")
        ElseIf Strings.AvailableFeature(5) = 3 Then
            If Strings.AvailableFeature(6) = 1 Then
                NewLine("TIME        Display the current time in the form of minutes since midnight")
            ElseIf Strings.AvailableFeature(6) = 3 Then
                If Strings.AvailableFeature(7) = 1 Then
                    NewLine("TIME        Display the current time in the form of hours since midnight")
                ElseIf Strings.AvailableFeature(7) = 3 Then
                    If Strings.AvailableFeature(12) = 1 Then
                        NewLine("TIME        Display the current time in the form of PM and AM format")
                    End If
                End If
            End If
        End If
        If Strings.AvailableFeature(20) = 1 Then
            NewLine("USERNAME    Sets the name of current user with a new one")
        End If
        NewLine("VER         Printing current version of ShiftOS TheRevival")
    End Sub

    Public Sub Manual(Command As String)
        'MAN command starts with this kinda format
        'ShiftOS Help Manual
        '
        ''command' Usage: [switch/value if needed]
        '
        'Summary of the command's action
        '
        'Example usage : command
        NewLine("ShiftOS Help Manual")
        NewLine(Nothing)
        'Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & command.Substring(4)
        Dim mancommand As String = Command.Replace("man ", "")
        Dim TempUsage As String = "'" & mancommand & "' Usage: "
        Select Case mancommand
        'In process to convert every command from printing from code to printing from text file
            Case "bc"
                If Strings.AvailableFeature(9) = "1" Then
                    TempUsage = TempUsage & "bc"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_bc & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "cd"
                If Strings.AvailableFeature(16) = "1" Then
                    TempUsage = TempUsage & "cd [DIRECTORY]"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_cd & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "clear"
                If Strings.AvailableFeature(1) = "1" Then
                    TempUsage = TempUsage & "clear"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_clear & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "color"
                TempUsage = TempUsage & "color [bg][fg]"
                Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_color & Environment.NewLine
                Console.BadCommand = False
            Case "colors"
                TempUsage = TempUsage & "colors"
                Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_colors & Environment.NewLine
                Console.BadCommand = False
            Case "cowsay"
                If Strings.AvailableFeature(22) = 1 Then
                    TempUsage = TempUsage & "cowsay [STRING]"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_cowsay & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "codepoint"
                TempUsage = TempUsage & "codepoint"
                Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_codepoint & Environment.NewLine
                Console.BadCommand = False
            Case "del"
                If Strings.AvailableFeature(16) = 1 Then
                    TempUsage = TempUsage & "del [FILENAME.TXT]"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_del & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "dir"
                If Strings.AvailableFeature(16) = "1" Then
                    TempUsage = TempUsage & "dir"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_dir & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "guess"
                TempUsage = TempUsage & "guess"
                Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_guess & Environment.NewLine
                Console.BadCommand = False
            Case "help"
                TempUsage = TempUsage & "help"
                Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_help & Environment.NewLine
                Console.BadCommand = False
            Case "hostname"
                If Strings.AvailableFeature(20) = 1 Then
                    TempUsage = TempUsage & "hostname [HOSTNAME]"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_hostname & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "infobar"
                If Strings.AvailableFeature(4) = 1 Then
                    TempUsage = TempUsage & "infobar [ON|OFF] [OPTION]"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_infobar & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "man"
                If Strings.AvailableFeature(0) = "1" Then
                    TempUsage = TempUsage & "man [command]"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_man & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "mkdir"
                If Strings.AvailableFeature(16) = "1" Then
                    TempUsage = TempUsage & "mkdir [DIRECTORY]"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_mkdir & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "print"
                If Strings.AvailableFeature(2) = "1" Then
                    TempUsage = TempUsage & "print [text]"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_print & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "pwd"
                If Strings.AvailableFeature(16) = "1" Then
                    TempUsage = TempUsage & "pwd"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_pwd & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "reboot"
                TempUsage = TempUsage & "reboot"
                Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_reboot & Environment.NewLine
                Console.BadCommand = False
            Case "rmdir"
                If Strings.AvailableFeature(16) = "1" Then
                    TempUsage = TempUsage & "rmdir [DIRECTORY]"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_rmdir & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "shiftfetch"
                If Strings.AvailableFeature(8) = "1" Then
                    TempUsage = TempUsage & "shiftfetch"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_shiftfetch & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "shiftorium"
                TempUsage = TempUsage & "shiftorium [option] [featureName]"
                Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_shiftorium & Environment.NewLine
                Console.BadCommand = False
            Case "shutdown"
                TempUsage = TempUsage & "shutdown"
                Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_shutdown & Environment.NewLine
                Console.BadCommand = False
            Case "textpad"
                If Strings.AvailableFeature(17) = "1" Then
                    TempUsage = TempUsage & "textpad [FILENAME.TXT]"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_textpad & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "time"
                If Strings.AvailableFeature(17) = "1" Then
                    TempUsage = TempUsage & "time"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_time & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "username"
                If Strings.AvailableFeature(19) = "1" Then
                    TempUsage = TempUsage & "username"
                    Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_username & Environment.NewLine
                    Console.BadCommand = False
                End If
            Case "ver"
                TempUsage = TempUsage & "ver"
                Console.TextBox1.Text = Console.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_ver & Environment.NewLine
                Console.BadCommand = False
            Case Else
                NewLine("MAN : Invalid command")
        End Select
    End Sub

    Public Sub Shiftfetch()
        If Strings.OnceInfo(0) = "Yes" Then
            NewLine("                 :^!7?JJJJJ?7!^:                  root@" & Strings.ComputerInfo(0))
        Else
            NewLine("                 :^!7?JJJJJ?7!^:                  " & Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0))
        End If
        NewLine("            .~?PB###BGP555PGB###BP?~.             ----------------------")
        NewLine("        .!P#&B57^..:: ^~~!!~^::~7YG&#5!.          OS: ShiftOS TheRevival")
        NewLine("       .?#@G7: .^               :^::!5&#?.        Host: " & Environment.MachineName)
        NewLine("     .?#@5^  !                   .^!!..J&#?       Kernel: " & My.Resources.CurrentVersion)
        NewLine("    B@G^ .J                        : 7?..J@G:     Uptime : N/ A")
        NewLine("   ~&@Y  7         ~PB&#Y:.           ~G7 ~&&^    Packages: " & Strings.ComputerInfo(4))
        NewLine("  ^&@Y  Y         5#5??YB@&B~          .GJ :&&:   Shell: sos-justshell")
        NewLine("  G@B  ?         5P      ^YB!           .#! ~@G   Window Manager: -")
        NewLine(" ^@@! :          @Y   .:::^~:.           7#  Y@^  Window Manager Theme: -")
        NewLine(" 7@@: !          B@&BBBBGPPB@#Y.         :&^ ^@?  Terminal: shiftos-terminal")
        NewLine(" ?@@: 7          :??7~:.    5@@5         :&^ .&?  Terminal Font: Consolas, 11pt")
        NewLine(" ~@@! !@    G#&B!.          Y@@B         7#.  Y~  CPU: " & My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "ProcessorNameString", Nothing))
        NewLine("  B@G  B@J   ...~&G.       7@@@?        .#?   7   GPU: N/A")
        Dim TripleDigitRAM As String
        TripleDigitRAM = (My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024)
        NewLine("  ~&@? ^@Y       !G#57~~!YB@#Y^        .GP   ..   Memory: " & TripleDigitRAM.Substring(0, 4) & " GB")
        NewLine("   !@@7 ~#J        5#&&BG57^          ~BY         Codepoint: " & Strings.ComputerInfo(2))
        NewLine("    ~#@Y .5P~                       ^5G~          ")
        NewLine("     .J&#! ^JY!:.                ^?P5!            ")
        NewLine("       :J&B?..!JYY7!~::...::~!7Y5Y7:              ")
        NewLine("         .7PBP?^::~!?JJJJJJJ?7~:                  ")
        NewLine("            .~?55Y?!^:...                         ")
        NewLine("                 .:~~^~^^::.                      ")
    End Sub

    Public Sub TimeTerm()
        If Strings.AvailableFeature(5) = 1 Then
            NewLine(Math.Floor(Date.Now.Subtract(Date.Today).TotalSeconds) & " seconds passed since midnight")
        ElseIf Strings.AvailableFeature(5) = 3 Then
            If Strings.AvailableFeature(6) = 1 Then
                NewLine(Math.Floor(Date.Now.Subtract(Date.Today).TotalMinutes) & " minutes passed since midnight")
            ElseIf Strings.AvailableFeature(6) = 3 Then
                If Strings.AvailableFeature(7) = 1 Then
                    NewLine(Math.Floor(Date.Now.Subtract(Date.Today).TotalHours) & " hours passed since midnight")
                ElseIf Strings.AvailableFeature(7) = 3 Then
                    If Strings.AvailableFeature(12) = 1 Then
                        If Date.Now.Hour < 12 Then
                            NewLine("The time is " & TimeOfDay.Hour & " AM")
                        Else
                            NewLine("The time is " & TimeOfDay.Hour - 12 & " PM")
                        End If
                    ElseIf Strings.AvailableFeature(23) = 1 Then
                        NewLine("The time is " & TimeOfDay.Hour & ":" & TimeOfDay.Minute)
                    End If
                End If
            End If
        End If
    End Sub
End Module
