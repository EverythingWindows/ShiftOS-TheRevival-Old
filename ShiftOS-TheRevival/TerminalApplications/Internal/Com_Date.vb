Module Com_Date
    Public Sub Terminal_Date()
        If Strings.AvailableFeature(24) = 1 Then
            NewLine("The date is " & Date.Now.DayOfYear & " days since the first day of the year")
            AdvancedCommand = False
            NormalCommand()
        ElseIf Strings.AvailableFeature(24) = 3 Then
            If Strings.AvailableFeature(25) = 1 Then
                Dim TheWeek As String = Date.Now.DayOfYear / 7
                NewLine("The date is " & TheWeek.Substring(0, 2) & " weeks since the first week of the year")
                AdvancedCommand = False
                NormalCommand()
            ElseIf Strings.AvailableFeature(25) = 3 Then
                If Strings.AvailableFeature(26) = 1 Then
                    NewLine("The date is " & Date.Now.Month & " months since the first month of the year")
                    AdvancedCommand = False
                    NormalCommand()
                ElseIf Strings.AvailableFeature(26) = 3 Then
                    If Strings.AvailableFeature(27) = 1 Then
                        NewLine("The year is " & Date.Now.Year)
                        AdvancedCommand = False
                        NormalCommand()
                    ElseIf Strings.AvailableFeature(27) = 3 Then
                        If Strings.AvailableFeature(28) = 1 Then
                            NewLine("The date is " & Date.Now.Day & "/" & Date.Now.Month)
                            AdvancedCommand = False
                            NormalCommand()
                        ElseIf Strings.AvailableFeature(28) = 3 Then
                            If Strings.AvailableFeature(29) = 1 Then
                                NewLine("The date is " & Date.Now.Day & "/" & Date.Now.Month & "/" & Date.Now.Year)
                                AdvancedCommand = False
                                NormalCommand()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Module
