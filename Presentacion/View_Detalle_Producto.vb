Public Class View_Detalle_Producto
    Private Sub View_Detalle_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False 'con esto desapareces los botones maximizar minimizat y cerrar'
        Me.ToolTip1.SetToolTip(Me.btnAceptarDetalleProducto, "Añadir")
        Me.ToolTip1.SetToolTip(Me.btnCancelarDetalleProducto, "Cancelar")
    End Sub

    Private Sub btnCancelarDetalleProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarDetalleProducto.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnAceptarDetalleProducto_Click(sender As Object, e As EventArgs) Handles btnAceptarDetalleProducto.Click
        If txtCantidadProducto.Text = "" Then
            MessageBox.Show("Debe de ingresar una cantidad")
            Exit Sub
        End If
        If txtCantidadProducto.Text = "0" Then
            MessageBox.Show("Deberia ingresar una cantidad mayor a 0")
            Exit Sub
        End If
        If Not IsNumeric(txtCantidadProducto.Text) Then
            MessageBox.Show("La Cantidad no es Valida")
            Exit Sub
        End If
        Dim posicion As Integer 'variable que contendra la posicion en la que se repite el listview'
        Dim stock As Integer
        posicion = recorrerlistview(View_Ventas.Lsv_det)

        If posicion = -1 Then
            stock = CType(Me.lbl_stock.Text, Integer)
            If stock >= CType(Me.txtCantidadProducto.Text, Integer) Then 'Comparamos el stock con la cantidad' 
                Dim oreg As New ListViewItem(lbl_nombre.Text) 'nombre  del producto'

                With oreg
                    .SubItems.Add(lbl_precio.Text) 'Precio'
                    .SubItems.Add(txtCantidadProducto.Text)  'Cantidad'
                    .SubItems.Add(PictureBox2.Name) 'Codigo del producto'
                    View_Ventas.Lsv_det.Items.Add(oreg) 'Agregamos todo esto al listview'
                End With
                'Sumamos el total'
                View_Ventas.lbl_TotalVenta.Text = CType(CType(View_Ventas.lbl_TotalVenta.Text, Double) + (CType(lbl_precio.Text, Double) * CType(txtCantidadProducto.Text, Double)), String) 'Multiplicamos el precio por la cantidad'
                Me.Close()
            Else
                MessageBox.Show("No tienes stock suficiente")
            End If

        Else
            stock = CType(Me.lbl_stock.Text, Integer)
            If stock >= (CType(Me.txtCantidadProducto.Text, Integer) + CType(View_Ventas.Lsv_det.Items(posicion).SubItems(2).Text, Integer)) Then
                View_Ventas.Lsv_det.Items(posicion).SubItems(2).Text = CType(CType(View_Ventas.Lsv_det.Items(posicion).SubItems(2).Text, Double) + CType(txtCantidadProducto.Text, Double), String)
                View_Ventas.lbl_TotalVenta.Text = CType(CType(View_Ventas.lbl_TotalVenta.Text, Double) + (CType(lbl_precio.Text, Double) * CType(txtCantidadProducto.Text, Double)), String)
                Me.Close()
            Else
                MessageBox.Show("No tienes stock suficiente")
            End If
        End If
    End Sub

    'Funcion que recorre el listview para ver si es que se repite algun producto y retorna la posicion en la que se encuentra'
    Private Function recorrerlistview(ByVal listview1 As ListView) As Integer

        Dim nombre As String
        Dim posicion As Integer = -1

        'Recorrermos el listview para saber si ahi un producto que se repite'
        For i = 0 To listview1.Items.Count - 1
            nombre = listview1.Items(i).SubItems(0).Text
            If posicion = -1 Then
                If lbl_nombre.Text = nombre Then
                    posicion = i
                Else
                    posicion = -1
                End If
            End If
        Next
        Return posicion
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class