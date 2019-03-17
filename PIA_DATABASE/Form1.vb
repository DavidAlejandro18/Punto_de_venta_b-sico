Public Class Form1

    Private Sub PuntoDeVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuntoDeVentaToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub TablaClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TablaClientesToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub TablaPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TablaPedidosToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub TablaPedidosProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TablaPedidosProductosToolStripMenuItem.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub TablaProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TablaProductosToolStripMenuItem.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub TablaProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TablaProveedorToolStripMenuItem.Click
        Me.Hide()
        Form8.Show()
    End Sub
End Class
