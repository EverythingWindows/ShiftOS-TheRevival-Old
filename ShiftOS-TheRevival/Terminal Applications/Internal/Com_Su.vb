Module Com_Su
    Public Sub Terminal_Su()
        If Strings.OnceInfo(0) = "Yes" Then
            NewLine("You already in root mode!")
        Else
            Strings.OnceInfo(0) = "Yes"
            Terminal_AssignPrompt()
        End If
    End Sub
End Module
