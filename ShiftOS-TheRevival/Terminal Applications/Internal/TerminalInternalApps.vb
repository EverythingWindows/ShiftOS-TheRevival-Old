Module TerminalInternalApps
    Public Sub Cowsay_Say(Say As String)

    End Sub

    Public Sub DateTerm()

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
End Module
