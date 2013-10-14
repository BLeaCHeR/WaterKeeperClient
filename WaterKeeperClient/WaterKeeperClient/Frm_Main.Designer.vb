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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeléfonosClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompuertasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompuertasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 438)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(853, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.CompuertasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(853, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.TeléfonosClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.ClientesToolStripMenuItem.Text = "Accionistas"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem1.Text = "Accionista"
        '
        'TeléfonosClientesToolStripMenuItem
        '
        Me.TeléfonosClientesToolStripMenuItem.Name = "TeléfonosClientesToolStripMenuItem"
        Me.TeléfonosClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TeléfonosClientesToolStripMenuItem.Text = "Telefonos"
        '
        'CompuertasToolStripMenuItem
        '
        Me.CompuertasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SectoresToolStripMenuItem, Me.CompuertasToolStripMenuItem1})
        Me.CompuertasToolStripMenuItem.Name = "CompuertasToolStripMenuItem"
        Me.CompuertasToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.CompuertasToolStripMenuItem.Text = "Compuertas"
        '
        'SectoresToolStripMenuItem
        '
        Me.SectoresToolStripMenuItem.Name = "SectoresToolStripMenuItem"
        Me.SectoresToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SectoresToolStripMenuItem.Text = "Sectores"
        '
        'CompuertasToolStripMenuItem1
        '
        Me.CompuertasToolStripMenuItem1.Name = "CompuertasToolStripMenuItem1"
        Me.CompuertasToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.CompuertasToolStripMenuItem1.Text = "Compuertas"
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 460)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Main"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeléfonosClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompuertasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SectoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompuertasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
