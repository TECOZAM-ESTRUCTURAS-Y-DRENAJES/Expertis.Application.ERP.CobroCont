Public Class CICobrosAgrupables
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents FwiFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFwiFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFwiFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiIdCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFwiIdCliente As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.FwiFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFwiFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFwiFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiIdCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFwiIdCliente = New Solmicro.Expertis.Engine.UI.Label
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CIMntoGridPanel.SuspendLayout()
        Me.FilterPanel.SuspendLayout()
       
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()

        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.SuspendLayout()
        '
        'Grid
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDCobro""><Bo" & _
        "und>False</Bound><Caption>IDCobro</Caption><Key>IDCobro</Key><Position>0</Positi" & _
        "on><TextAlignment>Far</TextAlignment><Visible>False</Visible></Column0><Column1 " & _
        "ID=""IDCliente""><Caption>Cliente</Caption><DataMember>IDCliente</DataMember><Key>" & _
        "IDCliente</Key><Position>1</Position><TextAlignment>Near</TextAlignment><Width>1" & _
        "18</Width></Column1><Column2 ID=""Titulo""><Caption>Titulo</Caption><DataMember>Ti" & _
        "tulo</DataMember><Key>Titulo</Key><Position>2</Position><TextAlignment>Near</Tex" & _
        "tAlignment><Width>241</Width></Column2><Column3 ID=""Cobros""><Caption>Cobros</Cap" & _
        "tion><DataMember>Cobros</DataMember><Key>Cobros</Key><Position>3</Position><Text" & _
        "Alignment>Near</TextAlignment><Width>50</Width></Column3><Column4 ID=""ImpVencimi" & _
        "ento""><Caption>Importe Vto.</Caption><DataMember>ImpVencimiento</DataMember><Key" & _
        ">ImpVencimiento</Key><Position>4</Position><TextAlignment>Far</TextAlignment><Wi" & _
        "dth>97</Width></Column4><Column5 ID=""AbrvMoneda""><Caption>AbrvMoneda</Caption><D" & _
        "ataMember>AbrvMoneda</DataMember><Key>AbrvMoneda</Key><Position>5</Position><Tex" & _
        "tAlignment>Near</TextAlignment><Width>27</Width></Column5><Column6 ID=""ImpVencim" & _
        "ientoA""><Caption>Importe Vto. A</Caption><DataMember>ImpVencimientoA</DataMember" & _
        "><Key>ImpVencimientoA</Key><Position>6</Position><TextAlignment>Far</TextAlignme" & _
        "nt><Width>97</Width></Column6></Columns><GroupCondition ID="""" /></RootTable></Gr" & _
        "idEXLayoutData>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = ""
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDCobro"
        Me.Grid.Name = "Grid"
        Me.Grid.RequeryManually = True
        Me.Grid.SecondaryDataFields = ""
        Me.Grid.Size = New System.Drawing.Size(688, 375)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = ""
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Name = "CIMntoGridPanel"
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 375)
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblFwiFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFwiFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFwiIdCliente)
        Me.FilterPanel.Controls.Add(Me.FwiFechaDesde)
        Me.FilterPanel.Controls.Add(Me.FwiFechaHasta)
        Me.FilterPanel.Controls.Add(Me.FwiIdCliente)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 375)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(688, 48)
        '
        
        '
        
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'MainPanel
        '
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(688, 423)
        '
       
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 26)
        Me.Menubar.Name = "Menubar"
        Me.Menubar.Size = New System.Drawing.Size(81, 26)
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'Toolbar
        '
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(318, 26)
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.False
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.False
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.False
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'FwiFechaDesde
        '
        Me.FwiFechaDesde.Location = New System.Drawing.Point(384, 19)
        Me.FwiFechaDesde.Name = "FwiFechaDesde"
        Me.FwiFechaDesde.Size = New System.Drawing.Size(96, 21)
        Me.FwiFechaDesde.TabIndex = 1
        '
        'lblFwiFechaDesde
        '
        Me.lblFwiFechaDesde.Location = New System.Drawing.Point(312, 19)
        Me.lblFwiFechaDesde.Name = "lblFwiFechaDesde"
        Me.lblFwiFechaDesde.Size = New System.Drawing.Size(60, 17)
        Me.lblFwiFechaDesde.TabIndex = 0
        Me.lblFwiFechaDesde.Tag = "IdRec=4727;"
        Me.lblFwiFechaDesde.Text = "Fecha >="
        '
        'FwiFechaHasta
        '
        Me.FwiFechaHasta.Location = New System.Drawing.Point(576, 19)
        Me.FwiFechaHasta.Name = "FwiFechaHasta"
        Me.FwiFechaHasta.Size = New System.Drawing.Size(96, 21)
        Me.FwiFechaHasta.TabIndex = 2
        '
        'lblFwiFechaHasta
        '
        Me.lblFwiFechaHasta.Location = New System.Drawing.Point(504, 19)
        Me.lblFwiFechaHasta.Name = "lblFwiFechaHasta"
        Me.lblFwiFechaHasta.Size = New System.Drawing.Size(60, 17)
        Me.lblFwiFechaHasta.TabIndex = 3
        Me.lblFwiFechaHasta.Tag = "IdRec=4726;"
        Me.lblFwiFechaHasta.Text = "Fecha <="
        '
        'FwiIdCliente
        '
        Me.FwiIdCliente.EntityName = "Cliente"
        Me.FwiIdCliente.Location = New System.Drawing.Point(80, 19)
        Me.FwiIdCliente.Name = "FwiIdCliente"
        Me.FwiIdCliente.PrimaryDataFields = "IDCliente"
        Me.FwiIdCliente.SecondaryDataFields = "IDCliente"
        Me.FwiIdCliente.Size = New System.Drawing.Size(136, 21)
        Me.FwiIdCliente.TabIndex = 0
        Me.FwiIdCliente.ViewName = "tbMaestroCliente"
        '
        'lblFwiIdCliente
        '
        Me.lblFwiIdCliente.Location = New System.Drawing.Point(13, 19)
        Me.lblFwiIdCliente.Name = "lblFwiIdCliente"
        Me.lblFwiIdCliente.Size = New System.Drawing.Size(43, 17)
        Me.lblFwiIdCliente.TabIndex = 4
        Me.lblFwiIdCliente.Tag = "IdRec=4365;"
        Me.lblFwiIdCliente.Text = "Cliente"
        '
        'CICobrosAgrupables
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = ""
        Me.KeyField = "IDCobro"
        Me.Name = "CICobrosAgrupables"
        Me.NavigationFields = ""
        Me.Text = "Selección de Cobros a agrupar"
        Me.UseCheck = True
        Me.ViewName = ""

        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CIMntoGridPanel.ResumeLayout(False)
        Me.FilterPanel.ResumeLayout(False)
        
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)

        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()

        Me.ResumeLayout(False)

    End Sub

#End Region

    Private fCriterios As New Filter
    Private mstrClientesSelec As String = String.Empty
    Private ClienteRepetido As Boolean = False

    Private Sub CICobrosAgrupables_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Me.RecordsState <> RecordsState.Initialize Then
            mstrClientesSelec = String.Empty
            Me.UnCheckAllRecords()
            Me.Execute()
        End If
    End Sub

    Private Sub CICobrosAgrupables_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadToolbarActions()
    End Sub

    Private Sub LoadToolbarActions()

        Me.FormActions.Add("Configurar Agrupaciones", AddressOf ConfigurarAgrupaciones)
        Me.FormActions.Add("Cobros Agrupados", AddressOf AbrirCobrosAgrupados)
    End Sub

    Private Sub ConfigurarAgrupaciones()
        Dim frm As New FrmAgrupaCobros
        frm.ShowDialog()

        Me.Execute()
    End Sub

    Private Sub AbrirCobrosAgrupados()
        If Not Grid.DataSource Is Nothing AndAlso Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords

            Dim HT As New Hashtable
            HT.Add("dtMarcados", dtMarcados)
            HT.Add("Criterios", fCriterios)

            ExpertisApp.OpenForm("CICOAGRUPADOS", , HT, Me)
        Else
            ExpertisApp.GenerateMessage("No hay lineas seleccionadas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CICobrosAgrupables_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        fCriterios.Clear()
        If Engine.Length(FwiIdCliente.Text) > 0 Then fCriterios.Add(New StringFilterItem("IDCliente", FilterOperator.Equal, FwiIdCliente.Text))
        If Engine.Length(FwiFechaDesde.Value) > 0 Then fCriterios.Add(New DateFilterItem("FechaVencimiento", FilterOperator.GreaterThanOrEqual, FwiFechaDesde.Value))
        If Engine.Length(FwiFechaHasta.Value) > 0 Then fCriterios.Add(New DateFilterItem("FechaVencimiento", FilterOperator.LessThanOrEqual, FwiFechaHasta.Value))

        Dim dtCobros As DataTable = ExpertisApp.ExecuteTask(Of Filter, DataTable)(AddressOf Cobro.CobrosAgrupables, fCriterios)
        Me.BindEditEvents(dtCobros)

        Grid.AddCheckColumnToDataSource(dtCobros, Nothing)
        Grid.DataSource = dtCobros
        Grid.ReQuery()
    End Sub

    Private Sub Grid_RecordChecked(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.CheckingEventArgs) Handles Grid.CheckingRecord
        If e.CheckState = CheckStates.UnChecked Then
            If Engine.Length(Grid.GetValue("IDCliente")) > 0 Then
                If InStr(mstrClientesSelec, "," & Grid.Value("IDCliente") & ",", CompareMethod.Text) = 0 Then
                    If Len(mstrClientesSelec) = 0 Then mstrClientesSelec = ","
                    mstrClientesSelec = mstrClientesSelec & Grid.GetValue("IDCliente") & ","
                Else
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("No se pueden marcar dos líneas con el mismo Cliente.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ClienteRepetido = True
                End If
            Else
                ExpertisApp.GenerateMessage("No se pueden seleccionar lineas sin Cliente configurado.{0}Por favor, revise los datos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, vbNewLine)
                e.Cancel = True
            End If
        Else
            If Length(Grid.GetValue("IDCliente")) > 0 Then
                If ClienteRepetido = True Then
                    ClienteRepetido = False
                Else
                    If InStr(mstrClientesSelec, "," & Grid.Value("IDCliente") & ",", CompareMethod.Text) > 0 Then
                        mstrClientesSelec = Replace(mstrClientesSelec, "," & Grid.Value("IDCliente") & ",", ",")
                    End If
                End If
            End If
        End If
    End Sub
End Class
