Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Imports Entidades
Public Class view_Principal
    'Se declaran campos de forma ´privada y un panel para el color izquierdo del botón'

    Private Btn_Actual As IconButton
    Private Border_Btn_Actual As Panel
    Private Frm_Hijo_Actual As Form

    'Constructor'
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        OcultarSubmenu()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Border_Btn_Actual = New Panel()

        'tamaño del border'
        Border_Btn_Actual.Size = New Size(7, 43)
        'Asignarle a todos los botones del panel menu'
        Panel_Menu.Controls.Add(Border_Btn_Actual)
        'Personalizacion del panel principal'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    'RESALTA BOTON ACTIVO'

    Private Sub Activacion_Boton(senderBtn As Object, Color_Actual As Color)
        Desactivar_Boton()
        'verificacion de nulidad del boton'
        If senderBtn IsNot Nothing Then

            '***Boton***'
            'Asignacion: boton remitente a boton actual'
            Btn_Actual = CType(senderBtn, IconButton)
            'cambio de color de boton'
            Btn_Actual.BackColor = RGBColors.ColorBlanco
            'cambio de color de texto a color definido'
            Btn_Actual.ForeColor = Color_Actual
            'cambio de color de icono a paramtro color'
            Btn_Actual.IconColor = Color_Actual
            'Alineación de texto al centro'
            Btn_Actual.TextAlign = ContentAlignment.MiddleCenter
            'alineación de icono'
            Btn_Actual.ImageAlign = ContentAlignment.MiddleRight
            'cambio relacion a texto antes de imagen'
            Btn_Actual.TextImageRelation = TextImageRelation.TextBeforeImage

            '***Border***'
            'cambio de color de fondo'
            Border_Btn_Actual.BackColor = Color_Actual
            'Se asigna nueva ubicacion'
            Border_Btn_Actual.Location = New Point(1, Btn_Actual.Location.Y)
            'visibilidad en verdadero'
            Border_Btn_Actual.Visible = True
            'se trae al frente'
            Border_Btn_Actual.BringToFront()


            '***Actualización de incono a lo seleccionado***'
            Icon_Form_Actual.IconChar = Btn_Actual.IconChar
            Icon_Form_Actual.IconColor = RGBColors.ColorBlanco
        End If
    End Sub



    'DESACTIVA BOTON'
    Private Sub Desactivar_Boton()
        If Btn_Actual IsNot Nothing Then
            Btn_Actual.BackColor = RGBColors.ColorAzulOscuro
            Btn_Actual.ForeColor = Color.Silver
            Btn_Actual.IconColor = Color.Silver
            Btn_Actual.TextAlign = ContentAlignment.MiddleLeft
            Btn_Actual.ImageAlign = ContentAlignment.MiddleLeft
            Btn_Actual.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    'ABRE FORMULARIO HIJO'
    Private Sub Abrir_Frm_Hijo(Frm_Hijo As Form)

        'Si formulario hijo actual está abierto, lo cierra'
        If Frm_Hijo_Actual IsNot Nothing Then
            Frm_Hijo_Actual.Close()
        End If
        Frm_Hijo_Actual = Frm_Hijo
        Frm_Hijo.TopLevel = False
        Frm_Hijo.Dock = DockStyle.Fill
        'Traer el formulario hijo'
        Panel_Secundario.Controls.Add(Frm_Hijo)
        'Se asigna los datos al panel'
        Panel_Secundario.Tag = Frm_Hijo
        'Se trae formulario al frente'
        Frm_Hijo.BringToFront()
        Frm_Hijo.Show()
        Title_Actual.Text = Frm_Hijo.Text

    End Sub


    'EVENTOS DE BOTONES'
