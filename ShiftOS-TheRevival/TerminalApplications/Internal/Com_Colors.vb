Module Com_Colors
    Public Sub Colors()
        NewLine("TERMINAL SUPPORTED COLORS")
        NewLine(Nothing)
        NewLine(Nothing)
        If Strings.AvailableFeature(10) = "1" Then
            NewLine("0 = Black      8 = Gray")
        Else
            NewLine("0 = Black      8 = ???")
        End If
        If Strings.AvailableFeature(14) = "1" Then
            NewLine("1 = Blue       9 = Light Blue")
            NewLine("2 = Green      A = Light Green")
        Else
            If Strings.AvailableFeature(13) = "1" Then
                NewLine("1 = ???        9 = Light Blue")
                NewLine("2 = Green      A = ???")
            Else
                NewLine("1 = ???        9 = ???")
                NewLine("2 = ???        A = ???")
            End If
        End If
        If Strings.AvailableFeature(15) = "1" Then
            NewLine("3 = Aqua       B = Light Aqua")
        Else
            NewLine("3 = ???        B = ???")
        End If
        If Strings.AvailableFeature(14) = "1" Then
            NewLine("4 = Red        C = Light Red")
        ElseIf Strings.AvailableFeature(13) = "1" Then
            NewLine("4 = ???        C = Light Red")
        Else
            NewLine("4 = ???        C = ???")
        End If
        If Strings.AvailableFeature(15) = "1" Then
            NewLine("5 = Purple     D = Light Purple")
            NewLine("6 = Yellow     E = Dark Yellow")
        Else
            NewLine("5 = ???        D = ???")
            NewLine("6 = ???        E = ???")
        End If
        If Strings.AvailableFeature(10) = "1" Then
            NewLine("7 = Dark Gray  F = White")
        Else
            NewLine("7 = ???        F = White")
        End If
    End Sub
End Module
