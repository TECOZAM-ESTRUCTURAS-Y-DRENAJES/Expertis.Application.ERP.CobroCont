Public Class CICobrosAgrupados
    Inherits Solmicro.Expertis.Engine.UI.CIMntoBase

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents panel3 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Panel4 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents LblNuevos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridNuevos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridNuevos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CICobrosAgrupados))
        Me.panel3 = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridNuevos = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel4 = New Solmicro.Expertis.Engine.UI.Panel
        Me.LblNuevos = New Solmicro.Expertis.Engine.UI.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.panel3.suspendlayout()
        CType(Me.GridNuevos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.suspendlayout()
        Me.Panel1.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.suspendlayout()
        Me.SuspendLayout()
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ExecuteQuery
        '
        Me.ExecuteQuery.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(298, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Controls.Add(Me.Splitter1)
        Me.MainPanel.Controls.Add(Me.panel3)
        Me.MainPanel.Size = New System.Drawing.Size(758, 405)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(758, 405)
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.GridNuevos)
        Me.panel3.Controls.Add(Me.Panel4)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel3.Location = New System.Drawing.Point(0, 213)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(758, 192)
        Me.panel3.TabIndex = 7
        '
        'GridNuevos
        '
        Me.GridNuevos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescFormaPago", "DescFormaPago")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCondicionPago", "CondicionPago", "IDCondicionPago"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IdClienteBanco", "ClienteBanco", "IdClienteBanco"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IdDireccion", "ClienteDireccion", "IdDireccion"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IdMoneda", "Moneda", "IdMoneda")})
        Me.GridNuevos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridNuevos.AllowCardSizing = False
        Me.GridNuevos.AllowColumnDrag = False
        Me.GridNuevos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridNuevos_DesignTimeLayout.LayoutString = resources.GetString("GridNuevos_DesignTimeLayout.LayoutString")
        Me.GridNuevos.DesignTimeLayout = GridNuevos_DesignTimeLayout
        Me.GridNuevos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridNuevos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridNuevos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridNuevos.EntityName = ""
        Me.GridNuevos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridNuevos.Location = New System.Drawing.Point(0, 29)
        Me.GridNuevos.Name = "GridNuevos"
        Me.GridNuevos.PrimaryDataFields = Nothing
        Me.GridNuevos.SecondaryDataFields = Nothing
        Me.GridNuevos.Size = New System.Drawing.Size(758, 163)
        Me.GridNuevos.TabIndex = 6
        Me.GridNuevos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridNuevos.ViewName = Nothing
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LblNuevos)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(758, 29)
        Me.Panel4.TabIndex = 4
        '
        'LblNuevos
        '
        Me.LblNuevos.Location = New System.Drawing.Point(5, 6)
        Me.LblNuevos.Name = "LblNuevos"
        Me.LblNuevos.Size = New System.Drawing.Size(168, 13)
        Me.LblNuevos.TabIndex = 4
        Me.LblNuevos.Tag = ""
        Me.LblNuevos.Text = "Registros que van a crearse"
        '
        'Splitter1
        '
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 210)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(758, 3)
        Me.Splitter1.TabIndex = 11
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Grid)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 210)
        Me.Panel1.TabIndex = 12
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = ""
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDCobro"
        Me.Grid.Location = New System.Drawing.Point(0, 26)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.RequeryManually = True
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(758, 184)
        Me.Grid.TabIndex = 8
        Me.Grid.Tag = ""
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = ""
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(758, 26)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Tag = "IdRec=4722;"
        Me.Label1.Text = "Registros que van a eliminarse"
        '
        'CICobrosAgrupados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(766, 493)
        Me.EntityName = "Cobro"
        Me.Name = "CICobrosAgrupados"
        Me.Text = "Desglose de los Cobros a agrupar"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        CType(Me.GridNuevos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private mblnInitialize As Boolean
    Private mdtFormaPago As DataTable

    Private Sub CICobrosAgrupados_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.RecordsState = RecordsState.Saved
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            mblnInitialize = True
            Me.CIPrimaryObject = Grid
            LoadERPData()
            LoadEnums()
            LoadToolbarActions()
            mblnInitialize = False
        End If
    End Sub

    Private Sub LoadERPData()
        Dim dtMarcados As New DataTable
        Dim fCriterios As New Filter
        Dim HT As Hashtable = Me.Params

        If Not HT Is Nothing Then
            dtMarcados = HT("dtMarcados")
            fCriterios = HT("Criterios")
        End If

        mdtFormaPago = New FormaPago().Filter(New Filter, , "IDFormaPago, DescFormaPago")

        Dim datos As New Cobro.DataCobrosAgrupados
        datos.CobrosAgrupables = dtMarcados
        datos.Criterios = fCriterios
        Dim result As Cobro.DataResultCobrosAgrupados = ExpertisApp.ExecuteTask(Of Cobro.DataCobrosAgrupados, Cobro.DataResultCobrosAgrupados)(AddressOf Cobro.CobrosAgrupados, datos)
        Me.BindEditEvents(result.CobrosAgrupables)

        Grid.AddCheckColumnToDataSource(result.CobrosAgrupables, Nothing)
        Grid.DataSource = result.CobrosAgrupables
        Grid.ReQuery()
        Grid.CheckAllRecords()

        GridNuevos.DataSource = result.PropuestaCobrosAgrupados
        For Each row As DataRow In CType(GridNuevos.DataSource, DataTable).Rows
            row("DescFormaPago") = GeTDescFormaPago(row("IDFormaPago"))
        Next
        GridNuevos.ReQuery()
    End Sub

    Private Function GeTDescFormaPago(ByVal IDFormaPago As String) As String
        Return (From c In mdtFormaPago Where c("IDFormaPago") = IDFormaPago Select c("DescFormaPago")).First
    End Function

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumCobroSituacion", Grid.Columns("Situacion"))
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Generar Cobros Agrupados", AddressOf CrearCobrosAgrupados)
    End Sub

    Private Sub CrearCobrosAgrupados()
        If Not Grid.DataSource Is Nothing AndAlso Grid.CheckedRecordsCount > 0 Then
            Dim mIDProcess As Guid = Grid.SaveServerChecks()
            Dim mstrIDProcess As String = mIDProcess.ToString

            Dim addCobroAgrup As New Cobro.DataAddCobrosAgrupados
            addCobroAgrup.IDProcess = mIDProcess
            addCobroAgrup.NuevosCobros = GridNuevos.DataSource
            Dim Errores() As ClassErrors = ExpertisApp.ExecuteTask(Of Cobro.DataAddCobrosAgrupados, ClassErrors())(AddressOf Cobro.AddCobrosAgrupados, addCobroAgrup)
            TratarMensajeResultado(Errores)

            Grid.DeleteServerChecks()
            Me.Close()
        Else
            ExpertisApp.GenerateMessage("No hay lineas seleccionadas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TratarMensajeResultado(ByVal Errores() As ClassErrors)
        If Not Errores Is Nothing AndAlso Errores.Length > 0 Then
            Dim strTexto As String = String.Empty
            For i As Integer = 0 To Errores.Length - 1
                If Len(strTexto) > 0 Then strTexto = strTexto & vbNewLine
                strTexto = strTexto & Errores(i).MessageError
            Next
            ExpertisApp.GenerateMessage(strTexto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ExpertisApp.GenerateMessage("Los nuevos cobros se han insertado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Grid_RecordChecked(ByVal sender As Object, ByVal e As Engine.UI.CheckedEventArgs) Handles Grid.RecordChecked
        If Not mblnInitialize Then

            Dim Cond1 As New Janus.Windows.GridEX.GridEXFilterCondition(Grid.Columns("Expertis.CheckValue"), Janus.Windows.GridEX.ConditionOperator.Equal, True)
            Dim Cond2 As New Janus.Windows.GridEX.GridEXFilterCondition(Grid.Columns("IDCliente"), Janus.Windows.GridEX.ConditionOperator.Equal, e.Row.Cells("IDCliente").Value)
            Dim Cond As New Janus.Windows.GridEX.GridEXFilterCondition
            Cond.AddCondition(Cond1)
            Cond.AddCondition(Cond2)

            Dim dFechaMin As Date = Grid.GetTotal(Grid.Columns("FechaVencimiento"), Janus.Windows.GridEX.AggregateFunction.Min, Cond)
            Dim IDClienteBancoMin As Integer = Grid.GetTotal(Grid.Columns("IDClienteBanco"), Janus.Windows.GridEX.AggregateFunction.Min, Cond)
            Dim IDFormaPagoMin As String = Grid.GetTotal(Grid.Columns("IDFormaPago"), Janus.Windows.GridEX.AggregateFunction.Min, Cond)

            Dim dt As DataTable = GridNuevos.DataSource
            Dim dtCopy As DataTable = dt.Copy
            dtCopy.DefaultView.RowFilter = "IDCliente= '" & e.Row.Cells("IDCliente").Value & "'"
            If dtCopy.DefaultView.Count > 0 Then
                If e.CheckState = CheckStates.UnChecked Then
                    dtCopy.DefaultView(0).Row("ImpVencimiento") = dtCopy.DefaultView(0).Row("ImpVencimiento") - e.Row.Cells("ImpVencimiento").Value
                    dtCopy.DefaultView(0).Row("ImpVencimientoA") = dtCopy.DefaultView(0).Row("ImpVencimientoA") - e.Row.Cells("ImpVencimientoA").Value
                    dtCopy.DefaultView(0).Row("ARepercutir") = dtCopy.DefaultView(0).Row("ARepercutir") - e.Row.Cells("ARepercutir").Value
                    dtCopy.DefaultView(0).Row("ARepercutirA") = dtCopy.DefaultView(0).Row("ARepercutirA") - e.Row.Cells("ARepercutirA").Value
                Else
                    dtCopy.DefaultView(0).Row("ImpVencimiento") = dtCopy.DefaultView(0).Row("ImpVencimiento") + e.Row.Cells("ImpVencimiento").Value
                    dtCopy.DefaultView(0).Row("ImpVencimientoA") = dtCopy.DefaultView(0).Row("ImpVencimientoA") + e.Row.Cells("ImpVencimientoA").Value
                    dtCopy.DefaultView(0).Row("ARepercutir") = dtCopy.DefaultView(0).Row("ARepercutir") + e.Row.Cells("ARepercutir").Value
                    dtCopy.DefaultView(0).Row("ARepercutirA") = dtCopy.DefaultView(0).Row("ARepercutirA") + e.Row.Cells("ARepercutirA").Value
                End If
                dtCopy.DefaultView(0).Row("FechaVencimiento") = dFechaMin
                dtCopy.DefaultView(0).Row("IDClienteBanco") = IDClienteBancoMin
                dtCopy.DefaultView(0).Row("IDFormaPago") = IDFormaPagoMin
                If dtCopy.DefaultView(0).Row("IDFormaPago") <> dtCopy.DefaultView(0).Row("IDFormaPago", DataRowVersion.Original) Then
                    dtCopy.DefaultView(0).Row("DescFormaPago") = GeTDescFormaPago(IDFormaPagoMin)
                End If
                dtCopy.AcceptChanges()
             End If
            dtCopy.DefaultView.RowStateFilter = DataViewRowState.None
            GridNuevos.DataSource = dtCopy.Copy
        End If
    End Sub

    Private Sub GridNuevos_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridNuevos.FormattingRow
        If e.Row.Cells("ImpVencimiento").Value = 0 Then
            e.Row.RowStyle = GridNuevos.FormatStyles("ImporteCero")
        End If
    End Sub

    Private Sub GridNuevos_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridNuevos.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "IDClienteBanco", "IDDireccion"
                e.Filter.Add(New StringFilterItem("IDCliente", FilterOperator.Equal, GridNuevos.GetValue("IDCliente")))
        End Select
    End Sub
End Class
