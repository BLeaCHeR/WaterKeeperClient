<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TelefonosAccionista
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV_TelefonosAccionista = New System.Windows.Forms.DataGridView()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Lbl_NombreAccionista = New System.Windows.Forms.Label()
        Me.Lbl_ApellidoPAccionista = New System.Windows.Forms.Label()
        Me.Lbl_ApellidoMAccionista = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Fono = New System.Windows.Forms.TextBox()
        Me.Cmb_Tipo = New System.Windows.Forms.ComboBox()
        Me.Btn_AddTelefono = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_TelefonosAccionista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGV_TelefonosAccionista)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Telefonos"
        '
        'DGV_TelefonosAccionista
        '
        Me.DGV_TelefonosAccionista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_TelefonosAccionista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_TelefonosAccionista.Location = New System.Drawing.Point(6, 19)
        Me.DGV_TelefonosAccionista.Name = "DGV_TelefonosAccionista"
        Me.DGV_TelefonosAccionista.Size = New System.Drawing.Size(532, 223)
        Me.DGV_TelefonosAccionista.TabIndex = 0
        '
        'Btn_Close
        '
        Me.Btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Close.Location = New System.Drawing.Point(481, 352)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Close.TabIndex = 1
        Me.Btn_Close.Text = "Cerrar"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Txt_Fono)
        Me.GroupBox2.Controls.Add(Me.Cmb_Tipo)
        Me.GroupBox2.Controls.Add(Me.Btn_AddTelefono)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 80)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_NombreAccionista)
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_ApellidoPAccionista)
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_ApellidoMAccionista)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 11)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(533, 17)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'Lbl_NombreAccionista
        '
        Me.Lbl_NombreAccionista.AutoSize = True
        Me.Lbl_NombreAccionista.Location = New System.Drawing.Point(3, 0)
        Me.Lbl_NombreAccionista.Name = "Lbl_NombreAccionista"
        Me.Lbl_NombreAccionista.Size = New System.Drawing.Size(113, 13)
        Me.Lbl_NombreAccionista.TabIndex = 9
        Me.Lbl_NombreAccionista.Text = "Lbl_NombreAccionista"
        '
        'Lbl_ApellidoPAccionista
        '
        Me.Lbl_ApellidoPAccionista.AutoSize = True
        Me.Lbl_ApellidoPAccionista.Location = New System.Drawing.Point(122, 0)
        Me.Lbl_ApellidoPAccionista.Name = "Lbl_ApellidoPAccionista"
        Me.Lbl_ApellidoPAccionista.Size = New System.Drawing.Size(120, 13)
        Me.Lbl_ApellidoPAccionista.TabIndex = 11
        Me.Lbl_ApellidoPAccionista.Text = "Lbl_ApellidoPAccionista"
        '
        'Lbl_ApellidoMAccionista
        '
        Me.Lbl_ApellidoMAccionista.AutoSize = True
        Me.Lbl_ApellidoMAccionista.Location = New System.Drawing.Point(248, 0)
        Me.Lbl_ApellidoMAccionista.Name = "Lbl_ApellidoMAccionista"
        Me.Lbl_ApellidoMAccionista.Size = New System.Drawing.Size(122, 13)
        Me.Lbl_ApellidoMAccionista.TabIndex = 12
        Me.Lbl_ApellidoMAccionista.Text = "Lbl_ApellidoMAccionista"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fono"
        '
        'Txt_Fono
        '
        Me.Txt_Fono.Location = New System.Drawing.Point(9, 47)
        Me.Txt_Fono.Name = "Txt_Fono"
        Me.Txt_Fono.Size = New System.Drawing.Size(119, 20)
        Me.Txt_Fono.TabIndex = 5
        '
        'Cmb_Tipo
        '
        Me.Cmb_Tipo.FormattingEnabled = True
        Me.Cmb_Tipo.Location = New System.Drawing.Point(134, 47)
        Me.Cmb_Tipo.Name = "Cmb_Tipo"
        Me.Cmb_Tipo.Size = New System.Drawing.Size(91, 21)
        Me.Cmb_Tipo.TabIndex = 4
        '
        'Btn_AddTelefono
        '
        Me.Btn_AddTelefono.Location = New System.Drawing.Point(231, 47)
        Me.Btn_AddTelefono.Name = "Btn_AddTelefono"
        Me.Btn_AddTelefono.Size = New System.Drawing.Size(34, 23)
        Me.Btn_AddTelefono.TabIndex = 3
        Me.Btn_AddTelefono.Text = "+"
        Me.Btn_AddTelefono.UseVisualStyleBackColor = True
        '
        'Frm_TelefonosAccionista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 383)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_TelefonosAccionista"
        Me.Text = "Frm_TelefonosCliente"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV_TelefonosAccionista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Close As System.Windows.Forms.Button
    Friend WithEvents DGV_TelefonosAccionista As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_AddTelefono As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Fono As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_NombreAccionista As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Lbl_ApellidoPAccionista As System.Windows.Forms.Label
    Friend WithEvents Lbl_ApellidoMAccionista As System.Windows.Forms.Label
End Class
