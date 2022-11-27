Imports System.IO

Public Class Uni_FileSkimmer
    Public CurrentDir As String
    Dim FileType As Integer
    Dim ItemsDeleted As Integer

    Private Sub Uni_FileSkimmer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets icons for buttons in here, for some reason
        btn_Up.BackgroundImage = My.Resources.FileSkimmerFunctionIcons.ico_up1
        'End thingy
        CurrentDir = Strings.OnceInfo(1)
        txt_AddressBar.Text = CurrentDir.Replace(Strings.OnceInfo(1), "!\")
        pic_Icon.Image = My.Resources.FileSkimmerFileIcons.ico_folder
        ShowContent()
    End Sub

    Private Sub PropertyPaneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertyPaneToolStripMenuItem.Click
        If PropertyPaneToolStripMenuItem.CheckState = False Then
            pnl_Properties.Visible = False
        Else
            pnl_Properties.Visible = True
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Dispose()
    End Sub

    Private Sub btn_Up_Click(sender As Object, e As EventArgs) Handles btn_Up.Click
        If txt_AddressBar.Text = "!\" Then
            btn_Up.Enabled = False
        Else
            Try
                If txt_AddressBar.Text = "!\" Then
                Else
                    Dim directoryInfo As System.IO.DirectoryInfo
                    directoryInfo = System.IO.Directory.GetParent(txt_AddressBar.Text.Replace("!\", Strings.OnceInfo(1) & "\"))
                    txt_AddressBar.Text = directoryInfo.FullName
                    CurrentDir = directoryInfo.FullName

                    Dim endloop As Boolean = False
                    txt_AddressBar.Text = txt_AddressBar.Text.Substring(0, txt_AddressBar.Text.Length - 1)

                    While endloop = False
                        Try
                            If txt_AddressBar.Text.Substring(txt_AddressBar.Text.Length - 1) = "\" Then
                                endloop = True
                            Else
                                txt_AddressBar.Text = txt_AddressBar.Text.Substring(0, txt_AddressBar.Text.Length - 1)
                            End If
                        Catch
                        End Try
                    End While
                    ShowContent()
                    'Try
                    '    ShowContent()
                    'Catch

                    'End Try
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub lsv_Content_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lsv_Content.MouseDoubleClick
        If txt_AddressBar.Text Like "*\" Then
        Else
            txt_AddressBar.Text = txt_AddressBar.Text + "\"
        End If
        ExecuteFile(txt_AddressBar.Text + lsv_Content.SelectedItems(0).Text)
    End Sub

    Private Sub lsv_Content_MouseClick(sender As Object, e As MouseEventArgs) Handles lsv_Content.MouseClick
        Select Case e.Button
            Case MouseButtons.Left
                If pnl_Properties.Visible = True Then
                    Dim IsFile As Boolean = False
                    If lsv_Content.SelectedItems(0).Text = Nothing Then

                    Else
                        If lsv_Content.SelectedItems(0).Text Like "*.txt" Then
                            pic_Icon.Image = My.Resources.FileSkimmerFileIcons.ico_textfile
                            lbl_filetype.Text = "Text File"
                            IsFile = True
                        End If
                        If IsFile = True Then
                            lbl_filesize.Visible = False
                            Dim filinf As New IO.FileInfo(CurrentDir & lsv_Content.SelectedItems(0).Text)
                            Dim filsize As Long = filinf.Length / 1024
                            Dim thesize As Integer = 1
                            Do
                                If filsize >= 1024 Then
                                    filsize = filsize / 1024
                                    thesize = thesize + 1
                                Else
                                    Exit Do
                                End If
                            Loop
                            Select Case thesize
                                Case 1
                                    lbl_filesize.Text = filsize & " KB"
                                Case 2
                                    lbl_filesize.Text = filsize & " MB"
                                Case 3
                                    lbl_filesize.Text = filsize & " GB"
                            End Select
                        Else
                            lbl_filetype.Text = "Folder"
                            lbl_filesize.Visible = False
                        End If
                        lbl_filename.Text = lsv_Content.SelectedItems(0).Text
                    End If
                End If
        End Select
    End Sub

    Public Sub ExecuteFile(path As String)
        If path Like "*.txt" Then
            Undeveloped()
        Else
            path = path.Replace("!\", Strings.OnceInfo(1) & "\")
            If My.Computer.FileSystem.DirectoryExists(path) Then
                CurrentDir = path
                txt_AddressBar.Text = CurrentDir.Replace(Strings.OnceInfo(1), "!")
                ShowContent()
            Else
            End If
        End If
    End Sub

    Public Sub ShowContent()
        Show()

        lsv_Content.Items.Clear()

        Dim Dir As New DirectoryInfo(CurrentDir)
        Dim Files As FileInfo() = Dir.GetFiles()
        Dim File As FileInfo
        Dim Folders As DirectoryInfo() = Dir.GetDirectories()
        Dim Folder As DirectoryInfo

        'For Each Dir As String In IO.Directory.GetDirectories(CurrentDir)
        '    Dim Dirinfo As New IO.DirectoryInfo(Dir)
        '    lsv_Content.Items.Add(Dirinfo.Name, 0)
        '    'NewLine("[DIR]     0 KB " & dirinf.Name)
        'Next

        For Each Folder In Folders
            Dim FolderName As String = Folder.Name
            lsv_Content.Items.Add(FolderName, 0)
        Next

        For Each File In Files
            Dim filename As String = File.Name
            Dim fileex As String = File.Extension

            FileType = GetFileType(fileex)(0)

            lsv_Content.Items.Add(filename, FileType)
        Next
    End Sub

    Public Function GetFileType(fileex As String)

        Dim FileType As Integer
        Dim Program As String

        Select Case fileex
            Case ".txt"
                FileType = 1
                Program = "Text Document"
            'Case ".doc"
            '    filetype = 5
            '    program = "Word Document"
            'Case ".docx"
            '    filetype = 5
            '    program = "Word Document"
            Case ".png"
                FileType = 3
                Program = "Picture"
            Case ".jpg"
                FileType = 3
                Program = "Picture"
            Case ".jpeg"
                FileType = 3
                Program = "Picture"
            Case ".bmp"
                FileType = 3
                Program = "Bitmap"
            Case ".gif"
                FileType = 3
                Program = "Animated Picture"
                'Case ".avi"
                '    filetype = 10
                '    program = "Video Clip"
                'Case ".m4v"
                '    filetype = 10
                '    program = "MPEG-4 Video"
                'Case ".mp4"
                '    filetype = 10
                '    program = "MPEG-4 Video"
                'Case ".wmv"
                '    filetype = 10
                '    program = "Windows Media Video"
                'Case ".mp3"
                '    filetype = 9
                '    program = "MPEG-3 Song"
                'Case ".zip"
                '    filetype = 11
                '    program = "Compressed Files"
                'Case ".dll"
                '    filetype = 8
                '    program = "System File"
                'Case ".exe"
                '    filetype = 6
                '    program = "MS-DOS Executable"
                'Case ".sh"
                '    filetype = 7
                '    program = "BASH Script"
                'Case ".bat"
                '    filetype = 6
                '    program = "MS-DOS Batch File"
                'Case ".url"
                '    filetype = 5
                '    program = "Shortcut"
                'Case ".htm", ".html"
                '    filetype = 5
                '    program = "Web Page"
            Case Else
                FileType = 2
                Program = "Unknown File Type"
        End Select

        Dim array() As String = {CStr(FileType), Program}

        Return (array)
        If txt_AddressBar.Text = "!\" Then
            'WARNING TO GET BACK BUTTON DISABLED
        End If
    End Function
End Class