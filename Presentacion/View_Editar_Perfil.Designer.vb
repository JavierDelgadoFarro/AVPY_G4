<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Editar_Perfil
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
        Me.Panel_Perfil = New System.Windows.Forms.Panel()
        Me.Btn_Editar_Perfil = New System.Windows.Forms.Button()
        Me.Panel_Editar_Perfil = New System.Windows.Forms.Panel()
        Me.lbl_contraseña = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Vigente_pass = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Perfil.SuspendLayout()
        Me.Panel_Editar_Perfil.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Perfil
        '
        Me.Panel_Perfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel_Perfil.Controls.Add(Me.Btn_Editar_Perfil)
        Me.Panel_Perfil.Controls.Add(Me.Panel_Editar_Perfil)
        Me.Panel_Perfil.Controls.Add(Me.lbl_apellido)
        Me.Panel_Perfil.Controls.Add(Me.lbl_nombre)
        Me.Panel_Perfil.Controls.Add(Me.Label5)
        Me.Panel_Perfil.Controls.Add(Me.Label4)
        Me.Panel_Perfil.Controls.Add(Me.lbl_usuario)
        Me.Panel_Perfil.Controls.Add(Me.Label2)
        Me.Panel_Perfil.Controls.Add(Me.Label1)
        Me.Panel_Perfil.Controls.Add(Me.PictureBox1)
        Me.Panel_Perfil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Perfil.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Perfil.Name = "Panel_Perfil"
        Me.Panel_Perfil.Size = New System.Drawing.Size(1106, 671)
        Me.Panel_Perfil.TabIndex = 0
        '
        'Btn_Editar_Perfil
        '
        Me.Btn_Editar_Perfil.Location = New System.Drawing.Point(157, 415)
        Me.Btn_Editar_Perfil.Name = "Btn_Editar_Perfil"
        Me.Btn_Editar_Perfil.Size = New System.Drawing.Size(224, 48)
        Me.Btn_Editar_Perfil.TabIndex = 23
        Me.Btn_Editar_Perfil.Text = "Editar perfil"
        Me.Btn_Editar_Perfil.UseVisualStyleBackColor = True
        '
        'Panel_Editar_Perfil
        '
        Me.Panel_Editar_Perfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel_Editar_Perfil.Controls.Add(Me.lbl_contraseña)
        Me.Panel_Editar_Perfil.Controls.Add(Me.lbl_id)
        Me.Panel_Editar_Perfil.Controls.Add(Me.Btn_actualizar)
        Me.Panel_Editar_Perfil.Controls.Add(Me.btn_Cancelar)
        Me.Panel_Editar_Perfil.Controls.Add(Me.Label11)
        Me.Panel_Editar_Perfil.Controls.Add(Me.txt_Vigente_pass)
        Me.Panel_Editar_Perfil.Controls.Add(Me.Label9)
        Me.Panel_Editar_Perfil.Controls.Add(Me.txt_apellido)
        Me.Panel_Editar_Perfil.Controls.Add(Me.Label8)
        Me.Panel_Editar_Perfil.Controls.Add(Me.txt_nombre)
        Me.Panel_Editar_Perfil.Controls.Add(Me.Label7)
        Me.Panel_Editar_Perfil.Controls.Add(Me.txt_usuario)
        Me.Panel_Editar_Perfil.Controls.Add(Me.Label6)
        Me.Panel_Editar_Perfil.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_Editar_Perfil.Location = New System.Drawing.Point(554, 0)
        Me.Panel_Editar_Perfil.Name = "Panel_Editar_Perfil"
        Me.Panel_Editar_Perfil.Size = New System.Drawing.Size(552, 671)
        Me.Panel_Editar_Perfil.TabIndex = 8
        Me.Panel_Editar_Perfil.Visible = False
        '
        'lbl_contraseña
        '
        Me.lbl_contraseña.AutoSize = True
        Me.lbl_contraseña.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lbl_contraseña.ForeColor = System.Drawing.Color.White
        Me.lbl_contraseña.Location = New System.Drawing.Point(402, 517)
        Me.lbl_contraseña.Name = "lbl_contraseña"
        Me.lbl_contraseña.Size = New System.Drawing.Size(48, 25)
        Me.lbl_contraseña.TabIndex = 24
        Me.lbl_contraseña.Text = "pass"
        Me.lbl_contraseña.Visible = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lbl_id.ForeColor = System.Drawing.Color.White
        Me.lbl_id.Location = New System.Drawing.Point(417, 42)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(27, 25)
        Me.lbl_id.TabIndex = 24
        Me.lbl_id.Text = "id"
        Me.lbl_id.Visible = False
        '
        'Btn_actualizar
        '
        Me.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Btn_actualizar.FlatAppearance.BorderSize = 0
        Me.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_actualizar.Location = New System.Drawing.Point(277, 421)
        Me.Btn_actualizar.Name = "Btn_actualizar"
        Me.Btn_actualizar.Size = New System.Drawing.Size(139, 33)
        Me.Btn_actualizar.TabIndex = 23
        Me.Btn_actualizar.Text = "Guardar"
        Me.Btn_actualizar.UseVisualStyleBackColor = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(94, 421)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(139, 33)
        Me.btn_Cancelar.TabIndex = 22
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(94, 324)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Contraseña"
        '
        'txt_Vigente_pass
        '
        Me.txt_Vigente_pass.Location = New System.Drawing.Point(94, 355)
        Me.txt_Vigente_pass.Name = "txt_Vigente_pass"
        Me.txt_Vigente_pass.Size = New System.Drawing.Size(322, 27)
        Me.txt_Vigente_pass.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(94, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Apellido"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(94, 271)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(322, 27)
        Me.txt_apellido.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(152, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 31)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "EDITAR MI PERFIL"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(94, 195)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(322, 27)
        Me.txt_nombre.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(94, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Usuario"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(94, 112)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(322, 27)
        Me.txt_usuario.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(94, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nombre"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lbl_apellido.ForeColor = System.Drawing.Color.White
        Me.lbl_apellido.Location = New System.Drawing.Point(417, 321)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(84, 25)
        Me.lbl_apellido.TabIndex = 7
        Me.lbl_apellido.Text = "apellidos"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lbl_nombre.ForeColor = System.Drawing.Color.White
        Me.lbl_nombre.Location = New System.Drawing.Point(417, 236)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(74, 25)
        Me.lbl_nombre.TabIndex = 6
        Me.lbl_nombre.Text = "nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(316, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "APELLIDO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(316, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "NOMBRE:"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lbl_usuario.ForeColor = System.Drawing.Color.White
        Me.lbl_usuario.Location = New System.Drawing.Point(417, 144)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(72, 25)
        Me.lbl_usuario.TabIndex = 3
        Me.lbl_usuario.Text = "usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(316, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "USUARIO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(204, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MI PERFIL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.usuario2
        Me.PictureBox1.Location = New System.Drawing.Point(57, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'View_Editar_Perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 671)
        Me.Controls.Add(Me.Panel_Perfil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "View_Editar_Perfil"
        Me.Text = "EDITAR PERFIL"
        Me.Panel_Perfil.ResumeLayout(False)
        Me.Panel_Perfil.PerformLayout()
        Me.Panel_Editar_Perfil.ResumeLayout(False)
        Me.Panel_Editar_Perfil.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Perfil As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_Editar_Perfil As Panel
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_Editar_Perfil As Button
    Friend WithEvents Btn_actualizar As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_Vigente_pass As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_contraseña As Label
End Class
