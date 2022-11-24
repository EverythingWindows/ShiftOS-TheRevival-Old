Module Com_App
    Public AppName As String

    Public Sub App()
        AppName = command.Substring(4)
        Select Case Strings.ComputerInfo(7)
            Case 1
                Select Case AppName
                    Case "knowledge_input"
                        DuWM_NewProcess(Uni_KnowledgeInput)
                    Case "shifter"
                        If Strings.AvailableFeature(36) = 0 Then
                            DuWM_NewProcess(DuWM_Shifter)
                        End If
                End Select
        End Select
    End Sub
End Module
