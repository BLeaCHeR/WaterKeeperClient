<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AddModAccionista
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
        Me.Txt_DireccionAccionista = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_ApellidoMAccionista = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_ApellidoPAccionista = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_NombreAccionista = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_RutAccionista = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Btn_Aplicar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Txt_DireccionAccionista)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_ApellidoMAccionista)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_ApellidoPAccionista)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_NombreAccionista)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_RutAccionista)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 304)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Txt_DireccionAccionista
        '
        Me.Txt_DireccionAccionista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_DireccionAccionista.Location = New System.Drawing.Point(9, 154)
        Me.Txt_DireccionAccionista.Multiline = True
        Me.Txt_DireccionAccionista.Name = "Txt_DireccionAccionista"
        Me.Txt_DireccionAccionista.Size = New System.Drawing.Size(340, 138)
        Me.Txt_DireccionAccionista.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dirección"
        '
        'Txt_ApellidoMAccionista
        '
        Me.Txt_ApellidoMAccionista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_ApellidoMAccionista.Location = New System.Drawing.Point(98, 105)
        Me.Txt_ApellidoMAccionista.Name = "Txt_ApellidoMAccionista"
        Me.Txt_ApellidoMAccionista.Size = New System.Drawing.Size(251, 20)
        Me.Txt_ApellidoMAccionista.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Apellido Materno"
        '
        'Txt_ApellidoPAccionista
        '
        Me.Txt_ApellidoPAccionista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_ApellidoPAccionista.Location = New System.Drawing.Point(98, 79)
        Me.Txt_ApellidoPAccionista.Name = "Txt_ApellidoPAccionista"
        Me.Txt_ApellidoPAccionista.Size = New System.Drawing.Size(251, 20)
        Me.Txt_ApellidoPAccionista.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellido Paterno"
        '
        'Txt_NombreAccionista
        '
        Me.Txt_NombreAccionista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_NombreAccionista.Location = New System.Drawing.Point(98, 53)
        Me.Txt_NombreAccionista.Name = "Txt_NombreAccionista"
        Me.Txt_NombreAccionista.Size = New System.Drawing.Size(251, 20)
        Me.Txt_NombreAccionista.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'Txt_RutAccionista
        '
        Me.Txt_RutAccionista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_RutAccionista.Location = New System.Drawing.Point(98, 27)
        Me.Txt_RutAccionista.MaxLength = 10
        Me.Txt_RutAccionista.Name = "Txt_RutAccionista"
        Me.Txt_RutAccionista.Size = New System.Drawing.Size(251, 20)
        Me.Txt_RutAccionista.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rut:"
        '
        'Btn_Close
        '
        Me.Btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Close.Location = New System.Drawing.Point(298, 324)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Close.TabIndex = 1
        Me.Btn_Close.Text = "Cerrar"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Btn_Aplicar
        '
        Me.Btn_Aplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Aplicar.Location = New System.Drawing.Point(217, 324)
        Me.Btn_Aplicar.Name = "Btn_Aplicar"
        Me.Btn_Aplicar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Aplicar.TabIndex = 2
        Me.Btn_Aplicar.Text = "Guardar"
        Me.Btn_Aplicar.UseVisualStyleBackColor = True
        '
        'Frm_AddModAccionista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 361)
        Me.Controls.Add(Me.Btn_Aplicar)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(295, 360)
        Me.Name = "Frm_AddModAccionista"
        Me.Text = "Frm_AddModAccionista"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Close As System.Windows.Forms.Button
    Friend WithEvents Btn_Aplicar As System.Windows.Forms.Button
    Friend WithEvents Txt_DireccionAccionista As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_ApellidoMAccionista As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_ApellidoPAccionista As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_NombreAccionista As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_RutAccionista As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
