Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports Entidades

Public Class Usuario_Datos
    'hereda de la clase conexion'
    Inherits Conexion

    Public Sub editar_Perfil(id, nombre, apellido, contraseña, usuario)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Using command = New SqlCommand()
                command.Connection = conexion_return
                command.CommandText = "UPDATE empleado set nombre=@nombre, apellido=@apellido, contraseña =@contraseña,
                 usuario=@usuario where idempleado = @id"
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@apellido", apellido)
                command.Parameters.AddWithValue("@contraseña", contraseña)
                command.Parameters.AddWithValue("@usuario", usuario)
                command.Parameters.AddWithValue("@id", id)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
