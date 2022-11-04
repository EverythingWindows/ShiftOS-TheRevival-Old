Module TerminalApps
    Public ShouldChange As Boolean = False
    'This is for GTN's RAM
    Public TheNumber As Integer = 0

    Public Sub ChangeCP(Addition As Boolean, NeededCP As Integer)
        Dim TempCP As Integer = Convert.ToInt32(Strings.ComputerInfo(2))
        If Addition = True Then
            TempCP = TempCP + NeededCP
        Else
            TempCP = TempCP - NeededCP
        End If
        Strings.ComputerInfo(2) = Convert.ToString(TempCP)
    End Sub

    Public Sub AppHost(App As Object)
        Select Case App
            Case "guess" 'Guess the Number
                Terminal.DefaultPrompt = "Your answer: "
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Guess the Number" & Environment.NewLine & "Guess the correct number between 1 and 50 and you'll get anything between 1 to 5 Codepoints" & Environment.NewLine & "Type 'exit' to terminate this game"
                Terminal.CurrentInterpreter = "guess"
                GTN_GenerateNumber()
                ShouldChange = True
            Case "shiftoriumfx"
                Terminal.DefaultPrompt = "Navigate> "
                Terminal.CurrentInterpreter = "shiftoriumfx"
                ShiftoriumFX_DisplayPackages()
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & Environment.NewLine & "Type any package you want to investigate"
                ShouldChange = True
        End Select
        If ShouldChange = True Then
            Terminal.ChangeInterpreter = True
            ShouldChange = False
        End If
    End Sub

    Public Sub TerminateApp()
        Terminal.ChangeInterpreter = False
        Terminal.CurrentInterpreter = "terminal"
        Terminal.PrintPrompt()
        Terminal.AssignPrompt()
    End Sub

    Public Sub DoChildCommand()
        Select Case Terminal.CurrentInterpreter
            Case "guess"
                Select Case Terminal.command
                    Case "exit"
                        TerminateApp()
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
                        TerminateApp()
                    Case Else
                        ShiftoriumFX_DisplayPackages()
                        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & Environment.NewLine & "Type any package you want to investigate" & Environment.NewLine & "Invalid package or bad command"
                End Select
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
                Dim GotCP As Integer = GetCP.Next(1, 6)
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

    Public Sub ShiftoriumFX_DisplayPackages()
        Terminal.TextBox1.Text = "Shiftorium FX!" & Environment.NewLine & "The place to shiftisize the ShiftOS" & Environment.NewLine & Environment.NewLine & "Available Package(s)"
        Shiftorium_ListFeatures()
    End Sub
End Module
