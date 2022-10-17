Imports System.Data.SqlClient

'mustinherti = clase abstracta'

'para no ser instanciada, solo una clase base'
Public MustInherit Class Conexion
    Private conexionString As String
    'inicializamos la cadena de conexion'

        conexionString = "Data Source=LAPTOP-7QMM155H\SQLEXPRESS;Initial Catalog=Tienda_Rosa;Integrated Security=True"

        conexionString = "Data Source=DESKTOP-PH1HUF0;Initial Catalog=Tienda_Rosa;User ID=sistema"
    End Sub

    Protected Function GetConexion() As SqlConnection
        Return New SqlConnection(conexionString)
    End Function
End Class
