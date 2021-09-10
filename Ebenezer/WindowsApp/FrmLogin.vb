Imports System.Configuration
Imports Entidades
Imports Negocio

Public Class FrmLogin
    Private usuarioEnt As New UsuarioEnt
    Private usuarioBll As New UsuarioBll
    Private result As Boolean
    Friend login As String

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = ConfigurationManager.AppSettings("Empresa")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsuario.Text = String.Empty Or txtContraseña.Text = String.Empty Then
            MessageBox.Show("Usuario, contraseña o rol vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            usuarioEnt.Usuario = txtUsuario.Text
            usuarioEnt.Contraseña = txtContraseña.Text
            usuarioEnt.Rol = cboRol.Text

            result = usuarioBll.Loguear(usuarioEnt)

            If result = True Then
                Me.txtContraseña.Text = String.Empty

                FrmMenu.lblUsuario.Text = usuarioEnt.Usuario
                FrmMenu.lblRol.Text = usuarioEnt.Rol
                FrmMenu.Show()
            Else
                MessageBox.Show("Usuario, contraseña o rol incorrectos", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.ExitThread()
    End Sub
End Class