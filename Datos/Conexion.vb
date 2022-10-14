Imports System.Data.SqlClient

'mustinherti = clase abstracta'

'para no ser instanciada, solo una clase base'
Public MustInherit Class Conexion
    Private conexionString As String
    'inicializamos la cadena de conexion'
    Protected Sub New()
        conexionString = "Data Source=DESKTOP-SC5IQGP\SQLEXPRESS;Initial Catalog=Tienda_Rosa;User ID=sistemas"
    End Sub

    Protected Function GetConexion() As SqlConnection
        Return New SqlConnection(conexionString)
    End Function
End Class
