Imports System.ComponentModel
Public Class ClassTurnosCollection


    Inherits BindingList(Of ClassTurnos)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)

        e.NewObject = New ClassTurnos()

    End Sub
End Class
