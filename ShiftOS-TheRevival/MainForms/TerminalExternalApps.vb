Imports System.IO

Module TerminalExternalApps
    Public ShouldChange As Boolean = False
    Public KeyInput As Keys
    'This is for GTN's RAM
    Public TheNumber As Integer = 0
    Public FreezeText As String
    'Basic Calculator's RAM
    Public BC_ReadNumbers As Integer
    Public BC_Numbers1 As String
    Public BC_Numbers2 As String
    Public BC_ThriceMoreValue As Integer
    Public BC_ThriceMoreCount As Integer
    Public BC_CurrentNumber As String
    Public BC_Result As Integer
    Public BC_Operation2 As String
    'TextPad's RAM
    Public TextPad_FileName As String
    Public TextPad_TempText As New Timer

    Public Sub ChangeCP(Addition As Boolean, NeededCP As Integer)
        Dim TempCP As Integer = Convert.ToInt32(Strings.ComputerInfo(2))
        If Addition = True Then
            TempCP = TempCP + NeededCP
        Else
            TempCP = TempCP - NeededCP
        End If
        Strings.ComputerInfo(2) = Convert.ToString(TempCP)
    End Sub

    Public Sub AppHost(App As Object, UseToolBar As Boolean)
        Select Case App
            Case "bc"
                Console.DefaultPrompt = "> "
                ResetLine("bc (Basic Calcultator)")
                NewLine("Copyright, Free Software Foundation.")
                NewLine("ShiftOS port by DevX.")
                NewLine("This is free software with ABSOLUTELY NO WARRANTY.")
                NewLine(Nothing)
                Console.CurrentInterpreter = "bc"
                ShouldChange = True
            Case "guess" 'Guess the Number
                Console.DefaultPrompt = "Your answer: "
                NewLine("Guess the Number")
                NewLine("Guess the correct number between 1 and 50 and you'll get anything between 1 to 10 Codepoints")
                NewLine("Type 'exit' to terminate this game")
                Console.CurrentInterpreter = "guess"
                GTN_GenerateNumber()
                ShouldChange = True
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
                ShouldChange = True
            Case "textpad"
                Console.DefaultPrompt = Nothing
                Console.TextBox1.Text = Nothing
                Console.ToolBarUse = True
                Console.CheckFeature()
                Console.CurrentInterpreter = "textpad"
                TextPad_CheckExist(command)
                Console.ToolBar.Text = "TextPad - " & command & Environment.NewLine & "Ctrl-Q Exit | Ctrl-N New | Ctrl-O Open | Ctrl-S Save | F12 Save As"
                Console.ReleaseCursor = True
                TextRebind()
        End Select
        If Console.ReleaseCursor = True Then
            'Strings.OnceInfo(5) = Terminal.TrackPos
            'Terminal.TrackPos = Nothing
        End If
        If ShouldChange = True Then
            Console.ChangeInterpreter = True
            ShouldChange = False
        End If
    End Sub

    Public Sub CaptureKeyBinding(KeysInput As Keys)
        Select Case KeysInput
            Case (Keys.S + Keys.Control)
                Select Case Console.CurrentInterpreter
                    Case "textpad"
                        If File.Exists(Console.CurrentDirectory & "\" & command) = True Then
                            Dim TempCompare As String = File.ReadAllText(Console.CurrentDirectory & "\" & command)
                            If Console.TextBox1.Text = TempCompare Then

                            Else
                                Dim BeforeCP As Integer = Strings.ComputerInfo(2)
                                SaveFile(command)
                                TextPad_GenerateCP_SavedFile()
                                Dim AfterCP As Integer = Strings.ComputerInfo(2) - BeforeCP
                                Console.ToolBar.Text = "TextPad - " & command & " - You've got " & AfterCP & " Codepoints" & Environment.NewLine & "Ctrl-Q Exit | Ctrl-N New | Ctrl-O Open | Ctrl-S Save | F12 Save As"
                            End If
                        Else
                            Dim BeforeCP As Integer = Strings.ComputerInfo(2)
                            SaveFile(command)
                            TextPad_GenerateCP_SavedFile()
                            Dim AfterCP As Integer = Strings.ComputerInfo(2) - BeforeCP
                            Console.ToolBar.Text = "TextPad - " & command & " - You've got " & AfterCP & " Codepoints" & Environment.NewLine & "Ctrl-Q Exit | Ctrl-N New | Ctrl-O Open | Ctrl-S Save | F12 Save As"
                        End If
                End Select
            Case (Keys.N + Keys.Control)
                Select Case Console.CurrentInterpreter
                    Case "textpad"
                        Console.TextBox1.Text = Nothing
                End Select
        End Select
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
                Console.CheckFeature()
                Terminal_AssignPrompt()
                Terminal_PrintPrompt()
                TextRebind()
            Case Else
                Console.ToolBarUse = False
                Console.ChangeInterpreter = False
                Console.ReleaseCursor = False
                Console.CurrentInterpreter = "terminal"
                Console.CheckFeature()
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
                        BC_ReadNumbers = 0
                        BC_ThriceMoreValue = 1
                        BC_Numbers1 = Nothing
                        BC_Numbers2 = Nothing
                        BC_Operation2 = Nothing
                        BC_CurrentNumber = Nothing
                        BC_Result = Nothing
                        Dim GetText As String
                        Try
                            Do
                                GetText = command.Chars(BC_ReadNumbers)
                                Select Case GetText
                                    Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
                                        BC_CurrentNumber = BC_CurrentNumber & GetText
                                    Case "+", "-", "*", "/"
                                        Dim BC_Numbers3 As Integer
                                        Select Case BC_ThriceMoreValue
                                            Case 1
                                                BC_Numbers1 = BC_CurrentNumber
                                                BC_CurrentNumber = Nothing
                                                BC_Operation2 = GetText
                                                BC_ThriceMoreValue = BC_ThriceMoreValue + 1
                                            Case >= 2
                                                BC_Numbers2 = BC_CurrentNumber
                                                BC_Counting(BC_Numbers1, BC_Numbers2, BC_Operation2)
                                                BC_Numbers3 = BC_Result
                                                BC_Numbers1 = BC_Numbers3
                                                BC_Numbers2 = Nothing
                                                BC_CurrentNumber = Nothing
                                                BC_ThriceMoreValue = BC_ThriceMoreValue + 1
                                        End Select
                                        BC_Operation2 = GetText
                                    Case "."
                                        Console.TextBox1.Text = Console.TextBox1.Text & "Decimals aren't supported yet!"
                                    Case Else
                                        'BC_Counting(BC_Numbers1, BC_Numbers2, BC_Operation2)
                                End Select
                                BC_ReadNumbers = BC_ReadNumbers + 1
                            Loop
                        Catch ex As Exception
                            BC_Numbers2 = BC_CurrentNumber
                            BC_CurrentNumber = Nothing
                        End Try
                        BC_Counting(BC_Numbers1, BC_Numbers2, BC_Operation2)
                        BC_ThriceMoreValue = Nothing
                        NewLine(BC_Result)
                End Select
        End Select
    End Sub

    Public Sub BC_Counting(FirstNum As Integer, SecondNum As Integer, Operation As String)
        Select Case Operation
            Case "+"
                BC_Result = FirstNum + SecondNum
            Case "-"
                BC_Result = FirstNum - SecondNum
            Case "*"
                BC_Result = FirstNum * SecondNum
            Case "/"
                BC_Result = FirstNum / SecondNum
        End Select
    End Sub

    Public Sub GTN_GenerateNumber()
        Dim RandNum As New Random
        TheNumber = RandNum.Next(1, 51)
    End Sub

    Public Sub GTN_CheckNumber()
        Dim TheirNumber As Integer = Convert.ToInt32(command)
        If TheirNumber > 0 And TheirNumber < 51 Then
            If TheirNumber = TheNumber Then
                Dim GetCP As New Random
                Dim GotCP As Integer = GetCP.Next(1, 11)
                ChangeCP(True, GotCP)
                NewLine("You are correct!, you got " & GotCP & " Codepoint(s)")
                NewLine("Guess the new number between 1 and 50.")
                GTN_GenerateNumber()
            Else
                If TheirNumber < TheNumber Then
                    NewLine("Higher!")
                ElseIf TheirNumber > TheNumber Then
                    NewLine("Lower!")
                End If
            End If
        End If
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

    Public Sub TextPad_CheckExist(TxtFileName As String)
        If File.Exists(Console.CurrentDirectory & "\" & TxtFileName) = True Then
            Console.TextBox1.Text = My.Computer.FileSystem.ReadAllText(Console.CurrentDirectory & "\" & TxtFileName)
        End If
    End Sub

    Public Sub TextPad_GenerateCP_SavedFile()
        Select Case Console.TextBox1.TextLength
            Case 1 To 9
                Dim GetCP As New Random
                Dim GotCP As Integer = GetCP.Next(1, 3)
                ChangeCP(True, GotCP)
            Case 10 To 99
                Dim GetCP As New Random
                Dim GotCP As Integer = GetCP.Next(4, 26)
                ChangeCP(True, GotCP)
            Case 100 To 999
                Dim GetCP As New Random
                Dim GotCP As Integer = GetCP.Next(27, 251)
                ChangeCP(True, GotCP)
            Case 1000 To 9999
                Dim GetCP As New Random
                Dim GotCP As Integer = GetCP.Next(252, 2501)
                ChangeCP(True, GotCP)
        End Select
    End Sub

    Public Sub ShiftoriumFX_DisplayPackages()
        Console.TextBox1.Text = "Shiftorium FX!" & Environment.NewLine & "The place to shiftisize the ShiftOS" & Environment.NewLine & Environment.NewLine & "Available Package(s)"
        Shiftorium_ListFeatures()
    End Sub
End Module
