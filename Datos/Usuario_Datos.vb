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

    'funcion para el login del usuario'
    Public Function Login(nombre_login As String, password As String) As Boolean
        Using conexion_return = GetConexion()
            'se abre la conexion'
            conexion_return.Open()
            'usign para llamar a los métodos desechables'
            Using command = New SqlCommand()
                command.Connection = conexion_return
                command.CommandText = "SELECT * FROM empleado where usuario=@nombre_login AND contraseña=@password"
                'asignación de valores a los parámetros'
                command.Parameters.AddWithValue("@nombre_login", nombre_login)
                command.Parameters.AddWithValue("@password", password)
                'especificación del tipo de comando'
                command.CommandType = CommandType.Text
                'se guarda en una variable la ejecución del comando'
                Dim lector = command.ExecuteReader()

                'verificación de la consulta'
                If lector.HasRows Then
                    While lector.Read()
                        E_Usuario.id = lector.GetInt32(0)
                        E_Usuario.nombre = lector.GetString(1)
                        E_Usuario.apellido = lector.GetString(2)
                        E_Usuario.contraseña = lector.GetString(3)
                        E_Usuario.idRol = lector.GetInt32(4)
                        E_Usuario.usuario = lector.GetString(5)
                    End While
                    lector.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Sub Permiso_Usuario()
        If E_Usuario.idRol = Cargos_login.administrador Then

        End If
        If E_Usuario.idRol = Cargos_login.almacenero Then

        End If
        If E_Usuario.idRol = Cargos_login.vendedor Then

        End If
    End Sub


End Class
