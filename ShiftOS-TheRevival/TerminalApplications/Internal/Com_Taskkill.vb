Module Com_Taskkill
    Public Sub Taskkill()
        Dim PID As Integer = command.Substring(9)
        If PID = 0 Then
            NewLine("You cannot kill Terminal in this Window Manager")
        Else
            Strings.ProcessID(PID) = 0
        End If
    End Sub
End Module
