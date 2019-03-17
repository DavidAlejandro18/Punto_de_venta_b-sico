Public Class Form7

    Private Sub TABLA_PRODUCTOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TABLA_PRODUCTOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TABLA_PRODUCTOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FerreteriaDataSet.TABLA_PRODUCTOS' table. You can move, or remove it, as needed.
        Me.TABLA_PRODUCTOSTableAdapter.Fill(Me.FerreteriaDataSet.TABLA_PRODUCTOS)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TABLA_PRODUCTOSDataGridView.Visible = True
        Button3.Visible = False
        Button2.Visible = True
        Me.Size = New System.Drawing.Size(791, 303)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TABLA_PRODUCTOSDataGridView.Visible = False
        Button3.Visible = True
        Button2.Visible = False
        Me.Size = New System.Drawing.Size(292, 303)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class