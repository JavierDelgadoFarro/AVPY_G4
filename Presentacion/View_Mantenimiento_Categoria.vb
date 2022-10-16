
Imports Entidades
Imports Negocio
Public Class Mantenimiento_Categoria

    Private Sub personalizargridview(ByVal grid As DataGridView)
        With grid
            .BackgroundColor = Color.White
            .EnableHeadersVisualStyles = False 'desactivar el estilo visual'
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(214, Byte), Integer))
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .RowHeadersVisible = False
            .DefaultCellStyle.SelectionBackColor = Color.Yellow
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .AllowUserToResizeRows = False
        End With
    End Sub
    Private Sub Cargar_gridview()
        Dim lista_categoria As New List(Of E_Categoria)
        Dim obj As New Categoria_Negocio
        lista_categoria = obj.Mostrar_categoria
        DGV_Categoria.DataSource = lista_categoria
    End Sub

    Private Sub Mantenimiento_Categoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        personalizargridview(Me.DGV_Categoria)
        Cargar_gridview()
    End Sub
End Class
