Module TerminalAPI
    Public command As String
    Public AdvancedCommand As Boolean
    Public RawCommand As String

    Public Sub Terminal_ReadCommand()
        command = Console.TextBox1.Lines(Console.TextBox1.Lines.Length - 1)
        If Console.DefaultPrompt = Nothing Then
        Else
            command = command.Replace(Console.DefaultPrompt, "")
        End If
        RawCommand = command
        command = command.ToLower()
    End Sub

    Public Sub Terminal_PrintPrompt()
        If Console.TextBox1.Text = Nothing Then
            If Console.ChangeInterpreter = True Then
                NewLine(Console.DefaultPrompt)
            Else
                If Strings.OnceInfo(0) = "Yes" Then
                    ResetLine("root@" & Strings.ComputerInfo(0) & " #> ")
                Else
                    ResetLine(Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> ")
                End If
            End If
        Else
            If Console.ChangeInterpreter = True Then
                NewLine(Console.DefaultPrompt)
            Else
                If Strings.OnceInfo(0) = "Yes" Then
                    NewLine("root@" & Strings.ComputerInfo(0) & " #> ")
                Else
                    NewLine(Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> ")
                End If
            End If
        End If
    End Sub

    Public Sub Terminal_AssignPrompt()
        If Console.ChangeInterpreter = False Then
            If Strings.OnceInfo(0) = "Yes" Then
                Console.DefaultPrompt = "root@" & Strings.ComputerInfo(0) & " #> "
            Else
                Console.DefaultPrompt = Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> "
            End If
        End If
    End Sub
End Module
