﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mantenimiento_Categoria
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btneliminarcategoria = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_buscarcategoria = New System.Windows.Forms.Button()
        Me.DGV_Categoria = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtbuscarcategoria = New System.Windows.Forms.TextBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnmodificarcategoria = New System.Windows.Forms.Button()
        Me.btnnuevacategoria = New System.Windows.Forms.Button()
        Me.txtdescripcioncategoria = New System.Windows.Forms.TextBox()
        Me.txtnombrecategoria = New System.Windows.Forms.TextBox()
        Me.labelidcategoria = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btneliminarcategoria)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.IconPictureBox1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnmodificarcategoria)
        Me.Panel2.Controls.Add(Me.btnnuevacategoria)
        Me.Panel2.Controls.Add(Me.txtdescripcioncategoria)
        Me.Panel2.Controls.Add(Me.txtnombrecategoria)
        Me.Panel2.Controls.Add(Me.labelidcategoria)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 511)
        Me.Panel2.TabIndex = 1
        '
        'btneliminarcategoria
        '
        Me.btneliminarcategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btneliminarcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminarcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btneliminarcategoria.ForeColor = System.Drawing.Color.White
        Me.btneliminarcategoria.Location = New System.Drawing.Point(659, 432)
        Me.btneliminarcategoria.Name = "btneliminarcategoria"
        Me.btneliminarcategoria.Size = New System.Drawing.Size(99, 35)
        Me.btneliminarcategoria.TabIndex = 13
        Me.btneliminarcategoria.Text = "Eliminar"
        Me.btneliminarcategoria.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_buscarcategoria)
        Me.GroupBox1.Controls.Add(Me.DGV_Categoria)
        Me.GroupBox1.Controls.Add(Me.txtbuscarcategoria)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Location = New System.Drawing.Point(304, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 383)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTA DE CATEGORÍAS"
        '
        'btn_buscarcategoria
        '
        Me.btn_buscarcategoria.BackColor = System.Drawing.Color.Blue
        Me.btn_buscarcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_buscarcategoria.ForeColor = System.Drawing.Color.White
        Me.btn_buscarcategoria.Location = New System.Drawing.Point(321, 33)
        Me.btn_buscarcategoria.Name = "btn_buscarcategoria"
        Me.btn_buscarcategoria.Size = New System.Drawing.Size(76, 26)
        Me.btn_buscarcategoria.TabIndex = 14
        Me.btn_buscarcategoria.Text = "Buscar"
        Me.btn_buscarcategoria.UseVisualStyleBackColor = False
        '
        'DGV_Categoria
        '
        Me.DGV_Categoria.AllowUserToAddRows = False
        Me.DGV_Categoria.AllowUserToDeleteRows = False
        Me.DGV_Categoria.BackgroundColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Categoria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Categoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Categoria.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Categoria.Location = New System.Drawing.Point(16, 74)
        Me.DGV_Categoria.Name = "DGV_Categoria"
        Me.DGV_Categoria.ReadOnly = True
        Me.DGV_Categoria.RowHeadersVisible = False
        Me.DGV_Categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Categoria.Size = New System.Drawing.Size(418, 288)
        Me.DGV_Categoria.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "idcategoria"
        Me.Column1.HeaderText = "idcategoria"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 102
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nombre"
        Me.Column2.HeaderText = "nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "descripcion"
        Me.Column3.HeaderText = "descripcion"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 193
        '
        'txtbuscarcategoria
        '
        Me.txtbuscarcategoria.Location = New System.Drawing.Point(46, 37)
        Me.txtbuscarcategoria.Name = "txtbuscarcategoria"
        Me.txtbuscarcategoria.Size = New System.Drawing.Size(262, 20)
        Me.txtbuscarcategoria.TabIndex = 2
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ThList
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 67
        Me.IconPictureBox1.Location = New System.Drawing.Point(117, 40)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(67, 71)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox1.TabIndex = 11
        Me.IconPictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(28, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(249, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "MANTENIMIENTO DE CATEGORÍA"
        '
        'btnmodificarcategoria
        '
        Me.btnmodificarcategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnmodificarcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnmodificarcategoria.ForeColor = System.Drawing.Color.White
        Me.btnmodificarcategoria.Location = New System.Drawing.Point(171, 295)
        Me.btnmodificarcategoria.Name = "btnmodificarcategoria"
        Me.btnmodificarcategoria.Size = New System.Drawing.Size(99, 35)
        Me.btnmodificarcategoria.TabIndex = 9
        Me.btnmodificarcategoria.Text = "Modificar"
        Me.btnmodificarcategoria.UseVisualStyleBackColor = False
        '
        'btnnuevacategoria
        '
        Me.btnnuevacategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnnuevacategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevacategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnnuevacategoria.ForeColor = System.Drawing.Color.White
        Me.btnnuevacategoria.Location = New System.Drawing.Point(41, 296)
        Me.btnnuevacategoria.Name = "btnnuevacategoria"
        Me.btnnuevacategoria.Size = New System.Drawing.Size(99, 35)
        Me.btnnuevacategoria.TabIndex = 7
        Me.btnnuevacategoria.Text = "Nuevo"
        Me.btnnuevacategoria.UseVisualStyleBackColor = False
        '
        'txtdescripcioncategoria
        '
        Me.txtdescripcioncategoria.Location = New System.Drawing.Point(133, 241)
        Me.txtdescripcioncategoria.Name = "txtdescripcioncategoria"
        Me.txtdescripcioncategoria.Size = New System.Drawing.Size(139, 23)
        Me.txtdescripcioncategoria.TabIndex = 8
        '
        'txtnombrecategoria
        '
        Me.txtnombrecategoria.Location = New System.Drawing.Point(133, 199)
        Me.txtnombrecategoria.Name = "txtnombrecategoria"
        Me.txtnombrecategoria.Size = New System.Drawing.Size(139, 23)
        Me.txtnombrecategoria.TabIndex = 7
        '
        'labelidcategoria
        '
        Me.labelidcategoria.AutoSize = True
        Me.labelidcategoria.ForeColor = System.Drawing.Color.White
        Me.labelidcategoria.Location = New System.Drawing.Point(130, 167)
        Me.labelidcategoria.Name = "labelidcategoria"
        Me.labelidcategoria.Size = New System.Drawing.Size(24, 17)
        Me.labelidcategoria.TabIndex = 6
        Me.labelidcategoria.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(33, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(32, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID"
        '
        'Mantenimiento_Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 513)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Mantenimiento_Categoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento_Categoria"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Categoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV_Categoria As DataGridView
    Friend WithEvents txtbuscarcategoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents labelidcategoria As Label
    Friend WithEvents txtdescripcioncategoria As TextBox
    Friend WithEvents txtnombrecategoria As TextBox
    Friend WithEvents btnmodificarcategoria As Button
    Friend WithEvents btnnuevacategoria As Button
    Friend WithEvents btneliminarcategoria As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btn_buscarcategoria As Button
End Class
