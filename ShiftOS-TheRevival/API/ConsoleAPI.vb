﻿Module ConsoleAPI
    Public Sub NewLine(str As String)
        Console.TextBox1.Text = Console.TextBox1.Text & Environment.NewLine & str
    End Sub

    Public Sub AddLine(str As String)
        Console.TextBox1.Text = Console.TextBox1.Text & str
    End Sub

    Public Sub ResetLine(str As String)
        Console.TextBox1.Text = str
    End Sub

    Public Sub Undeveloped()
        NewLine("Oopsie! It's only for newer version")
    End Sub

    Public Sub TextRebind()
        Console.TextBox1.Select(Console.TextBox1.Text.Length, 0)
        Console.TextBox1.ScrollToCaret()
    End Sub

    Public Sub TextRebindBehind()
        'Console.TextBox1.Select(Console.TextBox1.Lines.Length - 1, 0)
        Console.TextBox1.Select(Console.TextBox1.Lines.Length - 1, 0)
        Console.TextBox1.ScrollToCaret()
    End Sub
End Module