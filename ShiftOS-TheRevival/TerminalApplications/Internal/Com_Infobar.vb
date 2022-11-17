Module Com_Infobar
    Public Sub Infobar()
        'Infobar panel-ish and some sort
        Dim infobarcommand As String = command.Replace("infobar ", "")
        Dim advancedtool As Boolean = True
        Select Case infobarcommand
            Case "on"
                Strings.OnceInfo(2) = "True"
                Console.CheckFeature()
                NormalCommand()
                advancedtool = False
            Case "off"
                Strings.OnceInfo(2) = "False"
                Console.CheckFeature()
                NormalCommand()
                advancedtool = False
        End Select
        If advancedtool = True Then
            If infobarcommand Like "color *" Then
                GetColor("infobar", infobarcommand.Substring(6, 1), infobarcommand.Substring(7, 1))
                NormalCommand()
            End If
        End If
    End Sub
End Module
