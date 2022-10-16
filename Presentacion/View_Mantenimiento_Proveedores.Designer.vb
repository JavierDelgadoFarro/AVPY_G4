<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Mantenimiento_Proveedores
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnmodificarproveedor = New System.Windows.Forms.Button()
        Me.btnagregarproveedor = New System.Windows.Forms.Button()
        Me.txttelefonoproveedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdireccionproveedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtrepresentanteproveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtrucproveedor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnombreproveedor = New System.Windows.Forms.TextBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.labelidproveedor = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btneliminarproveedor = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbuscarproveedor = New System.Windows.Forms.Button()
        Me.DGV_Proveedor = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtbuscarproveedor = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1102, 653)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnmodificarproveedor)
        Me.Panel3.Controls.Add(Me.btnagregarproveedor)
        Me.Panel3.Controls.Add(Me.txttelefonoproveedor)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtdireccionproveedor)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtrepresentanteproveedor)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtrucproveedor)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtnombreproveedor)
        Me.Panel3.Controls.Add(Me.IconPictureBox1)
        Me.Panel3.Controls.Add(Me.labelidproveedor)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btneliminarproveedor)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Location = New System.Drawing.Point(0, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1100, 651)
        Me.Panel3.TabIndex = 1
        '
        'btnmodificarproveedor
        '
        Me.btnmodificarproveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnmodificarproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnmodificarproveedor.ForeColor = System.Drawing.Color.White
        Me.btnmodificarproveedor.Location = New System.Drawing.Point(261, 461)
        Me.btnmodificarproveedor.Name = "btnmodificarproveedor"
        Me.btnmodificarproveedor.Size = New System.Drawing.Size(99, 35)
        Me.btnmodificarproveedor.TabIndex = 59
        Me.btnmodificarproveedor.Text = "Modificar"
        Me.btnmodificarproveedor.UseVisualStyleBackColor = False
        '
        'btnagregarproveedor
        '
        Me.btnagregarproveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnagregarproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregarproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnagregarproveedor.ForeColor = System.Drawing.Color.White
        Me.btnagregarproveedor.Location = New System.Drawing.Point(102, 461)
        Me.btnagregarproveedor.Name = "btnagregarproveedor"
        Me.btnagregarproveedor.Size = New System.Drawing.Size(99, 35)
        Me.btnagregarproveedor.TabIndex = 58
        Me.btnagregarproveedor.Text = "Nuevo"
        Me.btnagregarproveedor.UseVisualStyleBackColor = False
        '
        'txttelefonoproveedor
        '
        Me.txttelefonoproveedor.Location = New System.Drawing.Point(175, 399)
        Me.txttelefonoproveedor.Name = "txttelefonoproveedor"
        Me.txttelefonoproveedor.Size = New System.Drawing.Size(225, 22)
        Me.txttelefonoproveedor.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(56, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Teléfono"
        '
        'txtdireccionproveedor
        '
        Me.txtdireccionproveedor.Location = New System.Drawing.Point(175, 357)
        Me.txtdireccionproveedor.Name = "txtdireccionproveedor"
        Me.txtdireccionproveedor.Size = New System.Drawing.Size(225, 22)
        Me.txtdireccionproveedor.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(56, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Dirección"
        '
        'txtrepresentanteproveedor
        '
        Me.txtrepresentanteproveedor.Location = New System.Drawing.Point(175, 312)
        Me.txtrepresentanteproveedor.Name = "txtrepresentanteproveedor"
        Me.txtrepresentanteproveedor.Size = New System.Drawing.Size(225, 22)
        Me.txtrepresentanteproveedor.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(56, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Representante"
        '
        'txtrucproveedor
        '
        Me.txtrucproveedor.Location = New System.Drawing.Point(175, 267)
        Me.txtrucproveedor.Name = "txtrucproveedor"
        Me.txtrucproveedor.Size = New System.Drawing.Size(225, 22)
        Me.txtrucproveedor.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(56, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "N° RUC"
        '
        'txtnombreproveedor
        '
        Me.txtnombreproveedor.Location = New System.Drawing.Point(175, 224)
        Me.txtnombreproveedor.Name = "txtnombreproveedor"
        Me.txtnombreproveedor.Size = New System.Drawing.Size(225, 22)
        Me.txtnombreproveedor.TabIndex = 49
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 67
        Me.IconPictureBox1.Location = New System.Drawing.Point(194, 70)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(67, 71)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox1.TabIndex = 45
        Me.IconPictureBox1.TabStop = False
        '
        'labelidproveedor
        '
        Me.labelidproveedor.AutoSize = True
        Me.labelidproveedor.ForeColor = System.Drawing.Color.White
        Me.labelidproveedor.Location = New System.Drawing.Point(175, 187)
        Me.labelidproveedor.Name = "labelidproveedor"
        Me.labelidproveedor.Size = New System.Drawing.Size(23, 16)
        Me.labelidproveedor.TabIndex = 48
        Me.labelidproveedor.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(92, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(257, 16)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "MANTENIMIENTO DE PROVEEDOR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(56, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(56, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 16)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "ID"
        '
        'btneliminarproveedor
        '
        Me.btneliminarproveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btneliminarproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminarproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btneliminarproveedor.ForeColor = System.Drawing.Color.White
        Me.btneliminarproveedor.Location = New System.Drawing.Point(433, 605)
        Me.btneliminarproveedor.Name = "btneliminarproveedor"
        Me.btneliminarproveedor.Size = New System.Drawing.Size(99, 35)
        Me.btneliminarproveedor.TabIndex = 43
        Me.btneliminarproveedor.Text = "Eliminar"
        Me.btneliminarproveedor.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbuscarproveedor)
        Me.GroupBox1.Controls.Add(Me.DGV_Proveedor)
        Me.GroupBox1.Controls.Add(Me.txtbuscarproveedor)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(433, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 568)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTA DE PROVEEDORES"
        '
        'btnbuscarproveedor
        '
        Me.btnbuscarproveedor.BackColor = System.Drawing.Color.Blue
        Me.btnbuscarproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnbuscarproveedor.ForeColor = System.Drawing.Color.White
        Me.btnbuscarproveedor.Location = New System.Drawing.Point(518, 38)
        Me.btnbuscarproveedor.Name = "btnbuscarproveedor"
        Me.btnbuscarproveedor.Size = New System.Drawing.Size(78, 26)
        Me.btnbuscarproveedor.TabIndex = 60
        Me.btnbuscarproveedor.Text = "Buscar"
        Me.btnbuscarproveedor.UseVisualStyleBackColor = False
        '
        'DGV_Proveedor
        '
        Me.DGV_Proveedor.AllowUserToAddRows = False
        Me.DGV_Proveedor.AllowUserToDeleteRows = False
        Me.DGV_Proveedor.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DGV_Proveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Proveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Proveedor.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Proveedor.GridColor = System.Drawing.Color.White
        Me.DGV_Proveedor.Location = New System.Drawing.Point(25, 87)
        Me.DGV_Proveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV_Proveedor.Name = "DGV_Proveedor"
        Me.DGV_Proveedor.RowHeadersVisible = False
        Me.DGV_Proveedor.RowTemplate.Height = 25
        Me.DGV_Proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Proveedor.Size = New System.Drawing.Size(592, 453)
        Me.DGV_Proveedor.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "idproveedor"
        Me.Column1.HeaderText = "idproveedor"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nombre"
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 95
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "RUC"
        Me.Column3.HeaderText = "RUC"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 85
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "representante"
        Me.Column4.HeaderText = "Representante"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 110
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "direccion"
        Me.Column5.HeaderText = "Direccion"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "telefono"
        Me.Column6.HeaderText = "Telefono"
        Me.Column6.Name = "Column6"
        '
        'txtbuscarproveedor
        '
        Me.txtbuscarproveedor.Location = New System.Drawing.Point(43, 40)
        Me.txtbuscarproveedor.Name = "txtbuscarproveedor"
        Me.txtbuscarproveedor.Size = New System.Drawing.Size(465, 22)
        Me.txtbuscarproveedor.TabIndex = 2
        '
        'View_Mantenimiento_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1101, 654)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "View_Mantenimiento_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View_Mantenimiento_Proveedores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbuscarproveedor As TextBox
    Friend WithEvents DGV_Proveedor As DataGridView
    Friend WithEvents btneliminarproveedor As Button
    Friend WithEvents btnmodificarproveedor As Button
    Friend WithEvents btnagregarproveedor As Button
    Friend WithEvents txttelefonoproveedor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdireccionproveedor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtrepresentanteproveedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtrucproveedor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnombreproveedor As TextBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents labelidproveedor As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnbuscarproveedor As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
