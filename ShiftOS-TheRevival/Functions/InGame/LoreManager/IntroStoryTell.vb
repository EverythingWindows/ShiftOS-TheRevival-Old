Module IntroStoryTell
    Public Sub StoryLineIntro(Timestamp As Integer)
        Select Case Strings.ComputerInfo(3)
            Case "0"
                Select Case Timestamp
                    Case 5
                        ResetLine("Connected to <null>")
                    Case 25
                        NewLine("<null>: Hey there, Unknown user!")
                    Case 60
                        NewLine("<null>: Congratulaions! You have been involuntarily selected for a test on my experimental operating system, ShiftOS.")
                    Case 125
                        NewLine("<null>: ShiftOS is an operating system that will evolve itself as you use it as I progressively add more features into ShiftOS.")
                    Case 160
                        NewLine("<null>: Currently ShiftOS isn't much from a basic command-line operating system.")
                    Case 210
                        NewLine("<null>: I don't wish to reveal my indentity at this point in time.")
                    Case 270
                        NewLine("<null>: I will install ShiftOS on your system once I leave while I work on... something else.")
                    Case 335
                        NewLine("<null>: Once you have ShiftOS rich feature enough, I will come back to you. In the mean time, goodbye!")
                    Case 400
                        NewLine("<null> Disconnected")
                    Case 430
                        ResetLine("Installing ShiftOS...")
                    Case 550
                        ResetLine("ShiftOS Installed, The computer will restart in a few seconds")
                    Case 600
                        Console.StoryOnlyTimer.Stop()
                        Console.TextBox1.Text = Nothing
                        Console.TextBox1.ReadOnly = False
                        Strings.ComputerInfo(0) = "shiftos"
                        Strings.ComputerInfo(1) = "user"
                        Terminal_CheckFeature()
                        Terminal_PrintPrompt()
                        Terminal_AssignPrompt()
                        TextRebind()
                End Select
        End Select
    End Sub
End Module
