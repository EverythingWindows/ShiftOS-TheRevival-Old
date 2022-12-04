Public Class AnusWM_Menu
    Private Sub StopAnusWMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopAnusWMToolStripMenuItem.Click
        StopG()
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click

    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem.Click
        TerminateShiftOS()
    End Sub

    Private Sub ApplicationToolStripMenuSubItem_Click(sender As Object, e As ToolStripItemClickedEventArgs) Handles ApplicationsToolStripMenuItem.DropDownItemClicked
        MsgBox(e.ClickedItem.Text.ToString)
    End Sub
End Class