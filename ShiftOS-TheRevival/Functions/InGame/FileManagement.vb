Imports System.IO

Module FileManagement
    Public Sub CatFile(filename As String)
        If File.Exists(Console.CurrentDirectory & "\" & filename) = True Then
            Dim ContentsFinal As String = File.ReadAllText(Console.CurrentDirectory & "\" & filename)
            NewLine(ContentsFinal)
        Else
            NewLine("File is not exist")
        End If
    End Sub

    Public Sub DeleteFile(filename As String)
        If File.Exists(Console.CurrentDirectory & "\" & filename) = True Then
            File.Delete(Console.CurrentDirectory & "\" & filename)
        Else
            NewLine("File is not exist")
        End If
    End Sub

    Public Sub SaveFile(filename As String)
        'If File.Exists(Terminal.CurrentDirectory & "\" & filename) = False Then
        '    File.WriteAllText(Terminal.CurrentDirectory & "\" & filename, Terminal.TextBox1.Text)
        'Else
        '    File.WriteAllText(Terminal.CurrentDirectory & "\" & filename, Terminal.TextBox1.Text)
        'End If
        File.WriteAllText(Console.CurrentDirectory & "\" & filename, Console.TextBox1.Text)
    End Sub
End Module
