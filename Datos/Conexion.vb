﻿Imports System.Data.SqlClient

'mustinherti = clase abstracta'

'para no ser instanciada, solo una clase base'
Public MustInherit Class Conexion
    Private conexionString As String
    'inicializamos la cadena de conexion'
    Protected Sub New()
        conexionString = "Data Source=JAVIERDF\SQLEXPRESS;Initial Catalog=Tienda_Rosa;Integrated Security=True"
        conexionString = "Data Source=DESKTOP-PH1HUF0;Initial Catalog=Tienda_Rosa;User ID=sistema"
>>>>>>> 6fa9e3b7e19ad8ccc3bf133285546e1ebe6c87cf
        conexionString = "Data Source=DESKTOP-PH1HUF0;Initial Catalog=Tienda_Rosa;User ID=sistema"
>>>>>>> 6fa9e3b7e19ad8ccc3bf133285546e1ebe6c87cf
    End Sub

    Protected Function GetConexion() As SqlConnection
        Return New SqlConnection(conexionString)
    End Function
End Class
