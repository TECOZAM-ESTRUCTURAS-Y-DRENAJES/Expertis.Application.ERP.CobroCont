Public Class CIRemesas
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.ExecuteActions.Visible = Janus.Windows.UI.InheritableBoolean.False
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents lblfwiRemesaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFNegHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblfwiFNegHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiRemesaDesde As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiRemesaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFNegDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblfwiFNegDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiTipoNeg As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblfwiTipoNeg As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiRemesaHasta As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiTipoNeg_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIRemesas))
        Me.lblfwiRemesaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFNegHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFNegHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRemesaDesde = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiRemesaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFNegDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFNegDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTipoNeg = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiTipoNeg = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRemesaHasta = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.fwiTipoNeg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.fwiRemesaHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiFNegHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiRemesaDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiFNegDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiTipoNeg)
        Me.FilterPanel.Controls.Add(Me.fwiFNegHasta)
        Me.FilterPanel.Controls.Add(Me.fwiRemesaDesde)
        Me.FilterPanel.Controls.Add(Me.fwiFNegDesde)
        Me.FilterPanel.Controls.Add(Me.fwiTipoNeg)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 325)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 96)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 325)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Cobro"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.FrozenColumns = 1
        Me.Grid.Hierarchical = True
        Me.Grid.KeyField = "IDRemesa"
        Me.Grid.Size = New System.Drawing.Size(688, 325)
        Me.Grid.ViewName = "vFrmMntoRemesa"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(688, 421)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(688, 421)
        '
        'lblfwiRemesaHasta
        '
        Me.lblfwiRemesaHasta.Location = New System.Drawing.Point(384, 56)
        Me.lblfwiRemesaHasta.Name = "lblfwiRemesaHasta"
        Me.lblfwiRemesaHasta.Size = New System.Drawing.Size(72, 17)
        Me.lblfwiRemesaHasta.TabIndex = 0
        Me.lblfwiRemesaHasta.Tag = "IdRec=5594;"
        Me.lblfwiRemesaHasta.Text = "Remesa <="
        '
        'fwiFNegHasta
        '
        Me.fwiFNegHasta.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFNegHasta.Location = New System.Drawing.Point(384, 56)
        Me.fwiFNegHasta.Name = "fwiFNegHasta"
        Me.fwiFNegHasta.Size = New System.Drawing.Size(85, 21)
        Me.fwiFNegHasta.TabIndex = 3
        '
        'lblfwiFNegHasta
        '
        Me.lblfwiFNegHasta.Location = New System.Drawing.Point(256, 56)
        Me.lblfwiFNegHasta.Name = "lblfwiFNegHasta"
        Me.lblfwiFNegHasta.Size = New System.Drawing.Size(125, 13)
        Me.lblfwiFNegHasta.TabIndex = 2
        Me.lblfwiFNegHasta.Tag = "IdRec=4747;"
        Me.lblfwiFNegHasta.Text = "Fecha Negociación <"
        '
        'fwiRemesaDesde
        '
        Me.fwiRemesaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRemesaDesde.Location = New System.Drawing.Point(104, 32)
        Me.fwiRemesaDesde.Name = "fwiRemesaDesde"
        Me.fwiRemesaDesde.Size = New System.Drawing.Size(87, 21)
        Me.fwiRemesaDesde.TabIndex = 0
        '
        'lblfwiRemesaDesde
        '
        Me.lblfwiRemesaDesde.Location = New System.Drawing.Point(16, 32)
        Me.lblfwiRemesaDesde.Name = "lblfwiRemesaDesde"
        Me.lblfwiRemesaDesde.Size = New System.Drawing.Size(75, 13)
        Me.lblfwiRemesaDesde.TabIndex = 4
        Me.lblfwiRemesaDesde.Tag = "IdRec=4746;"
        Me.lblfwiRemesaDesde.Text = "Remesa >="
        '
        'fwiFNegDesde
        '
        Me.fwiFNegDesde.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFNegDesde.Location = New System.Drawing.Point(384, 32)
        Me.fwiFNegDesde.Name = "fwiFNegDesde"
        Me.fwiFNegDesde.Size = New System.Drawing.Size(85, 21)
        Me.fwiFNegDesde.TabIndex = 2
        '
        'lblfwiFNegDesde
        '
        Me.lblfwiFNegDesde.Location = New System.Drawing.Point(256, 32)
        Me.lblfwiFNegDesde.Name = "lblfwiFNegDesde"
        Me.lblfwiFNegDesde.Size = New System.Drawing.Size(125, 13)
        Me.lblfwiFNegDesde.TabIndex = 5
        Me.lblfwiFNegDesde.Tag = "IdRec=4745;"
        Me.lblfwiFNegDesde.Text = "Fecha Negociación >"
        '
        'fwiTipoNeg
        '
        fwiTipoNeg_DesignTimeLayout.LayoutString = resources.GetString("fwiTipoNeg_DesignTimeLayout.LayoutString")
        Me.fwiTipoNeg.DesignTimeLayout = fwiTipoNeg_DesignTimeLayout
        Me.fwiTipoNeg.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTipoNeg.DisplayMember = "Text"
        Me.fwiTipoNeg.Location = New System.Drawing.Point(592, 32)
        Me.fwiTipoNeg.Name = "fwiTipoNeg"
        Me.fwiTipoNeg.SelectedIndex = -1
        Me.fwiTipoNeg.SelectedItem = Nothing
        Me.fwiTipoNeg.Size = New System.Drawing.Size(80, 21)
        Me.fwiTipoNeg.TabIndex = 4
        Me.fwiTipoNeg.ValueMember = "Value"
        '
        'lblfwiTipoNeg
        '
        Me.lblfwiTipoNeg.Location = New System.Drawing.Point(488, 34)
        Me.lblfwiTipoNeg.Name = "lblfwiTipoNeg"
        Me.lblfwiTipoNeg.Size = New System.Drawing.Size(103, 13)
        Me.lblfwiTipoNeg.TabIndex = 6
        Me.lblfwiTipoNeg.Tag = "IdRec=4744;"
        Me.lblfwiTipoNeg.Text = "Tipo Negociación"
        '
        'fwiRemesaHasta
        '
        Me.fwiRemesaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRemesaHasta.Location = New System.Drawing.Point(104, 56)
        Me.fwiRemesaHasta.Name = "fwiRemesaHasta"
        Me.fwiRemesaHasta.Size = New System.Drawing.Size(87, 21)
        Me.fwiRemesaHasta.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Tag = "IdRec=5594;"
        Me.Label1.Text = "Remesa <="
        '
        'CIRemesas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "Cobro"
        Me.KeyField = "IDRemesa"
        Me.Name = "CIRemesas"
        Me.ViewName = "vFrmMntoRemesa"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.fwiTipoNeg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mblnImprimirRemesa As Boolean
    Private mintIDRemesa As Integer
    Private mIDProcess As System.Guid
    Private mblnContabilidad As Boolean
    Private mblnContabilidadMultiple As Boolean

    Private mIDProcessGastos As System.Guid

    Private cnVER_REMESA As String = "Ver Remesa/Anticipo"
    Private cnVER_ASIENTO_REMESA As String = "Ver Asiento Remesa"
    Private cnVER_ASIENTO_REMESA_ANTICIPO As String = "Ver Asiento Anticipo"
    Private cnMODIFICAR_REMESA As String = "Modificar Remesa"
    Private cnMODIFICAR_REMESA_ANTICIPO As String = "Modificar Anticipo"
    Private cnELIMINAR_REMESA As String = "Eliminar Remesa"
    Private cnELIMINAR_REMESA_ANTICIPO As String = "Eliminar Anticipo"
    Private cnDESCONTABILIZAR_REMESA As String = "Descontablizar Remesa"
    Private cnDESCONTABILIZAR_REMESA_ANTICIPO As String = "Descontablizar Anticipo"
    Private cnVER_LIQUIDACION_REMESA As String = "Ver Asiento Liquidación"
    Private cnVER_CANCELACION_REMESA_ANTICIPO As String = "Ver Asiento Cancelación Anticipo"
    Private cnELIMINAR_LIQUIDACION_REMESA As String = "Eliminar Liquidación de Remesa"
    Private cnELIMINAR_CANCELACION_REMESA_ANTICIPO As String = "Eliminar Cancelación Anticipo"
    Private cnVER_FACTURAS_GASTOS As String = "Ver Facturas Gastos"
    Private cnGENERAR_FACTURAS_GASTOS As String = "Generar Facturas Gastos"


