Imports Entidades
Imports Negocio
Imports Presentacion
Public Class View_Editar_Perfil
    Private Sub View_Editar_Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Editar_Data_Perfil()
        iniciar_Controles_Contraseña()
        txt_Vigente_pass.UseSystemPasswordChar = True
    End Sub

    Private Sub Editar_Data_Perfil()
        'Vista'
        lbl_usuario.Text = E_Usuario.usuario
        lbl_nombre.Text = E_Usuario.nombre
        lbl_apellido.Text = E_Usuario.apellido

        'Edición'
        txt_usuario.Text = E_Usuario.usuario
        txt_nombre.Text = E_Usuario.nombre
        txt_apellido.Text = E_Usuario.apellido
        txt_password.Text = E_Usuario.contraseña
        txt_Confirmar_Pass.Text = E_Usuario.contraseña
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
        'view_Principal.Info_Usuario()
    End Sub

    Private Sub lbl_link_password_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_link_password.LinkClicked
        If lbl_link_password.Text = "Editar Contraseña" Then
            lbl_link_password.Text = "Cancelar"
            txt_password.Enabled = True
            txt_password.Text = ""
            txt_Confirmar_Pass.Enabled = True
            txt_Confirmar_Pass.Text = ""
            'view_Principal.Info_Usuario()
        ElseIf lbl_link_password.Text = "Cancelar" Then
            reiniciar()
        End If
    End Sub

    Private Sub Btn_Editar_Perfil_Click(sender As Object, e As EventArgs) Handles Btn_Editar_Perfil.Click
        Panel_Editar_Perfil.Visible = True
        Editar_Data_Perfil()
    End Sub

    Private Sub Btn_actualizar_Click(sender As Object, e As EventArgs) Handles Btn_actualizar.Click
        If txt_password.Text = txt_Confirmar_Pass.Text Then
            If txt_Vigente_pass.Text = E_Usuario.contraseña Then
                Dim Usuario_Negocio As New Usuario_Negocio(id:=E_Usuario.id,
                                                           nombre:=txt_nombre.Text,
                                                           apellido:=txt_apellido.Text,
                                                           contraseña:=txt_password.Text,
                                                           idRol:=Nothing,
                                                           usuario:=txt_usuario.Text)
                Dim result = Usuario_Negocio.editar_Perfil()
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