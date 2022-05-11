Public Class CICartaProveedores

    Private Sub CICartaProveedores_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        e.Filter.Add("IDProveedor", FilterOperator.GreaterThanOrEqual, Me.AdvProveedorDesde.Value)
        e.Filter.Add("IDProveedor", FilterOperator.LessThanOrEqual, Me.AdvProveedorHasta.Value)
        e.Filter.Add("IDTipoProveedor", FilterOperator.Equal, Me.AdvTipoProveedor.Value)
        e.Filter.Add("IDMercado", FilterOperator.Equal, Me.AdvMercado.Value)
        e.Filter.Add("IDPais", FilterOperator.Equal, Me.AdvPais.Value)
        e.Filter.Add("IDIdioma", FilterOperator.Equal, Me.AdvIdioma.Value)
    End Sub

    Private Sub CICartaProveedores_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles Me.SetReportDesignObjects
        Select Case e.Alias
            Case "CARTAUDICAS", "CARTAUDIENG"
                Dim ClsParam As New Parametro
                e.Formulas("AuditoriaCorreos").Text = ClsParam.AuditoriaCompraEMail
                e.Formulas("AuditoriaNombre").Text = ClsParam.AuditoriaCompraNombre
                e.Formulas("AuditoriaDireccion").Text = ClsParam.AuditoriaCompraDireccion
        End Select
    End Sub

    Private Sub CICartaProveedores_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles Me.SetReportSelectionCriteria
        If Me.CheckedRecordsCount > 0 Then
            Dim IDProv() As String = (From Dr As DataRow In CType(Me.CheckedRecords, DataTable).Rows Select CStr(Dr("IDProveedor"))).ToArray
            e.Filter.Add(New InListFilterItem("IDProveedor", IDProv, FilterType.String))
        Else : ExpertisApp.GenerateMessage("No se han seleccionado registros.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class