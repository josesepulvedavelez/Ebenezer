Imports System.Configuration
Imports Entidades
Imports Negocio
Imports Utilidades

Public Class FrmVehiculo
    Private vehiculoEnt As New VehiculoEnt()
    Private vehiculoBll As New VehiculoBll()
    Private vehiculoMantenimientoBll As New VehiculoMantenimientoBll()
    Private result As Boolean
    Private usuarioLog As String = FrmMenu.lblUsuario.Text

    Private Sub FrmVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvVehiculo.DataSource = vehiculoBll.ListarVehiculos()
        dgvVehiculo.Columns("ClienteId").Visible = False
        dgvVehiculo.Columns("VehiculoId").Visible = False

        cboCliente.DataSource = vehiculoBll.ListarClientesId()
        cboCliente.DisplayMember = "Cliente"
        cboCliente.ValueMember = "ClienteId"

        ComboBox1.DataSource = dgvVehiculo.DataSource
        ComboBox1.DisplayMember = "Placa"
        ComboBox1.ValueMember = "VehiculoId"
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        Dim vehiculoId As Integer = dgvVehiculo.CurrentRow.Cells("VehiculoId").Value

        If TabControl1.SelectedIndex = 1 Then
            dgvMantenimiento.DataSource = vehiculoMantenimientoBll.ListarMantenimientosById(vehiculoId)
            dgvMantenimiento.Columns("Actividades").Width = 300

            dgvMantenimiento.Columns("Cliente").Visible = False
            dgvMantenimiento.Columns("ClienteId").Visible = False
            dgvMantenimiento.Columns("Placa").Visible = False
            dgvMantenimiento.Columns("VehiculoId").Visible = False
            dgvMantenimiento.Columns("Garantia").Visible = False
            dgvMantenimiento.Columns("VehiculoMantenimientoId").Visible = False
        Else
            dgvMantenimiento.DataSource = Nothing
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dtpFecha.Value = DateTime.Now
        txtPlaca.Text = String.Empty
        txtMarca.Text = String.Empty
        txtModelo.Text = String.Empty
        dtpGarantia.Value = DateTime.Now

        txtPlaca.Focus()
        btnNuevo.Enabled = False
        btnAgregar.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtPlaca.Text = String.Empty Or txtMarca.Text = String.Empty Then
            MessageBox.Show("Placa o marca no pueden estar vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                vehiculoEnt.Fecha = dtpFecha.Value
                vehiculoEnt.Placa = txtPlaca.Text
                vehiculoEnt.Marca = txtMarca.Text
                vehiculoEnt.Modelo = txtModelo.Text
                vehiculoEnt.Garantia = dtpGarantia.Value
                vehiculoEnt.Notas = txtNotas.Text
                vehiculoEnt.ClienteId = cboCliente.SelectedValue
                vehiculoEnt.UsuarioLog = usuarioLog

                result = vehiculoBll.AgregarVehiculo(vehiculoEnt)

                MessageBox.Show("Vehiculo agregado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgvVehiculo.DataSource = vehiculoBll.ListarVehiculos()

                ComboBox1.DataSource = dgvVehiculo.DataSource
                ComboBox1.DisplayMember = "Placa"
                ComboBox1.ValueMember = "VehiculoId"

                btnNuevo.Enabled = True
                btnAgregar.Enabled = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtPlaca.Text = String.Empty Or txtMarca.Text = String.Empty Then
            MessageBox.Show("Placa o marca no pueden estar vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                vehiculoEnt.Fecha = dtpFecha.Value
                vehiculoEnt.Placa = txtPlaca.Text
                vehiculoEnt.Marca = txtMarca.Text
                vehiculoEnt.Modelo = txtModelo.Text
                vehiculoEnt.Garantia = dtpGarantia.Value
                vehiculoEnt.Notas = txtNotas.Text
                vehiculoEnt.VehiculoId = dgvVehiculo.CurrentRow.Cells("VehiculoId").Value
                vehiculoEnt.ClienteId = cboCliente.SelectedValue

                result = vehiculoBll.ActualizarVehiculo(vehiculoEnt)

                MessageBox.Show("Vehiculo actualizado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgvVehiculo.DataSource = vehiculoBll.ListarVehiculos()

                ComboBox1.DataSource = dgvVehiculo.DataSource
                ComboBox1.DisplayMember = "Placa"
                ComboBox1.ValueMember = "VehiculoId"

                btnNuevo.Enabled = True
                btnAgregar.Enabled = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim excel As New ExportarExcel()
        excel.Exportar(dgvVehiculo)
    End Sub

    Private Sub dgvVehiculo_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVehiculo.SelectionChanged
        dtpFecha.Value = dgvVehiculo.CurrentRow.Cells("Fecha").Value
        txtPlaca.Text = dgvVehiculo.CurrentRow.Cells("Placa").Value
        txtMarca.Text = dgvVehiculo.CurrentRow.Cells("Marca").Value
        txtModelo.Text = dgvVehiculo.CurrentRow.Cells("Modelo").Value
        dtpGarantia.Value = dgvVehiculo.CurrentRow.Cells("Garantia").Value
        txtNotas.Text = dgvVehiculo.CurrentRow.Cells("Notas").Value
        cboCliente.Text = dgvVehiculo.CurrentRow.Cells("Cliente").Value

        lblFilas.Text = dgvVehiculo.CurrentCell.RowIndex + 1 & " de " & vehiculoBll.ListarVehiculos.Count & " " & Me.Text.ToLower
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub btnAgregarMantenimiento_Click(sender As Object, e As EventArgs) Handles btnAgregarMantenimiento.Click
        FrmvehiculoMantenimientoAgregarActualizar.Show()
        FrmvehiculoMantenimientoAgregarActualizar.btnAgregar.Visible = True
    End Sub

    Private Sub btnMantenimientos_Click(sender As Object, e As EventArgs) Handles btnMantenimientos.Click
        Dim excel As New ExportarExcel()
        excel.Exportar(dgvMantenimiento)
    End Sub
End Class