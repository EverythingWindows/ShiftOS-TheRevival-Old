Module Com_Dir
    Dim spaces As String

    Public Sub TerminalDirectories(TheDirectory As String)
        Console.Pseudodir = TheDirectory.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS", "!")
        NewLine("Contents of " & Console.Pseudodir)
        NewLine(Nothing)
        NewLine("[DIR]     0 KB .")
        NewLine("[DIR]     0 KB ..")
        For Each Dir As String In IO.Directory.GetDirectories(TheDirectory)
            Dim dirinf As New IO.DirectoryInfo(Dir)
            NewLine("[DIR]     0 KB " & dirinf.Name)
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
                    NewLine(spaces & filsize & " KB " & filinf.Name)
                Case 2
                    NewLine(spaces & filsize & " MB " & filinf.Name)
                Case 3
                    NewLine(spaces & filsize & " GB " & filinf.Name)
            End Select
        Next
    End Sub
End Module
