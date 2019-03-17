<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim PRECIOC_PRODLabel As System.Windows.Forms.Label
        Dim PRECIOV_PRODLabel As System.Windows.Forms.Label
        Dim COD_PROVLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.FerreteriaDataSet = New WindowsApplication1.FerreteriaDataSet()
        Me.TABLA_PRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TABLA_PRODUCTOSTableAdapter = New WindowsApplication1.FerreteriaDataSetTableAdapters.TABLA_PRODUCTOSTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager()
        Me.TABLA_PRODUCTOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TABLA_PRODUCTOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TABLA_PRODUCTOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_PRODUCTOTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRE_PRODTextBox = New System.Windows.Forms.TextBox()
        Me.PRECIOC_PRODTextBox = New System.Windows.Forms.TextBox()
        Me.PRECIOV_PRODTextBox = New System.Windows.Forms.TextBox()
        Me.COD_PROVTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        COD_PRODUCTOLabel = New System.Windows.Forms.Label()
        NOMBRE_PRODLabel = New System.Windows.Forms.Label()
        PRECIOC_PRODLabel = New System.Windows.Forms.Label()
        PRECIOV_PRODLabel = New System.Windows.Forms.Label()
        COD_PROVLabel = New System.Windows.Forms.Label()
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABLA_PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABLA_PRODUCTOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TABLA_PRODUCTOSBindingNavigator.SuspendLayout()
        CType(Me.TABLA_PRODUCTOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'COD_PRODUCTOLabel
        '
        COD_PRODUCTOLabel.AutoSize = True
        COD_PRODUCTOLabel.Location = New System.Drawing.Point(13, 41)
        COD_PRODUCTOLabel.Name = "COD_PRODUCTOLabel"
        COD_PRODUCTOLabel.Size = New System.Drawing.Size(97, 13)
        COD_PRODUCTOLabel.TabIndex = 2
        COD_PRODUCTOLabel.Text = "COD PRODUCTO:"
        '
        'NOMBRE_PRODLabel
        '
        NOMBRE_PRODLabel.AutoSize = True
        NOMBRE_PRODLabel.Location = New System.Drawing.Point(13, 67)
        NOMBRE_PRODLabel.Name = "NOMBRE_PRODLabel"
        NOMBRE_PRODLabel.Size = New System.Drawing.Size(91, 13)
        NOMBRE_PRODLabel.TabIndex = 4
        NOMBRE_PRODLabel.Text = "NOMBRE PROD:"
        '
        'PRECIOC_PRODLabel
        '
        PRECIOC_PRODLabel.AutoSize = True
        PRECIOC_PRODLabel.Location = New System.Drawing.Point(13, 93)
        PRECIOC_PRODLabel.Name = "PRECIOC_PRODLabel"
        PRECIOC_PRODLabel.Size = New System.Drawing.Size(91, 13)
        PRECIOC_PRODLabel.TabIndex = 6
        PRECIOC_PRODLabel.Text = "PRECIOC PROD:"
        '
        'PRECIOV_PRODLabel
        '
        PRECIOV_PRODLabel.AutoSize = True
        PRECIOV_PRODLabel.Location = New System.Drawing.Point(13, 119)
        PRECIOV_PRODLabel.Name = "PRECIOV_PRODLabel"
        PRECIOV_PRODLabel.Size = New System.Drawing.Size(91, 13)
        PRECIOV_PRODLabel.TabIndex = 8
        PRECIOV_PRODLabel.Text = "PRECIOV PROD:"
        '
        'COD_PROVLabel
        '
        COD_PROVLabel.AutoSize = True
        COD_PROVLabel.Location = New System.Drawing.Point(13, 145)
        COD_PROVLabel.Name = "COD_PROVLabel"
        COD_PROVLabel.Size = New System.Drawing.Size(66, 13)
        COD_PROVLabel.TabIndex = 10
        COD_PROVLabel.Text = "COD PROV:"
        '
        'FerreteriaDataSet
        '
        Me.FerreteriaDataSet.DataSetName = "FerreteriaDataSet"
        Me.FerreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TABLA_PRODUCTOSBindingSource
        '
        Me.TABLA_PRODUCTOSBindingSource.DataMember = "TABLA_PRODUCTOS"
        Me.TABLA_PRODUCTOSBindingSource.DataSource = Me.FerreteriaDataSet
        '
        'TABLA_PRODUCTOSTableAdapter
        '
        Me.TABLA_PRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FACTURATableAdapter = Nothing
        Me.TableAdapterManager.TABLA_CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PEDIDOS_PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PEDIDOSTableAdapter = Nothing
        Me.TableAdapterManager.TABLA_PRODUCTOSTableAdapter = Me.TABLA_PRODUCTOSTableAdapter
        Me.TableAdapterManager.TABLA_PROVEEDORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.FerreteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.TABLA_PRODUCTOSBindingNavigator.Size = New System.Drawing.Size(276, 25)
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
        'TABLA_PRODUCTOSDataGridView
        '
        Me.TABLA_PRODUCTOSDataGridView.AutoGenerateColumns = False
        Me.TABLA_PRODUCTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TABLA_PRODUCTOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TABLA_PRODUCTOSDataGridView.DataSource = Me.TABLA_PRODUCTOSBindingSource
        Me.TABLA_PRODUCTOSDataGridView.Location = New System.Drawing.Point(222, 28)
        Me.TABLA_PRODUCTOSDataGridView.Name = "TABLA_PRODUCTOSDataGridView"
        Me.TABLA_PRODUCTOSDataGridView.Size = New System.Drawing.Size(545, 220)
        Me.TABLA_PRODUCTOSDataGridView.TabIndex = 1
        Me.TABLA_PRODUCTOSDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "COD_PRODUCTO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "COD_PRODUCTO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE_PROD"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE_PROD"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PRECIOC_PROD"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PRECIOC_PROD"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PRECIOV_PROD"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PRECIOV_PROD"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "COD_PROV"
        Me.DataGridViewTextBoxColumn5.HeaderText = "COD_PROV"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'COD_PRODUCTOTextBox
        '
        Me.COD_PRODUCTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PRODUCTOSBindingSource, "COD_PRODUCTO", True))
        Me.COD_PRODUCTOTextBox.Location = New System.Drawing.Point(116, 38)
        Me.COD_PRODUCTOTextBox.Name = "COD_PRODUCTOTextBox"
        Me.COD_PRODUCTOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.COD_PRODUCTOTextBox.TabIndex = 3
        '
        'NOMBRE_PRODTextBox
        '
        Me.NOMBRE_PRODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PRODUCTOSBindingSource, "NOMBRE_PROD", True))
        Me.NOMBRE_PRODTextBox.Location = New System.Drawing.Point(116, 64)
        Me.NOMBRE_PRODTextBox.Name = "NOMBRE_PRODTextBox"
        Me.NOMBRE_PRODTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRE_PRODTextBox.TabIndex = 5
        '
        'PRECIOC_PRODTextBox
        '
        Me.PRECIOC_PRODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PRODUCTOSBindingSource, "PRECIOC_PROD", True))
        Me.PRECIOC_PRODTextBox.Location = New System.Drawing.Point(116, 90)
        Me.PRECIOC_PRODTextBox.Name = "PRECIOC_PRODTextBox"
        Me.PRECIOC_PRODTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRECIOC_PRODTextBox.TabIndex = 7
        '
        'PRECIOV_PRODTextBox
        '
        Me.PRECIOV_PRODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PRODUCTOSBindingSource, "PRECIOV_PROD", True))
        Me.PRECIOV_PRODTextBox.Location = New System.Drawing.Point(116, 116)
        Me.PRECIOV_PRODTextBox.Name = "PRECIOV_PRODTextBox"
        Me.PRECIOV_PRODTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRECIOV_PRODTextBox.TabIndex = 9
        '
        'COD_PROVTextBox
        '
        Me.COD_PROVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TABLA_PRODUCTOSBindingSource, "COD_PROV", True))
        Me.COD_PROVTextBox.Location = New System.Drawing.Point(116, 142)
        Me.COD_PROVTextBox.Name = "COD_PROVTextBox"
        Me.COD_PROVTextBox.Size = New System.Drawing.Size(100, 20)
        Me.COD_PROVTextBox.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 30)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(99, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 30)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Ocultar tabla"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(99, 218)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 30)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Mostrar tabla"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(COD_PRODUCTOLabel)
        Me.Controls.Add(Me.COD_PRODUCTOTextBox)
        Me.Controls.Add(NOMBRE_PRODLabel)
        Me.Controls.Add(Me.NOMBRE_PRODTextBox)
        Me.Controls.Add(PRECIOC_PRODLabel)
        Me.Controls.Add(Me.PRECIOC_PRODTextBox)
        Me.Controls.Add(PRECIOV_PRODLabel)
        Me.Controls.Add(Me.PRECIOV_PRODTextBox)
        Me.Controls.Add(COD_PROVLabel)
        Me.Controls.Add(Me.COD_PROVTextBox)
        Me.Controls.Add(Me.TABLA_PRODUCTOSDataGridView)
        Me.Controls.Add(Me.TABLA_PRODUCTOSBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form7"
        Me.Text = "Tabla Productos"
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABLA_PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABLA_PRODUCTOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TABLA_PRODUCTOSBindingNavigator.ResumeLayout(False)
        Me.TABLA_PRODUCTOSBindingNavigator.PerformLayout()
        CType(Me.TABLA_PRODUCTOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TABLA_PRODUCTOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_PRODUCTOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_PRODTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRECIOC_PRODTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRECIOV_PRODTextBox As System.Windows.Forms.TextBox
    Friend WithEvents COD_PROVTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
