﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View_Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_Ventas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.Cb_filtro = New System.Windows.Forms.CheckBox()
        Me.Cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_idcliente = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.pnl_ini = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_TotalVenta = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Rbtn_Contado = New System.Windows.Forms.RadioButton()
        Me.btn_Total_pagar = New System.Windows.Forms.Button()
        Me.Rbtn_Credito = New System.Windows.Forms.RadioButton()
        Me.panel_detalle = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pic_Producto = New System.Windows.Forms.PictureBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.btnAceptarDetalleProducto = New System.Windows.Forms.Button()
        Me.btnCancelarDetalleProducto = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCantidadProducto = New System.Windows.Forms.TextBox()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lsv_det = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnl_ini.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_detalle.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pic_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_producto)
        Me.GroupBox1.Controls.Add(Me.Cb_filtro)
        Me.GroupBox1.Controls.Add(Me.Cmb_categoria)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(659, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(703, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Producto"
        '
        'txt_producto
        '
        Me.txt_producto.Location = New System.Drawing.Point(93, 57)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(227, 27)
        Me.txt_producto.TabIndex = 17
        '
        'Cb_filtro
        '
        Me.Cb_filtro.AutoSize = True
        Me.Cb_filtro.Location = New System.Drawing.Point(347, 60)
        Me.Cb_filtro.Name = "Cb_filtro"
        Me.Cb_filtro.Size = New System.Drawing.Size(82, 24)
        Me.Cb_filtro.TabIndex = 16
        Me.Cb_filtro.Text = "Filtrar"
        Me.Cb_filtro.UseVisualStyleBackColor = True
        '
        'Cmb_categoria
        '
        Me.Cmb_categoria.FormattingEnabled = True
        Me.Cmb_categoria.Location = New System.Drawing.Point(435, 57)
        Me.Cmb_categoria.Name = "Cmb_categoria"
        Me.Cmb_categoria.Size = New System.Drawing.Size(237, 28)
        Me.Cmb_categoria.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(11, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'lbl_idcliente
        '
        Me.lbl_idcliente.AutoSize = True
        Me.lbl_idcliente.Location = New System.Drawing.Point(409, 529)
        Me.lbl_idcliente.Name = "lbl_idcliente"
        Me.lbl_idcliente.Size = New System.Drawing.Size(68, 20)
        Me.lbl_idcliente.TabIndex = 30
        Me.lbl_idcliente.Text = "idCliente"
        Me.lbl_idcliente.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Btn_Actualizar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Cmb_cliente)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(31, 557)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(517, 167)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(347, 105)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(124, 27)
        Me.DateTimePicker2.TabIndex = 32
        Me.DateTimePicker2.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 105)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(164, 27)
        Me.DateTimePicker1.TabIndex = 31
        Me.DateTimePicker1.Visible = False
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Actualizar.ForeColor = System.Drawing.Color.White
        Me.Btn_Actualizar.Location = New System.Drawing.Point(347, 40)
        Me.Btn_Actualizar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(125, 39)
        Me.Btn_Actualizar.TabIndex = 8
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 49)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombre"
        '
        'Cmb_cliente
        '
        Me.Cmb_cliente.FormattingEnabled = True
        Me.Cmb_cliente.Location = New System.Drawing.Point(85, 45)
        Me.Cmb_cliente.Name = "Cmb_cliente"
        Me.Cmb_cliente.Size = New System.Drawing.Size(243, 28)
        Me.Cmb_cliente.TabIndex = 12
        '
        'pnl_ini
        '
        Me.pnl_ini.BackColor = System.Drawing.Color.Gray
        Me.pnl_ini.Controls.Add(Me.Label10)
        Me.pnl_ini.Controls.Add(Me.PictureBox1)
        Me.pnl_ini.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pnl_ini.ForeColor = System.Drawing.Color.Cornsilk
        Me.pnl_ini.Location = New System.Drawing.Point(54, 100)
        Me.pnl_ini.Name = "pnl_ini"
        Me.pnl_ini.Size = New System.Drawing.Size(481, 418)
        Me.pnl_ini.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(25, 299)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(398, 38)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "EL carrito de venta está vacío"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.ferreteria_icono
        Me.PictureBox1.Location = New System.Drawing.Point(112, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(146, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DETALLE DE FACTURACIÓN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Blue
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(261, 475)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 28)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "S/."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(54, 531)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo de Venta"
        '
        'lbl_TotalVenta
        '
        Me.lbl_TotalVenta.AutoSize = True
        Me.lbl_TotalVenta.BackColor = System.Drawing.Color.Blue
        Me.lbl_TotalVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_TotalVenta.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_TotalVenta.ForeColor = System.Drawing.Color.White
        Me.lbl_TotalVenta.Location = New System.Drawing.Point(438, 475)
        Me.lbl_TotalVenta.Name = "lbl_TotalVenta"
        Me.lbl_TotalVenta.Size = New System.Drawing.Size(64, 35)
        Me.lbl_TotalVenta.TabIndex = 27
        Me.lbl_TotalVenta.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(179, 53)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 20)
        Me.Label8.TabIndex = 11
        '
        'Rbtn_Contado
        '
        Me.Rbtn_Contado.AutoSize = True
        Me.Rbtn_Contado.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Rbtn_Contado.ForeColor = System.Drawing.Color.White
        Me.Rbtn_Contado.Location = New System.Drawing.Point(190, 524)
        Me.Rbtn_Contado.Name = "Rbtn_Contado"
        Me.Rbtn_Contado.Size = New System.Drawing.Size(102, 29)
        Me.Rbtn_Contado.TabIndex = 16
        Me.Rbtn_Contado.TabStop = True
        Me.Rbtn_Contado.Text = "Contado"
        Me.Rbtn_Contado.UseVisualStyleBackColor = True
        '
        'btn_Total_pagar
        '
        Me.btn_Total_pagar.BackColor = System.Drawing.Color.Blue
        Me.btn_Total_pagar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btn_Total_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Total_pagar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Total_pagar.ForeColor = System.Drawing.Color.White
        Me.btn_Total_pagar.Location = New System.Drawing.Point(54, 473)
        Me.btn_Total_pagar.Name = "btn_Total_pagar"
        Me.btn_Total_pagar.Size = New System.Drawing.Size(195, 36)
        Me.btn_Total_pagar.TabIndex = 19
        Me.btn_Total_pagar.Text = "Total a Pagar"
        Me.btn_Total_pagar.UseVisualStyleBackColor = False
        '
        'Rbtn_Credito
        '
        Me.Rbtn_Credito.AutoSize = True
        Me.Rbtn_Credito.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Rbtn_Credito.ForeColor = System.Drawing.Color.White
        Me.Rbtn_Credito.Location = New System.Drawing.Point(293, 524)
        Me.Rbtn_Credito.Name = "Rbtn_Credito"
        Me.Rbtn_Credito.Size = New System.Drawing.Size(91, 29)
        Me.Rbtn_Credito.TabIndex = 17
        Me.Rbtn_Credito.TabStop = True
        Me.Rbtn_Credito.Text = "Crédito"
        Me.Rbtn_Credito.UseVisualStyleBackColor = True
        '
        'panel_detalle
        '
        Me.panel_detalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.panel_detalle.Controls.Add(Me.GroupBox4)
        Me.panel_detalle.Controls.Add(Me.btnAceptarDetalleProducto)
        Me.panel_detalle.Controls.Add(Me.btnCancelarDetalleProducto)
        Me.panel_detalle.Controls.Add(Me.GroupBox3)
        Me.panel_detalle.Location = New System.Drawing.Point(807, 375)
        Me.panel_detalle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel_detalle.Name = "panel_detalle"
        Me.panel_detalle.Size = New System.Drawing.Size(588, 367)
        Me.panel_detalle.TabIndex = 515
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pic_Producto)
        Me.GroupBox4.Controls.Add(Me.lbl_nombre)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Location = New System.Drawing.Point(20, 16)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(296, 328)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "LISTA DE DETALLE DE PRODUCTOS"
        '
        'pic_Producto
        '
        Me.pic_Producto.Location = New System.Drawing.Point(56, 53)
        Me.pic_Producto.Name = "pic_Producto"
        Me.pic_Producto.Size = New System.Drawing.Size(187, 250)
        Me.pic_Producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Producto.TabIndex = 7
        Me.pic_Producto.TabStop = False
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_nombre.Location = New System.Drawing.Point(113, 27)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(50, 20)
        Me.lbl_nombre.TabIndex = 6
        Me.lbl_nombre.Text = "texto"
        '
        'btnAceptarDetalleProducto
        '
        Me.btnAceptarDetalleProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnAceptarDetalleProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarDetalleProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAceptarDetalleProducto.ForeColor = System.Drawing.Color.White
        Me.btnAceptarDetalleProducto.Location = New System.Drawing.Point(339, 198)
        Me.btnAceptarDetalleProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAceptarDetalleProducto.Name = "btnAceptarDetalleProducto"
        Me.btnAceptarDetalleProducto.Size = New System.Drawing.Size(99, 44)
        Me.btnAceptarDetalleProducto.TabIndex = 20
        Me.btnAceptarDetalleProducto.Text = "Aceptar"
        Me.btnAceptarDetalleProducto.UseVisualStyleBackColor = False
        '
        'btnCancelarDetalleProducto
        '
        Me.btnCancelarDetalleProducto.BackColor = System.Drawing.Color.Red
        Me.btnCancelarDetalleProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarDetalleProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancelarDetalleProducto.ForeColor = System.Drawing.Color.White
        Me.btnCancelarDetalleProducto.Location = New System.Drawing.Point(480, 198)
        Me.btnCancelarDetalleProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelarDetalleProducto.Name = "btnCancelarDetalleProducto"
        Me.btnCancelarDetalleProducto.Size = New System.Drawing.Size(99, 44)
        Me.btnCancelarDetalleProducto.TabIndex = 11
        Me.btnCancelarDetalleProducto.Text = "Cancelar"
        Me.btnCancelarDetalleProducto.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_precio)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtCantidadProducto)
        Me.GroupBox3.Controls.Add(Me.lbl_stock)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Location = New System.Drawing.Point(331, 33)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(242, 147)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_precio.Location = New System.Drawing.Point(149, 70)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(19, 20)
        Me.lbl_precio.TabIndex = 5
        Me.lbl_precio.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(24, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad"
        '
        'txtCantidadProducto
        '
        Me.txtCantidadProducto.Location = New System.Drawing.Point(125, 100)
        Me.txtCantidadProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCantidadProducto.Name = "txtCantidadProducto"
        Me.txtCantidadProducto.Size = New System.Drawing.Size(102, 23)
        Me.txtCantidadProducto.TabIndex = 6
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_stock.Location = New System.Drawing.Point(149, 40)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(19, 20)
        Me.lbl_stock.TabIndex = 4
        Me.lbl_stock.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(24, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(24, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Stock"
        '
        'Lsv_det
        '
        Me.Lsv_det.Location = New System.Drawing.Point(56, 130)
        Me.Lsv_det.Name = "Lsv_det"
        Me.Lsv_det.Size = New System.Drawing.Size(479, 324)
        Me.Lsv_det.TabIndex = 516
        Me.Lsv_det.UseCompatibleStateImageBehavior = False
        '
        'View_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1407, 755)
        Me.Controls.Add(Me.pnl_ini)
        Me.Controls.Add(Me.Lsv_det)
        Me.Controls.Add(Me.panel_detalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_idcliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Rbtn_Credito)
        Me.Controls.Add(Me.btn_Total_pagar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Rbtn_Contado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_TotalVenta)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "View_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnl_ini.ResumeLayout(False)
        Me.pnl_ini.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_detalle.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pic_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmb_categoria As ComboBox
    Friend WithEvents Cb_filtro As CheckBox
    Friend WithEvents lbl_idcliente As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Cmb_cliente As ComboBox
    Friend WithEvents pnl_ini As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Rbtn_Contado As RadioButton
    Friend WithEvents btn_Total_pagar As Button
    Friend WithEvents Rbtn_Credito As RadioButton
    Friend WithEvents txt_producto As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Public WithEvents lbl_TotalVenta As Label
    Friend WithEvents panel_detalle As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents pic_Producto As PictureBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAceptarDetalleProducto As Button
    Friend WithEvents btnCancelarDetalleProducto As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_precio As Label
    Friend WithEvents txtCantidadProducto As TextBox
    Friend WithEvents lbl_stock As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lsv_det As ListView
End Class
