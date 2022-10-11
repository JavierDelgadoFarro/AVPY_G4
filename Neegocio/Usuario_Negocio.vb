Imports Datos
Public Class Usuario_Negocio
    Dim usuarioDao As New Usuario_Negocio()

    Public Function Login(nombre_login As String, password As String) As Boolean
        Return usuarioDao.Login(nombre_login, password)
    End Function
End Class
