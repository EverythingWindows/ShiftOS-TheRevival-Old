Imports System.IO

Module KeyboardHandler
    Public InputKey As Keys

    Public Sub ShortcutHandle()
        Select Case InputKey
            Case (Keys.Control + Keys.Q)
                If Console.CurrentInterpreter = "terminal" Then
                Else
                    TerminateApp(KeyInput)
                    TextRebind()
                End If
            Case Else
                ExecKeyBinding(KeyInput)
        End Select
    End Sub

    Public Sub ExecKeyBinding(KeyInput As Keys)
        Select Case KeyInput
            Case (Keys.S + Keys.Control)
                Select Case Console.CurrentInterpreter
                    Case "textpad"
                        If File.Exists(Console.CurrentDirectory & "\" & command) = True Then
                            Dim TempCompare As String = File.ReadAllText(Console.CurrentDirectory & "\" & command)
                            If Console.TextBox1.Text = TempCompare Then

                            Else
                                Dim BeforeCP As Integer = Strings.ComputerInfo(2)
                                SaveFile(command)
                                TextPad_GenerateCP_SavedFile()
                                Dim AfterCP As Integer = Strings.ComputerInfo(2) - BeforeCP
                                Console.ToolBar.Text = "TextPad - " & command & " - You've got " & AfterCP & " Codepoints" & Environment.NewLine & "Ctrl-Q Exit | Ctrl-N New | Ctrl-O Open | Ctrl-S Save | F12 Save As"
                            End If
                        Else
                            Dim BeforeCP As Integer = Strings.ComputerInfo(2)
                            SaveFile(command)
                            TextPad_GenerateCP_SavedFile()
                            Dim AfterCP As Integer = Strings.ComputerInfo(2) - BeforeCP
                            Console.ToolBar.Text = "TextPad - " & command & " - You've got " & AfterCP & " Codepoints" & Environment.NewLine & "Ctrl-Q Exit | Ctrl-N New | Ctrl-O Open | Ctrl-S Save | F12 Save As"
                        End If
                End Select
            Case (Keys.N + Keys.Control)
                Select Case Console.CurrentInterpreter
                    Case "textpad"
                        Console.TextBox1.Text = Nothing
                End Select
        End Select
    End Sub

End Module
