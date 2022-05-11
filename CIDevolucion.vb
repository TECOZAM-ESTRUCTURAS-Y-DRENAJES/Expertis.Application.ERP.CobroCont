Public Class CIDevolucion
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
    Public WithEvents fwiImpVtoMayor As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiImpVtoMayor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpVtoMenor As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiImpVtoMenor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiARepercutirMenor As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiARepercutirMenor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiARepercutirMayor As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiARepercutirMayor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiComisionMenor As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiComisionMenor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiComisionMayor As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiComisionMayor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiGastoMenor As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiGastoMenor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiGastoMayor As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiGastoMayor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiNFacturaMenor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiNFacturaMenor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFechaVtoMenor As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblfwiFechaVtoMenor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFechaDevolMenor As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblfwiFechaDevolMenor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiNFacturaMayor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiNFacturaMayor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFechaVtoMayor As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblfwiFechaVtoMayor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFechaDevolMayor As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblfwiFechaDevolMayor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiIdCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiIdCliente As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiDescCliente As Solmicro.Expertis.Engine.UI.UnderLineLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIDevolucion))
        Me.fwiImpVtoMayor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiImpVtoMayor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpVtoMenor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiImpVtoMenor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiARepercutirMenor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiARepercutirMenor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiARepercutirMayor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiARepercutirMayor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiComisionMenor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiComisionMenor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiComisionMayor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiComisionMayor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiGastoMenor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiGastoMenor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiGastoMayor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiGastoMayor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiNFacturaMenor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiNFacturaMenor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaVtoMenor = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaVtoMenor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaDevolMenor = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaDevolMenor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiNFacturaMayor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiNFacturaMayor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaVtoMayor = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaVtoMayor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaDevolMayor = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaDevolMayor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiIdCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblcfwiDescCliente = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblfwiIdCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblcfwiDescCliente)
        Me.FilterPanel.Controls.Add(Me.lblfwiImpVtoMayor)
        Me.FilterPanel.Controls.Add(Me.fwiImpVtoMayor)
        Me.FilterPanel.Controls.Add(Me.lblfwiImpVtoMenor)
        Me.FilterPanel.Controls.Add(Me.fwiImpVtoMenor)
        Me.FilterPanel.Controls.Add(Me.lblfwiARepercutirMenor)
        Me.FilterPanel.Controls.Add(Me.fwiARepercutirMenor)
        Me.FilterPanel.Controls.Add(Me.lblfwiARepercutirMayor)
        Me.FilterPanel.Controls.Add(Me.fwiARepercutirMayor)
        Me.FilterPanel.Controls.Add(Me.lblfwiComisionMenor)
        Me.FilterPanel.Controls.Add(Me.fwiComisionMenor)
        Me.FilterPanel.Controls.Add(Me.lblfwiComisionMayor)
        Me.FilterPanel.Controls.Add(Me.fwiComisionMayor)
        Me.FilterPanel.Controls.Add(Me.lblfwiGastoMenor)
        Me.FilterPanel.Controls.Add(Me.fwiGastoMenor)
        Me.FilterPanel.Controls.Add(Me.lblfwiGastoMayor)
        Me.FilterPanel.Controls.Add(Me.fwiGastoMayor)
        Me.FilterPanel.Controls.Add(Me.lblfwiNFacturaMenor)
        Me.FilterPanel.Controls.Add(Me.fwiNFacturaMenor)
        Me.FilterPanel.Controls.Add(Me.lblfwiFechaVtoMenor)
        Me.FilterPanel.Controls.Add(Me.fwiFechaVtoMenor)
        Me.FilterPanel.Controls.Add(Me.lblfwiFechaDevolMenor)
        Me.FilterPanel.Controls.Add(Me.fwiFechaDevolMenor)
        Me.FilterPanel.Controls.Add(Me.lblfwiNFacturaMayor)
        Me.FilterPanel.Controls.Add(Me.fwiNFacturaMayor)
        Me.FilterPanel.Controls.Add(Me.lblfwiFechaVtoMayor)
        Me.FilterPanel.Controls.Add(Me.fwiFechaVtoMayor)
        Me.FilterPanel.Controls.Add(Me.lblfwiFechaDevolMayor)
        Me.FilterPanel.Controls.Add(Me.fwiFechaDevolMayor)
        Me.FilterPanel.Controls.Add(Me.lblfwiIdCliente)
        Me.FilterPanel.Controls.Add(Me.fwiIdCliente)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 285)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 136)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 285)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "CobroDevolucion"
        Me.Grid.KeyField = "IdDevolucion"
        Me.Grid.Size = New System.Drawing.Size(688, 285)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vCtlCIDevolucion"
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
        'fwiImpVtoMayor
        '
        Me.fwiImpVtoMayor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpVtoMayor.Location = New System.Drawing.Point(605, 42)
        Me.fwiImpVtoMayor.Name = "fwiImpVtoMayor"
        Me.fwiImpVtoMayor.Size = New System.Drawing.Size(76, 21)
        Me.fwiImpVtoMayor.TabIndex = 14
        '
        'lblfwiImpVtoMayor
        '
        Me.lblfwiImpVtoMayor.Location = New System.Drawing.Point(544, 42)
        Me.lblfwiImpVtoMayor.Name = "lblfwiImpVtoMayor"
        Me.lblfwiImpVtoMayor.Size = New System.Drawing.Size(75, 13)
        Me.lblfwiImpVtoMayor.TabIndex = 0
        Me.lblfwiImpVtoMayor.Text = "Imp.Vto.>="
        '
        'fwiImpVtoMenor
        '
        Me.fwiImpVtoMenor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpVtoMenor.Location = New System.Drawing.Point(605, 65)
        Me.fwiImpVtoMenor.Name = "fwiImpVtoMenor"
        Me.fwiImpVtoMenor.Size = New System.Drawing.Size(76, 21)
        Me.fwiImpVtoMenor.TabIndex = 15
        '
        'lblfwiImpVtoMenor
        '
        Me.lblfwiImpVtoMenor.Location = New System.Drawing.Point(544, 65)
        Me.lblfwiImpVtoMenor.Name = "lblfwiImpVtoMenor"
        Me.lblfwiImpVtoMenor.Size = New System.Drawing.Size(75, 13)
        Me.lblfwiImpVtoMenor.TabIndex = 15
        Me.lblfwiImpVtoMenor.Text = "Imp.Vto.<="
        '
        'fwiARepercutirMenor
        '
        Me.fwiARepercutirMenor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiARepercutirMenor.Location = New System.Drawing.Point(450, 88)
        Me.fwiARepercutirMenor.Name = "fwiARepercutirMenor"
        Me.fwiARepercutirMenor.Size = New System.Drawing.Size(76, 21)
        Me.fwiARepercutirMenor.TabIndex = 13
        '
        'lblfwiARepercutirMenor
        '
        Me.lblfwiARepercutirMenor.Location = New System.Drawing.Point(429, 88)
        Me.lblfwiARepercutirMenor.Name = "lblfwiARepercutirMenor"
        Me.lblfwiARepercutirMenor.Size = New System.Drawing.Size(25, 13)
        Me.lblfwiARepercutirMenor.TabIndex = 16
        Me.lblfwiARepercutirMenor.Text = "<="
        '
        'fwiARepercutirMayor
        '
        Me.fwiARepercutirMayor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiARepercutirMayor.Location = New System.Drawing.Point(353, 88)
        Me.fwiARepercutirMayor.Name = "fwiARepercutirMayor"
        Me.fwiARepercutirMayor.Size = New System.Drawing.Size(76, 21)
        Me.fwiARepercutirMayor.TabIndex = 12
        '
        'lblfwiARepercutirMayor
        '
        Me.lblfwiARepercutirMayor.Location = New System.Drawing.Point(292, 88)
        Me.lblfwiARepercutirMayor.Name = "lblfwiARepercutirMayor"
        Me.lblfwiARepercutirMayor.Size = New System.Drawing.Size(76, 13)
        Me.lblfwiARepercutirMayor.TabIndex = 17
        Me.lblfwiARepercutirMayor.Text = "Repercu.>="
        '
        'fwiComisionMenor
        '
        Me.fwiComisionMenor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiComisionMenor.Location = New System.Drawing.Point(450, 65)
        Me.fwiComisionMenor.Name = "fwiComisionMenor"
        Me.fwiComisionMenor.Size = New System.Drawing.Size(76, 21)
        Me.fwiComisionMenor.TabIndex = 11
        '
        'lblfwiComisionMenor
        '
        Me.lblfwiComisionMenor.Location = New System.Drawing.Point(429, 65)
        Me.lblfwiComisionMenor.Name = "lblfwiComisionMenor"
        Me.lblfwiComisionMenor.Size = New System.Drawing.Size(25, 13)
        Me.lblfwiComisionMenor.TabIndex = 18
        Me.lblfwiComisionMenor.Text = "<="
        '
        'fwiComisionMayor
        '
        Me.fwiComisionMayor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiComisionMayor.Location = New System.Drawing.Point(353, 65)
        Me.fwiComisionMayor.Name = "fwiComisionMayor"
        Me.fwiComisionMayor.Size = New System.Drawing.Size(76, 21)
        Me.fwiComisionMayor.TabIndex = 10
        '
        'lblfwiComisionMayor
        '
        Me.lblfwiComisionMayor.Location = New System.Drawing.Point(292, 65)
        Me.lblfwiComisionMayor.Name = "lblfwiComisionMayor"
        Me.lblfwiComisionMayor.Size = New System.Drawing.Size(78, 13)
        Me.lblfwiComisionMayor.TabIndex = 19
        Me.lblfwiComisionMayor.Text = "Comision>="
        '
        'fwiGastoMenor
        '
        Me.fwiGastoMenor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiGastoMenor.Location = New System.Drawing.Point(450, 42)
        Me.fwiGastoMenor.Name = "fwiGastoMenor"
        Me.fwiGastoMenor.Size = New System.Drawing.Size(76, 21)
        Me.fwiGastoMenor.TabIndex = 9
        '
        'lblfwiGastoMenor
        '
        Me.lblfwiGastoMenor.Location = New System.Drawing.Point(429, 42)
        Me.lblfwiGastoMenor.Name = "lblfwiGastoMenor"
        Me.lblfwiGastoMenor.Size = New System.Drawing.Size(25, 13)
        Me.lblfwiGastoMenor.TabIndex = 20
        Me.lblfwiGastoMenor.Text = "<="
        '
        'fwiGastoMayor
        '
        Me.fwiGastoMayor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiGastoMayor.Location = New System.Drawing.Point(353, 42)
        Me.fwiGastoMayor.Name = "fwiGastoMayor"
        Me.fwiGastoMayor.Size = New System.Drawing.Size(76, 21)
        Me.fwiGastoMayor.TabIndex = 8
        '
        'lblfwiGastoMayor
        '
        Me.lblfwiGastoMayor.Location = New System.Drawing.Point(292, 42)
        Me.lblfwiGastoMayor.Name = "lblfwiGastoMayor"
        Me.lblfwiGastoMayor.Size = New System.Drawing.Size(62, 13)
        Me.lblfwiGastoMayor.TabIndex = 21
        Me.lblfwiGastoMayor.Text = "Gasto >="
        '
        'fwiNFacturaMenor
        '
        Me.fwiNFacturaMenor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNFacturaMenor.EntityName = "FacturaVentaCabecera"
        Me.fwiNFacturaMenor.Location = New System.Drawing.Point(191, 88)
        Me.fwiNFacturaMenor.Name = "fwiNFacturaMenor"
        Me.fwiNFacturaMenor.PrimaryDataFields = "NFactura"
        Me.fwiNFacturaMenor.SecondaryDataFields = "NFactura"
        Me.fwiNFacturaMenor.Size = New System.Drawing.Size(67, 23)
        Me.fwiNFacturaMenor.TabIndex = 7
        Me.fwiNFacturaMenor.ViewName = "tbFacturaVentaCabecera"
        '
        'lblfwiNFacturaMenor
        '
        Me.lblfwiNFacturaMenor.Location = New System.Drawing.Point(170, 88)
        Me.lblfwiNFacturaMenor.Name = "lblfwiNFacturaMenor"
        Me.lblfwiNFacturaMenor.Size = New System.Drawing.Size(25, 13)
        Me.lblfwiNFacturaMenor.TabIndex = 22
        Me.lblfwiNFacturaMenor.Text = "<="
        '
        'fwiFechaVtoMenor
        '
        Me.fwiFechaVtoMenor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaVtoMenor.Location = New System.Drawing.Point(191, 65)
        Me.fwiFechaVtoMenor.Name = "fwiFechaVtoMenor"
        Me.fwiFechaVtoMenor.Size = New System.Drawing.Size(67, 21)
        Me.fwiFechaVtoMenor.TabIndex = 5
        '
        'lblfwiFechaVtoMenor
        '
        Me.lblfwiFechaVtoMenor.Location = New System.Drawing.Point(170, 65)
        Me.lblfwiFechaVtoMenor.Name = "lblfwiFechaVtoMenor"
        Me.lblfwiFechaVtoMenor.Size = New System.Drawing.Size(25, 13)
        Me.lblfwiFechaVtoMenor.TabIndex = 24
        Me.lblfwiFechaVtoMenor.Text = "<="
        '
        'fwiFechaDevolMenor
        '
        Me.fwiFechaDevolMenor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaDevolMenor.Location = New System.Drawing.Point(191, 42)
        Me.fwiFechaDevolMenor.Name = "fwiFechaDevolMenor"
        Me.fwiFechaDevolMenor.Size = New System.Drawing.Size(67, 21)
        Me.fwiFechaDevolMenor.TabIndex = 3
        '
        'lblfwiFechaDevolMenor
        '
        Me.lblfwiFechaDevolMenor.Location = New System.Drawing.Point(170, 42)
        Me.lblfwiFechaDevolMenor.Name = "lblfwiFechaDevolMenor"
        Me.lblfwiFechaDevolMenor.Size = New System.Drawing.Size(25, 13)
        Me.lblfwiFechaDevolMenor.TabIndex = 25
        Me.lblfwiFechaDevolMenor.Text = "<="
        '
        'fwiNFacturaMayor
        '
        Me.fwiNFacturaMayor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNFacturaMayor.EntityName = "FacturaVentaCabecera"
        Me.fwiNFacturaMayor.Location = New System.Drawing.Point(87, 88)
        Me.fwiNFacturaMayor.Name = "fwiNFacturaMayor"
        Me.fwiNFacturaMayor.PrimaryDataFields = "NFactura"
        Me.fwiNFacturaMayor.SecondaryDataFields = "NFactura"
        Me.fwiNFacturaMayor.Size = New System.Drawing.Size(67, 23)
        Me.fwiNFacturaMayor.TabIndex = 6
        Me.fwiNFacturaMayor.ViewName = "tbFacturaVentaCabecera"
        '
        'lblfwiNFacturaMayor
        '
        Me.lblfwiNFacturaMayor.Location = New System.Drawing.Point(6, 88)
        Me.lblfwiNFacturaMayor.Name = "lblfwiNFacturaMayor"
        Me.lblfwiNFacturaMayor.Size = New System.Drawing.Size(89, 13)
        Me.lblfwiNFacturaMayor.TabIndex = 26
        Me.lblfwiNFacturaMayor.Text = "Nº Factura >="
        '
        'fwiFechaVtoMayor
        '
        Me.fwiFechaVtoMayor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaVtoMayor.Location = New System.Drawing.Point(87, 65)
        Me.fwiFechaVtoMayor.Name = "fwiFechaVtoMayor"
        Me.fwiFechaVtoMayor.Size = New System.Drawing.Size(67, 21)
        Me.fwiFechaVtoMayor.TabIndex = 4
        '
        'lblfwiFechaVtoMayor
        '
        Me.lblfwiFechaVtoMayor.Location = New System.Drawing.Point(6, 65)
        Me.lblfwiFechaVtoMayor.Name = "lblfwiFechaVtoMayor"
        Me.lblfwiFechaVtoMayor.Size = New System.Drawing.Size(89, 13)
        Me.lblfwiFechaVtoMayor.TabIndex = 29
        Me.lblfwiFechaVtoMayor.Text = "Fecha Vto. >="
        '
        'fwiFechaDevolMayor
        '
        Me.fwiFechaDevolMayor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaDevolMayor.Location = New System.Drawing.Point(87, 42)
        Me.fwiFechaDevolMayor.Name = "fwiFechaDevolMayor"
        Me.fwiFechaDevolMayor.Size = New System.Drawing.Size(67, 21)
        Me.fwiFechaDevolMayor.TabIndex = 2
        '
        'lblfwiFechaDevolMayor
        '
        Me.lblfwiFechaDevolMayor.Location = New System.Drawing.Point(6, 42)
        Me.lblfwiFechaDevolMayor.Name = "lblfwiFechaDevolMayor"
        Me.lblfwiFechaDevolMayor.Size = New System.Drawing.Size(103, 13)
        Me.lblfwiFechaDevolMayor.TabIndex = 30
        Me.lblfwiFechaDevolMayor.Text = "Fecha Devol. >="
        '
        'fwiIdCliente
        '
        Me.fwiIdCliente.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCliente", lblcfwiDescCliente)})
        Me.fwiIdCliente.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdCliente.EntityName = "Cliente"
        Me.fwiIdCliente.Location = New System.Drawing.Point(67, 19)
        Me.fwiIdCliente.Name = "fwiIdCliente"
        Me.fwiIdCliente.PrimaryDataFields = "IDCliente"
        Me.fwiIdCliente.SecondaryDataFields = "IDCliente"
        Me.fwiIdCliente.Size = New System.Drawing.Size(86, 23)
        Me.fwiIdCliente.TabIndex = 0
        Me.fwiIdCliente.ViewName = "tbMaestroCliente"
        '
        'lblcfwiDescCliente
        '
        Me.lblcfwiDescCliente.Location = New System.Drawing.Point(160, 16)
        Me.lblcfwiDescCliente.Name = "lblcfwiDescCliente"
        Me.lblcfwiDescCliente.Size = New System.Drawing.Size(520, 23)
        Me.lblcfwiDescCliente.TabIndex = 32
        '
        'lblfwiIdCliente
        '
        Me.lblfwiIdCliente.Location = New System.Drawing.Point(6, 19)
        Me.lblfwiIdCliente.Name = "lblfwiIdCliente"
        Me.lblfwiIdCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblfwiIdCliente.TabIndex = 31
        Me.lblfwiIdCliente.Text = "Cliente"
        '
        'CIDevolucion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "CobroDevolucion"
        Me.KeyField = "IdDevolucion"
        Me.Name = "CIDevolucion"
        Me.ViewName = "vCtlCIDevolucion"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

