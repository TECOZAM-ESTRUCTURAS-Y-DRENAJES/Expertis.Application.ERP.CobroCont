<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarAnticipo
    Inherits Solmicro.Expertis.Engine.UI.FormBase


    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cboEjercicio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerarAnticipo))
        Dim cboBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridGastosAnticipo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.chkGenAsientos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblcboEjercicio = New Solmicro.Expertis.Engine.UI.Label
        Me.lbltxtTextoAsiento = New Solmicro.Expertis.Engine.UI.Label
        Me.lblccboEjercicio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.txtTextoAsiento = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cboEjercicio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblccboBanco = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FraContabilizacion = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkGenerarAsientoConGastos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.cbxFechaCargoAnticipo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaCargoAnticipo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtRefAbonoAnticipo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblRefAbonoAnticipo = New Solmicro.Expertis.Engine.UI.Label
        Me.FraAnticipos = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFechaAnticipo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaAnticipo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.chkImprimir = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblFechaCancPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaCancPrev = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.nbxTipoInteresInicial = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTipoInteres = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcboBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblNAnticipo = New Solmicro.Expertis.Engine.UI.Label
        Me.cboBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.txtIDAnticipo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.chkCrearFacturaGastos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FraGastosAnticipo = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridGastosAnticipo = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlGastosTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtFacturaGasto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFacturaGasto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtProveedor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.AdvIDContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        CType(Me.cboEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraContabilizacion.SuspendLayout()
        Me.FraAnticipos.SuspendLayout()
        CType(Me.cboBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.suspendlayout()
        Me.FraGastosAnticipo.SuspendLayout()
        CType(Me.GridGastosAnticipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGastosTop.suspendlayout()
        Me.SuspendLayout()
        '
        'chkGenAsientos
        '
        Me.chkGenAsientos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkGenAsientos.Location = New System.Drawing.Point(493, 12)
        Me.chkGenAsientos.Name = "chkGenAsientos"
        Me.chkGenAsientos.Size = New System.Drawing.Size(118, 19)
        Me.chkGenAsientos.TabIndex = 0
        Me.chkGenAsientos.Text = "Generar Asiento"
        '
        'lblcboEjercicio
        '
        Me.lblcboEjercicio.Location = New System.Drawing.Point(13, 67)
        Me.lblcboEjercicio.Name = "lblcboEjercicio"
        Me.lblcboEjercicio.Size = New System.Drawing.Size(110, 13)
        Me.lblcboEjercicio.TabIndex = 37
        Me.lblcboEjercicio.Tag = "IdRec=4772;"
        Me.lblcboEjercicio.Text = "Ejercicio Contable"
        '
        'lbltxtTextoAsiento
        '
        Me.lbltxtTextoAsiento.Location = New System.Drawing.Point(13, 96)
        Me.lbltxtTextoAsiento.Name = "lbltxtTextoAsiento"
        Me.lbltxtTextoAsiento.Size = New System.Drawing.Size(106, 13)
        Me.lbltxtTextoAsiento.TabIndex = 39
        Me.lbltxtTextoAsiento.Tag = "IdRec=4773;"
        Me.lbltxtTextoAsiento.Text = "Texto del Asiento"
        '
        'lblccboEjercicio
        '
        Me.TryDataBinding(lblccboEjercicio, New System.Windows.Forms.Binding("Text", Me.cboEjercicio, "DescEjercicio", True))
        Me.lblccboEjercicio.Location = New System.Drawing.Point(221, 63)
        Me.lblccboEjercicio.Name = "lblccboEjercicio"
        Me.lblccboEjercicio.Size = New System.Drawing.Size(184, 21)
        Me.lblccboEjercicio.TabIndex = 38
        '
        'txtTextoAsiento
        '
        Me.txtTextoAsiento.DisabledBackColor = System.Drawing.Color.White
        Me.txtTextoAsiento.Location = New System.Drawing.Point(125, 92)
        Me.txtTextoAsiento.Name = "txtTextoAsiento"
        Me.txtTextoAsiento.Size = New System.Drawing.Size(487, 21)
        Me.txtTextoAsiento.TabIndex = 3
        '
        'cboEjercicio
        '
        cboEjercicio_DesignTimeLayout.LayoutString = resources.GetString("cboEjercicio_DesignTimeLayout.LayoutString")
        Me.cboEjercicio.DesignTimeLayout = cboEjercicio_DesignTimeLayout
        Me.cboEjercicio.DisabledBackColor = System.Drawing.Color.White
        Me.cboEjercicio.EntityName = "EjercicioContable"
        Me.cboEjercicio.Location = New System.Drawing.Point(125, 63)
        Me.cboEjercicio.Name = "cboEjercicio"
        Me.cboEjercicio.PrimaryDataFields = "IDEjercicio"
        Me.cboEjercicio.SecondaryDataFields = "IDEjercicio"
        Me.cboEjercicio.SelectedIndex = -1
        Me.cboEjercicio.SelectedItem = Nothing
        Me.cboEjercicio.Size = New System.Drawing.Size(90, 21)
        Me.cboEjercicio.TabIndex = 1
        Me.cboEjercicio.ViewName = "tbMaestroEjercicio"
        '
        'lblccboBanco
        '
        Me.TryDataBinding(lblccboBanco, New System.Windows.Forms.Binding("Text", Me.cboBancoPropio, "DescBancoPropio", True))
        Me.lblccboBanco.Location = New System.Drawing.Point(178, 74)
        Me.lblccboBanco.Name = "lblccboBanco"
        Me.lblccboBanco.Size = New System.Drawing.Size(434, 21)
        Me.lblccboBanco.TabIndex = 43
        '
        'FraContabilizacion
        '
        Me.FraContabilizacion.Controls.Add(Me.chkGenerarAsientoConGastos)
        Me.FraContabilizacion.Controls.Add(Me.chkGenAsientos)
        Me.FraContabilizacion.Controls.Add(Me.cboEjercicio)
        Me.FraContabilizacion.Controls.Add(Me.lblcboEjercicio)
        Me.FraContabilizacion.Controls.Add(Me.txtTextoAsiento)
        Me.FraContabilizacion.Controls.Add(Me.lbltxtTextoAsiento)
        Me.FraContabilizacion.Controls.Add(Me.lblccboEjercicio)
        Me.FraContabilizacion.Controls.Add(Me.cbxFechaCargoAnticipo)
        Me.FraContabilizacion.Controls.Add(Me.lblFechaCargoAnticipo)
        Me.FraContabilizacion.Controls.Add(Me.txtRefAbonoAnticipo)
        Me.FraContabilizacion.Controls.Add(Me.lblRefAbonoAnticipo)
        Me.FraContabilizacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraContabilizacion.Location = New System.Drawing.Point(0, 102)
        Me.FraContabilizacion.Name = "FraContabilizacion"
        Me.FraContabilizacion.Size = New System.Drawing.Size(642, 159)
        Me.FraContabilizacion.TabIndex = 1
        Me.FraContabilizacion.TabStop = False
        Me.FraContabilizacion.Text = "Contabilización"
        '
        'chkGenerarAsientoConGastos
        '
        Me.chkGenerarAsientoConGastos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkGenerarAsientoConGastos.Location = New System.Drawing.Point(437, 33)
        Me.chkGenerarAsientoConGastos.Name = "chkGenerarAsientoConGastos"
        Me.chkGenerarAsientoConGastos.Size = New System.Drawing.Size(174, 19)
        Me.chkGenerarAsientoConGastos.TabIndex = 40
        Me.chkGenerarAsientoConGastos.Text = "Generar Asiento + Gastos"
        Me.chkGenerarAsientoConGastos.Visible = False
        '
        'cbxFechaCargoAnticipo
        '
        Me.cbxFechaCargoAnticipo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaCargoAnticipo.Location = New System.Drawing.Point(523, 63)
        Me.cbxFechaCargoAnticipo.Name = "cbxFechaCargoAnticipo"
        Me.cbxFechaCargoAnticipo.Size = New System.Drawing.Size(89, 21)
        Me.cbxFechaCargoAnticipo.TabIndex = 2
        '
        'lblFechaCargoAnticipo
        '
        Me.lblFechaCargoAnticipo.Location = New System.Drawing.Point(429, 67)
        Me.lblFechaCargoAnticipo.Name = "lblFechaCargoAnticipo"
        Me.lblFechaCargoAnticipo.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaCargoAnticipo.TabIndex = 25
        Me.lblFechaCargoAnticipo.Tag = ""
        Me.lblFechaCargoAnticipo.Text = "Fecha Abono"
        '
        'txtRefAbonoAnticipo
        '
        Me.txtRefAbonoAnticipo.DisabledBackColor = System.Drawing.Color.White
        Me.txtRefAbonoAnticipo.Location = New System.Drawing.Point(125, 118)
        Me.txtRefAbonoAnticipo.Name = "txtRefAbonoAnticipo"
        Me.txtRefAbonoAnticipo.Size = New System.Drawing.Size(487, 21)
        Me.txtRefAbonoAnticipo.TabIndex = 4
        '
        'lblRefAbonoAnticipo
        '
        Me.lblRefAbonoAnticipo.Location = New System.Drawing.Point(13, 122)
        Me.lblRefAbonoAnticipo.Name = "lblRefAbonoAnticipo"
        Me.lblRefAbonoAnticipo.Size = New System.Drawing.Size(70, 13)
        Me.lblRefAbonoAnticipo.TabIndex = 36
        Me.lblRefAbonoAnticipo.Tag = ""
        Me.lblRefAbonoAnticipo.Text = "Ref. Abono"
        '
        'FraAnticipos
        '
        Me.FraAnticipos.Controls.Add(Me.lblFechaAnticipo)
        Me.FraAnticipos.Controls.Add(Me.cbxFechaAnticipo)
        Me.FraAnticipos.Controls.Add(Me.chkImprimir)
        Me.FraAnticipos.Controls.Add(Me.lblFechaCancPrev)
        Me.FraAnticipos.Controls.Add(Me.cbxFechaCancPrev)
        Me.FraAnticipos.Controls.Add(Me.lblccboBanco)
        Me.FraAnticipos.Controls.Add(Me.nbxTipoInteresInicial)
        Me.FraAnticipos.Controls.Add(Me.lblTipoInteres)
        Me.FraAnticipos.Controls.Add(Me.lblcboBancoPropio)
        Me.FraAnticipos.Controls.Add(Me.lblNAnticipo)
        Me.FraAnticipos.Controls.Add(Me.cboBancoPropio)
        Me.FraAnticipos.Controls.Add(Me.txtIDAnticipo)
        Me.FraAnticipos.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraAnticipos.Location = New System.Drawing.Point(0, 0)
        Me.FraAnticipos.Name = "FraAnticipos"
        Me.FraAnticipos.Size = New System.Drawing.Size(642, 102)
        Me.FraAnticipos.TabIndex = 0
        Me.FraAnticipos.TabStop = False
        Me.FraAnticipos.Text = "Anticipo"
        '
        'lblFechaAnticipo
        '
        Me.lblFechaAnticipo.Location = New System.Drawing.Point(17, 51)
        Me.lblFechaAnticipo.Name = "lblFechaAnticipo"
        Me.lblFechaAnticipo.Size = New System.Drawing.Size(89, 13)
        Me.lblFechaAnticipo.TabIndex = 46
        Me.lblFechaAnticipo.Tag = ""
        Me.lblFechaAnticipo.Text = "Fecha Anticipo"
        '
        'cbxFechaAnticipo
        '
        Me.cbxFechaAnticipo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaAnticipo.Location = New System.Drawing.Point(116, 47)
        Me.cbxFechaAnticipo.Name = "cbxFechaAnticipo"
        Me.cbxFechaAnticipo.Size = New System.Drawing.Size(98, 21)
        Me.cbxFechaAnticipo.TabIndex = 2
        '
        'chkImprimir
        '
        Me.chkImprimir.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkImprimir.Location = New System.Drawing.Point(532, 23)
        Me.chkImprimir.Name = "chkImprimir"
        Me.chkImprimir.Size = New System.Drawing.Size(79, 19)
        Me.chkImprimir.TabIndex = 6
        Me.chkImprimir.Text = "Imprimir"
        '
        'lblFechaCancPrev
        '
        Me.lblFechaCancPrev.Location = New System.Drawing.Point(407, 51)
        Me.lblFechaCancPrev.Name = "lblFechaCancPrev"
        Me.lblFechaCancPrev.Size = New System.Drawing.Size(111, 13)
        Me.lblFechaCancPrev.TabIndex = 42
        Me.lblFechaCancPrev.Tag = ""
        Me.lblFechaCancPrev.Text = "Fecha Canc. Prev."
        '
        'cbxFechaCancPrev
        '
        Me.cbxFechaCancPrev.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaCancPrev.Location = New System.Drawing.Point(523, 47)
        Me.cbxFechaCancPrev.Name = "cbxFechaCancPrev"
        Me.cbxFechaCancPrev.Size = New System.Drawing.Size(89, 21)
        Me.cbxFechaCancPrev.TabIndex = 3
        '
        'nbxTipoInteresInicial
        '
        Me.nbxTipoInteresInicial.DisabledBackColor = System.Drawing.Color.White
        Me.nbxTipoInteresInicial.Location = New System.Drawing.Point(116, 101)
        Me.nbxTipoInteresInicial.Name = "nbxTipoInteresInicial"
        Me.nbxTipoInteresInicial.Size = New System.Drawing.Size(98, 21)
        Me.nbxTipoInteresInicial.TabIndex = 5
        Me.nbxTipoInteresInicial.Visible = False
        '
        'lblTipoInteres
        '
        Me.lblTipoInteres.Location = New System.Drawing.Point(17, 105)
        Me.lblTipoInteres.Name = "lblTipoInteres"
        Me.lblTipoInteres.Size = New System.Drawing.Size(93, 13)
        Me.lblTipoInteres.TabIndex = 37
        Me.lblTipoInteres.Tag = ""
        Me.lblTipoInteres.Text = "Tipo Int. Inicial"
        Me.lblTipoInteres.Visible = False
        '
        'lblcboBancoPropio
        '
        Me.lblcboBancoPropio.Location = New System.Drawing.Point(17, 78)
        Me.lblcboBancoPropio.Name = "lblcboBancoPropio"
        Me.lblcboBancoPropio.Size = New System.Drawing.Size(91, 13)
        Me.lblcboBancoPropio.TabIndex = 33
        Me.lblcboBancoPropio.Tag = "IdRec=6588;"
        Me.lblcboBancoPropio.Text = "Banco Anticipo"
        '
        'lblNAnticipo
        '
        Me.lblNAnticipo.Location = New System.Drawing.Point(17, 27)
        Me.lblNAnticipo.Name = "lblNAnticipo"
        Me.lblNAnticipo.Size = New System.Drawing.Size(70, 13)
        Me.lblNAnticipo.TabIndex = 19
        Me.lblNAnticipo.Tag = ""
        Me.lblNAnticipo.Text = "Nº Anticipo"
        '
        'cboBancoPropio
        '
        cboBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("cboBancoPropio_DesignTimeLayout.LayoutString")
        Me.cboBancoPropio.DesignTimeLayout = cboBancoPropio_DesignTimeLayout
        Me.cboBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.cboBancoPropio.EntityName = "BancoPropio"
        Me.cboBancoPropio.Location = New System.Drawing.Point(116, 74)
        Me.cboBancoPropio.Name = "cboBancoPropio"
        Me.cboBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.cboBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.cboBancoPropio.SelectedIndex = -1
        Me.cboBancoPropio.SelectedItem = Nothing
        Me.cboBancoPropio.Size = New System.Drawing.Size(57, 21)
        Me.cboBancoPropio.TabIndex = 4
        Me.cboBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'txtIDAnticipo
        '
        Me.txtIDAnticipo.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDAnticipo.Enabled = False
        Me.txtIDAnticipo.Location = New System.Drawing.Point(116, 23)
        Me.txtIDAnticipo.Name = "txtIDAnticipo"
        Me.txtIDAnticipo.Size = New System.Drawing.Size(98, 21)
        Me.txtIDAnticipo.TabIndex = 0
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.cmbCancelar)
        Me.pnlBottom.Controls.Add(Me.cmbAceptar)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 519)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(642, 57)
        Me.pnlBottom.TabIndex = 2
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCancelar.Location = New System.Drawing.Point(331, 14)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 31)
        Me.cmbCancelar.TabIndex = 1
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAceptar.Location = New System.Drawing.Point(224, 14)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 31)
        Me.cmbAceptar.TabIndex = 0
        Me.cmbAceptar.Text = "Aceptar"
        '
        'chkCrearFacturaGastos
        '
        Me.chkCrearFacturaGastos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCrearFacturaGastos.Location = New System.Drawing.Point(466, 8)
        Me.chkCrearFacturaGastos.Name = "chkCrearFacturaGastos"
        Me.chkCrearFacturaGastos.Size = New System.Drawing.Size(142, 19)
        Me.chkCrearFacturaGastos.TabIndex = 41
        Me.chkCrearFacturaGastos.Text = "Crear Factura Gastos"
        '
        'FraGastosAnticipo
        '
        Me.FraGastosAnticipo.Controls.Add(Me.GridGastosAnticipo)
        Me.FraGastosAnticipo.Controls.Add(Me.pnlGastosTop)
        Me.FraGastosAnticipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraGastosAnticipo.Location = New System.Drawing.Point(0, 261)
        Me.FraGastosAnticipo.Name = "FraGastosAnticipo"
        Me.FraGastosAnticipo.Size = New System.Drawing.Size(642, 258)
        Me.FraGastosAnticipo.TabIndex = 3
        Me.FraGastosAnticipo.TabStop = False
        Me.FraGastosAnticipo.Text = "Generar Gastos Asociados  al Anticipo"
        '
        'GridGastosAnticipo
        '
        Me.GridGastosAnticipo.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTipoIva", "IDTipoIVA"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("CCCompra", "IDCContable")}), "advArticulo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCContable", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoIVA", "TipoIVA", "IDTipoIVA"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NObra", "ObraCabecera", "NObra", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")}))})
        GridGastosAnticipo_DesignTimeLayout.LayoutString = resources.GetString("GridGastosAnticipo_DesignTimeLayout.LayoutString")
        Me.GridGastosAnticipo.DesignTimeLayout = GridGastosAnticipo_DesignTimeLayout
        Me.GridGastosAnticipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGastosAnticipo.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridGastosAnticipo.EntityName = Nothing
        Me.GridGastosAnticipo.Location = New System.Drawing.Point(3, 89)
        Me.GridGastosAnticipo.Name = "GridGastosAnticipo"
        Me.GridGastosAnticipo.PrimaryDataFields = Nothing
        Me.GridGastosAnticipo.SecondaryDataFields = Nothing
        Me.GridGastosAnticipo.Size = New System.Drawing.Size(636, 166)
        Me.GridGastosAnticipo.TabIndex = 48
        Me.GridGastosAnticipo.ViewName = Nothing
        '
        'pnlGastosTop
        '
        Me.pnlGastosTop.Controls.Add(Me.txtFacturaGasto)
        Me.pnlGastosTop.Controls.Add(Me.lblFacturaGasto)
        Me.pnlGastosTop.Controls.Add(Me.chkCrearFacturaGastos)
        Me.pnlGastosTop.Controls.Add(Me.txtProveedor)
        Me.pnlGastosTop.Controls.Add(Me.AdvIDContador)
        Me.pnlGastosTop.Controls.Add(Me.lblProveedor)
        Me.pnlGastosTop.Controls.Add(Me.lblContador)
        Me.pnlGastosTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlGastosTop.Location = New System.Drawing.Point(3, 17)
        Me.pnlGastosTop.Name = "pnlGastosTop"
        Me.pnlGastosTop.Size = New System.Drawing.Size(636, 72)
        Me.pnlGastosTop.TabIndex = 47
        '
        'txtFacturaGasto
        '
        Me.txtFacturaGasto.DisabledBackColor = System.Drawing.Color.White
        Me.txtFacturaGasto.Enabled = False
        Me.txtFacturaGasto.Location = New System.Drawing.Point(73, 41)
        Me.txtFacturaGasto.Name = "txtFacturaGasto"
        Me.txtFacturaGasto.Size = New System.Drawing.Size(119, 21)
        Me.txtFacturaGasto.TabIndex = 48
        '
        'lblFacturaGasto
        '
        Me.lblFacturaGasto.Location = New System.Drawing.Point(18, 45)
        Me.lblFacturaGasto.Name = "lblFacturaGasto"
        Me.lblFacturaGasto.Size = New System.Drawing.Size(49, 13)
        Me.lblFacturaGasto.TabIndex = 47
        Me.lblFacturaGasto.Tag = ""
        Me.lblFacturaGasto.Text = "Factura"
        '
        'txtProveedor
        '
        Me.txtProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Location = New System.Drawing.Point(487, 42)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(119, 21)
        Me.txtProveedor.TabIndex = 46
        '
        'AdvIDContador
        '
        Me.AdvIDContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDContador.EntityName = "EntidadContador"
        Me.AdvIDContador.Location = New System.Drawing.Point(302, 41)
        Me.AdvIDContador.Name = "AdvIDContador"
        Me.AdvIDContador.SecondaryDataFields = "IDContador"
        Me.AdvIDContador.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDContador.TabIndex = 42
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(420, 46)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblProveedor.TabIndex = 45
        Me.lblProveedor.Tag = ""
        Me.lblProveedor.Text = "Proveedor"
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(234, 45)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 43
        Me.lblContador.Tag = ""
        Me.lblContador.Text = "Contador"
        '
        'frmGenerarAnticipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 576)
        Me.Controls.Add(Me.FraGastosAnticipo)
        Me.Controls.Add(Me.FraContabilizacion)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.FraAnticipos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGenerarAnticipo"
        Me.Text = "Generar Anticipo"
        CType(Me.cboEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraContabilizacion.ResumeLayout(False)
        Me.FraContabilizacion.PerformLayout()
        Me.FraAnticipos.ResumeLayout(False)
        Me.FraAnticipos.PerformLayout()
        CType(Me.cboBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.FraGastosAnticipo.ResumeLayout(False)
        CType(Me.GridGastosAnticipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGastosTop.ResumeLayout(False)
        Me.pnlGastosTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkGenAsientos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblcboEjercicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lbltxtTextoAsiento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblccboEjercicio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents txtTextoAsiento As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cboEjercicio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblccboBanco As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents FraContabilizacion As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraAnticipos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblFechaCancPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaCancPrev As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents nbxTipoInteresInicial As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTipoInteres As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblRefAbonoAnticipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtRefAbonoAnticipo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFechaCargoAnticipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcboBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaCargoAnticipo As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblNAnticipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtIDAnticipo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents pnlBottom As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents chkImprimir As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblFechaAnticipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaAnticipo As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents chkGenerarAsientoConGastos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCrearFacturaGastos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents FraGastosAnticipo As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtProveedor As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlGastosTop As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents GridGastosAnticipo As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents txtFacturaGasto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFacturaGasto As Solmicro.Expertis.Engine.UI.Label
End Class
