Module Com_Applist
    Public Sub AppList()
        NewLine("ShiftOS Graphical Application List")
        NewLine("To run a program, you can type 'app ' and the name of the program listed below (along with its underscore or any symbols included)")
        NewLine(Nothing)
        If Strings.AvailableFeature(37) = 1 Then
            NewLine("KNOWLEDGE_INPUT          Simple puzzle game where you guess as many things as you can")
        End If
        If Strings.AvailableFeature(36) = 1 Then
            NewLine("SHIFTER                  Graphical customization program for ShiftOS")
        End If
    End Sub
End Module
