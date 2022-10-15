
Imports Negocio
Public Class Mantenimiento_Categoria

	Private objCategoriaNegocio As New Categoria_Negocio
	Private Sub FormPregrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MostrarCategorias()
	End Sub
	Sub MostrarCategorias()
		Dim dt As DataTable = objCategoriaNegocio.MostrarCategorias
		Me.DGV_Categoria.DataSource = dt
	End Sub


End Class
