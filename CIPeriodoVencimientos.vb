﻿Public Class CIPeriodoVencimientos

    Private Sub CIPeriodoVencimientos_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FilterClearing
        Me.ntbDiasVencimiento.Value = Nothing
    End Sub

    Private Sub CIPeriodoVencimientos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            Me.Toolbar.Commands("ExecuteActions").Visible = Janus.Windows.UI.InheritableBoolean.False
            Me.ntbDiasVencimiento.Value = Nothing

            LoadGridActions()
        End If
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add("Abrir Factura Venta", AddressOf AbrirFacturaVenta, ExpertisApp.GetIcon("xFacturaVenta.ico"))
    End Sub

    Private Sub AbrirFacturaVenta()
        ExpertisApp.OpenForm("MFACTV", New NumberFilterItem("IdFactura", Grid.Value("IdFactura")))
    End Sub

    Private Sub CIPeriodoVencimientos_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, Me.clbFechaFacturaD.Value)
        e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, Me.clbFechaFacturaH.Value)
        e.Filter.Add("FechaCobro", FilterOperator.GreaterThanOrEqual, Me.ClbFechaCobroDesde.Value)
        e.Filter.Add("FechaCobro", FilterOperator.LessThanOrEqual, Me.ClbFechaCobroHasta.Value)
        e.Filter.Add("IDCliente", FilterOperator.Equal, advIDCliente.Value)
        e.Filter.Add("DiasVencimiento", FilterOperator.GreaterThanOrEqual, ntbDiasVencimiento.Value)
    End Sub

End Class