Imports Entidades
Imports Negocio

Public Class FrmvehiculoMantenimientoAgregarActualizar
    Private vehiculoMantenimientoEnt As New VehiculoMantenimientoEnt()
    Private vehiculoMantenimientoBll As New VehiculoMantenimientoBll()
    Private result As Boolean
    Private usuarioLog As String = FrmMenu.lblUsuario.Text

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cboTipo.Text = String.Empty Or txtActividades.Text = String.Empty Then
            MessageBox.Show("Tipo, actividades y/o placa no pueden estar vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                vehiculoMantenimientoEnt.Fecha = dtpFecha.Value
                vehiculoMantenimientoEnt.Tipo = cboTipo.Text
                vehiculoMantenimientoEnt.PorGarantia = cboPorGarantia.Text
                vehiculoMantenimientoEnt.Actividades = txtActividades.Text

                If cboPorGarantia.Text <> "NO APLICA" And FrmVehiculo.dgvVehiculo.CurrentRow.Cells("Garantia").Value < dtpFecha.Value Then
                    txtNotas.Text += " Garantia vencida"
                End If

                vehiculoMantenimientoEnt.Notas = txtNotas.Text
                vehiculoMantenimientoEnt.Usuario = usuarioLog
                vehiculoMantenimientoEnt.VehiculoId = FrmVehiculo.dgvVehiculo.CurrentRow.Cells("VehiculoId").Value

                result = vehiculoMantenimientoBll.AgregarMantenimiento(vehiculoMantenimientoEnt)

                MessageBox.Show("Mantenimiento agregado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                FrmVehiculo.dgvMantenimiento.DataSource = vehiculoMantenimientoBll.ListarMantenimientosById(FrmVehiculo.dgvVehiculo.CurrentRow.Cells("VehiculoId").Value)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If cboTipo.Text = String.Empty Or txtActividades.Text = String.Empty Then
            MessageBox.Show("Tipo, actividades y/o placa no pueden estar vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                vehiculoMantenimientoEnt.Fecha = dtpFecha.Value
                vehiculoMantenimientoEnt.Tipo = cboTipo.Text
                vehiculoMantenimientoEnt.PorGarantia = cboPorGarantia.Text
                vehiculoMantenimientoEnt.Actividades = txtActividades.Text
                vehiculoMantenimientoEnt.Notas = txtNotas.Text
                vehiculoMantenimientoEnt.Usuario = usuarioLog
                vehiculoMantenimientoEnt.VehiculoId = FrmVehiculo.dgvVehiculo.CurrentRow.Cells("VehiculoId").Value
                vehiculoMantenimientoEnt.VehiculoMantenimientoId = FrmVehiculo.dgvMantenimiento.CurrentRow.Cells("VehiculoMantenimientoId").Value

                result = vehiculoMantenimientoBll.ActualizarMantenimiento(vehiculoMantenimientoEnt)

                MessageBox.Show("Mantenimiento actualizado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                FrmVehiculo.dgvMantenimiento.DataSource = vehiculoMantenimientoBll.ListarMantenimientosById(FrmVehiculo.dgvVehiculo.CurrentRow.Cells("VehiculoId").Value)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub
End Class