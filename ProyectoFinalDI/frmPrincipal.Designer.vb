<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.lblCargando = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(84, 261)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(421, 23)
        Me.ProgressBar.TabIndex = 0
        '
        'lblCargando
        '
        Me.lblCargando.AutoSize = True
        Me.lblCargando.Location = New System.Drawing.Point(226, 299)
        Me.lblCargando.Name = "lblCargando"
        Me.lblCargando.Size = New System.Drawing.Size(125, 13)
        Me.lblCargando.TabIndex = 2
        Me.lblCargando.Text = "Cargando tu aplicación..."
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(245, 322)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 3
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        Me.btnIniciar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoFinalDI.My.Resources.Iconos.LOLprincipal
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(541, 231)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 40
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 365)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.lblCargando)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrincipal"
        Me.Text = "League of Legends"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCargando As Label
    Friend WithEvents btnIniciar As Button
    Friend WithEvents Timer As Timer
End Class
