Public Class Form4

    Private Sub TABLA_CLIENTESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TABLA_CLIENTESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TABLA_CLIENTESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FerreteriaDataSet.TABLA_CLIENTES' table. You can move, or remove it, as needed.
        Me.TABLA_CLIENTESTableAdapter.Fill(Me.FerreteriaDataSet.TABLA_CLIENTES)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TABLA_CLIENTESDataGridView.Visible = True
        Button2.Visible = False
        Button3.Visible = True
        Me.Size = New System.Drawing.Size(834, 348)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TABLA_CLIENTESDataGridView.Visible = False
        Button2.Visible = True
        Button3.Visible = False
        Me.Size = New System.Drawing.Size(294, 348)
    End Sub
End Class