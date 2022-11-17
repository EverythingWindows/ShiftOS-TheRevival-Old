Imports System.IO

Public Class Console
    Public TrackPos As Integer                          'Tracking the position of the caret in order to not bypass the user@hostname string
    Public DefaultPrompt As String                      'Default prompt to display in ShiftOS, usually it's user@hostname
    Public BadCommand As Boolean                        'Detect if it's a bad command or not
    Public DisplayStory As Integer                      'Keep record for displaying the DevX's or other's monologue
    Public StoryToTell As String                        'Which chapter that you're going to be in
    Public ChangeInterpreter As Boolean = False         'Default interpreter is Terminal, if it's changed to True, there'll be other program used by Console
    Public CurrentInterpreter As String = "terminal"    'Shows what program is using Console
    Public CurrentDirectory As String                   'Current Directory for ShiftOS Explorer
    Public Pseudodir As String                          'Pseudo-directory for ShiftFS 
    Public StayAtChapter As Boolean = False             'If this set to true, then intro for chapters are mostly going to be in
    Public ToolBarUse As Boolean = False                'Either any program is using ToolBar or not
    Public ReleaseCursor As Boolean = False             'Release cursor from TrackPos
    Public ShOSKey As String                            'DOSKEY tracking string for ShiftOS

    Private Sub Console_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console_Full()
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
                            Terminal_DoCommand()
                            Terminal_PrintPrompt()
                            TextRebind()
                        End If
                    End If
                    TrackPos = 0
                Case Keys.ShiftKey, Keys.LShiftKey, Keys.RShiftKey, Keys.Alt, Keys.ControlKey, Keys.LWin, Keys.RWin
                    e.SuppressKeyPress = True
                    TrackPos = TrackPos
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
        StoryLineIntro(DisplayStory)
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
        If Strings.AvailableFeature(24) = 1 Then
            InfoBar.Text = InfoBar.Text & " " & Date.Now.DayOfYear & " |"
        ElseIf Strings.AvailableFeature(24) = 3 Then
            If Strings.AvailableFeature(25) = 1 Then
                Dim WeekOfYear As String = Date.Now.DayOfYear / 7
                InfoBar.Text = InfoBar.Text & " " & WeekOfYear.Substring(0, 2) & " |"
            ElseIf Strings.AvailableFeature(25) = 3 Then
                If Strings.AvailableFeature(26) = 1 Then
                    InfoBar.Text = InfoBar.Text & " " & Date.Now.Month & " |"
                ElseIf Strings.AvailableFeature(26) = 3 Then
                    If Strings.AvailableFeature(27) = 1 Then
                        InfoBar.Text = InfoBar.Text & " " & Date.Now.Year & " |"
                    ElseIf Strings.AvailableFeature(27) = 3 Then
                        If Strings.AvailableFeature(28) = 1 Then
                            InfoBar.Text = InfoBar.Text & " " & Date.Now.Day & "/" & Date.Now.Month & " |"
                        ElseIf Strings.AvailableFeature(28) = 3 Then
                            If Strings.AvailableFeature(29) = 1 Then
                                InfoBar.Text = InfoBar.Text & " " & Date.Now.Day & "/" & Date.Now.Month & "/" & Date.Now.Year & " |"
                            End If
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