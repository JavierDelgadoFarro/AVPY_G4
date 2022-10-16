﻿
Imports Entidades
Imports Negocio
Public Class Mantenimiento_Categoria

    Private Sub personalizargridview(ByVal grid As DataGridView)
        With grid
            .EnableHeadersVisualStyles = False 'desactivar el estilo visual'
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(214, Byte), Integer))
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .RowHeadersVisible = False
            .DefaultCellStyle.SelectionBackColor = Color.Yellow
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .AllowUserToResizeRows = False
        End With
    End Sub

    Private Sub Mantenimiento_Categoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        personalizargridview(Me.DGV_Categoria)
        Cargar_gridview()
    End Sub

    Private Sub Cargar_gridview()
        Dim lista_categoria As New List(Of E_Categoria)
        Dim obj As New Categoria_Negocio
        lista_categoria = obj.Mostrar_categoria
        DGV_Categoria.DataSource = lista_categoria
    End Sub

    Private Sub Mantenimiento_Categoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DGV_Categoria.AutoGenerateColumns = False
        personalizargridview(Me.DGV_Categoria)
        Cargar_gridview()
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Categoria.SelectionChanged
        Dim fila As Integer
        fila = DGV_Categoria.CurrentCell.RowIndex
        Label3.Text = Me.DGV_Categoria(0, fila).Value.ToString()
        TextBox2.Text = Me.DGV_Categoria(1, fila).Value.ToString()
        TextBox3.Text = Me.DGV_Categoria(2, fila).Value.ToString()
    End Sub

End Class
