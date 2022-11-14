Module Com_Help
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
End Module
