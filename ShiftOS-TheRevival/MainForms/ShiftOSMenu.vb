Imports System.IO

Public Class ShiftOSMenu

    Public Shared ActualBuildLab As String
    Public Shared BuildLab() As String
    Public Shared BannerUse As Integer = 1
    Public Shared TimeToChange
    Public Shared ShouldUpdate As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckInstall()
        lbl_BuildString.Text = My.Resources.CurrentVersion
        BannerChange.Start()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Select Case btn_Exit.Text
            Case "Exit"
                'Close()
                Application.Exit()
        End Select
    End Sub

    Private Sub btn_FreeRoam_Click(sender As Object, e As EventArgs) Handles btn_FreeRoam.Click
        Select Case btn_FreeRoam.Text
            Case "Free Roam Mode"
                Try
                    Strings.IsFree = True
                    Strings.OnceInfo(6) = "free"
                    IsConsoleParent = True
                    FreeRoamMode()
                    Console.Show()
                    Close()
                Catch ex As Exception
                    Dim NewBugSlap As New BugSlap
                    NewBugSlap.Show()
                    NewBugSlap.TextBox1.Text = ex.Message
                    Close()
                End Try
            Case "Continue"
                Strings.IsFree = False
                Strings.OnceInfo(6) = "story"
                IsConsoleParent = True
                StayAtChapter = True
                Console.Show()
                Close()
            Case "No"
                Label3.Visible = False
                btn_StoryMode.Text = "Story Mode"
                btn_FreeRoam.Text = "Free Roam Mode"
                btn_Aboot.Text = "About"
                btn_Aboot.Visible = True
                btn_Exit.Visible = True
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
                Label3.Text = "Are you sure?"
                Label3.Visible = True
                btn_StoryMode.Text = "Yes"
                btn_FreeRoam.Text = "No"
                btn_Aboot.Visible = False
                btn_Exit.Visible = False
            Case "Yes"
                Label3.Text = "Choose Chapter"
                btn_StoryMode.Text = "Chapter 1" & Environment.NewLine & "Hijacked!"
                btn_FreeRoam.Text = "Chapter 2" & Environment.NewLine & "Exploration"
                btn_Aboot.Text = "Chapter 3" & Environment.NewLine & "Escaped"
                btn_Exit.Text = "Chapter 4" & Environment.NewLine & "The known"
                btn_Aboot.Visible = True
                btn_Exit.Visible = True
                btn_Chapter5.Visible = True
                btn_Back.Visible = True
            Case "Chapter 1" & Environment.NewLine & "Hijacked!"
                Epilepsy.Show()
        End Select
    End Sub

    Private Sub btn_Aboot_Click(sender As Object, e As EventArgs) Handles btn_Aboot.Click
        Select Case btn_Aboot.Text
            Case "About"
                ShiftOSAbout.ShowDialog()
            Case "Back"
                btn_StoryMode.Text = "Story Mode"
                btn_FreeRoam.Text = "Free Roam Mode"
                btn_Aboot.Text = "About"
                btn_Exit.Visible = True
        End Select
    End Sub

    Private Sub btn_Chapter5_Click(sender As Object, e As EventArgs) Handles btn_Chapter5.Click

    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Label3.Visible = False
        btn_StoryMode.Text = "Story Mode"
        btn_FreeRoam.Text = "Free Roam Mode"
        btn_Aboot.Text = "About"
        btn_Exit.Text = "Exit"
        btn_Aboot.Visible = True
        btn_Exit.Visible = True
        btn_Chapter5.Visible = False
        btn_Back.Visible = False
    End Sub

    Private Sub CheckUpdate()
        Try
            If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SOS_NewVer.txt") = True Then
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SOS_NewVer.txt")
            End If
            My.Computer.Network.DownloadFile("http://148.251.124.62:8080/ShiftOS/data/NewVer.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SOS_NewVer.txt")
            Dim CurrentVersion As String = My.Resources.CurrentVersion
            Dim NewVersion As String = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SOS_NewVer.txt")
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
        If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS") = True Then
            Dim CurrentVersion As String = My.Resources.CurrentVersion
            If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\version.txt") = True Then
                TheUpdater.WhatVersion = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\version.txt")
            Else
                TheUpdater.WhatVersion = "0.2.4"
            End If
            If TheUpdater.WhatVersion = My.Resources.CurrentVersion Then
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\version.txt", My.Resources.CurrentVersion)
                CheckUpdate()
            Else
                btn_Aboot.Enabled = False
                btn_Exit.Enabled = False
                btn_FreeRoam.Enabled = False
                btn_StoryMode.Enabled = False
                ShouldUpdate = True
                ShiftOSUpdater.Show()
                ShiftOSUpdater.Label2.Text = "A new version, " & CurrentVersion & " is available." & Environment.NewLine & "Your version is " & TheUpdater.WhatVersion & Environment.NewLine & "Update now to get more features."                'ShiftOSUpdater.Label2.Text = "A new version, " & CurrentVersion & " is available." & Environment.NewLine & "Your version is " & TheUpdater.WhatVersion & "Update now to get more features."
                'ShiftOSUpdater.Label2.Text = "Update function is temporarily disabled." & Environment.NewLine & "Click the 'Reset' to reset the save"
                'ShiftOSUpdater.Button2.Text = "Reset"
            End If
        Else
            If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS") = True Then
                If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS") = True Then

                Else
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS")
                End If
                If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved") = True Then

                Else
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved")
                End If
                If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS") = True Then

                Else
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS")
                End If
            Else
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS")
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\ShiftFS")
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS")
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\saved")
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\version.txt", My.Resources.CurrentVersion)
            End If
            CheckUpdate()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label2.Text = "Debug it your way"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label3.Click
        If Label2.Text = "Debug it your way" Then
            Strings.IsFree = True
            GodMode()
            Console.Show()
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
