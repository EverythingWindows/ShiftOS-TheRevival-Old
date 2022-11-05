Public Class Strings
    Public Shared OSInfo() As String
    Public Shared ComputerInfo(4) As String
    Public Shared IsFree As Boolean
    Public Shared OnceInfo(0) As String
    Public Shared AvailableFeature(9) As String
    Public Shared CLIInterpreter As String
    Public Shared SaveFile As String

    'STRING CATEGORIZATION WRITING RULES!
    'THIS IS IN ORDER TO REMAIN COMPATIBLE WITH OLDER VERSIONS!
    '
    'General string :
    '(Row Number) = Function/Subject (default value : default)
    '
    'Each have to placed in numerical order
    'If there's moved strings for newer version, example:
    '0 = Computer Name (0.1) => OS Version (0.2) => Root Location (0.3), etc.
    'If there's removed strings for newer version, example:
    '69 = Secret Easter Egg (removed in 0.420)
    'If there's repurposed strings for newer version after removed, example:
    '5 = FreeRoam enabled? (removed in 0.4) => Story Mode State
    '
    'ALWAYS WRITE THE NOTES IN COMMENTS, THIS CLASS ONLY IS FOR STORING STRINGS AND DEPLOYING STRINGS TO DISK

    'OSInfo Strings:
    '0 = OSVersion (default : dependant)
    '
    'OnceInfo Strings:
    '0 = IsRoot? (0.1) (default : No)
    '
    'ComputerInfo Strings:
    '0 = Computer Name (0.1) (default : shiftos)
    '1 = Username (0.1) (default : user)
    '2 = Codepoint (0.2) (default : 0)
    '3 = Story Chapter (0.2) (default : 0 for New Game)
    '4 = Installed Packages (0.2.3) (default : 0 for New Game)
    '
    'AvailableFeature (Default is defined on the Story Mode, Free Mode automatically assigns every available feature to 1, Unavailable in the Shiftorium assigned as 2, Upgraded assigned as 3) Strings:
    '0 = MAN command [Manual on each command] (0.2) (default : 0)
    '1 = CLEAR command [Clearing the screen] (0.2) (default : 0)
    '2 = PRINT command [Printing a string] (0.2.2) (default : 0)
    '3 = Terminal Display Driver [Dependencies for advanced terminal applications] (0.2.2) (default : 0)
    '4 = Terminal InfoBar [A panel bar at the bottom of the terminal to show 'Time', 'User Session', 'Codepoint', 'Program running'] (0.2.2) (default : 0)
    '5 = Time by Second [Showing time in seconds form since midnight] (0.2.2) (default : 0)
    '6 = Time by Minutes [Showing time in minutes form since midnight] (0.2.2) (default : 0)
    '7 = Time by Hours [Showing time in hours form since midnight] (0.2.2) (default : 0)
    '8 = Shiftfetch [ShiftOS port of Neofetch, A command-line system information tool] (0.2.3) (default : 0)
    '9 = bc [Basic Calculator for ShiftOS] (0.2.3) (default : 0)
    '
    'Features bought hierarchy :
    'ShiftOS Help Manual (MAN) (20 CP)
    'Terminal Clear (CLEAR) (25 CP)
    '>Terminal Print (PRINT) (30 CP)
    '>Basic Calculator (BC) (75 CP)
    '>>Terminal Display Driver (50 CP)
    '>>>Terminal InfoBar (55 CP)
    '>>>Shiftfetch (75 CP)
    '>Time by Seconds (TIME, STIME) (10 CP)
    '>>Time by Minutes (TIME, MTIME) (20 CP)
    '>>>Time by Hours (Time, HTIME) (40 CP)
End Class
