Public Class ShiftOSAbout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/EverythingWindows/ShiftOS-TheRevival")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://shiftos-therevival.itch.io/shiftos-therevival")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://discord.gg/5QXxWJRM6R")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("https://www.youtube.com/@ShiftOS_")
    End Sub

    Private Sub ShiftOSAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Label3.Text & My.Resources.CurrentVersion
    End Sub
End Class