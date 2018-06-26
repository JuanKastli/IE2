Public Class FormGrid

    Private Sub FormGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = lst

    End Sub
    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click
        Form.operacion = "Agregar"
        Form.Text = "Agrega"
        Form.Show()
    End Sub

    Private Sub modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modificar.Click
        Form.operacion = "Modificar"
        Form.Text = "Modificar"
        Form.indice = DataGridView1.CurrentRow.Index
        llenarform()
        Form.ShowDialog()
    End Sub

    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click
        Form.operacion = "Eliminar"
        Form.Text = "Eliminar"
        Form.Show()
        Form.indice = DataGridView1.CurrentRow.Index
        llenarform()
        Form.Show()
    End Sub
    Private Sub llenarform()
        Form.id.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Form.fecha.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        Form.asignatura.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Form.doc.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        Form.vocal.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        Form.vocal2.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString

    End Sub

    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click
        Me.Close()
    End Sub
End Class