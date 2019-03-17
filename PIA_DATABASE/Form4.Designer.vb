<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim COD_CLIENTELabel As System.Windows.Forms.Label
        Dim NOMBRE_CLIENTELabel As System.Windows.Forms.Label
        Dim APELLIDO_CLIENTELabel As System.Windows.Forms.Label
        Dim DIRECCION_CLIENTELabel As System.Windows.Forms.Label
        Dim TELEFONO_CLIENTELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.FerreteriaDataSet = New WindowsApplication1.FerreteriaDataSet()
        Me.TABLA_CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TABLA_CLIENTESTableAdapter = New WindowsApplication1.FerreteriaDataSetTableAdapters.TABLA_CLIENTESTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager()
        Me.TABLA_CLIENTESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.TABLA_CLIENTESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.COD_CLIENTETextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRE_CLIENTETextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDO_CLIENTETextBox = New System.Windows.Forms.TextBox()
        Me.DIRECCION_CLIENTETextBox = New System.Windows.Forms.TextBox()
        Me.TELEFONO_CLIENTETextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABLA_CLIENTESDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        COD_CLIENTELabel = New System.Windows.Forms.Label()
        NOMBRE_CLIENTELabel = New System.Windows.Forms.Label()
        APELLIDO_CLIENTELabel = New System.Windows.Forms.Label()
        DIRECCION_CLIENTELabel = New System.Windows.Forms.Label()
        TELEFONO_CLIENTELabel = New System.Windows.Forms.Label()
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABLA_CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABLA_CLIENTESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TABLA_CLIENTESBindingNavigator.SuspendLayout()
        CType(Me.TABLA_CLIENTESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'COD_CLIENTELabel
        '
        COD_CLIENTELabel.AutoSize = True
        COD_CLIENTELabel.Location = New System.Drawing.Point(11, 41)
        COD_CLIENTELabel.Name = "COD_CLIENTELabel"
        COD_CLIENTELabel.Size = New System.Drawing.Size(81, 13)
        COD_CLIENTELabel.TabIndex = 3
        COD_CLIENTELabel.Text = "COD CLIENTE:"
        '
        'NOMBRE_CLIENTELabel
        '
        NOMBRE_CLIENTELabel.AutoSize = True
        NOMBRE_CLIENTELabel.Location = New System.Drawing.Point(11, 67)
        NOMBRE_CLIENTELabel.Name = "NOMBRE_CLIENTELabel"
        NOMBRE_CLIENTELabel.Size = New System.Drawing.Size(105, 13)
        NOMBRE_CLIENTELabel.TabIndex = 5
        NOMBRE_CLIENTELabel.Text = "NOMBRE CLIENTE:"
        '
        'APELLIDO_CLIENTELabel
        '
        APELLIDO_CLIENTELabel.AutoSize = True
        APELLIDO_CLIENTELabel.Location = New System.Drawing.Point(11, 93)
        APELLIDO_CLIENTELabel.Name = "APELLIDO_CLIENTELabel"
        APELLIDO_CLIENTELabel.Size = New System.Drawing.Size(110, 13)
        APELLIDO_CLIENTELabel.TabIndex = 7
        APELLIDO_CLIENTELabel.Text = "APELLIDO CLIENTE:"
        '
        'DIRECCION_CLIENTELabel
        '
        DIRECCION_CLIENTELabel.AutoSize = True
        DIRECCION_CLIENTELabel.Location = New System.Drawing.Point(11, 119)
        DIRECCION_CLIENTELabel.Name = "DIRECCION_CLIENTELabel"
        DIRECCION_CLIENTELabel.Size = New System.Drawing.Size(117, 13)
        DIRECCION_CLIENTELabel.TabIndex = 9
        DIRECCION_CLIENTELabel.Text = "DIRECCION CLIENTE:"
        '
        'TELEFONO_CLIENTELabel
        '
        TELEFONO_CLIENTELabel.AutoSize = True
        TELEFONO_CLIENTELabel.Location = New System.Drawing.Point(11, 145)
        TELEFONO_CLIENTELabel.Name = "TELEFONO_CLIENTELabel"
        TELEFONO_CLIENTELabel.Size = New System.Drawing.Size(115, 13)
        TELEFONO_CLIENTELabel.TabIndex = 11
        TELEFONO_CLIENTELabel.Text = "TELEFONO CLIENTE:"
        '
        'FerreteriaDataSet
        '
        Me.FerreteriaDataSet.DataSetName = "FerreteriaDataSet"
        Me.FerreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TABLA_CLIENTESBindingSource
        '
        Me.TABLA_CLIENTESBindingSource.DataMember = "TABLA_CLIENTES"
        Me.TABLA_CLIENTESBindingSource.DataSource = Me.FerreteriaDataSet
        '
        'TABLA_CLIENTESTableAdapter
        '
        Me.TABLA_CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FACTURATableAdapter = Nothing
        Me.TableAdapterManager.TABLA_CLIENTESTableAdapter = Me.TABLA_CLIENTESTableAdapter
        Me.TableAdapterManager.TABLA_PEDIDOS_PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PEDIDOSTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PROVEEDORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TABLA_CLIENTESBindingNavigator
        '
        Me.TABLA_CLIENTESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TABLA_CLIENTESBindingNavigator.BindingSource = Me.TABLA_CLIENTESBindingSource
        Me.TABLA_CLIENTESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TABLA_CLIENTESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TABLA_CLIENTESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TABLA_CLIENTESBindingNavigatorSaveItem})
        Me.TABLA_CLIENTESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TABLA_CLIENTESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TABLA_CLIENTESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TABLA_CLIENTESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TABLA_CLIENTESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TABLA_CLIENTESBindingNavigator.Name = "TABLA_CLIENTESBindingNavigator"
        Me.TABLA_CLIENTESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TABLA_CLIENTESBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.TABLA_CLIENTESBindingNavigator.TabIndex = 0
        Me.TABLA_CLIENTESBindingNavigator.Text = "BindingNavigator1"
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
        'TABLA_CLIENTESBindingNavigatorSaveItem
        '
        Me.TABLA_CLIENTESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TABLA_CLIENTESBindingNavigatorSaveItem.Image = CType(resources.GetObject("TABLA_CLIENTESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TABLA_CLIENTESBindingNavigatorSaveItem.Name = "TABLA_CLIENTESBindingNavigatorSaveItem"
        Me.TABLA_CLIENTESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TABLA_CLIENTESBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'COD_CLIENTETextBox
        '
        Me.COD_CLIENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_CLIENTESBindingSource, "COD_CLIENTE", True))
        Me.COD_CLIENTETextBox.Location = New System.Drawing.Point(134, 38)
        Me.COD_CLIENTETextBox.Name = "COD_CLIENTETextBox"
        Me.COD_CLIENTETextBox.Size = New System.Drawing.Size(100, 20)
        Me.COD_CLIENTETextBox.TabIndex = 4
        '
        'NOMBRE_CLIENTETextBox
        '
        Me.NOMBRE_CLIENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_CLIENTESBindingSource, "NOMBRE_CLIENTE", True))
        Me.NOMBRE_CLIENTETextBox.Location = New System.Drawing.Point(134, 64)
        Me.NOMBRE_CLIENTETextBox.Name = "NOMBRE_CLIENTETextBox"
        Me.NOMBRE_CLIENTETextBox.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRE_CLIENTETextBox.TabIndex = 6
        '
        'APELLIDO_CLIENTETextBox
        '
        Me.APELLIDO_CLIENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_CLIENTESBindingSource, "APELLIDO_CLIENTE", True))
        Me.APELLIDO_CLIENTETextBox.Location = New System.Drawing.Point(134, 90)
        Me.APELLIDO_CLIENTETextBox.Name = "APELLIDO_CLIENTETextBox"
        Me.APELLIDO_CLIENTETextBox.Size = New System.Drawing.Size(100, 20)
        Me.APELLIDO_CLIENTETextBox.TabIndex = 8
        '
        'DIRECCION_CLIENTETextBox
        '
        Me.DIRECCION_CLIENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_CLIENTESBindingSource, "DIRECCION_CLIENTE", True))
        Me.DIRECCION_CLIENTETextBox.Location = New System.Drawing.Point(134, 116)
        Me.DIRECCION_CLIENTETextBox.Name = "DIRECCION_CLIENTETextBox"
        Me.DIRECCION_CLIENTETextBox.Size = New System.Drawing.Size(100, 20)
        Me.DIRECCION_CLIENTETextBox.TabIndex = 10
        '
        'TELEFONO_CLIENTETextBox
        '
        Me.TELEFONO_CLIENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_CLIENTESBindingSource, "TELEFONO_CLIENTE", True))
        Me.TELEFONO_CLIENTETextBox.Location = New System.Drawing.Point(134, 142)
        Me.TELEFONO_CLIENTETextBox.Name = "TELEFONO_CLIENTETextBox"
        Me.TELEFONO_CLIENTETextBox.Size = New System.Drawing.Size(100, 20)
        Me.TELEFONO_CLIENTETextBox.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 35)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Mostrar tabla"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TELEFONO_CLIENTE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TELEFONO_CLIENTE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DIRECCION_CLIENTE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DIRECCION_CLIENTE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "APELLIDO_CLIENTE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "APELLIDO_CLIENTE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE_CLIENTE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE_CLIENTE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "COD_CLIENTE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "COD_CLIENTE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'TABLA_CLIENTESDataGridView
        '
        Me.TABLA_CLIENTESDataGridView.AutoGenerateColumns = False
        Me.TABLA_CLIENTESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TABLA_CLIENTESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TABLA_CLIENTESDataGridView.DataSource = Me.TABLA_CLIENTESBindingSource
        Me.TABLA_CLIENTESDataGridView.Location = New System.Drawing.Point(251, 28)
        Me.TABLA_CLIENTESDataGridView.Name = "TABLA_CLIENTESDataGridView"
        Me.TABLA_CLIENTESDataGridView.Size = New System.Drawing.Size(560, 220)
        Me.TABLA_CLIENTESDataGridView.TabIndex = 1
        Me.TABLA_CLIENTESDataGridView.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(108, 254)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 35)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Ocultar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 309)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(COD_CLIENTELabel)
        Me.Controls.Add(Me.COD_CLIENTETextBox)
        Me.Controls.Add(NOMBRE_CLIENTELabel)
        Me.Controls.Add(Me.NOMBRE_CLIENTETextBox)
        Me.Controls.Add(APELLIDO_CLIENTELabel)
        Me.Controls.Add(Me.APELLIDO_CLIENTETextBox)
        Me.Controls.Add(DIRECCION_CLIENTELabel)
        Me.Controls.Add(Me.DIRECCION_CLIENTETextBox)
        Me.Controls.Add(TELEFONO_CLIENTELabel)
        Me.Controls.Add(Me.TELEFONO_CLIENTETextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TABLA_CLIENTESDataGridView)
        Me.Controls.Add(Me.TABLA_CLIENTESBindingNavigator)
        Me.Controls.Add(Me.Button3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Tabla Clientes"
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABLA_CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABLA_CLIENTESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TABLA_CLIENTESBindingNavigator.ResumeLayout(False)
        Me.TABLA_CLIENTESBindingNavigator.PerformLayout()
        CType(Me.TABLA_CLIENTESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FerreteriaDataSet As WindowsApplication1.FerreteriaDataSet
    Friend WithEvents TABLA_CLIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TABLA_CLIENTESTableAdapter As WindowsApplication1.FerreteriaDataSetTableAdapters.TABLA_CLIENTESTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TABLA_CLIENTESBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TABLA_CLIENTESBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents COD_CLIENTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_CLIENTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents APELLIDO_CLIENTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIRECCION_CLIENTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents TELEFONO_CLIENTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABLA_CLIENTESDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
