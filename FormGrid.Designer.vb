<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGrid
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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.aceptar = New System.Windows.Forms.Button
        Me.modificar = New System.Windows.Forms.Button
        Me.eliminar = New System.Windows.Forms.Button
        Me.salir = New System.Windows.Forms.Button
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AsignaturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Vocal1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Vocal2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClassTurnosCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassTurnosCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.AsignaturaDataGridViewTextBoxColumn, Me.DocenteDataGridViewTextBoxColumn, Me.Vocal1DataGridViewTextBoxColumn, Me.Vocal2DataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClassTurnosCollectionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(644, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'aceptar
        '
        Me.aceptar.Location = New System.Drawing.Point(34, 205)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(75, 23)
        Me.aceptar.TabIndex = 1
        Me.aceptar.Text = "ACEPTAR"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.Location = New System.Drawing.Point(155, 205)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(75, 23)
        Me.modificar.TabIndex = 2
        Me.modificar.Text = "MODIFICAR"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(254, 204)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(75, 23)
        Me.eliminar.TabIndex = 3
        Me.eliminar.Text = "ELIMINAR"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(487, 205)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(75, 23)
        Me.salir.TabIndex = 4
        Me.salir.Text = "SALIR"
        Me.salir.UseVisualStyleBackColor = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AsignaturaDataGridViewTextBoxColumn
        '
        Me.AsignaturaDataGridViewTextBoxColumn.DataPropertyName = "Asignatura"
        Me.AsignaturaDataGridViewTextBoxColumn.HeaderText = "Asignatura"
        Me.AsignaturaDataGridViewTextBoxColumn.Name = "AsignaturaDataGridViewTextBoxColumn"
        Me.AsignaturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocenteDataGridViewTextBoxColumn
        '
        Me.DocenteDataGridViewTextBoxColumn.DataPropertyName = "Docente"
        Me.DocenteDataGridViewTextBoxColumn.HeaderText = "Docente"
        Me.DocenteDataGridViewTextBoxColumn.Name = "DocenteDataGridViewTextBoxColumn"
        Me.DocenteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Vocal1DataGridViewTextBoxColumn
        '
        Me.Vocal1DataGridViewTextBoxColumn.DataPropertyName = "Vocal1"
        Me.Vocal1DataGridViewTextBoxColumn.HeaderText = "Vocal1"
        Me.Vocal1DataGridViewTextBoxColumn.Name = "Vocal1DataGridViewTextBoxColumn"
        Me.Vocal1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Vocal2DataGridViewTextBoxColumn
        '
        Me.Vocal2DataGridViewTextBoxColumn.DataPropertyName = "Vocal2"
        Me.Vocal2DataGridViewTextBoxColumn.HeaderText = "Vocal2"
        Me.Vocal2DataGridViewTextBoxColumn.Name = "Vocal2DataGridViewTextBoxColumn"
        Me.Vocal2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassTurnosCollectionBindingSource
        '
        Me.ClassTurnosCollectionBindingSource.DataSource = GetType(IE2.ClassTurnosCollection)
        '
        'FormGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 262)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormGrid"
        Me.Text = "FormGrid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassTurnosCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents aceptar As System.Windows.Forms.Button
    Friend WithEvents modificar As System.Windows.Forms.Button
    Friend WithEvents eliminar As System.Windows.Forms.Button
    Friend WithEvents salir As System.Windows.Forms.Button
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AsignaturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vocal1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vocal2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassTurnosCollectionBindingSource As System.Windows.Forms.BindingSource
End Class
