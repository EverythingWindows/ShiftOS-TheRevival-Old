Module Shiftoriums
    Public Sub InstallFeature(IsCLI As Boolean, Feature As String, Codepoint As Integer)
        Dim TempCP As Integer = Convert.ToInt32(Strings.ComputerInfo(2))
        If TempCP >= Codepoint Then
            Dim success As Boolean = False
            Select Case Feature
                Case "man"
                    Strings.AvailableFeature(0) = "1"
                    success = True
                Case "clear"
                    Strings.AvailableFeature(1) = "1"
                    success = True
            End Select
            If success = False Then
                If IsCLI = True Then
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium: Invalid command or feature already installed"
                End If
            Else
                TempCP = TempCP - Codepoint
                Strings.ComputerInfo(2) = Convert.ToString(TempCP)
                If IsCLI = True Then
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Feature has been install succesfully"
                End If
            End If
        Else
            If IsCLI = True Then
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium: Insufficent Codepoint"
            End If
        End If
    End Sub
End Module
