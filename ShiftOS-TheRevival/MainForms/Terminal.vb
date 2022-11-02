Imports System.IO

Public Class Terminal
    Public command As String
    Public DefaultPrompt As String
    Public TrackPos As Integer
    Public AdvancedCommand As Boolean
    Public BadCommand As Boolean
    Public DisplayStory As Integer
    Public StoryToTell As String

    Private Sub Terminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
        If Strings.IsFree = True Then
            Strings.ComputerInfo(0) = "shiftos"
            Strings.ComputerInfo(1) = "user"
            Strings.ComputerInfo(2) = 0
            PrintPrompt()
            AssignPrompt()
        Else
            If Strings.ComputerInfo(3) = "0" Then
                TextBox1.ReadOnly = True
                StoryOnlyTimer.Start()
            Else
                Strings.ComputerInfo(0) = "shiftos"
                Strings.ComputerInfo(1) = "user"
                Strings.ComputerInfo(2) = 0
                PrintPrompt()
                AssignPrompt()
            End If
        End If
        TextBox1.Select(TextBox1.TextLength, 0)
        TextBox1.ScrollToCaret()
    End Sub

    Public Sub PrintPrompt()
        If TextBox1.Text = Nothing Then
            If Strings.OnceInfo(0) = "Yes" Then
                TextBox1.Text = "root@" & Strings.ComputerInfo(0) & " #> "
            Else
                TextBox1.Text = Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> "
            End If
        Else
            If Strings.OnceInfo(0) = "Yes" Then
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "root@" & Strings.ComputerInfo(0) & " #> "
            Else
                TextBox1.Text = TextBox1.Text & Environment.NewLine & Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> "
            End If
        End If
    End Sub

    Public Sub AssignPrompt()
        If Strings.OnceInfo(0) = "Yes" Then
            DefaultPrompt = "root@" & Strings.ComputerInfo(0) & " #> "
        Else
            DefaultPrompt = Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> "
        End If
    End Sub

    Private Sub Undeveloped()
        TextBox1.Text = TextBox1.Text & Environment.NewLine & "Oopsie! It's only for newer version"
    End Sub

    Private Sub ReadCommand()
        command = TextBox1.Lines(TextBox1.Lines.Length - 1)
        command = command.Replace(DefaultPrompt, "")
        command = command.ToLower()
    End Sub

    Private Sub DoCommand()
        AdvancedCommand = True
        BadCommand = True
        Select Case command
            Case ""
                AdvancedCommand = False
                BadCommand = False
            Case "clear"
                If Strings.AvailableFeature(1) = "1" Then
                    TextBox1.Text = Nothing
                    AdvancedCommand = False
                    BadCommand = False
                End If
            Case "codepoint"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & Strings.ComputerInfo(2) & " Codepoint(s) available in your wallet"
                AdvancedCommand = False
                BadCommand = False
            Case "guess"
                'AppHost("gtn")
                Undeveloped()
            Case "gimme"
                Dim TempCP As Integer = Convert.ToInt32(Strings.ComputerInfo(2))
                TempCP = TempCP + 50
                Strings.ComputerInfo(2) = Convert.ToString(TempCP)
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "you cheater!"
            Case "help"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "ShiftOS Help Manual" & Environment.NewLine & Environment.NewLine & "You can type 'help' to get all available commands and its corresponding action."
                If Strings.AvailableFeature(0) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "To get help on each command, you can type 'man [command]'" & Environment.NewLine
                Else
                    TextBox1.Text = TextBox1.Text & Environment.NewLine
                End If
                If Strings.AvailableFeature(1) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "CLEAR       Clear the terminal"
                End If
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "CODEPOINT   Display Codepoint(s) from your wallet"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "HELP        Shows all commands available and its corresponding action"
                If Strings.AvailableFeature(0) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "MAN         Shows a command, its corresponding action, and its example usage"
                End If
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "SHIFTORIUM  Terminate ShiftOS session"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "SHUTDOWN    Terminate ShiftOS session"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "SU          Runs terminal as super user"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "VER         Printing current version of ShiftOS TheRevival"
                TextBox1.Text = TextBox1.Text & Environment.NewLine
                AdvancedCommand = False
                BadCommand = False
            Case "su"
                If Strings.OnceInfo(0) = "Yes" Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "You already in root mode!"
                Else
                    Strings.OnceInfo(0) = "Yes"
                    AssignPrompt()
                End If
                AdvancedCommand = False
                BadCommand = False
            Case "shutdown", "shut down"
                ShiftOSMenu.Show()
                Close()
            Case "ver"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "ShiftOS TheRevival version 0.1.1"
                AdvancedCommand = False
                BadCommand = False
        End Select

        If AdvancedCommand = True Then
            If command Like "man *" Then
                If Strings.AvailableFeature(0) = "1" Then
                    'MAN command starts with this kinda format
                    'ShiftOS Help Manual
                    '
                    ''command' Usage: [switch/value if needed]
                    '
                    'Summary of the command's action
                    '
                    'Example usage : command
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "ShiftOS Help Manual" & Environment.NewLine
                    'TextBox1.Text = TextBox1.Text & Environment.NewLine & command.Substring(4)
                    Dim mancommand As String = command.Replace("man ", "")
                    Dim TempUsage As String = "'" & mancommand & "' Usage: "
                    Select Case mancommand
                        Case "clear"
                            TempUsage = TempUsage & "clear"
                            TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & "Clears all contents of the terminal" & Environment.NewLine
                            BadCommand = False
                        Case "codepoint"
                            TempUsage = TempUsage & "codepoint"
                            TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & "Shows the value of codepoint in your wallet" & Environment.NewLine
                            BadCommand = False
                        Case "help"
                            TempUsage = TempUsage & "help"
                            TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & "Shows all commands available in the terminal and its brief explanation of action" & Environment.NewLine
                            BadCommand = False
                        Case "man"
                            TempUsage = TempUsage & "man [command]"
                            TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & "Shows up a manual on each corresponding command and its example of action" & Environment.NewLine & Environment.NewLine & "[COMMAND] Any command that you want to get the manual for" & Environment.NewLine & Environment.NewLine & "Example: man help"
                            BadCommand = False
                        Case "shutdown"
                            TempUsage = TempUsage & "shutdown"
                            TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & "Terminate ShiftOS session" & Environment.NewLine
                            BadCommand = False
                        Case "ver"
                            TempUsage = TempUsage & "ver"
                            TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & "Displays current version of ShiftOS TheRevival" & Environment.NewLine
                            BadCommand = False
                        Case Else
                            TextBox1.Text = TextBox1.Text & Environment.NewLine & "MAN : Invalid command"
                    End Select
                End If
            End If
            If command Like "shiftorium *" Then
                Dim prompt As String = command.Replace("shiftorium ", "")
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "Shiftorium ShiftOS Center"
                If prompt Like "info *" Then
                    prompt = command.Replace("shiftorium info ", "")
                    'ManHeader is for the ShiftOS Help Manual header and the 'Cost' footer, kinda like template-ish
                    Dim ManHeader(1) As String
                    'ManHeader(0) = Insert any feature here for the Case prompt
                    ManHeader(1) = "Cost: "
                    Select Case prompt
                        Case "man"
                            ManHeader(0) = "ShiftOS Help Manual (command: man)"
                            ManHeader(1) = "20 CP"
                            TextBox1.Text = TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Shows up any further help instruction on each command, its corresponding action and its example if necessary" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                            BadCommand = False
                        Case "clear"
                            ManHeader(0) = "Clear Terminal Screen (command: clear)"
                            ManHeader(1) = "25 CP"
                            TextBox1.Text = TextBox1.Text & Environment.NewLine & ManHeader(0) & Environment.NewLine & Environment.NewLine & "Clears the terminal screen" & Environment.NewLine & Environment.NewLine & ManHeader(1)
                            BadCommand = False
                        Case Else
                            BadCommand = False
                            TextBox1.Text = TextBox1.Text & Environment.NewLine & "Shiftorium: Bad command or not available"
                    End Select
                End If
                If prompt Like "install *" Then
                    prompt = command.Replace("shiftorium install ", "")
                    Select Case prompt
                        Case "man"
                            InstallFeature(True, "man", 20)
                            BadCommand = False
                        Case "clear"
                            InstallFeature(True, "clear", 25)
                            BadCommand = False
                        Case Else
                            BadCommand = False
                            TextBox1.Text = TextBox1.Text & Environment.NewLine & "Shiftorium: Bad command or not available"
                    End Select
                End If
                If prompt = "list" Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "Shiftorium Available Feature(s)" & Environment.NewLine
                    If Strings.AvailableFeature(0) = "0" Then
                        TextBox1.Text = TextBox1.Text & Environment.NewLine & "ShiftOS Help Manual (20 CP)"
                    End If
                    If Strings.AvailableFeature(1) = "0" Then
                        TextBox1.Text = TextBox1.Text & Environment.NewLine & "Clear Terminal Screen (25 CP)"
                    End If
                    BadCommand = False
                End If
            End If
            If command Like "print *" Then
                TextBox1.Text = TextBox1.Text & Environment.NewLine & command.Substring(6)
                Dim printed As String = command.Replace("print ", "")
                ''It has the same issue, only displays in lowercase
                'TextBox1.Text = TextBox1.Text & Environment.NewLine & printed
                BadCommand = False
            End If
            AdvancedCommand = False
        End If

        If BadCommand = True Then
            TextBox1.Text = TextBox1.Text & Environment.NewLine & "Bad command or wrong file name"
        End If
    End Sub

    Private Sub txtterm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.T AndAlso e.Control Then
            Me.Hide()
            e.SuppressKeyPress = True
        End If

        Select Case e.KeyCode
            Case Keys.ShiftKey
                TrackPos = TrackPos - 1
            Case Keys.Alt
                TrackPos = TrackPos - 1
            Case Keys.CapsLock
                TrackPos = TrackPos - 1
            Case Keys.ControlKey
                TrackPos = TrackPos - 1
            Case Keys.LWin
                TrackPos = TrackPos - 1
            Case Keys.RWin
                TrackPos = TrackPos - 1
            Case Keys.Right
                If TextBox1.SelectionStart = TextBox1.TextLength Then
                    TrackPos = TrackPos - 1
                End If
            Case Keys.Left
                If TrackPos < 1 Then
                    e.SuppressKeyPress = True
                    TrackPos = TrackPos - 1
                Else
                    TrackPos = TrackPos - 2
                End If
            Case Keys.Up
                e.SuppressKeyPress = True
                TrackPos = TrackPos - 1
            Case Keys.Down
                e.SuppressKeyPress = True
                TrackPos = TrackPos - 1
        End Select

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ReadCommand()
            DoCommand()

            If command = "clear" Then
                PrintPrompt()
                TextBox1.Select(TextBox1.Text.Length, 0)

            Else
                PrintPrompt()
                TextBox1.Select(TextBox1.Text.Length, 0)
            End If

            TrackPos = 0
        Else
            If e.KeyCode = Keys.Back Then
            Else
                TrackPos = TrackPos + 1
            End If
        End If

        If e.KeyCode = Keys.Back Then
            If TrackPos < 1 Then
                e.SuppressKeyPress = True
            Else
                If TextBox1.SelectedText.Length < 1 Then
                    TrackPos = TrackPos - 1
                Else
                    e.SuppressKeyPress = True
                End If
            End If
        End If

        TextBox1.Select(TextBox1.TextLength, 0)
        TextBox1.ScrollToCaret()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click, TextBox1.MouseDoubleClick
        TextBox1.Select(TextBox1.TextLength, 0)
        TextBox1.ScrollToCaret()
    End Sub

    Private Sub StoryOnlyTimer_Tick(sender As Object, e As EventArgs) Handles StoryOnlyTimer.Tick
        Select Case Strings.ComputerInfo(3)
            Case "0"
                Select Case DisplayStory
                    Case 5
                        TextBox1.Text = "Connected to <null>"
                    Case 25
                        TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null>: Hey there, Unknown user!"
                    Case 40
                        TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null>: You have been selected for an unvolentary test on my experimental operating system, ShiftOS"
                    Case 90
                        TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null>: ShiftOS is an operating system that purposes itself to evolve itself as the time progresses"
                    Case 140
                        TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null>: I will add features into the operating system as you use it"
                    Case 170
                        TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null>: Currently ShiftOS didn't have that much function aside from a command line with little command"
                    Case 190
                        TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null>: I'll install ShiftOS now on your system"
                    Case 215
                        TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null>: I will come back and contact you later on when the time is necessary, see you!"
                    Case 250
                        TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null> Disconnected"
                    Case 275
                        TextBox1.Text = "Installing ShiftOS..."
                    Case 350
                        TextBox1.Text = "ShiftOS Installed, The computer will restart in a few seconds"
                    Case 400
                        TextBox1.Text = Nothing
                        TextBox1.ReadOnly = False
                        Strings.ComputerInfo(0) = "shiftos"
                        Strings.ComputerInfo(1) = "user"
                        Strings.ComputerInfo(2) = 0
                        PrintPrompt()
                        AssignPrompt()
                        TextBox1.Select(TextBox1.TextLength, 0)
                        TextBox1.ScrollToCaret()
                End Select
        End Select
        DisplayStory = DisplayStory + 1
    End Sub
End Class