' Migration Private Sub ShowToolBarMsg()
' Migration Dim strLinesCountMessage As String
' Migration On Error GoTo TratarError
' Migration 
' Migration strLinesCountMessage = TraslateWord(fwCheckedMessage) & " " & FwCheckedRecordsCount & " --- " & _
' Migration TraslateWord(fwSelectedMessage) & " " & Grid.RowCount
' Migration mobjMntoDoc.StatusMessage = strLinesCountMessage
' Migration 
' Migration fin:
' Migration On Error Resume Next
' Migration Exit Sub
' Migration TratarError:
' Migration GenerateError(err)
' Migration Resume fin
' Migration End Sub

   

    ' Migration Public Sub ConsultaInteractiva()
    ' Migration Dim intCuentaArg As Integer
    ' Migration Dim strFiltro As String
    ' Migration Dim FwCriterio As clsFilterCriteriaWrapper
    ' Migration On Error GoTo TratarError
    ' Migration 
    ' Migration strFiltro = vbNullString
    ' Migration FwCriterio = New clsFilterCriteriaWrapper
    ' Migration 
    ' Migration With FwCriterio
    ' Migration .Texto fwiIdCliente.Value, "IdCliente", strFiltro, intCuentaArg
    ' Migration .TextoDoble fwiDescCliente.Value, "DescCliente", strFiltro, intCuentaArg
    ' Migration .FechaMayorIgual fwiFechaDevolMayor.Value, "FechaDevolucion", strFiltro, intCuentaArg
    ' Migration .FechaMenorIgual fwiFechaDevolMenor.Value, "FechaDevolucion", strFiltro, intCuentaArg
    ' Migration .FechaMayorIgual fwiFechaVtoMayor.Value, "FechaVencimiento", strFiltro, intCuentaArg
    ' Migration .FechaMenorIgual fwiFechaVtoMenor.Value, "FechaVencimiento", strFiltro, intCuentaArg
    ' Migration .TextoMayorIgual fwiNFacturaMayor.Value, "NFactura", strFiltro, intCuentaArg
    ' Migration .TextoMenorIgual fwiNFacturaMenor.Value, "NFactura", strFiltro, intCuentaArg
    ' Migration .NumericoDecimalMayorIgual fwiGastoMayor.Value, "GastoA", strFiltro, intCuentaArg
    ' Migration .NumericoDecimalMenorIgual fwiGastoMenor.Value, "GastoA", strFiltro, intCuentaArg
    ' Migration .NumericoDecimalMayorIgual fwiComisionMayor.Value, "ComisionA", strFiltro, intCuentaArg
    ' Migration .NumericoDecimalMenorIgual fwiComisionMenor.Value, "ComisionA", strFiltro, intCuentaArg
    ' Migration .NumericoDecimalMayorIgual fwiARepercutirMayor.Value, "ARepercutirA", strFiltro, intCuentaArg
    ' Migration .NumericoDecimalMenorIgual fwiARepercutirMenor.Value, "ARepercutirA", strFiltro, intCuentaArg
    ' Migration .NumericoDecimalMayorIgual fwiImpVtoMayor.Value, "ImpVencimientoA", strFiltro, intCuentaArg
    ' Migration .NumericoDecimalMenorIgual fwiImpVtoMenor.Value, "ImpVencimientoA", strFiltro, intCuentaArg
    ' Migration End With
    ' Migration 
    ' Migration With Grid
    ' Migration .Filter = strFiltro
    ' Migration jsGrid.HoldFields
    ' Migration .Refresh
    ' Migration End With
    ' Migration 
    ' Migration 
    ' Migration fin:
    ' Migration On Error Resume Next
    ' Migration FwCriterio = Nothing
    ' Migration Exit Sub
    ' Migration TratarError:
    ' Migration GenerateError(err)
    ' Migration Resume fin
    ' Migration End Sub

    Protected Overridable Sub CIDevolucion_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        With e.Filter
            .Add("IdCliente", FilterOperator.Equal, fwiIdCliente.Text, FilterType.String)
            .Add("FechaDevolucion", FilterOperator.GreaterThanOrEqual, fwiFechaDevolMayor.Value, FilterType.DateTime)
            .Add("FechaDevolucion", FilterOperator.LessThanOrEqual, fwiFechaDevolMenor.Value, FilterType.DateTime)
            .Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, fwiFechaVtoMayor.Value, FilterType.DateTime)
            .Add("FechaVencimiento", FilterOperator.LessThanOrEqual, fwiFechaVtoMenor.Value, FilterType.DateTime)
            .Add("NFactura", FilterOperator.GreaterThanOrEqual, fwiNFacturaMayor.Value, FilterType.String)
            .Add("NFactura", FilterOperator.LessThanOrEqual, fwiNFacturaMenor.Value, FilterType.String)
            .Add("GastoA", FilterOperator.GreaterThanOrEqual, fwiGastoMayor.Text, FilterType.Numeric)
            .Add("GastoA", FilterOperator.LessThanOrEqual, fwiGastoMenor.Text, FilterType.Numeric)
            .Add("ComisionA", FilterOperator.GreaterThanOrEqual, fwiComisionMayor.Text, FilterType.Numeric)
            .Add("ComisionA", FilterOperator.LessThanOrEqual, fwiComisionMenor.Text, FilterType.Numeric)
            .Add("ARepercutirA", FilterOperator.GreaterThanOrEqual, fwiARepercutirMayor.Text, FilterType.Numeric)
            .Add("ARepercutirA", FilterOperator.LessThanOrEqual, fwiARepercutirMenor.Text, FilterType.Numeric)
            .Add("ImpVencimientoA", FilterOperator.GreaterThanOrEqual, fwiImpVtoMayor.Text, FilterType.Numeric)
            .Add("ImpVencimientoA", FilterOperator.LessThanOrEqual, fwiImpVtoMenor.Text, FilterType.Numeric)
        End With
    End Sub

    Protected Overridable Sub CIDevolucion_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        fwiIdCliente.Text = String.Empty
        fwiIdCliente.Value = String.Empty
        lblcfwiDescCliente.Text = String.Empty
        fwiFechaDevolMayor.Value = String.Empty
        'fwiFechaDevolMayor.Text = vbNullString
        'fwiFechaDevolMenor.Text = vbNullString
        fwiFechaDevolMenor.Value = String.Empty
        'fwiFechaVtoMayor.Text = vbNullString
        fwiFechaVtoMayor.Value = String.Empty
        'fwiFechaVtoMenor.Text = vbNullString
        fwiFechaVtoMenor.Value = String.Empty
        fwiNFacturaMayor.Text = String.Empty
        fwiNFacturaMayor.Value = String.Empty
        fwiNFacturaMenor.Text = String.Empty
        fwiNFacturaMenor.Value = String.Empty
        fwiGastoMayor.Text = String.Empty
        fwiGastoMenor.Text = String.Empty
        fwiComisionMayor.Text = String.Empty
        fwiComisionMenor.Text = String.Empty
        fwiARepercutirMayor.Text = String.Empty
        fwiARepercutirMenor.Text = String.Empty
        fwiImpVtoMayor.Text = String.Empty
        fwiImpVtoMenor.Text = String.Empty
    End Sub

    Protected Overridable Sub CIDevolucion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadGridActions()
        End If
    End Sub

    Protected Overridable Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente)
    End Sub

    Protected Overridable Sub AccionAbrirCliente()
        If ExpertisApp.IsFormOpen("MCLIENTE") Then ExpertisApp.CloseForm("MCLIENTE")
        ExpertisApp.OpenForm("MCLIENTE", New FilterItem("IDCliente", FilterOperator.Equal, Me.Grid.GetValue("IDCliente")))
    End Sub

End Class