Imports System.IO

Module FileManagement
    Public Sub CatFile(filename As String)
        If File.Exists(Terminal.CurrentDirectory & "\" & filename) = True Then
            Dim ContentsFinal As String = File.ReadAllText(Terminal.CurrentDirectory & "\" & filename)
            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ContentsFinal
        End If
    End Sub

    Public Sub SaveFile(filename As String)
        'If File.Exists(Terminal.CurrentDirectory & "\" & filename) = False Then
        '    File.WriteAllText(Terminal.CurrentDirectory & "\" & filename, Terminal.TextBox1.Text)
        'Else
        '    File.WriteAllText(Terminal.CurrentDirectory & "\" & filename, Terminal.TextBox1.Text)
        'End If
        File.WriteAllText(Terminal.CurrentDirectory & "\" & filename, Terminal.TextBox1.Text)
    End Sub
End Module
