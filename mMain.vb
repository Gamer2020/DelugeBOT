Imports System.IO

Module mMain

    Public AppPath As String = System.AppDomain.CurrentDomain.BaseDirectory() & IIf(Right(System.AppDomain.CurrentDomain.BaseDirectory(), 1) = "\", "", "\")
    Public config_file As String = AppPath & "config.ini"

End Module
