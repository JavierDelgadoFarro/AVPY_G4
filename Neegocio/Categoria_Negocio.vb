Imports Datos
Imports Entidades
Public Class Categoria_Negocio
    Public Function Mostrar_categoria() As List(Of E_Categoria)
        Dim lista_categoria As New List(Of E_Categoria)
        Dim obj As New Categoria_Datos
        lista_categoria = obj.Mostrar_categoria
        Return lista_categoria
    End Function

End Class
