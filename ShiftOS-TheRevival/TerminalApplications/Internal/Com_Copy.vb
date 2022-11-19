Imports System.IO

Module Com_Copy
    Public CopyString As String

    Public Sub Copy()
        'CopyString = RawCommand
        If RawCommand Like "copy '*' '*'" Then
            Dim CopyEXE() As String = RawCommand.Split("''")
            Dim DestFile As String = CopyEXE(2)
            NewLine(DestFile)
            DestFile.Replace("!", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS")
            CopyEXE(2) = DestFile
            NewLine(CopyEXE(2) & "\" & CopyEXE(1))
            If File.Exists(Console.CurrentDirectory & "\" & CopyEXE(1)) = True Then
                If Directory.Exists(CopyEXE(2)) = True Then
                    NewLine(Console.CurrentDirectory & "\" & CopyEXE(1))
                    File.Copy(Console.CurrentDirectory & "\" & CopyEXE(1), CopyEXE(2) & "\" & CopyEXE(1))
                End If
            End If
        End If
    End Sub
End Module
