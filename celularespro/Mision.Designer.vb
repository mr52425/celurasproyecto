<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mision
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DADSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MisiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuienesSomosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CelularesproDataSet1 = New celularespro.celularesproDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CelularesproDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightCoral
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.ForeColor = System.Drawing.Color.LightCoral
        Me.Panel1.Location = New System.Drawing.Point(1, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1144, 72)
        Me.Panel1.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightCoral
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DADSToolStripMenuItem, Me.MisiónToolStripMenuItem, Me.VisiónToolStripMenuItem, Me.ValoresToolStripMenuItem, Me.QuienesSomosToolStripMenuItem, Me.ContactoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(284, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(767, 33)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DADSToolStripMenuItem
        '
        Me.DADSToolStripMenuItem.Name = "DADSToolStripMenuItem"
        Me.DADSToolStripMenuItem.Size = New System.Drawing.Size(70, 29)
        Me.DADSToolStripMenuItem.Text = "Inicio"
        '
        'MisiónToolStripMenuItem
        '
        Me.MisiónToolStripMenuItem.Name = "MisiónToolStripMenuItem"
        Me.MisiónToolStripMenuItem.Size = New System.Drawing.Size(81, 29)
        Me.MisiónToolStripMenuItem.Text = "Misión"
        '
        'VisiónToolStripMenuItem
        '
        Me.VisiónToolStripMenuItem.Name = "VisiónToolStripMenuItem"
        Me.VisiónToolStripMenuItem.Size = New System.Drawing.Size(76, 29)
        Me.VisiónToolStripMenuItem.Text = "Visión"
        '
        'ValoresToolStripMenuItem
        '
        Me.ValoresToolStripMenuItem.Name = "ValoresToolStripMenuItem"
        Me.ValoresToolStripMenuItem.Size = New System.Drawing.Size(85, 29)
        Me.ValoresToolStripMenuItem.Text = "Valores"
        '
        'QuienesSomosToolStripMenuItem
        '
        Me.QuienesSomosToolStripMenuItem.Name = "QuienesSomosToolStripMenuItem"
        Me.QuienesSomosToolStripMenuItem.Size = New System.Drawing.Size(167, 29)
        Me.QuienesSomosToolStripMenuItem.Text = "¿Quienes somos?"
        '
        'ContactoToolStripMenuItem
        '
        Me.ContactoToolStripMenuItem.Name = "ContactoToolStripMenuItem"
        Me.ContactoToolStripMenuItem.Size = New System.Drawing.Size(100, 29)
        Me.ContactoToolStripMenuItem.Text = "Contacto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label1.Font = New System.Drawing.Font("Engravers MT", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(383, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tecnología MEX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label2.Font = New System.Drawing.Font("Engravers MT", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(595, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Catálogo de celulares"
        '
        'CelularesproDataSet1
        '
        Me.CelularesproDataSet1.DataSetName = "celularesproDataSet"
        Me.CelularesproDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label3.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(595, 234)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Catálogo "
        '
        'Mision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(1140, 748)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Mision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mision"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CelularesproDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DADSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MisiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuienesSomosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CelularesproDataSet1 As celularesproDataSet
    Friend WithEvents Label3 As Label
End Class
