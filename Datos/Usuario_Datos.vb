Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

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
                command.CommandText = "SELECT * FROM usuario users where nombre_login=@nombre_login AND password=@password"
                'asignación de valores a los parámetros'
                command.Parameters.AddWithValue("@nombre_login", nombre_login)
                command.Parameters.AddWithValue("@password", password)
                'especificación del tipo de comando'
                command.CommandType = CommandType.Text
                'se guarda en una variable la ejecución del comando'
                Dim lector = command.ExecuteReader()

                'verificación de la consulta'
                If lector.HasRows Then
                    Return True
                Else
                    Return False
                End If
                '7:22'

            End Using
        End Using
    End Function

End Class
