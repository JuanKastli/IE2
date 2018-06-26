Public Class Form
    Dim operacion_ As String
    Dim Miclase As New ClassTurnos

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For Each item As String In docente.Items
            ComboBox2.Items.Add(item)
            ComboBox3.Items.Add(item)
        Next
    End Sub

    Public Property operacion() As String
        Get
            Return operacion_
        End Get

        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Dim indice_ As Byte

    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Private Sub ide_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ide.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub fecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fecha.KeyPress
        If Not e.KeyChar = "/" And Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If

        Dim pos As Integer = fecha.SelectionStart
        If e.KeyChar = "/" And pos <> 2 And pos <> 5 Then
            e.Handled = False
        End If

        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 5) Then
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub asignatura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles asignatura.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub docente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles docente.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        'If docente = ComboBox2 Or docente = ComboBox3 Or ComboBox2 = ComboBox3 Then
        '    MsgBox("ERROR")
        '    docente.Focus()
        '    Exit Sub


        'End If

        Miclase.Id = (ide.Text)
        Miclase.Fecha = (fecha.Text)
        Miclase.Asignatura = (asignatura.Text)
        Miclase.Docente = docente.SelectedIndex
        Miclase.Vocal1 = ComboBox2.SelectedIndex
        Miclase.Vocal2 = ComboBox3.SelectedIndex
        Select Case operacion_
            Case "Agregar"
                lst.Add(Miclase)
            Case "Eliminar"
                lst.RemoveAt(indice_)
            Case "Modificar"
                lst.Item(indice_) = Miclase

                FormGrid.DataGridView1.Refresh()
        End Select
        Me.Close()
    End Sub

    
    Private Sub docente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles docente.SelectedIndexChanged

    End Sub

    
End Class
