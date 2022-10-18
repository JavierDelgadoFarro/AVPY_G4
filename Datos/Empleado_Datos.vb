Imports System.Data.SqlClient
Imports Entidades
Imports System.Data
Public Class Empleado_Datos
    Inherits Conexion

    Public Function Mostrartodoempleado() As List(Of E_Empleado)
        Dim lista As New List(Of E_Empleado)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_mostrartodoempleado", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Empleado
                reg.idempleado = dr.GetValue(0).ToString()
                reg.nombres = dr.GetValue(1).ToString()
                reg.apellidos = dr.GetValue(2).ToString()
                reg.contraseña = dr.GetValue(3).ToString()
                reg.id_rol = dr.GetValue(4).ToString()
                reg.usuario = dr.GetValue(5).ToString()
                lista.Add(reg)
            End While
            dr.Close()
        End Using
        Return lista
    End Function


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


    Public Function empleado(ByVal id As Int32) As List(Of E_Empleado)
        Dim lista_empleado As New List(Of E_Empleado)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_empleado", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idempleado", id)
            cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Empleado
                reg.idempleado = dr.GetValue(0).ToString()
                reg.nombres = dr.GetValue(1).ToString()
                reg.apellidos = dr.GetValue(2).ToString()
                reg.contraseña = dr.GetValue(3).ToString()
                reg.id_rol = dr.GetValue(4).ToString()
                reg.usuario = dr.GetValue(5).ToString()
                lista_empleado.Add(reg)
            End While
            dr.Close()
        End Using
        Return lista_empleado
    End Function


    Public Sub editar_Perfil(id, nombre, apellido, contraseña, idrol, usuario)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Using command = New SqlCommand()
                command.Connection = conexion_return
                command.CommandText = "UPDATE empleado set nombre=@nombre, apellido=@apellido, contraseña =@contraseña,
                idrol =@idrol, usuario=@usuario where idempleado = @id"
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@apellido", apellido)
                command.Parameters.AddWithValue("@contraseña", contraseña)
                command.Parameters.AddWithValue("@idrol", idrol)
                command.Parameters.AddWithValue("@usuario", usuario)
                command.Parameters.AddWithValue("@id", id)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'funcion para el login del usuario'


End Class