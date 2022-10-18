<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class view_Principal
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
        Me.Panel_Menu = New System.Windows.Forms.Panel()
        Me.Btn_Cerrar_Sesion = New FontAwesome.Sharp.IconButton()
        Me.Btn_Configuracion = New FontAwesome.Sharp.IconButton()
        Me.Panel_Mantenimiento = New System.Windows.Forms.Panel()
        Me.btnEmpleado = New FontAwesome.Sharp.IconButton()
        Me.Btn_Cliente = New FontAwesome.Sharp.IconButton()
        Me.Btn_Categoria = New FontAwesome.Sharp.IconButton()
        Me.Btn_Proveedor = New FontAwesome.Sharp.IconButton()
        Me.Btn_Producto = New FontAwesome.Sharp.IconButton()
        Me.Btn_Pagos = New FontAwesome.Sharp.IconButton()
        Me.Btn_Compras = New FontAwesome.Sharp.IconButton()
        Me.Btn_Ventas = New FontAwesome.Sharp.IconButton()
        Me.Panel_Logo = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lbl_apellidos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Barra_Titulo = New System.Windows.Forms.Panel()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_link_editar = New System.Windows.Forms.LinkLabel()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Pic_Perfil = New System.Windows.Forms.PictureBox()
        Me.Btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.Btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Btn_Maximizar = New System.Windows.Forms.PictureBox()
        Me.Title_Actual = New System.Windows.Forms.Label()
        Me.Icon_Form_Actual = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel_Secundario = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Btn_Mantenimiento = New FontAwesome.Sharp.IconButton()
        Me.Panel_Menu.SuspendLayout()
        Me.Panel_Mantenimiento.SuspendLayout()
        Me.Panel_Logo.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Barra_Titulo.SuspendLayout()
        CType(Me.Pic_Perfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_Form_Actual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Secundario.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Menu
        '
        Me.Panel_Menu.AutoScroll = True
        Me.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel_Menu.Controls.Add(Me.Btn_Cerrar_Sesion)
        Me.Panel_Menu.Controls.Add(Me.Btn_Configuracion)
        Me.Panel_Menu.Controls.Add(Me.Panel_Mantenimiento)
        Me.Panel_Menu.Controls.Add(Me.Btn_Mantenimiento)
        Me.Panel_Menu.Controls.Add(Me.Btn_Producto)
        Me.Panel_Menu.Controls.Add(Me.Btn_Pagos)
        Me.Panel_Menu.Controls.Add(Me.Btn_Compras)
        Me.Panel_Menu.Controls.Add(Me.Btn_Ventas)
        Me.Panel_Menu.Controls.Add(Me.Panel_Logo)
        Me.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(237, 557)
        Me.Panel_Menu.TabIndex = 0
        '
        'Btn_Cerrar_Sesion
        '
        Me.Btn_Cerrar_Sesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Cerrar_Sesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Cerrar_Sesion.FlatAppearance.BorderSize = 0
        Me.Btn_Cerrar_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cerrar_Sesion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Cerrar_Sesion.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Cerrar_Sesion.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.Btn_Cerrar_Sesion.IconColor = System.Drawing.Color.White
        Me.Btn_Cerrar_Sesion.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Cerrar_Sesion.IconSize = 35
        Me.Btn_Cerrar_Sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cerrar_Sesion.Location = New System.Drawing.Point(0, 690)
        Me.Btn_Cerrar_Sesion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Cerrar_Sesion.Name = "Btn_Cerrar_Sesion"
        Me.Btn_Cerrar_Sesion.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Cerrar_Sesion.Size = New System.Drawing.Size(220, 34)
        Me.Btn_Cerrar_Sesion.TabIndex = 7
        Me.Btn_Cerrar_Sesion.Text = "Cerrar Sesión"
        Me.Btn_Cerrar_Sesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cerrar_Sesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cerrar_Sesion.UseVisualStyleBackColor = False
        '
        'Btn_Configuracion
        '
        Me.Btn_Configuracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Configuracion.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Configuracion.FlatAppearance.BorderSize = 0
        Me.Btn_Configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Configuracion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Configuracion.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Configuracion.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench
        Me.Btn_Configuracion.IconColor = System.Drawing.Color.White
        Me.Btn_Configuracion.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Configuracion.IconSize = 35
        Me.Btn_Configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Configuracion.Location = New System.Drawing.Point(0, 645)
        Me.Btn_Configuracion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Configuracion.Name = "Btn_Configuracion"
        Me.Btn_Configuracion.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Configuracion.Size = New System.Drawing.Size(220, 45)
        Me.Btn_Configuracion.TabIndex = 6
        Me.Btn_Configuracion.Text = "Configuraciones"
        Me.Btn_Configuracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Configuracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Configuracion.UseVisualStyleBackColor = False
        '
        'Panel_Mantenimiento
        '
        Me.Panel_Mantenimiento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel_Mantenimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel_Mantenimiento.Controls.Add(Me.btnEmpleado)
        Me.Panel_Mantenimiento.Controls.Add(Me.Btn_Cliente)
        Me.Panel_Mantenimiento.Controls.Add(Me.Btn_Categoria)
        Me.Panel_Mantenimiento.Controls.Add(Me.Btn_Proveedor)
        Me.Panel_Mantenimiento.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Mantenimiento.Location = New System.Drawing.Point(0, 472)
        Me.Panel_Mantenimiento.Name = "Panel_Mantenimiento"
        Me.Panel_Mantenimiento.Size = New System.Drawing.Size(220, 173)
        Me.Panel_Mantenimiento.TabIndex = 7
        '
        'btnEmpleado
        '
        Me.btnEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnEmpleado.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmpleado.FlatAppearance.BorderSize = 0
        Me.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEmpleado.ForeColor = System.Drawing.Color.Silver
        Me.btnEmpleado.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup
        Me.btnEmpleado.IconColor = System.Drawing.Color.White
        Me.btnEmpleado.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEmpleado.IconSize = 35
        Me.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleado.Location = New System.Drawing.Point(0, 119)
        Me.btnEmpleado.Name = "btnEmpleado"
        Me.btnEmpleado.Padding = New System.Windows.Forms.Padding(51, 0, 23, 0)
        Me.btnEmpleado.Size = New System.Drawing.Size(220, 38)
        Me.btnEmpleado.TabIndex = 11
        Me.btnEmpleado.Text = "Empleados"
        Me.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpleado.UseVisualStyleBackColor = False
        '
        'Btn_Cliente
        '
        Me.Btn_Cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Cliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Cliente.FlatAppearance.BorderSize = 0
        Me.Btn_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Cliente.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Cliente.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows
        Me.Btn_Cliente.IconColor = System.Drawing.Color.White
        Me.Btn_Cliente.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Cliente.IconSize = 35
        Me.Btn_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cliente.Location = New System.Drawing.Point(0, 66)
        Me.Btn_Cliente.Name = "Btn_Cliente"
        Me.Btn_Cliente.Padding = New System.Windows.Forms.Padding(51, 0, 23, 0)
        Me.Btn_Cliente.Size = New System.Drawing.Size(220, 53)
        Me.Btn_Cliente.TabIndex = 10
        Me.Btn_Cliente.Text = "Clientes"
        Me.Btn_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cliente.UseVisualStyleBackColor = False
        '
        'Btn_Categoria
        '
        Me.Btn_Categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Categoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Categoria.FlatAppearance.BorderSize = 0
        Me.Btn_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Categoria.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Categoria.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Categoria.IconChar = FontAwesome.Sharp.IconChar.GripHorizontal
        Me.Btn_Categoria.IconColor = System.Drawing.Color.White
        Me.Btn_Categoria.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Categoria.IconSize = 35
        Me.Btn_Categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Categoria.Location = New System.Drawing.Point(0, 33)
        Me.Btn_Categoria.Name = "Btn_Categoria"
        Me.Btn_Categoria.Padding = New System.Windows.Forms.Padding(45, 0, 20, 0)
        Me.Btn_Categoria.Size = New System.Drawing.Size(220, 33)
        Me.Btn_Categoria.TabIndex = 9
        Me.Btn_Categoria.Text = "Categorias"
        Me.Btn_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Categoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Categoria.UseVisualStyleBackColor = False
        '
        'Btn_Proveedor
        '
        Me.Btn_Proveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Proveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Proveedor.FlatAppearance.BorderSize = 0
        Me.Btn_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Proveedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Proveedor.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Proveedor.IconChar = FontAwesome.Sharp.IconChar.Supple
        Me.Btn_Proveedor.IconColor = System.Drawing.Color.White
        Me.Btn_Proveedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Proveedor.IconSize = 35
        Me.Btn_Proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Proveedor.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Proveedor.Name = "Btn_Proveedor"
        Me.Btn_Proveedor.Padding = New System.Windows.Forms.Padding(45, 0, 20, 0)
        Me.Btn_Proveedor.Size = New System.Drawing.Size(220, 33)
        Me.Btn_Proveedor.TabIndex = 8
        Me.Btn_Proveedor.Text = "Proveedores"
        Me.Btn_Proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Proveedor.UseVisualStyleBackColor = False
        '
        'Btn_Producto
        '
        Me.Btn_Producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Producto.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Producto.FlatAppearance.BorderSize = 0
        Me.Btn_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Producto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Producto.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Producto.IconChar = FontAwesome.Sharp.IconChar.Tag
        Me.Btn_Producto.IconColor = System.Drawing.Color.White
        Me.Btn_Producto.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Producto.IconSize = 35
        Me.Btn_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Producto.Location = New System.Drawing.Point(0, 382)
        Me.Btn_Producto.Name = "Btn_Producto"
        Me.Btn_Producto.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Producto.Size = New System.Drawing.Size(220, 45)
        Me.Btn_Producto.TabIndex = 4
        Me.Btn_Producto.Text = "Productos"
        Me.Btn_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Producto.UseVisualStyleBackColor = False
        '
        'Btn_Pagos
        '
        Me.Btn_Pagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Pagos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Pagos.FlatAppearance.BorderSize = 0
        Me.Btn_Pagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Pagos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Pagos.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Pagos.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer
        Me.Btn_Pagos.IconColor = System.Drawing.Color.White
        Me.Btn_Pagos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Pagos.IconSize = 35
        Me.Btn_Pagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Pagos.Location = New System.Drawing.Point(0, 337)
        Me.Btn_Pagos.Name = "Btn_Pagos"
        Me.Btn_Pagos.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Pagos.Size = New System.Drawing.Size(220, 45)
        Me.Btn_Pagos.TabIndex = 3
        Me.Btn_Pagos.Text = "Pagos"
        Me.Btn_Pagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Pagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Pagos.UseVisualStyleBackColor = False
        '
        'Btn_Compras
        '
        Me.Btn_Compras.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Compras.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Compras.FlatAppearance.BorderSize = 0
        Me.Btn_Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Compras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Compras.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Compras.IconChar = FontAwesome.Sharp.IconChar.TruckFast
        Me.Btn_Compras.IconColor = System.Drawing.Color.White
        Me.Btn_Compras.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Compras.IconSize = 35
        Me.Btn_Compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Compras.Location = New System.Drawing.Point(0, 292)
        Me.Btn_Compras.Name = "Btn_Compras"
        Me.Btn_Compras.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Compras.Size = New System.Drawing.Size(220, 45)
        Me.Btn_Compras.TabIndex = 2
        Me.Btn_Compras.Text = "Compras"
        Me.Btn_Compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Compras.UseVisualStyleBackColor = False
        '
        'Btn_Ventas
        '
        Me.Btn_Ventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Ventas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Ventas.FlatAppearance.BorderSize = 0
        Me.Btn_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Ventas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Ventas.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Ventas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.Btn_Ventas.IconColor = System.Drawing.Color.White
        Me.Btn_Ventas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Ventas.IconSize = 35
        Me.Btn_Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Ventas.Location = New System.Drawing.Point(0, 247)
        Me.Btn_Ventas.Name = "Btn_Ventas"
        Me.Btn_Ventas.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Ventas.Size = New System.Drawing.Size(220, 45)
        Me.Btn_Ventas.TabIndex = 1
        Me.Btn_Ventas.Text = "Ventas"
        Me.Btn_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Ventas.UseVisualStyleBackColor = False
        '
        'Panel_Logo
        '
        Me.Panel_Logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel_Logo.Controls.Add(Me.PictureBox3)
        Me.Panel_Logo.Controls.Add(Me.lbl_apellidos)
        Me.Panel_Logo.Controls.Add(Me.Label1)
        Me.Panel_Logo.Controls.Add(Me.lbl_Nombre)
        Me.Panel_Logo.Controls.Add(Me.PictureBox1)
        Me.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Logo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Logo.Name = "Panel_Logo"
        Me.Panel_Logo.Size = New System.Drawing.Size(220, 247)
        Me.Panel_Logo.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.Image = Global.Presentacion.My.Resources.Resources.usuario2
        Me.PictureBox3.Location = New System.Drawing.Point(30, 175)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'lbl_apellidos
        '
        Me.lbl_apellidos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_apellidos.AutoSize = True
        Me.lbl_apellidos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_apellidos.ForeColor = System.Drawing.Color.White
        Me.lbl_apellidos.Location = New System.Drawing.Point(119, 182)
        Me.lbl_apellidos.Name = "lbl_apellidos"
        Me.lbl_apellidos.Size = New System.Drawing.Size(49, 19)
        Me.lbl_apellidos.TabIndex = 10
        Me.lbl_apellidos.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MENÚ FERRETERIA"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.White
        Me.lbl_Nombre.Location = New System.Drawing.Point(60, 182)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(49, 19)
        Me.lbl_Nombre.TabIndex = 6
        Me.lbl_Nombre.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.iconoprincipal4
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Barra_Titulo
        '
        Me.Barra_Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Barra_Titulo.Controls.Add(Me.lbl_id)
        Me.Barra_Titulo.Controls.Add(Me.lbl_link_editar)
        Me.Barra_Titulo.Controls.Add(Me.lbl_usuario)
        Me.Barra_Titulo.Controls.Add(Me.Pic_Perfil)
        Me.Barra_Titulo.Controls.Add(Me.Btn_minimizar)
        Me.Barra_Titulo.Controls.Add(Me.Btn_Cerrar)
        Me.Barra_Titulo.Controls.Add(Me.Btn_Maximizar)
        Me.Barra_Titulo.Controls.Add(Me.Title_Actual)
        Me.Barra_Titulo.Controls.Add(Me.Icon_Form_Actual)
        Me.Barra_Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barra_Titulo.Location = New System.Drawing.Point(237, 0)
        Me.Barra_Titulo.Name = "Barra_Titulo"
        Me.Barra_Titulo.Size = New System.Drawing.Size(693, 57)
        Me.Barra_Titulo.TabIndex = 1
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(710, 55)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(35, 15)
        Me.lbl_id.TabIndex = 11
        Me.lbl_id.Text = "lbl_id"
        Me.lbl_id.Visible = False
        '
        'lbl_link_editar
        '
        Me.lbl_link_editar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_link_editar.AutoSize = True
        Me.lbl_link_editar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_link_editar.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_link_editar.Location = New System.Drawing.Point(524, 34)
        Me.lbl_link_editar.Name = "lbl_link_editar"
        Me.lbl_link_editar.Size = New System.Drawing.Size(67, 15)
        Me.lbl_link_editar.TabIndex = 9
        Me.lbl_link_editar.TabStop = True
        Me.lbl_link_editar.Text = "Editar Perfil"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_usuario.ForeColor = System.Drawing.Color.White
        Me.lbl_usuario.Location = New System.Drawing.Point(550, 7)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(49, 19)
        Me.lbl_usuario.TabIndex = 8
        Me.lbl_usuario.Text = "Label2"
        '
        'Pic_Perfil
        '
        Me.Pic_Perfil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_Perfil.Image = Global.Presentacion.My.Resources.Resources.usuario2
        Me.Pic_Perfil.Location = New System.Drawing.Point(519, 8)
        Me.Pic_Perfil.Name = "Pic_Perfil"
        Me.Pic_Perfil.Size = New System.Drawing.Size(28, 19)
        Me.Pic_Perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Perfil.TabIndex = 5
        Me.Pic_Perfil.TabStop = False
        '
        'Btn_minimizar
        '
        Me.Btn_minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_minimizar.Image = Global.Presentacion.My.Resources.Resources.login_minimizar
        Me.Btn_minimizar.Location = New System.Drawing.Point(623, 7)
        Me.Btn_minimizar.Name = "Btn_minimizar"
        Me.Btn_minimizar.Size = New System.Drawing.Size(16, 16)
        Me.Btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Btn_minimizar.TabIndex = 4
        Me.Btn_minimizar.TabStop = False
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Image = Global.Presentacion.My.Resources.Resources.login_cerrar
        Me.Btn_Cerrar.Location = New System.Drawing.Point(668, 7)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(16, 16)
        Me.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Btn_Cerrar.TabIndex = 3
        Me.Btn_Cerrar.TabStop = False
        '
        'Btn_Maximizar
        '
        Me.Btn_Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Maximizar.Image = Global.Presentacion.My.Resources.Resources.compartir
        Me.Btn_Maximizar.Location = New System.Drawing.Point(645, 7)
        Me.Btn_Maximizar.Name = "Btn_Maximizar"
        Me.Btn_Maximizar.Size = New System.Drawing.Size(16, 16)
        Me.Btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Btn_Maximizar.TabIndex = 2
        Me.Btn_Maximizar.TabStop = False
        '
        'Title_Actual
        '
        Me.Title_Actual.AutoSize = True
        Me.Title_Actual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Title_Actual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Title_Actual.Location = New System.Drawing.Point(84, 22)
        Me.Title_Actual.Name = "Title_Actual"
        Me.Title_Actual.Size = New System.Drawing.Size(60, 21)
        Me.Title_Actual.TabIndex = 1
        Me.Title_Actual.Text = "INICIO"
        Me.Title_Actual.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Icon_Form_Actual
        '
        Me.Icon_Form_Actual.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Icon_Form_Actual.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.Icon_Form_Actual.IconColor = System.Drawing.Color.White
        Me.Icon_Form_Actual.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Icon_Form_Actual.IconSize = 36
        Me.Icon_Form_Actual.Location = New System.Drawing.Point(35, 14)
        Me.Icon_Form_Actual.Name = "Icon_Form_Actual"
        Me.Icon_Form_Actual.Size = New System.Drawing.Size(40, 36)
        Me.Icon_Form_Actual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_Form_Actual.TabIndex = 0
        Me.Icon_Form_Actual.TabStop = False
        '
        'Panel_Secundario
        '
        Me.Panel_Secundario.AutoSize = True
        Me.Panel_Secundario.BackColor = System.Drawing.Color.White
        Me.Panel_Secundario.Controls.Add(Me.PictureBox2)
        Me.Panel_Secundario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Secundario.Location = New System.Drawing.Point(237, 57)
        Me.Panel_Secundario.Name = "Panel_Secundario"
        Me.Panel_Secundario.Size = New System.Drawing.Size(693, 500)
        Me.Panel_Secundario.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.Presentacion.My.Resources.Resources.PANEL
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(693, 500)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Btn_Mantenimiento
        '
        Me.Btn_Mantenimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Mantenimiento.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Mantenimiento.FlatAppearance.BorderSize = 0
        Me.Btn_Mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Mantenimiento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Mantenimiento.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Mantenimiento.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.Btn_Mantenimiento.IconColor = System.Drawing.Color.White
        Me.Btn_Mantenimiento.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Mantenimiento.IconSize = 35
        Me.Btn_Mantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Mantenimiento.Location = New System.Drawing.Point(0, 427)
        Me.Btn_Mantenimiento.Name = "Btn_Mantenimiento"
        Me.Btn_Mantenimiento.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Mantenimiento.Size = New System.Drawing.Size(220, 45)
        Me.Btn_Mantenimiento.TabIndex = 5
        Me.Btn_Mantenimiento.Text = "Mantenimientos"
        Me.Btn_Mantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Mantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Mantenimiento.UseVisualStyleBackColor = False
        '
        'view_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(930, 557)
        Me.Controls.Add(Me.Panel_Secundario)
        Me.Controls.Add(Me.Barra_Titulo)
        Me.Controls.Add(Me.Panel_Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "view_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ferretería JHAYLI"
        Me.Panel_Menu.ResumeLayout(False)
        Me.Panel_Mantenimiento.ResumeLayout(False)
        Me.Panel_Logo.ResumeLayout(False)
        Me.Panel_Logo.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Barra_Titulo.ResumeLayout(False)
        Me.Barra_Titulo.PerformLayout()
        CType(Me.Pic_Perfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_Form_Actual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Secundario.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents Btn_Ventas As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Logo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Producto As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Pagos As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Compras As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Configuracion As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Barra_Titulo As Panel
    Friend WithEvents Icon_Form_Actual As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Title_Actual As Label
    Friend WithEvents Btn_minimizar As PictureBox
    Friend WithEvents Btn_Cerrar As PictureBox
    Friend WithEvents Btn_Maximizar As PictureBox
    Friend WithEvents Panel_Mantenimiento As Panel
    Friend WithEvents Btn_Proveedor As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Cliente As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Categoria As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Secundario As Panel
    Friend WithEvents Btn_Cerrar_Sesion As FontAwesome.Sharp.IconButton
    Friend WithEvents Pic_Perfil As PictureBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents lbl_link_editar As LinkLabel
    Friend WithEvents lbl_apellidos As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents btnEmpleados As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEmpleado As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btn_Mantenimiento As FontAwesome.Sharp.IconButton
End Class
