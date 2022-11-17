Module ColorSystem
    'GUIDE to COLORS in TERMINAL
    'Using the same Hexadecimal numbering as what Command Prompt used to:
    '0 = Black      8 = Gray
    '1 = Blue       9 = Light Blue
    '2 = Green      A = Light Green
    '3 = Aqua       B = Light Aqua
    '4 = Red        C = Light Red
    '5 = Purple     D = Light Purple
    '6 = Yellow     E = Yellow
    '7 = Dark Gray  F = White
    Public BgColor As Color
    Public FgColor As Color

    Public Sub GetColor(App As String, Bg As String, Fg As String)
        Select Case App
            Case "terminal"
                BgColor = Color.Black
                FgColor = Color.White
            Case "infobar"
                BgColor = Color.White
                FgColor = Color.Black
        End Select
        If Bg = Fg Then
            NewLine("Background and Foreground Color cannot be same!")
        Else
            If Strings.AvailableFeature(10) = "1" Then
                Select Case Bg
                    Case "0"
                        BgColor = Color.Black
                    Case "7"
                        BgColor = Color.Silver
                    Case "8"
                        BgColor = Color.Gray
                    Case "f"
                        BgColor = Color.White
                    Case "2", "9", "c"
                        If Strings.AvailableFeature(13) = "1" Then
                            Select Case Bg
                                Case "2"
                                    BgColor = Color.Green
                                Case "9"
                                    BgColor = Color.Blue
                                Case "c"
                                    BgColor = Color.Red
                            End Select
                        Else
                            NewLine("One or two colors you selected is not available.")
                        End If
                    Case "1", "4", "a"
                        If Strings.AvailableFeature(14) = "1" Then
                            Select Case Bg
                                Case "1"
                                    BgColor = Color.Navy
                                Case "4"
                                    BgColor = Color.Maroon
                                Case "a"
                                    BgColor = Color.Lime
                            End Select
                        Else
                            NewLine("One or two colors you selected is not available.")
                        End If
                    Case "3", "5", "6", "b", "d", "e"
                        If Strings.AvailableFeature(15) = "1" Then
                            Select Case Bg
                                Case "3"
                                    BgColor = Color.Cyan
                                Case "5"
                                    BgColor = Color.Magenta
                                Case "6"
                                    BgColor = Color.Brown
                                Case "b"
                                    BgColor = Color.Aqua
                                Case "d"
                                    BgColor = Color.Fuchsia
                                Case "e"
                                    BgColor = Color.Yellow
                            End Select
                        Else
                            NewLine("One or two colors you selected is not available.")
                        End If
                    Case Else
                        BgColor = Color.Black
                End Select
                Select Case Fg
                    Case "0"
                        FgColor = Color.Black
                    Case "7"
                        FgColor = Color.Silver
                    Case "8"
                        FgColor = Color.Gray
                    Case "f"
                        FgColor = Color.White
                    Case "2", "9", "c"
                        If Strings.AvailableFeature(13) = "1" Then
                            Select Case Fg
                                Case "2"
                                    FgColor = Color.Green
                                Case "9"
                                    FgColor = Color.Blue
                                Case "c"
                                    FgColor = Color.Red
                            End Select
                        Else
                            NewLine("One or two colors you selected is not available.")
                        End If
                    Case "1", "4", "a"
                        If Strings.AvailableFeature(14) = "1" Then
                            Select Case Fg
                                Case "1"
                                    FgColor = Color.Navy
                                Case "4"
                                    FgColor = Color.Maroon
                                Case "a"
                                    FgColor = Color.Lime
                            End Select
                        Else
                            NewLine("One or two colors you selected is not available.")
                        End If
                    Case "3", "5", "6", "b", "d", "e"
                        If Strings.AvailableFeature(15) = "1" Then
                            Select Case Fg
                                Case "3"
                                    FgColor = Color.Cyan
                                Case "5"
                                    FgColor = Color.Magenta
                                Case "6"
                                    FgColor = Color.Brown
                                Case "b"
                                    FgColor = Color.Aqua
                                Case "d"
                                    FgColor = Color.Fuchsia
                                Case "e"
                                    FgColor = Color.Yellow
                            End Select
                        Else
                            NewLine("One or two colors you selected is not available.")
                        End If
                    Case Else
                        FgColor = Color.White
                End Select
            Else
                NewLine("Color is not supported for 1-bit Color Display")
                Select Case App
                    Case "terminal"
                        BgColor = Color.Black
                        FgColor = Color.White
                    Case "infobar"
                        BgColor = Color.White
                        FgColor = Color.Black
                End Select
            End If
        End If
        Select Case App
            Case "infobar"
                Console.InfoBar.BackColor = BgColor
                Console.InfoBar.ForeColor = FgColor
                Strings.ComputerInfo(6) = Bg & Fg
            Case "terminal"
                Console.TextBox1.BackColor = BgColor
                Console.TextBox1.ForeColor = FgColor
                Strings.ComputerInfo(5) = Bg & Fg
        End Select
    End Sub
End Module
