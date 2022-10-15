Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Public Class Categoria_Datos
    Public conexion As SqlConnection = New SqlConnection("Data Source=LAPTOP-7QMM155H\SQLEXPRESS;Initial Catalog=Tienda_Rosa;Integrated Security=True")
    Public Function MostrarCategoria() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("p_mostrarcategoria", conexion)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function


End Class
