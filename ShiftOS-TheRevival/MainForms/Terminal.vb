Public Class Terminal
    Public command As String
    Public DefaultPrompt As String
    Public TrackPos As Integer
    Public AdvancedCommand As Boolean
    Public BadCommand As Boolean

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

        End If
        TextBox1.Select(TextBox1.TextLength, 0)
        TextBox1.ScrollToCaret()
    End Sub

    Public Sub PrintPrompt()
        If TextBox1.Text = Nothing Then
            If Strings.OnceInfo(0) = "No" Then
                TextBox1.Text = "root@" & Strings.ComputerInfo(0) & " #> "
            Else
                TextBox1.Text = Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> "
            End If
        Else
            If Strings.OnceInfo(0) = "No" Then
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "root@" & Strings.ComputerInfo(0) & " #> "
            Else
                TextBox1.Text = TextBox1.Text & Environment.NewLine & Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0) & " $> "
            End If
        End If
    End Sub

    Public Sub AssignPrompt()
        If Strings.OnceInfo(0) = "No" Then
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
            Case "help"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "ShiftOS Help Manual" & Environment.NewLine & Environment.NewLine & "You can type 'help' to get all available commands and its corresponding action."
                If Strings.AvailableFeature(0) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "To get help on each command, you can type 'man [command]'" & Environment.NewLine
                Else
                    TextBox1.Text = TextBox1.Text & Environment.NewLine
                End If
                If Strings.AvailableFeature(1) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "CLEAR      Clear the terminal"
                End If
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "CODEPOINT Display Codepoint(s) from your wallet"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "HELP      Shows all commands available and its corresponding action"
                If Strings.AvailableFeature(0) = 1 Then
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "MAN       Shows a command, its corresponding action, and its example usage"
                End If
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "SHUTDOWN  Terminate ShiftOS session"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "VER       Printing current version of ShiftOS TheRevival"
                TextBox1.Text = TextBox1.Text & Environment.NewLine
                AdvancedCommand = False
                BadCommand = False
            Case "ver"
                TextBox1.Text = TextBox1.Text & Environment.NewLine & "ShiftOS TheRevival version 0.1.1"
                AdvancedCommand = False
                BadCommand = False
            Case "shutdown", "shut down"
                ShiftOSMenu.Show()
                Close()
        End Select

        If AdvancedCommand = True Then
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
End Class