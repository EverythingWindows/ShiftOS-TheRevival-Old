Module Com_Mkdir
    Public Sub CreateDir(TheDirectory As String)
        If IO.Directory.Exists(Console.CurrentDirectory + "\" + TheDirectory) Then
            NewLine("Directory is already exists!")
        Else
            IO.Directory.CreateDirectory(Console.CurrentDirectory + "\" + TheDirectory)
        End If
    End Sub
End Module
