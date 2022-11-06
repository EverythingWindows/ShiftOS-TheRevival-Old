Imports System.IO

Public Class ShiftOSMenu

    Public Shared ActualBuildLab As String
    Public Shared BuildLab() As String
    Public Shared BannerUse As Integer = 1
    Public Shared TimeToChange
    Public Shared ShouldUpdate As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    If File.Exists("D:\ShiftOSBuildLab.txt") Then
        '        BuildLab = File.ReadAllLines("D:\ShiftOSBuildLab.txt")
        '        If BuildLab(0) = "No" Then
        '            Dim BuildNum As Integer = BuildLab(1)
        '            BuildNum = BuildLab(1) + 1
        '            ActualBuildLab = "ShiftOS_TheRevival." & BuildLab(3) & "." & BuildNum & "." & Date.Today.Year & Date.Today.Month & Date.Today.Day
        '            BuildLab(1) = BuildNum
        '            File.WriteAllLines("D:\ShiftOSBuildLab.txt", BuildLab)
        '        End If
        '        lbl_BuildString.Text = ActualBuildLab
        '    Else

        '    End If
        'Catch ex As Exception
        '    MsgBox("Why? Because of " & ex.Message)
        'End Try
        CheckUpdate()
        'CheckInstall()
        BannerChange.Start()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Close()
    End Sub

    Private Sub btn_FreeRoam_Click(sender As Object, e As EventArgs) Handles btn_FreeRoam.Click
        Select Case btn_FreeRoam.Text
            Case "Free Roam Mode"
                Try
                    Strings.IsFree = True
                    FreeRoamMode()
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
                NewGameMode()
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
        Try
            If File.Exists("C:\SOS_NewVer.txt") = True Then
                File.Delete("C:\SOS_NewVer.txt")
            End If
            My.Computer.Network.DownloadFile("http://148.251.124.62:8080/ShiftOS/data/NewVer.txt", "C:\SOS_NewVer.txt")
            Dim CurrentVersion As String = My.Resources.CurrentVersion
            Dim NewVersion As String = File.ReadAllText("C:\SOS_NewVer.txt")
            If CurrentVersion = NewVersion Then

            Else
                btn_Aboot.Enabled = False
                btn_Exit.Enabled = False
                btn_FreeRoam.Enabled = False
                btn_StoryMode.Enabled = False
                ShiftOSUpdater.Show()
                ShiftOSUpdater.NewVersion = NewVersion
                ShiftOSUpdater.Label2.Text = "A new version, " & NewVersion & " is available." & Environment.NewLine & "Your version is " & CurrentVersion
                ShiftOSUpdater.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckInstall()
        If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\ShiftOS\ShiftFS") = True Then
            Dim WhatVersion As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\ShiftOS\version.txt")
            If WhatVersion = My.Resources.CurrentVersion Then

            Else
                btn_Aboot.Enabled = False
                btn_Exit.Enabled = False
                btn_FreeRoam.Enabled = False
                btn_StoryMode.Enabled = False
                ShouldUpdate = True
                ShiftOSUpdater.Show()
            End If
        Else
            If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\ShiftOS") = True Then
                If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\ShiftOS\ShiftFS") = True Then
                    Directory.CreateDirectory(My.Computer.FileSystem.GetTempFileName & "\ShiftOS\ShiftFS")
                End If
            Else
                Directory.CreateDirectory(My.Computer.FileSystem.GetTempFileName & "\ShiftOS")
                Directory.CreateDirectory(My.Computer.FileSystem.GetTempFileName & "\ShiftOS\ShiftFS")
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label2.Text = "Debug it your way"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Label2.Text = "Debug it your way" Then
            Strings.IsFree = True
            GodMode()
            Terminal.Show()
            Close()
        End If
    End Sub

    Private Sub BannerChange_Tick(sender As Object, e As EventArgs) Handles BannerChange.Tick
        Select Case TimeToChange
            Case 50
                Thumbnail.BackgroundImage = My.Resources.MenuBanner1
            Case 100
                Thumbnail.BackgroundImage = My.Resources.MenuBanner2
                TimeToChange = 0
        End Select
        TimeToChange = TimeToChange + 1
    End Sub
End Class
