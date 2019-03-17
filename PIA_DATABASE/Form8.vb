Public Class Form8

    Private Sub TABLA_PROVEEDORBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TABLA_PROVEEDORBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TABLA_PROVEEDORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FerreteriaDataSet.TABLA_PROVEEDOR' table. You can move, or remove it, as needed.
        Me.TABLA_PROVEEDORTableAdapter.Fill(Me.FerreteriaDataSet.TABLA_PROVEEDOR)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TABLA_PROVEEDORDataGridView.Visible = True
        Button3.Visible = False
        Button2.Visible = True
        Me.Size = New System.Drawing.Size(708, 299)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TABLA_PROVEEDORDataGridView.Visible = False
        Button3.Visible = True
        Button2.Visible = False
        Me.Size = New System.Drawing.Size(293, 299)
    End Sub
End Class