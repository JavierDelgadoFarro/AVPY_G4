Imports Datos
Imports Entidades
Public Class Categoria_Negocio
	Private ObjCategoriaDatos As New Categoria_Datos
	Public Function MostrarCategorias() As DataTable
		Return ObjCategoriaDatos.MostrarCategoria
	End Function
End Class
