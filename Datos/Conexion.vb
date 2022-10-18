Imports System.Data.SqlClient

'mustinherti = clase abstracta'

'para no ser instanciada, solo una clase base'
Public MustInherit Class Conexion
    Private conexionString As String
    'inicializamos la cadena de conexion'
    Protected Sub New()
<<<<<<< HEAD
        conexionString = "Data Source=JAVIERDF\SQLEXPRESS;Initial Catalog=Tienda_Rosa;Integrated Security=True"
=======

        conexionString = "Data Source=DESKTOP-PH1HUF0;Initial Catalog=Tienda_Rosa;User ID=sistema"
>>>>>>> aae3da9b61bfaec69f22e6e4b1daed2d1d977818

    End Sub

    Protected Function GetConexion() As SqlConnection
        Return New SqlConnection(conexionString)
    End Function
End Class
