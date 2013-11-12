Imports MySql.Data.MySqlClient
Public Class Frm_Accionistas
    Dim DataAdLlenaAccionistas As New MySqlDataAdapter
    Dim DataSetLlenado As New DataSet
    Dim BS_Accionistas As New BindingSource
    Dim Str_FiltroAccionistas As String = ""

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

        ' Add a button column.  
        Dim DGVBTC_Compuertas As New DataGridViewButtonColumn()
        DGVBTC_Compuertas.HeaderText = "Compuertas"
        DGVBTC_Compuertas.Name = "BCCompuertas"
        DGVBTC_Compuertas.Text = "Asignar"
        DGVBTC_Compuertas.Visible = True
        DGVBTC_Compuertas.UseColumnTextForButtonValue = True

        ' Add a button column.  
        Dim DGVBTC_Eliminar As New DataGridViewButtonColumn()
        DGVBTC_Eliminar.HeaderText = ""
        DGVBTC_Eliminar.Name = "BCEliminar"
        DGVBTC_Eliminar.Text = "Eliminar"
        DGVBTC_Eliminar.Visible = False
        DGVBTC_Eliminar.UseColumnTextForButtonValue = True

        ' Add a button column.  
        Dim DGVBTC_Telefonos As New DataGridViewButtonColumn()
        DGVBTC_Telefonos.HeaderText = "Telefonos"
        DGVBTC_Telefonos.Name = "BCTelefonos"
        DGVBTC_Telefonos.Text = "Ver"
        DGVBTC_Telefonos.UseColumnTextForButtonValue = True

        DGVAccionistas.Columns.Add(DGVBTC_Telefonos)
        DGVAccionistas.Columns.Add(DGVBTC_Compuertas)
        DGVAccionistas.Columns.Add(DGVBTC_Eliminar)

        DGVAccionistas.Columns("ID_ACCIONISTA").DataPropertyName = "ID_ACCIONISTA"
        DGVAccionistas.Columns("ID_ACCIONISTA").ReadOnly = True
        DGVAccionistas.Columns("ID_ACCIONISTA").Visible = False
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

        'Dim custUnique As UniqueConstraint = New UniqueConstraint(New DataColumn() {DataSetLlenado.Tables("ACCIONISTAS").Columns("RUT_ACCIONISTA")})
        'custUnique.ConstraintName = "testlol"
        'DataSetLlenado.Tables("ACCIONISTAS").Constraints.Add(custUnique)

        BS_Accionistas.DataSource = DataSetLlenado.Tables("ACCIONISTAS")
        BS_Accionistas.Sort = "RUT_ACCIONISTA"

        DGVAccionistas.DataSource = BS_Accionistas
        LlenaData()
    End Sub

    Private Sub LlenaData()
        DataSetLlenado.Tables("ACCIONISTAS").Clear()
        Dim QryLlenaAccionistas As String

        QryLlenaAccionistas = "SELECT ID_ACCIONISTA, RUT_ACCIONISTA, NOMBRE_ACCIONISTA, APELLIDOP_ACCIONISTA, APELLIDOM_ACCIONISTA, DIRECCION_ACCIONISTA " & vbNewLine & _
        "FROM `WK_ACCIONISTAS`" & vbNewLine & _
        "WHERE ESTADO_ACCIONISTA= 'V'"

        Dim CmdSelectAccionistas As New MySqlCommand(QryLlenaAccionistas.ToUpper, Sqlcn1)

        Abre_conexion()
        DataAdLlenaAccionistas.SelectCommand = CmdSelectAccionistas

        DataAdLlenaAccionistas.Fill(DataSetLlenado, "ACCIONISTAS")

        Sqlcn1.Close()
    End Sub

    Private Sub Btn_AddAccionista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AddAccionista.Click
        Dim Dlgr_AddAccionista As DialogResult

        DataSetLlenado.Tables("ACCIONISTAS").Rows.Add()
        BS_Accionistas.Position = BS_Accionistas.Find("RUT_ACCIONISTA", vbNull)

        Frm_AddModAccionista.BS_RAccionistas = BS_Accionistas

        'Frm_AddModAccionista.MdiParent = Frm_Main
        Dlgr_AddAccionista = Frm_AddModAccionista.ShowDialog()

        If Dlgr_AddAccionista = Windows.Forms.DialogResult.OK Then

        Else
            DataSetLlenado.Tables("ACCIONISTAS").RejectChanges()
        End If

        Frm_AddModAccionista.Dispose()
    End Sub

    Private Sub DGVAccionistas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVAccionistas.CellContentClick
        Dim Dlgr_AddAccionista As DialogResult
        If DGVAccionistas.Columns(e.ColumnIndex).Name = "BCEliminar" Then
            Dim Dlgr_DeleteAccionista As DialogResult
            Dlgr_DeleteAccionista = MessageBox.Show("¿Esta seguro que desea elimnar este registro?", "Eliminar", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2)
            If Dlgr_DeleteAccionista = Windows.Forms.DialogResult.Yes Then
                CType(DGVAccionistas.Rows(e.RowIndex).DataBoundItem.row, DataRow).Delete()
            End If

        ElseIf DGVAccionistas.Columns(e.ColumnIndex).Name = "BCTelefonos" Then
            Frm_TelefonosAccionista.BS_RAccionistas = BS_Accionistas
            Frm_TelefonosAccionista.ShowDialog()
            Frm_TelefonosAccionista.Dispose()

        ElseIf DGVAccionistas.Columns(e.ColumnIndex).Name = "BCCompuertas" Then
            Frm_CompuertasAccionista.BS_RAccionistas = BS_Accionistas
            Frm_CompuertasAccionista.ShowDialog()
            Frm_CompuertasAccionista.Dispose()
        Else
            Frm_AddModAccionista.BS_RAccionistas = BS_Accionistas
            Dlgr_AddAccionista = Frm_AddModAccionista.ShowDialog()
            If Dlgr_AddAccionista = Windows.Forms.DialogResult.OK Then

            Else

            End If
            Frm_AddModAccionista.Dispose()
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
        CmdInsert.CommandText = "water_keeper.WK_SP_INS_ACCIONISTA"

        CmdInsert.Parameters.Add(New MySqlParameter("P_RUT_ACCIONISTA", MySqlDbType.VarChar, 12, "RUT_ACCIONISTA"))
        CmdInsert.Parameters.Add(New MySqlParameter("P_NOMBRE_ACCIONISTA", MySqlDbType.VarChar, 45, "NOMBRE_ACCIONISTA"))
        CmdInsert.Parameters.Add(New MySqlParameter("P_APELLIDOP_ACCIONISTA", MySqlDbType.VarChar, 45, "APELLIDOP_ACCIONISTA"))
        CmdInsert.Parameters.Add(New MySqlParameter("P_APELLIDOM_ACCIONISTA", MySqlDbType.VarChar, 45, "APELLIDOM_ACCIONISTA"))
        CmdInsert.Parameters.Add(New MySqlParameter("P_DIRECCION_ACCIONISTA", MySqlDbType.VarChar, 45, "DIRECCION_ACCIONISTA"))

        DataAdSavedata.InsertCommand = CmdInsert

        CmdDelete.CommandType = CommandType.StoredProcedure
        CmdDelete.CommandText = "water_keeper.WK_SP_DEL_ACCIONISTA"

        CmdDelete.Parameters.Add(New MySqlParameter("P_ID_ACCIONISTA", MySqlDbType.Int32, 10, "ID_ACCIONISTA"))


        DataAdSavedata.DeleteCommand = CmdDelete

        CmdUpdate.CommandType = CommandType.StoredProcedure
        CmdUpdate.CommandText = "water_keeper.WK_SP_UPD_ACCIONISTA"

        CmdUpdate.Parameters.Add(New MySqlParameter("P_ID_ACCIONISTA", MySqlDbType.Int32, 10, "ID_ACCIONISTA"))
        CmdUpdate.Parameters.Add(New MySqlParameter("P_RUT_ACCIONISTA", MySqlDbType.VarChar, 12, "RUT_ACCIONISTA"))
        CmdUpdate.Parameters.Add(New MySqlParameter("P_NOMBRE_ACCIONISTA", MySqlDbType.VarChar, 45, "NOMBRE_ACCIONISTA"))
        CmdUpdate.Parameters.Add(New MySqlParameter("P_APELLIDOP_ACCIONISTA", MySqlDbType.VarChar, 45, "APELLIDOP_ACCIONISTA"))
        CmdUpdate.Parameters.Add(New MySqlParameter("P_APELLIDOM_ACCIONISTA", MySqlDbType.VarChar, 45, "APELLIDOM_ACCIONISTA"))
        CmdUpdate.Parameters.Add(New MySqlParameter("P_DIRECCION_ACCIONISTA", MySqlDbType.VarChar, 45, "DIRECCION_ACCIONISTA"))

        DataAdSavedata.UpdateCommand = CmdUpdate

        DataAdSavedata.Update(DataSetLlenado, "ACCIONISTAS")
        Sqlcn1.Close()

        MessageBox.Show("DATOS GUARDADOS")
    End Sub

    Private Sub Chk_Eliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Eliminar.CheckedChanged
        If Chk_Eliminar.Checked = True Then
            DGVAccionistas.Columns("BCEliminar").Visible = True
        Else
            DGVAccionistas.Columns("BCEliminar").Visible = False
        End If

    End Sub

    Private Sub txt_NombreAct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_RutAccionista.TextChanged
        FiltraAccionista()
    End Sub

    Private Sub txt_NombreAccionista_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NombreAccionista.TextChanged
        FiltraAccionista()
    End Sub

    Private Sub FiltraAccionista()
        If txt_RutAccionista.Text.Count >= 1 Then
            Str_FiltroAccionistas = "RUT_ACCIONISTA like '%" & txt_RutAccionista.Text & "'"
        Else
            Str_FiltroAccionistas = ""
        End If

        If txt_NombreAccionista.Text.Count >= 1 Then
            If Str_FiltroAccionistas.Count >= 1 Then
                Str_FiltroAccionistas = Str_FiltroAccionistas & " AND " & "NOMBRE_ACCIONISTA + APELLIDOP_ACCIONISTA + APELLIDOM_ACCIONISTA LIKE '%" & txt_NombreAccionista.Text & "%'"
            Else
                Str_FiltroAccionistas = "NOMBRE_ACCIONISTA + APELLIDOP_ACCIONISTA + APELLIDOM_ACCIONISTA LIKE '%" & txt_NombreAccionista.Text & "%'"
            End If
        End If
        BS_Accionistas.Filter = Str_FiltroAccionistas
    End Sub
End Class