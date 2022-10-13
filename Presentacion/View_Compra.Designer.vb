<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_Compra))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dateFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboComprobante = New System.Windows.Forms.ComboBox()
        Me.cbxNombreProveedor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumeroComprobante = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxFiltroProducto = New System.Windows.Forms.ComboBox()
        Me.checkFiltro = New System.Windows.Forms.CheckBox()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAgregarCompra = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.listCompras = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.listCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-4, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 529)
        Me.Panel1.TabIndex = 0
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
        Me.Label7.Location = New System.Drawing.Point(156, 123)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "COMPRAS"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dateFechaCompra)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.comboComprobante)
        Me.GroupBox3.Controls.Add(Me.cbxNombreProveedor)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtNumeroComprobante)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtIdProveedor)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Location = New System.Drawing.Point(23, 301)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(358, 205)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PROVEEDOR"
        '
        'dateFechaCompra
        '
        Me.dateFechaCompra.Location = New System.Drawing.Point(128, 156)
        Me.dateFechaCompra.Name = "dateFechaCompra"
        Me.dateFechaCompra.Size = New System.Drawing.Size(214, 20)
        Me.dateFechaCompra.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(21, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Fecha"
        '
        'comboComprobante
        '
        Me.comboComprobante.FormattingEnabled = True
        Me.comboComprobante.Location = New System.Drawing.Point(128, 79)
        Me.comboComprobante.Name = "comboComprobante"
        Me.comboComprobante.Size = New System.Drawing.Size(214, 21)
        Me.comboComprobante.TabIndex = 17
        '
        'cbxNombreProveedor
        '
        Me.cbxNombreProveedor.FormattingEnabled = True
        Me.cbxNombreProveedor.Location = New System.Drawing.Point(128, 42)
        Me.cbxNombreProveedor.Name = "cbxNombreProveedor"
        Me.cbxNombreProveedor.Size = New System.Drawing.Size(214, 21)
        Me.cbxNombreProveedor.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(22, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "N°"
        '
        'txtNumeroComprobante
        '
        Me.txtNumeroComprobante.Location = New System.Drawing.Point(128, 118)
        Me.txtNumeroComprobante.Name = "txtNumeroComprobante"
        Me.txtNumeroComprobante.Size = New System.Drawing.Size(214, 20)
        Me.txtNumeroComprobante.TabIndex = 21
        Me.txtNumeroComprobante.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(22, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Comprobante"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(21, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Nombre"
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Location = New System.Drawing.Point(128, 16)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.Size = New System.Drawing.Size(181, 20)
        Me.txtIdProveedor.TabIndex = 2
        Me.txtIdProveedor.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(21, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "idproveedor"
        Me.Label2.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbxFiltroProducto)
        Me.GroupBox2.Controls.Add(Me.checkFiltro)
        Me.GroupBox2.Controls.Add(Me.txtBuscarProducto)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Location = New System.Drawing.Point(23, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 114)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BUSCAR PRODUCTO"
        '
        'cbxFiltroProducto
        '
        Me.cbxFiltroProducto.FormattingEnabled = True
        Me.cbxFiltroProducto.Location = New System.Drawing.Point(106, 78)
        Me.cbxFiltroProducto.Name = "cbxFiltroProducto"
        Me.cbxFiltroProducto.Size = New System.Drawing.Size(230, 21)
        Me.cbxFiltroProducto.TabIndex = 16
        '
        'checkFiltro
        '
        Me.checkFiltro.AutoSize = True
        Me.checkFiltro.Location = New System.Drawing.Point(23, 78)
        Me.checkFiltro.Name = "checkFiltro"
        Me.checkFiltro.Size = New System.Drawing.Size(58, 17)
        Me.checkFiltro.TabIndex = 16
        Me.checkFiltro.Text = "Filtrar"
        Me.checkFiltro.UseVisualStyleBackColor = True
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.Location = New System.Drawing.Point(106, 29)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(230, 20)
        Me.txtBuscarProducto.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar"
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnAgregarCompra)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(403, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(383, 523)
        Me.Panel2.TabIndex = 15
        '
        'btnAgregarCompra
        '
        Me.btnAgregarCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnAgregarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAgregarCompra.ForeColor = System.Drawing.Color.White
        Me.btnAgregarCompra.Location = New System.Drawing.Point(256, 457)
        Me.btnAgregarCompra.Name = "btnAgregarCompra"
        Me.btnAgregarCompra.Size = New System.Drawing.Size(87, 33)
        Me.btnAgregarCompra.TabIndex = 11
        Me.btnAgregarCompra.Text = "Agregar"
        Me.btnAgregarCompra.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSubTotal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.listCompras)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Location = New System.Drawing.Point(17, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 368)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTA DE COMPRAS"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(228, 312)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(98, 20)
        Me.txtSubTotal.TabIndex = 17
        Me.txtSubTotal.Text = "0.00"
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(152, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "SubTotal"
        '
        'listCompras
        '
        Me.listCompras.AllowUserToAddRows = False
        Me.listCompras.AllowUserToDeleteRows = False
        Me.listCompras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.listCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listCompras.Location = New System.Drawing.Point(22, 31)
        Me.listCompras.Name = "listCompras"
        Me.listCompras.ReadOnly = True
        Me.listCompras.RowHeadersVisible = False
        Me.listCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listCompras.Size = New System.Drawing.Size(304, 259)
        Me.listCompras.TabIndex = 0
        '
        'View_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 520)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "View_Compra"
        Me.Text = "COMPRA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.listCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents listCompras As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBuscarProducto As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtIdProveedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxFiltroProducto As ComboBox
    Friend WithEvents checkFiltro As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dateFechaCompra As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents comboComprobante As ComboBox
    Friend WithEvents cbxNombreProveedor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumeroComprobante As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAgregarCompra As Button
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label8 As Label
End Class
