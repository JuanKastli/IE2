<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.id = New System.Windows.Forms.Label
        Me.Fechaa = New System.Windows.Forms.Label
        Me.asig = New System.Windows.Forms.Label
        Me.doc = New System.Windows.Forms.Label
        Me.vocal = New System.Windows.Forms.Label
        Me.vocal2 = New System.Windows.Forms.Label
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.docente = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ide = New System.Windows.Forms.TextBox
        Me.fecha = New System.Windows.Forms.TextBox
        Me.asignatura = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(25, 27)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(18, 13)
        Me.id.TabIndex = 0
        Me.id.Text = "ID"
        '
        'Fechaa
        '
        Me.Fechaa.AutoSize = True
        Me.Fechaa.Location = New System.Drawing.Point(25, 56)
        Me.Fechaa.Name = "Fechaa"
        Me.Fechaa.Size = New System.Drawing.Size(42, 13)
        Me.Fechaa.TabIndex = 1
        Me.Fechaa.Text = "FECHA"
        '
        'asig
        '
        Me.asig.AutoSize = True
        Me.asig.Location = New System.Drawing.Point(25, 91)
        Me.asig.Name = "asig"
        Me.asig.Size = New System.Drawing.Size(77, 13)
        Me.asig.TabIndex = 2
        Me.asig.Text = "ASIGNATURA"
        '
        'doc
        '
        Me.doc.AutoSize = True
        Me.doc.Location = New System.Drawing.Point(22, 122)
        Me.doc.Name = "doc"
        Me.doc.Size = New System.Drawing.Size(59, 13)
        Me.doc.TabIndex = 3
        Me.doc.Text = "DOCENTE"
        '
        'vocal
        '
        Me.vocal.AutoSize = True
        Me.vocal.Location = New System.Drawing.Point(28, 150)
        Me.vocal.Name = "vocal"
        Me.vocal.Size = New System.Drawing.Size(48, 13)
        Me.vocal.TabIndex = 4
        Me.vocal.Text = "VOCAL1"
        '
        'vocal2
        '
        Me.vocal2.AutoSize = True
        Me.vocal2.Location = New System.Drawing.Point(28, 183)
        Me.vocal2.Name = "vocal2"
        Me.vocal2.Size = New System.Drawing.Size(48, 13)
        Me.vocal2.TabIndex = 5
        Me.vocal2.Text = "VOCAL2"
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(25, 278)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 6
        Me.Aceptar.Text = "ACEPTAR"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(154, 278)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 7
        Me.Cancelar.Text = "CANCELAR"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'docente
        '
        Me.docente.FormattingEnabled = True
        Me.docente.Items.AddRange(New Object() {"Murua Carlos", "Tettamanti Luiz", "Gamboa Maria"})
        Me.docente.Location = New System.Drawing.Point(126, 114)
        Me.docente.Name = "docente"
        Me.docente.Size = New System.Drawing.Size(121, 21)
        Me.docente.TabIndex = 8
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(126, 147)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(126, 175)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 10
        '
        'ide
        '
        Me.ide.Location = New System.Drawing.Point(126, 24)
        Me.ide.Name = "ide"
        Me.ide.Size = New System.Drawing.Size(100, 20)
        Me.ide.TabIndex = 11
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(126, 56)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(100, 20)
        Me.fecha.TabIndex = 12
        '
        'asignatura
        '
        Me.asignatura.Location = New System.Drawing.Point(126, 83)
        Me.asignatura.Name = "asignatura"
        Me.asignatura.Size = New System.Drawing.Size(100, 20)
        Me.asignatura.TabIndex = 13
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 313)
        Me.Controls.Add(Me.asignatura)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.ide)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.docente)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.vocal2)
        Me.Controls.Add(Me.vocal)
        Me.Controls.Add(Me.doc)
        Me.Controls.Add(Me.asig)
        Me.Controls.Add(Me.Fechaa)
        Me.Controls.Add(Me.id)
        Me.Name = "Form"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id As System.Windows.Forms.Label
    Friend WithEvents Fechaa As System.Windows.Forms.Label
    Friend WithEvents asig As System.Windows.Forms.Label
    Friend WithEvents doc As System.Windows.Forms.Label
    Friend WithEvents vocal As System.Windows.Forms.Label
    Friend WithEvents vocal2 As System.Windows.Forms.Label
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents docente As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ide As System.Windows.Forms.TextBox
    Friend WithEvents fecha As System.Windows.Forms.TextBox
    Friend WithEvents asignatura As System.Windows.Forms.TextBox

End Class
