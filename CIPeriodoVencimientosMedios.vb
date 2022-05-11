Public Class CIPeriodoVencimientosMedios

    Dim dtResultadoConsulta As DataTable
    Dim dtGridPrincipal As DataTable
    Dim fBusqueda As Filter

    Private Sub CIPeriodoVencimientosMedios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InizializarGridPrincipal()
    End Sub

    Private Sub Grid_GetChildList(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.GetChildListEventArgs) Handles Grid.GetChildList
        If Length(e.ParentRow.Cells("IDCliente").Value) > 0 Then
            Dim f As New Filter
            f.Add("IDCliente", FilterOperator.Equal, e.ParentRow.Cells("IDCliente").Value)
            f.Add(fBusqueda)
            e.ChildList = New BE.DataEngine().Filter("vfrmCIPeriodoVencimientosCobrosMedios", f)
        Else
            e.ChildList = Nothing
        End If
    End Sub

    Private Sub CIPeriodoVencimientosMedios_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles Me.QueryExecuted
        Me.dtResultadoConsulta = Me.Grid.DataSource
        Dim dtClientes As DataTable = Me.dtResultadoConsulta.DefaultView.ToTable(True, "IDCliente", "DescCliente")
        If Not dtClientes Is Nothing AndAlso dtClientes.Rows.Count > 0 Then
            dtGridPrincipal.Clear()
            For Each drCliente As DataRow In dtClientes.Rows
                Dim drClientes() As DataRow = dtGridPrincipal.Select("IDCliente=" & Quoted(drCliente("IDCliente")))
                If drClientes.Length = 0 Then
                    Dim drNew As DataRow = dtGridPrincipal.NewRow
                    drNew("IDCliente") = drCliente("IDCliente")
                    drNew("DescCliente") = drCliente("DescCliente")
                    Dim SumImpVencimientoA As Double = dtResultadoConsulta.Compute("SUM(ImpVencimientoA)", "IDCliente=" & Quoted(drCliente("IDCliente")))
                    Dim SumFactorFechaFactura As Double = dtResultadoConsulta.Compute("SUM(FactorFechaFactura)", "IDCliente=" & Quoted(drCliente("IDCliente")))
                    Dim SumFactorFechaVencimientoFactura As Double = dtResultadoConsulta.Compute("SUM(FactorFechaVencimientoFactura)", "IDCliente=" & Quoted(drCliente("IDCliente")))
                    If SumImpVencimientoA = 0 Then
                        drNew("PeriodoMedioCobro") = 0
                        drNew("PeriodoMedioRetraso") = 0
                    Else
                        drNew("PeriodoMedioCobro") = SumFactorFechaFactura / SumImpVencimientoA
                        drNew("PeriodoMedioRetraso") = SumFactorFechaVencimientoFactura / SumImpVencimientoA
                    End If
                    dtGridPrincipal.Rows.Add(drNew)
                End If
            Next
        End If
        Me.Grid.DataSource = dtGridPrincipal
    End Sub

    Private Sub CIPeriodoVencimientosMedios_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        CrearFiltroBusqueda()
        e.Filter.Add("IDCliente", FilterOperator.Equal, advsCliente.Text)
        e.Filter.Add(fBusqueda)
    End Sub

    Private Sub InizializarGridPrincipal()
        dtGridPrincipal = New DataTable
        dtGridPrincipal.Columns.Add("IDCliente", GetType(String))
        dtGridPrincipal.Columns.Add("DescCliente", GetType(String))
        dtGridPrincipal.Columns.Add("PeriodoMedioCobro", GetType(Integer))
        dtGridPrincipal.Columns.Add("PeriodoMedioRetraso", GetType(Integer))
    End Sub

    Private Sub CrearFiltroBusqueda()
        fBusqueda = New Filter
        fBusqueda.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, txtFechaFacturaDesde.Value)
        fBusqueda.Add("FechaFactura", FilterOperator.LessThanOrEqual, txtFechaFacturaHasta.Value)
        fBusqueda.Add("FechaVencimientoFactura", FilterOperator.GreaterThanOrEqual, txtFechaVencimientoDesde.Value)
        fBusqueda.Add("FechaVencimientoFactura", FilterOperator.LessThanOrEqual, txtFechaVencimientoDesde.Value)
    End Sub

End Class