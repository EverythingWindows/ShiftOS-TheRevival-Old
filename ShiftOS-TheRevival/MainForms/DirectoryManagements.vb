Module DirectoryManagements
    Public Sub TerminalDirectories(TheDirectory As String)
        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "Contents of " & Terminal.Pseudodir & Environment.NewLine
        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "[DIR]    0 KB ."
        Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "[DIR]    0 KB .."
        For Each Dir As String In IO.Directory.GetDirectories(TheDirectory)
            Dim dirinf As New IO.DirectoryInfo(Dir)
            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & "[DIR]    0 KB " & dirinf.Name
        Next
    End Sub
End Module
