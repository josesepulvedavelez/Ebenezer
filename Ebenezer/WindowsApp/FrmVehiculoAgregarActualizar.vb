Imports Entidades
Imports Negocio

Public Class FrmVehiculoAgregarActualizar
    Private vehiculoEnt As New VehiculoEnt()
    Private vehiculoBll As New VehiculoBll()
    Private vehiculoMantenimientoBll As New VehiculoMantenimientoBll()
    Private result As Boolean
    Private usuarioLog As String = FrmMenu.lblUsuario.Text

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
                vehiculoEnt.ClienteId = FrmCliente.dgv.CurrentRow.Cells("ClienteId").Value
                vehiculoEnt.UsuarioLog = usuarioLog

                result = vehiculoBll.AgregarVehiculo(vehiculoEnt)

                MessageBox.Show("Vehiculo agregado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                FrmCliente.dgvVehiculo.DataSource = vehiculoBll.ListarVehiculosById(FrmCliente.dgv.CurrentRow.Cells("ClienteId").Value)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

    End Sub
End Class