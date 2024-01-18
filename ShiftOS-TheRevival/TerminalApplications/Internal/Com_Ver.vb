Module Com_Ver
    Public Sub Terminal_Version()
        Select Case Strings.OnceInfo(9)
            Case 1
                NewLine(My.Resources.lang_en.Console_Ver_FullString & My.Resources.CurrentVersion)
            Case 2
                NewLine(My.Resources.lang_id.Console_Ver_FullString & My.Resources.CurrentVersion)
        End Select
    End Sub
End Module
