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
        Me.LabelIdProveedor = New System.Windows.Forms.Label()
        Me.dateFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboComprobante = New System.Windows.Forms.ComboBox()
        Me.cbxNombreProveedor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumeroComprobante = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxFiltroProducto = New System.Windows.Forms.ComboBox()
        Me.checkFiltro = New System.Windows.Forms.CheckBox()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAgregarCompra = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckPorcentaje = New System.Windows.Forms.CheckBox()
        Me.CheckIgv = New System.Windows.Forms.CheckBox()
        Me.LabelImporteTotal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabelPorcentaje = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelIgv = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelSubTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.listCompras = New System.Windows.Forms.ListView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 656)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(172, 39)
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
        Me.Label7.Location = New System.Drawing.Point(190, 156)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "COMPRAS"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelIdProveedor)
        Me.GroupBox3.Controls.Add(Me.dateFechaCompra)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.comboComprobante)
        Me.GroupBox3.Controls.Add(Me.cbxNombreProveedor)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtNumeroComprobante)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Location = New System.Drawing.Point(44, 404)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(358, 205)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PROVEEDOR"
        '
        'LabelIdProveedor
        '
        Me.LabelIdProveedor.AutoSize = True
        Me.LabelIdProveedor.Location = New System.Drawing.Point(126, 17)
        Me.LabelIdProveedor.Name = "LabelIdProveedor"
        Me.LabelIdProveedor.Size = New System.Drawing.Size(45, 13)
        Me.LabelIdProveedor.TabIndex = 25
        Me.LabelIdProveedor.Text = "Label9"
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
        Me.GroupBox2.Location = New System.Drawing.Point(44, 236)
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
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnAgregarCompra)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(452, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(512, 650)
        Me.Panel2.TabIndex = 15
        '
        'btnAgregarCompra
        '
        Me.btnAgregarCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnAgregarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAgregarCompra.ForeColor = System.Drawing.Color.White
        Me.btnAgregarCompra.Location = New System.Drawing.Point(346, 560)
        Me.btnAgregarCompra.Name = "btnAgregarCompra"
        Me.btnAgregarCompra.Size = New System.Drawing.Size(87, 33)
        Me.btnAgregarCompra.TabIndex = 11
        Me.btnAgregarCompra.Text = "Agregar"
        Me.btnAgregarCompra.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.listCompras)
        Me.GroupBox1.Controls.Add(Me.CheckPorcentaje)
        Me.GroupBox1.Controls.Add(Me.CheckIgv)
        Me.GroupBox1.Controls.Add(Me.LabelImporteTotal)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.LabelPorcentaje)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.LabelIgv)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.LabelSubTotal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Location = New System.Drawing.Point(91, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 451)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTA DE COMPRAS"
        '
        'CheckPorcentaje
        '
        Me.CheckPorcentaje.AutoSize = True
        Me.CheckPorcentaje.Location = New System.Drawing.Point(43, 384)
        Me.CheckPorcentaje.Name = "CheckPorcentaje"
        Me.CheckPorcentaje.Size = New System.Drawing.Size(42, 17)
        Me.CheckPorcentaje.TabIndex = 26
        Me.CheckPorcentaje.Text = "2%"
        Me.CheckPorcentaje.UseVisualStyleBackColor = True
        '
        'CheckIgv
        '
        Me.CheckIgv.AutoSize = True
        Me.CheckIgv.Location = New System.Drawing.Point(43, 347)
        Me.CheckIgv.Name = "CheckIgv"
        Me.CheckIgv.Size = New System.Drawing.Size(47, 17)
        Me.CheckIgv.TabIndex = 25
        Me.CheckIgv.Text = "IGV"
        Me.CheckIgv.UseVisualStyleBackColor = True
        '
        'LabelImporteTotal
        '
        Me.LabelImporteTotal.AutoSize = True
        Me.LabelImporteTotal.Location = New System.Drawing.Point(281, 414)
        Me.LabelImporteTotal.Name = "LabelImporteTotal"
        Me.LabelImporteTotal.Size = New System.Drawing.Size(32, 13)
        Me.LabelImporteTotal.TabIndex = 24
        Me.LabelImporteTotal.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(152, 414)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Importe Total"
        '
        'LabelPorcentaje
        '
        Me.LabelPorcentaje.AutoSize = True
        Me.LabelPorcentaje.Location = New System.Drawing.Point(281, 385)
        Me.LabelPorcentaje.Name = "LabelPorcentaje"
        Me.LabelPorcentaje.Size = New System.Drawing.Size(32, 13)
        Me.LabelPorcentaje.TabIndex = 22
        Me.LabelPorcentaje.Text = "0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(152, 385)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "2%"
        '
        'LabelIgv
        '
        Me.LabelIgv.AutoSize = True
        Me.LabelIgv.Location = New System.Drawing.Point(281, 348)
        Me.LabelIgv.Name = "LabelIgv"
        Me.LabelIgv.Size = New System.Drawing.Size(32, 13)
        Me.LabelIgv.TabIndex = 20
        Me.LabelIgv.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(152, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "IGV 18%"
        '
        'LabelSubTotal
        '
        Me.LabelSubTotal.AutoSize = True
        Me.LabelSubTotal.Location = New System.Drawing.Point(281, 316)
        Me.LabelSubTotal.Name = "LabelSubTotal"
        Me.LabelSubTotal.Size = New System.Drawing.Size(32, 13)
        Me.LabelSubTotal.TabIndex = 18
        Me.LabelSubTotal.Text = "0.00"
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
        Me.listCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.listCompras.Location = New System.Drawing.Point(30, 33)
        Me.listCompras.Name = "listCompras"
        Me.listCompras.Size = New System.Drawing.Size(283, 259)
        Me.listCompras.TabIndex = 27
        Me.listCompras.UseCompatibleStateImageBehavior = False
        '
        'View_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 656)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBuscarProducto As TextBox
    Friend WithEvents GroupBox3 As GroupBox
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
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelIgv As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LabelSubTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CheckPorcentaje As CheckBox
    Friend WithEvents CheckIgv As CheckBox
    Friend WithEvents LabelImporteTotal As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LabelPorcentaje As Label
    Friend WithEvents LabelIdProveedor As Label
    Friend WithEvents listCompras As ListView
End Class