#Region "Eventos"
    Private Sub Btn_Ventas_Click(sender As Object, e As EventArgs) Handles Btn_Ventas.Click
        Activacion_Boton(sender, RGBColors.ColorAzulClaro)
        Abrir_Frm_Hijo(New View_Ventas)
    End Sub

    Private Sub Btn_Compras_Click(sender As Object, e As EventArgs) Handles Btn_Compras.Click
        Activacion_Boton(sender, RGBColors.ColorAzulClaro)
        Abrir_Frm_Hijo(New View_Compra)
    End Sub

    Private Sub Btn_Pagos_Click(sender As Object, e As EventArgs) Handles Btn_Pagos.Click
        Activacion_Boton(sender, RGBColors.ColorAzulClaro)
    End Sub

    Private Sub Btn_Producto_Click(sender As Object, e As EventArgs) Handles Btn_Producto.Click
        Activacion_Boton(sender, RGBColors.ColorAzulClaro)

    End Sub

    Private Sub Btn_Mantenimiento_Click(sender As Object, e As EventArgs) Handles Btn_Mantenimiento.Click
        Activacion_Boton(sender, RGBColors.ColorAzulClaro)
        MostrarSubmenu(Panel_Mantenimiento)
    End Sub

    Private Sub Btn_Configuracion_Click(sender As Object, e As EventArgs) Handles Btn_Configuracion.Click
        Activacion_Boton(sender, RGBColors.ColorAzulClaro)
    End Sub

    'SUBMENU'
    Private Sub Btn_Proveedor_Click(sender As Object, e As EventArgs) Handles Btn_Proveedor.Click
        Activacion_Boton(sender, RGBColors.ColorAzulClaro)
    End Sub

    Private Sub Btn_Categoria_Click(sender As Object, e As EventArgs) Handles Btn_Categoria.Click
        Activacion_Boton(sender, RGBColors.ColorAzulClaro)
        Abrir_Frm_Hijo(New Mantenimiento_Categoria)
    End Sub

    Private Sub Btn_Cliente_Click(sender As Object, e As EventArgs) Handles Btn_Cliente.Click
        Activacion_Boton(sender, RGBColors.ColorAzulClaro)
        Abrir_Frm_Hijo(New Mantenimiento_Cliente)
    End Sub


#End Region

    'VENTANA PRINCIPAL'
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Cierre de formulario hijo y desactivacion de botones'
        If Frm_Hijo_Actual IsNot Nothing Then
            Frm_Hijo_Actual.Close()
        End If
        Reset()
    End Sub

    'REINICIO DE VALORES'
    Private Sub Reset()
        Desactivar_Boton()
        Icon_Form_Actual.IconChar = IconChar.None
        Icon_Form_Actual.IconColor = RGBColors.ColorAzulOscuro
        Title_Actual.Text = ""

    End Sub

    'MENU DESPLAZABLE'
#Region "Formulario Desplazable"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub Barra_Titulo_MouseDown(sender As Object, e As MouseEventArgs) Handles Barra_Titulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Panel_Secundario_MouseDown_1(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region

    'BOTONES DEL FORMULARIO PRINCIPAL'
#Region "Botones view"
    'CONFIGURACION DE PANEL PRINCIPAL'
    Private Sub view_Principal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        FormBorderStyle = FormBorderStyle.None
    End Sub

    'SALIR DE FORMULARIO'
    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        If MessageBox.Show("¿Seguro de cerrar la aplicación?", "Advertencia",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    'CERRAR SESION'
    Private Sub Btn_Cerrar_Sesion_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar_Sesion.Click
        If MessageBox.Show("¿Seguro de cerrar sesión?", "Advertencia",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    'MINIMIZAR FORMULARIO'
    Private Sub Btn_minimizar_Click(sender As Object, e As EventArgs) Handles Btn_minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    'MAXIMIZAR FORMULARIO'
    Private Sub Btn_Maximizar_Click(sender As Object, e As EventArgs) Handles Btn_Maximizar.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
#End Region

    'BOTONES DEL SUB MENU'
#Region "Sub Menu"
    'OCULTAR SUBMENU'
    Private Sub OcultarSubmenu()
        Panel_Mantenimiento.Visible = False
    End Sub
    'MOSTRAR SUBMENU'
    Private Sub MostrarSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            OcultarSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub view_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Info_Usuario()
        Permisos_Usuario()
    End Sub
    Private Sub Info_Usuario()
        lbl_Nombre.Text = E_Empleado.nombre + " " + E_Empleado.apellido
        lbl_usuario.Text = E_Empleado.usuario
        If E_Empleado.id = Nothing OrElse E_Empleado.id = 0 Then

            MessageBox.Show("Error")
            Me.Close()
        End If
    End Sub

#End Region

#Region "Permisos de usuarios"
    'administrador = 1
    'almacenero = 2
    'vendedor = 3

    Private Sub Permisos_Usuario()
        If E_Empleado.idRol = 2 Then
            Btn_Configuracion.Visible = False
            Btn_Pagos.Visible = False
        End If
        If E_Empleado.idRol = 3 Then
            Btn_Configuracion.Visible = False
            Btn_Compras.Visible = False
        End If
    End Sub
#End Region

End Class