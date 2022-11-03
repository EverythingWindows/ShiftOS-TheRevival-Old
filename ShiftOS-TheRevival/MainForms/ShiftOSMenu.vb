Imports System.IO

Public Class ShiftOSMenu

    Public Shared ActualBuildLab As String
    Public Shared BuildLab() As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If File.Exists("D:\ShiftOSBuildLab.txt") Then
                BuildLab = File.ReadAllLines("D:\ShiftOSBuildLab.txt")
                If BuildLab(0) = "No" Then
                    Dim BuildNum As Integer = BuildLab(1)
                    BuildNum = BuildLab(1) + 1
                    ActualBuildLab = "ShiftOS_TheRevival." & BuildLab(3) & "." & BuildNum & "." & Date.Today.Year & Date.Today.Month & Date.Today.Day
                    BuildLab(1) = BuildNum
                    File.WriteAllLines("D:\ShiftOSBuildLab.txt", BuildLab)
                End If
                lbl_BuildString.Text = ActualBuildLab
            Else

            End If
        Catch ex As Exception
            MsgBox("Why? Because of " & ex.Message)
        End Try
        CheckUpdate()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Close()
    End Sub

    Private Sub btn_FreeRoam_Click(sender As Object, e As EventArgs) Handles btn_FreeRoam.Click
        Select Case btn_FreeRoam.Text
            Case "Free Roam Mode"
                Try
                    Strings.IsFree = True
                    Strings.AvailableFeature(0) = "0"
                    Strings.AvailableFeature(1) = "0"
                    Terminal.Show()
                    Close()
                Catch ex As Exception
                    Dim NewBugSlap As New BugSlap
                    NewBugSlap.Show()
                    NewBugSlap.TextBox1.Text = ex.Message
                    Close()
                End Try
            Case "Continue"
                MsgBox("This feature is in development")
        End Select
    End Sub

    Private Sub btn_StoryMode_Click(sender As Object, e As EventArgs) Handles btn_StoryMode.Click
        Select Case btn_StoryMode.Text
            Case "Story Mode"
                btn_StoryMode.Text = "New Game"
                btn_FreeRoam.Text = "Continue"
                btn_Aboot.Text = "Back"
                btn_Exit.Visible = False
            Case "New Game"
                Strings.IsFree = False
                MsgBox("This feature is in development, be sure to watch out for bugs")
                IntroStory.Show()
                Close()
        End Select
    End Sub

    Private Sub btn_Aboot_Click(sender As Object, e As EventArgs) Handles btn_Aboot.Click
        Select Case btn_Aboot.Text
            Case "Back"
                btn_StoryMode.Text = "Story Mode"
                btn_FreeRoam.Text = "Free Roam Mode"
                btn_Aboot.Text = "About"
                btn_Exit.Visible = True
        End Select
    End Sub

    Private Sub CheckUpdate()
        If File.Exists("C:\SOS_NewVer.txt") = True Then
            File.Delete("C:\SOS_NewVer.txt")
        End If
        My.Computer.Network.DownloadFile("http://148.251.124.62:8080/ShiftOS/data/NewVer.txt", "C:\SOS_NewVer.txt")
        Dim CurrentVersion As String = My.Resources.CurrentVersion
        Dim NewVersion As String = File.ReadAllText("C:\SOS_NewVer.txt")
        If CurrentVersion = NewVersion Then

        Else
            ShiftOSUpdater.Show()
            ShiftOSUpdater.Label2.Text = "A new version, " & NewVersion & " is available." & Environment.NewLine & "Your version is " & CurrentVersion
        End If
    End Sub
End Class
