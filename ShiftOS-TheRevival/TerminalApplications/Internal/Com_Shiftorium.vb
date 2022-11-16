Module Com_Shiftorium
    Public Sub Shiftorium()
        Dim prompt As String = command.Replace("shiftorium ", "")
        NewLine("Shiftorium ShiftOS Center")
        If prompt Like "info *" Then
            Shiftoriums.prompt = command.Replace("shiftorium info ", "")
            Shiftorium_InformationFeatures()
        End If
        If prompt Like "install *" Then
            Shiftoriums.prompt = command.Replace("shiftorium install ", "")
            Shiftorium_DetectInstallFeatures()
        End If
        If prompt = "list" Then
            Shiftorium_ListFeatures()
            Console.BadCommand = False
        End If
    End Sub
End Module
