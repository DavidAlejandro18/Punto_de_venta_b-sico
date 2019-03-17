<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim COD_PRODUCTOLabel As System.Windows.Forms.Label
        Dim NOMBRE_PRODLabel As System.Windows.Forms.Label
        Dim PRECIOV_PRODLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TABLA_PRODUCTOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TABLA_PRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FerreteriaDataSet = New WindowsApplication1.FerreteriaDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TABLA_PRODUCTOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.COD_PRODUCTOTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRE_PRODTextBox = New System.Windows.Forms.TextBox()
        Me.PRECIOV_PRODTextBox = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfactura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttotalgeneral = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TABLA_PRODUCTOSTableAdapter = New WindowsApplication1.FerreteriaDataSetTableAdapters.TABLA_PRODUCTOSTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager()
        Me.FACTURATableAdapter = New WindowsApplication1.FerreteriaDataSetTableAdapters.FACTURATableAdapter()
        Me.FACTURABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        COD_PRODUCTOLabel = New System.Windows.Forms.Label()
        NOMBRE_PRODLabel = New System.Windows.Forms.Label()
        PRECIOV_PRODLabel = New System.Windows.Forms.Label()
        CType(Me.TABLA_PRODUCTOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TABLA_PRODUCTOSBindingNavigator.SuspendLayout()
        CType(Me.TABLA_PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTURABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'COD_PRODUCTOLabel
        '
        COD_PRODUCTOLabel.AutoSize = True
        COD_PRODUCTOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        COD_PRODUCTOLabel.Location = New System.Drawing.Point(13, 40)
        COD_PRODUCTOLabel.Name = "COD_PRODUCTOLabel"
        COD_PRODUCTOLabel.Size = New System.Drawing.Size(52, 16)
        COD_PRODUCTOLabel.TabIndex = 1
        COD_PRODUCTOLabel.Text = "Código"
        '
        'NOMBRE_PRODLabel
        '
        NOMBRE_PRODLabel.AutoSize = True
        NOMBRE_PRODLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NOMBRE_PRODLabel.Location = New System.Drawing.Point(176, 40)
        NOMBRE_PRODLabel.Name = "NOMBRE_PRODLabel"
        NOMBRE_PRODLabel.Size = New System.Drawing.Size(65, 16)
        NOMBRE_PRODLabel.TabIndex = 3
        NOMBRE_PRODLabel.Text = "Producto:"
        '
        'PRECIOV_PRODLabel
        '
        PRECIOV_PRODLabel.AutoSize = True
        PRECIOV_PRODLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PRECIOV_PRODLabel.Location = New System.Drawing.Point(353, 40)
        PRECIOV_PRODLabel.Name = "PRECIOV_PRODLabel"
        PRECIOV_PRODLabel.Size = New System.Drawing.Size(50, 16)
        PRECIOV_PRODLabel.TabIndex = 7
        PRECIOV_PRODLabel.Text = "Precio:"
        '
        'TABLA_PRODUCTOSBindingNavigator
        '
        Me.TABLA_PRODUCTOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TABLA_PRODUCTOSBindingNavigator.BindingSource = Me.TABLA_PRODUCTOSBindingSource
        Me.TABLA_PRODUCTOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TABLA_PRODUCTOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TABLA_PRODUCTOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TABLA_PRODUCTOSBindingNavigatorSaveItem})
        Me.TABLA_PRODUCTOSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TABLA_PRODUCTOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TABLA_PRODUCTOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TABLA_PRODUCTOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TABLA_PRODUCTOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TABLA_PRODUCTOSBindingNavigator.Name = "TABLA_PRODUCTOSBindingNavigator"
        Me.TABLA_PRODUCTOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TABLA_PRODUCTOSBindingNavigator.Size = New System.Drawing.Size(982, 25)
        Me.TABLA_PRODUCTOSBindingNavigator.TabIndex = 0
        Me.TABLA_PRODUCTOSBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'TABLA_PRODUCTOSBindingSource
        '
        Me.TABLA_PRODUCTOSBindingSource.DataMember = "TABLA_PRODUCTOS"
        Me.TABLA_PRODUCTOSBindingSource.DataSource = Me.FerreteriaDataSet
        '
        'FerreteriaDataSet
        '
        Me.FerreteriaDataSet.DataSetName = "FerreteriaDataSet"
        Me.FerreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TABLA_PRODUCTOSBindingNavigatorSaveItem
        '
        Me.TABLA_PRODUCTOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TABLA_PRODUCTOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("TABLA_PRODUCTOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TABLA_PRODUCTOSBindingNavigatorSaveItem.Name = "TABLA_PRODUCTOSBindingNavigatorSaveItem"
        Me.TABLA_PRODUCTOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TABLA_PRODUCTOSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'COD_PRODUCTOTextBox
        '
        Me.COD_PRODUCTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PRODUCTOSBindingSource, "COD_PRODUCTO", True))
        Me.COD_PRODUCTOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COD_PRODUCTOTextBox.Location = New System.Drawing.Point(71, 37)
        Me.COD_PRODUCTOTextBox.Name = "COD_PRODUCTOTextBox"
        Me.COD_PRODUCTOTextBox.Size = New System.Drawing.Size(100, 22)
        Me.COD_PRODUCTOTextBox.TabIndex = 2
        Me.COD_PRODUCTOTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NOMBRE_PRODTextBox
        '
        Me.NOMBRE_PRODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PRODUCTOSBindingSource, "NOMBRE_PROD", True))
        Me.NOMBRE_PRODTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRE_PRODTextBox.Location = New System.Drawing.Point(247, 37)
        Me.NOMBRE_PRODTextBox.Name = "NOMBRE_PRODTextBox"
        Me.NOMBRE_PRODTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NOMBRE_PRODTextBox.TabIndex = 4
        Me.NOMBRE_PRODTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PRECIOV_PRODTextBox
        '
        Me.PRECIOV_PRODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PRODUCTOSBindingSource, "PRECIOV_PROD", True))
        Me.PRECIOV_PRODTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRECIOV_PRODTextBox.Location = New System.Drawing.Point(409, 37)
        Me.PRECIOV_PRODTextBox.Name = "PRECIOV_PRODTextBox"
        Me.PRECIOV_PRODTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PRECIOV_PRODTextBox.TabIndex = 8
        Me.PRECIOV_PRODTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(588, 37)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtcantidad.TabIndex = 9
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(517, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(842, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "# Factura"
        '
        'txtfactura
        '
        Me.txtfactura.Location = New System.Drawing.Point(900, 76)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Size = New System.Drawing.Size(50, 20)
        Me.txtfactura.TabIndex = 11
        Me.txtfactura.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(668, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Subtotal:"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(723, 76)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtsubtotal.TabIndex = 13
        Me.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(831, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "IVA:"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(864, 113)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 17
        Me.TextBox2.Text = "16%"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(869, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 41)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(671, 134)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 55)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Calcular total"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(671, 195)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 56)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Confirmar compra"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(180, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 24)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Total general:"
        '
        'txttotalgeneral
        '
        Me.txttotalgeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalgeneral.Location = New System.Drawing.Point(311, 340)
        Me.txttotalgeneral.Name = "txttotalgeneral"
        Me.txttotalgeneral.Size = New System.Drawing.Size(142, 29)
        Me.txttotalgeneral.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(636, 240)
        Me.DataGridView1.TabIndex = 24
        '
        'Column1
        '
        Me.Column1.HeaderText = "# Factura"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Código"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Producto"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Subtotal"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Total"
        Me.Column6.Name = "Column6"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(763, 336)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 41)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Buscar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TABLA_PRODUCTOSTableAdapter
        '
        Me.TABLA_PRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FACTURATableAdapter = Me.FACTURATableAdapter
        Me.TableAdapterManager.TABLA_CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PEDIDOS_PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PEDIDOSTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PRODUCTOSTableAdapter = Me.TABLA_PRODUCTOSTableAdapter
        Me.TableAdapterManager.TABLA_PROVEEDORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FACTURATableAdapter
        '
        Me.FACTURATableAdapter.ClearBeforeFill = True
        '
        'FACTURABindingSource
        '
        Me.FACTURABindingSource.DataMember = "FACTURA"
        Me.FACTURABindingSource.DataSource = Me.FerreteriaDataSet
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(901, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Label4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(784, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(862, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Hora:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(745, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Fecha:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(982, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txttotalgeneral)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtfactura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(COD_PRODUCTOLabel)
        Me.Controls.Add(Me.COD_PRODUCTOTextBox)
        Me.Controls.Add(NOMBRE_PRODLabel)
        Me.Controls.Add(Me.NOMBRE_PRODTextBox)
        Me.Controls.Add(PRECIOV_PRODLabel)
        Me.Controls.Add(Me.PRECIOV_PRODTextBox)
        Me.Controls.Add(Me.TABLA_PRODUCTOSBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Punto de venta"
        CType(Me.TABLA_PRODUCTOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TABLA_PRODUCTOSBindingNavigator.ResumeLayout(False)
        Me.TABLA_PRODUCTOSBindingNavigator.PerformLayout()
        CType(Me.TABLA_PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTURABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FerreteriaDataSet As WindowsApplication1.FerreteriaDataSet
    Friend WithEvents TABLA_PRODUCTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TABLA_PRODUCTOSTableAdapter As WindowsApplication1.FerreteriaDataSetTableAdapters.TABLA_PRODUCTOSTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TABLA_PRODUCTOSBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TABLA_PRODUCTOSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents COD_PRODUCTOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_PRODTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRECIOV_PRODTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtfactura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtsubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FACTURATableAdapter As WindowsApplication1.FerreteriaDataSetTableAdapters.FACTURATableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents FACTURABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttotalgeneral As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
