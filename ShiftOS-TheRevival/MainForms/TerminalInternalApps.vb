﻿Module TerminalInternalApps
    Public Sub Cowsay_Say(Say As String)
        Select Case Say.Length
            Case 1 To 40
                Dim SubtractLength As Integer = Say.Length + 1
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & " "
                Do
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & "_"
                    SubtractLength = SubtractLength - 1
                    If SubtractLength = 0 Then
                        Terminal.TextBox1.Text = Terminal.TextBox1.Text & "_"
                        SubtractLength = Say.Length + 1
                        Exit Do
                    End If
                Loop
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "< " & Say & " >"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & " "
                Do
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & "-"
                    SubtractLength = SubtractLength - 1
                    If SubtractLength = 0 Then
                        Terminal.TextBox1.Text = Terminal.TextBox1.Text & "-"
                        SubtractLength = Say.Length + 1
                        Exit Do
                    End If
                Loop
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "        \   ^__^"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "         \  (oo)\_______"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "            (__)\       )\/\"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "                ||----w |"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "                ||     ||"
            Case 41 To 80
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & " __________________________________________ "
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "/ " & Say.Substring(0, 40) & " \"
                Say = Say.Substring(40, Say.Length - 40)
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "\ " & Say
                Dim Spaces As Integer = 40 - Say.Length
                Do
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & " "
                    If Spaces = 0 Then
                        Terminal.TextBox1.Text = Terminal.TextBox1.Text & "/"
                        Exit Do
                    End If
                    Spaces = Spaces - 1
                Loop
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & " ------------------------------------------ "
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "        \   ^__^"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "         \  (oo)\_______"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "            (__)\       )\/\"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "                ||----w |"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "                ||     ||"
            Case >= 81
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "cowsay: Character limit exceeded"
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

    Public Sub Manual(Command As String)
        'MAN command starts with this kinda format
        'ShiftOS Help Manual
        '
        ''command' Usage: [switch/value if needed]
        '
        'Summary of the command's action
        '
        'Example usage : command
        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "ShiftOS Help Manual" & Environment.NewLine
        'Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & command.Substring(4)
        Dim mancommand As String = Command.Replace("man ", "")
        Dim TempUsage As String = "'" & mancommand & "' Usage: "
        Select Case mancommand
                        'In process to convert every command from printing from code to printing from text file
            Case "bc"
                If Strings.AvailableFeature(9) = "1" Then
                    TempUsage = TempUsage & "bc"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_bc & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "cd"
                If Strings.AvailableFeature(16) = "1" Then
                    TempUsage = TempUsage & "cd [DIRECTORY]"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_cd & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "clear"
                If Strings.AvailableFeature(1) = "1" Then
                    TempUsage = TempUsage & "clear"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_clear & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "color"
                TempUsage = TempUsage & "color [bg][fg]"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_color & Environment.NewLine
                Terminal.BadCommand = False
            Case "colors"
                TempUsage = TempUsage & "colors"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_colors & Environment.NewLine
                Terminal.BadCommand = False
            Case "cowsay"
                If Strings.AvailableFeature(22) = 1 Then
                    TempUsage = TempUsage & "cowsay [STRING]"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_cowsay & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "codepoint"
                TempUsage = TempUsage & "codepoint"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_codepoint & Environment.NewLine
                Terminal.BadCommand = False
            Case "del"
                If Strings.AvailableFeature(16) = 1 Then
                    TempUsage = TempUsage & "del [FILENAME.TXT]"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_del & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "dir"
                If Strings.AvailableFeature(16) = "1" Then
                    TempUsage = TempUsage & "dir"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_dir & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "guess"
                TempUsage = TempUsage & "guess"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_guess & Environment.NewLine
                Terminal.BadCommand = False
            Case "help"
                TempUsage = TempUsage & "help"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_help & Environment.NewLine
                Terminal.BadCommand = False
            Case "hostname"
                If Strings.AvailableFeature(20) = 1 Then
                    TempUsage = TempUsage & "hostname [HOSTNAME]"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_hostname & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "infobar"
                If Strings.AvailableFeature(4) = 1 Then
                    TempUsage = TempUsage & "infobar [ON|OFF] [OPTION]"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_infobar & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "man"
                If Strings.AvailableFeature(0) = "1" Then
                    TempUsage = TempUsage & "man [command]"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_man & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "mkdir"
                If Strings.AvailableFeature(16) = "1" Then
                    TempUsage = TempUsage & "mkdir [DIRECTORY]"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_mkdir & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "print"
                If Strings.AvailableFeature(2) = "1" Then
                    TempUsage = TempUsage & "print [text]"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_print & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "pwd"
                If Strings.AvailableFeature(16) = "1" Then
                    TempUsage = TempUsage & "pwd"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_pwd & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "reboot"
                TempUsage = TempUsage & "reboot"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_reboot & Environment.NewLine
                Terminal.BadCommand = False
            Case "rmdir"
                If Strings.AvailableFeature(16) = "1" Then
                    TempUsage = TempUsage & "rmdir [DIRECTORY]"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_rmdir & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "shiftfetch"
                If Strings.AvailableFeature(8) = "1" Then
                    TempUsage = TempUsage & "shiftfetch"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_shiftfetch & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "shiftorium"
                TempUsage = TempUsage & "shiftorium [option] [featureName]"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_shiftorium & Environment.NewLine
                Terminal.BadCommand = False
            Case "shutdown"
                TempUsage = TempUsage & "shutdown"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_shutdown & Environment.NewLine
                Terminal.BadCommand = False
            Case "textpad"
                If Strings.AvailableFeature(17) = "1" Then
                    TempUsage = TempUsage & "textpad [FILENAME.TXT]"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_textpad & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "time"
                If Strings.AvailableFeature(17) = "1" Then
                    TempUsage = TempUsage & "time"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_time & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "username"
                If Strings.AvailableFeature(19) = "1" Then
                    TempUsage = TempUsage & "username"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_username & Environment.NewLine
                    Terminal.BadCommand = False
                End If
            Case "ver"
                TempUsage = TempUsage & "ver"
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_ver & Environment.NewLine
                Terminal.BadCommand = False
            Case Else
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "MAN : Invalid command"
        End Select
    End Sub
End Module