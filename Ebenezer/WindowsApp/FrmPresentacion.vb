Imports System.Configuration

Public Class FrmPresentacion
    Private Sub FrmPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = ConfigurationManager.AppSettings("Empresa")
        lblNombreApp.Text = ConfigurationManager.AppSettings("NompreApp")
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pgbBarra.Value <= 70 Then
            pgbBarra.Value += 1
        Else
            FrmLogin.Show()
            Me.Hide()
        End If
    End Sub
End Class