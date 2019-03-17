<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TablasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablaClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablaPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablaPedidosProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablaProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablaProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntoDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TablasToolStripMenuItem, Me.PuntoDeVentaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(631, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TablasToolStripMenuItem
        '
        Me.TablasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TablaClientesToolStripMenuItem, Me.TablaPedidosToolStripMenuItem, Me.TablaPedidosProductosToolStripMenuItem, Me.TablaProductosToolStripMenuItem, Me.TablaProveedorToolStripMenuItem})
        Me.TablasToolStripMenuItem.Name = "TablasToolStripMenuItem"
        Me.TablasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.TablasToolStripMenuItem.Text = "Tablas"
        '
        'TablaClientesToolStripMenuItem
        '
        Me.TablaClientesToolStripMenuItem.Name = "TablaClientesToolStripMenuItem"
        Me.TablaClientesToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.TablaClientesToolStripMenuItem.Text = "Tabla Clientes"
        '
        'TablaPedidosToolStripMenuItem
        '
        Me.TablaPedidosToolStripMenuItem.Name = "TablaPedidosToolStripMenuItem"
        Me.TablaPedidosToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.TablaPedidosToolStripMenuItem.Text = "Tabla Pedidos"
        '
        'TablaPedidosProductosToolStripMenuItem
        '
        Me.TablaPedidosProductosToolStripMenuItem.Name = "TablaPedidosProductosToolStripMenuItem"
        Me.TablaPedidosProductosToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.TablaPedidosProductosToolStripMenuItem.Text = "Tabla Pedidos Productos"
        '
        'TablaProductosToolStripMenuItem
        '
        Me.TablaProductosToolStripMenuItem.Name = "TablaProductosToolStripMenuItem"
        Me.TablaProductosToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.TablaProductosToolStripMenuItem.Text = "Tabla Productos"
        '
        'TablaProveedorToolStripMenuItem
        '
        Me.TablaProveedorToolStripMenuItem.Name = "TablaProveedorToolStripMenuItem"
        Me.TablaProveedorToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.TablaProveedorToolStripMenuItem.Text = "Tabla Proveedor"
        '
        'PuntoDeVentaToolStripMenuItem
        '
        Me.PuntoDeVentaToolStripMenuItem.Name = "PuntoDeVentaToolStripMenuItem"
        Me.PuntoDeVentaToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.PuntoDeVentaToolStripMenuItem.Text = "Punto de venta"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.SEO_44_300x300
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(631, 345)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 369)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagina principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TablasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PuntoDeVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablaClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablaPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablaPedidosProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablaProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablaProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
