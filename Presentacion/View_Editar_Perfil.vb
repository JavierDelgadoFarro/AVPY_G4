Imports System.Windows.Documents
Imports Entidades
Imports Negocio
Imports Presentacion
Public Class View_Editar_Perfil
    Dim lista3 As New List(Of E_Empleado)
    Dim obj2 As New Empleado_Negocio
    Private Sub View_Editar_Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Editar_Data_Perfil()
        iniciar_Controles_Contraseña()
        txt_Vigente_pass.UseSystemPasswordChar = True
    End Sub

    Private Sub Editar_Data_Perfil()


        lista3 = obj2.empleado(view_Principal.lbl_id.Text)
        'Vista'
        lbl_usuario.Text = lista3.Item(0).usuario
        lbl_nombre.Text = lista3.Item(0).nombres
        lbl_apellido.Text = lista3.Item(0).apellidos

        'Edición'
        txt_usuario.Text = lista3.Item(0).usuario
        txt_nombre.Text = lista3.Item(0).nombres
        txt_apellido.Text = lista3.Item(0).apellidos
        txt_password.Text = lista3.Item(0).contraseña
        txt_Confirmar_Pass.Text = lista3.Item(0).contraseña
    End Sub

    Private Sub iniciar_Controles_Contraseña()
        lbl_link_password.Text = "Editar Contraseña"
        txt_password.UseSystemPasswordChar = True
        txt_password.Enabled = False
        txt_Confirmar_Pass.UseSystemPasswordChar = True
        txt_Confirmar_Pass.Enabled = False
        txt_Vigente_pass.Text = ""
    End Sub

    Private Sub reiniciar()
        Editar_Data_Perfil()
        iniciar_Controles_Contraseña()
    End Sub

    Private Sub lbl_link_password_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_link_password.LinkClicked
        If lbl_link_password.Text = "Editar Contraseña" Then
            lbl_link_password.Text = "Cancelar"
            txt_password.Enabled = True
            txt_password.Text = ""
            txt_Confirmar_Pass.Enabled = True
            txt_Confirmar_Pass.Text = ""
        ElseIf lbl_link_password.Text = "Cancelar" Then
            reiniciar()
        End If
    End Sub

    Private Sub Btn_Editar_Perfil_Click(sender As Object, e As EventArgs) Handles Btn_Editar_Perfil.Click
        Panel_Editar_Perfil.Visible = True
        Editar_Data_Perfil()
    End Sub

    Private Sub Btn_actualizar_Click(sender As Object, e As EventArgs) Handles Btn_actualizar.Click
        lista3 = obj2.empleado(view_Principal.lbl_id.Text)
        If txt_password.Text = txt_Confirmar_Pass.Text Then
            If txt_Vigente_pass.Text = lista3.Item(0).contraseña Then
                Dim Empleado_Negocio As New Empleado_Negocio(id:=lista3.Item(0).idempleado,
                                                            nombre:=lista3.Item(0).nombres,
                                                           apellido:=lista3.Item(0).apellidos,
                                                          contraseña:=lista3.Item(0).contraseña,
                                                            idRol:=Nothing,
                                                          usuario:=lista3.Item(0).usuario)
                Dim result = Empleado_Negocio.editar_Perfil(id, nombre, apellido, contraseña, idRol, usuario)
                MessageBox.Show(result)
                reiniciar()
                Panel_Editar_Perfil.Visible = False
            Else
                MessageBox.Show("Contraseña actual Incorrecta")
            End If
        Else
            MessageBox.Show("Las contraseñas ingresadas no coinciden")
        End If
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Panel_Editar_Perfil.Visible = False
        reiniciar()
    End Sub

    Private Sub Panel_Perfil_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Perfil.Paint

    End Sub
End Class