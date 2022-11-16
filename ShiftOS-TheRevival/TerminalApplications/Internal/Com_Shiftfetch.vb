Module Com_Shiftfetch
    Public Sub Shiftfetch()
        If Strings.OnceInfo(0) = "Yes" Then
            NewLine("                 :^!7?JJJJJ?7!^:                  root@" & Strings.ComputerInfo(0))
        Else
            NewLine("                 :^!7?JJJJJ?7!^:                  " & Strings.ComputerInfo(1) & "@" & Strings.ComputerInfo(0))
        End If
        NewLine("            .~?PB###BGP555PGB###BP?~.             ----------------------")
        NewLine("        .!P#&B57^..:: ^~~!!~^::~7YG&#5!.          OS: ShiftOS TheRevival")
        NewLine("       .?#@G7: .^               :^::!5&#?.        Host: " & Environment.MachineName)
        NewLine("     .?#@5^  !                   .^!!..J&#?       Kernel: " & My.Resources.CurrentVersion)
        NewLine("    B@G^ .J                        : 7?..J@G:     Uptime : N/ A")
        NewLine("   ~&@Y  7         ~PB&#Y:.           ~G7 ~&&^    Packages: " & Strings.ComputerInfo(4))
        NewLine("  ^&@Y  Y         5#5??YB@&B~          .GJ :&&:   Shell: sos-justshell")
        NewLine("  G@B  ?         5P      ^YB!           .#! ~@G   Window Manager: -")
        NewLine(" ^@@! :          @Y   .:::^~:.           7#  Y@^  Window Manager Theme: -")
        NewLine(" 7@@: !          B@&BBBBGPPB@#Y.         :&^ ^@?  Terminal: shiftos-terminal")
        NewLine(" ?@@: 7          :??7~:.    5@@5         :&^ .&?  Terminal Font: Consolas, 11pt")
        NewLine(" ~@@! !@    G#&B!.          Y@@B         7#.  Y~  CPU: " & My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "ProcessorNameString", Nothing))
        NewLine("  B@G  B@J   ...~&G.       7@@@?        .#?   7   GPU: N/A")
        Dim TripleDigitRAM As String
        TripleDigitRAM = (My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024)
        NewLine("  ~&@? ^@Y       !G#57~~!YB@#Y^        .GP   ..   Memory: " & TripleDigitRAM.Substring(0, 4) & " GB")
        NewLine("   !@@7 ~#J        5#&&BG57^          ~BY         Codepoint: " & Strings.ComputerInfo(2))
        NewLine("    ~#@Y .5P~                       ^5G~          ")
        NewLine("     .J&#! ^JY!:.                ^?P5!            ")
        NewLine("       :J&B?..!JYY7!~::...::~!7Y5Y7:              ")
        NewLine("         .7PBP?^::~!?JJJJJJJ?7~:                  ")
        NewLine("            .~?55Y?!^:...                         ")
        NewLine("                 .:~~^~^^::.                      ")
    End Sub
End Module
