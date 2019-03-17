<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim COD_PROVLabel As System.Windows.Forms.Label
        Dim NOMBRE_PROVLabel As System.Windows.Forms.Label
        Dim TEL_PROVLabel As System.Windows.Forms.Label
        Dim DIRECCION_PROVLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.FerreteriaDataSet = New WindowsApplication1.FerreteriaDataSet()
        Me.TABLA_PROVEEDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TABLA_PROVEEDORTableAdapter = New WindowsApplication1.FerreteriaDataSetTableAdapters.TABLA_PROVEEDORTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager()
        Me.TABLA_PROVEEDORBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TABLA_PROVEEDORBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TABLA_PROVEEDORDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_PROVTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRE_PROVTextBox = New System.Windows.Forms.TextBox()
        Me.TEL_PROVTextBox = New System.Windows.Forms.TextBox()
        Me.DIRECCION_PROVTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        COD_PROVLabel = New System.Windows.Forms.Label()
        NOMBRE_PROVLabel = New System.Windows.Forms.Label()
        TEL_PROVLabel = New System.Windows.Forms.Label()
        DIRECCION_PROVLabel = New System.Windows.Forms.Label()
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABLA_PROVEEDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABLA_PROVEEDORBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TABLA_PROVEEDORBindingNavigator.SuspendLayout()
        CType(Me.TABLA_PROVEEDORDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'COD_PROVLabel
        '
        COD_PROVLabel.AutoSize = True
        COD_PROVLabel.Location = New System.Drawing.Point(10, 44)
        COD_PROVLabel.Name = "COD_PROVLabel"
        COD_PROVLabel.Size = New System.Drawing.Size(66, 13)
        COD_PROVLabel.TabIndex = 2
        COD_PROVLabel.Text = "COD PROV:"
        '
        'NOMBRE_PROVLabel
        '
        NOMBRE_PROVLabel.AutoSize = True
        NOMBRE_PROVLabel.Location = New System.Drawing.Point(10, 70)
        NOMBRE_PROVLabel.Name = "NOMBRE_PROVLabel"
        NOMBRE_PROVLabel.Size = New System.Drawing.Size(90, 13)
        NOMBRE_PROVLabel.TabIndex = 4
        NOMBRE_PROVLabel.Text = "NOMBRE PROV:"
        '
        'TEL_PROVLabel
        '
        TEL_PROVLabel.AutoSize = True
        TEL_PROVLabel.Location = New System.Drawing.Point(10, 96)
        TEL_PROVLabel.Name = "TEL_PROVLabel"
        TEL_PROVLabel.Size = New System.Drawing.Size(63, 13)
        TEL_PROVLabel.TabIndex = 6
        TEL_PROVLabel.Text = "TEL PROV:"
        '
        'DIRECCION_PROVLabel
        '
        DIRECCION_PROVLabel.AutoSize = True
        DIRECCION_PROVLabel.Location = New System.Drawing.Point(10, 122)
        DIRECCION_PROVLabel.Name = "DIRECCION_PROVLabel"
        DIRECCION_PROVLabel.Size = New System.Drawing.Size(102, 13)
        DIRECCION_PROVLabel.TabIndex = 8
        DIRECCION_PROVLabel.Text = "DIRECCION PROV:"
        '
        'FerreteriaDataSet
        '
        Me.FerreteriaDataSet.DataSetName = "FerreteriaDataSet"
        Me.FerreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TABLA_PROVEEDORBindingSource
        '
        Me.TABLA_PROVEEDORBindingSource.DataMember = "TABLA_PROVEEDOR"
        Me.TABLA_PROVEEDORBindingSource.DataSource = Me.FerreteriaDataSet
        '
        'TABLA_PROVEEDORTableAdapter
        '
        Me.TABLA_PROVEEDORTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FACTURATableAdapter = Nothing
        Me.TableAdapterManager.TABLA_CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PEDIDOS_PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PEDIDOSTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PROVEEDORTableAdapter = Me.TABLA_PROVEEDORTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TABLA_PROVEEDORBindingNavigator
        '
        Me.TABLA_PROVEEDORBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TABLA_PROVEEDORBindingNavigator.BindingSource = Me.TABLA_PROVEEDORBindingSource
        Me.TABLA_PROVEEDORBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TABLA_PROVEEDORBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TABLA_PROVEEDORBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TABLA_PROVEEDORBindingNavigatorSaveItem})
        Me.TABLA_PROVEEDORBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TABLA_PROVEEDORBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TABLA_PROVEEDORBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TABLA_PROVEEDORBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TABLA_PROVEEDORBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TABLA_PROVEEDORBindingNavigator.Name = "TABLA_PROVEEDORBindingNavigator"
        Me.TABLA_PROVEEDORBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TABLA_PROVEEDORBindingNavigator.Size = New System.Drawing.Size(277, 25)
        Me.TABLA_PROVEEDORBindingNavigator.TabIndex = 0
        Me.TABLA_PROVEEDORBindingNavigator.Text = "BindingNavigator1"
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
        'TABLA_PROVEEDORBindingNavigatorSaveItem
        '
        Me.TABLA_PROVEEDORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TABLA_PROVEEDORBindingNavigatorSaveItem.Image = CType(resources.GetObject("TABLA_PROVEEDORBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TABLA_PROVEEDORBindingNavigatorSaveItem.Name = "TABLA_PROVEEDORBindingNavigatorSaveItem"
        Me.TABLA_PROVEEDORBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TABLA_PROVEEDORBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TABLA_PROVEEDORDataGridView
        '
        Me.TABLA_PROVEEDORDataGridView.AutoGenerateColumns = False
        Me.TABLA_PROVEEDORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TABLA_PROVEEDORDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TABLA_PROVEEDORDataGridView.DataSource = Me.TABLA_PROVEEDORBindingSource
        Me.TABLA_PROVEEDORDataGridView.Location = New System.Drawing.Point(239, 28)
        Me.TABLA_PROVEEDORDataGridView.Name = "TABLA_PROVEEDORDataGridView"
        Me.TABLA_PROVEEDORDataGridView.Size = New System.Drawing.Size(445, 220)
        Me.TABLA_PROVEEDORDataGridView.TabIndex = 1
        Me.TABLA_PROVEEDORDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "COD_PROV"
        Me.DataGridViewTextBoxColumn1.HeaderText = "COD_PROV"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE_PROV"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE_PROV"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TEL_PROV"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TEL_PROV"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DIRECCION_PROV"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DIRECCION_PROV"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'COD_PROVTextBox
        '
        Me.COD_PROVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PROVEEDORBindingSource, "COD_PROV", True))
        Me.COD_PROVTextBox.Location = New System.Drawing.Point(118, 41)
        Me.COD_PROVTextBox.Name = "COD_PROVTextBox"
        Me.COD_PROVTextBox.Size = New System.Drawing.Size(100, 20)
        Me.COD_PROVTextBox.TabIndex = 3
        '
        'NOMBRE_PROVTextBox
        '
        Me.NOMBRE_PROVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PROVEEDORBindingSource, "NOMBRE_PROV", True))
        Me.NOMBRE_PROVTextBox.Location = New System.Drawing.Point(118, 67)
        Me.NOMBRE_PROVTextBox.Name = "NOMBRE_PROVTextBox"
        Me.NOMBRE_PROVTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRE_PROVTextBox.TabIndex = 5
        '
        'TEL_PROVTextBox
        '
        Me.TEL_PROVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PROVEEDORBindingSource, "TEL_PROV", True))
        Me.TEL_PROVTextBox.Location = New System.Drawing.Point(118, 93)
        Me.TEL_PROVTextBox.Name = "TEL_PROVTextBox"
        Me.TEL_PROVTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TEL_PROVTextBox.TabIndex = 7
        '
        'DIRECCION_PROVTextBox
        '
        Me.DIRECCION_PROVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PROVEEDORBindingSource, "DIRECCION_PROV", True))
        Me.DIRECCION_PROVTextBox.Location = New System.Drawing.Point(118, 119)
        Me.DIRECCION_PROVTextBox.Name = "DIRECCION_PROVTextBox"
        Me.DIRECCION_PROVTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DIRECCION_PROVTextBox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 33)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(97, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 33)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Ocultar tabla"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(97, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 33)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Mostrar tabla"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 260)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(COD_PROVLabel)
        Me.Controls.Add(Me.COD_PROVTextBox)
        Me.Controls.Add(NOMBRE_PROVLabel)
        Me.Controls.Add(Me.NOMBRE_PROVTextBox)
        Me.Controls.Add(TEL_PROVLabel)
        Me.Controls.Add(Me.TEL_PROVTextBox)
        Me.Controls.Add(DIRECCION_PROVLabel)
        Me.Controls.Add(Me.DIRECCION_PROVTextBox)
        Me.Controls.Add(Me.TABLA_PROVEEDORDataGridView)
        Me.Controls.Add(Me.TABLA_PROVEEDORBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form8"
        Me.Text = "Tabla Proveedor"
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABLA_PROVEEDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABLA_PROVEEDORBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TABLA_PROVEEDORBindingNavigator.ResumeLayout(False)
        Me.TABLA_PROVEEDORBindingNavigator.PerformLayout()
        CType(Me.TABLA_PROVEEDORDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FerreteriaDataSet As WindowsApplication1.FerreteriaDataSet
    Friend WithEvents TABLA_PROVEEDORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TABLA_PROVEEDORTableAdapter As WindowsApplication1.FerreteriaDataSetTableAdapters.TABLA_PROVEEDORTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TABLA_PROVEEDORBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TABLA_PROVEEDORBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TABLA_PROVEEDORDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_PROVTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_PROVTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TEL_PROVTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIRECCION_PROVTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
