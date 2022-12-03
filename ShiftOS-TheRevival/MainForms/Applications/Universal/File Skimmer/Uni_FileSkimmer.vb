Imports System.IO
Imports System.IO.Compression

Public Class Uni_FileSkimmer
    Public CurrentDir As String
    Dim FileType As Integer
    Dim ItemsDeleted As Integer

    Private Sub Uni_FileSkimmer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckAvailable()
        'End thingy
        CurrentDir = Strings.OnceInfo(1)
        txt_AddressBar.Text = CurrentDir.Replace(Strings.OnceInfo(1), "!\")
        ShowContent()
    End Sub

    Private Sub CheckAvailable()
        If Strings.AvailableFeature(47) = 1 Then
            btn_Delete.Image = My.Resources.FileSkimmerFunctionIcons.largeico_deletefile
            DeleteToolStripMenuItem.Visible = True
        Else
            btn_Delete.Image = My.Resources.FileSkimmerFunctionIcons.largeico_unknown
            btn_Delete.Text = "???"
            DeleteToolStripMenuItem.Visible = False
        End If
        If Strings.AvailableFeature(48) = 1 Then
            btn_Compress.Image = My.Resources.FileSkimmerFunctionIcons.largeico_compress
            CompressToolStripMenuItem.Visible = True
        Else
            btn_Compress.Image = My.Resources.FileSkimmerFunctionIcons.largeico_unknown
            btn_Compress.Text = "???"
            CompressToolStripMenuItem.Visible = False
        End If
        If Strings.AvailableFeature(49) = 1 Then
            PropertyPaneToolStripMenuItem.Checked = True
            pnl_Properties.Visible = True
        Else
            PropertyPaneToolStripMenuItem.Checked = False
            PropertyPaneToolStripMenuItem.Visible = False
            pnl_Properties.Visible = False
        End If
        If Strings.AvailableFeature(50) = 1 Then
            JobBarToolStripMenuItem.Checked = True
            pnl_JobBar.Visible = True
        Else
            JobBarToolStripMenuItem.Checked = False
            JobBarToolStripMenuItem.Visible = False
            pnl_JobBar.Visible = False
        End If
        'Sets icons for buttons in here, for some reason
        btn_NewFolder.Image = My.Resources.FileSkimmerFunctionIcons.largeico_unknown
        btn_NewFolder.Text = "???"
        btn_Rename.Image = My.Resources.FileSkimmerFunctionIcons.largeico_unknown
        btn_Rename.Text = "???"
        btn_CopyPath.Image = My.Resources.FileSkimmerFunctionIcons.largeico_unknown
        btn_CopyPath.Text = "???"
        If Strings.AvailableFeature(51) = 1 Then
        Else
            cmb_Layout.Items.Remove("Small Icons")
        End If
        If Strings.AvailableFeature(52) = 1 Then
        Else
            cmb_Layout.Items.Remove("List")
        End If
        btn_Up.BackgroundImage = My.Resources.FileSkimmerFunctionIcons.ico_up1
        btn_Refresh.BackgroundImage = My.Resources.FileSkimmerFunctionIcons.ico_refresh
    End Sub

    Private Sub PropertyPaneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertyPaneToolStripMenuItem.Click
        If PropertyPaneToolStripMenuItem.CheckState = False Then
            pnl_Properties.Visible = False
        Else
            pnl_Properties.Visible = True
        End If
    End Sub

    Private Sub JobBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobBarToolStripMenuItem.Click
        If JobBarToolStripMenuItem.CheckState = False Then
            pnl_JobBar.Visible = False
        Else
            pnl_JobBar.Visible = True
        End If
    End Sub

    Private Sub CompressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompressToolStripMenuItem.Click
        If Strings.AvailableFeature(48) = 1 Then
            FS_Compression()
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        FS_Delete()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Dispose()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        FS_Delete()
    End Sub

    Private Sub btn_Compress_Click(sender As Object, e As EventArgs) Handles btn_Compress.Click
        If Strings.AvailableFeature(48) = 1 Then
            FS_Compression()
        Else

        End If
    End Sub

    Private Sub cmb_Layout_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Layout.SelectedIndexChanged
        Select Case cmb_Layout.SelectedItem.ToString
            Case "Large Icons"
                lsv_Content.View = View.LargeIcon
            Case "Small Icons"
                lsv_Content.View = View.SmallIcon
            Case "List"
                lsv_Content.View = View.List
        End Select
    End Sub

    Private Sub cmb_Layout_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cmb_Layout.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
        End If
        Dim sf As New StringFormat
        Using b As New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(cmb_Layout.GetItemText(cmb_Layout.Items(e.Index)), e.Font, b, e.Bounds, sf)
        End Using
        e.DrawFocusRectangle()
    End Sub

    Private Sub btn_Up_Click(sender As Object, e As EventArgs) Handles btn_Up.Click
        Try
            If txt_AddressBar.Text = "!\" Or txt_AddressBar.Text = "!" Then

            Else
                Dim directoryInfo As System.IO.DirectoryInfo
                directoryInfo = System.IO.Directory.GetParent(CurrentDir.Replace("!\", Strings.OnceInfo(1) & "\"))

                'Dim endloop As Boolean = False
                'lbllocation.Text = lbllocation.Text.Substring(0, lbllocation.Text.Length - 1)

                'While endloop = False
                '    Try
                '        If lbllocation.Text.Substring(lbllocation.Text.Length - 1) = "/" Then
                '            endloop = True
                '        Else
                '            lbllocation.Text = lbllocation.Text.Substring(0, lbllocation.Text.Length - 1)
                '        End If
                '    Catch
                '        infobox.title = "File Skimmer - Error!"
                '        infobox.textinfo = "Unable to move into a higher directory due to error reading the requested folder on the drive." & Environment.NewLine & Environment.NewLine & "An error occured going up"
                '        infobox.Show()
                '    End Try
                'End While
                Dim DirFullName As String = directoryInfo.FullName
                txt_AddressBar.Text = DirFullName.Replace(Strings.OnceInfo(1), "!")
                CurrentDir = DirFullName
                ShowContent()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
        ShowContent()
    End Sub

    Private Sub txt_AddressBar_TextChanged(sender As Object, e As KeyEventArgs) Handles txt_AddressBar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_AddressBar.Text Like "!*" Then
                Dim BackupCurrentDir As String = txt_AddressBar.Text
                BackupCurrentDir = BackupCurrentDir.Replace("!", Strings.OnceInfo(1))
                If BackupCurrentDir Like "*.*" Then

                Else
                    If Directory.Exists(BackupCurrentDir) = True Then
                        txt_AddressBar.Text = BackupCurrentDir.Replace(Strings.OnceInfo(1), "!")
                        CurrentDir = BackupCurrentDir
                        ShowContent()
                    End If
                End If
            Else
                txt_AddressBar.Text = "!\"
                CurrentDir = Strings.OnceInfo(1)
                ShowContent()
            End If
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
                Dim IsCompressed As Boolean = False
                If lsv_Content.SelectedItems(0).Text Like "*.zip" Then
                    IsCompressed = True
                End If
                If pnl_Properties.Visible = True Then
                    Dim IsFile As Boolean = False
                    If lsv_Content.SelectedItems(0).Text = Nothing Then
                        pic_Icon.Image = Nothing
                        lbl_filename.Visible = False
                        lbl_filetype.Visible = False
                        lbl_filesize.Visible = False
                    Else
                        lbl_filename.Visible = True
                        lbl_filetype.Visible = True
                        If lsv_Content.SelectedItems(0).Text Like "*.txt" Then
                            pic_Icon.Image = My.Resources.FileSkimmerFileIcons.ico_textfile
                            lbl_filetype.Text = "Text File"
                            IsFile = True
                        ElseIf lsv_Content.SelectedItems(0).Text Like "*.zip" Then
                            lbl_filetype.Text = "Compressed ZIP File"
                            IsFile = True
                        ElseIf lsv_Content.SelectedItems(0).Text Like "*.*" Then
                            pic_Icon.Image = My.Resources.FileSkimmerFileIcons.ico_unknown
                            lbl_filetype.Text = "Unknown File Type"
                            IsFile = True
                        ElseIf lsv_Content.SelectedItems(0).Text = "???" Then
                            pic_Icon.Image = My.Resources.FileSkimmerFileIcons.ico_unknown
                            lbl_filetype.Text = "Unknown Type"
                        End If
                        If IsFile = True Then
                            lbl_filesize.Visible = True
                            Dim filinf As New IO.FileInfo(CurrentDir & "\" & lsv_Content.SelectedItems(0).Text)
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
                            pic_Icon.Image = My.Resources.FileSkimmerFileIcons.ico_folder
                            lbl_filetype.Text = "Folder"
                            lbl_filesize.Visible = False
                        End If
                        lbl_filename.Text = lsv_Content.SelectedItems(0).Text
                    End If
                End If
                If Strings.AvailableFeature(48) = 1 Then
                    If IsCompressed = True Then
                        btn_Compress.Image = My.Resources.FileSkimmerFunctionIcons.largeico_uncompress
                        btn_Compress.Text = "Extract"
                        CompressToolStripMenuItem.Text = "Extract"
                    Else
                        btn_Compress.Image = My.Resources.FileSkimmerFunctionIcons.largeico_compress
                        btn_Compress.Text = "Compress"
                        CompressToolStripMenuItem.Text = "Compress"
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
            If Strings.AvailableFeature(45) = 1 Then
                lsv_Content.Items.Add(FolderName, 0)
            Else
                lsv_Content.Items.Add("???", 2)
            End If
        Next

        For Each File In Files
            Dim filename As String = File.Name
            Dim fileex As String = File.Extension
            FileType = GetFileType(fileex)(0)
            If Strings.AvailableFeature(46) = 1 Then
                lsv_Content.Items.Add(filename, FileType)
            Else
                lsv_Content.Items.Add("???", 2)
            End If
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

    Private Sub FS_Compression()
        Dim NothingIn As Boolean = True
        Dim ZipRandomInt As Integer
        Dim ZipRandom As New Random
        Dim UnzipRandomInt As Integer
        Dim UnzipRandom As New Random
        If lsv_Content.SelectedItems(0).Text Like "*.zip" Then
            UnzipRandomInt = UnzipRandom.Next(1, 1000000)
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\UNZIP" & UnzipRandomInt)
            ZipFile.ExtractToDirectory(CurrentDir & "\" & lsv_Content.SelectedItems(0).Text, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\UNZIP" & UnzipRandomInt)
            Directory.CreateDirectory(CurrentDir & "\" & lsv_Content.SelectedItems(0).Text.Replace(".zip", ""))
            CopyDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\UNZIP" & UnzipRandomInt, CurrentDir & "\" & lsv_Content.SelectedItems(0).Text.Replace("zip", ""))
            Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\UNZIP" & UnzipRandomInt, True)
        ElseIf lsv_Content.SelectedItems(0).Text Like "*.*" Then
            ZipRandomInt = ZipRandom.Next(1, 1000000)
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\ZIP" & ZipRandomInt)
            File.Copy(CurrentDir & "\" & lsv_Content.SelectedItems(0).Text, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\ZIP" & ZipRandomInt & "\" & lsv_Content.SelectedItems(0).Text)
            Dim Numbering As String = lsv_Content.SelectedItems(0).Text.Length
            Dim TheNaming As String = lsv_Content.SelectedItems(0).Text.Substring(0, Numbering - 3) & "zip"
            ZipFile.CreateFromDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\ZIP" & ZipRandomInt, CurrentDir & "\" & TheNaming)
            Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\ZIP" & ZipRandomInt, True)
            NothingIn = False
        ElseIf lsv_Content.SelectedItems(0).Text Like "*" Then
            If Directory.Exists(CurrentDir & "\" & lsv_Content.SelectedItems(0).Text) = True Then
                ZipFile.CreateFromDirectory(CurrentDir & "\" & lsv_Content.SelectedItems(0).Text, CurrentDir & "\" & lsv_Content.SelectedItems(0).Text & ".zip")
                NothingIn = False
            Else

            End If
        End If
        ShowContent()
    End Sub

    Private Sub FS_Delete()
        If Strings.AvailableFeature(47) = 0 Then

        Else
            Try
                If lsv_Content.SelectedItems(0).Text Like "*.*" Then
                    File.Delete(CurrentDir & "\" & lsv_Content.SelectedItems(0).Text)
                ElseIf lsv_Content.SelectedItems(0).Text Like "*" Then
                    Directory.Delete(CurrentDir & "\" & lsv_Content.SelectedItems(0).Text)
                End If
                ShowContent()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class