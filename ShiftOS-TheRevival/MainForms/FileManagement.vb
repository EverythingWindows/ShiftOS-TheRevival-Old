Imports System.IO

Module FileManagement
    Public Sub CatFile(filename As String)
        If File.Exists(Terminal.CurrentDirectory & "\" & filename) = True Then
            Try
                Dim Contents As Byte() = File.ReadAllBytes(Terminal.CurrentDirectory & "\" & filename)
                Dim ContentsFinal As String = Convert.ToString(Contents)
                Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ContentsFinal
            Catch ex As Exception
                Try
                    Dim ContentsFinal As String() = File.ReadAllLines(Terminal.CurrentDirectory & "\" & filename)
                    Terminal.TextBox1.Text = Terminal.TextBox1.Text & Environment.NewLine & ContentsFinal
                Catch ex As Exception

                End Try
            End Try
        End If
    End Sub
End Module
