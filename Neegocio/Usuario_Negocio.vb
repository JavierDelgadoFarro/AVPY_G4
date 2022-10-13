Imports Datos
Imports Entidades

Public Class Usuario_Negocio
    Dim usuarioDao As New Usuario_Datos()

    Public Function Login(nombre_login As String, password As String) As Boolean
        Return usuarioDao.Login(nombre_login, password)
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
