<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Rbtn_Contado = New System.Windows.Forms.RadioButton()
        Me.btn_Total_pagar = New System.Windows.Forms.Button()
        Me.Rbtn_Credito = New System.Windows.Forms.RadioButton()
        Me.Lsv_det = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnl_ini.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Cb_filtro)
        Me.GroupBox1.Controls.Add(Me.Cmb_categoria)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(500, 40)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(615, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Producto"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(81, 43)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(199, 23)
        Me.TextBox2.TabIndex = 17
        '
        'Cb_filtro
        '
        Me.Cb_filtro.AutoSize = True
        Me.Cb_filtro.Location = New System.Drawing.Point(304, 45)
        Me.Cb_filtro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cb_filtro.Name = "Cb_filtro"
        Me.Cb_filtro.Size = New System.Drawing.Size(70, 21)
        Me.Cb_filtro.TabIndex = 16
        Me.Cb_filtro.Text = "Filtrar"
        Me.Cb_filtro.UseVisualStyleBackColor = True
        '
        'Cmb_categoria
        '
        Me.Cmb_categoria.FormattingEnabled = True
        Me.Cmb_categoria.Location = New System.Drawing.Point(381, 43)
        Me.Cmb_categoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_categoria.Name = "Cmb_categoria"
        Me.Cmb_categoria.Size = New System.Drawing.Size(208, 25)
        Me.Cmb_categoria.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'lbl_idcliente
        '
        Me.lbl_idcliente.AutoSize = True
        Me.lbl_idcliente.Location = New System.Drawing.Point(358, 397)
        Me.lbl_idcliente.Name = "lbl_idcliente"
        Me.lbl_idcliente.Size = New System.Drawing.Size(54, 15)
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
        Me.GroupBox2.Location = New System.Drawing.Point(27, 418)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(452, 125)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(304, 79)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(109, 23)
        Me.DateTimePicker2.TabIndex = 32
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(90, 79)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(144, 23)
        Me.DateTimePicker1.TabIndex = 31
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Actualizar.ForeColor = System.Drawing.Color.White
        Me.Btn_Actualizar.Location = New System.Drawing.Point(304, 30)
        Me.Btn_Actualizar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(109, 29)
        Me.Btn_Actualizar.TabIndex = 8
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 37)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombre"
        '
        'Cmb_cliente
        '
        Me.Cmb_cliente.FormattingEnabled = True
        Me.Cmb_cliente.Location = New System.Drawing.Point(74, 34)
        Me.Cmb_cliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_cliente.Name = "Cmb_cliente"
        Me.Cmb_cliente.Size = New System.Drawing.Size(213, 25)
        Me.Cmb_cliente.TabIndex = 12
        '
        'pnl_ini
        '
        Me.pnl_ini.BackColor = System.Drawing.Color.Gray
        Me.pnl_ini.Controls.Add(Me.Label10)
        Me.pnl_ini.Controls.Add(Me.PictureBox1)
        Me.pnl_ini.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pnl_ini.ForeColor = System.Drawing.Color.Cornsilk
        Me.pnl_ini.Location = New System.Drawing.Point(46, 52)
        Me.pnl_ini.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_ini.Name = "pnl_ini"
        Me.pnl_ini.Size = New System.Drawing.Size(404, 330)
        Me.pnl_ini.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(22, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(316, 30)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "EL carrito de venta está vacío"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.ferreteria_icono
        Me.PictureBox1.Location = New System.Drawing.Point(98, 70)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(128, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 16)
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
        Me.Label12.Location = New System.Drawing.Point(228, 356)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 21)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "S/."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(47, 398)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 16)
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
        Me.lbl_TotalVenta.Location = New System.Drawing.Point(214, 356)
        Me.lbl_TotalVenta.Name = "lbl_TotalVenta"
        Me.lbl_TotalVenta.Size = New System.Drawing.Size(221, 28)
        Me.lbl_TotalVenta.TabIndex = 27
        Me.lbl_TotalVenta.Text = "                           0. 00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(157, 40)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 15)
        Me.Label8.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Location = New System.Drawing.Point(47, 58)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(394, 26)
        Me.Panel5.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(357, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Concepto de Pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(167, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Precio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(249, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Cantidad"
        '
        'Rbtn_Contado
        '
        Me.Rbtn_Contado.AutoSize = True
        Me.Rbtn_Contado.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Rbtn_Contado.ForeColor = System.Drawing.Color.White
        Me.Rbtn_Contado.Location = New System.Drawing.Point(166, 393)
        Me.Rbtn_Contado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Rbtn_Contado.Name = "Rbtn_Contado"
        Me.Rbtn_Contado.Size = New System.Drawing.Size(84, 24)
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
        Me.btn_Total_pagar.Location = New System.Drawing.Point(47, 355)
        Me.btn_Total_pagar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Total_pagar.Name = "btn_Total_pagar"
        Me.btn_Total_pagar.Size = New System.Drawing.Size(171, 27)
        Me.btn_Total_pagar.TabIndex = 19
        Me.btn_Total_pagar.Text = "Total a Pagar"
        Me.btn_Total_pagar.UseVisualStyleBackColor = False
        '
        'Rbtn_Credito
        '
        Me.Rbtn_Credito.AutoSize = True
        Me.Rbtn_Credito.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Rbtn_Credito.ForeColor = System.Drawing.Color.White
        Me.Rbtn_Credito.Location = New System.Drawing.Point(256, 393)
        Me.Rbtn_Credito.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Rbtn_Credito.Name = "Rbtn_Credito"
        Me.Rbtn_Credito.Size = New System.Drawing.Size(76, 24)
        Me.Rbtn_Credito.TabIndex = 17
        Me.Rbtn_Credito.TabStop = True
        Me.Rbtn_Credito.Text = "Crédito"
        Me.Rbtn_Credito.UseVisualStyleBackColor = True
        '
        'Lsv_det
        '
        Me.Lsv_det.Location = New System.Drawing.Point(46, 84)
        Me.Lsv_det.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Lsv_det.Name = "Lsv_det"
        Me.Lsv_det.Size = New System.Drawing.Size(394, 267)
        Me.Lsv_det.TabIndex = 18
        Me.Lsv_det.UseCompatibleStateImageBehavior = False
        '
        'View_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 566)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_idcliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pnl_ini)
        Me.Controls.Add(Me.Lsv_det)
        Me.Controls.Add(Me.Rbtn_Credito)
        Me.Controls.Add(Me.btn_Total_pagar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Rbtn_Contado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.lbl_TotalVenta)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
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
    Friend WithEvents lbl_TotalVenta As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Rbtn_Contado As RadioButton
    Friend WithEvents btn_Total_pagar As Button
    Friend WithEvents Rbtn_Credito As RadioButton
    Friend WithEvents Lsv_det As ListView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
