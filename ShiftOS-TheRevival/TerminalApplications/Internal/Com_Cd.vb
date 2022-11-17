Module Com_Cd
    Public Sub NavigateDir(TheDirectory As String)
        If TheDirectory = ".." Then
            If Console.CurrentDirectory = Strings.OnceInfo(1) Then
                NewLine("!\")
            Else
                Console.CurrentDirectory = IO.Directory.GetParent(Console.CurrentDirectory).ToString
            End If
        Else
            If IO.Directory.Exists(Console.CurrentDirectory + "\" + TheDirectory) Then
                Console.CurrentDirectory = Console.CurrentDirectory & "\" & TheDirectory
            ElseIf IO.Directory.Exists(TheDirectory) Then
                Console.CurrentDirectory = TheDirectory
            Else
                NewLine("The directory is not exist!")
            End If
        End If
    End Sub
End Module
