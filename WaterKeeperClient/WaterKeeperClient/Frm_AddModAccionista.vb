Public Class Frm_AddModAccionista
    Public DR_Accionista As DataRow
    'Public DT_Accionistas As DataTable
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
        Try
            If (FuncValida()) Then
                BS_RAccionistas.EndEdit()
                Me.Txt_RutAccionista.DataBindings.Clear()
                Me.Txt_NombreAccionista.DataBindings.Clear()
                Me.Txt_ApellidoPAccionista.DataBindings.Clear()
                Me.Txt_ApellidoMAccionista.DataBindings.Clear()
                Me.Txt_DireccionAccionista.DataBindings.Clear()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error de la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Me.DialogResult = Windows.Forms.DialogResult.Abort
            Me.Close()
        End Try

    End Sub
    Private Function FuncValida() As Boolean
        If RutDigito(CLng(Txt_RutAccionista.Text.Substring(0, Txt_RutAccionista.Text.Length - 2))) <> Txt_RutAccionista.Text.Substring(Txt_RutAccionista.Text.Length - 1, 1) Then
            MessageBox.Show("Rut Accionista no valido")
            Txt_RutAccionista.Focus()
            Return False
        End If

        If (BS_RAccionistas.Find("RUT_ACCIONISTA", Txt_RutAccionista.Text) > 0) Then
            MessageBox.Show("Rut Accionista ya existe")
            Txt_RutAccionista.Focus()
            Return False
        End If

        If (Txt_RutAccionista.Text.Count < 1) Then
            MessageBox.Show("Ingrese Rut Accionista")
            Txt_RutAccionista.Focus()
            Return False
        End If

        If (Txt_NombreAccionista.Text.Count < 1) Then
            MessageBox.Show("Ingrese Nombre Accionista")
            Txt_RutAccionista.Focus()
            Return False
        End If

        If (Txt_ApellidoPAccionista.Text.Count < 1) Then
            MessageBox.Show("Ingrese Apellido Paterno Accionista")
            Txt_RutAccionista.Focus()
            Return False
        End If

        If (Txt_ApellidoMAccionista.Text.Count < 1) Then
            MessageBox.Show("Ingrese Apellido Materno Accionista")
            Txt_RutAccionista.Focus()
            Return False
        End If


        Return True
    End Function
End Class