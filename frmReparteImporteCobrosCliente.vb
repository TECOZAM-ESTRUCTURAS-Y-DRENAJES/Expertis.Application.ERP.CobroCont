Public Class frmReparteImporteCobrosCliente

    Private mImporteTotalCobros As Double
    Public WriteOnly Property ImporteTotalCobros() As Double
        Set(ByVal value As Double)
            mImporteTotalCobros = value
        End Set
    End Property

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Length(cbxIDFormaPago.Value) = 0 OrElse Length(ntxImporte.Value) = 0 Then
            ExpertisApp.GenerateMessage("Todos los datos son obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ntxImporte.Value > mImporteTotalCobros Then
            ExpertisApp.GenerateMessage("El Importe indicado no puede ser superior a la suma de los Cobros seleccionados para el Cliente {0}.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, txtIDCliente.Text)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

End Class