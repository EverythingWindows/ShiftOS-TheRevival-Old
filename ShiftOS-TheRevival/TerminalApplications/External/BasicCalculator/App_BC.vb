Module App_BC
    'Basic Calculator's RAM
    Public BC_ReadNumbers As Integer
    Public BC_Numbers1 As String
    Public BC_Numbers2 As String
    Public BC_ThriceMoreValue As Integer
    Public BC_ThriceMoreCount As Integer
    Public BC_CurrentNumber As String
    Public BC_Result As Integer
    Public BC_Operation2 As String

    Public Sub BC_Start()
        Console.DefaultPrompt = "> "
        ResetLine("bc (Basic Calcultator)")
        NewLine("Copyright, Free Software Foundation.")
        NewLine("ShiftOS port by DevX.")
        NewLine("This is free software with ABSOLUTELY NO WARRANTY.")
        NewLine(Nothing)
        Console.CurrentInterpreter = "bc"
        Console.ShouldChange = True
        Console_Interpreters()
    End Sub

    Public Sub BC_Calculate()
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
                    Case "+", "-", "*", "/", "^"
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
                        NewLine("Decimals aren't supported yet!")
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
            Case "^"
                BC_Result = FirstNum ^ SecondNum
        End Select
    End Sub
End Module
