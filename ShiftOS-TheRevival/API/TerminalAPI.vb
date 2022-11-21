Imports System.IO.Compression

Module TerminalAPI
    Public command As String
    Public AdvancedCommand As Boolean
    Public RawCommand As String
    Public IsConsoleParent As Boolean = True

    Public Sub InitializeTerminal()
        If IsConsoleParent = True Then
            Cursor.Hide()
            Strings.OnceInfo(1) = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS"
            Strings.OnceInfo(4) = "!"
            Strings.OnceInfo(7) = Console.Width
            Strings.OnceInfo(8) = Console.Height
            If Strings.IsFree = True Then
                Strings.ComputerInfo(0) = "shiftos"
                Strings.ComputerInfo(1) = "user"
                Terminal_CheckFeature()
                Terminal_PrintPrompt()
                Terminal_AssignPrompt()
            Else
                If Console.StayAtChapter = True Then
                    LoadGame()
                    Terminal_CheckFeature()
                    Terminal_PrintPrompt()
                    Terminal_AssignPrompt()
                Else
                    If Strings.ComputerInfo(3) = "0" Then
                        Console.TextBox1.ReadOnly = True
                        Console.StayAtChapter = True
                        Console.StoryOnlyTimer.Start()
                    Else
                        LoadGame()
                        Terminal_CheckFeature()
                        Terminal_PrintPrompt()
                        Terminal_AssignPrompt()
                    End If
                End If
            End If
        Else
            Cursor.Show()
            Console_Windowed()
            Console.TopMost = True
            Terminal_PrintPrompt()
            Terminal_AssignPrompt()
        End If
        Console.CurrentDirectory = Strings.OnceInfo(1)
        Console.Pseudodir = Console.CurrentDirectory.Replace(Strings.OnceInfo(1), "!\")
        Console.CurrentInterpreter = "terminal"
        TextRebind()
    End Sub

    Public Sub Terminal_CheckFeature()
        If Strings.AvailableFeature(4) = "1" Then
            If Console.ToolBarUse = True Then
                If Strings.OnceInfo(2) = "True" Then
                    Console.InfoBarTimer.Start()
                    Console.TextBox1.Dock = DockStyle.None
                    Console.ToolBar.Visible = True
                    Console.ToolBar.SendToBack()
                    Console.InfoBar.Visible = True
                    Console.InfoBar.SendToBack()
                    Console.TextBox1.Dock = DockStyle.Fill
                Else
                    Console.TextBox1.Dock = DockStyle.None
                    Console.InfoBar.Visible = False
                    Console.ToolBar.Visible = True
                    Console.ToolBar.SendToBack()
                    Console.TextBox1.Dock = DockStyle.Fill
                End If
            Else
                If Strings.OnceInfo(2) = "True" Then
                    Console.InfoBarTimer.Start()
                    Console.TextBox1.Dock = DockStyle.None
                    Console.InfoBar.Visible = True
                    Console.InfoBar.SendToBack()
                    Console.ToolBar.Visible = False
                    Console.TextBox1.Dock = DockStyle.Fill
                Else
                    Console.TextBox1.Dock = DockStyle.None
                    Console.InfoBar.Visible = False
                    Console.ToolBar.Visible = False
                    Console.TextBox1.Dock = DockStyle.Fill
                End If
            End If
        Else
            Console.TextBox1.Dock = DockStyle.None
            Console.InfoBar.Visible = False
            Console.TextBox1.Dock = DockStyle.Fill
        End If
    End Sub

    Public Sub Terminal_ExecuteInput()
        Terminal_ReadCommand()
        If Strings.AvailableFeature(18) = 1 Then
            ShOSKey_InputCommand(command)
        End If
        Terminal_DoCommand()
        Terminal_PrintPrompt()
        TextRebind()
    End Sub

    Public Sub Terminal_ReadCommand()
        command = Console.TextBox1.Lines(Console.TextBox1.Lines.Length - 1)
        If Console.DefaultPrompt = Nothing Then
        Else
            command = command.Replace(Console.DefaultPrompt, "")
        End If
        RawCommand = command
        command = command.ToLower()
    End Sub

    Public Sub Terminal_PrintPrompt()
        If Console.TextBox1.Text = Nothing Then
            If Console.ChangeInterpreter = True Then
                NewLine(Console.DefaultPrompt)
            Else
                If Strings.OnceInfo(0) = "Yes" Then
                    ResetLine("root@" & Strings.ComputerInfo(0) & " #> ")
                Else
                    ResetLine(Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> ")
                End If
            End If
        Else
            If Console.ChangeInterpreter = True Then
                NewLine(Console.DefaultPrompt)
            Else
                If Strings.OnceInfo(0) = "Yes" Then
                    NewLine("root@" & Strings.ComputerInfo(0) & " #> ")
                Else
                    NewLine(Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> ")
                End If
            End If
        End If
    End Sub

    Public Sub Terminal_AssignPrompt()
        If Console.ChangeInterpreter = False Then
            If Strings.OnceInfo(0) = "Yes" Then
                Console.DefaultPrompt = "root@" & Strings.ComputerInfo(0) & " #> "
            Else
                Console.DefaultPrompt = Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> "
            End If
        End If
    End Sub

    Public Sub Terminal_RunTerminalFile(filename As String)
        Dim sr As System.IO.StreamReader
        If My.Computer.FileSystem.FileExists(Console.CurrentDirectory & "\" & filename) Then
            Dim fileext As New IO.FileInfo(Console.CurrentDirectory & "\" & filename)
            If fileext.Extension = ".scr" Then
                sr = My.Computer.FileSystem.OpenTextFileReader(Console.CurrentDirectory & "\" & filename)
                Dim linenum As Integer = IO.File.ReadAllLines(Console.CurrentDirectory & "\" & filename).Length
                Dim i As Integer = 1
                While i <= linenum
                    command = sr.ReadLine()
                    Terminal_DoCommand()
                    NewLine(Nothing)
                    i = i + 1
                End While
                sr.Close()
            Else

            End If
        End If
    End Sub

    Public Sub Terminal_DoCommand()
        AdvancedCommand = True
        Console.BadCommand = True
        Select Case command
            Case ""
                AdvancedCommand = False
                NormalCommand()
            Case "05tray"
                _05tray()
                NewLine("you cheater!")
            Case "bc"
                If Strings.AvailableFeature(9) = "1" Then
                    Console.ChangeInterpreter = True
                    BC_Start()
                    AdvancedCommand = False
                    NormalCommand()
                End If
            Case "clear"
                If Strings.AvailableFeature(1) = "1" Then
                    Clear()
                    AdvancedCommand = False
                    NormalCommand()
                End If
            Case "close"
                If IsConsoleParent = False Then
                    Console.Close()
                End If
            Case "codepoint"
                Codepoint()
                AdvancedCommand = False
                NormalCommand()
            Case "colors"
                Colors()
                AdvancedCommand = False
                NormalCommand()
            Case "date"
                Terminal_Date()
            Case "dir"
                If Strings.AvailableFeature(16) = "1" Then
                    TerminalDirectories(Console.CurrentDirectory)
                    AdvancedCommand = False
                    NormalCommand()
                End If
            Case "exit su"
                If Strings.OnceInfo(0) = "No" Then

                Else
                    AdvancedCommand = False
                    NormalCommand()
                    NewLine("Exitting root mode...")
                    Strings.OnceInfo(0) = "No"
                    Terminal_AssignPrompt()
                End If
            Case "guess"
                Console.ChangeInterpreter = True
                GTN_Start()
                AdvancedCommand = False
                NormalCommand()
                'Undeveloped()
            Case "guide"
                Guide()
                AdvancedCommand = False
                NormalCommand()
            Case "help"
                Help()
                AdvancedCommand = False
                NormalCommand()
            Case "infobar"
                If Strings.AvailableFeature(4) = 1 Then
                    NewLine(My.Resources.man_infobar)
                End If
            Case "mathquiz"
                If Strings.AvailableFeature(34) = 1 Then
                    MQ_Start()
                    AdvancedCommand = False
                    NormalCommand()
                End If
            Case "pwd"
                If Strings.AvailableFeature(16) = 1 Then
                    Pwd()
                    AdvancedCommand = False
                    NormalCommand()
                End If
            Case "reboot"
                Console.TextBox1.Text = Nothing
                AdvancedCommand = False
                NormalCommand()
                SaveGame()
                InitializeTerminal()
            'Case "secure"
            '    Console.Secure = True
            '    Console.TextBox1.ReadOnly = True
            Case "shiftorium"
                NewLine(My.Resources.man_shiftorium)
                AdvancedCommand = False
                NormalCommand()
            Case "shiftfetch"
                If Strings.AvailableFeature(8) = "1" Then
                    Shiftfetch()
                    AdvancedCommand = False
                    NormalCommand()
                End If
            Case "shiftoriumfx"
                'ChangeInterpreter = True
                'AppHost("shiftoriumfx")
                AdvancedCommand = False
                NormalCommand()
                Undeveloped()
            Case "shutdown", "shut down"
                TerminateShiftOS()
            Case "startx"
                Undeveloped()
                StartX()
            Case "shiftertest"
                DuWM_SecondWindowSet(Shifter)
                Console.Close()
                DuWM_FirstWindowSet(Console)
            Case "stopx"
                StopX()
                Undeveloped()
            Case "textpad"
                If Strings.AvailableFeature(17) = "1" Then
                    TextPad_WarnFile()
                    AdvancedCommand = False
                    NormalCommand()
                End If
            Case "time"
                If Strings.AvailableFeature(5) = 1 Then
                    Terminal_Time()
                    AdvancedCommand = False
                    NormalCommand()
                ElseIf Strings.AvailableFeature(5) = 3 Then
                    Terminal_Time()
                    AdvancedCommand = False
                    NormalCommand()
                End If
            Case "su"
                Terminal_Su()
                AdvancedCommand = False
                NormalCommand()
            Case "ver"
                Terminal_Version()
                AdvancedCommand = False
                NormalCommand()
        End Select

        If AdvancedCommand = True Then
            If command Like "cat *" Then
                If Strings.AvailableFeature(16) = 1 Then
                    CatFile(command.Substring(4))
                    AdvancedCommand = False
                    NormalCommand()
                End If
            End If
            If command Like "cd *" Then
                If Strings.AvailableFeature(16) = 1 Then
                    NavigateDir(command.Replace("cd ", ""))
                    AdvancedCommand = False
                    NormalCommand()
                End If
            End If
            If command Like "color *" Then
                GetColor("terminal", command.Substring(6, 1), command.Substring(7, 1))
                AdvancedCommand = False
                NormalCommand()
            End If
            If command Like "cowsay *" Then
                If Strings.AvailableFeature(22) = 1 Then
                    Cowsay(RawCommand.Substring(7))
                    NormalCommand()
                End If
            End If
            If command Like "del *" Then
                If Strings.AvailableFeature(16) = 1 Then
                    DeleteFile(RawCommand.Substring(4))
                    AdvancedCommand = False
                    NormalCommand()
                End If
            End If
            If command Like "hostname *" Then
                If Strings.AvailableFeature(20) = 1 Then
                    Hostname()
                    AdvancedCommand = False
                    NormalCommand()
                End If
            End If
            If command Like "infobar *" Then
                If Strings.AvailableFeature(4) = "1" Then
                    Infobar()
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
                    NormalCommand()
                End If
            End If
            If command Like "print *" Then
                If Strings.AvailableFeature(2) = "1" Then
                    NewLine(RawCommand.Substring(6))
                    NormalCommand()
                    AdvancedCommand = False
                End If
            End If
            If command Like "ren '*' '*'" Then
                If Strings.AvailableFeature(31) = 1 Then
                    Rename()
                    NormalCommand()
                    AdvancedCommand = False
                End If
            End If
            If command Like "rev *" Then
                If Strings.AvailableFeature(21) = 1 Then
                    Reverse()
                    NormalCommand()
                    AdvancedCommand = False
                End If
            End If
            If command Like "rmdir *" Then
                If Strings.AvailableFeature(16) = 1 Then
                    RemoveDir(command.Replace("rmdir ", ""))
                    AdvancedCommand = False
                    NormalCommand()
                End If
            End If
            If command Like "run *" Then
                If Strings.AvailableFeature(30) = 1 Then
                    Terminal_RunTerminalFile(command.Substring(4))
                    AdvancedCommand = False
                    NormalCommand()
                End If
            End If
            If command Like "shiftorium *" Then
                Shiftorium()
            End If
            If command Like "textpad *" Then
                If Strings.AvailableFeature(17) = 1 Then
                    Console.ChangeInterpreter = True
                    command = RawCommand.Replace("textpad ", "")
                    TextPad_Start()
                    AdvancedCommand = False
                    NormalCommand()
                End If
            End If
            If command Like "username *" Then
                If Strings.AvailableFeature(19) = 1 Then
                    If command.Substring(9) = "root" Then
                        NewLine("This username is already taken!")
                    Else
                        Username()
                    End If
                    AdvancedCommand = False
                    NormalCommand()
                End If
            End If
            If command Like "unzip *" Then
                If Strings.AvailableFeature(33) = 1 Then
                    Unzip()
                End If
                AdvancedCommand = False
                NormalCommand()
            End If
            If command Like "zip *" Then
                If Strings.AvailableFeature(32) = 1 Then
                    Zip()
                End If
                AdvancedCommand = False
                NormalCommand()
            End If
        End If
        If Console.BadCommand = True Then
            NewLine("Bad command or wrong file name")
        End If
    End Sub

    Public Sub NormalCommand()
        Console.BadCommand = False
    End Sub
End Module
