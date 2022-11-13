Public Class DebugWindow

    Public ShouldDebug As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clipboard.SetText(TextBox1.Text)
    End Sub

    Public Sub AddLine(subs As String, int As String, str As String, action As String)
        If ShouldDebug = True Then
            TextBox1.Text = TextBox1.Text & Environment.NewLine & subs & " Sub with " & str & " string and " & int & " integer did " & action
        End If
    End Sub
End Class