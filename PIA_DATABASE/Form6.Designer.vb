<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim COD_PRODUCTOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.FerreteriaDataSet = New WindowsApplication1.FerreteriaDataSet()
        Me.TABLA_PEDIDOS_PRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TABLA_PEDIDOS_PRODUCTOSTableAdapter = New WindowsApplication1.FerreteriaDataSetTableAdapters.TABLA_PEDIDOS_PRODUCTOSTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager()
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TABLA_PEDIDOS_PRODUCTOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_PEDIDOTextBox = New System.Windows.Forms.TextBox()
        Me.COD_PRODUCTOTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        COD_PEDIDOLabel = New System.Windows.Forms.Label()
        COD_PRODUCTOLabel = New System.Windows.Forms.Label()
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABLA_PEDIDOS_PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.SuspendLayout()
        CType(Me.TABLA_PEDIDOS_PRODUCTOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'COD_PEDIDOLabel
        '
        COD_PEDIDOLabel.AutoSize = True
        COD_PEDIDOLabel.Location = New System.Drawing.Point(12, 57)
        COD_PEDIDOLabel.Name = "COD_PEDIDOLabel"
        COD_PEDIDOLabel.Size = New System.Drawing.Size(77, 13)
        COD_PEDIDOLabel.TabIndex = 2
        COD_PEDIDOLabel.Text = "COD PEDIDO:"
        '
        'COD_PRODUCTOLabel
        '
        COD_PRODUCTOLabel.AutoSize = True
        COD_PRODUCTOLabel.Location = New System.Drawing.Point(12, 83)
        COD_PRODUCTOLabel.Name = "COD_PRODUCTOLabel"
        COD_PRODUCTOLabel.Size = New System.Drawing.Size(97, 13)
        COD_PRODUCTOLabel.TabIndex = 4
        COD_PRODUCTOLabel.Text = "COD PRODUCTO:"
        '
        'FerreteriaDataSet
        '
        Me.FerreteriaDataSet.DataSetName = "FerreteriaDataSet"
        Me.FerreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TABLA_PEDIDOS_PRODUCTOSBindingSource
        '
        Me.TABLA_PEDIDOS_PRODUCTOSBindingSource.DataMember = "TABLA_PEDIDOS_PRODUCTOS"
        Me.TABLA_PEDIDOS_PRODUCTOSBindingSource.DataSource = Me.FerreteriaDataSet
        '
        'TABLA_PEDIDOS_PRODUCTOSTableAdapter
        '
        Me.TABLA_PEDIDOS_PRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FACTURATableAdapter = Nothing
        Me.TableAdapterManager.TABLA_CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PEDIDOS_PRODUCTOSTableAdapter = Me.TABLA_PEDIDOS_PRODUCTOSTableAdapter
        Me.TableAdapterManager.TABLA_PEDIDOSTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PROVEEDORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TABLA_PEDIDOS_PRODUCTOSBindingNavigator
        '
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.BindingSource = Me.TABLA_PEDIDOS_PRODUCTOSBindingSource
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigatorSaveItem})
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.Name = "TABLA_PEDIDOS_PRODUCTOSBindingNavigator"
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.Size = New System.Drawing.Size(277, 25)
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.TabIndex = 0
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.Text = "BindingNavigator1"
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
        'TABLA_PEDIDOS_PRODUCTOSBindingNavigatorSaveItem
        '
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("TABLA_PEDIDOS_PRODUCTOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigatorSaveItem.Name = "TABLA_PEDIDOS_PRODUCTOSBindingNavigatorSaveItem"
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TABLA_PEDIDOS_PRODUCTOSDataGridView
        '
        Me.TABLA_PEDIDOS_PRODUCTOSDataGridView.AutoGenerateColumns = False
        Me.TABLA_PEDIDOS_PRODUCTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TABLA_PEDIDOS_PRODUCTOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TABLA_PEDIDOS_PRODUCTOSDataGridView.DataSource = Me.TABLA_PEDIDOS_PRODUCTOSBindingSource
        Me.TABLA_PEDIDOS_PRODUCTOSDataGridView.Location = New System.Drawing.Point(228, 28)
        Me.TABLA_PEDIDOS_PRODUCTOSDataGridView.Name = "TABLA_PEDIDOS_PRODUCTOSDataGridView"
        Me.TABLA_PEDIDOS_PRODUCTOSDataGridView.Size = New System.Drawing.Size(244, 220)
        Me.TABLA_PEDIDOS_PRODUCTOSDataGridView.TabIndex = 1
        Me.TABLA_PEDIDOS_PRODUCTOSDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "COD_PEDIDO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "COD_PEDIDO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "COD_PRODUCTO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "COD_PRODUCTO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'COD_PEDIDOTextBox
        '
        Me.COD_PEDIDOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PEDIDOS_PRODUCTOSBindingSource, "COD_PEDIDO", True))
        Me.COD_PEDIDOTextBox.Location = New System.Drawing.Point(115, 54)
        Me.COD_PEDIDOTextBox.Name = "COD_PEDIDOTextBox"
        Me.COD_PEDIDOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.COD_PEDIDOTextBox.TabIndex = 3
        '
        'COD_PRODUCTOTextBox
        '
        Me.COD_PRODUCTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PEDIDOS_PRODUCTOSBindingSource, "COD_PRODUCTO", True))
        Me.COD_PRODUCTOTextBox.Location = New System.Drawing.Point(115, 80)
        Me.COD_PRODUCTOTextBox.Name = "COD_PRODUCTOTextBox"
        Me.COD_PRODUCTOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.COD_PRODUCTOTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 31)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Ocultar tabla"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(93, 219)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 31)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Mostrar tabla"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(COD_PEDIDOLabel)
        Me.Controls.Add(Me.COD_PEDIDOTextBox)
        Me.Controls.Add(COD_PRODUCTOLabel)
        Me.Controls.Add(Me.COD_PRODUCTOTextBox)
        Me.Controls.Add(Me.TABLA_PEDIDOS_PRODUCTOSDataGridView)
        Me.Controls.Add(Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6"
        Me.Text = "Tabla Pedidos - Productos"
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABLA_PEDIDOS_PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.ResumeLayout(False)
        Me.TABLA_PEDIDOS_PRODUCTOSBindingNavigator.PerformLayout()
        CType(Me.TABLA_PEDIDOS_PRODUCTOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FerreteriaDataSet As WindowsApplication1.FerreteriaDataSet
    Friend WithEvents TABLA_PEDIDOS_PRODUCTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TABLA_PEDIDOS_PRODUCTOSTableAdapter As WindowsApplication1.FerreteriaDataSetTableAdapters.TABLA_PEDIDOS_PRODUCTOSTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TABLA_PEDIDOS_PRODUCTOSBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TABLA_PEDIDOS_PRODUCTOSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TABLA_PEDIDOS_PRODUCTOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_PEDIDOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents COD_PRODUCTOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
