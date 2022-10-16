Imports System.Drawing.Text
Imports Datos
Imports Entidades

Public Class Usuario_Negocio
    Dim usuarioDao As New Usuario_Datos()

#Region "Atributos"
    'Atributos'

    Private id
    Private nombre
    Private apellido
    Private contraseña
    Private idRol
    Private usuario
    Public Property Id1 As Object
        Get
            Return id
        End Get
        Set(value As Object)
            id = value
        End Set
    End Property

    Public Property Nombre1 As Object
        Get
            Return nombre
        End Get
        Set(value As Object)
            nombre = value
        End Set
    End Property

    Public Property Apellido1 As Object
        Get
            Return apellido
        End Get
        Set(value As Object)
            apellido = value
        End Set
    End Property

    Public Property Contraseña1 As Object
        Get
            Return contraseña
        End Get
        Set(value As Object)
            contraseña = value
        End Set
    End Property

    Public Property IdRol1 As Object
        Get
            Return idRol
        End Get
        Set(value As Object)
            idRol = value
        End Set
    End Property

    Public Property Usuario1 As Object
        Get
            Return usuario
        End Get
        Set(value As Object)
            usuario = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id As Object, nombre As Object, apellido As Object, contraseña As Object, idRol As Object, usuario As Object)
        Me.Id1 = id
        Me.Nombre1 = nombre
        Me.Apellido1 = apellido
        Me.Contraseña1 = contraseña
        Me.IdRol1 = idRol
        Me.Usuario1 = usuario
    End Sub
#End Region

    Public Function editar_Perfil() As String
        Try
            usuarioDao.editar_Perfil(Id1, Nombre1, Apellido1, Contraseña1, Usuario1)
            Login(Usuario1, Contraseña1)
            Return "Perfil actualizado satisfactoriamente"
        Catch ex As Exception
            Return "Error , Usuario ya existente"
        End Try
    End Function
    Public Function Login(nombre_login As String, password As String) As Boolean
        Return usuarioDao.Login(nombre_login, password)
    End Function



End Class
