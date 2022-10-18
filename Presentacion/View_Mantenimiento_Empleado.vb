Imports Entidades
Imports Negocio

Public Class View_Mantenimiento_Empleado
    Private Sub View_Mantenimiento_Empleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ForeColor = Color.Black
        personalizargridviewEmpleado(Me.DGVEmpleado)
        cargargridviewEmpleado()
    End Sub

    Private Sub personalizargridviewEmpleado(ByVal grid As DataGridView)
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

    Private Sub cargargridviewEmpleado()
        Dim lista_empleado As New List(Of E_Empleado)
        Dim obj As New Empleado_Negocio
        lista_empleado = obj.Mostrartodoempleado
        DGVEmpleado.DataSource = lista_empleado
    End Sub
End Class