Imports MySql.Data.MySqlClient
Public Class Frm_Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strConnectionString As String
        strConnectionString = "Database=Water_Keeper;Data Source=localhost;User Id=root;Password=toor"
        Dim myConnection As New MySqlConnection(strConnectionString)
        Dim myInsertQuery As String = "INSERT INTO tipo_telefono (`tipo_fono_nombre`, `eliminado`, `modificable`) Values ('lol', 1,2)"
        Dim myCommand As New MySqlCommand(myInsertQuery)
        myCommand.Connection = myConnection
        myConnection.Open()
        myCommand.ExecuteNonQuery()
        myCommand.Connection.Close()
    End Sub

    Private Sub TeléfonosClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeléfonosClientesToolStripMenuItem.Click
        Frm_TelefonosCliente.MdiParent = Me
        Frm_TelefonosCliente.Show()
    End Sub
End Class
