Imports System.IO

Module TerminalApps
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
                Terminal.DefaultPrompt = "> "
                Terminal.TextBox1.Text = "bc (Basic Calcultator)" & Environment.NewLine & "Copyright, Free Software Foundation." & Environment.NewLine & "ShiftOS port by DevX." & Environment.NewLine & "This is free software with ABSOLUTELY NO WARRANTY." & Environment.NewLine
                Terminal.CurrentInterpreter = "bc"
                ShouldChange = True
            Case "guess" 'Guess the Number
                Terminal.DefaultPrompt = "Your answer: "
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Guess the Number" & Environment.NewLine & "Guess the correct number between 1 and 50 and you'll get anything between 1 to 10 Codepoints" & Environment.NewLine & "Type 'exit' to terminate this game"
                Terminal.CurrentInterpreter = "guess"
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
                Terminal.DefaultPrompt = "Navigate> "
                Terminal.CurrentInterpreter = "shiftoriumfx"
                ShiftoriumFX_DisplayPackages()
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & Environment.NewLine & "Type any package you want to investigate"
                ShouldChange = True
            Case "textpad"
                Terminal.DefaultPrompt = Nothing
                Terminal.TextBox1.Text = Nothing
                Terminal.ToolBarUse = True
                Terminal.CheckFeature()
                Terminal.CurrentInterpreter = "textpad"
                TextPad_CheckExist(Terminal.command)
                Terminal.ToolBar.Text = "TextPad - " & Terminal.command & Environment.NewLine & "Ctrl-Q Exit | Ctrl-N New | Ctrl-O Open | Ctrl-S Save | F12 Save As"
                Terminal.ReleaseCursor = True
        End Select
        If Terminal.ReleaseCursor = True Then
            'Strings.OnceInfo(5) = Terminal.TrackPos
            'Terminal.TrackPos = Nothing
        End If
        If ShouldChange = True Then
            Terminal.ChangeInterpreter = True
            ShouldChange = False
        End If
    End Sub

    Public Sub CaptureKeyBinding(KeysInput As Keys)
        Select Case KeysInput
            Case (Keys.S + Keys.Control)
                If File.Exists(Terminal.CurrentDirectory & "\" & Terminal.command) = True Then
                    Dim TempCompare As String = File.ReadAllText(Terminal.CurrentDirectory & "\" & Terminal.command)
                    If Terminal.TextBox1.Text = TempCompare Then

                    Else
                        Dim BeforeCP As Integer = Strings.ComputerInfo(2)
                        SaveFile(Terminal.command)
                        TextPad_GenerateCP_SavedFile()
                        Dim AfterCP As Integer = Strings.ComputerInfo(2) - BeforeCP
                        Terminal.ToolBar.Text = "TextPad - " & Terminal.command & " - You've got " & AfterCP & " Codepoints" & Environment.NewLine & "Ctrl-Q Exit | Ctrl-N New | Ctrl-O Open | Ctrl-S Save | F12 Save As"
                    End If
                Else
                    Dim BeforeCP As Integer = Strings.ComputerInfo(2)
                    SaveFile(Terminal.command)
                    TextPad_GenerateCP_SavedFile()
                    Dim AfterCP As Integer = Strings.ComputerInfo(2) - BeforeCP
                    Terminal.ToolBar.Text = "TextPad - " & Terminal.command & " - You've got " & AfterCP & " Codepoints" & Environment.NewLine & "Ctrl-Q Exit | Ctrl-N New | Ctrl-O Open | Ctrl-S Save | F12 Save As"
                End If
        End Select
    End Sub

    Public Sub TerminateApp(KeyInput As Keys)
        Select Case Terminal.CurrentInterpreter
            Case "textpad"
                Dim BeforeCP As Integer = Strings.ComputerInfo(2)
                If File.Exists(Terminal.CurrentDirectory & "\" & Terminal.command) = True Then
                    Dim TextCompare As String = My.Computer.FileSystem.ReadAllText(Terminal.CurrentDirectory & "\" & Terminal.command)
                    If Terminal.TextBox1.Text = TextCompare Then
                        Terminal.TextBox1.Text = Nothing
                    Else
                        SaveFile(Terminal.command)
                        TextPad_GenerateCP_SavedFile()
                        Dim AfterCP As Integer = Strings.ComputerInfo(2) - BeforeCP
                        Terminal.TextBox1.Text = "You've got " & AfterCP & " Codepoints"
                    End If
                Else
                    SaveFile(Terminal.command)
                    TextPad_GenerateCP_SavedFile()
                    Dim AfterCP As Integer = Strings.ComputerInfo(2) - BeforeCP
                    Terminal.TextBox1.Text = "You've got " & AfterCP & " Codepoints"
                End If
                Terminal.ToolBarUse = False
                Terminal.ChangeInterpreter = False
                Terminal.ReleaseCursor = False
                Terminal.CurrentInterpreter = "terminal"
                Terminal.CheckFeature()
                Terminal.AssignPrompt()
                Terminal.PrintPrompt()
                Terminal.TextRebind()
            Case Else
                Terminal.ToolBarUse = False
                Terminal.ChangeInterpreter = False
                Terminal.ReleaseCursor = False
                Terminal.CurrentInterpreter = "terminal"
                Terminal.CheckFeature()
                Terminal.AssignPrompt()
                Terminal.TextRebind()
        End Select
    End Sub

    Public Sub DoChildCommand()
        Select Case Terminal.CurrentInterpreter
            Case "guess"
                Select Case Terminal.command
                    Case "exit"
                        TerminateApp(Nothing)
                    Case Else
                        Try
                            GTN_CheckNumber()
                        Catch ex As Exception
                            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Invalid value!"
                        End Try
                End Select
            Case "shiftoriumfx"
                Select Case Terminal.command
                    Case ""

                    Case "exit"
                        TerminateApp(Nothing)
                    Case Else
                        ShiftoriumFX_DisplayPackages()
                        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & Environment.NewLine & "Type any package you want to investigate" & Environment.NewLine & "Invalid package or bad command"
                End Select
            Case "bc"
                Select Case Terminal.command
                    Case "jim"
                        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "69, the funni number" & Environment.NewLine & "gotcha!"
                    Case "ojas"
                        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "dis calculator is very gud" & Environment.NewLine & "it counts from another universe"
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
                                GetText = Terminal.command.Chars(BC_ReadNumbers)
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
                                        Terminal.TextBox1.Text = Terminal.TextBox1.Text & "Decimals aren't supported yet!"
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
                        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & BC_Result
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
        Dim TheirNumber As Integer = Convert.ToInt32(Terminal.command)
        If TheirNumber > 0 And TheirNumber < 51 Then
            If TheirNumber = TheNumber Then
                Dim GetCP As New Random
                Dim GotCP As Integer = GetCP.Next(1, 11)
                ChangeCP(True, GotCP)
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "You are correct!, you got " & GotCP & " Codepoint(s)" & Environment.NewLine & "Guess the new number between 1 and 50."
                GTN_GenerateNumber()
            Else
                If TheirNumber < TheNumber Then
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Higher!"
                ElseIf TheirNumber > TheNumber Then
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Lower!"
                End If
            End If
        End If
    End Sub

    Public Sub TextPad_CheckExist(TxtFileName As String)
        If File.Exists(Terminal.CurrentDirectory & "\" & TxtFileName) = True Then
            Terminal.TextBox1.Text = My.Computer.FileSystem.ReadAllText(Terminal.CurrentDirectory & "\" & TxtFileName)
        End If
    End Sub

    Public Sub TextPad_GenerateCP_SavedFile()
        Select Case Terminal.TextBox1.TextLength
            Case 1 To 9
                Dim GetCP As New Random
                Dim GotCP As Integer = GetCP.Next(1, 6)
                ChangeCP(True, GotCP)
            Case 10 To 99
                Dim GetCP As New Random
                Dim GotCP As Integer = GetCP.Next(1, 51)
                ChangeCP(True, GotCP)
            Case 100 To 999
                Dim GetCP As New Random
                Dim GotCP As Integer = GetCP.Next(1, 501)
                ChangeCP(True, GotCP)
            Case 1000 To 9999
                Dim GetCP As New Random
                Dim GotCP As Integer = GetCP.Next(1, 5001)
                ChangeCP(True, GotCP)
        End Select
    End Sub

    Public Sub ShiftoriumFX_DisplayPackages()
        Terminal.TextBox1.Text = "Shiftorium FX!" & Environment.NewLine & "The place to shiftisize the ShiftOS" & Environment.NewLine & Environment.NewLine & "Available Package(s)"
        Shiftorium_ListFeatures()
    End Sub
End Module
