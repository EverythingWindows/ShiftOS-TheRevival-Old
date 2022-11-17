Module CodepointSystem
    Public Sub ChangeCP(Addition As Boolean, NeededCP As Integer)
        Dim TempCP As Integer = Convert.ToInt32(Strings.ComputerInfo(2))
        If Addition = True Then
            TempCP = TempCP + NeededCP
        Else
            TempCP = TempCP - NeededCP
        End If
        Strings.ComputerInfo(2) = Convert.ToString(TempCP)
    End Sub
End Module
