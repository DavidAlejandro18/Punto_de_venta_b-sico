Public Class Form2
    Dim producto As String
    Dim codigo, cantidad, total, subtotal As Integer
    Dim factura As Single
    Private Sub TABLA_PRODUCTOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TABLA_PRODUCTOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TABLA_PRODUCTOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FerreteriaDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FerreteriaDataSet.FACTURA' table. You can move, or remove it, as needed.
        Me.FACTURATableAdapter.Fill(Me.FerreteriaDataSet.FACTURA)
        'TODO: This line of code loads data into the 'FerreteriaDataSet.TABLA_PRODUCTOS' table. You can move, or remove it, as needed.
        Me.TABLA_PRODUCTOSTableAdapter.Fill(Me.FerreteriaDataSet.TABLA_PRODUCTOS)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
        If txtcantidad.Text = "" Then
            txtcantidad.Text = 0
        End If

        txtsubtotal.Text = ("$" & PRECIOV_PRODTextBox.Text * txtcantidad.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtfactura.Text = txtfactura.Text + 1
        DataGridView1.Rows.Clear()
        txttotalgeneral.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        codigo = COD_PRODUCTOTextBox.Text
        factura = Val(txtfactura.Text)
        subtotal = txtsubtotal.Text
        producto = NOMBRE_PRODTextBox.Text
        cantidad = txtcantidad.Text
        total = "$" & txtsubtotal.Text + (txtsubtotal.Text * 0.16)

        DataGridView1.Rows.Add(factura, codigo, producto, cantidad, subtotal, total)

        Dim totalcompra As Double = 0
        Dim FILA As DataGridViewRow = New DataGridViewRow()

        For Each FILA In DataGridView1.Rows
            totalcompra += Convert.ToDouble(FILA.Cells("Column6").Value)
        Next

        txttotalgeneral.Text = Convert.ToString("$" & FormatNumber(totalcompra, 2))

        Me.FACTURATableAdapter.INSERTAR(factura, codigo, producto, cantidad, subtotal, total)

        Me.FACTURATableAdapter.Fill(Me.FerreteriaDataSet.FACTURA)

        txtcantidad.Text = ""
        txtsubtotal.Text = ""

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = TimeOfDay
        Label7.Text = DateString
    End Sub
End Class