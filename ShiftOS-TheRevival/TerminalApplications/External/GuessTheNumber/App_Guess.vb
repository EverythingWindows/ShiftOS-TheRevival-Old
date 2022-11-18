Module App_Guess
    'This is for GTN's RAM
    Public TheNumber As Integer = 0
    Public FreezeText As String

    Public Sub GTN_Start()
        Console.DefaultPrompt = "Your answer: "
        NewLine("Guess the Number")
        NewLine("Guess the correct number between 1 and 50 and you'll get anything between 1 to 10 Codepoints")
        NewLine("Type 'exit' to terminate this game")
        Console.CurrentInterpreter = "guess"
        GTN_GenerateNumber()
        Console.ShouldChange = True
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
End Module
