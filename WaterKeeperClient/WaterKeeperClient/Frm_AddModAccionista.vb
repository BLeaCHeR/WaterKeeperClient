Public Class Frm_AddModAccionista
    Public DR_Accionista As DataRow
    Public DT_Accionistas As DataTable
    Public BS_RAccionistas As BindingSource
    Private Sub Frm_AddModAccionista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Txt_RutAccionista.DataBindings.Add("Text", BS_RAccionistas, "RUT_ACCIONISTA")
        Me.Txt_NombreAccionista.DataBindings.Add("Text", BS_RAccionistas, "NOMBRE_ACCIONISTA")
        Me.Txt_ApellidoPAccionista.DataBindings.Add("Text", BS_RAccionistas, "APELLIDOP_ACCIONISTA")
        Me.Txt_ApellidoMAccionista.DataBindings.Add("Text", BS_RAccionistas, "APELLIDOM_ACCIONISTA")
        Me.Txt_DireccionAccionista.DataBindings.Add("Text", BS_RAccionistas, "DIRECCION_ACCIONISTA")

    End Sub

    Private Sub Btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Close.Click
        Me.Txt_RutAccionista.DataBindings.Clear()
        Me.Txt_NombreAccionista.DataBindings.Clear()
        Me.Txt_ApellidoPAccionista.DataBindings.Clear()
        Me.Txt_ApellidoMAccionista.DataBindings.Clear()
        Me.Txt_DireccionAccionista.DataBindings.Clear()
        Me.Close()
    End Sub

    Private Sub Btn_Aplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Aplicar.Click
        Me.Txt_RutAccionista.DataBindings.Clear()
        Me.Txt_NombreAccionista.DataBindings.Clear()
        Me.Txt_ApellidoPAccionista.DataBindings.Clear()
        Me.Txt_ApellidoMAccionista.DataBindings.Clear()
        Me.Txt_DireccionAccionista.DataBindings.Clear()
        BS_RAccionistas.EndEdit()
        Me.Close()
    End Sub
End Class