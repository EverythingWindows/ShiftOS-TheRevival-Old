Imports System.IO

Module TerminalExternalApps
    Public KeyInput As Keys

    Public Sub AppHost(App As Object, UseToolBar As Boolean)
        Select Case App
            'Revisit Later
            'Case "pause" 'Pause function
            '    Terminal.TextBox1.ReadOnly = True
            '    Terminal.DefaultPrompt = "Press any key to continue..."
            '    Terminal.CurrentInterpreter = "pause"
            '    FreezeText = Terminal.TextBox1.Text
            '    ShouldChange = True
            Case "shiftoriumfx" 'ShiftoriumFX : Advanced Shiftorium
                Console.DefaultPrompt = "Navigate> "
                Console.CurrentInterpreter = "shiftoriumfx"
                ShiftoriumFX_DisplayPackages()
                NewLine(Nothing)
                NewLine("Type any package you want to investigate")
                Console.ShouldChange = True
        End Select
        If Console.ReleaseCursor = True Then
            'Strings.OnceInfo(5) = Terminal.TrackPos
            'Terminal.TrackPos = Nothing
        End If
    End Sub


    Public Sub TerminateApp(KeyInput As Keys)
        Select Case Console.CurrentInterpreter
            Case "textpad"
                Dim BeforeCP As Integer = Strings.ComputerInfo(2)
                If File.Exists(Console.CurrentDirectory & "\" & command) = True Then
                    Dim TextCompare As String = My.Computer.FileSystem.ReadAllText(Console.CurrentDirectory & "\" & command)
                    If Console.TextBox1.Text = TextCompare Then
                        Console.TextBox1.Text = Nothing
                    Else
                        SaveFile(command)
                        TextPad_GenerateCP_SavedFile()
                        Dim AfterCP As Integer = Strings.ComputerInfo(2) - BeforeCP
                        Console.TextBox1.Text = "You've got " & AfterCP & " Codepoints"
                    End If
                Else
                    SaveFile(command)
                    TextPad_GenerateCP_SavedFile()
                    Dim AfterCP As Integer = Strings.ComputerInfo(2) - BeforeCP
                    Console.TextBox1.Text = "You've got " & AfterCP & " Codepoints"
                End If
                Console.ToolBarUse = False
                Console.ChangeInterpreter = False
                Console.ReleaseCursor = False
                Console.CurrentInterpreter = "terminal"
                Terminal_CheckFeature()
                Terminal_AssignPrompt()
                Terminal_PrintPrompt()
                TextRebind()
            Case Else
                Console.ToolBarUse = False
                Console.ChangeInterpreter = False
                Console.ReleaseCursor = False
                Console.CurrentInterpreter = "terminal"
                Terminal_CheckFeature()
                Terminal_AssignPrompt()
                Terminal_PrintPrompt()
                TextRebind()
        End Select
    End Sub

    Public Sub DoChildCommand()
        Select Case Console.CurrentInterpreter
            Case "guess"
                Select Case command
                    Case "exit"
                        TerminateApp(Nothing)
                    Case Else
                        Try
                            GTN_CheckNumber()
                        Catch ex As Exception
                            NewLine("Invalid value!")
                        End Try
                End Select
            Case "shiftoriumfx"
                Select Case command
                    Case ""

                    Case "exit"
                        TerminateApp(Nothing)
                    Case Else
                        ShiftoriumFX_DisplayPackages()
                        NewLine(Nothing)
                        NewLine("Type any package you want to investigate")
                        NewLine("Invalid package or bad command")
                End Select
            Case "bc"
                Select Case command
                    Case "jim"
                        NewLine("69, the funni number")
                        NewLine("gotcha!")
                    Case "ojas"
                        NewLine("dis calculator is very gud")
                        NewLine("it counts from another universe")
                    Case "exit"
                        TerminateApp(Nothing)
                    Case Else
                        BC_Calculate()
                End Select
            Case "mathquiz"
                Select Case command
                    Case "exit"
                        TerminateApp(Nothing)
                    Case Else
                        MQ_CheckAnswer()
                End Select
        End Select
    End Sub

    Public Sub ShOSKey_InputCommand(lastcommand As String)
        Console.ShOSKey = lastcommand
    End Sub

    Public Sub ShOSKey_Display()
        Console.TextBox1.Text = Console.TextBox1.Text & Console.ShOSKey
        Try
            Console.TrackPos = Console.ShOSKey.Length
        Catch ex As Exception
            Console.TrackPos = 0
        End Try
    End Sub

    Public Sub ShiftoriumFX_DisplayPackages()
        Console.TextBox1.Text = "Shiftorium FX!" & Environment.NewLine & "The place to shiftisize the ShiftOS" & Environment.NewLine & Environment.NewLine & "Available Package(s)"
        Shiftorium_ListFeatures()
    End Sub
End Module
