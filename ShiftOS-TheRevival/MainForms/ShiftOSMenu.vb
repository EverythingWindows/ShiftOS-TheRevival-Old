Imports System.IO

Public Class Form1

    Public Shared ActualBuildLab As String
    Public Shared BuildLab() As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BuildLab = File.ReadAllLines("D:\ShiftOSBuildLab.txt")
            If BuildLab(0) = "No" Then
                Dim BuildNum As Integer = BuildLab(1)
                BuildNum = BuildLab(1) + 1
                ActualBuildLab = "ShiftOS_TheRevival." & BuildLab(3) & "." & BuildNum & "." & Date.Today.Year & Date.Today.Month & Date.Today.Day
                BuildLab(1) = BuildNum
                File.WriteAllLines("D:\ShiftOSBuildLab.txt", BuildLab)
            End If
            lbl_BuildString.Text = ActualBuildLab
        Catch ex As Exception
            MsgBox("Why? Because of " & ex.Message)
        End Try
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Close()
    End Sub

    Private Sub btn_FreeRoam_Click(sender As Object, e As EventArgs) Handles btn_FreeRoam.Click
        Try
            Strings.GameState(0) = "Free"
            TerminalPrompt.Show()
            Close()
        Catch ex As Exception
            Dim NewBugSlap As New BugSlap
            NewBugSlap.Show()
            NewBugSlap.TextBox1.Text = ex.Message
            Close()
        End Try
    End Sub
End Class
