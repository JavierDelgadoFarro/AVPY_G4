<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View_Mantenimiento_Empleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.labelIdEmpleado = New System.Windows.Forms.Label()
        Me.TextNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.TextApellidoEmpleado = New System.Windows.Forms.TextBox()
        Me.TextContraseñaEmpleado = New System.Windows.Forms.TextBox()
        Me.TextUsuarioEmpleado = New System.Windows.Forms.TextBox()
        Me.ComboBoxRol = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVEmpleado = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnbuscarEmpleado = New System.Windows.Forms.Button()
        Me.txtbuscarEmpleado = New System.Windows.Forms.TextBox()
        Me.btnmodificarEmpleado = New System.Windows.Forms.Button()
        Me.btnnuevoEmpleado = New System.Windows.Forms.Button()
        Me.btneliminarEmpleado = New System.Windows.Forms.Button()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MANTENIMIENTO DE EMPLEADOS"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 67
        Me.IconPictureBox1.Location = New System.Drawing.Point(147, 48)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(67, 71)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox1.TabIndex = 2
        Me.IconPictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(37, 322)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Contraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(37, 280)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(37, 239)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 196)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 361)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Rol"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(37, 403)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Usuario"
        '
        'labelIdEmpleado
        '
        Me.labelIdEmpleado.AutoSize = True
        Me.labelIdEmpleado.ForeColor = System.Drawing.Color.White
        Me.labelIdEmpleado.Location = New System.Drawing.Point(147, 196)
        Me.labelIdEmpleado.Name = "labelIdEmpleado"
        Me.labelIdEmpleado.Size = New System.Drawing.Size(19, 15)
        Me.labelIdEmpleado.TabIndex = 24
        Me.labelIdEmpleado.Text = "00"
        '
        'TextNombreEmpleado
        '
        Me.TextNombreEmpleado.Location = New System.Drawing.Point(144, 237)
        Me.TextNombreEmpleado.Name = "TextNombreEmpleado"
        Me.TextNombreEmpleado.Size = New System.Drawing.Size(183, 23)
        Me.TextNombreEmpleado.TabIndex = 25
        '
        'TextApellidoEmpleado
        '
        Me.TextApellidoEmpleado.Location = New System.Drawing.Point(144, 275)
        Me.TextApellidoEmpleado.Name = "TextApellidoEmpleado"
        Me.TextApellidoEmpleado.Size = New System.Drawing.Size(183, 23)
        Me.TextApellidoEmpleado.TabIndex = 26
        '
        'TextContraseñaEmpleado
        '
        Me.TextContraseñaEmpleado.Location = New System.Drawing.Point(144, 320)
        Me.TextContraseñaEmpleado.Name = "TextContraseñaEmpleado"
        Me.TextContraseñaEmpleado.Size = New System.Drawing.Size(183, 23)
        Me.TextContraseñaEmpleado.TabIndex = 27
        '
        'TextUsuarioEmpleado
        '
        Me.TextUsuarioEmpleado.Location = New System.Drawing.Point(144, 400)
        Me.TextUsuarioEmpleado.Name = "TextUsuarioEmpleado"
        Me.TextUsuarioEmpleado.Size = New System.Drawing.Size(183, 23)
        Me.TextUsuarioEmpleado.TabIndex = 28
        '
        'ComboBoxRol
        '
        Me.ComboBoxRol.FormattingEnabled = True
        Me.ComboBoxRol.Location = New System.Drawing.Point(144, 359)
        Me.ComboBoxRol.Name = "ComboBoxRol"
        Me.ComboBoxRol.Size = New System.Drawing.Size(183, 23)
        Me.ComboBoxRol.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGVEmpleado)
        Me.GroupBox1.Controls.Add(Me.btnbuscarEmpleado)
        Me.GroupBox1.Controls.Add(Me.txtbuscarEmpleado)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(380, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 464)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTA DE EMPLEADOS"
        '
        'DGVEmpleado
        '
        Me.DGVEmpleado.AllowUserToAddRows = False
        Me.DGVEmpleado.AllowUserToDeleteRows = False
        Me.DGVEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DGVEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVEmpleado.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGVEmpleado.Location = New System.Drawing.Point(25, 98)
        Me.DGVEmpleado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGVEmpleado.Name = "DGVEmpleado"
        Me.DGVEmpleado.ReadOnly = True
        Me.DGVEmpleado.RowHeadersVisible = False
        Me.DGVEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVEmpleado.Size = New System.Drawing.Size(662, 322)
        Me.DGVEmpleado.TabIndex = 27
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "idempleado"
        Me.Column1.HeaderText = "idempleado"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nombres"
        Me.Column2.HeaderText = "nombres"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 130
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "apellidos"
        Me.Column3.HeaderText = "apellidos"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 130
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "contraseña"
        Me.Column4.HeaderText = "contraseña"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "id_rol"
        Me.Column5.HeaderText = "id_rol"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "usuario"
        Me.Column6.HeaderText = "usuario"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'btnbuscarEmpleado
        '
        Me.btnbuscarEmpleado.BackColor = System.Drawing.Color.Red
        Me.btnbuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnbuscarEmpleado.ForeColor = System.Drawing.Color.White
        Me.btnbuscarEmpleado.Location = New System.Drawing.Point(511, 48)
        Me.btnbuscarEmpleado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnbuscarEmpleado.Name = "btnbuscarEmpleado"
        Me.btnbuscarEmpleado.Size = New System.Drawing.Size(72, 27)
        Me.btnbuscarEmpleado.TabIndex = 26
        Me.btnbuscarEmpleado.Text = "Buscar"
        Me.btnbuscarEmpleado.UseVisualStyleBackColor = False
        '
        'txtbuscarEmpleado
        '
        Me.txtbuscarEmpleado.Location = New System.Drawing.Point(103, 51)
        Me.txtbuscarEmpleado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtbuscarEmpleado.Name = "txtbuscarEmpleado"
        Me.txtbuscarEmpleado.Size = New System.Drawing.Size(383, 23)
        Me.txtbuscarEmpleado.TabIndex = 25
        '
        'btnmodificarEmpleado
        '
        Me.btnmodificarEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnmodificarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnmodificarEmpleado.ForeColor = System.Drawing.Color.White
        Me.btnmodificarEmpleado.Location = New System.Drawing.Point(212, 455)
        Me.btnmodificarEmpleado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnmodificarEmpleado.Name = "btnmodificarEmpleado"
        Me.btnmodificarEmpleado.Size = New System.Drawing.Size(115, 40)
        Me.btnmodificarEmpleado.TabIndex = 34
        Me.btnmodificarEmpleado.Text = "Modificar"
        Me.btnmodificarEmpleado.UseVisualStyleBackColor = False
        '
        'btnnuevoEmpleado
        '
        Me.btnnuevoEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnnuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnnuevoEmpleado.ForeColor = System.Drawing.Color.White
        Me.btnnuevoEmpleado.Location = New System.Drawing.Point(43, 455)
        Me.btnnuevoEmpleado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnnuevoEmpleado.Name = "btnnuevoEmpleado"
        Me.btnnuevoEmpleado.Size = New System.Drawing.Size(115, 40)
        Me.btnnuevoEmpleado.TabIndex = 33
        Me.btnnuevoEmpleado.Text = "Nuevo"
        Me.btnnuevoEmpleado.UseVisualStyleBackColor = False
        '
        'btneliminarEmpleado
        '
        Me.btneliminarEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btneliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btneliminarEmpleado.ForeColor = System.Drawing.Color.White
        Me.btneliminarEmpleado.Location = New System.Drawing.Point(974, 532)
        Me.btneliminarEmpleado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btneliminarEmpleado.Name = "btneliminarEmpleado"
        Me.btneliminarEmpleado.Size = New System.Drawing.Size(115, 40)
        Me.btneliminarEmpleado.TabIndex = 35
        Me.btneliminarEmpleado.Text = "Eliminar"
        Me.btneliminarEmpleado.UseVisualStyleBackColor = False
        '
        'View_Mantenimiento_Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1130, 602)
        Me.Controls.Add(Me.btneliminarEmpleado)
        Me.Controls.Add(Me.btnmodificarEmpleado)
        Me.Controls.Add(Me.btnnuevoEmpleado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBoxRol)
        Me.Controls.Add(Me.TextUsuarioEmpleado)
        Me.Controls.Add(Me.TextContraseñaEmpleado)
        Me.Controls.Add(Me.TextApellidoEmpleado)
        Me.Controls.Add(Me.TextNombreEmpleado)
        Me.Controls.Add(Me.labelIdEmpleado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "View_Mantenimiento_Empleado"
        Me.Text = "View_Mantenimiento_Empleado"
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents labelIdEmpleado As Label
    Friend WithEvents TextNombreEmpleado As TextBox
    Friend WithEvents TextApellidoEmpleado As TextBox
    Friend WithEvents TextContraseñaEmpleado As TextBox
    Friend WithEvents TextUsuarioEmpleado As TextBox
    Friend WithEvents ComboBoxRol As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnmodificarEmpleado As Button
    Friend WithEvents btnnuevoEmpleado As Button
    Friend WithEvents btneliminarEmpleado As Button
    Friend WithEvents btnbuscarEmpleado As Button
    Friend WithEvents txtbuscarEmpleado As TextBox
    Friend WithEvents DGVEmpleado As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
