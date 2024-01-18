Module Com_Lang
    Public LangNum As Integer

    Public Sub Lang()
        LangNum = RawCommand.Substring(5)
        Select Case LangNum
            Case 1
                ' English
                Strings.OnceInfo(9) = 1
            Case 2
                ' Indonesian
                Strings.OnceInfo(9) = 2
        End Select
    End Sub
End Module
