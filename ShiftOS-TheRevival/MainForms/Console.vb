Imports System.IO

Public Class Console
    Public TrackPos As Integer
    Public DefaultPrompt As String
    Public BadCommand As Boolean
    Public DisplayStory As Integer
    Public StoryToTell As String
    Public ChangeInterpreter As Boolean = False
    Public CurrentInterpreter As String = "terminal"
    Public CurrentDirectory As String
    Public Pseudodir As String
    Public StayAtChapter As Boolean = False
    Public ToolBarUse As Boolean = False
    Public ReleaseCursor As Boolean = False
    Public ShOSKey As String

    Private Sub Console_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
        Cursor.Hide()
        InitializeTerminal()
    End Sub

    Public Sub InitializeTerminal()
        Strings.OnceInfo(1) = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS"
        Strings.OnceInfo(4) = "!"
        Strings.OnceInfo(7) = Width
        Strings.OnceInfo(8) = Height
        If Strings.IsFree = True Then
            Strings.ComputerInfo(0) = "shiftos"
            Strings.ComputerInfo(1) = "user"
            CheckFeature()
            Terminal_PrintPrompt()
            Terminal_AssignPrompt()
        Else
            If StayAtChapter = True Then
                LoadGame()
                CheckFeature()
                Terminal_PrintPrompt()
                Terminal_AssignPrompt()
            Else
                If Strings.ComputerInfo(3) = "0" Then
                    TextBox1.ReadOnly = True
                    StayAtChapter = True
                    StoryOnlyTimer.Start()
                Else
                    LoadGame()
                    CheckFeature()
                    Terminal_PrintPrompt()
                    Terminal_AssignPrompt()
                End If
            End If
        End If
        CurrentDirectory = Strings.OnceInfo(1)
        Pseudodir = CurrentDirectory.Replace(Strings.OnceInfo(1), "!\")
        TextRebind()
    End Sub

    Public Sub CheckFeature()
        If Strings.AvailableFeature(4) = "1" Then
            If ToolBarUse = True Then
                If Strings.OnceInfo(2) = "True" Then
                    InfoBarTimer.Start()
                    TextBox1.Dock = DockStyle.None
                    ToolBar.Visible = True
                    ToolBar.SendToBack()
                    InfoBar.Visible = True
                    InfoBar.SendToBack()
                    TextBox1.Dock = DockStyle.Fill
                Else
                    TextBox1.Dock = DockStyle.None
                    InfoBar.Visible = False
                    ToolBar.Visible = True
                    ToolBar.SendToBack()
                    TextBox1.Dock = DockStyle.Fill
                End If
            Else
                If Strings.OnceInfo(2) = "True" Then
                    InfoBarTimer.Start()
                    TextBox1.Dock = DockStyle.None
                    InfoBar.Visible = True
                    InfoBar.SendToBack()
                    ToolBar.Visible = False
                    TextBox1.Dock = DockStyle.Fill
                Else
                    TextBox1.Dock = DockStyle.None
                    InfoBar.Visible = False
                    ToolBar.Visible = False
                    TextBox1.Dock = DockStyle.Fill
                End If
            End If
        Else
            TextBox1.Dock = DockStyle.None
            InfoBar.Visible = False
            TextBox1.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub Undeveloped()
        NewLine("Oopsie! It's only for newer version")
    End Sub

    Private Sub DoCommand()
        AdvancedCommand = True
        BadCommand = True
        Select Case command
            Case ""
                AdvancedCommand = False
                BadCommand = False
            Case "05tray"
                Dim TempCP As Integer = Convert.ToInt32(Strings.ComputerInfo(2))
                TempCP = TempCP + 50
                Strings.ComputerInfo(2) = Convert.ToString(TempCP)
                NewLine("you cheater!")
            Case "bc"
                If Strings.AvailableFeature(9) = "1" Then
                    ChangeInterpreter = True
                    AppHost("bc", False)
                    AdvancedCommand = False
                    BadCommand = False
                End If
            Case "clear"
                If Strings.AvailableFeature(1) = "1" Then
                    TextBox1.Text = Nothing
                    AdvancedCommand = False
                    BadCommand = False
                End If
            Case "codepoint"
                NewLine(Strings.ComputerInfo(2) & " Codepoint(s) available in your wallet")
                AdvancedCommand = False
                BadCommand = False
            Case "colors"
                DisplayColors()
                AdvancedCommand = False
                BadCommand = False
            Case "dir"
                If Strings.AvailableFeature(16) = "1" Then
                    TerminalDirectories(CurrentDirectory)
                    AdvancedCommand = False
                    BadCommand = False
                End If
            Case "exit su"
                If Strings.OnceInfo(0) = "No" Then

                Else
                    AdvancedCommand = False
                    BadCommand = False
                    NewLine("Exitting root mode...")
                    Strings.OnceInfo(0) = "No"
                    Terminal_AssignPrompt()
                End If
            Case "guess"
                ChangeInterpreter = True
                AppHost("guess", False)
                AdvancedCommand = False
                BadCommand = False
                'Undeveloped()
            Case "help"
                NewLine("ShiftOS Help Manual")
                NewLine(Nothing)
                NewLine("You can type 'help' to get all available commands and its corresponding action.")
                If Strings.AvailableFeature(0) = 1 Then
                    NewLine("To get help on each command, you can type 'man [command]'")
                    NewLine(Nothing)
                Else
                    NewLine(Nothing)
                End If
                If Strings.AvailableFeature(9) = 1 Then
                    NewLine("BC          Basic Calculator for simple calculation")
                End If
                If Strings.AvailableFeature(16) = 1 Then
                    NewLine("CD          Changes directory to a selected one")
                End If
                If Strings.AvailableFeature(1) = 1 Then
                    NewLine("CLEAR       Clear the terminal")
                End If
                NewLine("CODEPOINT   Display Codepoint(s) from your wallet")
                NewLine("COLOR       Changes Terminal Text And Background color To the corresponding choice")
                NewLine("COLORS      Shows available colors support For the terminal")
                If Strings.AvailableFeature(22) = 1 Then
                    NewLine("COWSAY      Spawn a cow And saying anything you want")
                End If
                If Strings.AvailableFeature(16) = 1 Then
                    NewLine("DEL         Delete a selected file from the directory")
                    NewLine("DIR         Displays subdirectories And files In a directory")
                End If
                NewLine("GUESS       Runs 'Guess the Number' application")
                NewLine("HELP        Shows all commands available and its corresponding action")
                If Strings.AvailableFeature(20) = 1 Then
                    NewLine("HOSTNAME    Sets the name of current hostname/computer name with a new one")
                End If
                If Strings.AvailableFeature(4) = 1 Then
                    NewLine("INFOBAR     Displays informations about current session such as current app, current user, current time, etc.")
                End If
                If Strings.AvailableFeature(0) = 1 Then
                    NewLine("MAN         Shows a command, its corresponding action, and its example usage")
                End If
                If Strings.AvailableFeature(16) = 1 Then
                    NewLine("MKDIR       Creating a directory")
                End If
                If Strings.AvailableFeature(16) = 1 Then
                    NewLine("PWD         Display current directory navigated on ShiftOS")
                End If
                If Strings.AvailableFeature(2) = 1 Then
                    NewLine("PRINT       Prints a corresponding text entered in the command")
                End If
                NewLine("REBOOT      Terminate and re-run ShiftOS session")
                If Strings.AvailableFeature(21) = 1 Then
                    NewLine("REV         Turn any sentences you want and making it reversed")
                End If
                If Strings.AvailableFeature(16) = 1 Then
                    NewLine("RMDIR       Deleting a directory")
                End If
                If Strings.AvailableFeature(8) = 1 Then
                    NewLine("SHIFTFETCH  Shows informations about your computer")
                End If
                NewLine("SHIFTORIUM  A software center for upgrading features on ShiftOS")
                NewLine("SHUTDOWN    Terminate ShiftOS session")
                NewLine("SU          Runs terminal as super user")
                If Strings.AvailableFeature(17) = 1 Then
                    NewLine("TEXTPAD     Simple text-editor for ShiftOS")
                End If
                If Strings.AvailableFeature(5) = 1 Then
                    NewLine("TIME        Display the current time in the form of seconds since midnight")
                ElseIf Strings.AvailableFeature(5) = 3 Then
                    If Strings.AvailableFeature(6) = 1 Then
                        NewLine("TIME        Display the current time in the form of minutes since midnight")
                    ElseIf Strings.AvailableFeature(6) = 3 Then
                        If Strings.AvailableFeature(7) = 1 Then
                            NewLine("TIME        Display the current time in the form of hours since midnight")
                        ElseIf Strings.AvailableFeature(7) = 3 Then
                            If Strings.AvailableFeature(12) = 1 Then
                                NewLine("TIME        Display the current time in the form of PM and AM format")
                            End If
                        End If
                    End If
                End If
                If Strings.AvailableFeature(20) = 1 Then
                    NewLine("USERNAME    Sets the name of current user with a new one")
                End If
                NewLine("VER         Printing current version of ShiftOS TheRevival")
                AdvancedCommand = False
                BadCommand = False
            Case "infobar"
                If Strings.AvailableFeature(4) = 1 Then
                    NewLine(My.Resources.man_infobar)
                End If
            Case "pwd"
                If Strings.AvailableFeature(16) = 1 Then
                    NewLine(CurrentDirectory.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS", "!"))
                    AdvancedCommand = False
                    BadCommand = False
                End If
            Case "reboot"
                TextBox1.Text = Nothing
                AdvancedCommand = False
                BadCommand = False
                SaveGame()
                InitializeTerminal()
            Case "shiftorium"
                NewLine(My.Resources.man_shiftorium)
                AdvancedCommand = False
                BadCommand = False
            Case "shiftfetch"
                If Strings.AvailableFeature(8) = "1" Then
                    If Strings.OnceInfo(0) = "Yes" Then
                        NewLine("                 :^!7?JJJJJ?7!^:                  root@shiftos")
                    Else
                        NewLine("                 :^!7?JJJJJ?7!^:                  " & Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0))
                    End If
                    NewLine("            .~?PB###BGP555PGB###BP?~.             ----------------------")
                    NewLine("        .!P#&B57^..:: ^~~!!~^::~7YG&#5!.          OS: ShiftOS TheRevival")
                    NewLine("       .?#@G7: .^               :^::!5&#?.        Host: " & Environment.MachineName)
                    NewLine("     .?#@5^  !                   .^!!..J&#?       Kernel: " & My.Resources.CurrentVersion)
                    NewLine("    B@G^ .J                        : 7?..J@G:     Uptime : N/ A")
                    NewLine("   ~&@Y  7         ~PB&#Y:.           ~G7 ~&&^    Packages: " & Strings.ComputerInfo(4))
                    NewLine("  ^&@Y  Y         5#5??YB@&B~          .GJ :&&:   Shell: sos-justshell")
                    NewLine("  G@B  ?         5P      ^YB!           .#! ~@G   Window Manager: -")
                    NewLine(" ^@@! :          @Y   .:::^~:.           7#  Y@^  Window Manager Theme: -")
                    NewLine(" 7@@: !          B@&BBBBGPPB@#Y.         :&^ ^@?  Terminal: shiftos-terminal")
                    NewLine(" ?@@: 7          :??7~:.    5@@5         :&^ .&?  Terminal Font: Consolas, 11pt")
                    NewLine(" ~@@! !@    G#&B!.          Y@@B         7#.  Y~  CPU: " & My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "ProcessorNameString", Nothing))
                    NewLine("  B@G  B@J   ...~&G.       7@@@?        .#?   7   GPU: N/A")
                    Dim TripleDigitRAM As String
                    TripleDigitRAM = (My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024)
                    NewLine("  ~&@? ^@Y       !G#57~~!YB@#Y^        .GP   ..   Memory: " & TripleDigitRAM.Substring(0, 4) & " GB")
                    NewLine("   !@@7 ~#J        5#&&BG57^          ~BY         Codepoint: " & Strings.ComputerInfo(2))
                    NewLine("    ~#@Y .5P~                       ^5G~          ")
                    NewLine("     .J&#! ^JY!:.                ^?P5!            ")
                    NewLine("       :J&B?..!JYY7!~::...::~!7Y5Y7:              ")
                    NewLine("         .7PBP?^::~!?JJJJJJJ?7~:                  ")
                    NewLine("            .~?55Y?!^:...                         ")
                    NewLine("                 .:~~^~^^::.                      ")
                    AdvancedCommand = False
                    BadCommand = False
                End If
            Case "shiftoriumfx"
                'ChangeInterpreter = True
                'AppHost("shiftoriumfx")
                AdvancedCommand = False
                BadCommand = False
                Undeveloped()
            Case "shutdown", "shut down"
                NewLine("Saving game...")
                If Strings.OnceInfo(6) = "story" Then
                    SaveGame()
                End If
                Cursor.Show()
                ShiftOSMenu.Show()
                Close()
            Case "textpad"
                If Strings.AvailableFeature(17) = "1" Then
                    NewLine("Type any filename after 'textpad'!, ex: textpad text.txt")
                    AdvancedCommand = False
                    BadCommand = False
                End If
            Case "time"
                If Strings.AvailableFeature(5) = "1" Then
                    NewLine(Math.Floor(Date.Now.Subtract(Date.Today).TotalSeconds) & " seconds passed since midnight")
                ElseIf Strings.AvailableFeature(5) = "3" Then
                    If Strings.AvailableFeature(6) = "1" Then
                        NewLine(Math.Floor(Date.Now.Subtract(Date.Today).TotalMinutes) & " minutes passed since midnight")
                    ElseIf Strings.AvailableFeature(6) = "3" Then
                        If Strings.AvailableFeature(7) = "1" Then
                            NewLine(Math.Floor(Date.Now.Subtract(Date.Today).TotalHours) & " hours passed since midnight")
                        ElseIf Strings.AvailableFeature(7) = "3" Then
                            If Strings.AvailableFeature(12) = "1" Then
                                If Date.Now.Hour < 12 Then
                                    NewLine("The time is " & TimeOfDay.Hour & " AM")
                                Else
                                    NewLine("The time is " & TimeOfDay.Hour - 12 & " PM")
                                End If
                            ElseIf Strings.AvailableFeature(23) = "1" Then
                                NewLine("The time is " & TimeOfDay.Hour & ":" & TimeOfDay.Minute)
                            End If
                        End If
                    End If
                End If
                AdvancedCommand = False
                BadCommand = False
            Case "su"
                If Strings.OnceInfo(0) = "Yes" Then
                    NewLine("You already in root mode!")
                Else
                    Strings.OnceInfo(0) = "Yes"
                    Terminal_AssignPrompt()
                End If
                AdvancedCommand = False
                BadCommand = False
            Case "ver"
                NewLine("ShiftOS TheRevival version " & My.Resources.CurrentVersion)
                AdvancedCommand = False
                BadCommand = False
        End Select

        If AdvancedCommand = True Then
            If command Like "cat *" Then
                If Strings.AvailableFeature(16) = 1 Then
                    CatFile(command.Substring(4))
                    AdvancedCommand = False
                    BadCommand = False
                End If
            End If
            If command Like "cd *" Then
                If Strings.AvailableFeature(16) = 1 Then
                    NavigateDir(command.Replace("cd ", ""))
                    AdvancedCommand = False
                    BadCommand = False
                End If
            End If
            If command Like "color *" Then
                GetColor("terminal", command.Substring(6, 1), command.Substring(7, 1))
                BadCommand = False
            End If
            If command Like "cowsay *" Then
                If Strings.AvailableFeature(22) = 1 Then
                    Cowsay_Say(RawCommand.Substring(7))
                    BadCommand = False
                End If
            End If
            If command Like "del *" Then
                If Strings.AvailableFeature(16) = 1 Then
                    DeleteFile(RawCommand.Substring(4))
                    AdvancedCommand = False
                    BadCommand = False
                End If
            End If
            If command Like "hostname *" Then
                If Strings.AvailableFeature(20) = 1 Then
                    Strings.ComputerInfo(0) = command.Substring(command.LastIndexOf(" ") + 1, command.Length - (command.LastIndexOf(" ") + 1))
                    Terminal_AssignPrompt()
                    AdvancedCommand = False
                    BadCommand = False
                End If
            End If
            If command Like "infobar *" Then
                If Strings.AvailableFeature(4) = "1" Then
                    'Infobar panel-ish and some sort
                    Dim infobarcommand As String = command.Replace("infobar ", "")
                    Dim advancedtool As Boolean = True
                    Select Case infobarcommand
                        Case "on"
                            Strings.OnceInfo(2) = "True"
                            CheckFeature()
                            BadCommand = False
                            advancedtool = False
                        Case "off"
                            Strings.OnceInfo(2) = "False"
                            CheckFeature()
                            BadCommand = False
                            advancedtool = False
                    End Select
                    If advancedtool = True Then
                        If infobarcommand Like "color *" Then
                            GetColor("infobar", infobarcommand.Substring(6, 1), infobarcommand.Substring(7, 1))
                            BadCommand = False
                        End If
                    End If
                End If
            End If
            If command Like "man *" Then
                If Strings.AvailableFeature(0) = "1" Then
                    Manual(command)
                End If
            End If
            If command Like "mkdir *" Then
                If Strings.AvailableFeature(16) Then
                    CreateDir(command.Replace("mkdir ", ""))
                    AdvancedCommand = False
                    BadCommand = False
                End If
            End If
            If command Like "print *" Then
                If Strings.AvailableFeature(2) = "1" Then
                    NewLine(RawCommand.Substring(6))
                    'Dim printed As String = command.Replace("print ", "")
                    ''It has the same issue, only displays in lowercase
                    'NewLine( printed
                    BadCommand = False
                    AdvancedCommand = False
                End If
            End If
            If command Like "rev *" Then
                If Strings.AvailableFeature(21) = 1 Then
                    NewLine(StrReverse(RawCommand.Substring(4)))
                    BadCommand = False
                    AdvancedCommand = False
                End If
            End If
            If command Like "rmdir *" Then
                If Strings.AvailableFeature(16) = 1 Then
                    RemoveDir(command.Replace("rmdir ", ""))
                    AdvancedCommand = False
                    BadCommand = False
                End If
            End If
            If command Like "shiftorium *" Then
                Dim prompt As String = command.Replace("shiftorium ", "")
                NewLine("Shiftorium ShiftOS Center")
                If prompt Like "info *" Then
                    Shiftoriums.prompt = command.Replace("shiftorium info ", "")
                    Shiftorium_InformationFeatures()
                End If
                If prompt Like "install *" Then
                    Shiftoriums.prompt = command.Replace("shiftorium install ", "")
                    Shiftorium_DetectInstallFeatures()
                End If
                If prompt = "list" Then
                    Shiftorium_ListFeatures()
                    BadCommand = False
                End If
            End If
            If command Like "textpad *" Then
                If Strings.AvailableFeature(17) = 1 Then
                    ChangeInterpreter = True
                    command = RawCommand.Replace("textpad ", "")
                    AppHost("textpad", True)
                    AdvancedCommand = False
                    BadCommand = False
                End If
            End If
            If command Like "username *" Then
                If Strings.AvailableFeature(19) = 1 Then
                    If command.Substring(9) = "root" Then
                        NewLine("This username is already taken!")
                    Else
                        Strings.ComputerInfo(1) = command.Substring(command.LastIndexOf(" ") + 1, command.Length - (command.LastIndexOf(" ") + 1))
                        Terminal_AssignPrompt()
                    End If
                    AdvancedCommand = False
                    BadCommand = False
                End If
            End If
        End If

        If BadCommand = True Then
            NewLine("Bad command or wrong file name")
        End If
    End Sub

    Private Sub txtterm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        KeyInput = e.KeyData
        Select Case e.KeyData
            Case (Keys.Control + Keys.Q)
                If CurrentInterpreter = "terminal" Then
                Else
                    TerminateApp(KeyInput)
                    TextRebind()
                End If
            Case Else
                CaptureKeyBinding(KeyInput)
        End Select
        If ReleaseCursor = True Then

        Else
            Select Case e.KeyData
                Case Keys.Enter
                    e.SuppressKeyPress = True
                    If TextBox1.ReadOnly = True Then

                    Else
                        Terminal_ReadCommand()
                        If Strings.AvailableFeature(18) = 1 Then
                            ShOSKey_InputCommand(command)
                        End If
                        If ChangeInterpreter = True Then
                            DoChildCommand()
                            Terminal_PrintPrompt()
                            TextRebind()
                        Else
                            DoCommand()
                            Terminal_PrintPrompt()
                            TextRebind()
                        End If
                    End If
                    TrackPos = 0
                Case Keys.ShiftKey, Keys.Alt, Keys.ControlKey, Keys.LWin, Keys.RWin
                    e.SuppressKeyPress = True
                Case Keys.Back
                    If TrackPos <= 0 Then
                        e.SuppressKeyPress = True
                    Else
                        TrackPos = TrackPos - 1
                        'If TextBox1.SelectedText.Length < 1 Then
                        '    TrackPos = TrackPos - 1
                        'Else
                        '    e.SuppressKeyPress = True
                        'End If
                    End If
                Case Keys.Right
                    If TextBox1.SelectionStart = TextBox1.TextLength Then
                    Else
                        TrackPos = TrackPos + 1
                    End If
                    'If TrackPos <= 0 Then
                    '    Dim CommandChar As String
                    '    CommandChar = TextBox1.Lines(TextBox1.Lines.Length - 1)
                    '    CommandChar = CommandChar.Replace(DefaultPrompt, "")
                    '    TrackPos = CommandChar.Length - 1
                    '    TextBox1.Select(TextBox1.TextLength, 0)
                    '    TextBox1.ScrollToCaret()
                    'End If
                Case Keys.Left
                    If TextBox1.SelectionStart = 0 Then
                        e.SuppressKeyPress = True
                    Else
                        TrackPos = TrackPos - 1
                    End If
                    If TrackPos <= 0 Then
                        Dim CommandChar As String
                        CommandChar = TextBox1.Lines(TextBox1.Lines.Length - 1)
                        CommandChar = CommandChar.Replace(DefaultPrompt, "")
                        TrackPos = CommandChar.Length - 1
                        TextBox1.Select(TextBox1.TextLength, 0)
                        TextBox1.ScrollToCaret()
                    End If
                'If TrackPos < 1 Then
                '    e.SuppressKeyPress = True
                '    TrackPos = TrackPos - 1
                'Else
                '    TrackPos = TrackPos - 2
                'End If
                Case Keys.Up
                    e.SuppressKeyPress = True
                    If Strings.AvailableFeature(18) = 1 Then
                        ShOSKey_Display()
                        TextRebind()
                    End If
                Case Keys.Down
                    e.SuppressKeyPress = True
                    If Strings.AvailableFeature(18) = 1 Then
                        ShOSKey_Display()
                        TextRebind()
                    End If
                Case Else
                    TrackPos = TrackPos + 1
            End Select
        End If
        'If e.KeyCode = Keys.Enter Then
        '    'If command = "clear" Then
        '    '    txtterm.Text = txtterm.Text + ShiftOSDesktop.username & "@" & ShiftOSDesktop.osname & " $> "
        '    '    txtterm.Select(txtterm.Text.Length, 0)

        '    'Else
        '    '    txtterm.Text = txtterm.Text + Environment.NewLine & ShiftOSDesktop.username & "@" & ShiftOSDesktop.osname & " $> "
        '    '    txtterm.Select(txtterm.Text.Length, 0)
        '    'End If
        'Else
        '    If e.KeyCode = Keys.Back Then
        '    Else
        '        TrackPos = TrackPos + 1
        '    End If
        'End If

        'If e.KeyCode = Keys.Back Then
        '    'If TrackPos < 1 Then
        '    '    e.SuppressKeyPress = True
        '    'Else
        '    '    If TextBox1.SelectedText.Length < 1 Then
        '    '        TrackPos = TrackPos - 1
        '    '    Else
        '    '        e.SuppressKeyPress = True
        '    '    End If
        '    'End If
        'End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click, TextBox1.MouseDoubleClick
        TextRebind()
    End Sub

    Private Sub StoryOnlyTimer_Tick(sender As Object, e As EventArgs) Handles StoryOnlyTimer.Tick
        Select Case Strings.ComputerInfo(3)
            Case "0"
                Select Case DisplayStory
                    Case 5
                        ResetLine("Connected to <null>")
                    Case 25
                        NewLine("<null>: Hey there, Unknown user!")
                    Case 60
                        NewLine("<null>: Congratulaions! You have been involuntarily selected for a test on my experimental operating system, ShiftOS.")
                    Case 125
                        NewLine("<null>: ShiftOS is an operating system that will evolve itself as you use it as I progressively add more features into ShiftOS.")
                    Case 160
                        NewLine("<null>: Currently ShiftOS isn't much from a basic command-line operating system.")
                    Case 210
                        NewLine("<null>: I don't wish to reveal my indentity at this point in time.")
                    Case 270
                        NewLine("<null>: I will install ShiftOS on your system once I leave while I work on... something else.")
                    Case 335
                        NewLine("<null>: Once you have ShiftOS rich feature enough, I will come back to you. In the mean time, goodbye!")
                    Case 400
                        NewLine("<null> Disconnected")
                    Case 430
                        ResetLine("Installing ShiftOS...")
                    Case 550
                        ResetLine("ShiftOS Installed, The computer will restart in a few seconds")
                    Case 600
                        StoryOnlyTimer.Stop()
                        TextBox1.Text = Nothing
                        TextBox1.ReadOnly = False
                        Strings.ComputerInfo(0) = "shiftos"
                        Strings.ComputerInfo(1) = "user"
                        CheckFeature()
                        Terminal_PrintPrompt()
                        Terminal_AssignPrompt()
                        TextBox1.Select(TextBox1.TextLength, 0)
                        TextBox1.ScrollToCaret()
                End Select
        End Select
        DisplayStory = DisplayStory + 1
    End Sub

    Private Sub InfoBarTimer_Tick(sender As Object, e As EventArgs) Handles InfoBarTimer.Tick
        InfoBar.Text = "|"
        If Strings.AvailableFeature(5) = "1" Then
            InfoBar.Text = InfoBar.Text & " " & Math.Floor(Date.Now.Subtract(Date.Today).TotalSeconds) & " |"
        ElseIf Strings.AvailableFeature(5) = "3" Then
            If Strings.AvailableFeature(6) = "1" Then
                InfoBar.Text = InfoBar.Text & " " & Math.Floor(Date.Now.Subtract(Date.Today).TotalMinutes) & " |"
            ElseIf Strings.AvailableFeature(6) = "3" Then
                If Strings.AvailableFeature(7) = "1" Then
                    InfoBar.Text = InfoBar.Text & " " & Math.Floor(Date.Now.Subtract(Date.Today).TotalHours) & " |"
                ElseIf Strings.AvailableFeature(7) = "3" Then
                    If Strings.AvailableFeature(12) = "1" Then
                        If Date.Now.Hour < 12 Then
                            InfoBar.Text = InfoBar.Text & Environment.NewLine & " " & TimeOfDay.Hour & " AM |"
                        Else
                            InfoBar.Text = InfoBar.Text & Environment.NewLine & " " & TimeOfDay.Hour - 12 & " PM |"
                        End If
                    ElseIf Strings.AvailableFeature(12) = "3" Then
                        If Strings.AvailableFeature(23) = "1" Then
                            InfoBar.Text = InfoBar.Text & Environment.NewLine & " " & TimeOfDay.Hour & ":" & TimeOfDay.Minute & " |"
                        End If
                    End If
                End If
            End If
        End If
        If Strings.OnceInfo(0) = "Yes" Then
            InfoBar.Text = InfoBar.Text & " root |"
        Else
            InfoBar.Text = InfoBar.Text & " user |"
        End If
        InfoBar.Text = InfoBar.Text & " " & CurrentInterpreter & " |"
        InfoBar.Text = InfoBar.Text & " " & Strings.ComputerInfo(2) & " CP |"
        InfoBar.Text = InfoBar.Text & " " & TrackPos & " |"
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseDoubleClick, TextBox1.Click

    End Sub
End Class