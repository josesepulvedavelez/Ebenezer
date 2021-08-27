Imports System.Configuration
Imports Entidades
Imports Negocio
Imports Utilidades

Public Class FrmVehiculoMantenimiento
    Private vehiculoMantenimientoEnt As New VehiculoMantenimientoEnt()
    Private vehiculoMantenimientoBll As New VehiculoMantenimientoBll()
    Private result As Boolean
    Private usuarioLog As String = FrmMenu.lblUsuario.Text
    Private rol As String = FrmMenu.lblRol.Text

    Private Sub FrmVehiculoMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.DataSource = vehiculoMantenimientoBll.ListarMantenimientos()
        dgv.Columns("ClienteId").Visible = False
        dgv.Columns("VehiculoId").Visible = False
        dgv.Columns("VehiculoMantenimientoId").Visible = False

        cboVehiculo.DataSource = vehiculoMantenimientoBll.ListarVehiculosId()
        cboVehiculo.DisplayMember = "Placa"
        cboVehiculo.ValueMember = "VehiculoId"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dtpFecha.Value = DateTime.Now()
        cboTipo.Text = "INSTALACION"
        txtActividades.Text = String.Empty
        txtNotas.Text = String.Empty
        'cboPorGarantia.Text = "MANO DE OBRA"
        cboTipo.Focus()

        btnNuevo.Enabled = False
        btnAgregar.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cboTipo.Text = String.Empty Or txtActividades.Text = String.Empty Or cboVehiculo.Text = String.Empty Then
            MessageBox.Show("Tipo, actividades y/o placa no pueden estar vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                vehiculoMantenimientoEnt.Fecha = dtpFecha.Value
                vehiculoMantenimientoEnt.Tipo = cboTipo.Text
                vehiculoMantenimientoEnt.PorGarantia = cboPorGarantia.Text
                vehiculoMantenimientoEnt.Actividades = txtActividades.Text

                If cboPorGarantia.Text <> "NO APLICA" And dgv.CurrentRow.Cells("Garantia").Value < dtpFecha.Value Then
                    txtNotas.Text += " Garantia vencida"
                End If

                vehiculoMantenimientoEnt.Notas = txtNotas.Text

                vehiculoMantenimientoEnt.VehiculoId = cboVehiculo.SelectedValue
                vehiculoMantenimientoEnt.Usuario = usuarioLog

                result = vehiculoMantenimientoBll.AgregarMantenimiento(vehiculoMantenimientoEnt)

                MessageBox.Show("Mantenimiento agregado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgv.DataSource = vehiculoMantenimientoBll.ListarMantenimientos()
                btnNuevo.Enabled = True
                btnAgregar.Enabled = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If cboTipo.Text = String.Empty Or txtActividades.Text = String.Empty Or cboVehiculo.Text = String.Empty Then
            MessageBox.Show("Tipo, actividades y/o placa no pueden estar vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                vehiculoMantenimientoEnt.Fecha = dtpFecha.Value
                vehiculoMantenimientoEnt.Tipo = cboTipo.Text
                vehiculoMantenimientoEnt.PorGarantia = cboPorGarantia.Text
                vehiculoMantenimientoEnt.Actividades = txtActividades.Text
                vehiculoMantenimientoEnt.Notas = txtNotas.Text
                vehiculoMantenimientoEnt.VehiculoId = cboVehiculo.SelectedValue
                vehiculoMantenimientoEnt.Usuario = usuarioLog
                vehiculoMantenimientoEnt.VehiculoMantenimientoId = dgv.CurrentRow.Cells("VehiculoMantenimientoId").Value

                result = vehiculoMantenimientoBll.ActualizarMantenimiento(vehiculoMantenimientoEnt)

                MessageBox.Show("Mantenimiento actualizado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgv.DataSource = vehiculoMantenimientoBll.ListarMantenimientos()
                btnNuevo.Enabled = True
                btnAgregar.Enabled = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim excel As New ExportarExcel()
        excel.Exportar(dgv)
    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        dtpFecha.Value = dgv.CurrentRow.Cells("Fecha").Value
        cboTipo.Text = dgv.CurrentRow.Cells("Tipo").Value
        txtActividades.Text = dgv.CurrentRow.Cells("Actividades").Value
        txtNotas.Text = dgv.CurrentRow.Cells("Notas").Value
        cboVehiculo.Text = dgv.CurrentRow.Cells("Placa").Value
        cboPorGarantia.Text = dgv.CurrentRow.Cells("PorGarantia").Value

        If usuarioLog = dgv.CurrentRow.Cells("Usuario").Value And rol = "TECNICO" Or rol = "ADMINISTRADOR" Then
            btnActualizar.Enabled = True
        Else
            btnActualizar.Enabled = False
        End If
    End Sub


End Class