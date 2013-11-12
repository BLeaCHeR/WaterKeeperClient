Public Class Frm_Main

    Private Sub Frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub

    Private Sub AccionistasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccionistasToolStripMenuItem.Click
        Frm_Accionistas.MdiParent = Me
        Frm_Accionistas.Show()
    End Sub

    Private Sub CompuertasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CompuertasToolStripMenuItem.Click
        Frm_Compuertas.MdiParent = Me
        Frm_Compuertas.Show()
    End Sub

    Private Sub FuentesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FuentesToolStripMenuItem.Click
        Frm_Fuentes.MdiParent = Me
        Frm_Fuentes.Show()
    End Sub
End Class