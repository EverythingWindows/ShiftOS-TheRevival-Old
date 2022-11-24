Module Com_Guide
    Public Sub Guide()
        NewLine("The Definitive Guide on ShiftOS")
        NewLine(Nothing)
        NewLine("ShiftOS is an experimental operating system set to revolutionize personal computing in a progressive way you can think of")
        Select Case Strings.ComputerInfo(3)
            Case 0
                NewLine("You are now in a command-line interface phase of ShiftOS. You can only do one program/task at one time.")
        End Select
        NewLine(Nothing)
        NewLine("To get a list of features available to purchase of ShiftOS, you can type 'shiftorium list'")
        NewLine("And you can buy a features on ShiftOS by typing 'shiftorium install ' and then type the codename of the feature")
        NewLine(Nothing)
        NewLine("Type 'help' to get a list of all commands available in ShiftOS")
        If Strings.AvailableFeature(0) = 1 Then
            NewLine("To get any help for each command in the operating system, you can type 'man' and the name of the feature")
            NewLine(Nothing)
        Else
            NewLine(Nothing)
        End If
        If Strings.ComputerInfo(7) IsNot "0" Then
            NewLine("You can run a graphical user Interface With its installed window manager And desktop environment by typing 'startg', and stopping it by typing 'stopg'")
            If IsStartG = True Then
                NewLine("To run a program, type 'app ' and the program's name, and 'applist' for getting list of available applications")
                NewLine(Nothing)
            Else
                NewLine(Nothing)
            End If
        End If
        If Strings.AvailableFeature(5) = 1 Then
            NewLine("Time is displayed by seconds since 0:00 format such as 660 seconds since midnight is 0:11")
        ElseIf Strings.AvailableFeature(5) = 3 Then
            If Strings.AvailableFeature(6) = 1 Then
                NewLine("Time is displayed by minutes since 0:00 format such as 69 minutes since midnight is 1:09")
            ElseIf Strings.AvailableFeature(6) = 3 Then
                If Strings.AvailableFeature(7) = 1 Then
                    NewLine("Time is displayed by hours since 0:00 format such as 19 hours since midnight is 19:00")
                ElseIf Strings.AvailableFeature(7) = 3 Then
                    If Strings.AvailableFeature(12) = 1 Then
                        NewLine("Time is displayed by PM and AM format, eg: 9 AM, 4 PM")
                    ElseIf Strings.AvailableFeature(12) = 3 Then
                        If Strings.AvailableFeature(23) = 1 Then
                            NewLine("Time is displayed by HH:MM format, eg: 4:20")
                        End If
                    End If
                End If
            End If
        End If
        If Strings.AvailableFeature(24) = 1 Then
            NewLine("Date is displayed in days since first day of the year format, such as 32 days since first day of the year is 1 February")
        ElseIf Strings.AvailableFeature(24) = 3 Then
            If Strings.AvailableFeature(25) = 1 Then
                NewLine("Date is displayed in weeks since first week of the year format, such as 10 weeks since first week of the year is approximately first week of March")
            ElseIf Strings.AvailableFeature(25) = 3 Then
                If Strings.AvailableFeature(26) = 1 Then
                    NewLine("Date is displayed in months since first month of the year format, such as 8 months since first month of the year is August")
                ElseIf Strings.AvailableFeature(26) = 3 Then
                    If Strings.AvailableFeature(27) = 1 Then
                        NewLine("Date is displayed in year format, eg: 2022")
                    ElseIf Strings.AvailableFeature(27) = 3 Then
                        If Strings.AvailableFeature(28) = 1 Then
                            NewLine("Date is displayed in MM/YYYY format, eg: 11/2022")
                        ElseIf Strings.AvailableFeature(28) = 3 Then
                            If Strings.AvailableFeature(29) = 1 Then
                                NewLine("Date is displayed in DD/MM/YYYY format, eg: 20/11/2022")
                            End If
                        End If
                    End If
                End If
            End If
        End If
        NewLine("This operating system supports ")
        If Strings.AvailableFeature(10) = 1 Then
            If Strings.AvailableFeature(13) = 1 Then
                If Strings.AvailableFeature(14) = 1 Then
                    If Strings.AvailableFeature(15) = 1 Then
                        AddLine("16 colors")
                    Else
                        AddLine("Black, Dark and Light Gray, White, as well as Red, Green, and Blue with their darker/brighter variant")
                    End If
                Else
                    AddLine("Black, Dark and Light Gray, White, as well as Red, Green, and Blue")
                End If
            Else
                AddLine("only in Black, Dark Gray, Light Gray, and White")
            End If
        Else
            AddLine("only 2 colors, Black and White")
        End If
        AddLine(". For more information, you can type 'colors' to get the list of supported colors.")
        NewLine(Nothing)
        If Strings.AvailableFeature(19) = 1 Then
            NewLine("You can change your username by typing 'username ' and the name of your username")
        End If
        If Strings.AvailableFeature(20) = 1 Then
            NewLine("You can change your computer name by typing 'hostname ' and the name of your hostname")
        End If
        NewLine(Nothing)
        NewLine("You can get more codepoints by guessing the correct number with 'guess'")
        If Strings.AvailableFeature(17) = 1 Then
            AddLine(", writing a text document in 'textpad'")
        End If
        If Strings.AvailableFeature(34) = 1 Then
            AddLine(", answer basic arithmatical question on 'mathquiz'")
        End If
        If IsStartG = True Then
            If Strings.AvailableFeature(37) = 1 Then
                AddLine(", guess as many things as you can in 'knowledge_input'")
            End If
        End If
        AddLine(".")
    End Sub
End Module
