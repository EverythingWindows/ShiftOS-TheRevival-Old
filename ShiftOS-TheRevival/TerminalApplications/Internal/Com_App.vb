Module Com_App
    Public AppName As String

    Public Sub App()
        AppName = command.Substring(4)
        Select Case Strings.ComputerInfo(7)
            Case 1
                Select Case AppName
                    Case "knowledge_input"
                        If Strings.AvailableFeature(37) = 1 Then
                            DuWM_NewProcess(Uni_KnowledgeInput)
                        End If
                    Case "shifter"
                        If Strings.AvailableFeature(36) = 1 Then
                            DuWM_NewProcess(DuWM_Shifter)
                        End If
                    Case "file_skimmer"
                        DuWM_NewProcess(Uni_FileSkimmer)
                End Select
        End Select
    End Sub
End Module
