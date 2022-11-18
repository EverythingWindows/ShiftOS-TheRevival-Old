Module Com_Hostname
    Public NewHostname As String

    Public Sub Hostname()
        NewHostname = command.Substring(command.LastIndexOf(" ") + 1, command.Length - (command.LastIndexOf(" ") + 1))
        If NewHostname = "" Then
            NewLine("A hostname should not be blank!")
        Else
            Strings.ComputerInfo(0) = NewHostname
        End If
        Terminal_AssignPrompt()
    End Sub
End Module
