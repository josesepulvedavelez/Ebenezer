<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.btnUsuario = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab2 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel2 = New System.Windows.Forms.RibbonPanel()
        Me.btnCliente = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel3 = New System.Windows.Forms.RibbonPanel()
        Me.btnVehivulo = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel4 = New System.Windows.Forms.RibbonPanel()
        Me.btnMantenimientos = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab3 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel5 = New System.Windows.Forms.RibbonPanel()
        Me.btnInformeMantenimientos = New System.Windows.Forms.RibbonButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblRol = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.temporalizador = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 72)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(1185, 176)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab2)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab3)
        Me.Ribbon1.Text = "Ribbon1"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTab1.Text = "Usuarios"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.btnUsuario)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Text = ""
        '
        'btnUsuario
        '
        Me.btnUsuario.Image = CType(resources.GetObject("btnUsuario.Image"), System.Drawing.Image)
        Me.btnUsuario.LargeImage = CType(resources.GetObject("btnUsuario.LargeImage"), System.Drawing.Image)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.SmallImage = CType(resources.GetObject("btnUsuario.SmallImage"), System.Drawing.Image)
        Me.btnUsuario.Text = "Usuarios"
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Name = "RibbonTab2"
        Me.RibbonTab2.Panels.Add(Me.RibbonPanel2)
        Me.RibbonTab2.Panels.Add(Me.RibbonPanel3)
        Me.RibbonTab2.Panels.Add(Me.RibbonPanel4)
        Me.RibbonTab2.Text = "Operacion"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.Items.Add(Me.btnCliente)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Text = ""
        '
        'btnCliente
        '
        Me.btnCliente.Image = CType(resources.GetObject("btnCliente.Image"), System.Drawing.Image)
        Me.btnCliente.LargeImage = CType(resources.GetObject("btnCliente.LargeImage"), System.Drawing.Image)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.SmallImage = CType(resources.GetObject("btnCliente.SmallImage"), System.Drawing.Image)
        Me.btnCliente.Text = "Clientes"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.Items.Add(Me.btnVehivulo)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Text = ""
        '
        'btnVehivulo
        '
        Me.btnVehivulo.Image = CType(resources.GetObject("btnVehivulo.Image"), System.Drawing.Image)
        Me.btnVehivulo.LargeImage = CType(resources.GetObject("btnVehivulo.LargeImage"), System.Drawing.Image)
        Me.btnVehivulo.Name = "btnVehivulo"
        Me.btnVehivulo.SmallImage = CType(resources.GetObject("btnVehivulo.SmallImage"), System.Drawing.Image)
        Me.btnVehivulo.Text = "Vehiculos"
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.Items.Add(Me.btnMantenimientos)
        Me.RibbonPanel4.Name = "RibbonPanel4"
        Me.RibbonPanel4.Text = ""
        '
        'btnMantenimientos
        '
        Me.btnMantenimientos.Image = CType(resources.GetObject("btnMantenimientos.Image"), System.Drawing.Image)
        Me.btnMantenimientos.LargeImage = CType(resources.GetObject("btnMantenimientos.LargeImage"), System.Drawing.Image)
        Me.btnMantenimientos.Name = "btnMantenimientos"
        Me.btnMantenimientos.SmallImage = CType(resources.GetObject("btnMantenimientos.SmallImage"), System.Drawing.Image)
        Me.btnMantenimientos.Text = "Mantenimientos"
        '
        'RibbonTab3
        '
        Me.RibbonTab3.Name = "RibbonTab3"
        Me.RibbonTab3.Panels.Add(Me.RibbonPanel5)
        Me.RibbonTab3.Text = "Informes"
        '
        'RibbonPanel5
        '
        Me.RibbonPanel5.Items.Add(Me.btnInformeMantenimientos)
        Me.RibbonPanel5.Name = "RibbonPanel5"
        Me.RibbonPanel5.Text = ""
        '
        'btnInformeMantenimientos
        '
        Me.btnInformeMantenimientos.Image = CType(resources.GetObject("btnInformeMantenimientos.Image"), System.Drawing.Image)
        Me.btnInformeMantenimientos.LargeImage = CType(resources.GetObject("btnInformeMantenimientos.LargeImage"), System.Drawing.Image)
        Me.btnInformeMantenimientos.Name = "btnInformeMantenimientos"
        Me.btnInformeMantenimientos.SmallImage = CType(resources.GetObject("btnInformeMantenimientos.SmallImage"), System.Drawing.Image)
        Me.btnInformeMantenimientos.Text = "Mantenimientos"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsuario, Me.ToolStripStatusLabel4, Me.lblRol, Me.ToolStripStatusLabel2, Me.lblFecha, Me.ToolStripStatusLabel3, Me.lblHora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 631)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1185, 26)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(62, 20)
        Me.ToolStripStatusLabel1.Text = "Usuario:"
        '
        'lblUsuario
        '
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(59, 20)
        Me.lblUsuario.Text = "Usuario"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(34, 20)
        Me.ToolStripStatusLabel4.Text = "Rol:"
        '
        'lblRol
        '
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(31, 20)
        Me.lblRol.Text = "Rol"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripStatusLabel2.Text = "Fecha:"
        '
        'lblFecha
        '
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(47, 20)
        Me.lblFecha.Text = "Fecha"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(45, 20)
        Me.ToolStripStatusLabel3.Text = "Hora:"
        '
        'lblHora
        '
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(42, 20)
        Me.lblHora.Text = "Hora"
        '
        'temporalizador
        '
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 657)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Ribbon1)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "FrmMenu"
        Me.Text = "MENU PRINCIPAL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ribbon1 As Ribbon
    Friend WithEvents RibbonTab1 As RibbonTab
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents btnUsuario As RibbonButton
    Friend WithEvents RibbonTab2 As RibbonTab
    Friend WithEvents RibbonPanel2 As RibbonPanel
    Friend WithEvents RibbonPanel3 As RibbonPanel
    Friend WithEvents RibbonPanel4 As RibbonPanel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblUsuario As ToolStripStatusLabel
    Friend WithEvents lblFecha As ToolStripStatusLabel
    Friend WithEvents lblHora As ToolStripStatusLabel
    Friend WithEvents temporalizador As Timer
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents lblRol As ToolStripStatusLabel
    Friend WithEvents btnCliente As RibbonButton
    Friend WithEvents btnVehivulo As RibbonButton
    Friend WithEvents btnMantenimientos As RibbonButton
    Friend WithEvents RibbonTab3 As RibbonTab
    Friend WithEvents RibbonPanel5 As RibbonPanel
    Friend WithEvents btnInformeMantenimientos As RibbonButton
End Class
