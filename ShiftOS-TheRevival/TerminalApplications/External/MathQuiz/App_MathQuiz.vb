Module App_MathQuiz
    Public MQ_1stNum As Integer
    Public MQ_2ndNum As Integer
    Public MQ_Operation As String
    Public MQ_ShouldResult As Integer
    Public OperationChooser As Integer

    Public Sub MQ_Start()
        Console.DefaultPrompt = "> "
        ResetLine("MathQuiz for ShiftOS")
        NewLine("Answer basic arithmatical question and you'll get codepoints based on the answer")
        NewLine(Nothing)
        MQ_GiveQuestion()
        Console.CurrentInterpreter = "mathquiz"
        Console.ShouldChange = True
        Console_Interpreters()
    End Sub

    Public Sub MQ_GiveQuestion()
        Try
            Dim RandomNum As New Random
            MQ_1stNum = RandomNum.Next(1, 10)
            MQ_2ndNum = RandomNum.Next(1, 10)
            OperationChooser = RandomNum.Next(1, 5)
            Select Case OperationChooser
                Case 1
                    MQ_Operation = " + "
                    MQ_ShouldResult = MQ_1stNum + MQ_2ndNum
                Case 2
                    While MQ_2ndNum >= MQ_1stNum
                        MQ_2ndNum = RandomNum.Next(1, 10)
                    End While
                    MQ_Operation = " - "
                    MQ_ShouldResult = MQ_1stNum - MQ_2ndNum
                Case 3
                    MQ_Operation = " * "
                    MQ_ShouldResult = MQ_1stNum * MQ_2ndNum
                Case 4
                    While MQ_2ndNum > MQ_1stNum
                        MQ_2ndNum = RandomNum.Next(1, 10)
                    End While
                    MQ_Operation = " / "
                    MQ_ShouldResult = MQ_1stNum / MQ_2ndNum
            End Select
            NewLine("What is " & MQ_1stNum & MQ_Operation & MQ_2ndNum & " ?")
        Catch ex As Exception
            NewLine(ex.Message)
            TerminateApp(Nothing)
        End Try
    End Sub

    Public Sub MQ_CheckAnswer()
        Dim TheAnswer As Integer = command
        If TheAnswer = MQ_ShouldResult Then
            NewLine("You got the right answer! You got " & MQ_ShouldResult & " Codepoint(s)")
            ChangeCP(True, MQ_ShouldResult)
            MQ_GiveQuestion()
        Else
            NewLine("You got the wrong answer! Try again")
            MQ_GiveQuestion()
        End If
    End Sub
End Module
