Public Class CIRiesgoBanco
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
    Friend WithEvents cboTipoRemesa As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents advRemesa As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cboBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lbladvIDCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcbxFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcbxFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lbladvRemesa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcboBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcboTipoRemesa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FraTotalRiesgo As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents nbxTotalRiesgo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblcboTipoRiesgo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboTipoRiesgo As Solmicro.Expertis.Engine.UI.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout4 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.advIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbladvIDCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblcbxFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblcbxFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.advRemesa = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbladvRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.cboBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblcboBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.cboTipoRemesa = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblcboTipoRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.FraTotalRiesgo = New Solmicro.Expertis.Engine.UI.Frame
        Me.nbxTotalRiesgo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblcboTipoRiesgo = New Solmicro.Expertis.Engine.UI.Label
        Me.cboTipoRiesgo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraTotalRiesgo.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.cboTipoRiesgo)
        Me.FilterPanel.Controls.Add(Me.lblcboTipoRiesgo)
        Me.FilterPanel.Controls.Add(Me.lbladvIDCliente)
        Me.FilterPanel.Controls.Add(Me.lblcbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblcbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lbladvRemesa)
        Me.FilterPanel.Controls.Add(Me.lblcboBancoPropio)
        Me.FilterPanel.Controls.Add(Me.lblcboTipoRemesa)
        Me.FilterPanel.Controls.Add(Me.FraTotalRiesgo)
        Me.FilterPanel.Controls.Add(Me.advIDCliente)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.advRemesa)
        Me.FilterPanel.Controls.Add(Me.cboBancoPropio)
        Me.FilterPanel.Controls.Add(Me.cboTipoRemesa)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 321)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(688, 104)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Name = "CIMntoGridPanel"
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 321)
        '
        'Grid
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""DescBancoPro" & _
        "pio""><Caption>Banco Propio</Caption><DataMember>DescBancoPropio</DataMember><Key" & _
        ">DescBancoPropio</Key><Position>0</Position><TextAlignment>Near</TextAlignment><" & _
        "Width>120</Width></Column0><Column1 ID=""DescCliente""><Caption>Cliente</Caption><" & _
        "DataMember>DescCliente</DataMember><Key>DescCliente</Key><Position>1</Position><" & _
        "TextAlignment>Near</TextAlignment><Width>120</Width></Column1><Column2 ID=""ImpRi" & _
        "esgo""><Caption>Imp. Riesgo</Caption><DataMember>ImpRiesgo</DataMember><Key>ImpRi" & _
        "esgo</Key><Position>2</Position><TextAlignment>Far</TextAlignment><Width>80</Wid" & _
        "th></Column2><Column3 ID=""Abreviatura""><Caption>Abreviatura</Caption><DataMember" & _
        ">Abreviatura</DataMember><Key>Abreviatura</Key><Position>3</Position><TextAlignm" & _
        "ent>Near</TextAlignment><Width>27</Width></Column3><Column4 ID=""ImpRiesgoA""><Cap" & _
        "tion>Imp. Riesgo A</Caption><DataMember>ImpRiesgoA</DataMember><Key>ImpRiesgoA</" & _
        "Key><Position>4</Position><TextAlignment>Far</TextAlignment><Width>80</Width></C" & _
        "olumn4><Column5 ID=""FechaRemesa""><Caption>Fecha Remesa</Caption><DataMember>Fech" & _
        "aRemesa</DataMember><Key>FechaRemesa</Key><Position>5</Position><TextAlignment>N" & _
        "ear</TextAlignment><Width>80</Width></Column5><Column6 ID=""FechaVencimiento""><Ca" & _
        "ption>Fecha Vto.</Caption><DataMember>FechaVencimiento</DataMember><Key>FechaVen" & _
        "cimiento</Key><Position>6</Position><TextAlignment>Near</TextAlignment><Width>80" & _
        "</Width></Column6><Column7 ID=""IDTipoNegociacion""><Caption>Tipo Negociación</Cap" & _
        "tion><DataMember>IDTipoNegociacion</DataMember><Key>IDTipoNegociacion</Key><Posi" & _
        "tion>7</Position><TextAlignment>Near</TextAlignment><Width>80</Width></Column7><" & _
        "Column8 ID=""IDRemesa""><Caption>Remesa</Caption><DataMember>IDRemesa</DataMember>" & _
        "<Key>IDRemesa</Key><Position>8</Position><TextAlignment>Near</TextAlignment><Wid" & _
        "th>40</Width></Column8><Column9 ID=""IDBancoPropio""><Caption>IDBancoPropio</Capti" & _
        "on><DataMember>IDBancoPropio</DataMember><Key>IDBancoPropio</Key><Position>9</Po" & _
        "sition><TextAlignment>Near</TextAlignment><Visible>False</Visible></Column9><Col" & _
        "umn10 ID=""IDCliente""><Caption>IDCliente</Caption><DataMember>IDCliente</DataMemb" & _
        "er><Key>IDCliente</Key><Position>10</Position><TextAlignment>Near</TextAlignment" & _
        "><Visible>False</Visible></Column10><Column11 ID=""RiesgoFactoring""><Caption>Ries" & _
        "go Factoring</Caption><TypeNameFalseValue>System.Int32</TypeNameFalseValue><Chec" & _
        "kBoxFalseValue>0</CheckBoxFalseValue><TypeNameTrueValue>System.Int32</TypeNameTr" & _
        "ueValue><CheckBoxTrueValue>1</CheckBoxTrueValue><ColumnType>CheckBox</ColumnType" & _
        "><DataMember>RiesgoFactoring</DataMember><EditType>NoEdit</EditType><Key>RiesgoF" & _
        "actoring</Key><Position>11</Position><Width>110</Width></Column11></Columns><Gro" & _
        "upCondition ID="""" /><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColInde" & _
        "x>9</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.EntityName = "Cobro"
        Me.Grid.KeyField = "IDCobro"
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(688, 321)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vctlCICobroContRiesgoBanco"
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Name = "MainPanelCIMntoContainer"
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(688, 425)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 26)
        Me.Menubar.Name = "Menubar"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'Toolbar
        '
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(184, 26)
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'MainPanel
        '
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(688, 425)
        '
        'advIDCliente
        '
        Me.advIDCliente.EntityName = "Cliente"
        Me.advIDCliente.Location = New System.Drawing.Point(80, 19)
        Me.advIDCliente.Name = "advIDCliente"
        Me.advIDCliente.PrimaryDataFields = "IDCliente"
        Me.advIDCliente.SecondaryDataFields = "IDCliente"
        Me.advIDCliente.Size = New System.Drawing.Size(82, 23)
        Me.advIDCliente.TabIndex = 0
        Me.advIDCliente.ViewName = "tbMaestroCliente"
        '
        'lbladvIDCliente
        '
        Me.lbladvIDCliente.Location = New System.Drawing.Point(11, 19)
        Me.lbladvIDCliente.Name = "lbladvIDCliente"
        Me.lbladvIDCliente.Size = New System.Drawing.Size(43, 17)
        Me.lbladvIDCliente.TabIndex = 10
        Me.lbladvIDCliente.Tag = "IdRec=4365;"
        Me.lbladvIDCliente.Text = "Cliente"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.Location = New System.Drawing.Point(454, 20)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(77, 21)
        Me.cbxFechaDesde.TabIndex = 4
        '
        'lblcbxFechaDesde
        '
        Me.lblcbxFechaDesde.Location = New System.Drawing.Point(347, 20)
        Me.lblcbxFechaDesde.Name = "lblcbxFechaDesde"
        Me.lblcbxFechaDesde.Size = New System.Drawing.Size(97, 17)
        Me.lblcbxFechaDesde.TabIndex = 12
        Me.lblcbxFechaDesde.Tag = "IdRec=4777;"
        Me.lblcbxFechaDesde.Text = "Vencimiento >="
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.Location = New System.Drawing.Point(454, 46)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(77, 21)
        Me.cbxFechaHasta.TabIndex = 5
        '
        'lblcbxFechaHasta
        '
        Me.lblcbxFechaHasta.Location = New System.Drawing.Point(347, 46)
        Me.lblcbxFechaHasta.Name = "lblcbxFechaHasta"
        Me.lblcbxFechaHasta.Size = New System.Drawing.Size(97, 17)
        Me.lblcbxFechaHasta.TabIndex = 13
        Me.lblcbxFechaHasta.Tag = "IdRec=4779;"
        Me.lblcbxFechaHasta.Text = "Vencimiento <="
        '
        'advRemesa
        '
        Me.advRemesa.EntityName = "Remesa"
        Me.advRemesa.Location = New System.Drawing.Point(259, 20)
        Me.advRemesa.Name = "advRemesa"
        Me.advRemesa.PrimaryDataFields = "IDRemesa"
        Me.advRemesa.SecondaryDataFields = "IDRemesa"
        Me.advRemesa.Size = New System.Drawing.Size(80, 23)
        Me.advRemesa.TabIndex = 2
        Me.advRemesa.ViewName = "tbRemesa"
        '
        'lbladvRemesa
        '
        Me.lbladvRemesa.Location = New System.Drawing.Point(171, 20)
        Me.lbladvRemesa.Name = "lbladvRemesa"
        Me.lbladvRemesa.Size = New System.Drawing.Size(49, 17)
        Me.lbladvRemesa.TabIndex = 14
        Me.lbladvRemesa.Tag = "IdRec=4782;"
        Me.lbladvRemesa.Text = "Remesa"
        '
        'cboBancoPropio
        '
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDBancoPropi" & _
        "o""><Caption>Id. Banco Propio</Caption><DataMember>IDBancoPropio</DataMember><Key" & _
        ">IDBancoPropio</Key><Position>0</Position><Width>50</Width></Column0><Column1 ID" & _
        "=""DescBancoPropio""><Caption>Banco Propio</Caption><DataMember>DescBancoPropio</D" & _
        "ataMember><Key>DescBancoPropio</Key><Position>1</Position><Width>150</Width></Co" & _
        "lumn1></Columns><GroupCondition ID="""" /></RootTable><RowWithErrorsFormatStyle><P" & _
        "redefinedStyle>RowWithErrorsFormatStyle</PredefinedStyle></RowWithErrorsFormatSt" & _
        "yle><LinkFormatStyle><PredefinedStyle>LinkFormatStyle</PredefinedStyle></LinkFor" & _
        "matStyle><CardCaptionFormatStyle><PredefinedStyle>CardCaptionFormatStyle</Predef" & _
        "inedStyle></CardCaptionFormatStyle><GroupByBoxFormatStyle><PredefinedStyle>Group" & _
        "ByBoxFormatStyle</PredefinedStyle></GroupByBoxFormatStyle><GroupByBoxInfoFormatS" & _
        "tyle><PredefinedStyle>GroupByBoxInfoFormatStyle</PredefinedStyle></GroupByBoxInf" & _
        "oFormatStyle><GroupRowFormatStyle><PredefinedStyle>GroupRowFormatStyle</Predefin" & _
        "edStyle></GroupRowFormatStyle><HeaderFormatStyle><PredefinedStyle>HeaderFormatSt" & _
        "yle</PredefinedStyle></HeaderFormatStyle><PreviewRowFormatStyle><PredefinedStyle" & _
        ">PreviewRowFormatStyle</PredefinedStyle></PreviewRowFormatStyle><RowFormatStyle>" & _
        "<PredefinedStyle>RowFormatStyle</PredefinedStyle></RowFormatStyle><SelectedForma" & _
        "tStyle><PredefinedStyle>SelectedFormatStyle</PredefinedStyle></SelectedFormatSty" & _
        "le><SelectedInactiveFormatStyle><PredefinedStyle>SelectedInactiveFormatStyle</Pr" & _
        "edefinedStyle></SelectedInactiveFormatStyle><WatermarkImage /><BorderStyle>Flat<" & _
        "/BorderStyle><FlatBorderColor>125, 159, 190</FlatBorderColor><ControlStyle><Butt" & _
        "onAppearance>Flat</ButtonAppearance></ControlStyle><VisualStyle>Standard</Visual" & _
        "Style><AllowEdit>False</AllowEdit><ExpandableGroups>False</ExpandableGroups><Gro" & _
        "upByBoxVisible>False</GroupByBoxVisible><HideSelection>Highlight</HideSelection>" & _
        "</GridEXLayoutData>"
        Me.cboBancoPropio.DesignTimeLayout = GridEXLayout2
        Me.cboBancoPropio.EntityName = "BancoPropio"
        Me.cboBancoPropio.Location = New System.Drawing.Point(100, 46)
        Me.cboBancoPropio.Name = "cboBancoPropio"
        Me.cboBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.cboBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.cboBancoPropio.SelectedIndex = -1
        Me.cboBancoPropio.SelectedItem = Nothing
        Me.cboBancoPropio.Size = New System.Drawing.Size(61, 21)
        Me.cboBancoPropio.TabIndex = 1
        Me.cboBancoPropio.Value = Nothing
        Me.cboBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'lblcboBancoPropio
        '
        Me.lblcboBancoPropio.Location = New System.Drawing.Point(11, 46)
        Me.lblcboBancoPropio.Name = "lblcboBancoPropio"
        Me.lblcboBancoPropio.Size = New System.Drawing.Size(78, 17)
        Me.lblcboBancoPropio.TabIndex = 16
        Me.lblcboBancoPropio.Tag = "IdRec=4613;"
        Me.lblcboBancoPropio.Text = "Banco Propio"
        '
        'cboTipoRemesa
        '
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition ID="""" /></RootTable><RowWithErrorsFo" & _
        "rmatStyle><PredefinedStyle>RowWithErrorsFormatStyle</PredefinedStyle></RowWithEr" & _
        "rorsFormatStyle><LinkFormatStyle><PredefinedStyle>LinkFormatStyle</PredefinedSty" & _
        "le></LinkFormatStyle><CardCaptionFormatStyle><PredefinedStyle>CardCaptionFormatS" & _
        "tyle</PredefinedStyle></CardCaptionFormatStyle><GroupByBoxFormatStyle><Predefine" & _
        "dStyle>GroupByBoxFormatStyle</PredefinedStyle></GroupByBoxFormatStyle><GroupByBo" & _
        "xInfoFormatStyle><PredefinedStyle>GroupByBoxInfoFormatStyle</PredefinedStyle></G" & _
        "roupByBoxInfoFormatStyle><GroupRowFormatStyle><PredefinedStyle>GroupRowFormatSty" & _
        "le</PredefinedStyle></GroupRowFormatStyle><HeaderFormatStyle><PredefinedStyle>He" & _
        "aderFormatStyle</PredefinedStyle></HeaderFormatStyle><PreviewRowFormatStyle><Pre" & _
        "definedStyle>PreviewRowFormatStyle</PredefinedStyle></PreviewRowFormatStyle><Row" & _
        "FormatStyle><PredefinedStyle>RowFormatStyle</PredefinedStyle></RowFormatStyle><S" & _
        "electedFormatStyle><PredefinedStyle>SelectedFormatStyle</PredefinedStyle></Selec" & _
        "tedFormatStyle><SelectedInactiveFormatStyle><PredefinedStyle>SelectedInactiveFor" & _
        "matStyle</PredefinedStyle></SelectedInactiveFormatStyle><WatermarkImage /><Borde" & _
        "rStyle>Flat</BorderStyle><FlatBorderColor>125, 159, 190</FlatBorderColor><Contro" & _
        "lStyle><ButtonAppearance>Flat</ButtonAppearance></ControlStyle><VisualStyle>Stan" & _
        "dard</VisualStyle><AllowEdit>False</AllowEdit><ExpandableGroups>False</Expandabl" & _
        "eGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelection>Highlight</Hi" & _
        "deSelection></GridEXLayoutData>"
        Me.cboTipoRemesa.DesignTimeLayout = GridEXLayout3
        Me.cboTipoRemesa.Location = New System.Drawing.Point(259, 46)
        Me.cboTipoRemesa.Name = "cboTipoRemesa"
        Me.cboTipoRemesa.SelectedIndex = -1
        Me.cboTipoRemesa.SelectedItem = Nothing
        Me.cboTipoRemesa.Size = New System.Drawing.Size(79, 21)
        Me.cboTipoRemesa.TabIndex = 3
        Me.cboTipoRemesa.Value = Nothing
        '
        'lblcboTipoRemesa
        '
        Me.lblcboTipoRemesa.Location = New System.Drawing.Point(171, 46)
        Me.lblcboTipoRemesa.Name = "lblcboTipoRemesa"
        Me.lblcboTipoRemesa.Size = New System.Drawing.Size(77, 17)
        Me.lblcboTipoRemesa.TabIndex = 17
        Me.lblcboTipoRemesa.Text = "Tipo Remesa"
        '
        'FraTotalRiesgo
        '
        Me.FraTotalRiesgo.Controls.Add(Me.nbxTotalRiesgo)
        Me.FraTotalRiesgo.Location = New System.Drawing.Point(552, 0)
        Me.FraTotalRiesgo.Name = "FraTotalRiesgo"
        Me.FraTotalRiesgo.Size = New System.Drawing.Size(136, 104)
        Me.FraTotalRiesgo.TabIndex = 18
        Me.FraTotalRiesgo.TabStop = False
        Me.FraTotalRiesgo.Text = "Total Riesgo"
        '
        'nbxTotalRiesgo
        '
        Me.nbxTotalRiesgo.Enabled = False
        Me.nbxTotalRiesgo.Location = New System.Drawing.Point(8, 20)
        Me.nbxTotalRiesgo.Name = "nbxTotalRiesgo"
        Me.nbxTotalRiesgo.Size = New System.Drawing.Size(121, 21)
        Me.nbxTotalRiesgo.TabIndex = 10
        '
        'lblcboTipoRiesgo
        '
        Me.lblcboTipoRiesgo.Location = New System.Drawing.Point(11, 74)
        Me.lblcboTipoRiesgo.Name = "lblcboTipoRiesgo"
        Me.lblcboTipoRiesgo.Size = New System.Drawing.Size(70, 17)
        Me.lblcboTipoRiesgo.TabIndex = 19
        Me.lblcboTipoRiesgo.Text = "Tipo Riesgo"
        '
        'cboTipoRiesgo
        '
        GridEXLayout4.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition ID="""" /></RootTable><RowWithErrorsFo" & _
        "rmatStyle><PredefinedStyle>RowWithErrorsFormatStyle</PredefinedStyle></RowWithEr" & _
        "rorsFormatStyle><LinkFormatStyle><PredefinedStyle>LinkFormatStyle</PredefinedSty" & _
        "le></LinkFormatStyle><CardCaptionFormatStyle><PredefinedStyle>CardCaptionFormatS" & _
        "tyle</PredefinedStyle></CardCaptionFormatStyle><GroupByBoxFormatStyle><Predefine" & _
        "dStyle>GroupByBoxFormatStyle</PredefinedStyle></GroupByBoxFormatStyle><GroupByBo" & _
        "xInfoFormatStyle><PredefinedStyle>GroupByBoxInfoFormatStyle</PredefinedStyle></G" & _
        "roupByBoxInfoFormatStyle><GroupRowFormatStyle><PredefinedStyle>GroupRowFormatSty" & _
        "le</PredefinedStyle></GroupRowFormatStyle><HeaderFormatStyle><PredefinedStyle>He" & _
        "aderFormatStyle</PredefinedStyle></HeaderFormatStyle><PreviewRowFormatStyle><Pre" & _
        "definedStyle>PreviewRowFormatStyle</PredefinedStyle></PreviewRowFormatStyle><Row" & _
        "FormatStyle><PredefinedStyle>RowFormatStyle</PredefinedStyle></RowFormatStyle><S" & _
        "electedFormatStyle><PredefinedStyle>SelectedFormatStyle</PredefinedStyle></Selec" & _
        "tedFormatStyle><SelectedInactiveFormatStyle><PredefinedStyle>SelectedInactiveFor" & _
        "matStyle</PredefinedStyle></SelectedInactiveFormatStyle><WatermarkImage /><Borde" & _
        "rStyle>Flat</BorderStyle><FlatBorderColor>125, 159, 190</FlatBorderColor><Contro" & _
        "lStyle><ButtonAppearance>Flat</ButtonAppearance></ControlStyle><VisualStyle>Stan" & _
        "dard</VisualStyle><AllowEdit>False</AllowEdit><ExpandableGroups>False</Expandabl" & _
        "eGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelection>Highlight</Hi" & _
        "deSelection></GridEXLayoutData>"
        Me.cboTipoRiesgo.DesignTimeLayout = GridEXLayout4
        Me.cboTipoRiesgo.Location = New System.Drawing.Point(100, 74)
        Me.cboTipoRiesgo.Name = "cboTipoRiesgo"
        Me.cboTipoRiesgo.SelectedIndex = -1
        Me.cboTipoRiesgo.SelectedItem = Nothing
        Me.cboTipoRiesgo.Size = New System.Drawing.Size(120, 21)
        Me.cboTipoRiesgo.TabIndex = 20
        Me.cboTipoRiesgo.Value = Nothing
        '
        'CIRiesgoBanco
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "Cobro"
        Me.KeyField = "IDCobro"
        Me.Name = "CIRiesgoBanco"
        Me.ViewName = "vctlCICobroContRiesgoBanco"
        Me.FilterPanel.ResumeLayout(False)
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraTotalRiesgo.ResumeLayout(False)

    End Sub

