Public Class Form5

    Private Sub TABLA_PEDIDOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TABLA_PEDIDOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TABLA_PEDIDOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FerreteriaDataSet.TABLA_PEDIDOS' table. You can move, or remove it, as needed.
        Me.TABLA_PEDIDOSTableAdapter.Fill(Me.FerreteriaDataSet.TABLA_PEDIDOS)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TABLA_PEDIDOSDataGridView.Visible = True
        Button3.Visible = False
        Button2.Visible = True
        Me.Size = New System.Drawing.Size(758, 302)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TABLA_PEDIDOSDataGridView.Visible = False
        Button3.Visible = True
        Button2.Visible = False
        Me.Size = New System.Drawing.Size(293, 302)
    End Sub
End Class