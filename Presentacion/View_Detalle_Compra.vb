Public Class View_Detalle_Compra

    Private Sub btnAceptarDetalle_Click(sender As Object, e As EventArgs) Handles btnAceptarDetalle.Click

        If txtCantidad.Text = "" Then
            MessageBox.Show("Debe de ingresar una cantidad")
            Exit Sub
        End If
        If txtCantidad.Text = "0" Then
            MessageBox.Show("Deberia ingresar una cantidad mayor a 0")
            Exit Sub
        End If
        If Not IsNumeric(txtCantidad.Text) Then
            MessageBox.Show("La Cantidad no es Valida")
            Exit Sub
        End If

        Dim oreg As New ListViewItem(PictureBox.Name) 'codigo del producto'

        With oreg
            .SubItems.Add(lbl_nombre1.Text) 'nombre'
            .SubItems.Add(txtCantidad.Text)  'Cantidad'
            .SubItems.Add(importeDetalle.Value) 'importe'
            View_Compra.listCompras.Items.Add(oreg) 'Agregamos todo esto al listview'
        End With
        View_Compra.Label7.Text = CStr(CDbl(View_Compra.Label7.Text) + CDbl(importeDetalle.Value))
        View_Compra.verificarcheckboxes()
        Me.Close()

    End Sub

    Private Sub btnCancelarDetalle_Click(sender As Object, e As EventArgs) Handles btnCancelarDetalle.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class