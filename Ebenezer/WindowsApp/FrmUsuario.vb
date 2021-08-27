Imports System.Configuration
Imports Entidades
Imports Negocio

Public Class FrmUsuario
    Private usuarioEnt As New UsuarioEnt
    Private usuarioBll As New UsuarioBll
    Private result As Boolean

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.DataSource = usuarioBll.ListarUsuarios
        dgv.Columns("Nombres").Width = 320
        dgv.Columns("UsuarioId").Visible = False

        cboBusqueda.DataSource = dgv.DataSource
        cboBusqueda.DisplayMember = "Nombres"
        cboBusqueda.ValueMember = "UsuarioId"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtUsuario.Text = String.Empty
        txtContraseña.Text = String.Empty
        txtNombres.Text = String.Empty
        cboRol.Text = "ADMINISTRADOR"
        txtUsuario.Focus()

        btnNuevo.Enabled = False
        btnAgregar.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtUsuario.Text = String.Empty Or txtContraseña.Text = String.Empty Or txtNombres.Text = String.Empty Then
            MessageBox.Show("Usuario, contraseña o rol vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                usuarioEnt.Usuario = txtUsuario.Text
                usuarioEnt.Contraseña = txtContraseña.Text
                usuarioEnt.Nombres = txtNombres.Text
                usuarioEnt.Rol = cboRol.Text

                result = usuarioBll.AgregarUsuario(usuarioEnt)

                MessageBox.Show("Usuario agregado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgv.DataSource = usuarioBll.ListarUsuarios

                cboBusqueda.DataSource = dgv.DataSource
                cboBusqueda.DisplayMember = "Nombres"
                cboBusqueda.ValueMember = "UsuarioId"

                btnNuevo.Enabled = True
                btnAgregar.Enabled = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtUsuario.Text = String.Empty Or txtContraseña.Text = String.Empty Or txtNombres.Text = String.Empty Then
            MessageBox.Show("Usuario, contraseña o rol vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                usuarioEnt.Usuario = txtUsuario.Text
                usuarioEnt.Contraseña = txtContraseña.Text
                usuarioEnt.Nombres = txtNombres.Text
                usuarioEnt.Rol = cboRol.Text
                usuarioEnt.UsuarioId = dgv.CurrentRow.Cells("UsuarioId").Value

                result = usuarioBll.ActualizarUsuario(usuarioEnt)

                MessageBox.Show("Usuario actualizado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgv.DataSource = usuarioBll.ListarUsuarios

                cboBusqueda.DataSource = dgv.DataSource
                cboBusqueda.DisplayMember = "Nombres"
                cboBusqueda.ValueMember = "UsuarioId"

                btnNuevo.Enabled = True
                btnAgregar.Enabled = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        txtUsuario.Text = dgv.CurrentRow.Cells("Usuario").Value
        txtContraseña.Text = dgv.CurrentRow.Cells("Contraseña").Value
        txtNombres.Text = dgv.CurrentRow.Cells("Nombres").Value
        cboRol.Text = dgv.CurrentRow.Cells("Rol").Value

        lblFilas.Text = dgv.CurrentCell.RowIndex + 1 & " de " & usuarioBll.ListarUsuarios.Count & " " & Me.Text.ToLower
    End Sub

    Private Sub dgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting
        If dgv.Columns(e.ColumnIndex).Name = “Contraseña” And e.Value <> Nothing Then
            dgv.Rows(e.RowIndex).Tag = e.Value
            e.Value = New String("*", e.Value.ToString().Length)
        End If
    End Sub

    Private Sub chkVerContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles chkVerContraseña.CheckedChanged
        If chkVerContraseña.CheckState = CheckState.Checked Then
            MessageBox.Show(txtContraseña.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            chkVerContraseña.CheckState = False
        End If
    End Sub
End Class
