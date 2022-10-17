Imports System.Data.SqlClient
Imports Entidades
Imports System.Data
Public Class Empleado_Datos
    Inherits Conexion
    'Para el Login'

    Public Function Validar(ByVal registro As E_Empleado) As Boolean
        Dim logeo As Boolean
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_validar", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@usuario", registro.usuario)
            cmd.Parameters.AddWithValue("@clave", registro.contraseña)
            cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
            Dim valor As Integer
            cmd.ExecuteNonQuery()
            valor = CType(cmd.Parameters.Item("@RETURN_VALUE").Value, Integer)
            If valor >= 0 Then
                logeo = True
            Else
                logeo = False
            End If
            conexion_return.Close()
            conexion_return.Dispose()
        End Using
        Return logeo
    End Function

    'Obtenemos el id del empleado'
    Public Function obtener_idempleado(ByVal usuario As String) As List(Of E_Empleado)

        Dim lista As New List(Of E_Empleado)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Try
                Dim cmd As New SqlCommand("p_idempleado", conexion_return)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@usuario", usuario)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                While dr.Read
                    Dim reg As New E_Empleado
                    reg.idempleado = dr.GetValue(0).ToString()
                    lista.Add(reg)
                End While
                dr.Close()

            Catch ex As Exception
            End Try
        End Using

        Return lista

    End Function

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

End Class