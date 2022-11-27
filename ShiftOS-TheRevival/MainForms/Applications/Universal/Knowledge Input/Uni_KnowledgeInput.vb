Imports System.IO

Public Class Uni_KnowledgeInput
    Public Countries(194) As String
    Public Animals(226) As String
    Public Fruits(75) As String
    Public US_States(50) As String
    Public TotalGuessed As Integer
    Public CurrentCategory As String
    Public Level As Integer
    Public ForNextLevel As Integer
    Public JustStarted As Boolean = True

    Private Sub Uni_KnowledgeInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput") = True Then
            If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\Animals.kin") = True Then

            Else
                If Strings.AvailableFeature(38) = 1 Then
                    File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\Animals.kin", My.Resources.KnowledgeInputContent.Animals)
                End If
            End If
            If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\Fruits.kin") = True Then

            Else
                If Strings.AvailableFeature(39) = 1 Then
                    File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\Fruits.kin", My.Resources.KnowledgeInputContent.Fruits)
                End If
            End If
            If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\US_States.kin") = True Then

            Else
                If Strings.AvailableFeature(42) = 1 Then
                    File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\US_States.kin", My.Resources.KnowledgeInputContent.US_States)
                End If
            End If
        Else
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput")
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\Countries.kin", My.Resources.KnowledgeInputContent.Countries)
        End If
        CurrentCategory = "Select Category"
        LoadCategory()
    End Sub

    Private Sub lst_Guessed_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles lst_Guessed.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
        End If
        Dim sf As New StringFormat
        Using b As New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(lst_Guessed.GetItemText(lst_Guessed.Items(e.Index)), e.Font, b, e.Bounds, sf)
        End Using
        e.DrawFocusRectangle()
    End Sub

    Private Sub cmb_Category_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cmb_Category.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
        End If
        Dim sf As New StringFormat
        Using b As New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(cmb_Category.GetItemText(cmb_Category.Items(e.Index)), e.Font, b, e.Bounds, sf)
        End Using
        e.DrawFocusRectangle()
    End Sub

    Private Sub txt_InputWord_TextChanged(sender As Object, e As KeyEventArgs) Handles txt_InputWord.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                CheckCorrect(txt_InputWord.Text.ToLower)
                txt_InputWord.Text = Nothing
                JustStarted = False
        End Select
    End Sub

    Private Sub cmb_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Category.SelectedIndexChanged
        Dim Available As Boolean = False
        JustStarted = True
        lbl_TotalGuess.Text = "Guessed : 0/0"
        lst_Guessed.Items.Clear()
        Select Case cmb_Category.SelectedItem.ToString
            Case "Countries"
                If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\CurrentCountries.kin") = True Then
                    lst_Guessed.Items.AddRange(File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\CurrentCountries.kin"))
                End If
                Available = True
                Countries = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\Countries.kin")
            Case "Animals"
                If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\CurrentAnimals.kin") = True Then
                    lst_Guessed.Items.AddRange(File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\CurrentAnimals.kin"))
                End If
                Available = True
                Animals = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\Animals.kin")
            Case "Fruits"
                If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\CurrentFruits.kin") = True Then
                    lst_Guessed.Items.AddRange(File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\CurrentFruits.kin"))
                End If
                Available = True
                Fruits = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\Fruits.kin")
            Case "US States"
                If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\CurrentUS_States.kin") = True Then
                    lst_Guessed.Items.AddRange(File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\CurrentUS_States.kin"))
                End If
                Available = True
                US_States = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\US_States.kin")
        End Select
        If Available = True Then
            TotalGuessed = lst_Guessed.Items.Count
            lbl_TotalGuess.Text = "Guessed : " & TotalGuessed & "/"
            Select Case cmb_Category.SelectedItem.ToString
                Case "Countries"
                    lbl_TotalGuess.Text = lbl_TotalGuess.Text & Countries.Length
                Case "Animals"
                    lbl_TotalGuess.Text = lbl_TotalGuess.Text & Animals.Length
                Case "Fruits"
                    lbl_TotalGuess.Text = lbl_TotalGuess.Text & Fruits.Length
                Case "US States"
                    lbl_TotalGuess.Text = lbl_TotalGuess.Text & US_States.Length
            End Select
            Level = Math.Ceiling((TotalGuessed / 10))
            CheckLevel()
            CurrentCategory = cmb_Category.SelectedItem.ToString
        End If
    End Sub

    Private Sub LoadCategory()
        If Strings.AvailableFeature(38) = 0 Then
            cmb_Category.Items.Remove("Animals")
        End If
        If Strings.AvailableFeature(39) = 0 Then
            cmb_Category.Items.Remove("Fruits")
        End If
        If Strings.AvailableFeature(42) = 0 Then
            cmb_Category.Items.Remove("US States")
        End If
    End Sub

    Private Sub CheckLevel()
        lbl_Level.Text = "Level " & Level
        ForNextLevel = Math.Abs(TotalGuessed - (Level * 10))
        If ForNextLevel = 0 Then
            If JustStarted = False Then
                ChangeCP(True, Level * 25)
            End If
            Level = Level + 1
            lbl_Level.Text = "Level " & Level
            ForNextLevel = 10
        End If
        lbl_NextLevel.Text = "Words until next level (" & Level * 25 & " CP) : " & ForNextLevel
    End Sub

    Private Sub CheckCorrect(Input As String)
        Dim Correct As Boolean = False
        Select Case cmb_Category.SelectedItem.ToString
            Case "Countries"
                Dim Lines As Integer = 0
                Do
                    If Lines = Countries.Length Then
                        Exit Do
                    End If
                    If Countries(Lines) = Input Then
                        Countries(Lines) = "null"
                        Correct = True
                        Exit Do
                    Else
                        Lines = Lines + 1
                    End If
                Loop
            Case "Animals"
                Dim Lines As Integer = 0
                Do
                    If Lines = Animals.Length Then
                        Exit Do
                    End If
                    If Animals(Lines) = Input Then
                        Animals(Lines) = "null"
                        Correct = True
                        Exit Do
                    Else
                        Lines = Lines + 1
                    End If
                Loop
            Case "Fruits"
                Dim Lines As Integer = 0
                Do
                    If Lines = Fruits.Length Then
                        Exit Do
                    End If
                    If Fruits(Lines) = Input Then
                        Fruits(Lines) = "null"
                        Correct = True
                        Exit Do
                    Else
                        Lines = Lines + 1
                    End If
                Loop
            Case "US States"
                Dim Lines As Integer = 0
                Do
                    If Lines = US_States.Length Then
                        Exit Do
                    End If
                    If US_States(Lines) = Input Then
                        US_States(Lines) = "null"
                        Correct = True
                        Exit Do
                    Else
                        Lines = Lines + 1
                    End If
                Loop
        End Select
        If Correct = True Then
            lst_Guessed.Items.Add(Input)
            TotalGuessed = lst_Guessed.Items.Count
            lbl_TotalGuess.Text = "Guessed : " & TotalGuessed & "/"
            Select Case cmb_Category.SelectedItem.ToString
                Case "Countries"
                    lbl_TotalGuess.Text = lbl_TotalGuess.Text & Countries.Length
                Case "Animals"
                    lbl_TotalGuess.Text = lbl_TotalGuess.Text & Animals.Length
                Case "Fruits"
                    lbl_TotalGuess.Text = lbl_TotalGuess.Text & Fruits.Length
                Case "US States"
                    lbl_TotalGuess.Text = lbl_TotalGuess.Text & US_States.Length
            End Select
            CheckLevel()
            SaveCategory()
        End If
    End Sub

    Private Sub SaveCategory()
        Select Case CurrentCategory
            Case "Countries"
                File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\Countries.kin", Countries)
                File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\CurrentCountries.kin", lst_Guessed.Items.Cast(Of String).ToArray)
            Case "Animals"
                File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\Animals.kin", Animals)
                File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\CurrentAnimals.kin", lst_Guessed.Items.Cast(Of String).ToArray)
            Case "Fruits"
                File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\Fruits.kin", Fruits)
                File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\CurrentFruits.kin", lst_Guessed.Items.Cast(Of String).ToArray)
            Case "US States"
                File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\US_States.kin", US_States)
                File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\KnowledgeInput\CurrentUS_States.kin", lst_Guessed.Items.Cast(Of String).ToArray)
        End Select
    End Sub
End Class