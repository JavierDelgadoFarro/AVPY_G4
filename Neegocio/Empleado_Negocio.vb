
Imports Entidades
Imports Datos

Public Class Empleado_Negocio
    'Para El login
    Public Function Validar(ByVal registros As E_Empleado) As Boolean
        Dim valor As Boolean
        Dim obj As New Empleado_Datos
        valor = obj.Validar(registros)

        Return valor
    End Function

    'Para obtener el idempleado
    Public Function obtener_idempleado(ByVal usuario As String) As List(Of E_Empleado)
        Dim lista As New List(Of E_Empleado)
        Dim obj As New Empleado_Datos
        lista = obj.obtener_idempleado(usuario)
        Return lista
    End Function
End Class
