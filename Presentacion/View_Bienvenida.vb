﻿Imports Entidades
Public Class View_Bienvenida
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Formulario_Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuario_Bienvenido.Text = E_Empleado.nombre & " " & E_Empleado.apellido
        ProgressBar1.Value = 0
        Me.Opacity = 0
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            Timer2.Stop()
            Me.Close()
        End If
    End Sub

End Class