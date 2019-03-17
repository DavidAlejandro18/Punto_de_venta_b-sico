Public Class Form3

    Private Sub FACTURABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FACTURABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FACTURABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FerreteriaDataSet.FACTURA' table. You can move, or remove it, as needed.
        Me.FACTURATableAdapter.Fill(Me.FerreteriaDataSet.FACTURA)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtbuscar.Text = "" Then
            MessageBox.Show("Escribe un número de factura dentro del cuadro de texto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Else
            Me.FACTURATableAdapter.FillBy(Me.FerreteriaDataSet.FACTURA, txtbuscar.Text)

            Dim totalcompra As Double = 0
            Dim FILA As DataGridViewRow = New DataGridViewRow()

            For Each FILA In FACTURADataGridView.Rows
                totalcompra += Convert.ToDouble(FILA.Cells(5).Value)
            Next

            txttotalgeneral.Text = Convert.ToString("$" & FormatNumber(totalcompra, 2))
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FACTURABindingNavigator.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(50, 0, 0, 0)
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
        FACTURABindingNavigator.Visible = True
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
    End Sub
End Class