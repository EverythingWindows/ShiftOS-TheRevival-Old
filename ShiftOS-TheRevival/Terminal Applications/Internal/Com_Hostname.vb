Module Com_Hostname
    Public Sub Hostname()
        Strings.ComputerInfo(0) = command.Substring(command.LastIndexOf(" ") + 1, command.Length - (command.LastIndexOf(" ") + 1))
        Terminal_AssignPrompt()
    End Sub
End Module
