Module Com_App
    Public AppName As String

    Public Sub App()
        AppName = command.Substring(4)
        Select Case Strings.ComputerInfo(7)
            Case 1
                Select Case AppName
                    Case "shifter"
                        DuWM_NewProcess(DuWM_Shifter)
                End Select
        End Select
    End Sub
End Module
