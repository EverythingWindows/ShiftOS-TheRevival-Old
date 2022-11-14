Module Com_Pwd
    Public Sub Pwd()
        NewLine(Console.CurrentDirectory.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS", "!"))
    End Sub
End Module
