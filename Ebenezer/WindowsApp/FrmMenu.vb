Public Class FrmMenu
    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        temporalizador.Enabled = True

        If lblRol.Text = "TECNICO" Then
            RibbonTab1.Visible = False
            FrmCliente.btnActualizar.Visible = False
            FrmVehiculo.btnActualizar.Visible = False
        End If
    End Sub

    Private Sub temporalizador_Tick(sender As Object, e As EventArgs) Handles temporalizador.Tick
        lblFecha.Text = DateTime.Now.ToShortDateString()
        lblHora.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        FrmUsuario.MdiParent = Me
        FrmUsuario.Show()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        FrmCliente.MdiParent = Me
        FrmCliente.Show()
    End Sub

    Private Sub btnVehivulo_Click(sender As Object, e As EventArgs) Handles btnVehivulo.Click
        FrmVehiculo.MdiParent = Me
        FrmVehiculo.Show()
    End Sub

    Private Sub btnMantenimientos_CanvasChanged(sender As Object, e As EventArgs) Handles btnMantenimientos.CanvasChanged

    End Sub

    Private Sub btnMantenimientos_Click(sender As Object, e As EventArgs) Handles btnMantenimientos.Click
        FrmVehiculoMantenimiento.MdiParent = Me
        FrmVehiculoMantenimiento.Show()
    End Sub

    Private Sub btnInformeMantenimientos_Click(sender As Object, e As EventArgs) Handles btnInformeMantenimientos.Click
        FrmInformeMantenimientos.MdiParent = Me
        FrmInformeMantenimientos.Show()
    End Sub
End Class