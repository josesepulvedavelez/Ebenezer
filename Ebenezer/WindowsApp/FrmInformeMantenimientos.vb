Imports Negocio
Imports Entidades
Imports Utilidades

Public Class FrmInformeMantenimientos
    Private vehiculoMantenimientoEnt As New VehiculoMantenimientoEnt()
    Private vehiculoMantenimientoBll As New VehiculoMantenimientoBll()
    Private vehiculoBll As New VehiculoBll()
    Private result As Boolean
    Private usuarioLog As String = FrmMenu.lblUsuario.Text
    Private rol As String = FrmMenu.lblRol.Text

    Private Sub FrmInformeMantenimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.DataSource = vehiculoMantenimientoBll.ListarMantenimientos()
        dgv.Columns("ClienteId").Visible = False
        dgv.Columns("VehiculoId").Visible = False
        dgv.Columns("VehiculoMantenimientoId").Visible = False

        cboCliente.DataSource = vehiculoBll.ListarClientesId()
        cboCliente.DisplayMember = "Cliente"
        cboCliente.ValueMember = "ClienteId"
    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        lblFilas.Text = dgv.CurrentCell.RowIndex + 1 & " de " & dgv.Rows.Count & " " & Me.Text.ToLower
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim fechaIni As String = dtpDesde.Value.ToString("yyyy-MM-dd")
        Dim fechaFin As String = dtpHasta.Value.ToString("yyyy-MM-dd")
        Dim clienteId As Int32 = cboCliente.SelectedValue

        Try
            dgv.DataSource = vehiculoMantenimientoBll.ListarMantenimientosByDate(fechaIni, fechaFin, clienteId)
            dgv.Columns("ClienteId").Visible = False
            dgv.Columns("VehiculoId").Visible = False
            dgv.Columns("VehiculoMantenimientoId").Visible = False

            'lblFilas.Text = dgv.CurrentCell.RowIndex + 1 & " de " & dgv.Rows.Count & " " & Me.Text.ToLower
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnReestablecer_Click(sender As Object, e As EventArgs) Handles btnReestablecer.Click
        dgv.DataSource = vehiculoMantenimientoBll.ListarMantenimientos()
        dgv.Columns("ClienteId").Visible = False
        dgv.Columns("VehiculoId").Visible = False
        dgv.Columns("VehiculoMantenimientoId").Visible = False

        cboCliente.DataSource = vehiculoBll.ListarClientesId()
        cboCliente.DisplayMember = "Cliente"
        cboCliente.ValueMember = "ClienteId"
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim excel As New ExportarExcel()
        excel.Exportar(dgv)
    End Sub
End Class