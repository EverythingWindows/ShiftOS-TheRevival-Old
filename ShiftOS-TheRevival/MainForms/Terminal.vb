Imports System.IO

Public Class Terminal
    Public command As String
    Public DefaultPrompt As String
    Public TrackPos As Integer
    Public AdvancedCommand As Boolean
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

    Private Sub Terminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
        Cursor.Hide()
        InitializeTerminal()
    End Sub

    Public Sub InitializeTerminal()
        Strings.OnceInfo(1) = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS"
        Strings.OnceInfo(4) = "!"
        If Strings.IsFree = True Then
            Strings.ComputerInfo(0) = "shiftos"
            Strings.ComputerInfo(1) = "user"
            CheckFeature()
            PrintPrompt()
            AssignPrompt()
        Else
            If StayAtChapter = True Then
                Strings.ComputerInfo(0) = "shiftos"
                Strings.ComputerInfo(1) = "user"
                LoadGame()
                CheckFeature()
                PrintPrompt()
                AssignPrompt()
            Else
                If Strings.ComputerInfo(3) = "0" Then
                    TextBox1.ReadOnly = True
                    StayAtChapter = True
                    StoryOnlyTimer.Start()
                Else
                    Strings.ComputerInfo(0) = "shiftos"
                    Strings.ComputerInfo(1) = "user"
                    LoadGame()
                    CheckFeature()
                    PrintPrompt()
                    AssignPrompt()
                End If
            End If
        End If
        CurrentDirectory = Strings.OnceInfo(1)
        Pseudodir = CurrentDirectory.Replace(Strings.OnceInfo(1), "!\")
        TextBox1.Select(TextBox1.TextLength, 0)
        TextBox1.ScrollToCaret()
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

    Public Sub PrintPrompt()
        If TextBox1.Text = Nothing Then
            If ChangeInterpreter = True Then
                TextBox1.Text = TextBox1.Text & Environment.NewLine & DefaultPrompt
            Else
                If Strings.OnceInfo(0) = "Yes" Then
                    TextBox1.Text = "root@" & Strings.ComputerInfo(0) & " #> "
                Else
                    TextBox1.Text = Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> "
                End If
            End If
        Else
            If ChangeInterpreter = True Then
                TextBox1.Text = TextBox1.Text & Environment.NewLine & DefaultPrompt
            Else
                If Strings.OnceInfo(0) = "Yes" Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "root@" & Strings.ComputerInfo(0) & " #> "
                Else
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> "
                End If
            End If
        End If
    End Sub

    Public Sub AssignPrompt()
        If ChangeInterpreter = False Then
            If Strings.OnceInfo(0) = "Yes" Then
                DefaultPrompt = "root@" & Strings.ComputerInfo(0) & " #> "
            Else
                DefaultPrompt = Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> "
            End If
        End If
    End Sub

    Private Sub Undeveloped()
        TextBox1.Text = TextBox1.Text & Environment.NewLine & "Oopsie! It's only for newer version"
    End Sub

    Private Sub ReadCommand()
        command = TextBox1.Lines(TextBox1.Lines.Length - 1)
        If DefaultPrompt = Nothing Then
        Else
            command = command.Replace(DefaultPrompt, "")
        End If
        command = command.ToLower()
    End Sub

    Private Sub DoCommand()
        AdvancedCommand = True
        BadCommand = True
        Select Case command
            Case ""
                AdvancedCommand = False
                BadCommand = False
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
                TextBox1.Text = TextBox1.Text & Environment.NewLine & Strings.ComputerInfo(2) & " Codepoint(s) available in your wallet"
                AdvancedCommand = False
                BadCommand = False
            Case "colors"
                DisplayColors()
                AdvancedCommand = False
                BadCommand = False
            Case "dir"
                TerminalDirectories(CurrentDirectory)
                AdvancedCommand = False
                BadCommand = False
            Case "exit su"
                If Strings.OnceInfo(0) = "No" Then

                Else
                    AdvancedCommand = False
                    BadCommand = False
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "Exitting root mode..."
                    Strings.OnceInfo(0) = "No"
                    AssignPrompt()
                End If
            Case "guess"
                ChangeInterpreter = True
                AppHost("guess", False)
                AdvancedCommand = False
                BadCommand = False
                'Undeveloped()
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
                If Strings.AvailableFeature(9) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "BC          Basic Calculator for simple calculation"
                End If
                If Strings.AvailableFeature(16) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "CD          Changes directory to a selected one"
                End If
                If Strings.AvailableFeature(1) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "CLEAR       Clear the terminal"
                End If
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "CODEPOINT   Display Codepoint(s) from your wallet"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "COLOR       Changes Terminal Text and Background color to the corresponding choice"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "COLORS      Shows available colors support for the terminal"
                If Strings.AvailableFeature(16) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "DIR         Displays subdirectories and files in a directory"
                End If
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "GUESS       Runs 'Guess the Number' application"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "HELP        Shows all commands available and its corresponding action"
                If Strings.AvailableFeature(0) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "MAN         Shows a command, its corresponding action, and its example usage"
                End If
                If Strings.AvailableFeature(16) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "MKDIR       Creating a directory"
                End If
                If Strings.AvailableFeature(16) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "PWD         Display current directory navigated on ShiftOS"
                End If
                If Strings.AvailableFeature(2) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "PRINT       Prints a corresponding text entered in the command"
                End If
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "REBOOT      Terminate and re-run ShiftOS session"
                If Strings.AvailableFeature(16) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "RMDIR       Deleting a directory"
                End If
                If Strings.AvailableFeature(8) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "SHIFTFETCH  Shows informations about your computer"
                End If
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "SHIFTORIUM  A software center for upgrading features on ShiftOS"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "SHUTDOWN    Terminate ShiftOS session"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "SU          Runs terminal as super user"
                If Strings.AvailableFeature(5) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "TIME        Display the current time in the form of seconds since midnight"
                ElseIf Strings.AvailableFeature(5) = 3 Then
                    If Strings.AvailableFeature(6) = 1 Then
                        TextBox1.Text = TextBox1.Text & Environment.NewLine & "TIME        Display the current time in the form of minutes since midnight"
                    ElseIf Strings.AvailableFeature(6) = 3 Then
                        If Strings.AvailableFeature(7) = 1 Then
                            TextBox1.Text = TextBox1.Text & Environment.NewLine & "TIME        Display the current time in the form of hours since midnight"
                        ElseIf Strings.AvailableFeature(7) = 3 Then
                            If Strings.AvailableFeature(12) = 1 Then
                                TextBox1.Text = TextBox1.Text & Environment.NewLine & "TIME        Display the current time in the form of PM and AM format"
                            End If
                        End If
                    End If
                End If
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "VER         Printing current version of ShiftOS TheRevival"
                TextBox1.Text = TextBox1.Text & Environment.NewLine
                AdvancedCommand = False
                BadCommand = False
            Case "textpad"
                ChangeInterpreter = True
                AppHost("textpad", True)
                AdvancedCommand = False
                BadCommand = False
            Case "pwd"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & CurrentDirectory.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS", "!")
                AdvancedCommand = False
                BadCommand = False
            Case "reboot"
                TextBox1.Text = Nothing
                AdvancedCommand = False
                BadCommand = False
                InitializeTerminal()
            Case "shiftfetch"
                If Strings.AvailableFeature(8) = "1" Then
                    If Strings.OnceInfo(0) = "Yes" Then
                        TextBox1.Text = TextBox1.Text & Environment.NewLine & Environment.NewLine & "                 :^!7?JJJJJ?7!^:                  root@shiftos"
                    Else
                        TextBox1.Text = TextBox1.Text & Environment.NewLine & Environment.NewLine & "                 :^!7?JJJJJ?7!^:                  user@shiftos"
                    End If
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "            .~?PB###BGP555PGB###BP?~.             ----------------------"
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "         .!P#&B57^..::^~~!!~^::~7YG&#5!.          OS: ShiftOS TheRevival"
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "       .?#@G7: .^               :^::!5&#?.        Host: " & Environment.MachineName
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "     .?#@5^  !                   .^!!..J&#?       Kernel: " & My.Resources.CurrentVersion
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "    ^B@G^ .J                        :7?..J@G:     Uptime: N/A"
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "   ~&@Y  7         ~PB&#Y:.           ~G7 ~&&^    Packages: " & Strings.ComputerInfo(4)
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "  ^&@Y  Y         5#5??YB@&B~          .GJ :&&:   Shell: sos-justshell"
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "  G@B  ?         5P      ^YB!           .#! ~@G   Window Manager: -"
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & " ^@@! :          @Y   .:::^~:.           7#  Y@^  Window Manager Theme: -"
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & " 7@@: !          B@&BBBBGPPB@#Y.         :&^ ^@?  Terminal: shiftos-terminal"
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & " ?@@: 7          :??7~:.    5@@5         :&^ .&?  Terminal Font: Consolas, 11pt"
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & " ~@@! !@    G#&B!.          Y@@B         7#.  Y~  CPU: " & My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "ProcessorNameString", Nothing)
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "  B@G  B@J   ...~&G.       7@@@?        .#?   7   GPU: N/A"
                    Dim TripleDigitRAM As String
                    TripleDigitRAM = (My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024)
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "  ~&@? ^@Y       !G#57~~!YB@#Y^        .GP   ..   Memory: " & TripleDigitRAM.Substring(0, 4) & " GB"
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "   !@@7 ~#J        5#&&BG57^          ~BY         Codepoint: " & Strings.ComputerInfo(2)
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "    ~#@Y .5P~                       ^5G~          "
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "     .J&#! ^JY!:.                ^?P5!            "
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "       :J&B?..!JYY7!~::...::~!7Y5Y7:              "
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "         .7PBP?^::~!?JJJJJJJ?7~:                  "
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "            .~?55Y?!^:...                         "
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "                 .:~~^~^^::.                      "
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
                If Strings.OnceInfo(6) = "story" Then
                    SaveGame()
                End If
                Cursor.Show()
                ShiftOSMenu.Show()
                Close()
            Case "time"
                If Strings.AvailableFeature(5) = "1" Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & Math.Floor(Date.Now.Subtract(Date.Today).TotalSeconds) & " seconds passed since midnight"
                ElseIf Strings.AvailableFeature(5) = "3" Then
                    If Strings.AvailableFeature(6) = "1" Then
                        TextBox1.Text = TextBox1.Text & Environment.NewLine & Math.Floor(Date.Now.Subtract(Date.Today).TotalMinutes) & " minutes passed since midnight"
                    ElseIf Strings.AvailableFeature(6) = "3" Then
                        If Strings.AvailableFeature(7) = "1" Then
                            TextBox1.Text = TextBox1.Text & Environment.NewLine & Math.Floor(Date.Now.Subtract(Date.Today).TotalHours) & " hours passed since midnight"
                        ElseIf Strings.AvailableFeature(7) = "3" Then
                            If Strings.AvailableFeature(12) = "1" Then
                                If Date.Now.Hour < 12 Then
                                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "The time is " & TimeOfDay.Hour & " AM"
                                Else
                                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "The time is " & TimeOfDay.Hour - 12 & " PM"
                                End If
                            End If
                        End If
                    End If
                End If
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
            Case "ver"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "ShiftOS TheRevival version " & My.Resources.CurrentVersion
                AdvancedCommand = False
                BadCommand = False
        End Select

        If AdvancedCommand = True Then
            If command Like "cat *" Then
                CatFile(command.Substring(4))
            End If
            If command Like "cd *" Then
                NavigateDir(command.Replace("cd ", ""))
                AdvancedCommand = False
                BadCommand = False
            End If
            If command Like "color *" Then
                GetColor("terminal", command.Substring(6, 1), command.Substring(7, 1))
                BadCommand = False
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
                        'In process to convert every command from printing from code to printing from text file
                        Case "bc"
                            If Strings.AvailableFeature(9) = "1" Then
                                TempUsage = TempUsage & "bc"
                                TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_bc & Environment.NewLine
                                BadCommand = False
                            End If
                        Case "clear"
                            If Strings.AvailableFeature(1) = "1" Then
                                TempUsage = TempUsage & "clear"
                                TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_clear & Environment.NewLine
                                BadCommand = False
                            End If
                        Case "codepoint"
                            TempUsage = TempUsage & "codepoint"
                            TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_codepoint & Environment.NewLine
                            BadCommand = False
                        Case "guess"
                            TempUsage = TempUsage & "guess"
                            TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_guess & Environment.NewLine
                            BadCommand = False
                        Case "help"
                            TempUsage = TempUsage & "help"
                            TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_help & Environment.NewLine
                            BadCommand = False
                        Case "man"
                            If Strings.AvailableFeature(0) = "1" Then
                                TempUsage = TempUsage & "man [command]"
                                TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_man & Environment.NewLine
                                BadCommand = False
                            End If
                        Case "print"
                            If Strings.AvailableFeature(2) = "1" Then
                                TempUsage = TempUsage & "print [text]"
                                TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_print & Environment.NewLine
                                BadCommand = False
                            End If
                        Case "reboot"
                            TempUsage = TempUsage & "reboot"
                            TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_reboot & Environment.NewLine
                            BadCommand = False
                        Case "shiftfetch"
                            If Strings.AvailableFeature(8) = "1" Then
                                TempUsage = TempUsage & "shiftfetch"
                                TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_shiftfetch & Environment.NewLine
                                BadCommand = False
                            End If
                        Case "shiftorium"
                            TempUsage = TempUsage & "shiftorium [option] [featureName]"
                            TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_shiftorium & Environment.NewLine
                            BadCommand = False
                        Case "shutdown"
                            TempUsage = TempUsage & "shutdown"
                            TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_shutdown & Environment.NewLine
                            BadCommand = False
                        Case "ver"
                            TempUsage = TempUsage & "ver"
                            TextBox1.Text = TextBox1.Text & TempUsage & Environment.NewLine & Environment.NewLine & My.Resources.man_ver & Environment.NewLine
                            BadCommand = False
                        Case Else
                            TextBox1.Text = TextBox1.Text & Environment.NewLine & "MAN : Invalid command"
                    End Select
                End If
            End If
            If command Like "mkdir *" Then
                CreateDir(command.Replace("mkdir ", ""))
                AdvancedCommand = False
                BadCommand = False
            End If
            If command Like "rmdir *" Then
                RemoveDir(command.Replace("rmdir ", ""))
                AdvancedCommand = False
                BadCommand = False
            End If
            If command Like "shiftorium *" Then
                Dim prompt As String = command.Replace("shiftorium ", "")
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "Shiftorium ShiftOS Center"
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
            If command Like "print *" Then
                If Strings.AvailableFeature(2) = "1" Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & command.Substring(6)
                    Dim printed As String = command.Replace("print ", "")
                    ''It has the same issue, only displays in lowercase
                    'TextBox1.Text = TextBox1.Text & Environment.NewLine & printed
                    BadCommand = False
                End If
            End If
            AdvancedCommand = False
        End If

        If BadCommand = True Then
            TextBox1.Text = TextBox1.Text & Environment.NewLine & "Bad command or wrong file name"
        End If
    End Sub

    Private Sub txtterm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown


        Select Case e.KeyData
            Case (Keys.Control + Keys.Q)
                If CurrentInterpreter = "terminal" Then
                Else
                    TerminateApp()
                    PrintPrompt()
                End If
        End Select
        'Select Case e.KeyCode
        '    Case e.KeyCode = Keys.T AndAlso e.Control
        '        e.SuppressKeyPress = True
        '    Case e.KeyCode = Keys.Q AndAlso e.Control
        '        If CurrentInterpreter = "terminal" Then
        '        Else
        '            TerminateApp()
        '        End If
        'End Select
        If ReleaseCursor = True Then

        Else
            If ReleaseCursor = True Then

            Else
                Select Case e.KeyCode
                    Case Keys.ShiftKey
                        TrackPos = TrackPos - 1
                    Case Keys.Alt
                        TrackPos = TrackPos - 1
                    Case Keys.CapsLock
                        TrackPos = TrackPos - 1
                    Case Keys.ControlKey
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
            End If
            Select Case e.KeyCode
                Case Keys.LWin
                    TrackPos = TrackPos - 1
                Case Keys.RWin
                    TrackPos = TrackPos - 1
            End Select

            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                If TextBox1.ReadOnly = True Then

                Else
                    ReadCommand()
                    If ChangeInterpreter = True Then
                        DoChildCommand()
                        PrintPrompt()
                        TextBox1.Select(TextBox1.Text.Length, 0)
                    Else
                        DoCommand()
                        PrintPrompt()
                        TextBox1.Select(TextBox1.Text.Length, 0)
                    End If
                End If

                'If command = "clear" Then
                '    PrintPrompt()
                '    TextBox1.Select(TextBox1.Text.Length, 0)

                'Else
                '    PrintPrompt()
                '    TextBox1.Select(TextBox1.Text.Length, 0)
                'End If

                TrackPos = 0
            Else
                If ReleaseCursor = True Then

                Else
                    If e.KeyCode = Keys.Back Then
                    Else
                        TrackPos = TrackPos + 1
                    End If
                End If
            End If

            If ReleaseCursor = True Then

            Else
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
                        StoryOnlyTimer.Stop()
                        TextBox1.Text = Nothing
                        TextBox1.ReadOnly = False
                        Strings.ComputerInfo(0) = "shiftos"
                        Strings.ComputerInfo(1) = "user"
                        CheckFeature()
                        PrintPrompt()
                        AssignPrompt()
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
    End Sub
End Class