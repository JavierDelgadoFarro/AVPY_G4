<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_Principal))
        Me.Panel_Menu = New System.Windows.Forms.Panel()
        Me.Btn_Configuracion = New FontAwesome.Sharp.IconButton()
        Me.Btn_Mantenimiento = New FontAwesome.Sharp.IconButton()
        Me.Btn_Producto = New FontAwesome.Sharp.IconButton()
        Me.Btn_Pagos = New FontAwesome.Sharp.IconButton()
        Me.Btn_Compras = New FontAwesome.Sharp.IconButton()
        Me.Btn_Ventas = New FontAwesome.Sharp.IconButton()
        Me.Panel_Logo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Barra_Titulo = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel_Menu.SuspendLayout()
        Me.Panel_Logo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Barra_Titulo.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Menu
        '
        Me.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel_Menu.Controls.Add(Me.Btn_Configuracion)
        Me.Panel_Menu.Controls.Add(Me.Btn_Mantenimiento)
        Me.Panel_Menu.Controls.Add(Me.Btn_Producto)
        Me.Panel_Menu.Controls.Add(Me.Btn_Pagos)
        Me.Panel_Menu.Controls.Add(Me.Btn_Compras)
        Me.Panel_Menu.Controls.Add(Me.Btn_Ventas)
        Me.Panel_Menu.Controls.Add(Me.Panel_Logo)
        Me.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(220, 469)
        Me.Panel_Menu.TabIndex = 0
        '
        'Btn_Configuracion
        '
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
        Me.Btn_Configuracion.Location = New System.Drawing.Point(0, 395)
        Me.Btn_Configuracion.Name = "Btn_Configuracion"
        Me.Btn_Configuracion.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Configuracion.Size = New System.Drawing.Size(220, 43)
        Me.Btn_Configuracion.TabIndex = 6
        Me.Btn_Configuracion.Text = "Configuraciones"
        Me.Btn_Configuracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Configuracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Configuracion.UseVisualStyleBackColor = True
        '
        'Btn_Mantenimiento
        '
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
        Me.Btn_Mantenimiento.Location = New System.Drawing.Point(0, 352)
        Me.Btn_Mantenimiento.Name = "Btn_Mantenimiento"
        Me.Btn_Mantenimiento.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Mantenimiento.Size = New System.Drawing.Size(220, 43)
        Me.Btn_Mantenimiento.TabIndex = 5
        Me.Btn_Mantenimiento.Text = "Mantenimientos"
        Me.Btn_Mantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Mantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Mantenimiento.UseVisualStyleBackColor = True
        '
        'Btn_Producto
        '
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
        Me.Btn_Producto.Location = New System.Drawing.Point(0, 309)
        Me.Btn_Producto.Name = "Btn_Producto"
        Me.Btn_Producto.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Producto.Size = New System.Drawing.Size(220, 43)
        Me.Btn_Producto.TabIndex = 4
        Me.Btn_Producto.Text = "Productos"
        Me.Btn_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Producto.UseVisualStyleBackColor = True
        '
        'Btn_Pagos
        '
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
        Me.Btn_Pagos.Location = New System.Drawing.Point(0, 266)
        Me.Btn_Pagos.Name = "Btn_Pagos"
        Me.Btn_Pagos.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Pagos.Size = New System.Drawing.Size(220, 43)
        Me.Btn_Pagos.TabIndex = 3
        Me.Btn_Pagos.Text = "Pagos"
        Me.Btn_Pagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Pagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Pagos.UseVisualStyleBackColor = True
        '
        'Btn_Compras
        '
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
        Me.Btn_Compras.Location = New System.Drawing.Point(0, 223)
        Me.Btn_Compras.Name = "Btn_Compras"
        Me.Btn_Compras.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Compras.Size = New System.Drawing.Size(220, 43)
        Me.Btn_Compras.TabIndex = 2
        Me.Btn_Compras.Text = "Compras"
        Me.Btn_Compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Compras.UseVisualStyleBackColor = True
        '
        'Btn_Ventas
        '
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
        Me.Btn_Ventas.Location = New System.Drawing.Point(0, 180)
        Me.Btn_Ventas.Name = "Btn_Ventas"
        Me.Btn_Ventas.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Ventas.Size = New System.Drawing.Size(220, 43)
        Me.Btn_Ventas.TabIndex = 1
        Me.Btn_Ventas.Text = "Ventas Javier "
        Me.Btn_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Ventas.UseVisualStyleBackColor = True
        '
        'Panel_Logo
        '
        Me.Panel_Logo.Controls.Add(Me.Label1)
        Me.Panel_Logo.Controls.Add(Me.PictureBox1)
        Me.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Logo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Logo.Name = "Panel_Logo"
        Me.Panel_Logo.Size = New System.Drawing.Size(220, 180)
        Me.Panel_Logo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lo mejor para tu Hogar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Barra_Titulo
        '
        Me.Barra_Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Barra_Titulo.Controls.Add(Me.IconPictureBox1)
        Me.Barra_Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barra_Titulo.Location = New System.Drawing.Point(220, 0)
        Me.Barra_Titulo.Name = "Barra_Titulo"
        Me.Barra_Titulo.Size = New System.Drawing.Size(743, 69)
        Me.Barra_Titulo.TabIndex = 1
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.Location = New System.Drawing.Point(34, 25)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'view_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 469)
        Me.Controls.Add(Me.Barra_Titulo)
        Me.Controls.Add(Me.Panel_Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "view_Principal"
        Me.Text = "view_Principal"
        Me.Panel_Menu.ResumeLayout(False)
        Me.Panel_Logo.ResumeLayout(False)
        Me.Panel_Logo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Barra_Titulo.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents Btn_Ventas As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Logo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Producto As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Pagos As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Compras As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Mantenimiento As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Configuracion As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Barra_Titulo As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
End Class