#Region " Carga del formulario "

    Private Sub CIRemesas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadEnums()
            LoadGridActions()
            LoadParams()
        End If
    End Sub

    Private Sub LoadParams()
        If Not Me.Params Is Nothing Then
            Dim IDRemesa As Integer = Me.Params
            Me.fwiRemesaDesde.Text = IDRemesa
            Me.fwiRemesaHasta.Text = IDRemesa
            Me.Execute()
        End If
    End Sub

    Private Sub LoadERPData()
        mblnContabilidad = New ParametroContabilidad().Contabilidad
        mblnContabilidadMultiple = New Parametro().ContabilidadMultiple
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumTipoRemesa", Grid.Columns("IDTipoNegociacion"))
        fwiTipoNeg.DataSource = New EnumData("enumTipoRemesaConsulta")

        EnumData.PopulateValueList("enumEstadoAnticipo", Grid.RootTable.ChildTables("GridCobrosRemesa").Columns("EstadoAnticipo"))

        Me.Grid.RootTable.ChildTables(0).Columns("IDTipoMandato").DropDown.SetDataBinding(EnumData.EnumView("TipoMandato"), Nothing)
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Clear()
        Grid.Actions.Add(cnVER_REMESA, AddressOf AccionGridCargarRemesa)
        If mblnContabilidad Then
            Grid.Actions.Add(cnVER_ASIENTO_REMESA, AddressOf AccionGridCargarAsientoRemesa)
            Grid.Actions.Add(cnVER_ASIENTO_REMESA_ANTICIPO, AddressOf AccionGridCargarAsientoRemesaAnticipo)
        End If
        Grid.Actions.Add(cnMODIFICAR_REMESA, AddressOf AccionGridModificarRemesa)
        Grid.Actions.Add(cnMODIFICAR_REMESA_ANTICIPO, AddressOf AccionGridModificarRemesaAnticipo)
        Grid.Actions.Add(cnELIMINAR_REMESA, AddressOf AccionGridEliminarRemesa)
        Grid.Actions.Add(cnELIMINAR_REMESA_ANTICIPO, AddressOf AccionGridEliminarRemesaAnticipo)
        If mblnContabilidad Then
            Grid.Actions.Add(cnDESCONTABILIZAR_REMESA, AddressOf AccionGridDescontabilizarRemesa)
            Grid.Actions.Add(cnDESCONTABILIZAR_REMESA_ANTICIPO, AddressOf AccionGridDescontabilizarRemesaAnticipo)
            Grid.Actions.Add(cnVER_LIQUIDACION_REMESA, AddressOf AccionGridCargarAsientoLiquidacion)
            Grid.Actions.Add(cnVER_CANCELACION_REMESA_ANTICIPO, AddressOf AccionGridCargarAsientoLiquidacionAnticipo)
        End If
        Grid.Actions.Add(cnELIMINAR_LIQUIDACION_REMESA, AddressOf AccionGridEliminarAsientoLiquidacion)
        Grid.Actions.Add(cnELIMINAR_CANCELACION_REMESA_ANTICIPO, AddressOf AccionGridEliminarAsientoLiquidacionAnticipo)
        Grid.AddSeparator()
        Grid.Actions.Add(cnVER_FACTURAS_GASTOS, AddressOf AccionVerCompras)
        Grid.Actions.Add(cnGENERAR_FACTURAS_GASTOS, AddressOf AccionGenerarCompras)
        'Grid.Actions.Add("Eliminar Relación Remesa Facturas", AddressOf AccionEliminarRelacionCompras)
    End Sub


#End Region

    Private Sub fwiRemesaDesde_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiRemesaDesde.Validated
        fwiRemesaHasta.Text = fwiRemesaDesde.Text
    End Sub


    Private Sub fwiFNegDesde_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiFNegDesde.Validated
        fwiFNegHasta.Value = fwiFNegDesde.Value
    End Sub

#Region " Consulta Interactiva "

    Private Sub CIRemesas_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        With e.Filter
            .Add("IDRemesa", FilterOperator.GreaterThanOrEqual, fwiRemesaDesde.Text, FilterType.Numeric)
            .Add("IDRemesa", FilterOperator.LessThanOrEqual, fwiRemesaHasta.Text, FilterType.Numeric)
            .Add("FechaNegociacion", FilterOperator.GreaterThanOrEqual, fwiFNegDesde.Value, FilterType.DateTime)
            .Add("FechaNegociacion", FilterOperator.LessThanOrEqual, fwiFNegHasta.Value, FilterType.DateTime)
            If fwiTipoNeg.Value <> enumTipoRemesaConsulta.Todo Then
                .Add("IdTipoNegociacion", FilterOperator.Equal, fwiTipoNeg.Value, FilterType.Numeric)
            End If
        End With

    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        fwiTipoNeg.Value = CInt(enumTipoRemesaConsulta.Todo)
    End Sub

#End Region

