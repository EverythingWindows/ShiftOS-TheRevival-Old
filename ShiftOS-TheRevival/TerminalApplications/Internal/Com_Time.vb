Module Com_Time
    Public Sub Terminal_Time()
        If Strings.AvailableFeature(5) = 1 Then
            NewLine(Math.Floor(Date.Now.Subtract(Date.Today).TotalSeconds) & " seconds passed since midnight")
        ElseIf Strings.AvailableFeature(5) = 3 Then
            If Strings.AvailableFeature(6) = 1 Then
                NewLine(Math.Floor(Date.Now.Subtract(Date.Today).TotalMinutes) & " minutes passed since midnight")
            ElseIf Strings.AvailableFeature(6) = 3 Then
                If Strings.AvailableFeature(7) = 1 Then
                    NewLine(Math.Floor(Date.Now.Subtract(Date.Today).TotalHours) & " hours passed since midnight")
                ElseIf Strings.AvailableFeature(7) = 3 Then
                    If Strings.AvailableFeature(12) = 1 Then
                        If Date.Now.Hour < 12 Then
                            NewLine("The time is " & TimeOfDay.Hour & " AM")
                        Else
                            NewLine("The time is " & TimeOfDay.Hour - 12 & " PM")
                        End If
                    ElseIf Strings.AvailableFeature(23) = 1 Then
                        NewLine("The time is " & TimeOfDay.Hour & ":" & TimeOfDay.Minute)
                    End If
                End If
            End If
        End If
    End Sub
End Module
