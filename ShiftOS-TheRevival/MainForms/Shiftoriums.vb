Module Shiftoriums
    Public prompt As String

    Public Sub Shiftorium_ListFeatures()
        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium Available Feature(s)" & Environment.NewLine
        If Strings.AvailableFeature(0) = "0" Then
            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "ShiftOS Help Manual (man | 20 CP)"
        End If
        If Strings.AvailableFeature(1) = "0" Then
            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Clear Terminal Screen (clear | 25 CP)"
        Else
            If Strings.AvailableFeature(2) = "0" Then
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Print Terminal Screen (print | 30 CP)"
            Else
                If Strings.AvailableFeature(3) = "0" Then
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Terminal Display Driver (termdspdrv | 50 CP)"
                End If
            End If
        End If
    End Sub

    Public Sub Shiftorium_InformationFeatures()
        'ManHeader is for the ShiftOS Help Manual header and the 'Cost' footer, kinda like template-ish
        Dim ManHeader(1) As String
        'ManHeader(0) = Insert any feature here for the Case prompt
        ManHeader(1) = "Cost: "
        Select Case prompt
            Case "man"
                If Strings.AvailableFeature(0) = "0" Then
                    ManHeader(0) = "ShiftOS Help Manual (command: man)"
                    ManHeader(1) = "20 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Shows up any further help instruction on each command, its corresponding action and its example if necessary" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "clear"
                If Strings.AvailableFeature(1) = "0" Then
                    ManHeader(0) = "Clear Terminal Screen (command: clear)"
                    ManHeader(1) = "25 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Clears the terminal screen" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "print"
                If Strings.AvailableFeature(2) = "0" Then
                    ManHeader(0) = "Print Command (command: print)"
                    ManHeader(1) = "30 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Prints a corresponding text entered in the command" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case "termdspdrv"
                If Strings.AvailableFeature(3) = "0" Then
                    ManHeader(0) = "Terminal Display Driver"
                    ManHeader(1) = "50 CP"
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Display driver for ShiftOS' Terminal to utilize advantages such as Infobar, ASCII-based applications" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                    Terminal.BadCommand = False
                End If
            Case Else
                Terminal.BadCommand = False
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium: Bad command or not available"
        End Select
    End Sub

    Public Sub Shiftorium_DetectInstallFeatures()
        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Installing feature..."
        Select Case prompt
            Case "man"
                Shiftorium_InstallFeatures(True, "man", 0, 20)
                Terminal.BadCommand = False
            Case "clear"
                Shiftorium_InstallFeatures(True, "clear", 1, 25)
                Terminal.BadCommand = False
            Case "print"
                Shiftorium_InstallFeatures(True, "print", 2, 30)
                Terminal.BadCommand = False
            Case "termdspdrv"
                Shiftorium_InstallFeatures(True, "termdspdrv", 3, 50)
                Terminal.BadCommand = False
            Case Else
                Terminal.BadCommand = False
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium: Bad command or not available"
        End Select
    End Sub

    Public Sub Shiftorium_InstallFeatures(IsCLI As Boolean, Feature As String, FeatureRow As Integer, Codepoint As Integer)
        Dim TempCP As Integer = Convert.ToInt32(Strings.ComputerInfo(2))
        Select Case Strings.AvailableFeature(FeatureRow)
            Case "0"
                If TempCP >= Codepoint Then
                    Dim success As Boolean = False
                    Select Case Feature
                        Case "man"
                            Strings.AvailableFeature(0) = "1"
                            success = True
                        Case "clear"
                            Strings.AvailableFeature(1) = "1"
                            Strings.AvailableFeature(2) = "0"
                            success = True
                        Case "print"
                            Strings.AvailableFeature(2) = "1"
                            Strings.AvailableFeature(3) = "0"
                            success = True
                        Case "termdspdrv"
                            Strings.AvailableFeature(3) = "1"
                            'Strings.AvailableFeature(3) = "0"
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
            Case "1"
                If IsCLI = True Then
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium: Feature has already been installed"
                End If
            Case "2"
                If IsCLI = True Then
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Shiftorium: Feature is not available"
                End If
        End Select
    End Sub
End Module
