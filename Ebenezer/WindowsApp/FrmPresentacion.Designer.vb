<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPresentacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPresentacion))
        Me.pgbBarra = New System.Windows.Forms.ProgressBar()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblNombreApp = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgbBarra
        '
        Me.pgbBarra.Location = New System.Drawing.Point(32, 599)
        Me.pgbBarra.Name = "pgbBarra"
        Me.pgbBarra.Size = New System.Drawing.Size(415, 12)
        Me.pgbBarra.TabIndex = 0
        Me.pgbBarra.Visible = False
        '
        'pic
        '
        Me.pic.Image = CType(resources.GetObject("pic.Image"), System.Drawing.Image)
        Me.pic.Location = New System.Drawing.Point(39, 26)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(377, 530)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic.TabIndex = 1
        Me.pic.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTitulo.Location = New System.Drawing.Point(47, 614)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(79, 25)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "lblTitulo"
        '
        'Timer1
        '
        '
        'lblNombreApp
        '
        Me.lblNombreApp.AutoSize = True
        Me.lblNombreApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreApp.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblNombreApp.Location = New System.Drawing.Point(147, 571)
        Me.lblNombreApp.Name = "lblNombreApp"
        Me.lblNombreApp.Size = New System.Drawing.Size(77, 25)
        Me.lblNombreApp.TabIndex = 3
        Me.lblNombreApp.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(139, 660)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FrmPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 752)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNombreApp)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.pgbBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPresentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pgbBarra As ProgressBar
    Friend WithEvents pic As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblNombreApp As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
