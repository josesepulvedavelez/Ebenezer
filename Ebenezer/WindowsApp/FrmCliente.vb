Imports System.Configuration
Imports Entidades
Imports Negocio
Imports Utilidades

Public Class FrmCliente
    Private clienteEnt As New ClienteEnt()
    Private clienteBll As New ClienteBll()
    Private vehiculoBll As New VehiculoBll()
    Private result As Boolean
    Private usuarioLog As String = FrmMenu.lblUsuario.Text

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.DataSource = clienteBll.ListarClientes
        dgv.Columns("ClienteId").Visible = False

        cboBusqueda.DataSource = dgv.DataSource
        cboBusqueda.DisplayMember = "Cliente"
        cboBusqueda.ValueMember = "ClienteId"
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        Dim clienteId As Integer = dgv.CurrentRow.Cells("ClienteId").Value

        If TabControl1.SelectedIndex = 1 Then
            dgvVehiculo.DataSource = vehiculoBll.ListarVehiculosById(clienteId)
            dgvVehiculo.Columns("Cliente").Visible = False
            dgvVehiculo.Columns("ClienteId").Visible = False
            dgvVehiculo.Columns("VehiculoId").Visible = False
        Else
            dgvVehiculo.DataSource = Nothing
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dtpFecha.Value = DateTime.Now
        txtCliente.Text = String.Empty
        txtNit.Text = String.Empty
        txtDireccion.Text = String.Empty
        txtContacto.Text = String.Empty
        txtTelefonos.Text = String.Empty
        txtCorreo.Text = String.Empty
        txtNotas.Text = "NINGUNA"

        txtCliente.Focus()

        btnNuevo.Enabled = False
        btnAgregar.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCliente.Text = String.Empty Or txtNit.Text = String.Empty Then
            MessageBox.Show("Nombre de cliente o nit vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                clienteEnt.Fecha = dtpFecha.Value
                clienteEnt.Cliente = txtCliente.Text
                clienteEnt.NitCc = txtNit.Text
                clienteEnt.Direccion = txtDireccion.Text
                clienteEnt.Contacto = txtContacto.Text
                clienteEnt.Telefonos = txtTelefonos.Text
                clienteEnt.Correo = txtCorreo.Text
                clienteEnt.Notas = txtNotas.Text
                clienteEnt.UsuarioLog = usuarioLog

                result = clienteBll.AgregarCliente(clienteEnt)

                MessageBox.Show("Cliente/empresa agregado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgv.DataSource = clienteBll.ListarClientes()

                cboBusqueda.DataSource = dgv.DataSource
                cboBusqueda.DisplayMember = "Cliente"
                cboBusqueda.ValueMember = "ClienteId"

                btnNuevo.Enabled = True
                btnAgregar.Enabled = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtCliente.Text = String.Empty Or txtNit.Text = String.Empty Then
            MessageBox.Show("Nombre de cliente o nit vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                clienteEnt.Fecha = dtpFecha.Value
                clienteEnt.Cliente = txtCliente.Text
                clienteEnt.NitCc = txtNit.Text
                clienteEnt.Direccion = txtDireccion.Text
                clienteEnt.Contacto = txtContacto.Text
                clienteEnt.Telefonos = txtTelefonos.Text
                clienteEnt.Correo = txtCorreo.Text
                clienteEnt.Notas = txtNotas.Text
                clienteEnt.ClienteId = dgv.CurrentRow.Cells("ClienteId").Value

                result = clienteBll.ActualizarCliente(clienteEnt)

                MessageBox.Show("Cliente/empresa actualizado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgv.DataSource = clienteBll.ListarClientes()

                cboBusqueda.DataSource = dgv.DataSource
                cboBusqueda.DisplayMember = "Cliente"
                cboBusqueda.ValueMember = "ClienteId"

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
        dtpFecha.Value = dgv.CurrentRow.Cells("fecha").Value
        txtCliente.Text = dgv.CurrentRow.Cells("Cliente").Value
        txtNit.Text = dgv.CurrentRow.Cells("NitCc").Value
        txtDireccion.Text = dgv.CurrentRow.Cells("Direccion").Value
        txtContacto.Text = dgv.CurrentRow.Cells("Contacto").Value
        txtTelefonos.Text = dgv.CurrentRow.Cells("Telefonos").Value
        txtCorreo.Text = dgv.CurrentRow.Cells("Correo").Value
        txtNotas.Text = dgv.CurrentRow.Cells("Notas").Value

        lblFilas.Text = dgv.CurrentCell.RowIndex + 1 & " de " & clienteBll.ListarClientes.Count & " " & Me.Text.ToLower
    End Sub

    Private Sub cboBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBusqueda.SelectedIndexChanged
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub btnAgregarVehiculo_Click(sender As Object, e As EventArgs) Handles btnAgregarVehiculo.Click
        FrmVehiculoAgregarActualizar.Show()
        FrmVehiculoAgregarActualizar.btnAgregar.Visible = True
    End Sub

    Private Sub btnExcelVehiculos_Click(sender As Object, e As EventArgs) Handles btnExcelVehiculos.Click
        Dim excel As New ExportarExcel()
        excel.Exportar(dgvVehiculo)
    End Sub
End Class