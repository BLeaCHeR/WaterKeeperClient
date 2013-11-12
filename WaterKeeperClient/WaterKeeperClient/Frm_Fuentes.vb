Imports MySql.Data.MySqlClient
Public Class Frm_Fuentes
    Dim DataAdLlenaFuentes As New MySqlDataAdapter
    Dim DataSetLlenado As New DataSet
    Dim BS_Fuentes As New BindingSource
    Dim Str_FiltroFuentes As String = ""

    Private Sub Frm_Fuentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        DGVFuentes.AllowUserToAddRows = False
        DGVFuentes.AllowUserToDeleteRows = False
        DGVFuentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        DGVFuentes.Columns.Add("ID_FUENTE", "ID_FUENTE")
        DGVFuentes.Columns.Add("NOMBRE_FUENTE", "NOMBRE FUENTE")
        DGVFuentes.Columns.Add("ESTADO_FUENTE", "ESTADO_FUENTE")

        ' Add a button column.  
        Dim DGVBTC_Eliminar As New DataGridViewButtonColumn()
        DGVBTC_Eliminar.HeaderText = ""
        DGVBTC_Eliminar.Name = "BCEliminar"
        DGVBTC_Eliminar.Text = "Eliminar"
        DGVBTC_Eliminar.Visible = False
        DGVBTC_Eliminar.UseColumnTextForButtonValue = True

        DGVFuentes.Columns.Add(DGVBTC_Eliminar)

        DGVFuentes.Columns("ID_FUENTE").DataPropertyName = "ID_FUENTE"
        DGVFuentes.Columns("ID_FUENTE").ReadOnly = True
        DGVFuentes.Columns("ID_FUENTE").Visible = False
        DGVFuentes.Columns("NOMBRE_FUENTE").DataPropertyName = "NOMBRE_FUENTE"
        DGVFuentes.Columns("NOMBRE_FUENTE").ReadOnly = True
        DGVFuentes.Columns("NOMBRE_FUENTE").Visible = True
        DGVFuentes.Columns("ESTADO_FUENTE").DataPropertyName = "ESTADO_FUENTE"
        DGVFuentes.Columns("ESTADO_FUENTE").ReadOnly = True
        DGVFuentes.Columns("ESTADO_FUENTE").Visible = False

        DataSetLlenado.Tables.Add("FUENTES")
        DataSetLlenado.Tables("FUENTES").Columns.Add("ID_FUENTE")
        DataSetLlenado.Tables("FUENTES").Columns.Add("NOMBRE_FUENTE")
        DataSetLlenado.Tables("FUENTES").Columns.Add("ESTADO_FUENTE")

        BS_Fuentes.DataSource = DataSetLlenado.Tables("FUENTES")
        BS_Fuentes.Sort = "NOMBRE_FUENTE"

        DGVFuentes.DataSource = BS_Fuentes
        LlenaData()
    End Sub

    Private Sub LlenaData()
        DataSetLlenado.Tables("FUENTES").Clear()
        Dim QryLlenaFuentes As String

        QryLlenaFuentes = "SELECT `Id_fuente`, " & vbNewLine & _
        "`Nombre_Fuente`," & vbNewLine & _
        "`Estado_Fuente`" & vbNewLine & _
        "FROM `water_keeper`.`wk_fuentes`" & vbNewLine & _
        "WHERE `Estado_Fuente` = 'V'"

        Dim CmdSelectFuentes As New MySqlCommand(QryLlenaFuentes.ToUpper, Sqlcn1)

        Abre_conexion()
        DataAdLlenaFuentes.SelectCommand = CmdSelectFuentes

        DataAdLlenaFuentes.Fill(DataSetLlenado, "FUENTES")

        Sqlcn1.Close()
    End Sub

    Private Sub Btn_AddFuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AddFuente.Click

        If BS_Fuentes.Find("NOMBRE_FUENTE", txt_NombreFuente.Text) <= 0 Then
            DataSetLlenado.Tables("FUENTES").Rows.Add()
            BS_Fuentes.Position = BS_Fuentes.Find("NOMBRE_FUENTE", vbNull)
            CType(BS_Fuentes.Current, DataRowView).Row.Item("NOMBRE_FUENTE") = txt_NombreFuente.Text
            CType(BS_Fuentes.Current, DataRowView).Row.Item("ESTADO_FUENTE") = "V"
            BS_Fuentes.EndEdit()
            txt_NombreFuente.Clear()
        Else
            MessageBox.Show("NOMBRE FUENTE YA EXISTE")
            BS_Fuentes.CancelEdit()
        End If

        Frm_AddModCompuerta.Dispose()
    End Sub

    Private Sub DGVFuentes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVFuentes.CellContentClick
        If DGVFuentes.Columns(e.ColumnIndex).Name = "BCEliminar" Then
            Dim Dlgr_DeleteCompuerta As DialogResult
            Dlgr_DeleteCompuerta = MessageBox.Show("¿Esta seguro que desea elimnar este registro?", "Eliminar", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2)
            If Dlgr_DeleteCompuerta = Windows.Forms.DialogResult.Yes Then
                CType(DGVFuentes.Rows(e.RowIndex).DataBoundItem.row, DataRow).Delete()
            End If
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
        CmdInsert.CommandText = "water_keeper.WK_SP_INS_FUENTE"

        CmdInsert.Parameters.Add(New MySqlParameter("P_NOMBRE_FUENTE", MySqlDbType.VarChar, 45, "NOMBRE_FUENTE"))

        DataAdSavedata.InsertCommand = CmdInsert

        CmdDelete.CommandType = CommandType.StoredProcedure
        CmdDelete.CommandText = "water_keeper.WK_SP_DEL_FUENTE"

        CmdDelete.Parameters.Add(New MySqlParameter("P_ID_FUENTE", MySqlDbType.Int32, 10, "ID_FUENTE"))


        DataAdSavedata.DeleteCommand = CmdDelete

        CmdUpdate.CommandType = CommandType.StoredProcedure
        CmdUpdate.CommandText = "water_keeper.WK_SP_UPD_FUENTE"

        CmdUpdate.Parameters.Add(New MySqlParameter("P_ID_FUENTE", MySqlDbType.Int32, 10, "ID_FUENTE"))
        CmdUpdate.Parameters.Add(New MySqlParameter("P_NOMBRE_FUENTE", MySqlDbType.VarChar, 45, "NOMBRE_FUENTE"))

        DataAdSavedata.UpdateCommand = CmdUpdate

        DataAdSavedata.Update(DataSetLlenado, "FUENTES")
        Sqlcn1.Close()

        MessageBox.Show("DATOS GUARDADOS")
    End Sub

    Private Sub Chk_Eliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Eliminar.CheckedChanged
        If Chk_Eliminar.Checked = True Then
            DGVFuentes.Columns("BCEliminar").Visible = True
        Else
            DGVFuentes.Columns("BCEliminar").Visible = False
        End If

    End Sub

    Private Sub txt_NombreFuentes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NombreFuente.TextChanged
        'FiltraCompuerta()
    End Sub

    Private Sub FiltraCompuerta()
        If txt_NombreFuente.Text.Count >= 1 Then
            Str_FiltroFuentes = "NOMBRE_FUENTE like '%" & txt_NombreFuente.Text & "%'"
        Else
            Str_FiltroFuentes = ""
        End If

        BS_Fuentes.Filter = Str_FiltroFuentes
    End Sub
End Class