Imports MySql.Data.MySqlClient
Module ModMsysql
    Public Sqlcn1 As New MySqlConnection
    Public SqlCmd1 As New MySqlCommand
    Public vSqlTimeout As Integer = 60
    Public strCnn As String
    Public Sub Abre_conexion()
        Dim Configreader As System.Configuration.AppSettingsReader
        Configreader = New System.Configuration.AppSettingsReader
        Dim Vuser As String
        Dim Vpass As String
        Dim Vdatabase As String
        Dim Vserver As String
        Vserver = CStr(Configreader.GetValue("server", GetType(String)))
        Vdatabase = CStr(Configreader.GetValue("database", GetType(String)))
        Vuser = CStr(Configreader.GetValue("user", GetType(String)))
        Vpass = CStr(Configreader.GetValue("pass", GetType(String)))
        vSqlTimeout = CInt(Configreader.GetValue("TimeOut", GetType(Integer)))
        strCnn = "Data Source=" & Vserver & ";Database=" & Vdatabase & ";User Id=" & Vuser & ";Password=" & Vpass & ";"
        Sqlcn1.ConnectionString = strCnn
    End Sub
End Module
