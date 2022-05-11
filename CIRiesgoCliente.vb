Public Class CIRiesgoCliente
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
    Friend WithEvents NtbTotalRiesgo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents AdvCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CmbSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents LblSituacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblTotalRiesgo As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIRiesgoCliente))
        Me.NtbTotalRiesgo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.AdvCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.LblTotalRiesgo = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.CmbSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.LblTotalRiesgo)
        Me.FilterPanel.Controls.Add(Me.NtbTotalRiesgo)
        Me.FilterPanel.Controls.Add(Me.LblCliente)
        Me.FilterPanel.Controls.Add(Me.AdvCliente)
        Me.FilterPanel.Controls.Add(Me.LblSituacion)
        Me.FilterPanel.Controls.Add(Me.CmbSituacion)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 333)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 88)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 333)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "Cobro"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.KeyField = "IDCobro"
        Me.Grid.Size = New System.Drawing.Size(688, 333)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vctlCICobroContRiesgoCliente"
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
        'NtbTotalRiesgo
        '
        Me.NtbTotalRiesgo.DisabledBackColor = System.Drawing.Color.White
        Me.NtbTotalRiesgo.Enabled = False
        Me.NtbTotalRiesgo.Location = New System.Drawing.Point(560, 24)
        Me.NtbTotalRiesgo.Name = "NtbTotalRiesgo"
        Me.NtbTotalRiesgo.Size = New System.Drawing.Size(121, 21)
        Me.NtbTotalRiesgo.TabIndex = 5
        '
        'AdvCliente
        '
        Me.AdvCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvCliente.EntityName = "Cliente"
        Me.AdvCliente.Location = New System.Drawing.Point(80, 22)
        Me.AdvCliente.Name = "AdvCliente"
        Me.AdvCliente.SecondaryDataFields = "IDCliente"
        Me.AdvCliente.Size = New System.Drawing.Size(128, 23)
        Me.AdvCliente.TabIndex = 0
        '
        'LblCliente
        '
        Me.LblCliente.Location = New System.Drawing.Point(8, 24)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(47, 13)
        Me.LblCliente.TabIndex = 6
        Me.LblCliente.Tag = "IdRec=4365;"
        Me.LblCliente.Text = "Cliente"
        Me.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbSituacion
        '
        Me.CmbSituacion.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        CmbSituacion_DesignTimeLayout.LayoutString = resources.GetString("CmbSituacion_DesignTimeLayout.LayoutString")
        Me.CmbSituacion.DesignTimeLayout = CmbSituacion_DesignTimeLayout
        Me.CmbSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.CmbSituacion.EntityName = "EstadoCobro"
        Me.CmbSituacion.Location = New System.Drawing.Point(80, 56)
        Me.CmbSituacion.Name = "CmbSituacion"
        Me.CmbSituacion.SecondaryDataFields = "IDEstado"
        Me.CmbSituacion.SelectedIndex = -1
        Me.CmbSituacion.SelectedItem = Nothing
        Me.CmbSituacion.Size = New System.Drawing.Size(128, 21)
        Me.CmbSituacion.TabIndex = 1
        '
        'LblSituacion
        '
        Me.LblSituacion.Location = New System.Drawing.Point(8, 56)
        Me.LblSituacion.Name = "LblSituacion"
        Me.LblSituacion.Size = New System.Drawing.Size(59, 13)
        Me.LblSituacion.TabIndex = 8
        Me.LblSituacion.Text = "Situación"
        Me.LblSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTotalRiesgo
        '
        Me.LblTotalRiesgo.Location = New System.Drawing.Point(472, 24)
        Me.LblTotalRiesgo.Name = "LblTotalRiesgo"
        Me.LblTotalRiesgo.Size = New System.Drawing.Size(77, 13)
        Me.LblTotalRiesgo.TabIndex = 9
        Me.LblTotalRiesgo.Text = "Total Riesgo"
        Me.LblTotalRiesgo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CIRiesgoCliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "Cobro"
        Me.KeyField = "IDCobro"
        Me.Name = "CIRiesgoCliente"
        Me.ViewName = "vctlCICobroContRiesgoCliente"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.CmbSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MDblDecA As Double

    Private Sub CalcularTotales()
        Dim DtGrid As DataTable = Grid.DataSource
        If Not DtGrid Is Nothing AndAlso DtGrid.Rows.Count > 0 Then
            NtbTotalRiesgo.Value = xRound(Grid.GetTotal(Grid.Columns("ImpRiesgoA"), Janus.Windows.GridEX.AggregateFunction.Sum), MDblDecA)
        End If
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGridActions()
        Dim DtMoneda As DataTable = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Moneda.ObtenerMonedaA, New Object)
        MDblDecA = DtMoneda.Rows(0)("NDecimalesImp")
    End Sub

    Private Sub CIRiesgoCliente_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If Length(AdvCliente.Text) > 0 Then
            Dim dat As DataParamRiesgoCliente = ExpertisApp.ExecuteTask(Of String, DataParamRiesgoCliente)(AddressOf Cliente.GetParamsRiesgoCliente, AdvCliente.Text)
            If Not dat Is Nothing AndAlso Not dat.IDClientesGrupo Is Nothing AndAlso dat.IDClientesGrupo.Length > 0 Then
                e.Filter.Add(New InListFilterItem("IDCliente", dat.IDClientesGrupo, FilterType.String))
            Else
                e.Filter.Add("IDCliente", FilterOperator.Equal, AdvCliente.Text, FilterType.String)
            End If
        End If
        e.Filter.Add("Situacion", FilterOperator.Equal, CmbSituacion.Value, FilterType.Numeric)
    End Sub

    Private Sub CIRiesgoCliente_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        CalcularTotales()
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente)
    End Sub

    Private Sub AccionAbrirCliente()
        If ExpertisApp.IsFormOpen("MCLIENTE") Then ExpertisApp.CloseForm("MCLIENTE")
        ExpertisApp.OpenForm("MCLIENTE", New FilterItem("IDCliente", FilterOperator.Equal, Me.Grid.GetValue("IDCliente")))
    End Sub

End Class