Imports Janus.Windows.GridEX
Public Class CICobroCont
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
    Public WithEvents AdvIDContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaFacturaD As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFechaFacturaD As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaFacturaH As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFechaFacturaH As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxManual As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblManual As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblGrupo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxRiesgo As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblRiesgo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxEmpresa As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblBBDD As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDClienteCab As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblClienteCab As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxLiquidado As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblLiquidado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxEspecial As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblEspecial As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxIDTipoCobro As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxContabilizado As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblContabilizado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCContable As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiCContable As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtSaldoCContable As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiSaldoCContable As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvFacturaHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblFacturaHasta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvFacturaDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblFacturaDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxIDFormaPago As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblFormaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImporteDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImporteHasta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDRemesa As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblRemesa As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxIDBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxIDEjercicio As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblEjercicio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxDomiciliado As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblDomiciliado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxRemesable As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblRemesable As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblSituacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpDesde As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiImpHasta As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTitulo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiTitulo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents cbxEmpresaGrupo As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblFactoring As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFactoring As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblClteFactoring As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxClienteFactoring As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents PicTotal As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTotalMarcado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtTotalMarcado As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblremesaAnticipo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvRemesaAnticipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents lblEstadoAnticipo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cboEstadoAnticipo As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxFechaComunicacionGestorCobro As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFechaComunicacionGestorCobro As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblComunicadoGestorCobro As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxComunicadoGestorCobro As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblFrasAgrup As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtFrasAgrup As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents clbFechaCobroHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaCobroDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaCobro As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaPagMax As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents clbFechaPagare As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaPagare As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim cbxManual_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEmpresaGrupo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxRiesgo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEmpresa_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxLiquidado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEspecial_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDTipoCobro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxContabilizado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDFormaPago_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDEjercicio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxDomiciliado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxRemesable_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxFactoring_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxClienteFactoring_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboEstadoAnticipo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxComunicadoGestorCobro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CICobroCont))
        Me.AdvIDContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFacturaD = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFacturaD = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFacturaH = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFacturaH = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxManual = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblManual = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEmpresaGrupo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblGrupo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxRiesgo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblRiesgo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEmpresa = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblBBDD = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDClienteCab = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblClienteCab = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxLiquidado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblLiquidado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEspecial = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEspecial = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDTipoCobro = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxContabilizado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblContabilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCContable = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiCContable = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSaldoCContable = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiSaldoCContable = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFacturaHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFacturaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFacturaDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFacturaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDFormaPago = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImporteDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImporteHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDRemesa = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDEjercicio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEjercicio = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxDomiciliado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblDomiciliado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxRemesable = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblRemesable = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpDesde = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiImpHasta = New Solmicro.Expertis.Engine.UI.TextBox
        Me.PicTotal = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTotalMarcado = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtTotalMarcado = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiTitulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTitulo = New Solmicro.Expertis.Engine.UI.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.lblFactoring = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFactoring = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblClteFactoring = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxClienteFactoring = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblremesaAnticipo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvRemesaAnticipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblEstadoAnticipo = New Solmicro.Expertis.Engine.UI.Label
        Me.cboEstadoAnticipo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFechaComunicacionGestorCobro = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaComunicacionGestorCobro = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxComunicadoGestorCobro = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblComunicadoGestorCobro = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFrasAgrup = New Solmicro.Expertis.Engine.UI.Label
        Me.txtFrasAgrup = New Solmicro.Expertis.Engine.UI.TextBox
        Me.clbFechaCobroDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaCobro = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaCobroHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaPagare = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaPagare = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaPagMax = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEmpresaGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxRiesgo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxLiquidado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEspecial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDTipoCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxContabilizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxDomiciliado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxRemesable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PicTotal.suspendlayout()
        CType(Me.cbxFactoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxClienteFactoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoAnticipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxComunicadoGestorCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.Label2)
        Me.FilterPanel.Controls.Add(Me.clbFechaPagMax)
        Me.FilterPanel.Controls.Add(Me.clbFechaPagare)
        Me.FilterPanel.Controls.Add(Me.lblFechaPagare)
        Me.FilterPanel.Controls.Add(Me.clbFechaCobroHasta)
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.clbFechaCobroDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaCobro)
        Me.FilterPanel.Controls.Add(Me.lblFrasAgrup)
        Me.FilterPanel.Controls.Add(Me.txtFrasAgrup)
        Me.FilterPanel.Controls.Add(Me.lblComunicadoGestorCobro)
        Me.FilterPanel.Controls.Add(Me.cbxComunicadoGestorCobro)
        Me.FilterPanel.Controls.Add(Me.cbxFechaComunicacionGestorCobro)
        Me.FilterPanel.Controls.Add(Me.lblFechaComunicacionGestorCobro)
        Me.FilterPanel.Controls.Add(Me.cboEstadoAnticipo)
        Me.FilterPanel.Controls.Add(Me.lblEstadoAnticipo)
        Me.FilterPanel.Controls.Add(Me.lblremesaAnticipo)
        Me.FilterPanel.Controls.Add(Me.AdvRemesaAnticipo)
        Me.FilterPanel.Controls.Add(Me.lblClteFactoring)
        Me.FilterPanel.Controls.Add(Me.lblFactoring)
        Me.FilterPanel.Controls.Add(Me.lblTitulo)
        Me.FilterPanel.Controls.Add(Me.lblObra)
        Me.FilterPanel.Controls.Add(Me.lblContador)
        Me.FilterPanel.Controls.Add(Me.lblFechaFacturaD)
        Me.FilterPanel.Controls.Add(Me.lblFechaFacturaH)
        Me.FilterPanel.Controls.Add(Me.lblManual)
        Me.FilterPanel.Controls.Add(Me.lblGrupo)
        Me.FilterPanel.Controls.Add(Me.lblRiesgo)
        Me.FilterPanel.Controls.Add(Me.lblBBDD)
        Me.FilterPanel.Controls.Add(Me.lblClienteCab)
        Me.FilterPanel.Controls.Add(Me.lblLiquidado)
        Me.FilterPanel.Controls.Add(Me.lblEspecial)
        Me.FilterPanel.Controls.Add(Me.lblTipo)
        Me.FilterPanel.Controls.Add(Me.lblContabilizado)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.lblFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFormaPago)
        Me.FilterPanel.Controls.Add(Me.lblImporteDesde)
        Me.FilterPanel.Controls.Add(Me.lblImporteHasta)
        Me.FilterPanel.Controls.Add(Me.lblRemesa)
        Me.FilterPanel.Controls.Add(Me.lblBancoPropio)
        Me.FilterPanel.Controls.Add(Me.lblEjercicio)
        Me.FilterPanel.Controls.Add(Me.lblDomiciliado)
        Me.FilterPanel.Controls.Add(Me.lblRemesable)
        Me.FilterPanel.Controls.Add(Me.lblSituacion)
        Me.FilterPanel.Controls.Add(Me.cbxClienteFactoring)
        Me.FilterPanel.Controls.Add(Me.cbxFactoring)
        Me.FilterPanel.Controls.Add(Me.FwiTitulo)
        Me.FilterPanel.Controls.Add(Me.AdvIDObra)
        Me.FilterPanel.Controls.Add(Me.fwiImpHasta)
        Me.FilterPanel.Controls.Add(Me.fwiImpDesde)
        Me.FilterPanel.Controls.Add(Me.AdvIDContador)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFacturaD)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFacturaH)
        Me.FilterPanel.Controls.Add(Me.cbxManual)
        Me.FilterPanel.Controls.Add(Me.cbxEmpresaGrupo)
        Me.FilterPanel.Controls.Add(Me.cbxRiesgo)
        Me.FilterPanel.Controls.Add(Me.cbxEmpresa)
        Me.FilterPanel.Controls.Add(Me.AdvIDClienteCab)
        Me.FilterPanel.Controls.Add(Me.cbxLiquidado)
        Me.FilterPanel.Controls.Add(Me.cbxEspecial)
        Me.FilterPanel.Controls.Add(Me.cbxIDTipoCobro)
        Me.FilterPanel.Controls.Add(Me.cbxContabilizado)
        Me.FilterPanel.Controls.Add(Me.lblfwiCContable)
        Me.FilterPanel.Controls.Add(Me.txtCContable)
        Me.FilterPanel.Controls.Add(Me.lblfwiSaldoCContable)
        Me.FilterPanel.Controls.Add(Me.txtSaldoCContable)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.AdvIDCliente)
        Me.FilterPanel.Controls.Add(Me.AdvFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.AdvFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxIDFormaPago)
        Me.FilterPanel.Controls.Add(Me.AdvIDRemesa)
        Me.FilterPanel.Controls.Add(Me.cbxIDBancoPropio)
        Me.FilterPanel.Controls.Add(Me.cbxIDEjercicio)
        Me.FilterPanel.Controls.Add(Me.cbxDomiciliado)
        Me.FilterPanel.Controls.Add(Me.cbxRemesable)
        Me.FilterPanel.Controls.Add(Me.cbxSituacion)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 245)
        Me.FilterPanel.Size = New System.Drawing.Size(952, 176)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.PicTotal)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(952, 245)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.PicTotal, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCheque", "Cheque", "IDCheque"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTarjeta", "Tarjeta", "IDTarjeta"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NMandato", "Mandato", "NMandato", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDMandato", "IDMandato")}), "tbMaestroMandato")})
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[True]
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Cobro"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.KeyField = "IDCobro"
        Me.Grid.Size = New System.Drawing.Size(952, 213)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "frmCobros"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
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
        Me.Toolbar.Size = New System.Drawing.Size(391, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(952, 421)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(952, 421)
        '
        'AdvIDContador
        '
        Me.AdvIDContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDContador.EntityName = "EntidadContador"
        Me.AdvIDContador.Location = New System.Drawing.Point(248, 128)
        Me.AdvIDContador.Name = "AdvIDContador"
        Me.AdvIDContador.SecondaryDataFields = "IDContador"
        Me.AdvIDContador.Size = New System.Drawing.Size(91, 23)
        Me.AdvIDContador.TabIndex = 13
        Me.AdvIDContador.ViewName = "tbEntidadContador"
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(176, 133)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 0
        Me.lblContador.Text = "Contador"
        '
        'cbxFechaFacturaD
        '
        Me.cbxFechaFacturaD.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFacturaD.Location = New System.Drawing.Point(104, 103)
        Me.cbxFechaFacturaD.Name = "cbxFechaFacturaD"
        Me.cbxFechaFacturaD.Size = New System.Drawing.Size(70, 21)
        Me.cbxFechaFacturaD.TabIndex = 5
        '
        'lblFechaFacturaD
        '
        Me.lblFechaFacturaD.Location = New System.Drawing.Point(5, 103)
        Me.lblFechaFacturaD.Name = "lblFechaFacturaD"
        Me.lblFechaFacturaD.Size = New System.Drawing.Size(82, 13)
        Me.lblFechaFacturaD.TabIndex = 34
        Me.lblFechaFacturaD.Text = "F. Factura >="
        '
        'cbxFechaFacturaH
        '
        Me.cbxFechaFacturaH.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFacturaH.Location = New System.Drawing.Point(104, 126)
        Me.cbxFechaFacturaH.Name = "cbxFechaFacturaH"
        Me.cbxFechaFacturaH.Size = New System.Drawing.Size(70, 21)
        Me.cbxFechaFacturaH.TabIndex = 6
        '
        'lblFechaFacturaH
        '
        Me.lblFechaFacturaH.Location = New System.Drawing.Point(5, 126)
        Me.lblFechaFacturaH.Name = "lblFechaFacturaH"
        Me.lblFechaFacturaH.Size = New System.Drawing.Size(78, 13)
        Me.lblFechaFacturaH.TabIndex = 35
        Me.lblFechaFacturaH.Text = "F.Factura <="
        '
        'cbxManual
        '
        cbxManual_DesignTimeLayout.LayoutString = resources.GetString("cbxManual_DesignTimeLayout.LayoutString")
        Me.cbxManual.DesignTimeLayout = cbxManual_DesignTimeLayout
        Me.cbxManual.DisabledBackColor = System.Drawing.Color.White
        Me.cbxManual.Location = New System.Drawing.Point(421, 125)
        Me.cbxManual.Name = "cbxManual"
        Me.cbxManual.SelectedIndex = -1
        Me.cbxManual.SelectedItem = Nothing
        Me.cbxManual.Size = New System.Drawing.Size(57, 21)
        Me.cbxManual.TabIndex = 20
        '
        'lblManual
        '
        Me.lblManual.Location = New System.Drawing.Point(340, 125)
        Me.lblManual.Name = "lblManual"
        Me.lblManual.Size = New System.Drawing.Size(75, 13)
        Me.lblManual.TabIndex = 36
        Me.lblManual.Text = "Tipo Manual"
        '
        'cbxEmpresaGrupo
        '
        cbxEmpresaGrupo_DesignTimeLayout.LayoutString = resources.GetString("cbxEmpresaGrupo_DesignTimeLayout.LayoutString")
        Me.cbxEmpresaGrupo.DesignTimeLayout = cbxEmpresaGrupo_DesignTimeLayout
        Me.cbxEmpresaGrupo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEmpresaGrupo.Location = New System.Drawing.Point(710, 15)
        Me.cbxEmpresaGrupo.Name = "cbxEmpresaGrupo"
        Me.cbxEmpresaGrupo.SelectedIndex = -1
        Me.cbxEmpresaGrupo.SelectedItem = Nothing
        Me.cbxEmpresaGrupo.Size = New System.Drawing.Size(50, 21)
        Me.cbxEmpresaGrupo.TabIndex = 29
        '
        'lblGrupo
        '
        Me.lblGrupo.Location = New System.Drawing.Point(643, 19)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(42, 13)
        Me.lblGrupo.TabIndex = 37
        Me.lblGrupo.Text = "Grupo"
        '
        'cbxRiesgo
        '
        cbxRiesgo_DesignTimeLayout.LayoutString = resources.GetString("cbxRiesgo_DesignTimeLayout.LayoutString")
        Me.cbxRiesgo.DesignTimeLayout = cbxRiesgo_DesignTimeLayout
        Me.cbxRiesgo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxRiesgo.Location = New System.Drawing.Point(421, 81)
        Me.cbxRiesgo.Name = "cbxRiesgo"
        Me.cbxRiesgo.SelectedIndex = -1
        Me.cbxRiesgo.SelectedItem = Nothing
        Me.cbxRiesgo.Size = New System.Drawing.Size(57, 21)
        Me.cbxRiesgo.TabIndex = 18
        '
        'lblRiesgo
        '
        Me.lblRiesgo.Location = New System.Drawing.Point(340, 81)
        Me.lblRiesgo.Name = "lblRiesgo"
        Me.lblRiesgo.Size = New System.Drawing.Size(45, 13)
        Me.lblRiesgo.TabIndex = 39
        Me.lblRiesgo.Text = "Riesgo"
        '
        'cbxEmpresa
        '
        cbxEmpresa_DesignTimeLayout.LayoutString = resources.GetString("cbxEmpresa_DesignTimeLayout.LayoutString")
        Me.cbxEmpresa.DesignTimeLayout = cbxEmpresa_DesignTimeLayout
        Me.cbxEmpresa.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEmpresa.Location = New System.Drawing.Point(552, 103)
        Me.cbxEmpresa.Name = "cbxEmpresa"
        Me.cbxEmpresa.SelectedIndex = -1
        Me.cbxEmpresa.SelectedItem = Nothing
        Me.cbxEmpresa.Size = New System.Drawing.Size(88, 21)
        Me.cbxEmpresa.TabIndex = 26
        '
        'lblBBDD
        '
        Me.lblBBDD.Location = New System.Drawing.Point(480, 103)
        Me.lblBBDD.Name = "lblBBDD"
        Me.lblBBDD.Size = New System.Drawing.Size(72, 13)
        Me.lblBBDD.TabIndex = 40
        Me.lblBBDD.Text = "Base Datos"
        '
        'AdvIDClienteCab
        '
        Me.AdvIDClienteCab.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDClienteCab.EntityName = "Cliente"
        Me.AdvIDClienteCab.Location = New System.Drawing.Point(248, 151)
        Me.AdvIDClienteCab.Name = "AdvIDClienteCab"
        Me.AdvIDClienteCab.SecondaryDataFields = "IDCliente"
        Me.AdvIDClienteCab.Size = New System.Drawing.Size(91, 23)
        Me.AdvIDClienteCab.TabIndex = 14
        Me.AdvIDClienteCab.ViewName = "tbMaestroCliente"
        '
        'lblClienteCab
        '
        Me.lblClienteCab.Location = New System.Drawing.Point(176, 156)
        Me.lblClienteCab.Name = "lblClienteCab"
        Me.lblClienteCab.Size = New System.Drawing.Size(42, 13)
        Me.lblClienteCab.TabIndex = 41
        Me.lblClienteCab.Text = "Grupo"
        '
        'cbxLiquidado
        '
        cbxLiquidado_DesignTimeLayout.LayoutString = resources.GetString("cbxLiquidado_DesignTimeLayout.LayoutString")
        Me.cbxLiquidado.DesignTimeLayout = cbxLiquidado_DesignTimeLayout
        Me.cbxLiquidado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxLiquidado.Location = New System.Drawing.Point(421, 148)
        Me.cbxLiquidado.Name = "cbxLiquidado"
        Me.cbxLiquidado.SelectedIndex = -1
        Me.cbxLiquidado.SelectedItem = Nothing
        Me.cbxLiquidado.Size = New System.Drawing.Size(57, 21)
        Me.cbxLiquidado.TabIndex = 21
        '
        'lblLiquidado
        '
        Me.lblLiquidado.Location = New System.Drawing.Point(340, 148)
        Me.lblLiquidado.Name = "lblLiquidado"
        Me.lblLiquidado.Size = New System.Drawing.Size(61, 13)
        Me.lblLiquidado.TabIndex = 43
        Me.lblLiquidado.Text = "Liquidado"
        '
        'cbxEspecial
        '
        cbxEspecial_DesignTimeLayout.LayoutString = resources.GetString("cbxEspecial_DesignTimeLayout.LayoutString")
        Me.cbxEspecial.DesignTimeLayout = cbxEspecial_DesignTimeLayout
        Me.cbxEspecial.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEspecial.Location = New System.Drawing.Point(710, 37)
        Me.cbxEspecial.Name = "cbxEspecial"
        Me.cbxEspecial.SelectedIndex = -1
        Me.cbxEspecial.SelectedItem = Nothing
        Me.cbxEspecial.Size = New System.Drawing.Size(50, 21)
        Me.cbxEspecial.TabIndex = 30
        '
        'lblEspecial
        '
        Me.lblEspecial.Location = New System.Drawing.Point(643, 41)
        Me.lblEspecial.Name = "lblEspecial"
        Me.lblEspecial.Size = New System.Drawing.Size(53, 13)
        Me.lblEspecial.TabIndex = 44
        Me.lblEspecial.Text = "Especial"
        '
        'cbxIDTipoCobro
        '
        cbxIDTipoCobro_DesignTimeLayout.LayoutString = resources.GetString("cbxIDTipoCobro_DesignTimeLayout.LayoutString")
        Me.cbxIDTipoCobro.DesignTimeLayout = cbxIDTipoCobro_DesignTimeLayout
        Me.cbxIDTipoCobro.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDTipoCobro.DisplayMember = "DescTipo"
        Me.cbxIDTipoCobro.EntityName = "TipoCobro"
        Me.cbxIDTipoCobro.Location = New System.Drawing.Point(552, 59)
        Me.cbxIDTipoCobro.Name = "cbxIDTipoCobro"
        Me.cbxIDTipoCobro.SecondaryDataFields = "IdTipoCobro"
        Me.cbxIDTipoCobro.SelectedIndex = -1
        Me.cbxIDTipoCobro.SelectedItem = Nothing
        Me.cbxIDTipoCobro.Size = New System.Drawing.Size(88, 21)
        Me.cbxIDTipoCobro.TabIndex = 24
        Me.cbxIDTipoCobro.ValueMember = "IdTipoCobro"
        Me.cbxIDTipoCobro.ViewName = "tbMaestroTipoCobro"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(480, 59)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 45
        Me.lblTipo.Text = "Tipo"
        '
        'cbxContabilizado
        '
        cbxContabilizado_DesignTimeLayout.LayoutString = resources.GetString("cbxContabilizado_DesignTimeLayout.LayoutString")
        Me.cbxContabilizado.DesignTimeLayout = cbxContabilizado_DesignTimeLayout
        Me.cbxContabilizado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxContabilizado.Location = New System.Drawing.Point(421, 59)
        Me.cbxContabilizado.Name = "cbxContabilizado"
        Me.cbxContabilizado.SelectedIndex = -1
        Me.cbxContabilizado.SelectedItem = Nothing
        Me.cbxContabilizado.Size = New System.Drawing.Size(57, 21)
        Me.cbxContabilizado.TabIndex = 17
        '
        'lblContabilizado
        '
        Me.lblContabilizado.Location = New System.Drawing.Point(340, 59)
        Me.lblContabilizado.Name = "lblContabilizado"
        Me.lblContabilizado.Size = New System.Drawing.Size(84, 13)
        Me.lblContabilizado.TabIndex = 47
        Me.lblContabilizado.Tag = "IdRec=4725;"
        Me.lblContabilizado.Text = "Contabilizado"
        '
        'txtCContable
        '
        Me.txtCContable.DisabledBackColor = System.Drawing.Color.White
        Me.txtCContable.Enabled = False
        Me.txtCContable.Location = New System.Drawing.Point(8, 37)
        Me.txtCContable.Name = "txtCContable"
        Me.txtCContable.Size = New System.Drawing.Size(83, 21)
        Me.txtCContable.TabIndex = 1
        Me.txtCContable.TabStop = False
        '
        'lblfwiCContable
        '
        Me.lblfwiCContable.Location = New System.Drawing.Point(4, 37)
        Me.lblfwiCContable.Name = "lblfwiCContable"
        Me.lblfwiCContable.Size = New System.Drawing.Size(0, 13)
        Me.lblfwiCContable.TabIndex = 1
        Me.lblfwiCContable.Tag = "IdRec=0;"
        '
        'txtSaldoCContable
        '
        Me.txtSaldoCContable.DisabledBackColor = System.Drawing.Color.White
        Me.txtSaldoCContable.Enabled = False
        Me.txtSaldoCContable.Location = New System.Drawing.Point(93, 37)
        Me.txtSaldoCContable.Name = "txtSaldoCContable"
        Me.txtSaldoCContable.Size = New System.Drawing.Size(81, 21)
        Me.txtSaldoCContable.TabIndex = 2
        Me.txtSaldoCContable.TabStop = False
        '
        'lblfwiSaldoCContable
        '
        Me.lblfwiSaldoCContable.Location = New System.Drawing.Point(84, 37)
        Me.lblfwiSaldoCContable.Name = "lblfwiSaldoCContable"
        Me.lblfwiSaldoCContable.Size = New System.Drawing.Size(0, 13)
        Me.lblfwiSaldoCContable.TabIndex = 2
        Me.lblfwiSaldoCContable.Tag = "IdRec=0;"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(104, 81)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(70, 21)
        Me.cbxFechaHasta.TabIndex = 4
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(5, 81)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(98, 13)
        Me.lblFechaHasta.TabIndex = 50
        Me.lblFechaHasta.Tag = "IdRec=4779;"
        Me.lblFechaHasta.Text = "Vencimiento <="
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(104, 59)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(70, 21)
        Me.cbxFechaDesde.TabIndex = 3
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(5, 59)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(98, 13)
        Me.lblFechaDesde.TabIndex = 51
        Me.lblFechaDesde.Tag = "IdRec=4777;"
        Me.lblFechaDesde.Text = "Vencimiento >="
        '
        'AdvIDCliente
        '
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(69, 15)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IDCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(105, 23)
        Me.AdvIDCliente.TabIndex = 0
        Me.AdvIDCliente.ViewName = "tbMaestroCliente"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(5, 15)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 52
        Me.lblCliente.Tag = "IdRec=4365;"
        Me.lblCliente.Text = "Cliente"
        '
        'AdvFacturaHasta
        '
        Me.AdvFacturaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFacturaHasta.DisplayField = "NFactura"
        Me.AdvFacturaHasta.EntityName = "FacturaVentaCabecera"
        Me.AdvFacturaHasta.Location = New System.Drawing.Point(248, 37)
        Me.AdvFacturaHasta.Name = "AdvFacturaHasta"
        Me.AdvFacturaHasta.PrimaryDataFields = "IDFactura"
        Me.AdvFacturaHasta.SecondaryDataFields = "IDFactura"
        Me.AdvFacturaHasta.Size = New System.Drawing.Size(91, 23)
        Me.AdvFacturaHasta.TabIndex = 9
        '
        'lblFacturaHasta
        '
        Me.lblFacturaHasta.Location = New System.Drawing.Point(176, 42)
        Me.lblFacturaHasta.Name = "lblFacturaHasta"
        Me.lblFacturaHasta.Size = New System.Drawing.Size(70, 13)
        Me.lblFacturaHasta.TabIndex = 54
        Me.lblFacturaHasta.Tag = "IdRec=4775;"
        Me.lblFacturaHasta.Text = "Factura <="
        '
        'AdvFacturaDesde
        '
        Me.AdvFacturaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFacturaDesde.DisplayField = "NFactura"
        Me.AdvFacturaDesde.EntityName = "FacturaVentaCabecera"
        Me.AdvFacturaDesde.Location = New System.Drawing.Point(248, 15)
        Me.AdvFacturaDesde.Name = "AdvFacturaDesde"
        Me.AdvFacturaDesde.PrimaryDataFields = "IDFactura"
        Me.AdvFacturaDesde.SecondaryDataFields = "IDFactura"
        Me.AdvFacturaDesde.Size = New System.Drawing.Size(91, 23)
        Me.AdvFacturaDesde.TabIndex = 8
        '
        'lblFacturaDesde
        '
        Me.lblFacturaDesde.Location = New System.Drawing.Point(176, 15)
        Me.lblFacturaDesde.Name = "lblFacturaDesde"
        Me.lblFacturaDesde.Size = New System.Drawing.Size(70, 13)
        Me.lblFacturaDesde.TabIndex = 56
        Me.lblFacturaDesde.Tag = "IdRec=4776;"
        Me.lblFacturaDesde.Text = "Factura >="
        '
        'cbxIDFormaPago
        '
        cbxIDFormaPago_DesignTimeLayout.LayoutString = resources.GetString("cbxIDFormaPago_DesignTimeLayout.LayoutString")
        Me.cbxIDFormaPago.DesignTimeLayout = cbxIDFormaPago_DesignTimeLayout
        Me.cbxIDFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDFormaPago.DisplayMember = "IDFormaPago"
        Me.cbxIDFormaPago.EntityName = "FormaPago"
        Me.cbxIDFormaPago.Location = New System.Drawing.Point(421, 37)
        Me.cbxIDFormaPago.Name = "cbxIDFormaPago"
        Me.cbxIDFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.cbxIDFormaPago.SelectedIndex = -1
        Me.cbxIDFormaPago.SelectedItem = Nothing
        Me.cbxIDFormaPago.Size = New System.Drawing.Size(57, 21)
        Me.cbxIDFormaPago.TabIndex = 16
        Me.cbxIDFormaPago.ValueMember = "IDFormaPago"
        Me.cbxIDFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Location = New System.Drawing.Point(340, 37)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(75, 13)
        Me.lblFormaPago.TabIndex = 58
        Me.lblFormaPago.Tag = "IdRec=4758;"
        Me.lblFormaPago.Text = "Forma Pago"
        '
        'lblImporteDesde
        '
        Me.lblImporteDesde.Location = New System.Drawing.Point(176, 88)
        Me.lblImporteDesde.Name = "lblImporteDesde"
        Me.lblImporteDesde.Size = New System.Drawing.Size(75, 13)
        Me.lblImporteDesde.TabIndex = 59
        Me.lblImporteDesde.Tag = "IdRec=4778;"
        Me.lblImporteDesde.Text = "Importe >="
        '
        'lblImporteHasta
        '
        Me.lblImporteHasta.Location = New System.Drawing.Point(176, 110)
        Me.lblImporteHasta.Name = "lblImporteHasta"
        Me.lblImporteHasta.Size = New System.Drawing.Size(75, 13)
        Me.lblImporteHasta.TabIndex = 60
        Me.lblImporteHasta.Tag = "IdRec=4780;"
        Me.lblImporteHasta.Text = "Importe <="
        '
        'AdvIDRemesa
        '
        Me.AdvIDRemesa.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDRemesa.EntityName = "Remesa"
        Me.AdvIDRemesa.Location = New System.Drawing.Point(552, 15)
        Me.AdvIDRemesa.Name = "AdvIDRemesa"
        Me.AdvIDRemesa.SecondaryDataFields = "IDRemesa"
        Me.AdvIDRemesa.Size = New System.Drawing.Size(88, 23)
        Me.AdvIDRemesa.TabIndex = 22
        Me.AdvIDRemesa.ViewName = "tbRemesa"
        '
        'lblRemesa
        '
        Me.lblRemesa.Location = New System.Drawing.Point(480, 15)
        Me.lblRemesa.Name = "lblRemesa"
        Me.lblRemesa.Size = New System.Drawing.Size(53, 13)
        Me.lblRemesa.TabIndex = 61
        Me.lblRemesa.Tag = "IdRec=4782;"
        Me.lblRemesa.Text = "Remesa"
        '
        'cbxIDBancoPropio
        '
        cbxIDBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("cbxIDBancoPropio_DesignTimeLayout.LayoutString")
        Me.cbxIDBancoPropio.DesignTimeLayout = cbxIDBancoPropio_DesignTimeLayout
        Me.cbxIDBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDBancoPropio.DisplayMember = "DescBancoPropio"
        Me.cbxIDBancoPropio.EntityName = "BancoPropio"
        Me.cbxIDBancoPropio.Location = New System.Drawing.Point(421, 15)
        Me.cbxIDBancoPropio.Name = "cbxIDBancoPropio"
        Me.cbxIDBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.cbxIDBancoPropio.SelectedIndex = -1
        Me.cbxIDBancoPropio.SelectedItem = Nothing
        Me.cbxIDBancoPropio.Size = New System.Drawing.Size(57, 21)
        Me.cbxIDBancoPropio.TabIndex = 15
        Me.cbxIDBancoPropio.ValueMember = "IDBancoPropio"
        Me.cbxIDBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'lblBancoPropio
        '
        Me.lblBancoPropio.Location = New System.Drawing.Point(340, 15)
        Me.lblBancoPropio.Name = "lblBancoPropio"
        Me.lblBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblBancoPropio.TabIndex = 63
        Me.lblBancoPropio.Tag = "IdRec=4613;"
        Me.lblBancoPropio.Text = "Banco Propio"
        '
        'cbxIDEjercicio
        '
        cbxIDEjercicio_DesignTimeLayout.LayoutString = resources.GetString("cbxIDEjercicio_DesignTimeLayout.LayoutString")
        Me.cbxIDEjercicio.DesignTimeLayout = cbxIDEjercicio_DesignTimeLayout
        Me.cbxIDEjercicio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDEjercicio.DisplayMember = "IDEjercicio"
        Me.cbxIDEjercicio.EntityName = "EjercicioContable"
        Me.cbxIDEjercicio.Location = New System.Drawing.Point(552, 37)
        Me.cbxIDEjercicio.Name = "cbxIDEjercicio"
        Me.cbxIDEjercicio.SecondaryDataFields = "IDEjercicio"
        Me.cbxIDEjercicio.SelectedIndex = -1
        Me.cbxIDEjercicio.SelectedItem = Nothing
        Me.cbxIDEjercicio.Size = New System.Drawing.Size(88, 21)
        Me.cbxIDEjercicio.TabIndex = 23
        Me.cbxIDEjercicio.ValueMember = "IDEjercicio"
        Me.cbxIDEjercicio.ViewName = "tbMaestroEjercicio"
        '
        'lblEjercicio
        '
        Me.lblEjercicio.Location = New System.Drawing.Point(480, 37)
        Me.lblEjercicio.Name = "lblEjercicio"
        Me.lblEjercicio.Size = New System.Drawing.Size(55, 13)
        Me.lblEjercicio.TabIndex = 64
        Me.lblEjercicio.Tag = "IdRec=4467;"
        Me.lblEjercicio.Text = "Ejercicio"
        '
        'cbxDomiciliado
        '
        cbxDomiciliado_DesignTimeLayout.LayoutString = resources.GetString("cbxDomiciliado_DesignTimeLayout.LayoutString")
        Me.cbxDomiciliado.DesignTimeLayout = cbxDomiciliado_DesignTimeLayout
        Me.cbxDomiciliado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxDomiciliado.Location = New System.Drawing.Point(552, 125)
        Me.cbxDomiciliado.Name = "cbxDomiciliado"
        Me.cbxDomiciliado.SelectedIndex = -1
        Me.cbxDomiciliado.SelectedItem = Nothing
        Me.cbxDomiciliado.Size = New System.Drawing.Size(54, 21)
        Me.cbxDomiciliado.TabIndex = 27
        '
        'lblDomiciliado
        '
        Me.lblDomiciliado.Location = New System.Drawing.Point(480, 125)
        Me.lblDomiciliado.Name = "lblDomiciliado"
        Me.lblDomiciliado.Size = New System.Drawing.Size(73, 13)
        Me.lblDomiciliado.TabIndex = 65
        Me.lblDomiciliado.Tag = "IdRec=4783;"
        Me.lblDomiciliado.Text = "Domiciliado"
        '
        'cbxRemesable
        '
        cbxRemesable_DesignTimeLayout.LayoutString = resources.GetString("cbxRemesable_DesignTimeLayout.LayoutString")
        Me.cbxRemesable.DesignTimeLayout = cbxRemesable_DesignTimeLayout
        Me.cbxRemesable.DisabledBackColor = System.Drawing.Color.White
        Me.cbxRemesable.Location = New System.Drawing.Point(421, 103)
        Me.cbxRemesable.Name = "cbxRemesable"
        Me.cbxRemesable.SelectedIndex = -1
        Me.cbxRemesable.SelectedItem = Nothing
        Me.cbxRemesable.Size = New System.Drawing.Size(57, 21)
        Me.cbxRemesable.TabIndex = 19
        '
        'lblRemesable
        '
        Me.lblRemesable.Location = New System.Drawing.Point(340, 103)
        Me.lblRemesable.Name = "lblRemesable"
        Me.lblRemesable.Size = New System.Drawing.Size(70, 13)
        Me.lblRemesable.TabIndex = 66
        Me.lblRemesable.Text = "Remesable"
        '
        'cbxSituacion
        '
        cbxSituacion_DesignTimeLayout.LayoutString = resources.GetString("cbxSituacion_DesignTimeLayout.LayoutString")
        Me.cbxSituacion.DesignTimeLayout = cbxSituacion_DesignTimeLayout
        Me.cbxSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxSituacion.DisplayMember = "DescEstado"
        Me.cbxSituacion.EntityName = "EstadoCobro"
        Me.cbxSituacion.Location = New System.Drawing.Point(552, 81)
        Me.cbxSituacion.Name = "cbxSituacion"
        Me.cbxSituacion.SecondaryDataFields = "IDEstado"
        Me.cbxSituacion.SelectedIndex = -1
        Me.cbxSituacion.SelectedItem = Nothing
        Me.cbxSituacion.Size = New System.Drawing.Size(88, 21)
        Me.cbxSituacion.TabIndex = 25
        Me.cbxSituacion.ValueMember = "IDEstado"
        Me.cbxSituacion.ViewName = "tbMaestroEstadoCobro"
        '
        'lblSituacion
        '
        Me.lblSituacion.Location = New System.Drawing.Point(480, 81)
        Me.lblSituacion.Name = "lblSituacion"
        Me.lblSituacion.Size = New System.Drawing.Size(59, 13)
        Me.lblSituacion.TabIndex = 67
        Me.lblSituacion.Tag = "IdRec=4781;"
        Me.lblSituacion.Text = "Situación"
        '
        'fwiImpDesde
        '
        Me.fwiImpDesde.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpDesde.Location = New System.Drawing.Point(248, 84)
        Me.fwiImpDesde.Name = "fwiImpDesde"
        Me.fwiImpDesde.Size = New System.Drawing.Size(91, 21)
        Me.fwiImpDesde.TabIndex = 11
        '
        'fwiImpHasta
        '
        Me.fwiImpHasta.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpHasta.Location = New System.Drawing.Point(248, 106)
        Me.fwiImpHasta.Name = "fwiImpHasta"
        Me.fwiImpHasta.Size = New System.Drawing.Size(91, 21)
        Me.fwiImpHasta.TabIndex = 12
        '
        'PicTotal
        '
        Me.PicTotal.Controls.Add(Me.lblTotal)
        Me.PicTotal.Controls.Add(Me.lblTotalMarcado)
        Me.PicTotal.Controls.Add(Me.txtTotal)
        Me.PicTotal.Controls.Add(Me.txtTotalMarcado)
        Me.PicTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PicTotal.Location = New System.Drawing.Point(0, 213)
        Me.PicTotal.Name = "PicTotal"
        Me.PicTotal.Size = New System.Drawing.Size(952, 32)
        Me.PicTotal.TabIndex = 6
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(764, 9)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(55, 13)
        Me.lblTotal.TabIndex = 73
        Me.lblTotal.Tag = "IdRec=6574;"
        Me.lblTotal.Text = "TOTAL A"
        '
        'lblTotalMarcado
        '
        Me.lblTotalMarcado.Location = New System.Drawing.Point(505, 9)
        Me.lblTotalMarcado.Name = "lblTotalMarcado"
        Me.lblTotalMarcado.Size = New System.Drawing.Size(125, 13)
        Me.lblTotalMarcado.TabIndex = 74
        Me.lblTotalMarcado.Text = "Total A Seleccionado"
        '
        'txtTotal
        '
        Me.txtTotal.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(824, 6)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(122, 21)
        Me.txtTotal.TabIndex = 72
        '
        'txtTotalMarcado
        '
        Me.txtTotalMarcado.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalMarcado.Enabled = False
        Me.txtTotalMarcado.Location = New System.Drawing.Point(634, 6)
        Me.txtTotalMarcado.Name = "txtTotalMarcado"
        Me.txtTotalMarcado.Size = New System.Drawing.Size(122, 21)
        Me.txtTotalMarcado.TabIndex = 71
        '
        'AdvIDObra
        '
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "ObraCabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(852, 105)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(95, 23)
        Me.AdvIDObra.TabIndex = 38
        Me.AdvIDObra.ViewName = "tbObraCabecera"
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(763, 110)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(35, 13)
        Me.lblObra.TabIndex = 69
        Me.lblObra.Text = "Obra"
        '
        'FwiTitulo
        '
        Me.FwiTitulo.DisabledBackColor = System.Drawing.Color.White
        Me.FwiTitulo.Location = New System.Drawing.Point(48, 149)
        Me.FwiTitulo.Name = "FwiTitulo"
        Me.FwiTitulo.Size = New System.Drawing.Size(125, 21)
        Me.FwiTitulo.TabIndex = 7
        '
        'lblTitulo
        '
        Me.lblTitulo.Location = New System.Drawing.Point(5, 152)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(38, 13)
        Me.lblTitulo.TabIndex = 71
        Me.lblTitulo.Text = "Título"
        '
        'lblFactoring
        '
        Me.lblFactoring.Location = New System.Drawing.Point(480, 148)
        Me.lblFactoring.Name = "lblFactoring"
        Me.lblFactoring.Size = New System.Drawing.Size(58, 13)
        Me.lblFactoring.TabIndex = 73
        Me.lblFactoring.Tag = ""
        Me.lblFactoring.Text = "Factoring"
        '
        'cbxFactoring
        '
        cbxFactoring_DesignTimeLayout.LayoutString = resources.GetString("cbxFactoring_DesignTimeLayout.LayoutString")
        Me.cbxFactoring.DesignTimeLayout = cbxFactoring_DesignTimeLayout
        Me.cbxFactoring.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFactoring.Location = New System.Drawing.Point(552, 148)
        Me.cbxFactoring.Name = "cbxFactoring"
        Me.cbxFactoring.SelectedIndex = -1
        Me.cbxFactoring.SelectedItem = Nothing
        Me.cbxFactoring.Size = New System.Drawing.Size(54, 21)
        Me.cbxFactoring.TabIndex = 28
        '
        'lblClteFactoring
        '
        Me.lblClteFactoring.Location = New System.Drawing.Point(643, 63)
        Me.lblClteFactoring.Name = "lblClteFactoring"
        Me.lblClteFactoring.Size = New System.Drawing.Size(64, 13)
        Me.lblClteFactoring.TabIndex = 75
        Me.lblClteFactoring.Tag = ""
        Me.lblClteFactoring.Text = "Clte. Fact."
        '
        'cbxClienteFactoring
        '
        cbxClienteFactoring_DesignTimeLayout.LayoutString = resources.GetString("cbxClienteFactoring_DesignTimeLayout.LayoutString")
        Me.cbxClienteFactoring.DesignTimeLayout = cbxClienteFactoring_DesignTimeLayout
        Me.cbxClienteFactoring.DisabledBackColor = System.Drawing.Color.White
        Me.cbxClienteFactoring.Location = New System.Drawing.Point(710, 59)
        Me.cbxClienteFactoring.Name = "cbxClienteFactoring"
        Me.cbxClienteFactoring.SelectedIndex = -1
        Me.cbxClienteFactoring.SelectedItem = Nothing
        Me.cbxClienteFactoring.Size = New System.Drawing.Size(50, 21)
        Me.cbxClienteFactoring.TabIndex = 31
        '
        'lblremesaAnticipo
        '
        Me.lblremesaAnticipo.Location = New System.Drawing.Point(643, 85)
        Me.lblremesaAnticipo.Name = "lblremesaAnticipo"
        Me.lblremesaAnticipo.Size = New System.Drawing.Size(64, 13)
        Me.lblremesaAnticipo.TabIndex = 77
        Me.lblremesaAnticipo.Tag = ""
        Me.lblremesaAnticipo.Text = "Rem. Ant."
        '
        'AdvRemesaAnticipo
        '
        Me.AdvRemesaAnticipo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvRemesaAnticipo.EntityName = "Remesa"
        Me.AdvRemesaAnticipo.Location = New System.Drawing.Point(710, 81)
        Me.AdvRemesaAnticipo.Name = "AdvRemesaAnticipo"
        Me.AdvRemesaAnticipo.SecondaryDataFields = "IDRemesa"
        Me.AdvRemesaAnticipo.Size = New System.Drawing.Size(50, 23)
        Me.AdvRemesaAnticipo.TabIndex = 32
        Me.AdvRemesaAnticipo.ViewName = "tbRemesa"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add2.ico")
        Me.ImageList1.Images.SetKeyName(1, "delete2.ico")
        '
        'lblEstadoAnticipo
        '
        Me.lblEstadoAnticipo.Location = New System.Drawing.Point(643, 106)
        Me.lblEstadoAnticipo.Name = "lblEstadoAnticipo"
        Me.lblEstadoAnticipo.Size = New System.Drawing.Size(55, 13)
        Me.lblEstadoAnticipo.TabIndex = 79
        Me.lblEstadoAnticipo.Tag = ""
        Me.lblEstadoAnticipo.Text = "Est. Ant."
        '
        'cboEstadoAnticipo
        '
        cboEstadoAnticipo_DesignTimeLayout.LayoutString = resources.GetString("cboEstadoAnticipo_DesignTimeLayout.LayoutString")
        Me.cboEstadoAnticipo.DesignTimeLayout = cboEstadoAnticipo_DesignTimeLayout
        Me.cboEstadoAnticipo.DisabledBackColor = System.Drawing.Color.White
        Me.cboEstadoAnticipo.Location = New System.Drawing.Point(710, 103)
        Me.cboEstadoAnticipo.Name = "cboEstadoAnticipo"
        Me.cboEstadoAnticipo.SelectedIndex = -1
        Me.cboEstadoAnticipo.SelectedItem = Nothing
        Me.cboEstadoAnticipo.Size = New System.Drawing.Size(50, 21)
        Me.cboEstadoAnticipo.TabIndex = 33
        '
        'lblFechaComunicacionGestorCobro
        '
        Me.lblFechaComunicacionGestorCobro.Location = New System.Drawing.Point(763, 86)
        Me.lblFechaComunicacionGestorCobro.Name = "lblFechaComunicacionGestorCobro"
        Me.lblFechaComunicacionGestorCobro.Size = New System.Drawing.Size(99, 13)
        Me.lblFechaComunicacionGestorCobro.TabIndex = 85
        Me.lblFechaComunicacionGestorCobro.Text = "F. Comunicación"
        '
        'cbxFechaComunicacionGestorCobro
        '
        Me.cbxFechaComunicacionGestorCobro.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaComunicacionGestorCobro.Location = New System.Drawing.Point(852, 82)
        Me.cbxFechaComunicacionGestorCobro.Name = "cbxFechaComunicacionGestorCobro"
        Me.cbxFechaComunicacionGestorCobro.Size = New System.Drawing.Size(95, 21)
        Me.cbxFechaComunicacionGestorCobro.TabIndex = 37
        '
        'cbxComunicadoGestorCobro
        '
        cbxComunicadoGestorCobro_DesignTimeLayout.LayoutString = resources.GetString("cbxComunicadoGestorCobro_DesignTimeLayout.LayoutString")
        Me.cbxComunicadoGestorCobro.DesignTimeLayout = cbxComunicadoGestorCobro_DesignTimeLayout
        Me.cbxComunicadoGestorCobro.DisabledBackColor = System.Drawing.Color.White
        Me.cbxComunicadoGestorCobro.Location = New System.Drawing.Point(852, 60)
        Me.cbxComunicadoGestorCobro.Name = "cbxComunicadoGestorCobro"
        Me.cbxComunicadoGestorCobro.SelectedIndex = -1
        Me.cbxComunicadoGestorCobro.SelectedItem = Nothing
        Me.cbxComunicadoGestorCobro.Size = New System.Drawing.Size(95, 21)
        Me.cbxComunicadoGestorCobro.TabIndex = 36
        '
        'lblComunicadoGestorCobro
        '
        Me.lblComunicadoGestorCobro.Location = New System.Drawing.Point(763, 64)
        Me.lblComunicadoGestorCobro.Name = "lblComunicadoGestorCobro"
        Me.lblComunicadoGestorCobro.Size = New System.Drawing.Size(108, 13)
        Me.lblComunicadoGestorCobro.TabIndex = 196
        Me.lblComunicadoGestorCobro.Text = "Comunicado G.C."
        '
        'lblFrasAgrup
        '
        Me.lblFrasAgrup.Location = New System.Drawing.Point(176, 65)
        Me.lblFrasAgrup.Name = "lblFrasAgrup"
        Me.lblFrasAgrup.Size = New System.Drawing.Size(75, 13)
        Me.lblFrasAgrup.TabIndex = 198
        Me.lblFrasAgrup.Text = "Fact. Agrup."
        '
        'txtFrasAgrup
        '
        Me.txtFrasAgrup.DisabledBackColor = System.Drawing.Color.White
        Me.txtFrasAgrup.Location = New System.Drawing.Point(248, 61)
        Me.txtFrasAgrup.Name = "txtFrasAgrup"
        Me.txtFrasAgrup.Size = New System.Drawing.Size(91, 21)
        Me.txtFrasAgrup.TabIndex = 10
        '
        'clbFechaCobroDesde
        '
        Me.TryDataBinding(clbFechaCobroDesde, New System.Windows.Forms.Binding("BindableValue", Me, "FechaCobro", True))
        Me.clbFechaCobroDesde.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaCobroDesde.Location = New System.Drawing.Point(852, 15)
        Me.clbFechaCobroDesde.Name = "clbFechaCobroDesde"
        Me.clbFechaCobroDesde.Size = New System.Drawing.Size(94, 21)
        Me.clbFechaCobroDesde.TabIndex = 199
        '
        'lblFechaCobro
        '
        Me.lblFechaCobro.Location = New System.Drawing.Point(763, 19)
        Me.lblFechaCobro.Name = "lblFechaCobro"
        Me.lblFechaCobro.Size = New System.Drawing.Size(105, 13)
        Me.lblFechaCobro.TabIndex = 200
        Me.lblFechaCobro.Text = "Fecha Cobro > ="
        '
        'clbFechaCobroHasta
        '
        Me.clbFechaCobroHasta.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaCobroHasta.Location = New System.Drawing.Point(852, 37)
        Me.clbFechaCobroHasta.Name = "clbFechaCobroHasta"
        Me.clbFechaCobroHasta.Size = New System.Drawing.Size(94, 21)
        Me.clbFechaCobroHasta.TabIndex = 201
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(763, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 202
        Me.Label1.Text = "Fecha Cobro < ="
        '
        'clbFechaPagare
        '
        Me.TryDataBinding(clbFechaPagare, New System.Windows.Forms.Binding("BindableValue", Me, "FechaPagare", True))
        Me.clbFechaPagare.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaPagare.Location = New System.Drawing.Point(729, 134)
        Me.clbFechaPagare.Name = "clbFechaPagare"
        Me.clbFechaPagare.Size = New System.Drawing.Size(90, 21)
        Me.clbFechaPagare.TabIndex = 203
        '
        'lblFechaPagare
        '
        Me.lblFechaPagare.Location = New System.Drawing.Point(643, 138)
        Me.lblFechaPagare.Name = "lblFechaPagare"
        Me.lblFechaPagare.Size = New System.Drawing.Size(81, 13)
        Me.lblFechaPagare.TabIndex = 204
        Me.lblFechaPagare.Text = "F. Pagare >="
        '
        'clbFechaPagMax
        '
        Me.clbFechaPagMax.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaPagMax.Location = New System.Drawing.Point(852, 133)
        Me.clbFechaPagMax.Name = "clbFechaPagMax"
        Me.clbFechaPagMax.Size = New System.Drawing.Size(94, 21)
        Me.clbFechaPagMax.TabIndex = 205
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(825, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "<="
        '
        'CICobroCont
        '
        Me.AllowUpdate = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(960, 509)
        Me.EntityName = "Cobro"
        Me.KeyField = "IDCobro"
        Me.Name = "CICobroCont"
        Me.UseCheck = True
        Me.ViewName = "frmCobros"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEmpresaGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxRiesgo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxLiquidado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEspecial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDTipoCobro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxContabilizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxDomiciliado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxRemesable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PicTotal.ResumeLayout(False)
        Me.PicTotal.PerformLayout()
        CType(Me.cbxFactoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxClienteFactoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoAnticipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxComunicadoGestorCobro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected mintTipoCobro As Integer
    Protected mblnNoEditable As Boolean
    Protected dblTotalMarcado As Double
    Protected mblnImprimirRemesa As Boolean
    Protected mlngIDRemesa As Integer
    Protected DtFechaInforme As Date
    Protected mstrEjercicio As String
    Protected mIDProcess As System.Guid
    Protected mblnContabilidad As Boolean
    Protected mblnSAAS As Boolean
    Protected mIDCobros(-1) As Object
    Protected mSituacion As enumCobroSituacion?
    Protected mblnContabilidadMultiple As Boolean

    Protected Const cnEntidad As String = "FacturaVentaCabecera"
    Protected Const cnABRIRFACTURAVENTA As String = "Abrir Factura Venta"
    Protected Const cnABRIROBRA As String = "Abrir Obra"
    Protected Const cnABRIRCLTE As String = "Ver Cliente"
    Protected Const cnABRIRREMESA As String = "Abrir Remesa"
    Protected Const cnABRIRANTICIPO As String = "Abrir Anticipo"
    Protected Const cnABRIR_MANDATO As String = "Ver Mandato"

    Protected cnGESTION_CHEQUE_ADD As String = "Introducir Información Cheque"
    Protected cnGESTION_TARJETA_ADD As String = "Introducir Información Tarjeta"
    Protected cnGESTION_CHEQUE As String = "Ver/Modificar Información Cheque"
    Protected cnGESTION_TARJETA As String = "Ver/Modificar Información Tarjeta"
    Protected mblnAccionFormulario As Boolean



#Region " Load "

    Protected Overridable Sub CICobroCont_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Not Me.DesignMode Then
            Me.RecordsState = RecordsState.Saved
            '//Al volver del informe de Impresión de Recibos, hay que eliminar las marcas del servidor.
            If mblnDesmarcar AndAlso Not IsNothing(mobjGuid) Then
                DesmarcarRegistro(mobjGuid, FilterType.Numeric)
                mblnDesmarcar = False
            End If
        End If
    End Sub

    Protected Overridable Sub CICobroCont_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadToolbarActions()
            LoadGridActions()
            LoadEnums()
            InitFilterCriteria()
            If Not mIDCobros Is Nothing AndAlso mIDCobros.Length > 0 Then Me.Execute()
        End If
    End Sub

    Protected Overridable Sub LoadERPData()
        Dim P As New Parametro
        mintTipoCobro = P.CTipoCobroFV
        mblnContabilidad = P.Contabilidad
        mblnContabilidadMultiple = P.ContabilidadMultiple
        mblnSAAS = P.ExpertisSAAS
        If mblnContabilidad Then
            mstrEjercicio = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, Today)
        ElseIf Not mblnContabilidad Then
            Me.lblObra.Visible = False : Me.AdvIDObra.Visible = False
            Me.lblContabilizado.Visible = False : Me.cbxContabilizado.Visible = False
            Me.lblEjercicio.Visible = False : Me.cbxIDEjercicio.Visible = False
        End If
        cbxEmpresa.DataSource = New Comunes().GetUserDataBase
        cbxEmpresa.DisplayMember = "BaseDatos"
        cbxEmpresa.ValueMember = "IDBaseDatos"
        lblBBDD.Visible = Not mblnSAAS
        cbxEmpresa.Visible = Not mblnSAAS

        If TypeOf Me.Params Is Hashtable Then
            If CType(Me.Params, Hashtable).ContainsKey("IDCobros") Then
                Dim IDCobros() As Integer = CType(Me.Params, Hashtable)("IDCobros")
                If IDCobros.Length > 0 Then
                    ReDim mIDCobros(IDCobros.Length)
                    IDCobros.CopyTo(mIDCobros, 0)
                End If
            End If
            If CType(Me.Params, Hashtable).ContainsKey("Situacion") Then
                mSituacion = CType(CType(Me.Params, Hashtable)("Situacion"), enumCobroSituacion)
            End If
        End If
    End Sub

    Protected Overridable Sub LoadToolbarActions()
        If mblnContabilidad Then
            Me.FormActions.Add("Contabilización", AddressOf Contabilizar)
            Me.FormActions.Add("Descontabilización", AddressOf Descontabilizar)

            Me.FormActions.Add("Descontabilización Efectos Recibidos", AddressOf DescontabilizarEfectoRecibido)
            Me.AddSeparator()
        End If
        Me.FormActions.Add("Remesa provisional", AddressOf RemesaProvisional)
        Me.FormActions.Add("Remesa definitiva", AddressOf RemesaDefinitiva)
        Me.FormActions.Add("Añadir cobros a Remesa", AddressOf AñadirRemesa)
        Me.FormActions.Add("Retirar cobros de Remesa", AddressOf RetirarRemesa)
        'If mblnContabilidad Then
        Me.FormActions.Add("Liquidación de Remesa", AddressOf RemesaLiquidacion)
        'End If
        Me.AddSeparator()
        Me.FormActions.Add("Generar Anticipo", AddressOf AccionGenerarAnticipo)
        Me.FormActions.Add("Cancelar Anticipo", AddressOf AccionCancelarAnticipo)
        Me.FormActions.Add("Eliminar Cancelación Anticipo", AddressOf AccionEliminarCancelacionAnticipo)
        Me.FormActions.Add("Añadir cobros a Anticipo", AddressOf AccionAñadirAnticipo)
        Me.FormActions.Add("Retirar cobros de Anticipo", AddressOf AccionRetirarAnticipo)
        Me.AddSeparator()
        Me.FormActions.Add("Agrupación de Cobros", AddressOf CobrosAgrupables)
        Me.FormActions.Add("Desagrupación de Cobros", AddressOf DesagruparCobros)
        Me.FormActions.Add("Ver Agrupación de Cobros", AddressOf ConsultarAgrupacion)
        Me.FormActions.Add("Desglose de Cobro", AddressOf DesgloseCobros)
        Me.AddSeparator()
        Me.FormActions.Add("Cambio de situación", AddressOf CambioSituacion)
        Me.FormActions.Add("Cambio automático de situación", AddressOf CambioSituacionAutomatica)
        Me.AddSeparator()
        Me.FormActions.Add("Modificación de Cobros", AddressOf ModificacionCobros)
        Me.AddSeparator()
        Me.FormActions.Add("Devoluciones", AddressOf DevolucionCobros)
        Me.AddSeparator()
        Me.FormActions.Add("Cobro Manual", AddressOf CobroManual)
        Me.FormActions.Add("Eliminar Cobros", AddressOf AccionEliminarCobros)
        'If mblnContabilidad Then
        '    Me.AddSeparator()
        '    Me.FormActions.Add("Comparación de Saldos Contables", AddressOf ComparacionSaldos)
        'End If
        If Not New Parametro().ExpertisSAAS Then
            'If mblnContabilidad Then
            '    Me.FormActions.Add("Comparación de Saldos Contables a Fecha", AddressOf AccionComparacionSaldosFecha)
            '    Me.FormActions.Add("Comparación de Saldos Contables a Fecha Desglosado", AddressOf AccionComparacionSaldosFechaDesglose)
            'End If
            Me.AddSeparator()
            Me.FormActions.Add("Generar Pagos desde Cobros", AddressOf AccionAñadirPago)
            'Me.FormActions.Add("Ver Seguimiento del Cobro", AddressOf VerSeguimientoCobro)
        End If
        Me.AddSeparator()
        Me.FormActions.Add("Generar Facturas Gastos", AddressOf AccionGenerarCompras)
        Me.AddSeparator()
        Me.FormActions.Add("Repartir Importes", AddressOf AccionRepartirImportes)
        Me.AddSeparator()
        Me.FormActions.Add(cnGESTION_CHEQUE_ADD, AddressOf AccionFormularioGestionCheque)
        Me.FormActions.Add(cnGESTION_TARJETA_ADD, AddressOf AccionFormularioGestionTarjeta)

    End Sub

    Protected Overridable Sub LoadGridActions()
        Grid.AddSeparator()
        Grid.Actions.Add(cnABRIRCLTE, AddressOf AbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
        Grid.Actions.Add(cnABRIRFACTURAVENTA, AddressOf AbrirFacturaVenta, ExpertisApp.GetIcon("xFacturaVenta.ico"))
        Grid.Actions.Add(cnABRIROBRA, AddressOf AbrirObra, ExpertisApp.GetIcon("xProyectos.ico"))
        Grid.AddSeparator()
        Grid.Actions.Add("Ver Remesa", AddressOf CargarRemesa)
        Grid.Actions.Add(cnABRIRREMESA, AddressOf AbrirRemesa)
        Grid.Actions.Add(cnABRIRANTICIPO, AddressOf AbrirAnticipo)
        Grid.AddSeparator()
        Grid.Actions.Add("Ver Devoluciones", AddressOf CargarDevolucion)
        '       Grid.Actions.Add("Eliminar Cobro",  AddressOf EliminarCobros) 
        Grid.Actions.Add("Ver Seguimiento del Cobro", AddressOf VerSeguimientoCobro)
        Grid.AddSeparator()
        Grid.Actions.Add("Ver Facturas Gastos", AddressOf AccionVerCompras)
        'Grid.Actions.Add("Generar Facturas Gastos", AddressOf AccionGenerarCompras)
        Grid.AddSeparator()
        Grid.Actions.Add(cnGESTION_CHEQUE, AddressOf AccionGestionCheque)
        Grid.Actions.Add(cnGESTION_TARJETA, AddressOf AccionGestionTarjeta)

        Grid.Actions.Add(cnABRIR_MANDATO, AddressOf AbrirMandato, ExpertisApp.GetIcon("books_preferences.ico"))
    End Sub

    Protected Overridable Sub LoadEnums()
        cbxDomiciliado.DataSource = New EnumData("enumBoolean")
        cbxContabilizado.DataSource = New EnumData("enumContabilizadoTodos")
        If Not mblnContabilidadMultiple Then
            CType(cbxContabilizado.DataSource, DataView).RowFilter = "Name = 'enumContabilizadoTodos' AND Value <> " & enumContabilizado.ContabilizadoNIIF & " AND Value <> " & enumContabilizado.ContabilizadoTributario
        End If
        cbxRemesable.DataSource = New EnumData("enumBoolean")
        cbxLiquidado.DataSource = New EnumData("enumContabilizadoTodos")
        If Not mblnContabilidadMultiple Then
            CType(cbxLiquidado.DataSource, DataView).RowFilter = "Name = 'enumContabilizadoTodos' AND Value <> " & enumContabilizado.ContabilizadoNIIF & " AND Value <> " & enumContabilizado.ContabilizadoTributario
        End If

        cbxRiesgo.DataSource = New EnumData("enumBoolean")
       

        cbxManual.DataSource = New EnumData("enumBoolean")
        cbxEmpresaGrupo.DataSource = New EnumData("enumBoolean")
        cbxEspecial.DataSource = New EnumData("enumBoolean")
        cbxFactoring.DataSource = New EnumData("enumBoolean")
        cbxClienteFactoring.DataSource = New EnumData("enumBoolean")
        cbxComunicadoGestorCobro.DataSource = New EnumData("enumBoolean")

        EnumData.PopulateValueList("enumEstadoAnticipo", Grid.Columns("EstadoAnticipo"))
        cboEstadoAnticipo.DataSource = New EnumData("enumEstadoAnticipo")
        EnumData.PopulateValueList("enumContabilizado", Grid.Columns("Liquidado"))
        EnumData.PopulateValueList("enumContabilizado", Grid.Columns("RecibidoEfecto"))
    End Sub

    Protected Overridable Sub InitFilterCriteria()
        'txtTotalMarcado.Value = 0
        cbxEspecial.Value = enumBoolean.No
        ' Sergio Tecozam 20220204
        cbxRiesgo.Value = enumBoolean.Si
        cbxManual.Value = enumBoolean.Todos
        cbxEmpresaGrupo.Value = enumBoolean.Todos
        cbxContabilizado.Value = enumContabilizadoTodos.Todos
        If Not mSituacion Is Nothing Then
            cbxSituacion.Value = mSituacion
        Else
            cbxSituacion.Value = enumCobroSituacion.NoNegociado
        End If

        cbxRemesable.Value = enumBoolean.Todos
        cbxLiquidado.Value = enumContabilizadoTodos.Todos
        cbxDomiciliado.Value = enumBoolean.Todos
        'cbxRiesgo.Value = enumBoolean.Todos
        cbxFactoring.Value = enumBoolean.Todos
        cbxClienteFactoring.Value = enumBoolean.Todos
        cbxComunicadoGestorCobro.Value = enumBoolean.Todos
        txtTotalMarcado.Value = 0
        txtTotal.Value = 0
    End Sub

#End Region

#Region " ToolbarActions "

#Region " Contabilizar "

    Protected Overridable Sub Contabilizar()
        If Grid.CheckedRecordsCount > 0 Then
            If Engine.Length(cbxEspecial.Value) = 0 Or cbxEspecial.Value = enumBoolean.Todos Then
                ExpertisApp.GenerateMessage("Seleccione si es o no un cobro especial.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.UncheckAll.InvokeOnClick()
            Else
                AccionContabilizar(, , cbxEspecial.Value)
            End If
        Else : ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, ExpertisApp.Title)
        End If
    End Sub

    Protected Overridable Sub AccionContabilizar(Optional ByVal blnCambioSituacion As Boolean = False, _
                                   Optional ByVal blnCambioSituacionManual As Boolean = False, _
                                   Optional ByVal blnEspecial As Boolean = False)

        Dim dtMarcados As DataTable = Grid.CheckedRecords

        If dtMarcados Is Nothing OrElse dtMarcados.Rows.Count = 0 Then
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim VtosGeneradoPago As List(Of DataRow) = (From c In dtMarcados Where c("Situacion") = enumCobroSituacion.GeneradoPago).ToList()
        If VtosGeneradoPago.Count > 0 Then
            ExpertisApp.GenerateMessage("Existen Vencimientos que se deben contabilizar desde la gestión de pagos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim VtosRemesados As List(Of DataRow) = (From c In dtMarcados Where Not c.IsNull("IDRemesa")).ToList()
        If VtosRemesados.Count > 0 Then
            Dim TipoRemesa As Integer = New Parametro().TipoAsientoRemesa
            If TipoRemesa <> enumTipoAsientoRemesa.Banco_a_Cliente Then
                ExpertisApp.GenerateMessage("Existen Vencimientos que se deben contabilizar desde la Gestión de Remesas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        'Miramos si los pagos seleccionados tienen el mismo BPropio
        Dim strIdBancoPropio As String = String.Empty
        For Each drMarcados As DataRow In dtMarcados.Select
            If Engine.Length(drMarcados("IDBancoPropio")) > 0 Then
                If Engine.Length(strIdBancoPropio) > 0 And strIdBancoPropio <> drMarcados("IDBancoPropio") Then
                    strIdBancoPropio = String.Empty
                    Exit For
                ElseIf Engine.Length(strIdBancoPropio) = 0 Then
                    strIdBancoPropio = drMarcados("IDBancoPropio")
                End If
            End If
        Next

        Dim frm As New frmContabilizar
        Dim r As DialogResult = frm.AbrirContabilizacion(dtMarcados, blnCambioSituacion, blnCambioSituacionManual, strIdBancoPropio, blnEspecial)
        If r = Windows.Forms.DialogResult.OK Then
            Dim blnContabilizarFactoring As Boolean = frm.ContabilizacionFactoring
            Dim blnGenerarFicheroFactoring As Boolean = frm.FicheroFactoring
            Dim blnGenerarAsientoFactoring As Boolean = frm.AsientoFactoring
            Dim dblImporteBanco As Double = frm.ImporteBanco
            Dim dblComision As Double = frm.Comision

            mIDProcess = Grid.SaveServerChecks()
            If blnContabilizarFactoring Then
                ContabilizacionFactoring(mIDProcess, blnGenerarFicheroFactoring, blnGenerarAsientoFactoring, blnCambioSituacion, dblImporteBanco, dblComision)
            Else
                Dim fContabilizado As New Filter(FilterUnionOperator.Or)
                fContabilizado.Add(New NumberFilterItem("Contabilizado", enumContabilizado.Contabilizado))
                If frm.AsientoEfectoRdo Then
                    fContabilizado.Add(New NumberFilterItem("Contabilizado", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))
                End If
                Dim dv As DataView = dtMarcados.DefaultView
                dv.RowFilter = fContabilizado.Compose(New AdoFilterComposer)
                If dv.Count > 0 Then
                    If frm.AsientoEfectoRdo Then
                        ExpertisApp.GenerateMessage("Existen cobros seleccionados Contabilizados Total o Parcialmente que no intervendrán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ExpertisApp.GenerateMessage("Existen cobros seleccionados Contabilizados que no intervendrán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If

                If mblnContabilidadMultiple AndAlso frm.AsientoCobro Then
                    Dim fContaParcial As New Filter
                    fContaParcial.Add(New NumberFilterItem("RecibidoEfecto", FilterOperator.NotEqual, enumContabilizado.Contabilizado))
                    fContaParcial.Add(New NumberFilterItem("RecibidoEfecto", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))
                    dv.RowFilter = fContaParcial.Compose(New AdoFilterComposer)
                    If dv.Count > 0 Then
                        ExpertisApp.GenerateMessage("Existen cobros seleccionados con Contabilización de Recibido Efecto Cliente incompleta. {0}Revise Contabilización Tributaria y/o NIIF. Se cancelará el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
                        Exit Sub
                    End If
                End If

                Dim SimInfo As New DataSimulacionContableInfoCobro
                SimInfo.IDEjercicio = mstrEjercicioActual
                SimInfo.GuidSimulacion = mIDProcess
                SimInfo.FechaApunte = dtFechaApunte
                SimInfo.CambioSituacion = blnCambioSituacion
                SimInfo.NuevaSituacionCobro = lngNuevaSituacion
                SimInfo.AgruparPorBanco = mblnAgruparBanco
                SimInfo.IDBancoPropio = mstrIDBancoPropio
                SimInfo.DescApunte = mstrDescApunte
                SimInfo.Caption = ExpertisApp.Traslate("Simulación Contable - COBROS -")
                SimInfo.FechaValor = mdtFechaValor
                SimInfo.NDocumento = mstrNDocumento
                SimInfo.ImporteBanco = dblImporteBanco
                SimInfo.Comision = dblComision
                SimInfo.Factoring = False
                SimInfo.AsientoEfectoRecibido = frm.AsientoEfectoRdo
                SimInfo.GenerarDiferenciaCambio = frm.GenerarDiferenciaCambio

                Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
                AddHandler oFrm.Closed, AddressOf FrmActionClosed
            End If
        End If


    End Sub

#End Region

    Protected Overridable Sub Descontabilizar()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords

            'Comprobamos si los Cobros marcados se pueden descontabilizar
            Dim dv As DataView = dtMarcados.DefaultView
            dv.RowFilter = New NumberFilterItem("Contabilizado", FilterOperator.NotEqual, enumContabilizado.NoContabilizado).Compose(New AdoFilterComposer)
            If dv.Count = 0 Then
                ExpertisApp.GenerateMessage("No se pueden descontabilizar los cobros seleccionados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                dv.RowFilter = New IsNullFilterItem("IDRemesa", False).Compose(New AdoFilterComposer)
                If dv.Count > 0 Then
                    Dim TipoRemesa As Integer = New Parametro().TipoAsientoRemesa
                    If TipoRemesa <> enumTipoAsientoRemesa.Banco_a_Cliente Then
                        ExpertisApp.GenerateMessage("Existen Vencimientos que se deben descontabilizar desde la gestión de remesas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                mIDProcess = Grid.SaveServerChecks()
                Dim frm As New frmDescontabilizar
                frm.IDProcess = mIDProcess
                frm.ShowDialog()
            End If
            QuitarMarcas()
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Protected Overridable Sub DescontabilizarEfectoRecibido()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords

            'Comprobamos si los Cobros marcados se pueden descontabilizar
            Dim fValidacionDescont As New Filter(FilterUnionOperator.Or)

            fValidacionDescont.Add(New NumberFilterItem("RecibidoEfecto", FilterOperator.Equal, enumContabilizado.NoContabilizado))
            fValidacionDescont.Add(New NumberFilterItem("Situacion", FilterOperator.NotEqual, enumCobroSituacion.RecibidoClte))
            fValidacionDescont.Add(New NumberFilterItem("Contabilizado", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))

            Dim dv As DataView = dtMarcados.DefaultView
            dv.RowFilter = fValidacionDescont.Compose(New AdoFilterComposer)
            If dv.Count > 0 Then
                ExpertisApp.GenerateMessage("No se pueden descontabilizar los Efectos Recibidos seleccionados. {0}Deben estar No Contabilizados, en Situación de Rdo. Clte. y Recibido Efecto.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, vbNewLine)
            Else
                mIDProcess = Grid.SaveServerChecks()
                Dim frm As New frmDescontabilizar
                frm.IDProcess = mIDProcess
                frm.RecibidoEfectosCliente = True
                frm.ShowDialog()
            End If
            QuitarMarcas()
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#Region " Remesas "

    Protected Overridable Sub RemesaProvisional()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                Dim IDCobros(-1) As Integer
                For Each drCobro As DataRow In dtMarcados.Rows
                    ReDim Preserve IDCobros(UBound(IDCobros) + 1)
                    IDCobros(UBound(IDCobros)) = drCobro("IDCobro")
                Next

                Dim blnRemesables As Boolean = ExpertisApp.ExecuteTask(Of Integer(), Boolean)(AddressOf Cobro.ComprobarCobrosRemesables, IDCobros)
                If blnRemesables Then
                    mIDProcess = Grid.SaveServerChecks()
                    Dim frm As New frmRemesaProvisional
                    frm.AbrirRemesaProvisional(dtMarcados)
                    QuitarMarcas()
                Else
                    ExpertisApp.GenerateMessage("Los Cobros deben ser remesables. Revise su Situación y su Forma de Pago.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Protected Overridable Sub RemesaDefinitiva()
        'TODO: ¿Que hacemos con el AIva?
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            Dim IDCobros(-1) As Integer
            For Each drCobro As DataRow In dtMarcados.Rows
                ReDim Preserve IDCobros(UBound(IDCobros) + 1)
                IDCobros(UBound(IDCobros)) = drCobro("IDCobro")
            Next

            Dim dv As DataView = dtMarcados.DefaultView
            dv.RowFilter = New NumberFilterItem("Contabilizado", enumContabilizado.Contabilizado).Compose(New AdoFilterComposer)
            If dv.Count > 0 Then
                ExpertisApp.GenerateMessage("Existen cobros seleccionadas contabilizados que no intervendrán en el proceso de contabilización.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Dim blnRemesables As Boolean = ExpertisApp.ExecuteTask(Of Integer(), Boolean)(AddressOf Cobro.ComprobarCobrosRemesables, IDCobros)
            If blnRemesables Then
                mIDProcess = Grid.SaveServerChecks()
                Dim frm As New frmRemesaDefinitiva
                frm.IDProcess = mIDProcess
                If frm.AbrirRemesaDefinitiva(False, dtMarcados) = Windows.Forms.DialogResult.OK Then 'TODO: ANTES frm.AbrirRemesaDefinitiva(False, rs, blnEspecial)
                    'Añadimos la nueva remesa creada en la lista de remesas del filtro
                    Dim IDRemesa As Integer = frm.txtIDRemesa.Text
                    Dim f As New Filter
                    f.Add(New NumberFilterItem("IDRemesa", IDRemesa))
                    Dim dtRemesa As DataTable = New Remesa().Filter(f, "FechaNegociacion")
                    If Not dtRemesa Is Nothing AndAlso dtRemesa.Rows.Count > 0 Then
                        Dim FechaNegociacion As Date = dtRemesa.Rows(0)("FechaNegociacion")
                        Dim dtFechaValor As Date = Nz(frm.fwiFechaValor.Value, cnMinDate)
                        Dim strNDocumento As String = frm.fwiNDocumento.Text
                        Dim blnImprimirRemesa As Boolean = frm.fwiImprimir.Checked
                        Dim blnAsientoRemesa As Boolean = frm.mblnAsientoRemesa
                        Dim strEjercicio As String = frm.mstrEjercicio
                        Dim dtmFechaAsiento As Date = frm.mdtmFechaAsiento
                        Dim intTipoAsientoRemesa As Integer = frm.mintTipoAsientoRemesa
                        Dim strComentarioRemesa As String = frm.mstrComentarioRemesa
                        Dim strBPRemesa As String = frm.mstrBancoPropio
                        If blnImprimirRemesa Then
                            Dim oRpt As New Report("REMDEF")
                            oRpt.Filter.Add(f)
                            oRpt.Formulas("NomCedente").Text = ExpertisApp.EnterpriseName
                            ExpertisApp.OpenReport(oRpt)
                        End If
                        If blnAsientoRemesa Then
                            Dim SimInfo As New DataSimulacionContableInfoRemesa
                            SimInfo.IDEjercicio = strEjercicio
                            SimInfo.GuidSimulacion = mIDProcess
                            SimInfo.FechaApunte = dtmFechaAsiento
                            SimInfo.IDBancoPropio = strBPRemesa
                            SimInfo.DescApunte = strComentarioRemesa
                            SimInfo.Caption = "Simulación Contable - REMESAS -"
                            SimInfo.FechaValor = dtFechaValor
                            SimInfo.NDocumento = mstrNDocumento
                            SimInfo.IDRemesa = IDRemesa
                            SimInfo.TipoRemesa = intTipoAsientoRemesa

                            Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCont", , SimInfo, Me)
                            AddHandler oFrm.Closed, AddressOf FrmActionClosed
                        Else
                            QuitarMarcas()
                        End If
                    End If
                Else
                    QuitarMarcas()
                End If
            Else
                ExpertisApp.GenerateMessage("Los Cobros deben ser remesables. Revise su Situación y su Forma de Pago.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Protected Overridable Sub AñadirRemesa()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                Dim drMarcados() As DataRow = dtMarcados.Select(New IsNullFilterItem("IDRemesa", False).Compose(New AdoFilterComposer))
                If drMarcados.Length = 0 Then
                    Dim frm As New frmRemesa
                    If frm.ShowDialog() = DialogResult.OK Then
                        If ExpertisApp.GenerateMessage("Se añadirán los Cobros a la remesa. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            Dim IDRemesa As Integer = frm.IDRemesa
                            Dim f As New Filter
                            f.Add(New NumberFilterItem("IDRemesa", IDRemesa))
                            Dim f_OR As New Filter
                            f_OR.Add(New NumberFilterItem("Liquidado", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))
                            If mblnContabilidad Then f_OR.Add(New NumberFilterItem("Contabilizado", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))
                            f.Add(f_OR)
                            Dim dv As New DataView(dtMarcados)
                            dv.RowFilter = f.Compose(New AdoFilterComposer)
                            If dv.Count = 0 Then
                                Dim dtCobros As DataTable = dtMarcados.Clone
                                For Each dr As DataRow In dtMarcados.Select("GeneraRemesa = 1")
                                    dtCobros.ImportRow(dr)
                                Next
                                If dtCobros.Rows.Count > 0 Then
                                    Dim datos As New Cobro.DataAñadirCobrosARemesa
                                    datos.IDRemesa = IDRemesa
                                    datos.CobrosAAñadir = dtCobros
                                    ExpertisApp.ExecuteTask(Of Cobro.DataAñadirCobrosARemesa)(AddressOf Cobro.AñadirCobrosARemesa, datos)
                                    QuitarMarcas()
                                Else
                                    ExpertisApp.GenerateMessage("Los cobros seleccionados no cumplen las condiciones para añadirlo a la Remesa.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Else
                                Dim Msg As String
                                If mblnContabilidad Then
                                    Msg = ExpertisApp.Traslate("No se pueden añadir Remesas. La Remesa está liquidada y/o contabilizada.")
                                Else
                                    Msg = ExpertisApp.Traslate("No se pueden añadir Remesas. La Remesa está liquidada.")
                                End If
                                ExpertisApp.GenerateMessage(Msg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    End If
                Else
                    ExpertisApp.GenerateMessage("Hay Cobros seleccionados que ya están asociados a una remesa.{0}Por favor, revise las selecciones de los Cobros.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar algún registro.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Protected Overridable Sub RetirarRemesa()
        If Grid.CheckedRecordsCount > 0 Then
            Dim Msg As String
            If mblnContabilidad Then
                Msg = ExpertisApp.Traslate("Se retirarán los Cobros seleccionados de sus remesas.{0}Sólo se tendrán en cuenta los cobros con remesas no contabilizadas y no liquidadas y con anticipos no contabilizados.{1}¿Desea continuar?", vbNewLine, vbNewLine)
            Else
                Msg = ExpertisApp.Traslate("Se retirarán los Cobros seleccionados de sus remesas.{0}Sólo se tendrán en cuenta los cobros con remesas no liquidadas y con anticipos no gestionados.{1}¿Desea continuar?", vbNewLine, vbNewLine)
            End If
            If ExpertisApp.GenerateMessage(Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim dtMarcados As DataTable = Grid.CheckedRecords
                Dim f As New Filter
                f.Add(New NumberFilterItem("Liquidado", FilterOperator.NotEqual, enumContabilizado.Contabilizado))
                If mblnContabilidad Then f.Add(New NumberFilterItem("Contabilizado", FilterOperator.NotEqual, enumContabilizado.Contabilizado))
                Dim drCobro() As DataRow = dtMarcados.Select(f.Compose(New AdoFilterComposer))
                If Not drCobro Is Nothing AndAlso drCobro.Length > 0 Then
                    Dim IDCobros(-1) As String
                    Dim i As Integer = 0
                    For Each dr As DataRow In drCobro
                        ReDim Preserve IDCobros(i)
                        IDCobros(i) = dr("IDCobro")
                        i += 1
                    Next

                    ExpertisApp.ExecuteTask(Of Object())(AddressOf Cobro.RetirarCobrosDeRemesas, IDCobros)
                    QuitarMarcas()
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar algún Cobro.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Protected Overridable Sub RemesaLiquidacion()
        Dim TipoRemesa As Integer = New Parametro().TipoAsientoRemesa
        If TipoRemesa = enumTipoAsientoRemesa.Banco_a_Cliente Then
            ExpertisApp.GenerateMessage("Las Remesas de Tipo Banco a Cliente, no son liquidables.")
            QuitarMarcas()
        Else
            If Grid.CheckedRecordsCount > 0 Then
                '//Se valida la situación y el estado de los cobros.
                Dim objFilterSituacion As New Filter
                objFilterSituacion.Add(New NumberFilterItem("Situacion", FilterOperator.NotEqual, enumCobroSituacion.Negociado))
                objFilterSituacion.Add(New NumberFilterItem("Situacion", FilterOperator.NotEqual, enumCobroSituacion.Descontado))

                Dim objFilterEstado As New Filter
                If mblnContabilidad Then objFilterEstado.Add(New NumberFilterItem("Contabilizado", FilterOperator.Equal, enumContabilizado.NoContabilizado))

                Dim objFilter As New Filter(FilterUnionOperator.Or)
                objFilter.Add(objFilterSituacion)
                objFilter.Add(objFilterEstado)
                objFilter.Add(New NumberFilterItem("Liquidado", FilterOperator.Equal, enumContabilizado.Contabilizado))
                Dim Where As String = objFilter.Compose(New AdoFilterComposer)
                Dim adr() As DataRow = CType(Me.CheckedRecords, DataTable).Select(Where)
                If Not IsNothing(adr) AndAlso adr.Length > 0 Then
                    Dim Msg As String
                    If Not mblnContabilidad Then
                        Msg = ExpertisApp.Traslate("Debe seleccionar cobros Negociados o Descontados que no estén liquidados.")
                    Else
                        Msg = ExpertisApp.Traslate("Debe seleccionar cobros Negociados o Descontados y Contabilizados que no estén liquidados.")
                    End If
                    ExpertisApp.GenerateMessage(Msg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    QuitarMarcas()
                Else
                    '//Se solicita al usuario cierta información para generar el asiento de liquidación.
                    Dim frm As New frmLiquidacionRemesa
                    If frm.ShowDialog(Me) = DialogResult.OK Then
                        Dim strDescripcion As String = frm.Descripcion
                        Dim intSituacion As Integer = frm.Situacion
                        Dim blnEnfechaVto As Boolean = frm.EnFechaVto
                        Dim blnEnFechaRemesa As Boolean = frm.EnFechaRemesa
                        Dim dtFechaApunte As Date = frm.FechaApunte

                        If mblnContabilidad Then
                            mIDProcess = Grid.SaveServerChecks()
                            Dim SimInfo As New DataSimulacionContableInfoCobroAutomatico
                            SimInfo.GuidSimulacion = mIDProcess
                            SimInfo.TipoContabilizacion = enumTipoContabilizacion.tcCobroCambioAutomatico
                            SimInfo.Observaciones = strDescripcion
                            SimInfo.NuevaSituacionCobro = intSituacion
                            SimInfo.FechaApunte = dtFechaApunte
                            SimInfo.EnFechaVencimiento = blnEnfechaVto
                            SimInfo.EnFechaNegociacion = blnEnFechaRemesa
                            SimInfo.Caption = "Simulación Contable - REMESA LIQUIDACION -"
                            For Each dr As DataRow In Me.CheckedRecords.Rows
                                ReDim Preserve SimInfo.IDsContabilizar(UBound(SimInfo.IDsContabilizar) + 1)
                                SimInfo.IDsContabilizar(UBound(SimInfo.IDsContabilizar)) = dr("IDCobro")
                            Next
                            SimInfo.AgruparPorBanco = mblnAgruparBancoLiquidacion

                            Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
                            AddHandler oFrm.Closed, AddressOf FrmActionClosed
                        Else
                            Dim IDCobros(-1) As Object
                            For Each dr As DataRow In Me.CheckedRecords.Rows
                                ReDim Preserve IDCobros(UBound(IDCobros) + 1)
                                IDCobros(UBound(IDCobros)) = dr("IDCobro")
                            Next
                            Dim datosLiq As New Cobro.DataLiquidacionRemesaSinConta
                            datosLiq.IDCobros = IDCobros
                            datosLiq.NuevaSituacion = intSituacion
                            ExpertisApp.ExecuteTask(Of Cobro.DataLiquidacionRemesaSinConta)(AddressOf Cobro.LiquidacionRemesaSinConta, datosLiq)
                        End If
                    End If
                End If
            Else
                ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub



#Region " Anticipos "

    Protected Overridable Sub AccionGenerarAnticipo()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords

            Dim dv As DataView = dtMarcados.DefaultView
            dv.RowFilter = New IsNullFilterItem("IDRemesaAnticipo", False).Compose(New AdoFilterComposer)
            If dv.Count > 0 Then
                ExpertisApp.GenerateMessage("Existen cobros seleccionados Anticipados que no intervendrán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            dv.RowFilter = String.Empty
            dv.RowFilter = New NumberFilterItem("Contabilizado", enumContabilizado.Contabilizado).Compose(New AdoFilterComposer)
            If dv.Count > 0 Then
                ExpertisApp.GenerateMessage("Existen cobros seleccionadas contabilizados que no intervendrán en el proceso de contabilización.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Dim IDCobros(-1) As Integer
            For Each drCobro As DataRow In dtMarcados.Rows
                ReDim Preserve IDCobros(UBound(IDCobros) + 1)
                IDCobros(UBound(IDCobros)) = drCobro("IDCobro")
            Next
            'Dim blnRemesables As Boolean = ExpertisApp.ExecuteTask(Of Integer(), Boolean)(AddressOf Cobro.ComprobarCobrosRemesables, IDCobros)
            'If blnRemesables Then
            mIDProcess = Grid.SaveServerChecks()
            Dim frm As New frmGenerarAnticipo
            If frm.AbrirRemesaAnticipo(False, dtMarcados) = Windows.Forms.DialogResult.OK Then 'TODO: ANTES frm.AbrirRemesaDefinitiva(False, rs, blnEspecial)
                'Añadimos la nueva remesa creada en la lista de remesas del filtro
                Dim IDRemesa As Integer = frm.IDAnticipo
                Dim f As New Filter
                f.Add(New NumberFilterItem("IDRemesa", IDRemesa))
                Dim dtRemesa As DataTable = New Remesa().Filter(f, "FechaNegociacion")
                If Not dtRemesa Is Nothing AndAlso dtRemesa.Rows.Count > 0 Then
                    Dim FechaNegociacion As Date = dtRemesa.Rows(0)("FechaNegociacion")
                    Dim blnImprimirRemesa As Boolean '= frm.Imprimir
                    Dim blnAsientoRemesa As Boolean = frm.GenerarAsientoAnticipo
                    Dim strEjercicio As String = frm.Ejercicio
                    Dim dtmFechaAsiento As Date = frm.FechaAbono
                    Dim strBPRemesa As String = frm.BancoPropio
                    'If blnImprimirRemesa Then
                    '    Dim oRpt As New Report("REMDEF")
                    '    oRpt.Filter.Add(f)
                    '    oRpt.Formulas("NomCedente").Text = ExpertisApp.EnterpriseName
                    '    ExpertisApp.OpenReport(oRpt)
                    'End If
                    If blnAsientoRemesa Then
                        Dim SimInfo As New DataSimulacionContableInfoRemesa
                        SimInfo.IDEjercicio = strEjercicio
                        SimInfo.GuidSimulacion = mIDProcess
                        SimInfo.FechaApunte = dtmFechaAsiento
                        SimInfo.IDBancoPropio = strBPRemesa
                        SimInfo.DescApunte = frm.TextoAsientoAnticipo
                        SimInfo.Caption = "Simulación Contable - ANTICIPOS -"
                        SimInfo.FechaValor = dtmFechaAsiento
                        SimInfo.NDocumento = mstrNDocumento
                        SimInfo.IDRemesa = IDRemesa
                        SimInfo.TipoRemesa = enumTipoRemesa.RemesaAnticipo
                        SimInfo.Anticipo = True
                        SimInfo.FechaAbono = frm.FechaAbono
                        SimInfo.ReferenciaAbono = frm.ReferenciaAbono

                        Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCont", , SimInfo, Me)
                        AddHandler oFrm.Closed, AddressOf FrmActionClosed
                    Else
                        QuitarMarcas()
                    End If
                End If
            Else
                QuitarMarcas()
            End If
            'Else
            '    ExpertisApp.GenerateMessage("Los Cobros deben ser remesables. Revise su Situación y su Forma de Pago.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Protected Overridable Sub AccionCancelarAnticipo()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            If dtMarcados Is Nothing Then
                ExpertisApp.GenerateMessage("Debe seleccionar cobros asociados a una Remesa de Anticipo.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim dvAnt As DataView = dtMarcados.DefaultView
            dvAnt.RowFilter = New IsNullFilterItem("IDRemesaAnticipo", True).Compose(New AdoFilterComposer)
            If dvAnt.Count > 0 Then
                ExpertisApp.GenerateMessage("Debe seleccionar cobros asociados a una Remesa de Anticipo.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'QuitarMarcas()
                Exit Sub
            End If
            dvAnt.RowFilter = String.Empty

            dvAnt.RowFilter = New NumberFilterItem("EstadoAnticipo", FilterOperator.NotEqual, enumEstadoAnticipo.Abonado).Compose(New AdoFilterComposer)
            If dvAnt.Count > 0 Then
                ExpertisApp.GenerateMessage("Existen cobros seleccionados No Abonados que no intervendrán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            '//Si son de una Remesa de Anticipo y no están Liquidados (EstadoAnticipo<>Cancelado)
            Dim fAnticiposLiq As New Filter
            fAnticiposLiq.Add(New IsNullFilterItem("IDRemesaAnticipo", False))
            fAnticiposLiq.Add(New NumberFilterItem("EstadoAnticipo", FilterOperator.NotEqual, enumEstadoAnticipo.Cancelado))

            Dim fSituacionLiquidable As New Filter '(FilterUnionOperator.Or)
            Dim fSituacionAnt As New Filter
            fSituacionAnt.Add(New NumberFilterItem("Situacion", FilterOperator.NotEqual, enumCobroSituacion.Anticipado))
            ' If mblnContabilidad Then fAnticiposLiq.Add(New BooleanFilterItem("Contabilizado", enumCobroContabilizado.CobroNoContabilizado))

            Dim fSituacionCob As New Filter
            fSituacionCob.Add(New NumberFilterItem("Situacion", FilterOperator.NotEqual, enumCobroSituacion.Cobrado))
            ' If mblnContabilidad Then fSituacionCob.Add(New NumberFilterItem("Contabilizado", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))

            fSituacionLiquidable.Add(fSituacionAnt)
            fSituacionLiquidable.Add(fSituacionCob)
            ''fSituacionLiquidable.Add(New BooleanFilterItem("Liquidado", True))

            fAnticiposLiq.Add(fSituacionLiquidable)

            Dim WhereAnt As String = fAnticiposLiq.Compose(New AdoFilterComposer)
            dvAnt.RowFilter = String.Empty
            dvAnt.RowFilter = WhereAnt
            'Dim adrAnt() As DataRow = CType(Me.CheckedRecords, DataTable).Select(WhereAnt)
            If Not dvAnt Is Nothing AndAlso dvAnt.Count > 0 Then
                Dim Msg As String
                ' If Not mblnContabilidad Then
                Msg = ExpertisApp.Traslate("Debe seleccionar cobros Anticipados o Cobrados que no estén cancelados.")
                'Else
                '    Msg = ExpertisApp.Traslate("Debe seleccionar cobros Anticipados o Cobrados y Contabilizados que no estén cancelados.")
                'End If
                ExpertisApp.GenerateMessage(Msg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                QuitarMarcas()
            Else
                '//Se solicita al usuario cierta información para generar el asiento de liquidación.
                Dim frm As New frmCancelarAnticipo
                Dim BancosPropios As List(Of Object) = (From c In dtMarcados Where Not c.IsNull("IDBancoPropio") Select c("IDBancoPropio") Distinct).ToList
                If BancosPropios.Count = 1 Then
                    frm.IDBancoPropio = BancosPropios(0) & String.Empty
                End If
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    Dim intSituacion As Integer = frm.Situacion
                    Dim dtFechaApunte As Date = frm.FechaCancelacion

                    If mblnContabilidad Then
                        mblnAgruparBanco = frm.AgruparPorBanco
                        mIDProcess = Grid.SaveServerChecks()
                        Dim SimInfo As New DataSimulacionContableInfoCobroAutomatico
                        SimInfo.GuidSimulacion = mIDProcess
                        SimInfo.TipoContabilizacion = enumTipoContabilizacion.tcCobroCambioAutomatico
                        SimInfo.NuevaSituacionCobro = intSituacion
                        SimInfo.FechaApunte = dtFechaApunte
                        SimInfo.Anticipo = True
                        SimInfo.FechaCancelacion = dtFechaApunte
                        SimInfo.ReferenciaCancelacion = frm.RefCancelacion
                        SimInfo.Caption = ExpertisApp.Traslate("Simulación Contable - CANCELACIÓN ANTICIPO -")
                        SimInfo.DescApunte = frm.DescApunteAnticipo
                        Dim i As Integer = 0
                        For Each dr As DataRow In Me.CheckedRecords.Rows
                            ReDim Preserve SimInfo.IDsContabilizar(UBound(SimInfo.IDsContabilizar) + 1)
                            SimInfo.IDsContabilizar(UBound(SimInfo.IDsContabilizar)) = dr("IDCobro")

                            If frm.ContabilizarCobros OrElse frm.ContabilizarGastosAsociados Then
                                mIDCobrosContabilizar("IDEnlace" & i) = dr("IDCobro")
                                i += 1
                                mintSituacion = intSituacion
                                mdtFechaApunte = dtFechaApunte
                                mstrDescApunte = frm.DescApunteCobros

                                If frm.ContabilizarGastosAsociados Then
                                    Dim IDFacturaAnt As Integer
                                    Dim fCobro As New Filter
                                    fCobro.Add(New NumberFilterItem("IDCobro", dr("IDCobro")))
                                    Dim dtGastosCobro As DataTable = New CobroFacturaCompra().Filter(fCobro)
                                    For Each drGasto As DataRow In dtGastosCobro.Select(Nothing, "IDFactura")
                                        If IDFacturaAnt <> drGasto("IDFactura") Then
                                            ReDim Preserve mIDFacturas(mIDFacturas.Length)
                                            mIDFacturas(mIDFacturas.Length - 1) = drGasto("IDFactura")

                                            IDFacturaAnt = drGasto("IDFactura")
                                        End If
                                    Next
                                End If
                                mstrIDBancoPropio = frm.IDBancoPropio
                            End If
                        Next
                        SimInfo.AgruparPorBanco = mblnAgruparBancoLiquidacion
                        Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
                        AddHandler oFrm.Closed, AddressOf FrmActionClosed
                    Else
                        Dim IDCobros(-1) As Object
                        For Each dr As DataRow In Me.CheckedRecords.Rows
                            ReDim Preserve IDCobros(UBound(IDCobros) + 1)
                            IDCobros(UBound(IDCobros)) = dr("IDCobro")
                        Next
                        Dim datosLiq As New Cobro.DataLiquidacionRemesaSinConta
                        datosLiq.IDCobros = IDCobros
                        datosLiq.NuevaSituacion = intSituacion
                        ExpertisApp.ExecuteTask(Of Cobro.DataLiquidacionRemesaSinConta)(AddressOf Cobro.LiquidacionRemesaSinConta, datosLiq)
                    End If
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Protected Overridable Sub AccionEliminarCancelacionAnticipo()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords

            Dim CobrosSinAnticipo As List(Of DataRow) = (From c In dtMarcados Where c.IsNull("IDRemesaAnticipo") Select c).ToList
            If CobrosSinAnticipo.Count > 0 Then
                ExpertisApp.GenerateMessage("Debe seleccionar cobros asociados a una Remesa de Anticipo.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim CobrosSinCancelar As List(Of DataRow) = (From c In dtMarcados Where Not c.IsNull("EstadoAnticipo") AndAlso c("EstadoAnticipo") <> enumEstadoAnticipo.Cancelado Select c).ToList
            If CobrosSinCancelar.Count > 0 Then
                ExpertisApp.GenerateMessage("Existen cobros seleccionados No Cancelados que no intervendrán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            Dim dtAsientos As New DataTable
            Dim dtNAsientos As New DataTable

            If mblnContabilidad Then
                ComprobarAsientosCancelacionAnticipo(dtMarcados, dtNAsientos, dtAsientos)
                If Not IsNothing(dtNAsientos) AndAlso dtNAsientos.Rows.Count > 0 Then
                    Dim objfrmConsAsientoRemesa As New frmConsultaAsientoRemesa
                    'objfrmConsAsientoRemesa.IDRemesa = Grid.Value("IDRemesaAnticipo")
                    objfrmConsAsientoRemesa.TipoNegociacion = enumTipoRemesa.RemesaAnticipo
                    objfrmConsAsientoRemesa.TipoAsiento = enumDiarioTipoApunte.CancelacionAnticipo
                    objfrmConsAsientoRemesa.Accion = frmConsultaAsientoRemesa.enumTipoAccion.Eliminacion
                    objfrmConsAsientoRemesa.Asientos = dtAsientos
                    objfrmConsAsientoRemesa.NAsientos = dtNAsientos
                    objfrmConsAsientoRemesa.ShowDialog(Me)
                End If
            Else
                Dim IDCobros(-1) As Object
                For Each dr As DataRow In dtMarcados.Rows
                    ReDim Preserve IDCobros(IDCobros.Length)
                    IDCobros(IDCobros.Length - 1) = dr("IDCobro")
                Next
                Dim datosLiq As New Cobro.DataLiquidacionRemesaSinConta
                datosLiq.IDCobros = IDCobros
                ExpertisApp.ExecuteTask(Of Cobro.DataLiquidacionRemesaSinConta)(AddressOf Cobro.EliminarLiquidacionRemesaSinConta, datosLiq)
            End If
            QuitarMarcas()
            Me.Execute()
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Protected Overridable Sub ComprobarAsientosCancelacionAnticipo(ByVal dtCobros As DataTable, ByRef outDT_NAsientos As DataTable, ByRef outDT_Asientos As DataTable)
        If Not dtCobros Is Nothing AndAlso dtCobros.Rows.Count > 0 Then
            Dim f As New Filter
            f.Add(New NumberFilterItem("IDTipoApunte", enumDiarioTipoApunte.CancelacionAnticipo))
            Dim fCobros As New Filter(FilterUnionOperator.Or)
            For Each drCobro As DataRow In dtCobros.Rows
                fCobros.Add(New NumberFilterItem("IDDocumento", drCobro("IDCobro")))
            Next
            f.Add(fCobros)
            Dim strWhere As String = f.Compose(New AdoFilterComposer) & " Group By NAsiento, IDEjercicio"
            outDT_NAsientos = New BE.DataEngine().Filter("tbDiarioContable", "NAsiento, IDEjercicio", strWhere)

            Dim fAsientos As New Filter(FilterUnionOperator.Or)
            For Each row As DataRow In outDT_NAsientos.Rows
                Dim fAsiEjer As New Filter
                fAsiEjer.Add(New StringFilterItem("IDEjercicio", row("IDEjercicio")))
                fAsiEjer.Add(New NumberFilterItem("NAsiento", row("NAsiento")))
                fAsientos.Add(fAsiEjer)
            Next row
            If Not fAsientos Is Nothing AndAlso fAsientos.Count > 0 Then
                outDT_Asientos = New Business.Financiero.DiarioContable().Filter(fAsientos)
            End If
        End If
    End Sub

    Protected Overridable Sub AccionAñadirAnticipo()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then

                Dim CobrosYaAnticipados As List(Of DataRow) = (From c In dtMarcados _
                                                               Where Not c.IsNull("IDRemesaAnticipo")).ToList()

                'Dim drMarcados() As DataRow = dtMarcados.Select(New IsNullFilterItem("IDRemesaAnticipo", False).Compose(New AdoFilterComposer))
                If CobrosYaAnticipados Is Nothing OrElse CobrosYaAnticipados.Count = 0 Then
                    Dim frm As New frmRemesa
                    frm.Anticipo = True
                    If frm.ShowDialog() = DialogResult.OK Then
                        If ExpertisApp.GenerateMessage("Se añadirán los Cobros al anticipo. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            Dim IDRemesa As Integer = frm.IDRemesa

                            Dim f As New Filter
                            f.Add(New NumberFilterItem("IDRemesa", IDRemesa))
                            f.Add(New NumberFilterItem("ContabilizadoAnticipo", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))

                            Dim dtRemesaContabilizada As DataTable = New Remesa().Filter(f)
                            If dtRemesaContabilizada.Rows.Count = 0 Then
                                'Dim CobrosRemesables As List(Of DataRow) = (From c In dtMarcados _
                                '                                            Where Not c.IsNull("GeneraRemesa") AndAlso c("GeneraRemesa") AndAlso _
                                '                                                  Not c.IsNull("CobroRemesable") AndAlso c("CobroRemesable")).ToList()
                                'If CobrosRemesables.Count > 0 Then
                                'Dim dtCobros As DataTable = dtMarcados.Clone
                                'For Each dr As DataRow In CobrosRemesables
                                '    dtCobros.ImportRow(dr)
                                'Next

                                Dim datos As New Cobro.DataAñadirCobrosARemesa
                                datos.IDRemesa = IDRemesa
                                datos.CobrosAAñadir = dtMarcados
                                ExpertisApp.ExecuteTask(Of Cobro.DataAñadirCobrosARemesa)(AddressOf Cobro.AñadirCobrosARemesa, datos)

                                QuitarMarcas()
                                'Else
                                '    ExpertisApp.GenerateMessage("Los Cobros seleccionados no son Remesables.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                'End If
                            Else
                                ExpertisApp.GenerateMessage("No se pueden añadir cobros. El Anticipo está contabilizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Else
                        ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
                    End If
                Else
                    ExpertisApp.GenerateMessage("Hay Cobros seleccionados que ya están asociados a un anticipo.{0}Por favor, revise las selecciones de los Cobros.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar algún registro.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Protected Overridable Sub AccionRetirarAnticipo()
        If Grid.CheckedRecordsCount > 0 Then
            Dim Msg As String
            If mblnContabilidad Then
                Msg = ExpertisApp.Traslate("Se retirarán los Cobros seleccionados de sus anticipos.{0}Sólo se tendrán en cuenta los cobros con anticipos no contabilizados y con remesas no contabilizadas y no liquidadas.{1}¿Desea continuar?", vbNewLine, vbNewLine)
            Else
                Msg = ExpertisApp.Traslate("Se retirarán los Cobros seleccionados de sus anticipos.{0}Sólo se tendrán en cuenta los cobros con anticipos no gestionados y con remesas no liquidadas.{1}¿Desea continuar?", vbNewLine, vbNewLine)
            End If

            If ExpertisApp.GenerateMessage(Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim dtMarcados As DataTable = Grid.CheckedRecords
                If dtMarcados.Rows.Count > 0 Then

                    Dim MarcadosConAnticipoNoConta As List(Of Object) = (From c In dtMarcados _
                                                                    Where Not c.IsNull("IDRemesaAnticipo") AndAlso _
                                                                    c("Contabilizado") = enumContabilizado.NoContabilizado _
                                                                    Select c("IDCobro")).ToList()
                    Dim IDCobros(-1) As Object
                    IDCobros = MarcadosConAnticipoNoConta.ToArray

                    If IDCobros.Count = 0 Then
                        ExpertisApp.GenerateMessage("Los Cobros seleccionados no pertecen a ningún Anticipo o bien ya están gestionados. No se pueden eliminar del Anticipo.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ExpertisApp.ExecuteTask(Of Object())(AddressOf Cobro.RetirarCobrosDeAnticipos, IDCobros)
                    End If

                    QuitarMarcas()
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar algún Cobro.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


#End Region

#End Region

#Region " Agrupaciones "

    Public Sub CobrosAgrupables()
        Dim oFrm As Form = ExpertisApp.OpenForm("CICOAGR", , , Me)
        AddHandler oFrm.Closed, AddressOf FrmActionClosed
    End Sub

    Public Sub DesagruparCobros()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            Dim frm As New FrmDesagrupaCobros
            frm.AbrirFormulario(dtMarcados)
            QuitarMarcas()
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Sub ConsultarAgrupacion()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            Dim frm As New FrmDesagrupaCobros
            frm.AbrirFormulario(dtMarcados, True)

            QuitarMarcas()
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region " DesgloseCobros "

    Public Sub DesgloseCobros()
        If Grid.CheckedRecordsCount = 1 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                If ExpertisApp.ExecuteTask(Of enumCobroSituacion, Boolean)(AddressOf Cobro.EsDesagrupable, dtMarcados.Rows(0)("Situacion")) AndAlso _
                   Not dtMarcados.Rows(0)("Contabilizado") AndAlso _
                   CobroAgrupado(dtMarcados.Rows(0)("IDCobro")) = 0 Then

                    Dim frm As New FrmDesglosarCobros
                    frm.AbrirDesgloseCobro(dtMarcados, Me)

                    QuitarMarcas()
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar solo una fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overridable Function CobroAgrupado(ByVal IDCobro As Integer) As Integer
        Dim intTotal As Integer
        If IDCobro > 0 Then
            Dim dtCobro As DataTable = New Cobro().Filter(New NumberFilterItem("IdCobroAgrupado", IDCobro))
            If Not IsNothing(dtCobro) Then
                intTotal = dtCobro.Rows.Count
            End If
        End If

        Return intTotal
    End Function

#End Region

    Public Sub CambioSituacion()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                Dim dv As DataView = dtMarcados.DefaultView
                dv.RowFilter = "IDRemesa IS NULL OR (IDRemesa IS NOT NULL AND Contabilizado=0) "
                If dv.Count <> dtMarcados.Rows.Count Then
                    ExpertisApp.GenerateMessage("Para cambiar el estado de los Cobros remesados y Contabilizados hay que usar el 'Cambio Automático de situación'.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                dv.RowFilter = "IDPago is null"
                If dv.Count <> dtMarcados.Rows.Count Then
                    ExpertisApp.GenerateMessage("No se puede cambiar el estado de los cobros en situación de generado pago.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Dim frm As New FrmCambioSituacion

                If frm.AbrirCambioSituacion(dtMarcados, Me) = DialogResult.OK Then
                    If frm.BlnContabilizar Then AccionContabilizar(False, True)
                    txtTotalMarcado.Value = 0
                End If
                QuitarMarcas()
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub CambioSituacionAutomatica()
        Dim oFrm As Form
        Dim frm As New frmCambioAutomaticoEstados
        If frm.AbrirCambioAutomaticoEstados = Windows.Forms.DialogResult.OK Then
            Dim SimInfo As New DataSimulacionContableInfoCobroAutomatico
            'SimInfo.TipoContabilizacion = enumTipoContabilizacion.tcCobroCambioAutomatico
            'SimInfo.IDProgramParent = Me.Name
            SimInfo.IDEjercicio = mstrEjercicio
            SimInfo.Observaciones = frm.mstrComentarioRemesa
            SimInfo.NuevaSituacionCobro = enumCobroSituacion.Cobrado
            SimInfo.FechaApunte = cnMinDate
            SimInfo.EnFechaVencimiento = True
            SimInfo.EnFechaNegociacion = True
            SimInfo.Caption = "Simulación Contable - CAMBIO AUTOMATICO DE SITUACION -"
            ' Dim htMarcas As New Hashtable
            'Dim i As Integer
            For Each IDCobro As Integer In frm.IDCobros
                ReDim Preserve SimInfo.IDsContabilizar(SimInfo.IDsContabilizar.Length)
                SimInfo.IDsContabilizar(SimInfo.IDsContabilizar.Length - 1) = IDCobro
                'htMarcas("IDEnlace" & i) = IDCobro
                ' i += 1
            Next
            mobjGuid = MarcarRegistro(SimInfo.IDsContabilizar, FilterType.Numeric)
            SimInfo.GuidSimulacion = mobjGuid

            oFrm = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
            AddHandler oFrm.Closed, AddressOf FrmActionClosed
        End If
    End Sub

    Public Sub ModificacionCobros()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                Dim frm As New frmModifCobros
                mIDProcess = Grid.SaveServerChecks()

                If frm.AbrirModificacionCobros(mIDProcess.ToString, Me) = DialogResult.OK Then
                    QuitarMarcas()
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    'Public Sub DevolucionCobros()
    '    If Not Grid.DataSource Is Nothing Then
    '        If Grid.CheckedRecordsCount > 0 Then
    '            Dim dtMarcados As DataTable = Grid.CheckedRecords
    '            If IsNothing(dtMarcados) OrElse dtMarcados.Rows.Count = 0 Then
    '                ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Else
    '                '//Comprobamos que todos pertenecen al mismo banco propio
    '                Dim strIDBancoPropio As String = dtMarcados.Rows(0)("IDBancoPropio") & String.Empty
    '                Dim objFilterBancoPropio As New Filter
    '                objFilterBancoPropio.Add(New StringFilterItem("IDBancoPropio", FilterOperator.NotEqual, strIDBancoPropio))
    '                Dim adr() As DataRow = dtMarcados.Select(objFilterBancoPropio.Compose(New AdoFilterComposer))
    '                If Not IsNothing(adr) AndAlso adr.Length > 0 Then
    '                    ExpertisApp.GenerateMessage("Todos los cobros deben pertenecer al mismo Banco Propio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    Exit Sub
    '                End If

    '                Dim IDCobros(-1) As Object
    '                Dim blnContabilidad As Boolean = New Parametro().Contabilidad
    '                'Dim oFilter As New Filter(FilterUnionOperator.Or)
    '                Dim htMarcarCobros As New Hashtable
    '                For Each drRowMarcado As DataRow In dtMarcados.Rows
    '                    '//Comprobamos si el cobro esta Contabilizado(sólo si llevamos contabilidad), si el estado es Cobrado, Descontado o
    '                    '//(Negociado y Liquidado), y si esta Remesado. Si no, no se permite la Devolucion.
    '                    Dim blnCondicion As Boolean = (drRowMarcado("Situacion") = enumCobroSituacion.Cobrado OrElse _
    '                        drRowMarcado("Situacion") = enumCobroSituacion.Descontado OrElse _
    '                        (drRowMarcado("Situacion") = enumCobroSituacion.Negociado AndAlso drRowMarcado("Liquidado"))) AndAlso _
    '                       (Engine.Length(drRowMarcado("IDRemesa")) > 0) OrElse _
    '                    (drRowMarcado("Situacion") = enumCobroSituacion.Cobrado AndAlso Length(drRowMarcado("IDRemesaAnticipo")) > 0 AndAlso drRowMarcado("EstadoAnticipo") <> enumEstadoAnticipo.PdteAbono)
    '                    If blnContabilidad Then
    '                        blnCondicion = drRowMarcado("Contabilizado") AndAlso blnCondicion
    '                    End If
    '                    If blnCondicion Then
    '                        ReDim Preserve IDCobros(UBound(IDCobros) + 1)
    '                        IDCobros(UBound(IDCobros)) = drRowMarcado("IDCobro")
    '                    Else
    '                        Dim Msg As String = "Hay que seleccionar cobros "
    '                        If blnContabilidad Then Msg = Msg & "Contabilizados,"
    '                        Msg = Msg & "Remesados al Descuento y en Situación Descontado o Cobrado o Cobros Contabilizados, Remesados al Cobro, en situación Cobrado y Liquidados, o Cobrado y No Pendiente de Abono (Anticipos)."
    '                        ExpertisApp.GenerateMessage(Msg, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        Exit Sub
    '                    End If
    '                Next

    '                If IDCobros.Length > 0 Then
    '                    '//Si se permite la Devolución de alguno de los cobros seleccionados
    '                    mobjGuid = MarcarRegistro(IDCobros, FilterType.Numeric)
    '                    Dim HT As New Hashtable
    '                    'HT("Filter") = oFilter
    '                    HT("Guid") = mobjGuid
    '                    Dim oFrm As Form = ExpertisApp.OpenForm("CIDEVCO", , HT, Me)
    '                    AddHandler oFrm.Closed, AddressOf FrmActionClosed
    '                End If
    '            End If

    '            '         Me.Execute()
    '            QuitarMarcas()
    '        Else
    '            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    End If
    'End Sub

    Public Sub DevolucionCobros()
        If Not Grid.DataSource Is Nothing Then
            If Grid.CheckedRecordsCount > 0 Then
                Dim dtMarcados As DataTable = Grid.CheckedRecords
                If IsNothing(dtMarcados) OrElse dtMarcados.Rows.Count = 0 Then
                    ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    '//Comprobamos que todos pertenecen al mismo banco propio
                    Dim BancosPropios As List(Of Object) = (From c In dtMarcados Select c("IDBancoPropio") Distinct).ToList
                    If BancosPropios.Count > 1 Then
                        ExpertisApp.GenerateMessage("Todos los cobros deben pertenecer al mismo Banco Propio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    Dim IDCobros(-1) As Object
                    Dim blnContabilidad As Boolean = New Parametro().Contabilidad
                    'Dim oFilter As New Filter(FilterUnionOperator.Or)
                    Dim htMarcarCobros As New Hashtable
                    For Each drRowMarcado As DataRow In dtMarcados.Rows
                        '//Comprobamos si el cobro esta Contabilizado(sólo si llevamos contabilidad), si el estado es Cobrado, Descontado o
                        '//(Negociado y Liquidado), y si esta Remesado. O bien, no está remesado y es un ChequeTalón. Si no, no se permite la Devolucion.
                        Dim blnCondicion As Boolean = ((drRowMarcado("Situacion") = enumCobroSituacion.Cobrado OrElse _
                            drRowMarcado("Situacion") = enumCobroSituacion.Descontado OrElse _
                            (drRowMarcado("Situacion") = enumCobroSituacion.Negociado AndAlso drRowMarcado("Liquidado") <> enumContabilizado.NoContabilizado)) AndAlso _
                            (Engine.Length(drRowMarcado("IDRemesa")) > 0)) OrElse _
                            (Length(drRowMarcado("IDRemesa")) = 0 AndAlso Nz(drRowMarcado("ChequeTalon"), False) AndAlso drRowMarcado("Situacion") = enumCobroSituacion.Cobrado)

                        If blnContabilidad Then
                            blnCondicion = drRowMarcado("Contabilizado") AndAlso blnCondicion
                        End If
                        If blnCondicion Then
                            ReDim Preserve IDCobros(UBound(IDCobros) + 1)
                            IDCobros(UBound(IDCobros)) = drRowMarcado("IDCobro")
                        Else
                            Dim Msg As String = "Hay que seleccionar cobros "
                            If blnContabilidad Then Msg = Msg & "Contabilizados,"
                            Msg = Msg & "Remesados al Descuento y en Situación Descontado o Cobrado o Cobros Contabilizados, Remesados al Cobro, en situación Cobrado y Liquidados o Cheques Cobrados."
                            ExpertisApp.GenerateMessage(Msg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    Next

                    If IDCobros.Length > 0 Then
                        '//Si se permite la Devolución de alguno de los cobros seleccionados
                        mobjGuid = MarcarRegistro(IDCobros, FilterType.Numeric)
                        Dim HT As New Hashtable
                        'HT("Filter") = oFilter
                        HT("Guid") = mobjGuid
                        Dim oFrm As Form = ExpertisApp.OpenForm("CIDEVCO", , HT, Me)
                        AddHandler oFrm.Closed, AddressOf FrmActionClosed
                    End If
                End If

                '         Me.Execute()
                QuitarMarcas()
            Else
                ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Public Sub CobroManual()
        Dim frm As New frmCobroManual
        If frm.AbrirCobroManual(Me) = DialogResult.OK Then
            Me.Execute()
        End If
    End Sub


    Public Sub AccionEliminarCobros()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                If ExpertisApp.GenerateMessage("Se borrarán los cobros seleccionados que no estén Contabilizados y no dependan de una factura. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim IDCobros(-1) As Object
                    For Each pa As DataRow In dtMarcados.Rows
                        ReDim Preserve IDCobros(IDCobros.Length)
                        IDCobros(IDCobros.Length - 1) = pa("IDCobro")
                    Next

                    ExpertisApp.ExecuteTask(Of Object())(AddressOf Cobro.DeleteCobroManual, IDCobros)
                    QuitarMarcas()
                    txtTotalMarcado.Value = 0
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    'Public Sub ComparacionSaldos()
    '    Dim HT As New Hashtable
    '    HT("Origen") = enumOrigenDetalle.tdCobro
    '    If ExpertisApp.IsFormOpen("CONSALDO") Then ExpertisApp.CloseForm("CONSALDO")
    '    ExpertisApp.OpenForm("CONSALDO", , HT, Me)
    '    txtTotalMarcado.Value = 0
    'End Sub

    'Public Sub AccionComparacionSaldosFecha()
    '    Dim HT As New Hashtable
    '    HT("Origen") = enumOrigenDetalle.tdCobro
    '    If ExpertisApp.IsFormOpen("CONSALDOF") Then ExpertisApp.CloseForm("CONSALDOF")
    '    ExpertisApp.OpenForm("CONSALDOF", , HT, Me)
    '    txtTotalMarcado.Value = 0
    'End Sub

    'Public Sub AccionComparacionSaldosFechaDesglose()
    '    Dim HT As New Hashtable
    '    HT("Origen") = enumOrigenDetalle.tdCobro
    '    If ExpertisApp.IsFormOpen("CONSALDOFD") Then ExpertisApp.CloseForm("CONSALDOFD")
    '    ExpertisApp.OpenForm("CONSALDOFD", , HT, Me)
    '    txtTotalMarcado.Value = 0
    'End Sub

    Public Sub AccionFechaVtoMasivo()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords()
            If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                Dim IDCobros(-1) As Object
                For Each c As DataRow In dtMarcados.Rows
                    ReDim Preserve IDCobros(IDCobros.Length)
                    IDCobros(IDCobros.Length - 1) = c("IDCobro")
                Next
                Dim frm As New frmFechaVtoMasivo
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim dtmFechaVto As Date = frm.dtFechaVencimiento
                    Dim datos As New Cobro.DataUpdateFechaVto
                    datos.IDCobros = IDCobros
                    datos.FechaVencimiento = dtmFechaVto
                    ExpertisApp.ExecuteTask(Of Cobro.DataUpdateFechaVto, Boolean)(AddressOf Cobro.UpdateFechaVto, datos)
                    ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    QuitarMarcas()
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Protected Overridable Sub AccionAñadirPago()
        If Grid.CheckedRecordsCount > 0 Then
            Dim NFilas As Integer = Me.CheckedRecordsCount
            Dim dtCobros As DataTable = Me.CheckedRecords
            If Not IsNothing(dtCobros) AndAlso dtCobros.Rows.Count > 0 Then
                If NFilas <= 1 Then
                    If NFilas <> 0 Then
                        If dtCobros.Rows(0)("Situacion") = enumCobroSituacion.NoNegociado And _
                        dtCobros.Rows(0)("Contabilizado") = enumCobroContabilizado.CobroNoContabilizado And _
                        dtCobros.Rows(0)("ImpVencimiento") < 0 Then
                            Dim IDCobro As Integer = dtCobros.Rows(0)("IDCobro")
                            ExpertisApp.ExecuteTask(Of Integer)(AddressOf Pago.InsertarPagoDesdeCobro, IDCobro)
                            QuitarMarcas()
                        Else
                            ExpertisApp.GenerateMessage("Sólo se pueden generar Cobros con importe negativo, No Contabilizados, No Agrupados o en situación de No Negociado.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExpertisApp.GenerateMessage("Debe seleccionar solo una fila.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar solo una fila.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Protected mIDProcessGastos As Guid
    Protected mIDFacturas(-1) As Object
    Protected mIDCobrosContabilizar As New Hashtable
    Protected mintSituacion As Integer
    Protected mdtFechaApunte As Date

    Protected Overridable Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CType(sender, Form).Closed, AddressOf FrmActionClosed
        QuitarMarcas()
        Dim blnContabilizarGastos As Boolean
        If mIDCobrosContabilizar.Count > 0 AndAlso Nz(mdtFechaApunte, cnMinDate) <> cnMinDate Then
            Dim fCobros As New Filter(FilterUnionOperator.Or)
            For Each key As String In mIDCobrosContabilizar.Keys
                fCobros.Add(New NumberFilterItem("IDCobro", mIDCobrosContabilizar(key)))
            Next
            Dim fCobrosNoContabilizados As New Filter
            fCobrosNoContabilizados.Add("Contabilizado", False)
            fCobrosNoContabilizados.Add(fCobros)
            Dim dtCobros As DataTable = New Cobro().Filter(fCobrosNoContabilizados)
            If dtCobros.Rows.Count > 0 Then
                mobjGuid = MarcarRegistro(mIDCobrosContabilizar, FilterType.Numeric)
                mstrEjercicioActual = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, mdtFechaApunte)
                Dim SimInfo As New DataSimulacionContableInfoCobro
                SimInfo.GuidSimulacion = mobjGuid
                SimInfo.TipoContabilizacion = enumTipoContabilizacion.tcCobro
                SimInfo.IDEjercicio = mstrEjercicioActual
                SimInfo.FechaApunte = mdtFechaApunte
                SimInfo.CambioSituacion = True
                SimInfo.NuevaSituacionCobro = mintSituacion
                SimInfo.AgruparPorBanco = mblnAgruparBanco
                SimInfo.IDBancoPropio = mstrIDBancoPropio
                SimInfo.DescApunte = mstrDescApunte
                SimInfo.Caption = ExpertisApp.Traslate("Simulación Contable - COBROS -")
                SimInfo.FechaValor = mdtFechaValor
                SimInfo.NDocumento = mstrNDocumento

                SimInfo.Factoring = False
                If ExpertisApp.IsFormOpen("CISIMUCONT") Then ExpertisApp.CloseForm("CISIMUCONT")
                Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
                AddHandler oFrm.Closed, AddressOf FrmActionClosed
            Else
                blnContabilizarGastos = True
            End If

            mIDCobrosContabilizar.Clear()
        End If

        Dim f As Form = CType(sender, Form)
        If mIDFacturas.Length > 0 AndAlso (f.Text = ExpertisApp.Traslate("Simulación Contable - COBROS -") OrElse blnContabilizarGastos) Then
            Dim fFrasNoContabilizadas As New Filter
            fFrasNoContabilizadas.Add(New InListFilterItem("IDFactura", mIDFacturas, FilterType.Numeric))
            fFrasNoContabilizadas.Add("Estado", False)

            Dim dtFras As DataTable = New FacturaCompraCabecera().Filter(fFrasNoContabilizadas)
            If dtFras.Rows.Count > 0 Then
                mIDProcessGastos = MarcarRegistro(mIDFacturas, FilterType.Numeric)
                Dim SimInfo As New DataSimulacionContableInfo
                SimInfo.GuidSimulacion = mIDProcessGastos
                SimInfo.TipoContabilizacion = enumTipoContabilizacion.tcFacturaCompra
                SimInfo.Caption = ExpertisApp.Traslate("Simulación Contable - FACTURA COMPRA -")

                If ExpertisApp.IsFormOpen("CISIMUCONT") Then ExpertisApp.CloseForm("CISIMUCONT")
                Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
                AddHandler oFrm.Closed, AddressOf FrmActionClosed
            End If

            ReDim mIDFacturas(-1)
        End If

        If Engine.Length(mIDProcessGastos) > 0 Then DesmarcarRegistro(mIDProcessGastos, FilterType.Numeric)
    End Sub

    Protected Overridable Sub AccionRepartirImportes()
        If Length(AdvIDCliente.Text) > 0 Then
            Me.Execute()

            Dim frm As New frmReparteImporteCobrosCliente

            Dim where As String = String.Empty
            frm.ImporteTotalCobros = Nz(CType(Grid.DataSource, DataTable).Compute("SUM(ImpVencimientoA)", where), 0)
            frm.txtIDCliente.Text = AdvIDCliente.Text
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Cursor = Cursors.WaitCursor

                where = "Contabilizado = " & CInt(enumContabilizado.NoContabilizado)

                Dim IDCobro(-1) As Object

                Dim ImporteRestante As Double = frm.ntxImporte.Value
                For Each drCobro As DataRow In CType(Grid.DataSource, DataTable).Select(where, "FechaVencimiento Asc , ImpVencimientoA Asc")
                    If ImporteRestante > 0 Then
                        If ImporteRestante < drCobro("ImpVencimientoA") Then
                            ReDim Preserve IDCobro(IDCobro.Length)
                            IDCobro(IDCobro.Length - 1) = Desglosar(AdvIDCliente.Text, drCobro("IDCobro"), ImporteRestante)
                        Else
                            ReDim Preserve IDCobro(IDCobro.Length)
                            IDCobro(IDCobro.Length - 1) = drCobro("IDCobro")
                        End If
                        ImporteRestante -= drCobro("ImpVencimientoA")
                    Else
                        Exit For
                    End If
                Next

                If IDCobro.Length > 0 Then
                    Dim data As New Business.Negocio.Cobro.dataActualizarFormaPago(IDCobro, frm.cbxIDFormaPago.Value)
                    ExpertisApp.ExecuteTask(Of Business.Negocio.Cobro.dataActualizarFormaPago)(AddressOf Business.Negocio.Cobro.ActualizarFormaPago, data)

                    Me.Cursor = Cursors.Default
                    Me.Execute()
                    Dim f As New Filter
                    f.Add(New InListFilterItem("IDCobro", data.IDCobro, FilterType.Numeric))
                    where = f.Compose(New AdoFilterComposer)
                    For Each drCobro As DataRow In CType(Grid.DataSource, DataTable).Select(where)
                        If Grid.Find(Grid.Columns("IDCobro"), Janus.Windows.GridEX.ConditionOperator.Equal, drCobro("IDCobro"), -1, 1) Then
                            Grid.CheckRecord(Grid.GetRow)
                        End If
                    Next
                End If
                Me.Cursor = Cursors.Default
            Else
                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ExpertisApp.GenerateMessage("Debe de filtrar por un Cliente.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overridable Function Desglosar(ByVal IDCliente As String, ByVal IDCobro As Integer, ByVal Importe As Double) As Integer
        Dim data As New Business.Negocio.Cobro.dataCrearDesgloseCobro(IDCobro, Importe)
        Return ExpertisApp.ExecuteTask(Of Business.Negocio.Cobro.dataCrearDesgloseCobro, Integer)(AddressOf Business.Negocio.Cobro.CrearDesgloseCobro, data)
    End Function

#End Region

#Region " GridActions "

    Protected Overridable Sub AbrirCliente()
        ExpertisApp.OpenForm("MCLIENTE", New StringFilterItem("IDCliente", FilterOperator.Equal, Grid.Value("IDCliente")))
    End Sub

    Protected Overridable Sub AbrirFacturaVenta()
        ExpertisApp.OpenForm("MFACTV", New NumberFilterItem("IdFactura", FilterOperator.Equal, Grid.Value("IdFactura")))
    End Sub

    Protected Overridable Sub AbrirObra()
        ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IdObra", FilterOperator.Equal, Grid.Value("IdObra")))
    End Sub

    Protected Overridable Sub CargarRemesa()
        Dim IDRemesa As Integer = Nz(Grid.Value("IdRemesa"), 0)
        If IDRemesa = 0 AndAlso Length(Grid.Value("IdRemesaAnticipo")) > 0 Then IDRemesa = Nz(Grid.Value("IdRemesaAnticipo"), 0)
        If IDRemesa = 0 Then
            ExpertisApp.GenerateMessage("El cobro no está asociado a ninguna remesa.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim frm As New frmConsultaRemesa
            frm.IDRemesa = IDRemesa
            frm.ShowDialog(Me)
        End If
    End Sub

    Protected Overridable Sub CargarDevolucion()
        Dim frm As New frmConsultaDevoluciones
        If frm.AbrirDevoluciones(Grid.Value("IDCobro"), Grid.GetValue("Situacion")) = DialogResult.OK Then
            Me.UnCheckAllRecords()
            Me.Execute()
        End If
    End Sub

    Public Sub VerSeguimientoCobro()
        Dim frm As New frmSeguimientoCobro
        frm.MainFunction(Grid.Value("IDCobro"))
    End Sub

    Protected Overridable Sub AccionVerCompras()
        Dim frm As New frmGastosAsociados
        frm.AbrirFormularioCobro(Grid.Value("IDCobro"))
    End Sub

    Protected Overridable Sub AccionGenerarCompras()
        Dim dtMarcados As DataTable = Grid.CheckedRecords
        If Not dtMarcados Is Nothing Then
            Dim IDCobros(-1) As Integer

            For Each drCobro As DataRow In dtMarcados.Rows
                ReDim Preserve IDCobros(IDCobros.Length)
                IDCobros(IDCobros.Length - 1) = drCobro("IDCobro")
            Next

            If IDCobros.Length > 0 Then
                Dim HT As New Hashtable
                HT("IDCobros") = IDCobros
                ExpertisApp.OpenForm("MFACC", , HT)
            Else
                ExpertisApp.GenerateMessage("Debe seleccionar al menos un Cobro.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub

    Protected Overridable Sub AbrirRemesa()
        If Length(Grid.Value("IDRemesa")) > 0 Then
            Dim strAlias As String = "CIREMCOBRO"
            If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
            ExpertisApp.OpenForm(strAlias, , Grid.Value("IDRemesa"), Me)
        End If
    End Sub

    Protected Overridable Sub AbrirAnticipo()
        If Length(Grid.Value("IDRemesaAnticipo")) > 0 Then
            Dim strAlias As String = "CIREMCOBRO"
            If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
            ExpertisApp.OpenForm(strAlias, , Grid.Value("IDRemesaAnticipo"), Me)
        End If
    End Sub

    Protected Overridable Sub AbrirMandato()
        If Length(Grid.Value("IDMandato")) > 0 Then
            Dim strAlias As String = "MNTOMDTO"
            If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
            ExpertisApp.OpenForm(strAlias, New NumberFilterItem("IDMandato", Grid.Value("IDMandato")))
        End If
    End Sub

#End Region

#Region " QueryExecuting "

    Protected Overridable Sub CICobroCont_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        Dim CHAR_LIKE As String = "*"
        With e.Filter
            If Not mIDCobros Is Nothing AndAlso mIDCobros.Length > 0 Then
                .Add(New InListFilterItem("IDCobro", mIDCobros, FilterType.Numeric))
            End If
            .Add("IDCliente", FilterOperator.Equal, AdvIDCliente.Text, FilterType.String)

            Dim IDFacturasAgrup As String = Trim(txtFrasAgrup.Text & String.Empty)
            If Length(IDFacturasAgrup) > 0 Then
                Dim fFras As New Filter(FilterUnionOperator.Or)
                fFras.Add(New LikeFilterItem("NFacturasAgrupadas", CHAR_LIKE & IDFacturasAgrup & CHAR_LIKE))
                fFras.Add(New FilterItem("NFactura", IDFacturasAgrup))

                Dim fFrasRango As New Filter
                If Length(AdvFacturaDesde.Text) > 0 Then fFrasRango.Add("NFactura", FilterOperator.GreaterThanOrEqual, AdvFacturaDesde.Text, FilterType.String)
                If Length(AdvFacturaHasta.Text) > 0 Then fFrasRango.Add("NFactura", FilterOperator.LessThanOrEqual, AdvFacturaHasta.Text, FilterType.String)
                If fFrasRango.Count > 0 Then fFras.Add(fFrasRango)

                .Add(fFras)
            Else
                .Add("NFactura", FilterOperator.GreaterThanOrEqual, AdvFacturaDesde.Text, FilterType.String)
                .Add("NFactura", FilterOperator.LessThanOrEqual, AdvFacturaHasta.Text, FilterType.String)
            End If

            If Engine.Length(fwiImpDesde.Text) > 0 AndAlso IsNumeric(fwiImpDesde.Text) Then
                e.Filter.Add(New NumberFilterItem("ImpVencimientoA", FilterOperator.GreaterThanOrEqual, fwiImpDesde.Text))
            End If
            If Engine.Length(fwiImpHasta.Text) > 0 AndAlso IsNumeric(fwiImpHasta.Text) Then
                e.Filter.Add(New NumberFilterItem("ImpVencimientoA", FilterOperator.LessThanOrEqual, fwiImpHasta.Text))
            End If
            .Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
            .Add("FechaVencimiento", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
            .Add("IDFormaPago", FilterOperator.Equal, cbxIDFormaPago.Text, FilterType.String)
            .Add("IDBancoPropio", FilterOperator.Equal, cbxIDBancoPropio.Value, FilterType.String)
            .Add("IDEjercicio", FilterOperator.Equal, cbxIDEjercicio.Text, FilterType.String)
            .Add("IDRemesa", FilterOperator.Equal, AdvIDRemesa.Text, FilterType.Numeric)
            .Add("IDRemesaAnticipo", FilterOperator.Equal, AdvRemesaAnticipo.Text, FilterType.Numeric)
            .Add("Situacion", FilterOperator.Equal, cbxSituacion.Value, FilterType.Numeric)
            .Add("IdTipoCobro", FilterOperator.Equal, cbxIDTipoCobro.Value, FilterType.Numeric)
            .Add("FechaFactura", FilterOperator.GreaterThanOrEqual, cbxFechaFacturaD.Text, FilterType.DateTime)
            .Add("FechaFactura", FilterOperator.LessThanOrEqual, cbxFechaFacturaH.Text, FilterType.DateTime)
            .Add("IdObra", FilterOperator.Equal, AdvIDObra.Value, FilterType.Numeric)
            .Add("FechaCobro", FilterOperator.GreaterThanOrEqual, clbFechaCobroDesde.Value, FilterType.DateTime)
            .Add("FechaCobro", FilterOperator.LessThanOrEqual, clbFechaCobroHasta.Value, FilterType.DateTime)
            .Add("FechaPagare", FilterOperator.GreaterThanOrEqual, clbFechaPagare.Value, FilterType.DateTime)
            .Add("FechaPagare", FilterOperator.LessThanOrEqual, clbFechaPagMax.Value, FilterType.DateTime)
            If Engine.Length(FwiTitulo.Text) > 0 Then
                .Add(New LikeFilterItem("Titulo", FwiTitulo.Text))
            End If

            If cbxContabilizado.Value <> enumContabilizadoTodos.Todos Then    'IDClienteBanco is not Null
                .Add("Contabilizado", FilterOperator.Equal, cbxContabilizado.Value, FilterType.Numeric)
            End If
            If cbxDomiciliado.Value = enumBoolean.Si Then     'IDClienteBanco is not Null
                .Add(New IsNullFilterItem("IDClienteBanco", False))
            End If
            If cbxDomiciliado.Value = enumBoolean.No Then     'IDClienteBanco is not Null
                .Add(New IsNullFilterItem("IDClienteBanco", True))
            End If
            If cbxRemesable.Value <> enumBoolean.Todos And Len(cbxRemesable.Value) > 0 Then
                .Add(New BooleanFilterItem("CobroRemesable", FilterOperator.Equal, CBool(cbxRemesable.Value)))
            End If
            If cbxLiquidado.Value <> enumContabilizadoTodos.Todos Then
                .Add("Liquidado", FilterOperator.Equal, cbxLiquidado.Value, FilterType.Numeric)
            End If
            If cbxRiesgo.Value <> enumBoolean.Todos And Len(cbxRiesgo.Value) > 0 Then  ' Riesgo del estado
                .Add(New BooleanFilterItem("Riesgo", FilterOperator.Equal, CBool(cbxRiesgo.Value)))
            End If
            If cbxEspecial.Value <> enumBoolean.Todos And Len(cbxEspecial.Value) > 0 Then ' Riesgo del estado
                .Add(New BooleanFilterItem("Especial", FilterOperator.Equal, CBool(cbxEspecial.Value)))
            End If

            If cbxFactoring.Value <> enumBoolean.Todos Then
                '.Add(New IsNullFilterItem("Factoring", False))
                .Add(New BooleanFilterItem("Factoring", CBool(cbxFactoring.Value)))
            End If
            If cbxClienteFactoring.Value <> enumBoolean.Todos Then
                '.Add(New IsNullFilterItem("ClienteFactoring", False))
                .Add(New BooleanFilterItem("ClienteFactoring", CBool(cbxFactoring.Value)))
            End If

            .Add("SyncDB", FilterOperator.Equal, cbxEmpresa.Text, FilterType.String)

            If AdvIDClienteCab.Text <> String.Empty Then
                .Add("IDGrupoCliente", FilterOperator.Equal, AdvIDClienteCab.Text, FilterType.String)
            End If

            If cbxManual.Value = enumBoolean.Si Then
                .Add(New NumberFilterItem("IdTipoCobro", FilterOperator.NotEqual, mintTipoCobro))
            ElseIf cbxManual.Value = enumBoolean.No Then
                .Add(New NumberFilterItem("IdTipoCobro", FilterOperator.Equal, mintTipoCobro))
            End If

            If cbxEmpresaGrupo.Value = enumBoolean.Si Then
                .Add("EmpresaGrupo", FilterOperator.Equal, 1, FilterType.Numeric)
            ElseIf cbxEmpresaGrupo.Value = enumBoolean.No Then
                .Add("EmpresaGrupo", FilterOperator.Equal, 0, FilterType.Numeric)
            End If

            .Add("IDContador", FilterOperator.Equal, AdvIDContador.Text, FilterType.String)
            .Add("EstadoAnticipo", FilterOperator.Equal, cboEstadoAnticipo.Value, FilterType.Numeric)

            '.Add("IDProveedor", FilterOperator.Equal, advIDProveedor.Text, FilterType.String)
            '.Add("IDOperario", FilterOperator.Equal, advIDOperario.Text, FilterType.String)
            If cbxComunicadoGestorCobro.Value <> enumBoolean.Todos Then
                .Add(New BooleanFilterItem("ComunicadoGestorCobro", CBool(cbxComunicadoGestorCobro.Value)))
            End If
            .Add("FechaComunicacionGestorCobro", FilterOperator.Equal, cbxFechaComunicacionGestorCobro.Value, FilterType.DateTime)
        End With
    End Sub

    Protected Overridable Sub CICobroCont_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles Me.QueryExecuted
        Me.txtTotal.Value = Grid.GetTotal(Grid.Columns("ImpVencimientoA"), AggregateFunction.Sum)
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)

        ReDim Me.mIDCobros(-1)
        mSituacion = Nothing
        InitFilterCriteria()
        cbxFechaDesde.TextBox.Clear()
        cbxFechaHasta.TextBox.Clear()
        cbxFechaFacturaD.TextBox.Clear()
        cbxFechaFacturaH.TextBox.Clear()
    End Sub

#End Region

    Protected Overridable Sub QuitarMarcas()
        If Me.ShowAllCheckedItems.IsChecked Then Me.ShowAllCheckedItems.InvokeOnClick()
        Me.UnCheckAllRecords()
        Me.DeleteServerChecks()
        Me.Execute()
        Me.txtTotalMarcado.Value = 0
        If Length(mobjGuid.ToString) > 0 Then DesmarcarRegistro(mobjGuid, FilterType.Numeric)
        If Length(mIDProcess.ToString) > 0 Then DesmarcarRegistro(mIDProcess, FilterType.Numeric)
    End Sub

    Protected Overridable Sub CICobroCont_RecordChecked(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.CheckedEventArgs) Handles MyBase.RecordChecked
        'If e.CheckState = CheckStates.Checked Then
        '    dblTotalMarcado = dblTotalMarcado + e.Row.Cells("ImpVencimientoA").Value()
        'Else
        '    dblTotalMarcado = dblTotalMarcado - e.Row.Cells("ImpVencimientoA").Value()
        'End If
        Dim dblTotalMarcado As Double = Nz(Me.CheckedRecords.Compute("SUM(ImpVencimientoA)", Nothing), 0)
        txtTotalMarcado.Value = dblTotalMarcado
    End Sub

#Region " Grid "

    'Protected Overridable Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
    '    Select Case e.Column.Key
    '        Case "IDClienteBanco"
    '            ActualizarMandato(Grid.Value("IDCliente") & String.Empty, Nz(e.Value, 0), Nz(Grid.Value("IDClienteBanco"), 0))
    '    End Select
    'End Sub

    'Private Sub ActualizarMandato(ByVal IDCliente As String, ByVal IDClienteBanco As Integer, ByVal IDClienteBancoOld As Integer)
    '    If Length(IDCliente) > 0 AndAlso IDClienteBanco <> 0 Then
    '        ActualizarMandatoFactura(IDCliente, IDClienteBanco, IDClienteBancoOld)
    '    End If
    'End Sub

    'Private Sub ActualizarMandatoFactura(ByVal IDCliente As String, ByVal IDClienteBanco As Integer, ByVal IDClienteBancoOld As Integer)
    '    Dim blnNoMandato As Boolean
    '    Dim f As New Filter
    '    f.Add(New BooleanFilterItem("Predeterminado", True))
    '    f.Add(New NumberFilterItem("IDClienteBanco", IDClienteBanco))
    '    f.Add(New StringFilterItem("IDCliente", IDCliente))
    '    Dim dtMandatoPred As DataTable = New BE.DataEngine().Filter("tbMaestroMandato", f)
    '    If dtMandatoPred.Rows.Count > 0 Then
    '        If Nz(dtMandatoPred.Rows(0)("IDMandato"), 0) <> Nz(Grid.Value("IDMandato"), 0) Then
    '            If ExpertisApp.GenerateMessage("La Modificación del Banco del Cliente actualizará la información del Mandato ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '                If Nz(dtMandatoPred.Rows(0)("IDMandato"), 0) <> 0 Then
    '                    Grid.Value("IDMandato") = dtMandatoPred.Rows(0)("IDMandato")
    '                Else
    '                    blnNoMandato = True
    '                End If
    '            Else
    '                Grid.Value("IDClienteBanco") = IDClienteBancoOld
    '            End If
    '        End If
    '    Else
    '        blnNoMandato = True
    '    End If

    '    If blnNoMandato Then
    '        If ExpertisApp.GenerateMessage("El Banco del Cliente seleccionado no tiene un Mandato asociado ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '            Grid.Value("IDMandato") = System.DBNull.Value
    '        Else
    '            Grid.Value("IDClienteBanco") = IDClienteBancoOld
    '        End If
    '    End If
    'End Sub

    Protected Overridable Sub Grid_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "NMandato"
                If Length(Grid.Value("IDCliente")) > 0 Then
                    e.Filter.Add(New StringFilterItem("IDCliente", Grid.Value("IDCliente")))
                End If
                If Nz(Grid.Value("IDClienteBanco"), 0) <> 0 Then
                    e.Filter.Add(New NumberFilterItem("IDClienteBanco", Grid.Value("IDClienteBanco")))
                End If
                If Length(Grid.Value("IDFormaPago")) = 0 OrElse Not Nz(Grid.Value("CobroRemesable"), False) Then
                    e.Filter.Add(New NoRowsFilterItem)
                End If
                e.Filter.Add(New BooleanFilterItem("Caducado", False))
                e.Filter.Add(New NumberFilterItem("Estado", CInt(Business.SEPA.BusinessEnum.MandatoEstado.Aceptado)))
        End Select
    End Sub


    Protected Overridable Sub grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        With Grid
            Select Case e.Column.Key
                Case "IDAgrupacion"
                    .Columns("IDAgrupacion").EditType = Janus.Windows.GridEX.EditType.TextBox
                    .Columns("IDAgrupacion").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Ellipsis
                    mblnNoEditable = True
                Case "Permiso"
                    .Columns("Permiso").EditType = Janus.Windows.GridEX.EditType.CheckBox
                    mblnNoEditable = True
                Case "FechaANegociar"
                    .Columns("FechaANegociar").EditType = Janus.Windows.GridEX.EditType.CalendarDropDown
                    mblnNoEditable = True
                Case "EstadoAnticipo", "Situacion"
                    e.Cancel = True
                Case "Contabilizado", "Liquidado", "RecibidoEfecto"
                    e.Cancel = True
                Case Else
                    If e.Column.Key <> "IDCheque" AndAlso e.Column.Key <> "IDTarjeta" AndAlso e.Column.Key <> "NMandato" AndAlso e.Column.Key <> "Expertis.Check" Then
                        e.Cancel = True
                    End If
                    If e.Column.Key = "IDCheque" OrElse e.Column.Key = "IDTarjeta" Then
                        If Grid.Value("Contabilizado") <> enumContabilizado.NoContabilizado Then
                            e.Cancel = True
                            e.Column.ButtonStyle = ButtonStyle.NoButton
                        Else
                            e.Column.ButtonStyle = ButtonStyle.Image
                        End If
                    End If
                    If e.Column.Key = "IDCheque" AndAlso Not Nz(Grid.Value("ChequeTalon"), False) Then
                        e.Cancel = True
                        e.Column.ButtonStyle = ButtonStyle.NoButton
                    End If
                    If e.Column.Key = "IDTarjeta" AndAlso Not Nz(Grid.Value("Tarjeta"), False) Then
                        e.Cancel = True
                        e.Column.ButtonStyle = ButtonStyle.NoButton
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If e.Row.Cells("Contabilizado").Value <> enumContabilizado.NoContabilizado Then
                e.Row.RowStyle = Grid.FormatStyles("ContabilizadoFormatStyle")
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.Contabilizado
            Else
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.NoContabilizado
            End If
        End If
    End Sub

    Protected Overridable Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(Grid) AndAlso Grid.RowCount > 0 Then
                Grid.UiCommandManager1.Commands(cnABRIRFACTURAVENTA).Visible = InheritableBoolean.False
                Grid.UiCommandManager1.Commands(cnABRIROBRA).Visible = InheritableBoolean.False
                Grid.UiCommandManager1.Commands(cnABRIRREMESA).Visible = InheritableBoolean.False
                Grid.UiCommandManager1.Commands(cnABRIRANTICIPO).Visible = InheritableBoolean.False

                If Engine.Length(Grid.Value("IDFactura")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIRFACTURAVENTA).Visible = InheritableBoolean.True
                End If
                If Engine.Length(Grid.Value("IDObra")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIROBRA).Visible = InheritableBoolean.True
                End If
                If Engine.Length(Grid.Value("IDRemesa")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIRREMESA).Visible = InheritableBoolean.True
                End If
                If Engine.Length(Grid.Value("IDRemesaAnticipo")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIRANTICIPO).Visible = InheritableBoolean.True
                End If

                Grid.UiCommandManager1.Commands(cnGESTION_CHEQUE).IsVisible = Nz(Grid.Value("ChequeTalon"), False)
                Grid.UiCommandManager1.Commands(cnGESTION_TARJETA).IsVisible = Nz(Grid.Value("Tarjeta"), False)

                If Length(Grid.Value("IDMandato")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIR_MANDATO).Visible = InheritableBoolean.True
                Else
                    Grid.UiCommandManager1.Commands(cnABRIR_MANDATO).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

#End Region

    Protected Overridable Sub AdvIDContador_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDContador.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("Entidad", FilterOperator.Equal, cnEntidad))
    End Sub

    Protected Overridable Sub cbxFechaDesde_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFechaDesde.Validated
        If Engine.Length(cbxFechaDesde.Value) > 0 Then cbxFechaHasta.Value = cbxFechaDesde.Value
    End Sub

    Protected Overridable Sub AdvFacturaDesde_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvFacturaDesde.Validated
        AdvFacturaHasta.Value = AdvFacturaDesde.Value
        AdvFacturaHasta.Text = AdvFacturaDesde.Text
    End Sub

    Protected Overridable Sub cbxIDTipoCobro_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxIDTipoCobro.Validated
        If Engine.Length(cbxIDTipoCobro.Value) > 0 Then
            Dim dtTipoCobro As DataTable = New TipoCobro().SelOnPrimaryKey(cbxIDTipoCobro.Value)
            If Not dtTipoCobro Is Nothing AndAlso dtTipoCobro.Rows.Count > 0 Then
                If dtTipoCobro.Rows(0)("Especial") Then
                    cbxEspecial.Value = enumBoolean.Si
                Else
                    cbxEspecial.Value = enumBoolean.No
                End If
            End If
        End If
    End Sub

    Protected Overridable Sub cbxRiesgo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxRiesgo.Validated
        If Engine.Length(cbxRiesgo.Value) = 0 Then cbxRiesgo.Value = enumBoolean.Todos
    End Sub

    Protected Overridable Sub cbxRemesable_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxRemesable.Validated
        If Engine.Length(cbxRemesable.Value) = 0 Then cbxRemesable.Value = enumBoolean.Todos
    End Sub

    Protected Overridable Sub cbxManual_DropDownHide(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ComboDropDownHideEventArgs) Handles cbxManual.DropDownHide
        If Engine.Length(cbxManual.Value) = 0 Then cbxManual.Value = enumBoolean.Todos
    End Sub

    Protected Overridable Sub cbxLiquidado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLiquidado.Validated
        If Engine.Length(cbxLiquidado.Value) = 0 Then cbxLiquidado.Value = enumContabilizadoTodos.Todos
    End Sub

    Protected Overridable Sub cbxEmpresaGrupo_DropDownHide(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ComboDropDownHideEventArgs) Handles cbxEmpresaGrupo.DropDownHide
        If Engine.Length(cbxEmpresa.Value) = 0 Then cbxEmpresa.Value = enumBoolean.Todos
    End Sub

    Protected Overridable Sub cbxFechaFacturaD_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFechaFacturaD.Validated
        cbxFechaFacturaH.Value = cbxFechaFacturaD.Value
    End Sub

    Protected Overridable Sub cbxDomiciliado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDomiciliado.Validated
        If cbxDomiciliado.Value & vbNullString = vbNullString Then
            cbxDomiciliado.Value = enumBoolean.Todos
        End If
    End Sub

    Protected Overridable Sub cbxContabilizado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxContabilizado.Validated
        If Engine.Length(cbxContabilizado.Value) = 0 Then cbxContabilizado.Value = enumBoolean.Todos
    End Sub

    Protected Overridable Sub AdvIDCliente_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDCliente.SelectionChanged
        GetSaldoCliente()
    End Sub

    Protected Overridable Sub AdvIDCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvIDCliente.Validated
        If Engine.Length(AdvIDCliente.Text) = 0 Then
            txtSaldoCContable.Value = DBNull.Value
            txtCContable.Text = String.Empty
            txtSaldoCContable.ForeColor = Color.Black
        End If
    End Sub

    Protected Overridable Sub cbxIDEjercicio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxIDEjercicio.Validated
        GetSaldoCliente()
    End Sub

    Protected Overridable Sub GetSaldoCliente()
        txtSaldoCContable.Value = DBNull.Value
        txtCContable.Text = String.Empty
        txtSaldoCContable.ForeColor = Color.Black

        If Length(AdvIDCliente.Text) > 0 AndAlso mblnContabilidad Then
            Dim drCliente As DataRow = AdvIDCliente.SelectedRow()
            If Not drCliente Is Nothing AndAlso Engine.Length(drCliente("CCCliente")) > 0 Then
                Dim datos As New DiarioContable.DataCuentaSaldo
                datos.IDEjercicio = cbxIDEjercicio.Value
                Dim f As New Filter
                f.Add(New StringFilterItem("IDCContable", drCliente("CCCliente")))
                datos.Filtro = f
                Dim dtSaldo As DataTable = ExpertisApp.ExecuteTask(Of DiarioContable.DataCuentaSaldo, DataTable)(AddressOf DiarioContable.CuentaSaldo, datos)
                If Not dtSaldo Is Nothing AndAlso dtSaldo.Rows.Count > 0 Then
                    If dtSaldo.Rows(0)("SaldoA") < 0 Then
                        txtSaldoCContable.ForeColor = Color.Red
                    End If
                    txtSaldoCContable.Value = dtSaldo.Rows(0)("SaldoA")
                End If

                txtCContable.Text = drCliente("CCCliente") & String.Empty
            End If
        End If
    End Sub

#Region " Informes "

    Protected cnDATABASEALIAS_IMPRIMIR_RECIBO As String = "IRECIBO"
    Protected cnDATABASEALIAS_RIESGO_CLIENTE As String = "RIESGOCLTE"
    Protected cnDATABASEALIAS_COBROS_PEND_REP As String = "COBROPENDREP"
    Protected cnDATABASEALIAS_COBROS_PEND_CAR As String = "COBROPENDCARTERA"
    Protected cnDATABASEALIAS_CARTERA_CLTE As String = "LCARTERACLTE"
    Protected cnDATABASEALIAS_COBROS_PEND_CLTE As String = "COBROPENDCLTE"
    Protected cnDATABASEALIAS_RESUMEN_CARTERA_CLIENTE As String = "RCARTERACLTE"
    Protected cnDATABASEALIAS_RESUMEN_CARTERA As String = "RCARTERA"
    Protected mobjGuid As Guid
    Protected mblnDesmarcar As Boolean
    Protected mstrIDRepresentante As String

    Protected Overridable Sub CICobroCont_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Select Case e.Alias
            Case cnDATABASEALIAS_IMPRIMIR_RECIBO
                Dim objNegMoneda As New Moneda
                e.Formulas("AbreviaturaMonedaA").Text = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate).Abreviatura
                e.Formulas("DescMonedaA").Text = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate).Texto
                e.Formulas("NDecimalesMonedaA").Text = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate).NDecimalesImporte

                If Grid.CheckedRecordsCount > 0 Then
                    Dim objFilter As New Filter
                    objFilter.Clear()
                    objFilter.Add(New BooleanFilterItem("CobroImprimible", False))
                    Dim dvChecked As DataView = New DataView(Grid.CheckedRecords, objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.CurrentRows)
                    If dvChecked.Count > 0 Then
                        e.Cancel = True
                        ExpertisApp.GenerateMessage("Ha seleccionado Cobros cuya forma de pago asociada no permite generar recibo.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        objFilter.Clear()
                        objFilter.Add(New BooleanFilterItem("Impreso", True))
                        Dim dvImpresos As DataView = New DataView(Grid.CheckedRecords, objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.CurrentRows)
                        If dvImpresos.Count > 0 Then
                            If ExpertisApp.GenerateMessage("!Advertencia! Ha seleccionado Cobros ya impresos. ¿Desea Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                                e.Cancel = True
                                Exit Sub
                            End If
                        End If

                        '//Marcamos los cobros como impresos
                        'Dim objNegCobro As New Cobro
                        'objNegCobro.CobroImpreso(Grid.CheckedRecords, True)
                        Dim IDCobros(-1) As Object
                        For Each c As DataRow In Grid.CheckedRecords.Rows
                            ReDim Preserve IDCobros(IDCobros.Length)
                            IDCobros(IDCobros.Length - 1) = c("IDCobro")
                        Next
                        Dim datos As New Cobro.DataActualizarCobrosImpresos
                        datos.IDCobros = IDCobros
                        datos.Impreso = True
                        ExpertisApp.ExecuteTask(Of Cobro.DataActualizarCobrosImpresos)(AddressOf Cobro.ActualizarCobrosImpresos, datos)
                        Grid.UnCheckAllRecords()
                        Me.Execute()
                    End If
                Else
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Debe seleccionar algún registro.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case "INFLEAS"
                e.Formulas("Fecha").Text = Today.Date
            Case "PMC"
                Dim FrmFecha As New FrmFechaInforme
                If FrmFecha.ShowDialog = DialogResult.OK Then
                    DtFechaInforme = FrmFecha.FechaInforme
                    e.Formulas("Fecha").Text = DtFechaInforme
                Else
                    e.Cancel = True
                End If
            Case cnDATABASEALIAS_RIESGO_CLIENTE, cnDATABASEALIAS_COBROS_PEND_CAR, cnDATABASEALIAS_CARTERA_CLTE, cnDATABASEALIAS_COBROS_PEND_CLTE
                e.Formulas("Enterprise").Text = ExpertisApp.EnterpriseName
            Case cnDATABASEALIAS_COBROS_PEND_REP
                e.Formulas("Enterprise").Text = ExpertisApp.EnterpriseName
                Dim frmRep As New FrmRepresentante
                Dim Result As System.Windows.Forms.DialogResult
                Result = frmRep.ShowDialog()
                If Result = DialogResult.OK Then
                    mstrIDRepresentante = frmRep.Representante & String.Empty
                Else
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Se ha cancelado la impresión del documento.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case cnDATABASEALIAS_RESUMEN_CARTERA_CLIENTE, cnDATABASEALIAS_RESUMEN_CARTERA
                If Grid.DataRowCount = 0 Then
                    ExpertisApp.GenerateMessage("No existen datos para sacar el informe. Lance primero la consulta.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    e.Cancel = True
                End If
        End Select
    End Sub

    Protected Overridable Sub CICobroCont_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        Select Case e.Alias
            Case "INFLEAS"
                e.Filter.Clear()
                e.Filter.Add("FechaFin", FilterOperator.GreaterThanOrEqual, Today.Date, FilterType.DateTime)

            Case "PMC"
                e.Filter.Clear()
                e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, DtFechaInforme, FilterType.DateTime)
            Case cnDATABASEALIAS_COBROS_PEND_REP
                If Engine.Length(mstrIDRepresentante & String.Empty) > 0 Then
                    e.Filter.Add("IDRepresentante", FilterOperator.Equal, mstrIDRepresentante, FilterType.String)
                End If
        End Select
    End Sub

    Protected Overridable Sub CICobroCont_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        Select Case e.Alias
            Case "IRECIBOP"
                If Grid.CheckedRecordsCount > 0 Then
                    e.DataSource = CargarDTRecibo()
                Else
                    ExpertisApp.GenerateMessage("Debe tener marcado algún registro.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    e.Cancel = True
                End If
        End Select
    End Sub

    Protected Overridable Function CargarDTRecibo() As DataTable
        Dim objcobro As New Cobro
        Dim dt As DataTable = Grid.CheckedRecords()
        Dim dtDestino As DataTable = CrearDTRecibo()
        Dim objClte As New Cliente
        Dim strIdioma As String
        For Each dr As DataRow In dt.Rows()
            Dim drAlta As DataRow = dtDestino.NewRow
            drAlta("IDCobro") = dr("IDCobro")
            drAlta("NFactura") = dr("NFactura")
            drAlta("ImpVencimientoA") = Math.Round(dr("ImpVencimientoA"), 2)
            strIdioma = ExpertisApp.ExecuteTask(Of String, String)(AddressOf Cliente.Idioma, dr("IDCliente") & String.Empty)
            drAlta("IDIdioma") = strIdioma
            drAlta("TextoNumero") = ObtenerTextoNumero(dr("impVencimientoA"), strIdioma)
            drAlta("FechaImpresion") = Today.Day.ToString & " DE " & UCase(MesTexto(Today.Month, strIdioma)) & " DE " & Today.Year.ToString
            If Engine.Length(dr("IDDireccion") & String.Empty) > 0 Then
                Dim objClteDir As New ClienteDireccion
                Dim dtDir As DataTable = objClteDir.SelOnPrimaryKey(dr("IDDireccion"))
                If Not dtDir Is Nothing AndAlso dtDir.Rows.Count > 0 Then
                    drAlta("RazonSocial") = dtDir.Rows(0)("RazonSocial")
                    drAlta("Direccion") = dtDir.Rows(0)("Direccion")
                    drAlta("CodPostal") = dtDir.Rows(0)("CodPostal")
                    drAlta("Poblacion") = dtDir.Rows(0)("Poblacion")
                    drAlta("Provincia") = dtDir.Rows(0)("Provincia")
                End If
            End If
            dtDestino.Rows.Add(drAlta)
        Next
        Return dtDestino
    End Function

#End Region

#Region " FACTORING "

    Protected Overridable Sub ContabilizacionFactoring(ByVal IDProcess As Guid, ByVal blnGenerarFichero As Boolean, ByVal blnGenerarAsiento As Boolean, ByVal blnCambioSituacion As Boolean, ByVal dblImporteBanco As Double, ByVal dblComision As Double)
        ExpertisApp.GenerateMessage("No se van a tener en cuenta los abonos de facturas.", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If Not IsNothing(Grid.CheckedRecords) AndAlso Grid.CheckedRecordsCount > 0 Then
            '//Comprobamos si hay cobros que no sean de Factoring o no sean de una fatura. Esto no se podrán contabilizar por Factoring.
            Dim objFilter As New Filter(FilterUnionOperator.Or)
            objFilter.Add(New BooleanFilterItem("Factoring", False))
            objFilter.Add(New IsNullFilterItem("IDFactura"))
            Dim dtFactorizar As DataTable = Grid.CheckedRecords
            Dim dvNoFactoring As DataView = New DataView(dtFactorizar, objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.CurrentRows)
            If Not IsNothing(dvNoFactoring) AndAlso dvNoFactoring.Count > 0 Then
                ExpertisApp.GenerateMessage("Hay Cobros cuya Forma de Pago no es Factoring o que no corresponden a una Factura.{0}" & _
                "Dichos Cobros no serán contabilizados.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
            End If

            '//Nos quedamos con los cobros que sí se pueden contabilizar por Factoring.
            objFilter.Clear()
            objFilter.Add(New BooleanFilterItem("Factoring", True))
            objFilter.Add(New IsNullFilterItem("IDFactura", False))
            dtFactorizar.DefaultView.RowFilter = objFilter.Compose(New AdoFilterComposer)

            If IsNothing(dtFactorizar.DefaultView) OrElse dtFactorizar.DefaultView.Count = 0 Then
                ExpertisApp.GenerateMessage("No hay Cobros seleccionados para la Contabilización de tipo Factoring.|" & _
                                "(Forma de Pago es Factoring o que corresponden a una Factura)|" & _
                                "Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine, vbNewLine)
                QuitarMarcas()
                Exit Sub
            Else
                Cursor.Current = Cursors.WaitCursor

                Dim objNegBP As New BancoPropio
                Dim infoBP As BancoPropio.BancoPropioFactoringInfo
                infoBP = BancoPropio.BancoFactoringInfo(mstrIDBancoPropio)
                If Not IsNothing(infoBP) Then
                    Dim objNegCobro As New Cobro
                    '//Código para establecer el contador nFactoring de los cobros seleccionados
                    Dim blnCancelar As Boolean
                    Dim strNFactoring As String = String.Empty
                    If blnGenerarFichero Then
                        '//Establezco el NFactoring si se necesitase. Sólo se necesita para el fichero de BSCH.
                        '//Sólo se pone el NFactoring en los cobros cuando se genera el fichero.
                        If Engine.Length(infoBP.IDContadorFactoring & String.Empty) > 0 Then
                            Dim objNegContador As New Contador
                            strNFactoring = ExpertisApp.ExecuteTask(Of String, String)(AddressOf Contador.CounterValueID, infoBP.IDContadorFactoring)
                            objNegContador = Nothing
                        End If

                        '//Si ha habido problemas al generar el fichero, no generaremos el asiento si se ha solicitado.
                        blnCancelar = Not GenerarFicheroFactoring(IDProcess.ToString, strNFactoring, infoBP, dtFactorizar.DefaultView)

                        If blnCancelar Then
                            QuitarMarcas()
                        Else
                            '//Si ha generado Ok el fichero y no hay que generar el asiento, debemos asignar el banco y la situación nueva 
                            '//a los cobros pero no cambiar el campo de contabilizado.
                            Dim ActFact As New Cobro.DataActualizarFactoring
                            ActFact.IDProcess = IDProcess
                            ActFact.NFactoring = strNFactoring
                            ActFact.NuevaSituacion = lngNuevaSituacion
                            ActFact.IDBancoPropio = mstrIDBancoPropio
                            ExpertisApp.ExecuteTask(Of Cobro.DataActualizarFactoring)(AddressOf Cobro.ActualizarContadorFactoring, ActFact)
                            ExpertisApp.ExecuteTask(Of Cobro.DataActualizarFactoring)(AddressOf Cobro.ActualizarSituacionFactoring, ActFact)
                        End If
                    End If

                    If blnGenerarAsiento AndAlso Not blnCancelar Then
                        '//GENERAR ASIENTO
                        Dim dtChecked As DataTable = Me.CheckedRecords
                        If IsNothing(objFilter) Then objFilter = New Filter
                        objFilter.Clear()
                        objFilter.Add(New BooleanFilterItem("Contabilizado", True))
                        Dim dvContabilizados As DataView = New DataView(dtChecked, objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.CurrentRows)
                        If Not IsNothing(dvContabilizados) AndAlso dvContabilizados.Count > 0 Then
                            ExpertisApp.GenerateMessage("Existen cobros seleccionadas contabilizados que no intervendrán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If


                        Dim SimInfo As New DataSimulacionContableInfoCobro
                        SimInfo.IDEjercicio = mstrEjercicioActual
                        SimInfo.GuidSimulacion = IDProcess
                        SimInfo.FechaApunte = dtFechaApunte
                        SimInfo.CambioSituacion = blnCambioSituacion
                        SimInfo.NuevaSituacionCobro = lngNuevaSituacion
                        SimInfo.AgruparPorBanco = mblnAgruparBanco
                        SimInfo.IDBancoPropio = mstrIDBancoPropio
                        SimInfo.DescApunte = mstrDescApunte
                        SimInfo.Caption = "Simulación Contable - COBROS (FACTORING) -"
                        SimInfo.FechaValor = mdtFechaValor
                        SimInfo.NDocumento = mstrNDocumento
                        SimInfo.ImporteBanco = dblImporteBanco
                        SimInfo.Comision = dblComision
                        SimInfo.Factoring = True

                        Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCont", , SimInfo, Me)
                        AddHandler oFrm.Closed, AddressOf FrmActionClosed

                        If oFrm.DialogResult = DialogResult.OK Then
                            '//Caso en el que se hace SOLO la Contabilización.
                            If Not blnGenerarFichero Then
                                Dim ActFact As New Cobro.DataActualizarFactoring
                                ActFact.IDProcess = IDProcess
                                ActFact.NFactoring = strNFactoring
                                ActFact.NuevaSituacion = lngNuevaSituacion
                                ActFact.IDBancoPropio = mstrIDBancoPropio
                                ExpertisApp.ExecuteTask(Of Cobro.DataActualizarFactoring)(AddressOf Cobro.ActualizarSituacionFactoring, ActFact)
                            End If
                        End If
                    Else
                        '//Si no realizamos la contablización, quitaremos las marcas.
                        QuitarMarcas()
                    End If
                End If
                Cursor.Current = Cursors.Default
            End If
        End If
    End Sub

    Protected Overridable Function GenerarFicheroFactoring(ByVal strIDProcess As String, ByVal strNFactoring As String, ByVal infoBP As BancoPropio.BancoPropioFactoringInfo, ByVal dvFactoring As DataView) As Boolean
        GenerarFicheroFactoring = False
        If Not IsNothing(dvFactoring) AndAlso dvFactoring.Count > 0 Then
            If Not IsNothing(infoBP) Then
                Dim blnFicheroExcel As Boolean
                '//Generamos los ficheros
                Dim objNegModeloFactoring As New ModeloFactoring
                Dim dtSourceFichero As DataTable
                Select Case infoBP.TipoFactoring & String.Empty
                    Case ModeloFactoring.FACTORING_BBVA               '//EXCEL
                        blnFicheroExcel = True
                        GenerarFicheroFactoring = GenerarFicheroExcelFactoring_Generico(strIDProcess)
                        dtSourceFichero = Nothing
                    Case ModeloFactoring.FACTORING_BANCO_POPULAR      '//EXCEL
                        blnFicheroExcel = True
                        GenerarFicheroFactoring = GenerarFicheroExcelFactoring_BancoPopular(strIDProcess, infoBP.IDClienteFactoring & String.Empty)
                        dtSourceFichero = Nothing
                    Case ModeloFactoring.FACTORING_BSCH, ModeloFactoring.FACTORING_BANCO_SABADELL, ModeloFactoring.FACTORING_CAJA_MADRID, ModeloFactoring.FACTORING_BANESTO
                        blnFicheroExcel = False
                        Try
                            If Engine.Length(strNFactoring) > 0 Then
                                '//Estos tipos de Factoring, devuelven un DataTable con las líneas del fichero.
                                dtSourceFichero = objNegModeloFactoring.ExportacionFicheroFactoring(strIDProcess, strNFactoring, infoBP)
                            Else
                                dtSourceFichero = Nothing
                                ExpertisApp.GenerateMessage("No se ha indicado un contador para el Factoring.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Function
                            End If
                        Catch ex As Exception
                            dtSourceFichero = Nothing
                            GenerarFicheroFactoring = False
                            ExpertisApp.GenerateMessage(ex.Message & Chr(10) & "No se ha generado el fichero.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                    Case Else                                                '//EXCEL
                        blnFicheroExcel = True
                        GenerarFicheroFactoring = GenerarFicheroExcelFactoring_Generico(strIDProcess)
                        dtSourceFichero = Nothing
                End Select
                objNegModeloFactoring = Nothing

                If Not IsNothing(dtSourceFichero) AndAlso dtSourceFichero.Rows.Count > 0 Then
                    '//Factoring de Ficheros no Excel.
                    Dim objInfo As New _GuardarFicheroInfo
                    objInfo = GuardarFichero(dtSourceFichero)
                    If objInfo.GuardarFicheroOK AndAlso IsNothing(objInfo.MensajeError) Then
                        '//13096: Fichero generado con éxito.
                        ExpertisApp.GenerateMessage("Fichero generado con éxito.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    '//Se comprueba si es correcto con esta condición por el caso en el que, se ha puesado cancelar en 
                    '//el cuadro de dialogo de salvar fichero.
                    GenerarFicheroFactoring = (objInfo.GuardarFicheroOK AndAlso IsNothing(objInfo.MensajeError))
                End If
            End If
        End If
    End Function

    Protected Class _GuardarFicheroInfo
        Public GuardarFicheroOK As Boolean
        Public MensajeError As String
    End Class

#Region " Generación Ficheros EXCEL "

    '//El resto de generaciones de ficheros que NO precisan Excel están en Negocio.

    Protected Overridable Function GenerarFicheroExcelFactoring_Generico(ByVal strIDProcess As String) As Boolean
        Const FILA_EXCEL_CABECERA As Integer = 1
        Const FILA_EXCEL_INICIO_DATOS As Integer = 2
        'Dim FORMATO_FECHA As String = "yyyy/MM/dd"      '//No es Const, xq al hacer el Format da problemas.
        Const FORMATO_NUMERICO As String = "#.##0,00"
        Const FORMATO_STRING As String = "@"

        GenerarFicheroExcelFactoring_Generico = True
        Dim objFilter As New Filter
        objFilter.Clear()
        objFilter.Add(New StringFilterItem("IDProcess", FilterOperator.Equal, strIDProcess))
        objFilter.Add(New NumberFilterItem("ImpVencimiento", FilterOperator.GreaterThan, 0))

        Dim BEDataEngine As New BE.DataEngine
        Dim dtExportacion As DataTable = BEDataEngine.Filter("FicheroFactoringExportExcel", objFilter)
        If Not IsNothing(dtExportacion) AndAlso dtExportacion.Rows.Count > 0 Then
            Dim xlsApp As New Object
            Dim xlsWrkBook As New Object
            Dim xlsSheet As New Object

            If CrearAplicacionExcel(xlsApp, xlsWrkBook, xlsSheet) Then
                Try
                    '//////////////////////////  RELLENAMOS LAS CELDAS  ///////////////////////////
                    '//Creamos la cabecera con los nombres de los campos de la exportación.
                    For col As Integer = 1 To dtExportacion.Columns.Count
                        If dtExportacion.Columns(col - 1).ColumnName <> "IDProcess" AndAlso dtExportacion.Columns(col - 1).ColumnName <> "IDEnlace" Then xlsSheet.Cells(FILA_EXCEL_CABECERA, col) = dtExportacion.Columns(col - 1).ColumnName
                    Next col

                    '//Escribimos en la hoja Excel los datos
                    Dim row As Integer = FILA_EXCEL_INICIO_DATOS
                    For Each drRowExportacion As DataRow In dtExportacion.Rows
                        For col As Integer = 1 To dtExportacion.Columns.Count
                            Select Case dtExportacion.Columns(col - 1).ColumnName
                                Case "FechaFactura", "FechaVencimientoFactura"
                                    xlsSheet.Cells(row, col) = drRowExportacion(dtExportacion.Columns(col - 1).ColumnName)
                                    'CType(xlsSheet.Cells(row, col), Excel.Range).NumberFormat = FORMATO_FECHA
                                Case "ImporteFactura", "ImpVencimiento"
                                    xlsSheet.Cells(row, col).NumberFormat = FORMATO_NUMERICO
                                    xlsSheet.Cells(row, col) = drRowExportacion(dtExportacion.Columns(col - 1).ColumnName)
                                Case "IDProcess", "IDEnlace"
                                    '//Con estos campos no hacemos nada. No los pasamos al fichero
                                Case Else
                                    '//Se fuerza a que los campos texto tengan formato texto. Hay que poner el formato antes de pasarle el valor.
                                    If dtExportacion.Columns(col - 1).DataType Is GetType(String) Then
                                        xlsSheet.Cells(row, col).NumberFormat = FORMATO_STRING
                                    End If
                                    xlsSheet.Cells(row, col) = drRowExportacion(dtExportacion.Columns(col - 1).ColumnName)
                            End Select
                        Next col
                        row = row + 1
                    Next drRowExportacion

                    '//Mostramos el cuadro de diálogo de Guardar Fichero.
                    Dim strPath As String = DialogoSaveAsExcel()

                    If Engine.Length(strPath) > 0 Then
                        '//Guardamos el archivo excel
                        If GuardarAplicacionExcel(strPath, xlsApp, xlsWrkBook, xlsSheet) Then
                            '//13096: Fichero generado con éxito.
                            ExpertisApp.GenerateMessage("Fichero generado con éxito.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        GenerarFicheroExcelFactoring_Generico = False
                    End If

                Catch ex As Exception
                    GenerarFicheroExcelFactoring_Generico = False
                    'MessageBox.Show(ERROR_GENERACION_FICHERO & Chr(13) & ex.Message, ExpertisApp.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                GenerarFicheroExcelFactoring_Generico = False
                ExpertisApp.GenerateMessage("Ha ocurrido un error al crear la aplicación Excel.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            GenerarFicheroExcelFactoring_Generico = False
            ExpertisApp.GenerateMessage("No hay registros a procesar.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Protected Overridable Function GenerarFicheroExcelFactoring_BancoPopular(ByVal strIDProcess As String, ByVal strClienteFactoring As String) As Boolean
        '//Constantes de filas y columnas
        Const FILA_EXCEL_CABECERA As Integer = 1
        Const FILA_EXCEL_INICIO_DATOS As Integer = 2
        Const COLUMNA_TIPO_REGISTRO As Integer = 1
        Const COLUMNA_SUBTIPO As Integer = 2
        Const COLUMNA_CABECERA_CLIENTE_FACTORING As Integer = 3
        Const COLUMNA_CABECERA_FECHA As Integer = 4
        Const COLUMNA_CABECERA_MONEDA As Integer = 5
        Const COLUMNA_IMPORTE_TOTAL As Integer = 8
        Const COLUMNA_TIPO_PRODUCTO As Integer = 4
        Const COLUMNA_FECHA_FACTURA As Integer = 6
        Const COLUMNA_NFACTURA As Integer = 7
        Const COLUMNA_FECHA_VENCIMIENTO_FACTURA As Integer = 9
        Const COLUMNA_COND_VENTA_FACTORING As Integer = 5
        Const COLUMNA_IMPORTE_FACTURA As Integer = 8

        '//Constantes de formatos
        'Const FORMATO_FECHA As String = "yyyy/MM/dd"
        Const FORMATO_NUMERICO As String = "#.##0,00"
        Const FORMATO_STRING As String = "@"


        '//Constantes de Tipos de Registros del fichero
        Const CODIGO_REGISTRO_CABECERA As String = "1"
        Const CODIGO_REGISTRO_DETALLE_FACTURA As String = "2"
        Const CODIGO_REGISTRO_TOTALES As String = "3"

        '//Otros
        Const CODIGO_COMPRADOR As String = "888"
        Const CODIGO_TIPO_PRODUCTO As String = "F"          '// F = Factoring
        Const CODIGO_COND_VENTA_FACTORING As String = "T"   '// T = Trasferencia

        GenerarFicheroExcelFactoring_BancoPopular = True

        Dim objFilter As New Filter
        objFilter.Clear()
        objFilter.Add(New StringFilterItem("IDProcess", FilterOperator.Equal, strIDProcess))
        objFilter.Add(New NumberFilterItem("ImpVencimiento", FilterOperator.GreaterThan, 0))

        Dim BEDataEngine As New BE.DataEngine
        Dim dtExportacion As DataTable = BEDataEngine.Filter("FicheroFactoringBPopular", objFilter)
        If Not IsNothing(dtExportacion) AndAlso dtExportacion.Rows.Count > 0 Then
            Dim xlsApp As New Object
            Dim xlsWrkBook As New Object
            Dim xlsSheet As New Object

            If CrearAplicacionExcel(xlsApp, xlsWrkBook, xlsSheet) Then
                Try
                    Dim objNegMoneda As New Moneda
                    Dim strMonedaA As String = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate).ID
                    objNegMoneda = Nothing

                    '//////////////////////////  RELLENAMOS LAS CELDAS  ///////////////////////////
                    '//Creamos la Cabecera.
                    xlsSheet.Cells(FILA_EXCEL_CABECERA, COLUMNA_TIPO_REGISTRO) = CODIGO_REGISTRO_CABECERA
                    xlsSheet.Cells(FILA_EXCEL_CABECERA, COLUMNA_SUBTIPO) = CODIGO_COMPRADOR
                    xlsSheet.Cells(FILA_EXCEL_CABECERA, COLUMNA_CABECERA_CLIENTE_FACTORING) = strClienteFactoring  'De Banco Propio
                    xlsSheet.Cells(FILA_EXCEL_CABECERA, COLUMNA_CABECERA_FECHA) = Today
                    xlsSheet.Cells(FILA_EXCEL_CABECERA, COLUMNA_CABECERA_MONEDA) = strMonedaA


                    '//Escribimos en la hoja Excel los registros de detalle.
                    Dim dblImporteTotal As Double
                    Dim row As Integer = FILA_EXCEL_INICIO_DATOS
                    For Each drRowExportacion As DataRow In dtExportacion.Rows
                        xlsSheet.Cells(row, COLUMNA_TIPO_REGISTRO) = CODIGO_REGISTRO_DETALLE_FACTURA
                        '//NOTA: De momento no vamos a mostrar el Código de la entidad aseguradora, ni el subtipo.
                        'xlsSheet.Cells(row, COLUMNA_SUBTIPO) = drRowExportacion("SubTipoEntidadAseguradora") & String.Empty
                        'xlsSheet.Cells(row, COLUMNA_COMPRADOR) = drRowExportacion("CodigoEntidadAseguradora") & String.Empty
                        xlsSheet.Cells(row, COLUMNA_TIPO_PRODUCTO) = CODIGO_TIPO_PRODUCTO

                        For col As Integer = 1 To dtExportacion.Columns.Count
                            Select Case dtExportacion.Columns(col - 1).ColumnName
                                Case "FechaFactura", "FechaVencimientoFactura"
                                    Dim colAux As Integer
                                    If dtExportacion.Columns(col - 1).ColumnName = "FechaFactura" Then
                                        colAux = COLUMNA_FECHA_FACTURA
                                    ElseIf dtExportacion.Columns(col - 1).ColumnName = "FechaVencimientoFactura" Then
                                        colAux = COLUMNA_FECHA_VENCIMIENTO_FACTURA
                                    End If
                                    xlsSheet.Cells(row, colAux) = drRowExportacion(dtExportacion.Columns(col - 1).ColumnName)
                                Case "CondicionVentaFactoring"
                                    xlsSheet.Cells(row, COLUMNA_COND_VENTA_FACTORING) = CODIGO_COND_VENTA_FACTORING
                                Case "ImporteFactura"
                                    dblImporteTotal = dblImporteTotal + Nz(drRowExportacion(dtExportacion.Columns(col - 1).ColumnName), 0)
                                    xlsSheet.Cells(row, COLUMNA_IMPORTE_FACTURA).NumberFormat = FORMATO_NUMERICO
                                    xlsSheet.Cells(row, COLUMNA_IMPORTE_FACTURA) = Nz(drRowExportacion(dtExportacion.Columns(col - 1).ColumnName), 0)
                                Case "NumeroFactura"
                                    xlsSheet.Cells(row, COLUMNA_NFACTURA).NumberFormat = FORMATO_STRING
                                    xlsSheet.Cells(row, COLUMNA_NFACTURA) = drRowExportacion(dtExportacion.Columns(col - 1).ColumnName)
                            End Select
                        Next col


                        row = row + 1
                    Next drRowExportacion

                    '//Creamos el Registro de Totales.
                    xlsSheet.Cells(row, COLUMNA_TIPO_REGISTRO) = CODIGO_REGISTRO_TOTALES
                    xlsSheet.Cells(row, COLUMNA_IMPORTE_TOTAL).NumberFormat = FORMATO_NUMERICO
                    xlsSheet.Cells(row, COLUMNA_IMPORTE_TOTAL) = dblImporteTotal

                    '/////////////////////////////////////////////////////////////////////////////

                    '//Mostramos el cuadro de diálogo de Guardar Fichero.
                    Dim strPath As String = DialogoSaveAsExcel()

                    If Engine.Length(strPath) > 0 Then
                        '//Guardamos el archivo excel
                        If GuardarAplicacionExcel(strPath, xlsApp, xlsWrkBook, xlsSheet) Then
                            '//13096: Fichero generado con éxito.
                            ExpertisApp.GenerateMessage("Fichero generado con éxito.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        GenerarFicheroExcelFactoring_BancoPopular = False
                    End If

                Catch ex As Exception
                    GenerarFicheroExcelFactoring_BancoPopular = False
                    'MessageBox.Show(ERROR_GENERACION_FICHERO & Chr(13) & ex.Message, ExpertisApp.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                GenerarFicheroExcelFactoring_BancoPopular = False
                ExpertisApp.GenerateMessage("Ha ocurrido un error al crear la aplicación Excel.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            GenerarFicheroExcelFactoring_BancoPopular = False
            ExpertisApp.GenerateMessage("No hay registros a procesar.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Protected Overridable Function CrearAplicacionExcel(ByRef xlsApp As Object, ByRef xlsWrkBook As Object, ByRef xlsSheet As Object) As Boolean
        CrearAplicacionExcel = False

        xlsApp = CreateObject("Excel.Application")
        If Not IsNothing(xlsApp) Then
            xlsWrkBook = xlsApp.Workbooks.Add       '//Creamos el libro de trabajo
            xlsSheet = xlsApp.Worksheets.Item(1)    '//Creamos la hoja de trabajo
        End If
        CrearAplicacionExcel = True
    End Function

    Protected Overridable Function GuardarAplicacionExcel(ByVal strPath As String, ByVal xlsApp As Object, ByVal xlsWrkBook As Object, ByVal xlsSheet As Object) As Boolean
        GuardarAplicacionExcel = True
        Try
            If Engine.Length(strPath & String.Empty) > 0 Then
                xlsWrkBook.SaveAs(FileName:=strPath)
            Else
                GuardarAplicacionExcel = False
                ExpertisApp.GenerateMessage("No se ha indicado una ruta para el fichero.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            GuardarAplicacionExcel = False
            ExpertisApp.GenerateMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            xlsWrkBook.Close(False)
            xlsApp.Quit()
            xlsApp = Nothing
        End Try
    End Function

    Protected Overridable Function DialogoSaveAsExcel() As String
        Const EXTENSION_FICHERO As String = ".xls"

        Dim strPath As String
        SaveFileDialog1.InitialDirectory = ExpertisApp.Path
        SaveFileDialog1.FileName = "*" & EXTENSION_FICHERO
        SaveFileDialog1.RestoreDirectory = True
        If SaveFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            strPath = SaveFileDialog1.FileName
            Dim intPos As Integer = InStr(1, strPath, EXTENSION_FICHERO)
            If intPos = 0 Then
                '//Si no le habiamos puesto extensión al fichero, se la ponemos ahora.
                strPath = strPath & EXTENSION_FICHERO
            End If
        Else
            strPath = String.Empty
        End If
        Return strPath
    End Function

#End Region

#Region " Generación Ficheros NO EXCEL "


    '//La generación de ficheros que NO precisan Excel están en Negocio. Aquí, simplemente recogemos
    '//el DataTable devuelvo y lo traspasamos a un fichero de texto.
    Protected Overridable Function GuardarFichero(ByVal dtFichero As DataTable) As _GuardarFicheroInfo
        Const cnEXT_FICHERO As String = ".txt"

        Dim objInfo As New _GuardarFicheroInfo

        Try
            objInfo.GuardarFicheroOK = True
            objInfo.MensajeError = Nothing
            If Not IsNothing(dtFichero) AndAlso dtFichero.Rows.Count > 0 Then
                '//Abrimos un cuadro de dialogo, para pedir al usuario el nombre del fichero.
                Dim strPath As String = String.Empty
                SaveFileDialog1.InitialDirectory = ExpertisApp.Path
                SaveFileDialog1.FileName = String.Empty
                If SaveFileDialog1.ShowDialog(Me) = DialogResult.OK Then
                    strPath = SaveFileDialog1.FileName
                    Dim intPos As Integer = InStr(1, strPath, cnEXT_FICHERO)
                    If intPos = 0 Then
                        strPath = strPath & cnEXT_FICHERO
                    End If

                    '//Escribimos la información en el fichero y la guardamos.
                    If Engine.Length(strPath) > 0 Then
                        Dim sr As System.IO.StreamWriter = New System.IO.StreamWriter(strPath)
                        For Each drLinea As DataRow In dtFichero.Rows
                            sr.WriteLine(drLinea("Linea"))
                        Next
                        sr.Close()
                    Else
                        objInfo.GuardarFicheroOK = False
                        objInfo.MensajeError = "No se ha indicado el nombre del fichero."
                    End If
                Else
                    '//Este es un cso, especial (cuando hemos pulsado Cancelar en el Cuadro de Dialogo de guardar el fichero)
                    objInfo.GuardarFicheroOK = True
                    objInfo.MensajeError = "No se ha indicado el nombre del fichero."
                End If
            Else
                objInfo.GuardarFicheroOK = False
                objInfo.MensajeError = "No hay datos a incluir en el fichero."
            End If
        Catch ex As Exception
            objInfo.GuardarFicheroOK = False
            objInfo.MensajeError = ex.Message
        End Try

        Return objInfo
    End Function

#End Region

#End Region


#Region "Informes"

    Protected Overridable Function CrearDTRecibo() As DataTable
        Dim dt As New DataTable
        'dt.RemotingFormat = SerializationFormat.Binary
        With (dt.Columns)
            .Add("IDCobro", GetType(Integer))
            .Add("RazonSocial", GetType(String))
            .Add("Direccion", GetType(String))
            .Add("CodPostal", GetType(String))
            .Add("Poblacion", GetType(String))
            .Add("Provincia", GetType(String))
            .Add("ImpVencimientoA", GetType(String))
            .Add("TextoNumero", GetType(String))
            .Add("NFactura", GetType(String))
            .Add("FechaImpresion", GetType(String))
            .Add("IDIdioma", GetType(String))
        End With
        Return dt
    End Function


    '<Task()> Public Shared Function CrearDTRecibo(ByVal data As Object, ByVal services As ServiceProvider) As DataTable
    '    Dim dt As New DataTable
    '    dt.RemotingFormat = SerializationFormat.Binary
    '    With (dt.Columns)
    '        .Add("IDCobro", GetType(Integer))
    '        .Add("RazonSocial", GetType(String))
    '        .Add("Direccion", GetType(String))
    '        .Add("CodPostal", GetType(String))
    '        .Add("Poblacion", GetType(String))
    '        .Add("Provincia", GetType(String))
    '        .Add("ImpVencimientoA", GetType(String))
    '        .Add("TextoNumero", GetType(String))
    '        .Add("NFactura", GetType(String))
    '        .Add("FechaImpresion", GetType(String))
    '        .Add("IDIdioma", GetType(String))
    '    End With
    '    Return dt
    'End Function

#End Region


    Protected Overridable Sub CICobroCont_CheckingAllRecord(ByVal sender As Object, ByVal e As Engine.UI.CheckingAllEventArgs) Handles Me.CheckingAllRecord
        If e.CheckAction = UI.CheckAction.UnChek Then
            AdvIDCliente.Focus()
        End If
    End Sub

    Protected Overridable Sub CICobroCont_AllRecordChecked(ByVal sender As Object, ByVal e As Engine.UI.AllCheckedEventArgs) Handles Me.AllRecordChecked
        If e.CheckAction = UI.CheckAction.UnChek Then txtTotalMarcado.Text = 0
    End Sub


    Protected Overridable Sub AdvIDRemesa_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDRemesa.SetPredefinedFilter
        Dim fRemesas As New Filter(FilterUnionOperator.Or)
        fRemesas.Add(New NumberFilterItem("IDTipoNegociacion", enumTipoRemesa.RemesaAlCobro))
        fRemesas.Add(New NumberFilterItem("IDTipoNegociacion", enumTipoRemesa.RemesaAlDescuento))
        e.Filter.Add(fRemesas)
    End Sub

    Protected Overridable Sub AdvRemesaAnticipo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvRemesaAnticipo.SetPredefinedFilter
        e.Filter.Add(New NumberFilterItem("IDTipoNegociacion", enumTipoRemesa.RemesaAnticipo))
    End Sub



#Region " Gestión de Tarjetas/Cheques "

    Protected Overridable Sub AccionFormularioGestionCheque()
        mblnAccionFormulario = True
        AccionGestionCheque()
    End Sub

    Protected Overridable Sub AccionFormularioGestionTarjeta()
        mblnAccionFormulario = True
        AccionGestionTarjeta()
    End Sub


    Protected Overridable Sub AccionGestionCheque()
        Dim frm As New frmAddInformacionCheque
        If Not mblnAccionFormulario AndAlso Length(Grid.Value("IDCheque")) > 0 Then
            frm.IDCheque = Grid.Value("IDCheque")
            Dim f As New Filter
            f.Add(New NumberFilterItem("Contabilizado", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))
            f.Add(New NumberFilterItem("IDCheque", FilterOperator.Equal, frm.IDCheque))
            Dim dtCobrosChequeContabilizados As DataTable = New BE.DataEngine().Filter("frmCobros", f)
            If dtCobrosChequeContabilizados.Rows.Count > 0 Then
                frm.SoloLectura = True
            End If
        Else
            If Not mblnAccionFormulario Then
                Grid.CheckRecord(Grid.GetRow)
            End If

            If Grid.CheckedRecordsCount = 0 Then
                ExpertisApp.GenerateMessage("Debe marcar algún cobro para Generar su Cheque.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mblnAccionFormulario = False
                Exit Sub
            Else
                If mblnAccionFormulario Then
                    Dim CobrosConCheque As List(Of DataRow) = (From c In CType(Grid.CheckedRecords, DataTable) _
                                                                  Where Not c.IsNull("IDCheque")).ToList()
                    If CobrosConCheque.Count > 0 Then
                        ExpertisApp.GenerateMessage("Alguno de los Cobros marcados ya está gestionado en algún Cheque.{0}Para ver dicha información seleccione el Cobro y pulse botón derecho.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
                        mblnAccionFormulario = False
                        Exit Sub
                    End If

                    Dim CobrosNoCheque As List(Of DataRow) = (From c In CType(Grid.CheckedRecords, DataTable) _
                                                                  Where Not c("ChequeTalon")).ToList()
                    If CobrosNoCheque.Count > 0 Then
                        ExpertisApp.GenerateMessage("Alguno de los Cobros marcados no puede gestionarse como Cheque.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
                        mblnAccionFormulario = False
                        Exit Sub
                    End If


                    Dim ClientesDistintos As List(Of Object) = (From c In CType(Grid.CheckedRecords, DataTable) Select c("IDCliente") Distinct).ToList
                    If ClientesDistintos.Count > 1 Then
                        ExpertisApp.GenerateMessage("En los registros seleccionados hay más de un Cliente. Revise sus datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mblnAccionFormulario = False
                        Exit Sub
                    End If
                End If

                For Each drCobro As DataRow In Grid.CheckedRecords.Rows
                    If Not frm.SoloLectura AndAlso drCobro("Contabilizado") <> enumContabilizado.NoContabilizado Then
                        frm.SoloLectura = True
                    End If
                    ReDim Preserve frm.IDCobros(frm.IDCobros.Length)
                    frm.IDCobros(frm.IDCobros.Length - 1) = drCobro("IDCobro")
                Next
            End If
        End If
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.UnCheckAllRecords()
            Me.Execute()
        End If
        mblnAccionFormulario = False
    End Sub

    Protected Overridable Sub AccionGestionTarjeta()
        Dim frm As New frmAddInformacionTarjeta
        If Not mblnAccionFormulario AndAlso Length(Grid.Value("IDTarjeta")) > 0 Then
            frm.IDTarjeta = Grid.Value("IDTarjeta")
            Dim f As New Filter
            f.Add(New NumberFilterItem("Contabilizado", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))
            f.Add(New NumberFilterItem("IDTarjeta", FilterOperator.Equal, frm.IDTarjeta))
            Dim dtCobrosTarjetaContabilizados As DataTable = New BE.DataEngine().Filter("frmCobros", f)
            If dtCobrosTarjetaContabilizados.Rows.Count > 0 Then
                frm.SoloLectura = True
            End If
        Else
            If Not mblnAccionFormulario Then
                Grid.CheckRecord(Grid.GetRow)
            End If
            If Grid.CheckedRecordsCount = 0 Then
                ExpertisApp.GenerateMessage("Debe marcar algún cobro para Generar su Tarjeta.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mblnAccionFormulario = False
                Exit Sub
            Else
                If mblnAccionFormulario Then
                    Dim CobrosConTarjeta As List(Of DataRow) = (From c In CType(Grid.CheckedRecords, DataTable) _
                                                                  Where Not c.IsNull("IDTarjeta")).ToList()
                    If CobrosConTarjeta.Count > 0 Then
                        ExpertisApp.GenerateMessage("Alguno de los Cobros marcados ya está gestionado en alguna Tarjeta. {0}Para ver dicha información seleccione el Cobro y pulse botón derecho.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
                        mblnAccionFormulario = False
                        Exit Sub
                    End If


                    Dim CobrosNoTarjeta As List(Of DataRow) = (From c In CType(Grid.CheckedRecords, DataTable) _
                                                                Where Not c("Tarjeta")).ToList()
                    If CobrosNoTarjeta.Count > 0 Then
                        ExpertisApp.GenerateMessage("Alguno de los Cobros marcados no puede gestionarse como Tarjeta.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
                        mblnAccionFormulario = False
                        Exit Sub
                    End If

                    Dim ClientesDistintos As List(Of Object) = (From c In CType(Grid.CheckedRecords, DataTable) Select c("IDCliente") Distinct).ToList
                    If ClientesDistintos.Count > 1 Then
                        ExpertisApp.GenerateMessage("En los registros seleccionados hay más de un Cliente. Revise sus datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mblnAccionFormulario = False
                        Exit Sub
                    End If
                End If

                For Each drCobro As DataRow In Grid.CheckedRecords.Rows
                    If Not frm.SoloLectura AndAlso drCobro("Contabilizado") <> enumContabilizado.NoContabilizado Then
                        frm.SoloLectura = True
                    End If
                    ReDim Preserve frm.IDCobros(frm.IDCobros.Length)
                    frm.IDCobros(frm.IDCobros.Length - 1) = drCobro("IDCobro")
                Next
            End If
        End If
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.UnCheckAllRecords()
            Me.Execute()
        End If
        mblnAccionFormulario = False
    End Sub

#End Region

End Class
