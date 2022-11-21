Module DuWM_Main
    Public OnlyOne As Boolean
    Public FirstWindow As Form
    Public SecondWindow As Form

    Public Sub DuWM_FirstWindowSet(WindowName As Form)
        WindowName.Show()
        WindowName.Height = Desktop.Height - 20
        WindowName.Width = (Desktop.Width / 2) - 20
        WindowName.Location = New Point(10, 10)
        FirstWindow = WindowName
        Strings.ProcessID(0) = 1
    End Sub

    Public Sub DuWM_SecondWindowSet(WindowName As Form)
        WindowName.Show()
        WindowName.Height = Desktop.Height - 20
        WindowName.Width = (Desktop.Width / 2) - 20
        WindowName.Location = New Point((Desktop.Width / 2) + 10, 10)
        SecondWindow = WindowName
        Strings.ProcessID(1) = 1
    End Sub

    Public Sub DuWM_SingleWindowSet(WindowName As Form)
        WindowName.Show()
        WindowName.Height = Desktop.Height - 20
        WindowName.Width = Desktop.Width - 20
        WindowName.Location = New Point(10, 10)
        FirstWindow = WindowName
    End Sub

    'Public Sub DuWM_GenerateWindowSet(WindowName As Form, PID As Integer)
    '    Dim NewWContainer As New DuWM_WindowContainer
    '    NewWContainer.Width = (Desktop.Width / 2) - 10
    '    NewWContainer.Height = Desktop.Height - 20
    '    NewWContainer.ChildForm = WindowName
    '    NewWContainer.ChildForm.TopLevel = False
    '    NewWContainer.ChildForm.FormBorderStyle = FormBorderStyle.None
    '    NewWContainer.ChildForm.Size = New Size((Desktop.Width / 2) - 10, Desktop.Height - 20)
    '    Select Case PID
    '        Case 0
    '            NewWContainer.Location = New Point(10, 10)
    '        Case 1
    '            NewWContainer.Location = New Point((Desktop.Width / 2) + 10, 10)
    '    End Select
    '    NewWContainer.ChildForm.WindowState = FormWindowState.Normal
    '    NewWContainer.ChildForm.Visible = False
    '    NewWContainer.DuWM_ContainerPanel.Controls.Add(NewWContainer.ChildForm)
    '    Select Case NewWContainer.ChildForm.Visible
    '        Case False
    '            NewWContainer.ChildForm.Visible = True
    '        Case Else
    '            NewWContainer.ChildForm.Visible = False
    '    End Select
    '    Dim WindowNameStr As String = Convert.ToString(WindowName)
    '    Select Case WindowNameStr
    '        Case "Console"
    '            NewWContainer.DuWM_PID = 0
    '            Strings.ProcessID(0) = 1
    '        Case "Shifter"
    '            NewWContainer.DuWM_PID = 1
    '            Strings.ProcessID(1) = 1
    '    End Select
    '    NewWContainer.Show()
    '    NewWContainer.DuWM_WMCheck.Start()
    'End Sub

    'Public Sub DuWM_KillAllWindow()
    '    Strings.ProcessID(0) = 0
    '    Strings.ProcessID(1) = 0
    'End Sub
End Module
