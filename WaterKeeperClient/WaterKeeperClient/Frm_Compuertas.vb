Imports MySql.Data.MySqlClient
Public Class Frm_Compuertas
    Dim DataAdLlenaCompuertas As New MySqlDataAdapter
    Dim DataSetLlenado As New DataSet
    Dim BS_Compuertas As New BindingSource
    Dim Str_FiltroCompuertas As String = ""

    Private Sub Frm_Compuertas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGVCompuertas.AllowUserToAddRows = False
        DGVCompuertas.AllowUserToDeleteRows = False
        DGVCompuertas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        DGVCompuertas.Columns.Add("ID_COMPUERTA", "ID_COMPUERTA")
        DGVCompuertas.Columns.Add("NOMBRE_COMPUERTA", "NOMBRE COMPUERTA")
        DGVCompuertas.Columns.Add("ALTURA_COMPUERTA", "ALTURA")
        DGVCompuertas.Columns.Add("ANCHO_COMPUERTA", "ANCHURA")
        DGVCompuertas.Columns.Add("UBICACION_COMPUERTA", "UBICACION")
        DGVCompuertas.Columns.Add("ACCIONESMINUTO_COMPUERTA", "ACCIONES POR MINUTO")
        DGVCompuertas.Columns.Add("ESTADO_COMPUERTA", "ESTADO_COMPUERTA")

        ' Add a button column.  
        Dim DGVBTC_Eliminar As New DataGridViewButtonColumn()
        DGVBTC_Eliminar.HeaderText = ""
        DGVBTC_Eliminar.Name = "BCEliminar"
        DGVBTC_Eliminar.Text = "Eliminar"
        DGVBTC_Eliminar.Visible = False
        DGVBTC_Eliminar.UseColumnTextForButtonValue = True

        DGVCompuertas.Columns.Add(DGVBTC_Eliminar)

        DGVCompuertas.Columns("ID_COMPUERTA").DataPropertyName = "ID_COMPUERTA"
        DGVCompuertas.Columns("ID_COMPUERTA").ReadOnly = True
        DGVCompuertas.Columns("ID_COMPUERTA").Visible = False
        DGVCompuertas.Columns("NOMBRE_COMPUERTA").DataPropertyName = "NOMBRE_COMPUERTA"
        DGVCompuertas.Columns("NOMBRE_COMPUERTA").ReadOnly = True
        DGVCompuertas.Columns("NOMBRE_COMPUERTA").Visible = True
        DGVCompuertas.Columns("ALTURA_COMPUERTA").DataPropertyName = "ALTURA_COMPUERTA"
        DGVCompuertas.Columns("ALTURA_COMPUERTA").ReadOnly = True
        DGVCompuertas.Columns("ALTURA_COMPUERTA").Visible = True
        DGVCompuertas.Columns("ANCHO_COMPUERTA").DataPropertyName = "ANCHO_COMPUERTA"
        DGVCompuertas.Columns("ANCHO_COMPUERTA").ReadOnly = True
        DGVCompuertas.Columns("ANCHO_COMPUERTA").Visible = True
        DGVCompuertas.Columns("UBICACION_COMPUERTA").DataPropertyName = "UBICACION_COMPUERTA"
        DGVCompuertas.Columns("UBICACION_COMPUERTA").ReadOnly = True
        DGVCompuertas.Columns("UBICACION_COMPUERTA").Visible = True
        DGVCompuertas.Columns("ACCIONESMINUTO_COMPUERTA").DataPropertyName = "ACCIONESMINUTO_COMPUERTA"
        DGVCompuertas.Columns("ACCIONESMINUTO_COMPUERTA").ReadOnly = True
        DGVCompuertas.Columns("ACCIONESMINUTO_COMPUERTA").Visible = True
        DGVCompuertas.Columns("ESTADO_COMPUERTA").DataPropertyName = "ESTADO_COMPUERTA"
        DGVCompuertas.Columns("ESTADO_COMPUERTA").ReadOnly = True
        DGVCompuertas.Columns("ESTADO_COMPUERTA").Visible = True

        DataSetLlenado.Tables.Add("COMPUERTAS")
        DataSetLlenado.Tables("COMPUERTAS").Columns.Add("ID_COMPUERTA")
        DataSetLlenado.Tables("COMPUERTAS").Columns.Add("NOMBRE_COMPUERTA")
        DataSetLlenado.Tables("COMPUERTAS").Columns.Add("ALTURA_COMPUERTA")
        DataSetLlenado.Tables("COMPUERTAS").Columns.Add("ANCHO_COMPUERTA")
        DataSetLlenado.Tables("COMPUERTAS").Columns.Add("UBICACION_COMPUERTA")
        DataSetLlenado.Tables("COMPUERTAS").Columns.Add("ACCIONESMINUTO_COMPUERTA")
        DataSetLlenado.Tables("COMPUERTAS").Columns.Add("ESTADO_COMPUERTA")

        BS_Compuertas.DataSource = DataSetLlenado.Tables("COMPUERTAS")
        BS_Compuertas.Sort = "NOMBRE_COMPUERTA"

        DGVCompuertas.DataSource = BS_Compuertas
        LlenaData()
    End Sub

    Private Sub LlenaData()
        DataSetLlenado.Tables("COMPUERTAS").Clear()
        Dim QryLlenaCompuertas As String

        QryLlenaCompuertas = "SELECT `Id_Compuerta`, " & vbNewLine & _
        "'COMPUERTA01' AS `Nombre_Compuerta`," & vbNewLine & _
        "`Altura_Compuerta`," & vbNewLine & _
        "`Ancho_Compuerta`," & vbNewLine & _
        "`Ubicacion_Compuerta`," & vbNewLine & _
        "`AccionesMinuto_Compuerta`," & vbNewLine & _
        "`Estado_Compuerta`" & vbNewLine & _
        "FROM `water_keeper`.`wk_compuertas`" & vbNewLine & _
        "WHERE `Estado_Compuerta` = 'V'"

        Dim CmdSelectCompuertas As New MySqlCommand(QryLlenaCompuertas.ToUpper, Sqlcn1)

        Abre_conexion()
        DataAdLlenaCompuertas.SelectCommand = CmdSelectCompuertas

        DataAdLlenaCompuertas.Fill(DataSetLlenado, "COMPUERTAS")

        Sqlcn1.Close()
    End Sub

    Private Sub Btn_AddAccionista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AddAccionista.Click
        Dim Dlgr_AddCompuerta As DialogResult

        DataSetLlenado.Tables("COMPUERTAS").Rows.Add()
        BS_Compuertas.Position = BS_Compuertas.Find("NOMBRE_COMPUERTA", vbNull)

        Frm_AddModCompuerta.BS_RCompuertas = BS_Compuertas

        Dlgr_AddCompuerta = Frm_AddModCompuerta.ShowDialog()

        If Dlgr_AddCompuerta = Windows.Forms.DialogResult.OK Then

        Else
            DataSetLlenado.Tables("COMPUERTAS").RejectChanges()
        End If

        Frm_AddModCompuerta.Dispose()
    End Sub

    Private Sub DGVCompuertas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCompuertas.CellContentClick
        Dim Dlgr_AddCompuerta As DialogResult
        If DGVCompuertas.Columns(e.ColumnIndex).Name = "BCEliminar" Then
            Dim Dlgr_DeleteCompuerta As DialogResult
            Dlgr_DeleteCompuerta = MessageBox.Show("¿Esta seguro que desea elimnar este registro?", "Eliminar", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2)
            If Dlgr_DeleteCompuerta = Windows.Forms.DialogResult.Yes Then
                CType(DGVCompuertas.Rows(e.RowIndex).DataBoundItem.row, DataRow).Delete()
            End If
        Else
            Frm_AddModCompuerta.BS_RCompuertas = BS_Compuertas
            Dlgr_AddCompuerta = Frm_AddModCompuerta.ShowDialog()
            If Dlgr_AddCompuerta = Windows.Forms.DialogResult.OK Then

            Else

            End If
            Frm_AddModCompuerta.Dispose()
        End If

    End Sub

    Private Sub Btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Save.Click
        SaveChanges()
        LlenaData()
    End Sub
    Private Sub SaveChanges()
        Dim DataAdSavedata As New MySqlDataAdapter("", Sqlcn1)

        Dim CmdInsert As New MySqlCommand("", Sqlcn1)
        Dim CmdDelete As New MySqlCommand("", Sqlcn1)
        Dim CmdUpdate As New MySqlCommand("", Sqlcn1)

        CmdInsert.CommandType = CommandType.StoredProcedure
        CmdInsert.CommandText = "water_keeper.WK_SP_INS_COMPUERTA"

        CmdInsert.Parameters.Add(New MySqlParameter("P_NOMBRE_COMPUERTA", MySqlDbType.VarChar, 45, "NOMBRE_COMPUERTA"))
        CmdInsert.Parameters.Add(New MySqlParameter("P_ALTURA_COMPUERTA", MySqlDbType.Int32, 15, "ALTURA_COMPUERTA"))
        CmdInsert.Parameters.Add(New MySqlParameter("P_ANCHO_COMPUERTA", MySqlDbType.Int32, 15, "ANCHO_COMPUERTA"))
        CmdInsert.Parameters.Add(New MySqlParameter("P_UBICACION_COMPUERTA", MySqlDbType.VarChar, 45, "UBICACION_COMPUERTA"))
        CmdInsert.Parameters.Add(New MySqlParameter("P_ACCIONESMINUTO_COMPUERTA", MySqlDbType.Int32, 15, "ACCIONESMINUTO_COMPUERTA"))

        DataAdSavedata.InsertCommand = CmdInsert

        CmdDelete.CommandType = CommandType.StoredProcedure
        CmdDelete.CommandText = "water_keeper.WK_SP_DEL_COMPUERTA"

        CmdDelete.Parameters.Add(New MySqlParameter("P_ID_COMPUERTA", MySqlDbType.Int32, 10, "ID_COMPUERTA"))


        DataAdSavedata.DeleteCommand = CmdDelete

        CmdUpdate.CommandType = CommandType.StoredProcedure
        CmdUpdate.CommandText = "water_keeper.WK_SP_UPD_COMPUERTA"

        CmdUpdate.Parameters.Add(New MySqlParameter("P_ID_COMPUERTA", MySqlDbType.Int32, 10, "ID_COMPUERTA"))
        CmdUpdate.Parameters.Add(New MySqlParameter("P_NOMBRE_COMPUERTA", MySqlDbType.VarChar, 45, "NOMBRE_COMPUERTA"))
        CmdUpdate.Parameters.Add(New MySqlParameter("P_ALTURA_COMPUERTA", MySqlDbType.Int32, 15, "ALTURA_COMPUERTA"))
        CmdUpdate.Parameters.Add(New MySqlParameter("P_ANCHO_COMPUERTA", MySqlDbType.Int32, 15, "ANCHO_COMPUERTA"))
        CmdUpdate.Parameters.Add(New MySqlParameter("P_UBICACION_COMPUERTA", MySqlDbType.VarChar, 45, "UBICACION_COMPUERTA"))
        CmdUpdate.Parameters.Add(New MySqlParameter("P_ACCIONESMINUTO_COMPUERTA", MySqlDbType.Int32, 15, "ACCIONESMINUTO_COMPUERTA"))

        DataAdSavedata.UpdateCommand = CmdUpdate

        DataAdSavedata.Update(DataSetLlenado, "COMPUERTAS")
        Sqlcn1.Close()

        MessageBox.Show("DATOS GUARDADOS")
    End Sub

    Private Sub Chk_Eliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Eliminar.CheckedChanged
        If Chk_Eliminar.Checked = True Then
            DGVCompuertas.Columns("BCEliminar").Visible = True
        Else
            DGVCompuertas.Columns("BCEliminar").Visible = False
        End If

    End Sub

    Private Sub txt_NombreCompuertas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NombreCompuerta.TextChanged
        FiltraCompuerta()
    End Sub

    Private Sub FiltraCompuerta()
        If txt_NombreCompuerta.Text.Count >= 1 Then
            Str_FiltroCompuertas = "NOMBRE_COMPUERTA like '%" & txt_NombreCompuerta.Text & "%'"
        Else
            Str_FiltroCompuertas = ""
        End If

        BS_Compuertas.Filter = Str_FiltroCompuertas
    End Sub
End Class