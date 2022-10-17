<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Pagos
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
        Me.GroupBox_Pagos = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_id_cliente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cb_nombre_cliente = New System.Windows.Forms.ComboBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.Label()
        Me.monto = New System.Windows.Forms.Label()
        Me.lbl_monto_total = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Btn_Pagar = New System.Windows.Forms.Button()
        Me.GroupBox_Pagos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox_Pagos
        '
        Me.GroupBox_Pagos.Controls.Add(Me.Button1)
        Me.GroupBox_Pagos.Controls.Add(Me.Label2)
        Me.GroupBox_Pagos.Controls.Add(Me.lbl_id_cliente)
        Me.GroupBox_Pagos.Controls.Add(Me.Label1)
        Me.GroupBox_Pagos.Controls.Add(Me.Cb_nombre_cliente)
        Me.GroupBox_Pagos.Controls.Add(Me.Nombre)
        Me.GroupBox_Pagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox_Pagos.ForeColor = System.Drawing.Color.White
        Me.GroupBox_Pagos.Location = New System.Drawing.Point(22, 10)
        Me.GroupBox_Pagos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox_Pagos.Name = "GroupBox_Pagos"
        Me.GroupBox_Pagos.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox_Pagos.Size = New System.Drawing.Size(619, 76)
        Me.GroupBox_Pagos.TabIndex = 3
        Me.GroupBox_Pagos.TabStop = False
        Me.GroupBox_Pagos.Text = "Detalles Cliente"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(430, 22)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 34)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(565, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 8
        '
        'lbl_id_cliente
        '
        Me.lbl_id_cliente.AutoSize = True
        Me.lbl_id_cliente.Location = New System.Drawing.Point(565, 39)
        Me.lbl_id_cliente.Name = "lbl_id_cliente"
        Me.lbl_id_cliente.Size = New System.Drawing.Size(0, 17)
        Me.lbl_id_cliente.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(537, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Código"
        '
        'Cb_nombre_cliente
        '
        Me.Cb_nombre_cliente.FormattingEnabled = True
        Me.Cb_nombre_cliente.Location = New System.Drawing.Point(110, 28)
        Me.Cb_nombre_cliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cb_nombre_cliente.Name = "Cb_nombre_cliente"
        Me.Cb_nombre_cliente.Size = New System.Drawing.Size(304, 25)
        Me.Cb_nombre_cliente.TabIndex = 5
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(31, 30)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(64, 17)
        Me.Nombre.TabIndex = 4
        Me.Nombre.Text = "Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idVenta, Me.idProducto, Me.importe})
        Me.DataGridView1.Location = New System.Drawing.Point(36, 110)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(388, 260)
        Me.DataGridView1.TabIndex = 4
        '
        'idVenta
        '
        Me.idVenta.DataPropertyName = "Id_Venta"
        Me.idVenta.HeaderText = "idVenta"
        Me.idVenta.MinimumWidth = 6
        Me.idVenta.Name = "idVenta"
        Me.idVenta.ReadOnly = True
        Me.idVenta.Width = 125
        '
        'idProducto
        '
        Me.idProducto.DataPropertyName = "idproducto"
        Me.idProducto.HeaderText = "idProducto"
        Me.idProducto.MinimumWidth = 6
        Me.idProducto.Name = "idProducto"
        Me.idProducto.ReadOnly = True
        Me.idProducto.Width = 125
        '
        'importe
        '
        Me.importe.DataPropertyName = "importe"
        Me.importe.HeaderText = "importe"
        Me.importe.MinimumWidth = 6
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        Me.importe.Width = 125
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.total.ForeColor = System.Drawing.Color.White
        Me.total.Location = New System.Drawing.Point(464, 185)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(68, 25)
        Me.total.TabIndex = 8
        Me.total.Text = "TOTAL"
        '
        'monto
        '
        Me.monto.AutoSize = True
        Me.monto.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.monto.ForeColor = System.Drawing.Color.White
        Me.monto.Location = New System.Drawing.Point(464, 236)
        Me.monto.Name = "monto"
        Me.monto.Size = New System.Drawing.Size(83, 25)
        Me.monto.TabIndex = 9
        Me.monto.Text = "MONTO"
        '
        'lbl_monto_total
        '
        Me.lbl_monto_total.AutoSize = True
        Me.lbl_monto_total.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_monto_total.ForeColor = System.Drawing.Color.White
        Me.lbl_monto_total.Location = New System.Drawing.Point(566, 185)
        Me.lbl_monto_total.Name = "lbl_monto_total"
        Me.lbl_monto_total.Size = New System.Drawing.Size(68, 25)
        Me.lbl_monto_total.TabIndex = 10
        Me.lbl_monto_total.Text = "TOTAL"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown1.Location = New System.Drawing.Point(566, 236)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(89, 32)
        Me.NumericUpDown1.TabIndex = 11
        '
        'Btn_Pagar
        '
        Me.Btn_Pagar.BackColor = System.Drawing.Color.Blue
        Me.Btn_Pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Pagar.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Pagar.ForeColor = System.Drawing.Color.White
        Me.Btn_Pagar.Location = New System.Drawing.Point(508, 308)
        Me.Btn_Pagar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Pagar.Name = "Btn_Pagar"
        Me.Btn_Pagar.Size = New System.Drawing.Size(102, 31)
        Me.Btn_Pagar.TabIndex = 12
        Me.Btn_Pagar.Text = "Pagar"
        Me.Btn_Pagar.UseVisualStyleBackColor = False
        '
        'View_Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 419)
        Me.Controls.Add(Me.Btn_Pagar)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.lbl_monto_total)
        Me.Controls.Add(Me.monto)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox_Pagos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "View_Pagos"
        Me.Text = "PAGOS"
        Me.GroupBox_Pagos.ResumeLayout(False)
        Me.GroupBox_Pagos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox_Pagos As GroupBox
    Friend WithEvents Nombre As Label
    Friend WithEvents Cb_nombre_cliente As ComboBox
    Friend WithEvents lbl_id_cliente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents total As Label
    Friend WithEvents monto As Label
    Friend WithEvents lbl_monto_total As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Btn_Pagar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents idVenta As DataGridViewTextBoxColumn
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents importe As DataGridViewTextBoxColumn
End Class
