Module IntroStoryTell
    Public NextChapter As Boolean

    Public Sub CheckNextChapterEligibility()
        Select Case Strings.ComputerInfo(3)
            Case 0
                If Strings.ComputerInfo(4) = 35 Then
                    Strings.ComputerInfo(3) = 1
                    NextChapter = True
                Else
                    NextChapter = False
                End If
        End Select
    End Sub

    Public Sub StoryLineIntro(Timestamp As Integer)
        Select Case Strings.ComputerInfo(3)
            Case 0
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
                        NewLine("To get the definitive guide on using ShiftOS, you can type 'guide' on ShiftOS")
                    Case 650
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
            Case 1
                Select Case Timestamp
                    Case 5
                        ResetLine("<null> Connected")
                    Case 25
                        NewLine("<null> : Hmmm, you've got your terminal explored enough, ay?")
                    Case 75
                        NewLine("<null> : I've seen your progress and let's just say, it's quite rough for me.")
                    Case 145
                        NewLine("<null> : Having to code each functions, programs, and applications while you are using it, haha.")
                    Case 180
                        NewLine("<null> : I think you've already push the boundary of command line interface for ShiftOS.")
                    Case 220
                        NewLine("<null> : Let me introduce you to my basic Window Manager for ShiftOS, DuWM.")
                    Case 270
                        NewLine("<null> : It is capable for handling 2 programs at the same time.")
                    Case 320
                        NewLine("<null> : And the window manager will evolve as you usually using it.")
                    Case 380
                        NewLine("<null> : Wonder why you cannot send a message to me while I'm communicating with you?")
                    Case 420 'That's the number baby!
                        NewLine("<null> : Because I only design this to do one-way communication, no reply whatsover.")
                    Case 475
                        NewLine("<null> : Anyways, you gotta have 200 codepoints to install DuWM")
                    Case 550
                        NewLine("<null> : Once you able to afford it and installing it, there's a guide to use the window manager")
                    Case 600
                        NewLine("<null> : Alright, I gotta go now and see you in the next progress.")
                    Case 630
                        NewLine("<null> Disconnected")
                    Case 675
                        Console.StoryOnlyTimer.Stop()
                        Console.TextBox1.Text = Nothing
                        Console.TextBox1.ReadOnly = False
                        Strings.AvailableFeature(35) = 0
                        Terminal_CheckFeature()
                        Terminal_PrintPrompt()
                        Terminal_AssignPrompt()
                        TextRebind()
                End Select
        End Select
    End Sub
End Module
