Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Public Class Categoria_Datos
    Inherits Conexion
    'Para listar una categoría'
    Public Function Mostrar_categoria() As List(Of E_Categoria)
        Dim lista_categoria As New List(Of E_Categoria)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_mostrarcategoria", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Categoria
                reg.idcategoria = dr.GetValue(0).ToString()
                reg.Nombre = dr.GetValue(1).ToString()
                reg.Descripcion = dr.GetValue(2).ToString()
                lista_categoria.Add(reg)
            End While
            dr.Close()
        End Using
        Return lista_categoria
    End Function


End Class
