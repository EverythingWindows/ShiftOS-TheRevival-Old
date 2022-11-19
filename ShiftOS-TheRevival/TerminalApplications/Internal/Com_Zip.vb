Imports System.IO
Imports System.IO.Compression

Module Com_Zip
    Public ZipString As String

    Public Sub Zip()
        ZipString = RawCommand.Substring(4)
        If ZipString Like "-f '*.zip' '*'" Then
            Dim ZipEXE() As String = ZipString.Split("''")
            If File.Exists(Console.CurrentDirectory & "\" & ZipEXE(3)) = True Then
                Dim ZipRandomInt As Integer
                Dim ZipRandom As New Random
                ZipRandomInt = ZipRandom.Next(1, 1000000)
                NewLine("Creating temporary place for selected file...")
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\ZIP" & ZipRandomInt)
                NewLine("Assigning place for the selected file...")
                File.Copy(Console.CurrentDirectory & "\" & ZipEXE(3), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\ZIP" & ZipRandomInt & "\" & ZipEXE(3))
                NewLine("Compressing the file into a zip file...")
                ZipFile.CreateFromDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\ZIP" & ZipRandomInt, Console.CurrentDirectory & "\" & ZipEXE(1))
                NewLine("Removing temporary place of the file...")
                Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ShiftOS\SysShiftFS\ZIP" & ZipRandomInt, True)
            Else

            End If
        End If
        If ZipString Like "-d '*.zip' '*'" Then
            Dim ZipEXE() As String = ZipString.Split("''")
            If Directory.Exists(Console.CurrentDirectory & "\" & ZipEXE(3)) = True Then
                NewLine("Compressing the directory into a zip file...")
                ZipFile.CreateFromDirectory(Console.CurrentDirectory & "\" & ZipEXE(3), Console.CurrentDirectory & "\" & ZipEXE(1))
            Else

            End If
        End If
    End Sub
End Module
