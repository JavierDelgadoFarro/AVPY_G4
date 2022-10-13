<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Detalle_Producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_Detalle_Producto))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCantidadProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAceptarDetalleProducto = New System.Windows.Forms.Button()
        Me.btnCancelarDetalleProducto = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.precioProducto = New System.Windows.Forms.DomainUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStockProductos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.listDetalleProducto = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.listDetalleProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtCantidadProducto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnAceptarDetalleProducto)
        Me.Panel1.Controls.Add(Me.btnCancelarDetalleProducto)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 426)
        Me.Panel1.TabIndex = 2
        '
        'txtCantidadProducto
        '
        Me.txtCantidadProducto.Location = New System.Drawing.Point(129, 279)
        Me.txtCantidadProducto.Name = "txtCantidadProducto"
        Me.txtCantidadProducto.Size = New System.Drawing.Size(230, 23)
        Me.txtCantidadProducto.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(44, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cantidad"
        '
        'btnAceptarDetalleProducto
        '
        Me.btnAceptarDetalleProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnAceptarDetalleProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarDetalleProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAceptarDetalleProducto.ForeColor = System.Drawing.Color.White
        Me.btnAceptarDetalleProducto.Location = New System.Drawing.Point(87, 363)
        Me.btnAceptarDetalleProducto.Name = "btnAceptarDetalleProducto"
        Me.btnAceptarDetalleProducto.Size = New System.Drawing.Size(87, 33)
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
        Me.btnCancelarDetalleProducto.Location = New System.Drawing.Point(227, 363)
        Me.btnCancelarDetalleProducto.Name = "btnCancelarDetalleProducto"
        Me.btnCancelarDetalleProducto.Size = New System.Drawing.Size(87, 33)
        Me.btnCancelarDetalleProducto.TabIndex = 11
        Me.btnCancelarDetalleProducto.Text = "Cancelar"
        Me.btnCancelarDetalleProducto.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(138, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(112, 128)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "DETALLE DE PRODUCTOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.precioProducto)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtStockProductos)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Location = New System.Drawing.Point(23, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 154)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'precioProducto
        '
        Me.precioProducto.Location = New System.Drawing.Point(106, 71)
        Me.precioProducto.Name = "precioProducto"
        Me.precioProducto.Size = New System.Drawing.Size(230, 20)
        Me.precioProducto.TabIndex = 4
        Me.precioProducto.Text = "1,00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(21, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Precio"
        '
        'txtStockProductos
        '
        Me.txtStockProductos.Location = New System.Drawing.Point(106, 29)
        Me.txtStockProductos.Name = "txtStockProductos"
        Me.txtStockProductos.Size = New System.Drawing.Size(230, 20)
        Me.txtStockProductos.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock"
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(403, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(383, 426)
        Me.Panel2.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.listDetalleProducto)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Location = New System.Drawing.Point(19, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 368)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTA DE DETALLE DE PRODUCTOS"
        '
        'listDetalleProducto
        '
        Me.listDetalleProducto.AllowUserToAddRows = False
        Me.listDetalleProducto.AllowUserToDeleteRows = False
        Me.listDetalleProducto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.listDetalleProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listDetalleProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listDetalleProducto.Location = New System.Drawing.Point(22, 31)
        Me.listDetalleProducto.Name = "listDetalleProducto"
        Me.listDetalleProducto.ReadOnly = True
        Me.listDetalleProducto.RowHeadersVisible = False
        Me.listDetalleProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listDetalleProducto.Size = New System.Drawing.Size(304, 317)
        Me.listDetalleProducto.TabIndex = 0
        '
        'View_Detalle_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 425)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "View_Detalle_Producto"
        Me.Text = "View_Detalle_Producto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.listDetalleProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCantidadProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAceptarDetalleProducto As Button
    Friend WithEvents btnCancelarDetalleProducto As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents precioProducto As DomainUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents txtStockProductos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents listDetalleProducto As DataGridView
End Class
