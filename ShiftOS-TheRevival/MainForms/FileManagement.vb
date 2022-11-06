Imports System.IO

Module FileManagement
    Public Sub CatFile(filename As String)
        If File.Exists(Terminal.CurrentDirectory & "\" & filename) = True Then
            Dim Contents As String = File.ReadAllText(Terminal.CurrentDirectory & "\" & filename)
            Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & Contents
        End If
    End Sub
End Module
