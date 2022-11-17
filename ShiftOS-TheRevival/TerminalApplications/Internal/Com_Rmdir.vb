Module Com_Rmdir
    Public Sub RemoveDir(TheDirectory As String)
        If IO.Directory.Exists(Console.CurrentDirectory + "\" + TheDirectory) Then
            Try
                IO.Directory.Delete(Console.CurrentDirectory + "\" + TheDirectory)
            Catch ex As Exception
                NewLine(ex.Message)
            End Try
        Else
            NewLine("The directory is not exists!")
        End If
    End Sub
End Module
