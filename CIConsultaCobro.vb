Public Class CIConsultaCobro
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
    Protected WithEvents lblfwiFechaPagoHasta As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblfwiBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblfwiImpHasta As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblfwiFechaVtoHasta As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblfwiImpDesde As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblfwiFechaVtoDesde As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblfwiFormaPago As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblfwiFacturaDesde As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblfwiFacturaHasta As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblfwiSituacion As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblfwiIDCliente As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblfwiFechaCobroDesde As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents FrmTotalImpVtoA As Solmicro.Expertis.Engine.UI.Frame
    Protected WithEvents NtbTotalImpVtoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Protected WithEvents LblTotalImpVtoA As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents ClbFechaCobroHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Protected WithEvents ClbFechaCobroDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Protected WithEvents CmbBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Protected WithEvents NtbImpHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Protected WithEvents ClbFechaVtoHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Protected WithEvents NtbImpDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Protected WithEvents ClbFechaVtoDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Protected WithEvents CmbFormaPago As Solmicro.Expertis.Engine.UI.ComboBox
    Protected WithEvents CmbSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Protected WithEvents AdvCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents AdvFacturaDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents CmbEmpresas As Solmicro.Expertis.Engine.UI.ComboBox
    Protected WithEvents LblEmpresa As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents ChkMultiEmpresa As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents AdvFacturaHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbFormaPago_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbEmpresas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIConsultaCobro))
        Me.ClbFechaCobroHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaPagoHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbFechaCobroDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaCobroDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbImpHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbFechaVtoHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaVtoHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbImpDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbFechaVtoDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaVtoDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbFormaPago = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFacturaDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiFacturaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFacturaHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiFacturaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIDCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.FrmTotalImpVtoA = New Solmicro.Expertis.Engine.UI.Frame
        Me.LblTotalImpVtoA = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbTotalImpVtoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.ChkMultiEmpresa = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.CmbEmpresas = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblEmpresa = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.CmbBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmTotalImpVtoA.SuspendLayout()
        CType(Me.CmbEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.CmbEmpresas)
        Me.FilterPanel.Controls.Add(Me.LblEmpresa)
        Me.FilterPanel.Controls.Add(Me.ChkMultiEmpresa)
        Me.FilterPanel.Controls.Add(Me.lblfwiFechaPagoHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiFechaCobroDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiBancoPropio)
        Me.FilterPanel.Controls.Add(Me.lblfwiImpHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiFechaVtoHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiImpDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiFechaVtoDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiFormaPago)
        Me.FilterPanel.Controls.Add(Me.lblfwiFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiSituacion)
        Me.FilterPanel.Controls.Add(Me.lblfwiIDCliente)
        Me.FilterPanel.Controls.Add(Me.ClbFechaCobroHasta)
        Me.FilterPanel.Controls.Add(Me.ClbFechaCobroDesde)
        Me.FilterPanel.Controls.Add(Me.CmbBancoPropio)
        Me.FilterPanel.Controls.Add(Me.NtbImpHasta)
        Me.FilterPanel.Controls.Add(Me.ClbFechaVtoHasta)
        Me.FilterPanel.Controls.Add(Me.NtbImpDesde)
        Me.FilterPanel.Controls.Add(Me.ClbFechaVtoDesde)
        Me.FilterPanel.Controls.Add(Me.CmbFormaPago)
        Me.FilterPanel.Controls.Add(Me.AdvFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.AdvFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.CmbSituacion)
        Me.FilterPanel.Controls.Add(Me.AdvCliente)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 301)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 120)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.FrmTotalImpVtoA)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 301)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.FrmTotalImpVtoA, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "Cobro"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDCobro"
        Me.Grid.Size = New System.Drawing.Size(688, 259)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vctlCICobroContConsultaCobro"
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
        'ClbFechaCobroHasta
        '
        Me.ClbFechaCobroHasta.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaCobroHasta.Location = New System.Drawing.Point(207, 44)
        Me.ClbFechaCobroHasta.Name = "ClbFechaCobroHasta"
        Me.ClbFechaCobroHasta.Size = New System.Drawing.Size(84, 21)
        Me.ClbFechaCobroHasta.TabIndex = 3
        '
        'lblfwiFechaPagoHasta
        '
        Me.lblfwiFechaPagoHasta.Location = New System.Drawing.Point(185, 48)
        Me.lblfwiFechaPagoHasta.Name = "lblfwiFechaPagoHasta"
        Me.lblfwiFechaPagoHasta.Size = New System.Drawing.Size(16, 13)
        Me.lblfwiFechaPagoHasta.TabIndex = 16
        Me.lblfwiFechaPagoHasta.Tag = "IdRec=4817;"
        Me.lblfwiFechaPagoHasta.Text = "<"
        Me.lblfwiFechaPagoHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClbFechaCobroDesde
        '
        Me.ClbFechaCobroDesde.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaCobroDesde.Location = New System.Drawing.Point(95, 44)
        Me.ClbFechaCobroDesde.Name = "ClbFechaCobroDesde"
        Me.ClbFechaCobroDesde.Size = New System.Drawing.Size(84, 21)
        Me.ClbFechaCobroDesde.TabIndex = 2
        '
        'lblfwiFechaCobroDesde
        '
        Me.lblfwiFechaCobroDesde.Location = New System.Drawing.Point(10, 48)
        Me.lblfwiFechaCobroDesde.Name = "lblfwiFechaCobroDesde"
        Me.lblfwiFechaCobroDesde.Size = New System.Drawing.Size(72, 13)
        Me.lblfwiFechaCobroDesde.TabIndex = 17
        Me.lblfwiFechaCobroDesde.Tag = "IdRec=5654;"
        Me.lblfwiFechaCobroDesde.Text = "F.Cobro >="
        Me.lblfwiFechaCobroDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbBancoPropio
        '
        CmbBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("CmbBancoPropio_DesignTimeLayout.LayoutString")
        Me.CmbBancoPropio.DesignTimeLayout = CmbBancoPropio_DesignTimeLayout
        Me.CmbBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.CmbBancoPropio.DisplayMember = "IDBancoPropio"
        Me.CmbBancoPropio.EntityName = "BancoPropio"
        Me.CmbBancoPropio.Location = New System.Drawing.Point(405, 92)
        Me.CmbBancoPropio.Name = "CmbBancoPropio"
        Me.CmbBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.CmbBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.CmbBancoPropio.SelectedIndex = -1
        Me.CmbBancoPropio.SelectedItem = Nothing
        Me.CmbBancoPropio.Size = New System.Drawing.Size(97, 21)
        Me.CmbBancoPropio.TabIndex = 11
        Me.CmbBancoPropio.ValueMember = "IDBancoPropio"
        Me.CmbBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'lblfwiBancoPropio
        '
        Me.lblfwiBancoPropio.Location = New System.Drawing.Point(317, 96)
        Me.lblfwiBancoPropio.Name = "lblfwiBancoPropio"
        Me.lblfwiBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblfwiBancoPropio.TabIndex = 18
        Me.lblfwiBancoPropio.Tag = "IdRec=4602;"
        Me.lblfwiBancoPropio.Text = "Banco Propio"
        Me.lblfwiBancoPropio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbImpHasta
        '
        Me.NtbImpHasta.DisabledBackColor = System.Drawing.Color.White
        Me.NtbImpHasta.Location = New System.Drawing.Point(207, 92)
        Me.NtbImpHasta.Name = "NtbImpHasta"
        Me.NtbImpHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.NtbImpHasta.Size = New System.Drawing.Size(84, 21)
        Me.NtbImpHasta.TabIndex = 7
        '
        'lblfwiImpHasta
        '
        Me.lblfwiImpHasta.Location = New System.Drawing.Point(185, 96)
        Me.lblfwiImpHasta.Name = "lblfwiImpHasta"
        Me.lblfwiImpHasta.Size = New System.Drawing.Size(16, 13)
        Me.lblfwiImpHasta.TabIndex = 19
        Me.lblfwiImpHasta.Tag = "IdRec=4817;"
        Me.lblfwiImpHasta.Text = "<"
        Me.lblfwiImpHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClbFechaVtoHasta
        '
        Me.ClbFechaVtoHasta.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaVtoHasta.Location = New System.Drawing.Point(207, 20)
        Me.ClbFechaVtoHasta.Name = "ClbFechaVtoHasta"
        Me.ClbFechaVtoHasta.Size = New System.Drawing.Size(84, 21)
        Me.ClbFechaVtoHasta.TabIndex = 1
        '
        'lblfwiFechaVtoHasta
        '
        Me.lblfwiFechaVtoHasta.Location = New System.Drawing.Point(185, 25)
        Me.lblfwiFechaVtoHasta.Name = "lblfwiFechaVtoHasta"
        Me.lblfwiFechaVtoHasta.Size = New System.Drawing.Size(16, 13)
        Me.lblfwiFechaVtoHasta.TabIndex = 20
        Me.lblfwiFechaVtoHasta.Tag = "IdRec=4817;"
        Me.lblfwiFechaVtoHasta.Text = "<"
        Me.lblfwiFechaVtoHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbImpDesde
        '
        Me.NtbImpDesde.DisabledBackColor = System.Drawing.Color.White
        Me.NtbImpDesde.Location = New System.Drawing.Point(95, 92)
        Me.NtbImpDesde.Name = "NtbImpDesde"
        Me.NtbImpDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.NtbImpDesde.Size = New System.Drawing.Size(84, 21)
        Me.NtbImpDesde.TabIndex = 6
        '
        'lblfwiImpDesde
        '
        Me.lblfwiImpDesde.Location = New System.Drawing.Point(10, 96)
        Me.lblfwiImpDesde.Name = "lblfwiImpDesde"
        Me.lblfwiImpDesde.Size = New System.Drawing.Size(79, 13)
        Me.lblfwiImpDesde.TabIndex = 21
        Me.lblfwiImpDesde.Tag = "IdRec=5655;"
        Me.lblfwiImpDesde.Text = "Imp. Vto >="
        Me.lblfwiImpDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClbFechaVtoDesde
        '
        Me.ClbFechaVtoDesde.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaVtoDesde.Location = New System.Drawing.Point(95, 20)
        Me.ClbFechaVtoDesde.Name = "ClbFechaVtoDesde"
        Me.ClbFechaVtoDesde.Size = New System.Drawing.Size(84, 21)
        Me.ClbFechaVtoDesde.TabIndex = 0
        '
        'lblfwiFechaVtoDesde
        '
        Me.lblfwiFechaVtoDesde.Location = New System.Drawing.Point(10, 25)
        Me.lblfwiFechaVtoDesde.Name = "lblfwiFechaVtoDesde"
        Me.lblfwiFechaVtoDesde.Size = New System.Drawing.Size(60, 13)
        Me.lblfwiFechaVtoDesde.TabIndex = 22
        Me.lblfwiFechaVtoDesde.Tag = "IdRec=5656;"
        Me.lblfwiFechaVtoDesde.Text = "F. Vto >="
        Me.lblfwiFechaVtoDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbFormaPago
        '
        CmbFormaPago_DesignTimeLayout.LayoutString = resources.GetString("CmbFormaPago_DesignTimeLayout.LayoutString")
        Me.CmbFormaPago.DesignTimeLayout = CmbFormaPago_DesignTimeLayout
        Me.CmbFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.CmbFormaPago.DisplayMember = "IDFormaPago"
        Me.CmbFormaPago.EntityName = "FormaPago"
        Me.CmbFormaPago.Location = New System.Drawing.Point(405, 68)
        Me.CmbFormaPago.Name = "CmbFormaPago"
        Me.CmbFormaPago.PrimaryDataFields = "IDFormaPago"
        Me.CmbFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.CmbFormaPago.SelectedIndex = -1
        Me.CmbFormaPago.SelectedItem = Nothing
        Me.CmbFormaPago.Size = New System.Drawing.Size(97, 21)
        Me.CmbFormaPago.TabIndex = 10
        Me.CmbFormaPago.ValueMember = "IDFormaPago"
        Me.CmbFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'lblfwiFormaPago
        '
        Me.lblfwiFormaPago.Location = New System.Drawing.Point(317, 72)
        Me.lblfwiFormaPago.Name = "lblfwiFormaPago"
        Me.lblfwiFormaPago.Size = New System.Drawing.Size(75, 13)
        Me.lblfwiFormaPago.TabIndex = 23
        Me.lblfwiFormaPago.Tag = "IdRec=4758;"
        Me.lblfwiFormaPago.Text = "Forma Pago"
        Me.lblfwiFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvFacturaDesde
        '
        Me.AdvFacturaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFacturaDesde.EntityName = "FacturaVentaCabecera"
        Me.AdvFacturaDesde.Location = New System.Drawing.Point(95, 67)
        Me.AdvFacturaDesde.Name = "AdvFacturaDesde"
        Me.AdvFacturaDesde.SecondaryDataFields = "NFactura"
        Me.AdvFacturaDesde.Size = New System.Drawing.Size(84, 23)
        Me.AdvFacturaDesde.TabIndex = 4
        '
        'lblfwiFacturaDesde
        '
        Me.lblfwiFacturaDesde.Location = New System.Drawing.Point(10, 72)
        Me.lblfwiFacturaDesde.Name = "lblfwiFacturaDesde"
        Me.lblfwiFacturaDesde.Size = New System.Drawing.Size(70, 13)
        Me.lblfwiFacturaDesde.TabIndex = 24
        Me.lblfwiFacturaDesde.Tag = "IdRec=4776;"
        Me.lblfwiFacturaDesde.Text = "Factura >="
        Me.lblfwiFacturaDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvFacturaHasta
        '
        Me.AdvFacturaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFacturaHasta.EntityName = "FacturaVentaCabecera"
        Me.AdvFacturaHasta.Location = New System.Drawing.Point(207, 67)
        Me.AdvFacturaHasta.Name = "AdvFacturaHasta"
        Me.AdvFacturaHasta.SecondaryDataFields = "NFactura"
        Me.AdvFacturaHasta.Size = New System.Drawing.Size(84, 23)
        Me.AdvFacturaHasta.TabIndex = 5
        '
        'lblfwiFacturaHasta
        '
        Me.lblfwiFacturaHasta.Location = New System.Drawing.Point(185, 72)
        Me.lblfwiFacturaHasta.Name = "lblfwiFacturaHasta"
        Me.lblfwiFacturaHasta.Size = New System.Drawing.Size(16, 13)
        Me.lblfwiFacturaHasta.TabIndex = 26
        Me.lblfwiFacturaHasta.Tag = "IdRec=4817;"
        Me.lblfwiFacturaHasta.Text = "<"
        Me.lblfwiFacturaHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbSituacion
        '
        CmbSituacion_DesignTimeLayout.LayoutString = resources.GetString("CmbSituacion_DesignTimeLayout.LayoutString")
        Me.CmbSituacion.DesignTimeLayout = CmbSituacion_DesignTimeLayout
        Me.CmbSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.CmbSituacion.DisplayMember = "IDEstado"
        Me.CmbSituacion.EntityName = "EstadoCobro"
        Me.CmbSituacion.Location = New System.Drawing.Point(405, 44)
        Me.CmbSituacion.Name = "CmbSituacion"
        Me.CmbSituacion.PrimaryDataFields = "IDEstado"
        Me.CmbSituacion.SecondaryDataFields = "IDEstado"
        Me.CmbSituacion.SelectedIndex = -1
        Me.CmbSituacion.SelectedItem = Nothing
        Me.CmbSituacion.Size = New System.Drawing.Size(97, 21)
        Me.CmbSituacion.TabIndex = 9
        Me.CmbSituacion.ValueMember = "IDEstado"
        Me.CmbSituacion.ViewName = "tbMaestroEstadoCobro"
        '
        'lblfwiSituacion
        '
        Me.lblfwiSituacion.Location = New System.Drawing.Point(317, 48)
        Me.lblfwiSituacion.Name = "lblfwiSituacion"
        Me.lblfwiSituacion.Size = New System.Drawing.Size(59, 13)
        Me.lblfwiSituacion.TabIndex = 28
        Me.lblfwiSituacion.Tag = "IdRec=5653;"
        Me.lblfwiSituacion.Text = "Situacion"
        Me.lblfwiSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvCliente
        '
        Me.AdvCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvCliente.EntityName = "Cliente"
        Me.AdvCliente.Location = New System.Drawing.Point(405, 20)
        Me.AdvCliente.Name = "AdvCliente"
        Me.AdvCliente.SecondaryDataFields = "IDCliente"
        Me.AdvCliente.Size = New System.Drawing.Size(97, 23)
        Me.AdvCliente.TabIndex = 8
        '
        'lblfwiIDCliente
        '
        Me.lblfwiIDCliente.Location = New System.Drawing.Point(317, 25)
        Me.lblfwiIDCliente.Name = "lblfwiIDCliente"
        Me.lblfwiIDCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblfwiIDCliente.TabIndex = 30
        Me.lblfwiIDCliente.Tag = "IdRec=4365;"
        Me.lblfwiIDCliente.Text = "Cliente"
        Me.lblfwiIDCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmTotalImpVtoA
        '
        Me.FrmTotalImpVtoA.Controls.Add(Me.LblTotalImpVtoA)
        Me.FrmTotalImpVtoA.Controls.Add(Me.NtbTotalImpVtoA)
        Me.FrmTotalImpVtoA.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FrmTotalImpVtoA.Location = New System.Drawing.Point(0, 259)
        Me.FrmTotalImpVtoA.Name = "FrmTotalImpVtoA"
        Me.FrmTotalImpVtoA.Size = New System.Drawing.Size(688, 42)
        Me.FrmTotalImpVtoA.TabIndex = 32
        Me.FrmTotalImpVtoA.TabStop = False
        '
        'LblTotalImpVtoA
        '
        Me.LblTotalImpVtoA.Location = New System.Drawing.Point(437, 18)
        Me.LblTotalImpVtoA.Name = "LblTotalImpVtoA"
        Me.LblTotalImpVtoA.Size = New System.Drawing.Size(123, 13)
        Me.LblTotalImpVtoA.TabIndex = 17
        Me.LblTotalImpVtoA.Text = "Total Importe Vto. A"
        Me.LblTotalImpVtoA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbTotalImpVtoA
        '
        Me.NtbTotalImpVtoA.DisabledBackColor = System.Drawing.Color.White
        Me.NtbTotalImpVtoA.Enabled = False
        Me.NtbTotalImpVtoA.Location = New System.Drawing.Point(566, 14)
        Me.NtbTotalImpVtoA.Name = "NtbTotalImpVtoA"
        Me.NtbTotalImpVtoA.Size = New System.Drawing.Size(114, 21)
        Me.NtbTotalImpVtoA.TabIndex = 16
        '
        'ChkMultiEmpresa
        '
        Me.ChkMultiEmpresa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkMultiEmpresa.Location = New System.Drawing.Point(519, 15)
        Me.ChkMultiEmpresa.Name = "ChkMultiEmpresa"
        Me.ChkMultiEmpresa.Size = New System.Drawing.Size(159, 23)
        Me.ChkMultiEmpresa.TabIndex = 31
        Me.ChkMultiEmpresa.Text = "Multi-Empresa"
        '
        'CmbEmpresas
        '
        CmbEmpresas_DesignTimeLayout.LayoutString = resources.GetString("CmbEmpresas_DesignTimeLayout.LayoutString")
        Me.CmbEmpresas.DesignTimeLayout = CmbEmpresas_DesignTimeLayout
        Me.CmbEmpresas.DisabledBackColor = System.Drawing.Color.White
        Me.CmbEmpresas.DisplayMember = "DescBaseDatos"
        Me.CmbEmpresas.Location = New System.Drawing.Point(579, 44)
        Me.CmbEmpresas.Name = "CmbEmpresas"
        Me.CmbEmpresas.SelectedIndex = -1
        Me.CmbEmpresas.SelectedItem = Nothing
        Me.CmbEmpresas.Size = New System.Drawing.Size(99, 21)
        Me.CmbEmpresas.TabIndex = 35
        Me.CmbEmpresas.ValueMember = "IDBaseDatos"
        Me.CmbEmpresas.Visible = False
        '
        'LblEmpresa
        '
        Me.LblEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblEmpresa.Location = New System.Drawing.Point(516, 48)
        Me.LblEmpresa.Name = "LblEmpresa"
        Me.LblEmpresa.Size = New System.Drawing.Size(57, 13)
        Me.LblEmpresa.TabIndex = 36
        Me.LblEmpresa.Text = "Empresa"
        Me.LblEmpresa.Visible = False
        '
        'CIConsultaCobro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "Cobro"
        Me.KeyField = "IDCobro"
        Me.Name = "CIConsultaCobro"
        Me.ViewName = "vctlCICobroContConsultaCobro"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.CmbBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmTotalImpVtoA.ResumeLayout(False)
        Me.FrmTotalImpVtoA.PerformLayout()
        CType(Me.CmbEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected mMonedaA As MonedaInfo
    Protected Const cnVerCliente As String = "Ver Cliente"
    Protected Const cnVerFacturaVenta As String = "Ver Factura Venta"
    Protected Const cnALIAS_MNTO_CLIENTE As String = "MCLIENTE"
    Protected Const cnALIAS_MNTO_FACTURA_VENTA As String = "MFACTV"

#Region "Funciones Privadas"

    Protected Overridable Sub LoadGridActions()
        Me.Grid.Actions.Add(cnVerCliente, AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
        Me.Grid.Actions.Add(cnVerFacturaVenta, AddressOf AccionAbrirFactura, ExpertisApp.GetIcon("xFacturaVenta.ico"))
    End Sub

    Protected Overridable Sub AccionAbrirCliente()
        If ExpertisApp.IsFormOpen(cnALIAS_MNTO_CLIENTE) Then ExpertisApp.CloseForm(cnALIAS_MNTO_CLIENTE)
        ExpertisApp.OpenForm(cnALIAS_MNTO_CLIENTE, New FilterItem("IDCliente", FilterOperator.Equal, Me.Grid.GetValue("IDCliente")))
    End Sub

    Protected Overridable Sub AccionAbrirFactura()
        If ExpertisApp.IsFormOpen(cnALIAS_MNTO_FACTURA_VENTA) Then ExpertisApp.CloseForm(cnALIAS_MNTO_FACTURA_VENTA)
        ExpertisApp.OpenForm(cnALIAS_MNTO_FACTURA_VENTA, New FilterItem("IDFactura", FilterOperator.Equal, Me.Grid.GetValue("IDFactura")))
    End Sub

    Protected Overridable Sub LoadEmpresas()
        Me.CmbEmpresas.DataSource = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Comunes.GetUserDataBases, Nothing)
    End Sub

    Protected Overridable Sub LoadInitFilterCriteria()
        Me.NtbImpDesde.Value = Nothing
        Me.NtbImpHasta.Value = Nothing
    End Sub

    Protected Overridable Sub LoadParams()
        mMonedaA = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate)
        If Not Me.Params Is Nothing Then
            Dim HtParams As Hashtable = Me.Params
            If HtParams.ContainsKey("IDCliente") Then
                AdvCliente.Value = HtParams("IDCliente")
                AdvCliente.Text = HtParams("IDCliente")
                Me.Execute()
            End If
        End If
    End Sub

    Protected Overridable Sub AplicarFiltros(ByRef e As Engine.UI.QueryExecutingEventArgs)
        e.Filter.Add("IDCliente", FilterOperator.Equal, AdvCliente.Text, FilterType.String)
        e.Filter.Add("NFactura", FilterOperator.GreaterThanOrEqual, AdvFacturaDesde.Text, FilterType.String)
        e.Filter.Add("NFactura", FilterOperator.LessThanOrEqual, AdvFacturaHasta.Text, FilterType.String)
        e.Filter.Add("ImpVencimientoA", FilterOperator.GreaterThanOrEqual, NtbImpDesde.Text, FilterType.Numeric)
        e.Filter.Add("ImpVencimientoA", FilterOperator.LessThanOrEqual, NtbImpHasta.Text, FilterType.Numeric)
        e.Filter.Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, ClbFechaVtoDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaVencimiento", FilterOperator.LessThanOrEqual, ClbFechaVtoHasta.Value, FilterType.DateTime)
        e.Filter.Add("FechaCobro", FilterOperator.GreaterThanOrEqual, ClbFechaCobroDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaCobro", FilterOperator.LessThanOrEqual, ClbFechaCobroHasta.Value, FilterType.DateTime)
        e.Filter.Add("IDFormaPago", FilterOperator.Equal, CmbFormaPago.Text, FilterType.String)
        e.Filter.Add("IDBancoPropio", FilterOperator.Equal, CmbBancoPropio.Text, FilterType.String)
        e.Filter.Add("Situacion", FilterOperator.Equal, CmbSituacion.Value, FilterType.Numeric)
    End Sub

    Protected Overridable Sub CalcularTotales()
        NtbTotalImpVtoA.Value = xRound(Grid.GetTotal(Grid.Columns("ImpVencimientoA"), Janus.Windows.GridEX.AggregateFunction.Sum), mMonedaA.NDecimalesImporte)
    End Sub

#End Region

#Region "Eventos CIConsultaCobro"

#Region "Eventos Formulario"

    Protected Overridable Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadGridActions()
            LoadEmpresas()
            LoadInitFilterCriteria()
            LoadParams()
        End If
    End Sub

    Protected Overridable Sub CIConsultaCobro_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        AplicarFiltros(e)
        If Me.ChkMultiEmpresa.Checked Then
            Dim fEmpresasOrigen As New Filter
            If Length(Me.CmbEmpresas.Value) > 0 Then fEmpresasOrigen.Add(New GuidFilterItem("IDBaseDatos", Me.CmbEmpresas.Value))

            Dim data As New BEGetQueryMultipleDB.DataGetQueryMultipleDB(Me.ViewName, e.Filter.InnerFilter, fEmpresasOrigen, Me.ChkMultiEmpresa.Checked)
            Dim QueryMultipleDB As New GetQueryMultipleDB
            Dim DtGrid As DataTable = QueryMultipleDB.Execute(data)

            If Me.Grid.RootTable.Groups.Count = 0 Then
                Me.Grid.Columns("Empresa").Visible = True
                Me.Grid.RootTable.Groups.Clear()
                Dim GrpEmpresa As New Janus.Windows.GridEX.GridEXGroup
                GrpEmpresa.Column = Me.Grid.Columns("Empresa")
                GrpEmpresa.GroupPrefix = "Empresa:"
                GrpEmpresa.HeaderCaption = "Empresa"
                GrpEmpresa.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending
                Me.Grid.RootTable.Groups.Add(GrpEmpresa)
            End If

            Me.BindEditEvents(DtGrid)
            Me.Grid.DataSource = DtGrid
            e.Cancel = True
        Else
            If Me.Grid.RootTable.Groups.Count > 0 Then Me.Grid.RootTable.Groups.Clear()
            Me.Grid.Columns("Empresa").Visible = False
        End If
    End Sub

    Protected Overridable Sub CIPagoCont_QueryExecuted(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        CalcularTotales()
    End Sub

    Protected Overridable Sub CIConsultaCobro_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        LoadInitFilterCriteria()
    End Sub

#End Region

#Region "Eventos Controles"

    Private Sub Grid_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Length(Me.Grid.GetValue("IDFactura")) = 0 Then
                Me.Grid.UiCommandManager1.Commands(cnVerFacturaVenta).Visible = Janus.Windows.UI.InheritableBoolean.False
            Else
                Me.Grid.UiCommandManager1.Commands(cnVerFacturaVenta).Visible = Janus.Windows.UI.InheritableBoolean.True
            End If
        End If
    End Sub

    Protected Overridable Sub NtbImpDesde_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NtbImpDesde.Validated
        NtbImpHasta.Value = NtbImpDesde.Value
    End Sub

    Protected Overridable Sub ClbFechaVtoDesde_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClbFechaVtoDesde.Validated
        ClbFechaVtoHasta.Value = ClbFechaVtoDesde.Value
    End Sub

    Protected Overridable Sub ClbFechaCobroDesde_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClbFechaCobroDesde.Validated
        ClbFechaCobroHasta.Value = ClbFechaCobroDesde.Value
    End Sub

    Protected Overridable Sub AdvFacturaDesde_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvFacturaDesde.Validated
        AdvFacturaHasta.Text = AdvFacturaDesde.Text
    End Sub

    Protected Overridable Sub ChkMultiEmpresa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkMultiEmpresa.CheckedChanged
        Me.LblEmpresa.Visible = Me.ChkMultiEmpresa.Checked
        Me.CmbEmpresas.Visible = Me.ChkMultiEmpresa.Checked
        If Not Me.ChkMultiEmpresa.Checked Then
            Me.CmbEmpresas.Text = String.Empty
            Me.CmbEmpresas.Value = String.Empty
        End If
    End Sub

#End Region

#End Region

End Class