Module Com_Username
    Public Sub Username()
        Strings.ComputerInfo(1) = command.Substring(command.LastIndexOf(" ") + 1, command.Length - (command.LastIndexOf(" ") + 1))
        Terminal_AssignPrompt()
    End Sub
End Module
