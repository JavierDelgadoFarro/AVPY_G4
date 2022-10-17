﻿'Para que el formulario sea desplazable'
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports Negocio
Imports Entidades
Imports System.Security

Public Class View_Login

#Region "Formulario Login"
    Private Sub Btn_cerrar_Click(sender As Object, e As EventArgs) Handles Btn_cerrar.Click
        Application.Exit()
    End Sub

    Private Sub Btn_Minimizar_Click(sender As Object, e As EventArgs) Handles Btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Formulario Desplazable"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub View_Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region

#Region "Personalizar Iconos"
    Private Sub PersonalizarIconos()
        'login'
        txt_nombre_login.AutoSize = False
        txt_nombre_login.Size = New Size(198, 26)
        'password'
        txt_password.AutoSize = False
        txt_password.Size = New Size(198, 26)
        txt_password.UseSystemPasswordChar = True
    End Sub


#End Region
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        PersonalizarIconos()
    End Sub


    Private Function Validar(ByVal registros As E_Empleado) As Boolean
        Dim valor As Boolean
        Dim obj As New Empleado_Negocio
        valor = obj.Validar(registros)
        Return valor
    End Function



    Private Sub logearse()
        Dim autorizado As Boolean
        Dim registros As New E_Empleado
        With registros
            .usuario = txt_nombre_login.Text
            .contraseña = txt_password.Text
        End With
        autorizado = Validar(registros)

        If autorizado Then
            'View_Bienvenida.ShowDialog()
            Me.Hide()
            view_Principal.Show()
            view_Principal.Text = "Usuario : " + registros.usuario
            'Recarga el login'
            AddHandler view_Principal.FormClosed, AddressOf Me.Cerrar_Sesion
        Else
            MessageBox.Show("usuario o contraseña incorrecta")
            txt_password.Clear()
            txt_password.Focus()
        End If
    End Sub

    Private Sub Btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Login.Click
        logearse()
    End Sub


    Private Sub txt_password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            logearse()
        End If
    End Sub

    Private Sub Cerrar_Sesion(sender As Object, e As FormClosedEventArgs)
        txt_nombre_login.Clear()
        txt_password.Clear()
        Me.Show()
        txt_nombre_login.Focus()
    End Sub

End Class