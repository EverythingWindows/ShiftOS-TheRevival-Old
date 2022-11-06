Module DirectoryManagements
    Dim spaces As String
    Public Sub TerminalDirectories(TheDirectory As String)
        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Contents of " & Terminal.Pseudodir & Environment.NewLine
        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "[DIR]     0 KB ."
        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "[DIR]     0 KB .."
        For Each Dir As String In IO.Directory.GetDirectories(TheDirectory)
            Dim dirinf As New IO.DirectoryInfo(Dir)
            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "[DIR]     0 KB " & dirinf.Name
        Next
        For Each file As String In IO.Directory.GetFiles(TheDirectory)
            Dim filinf As New IO.FileInfo(file)
            Dim filsize As Long = filinf.Length / 1024
            Dim thesize As Integer = 1
            Do
                If filsize >= 1024 Then
                    filsize = filsize / 1024
                    thesize = thesize + 1
                Else
                    Exit Do
                End If
            Loop
            Select Case filsize
                Case 0 To 9
                    spaces = "          "
                Case 10 To 99
                    spaces = "         "
                Case 100 To 999
                    spaces = "        "
                Case 1000 To 1023
                    spaces = "       "
            End Select
            Select Case thesize
                Case 1
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & spaces & filsize & " KB " & filinf.Name
                Case 2
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & spaces & filsize & " MB " & filinf.Name
                Case 3
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & spaces & filsize & " GB " & filinf.Name
            End Select
        Next
    End Sub

    Public Sub NavigateDir(TheDirectory As String)
        If TheDirectory = ".." Then
            If Terminal.CurrentDirectory = Strings.OnceInfo(1) Then
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "!\"
            Else
                Terminal.CurrentDirectory = IO.Directory.GetParent(Terminal.CurrentDirectory).ToString
            End If
        Else
            If IO.Directory.Exists(Terminal.CurrentDirectory + "\" + TheDirectory) Then
                Terminal.CurrentDirectory = Terminal.CurrentDirectory & "\" & TheDirectory
            ElseIf IO.Directory.Exists(TheDirectory) Then
                Terminal.CurrentDirectory = TheDirectory
            Else
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "The directory is not exist!"
            End If
        End If
    End Sub

    Public Sub CreateDir(TheDirectory As String)
        If IO.Directory.Exists(Terminal.CurrentDirectory + "\" + TheDirectory) Then
            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Directory is already exists!"
        Else
            IO.Directory.CreateDirectory(Terminal.CurrentDirectory + "\" + TheDirectory)
        End If
    End Sub

    Public Sub RemoveDir(TheDirectory As String)
        If IO.Directory.Exists(Terminal.CurrentDirectory + "\" + TheDirectory) Then
            Try
                IO.Directory.Delete(Terminal.CurrentDirectory + "\" + TheDirectory)
            Catch ex As Exception
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ex.Message
            End Try
        Else
            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "The directory is not exists!"
        End If
    End Sub
End Module
