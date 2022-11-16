Module Com_Cowsay
    Public Sub Cowsay(Say As String)
        Select Case Say.Length
            Case 1 To 40
                Dim SubtractLength As Integer = Say.Length + 1
                NewLine(" ")
                Do
                    AddLine("_")
                    SubtractLength = SubtractLength - 1
                    If SubtractLength = 0 Then
                        AddLine("_")
                        SubtractLength = Say.Length + 1
                        Exit Do
                    End If
                Loop
                NewLine("< " & Say & " >")
                NewLine(" ")
                Do
                    AddLine("-")
                    SubtractLength = SubtractLength - 1
                    If SubtractLength = 0 Then
                        AddLine("-")
                        SubtractLength = Say.Length + 1
                        Exit Do
                    End If
                Loop
                NewLine("        \   ^__^")
                NewLine("         \  (oo)\_______")
                NewLine("            (__)\       )\/\")
                NewLine("                ||----w |")
                NewLine("                ||     ||")
            Case 41 To 80
                NewLine(" __________________________________________ ")
                NewLine("/ " & Say.Substring(0, 40) & " \")
                Say = Say.Substring(40, Say.Length - 40)
                NewLine("\ " & Say)
                Dim Spaces As Integer = 40 - Say.Length
                Do
                    AddLine(" ")
                    If Spaces = 0 Then
                        AddLine("/")
                        Exit Do
                    End If
                    Spaces = Spaces - 1
                Loop
                NewLine(" ------------------------------------------ ")
                NewLine("        \   ^__^")
                NewLine("         \  (oo)\_______")
                NewLine("            (__)\       )\/\")
                NewLine("                ||----w |")
                NewLine("                ||     ||")
            Case >= 81
                NewLine("cowsay: Character limit exceeded")
                'Dim SubtractLength As Integer = Say.Length + 1
                'Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & " __________________________________________ "
                'Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "/ " & Say.Substring(0, 40) & " \"
                'Dim CurrentLength As Integer = 40
                'Dim WhatSay As String
                'Dim Spaces As Integer
                'Do
                '    Try
                '        WhatSay = Say.Substring(CurrentLength, 40)
                '    Catch ex As Exception
                '        WhatSay = Say.Substring(CurrentLength, (CurrentLength + 40) - Say.Length)
                '    End Try
                '    Spaces = 40 - WhatSay.Length
                '    If Spaces > 0 Then
                '        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "\ " & WhatSay
                '        Do
                '            Terminal.TextBox1.Text = Terminal.TextBox1.Text & " "
                '            If Spaces = 0 Then
                '                Terminal.TextBox1.Text = Terminal.TextBox1.Text & "/"
                '                Exit Do
                '            End If
                '            Spaces = Spaces - 1
                '        Loop
                '        Exit Do
                '    Else
                '        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "| " & WhatSay & " |"
                '        CurrentLength = CurrentLength + 40
                '    End If
                'Loop
        End Select
    End Sub
End Module
