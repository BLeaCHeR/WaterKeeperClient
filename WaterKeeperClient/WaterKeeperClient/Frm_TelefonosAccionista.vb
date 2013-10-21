Imports MySql.Data.MySqlClient
Public Class Frm_TelefonosAccionista
    Public BS_RAccionistas As BindingSource
    Dim DataAdLlenaTelefonosAccionista As New MySqlDataAdapter
    Dim DataSetLlenado As New DataSet
    Dim str_IdAccionista As String
    Dim BS_TelefonosAccionista As New BindingSource
    Dim Str_FiltroTelefonosAccionista As String = ""


    Private Sub Frm_TelefonosAccionista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Cmb_Tipo.DropDownStyle = ComboBoxStyle.DropDownList
        Me.Cmb_Tipo.Items.Add("")
        Me.Cmb_Tipo.Items.Add("Red Fija")
        Me.Cmb_Tipo.Items.Add("Celular")


        Me.Lbl_NombreAccionista.DataBindings.Add("Text", BS_RAccionistas, "NOMBRE_ACCIONISTA")
        Me.Lbl_ApellidoPAccionista.DataBindings.Add("Text", BS_RAccionistas, "APELLIDOP_ACCIONISTA")
        Me.Lbl_ApellidoMAccionista.DataBindings.Add("Text", BS_RAccionistas, "APELLIDOM_ACCIONISTA")
        str_IdAccionista = BS_RAccionistas.Current.row.item(0)

        DGV_TelefonosAccionista.AllowUserToAddRows = False
        DGV_TelefonosAccionista.AllowUserToDeleteRows = False
        DGV_TelefonosAccionista.AllowUserToOrderColumns = False


        DGV_TelefonosAccionista.Columns.Add("Id_Telefono", "Id_Telefono")
        DGV_TelefonosAccionista.Columns.Add("Id_Accionista", "Id_Accionista")
        DGV_TelefonosAccionista.Columns.Add("Numero_Telefono", "Número")
        DGV_TelefonosAccionista.Columns.Add("Tipo_Telefono", "Tipo")
        DGV_TelefonosAccionista.Columns.Add("Estado_Telefono", "Estado_Telefono")

        DGV_TelefonosAccionista.Columns("Id_Telefono").DataPropertyName = "Id_Telefono"
        DGV_TelefonosAccionista.Columns("Id_Telefono").ReadOnly = True
        DGV_TelefonosAccionista.Columns("Id_Telefono").Visible = True
        DGV_TelefonosAccionista.Columns("Id_Accionista").DataPropertyName = "Id_Accionista"
        DGV_TelefonosAccionista.Columns("Id_Accionista").ReadOnly = True
        DGV_TelefonosAccionista.Columns("Id_Accionista").Visible = True
        DGV_TelefonosAccionista.Columns("Numero_Telefono").DataPropertyName = "Numero_Telefono"
        DGV_TelefonosAccionista.Columns("Numero_Telefono").ReadOnly = True
        DGV_TelefonosAccionista.Columns("Numero_Telefono").Visible = True
        DGV_TelefonosAccionista.Columns("Tipo_Telefono").DataPropertyName = "Tipo_Telefono"
        DGV_TelefonosAccionista.Columns("Tipo_Telefono").ReadOnly = True
        DGV_TelefonosAccionista.Columns("Tipo_Telefono").Visible = True
        DGV_TelefonosAccionista.Columns("Estado_Telefono").DataPropertyName = "Estado_Telefono"
        DGV_TelefonosAccionista.Columns("Estado_Telefono").ReadOnly = True
        DGV_TelefonosAccionista.Columns("Estado_Telefono").Visible = True


        DataSetLlenado.Tables.Add("TELEFONOS_ACCIONISTA")
        DataSetLlenado.Tables("TELEFONOS_ACCIONISTA").Columns.Add("Id_Telefono")
        DataSetLlenado.Tables("TELEFONOS_ACCIONISTA").Columns.Add("Id_Accionista")
        DataSetLlenado.Tables("TELEFONOS_ACCIONISTA").Columns.Add("Numero_Telefono")
        DataSetLlenado.Tables("TELEFONOS_ACCIONISTA").Columns.Add("Tipo_Telefono")
        DataSetLlenado.Tables("TELEFONOS_ACCIONISTA").Columns.Add("Estado_Telefono")

        BS_TelefonosAccionista.DataSource = DataSetLlenado.Tables("TELEFONOS_ACCIONISTA")
        BS_TelefonosAccionista.Sort = "Numero_Telefono"


        DGV_TelefonosAccionista.DataSource = BS_TelefonosAccionista
        LlenaData()

    End Sub
    Private Sub LlenaData()
        DataSetLlenado.Tables("TELEFONOS_ACCIONISTA").Clear()
        Dim QryLlenaTelefonosAccionista As String

        QryLlenaTelefonosAccionista = "SELECT Id_Telefono, Id_Accionista, Numero_Telefono, Tipo_Telefono, Estado_Telefono " & vbNewLine & _
        "FROM `WK_TELEFONOS`" & vbNewLine & _
        "WHERE ID_ACCIONISTA= '" & str_IdAccionista & "' AND Estado_Telefono= 'V'"

        Dim CmdSelectTelefonosAccionista As New MySqlCommand(QryLlenaTelefonosAccionista.ToUpper, Sqlcn1)

        Abre_conexion()

        DataAdLlenaTelefonosAccionista.SelectCommand = CmdSelectTelefonosAccionista

        DataAdLlenaTelefonosAccionista.Fill(DataSetLlenado, "TELEFONOS_ACCIONISTA")
    End Sub

    Private Sub FiltraTelefono()
        If Txt_Fono.Text.Count >= 1 Then
            Str_FiltroTelefonosAccionista = "Numero_Telefono like '" & Txt_Fono.Text & "%'"
        Else
            Str_FiltroTelefonosAccionista = ""
        End If

        BS_TelefonosAccionista.Filter = Str_FiltroTelefonosAccionista
    End Sub

    Private Sub Txt_Fono_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_Fono.TextChanged
        FiltraTelefono()
    End Sub

    Private Sub Btn_Close_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_AddTelefono_Click(sender As System.Object, e As System.EventArgs) Handles Btn_AddTelefono.Click
        MsgBox(F_BuscaRepetido(Txt_Fono.Text))
    End Sub

    Private Function F_BuscaRepetido(ByVal str_Valor As String) As Integer
        Return (BS_TelefonosAccionista.Find("Numero_Telefono", str_Valor))
    End Function
End Class