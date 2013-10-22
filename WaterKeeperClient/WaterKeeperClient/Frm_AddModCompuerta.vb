Public Class Frm_AddModCompuerta
    Public DR_Accionista As DataRow
    Public DT_Accionistas As DataTable
    Public BS_RCompuertas As BindingSource
    Private Sub Frm_AddModAccionista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Txt_NombreCompuerta.DataBindings.Add("Text", BS_RCompuertas, "NOMBRE_COMPUERTA")
        Me.Txt_AlturaCompuerta.DataBindings.Add("Text", BS_RCompuertas, "ALTURA_COMPUERTA")
        Me.Txt_AnchuraCompuerta.DataBindings.Add("Text", BS_RCompuertas, "ANCHO_COMPUERTA")
        Me.Txt_UbicacionCompuerta.DataBindings.Add("Text", BS_RCompuertas, "UBICACION_COMPUERTA")
        Me.Txt_AccionesMinutoCompuerta.DataBindings.Add("Text", BS_RCompuertas, "ACCIONESMINUTO_COMPUERTA")

    End Sub

    Private Sub Btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Close.Click
        Me.Txt_NombreCompuerta.DataBindings.Clear()
        Me.Txt_AlturaCompuerta.DataBindings.Clear()
        Me.Txt_AnchuraCompuerta.DataBindings.Clear()
        Me.Txt_UbicacionCompuerta.DataBindings.Clear()
        Me.Txt_AccionesMinutoCompuerta.DataBindings.Clear()
        Me.Close()
    End Sub

    Private Sub Btn_Aplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Aplicar.Click
        Me.Txt_NombreCompuerta.DataBindings.Clear()
        Me.Txt_AlturaCompuerta.DataBindings.Clear()
        Me.Txt_AnchuraCompuerta.DataBindings.Clear()
        Me.Txt_UbicacionCompuerta.DataBindings.Clear()
        Me.Txt_AccionesMinutoCompuerta.DataBindings.Clear()
        BS_RCompuertas.EndEdit()
        Me.Close()
    End Sub
End Class