Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports Entidades

Public Class Usuario_Datos
    'hereda de la clase conexion'
    Inherits Conexion

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
                        Entidades.id = lector.GetInt32(0)
                        Entidades.nombre = lector.GetString(1)
                        Entidades.apellido = lector.GetString(2)
                        Entidades.contraseña = lector.GetString(3)
                        Entidades.idRol = lector.GetInt32(4)
                        Entidades.usuario = lector.GetString(5)
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
        If E_Empleado.idRol = Cargos_login.administrador Then

        End If
        If E_Empleado.idRol = Cargos_login.almacenero Then

        End If
        If E_Empleado.idRol = Cargos_login.vendedor Then

        End If
    End Sub


End Class
