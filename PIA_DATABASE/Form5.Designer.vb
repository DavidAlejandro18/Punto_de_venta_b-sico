<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim COD_PEDIDOLabel As System.Windows.Forms.Label
        Dim FECHA_PEDIDOLabel As System.Windows.Forms.Label
        Dim MONTO_TOTALLabel As System.Windows.Forms.Label
        Dim COD_CLIENTELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.FerreteriaDataSet = New WindowsApplication1.FerreteriaDataSet()
        Me.TABLA_PEDIDOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TABLA_PEDIDOSTableAdapter = New WindowsApplication1.FerreteriaDataSetTableAdapters.TABLA_PEDIDOSTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager()
        Me.TABLA_PEDIDOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TABLA_PEDIDOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TABLA_PEDIDOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_PEDIDOTextBox = New System.Windows.Forms.TextBox()
        Me.FECHA_PEDIDODateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MONTO_TOTALTextBox = New System.Windows.Forms.TextBox()
        Me.COD_CLIENTETextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        COD_PEDIDOLabel = New System.Windows.Forms.Label()
        FECHA_PEDIDOLabel = New System.Windows.Forms.Label()
        MONTO_TOTALLabel = New System.Windows.Forms.Label()
        COD_CLIENTELabel = New System.Windows.Forms.Label()
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABLA_PEDIDOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABLA_PEDIDOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TABLA_PEDIDOSBindingNavigator.SuspendLayout()
        CType(Me.TABLA_PEDIDOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'COD_PEDIDOLabel
        '
        COD_PEDIDOLabel.AutoSize = True
        COD_PEDIDOLabel.Location = New System.Drawing.Point(9, 55)
        COD_PEDIDOLabel.Name = "COD_PEDIDOLabel"
        COD_PEDIDOLabel.Size = New System.Drawing.Size(77, 13)
        COD_PEDIDOLabel.TabIndex = 2
        COD_PEDIDOLabel.Text = "COD PEDIDO:"
        '
        'FECHA_PEDIDOLabel
        '
        FECHA_PEDIDOLabel.AutoSize = True
        FECHA_PEDIDOLabel.Location = New System.Drawing.Point(9, 82)
        FECHA_PEDIDOLabel.Name = "FECHA_PEDIDOLabel"
        FECHA_PEDIDOLabel.Size = New System.Drawing.Size(89, 13)
        FECHA_PEDIDOLabel.TabIndex = 4
        FECHA_PEDIDOLabel.Text = "FECHA PEDIDO:"
        '
        'MONTO_TOTALLabel
        '
        MONTO_TOTALLabel.AutoSize = True
        MONTO_TOTALLabel.Location = New System.Drawing.Point(9, 107)
        MONTO_TOTALLabel.Name = "MONTO_TOTALLabel"
        MONTO_TOTALLabel.Size = New System.Drawing.Size(88, 13)
        MONTO_TOTALLabel.TabIndex = 6
        MONTO_TOTALLabel.Text = "MONTO TOTAL:"
        '
        'COD_CLIENTELabel
        '
        COD_CLIENTELabel.AutoSize = True
        COD_CLIENTELabel.Location = New System.Drawing.Point(9, 133)
        COD_CLIENTELabel.Name = "COD_CLIENTELabel"
        COD_CLIENTELabel.Size = New System.Drawing.Size(81, 13)
        COD_CLIENTELabel.TabIndex = 8
        COD_CLIENTELabel.Text = "COD CLIENTE:"
        '
        'FerreteriaDataSet
        '
        Me.FerreteriaDataSet.DataSetName = "FerreteriaDataSet"
        Me.FerreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TABLA_PEDIDOSBindingSource
        '
        Me.TABLA_PEDIDOSBindingSource.DataMember = "TABLA_PEDIDOS"
        Me.TABLA_PEDIDOSBindingSource.DataSource = Me.FerreteriaDataSet
        '
        'TABLA_PEDIDOSTableAdapter
        '
        Me.TABLA_PEDIDOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FACTURATableAdapter = Nothing
        Me.TableAdapterManager.TABLA_CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PEDIDOS_PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PEDIDOSTableAdapter = Me.TABLA_PEDIDOSTableAdapter
        Me.TableAdapterManager.TABLA_PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PROVEEDORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TABLA_PEDIDOSBindingNavigator
        '
        Me.TABLA_PEDIDOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TABLA_PEDIDOSBindingNavigator.BindingSource = Me.TABLA_PEDIDOSBindingSource
        Me.TABLA_PEDIDOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TABLA_PEDIDOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TABLA_PEDIDOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TABLA_PEDIDOSBindingNavigatorSaveItem})
        Me.TABLA_PEDIDOSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TABLA_PEDIDOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TABLA_PEDIDOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TABLA_PEDIDOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TABLA_PEDIDOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TABLA_PEDIDOSBindingNavigator.Name = "TABLA_PEDIDOSBindingNavigator"
        Me.TABLA_PEDIDOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TABLA_PEDIDOSBindingNavigator.Size = New System.Drawing.Size(277, 25)
        Me.TABLA_PEDIDOSBindingNavigator.TabIndex = 0
        Me.TABLA_PEDIDOSBindingNavigator.Text = "BindingNavigator1"
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
        'TABLA_PEDIDOSBindingNavigatorSaveItem
        '
        Me.TABLA_PEDIDOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TABLA_PEDIDOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("TABLA_PEDIDOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TABLA_PEDIDOSBindingNavigatorSaveItem.Name = "TABLA_PEDIDOSBindingNavigatorSaveItem"
        Me.TABLA_PEDIDOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TABLA_PEDIDOSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TABLA_PEDIDOSDataGridView
        '
        Me.TABLA_PEDIDOSDataGridView.AutoGenerateColumns = False
        Me.TABLA_PEDIDOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TABLA_PEDIDOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TABLA_PEDIDOSDataGridView.DataSource = Me.TABLA_PEDIDOSBindingSource
        Me.TABLA_PEDIDOSDataGridView.Location = New System.Drawing.Point(284, 28)
        Me.TABLA_PEDIDOSDataGridView.Name = "TABLA_PEDIDOSDataGridView"
        Me.TABLA_PEDIDOSDataGridView.Size = New System.Drawing.Size(447, 220)
        Me.TABLA_PEDIDOSDataGridView.TabIndex = 1
        Me.TABLA_PEDIDOSDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "COD_PEDIDO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "COD_PEDIDO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FECHA_PEDIDO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FECHA_PEDIDO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MONTO_TOTAL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MONTO_TOTAL"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "COD_CLIENTE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "COD_CLIENTE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'COD_PEDIDOTextBox
        '
        Me.COD_PEDIDOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PEDIDOSBindingSource, "COD_PEDIDO", True))
        Me.COD_PEDIDOTextBox.Location = New System.Drawing.Point(104, 52)
        Me.COD_PEDIDOTextBox.Name = "COD_PEDIDOTextBox"
        Me.COD_PEDIDOTextBox.Size = New System.Drawing.Size(164, 20)
        Me.COD_PEDIDOTextBox.TabIndex = 3
        '
        'FECHA_PEDIDODateTimePicker
        '
        Me.FECHA_PEDIDODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TABLA_PEDIDOSBindingSource, "FECHA_PEDIDO", True))
        Me.FECHA_PEDIDODateTimePicker.Location = New System.Drawing.Point(104, 78)
        Me.FECHA_PEDIDODateTimePicker.Name = "FECHA_PEDIDODateTimePicker"
        Me.FECHA_PEDIDODateTimePicker.Size = New System.Drawing.Size(164, 20)
        Me.FECHA_PEDIDODateTimePicker.TabIndex = 5
        '
        'MONTO_TOTALTextBox
        '
        Me.MONTO_TOTALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PEDIDOSBindingSource, "MONTO_TOTAL", True))
        Me.MONTO_TOTALTextBox.Location = New System.Drawing.Point(104, 104)
        Me.MONTO_TOTALTextBox.Name = "MONTO_TOTALTextBox"
        Me.MONTO_TOTALTextBox.Size = New System.Drawing.Size(164, 20)
        Me.MONTO_TOTALTextBox.TabIndex = 7
        '
        'COD_CLIENTETextBox
        '
        Me.COD_CLIENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PEDIDOSBindingSource, "COD_CLIENTE", True))
        Me.COD_CLIENTETextBox.Location = New System.Drawing.Point(104, 130)
        Me.COD_CLIENTETextBox.Name = "COD_CLIENTETextBox"
        Me.COD_CLIENTETextBox.Size = New System.Drawing.Size(164, 20)
        Me.COD_CLIENTETextBox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(113, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 32)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Ocultar tabla"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(113, 216)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 32)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Mostrar tabla"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 263)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(COD_PEDIDOLabel)
        Me.Controls.Add(Me.COD_PEDIDOTextBox)
        Me.Controls.Add(FECHA_PEDIDOLabel)
        Me.Controls.Add(Me.FECHA_PEDIDODateTimePicker)
        Me.Controls.Add(MONTO_TOTALLabel)
        Me.Controls.Add(Me.MONTO_TOTALTextBox)
        Me.Controls.Add(COD_CLIENTELabel)
        Me.Controls.Add(Me.COD_CLIENTETextBox)
        Me.Controls.Add(Me.TABLA_PEDIDOSDataGridView)
        Me.Controls.Add(Me.TABLA_PEDIDOSBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.Text = "Tabla Pedidos"
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABLA_PEDIDOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABLA_PEDIDOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TABLA_PEDIDOSBindingNavigator.ResumeLayout(False)
        Me.TABLA_PEDIDOSBindingNavigator.PerformLayout()
        CType(Me.TABLA_PEDIDOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FerreteriaDataSet As WindowsApplication1.FerreteriaDataSet
    Friend WithEvents TABLA_PEDIDOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TABLA_PEDIDOSTableAdapter As WindowsApplication1.FerreteriaDataSetTableAdapters.TABLA_PEDIDOSTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TABLA_PEDIDOSBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TABLA_PEDIDOSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TABLA_PEDIDOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_PEDIDOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_PEDIDODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MONTO_TOTALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents COD_CLIENTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
