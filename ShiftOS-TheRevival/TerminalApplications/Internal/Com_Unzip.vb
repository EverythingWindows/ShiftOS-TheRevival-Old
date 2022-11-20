Imports System.IO
Imports System.IO.Compression

Module Com_Unzip
    Public UnzipString As String

    Public Sub Unzip()
        UnzipString = RawCommand.Substring(6)
        If UnzipString Like "-d '*.zip'" Then
            Dim UnzipEXE() As String = UnzipString.Split("''")
            If File.Exists(Console.CurrentDirectory & "\" & UnzipEXE(1)) = True Then
                Dim UnzipDir As String = UnzipEXE(1).Replace(".zip", "")
                Dim UnzipRandomInt As Integer
                Dim UnzipRandom As New Random
                UnzipRandomInt = UnzipRandom.Next(1, 1000000)
                NewLine("Creating temporary place for selected archive...")
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\UNZIP" & UnzipRandomInt)
                NewLine("Extracting the file from a zip file...")
                ZipFile.ExtractToDirectory(Console.CurrentDirectory & "\" & UnzipEXE(1), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\UNZIP" & UnzipRandomInt)
                NewLine("Copying the extracted file into the current directory...")
                Directory.CreateDirectory(Console.CurrentDirectory & "\" & UnzipDir)
                CopyDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\UNZIP" & UnzipRandomInt, Console.CurrentDirectory & "\" & UnzipDir)
                NewLine("Removing temporary place of the file...")
                Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\UNZIP" & UnzipRandomInt, True)
            Else

            End If
        End If
        If UnzipString Like "-f '*.zip'" Then
            Dim UnzipEXE() As String = UnzipString.Split("''")
            If File.Exists(Console.CurrentDirectory & "\" & UnzipEXE(1)) = True Then
                Dim UnzipDir As String = UnzipEXE(1).Replace(".zip", "")
                Dim UnzipRandomInt As Integer
                Dim UnzipRandom As New Random
                UnzipRandomInt = UnzipRandom.Next(1, 1000000)
                NewLine("Creating temporary place for selected archive...")
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\UNZIP" & UnzipRandomInt)
                NewLine("Extracting the file from a zip file...")
                ZipFile.ExtractToDirectory(Console.CurrentDirectory & "\" & UnzipEXE(1), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\UNZIP" & UnzipRandomInt)
                NewLine("Copying the extracted file into the current directory...")
                Directory.CreateDirectory(Console.CurrentDirectory & "\" & UnzipDir)
                CopyDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\UNZIP" & UnzipRandomInt, Console.CurrentDirectory)
                NewLine("Removing temporary place of the file...")
                Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\UNZIP" & UnzipRandomInt, True)
            Else

            End If
        End If
    End Sub

    Public Sub CopyDirectory(ByVal SourcePath As String, ByVal DestPath As String, Optional ByVal Overwrite As Boolean = False)
        Dim SourceDir As DirectoryInfo = New DirectoryInfo(SourcePath)
        Dim DestDir As DirectoryInfo = New DirectoryInfo(DestPath)

        ' the source directory must exist, otherwise throw an exception
        If SourceDir.Exists Then
            ' if destination SubDir's parent SubDir does not exist throw an exception
            If Not DestDir.Parent.Exists Then
                Throw New DirectoryNotFoundException _
                  ("Destination directory does not exist: " + DestDir.Parent.FullName)
            End If

            If Not DestDir.Exists Then
                DestDir.Create()
            End If

            ' copy all the files of the current directory
            Dim ChildFile As FileInfo
            For Each ChildFile In SourceDir.GetFiles()
                If Overwrite Then
                    ChildFile.CopyTo(Path.Combine(DestDir.FullName, ChildFile.Name), True)
                Else
                    ' if Overwrite = false, copy the file only if it does not exist
                    ' this is done to avoid an IOException if a file already exists
                    ' this way the other files can be copied anyway...
                    NewLine("Copying " & ChildFile.Name & "...")
                    If Not File.Exists(Path.Combine(DestDir.FullName, ChildFile.Name)) Then
                        ChildFile.CopyTo(Path.Combine(DestDir.FullName, ChildFile.Name), False)
                        AddLine(" OK")
                    End If
                End If
            Next

            ' copy all the sub-directories by recursively calling this same routine
            Dim SubDir As DirectoryInfo
            For Each SubDir In SourceDir.GetDirectories()
                NewLine("Copying " & SubDir.Name & "...")
                CopyDirectory(SubDir.FullName, Path.Combine(DestDir.FullName,
                  SubDir.Name), Overwrite)
                AddLine(" OK")
            Next
        Else
            Throw New DirectoryNotFoundException("Source directory does not exist: " + SourceDir.FullName)
        End If
    End Sub
End Module
