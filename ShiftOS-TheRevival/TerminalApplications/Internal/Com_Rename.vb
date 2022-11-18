Imports System.IO

Module Com_Rename
    Public ShouldRename As Boolean

    Public Sub Rename()
        Dim Names() As String = command.Split("''")
        If Names(1) = "" Then
            NewLine("No filename has been inputted")
            ShouldRename = False
        ElseIf Names(1) Like " *" Then
            NewLine("Filename cannot be started with spaces")
            ShouldRename = False
        Else
            ShouldRename = True
        End If
        If Names(3) = "" Then
            NewLine("No new filename has been inputted")
            ShouldRename = False
        ElseIf Names(3) Like " *" Then
            NewLine("Filename cannot be started with spaces")
            ShouldRename = False
        Else
            ShouldRename = True
        End If
        If ShouldRename = True Then
            If File.Exists(Console.CurrentDirectory & "\" & Names(1)) = True Then
                FileSystem.Rename(Console.CurrentDirectory & "\" & Names(1), Console.CurrentDirectory & "\" & Names(3))
            Else
                NewLine("File is not exist")
            End If
        End If
    End Sub
End Module