#Region " Acciones del grid "

    Private Sub AccionGridCargarRemesa()
        Dim objfrmConsRemesa As New frmConsultaRemesa
        objfrmConsRemesa.IDRemesa = Grid.Value("IDRemesa")
        objfrmConsRemesa.ShowDialog(Me)
    End Sub

    Private Sub AccionGridCargarAsientoRemesa()
        Dim dtAsientos As New DataTable
        Dim dtNAsientos As New DataTable

        Dim fRemesa As New Filter
        fRemesa.Add(New NumberFilterItem("IDRemesa", Grid.Value("IDRemesa")))

        Dim dtCobro As DataTable = New Cobro().Filter(fRemesa)
        ComprobarAsientos(dtCobro, enumDiarioTipoApunte.Remesa, dtNAsientos, dtAsientos, Grid.Value("IDRemesa"))

        Dim objfrmConsAsientoRemesa As New frmConsultaAsientoRemesa
        objfrmConsAsientoRemesa.IDRemesa = Grid.Value("IDRemesa")
        objfrmConsAsientoRemesa.TipoNegociacion = Grid.Value("IDTipoNegociacion")
        objfrmConsAsientoRemesa.TipoAsiento = enumDiarioTipoApunte.Remesa
        objfrmConsAsientoRemesa.Accion = frmConsultaAsientoRemesa.enumTipoAccion.Consulta
        objfrmConsAsientoRemesa.Asientos = dtAsientos
        objfrmConsAsientoRemesa.NAsientos = dtNAsientos
        objfrmConsAsientoRemesa.ShowDialog(Me)
    End Sub

    Protected Overridable Sub ComprobarAsientos(ByVal dtCobros As DataTable, _
                                 ByVal pTipoAsiento As enumDiarioTipoApunte, _
                                 ByRef outDT_NAsientos As DataTable, _
                                 ByRef outDT_Asientos As DataTable, ByVal IDRemesa As Integer)
        'Dim strListaCobro(-1) As String
        'Dim row As DataRow
        Dim strEjercicio As String

        Dim IDEjercicioAnticipo As String
        Dim IDTipoNegociacion As enumTipoRemesa
        Dim dtRemesa As DataTable = New Remesa().SelOnPrimaryKey(IDRemesa)
        If dtRemesa.Rows.Count > 0 Then
            IDTipoNegociacion = dtRemesa.Rows(0)("IDTipoNegociacion")
            If IDTipoNegociacion = enumTipoRemesa.RemesaAnticipo Then IDEjercicioAnticipo = dtRemesa.Rows(0)("IDEjercicioAnticipo") & String.Empty
        End If

        Dim fEjercicio As New Filter(FilterUnionOperator.Or)

        If Not IsNothing(dtCobros) AndAlso dtCobros.Rows.Count > 0 Then
            If Engine.Length(dtCobros.Rows(0)("IDEjercicio")) > 0 OrElse Length(IDEjercicioAnticipo) > 0 Then
                If IDTipoNegociacion <> enumTipoRemesa.RemesaAnticipo Then
                    strEjercicio = dtCobros.Rows(0)("IDEjercicio")
                Else
                    If pTipoAsiento <> enumDiarioTipoApunte.CancelacionAnticipo Then
                        strEjercicio = IDEjercicioAnticipo
                    Else
                        strEjercicio = String.Empty
                    End If
                End If

                Dim objFilter As New Filter
                Dim objFilterSinEjercicio As New Filter(FilterUnionOperator.And)

                'If pTipoAsiento = enumDiarioTipoApunte.LiquidacionRemesa Then
                '    Dim fTipoApte As New Filter(FilterUnionOperator.Or)
                '    fTipoApte.Add(New NumberFilterItem("IDTipoApunte", pTipoAsiento))
                '    fTipoApte.Add(New NumberFilterItem("IDTipoApunte", enumDiarioTipoApunte.Remesa))
                '    objFilter.Add(fTipoApte)
                'Else
                objFilter.Add(New NumberFilterItem("IDTipoApunte", pTipoAsiento))

                'End If

                If IDTipoNegociacion <> enumTipoRemesa.RemesaAnticipo Then
                    objFilter.Add(New StringFilterItem("NDocumento", CStr(IDRemesa)))

                Else
                    Dim fCobros As New Filter(FilterUnionOperator.Or)
                    For Each drCobro As DataRow In dtCobros.Rows
                        fCobros.Add(New NumberFilterItem("IDDocumento", drCobro("IDCobro")))
                    Next
                    objFilter.Add(fCobros)
                End If

                objFilterSinEjercicio.Add(objFilter)
                Dim strWhereSinEjercicio As String = objFilterSinEjercicio.Compose(New AdoFilterComposer) & " Group By NAsiento, IdEjercicio"

                If Engine.Length(strEjercicio) > 0 Then
                    If mblnContabilidadMultiple Then
                        Dim Ej As New EjercicioContable
                        Dim dtEjercicio As DataTable = Ej.SelOnPrimaryKey(strEjercicio)
                        If dtEjercicio.Rows.Count > 0 Then
                            If Nz(dtEjercicio.Rows(0)("EjercicioTributario"), False) Then
                                Dim dtEjercicioNIIF As DataTable = Ej.Filter(New StringFilterItem("IDEjercicio", strEjercicio))
                                If dtEjercicioNIIF.Rows.Count > 0 Then
                                    fEjercicio.Add(New StringFilterItem("IDEjercicio", dtEjercicioNIIF.Rows(0)("IDEjercicio")))
                                End If
                            Else
                                fEjercicio.Add(New StringFilterItem("IDEjercicio", strEjercicio))
                                If Length(dtEjercicio.Rows(0)("IDEjercicioTributario")) > 0 Then
                                    fEjercicio.Add(New StringFilterItem("IDEjercicio", dtEjercicio.Rows(0)("IDEjercicioTributario")))
                                End If
                            End If
                        End If
                    Else
                        fEjercicio.Add(New StringFilterItem("IDEjercicio", strEjercicio))
                    End If

                    objFilter.Add(fEjercicio)
                End If
                'If pTipoAsiento = enumDiarioTipoApunte.Remesa AndAlso Length(dtCobros.Rows(0)("IDCobro")) > 0 Then
                '    objFilter.Add(New NumberFilterItem("IDDocumento", dtCobros.Rows(0)("IDCobro")))
                'End If
                Dim strWhere As String = objFilter.Compose(New AdoFilterComposer) & " Group By NAsiento, IdEjercicio"
                outDT_NAsientos = New BE.DataEngine().Filter("tbDiarioContable", "NAsiento, IdEjercicio", strWhere)

                'Si no encuentra asientos filtramos sin ejercicio.
                If Not IsNothing(outDT_NAsientos) AndAlso outDT_NAsientos.Rows.Count > 0 Then
                Else
                    outDT_NAsientos = New BE.DataEngine().Filter("tbDiarioContable", "NAsiento, IdEjercicio", strWhereSinEjercicio)
                End If

                Dim fAsientos As New Filter(FilterUnionOperator.Or)
                For Each row As DataRow In outDT_NAsientos.Rows
                    Dim fAsiEjer As New Filter
                    fAsiEjer.Add(New StringFilterItem("IDEjercicio", row("IDEjercicio")))
                    fAsiEjer.Add(New NumberFilterItem("NAsiento", row("NAsiento")))

                    fAsientos.Add(fAsiEjer)
                Next row

                If Not fAsientos Is Nothing AndAlso fAsientos.Count > 0 Then
                    Dim FilDiario As New Filter
                    FilDiario.Add(fAsientos)
                    'FilDiario.Add("IDTipoApunte", FilterOperator.Equal, pTipoAsiento)

                    outDT_Asientos = New Business.Financiero.DiarioContable().Filter(FilDiario)

                    For Each drAsiento As DataRow In outDT_NAsientos.Select()
                        Dim IDEjercicio As String = drAsiento("IDEjercicio")
                        Dim NAsiento As Integer = drAsiento("NAsiento")
                        Dim TipoApunteDistinto As List(Of Object) = (From c In outDT_Asientos _
                                                                     Where c("IDEjercicio") = IDEjercicio AndAlso c("NAsiento") = NAsiento _
                                                                     Select c("IDTipoApunte") Distinct).ToList
                        If TipoApunteDistinto.Count > 1 Then
                            For Each drapunte As DataRow In outDT_Asientos.Select("IDEjercicio = '" & IDEjercicio & "' AND NAsiento = " & NAsiento, Nothing)
                                drapunte.Delete()
                                drapunte.AcceptChanges()
                            Next

                            For Each drapunte As DataRow In outDT_NAsientos.Select("IDEjercicio = '" & IDEjercicio & "' AND NAsiento = " & NAsiento, Nothing)
                                drapunte.Delete()
                                drapunte.AcceptChanges()
                            Next

                        End If
                    Next

                End If
            End If
        End If
    End Sub


    Private mIDFacturas(-1) As Object
    Private Sub AccionGridModificarRemesa()
        Dim frm As New frmRemesaDefinitiva
        frm.MostrarContabilizacionGastosAsociados = True
        frm.Modificacion = True
        frm.IdRemesa = Grid.Value("IDRemesa")
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

            '//provisional
            mblnImprimirRemesa = frm.fwiImprimir.Checked
            mintIDRemesa = Grid.GetValue("IDRemesa")

            mdtFechaValor = Nz(frm.fwiFechaValor.Value, cnMinDate)
            mstrNDocumento = frm.fwiNDocumento.Text
            If intAccion = enumAccion.RemesaDefinitiva Then
                Dim dtFechaValor As Date = Nz(frm.fwiFechaValor.Value, cnMinDate)
                Dim strNDocumento As String = frm.fwiNDocumento.Text
                Dim strBancoPropio As String = frm.mstrBancoPropio
                Dim blnAsientoRemesa As Boolean = frm.mblnAsientoRemesa OrElse frm.ContabilizarGastosAsociados
                Dim strEjercicio As String = frm.mstrEjercicio
                Dim dtmFechaAsiento As Date = frm.mdtmFechaAsiento
                Dim intTipoAsientoRemesa As Integer = frm.mintTipoAsientoRemesa
                Dim strComentarioRemesa As String = frm.mstrComentarioRemesa

                If blnAsientoRemesa OrElse frm.ContabilizarGastosAsociados Then
                    Dim IDs(-1) As Object
                    Dim fRemesa As New Filter
                    fRemesa.Add(New NumberFilterItem("IDRemesa", mintIDRemesa))

                    Dim dtCobrosRemesa As DataTable = New Cobro().Filter(fRemesa)
                    For Each drCobro As DataRow In dtCobrosRemesa.Rows
                        ReDim Preserve IDs(UBound(IDs) + 1)
                        IDs(UBound(IDs)) = drCobro("IDCobro")
                    Next

                    If frm.ContabilizarGastosAsociados Then
                        Dim dtGastosRemesa As DataTable = New RemesaCobroFacturaCompra().Filter(fRemesa)
                        For Each drGasto As DataRow In dtGastosRemesa.Rows
                            ReDim Preserve mIDFacturas(mIDFacturas.Length)
                            mIDFacturas(mIDFacturas.Length - 1) = drGasto("IDFacturaCompra")
                        Next
                    End If

                    mIDProcess = MarcarRegistro(IDs, FilterType.Numeric)

                    Dim SimInfo As New DataSimulacionContableInfoRemesa
                    SimInfo.IDEjercicio = strEjercicio
                    SimInfo.GuidSimulacion = mIDProcess
                    SimInfo.FechaApunte = dtmFechaAsiento
                    SimInfo.IDBancoPropio = strBancoPropio
                    SimInfo.DescApunte = strComentarioRemesa
                    SimInfo.Caption = "Simulación Contable - REMESAS -"
                    SimInfo.FechaValor = dtFechaValor
                    SimInfo.NDocumento = mstrNDocumento
                    SimInfo.IDRemesa = Grid.GetValue("IDRemesa")
                    SimInfo.TipoRemesa = intTipoAsientoRemesa

                    Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
                    AddHandler oFrm.Closed, AddressOf FrmActionClosed
                Else
                    FrmActionClosed(Nothing, System.EventArgs.Empty)
                End If
            End If

            ' Me.Execute()
        End If
    End Sub

    Protected Overridable Sub AccionGridEliminarRemesa()
        Dim dtAsientos As New DataTable
        Dim dtNAsientos As New DataTable


        Dim adr As DataRow()
        Dim objFilter As New Filter
        Dim strWhere As String

        '// Se recuperan todos los cobros de la remesa seleccionada.
        Dim objNegCobro As New Cobro
        Dim fRemesa As New Filter
        fRemesa.Add(New NumberFilterItem("IdRemesa", Grid.GetValue("IDRemesa")))

        Dim dtCobro As DataTable = objNegCobro.Filter(fRemesa)

        '// Se comprueba que la Remesa no tiene liquidación. Ya que en el caso de que la tenga, no se podrá eliminar la remesa.
        objFilter.Clear()
        objFilter.Add(New NumberFilterItem("Liquidado", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))
        strWhere = objFilter.Compose(New AdoFilterComposer)
        adr = dtCobro.Select(strWhere) 'Liquidado=1
        If Not IsNothing(adr) And adr.Length > 0 Then
            ExpertisApp.GenerateMessage("Antes de eliminar la remesa debe eliminar la liquidación de la remesa.El proceso se ha cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            '//Nos quedamos con los cobros de la remesa no liquidados.
            objFilter.Clear()
            objFilter.Add(New NumberFilterItem("Liquidado", FilterOperator.NotEqual, enumContabilizado.Contabilizado))
            strWhere = objFilter.Compose(New AdoFilterComposer)

            adr = dtCobro.Select(strWhere)  'Liquidado<>1
            ComprobarAsientos(dtCobro, enumDiarioTipoApunte.Remesa, dtNAsientos, dtAsientos, Grid.GetValue("IDRemesa"))

            If Not IsNothing(dtNAsientos) AndAlso dtNAsientos.Rows.Count > 0 Then
                Dim objfrmConsAsientoRemesa As New frmConsultaAsientoRemesa
                objfrmConsAsientoRemesa.IDRemesa = Grid.Value("IDRemesa")
                objfrmConsAsientoRemesa.TipoNegociacion = Grid.Value("IDTipoNegociacion")
                objfrmConsAsientoRemesa.TipoAsiento = enumDiarioTipoApunte.Remesa
                objfrmConsAsientoRemesa.Accion = frmConsultaAsientoRemesa.enumTipoAccion.Eliminacion
                objfrmConsAsientoRemesa.Asientos = dtAsientos
                objfrmConsAsientoRemesa.NAsientos = dtNAsientos
                objfrmConsAsientoRemesa.ShowDialog(Me)
            Else
                Dim delRem As New Cobro.DataDeleteRemesa
                delRem.IDRemesa = Nz(Grid.Value("IDRemesa"), -1)
                delRem.TipoNegociacion = Grid.Value("IdTipoNegociacion")
                delRem.TodosAsientos = True
                delRem.NAsiento = 0
                delRem.IDEjercicio = "SinEje"
                ExpertisApp.ExecuteTask(Of Cobro.DataDeleteRemesa, Boolean)(AddressOf Cobro.DeleteRemesa, delRem)
            End If
            Me.Execute()
        End If
    End Sub

    Private Sub AccionGridDescontabilizarRemesa()
        Dim objFilter As New Filter
        Dim strWhere As String
        Dim adr As DataRow()
        Dim dtAsientos As New DataTable
        Dim dtNAsientos As New DataTable

        '// Se recuperan todos los cobros de la remesa seleccionada.
        Dim objNegCobro As New Cobro
        Dim fRemesa As New Filter
        fRemesa.Add(New NumberFilterItem("IdRemesa", Grid.GetValue("IDRemesa")))

        Dim dtCobro As DataTable = objNegCobro.Filter(fRemesa)

        '// Se comprueba que la Remesa no tiene liquidación. Ya que en el caso de que la tenga, no se podrá eliminar la remesa.
        objFilter.Clear()
        objFilter.Add(New NumberFilterItem("Liquidado", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))
        strWhere = objFilter.Compose(New AdoFilterComposer)
        adr = dtCobro.Select(strWhere) 'Liquidado=1
        If Not IsNothing(adr) And adr.Length > 0 Then
            ExpertisApp.GenerateMessage("Antes de descontabilizar la remesa debe eliminar la liquidación de la remesa.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            '//Nos quedamos con los cobros de la remesa no liquidados.
            objFilter.Clear()
            objFilter.Add(New NumberFilterItem("Liquidado", FilterOperator.NotEqual, enumContabilizado.Contabilizado))
            strWhere = objFilter.Compose(New AdoFilterComposer)
            adr = dtCobro.Select(strWhere)  'Liquidado<>1
            ComprobarAsientos(dtCobro, enumDiarioTipoApunte.Remesa, dtNAsientos, dtAsientos, Grid.GetValue("IDRemesa"))

            If Not IsNothing(dtNAsientos) AndAlso dtNAsientos.Rows.Count > 0 Then
                Dim objfrmConsAsientoRemesa As New frmConsultaAsientoRemesa
                objfrmConsAsientoRemesa.IDRemesa = Grid.Value("IDRemesa")
                objfrmConsAsientoRemesa.TipoNegociacion = Grid.Value("IDTipoNegociacion")
                objfrmConsAsientoRemesa.TipoAsiento = enumDiarioTipoApunte.Remesa
                objfrmConsAsientoRemesa.Accion = frmConsultaAsientoRemesa.enumTipoAccion.Descontablizacion
                objfrmConsAsientoRemesa.Asientos = dtAsientos
                objfrmConsAsientoRemesa.NAsientos = dtNAsientos
                objfrmConsAsientoRemesa.ShowDialog(Me)
            Else
                ExpertisApp.GenerateMessage("La remesa ya está descontabilizada.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub AccionGridCargarAsientoLiquidacion()
        Dim dtAsientos As New DataTable
        Dim dtNAsientos As New DataTable

        '// Construir el filtro ("Liquidado=1 AND IdRemesa=" & Grid.Value(Grid.Columns("IDRemesa").Index))
        Dim objFilter As New Filter
        objFilter.Add(New NumberFilterItem("Liquidado", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))
        Dim fRemesa As New Filter
        fRemesa.Add(New NumberFilterItem("IdRemesa", Grid.GetValue("IDRemesa")))

        objFilter.Add(fRemesa)

        Dim dtCobro As DataTable = New Cobro().Filter(objFilter)
        ComprobarAsientos(dtCobro, enumDiarioTipoApunte.LiquidacionRemesa, dtNAsientos, dtAsientos, Grid.GetValue("IDRemesa"))

        Dim objfrmConsAsientoRemesa As New frmConsultaAsientoRemesa
        objfrmConsAsientoRemesa.IDRemesa = Grid.Value("IDRemesa")
        objfrmConsAsientoRemesa.TipoNegociacion = Grid.Value("IDTipoNegociacion")
        objfrmConsAsientoRemesa.TipoAsiento = enumDiarioTipoApunte.LiquidacionRemesa
        objfrmConsAsientoRemesa.Accion = frmConsultaAsientoRemesa.enumTipoAccion.Consulta
        objfrmConsAsientoRemesa.Asientos = dtAsientos
        objfrmConsAsientoRemesa.NAsientos = dtNAsientos
        objfrmConsAsientoRemesa.ShowDialog(Me)
    End Sub

    Private Sub AccionGridEliminarAsientoLiquidacion()
        Dim dtAsientos As New DataTable
        Dim dtNAsientos As New DataTable

        '// Construir el filtro ("Liquidado=1 AND IdRemesa=" & Grid.Value(Grid.Columns("IDRemesa").Index))
        Dim objFilter As New Filter
        objFilter.Add(New NumberFilterItem("Liquidado", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))
        Dim fRemesa As New Filter
        fRemesa.Add(New NumberFilterItem("IdRemesa", Grid.GetValue("IDRemesa")))

        objFilter.Add(fRemesa)
        Dim c As New Cobro
        Dim dtCobro As DataTable = c.Filter(objFilter)
        If mblnContabilidad Then
            ComprobarAsientos(dtCobro, enumDiarioTipoApunte.LiquidacionRemesa, dtNAsientos, dtAsientos, Grid.Value("IDRemesa"))
            If Not IsNothing(dtNAsientos) AndAlso dtNAsientos.Rows.Count > 0 Then
                Dim objfrmConsAsientoRemesa As New frmConsultaAsientoRemesa
                objfrmConsAsientoRemesa.IDRemesa = Grid.Value("IDRemesa")
                objfrmConsAsientoRemesa.TipoNegociacion = Grid.Value("IDTipoNegociacion")
                objfrmConsAsientoRemesa.TipoAsiento = enumDiarioTipoApunte.LiquidacionRemesa
                objfrmConsAsientoRemesa.Accion = frmConsultaAsientoRemesa.enumTipoAccion.Eliminacion
                objfrmConsAsientoRemesa.Asientos = dtAsientos
                objfrmConsAsientoRemesa.NAsientos = dtNAsientos
                objfrmConsAsientoRemesa.ShowDialog(Me)
            End If
        Else
            Dim IDCobros(-1) As Object
            For Each dr As DataRow In dtCobro.Rows
                ReDim Preserve IDCobros(IDCobros.Length)
                IDCobros(IDCobros.Length - 1) = dr("IDCobro")
            Next
            Dim datosLiq As New Cobro.DataLiquidacionRemesaSinConta
            datosLiq.IDCobros = IDCobros
            ExpertisApp.ExecuteTask(Of Cobro.DataLiquidacionRemesaSinConta)(AddressOf Cobro.EliminarLiquidacionRemesaSinConta, datosLiq)
        End If
        Me.Execute()
    End Sub



#Region " Gastos "

    Private Sub AccionVerCompras()
        Dim frm As New frmGastosAsociados
        frm.AbrirFormularioRemesa(Grid.Value("IDRemesa"))
    End Sub

    Private Sub AccionGenerarCompras()
        Dim HT As New Hashtable
        HT("IDRemesa") = Grid.Value("IDRemesa")
        ExpertisApp.OpenForm("MFACC", , HT)
    End Sub

    'Private Sub AccionEliminarRelacionCompras()
    '    Dim frm As New frmFacturasCompra
    '    frm.AbrirFormulario(Grid.Value("IDRemesa"), frmFacturasCompra.enumAccion.EliminarRelacionRemesaFactura)
    'End Sub

#End Region
#End Region

    Private Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim blnDoit As Boolean = True
        If Not sender Is Nothing Then
            RemoveHandler CType(sender, Form).Closed, AddressOf FrmActionClosed
            blnDoit = CType(sender, Form).DialogResult = DialogResult.OK
        End If
        If blnDoit Then
            If mblnImprimirRemesa Then
                Dim oRpt As New Report("REMDEF")
                oRpt.Filter.Add(New NumberFilterItem("IDRemesa", mintIDRemesa))
                oRpt.Formulas("NomCedente").Text = ExpertisApp.EnterpriseName
                'oRpt.Formulas("TipoRemesa").Text = fwiTipoRemesa.Value
                'oRpt.Formulas("NCuenta").Text = dtBP.Rows(0)("NCuenta") & String.Empty
                'oRpt.Formulas("DescBancoPropio").Text = dtBP.Rows(0)("DescBancoPropio") & String.Empty
                'oRpt.Formulas("FechaNeg").Text = fwiFechaNeg.Value
                'oRpt.Formulas("NRemesa").Text = lngIDRemesa
                'oRpt.OpenReport()
                ExpertisApp.OpenReport(oRpt)
            End If


            If mIDFacturas.Length > 0 Then 'AndAlso Nz(mdtFechaApunte, cnMinDate) <> cnMinDate Then
                Dim fFrasNoContabilizadas As New Filter
                fFrasNoContabilizadas.Add(New InListFilterItem("IDFactura", mIDFacturas, FilterType.Numeric))
                fFrasNoContabilizadas.Add("Estado", False)

                Dim dtFras As DataTable = New FacturaCompraCabecera().Filter(fFrasNoContabilizadas)
                If dtFras.Rows.Count > 0 Then
                    mIDProcessGastos = MarcarRegistro(mIDFacturas, FilterType.Numeric)
                    'mstrEjercicioActual = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, mdtFechaApunte)
                    Dim SimInfo As New DataSimulacionContableInfo
                    SimInfo.GuidSimulacion = mIDProcessGastos
                    SimInfo.TipoContabilizacion = enumTipoContabilizacion.tcFacturaCompra
                    'SimInfo.IDEjercicio = mstrEjercicioActual
                    'SimInfo.FechaApunte = mdtFechaApunte
                    SimInfo.Caption = "Simulación Contable - FACTURA COMPRA -"

                    If ExpertisApp.IsFormOpen("CISIMUCONT") Then ExpertisApp.CloseForm("CISIMUCONT")
                    Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
                    AddHandler oFrm.Closed, AddressOf FrmActionClosed
                End If

                ReDim mIDFacturas(-1)
            End If
        End If
        If Engine.Length(mIDProcess) > 0 Then DesmarcarRegistro(mIDProcess, FilterType.Numeric)
        If Engine.Length(mIDProcessGastos) > 0 Then DesmarcarRegistro(mIDProcessGastos, FilterType.Numeric)
        Me.Execute()

    End Sub



#Region " Anticipos "


    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        Try
            If e.Button = MouseButtons.Right AndAlso sender.name = "Grid" Then
                Grid.UiCommandManager1.Commands(cnVER_REMESA).Visible = InheritableBoolean.True
                Grid.UiCommandManager1.Commands(cnVER_FACTURAS_GASTOS).Visible = InheritableBoolean.True
                Grid.UiCommandManager1.Commands(cnGENERAR_FACTURAS_GASTOS).Visible = InheritableBoolean.True
                If Not Grid Is Nothing AndAlso Grid.RowCount > 0 AndAlso Grid.Columns.Contains("IDTipoNegociacion") Then
                    If Grid.Value("IDTipoNegociacion") = enumTipoRemesa.RemesaAnticipo Then
                        Grid.UiCommandManager1.Commands(cnMODIFICAR_REMESA_ANTICIPO).Visible = InheritableBoolean.True
                        Grid.UiCommandManager1.Commands(cnMODIFICAR_REMESA).Visible = InheritableBoolean.False

                        Grid.UiCommandManager1.Commands(cnELIMINAR_REMESA_ANTICIPO).Visible = InheritableBoolean.True
                        Grid.UiCommandManager1.Commands(cnELIMINAR_REMESA).Visible = InheritableBoolean.False

                        If mblnContabilidad Then

                            Grid.UiCommandManager1.Commands(cnVER_ASIENTO_REMESA_ANTICIPO).Visible = InheritableBoolean.True
                            Grid.UiCommandManager1.Commands(cnVER_ASIENTO_REMESA).Visible = InheritableBoolean.False

                            Grid.UiCommandManager1.Commands(cnDESCONTABILIZAR_REMESA_ANTICIPO).Visible = InheritableBoolean.True
                            Grid.UiCommandManager1.Commands(cnDESCONTABILIZAR_REMESA).Visible = InheritableBoolean.False

                            Grid.UiCommandManager1.Commands(cnVER_CANCELACION_REMESA_ANTICIPO).Visible = InheritableBoolean.True
                            Grid.UiCommandManager1.Commands(cnVER_LIQUIDACION_REMESA).Visible = InheritableBoolean.False
                        End If
                        Grid.UiCommandManager1.Commands(cnELIMINAR_CANCELACION_REMESA_ANTICIPO).Visible = InheritableBoolean.True
                        Grid.UiCommandManager1.Commands(cnELIMINAR_LIQUIDACION_REMESA).Visible = InheritableBoolean.False

                    Else
                        Grid.UiCommandManager1.Commands(cnMODIFICAR_REMESA_ANTICIPO).Visible = InheritableBoolean.False
                        Grid.UiCommandManager1.Commands(cnMODIFICAR_REMESA).Visible = InheritableBoolean.True

                        Grid.UiCommandManager1.Commands(cnELIMINAR_REMESA_ANTICIPO).Visible = InheritableBoolean.False
                        Grid.UiCommandManager1.Commands(cnELIMINAR_REMESA).Visible = InheritableBoolean.True

                        If mblnContabilidad Then

                            Grid.UiCommandManager1.Commands(cnVER_ASIENTO_REMESA_ANTICIPO).Visible = InheritableBoolean.False
                            Grid.UiCommandManager1.Commands(cnVER_ASIENTO_REMESA).Visible = InheritableBoolean.True

                            Grid.UiCommandManager1.Commands(cnDESCONTABILIZAR_REMESA_ANTICIPO).Visible = InheritableBoolean.False
                            Grid.UiCommandManager1.Commands(cnDESCONTABILIZAR_REMESA).Visible = InheritableBoolean.True

                            Grid.UiCommandManager1.Commands(cnVER_CANCELACION_REMESA_ANTICIPO).Visible = InheritableBoolean.False
                            Grid.UiCommandManager1.Commands(cnVER_LIQUIDACION_REMESA).Visible = InheritableBoolean.True
                        End If
                        Grid.UiCommandManager1.Commands(cnELIMINAR_CANCELACION_REMESA_ANTICIPO).Visible = InheritableBoolean.False
                        Grid.UiCommandManager1.Commands(cnELIMINAR_LIQUIDACION_REMESA).Visible = InheritableBoolean.True
                    End If
                End If
            End If
        Catch ex As Exception
            '//Para evitar un error, cuando estamos en el grid hijo (NO QUITAR EL try Catch)
            Grid.UiCommandManager1.Commands(cnMODIFICAR_REMESA_ANTICIPO).Visible = InheritableBoolean.False
            Grid.UiCommandManager1.Commands(cnMODIFICAR_REMESA).Visible = InheritableBoolean.False

            Grid.UiCommandManager1.Commands(cnELIMINAR_REMESA_ANTICIPO).Visible = InheritableBoolean.False
            Grid.UiCommandManager1.Commands(cnELIMINAR_REMESA).Visible = InheritableBoolean.False

            If mblnContabilidad Then

                Grid.UiCommandManager1.Commands(cnVER_ASIENTO_REMESA_ANTICIPO).Visible = InheritableBoolean.False
                Grid.UiCommandManager1.Commands(cnVER_ASIENTO_REMESA).Visible = InheritableBoolean.False

                Grid.UiCommandManager1.Commands(cnDESCONTABILIZAR_REMESA_ANTICIPO).Visible = InheritableBoolean.False
                Grid.UiCommandManager1.Commands(cnDESCONTABILIZAR_REMESA).Visible = InheritableBoolean.False

                Grid.UiCommandManager1.Commands(cnVER_CANCELACION_REMESA_ANTICIPO).Visible = InheritableBoolean.False
                Grid.UiCommandManager1.Commands(cnVER_LIQUIDACION_REMESA).Visible = InheritableBoolean.False
            End If
            Grid.UiCommandManager1.Commands(cnELIMINAR_CANCELACION_REMESA_ANTICIPO).Visible = InheritableBoolean.False
            Grid.UiCommandManager1.Commands(cnELIMINAR_LIQUIDACION_REMESA).Visible = InheritableBoolean.False


            Grid.UiCommandManager1.Commands(cnVER_REMESA).Visible = InheritableBoolean.False
            Grid.UiCommandManager1.Commands(cnVER_FACTURAS_GASTOS).Visible = InheritableBoolean.False
            Grid.UiCommandManager1.Commands(cnGENERAR_FACTURAS_GASTOS).Visible = InheritableBoolean.False
        End Try
    End Sub

    Private Sub AccionGridCargarAsientoRemesaAnticipo()
        Dim dtAsientos As New DataTable
        Dim dtNAsientos As New DataTable
        Dim fRemesa As New Filter
        fRemesa.Add(New NumberFilterItem("IDRemesaAnticipo", Grid.Value("IDRemesa")))
        Dim dtCobro As DataTable = New Cobro().Filter(fRemesa)

        ComprobarAsientos(dtCobro, enumDiarioTipoApunte.Anticipo, dtNAsientos, dtAsientos, Grid.Value("IDRemesa"))

        Dim objfrmConsAsientoRemesa As New frmConsultaAsientoRemesa
        objfrmConsAsientoRemesa.IDRemesa = Grid.Value("IDRemesa")
        objfrmConsAsientoRemesa.TipoNegociacion = Grid.Value("IDTipoNegociacion")
        objfrmConsAsientoRemesa.TipoAsiento = enumDiarioTipoApunte.Anticipo
        objfrmConsAsientoRemesa.Accion = frmConsultaAsientoRemesa.enumTipoAccion.Consulta
        objfrmConsAsientoRemesa.Asientos = dtAsientos
        objfrmConsAsientoRemesa.NAsientos = dtNAsientos
        objfrmConsAsientoRemesa.ShowDialog(Me)
    End Sub

    Private Sub AccionGridModificarRemesaAnticipo()
        If Grid.Value("IDTipoNegociacion") = enumTipoRemesa.RemesaAnticipo AndAlso Length(Grid.Value("IDEjercicioAnticipo")) > 0 AndAlso Grid.Value("ContabilizadoAnticipo") = enumContabilizado.Contabilizado Then
            ExpertisApp.GenerateMessage("La Remesa de Anticipo, ya está Contabilizada. No se permite modificar.")
            Exit Sub
        End If
        Dim frm As New frmGenerarAnticipo
        frm.MostrarContabilizacionGastosAsociados = True
        frm.Modificacion = True
        frm.IDAnticipo = Grid.Value("IDRemesa")
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

            '//provisional
            'mblnImprimirRemesa = frm.Imprimir
            mintIDRemesa = Grid.GetValue("IDRemesa")


            Dim strBancoPropio As String = frm.BancoPropio
            Dim blnAsientoRemesa As Boolean = frm.GenerarAsientoAnticipo
            Dim strEjercicio As String = frm.Ejercicio
            Dim dtmFechaAsiento As Date = frm.FechaAbono
            'Dim intTipoAsientoRemesa As Integer = frm.mintTipoAsientoRemesa
            'Dim strComentarioRemesa As String = frm.mstrComentarioRemesa

            If blnAsientoRemesa OrElse frm.ContabilizarGastosAsociados Then
                Dim IDs(-1) As Object
                Dim fRemesa As New Filter
                fRemesa.Add(New NumberFilterItem("IDRemesaAnticipo", mintIDRemesa))

                Dim dtCobrosRemesa As DataTable = New Cobro().Filter(fRemesa)

                For Each drCobro As DataRow In dtCobrosRemesa.Rows
                    ReDim Preserve IDs(UBound(IDs) + 1)
                    IDs(UBound(IDs)) = drCobro("IDCobro")
                Next
                mIDProcess = MarcarRegistro(IDs, FilterType.Numeric)

                If frm.ContabilizarGastosAsociados Then
                    fRemesa.Clear()
                    fRemesa.Add(New NumberFilterItem("IDRemesa", mintIDRemesa))
                    Dim dtGastosRemesa As DataTable = New RemesaCobroFacturaCompra().Filter(fRemesa)
                    For Each drGasto As DataRow In dtGastosRemesa.Rows
                        ReDim Preserve mIDFacturas(mIDFacturas.Length)
                        mIDFacturas(mIDFacturas.Length - 1) = drGasto("IDFacturaCompra")
                    Next
                End If


                Dim SimInfo As New DataSimulacionContableInfoRemesa
                SimInfo.IDEjercicio = strEjercicio
                SimInfo.GuidSimulacion = mIDProcess
                SimInfo.FechaApunte = dtmFechaAsiento
                SimInfo.IDBancoPropio = strBancoPropio
                SimInfo.DescApunte = frm.TextoAsientoAnticipo
                SimInfo.Anticipo = True
                SimInfo.FechaAbono = frm.FechaAbono
                SimInfo.ReferenciaAbono = frm.ReferenciaAbono
                SimInfo.Caption = "Simulación Contable - REMESAS -"
                SimInfo.FechaValor = frm.FechaAbono
                SimInfo.NDocumento = mstrNDocumento
                SimInfo.IDRemesa = Grid.GetValue("IDRemesa")
                SimInfo.TipoRemesa = enumTipoRemesa.RemesaAnticipo

                Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
                AddHandler oFrm.Closed, AddressOf FrmActionClosed
            Else
                FrmActionClosed(Nothing, System.EventArgs.Empty)
            End If


            ' Me.Execute()
        End If
    End Sub

    Protected Overridable Sub AccionGridEliminarRemesaAnticipo()
        Dim dtAsientos As New DataTable
        Dim dtNAsientos As New DataTable


        Dim adr As DataRow()
        Dim objFilter As New Filter
        Dim strWhere As String

        '// Se recuperan todos los cobros de la remesa seleccionada.
        Dim objNegCobro As New Cobro
        Dim fRemesa As New Filter
        fRemesa.Add(New NumberFilterItem("IDRemesaAnticipo", Grid.GetValue("IDRemesa")))

        Dim dtCobro As DataTable = objNegCobro.Filter(fRemesa)

        '// Se comprueba que la Remesa no tiene liquidación. Ya que en el caso de que la tenga, no se podrá eliminar la remesa.
        objFilter.Clear()
        objFilter.Add(New NumberFilterItem("EstadoAnticipo", FilterOperator.Equal, enumEstadoAnticipo.Cancelado))
        strWhere = objFilter.Compose(New AdoFilterComposer)
        adr = dtCobro.Select(strWhere) 'EstadoAnticipo=Cancelado
        If Not IsNothing(adr) And adr.Length > 0 Then
            ExpertisApp.GenerateMessage("Antes de eliminar la remesa debe eliminar la liquidación de la remesa.El proceso se ha cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            '//Nos quedamos con los cobros de la remesa no liquidados.
            objFilter.Clear()
            objFilter.Add(New NumberFilterItem("EstadoAnticipo", FilterOperator.NotEqual, enumEstadoAnticipo.Cancelado))
            strWhere = objFilter.Compose(New AdoFilterComposer)

            adr = dtCobro.Select(strWhere)  'EstadoAnticipo=Cancelado
            ComprobarAsientos(dtCobro, enumDiarioTipoApunte.Anticipo, dtNAsientos, dtAsientos, Grid.GetValue("IDRemesa"))

            If Not IsNothing(dtNAsientos) AndAlso dtNAsientos.Rows.Count > 0 Then
                Dim objfrmConsAsientoRemesa As New frmConsultaAsientoRemesa
                objfrmConsAsientoRemesa.IDRemesa = Grid.Value("IDRemesa")
                objfrmConsAsientoRemesa.TipoNegociacion = Grid.Value("IDTipoNegociacion")
                objfrmConsAsientoRemesa.TipoAsiento = enumDiarioTipoApunte.Anticipo
                objfrmConsAsientoRemesa.Accion = frmConsultaAsientoRemesa.enumTipoAccion.Eliminacion
                objfrmConsAsientoRemesa.Asientos = dtAsientos
                objfrmConsAsientoRemesa.NAsientos = dtNAsientos
                objfrmConsAsientoRemesa.ShowDialog(Me)
            Else
                Dim delRem As New Cobro.DataDeleteRemesa
                delRem.IDRemesa = Nz(Grid.Value("IDRemesa"), -1)
                delRem.TipoNegociacion = Grid.Value("IdTipoNegociacion")
                delRem.TodosAsientos = True
                delRem.NAsiento = 0
                delRem.IDEjercicio = "SinEje"
                ExpertisApp.ExecuteTask(Of Cobro.DataDeleteRemesa, Boolean)(AddressOf Cobro.DeleteRemesa, delRem)
            End If
            Me.Execute()
        End If
    End Sub

    Private Sub AccionGridDescontabilizarRemesaAnticipo()
        Dim objFilter As New Filter
        Dim strWhere As String
        Dim adr As DataRow()
        Dim dtAsientos As New DataTable
        Dim dtNAsientos As New DataTable

        '// Se recuperan todos los cobros de la remesa seleccionada.
        Dim objNegCobro As New Cobro
        Dim fRemesa As New Filter
        fRemesa.Add(New NumberFilterItem("IDRemesaAnticipo", Grid.GetValue("IDRemesa")))
        Dim dtCobro As DataTable = objNegCobro.Filter(fRemesa)

        '// Se comprueba que la Remesa no tiene liquidación. Ya que en el caso de que la tenga, no se podrá eliminar la remesa.
        objFilter.Clear()
        objFilter.Add(New NumberFilterItem("EstadoAnticipo", FilterOperator.Equal, enumEstadoAnticipo.Cancelado))
        strWhere = objFilter.Compose(New AdoFilterComposer)
        adr = dtCobro.Select(strWhere) 'EstadoAnticipo=Cancelado
        If Not IsNothing(adr) And adr.Length > 0 Then
            ExpertisApp.GenerateMessage("Antes de descontabilizar la remesa debe eliminar la liquidación de la remesa.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            '//Nos quedamos con los cobros de la remesa no liquidados.
            objFilter.Clear()
            objFilter.Add(New NumberFilterItem("EstadoAnticipo", FilterOperator.NotEqual, enumEstadoAnticipo.Cancelado))
            strWhere = objFilter.Compose(New AdoFilterComposer)
            adr = dtCobro.Select(strWhere)  'EstadoAnticipo<>Cancelado
            ComprobarAsientos(dtCobro, enumDiarioTipoApunte.Anticipo, dtNAsientos, dtAsientos, Grid.GetValue("IDRemesa"))

            If Not IsNothing(dtNAsientos) AndAlso dtNAsientos.Rows.Count > 0 Then
                Dim objfrmConsAsientoRemesa As New frmConsultaAsientoRemesa
                objfrmConsAsientoRemesa.IDRemesa = Grid.Value("IDRemesa")
                objfrmConsAsientoRemesa.TipoNegociacion = Grid.Value("IDTipoNegociacion")
                objfrmConsAsientoRemesa.TipoAsiento = enumDiarioTipoApunte.Anticipo
                objfrmConsAsientoRemesa.Accion = frmConsultaAsientoRemesa.enumTipoAccion.Descontablizacion
                objfrmConsAsientoRemesa.Asientos = dtAsientos
                objfrmConsAsientoRemesa.NAsientos = dtNAsientos
                objfrmConsAsientoRemesa.ShowDialog(Me)
            Else
                ExpertisApp.GenerateMessage("La remesa ya está descontabilizada.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            Me.Execute()
        End If
    End Sub

    Private Sub AccionGridCargarAsientoLiquidacionAnticipo()
        Dim dtAsientos As New DataTable
        Dim dtNAsientos As New DataTable

        '// Construir el filtro ("EstadoAnticipo=Cancelado AND IdRemesa=" & Grid.Value(Grid.Columns("IDRemesa").Index))
        Dim objFilter As New Filter
        objFilter.Add(New NumberFilterItem("EstadoAnticipo", FilterOperator.Equal, enumEstadoAnticipo.Cancelado))
        Dim fRemesa As New Filter
        fRemesa.Add(New NumberFilterItem("IDRemesaAnticipo", Grid.GetValue("IDRemesa")))
        objFilter.Add(fRemesa)

        Dim dtCobro As DataTable = New Cobro().Filter(objFilter)
        ComprobarAsientos(dtCobro, enumDiarioTipoApunte.CancelacionAnticipo, dtNAsientos, dtAsientos, Grid.GetValue("IDRemesa"))

        Dim objfrmConsAsientoRemesa As New frmConsultaAsientoRemesa
        objfrmConsAsientoRemesa.IDRemesa = Grid.Value("IDRemesa")
        objfrmConsAsientoRemesa.TipoNegociacion = Grid.Value("IDTipoNegociacion")
        objfrmConsAsientoRemesa.TipoAsiento = enumDiarioTipoApunte.CancelacionAnticipo
        objfrmConsAsientoRemesa.Accion = frmConsultaAsientoRemesa.enumTipoAccion.Consulta
        objfrmConsAsientoRemesa.Asientos = dtAsientos
        objfrmConsAsientoRemesa.NAsientos = dtNAsientos
        objfrmConsAsientoRemesa.ShowDialog(Me)
    End Sub

    Private Sub AccionGridEliminarAsientoLiquidacionAnticipo()
        Dim dtAsientos As New DataTable
        Dim dtNAsientos As New DataTable

        '// Construir el filtro ("EstadoAnticipo=Cancelado AND IdRemesa=" & Grid.Value(Grid.Columns("IDRemesa").Index))
        Dim objFilter As New Filter
        objFilter.Add(New NumberFilterItem("EstadoAnticipo", FilterOperator.Equal, enumEstadoAnticipo.Cancelado))
        Dim fRemesa As New Filter
        fRemesa.Add(New NumberFilterItem("IDRemesaAnticipo", Grid.GetValue("IDRemesa")))
        objFilter.Add(fRemesa)
        Dim c As New Cobro
        Dim dtCobro As DataTable = c.Filter(objFilter)
        If mblnContabilidad Then
            ComprobarAsientos(dtCobro, enumDiarioTipoApunte.CancelacionAnticipo, dtNAsientos, dtAsientos, Grid.Value("IDRemesa"))
            If Not IsNothing(dtNAsientos) AndAlso dtNAsientos.Rows.Count > 0 Then
                Dim objfrmConsAsientoRemesa As New frmConsultaAsientoRemesa
                objfrmConsAsientoRemesa.IDRemesa = Grid.Value("IDRemesa")
                objfrmConsAsientoRemesa.TipoNegociacion = Grid.Value("IDTipoNegociacion")
                objfrmConsAsientoRemesa.TipoAsiento = enumDiarioTipoApunte.CancelacionAnticipo
                objfrmConsAsientoRemesa.Accion = frmConsultaAsientoRemesa.enumTipoAccion.Eliminacion
                objfrmConsAsientoRemesa.Asientos = dtAsientos
                objfrmConsAsientoRemesa.NAsientos = dtNAsientos
                objfrmConsAsientoRemesa.ShowDialog(Me)
            End If
        Else
            Dim IDCobros(-1) As Object
            For Each dr As DataRow In dtCobro.Rows
                ReDim Preserve IDCobros(IDCobros.Length)
                IDCobros(IDCobros.Length - 1) = dr("IDCobro")
            Next
            Dim datosLiq As New Cobro.DataLiquidacionRemesaSinConta
            datosLiq.IDCobros = IDCobros
            ExpertisApp.ExecuteTask(Of Cobro.DataLiquidacionRemesaSinConta)(AddressOf Cobro.EliminarLiquidacionRemesaSinConta, datosLiq)
        End If
        Me.Execute()
    End Sub


    Private Sub Grid_GetChildList(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.GetChildListEventArgs) Handles Grid.GetChildList
        If Length(e.ParentRow.Cells("IDRemesa").Value) > 0 AndAlso Length(e.ParentRow.Cells("IDTipoNegociacion").Value) > 0 Then
            Dim f As New Filter
            If e.ParentRow.Cells("IDTipoNegociacion").Value = enumTipoRemesa.RemesaAnticipo Then
                e.ChildTable.Columns("EstadoAnticipo").Visible = True
                f.Add(New NumberFilterItem("IDRemesaAnticipo", e.ParentRow.Cells("IDRemesa").Value))
            Else
                e.ChildTable.Columns("EstadoAnticipo").Visible = False
                Dim fTrazabilidadRemesas As New Filter(FilterUnionOperator.Or)
                Dim fRemesa As New Filter
                fRemesa.Add(New NumberFilterItem("IDRemesa", e.ParentRow.Cells("IDRemesa").Value))
                fRemesa.Add(New IsNullFilterItem("IDRemesaAnterior"))
                fTrazabilidadRemesas.Add(fRemesa)
                Dim fRemesaDevol As New Filter
                'fRemesaDevol.Add(New IsNullFilterItem("IDRemesa"))
                '  fRemesaDevol.Add(New NumberFilterItem("IDRemesaAnterior", e.ParentRow.Cells("IDRemesa").Value))
                fRemesaDevol.Add(New NumberFilterItem("IDRemesaAnterior", e.ParentRow.Cells("IDRemesa").Value))
                fTrazabilidadRemesas.Add(fRemesaDevol)

                f.Add(fTrazabilidadRemesas)
            End If

            e.ChildList = New BE.DataEngine().Filter("frmCobrosRemesa", f)
        Else
            e.ChildList = Nothing
        End If
    End Sub


    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If Not e.Row.Parent Is Nothing AndAlso e.Row.Parent.GridEX.Name = "Grid" Then
                If e.Row.Cells("Situacion").Value = enumCobroSituacion.Devuelto Then
                    e.Row.RowStyle = Grid.FormatStyles("DevueltoFormatStyle")
                ElseIf e.Row.Cells("Contabilizado").Value <> enumContabilizado.NoContabilizado Then
                    e.Row.RowStyle = Grid.FormatStyles("ContabilizadoFormatStyle")
                    'e.Row.Cells("Contabilizado").ImageIndex = IconIndex.Contabilizado
                Else
                    'e.Row.Cells("Contabilizado").ImageIndex = IconIndex.NoContabilizado
                End If
                If e.Row.Parent.Cells("IDTipoNegociacion").Value = enumTipoRemesa.RemesaAnticipo Then
                    e.Row.Cells("EstadoAnticipo").Column.Visible = True
                Else
                    e.Row.Cells("EstadoAnticipo").Value = System.DBNull.Value
                    e.Row.Cells("EstadoAnticipo").Column.Visible = False
                End If
            End If

        End If
    End Sub


#End Region

End Class