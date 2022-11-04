Public Class Strings
    Public Shared OSInfo() As String
    Public Shared ComputerInfo(3) As String
    Public Shared IsFree As Boolean
    Public Shared OnceInfo(0) As String
    Public Shared AvailableFeature(3) As String
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
    '
    'AvailableFeature (Default is defined on the Story Mode, Free Mode automatically assigns every available feature to 1, Unavailable in the Shiftorium assigned as 2) Strings:
    '0 = MAN command [Manual on each command] (0.2) (default : 0)
    '1 = CLEAR command [Clearing the screen] (0.2) (default : 0)
    '2 = PRINT command [Printing a string] (0.2.2) (default : 0)
    '3 = Terminal Display Driver [Dependencies for advanced terminal applications] (0.2.2) (default : 0)
    '
    'Features bought hierarchy :
    'ShiftOS Help Manual (MAN) (20 CP)
    'Terminal Clear (CLEAR) (25 CP)
    '>Terminal Print (PRINT) (30 CP)
    '>>Terminal Display Driver (50 CP)
End Class
