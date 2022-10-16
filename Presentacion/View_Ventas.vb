Imports Entidades
Imports Negocio
Imports System.Data.SqlClient
Imports System.IO
Public Class View_Ventas
    Private txt() As PictureBox
    Private lbl() As Label

#Region "Mostrar CLiente"
    Private Sub Btn_Actualizar1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Actualizar.Click
        cargarcombo(Cmb_cliente)
        cargarcombocategoria()
    End Sub

    Private Sub cargarcombo(ByVal combo As ComboBox)
        Dim lista As New List(Of E_Cliente)
        Dim obj As New Cliente_Negocio
        lista = obj.Mostrarcliente
        combo.DataSource = lista
        combo.DisplayMember = "nombre"
        combo.ValueMember = "idcliente"
        combo.SelectedIndex = -1

    End Sub
#End Region



    Private Sub cargarcombocategoria()
        Dim lista As New List(Of E_Categoria)
        Dim obj As New Categoria_Negocio
        lista = obj.Mostrar_categoria
        Cmb_categoria.DataSource = lista
        Cmb_categoria.DisplayMember = "nombre"
        Cmb_categoria.ValueMember = "idcategoria"
        Cmb_categoria.SelectedIndex = -1
    End Sub


End Class