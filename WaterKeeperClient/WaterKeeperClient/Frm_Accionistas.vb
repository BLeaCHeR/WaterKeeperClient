Imports MySql.Data.MySqlClient
Public Class Frm_Accionistas
    Dim DataAdLlenaAccionistas As New MySqlDataAdapter
    Dim DataSetLlenado As New DataSet
    Dim BS_Accionistas As New BindingSource

    Private Sub Frm_Accionistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGVAccionistas.AllowUserToAddRows = False
        DGVAccionistas.AllowUserToDeleteRows = False
        DGVAccionistas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DGVAccionistas.Columns.Add("ID_ACCIONISTA", "ID_ACCIONISTA")
        DGVAccionistas.Columns.Add("RUT_ACCIONISTA", "RUT")
        DGVAccionistas.Columns.Add("NOMBRE_ACCIONISTA", "NOMBRE")
        DGVAccionistas.Columns.Add("APELLIDOP_ACCIONISTA", "APELLIDO PATERNO")
        DGVAccionistas.Columns.Add("APELLIDOM_ACCIONISTA", "APELLIDO MATERNO")
        DGVAccionistas.Columns.Add("DIRECCION_ACCIONISTA", "DIRECCION")

        DGVAccionistas.Columns("ID_ACCIONISTA").DataPropertyName = "ID_ACCIONISTA"
        DGVAccionistas.Columns("ID_ACCIONISTA").ReadOnly = True
        DGVAccionistas.Columns("ID_ACCIONISTA").Visible = True
        DGVAccionistas.Columns("RUT_ACCIONISTA").DataPropertyName = "RUT_ACCIONISTA"
        DGVAccionistas.Columns("RUT_ACCIONISTA").ReadOnly = True
        DGVAccionistas.Columns("RUT_ACCIONISTA").Visible = True
        DGVAccionistas.Columns("NOMBRE_ACCIONISTA").DataPropertyName = "NOMBRE_ACCIONISTA"
        DGVAccionistas.Columns("NOMBRE_ACCIONISTA").ReadOnly = True
        DGVAccionistas.Columns("NOMBRE_ACCIONISTA").Visible = True
        DGVAccionistas.Columns("APELLIDOP_ACCIONISTA").DataPropertyName = "APELLIDOP_ACCIONISTA"
        DGVAccionistas.Columns("APELLIDOP_ACCIONISTA").ReadOnly = True
        DGVAccionistas.Columns("APELLIDOP_ACCIONISTA").Visible = True
        DGVAccionistas.Columns("APELLIDOM_ACCIONISTA").DataPropertyName = "APELLIDOM_ACCIONISTA"
        DGVAccionistas.Columns("APELLIDOM_ACCIONISTA").ReadOnly = True
        DGVAccionistas.Columns("APELLIDOM_ACCIONISTA").Visible = True
        DGVAccionistas.Columns("DIRECCION_ACCIONISTA").DataPropertyName = "DIRECCION_ACCIONISTA"
        DGVAccionistas.Columns("DIRECCION_ACCIONISTA").ReadOnly = True
        DGVAccionistas.Columns("DIRECCION_ACCIONISTA").Visible = True

        DataSetLlenado.Tables.Add("ACCIONISTAS")
        DataSetLlenado.Tables("ACCIONISTAS").Columns.Add("ID_ACCIONISTA")
        DataSetLlenado.Tables("ACCIONISTAS").Columns.Add("RUT_ACCIONISTA")
        DataSetLlenado.Tables("ACCIONISTAS").Columns.Add("NOMBRE_ACCIONISTA")
        DataSetLlenado.Tables("ACCIONISTAS").Columns.Add("APELLIDOP_ACCIONISTA")
        DataSetLlenado.Tables("ACCIONISTAS").Columns.Add("APELLIDOM_ACCIONISTA")
        DataSetLlenado.Tables("ACCIONISTAS").Columns.Add("DIRECCION_ACCIONISTA")

        BS_Accionistas.DataSource = DataSetLlenado.Tables("ACCIONISTAS")
        BS_Accionistas.Sort = "RUT_ACCIONISTA"

        DGVAccionistas.DataSource = BS_Accionistas
        LlenaData()
    End Sub

    Private Sub LlenaData()
        DataSetLlenado.Tables("ACCIONISTAS").Clear()
        Dim QryLlenaAccionistas As String

        QryLlenaAccionistas = "SELECT ID_ACCIONISTA, RUT_ACCIONISTA, NOMBRE_ACCIONISTA, APELLIDOP_ACCIONISTA, APELLIDOM_ACCIONISTA, DIRECCION_ACCIONISTA " & vbNewLine & _
        "FROM `WK_ACCIONISTAS`"

        Dim CmdSelectAccionistas As New MySqlCommand(QryLlenaAccionistas.ToUpper, Sqlcn1)

        Abre_conexion()
        DataAdLlenaAccionistas.SelectCommand = CmdSelectAccionistas

        DataAdLlenaAccionistas.Fill(DataSetLlenado, "ACCIONISTAS")
    End Sub

    Private Sub Btn_AddAccionista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AddAccionista.Click
        Dim Dlgr_AddAccionista As DialogResult
        DataSetLlenado.Tables("ACCIONISTAS").Rows.Add()
        BS_Accionistas.Position = BS_Accionistas.Find("RUT_ACCIONISTA", vbNull)

        Frm_AddModAccionista.BS_RAccionistas = BS_Accionistas

        Dlgr_AddAccionista = Frm_AddModAccionista.ShowDialog()

        If Dlgr_AddAccionista = Windows.Forms.DialogResult.OK Then

        Else
            DataSetLlenado.Tables("ACCIONISTAS").RejectChanges()
        End If

        Frm_AddModAccionista.Dispose()
    End Sub

    Private Sub DGVAccionistas_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVAccionistas.CellContentClick
        Dim Dlgr_AddAccionista As DialogResult

        Frm_AddModAccionista.BS_RAccionistas = BS_Accionistas

        Dlgr_AddAccionista = Frm_AddModAccionista.ShowDialog()

        If Dlgr_AddAccionista = Windows.Forms.DialogResult.OK Then

        Else

        End If

        Frm_AddModAccionista.Dispose()
    End Sub

    Private Sub Btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub
End Class