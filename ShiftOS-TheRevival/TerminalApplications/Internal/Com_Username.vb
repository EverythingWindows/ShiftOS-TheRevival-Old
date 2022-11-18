Module Com_Username
    Public NewUsername As String

    Public Sub Username()
        NewUsername = command.Substring(command.LastIndexOf(" ") + 1, command.Length - (command.LastIndexOf(" ") + 1))
        If NewUsername = "" Then
            NewLine("A username should not be blank")
        Else
            Strings.ComputerInfo(1) = NewUsername
        End If
        Terminal_AssignPrompt()
    End Sub
End Module
