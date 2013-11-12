Imports MySql.Data.MySqlClient
Public Class Frm_CompuertasAccionista
    Public BS_RAccionistas As BindingSource
    Dim DataAdLlenaTelefonosAccionista As New MySqlDataAdapter
    Dim DataSetLlenado As New DataSet
    Dim str_IdAccionista As String
    Dim BS_CompuertasAccionista As New BindingSource
    Dim Str_FiltroTelefonosAccionista As String = ""


    Private Sub Frm_CompuertasAccionista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cmb_Compuerta.DropDownStyle = ComboBoxStyle.DropDownList

        Me.Cmb_Sector.DropDownStyle = ComboBoxStyle.DropDownList
        Me.Cmb_Sector.Items.Add("")
        Me.Cmb_Sector.Items.Add("Red Fija")
        Me.Cmb_Sector.Items.Add("Celular")


        Me.Lbl_NombreAccionista.DataBindings.Add("Text", BS_RAccionistas, "NOMBRE_ACCIONISTA")
        Me.Lbl_ApellidoPAccionista.DataBindings.Add("Text", BS_RAccionistas, "APELLIDOP_ACCIONISTA")
        Me.Lbl_ApellidoMAccionista.DataBindings.Add("Text", BS_RAccionistas, "APELLIDOM_ACCIONISTA")
        str_IdAccionista = BS_RAccionistas.Current.row.item(0)

        DGV_CompuertasAccionista.AllowUserToAddRows = False
        DGV_CompuertasAccionista.AllowUserToDeleteRows = False
        DGV_CompuertasAccionista.AllowUserToOrderColumns = False


        DGV_CompuertasAccionista.Columns.Add("Id_AccionistaCompuerta", "Id_AccionistaCompuerta")
        DGV_CompuertasAccionista.Columns.Add("Id_Accionista", "Id_Accionista")
        DGV_CompuertasAccionista.Columns.Add("FullNombre_Accionista", "FullNombre_Accionista")
        DGV_CompuertasAccionista.Columns.Add("Id_Compuerta", "Id_Compuerta")
        DGV_CompuertasAccionista.Columns.Add("Nombre_Compuerta", "Nombre_Compuerta")
        DGV_CompuertasAccionista.Columns.Add("Id_Sector", "Id_Sector")
        DGV_CompuertasAccionista.Columns.Add("Nombre_Sector", "Nombre_Sector")
        DGV_CompuertasAccionista.Columns.Add("CantAcciones_AccionistaCompuerta", "Cantidad Acciones")
        DGV_CompuertasAccionista.Columns.Add("FechaInicio_AccionistaCompuerta", "Cantidad Acciones")
        DGV_CompuertasAccionista.Columns.Add("FechaFin_AccionistaCompuerta", "Cantidad Acciones")
        DGV_CompuertasAccionista.Columns.Add("Estado_AccionistaCompuerta", "Estado_AccionistaCompuerta")

        DGV_CompuertasAccionista.Columns("Id_AccionistaCompuerta").DataPropertyName = "Id_AccionistaCompuerta"
        DGV_CompuertasAccionista.Columns("Id_AccionistaCompuerta").ReadOnly = True
        DGV_CompuertasAccionista.Columns("Id_AccionistaCompuerta").Visible = True
        DGV_CompuertasAccionista.Columns("Id_Accionista").DataPropertyName = "Id_Accionista"
        DGV_CompuertasAccionista.Columns("Id_Accionista").ReadOnly = True
        DGV_CompuertasAccionista.Columns("Id_Accionista").Visible = True
        DGV_CompuertasAccionista.Columns("FullNombre_Accionista").DataPropertyName = "FullNombre_Accionista"
        DGV_CompuertasAccionista.Columns("FullNombre_Accionista").ReadOnly = True
        DGV_CompuertasAccionista.Columns("FullNombre_Accionista").Visible = True
        DGV_CompuertasAccionista.Columns("Id_Compuerta").DataPropertyName = "Id_Compuerta"
        DGV_CompuertasAccionista.Columns("Id_Compuerta").ReadOnly = True
        DGV_CompuertasAccionista.Columns("Id_Compuerta").Visible = True
        DGV_CompuertasAccionista.Columns("Nombre_Compuerta").DataPropertyName = "Nombre_Compuerta"
        DGV_CompuertasAccionista.Columns("Nombre_Compuerta").ReadOnly = True
        DGV_CompuertasAccionista.Columns("Nombre_Compuerta").Visible = True
        DGV_CompuertasAccionista.Columns("Id_Sector").DataPropertyName = "Id_Sector"
        DGV_CompuertasAccionista.Columns("Id_Sector").ReadOnly = True
        DGV_CompuertasAccionista.Columns("Id_Sector").Visible = True
        DGV_CompuertasAccionista.Columns("Nombre_Sector").DataPropertyName = "Nombre_Sector"
        DGV_CompuertasAccionista.Columns("Nombre_Sector").ReadOnly = True
        DGV_CompuertasAccionista.Columns("Nombre_Sector").Visible = True
        DGV_CompuertasAccionista.Columns("CantAcciones_AccionistaCompuerta").DataPropertyName = "CantAcciones_AccionistaCompuerta"
        DGV_CompuertasAccionista.Columns("CantAcciones_AccionistaCompuerta").ReadOnly = True
        DGV_CompuertasAccionista.Columns("CantAcciones_AccionistaCompuerta").Visible = True
        DGV_CompuertasAccionista.Columns("FechaInicio_AccionistaCompuerta").DataPropertyName = "FechaInicio_AccionistaCompuerta"
        DGV_CompuertasAccionista.Columns("FechaInicio_AccionistaCompuerta").ReadOnly = True
        DGV_CompuertasAccionista.Columns("FechaInicio_AccionistaCompuerta").Visible = True
        DGV_CompuertasAccionista.Columns("FechaFin_AccionistaCompuerta").DataPropertyName = "FechaFin_AccionistaCompuerta"
        DGV_CompuertasAccionista.Columns("FechaFin_AccionistaCompuerta").ReadOnly = True
        DGV_CompuertasAccionista.Columns("FechaFin_AccionistaCompuerta").Visible = True
        DGV_CompuertasAccionista.Columns("Estado_AccionistaCompuerta").DataPropertyName = "Estado_AccionistaCompuerta"
        DGV_CompuertasAccionista.Columns("Estado_AccionistaCompuerta").ReadOnly = True
        DGV_CompuertasAccionista.Columns("Estado_AccionistaCompuerta").Visible = True


        DataSetLlenado.Tables.Add("COMPUERTAS_ACCIONISTA")
        DataSetLlenado.Tables("COMPUERTAS_ACCIONISTA").Columns.Add("Id_AccionistaCompuerta")
        DataSetLlenado.Tables("COMPUERTAS_ACCIONISTA").Columns.Add("Id_Accionista")
        DataSetLlenado.Tables("COMPUERTAS_ACCIONISTA").Columns.Add("FullNombre_Accionista")
        DataSetLlenado.Tables("COMPUERTAS_ACCIONISTA").Columns.Add("Id_Compuerta")
        DataSetLlenado.Tables("COMPUERTAS_ACCIONISTA").Columns.Add("Nombre_Compuerta")
        DataSetLlenado.Tables("COMPUERTAS_ACCIONISTA").Columns.Add("Id_Sector")
        DataSetLlenado.Tables("COMPUERTAS_ACCIONISTA").Columns.Add("Nombre_Sector")
        DataSetLlenado.Tables("COMPUERTAS_ACCIONISTA").Columns.Add("CantAcciones_AccionistaCompuerta")
        DataSetLlenado.Tables("COMPUERTAS_ACCIONISTA").Columns.Add("FechaInicio_AccionistaCompuerta")
        DataSetLlenado.Tables("COMPUERTAS_ACCIONISTA").Columns.Add("FechaFin_AccionistaCompuerta")
        DataSetLlenado.Tables("COMPUERTAS_ACCIONISTA").Columns.Add("Estado_AccionistaCompuerta")

        BS_CompuertasAccionista.DataSource = DataSetLlenado.Tables("COMPUERTAS_ACCIONISTA")
        BS_CompuertasAccionista.Sort = "Nombre_Compuerta"


        DGV_CompuertasAccionista.DataSource = BS_CompuertasAccionista
        LlenaData()

    End Sub
    Private Sub LlenaData()
        DataSetLlenado.Tables("COMPUERTAS_ACCIONISTA").Clear()
        Dim QryLlenaCompuertasAccionista As String

        QryLlenaCompuertasAccionista = "SELECT" & vbNewLine & _
        "`Id_AccionistaCompuerta`, " & vbNewLine & _
        "`Id_Accionista`, " & vbNewLine & _
        "'NOMBRE_ACCIONISTA' AS `Nombre_Accionista`, " & vbNewLine & _
        "`Id_Compuerta`, " & vbNewLine & _
        "'NOMBRE_COMPUERTA' AS `Nombre_Compuerta`, " & vbNewLine & _
        "`Id_Sector`, " & vbNewLine & _
        "'NOMBRE_SECTOR' AS `NOMBRE_SECTOR`, " & vbNewLine & _
        "`CantAcciones_AccionistaCompuerta`, " & vbNewLine & _
        "`FechaInicio_AccionistaCompuerta`, " & vbNewLine & _
        "`FechaFin_AccionistaCompuerta`, " & vbNewLine & _
        "`Estado_AccionistaCompuerta` " & vbNewLine & _
        "FROM `wk_accionistacompuerta` " & vbNewLine & _
        "WHERE `Estado_AccionistaCompuerta` ='V' "

        Dim CmdSelectCompuertasAccionista As New MySqlCommand(QryLlenaCompuertasAccionista.ToUpper, Sqlcn1)

        Abre_conexion()

        DataAdLlenaTelefonosAccionista.SelectCommand = CmdSelectCompuertasAccionista

        DataAdLlenaTelefonosAccionista.Fill(DataSetLlenado, "COMPUERTAS_ACCIONISTA")
    End Sub

    Private Sub FiltraTelefono()
        If Txt_CantAcciones.Text.Count >= 1 Then
            Str_FiltroTelefonosAccionista = "Numero_Telefono like '" & Txt_CantAcciones.Text & "%'"
        Else
            Str_FiltroTelefonosAccionista = ""
        End If

        BS_CompuertasAccionista.Filter = Str_FiltroTelefonosAccionista
    End Sub

    Private Sub Txt_Fono_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_CantAcciones.TextChanged
        FiltraTelefono()
    End Sub

    Private Sub Btn_Close_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_AddTelefono_Click(sender As System.Object, e As System.EventArgs) Handles Btn_AddTelefono.Click
        MsgBox(F_BuscaRepetido(Txt_CantAcciones.Text))
    End Sub

    Private Function F_BuscaRepetido(ByVal str_Valor As String) As Integer
        Return (BS_CompuertasAccionista.Find("Numero_Telefono", str_Valor))
    End Function
End Class