#End Region

    Private mlngDecimalesImpA As Long

#Region " Carga del formulario "

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadERPData()
        LoadEnums()
        LoadGridActions()
    End Sub

    Private Sub LoadERPData()
        '//Moneda
        Dim objNegMoneda As New Moneda
        mlngDecimalesImpA = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate).NDecimalesImporte
    End Sub

    Private Sub LoadEnums()
        cboTipoRemesa.DataSource = New EnumData("enumTipoRemesa")
        cboTipoRemesa.Value = enumTipoRemesa.RemesaAlCobro
        EnumData.PopulateValueList("enumTipoRemesa", Grid.Columns("IDTipoNegociacion"))
        cboTipoRiesgo.DataSource = New EnumData("RiesgoFactoring")
        cboTipoRiesgo.Value = RiesgoFactoring.Todos
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Banco", AddressOf AccionAbrirBanco)
        Me.Grid.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente)
    End Sub

    Private Sub AccionAbrirBanco()
        If ExpertisApp.IsFormOpen("MNTOBANCP") Then ExpertisApp.CloseForm("MNTOBANCP")
        ExpertisApp.OpenForm("MNTOBANCP", New FilterItem("IDBancoPropio", FilterOperator.Equal, Me.Grid.GetValue("IDBancoPropio")))
    End Sub

    Private Sub AccionAbrirCliente()
        If ExpertisApp.IsFormOpen("MCLIENTE") Then ExpertisApp.CloseForm("MCLIENTE")
        ExpertisApp.OpenForm("MCLIENTE", New FilterItem("IDCliente", FilterOperator.Equal, Me.Grid.GetValue("IDCliente")))
    End Sub

