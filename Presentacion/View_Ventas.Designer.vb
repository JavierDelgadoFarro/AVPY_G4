﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_Ventas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cb_filtro = New System.Windows.Forms.CheckBox()
        Me.Cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Cmb_Producto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Total_pagar = New System.Windows.Forms.Button()
        Me.Lsv_det = New System.Windows.Forms.ListView()
        Me.Rbtn_Credito = New System.Windows.Forms.RadioButton()
        Me.Rbtn_Contado = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 746)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Location = New System.Drawing.Point(499, -1)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(636, 757)
        Me.Panel3.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cb_filtro)
        Me.GroupBox1.Controls.Add(Me.Cmb_categoria)
        Me.GroupBox1.Controls.Add(Me.Cmb_Producto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(45, 31)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(504, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Producto"
        '
        'Cb_filtro
        '
        Me.Cb_filtro.AutoSize = True
        Me.Cb_filtro.Location = New System.Drawing.Point(252, 64)
        Me.Cb_filtro.Name = "Cb_filtro"
        Me.Cb_filtro.Size = New System.Drawing.Size(82, 24)
        Me.Cb_filtro.TabIndex = 16
        Me.Cb_filtro.Text = "Filtrar"
        Me.Cb_filtro.UseVisualStyleBackColor = True
        '
        'Cmb_categoria
        '
        Me.Cmb_categoria.FormattingEnabled = True
        Me.Cmb_categoria.Location = New System.Drawing.Point(340, 58)
        Me.Cmb_categoria.Name = "Cmb_categoria"
        Me.Cmb_categoria.Size = New System.Drawing.Size(149, 28)
        Me.Cmb_categoria.TabIndex = 15
        '
        'Cmb_Producto
        '
        Me.Cmb_Producto.FormattingEnabled = True
        Me.Cmb_Producto.Location = New System.Drawing.Point(86, 60)
        Me.Cmb_Producto.Name = "Cmb_Producto"
        Me.Cmb_Producto.Size = New System.Drawing.Size(149, 28)
        Me.Cmb_Producto.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buscar"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.btn_Total_pagar)
        Me.Panel2.Controls.Add(Me.Lsv_det)
        Me.Panel2.Controls.Add(Me.Rbtn_Credito)
        Me.Panel2.Controls.Add(Me.Rbtn_Contado)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-2, -1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(502, 748)
        Me.Panel2.TabIndex = 2
        '
        'btn_Total_pagar
        '
        Me.btn_Total_pagar.BackColor = System.Drawing.Color.Blue
        Me.btn_Total_pagar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btn_Total_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Total_pagar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Total_pagar.ForeColor = System.Drawing.Color.White
        Me.btn_Total_pagar.Location = New System.Drawing.Point(42, 475)
        Me.btn_Total_pagar.Name = "btn_Total_pagar"
        Me.btn_Total_pagar.Size = New System.Drawing.Size(195, 36)
        Me.btn_Total_pagar.TabIndex = 19
        Me.btn_Total_pagar.Text = "Total a Pagar"
        Me.btn_Total_pagar.UseVisualStyleBackColor = False
        '
        'Lsv_det
        '
        Me.Lsv_det.Location = New System.Drawing.Point(42, 114)
        Me.Lsv_det.Name = "Lsv_det"
        Me.Lsv_det.Size = New System.Drawing.Size(396, 355)
        Me.Lsv_det.TabIndex = 18
        Me.Lsv_det.UseCompatibleStateImageBehavior = False
        '
        'Rbtn_Credito
        '
        Me.Rbtn_Credito.AutoSize = True
        Me.Rbtn_Credito.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Rbtn_Credito.ForeColor = System.Drawing.Color.White
        Me.Rbtn_Credito.Location = New System.Drawing.Point(299, 527)
        Me.Rbtn_Credito.Name = "Rbtn_Credito"
        Me.Rbtn_Credito.Size = New System.Drawing.Size(91, 29)
        Me.Rbtn_Credito.TabIndex = 17
        Me.Rbtn_Credito.TabStop = True
        Me.Rbtn_Credito.Text = "Crédito"
        Me.Rbtn_Credito.UseVisualStyleBackColor = True
        '
        'Rbtn_Contado
        '
        Me.Rbtn_Contado.AutoSize = True
        Me.Rbtn_Contado.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Rbtn_Contado.ForeColor = System.Drawing.Color.White
        Me.Rbtn_Contado.Location = New System.Drawing.Point(178, 526)
        Me.Rbtn_Contado.Name = "Rbtn_Contado"
        Me.Rbtn_Contado.Size = New System.Drawing.Size(102, 29)
        Me.Rbtn_Contado.TabIndex = 16
        Me.Rbtn_Contado.TabStop = True
        Me.Rbtn_Contado.Text = "Contado"
        Me.Rbtn_Contado.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Cmb_cliente)
        Me.Panel4.Controls.Add(Me.Btn_Actualizar)
        Me.Panel4.Location = New System.Drawing.Point(35, 565)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(423, 168)
        Me.Panel4.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(31, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombre"
        '
        'Cmb_cliente
        '
        Me.Cmb_cliente.FormattingEnabled = True
        Me.Cmb_cliente.Location = New System.Drawing.Point(160, 29)
        Me.Cmb_cliente.Name = "Cmb_cliente"
        Me.Cmb_cliente.Size = New System.Drawing.Size(243, 28)
        Me.Cmb_cliente.TabIndex = 12
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Actualizar.ForeColor = System.Drawing.Color.White
        Me.Btn_Actualizar.Location = New System.Drawing.Point(19, 87)
        Me.Btn_Actualizar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(121, 48)
        Me.Btn_Actualizar.TabIndex = 8
        Me.Btn_Actualizar.Text = "Modificar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(167, 56)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 20)
        Me.Label8.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(42, 532)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo de Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(105, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DETALLE DE FACTURACIÓN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 25)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Concepto de Pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(178, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Precio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(355, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 25)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Id"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(249, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 25)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Cantidad"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Location = New System.Drawing.Point(42, 79)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(396, 35)
        Me.Panel5.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Blue
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(233, 476)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(204, 35)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "                   0. 00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Blue
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(249, 478)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 28)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "S/."
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gray
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.PictureBox1)
        Me.Panel6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Panel6.ForeColor = System.Drawing.Color.Cornsilk
        Me.Panel6.Location = New System.Drawing.Point(35, 71)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(423, 440)
        Me.Panel6.TabIndex = 29
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.ferreteria_icono
        Me.PictureBox1.Location = New System.Drawing.Point(95, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(0, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(398, 38)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "EL carrito de venta está vacío"
        '
        'View_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 746)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "View_Ventas"
        Me.Text = "View_Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Cmb_cliente As ComboBox
    Friend WithEvents Cmb_categoria As ComboBox
    Friend WithEvents Cmb_Producto As ComboBox
    Friend WithEvents Rbtn_Credito As RadioButton
    Friend WithEvents Rbtn_Contado As RadioButton
    Friend WithEvents Cb_filtro As CheckBox
    Friend WithEvents btn_Total_pagar As Button
    Friend WithEvents Lsv_det As ListView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class