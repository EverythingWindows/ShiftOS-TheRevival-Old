Public Class Strings
    Public Shared OSInfo() As String
    Public Shared ComputerInfo(1) As String
    Public Shared IsFree As Boolean
    Public Shared OnceInfo(0) As String

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
    '0 = IsRoot? (default : 0)
    '
    'ComputerInfo Strings:
    '0 = Computer Name (default : shiftos)
    '1 = Username (default : user)
    '
End Class
