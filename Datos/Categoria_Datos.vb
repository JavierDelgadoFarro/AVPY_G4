Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades

Public Class Categoria_Datos

    'Para listar una categoría'
    Public Function Mostrar_categoria() As List(Of E_Categoria)
        Dim lista_categoria As New List(Of E_Categoria)
        Using cnn As New SqlConnection(My.Settings.cnn)
            cnn.Open()
            Dim cmd As New SqlCommand("p_mostrarcategoria", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Categoria
                reg.ID = dr.GetValue(0).ToString()
                reg.Nombre = dr.GetValue(1).ToString()
                reg.Descripcion = dr.GetValue(2).ToString()
                lista_categoria.Add(reg)
            End While
            dr.Close()
        End Using
        Return lista_categoria
    End Function


End Class
