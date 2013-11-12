<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccionistasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompuertasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatricesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenedoresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(101, 261)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenedoresToolStripMenuItem
        '
        Me.MantenedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccionistasToolStripMenuItem, Me.CompuertasToolStripMenuItem, Me.FuentesToolStripMenuItem, Me.MatricesToolStripMenuItem})
        Me.MantenedoresToolStripMenuItem.Name = "MantenedoresToolStripMenuItem"
        Me.MantenedoresToolStripMenuItem.Size = New System.Drawing.Size(88, 19)
        Me.MantenedoresToolStripMenuItem.Text = "Mantenedores"
        '
        'AccionistasToolStripMenuItem
        '
        Me.AccionistasToolStripMenuItem.Name = "AccionistasToolStripMenuItem"
        Me.AccionistasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AccionistasToolStripMenuItem.Text = "Accionistas"
        '
        'CompuertasToolStripMenuItem
        '
        Me.CompuertasToolStripMenuItem.Name = "CompuertasToolStripMenuItem"
        Me.CompuertasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CompuertasToolStripMenuItem.Text = "Compuertas"
        '
        'FuentesToolStripMenuItem
        '
        Me.FuentesToolStripMenuItem.Name = "FuentesToolStripMenuItem"
        Me.FuentesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FuentesToolStripMenuItem.Text = "Fuentes"
        '
        'MatricesToolStripMenuItem
        '
        Me.MatricesToolStripMenuItem.Name = "MatricesToolStripMenuItem"
        Me.MatricesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MatricesToolStripMenuItem.Text = "Matrices"
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Main"
        Me.Text = "Frm_Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MantenedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccionistasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompuertasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatricesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