#End Region

#Region " Consulta Interactiva y Cálculo de Totales "

    Private Sub CIRiesgoBanco_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        With e.Filter
            .Add("IDCliente", FilterOperator.Equal, advIDCliente.Text, FilterType.String)
            .Add("IDBancoPropio", FilterOperator.Equal, cboBancoPropio.Value, FilterType.String)

            .Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Text, FilterType.DateTime)
            .Add("FechaVencimiento", FilterOperator.LessThanOrEqual, cbxFechaHasta.Text, FilterType.DateTime)
            .Add("IDRemesa", FilterOperator.Equal, advRemesa.Text, FilterType.Numeric)
            .Add("IdTipoNegociacion", FilterOperator.Equal, cboTipoRemesa.Value, FilterType.Numeric)

            If cboTipoRiesgo.Value <> RiesgoFactoring.Todos Then
                .Add(New BooleanFilterItem("RiesgoFactoring", CBool(cboTipoRiesgo.Value)))
            End If
        End With
    End Sub

    Private Sub CIRiesgoBanco_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        cbxFechaDesde.Value = Nothing
        cbxFechaHasta.Value = Nothing
    End Sub

    Private Sub CIRiesgoBanco_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        cboTipoRiesgo.Value = RiesgoFactoring.Todos
    End Sub

    Private Sub CIRiesgoBanco_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        nbxTotalRiesgo.Value = xRound(Grid.GetTotal(Grid.Columns("ImpRiesgoA"), Janus.Windows.GridEX.AggregateFunction.Sum), mlngDecimalesImpA)
    End Sub

#End Region

    Private Sub cbxFechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFechaDesde.ValueChanged
        cbxFechaHasta.Value = cbxFechaDesde.Value
    End Sub
End Class
