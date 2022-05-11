Public Class frmRemesaDefinitiva
    Inherits Solmicro.Expertis.Engine.UI.FormBase


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
    Public WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents txtIDRemesa As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiNRemesa As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pnlBottom As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraNumRemesa As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents wlfOpciones As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents chkGenerarAsientoConGastos As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblfwiTipoRemesa As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiTipoRemesa As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents fwiGenAsientos As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents fwiImprimir As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents FraGenFicherosSEPA As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents rbtCOR1 As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents rbtB2B As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents rbtCore As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents lblfwiFechaCargo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiFechaNeg As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFechaCargo As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents fwiFechaNeg As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents fwiGenFich58 As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents fwiTexto58 As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents FraFicherosObsoletos As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fwiGenFich19 As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents FraBanco As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblfwiSufijo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiSufijo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblcfwiBanco As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents FraConta As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiNDocumento As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFechaValor As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblfwiFechaAsiento As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiEjercicio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiTextoAsiento As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFechaAsiento As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblcfwiEjercicio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiTextoAsiento As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiEjercicio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents CmbTipoFicheroSEPA As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents LblTipoFicheroSEPA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlFechaEmision As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraFicheros As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim fwiTipoRemesa_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemesaDefinitiva))
        Dim CmbTipoFicheroSEPA_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiEjercicio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.txtIDRemesa = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiNRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.pnlBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.FraNumRemesa = New Solmicro.Expertis.Engine.UI.Frame
        Me.wlfOpciones = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkGenerarAsientoConGastos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblfwiTipoRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTipoRemesa = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.fwiGenAsientos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.fwiImprimir = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FraGenFicherosSEPA = New Solmicro.Expertis.Engine.UI.Frame
        Me.CmbTipoFicheroSEPA = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblTipoFicheroSEPA = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtCOR1 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtB2B = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtCore = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblfwiFechaCargo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFechaNeg = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaCargo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.fwiFechaNeg = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.fwiGenFich58 = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.fwiTexto58 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraFicherosObsoletos = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiGenFich19 = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FraBanco = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiSufijo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiSufijo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblcfwiBanco = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FraConta = New Solmicro.Expertis.Engine.UI.Frame
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiNDocumento = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaValor = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaAsiento = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiEjercicio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiTextoAsiento = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaAsiento = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblcfwiEjercicio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiTextoAsiento = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiEjercicio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FraFicheros = New Solmicro.Expertis.Engine.UI.Frame
        Me.pnlFechaEmision = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlBottom.suspendlayout()
        Me.FraNumRemesa.SuspendLayout()
        Me.wlfOpciones.SuspendLayout()
        CType(Me.fwiTipoRemesa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraGenFicherosSEPA.SuspendLayout()
        CType(Me.CmbTipoFicheroSEPA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraFicherosObsoletos.SuspendLayout()
        Me.FraBanco.SuspendLayout()
        CType(Me.fwiBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraConta.SuspendLayout()
        CType(Me.fwiEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraFicheros.SuspendLayout()
        Me.pnlFechaEmision.suspendlayout()
        Me.SuspendLayout()
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCancelar.Location = New System.Drawing.Point(231, 11)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 32)
        Me.cmbCancelar.TabIndex = 5
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAceptar.Location = New System.Drawing.Point(112, 11)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 32)
        Me.cmbAceptar.TabIndex = 4
        Me.cmbAceptar.Text = "Aceptar"
        '
        'txtIDRemesa
        '
        Me.txtIDRemesa.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDRemesa.Enabled = False
        Me.txtIDRemesa.Location = New System.Drawing.Point(190, 20)
        Me.txtIDRemesa.Name = "txtIDRemesa"
        Me.txtIDRemesa.Size = New System.Drawing.Size(65, 21)
        Me.txtIDRemesa.TabIndex = 7
        '
        'lblfwiNRemesa
        '
        Me.lblfwiNRemesa.Location = New System.Drawing.Point(104, 24)
        Me.lblfwiNRemesa.Name = "lblfwiNRemesa"
        Me.lblfwiNRemesa.Size = New System.Drawing.Size(76, 13)
        Me.lblfwiNRemesa.TabIndex = 16
        Me.lblfwiNRemesa.Tag = "IdRec=4792;"
        Me.lblfwiNRemesa.Text = "Nº Remesa:"
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.cmbAceptar)
        Me.pnlBottom.Controls.Add(Me.cmbCancelar)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 497)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(429, 55)
        Me.pnlBottom.TabIndex = 5
        '
        'FraNumRemesa
        '
        Me.FraNumRemesa.Controls.Add(Me.txtIDRemesa)
        Me.FraNumRemesa.Controls.Add(Me.lblfwiNRemesa)
        Me.FraNumRemesa.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraNumRemesa.Location = New System.Drawing.Point(0, 0)
        Me.FraNumRemesa.Name = "FraNumRemesa"
        Me.FraNumRemesa.Size = New System.Drawing.Size(429, 52)
        Me.FraNumRemesa.TabIndex = 0
        Me.FraNumRemesa.TabStop = False
        '
        'wlfOpciones
        '
        Me.wlfOpciones.Controls.Add(Me.chkGenerarAsientoConGastos)
        Me.wlfOpciones.Controls.Add(Me.lblfwiTipoRemesa)
        Me.wlfOpciones.Controls.Add(Me.fwiTipoRemesa)
        Me.wlfOpciones.Controls.Add(Me.fwiGenAsientos)
        Me.wlfOpciones.Controls.Add(Me.fwiImprimir)
        Me.wlfOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.wlfOpciones.Location = New System.Drawing.Point(0, 52)
        Me.wlfOpciones.Name = "wlfOpciones"
        Me.wlfOpciones.Size = New System.Drawing.Size(429, 91)
        Me.wlfOpciones.TabIndex = 1
        Me.wlfOpciones.TabStop = False
        Me.wlfOpciones.Tag = "IdRec=4802;"
        Me.wlfOpciones.Text = "Opciones"
        '
        'chkGenerarAsientoConGastos
        '
        Me.chkGenerarAsientoConGastos.Location = New System.Drawing.Point(161, 60)
        Me.chkGenerarAsientoConGastos.Name = "chkGenerarAsientoConGastos"
        Me.chkGenerarAsientoConGastos.Size = New System.Drawing.Size(209, 19)
        Me.chkGenerarAsientoConGastos.TabIndex = 3
        Me.chkGenerarAsientoConGastos.Text = "Generar Asientos + Gastos"
        Me.chkGenerarAsientoConGastos.Visible = False
        '
        'lblfwiTipoRemesa
        '
        Me.lblfwiTipoRemesa.Location = New System.Drawing.Point(9, 18)
        Me.lblfwiTipoRemesa.Name = "lblfwiTipoRemesa"
        Me.lblfwiTipoRemesa.Size = New System.Drawing.Size(81, 13)
        Me.lblfwiTipoRemesa.TabIndex = 30
        Me.lblfwiTipoRemesa.Tag = "IdRec=4456;"
        Me.lblfwiTipoRemesa.Text = "Tipo Remesa"
        '
        'fwiTipoRemesa
        '
        fwiTipoRemesa_DesignTimeLayout.LayoutString = resources.GetString("fwiTipoRemesa_DesignTimeLayout.LayoutString")
        Me.fwiTipoRemesa.DesignTimeLayout = fwiTipoRemesa_DesignTimeLayout
        Me.fwiTipoRemesa.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTipoRemesa.DisplayMember = "Text"
        Me.fwiTipoRemesa.Location = New System.Drawing.Point(9, 38)
        Me.fwiTipoRemesa.Name = "fwiTipoRemesa"
        Me.fwiTipoRemesa.SelectedIndex = -1
        Me.fwiTipoRemesa.SelectedItem = Nothing
        Me.fwiTipoRemesa.Size = New System.Drawing.Size(123, 21)
        Me.fwiTipoRemesa.TabIndex = 0
        '
        'fwiGenAsientos
        '
        Me.fwiGenAsientos.Location = New System.Drawing.Point(161, 40)
        Me.fwiGenAsientos.Name = "fwiGenAsientos"
        Me.fwiGenAsientos.Size = New System.Drawing.Size(140, 19)
        Me.fwiGenAsientos.TabIndex = 2
        Me.fwiGenAsientos.Text = "Generar Asientos"
        '
        'fwiImprimir
        '
        Me.fwiImprimir.Location = New System.Drawing.Point(161, 18)
        Me.fwiImprimir.Name = "fwiImprimir"
        Me.fwiImprimir.Size = New System.Drawing.Size(104, 19)
        Me.fwiImprimir.TabIndex = 1
        Me.fwiImprimir.Text = "Imprimir"
        '
        'FraGenFicherosSEPA
        '
        Me.FraGenFicherosSEPA.Controls.Add(Me.CmbTipoFicheroSEPA)
        Me.FraGenFicherosSEPA.Controls.Add(Me.LblTipoFicheroSEPA)
        Me.FraGenFicherosSEPA.Controls.Add(Me.rbtCOR1)
        Me.FraGenFicherosSEPA.Controls.Add(Me.rbtB2B)
        Me.FraGenFicherosSEPA.Controls.Add(Me.rbtCore)
        Me.FraGenFicherosSEPA.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraGenFicherosSEPA.Location = New System.Drawing.Point(3, 48)
        Me.FraGenFicherosSEPA.Name = "FraGenFicherosSEPA"
        Me.FraGenFicherosSEPA.Size = New System.Drawing.Size(423, 41)
        Me.FraGenFicherosSEPA.TabIndex = 1
        Me.FraGenFicherosSEPA.TabStop = False
        Me.FraGenFicherosSEPA.Tag = ""
        Me.FraGenFicherosSEPA.Text = "SEPA"
        '
        'CmbTipoFicheroSEPA
        '
        Me.CmbTipoFicheroSEPA.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        CmbTipoFicheroSEPA_DesignTimeLayout.LayoutString = resources.GetString("CmbTipoFicheroSEPA_DesignTimeLayout.LayoutString")
        Me.CmbTipoFicheroSEPA.DesignTimeLayout = CmbTipoFicheroSEPA_DesignTimeLayout
        Me.CmbTipoFicheroSEPA.DisabledBackColor = System.Drawing.Color.White
        Me.CmbTipoFicheroSEPA.DisplayMember = "Text"
        Me.CmbTipoFicheroSEPA.Location = New System.Drawing.Point(311, 14)
        Me.CmbTipoFicheroSEPA.Name = "CmbTipoFicheroSEPA"
        Me.CmbTipoFicheroSEPA.SelectedIndex = -1
        Me.CmbTipoFicheroSEPA.SelectedItem = Nothing
        Me.CmbTipoFicheroSEPA.Size = New System.Drawing.Size(99, 21)
        Me.CmbTipoFicheroSEPA.TabIndex = 26
        Me.CmbTipoFicheroSEPA.ValueMember = "Value"
        '
        'LblTipoFicheroSEPA
        '
        Me.LblTipoFicheroSEPA.Location = New System.Drawing.Point(220, 18)
        Me.LblTipoFicheroSEPA.Name = "LblTipoFicheroSEPA"
        Me.LblTipoFicheroSEPA.Size = New System.Drawing.Size(76, 13)
        Me.LblTipoFicheroSEPA.TabIndex = 25
        Me.LblTipoFicheroSEPA.Text = "Tipo Fichero"
        '
        'rbtCOR1
        '
        Me.rbtCOR1.Location = New System.Drawing.Point(70, 15)
        Me.rbtCOR1.Name = "rbtCOR1"
        Me.rbtCOR1.Size = New System.Drawing.Size(55, 19)
        Me.rbtCOR1.TabIndex = 1
        Me.rbtCOR1.Text = "COR1"
        Me.rbtCOR1.Visible = False
        '
        'rbtB2B
        '
        Me.rbtB2B.Location = New System.Drawing.Point(131, 15)
        Me.rbtB2B.Name = "rbtB2B"
        Me.rbtB2B.Size = New System.Drawing.Size(47, 19)
        Me.rbtB2B.TabIndex = 2
        Me.rbtB2B.Text = "B2B"
        '
        'rbtCore
        '
        Me.rbtCore.Location = New System.Drawing.Point(9, 15)
        Me.rbtCore.Name = "rbtCore"
        Me.rbtCore.Size = New System.Drawing.Size(55, 19)
        Me.rbtCore.TabIndex = 0
        Me.rbtCore.Text = "CORE"
        '
        'lblfwiFechaCargo
        '
        Me.lblfwiFechaCargo.Location = New System.Drawing.Point(217, 18)
        Me.lblfwiFechaCargo.Name = "lblfwiFechaCargo"
        Me.lblfwiFechaCargo.Size = New System.Drawing.Size(79, 13)
        Me.lblfwiFechaCargo.TabIndex = 23
        Me.lblfwiFechaCargo.Tag = "IdRec=6587;"
        Me.lblfwiFechaCargo.Text = "Fecha Cargo"
        Me.lblfwiFechaCargo.Visible = False
        '
        'lblfwiFechaNeg
        '
        Me.lblfwiFechaNeg.Location = New System.Drawing.Point(220, 8)
        Me.lblfwiFechaNeg.Name = "lblfwiFechaNeg"
        Me.lblfwiFechaNeg.Size = New System.Drawing.Size(88, 13)
        Me.lblfwiFechaNeg.TabIndex = 24
        Me.lblfwiFechaNeg.Tag = "IdRec=5716;"
        Me.lblfwiFechaNeg.Text = "Fecha Emisión"
        '
        'fwiFechaCargo
        '
        Me.fwiFechaCargo.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaCargo.Location = New System.Drawing.Point(311, 14)
        Me.fwiFechaCargo.Name = "fwiFechaCargo"
        Me.fwiFechaCargo.Size = New System.Drawing.Size(99, 21)
        Me.fwiFechaCargo.TabIndex = 5
        Me.fwiFechaCargo.Visible = False
        '
        'fwiFechaNeg
        '
        Me.fwiFechaNeg.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaNeg.Location = New System.Drawing.Point(311, 4)
        Me.fwiFechaNeg.Name = "fwiFechaNeg"
        Me.fwiFechaNeg.Size = New System.Drawing.Size(99, 21)
        Me.fwiFechaNeg.TabIndex = 4
        '
        'fwiGenFich58
        '
        Me.fwiGenFich58.Location = New System.Drawing.Point(114, 14)
        Me.fwiGenFich58.Name = "fwiGenFich58"
        Me.fwiGenFich58.Size = New System.Drawing.Size(83, 19)
        Me.fwiGenFich58.TabIndex = 3
        Me.fwiGenFich58.Text = "Fichero 58"
        '
        'fwiTexto58
        '
        Me.fwiTexto58.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTexto58.Enabled = False
        Me.fwiTexto58.Location = New System.Drawing.Point(222, 14)
        Me.fwiTexto58.Name = "fwiTexto58"
        Me.fwiTexto58.Size = New System.Drawing.Size(187, 21)
        Me.fwiTexto58.TabIndex = 4
        Me.fwiTexto58.Text = " Cada efecto con su Fecha Vto."
        Me.fwiTexto58.Visible = False
        '
        'FraFicherosObsoletos
        '
        Me.FraFicherosObsoletos.Controls.Add(Me.fwiGenFich19)
        Me.FraFicherosObsoletos.Controls.Add(Me.fwiGenFich58)
        Me.FraFicherosObsoletos.Controls.Add(Me.fwiTexto58)
        Me.FraFicherosObsoletos.Controls.Add(Me.fwiFechaCargo)
        Me.FraFicherosObsoletos.Controls.Add(Me.lblfwiFechaCargo)
        Me.FraFicherosObsoletos.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraFicherosObsoletos.Location = New System.Drawing.Point(3, 89)
        Me.FraFicherosObsoletos.Name = "FraFicherosObsoletos"
        Me.FraFicherosObsoletos.Size = New System.Drawing.Size(423, 41)
        Me.FraFicherosObsoletos.TabIndex = 2
        Me.FraFicherosObsoletos.TabStop = False
        '
        'fwiGenFich19
        '
        Me.fwiGenFich19.Location = New System.Drawing.Point(9, 14)
        Me.fwiGenFich19.Name = "fwiGenFich19"
        Me.fwiGenFich19.Size = New System.Drawing.Size(90, 19)
        Me.fwiGenFich19.TabIndex = 0
        Me.fwiGenFich19.Text = "Fichero 19"
        '
        'FraBanco
        '
        Me.FraBanco.Controls.Add(Me.lblfwiSufijo)
        Me.FraBanco.Controls.Add(Me.lblfwiBancoPropio)
        Me.FraBanco.Controls.Add(Me.fwiSufijo)
        Me.FraBanco.Controls.Add(Me.fwiBancoPropio)
        Me.FraBanco.Controls.Add(Me.lblcfwiBanco)
        Me.FraBanco.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraBanco.Location = New System.Drawing.Point(0, 283)
        Me.FraBanco.Name = "FraBanco"
        Me.FraBanco.Size = New System.Drawing.Size(429, 67)
        Me.FraBanco.TabIndex = 3
        Me.FraBanco.TabStop = False
        Me.FraBanco.Tag = "IdRec=0;"
        '
        'lblfwiSufijo
        '
        Me.lblfwiSufijo.Location = New System.Drawing.Point(9, 39)
        Me.lblfwiSufijo.Name = "lblfwiSufijo"
        Me.lblfwiSufijo.Size = New System.Drawing.Size(96, 13)
        Me.lblfwiSufijo.TabIndex = 27
        Me.lblfwiSufijo.Tag = "IdRec=6590;"
        Me.lblfwiSufijo.Text = "Sufijo Remesas"
        '
        'lblfwiBancoPropio
        '
        Me.lblfwiBancoPropio.Location = New System.Drawing.Point(9, 15)
        Me.lblfwiBancoPropio.Name = "lblfwiBancoPropio"
        Me.lblfwiBancoPropio.Size = New System.Drawing.Size(92, 13)
        Me.lblfwiBancoPropio.TabIndex = 28
        Me.lblfwiBancoPropio.Tag = "IdRec=6588;"
        Me.lblfwiBancoPropio.Text = "Banco Remesa"
        '
        'fwiSufijo
        '
        Me.fwiSufijo.DisabledBackColor = System.Drawing.Color.White
        Me.fwiSufijo.Location = New System.Drawing.Point(107, 39)
        Me.fwiSufijo.Name = "fwiSufijo"
        Me.fwiSufijo.Size = New System.Drawing.Size(53, 21)
        Me.fwiSufijo.TabIndex = 1
        '
        'fwiBancoPropio
        '
        fwiBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("fwiBancoPropio_DesignTimeLayout.LayoutString")
        Me.fwiBancoPropio.DesignTimeLayout = fwiBancoPropio_DesignTimeLayout
        Me.fwiBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.fwiBancoPropio.EntityName = "BancoPropio"
        Me.fwiBancoPropio.Location = New System.Drawing.Point(107, 15)
        Me.fwiBancoPropio.Name = "fwiBancoPropio"
        Me.fwiBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.fwiBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.fwiBancoPropio.SelectedIndex = -1
        Me.fwiBancoPropio.SelectedItem = Nothing
        Me.fwiBancoPropio.Size = New System.Drawing.Size(53, 21)
        Me.fwiBancoPropio.TabIndex = 0
        Me.fwiBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'lblcfwiBanco
        '
        Me.TryDataBinding(lblcfwiBanco, New System.Windows.Forms.Binding("Text", Me.fwiBancoPropio, "DescBancoPropio", True))
        Me.lblcfwiBanco.Location = New System.Drawing.Point(164, 16)
        Me.lblcfwiBanco.Name = "lblcfwiBanco"
        Me.lblcfwiBanco.Size = New System.Drawing.Size(208, 21)
        Me.lblcfwiBanco.TabIndex = 24
        '
        'FraConta
        '
        Me.FraConta.Controls.Add(Me.Label1)
        Me.FraConta.Controls.Add(Me.fwiNDocumento)
        Me.FraConta.Controls.Add(Me.Label2)
        Me.FraConta.Controls.Add(Me.fwiFechaValor)
        Me.FraConta.Controls.Add(Me.lblfwiFechaAsiento)
        Me.FraConta.Controls.Add(Me.lblfwiEjercicio)
        Me.FraConta.Controls.Add(Me.lblfwiTextoAsiento)
        Me.FraConta.Controls.Add(Me.fwiFechaAsiento)
        Me.FraConta.Controls.Add(Me.lblcfwiEjercicio)
        Me.FraConta.Controls.Add(Me.fwiTextoAsiento)
        Me.FraConta.Controls.Add(Me.fwiEjercicio)
        Me.FraConta.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraConta.Location = New System.Drawing.Point(0, 350)
        Me.FraConta.Name = "FraConta"
        Me.FraConta.Size = New System.Drawing.Size(429, 142)
        Me.FraConta.TabIndex = 4
        Me.FraConta.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Tag = "IdRec=4739;"
        Me.Label1.Text = "Documento"
        '
        'fwiNDocumento
        '
        Me.fwiNDocumento.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNDocumento.Location = New System.Drawing.Point(122, 113)
        Me.fwiNDocumento.Name = "fwiNDocumento"
        Me.fwiNDocumento.Size = New System.Drawing.Size(104, 21)
        Me.fwiNDocumento.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Tag = "IdRec=5024;"
        Me.Label2.Text = "Fecha Valor"
        '
        'fwiFechaValor
        '
        Me.fwiFechaValor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaValor.Location = New System.Drawing.Point(122, 90)
        Me.fwiFechaValor.Name = "fwiFechaValor"
        Me.fwiFechaValor.Size = New System.Drawing.Size(104, 21)
        Me.fwiFechaValor.TabIndex = 3
        '
        'lblfwiFechaAsiento
        '
        Me.lblfwiFechaAsiento.Location = New System.Drawing.Point(9, 41)
        Me.lblfwiFechaAsiento.Name = "lblfwiFechaAsiento"
        Me.lblfwiFechaAsiento.Size = New System.Drawing.Size(86, 13)
        Me.lblfwiFechaAsiento.TabIndex = 29
        Me.lblfwiFechaAsiento.Tag = "IdRec=4794;"
        Me.lblfwiFechaAsiento.Text = "Fecha Asiento"
        '
        'lblfwiEjercicio
        '
        Me.lblfwiEjercicio.Location = New System.Drawing.Point(9, 17)
        Me.lblfwiEjercicio.Name = "lblfwiEjercicio"
        Me.lblfwiEjercicio.Size = New System.Drawing.Size(110, 13)
        Me.lblfwiEjercicio.TabIndex = 31
        Me.lblfwiEjercicio.Tag = "IdRec=4772;"
        Me.lblfwiEjercicio.Text = "Ejercicio Contable"
        '
        'lblfwiTextoAsiento
        '
        Me.lblfwiTextoAsiento.Location = New System.Drawing.Point(9, 65)
        Me.lblfwiTextoAsiento.Name = "lblfwiTextoAsiento"
        Me.lblfwiTextoAsiento.Size = New System.Drawing.Size(105, 13)
        Me.lblfwiTextoAsiento.TabIndex = 34
        Me.lblfwiTextoAsiento.Tag = "IdRec=4773;"
        Me.lblfwiTextoAsiento.Text = "Texto del Asiento"
        '
        'fwiFechaAsiento
        '
        Me.fwiFechaAsiento.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaAsiento.Location = New System.Drawing.Point(122, 41)
        Me.fwiFechaAsiento.Name = "fwiFechaAsiento"
        Me.fwiFechaAsiento.Size = New System.Drawing.Size(101, 21)
        Me.fwiFechaAsiento.TabIndex = 1
        '
        'lblcfwiEjercicio
        '
        Me.lblcfwiEjercicio.Location = New System.Drawing.Point(193, 17)
        Me.lblcfwiEjercicio.Name = "lblcfwiEjercicio"
        Me.lblcfwiEjercicio.Size = New System.Drawing.Size(184, 21)
        Me.lblcfwiEjercicio.TabIndex = 32
        '
        'fwiTextoAsiento
        '
        Me.fwiTextoAsiento.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTextoAsiento.Location = New System.Drawing.Point(122, 65)
        Me.fwiTextoAsiento.Name = "fwiTextoAsiento"
        Me.fwiTextoAsiento.Size = New System.Drawing.Size(256, 21)
        Me.fwiTextoAsiento.TabIndex = 2
        '
        'fwiEjercicio
        '
        fwiEjercicio_DesignTimeLayout.LayoutString = resources.GetString("fwiEjercicio_DesignTimeLayout.LayoutString")
        Me.fwiEjercicio.DesignTimeLayout = fwiEjercicio_DesignTimeLayout
        Me.fwiEjercicio.DisabledBackColor = System.Drawing.Color.White
        Me.fwiEjercicio.EntityName = "EjercicioContable"
        Me.fwiEjercicio.Location = New System.Drawing.Point(122, 17)
        Me.fwiEjercicio.Name = "fwiEjercicio"
        Me.fwiEjercicio.PrimaryDataFields = "IDEjercicio"
        Me.fwiEjercicio.SecondaryDataFields = "IDEjercicio"
        Me.fwiEjercicio.SelectedIndex = -1
        Me.fwiEjercicio.SelectedItem = Nothing
        Me.fwiEjercicio.Size = New System.Drawing.Size(67, 21)
        Me.fwiEjercicio.TabIndex = 0
        Me.fwiEjercicio.ViewName = "tbMaestroEjercicio"
        '
        'FraFicheros
        '
        Me.FraFicheros.Controls.Add(Me.FraFicherosObsoletos)
        Me.FraFicheros.Controls.Add(Me.FraGenFicherosSEPA)
        Me.FraFicheros.Controls.Add(Me.pnlFechaEmision)
        Me.FraFicheros.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraFicheros.Location = New System.Drawing.Point(0, 143)
        Me.FraFicheros.Name = "FraFicheros"
        Me.FraFicheros.Size = New System.Drawing.Size(429, 140)
        Me.FraFicheros.TabIndex = 2
        Me.FraFicheros.TabStop = False
        Me.FraFicheros.Text = "Ficheros"
        '
        'pnlFechaEmision
        '
        Me.pnlFechaEmision.Controls.Add(Me.lblfwiFechaNeg)
        Me.pnlFechaEmision.Controls.Add(Me.fwiFechaNeg)
        Me.pnlFechaEmision.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFechaEmision.Location = New System.Drawing.Point(3, 17)
        Me.pnlFechaEmision.Name = "pnlFechaEmision"
        Me.pnlFechaEmision.Size = New System.Drawing.Size(423, 31)
        Me.pnlFechaEmision.TabIndex = 0
        '
        'frmRemesaDefinitiva
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(429, 552)
        Me.Controls.Add(Me.FraConta)
        Me.Controls.Add(Me.FraBanco)
        Me.Controls.Add(Me.FraFicheros)
        Me.Controls.Add(Me.wlfOpciones)
        Me.Controls.Add(Me.FraNumRemesa)
        Me.Controls.Add(Me.pnlBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRemesaDefinitiva"
        Me.Text = "Datos para la Remesa"
        Me.pnlBottom.ResumeLayout(False)
        Me.FraNumRemesa.ResumeLayout(False)
        Me.FraNumRemesa.PerformLayout()
        Me.wlfOpciones.ResumeLayout(False)
        Me.wlfOpciones.PerformLayout()
        CType(Me.fwiTipoRemesa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraGenFicherosSEPA.ResumeLayout(False)
        Me.FraGenFicherosSEPA.PerformLayout()
        CType(Me.CmbTipoFicheroSEPA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraFicherosObsoletos.ResumeLayout(False)
        Me.FraFicherosObsoletos.PerformLayout()
        Me.FraBanco.ResumeLayout(False)
        Me.FraBanco.PerformLayout()
        CType(Me.fwiBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraConta.ResumeLayout(False)
        Me.FraConta.PerformLayout()
        CType(Me.fwiEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraFicheros.ResumeLayout(False)
        Me.pnlFechaEmision.ResumeLayout(False)
        Me.pnlFechaEmision.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mstrRuta As String
    'Protected mstrRutaFicheroSEPA As String
    Private mIDRemesa As Integer
    Private mblnEspecial, mblnModificacion As Boolean
    Private mBlnContabilidad As Boolean
    Public mblnAsientoRemesa As Boolean
    Public mstrEjercicio, mstrComentarioRemesa, mstrBancoPropio As String
    Public mdtmFechaAsiento As Date
    Public mintTipoAsientoRemesa As Integer

    Private mblnLoading As Boolean


    'Private cnFICH_CORE As String = ""
    'Private cnFICH_B2B As String = ""


#Region " Propiedades "

    Public WriteOnly Property Especial() As Boolean
        Set(ByVal Value As Boolean)
            mblnEspecial = Value
        End Set
    End Property

    Public WriteOnly Property Modificacion() As Boolean
        Set(ByVal Value As Boolean)
            mblnModificacion = Value
        End Set
    End Property

    Public WriteOnly Property Cobros() As DataTable
        Set(ByVal Value As DataTable)
            mdtCobros = Value     'rs que contiene los cobros que se veran en el informe
        End Set
    End Property

    Public WriteOnly Property IdRemesa() As Long
        Set(ByVal Value As Long)
            mIDRemesa = Value
        End Set
    End Property

    Public ReadOnly Property ContabilizarGastosAsociados() As Boolean
        Get
            Return Me.chkGenerarAsientoConGastos.Checked
        End Get
    End Property

    Public WriteOnly Property MostrarContabilizacionGastosAsociados() As Boolean
        Set(ByVal value As Boolean)
            Me.chkGenerarAsientoConGastos.Visible = value
        End Set
    End Property

    Private mIDProcess As Guid
    Public WriteOnly Property IDProcess() As Guid
        Set(ByVal value As Guid)
            mIDProcess = value
        End Set
    End Property

#End Region

#Region " Load "

    Public Function AbrirRemesaDefinitiva(Optional ByVal blnModificacion As Boolean = True, _
                                     Optional ByVal dtCobros As DataTable = Nothing, _
                                     Optional ByVal blnEspecial As Boolean = False, _
                                     Optional ByVal IDRemesa As Integer = 0) As DialogResult

        'RECIBE: -blnModificacion que indica si este formulario se abre para hacer una modif o una insercion
        '        -si es una insercion, recibe un rs con las remesas
        '        -si es una modificacion, recibe el Id de la remesa a modificar
        '        -blnEspecial que indica si se debe filtar el ejercicio, si va a IVA o no
        mblnEspecial = blnEspecial
        mblnModificacion = blnModificacion

        'Comprobamos si se va a crear una remesa nueva o modificar una que ya existe
        If Not blnModificacion Then 'Si se va a crear una remesa nueva dtCobros que contiene los cobros que se veran en el informe
            mdtCobros = dtCobros
        Else                        ' Si se va a modificar una remesa
            mIDRemesa = IDRemesa
        End If

        Dim FilEjer As New Filter
        FilEjer.Add("EjercicioCerrado", FilterOperator.Equal, False, FilterType.Boolean)
        Me.fwiEjercicio.Filter = FilEjer

        Me.ShowDialog()

        Return Me.DialogResult
    End Function

    Private Sub frmRemesaDefinitiva_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            mblnLoading = True

            'Cargamos el input con los tipos de remesa
            Me.fwiTipoRemesa.DataSource = New EnumData("enumTipoRemesa")
            If TypeOf Me.fwiTipoRemesa.DataSource Is DataView Then
                CType(Me.fwiTipoRemesa.DataSource, DataView).RowFilter = "Name = 'enumTipoRemesa' AND Value < " & enumTipoRemesa.RemesaAnticipo
            End If


            'Comprobamos si se va a crear una remesa nueva o modificar una que ya existe
            Dim p As New Parametro
            mBlnContabilidad = p.Contabilidad
            Me.fwiGenAsientos.Visible = mBlnContabilidad
            Me.fwiGenAsientos.Checked = mBlnContabilidad
            Me.FraConta.Visible = mBlnContabilidad

            Me.CmbTipoFicheroSEPA.DataSource = EnumData.EnumView("enumFormatoFicheroSEPA")
            Me.CmbTipoFicheroSEPA.Value = enumFormatoFicheroSEPA.XML

            If Not mblnModificacion Then 'Si se va a crear una remesa nueva
                fwiGenAsientos.Checked = p.GenerarAsientoCobro()
                mIDRemesa = ExpertisApp.ExecuteTask(Of Object, Integer)(AddressOf Cobro.NuevoIdRemesa, Nothing)

                txtIDRemesa.Text = IIf(mIDRemesa = -1, String.Empty, mIDRemesa)

                'Ponemos el TipoRemesa por defecto
                fwiTipoRemesa.Value = CInt(enumTipoRemesa.RemesaAlCobro)
                fwiFechaNeg.Value = Today
                fwiFechaAsiento.Value = Today

                Dim FechaValor As Date = ExpertisApp.ExecuteTask(Of String, Date)(AddressOf Remesa.FechaValorProv, mIDProcess.ToString)
                If FechaValor <> cnMinDate Then
                    fwiFechaValor.Value = FechaValor
                End If
            Else    ' Si se va a modificar una remesa
                'fwiSufijo.Enabled = False
                fwiBancoPropio.Enabled = False
                fwiTipoRemesa.Enabled = False

                'Recuperamos los datos de la remesa
                Dim dtRemesa As DataTable = New Remesa().SelOnPrimaryKey(mIDRemesa)
                If Not IsNothing(dtRemesa) AndAlso dtRemesa.Rows.Count > 0 Then
                    With dtRemesa
                        txtIDRemesa.Text = .Rows(0)("IDRemesa")
                        fwiBancoPropio.Value = .Rows(0)("IdBancopropio")
                        Dim dtBPropio As DataTable = New BancoPropio().SelOnPrimaryKey(.Rows(0)("IdBancopropio"))
                        If Not IsNothing(dtBPropio) AndAlso dtBPropio.Rows.Count > 0 Then
                            fwiSufijo.Text = dtBPropio.Rows(0)("Sufijoremesas") & String.Empty
                        End If
                        fwiFechaNeg.Value = .Rows(0)("FechaNegociacion")
                        fwiTipoRemesa.Value = CInt(.Rows(0)("IdTipoNegociacion"))
                        If Length(.Rows(0)("FechaCargo")) > 0 Then
                            fwiFechaCargo.Value = .Rows(0)("FechaCargo")
                            fwiFechaCargo.Top = fwiGenFich58.Top
                            lblfwiFechaCargo.Visible = False
                            fwiFechaCargo.Visible = False
                        End If
                        fwiFechaAsiento.Value = Today
                        Dim FechaValor As Date = ExpertisApp.ExecuteTask(Of Integer, Date)(AddressOf Remesa.FechaValor, mIDRemesa)
                        If FechaValor <> cnMinDate Then
                            fwiFechaValor.Value = FechaValor
                        End If

                    End With
                End If

                'Cargamos en un dt los cobros que se verán en el informe
                mdtCobros = New DataEngine().Filter("frmCobros", New NumberFilterItem("IDRemesa", mIDRemesa))
            End If
        End If
        mblnLoading = False
        fwiTipoRemesa.Focus()
    End Sub

#End Region

#Region " Validaciones controles formulario "

    Private Sub fwiGenFich19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiGenFich19.CheckedChanged

        If fwiGenFich19.Checked Then
            fwiGenFich58.Checked = False
            fwiTexto58.Visible = False

            fwiFechaNeg.Value = IIf(Len(fwiFechaNeg.Value) > 0, fwiFechaNeg.Value, Date.Today)

            mstrRuta = String.Empty
            SaveFileDialog1.Filter = String.Empty
            SaveFileDialog1.FileName = String.Empty
            SaveFileDialog1.ShowDialog()
            mstrRuta = SaveFileDialog1.FileName

            If Len(mstrRuta) = 0 Then
                'Si se ha cancelado el Save
                fwiGenFich19.Checked = False
            Else
                fwiFechaCargo.Top = fwiGenFich58.Top
                lblfwiFechaCargo.Visible = True
                fwiFechaCargo.Visible = True
            End If
        Else
            lblfwiFechaCargo.Visible = False
            fwiFechaCargo.Visible = False
        End If

    End Sub
    Private Sub fwiGenFich58_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiGenFich58.CheckedChanged


        If fwiGenFich58.Checked Then
            fwiGenFich19.Checked = False
            lblfwiFechaCargo.Visible = False
            fwiFechaCargo.Visible = False

            fwiFechaNeg.Value = IIf(Len(fwiFechaNeg.Value) > 0, fwiFechaNeg.Value, Date.Today)

            mstrRuta = String.Empty
            SaveFileDialog1.Filter = String.Empty
            SaveFileDialog1.FileName = String.Empty
            SaveFileDialog1.ShowDialog()
            mstrRuta = SaveFileDialog1.FileName

            If Len(mstrRuta) = 0 Then
                fwiGenFich58.Checked = False
            Else
                fwiTexto58.Visible = True
            End If
        Else
            fwiTexto58.Visible = False
        End If

    End Sub

    'PENDIENTE: Filtrar el ComboBox de fwiEjercicio
    Private Sub fwiEjercicio_SetPredefinedFilter(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs)
        e.Filter.Add("AIva", FilterOperator.NotEqual, mblnEspecial)
    End Sub

    Private Sub fwiBancoPropio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiBancoPropio.ValueChanged
        '// Se carga el SufijoRemesas del Banco Propio seleccionado.
        If Not IsNothing(fwiBancoPropio.SelectedItem) Then
            fwiSufijo.Text = Nz(fwiBancoPropio.SelectedItem("SufijoRemesas"), String.Empty)
        Else
            fwiSufijo.Text = String.Empty
        End If
    End Sub

    Private Sub fwiBancoPropio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fwiBancoPropio.Validating
        'Se comprueba que el banco existe.
        Dim objNegBP As BancoPropio
        Dim dtBP As DataTable

        Try
            e.Cancel = False

            If Len(fwiBancoPropio.Value) > 0 Then
                objNegBP = New BancoPropio
                dtBP = objNegBP.SelOnPrimaryKey(fwiBancoPropio.Value)
                If IsNothing(dtBP) OrElse dtBP.Rows.Count = 0 Then
                    '894: El Banco Propio no existe.
                    ExpertisApp.GenerateMessage("El Banco Propio no existe.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            e.Cancel = True
            ExpertisApp.GenerateMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region " Aceptar "

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        Dim p As New Parametro
        Dim intTipoNeg As Integer = fwiTipoRemesa.Value
        Dim intSituacion As Integer
        If p.ActAutomaticaSituacionRemCobro And (p.TipoAsientoRemesa = 0 Or (p.TipoAsientoRemesa = 1 And intTipoNeg = enumTipoRemesa.RemesaAlCobro)) Then
            intSituacion = enumCobroSituacion.Cobrado
        ElseIf intTipoNeg = enumTipoRemesa.RemesaAlCobro Then
            intSituacion = enumCobroSituacion.Negociado
        Else
            intSituacion = enumCobroSituacion.Descontado
        End If

        If ComprobarObligatorios() Then
            If fwiGenAsientos.Checked OrElse Me.chkGenerarAsientoConGastos.Checked Then
                If Engine.Length(fwiEjercicio.Value) = 0 Then
                    ExpertisApp.GenerateMessage("Debe introducir un Ejercicio Contable.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.fwiEjercicio.Focus()
                    Exit Sub
                ElseIf Engine.Length(fwiFechaAsiento.Value) = 0 Then
                    ExpertisApp.GenerateMessage("Debe introducir una Fecha de Apunte.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.fwiFechaAsiento.Focus()
                    Exit Sub
                ElseIf Engine.Length(fwiBancoPropio.Value) = 0 Then
                    ExpertisApp.GenerateMessage("El Banco Propio es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.fwiBancoPropio.Focus()
                    Exit Sub
                End If

                Dim dtDesde, dtHasta As Date
                Dim dtEjercicio As DataTable = New EjercicioContable().SelOnPrimaryKey(fwiEjercicio.Value)
                If Not IsNothing(dtEjercicio) AndAlso dtEjercicio.Rows.Count > 0 Then
                    dtDesde = dtEjercicio.Rows(0)("FechaDesde")
                    dtHasta = dtEjercicio.Rows(0)("FechaHasta")
                Else
                    ExpertisApp.GenerateMessage("Debe introducir un Ejercicio Contable correcto.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.fwiEjercicio.Focus()
                    Exit Sub
                End If

                If Me.fwiFechaAsiento.Value < dtDesde OrElse Me.fwiFechaAsiento.Value > dtHasta Then
                    ExpertisApp.GenerateMessage("La fecha introducida no pertenece al Ejercicio Seleccionado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Me.Cursor = Cursors.WaitCursor
                mblnAsientoRemesa = True
                mstrEjercicio = fwiEjercicio.Value
                mdtmFechaAsiento = fwiFechaAsiento.Value
                mintTipoAsientoRemesa = intTipoNeg
                mstrBancoPropio = fwiBancoPropio.Value
                mdtFechaValor = Nz(fwiFechaValor.Value, cnMinDate)
                mstrNDocumento = fwiNDocumento.Text
                If Engine.Length(fwiTextoAsiento.Text) Then mstrComentarioRemesa = fwiTextoAsiento.Text
            Else
                mblnAsientoRemesa = False
            End If

            Dim dtmFecha As Date = fwiFechaNeg.Value

            'Si se esta generando una remesa nueva
            ' Dim dtmFechaCargo As Date
            Dim dtRemesa As DataTable
            Dim blnInsertado As Boolean
            If Not mblnModificacion OrElse (mIDRemesa <> 0 AndAlso mblnModificacion) Then
                If Not mblnModificacion Then mIDRemesa = 0
                Dim objNegCobro As New Cobro
                'Insertamos la remesa y actualizamos los cobros remesados
                Dim ur As New Cobro.DataUpdateRemesa
                ur.IDBancoPropio = fwiBancoPropio.Text
                ur.TipoNegociacion = intTipoNeg
                ur.FechaEmision = dtmFecha
                ur.Cobros = mdtCobros
                ur.Situacion = intSituacion
                ur.IDRemesa = mIDRemesa
                If fwiGenFich19.Checked Then
                    ur.FechaCargo = fwiFechaCargo.Value
                    ur.Ruta = mstrRuta
                    dtRemesa = ExpertisApp.ExecuteTask(Of Cobro.DataUpdateRemesa, DataTable)(AddressOf Cobro.UpdateRemesa, ur)
                ElseIf fwiGenFich58.Checked Then
                    ur.Ruta = mstrRuta
                    dtRemesa = ExpertisApp.ExecuteTask(Of Cobro.DataUpdateRemesa, DataTable)(AddressOf Cobro.UpdateRemesa, ur)
                ElseIf rbtCore.Checked OrElse rbtCOR1.Checked OrElse rbtB2B.Checked Then
                    ur.Ruta = mstrRuta
                    dtRemesa = ExpertisApp.ExecuteTask(Of Cobro.DataUpdateRemesa, DataTable)(AddressOf Cobro.UpdateRemesa, ur)
                Else
                    dtRemesa = ExpertisApp.ExecuteTask(Of Cobro.DataUpdateRemesa, DataTable)(AddressOf Cobro.UpdateRemesa, ur)
                End If
                blnInsertado = True
            End If

            Dim intIDRemesa As Integer = txtIDRemesa.Text
            If Not dtRemesa Is Nothing AndAlso dtRemesa.Rows.Count > 0 Then
                intIDRemesa = dtRemesa.Rows(0)("IDRemesa")
            End If

            If fwiGenFich19.Checked OrElse fwiGenFich58.Checked OrElse rbtCore.Checked OrElse rbtCOR1.Checked OrElse rbtB2B.Checked Then
                ' blnMonedaA = True
                Dim dtFichero As DataTable
                Dim data As New GenerarFicheros.DataRemesa
                data.IDBanco = fwiBancoPropio.Text
                data.FechaEmision = dtmFecha
                data.Sufijo = fwiSufijo.Text
                data.Remesa = intIDRemesa
                If fwiGenFich19.Checked Then
                    data.FechaCargo = fwiFechaCargo.Value
                    dtFichero = ExpertisApp.ExecuteTask(Of GenerarFicheros.DataRemesa, DataTable)(AddressOf GenerarFicheros.GenerarFichero19, data)
                ElseIf fwiGenFich58.Checked Then
                    dtFichero = ExpertisApp.ExecuteTask(Of GenerarFicheros.DataRemesa, DataTable)(AddressOf GenerarFicheros.GenerarFichero58, data)
                ElseIf rbtCore.Checked OrElse rbtCOR1.Checked OrElse rbtB2B.Checked Then
                    dtFichero = GenerarFicherosSEPA(intIDRemesa)
                End If

                If dtFichero.Rows.Count > 0 AndAlso GuardarFichero(dtFichero) Then
                    ExpertisApp.GenerateMessage("Fichero generado con éxito.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                If Not blnInsertado Then
                    'Guardamos la ruta del nuevo fichero
                    Dim ur As New Cobro.DataUpdateRemesa
                    ur.FechaEmision = dtmFecha
                    ur.IDRemesa = intIDRemesa
                    If fwiGenFich19.Checked Then
                        ur.FechaCargo = fwiFechaCargo.Value
                        ur.Ruta = mstrRuta
                        dtRemesa = ExpertisApp.ExecuteTask(Of Cobro.DataUpdateRemesa, DataTable)(AddressOf Cobro.UpdateRemesa, ur)
                    ElseIf fwiGenFich58.Checked Then
                        ur.Ruta = mstrRuta
                        dtRemesa = ExpertisApp.ExecuteTask(Of Cobro.DataUpdateRemesa, DataTable)(AddressOf Cobro.UpdateRemesa, ur)
                    ElseIf rbtCore.Checked OrElse rbtCOR1.Checked OrElse rbtB2B.Checked Then
                        ur.Ruta = mstrRuta
                        dtRemesa = ExpertisApp.ExecuteTask(Of Cobro.DataUpdateRemesa, DataTable)(AddressOf Cobro.UpdateRemesa, ur)
                    Else
                        dtRemesa = ExpertisApp.ExecuteTask(Of Cobro.DataUpdateRemesa, DataTable)(AddressOf Cobro.UpdateRemesa, ur)
                    End If
                End If
            End If




            If fwiImprimir.Checked Then
                Me.Close()
                'If Not IsNothing(mrcsCobros) AndAlso mrcsCobros.RecordCount > 0 Then
                '    '    Creamos la cadena con los datos de la cabecera
                '    objNegBP = New BancoPropio
                '    dtBP = objNegBP.SelOnPrimaryKey(fwiBancoPropio.Value)
                '    objNegBP = Nothing
                '    If Not IsNothing(dtBP) AndAlso dtBP.Rows.Count > 0 Then
                '        Dim strFormCab As String
                '        'strFormCab = "NomCedente=" & ExpertisApp.EnterpriseName & "; "
                '        'strFormCab = strFormCab & "TipoRemesa=" & fwiTipoRemesa.Text & ";"
                '        'strFormCab = strFormCab & "NCuenta=" & dtBP.Rows(0)("NCuenta") & "; "
                '        'strFormCab = strFormCab & "DescBancoPropio=" & dtBP.Rows(0)("DescBancoPropio") & "; "
                '        'strFormCab = strFormCab & "FechaNeg=" & Format(IIf(Len(fwiFechaNeg.Value) > 0, fwiFechaNeg.Value, Date.Today), "dd/mm/yyyy") & ";"
                '        'strFormCab = strFormCab & "NRemesa=" & lngIDRemesa

                '        'Creamos el rcs con los datos de las lineas de Cobro
                '        CrearRsInformeLineas(IIf(Len(fwiFechaNeg.Value) > 0, fwiFechaNeg.Value, Date.Today), fwiBancoPropio.Value, fwiTipoRemesa.Value)

                '        oRpt.Formulas("NomCedente").Text = ExpertisApp.EnterpriseName
                '        oRpt.Formulas("TipoRemesa").Text = fwiTipoRemesa.Value
                '        oRpt.Formulas("NCuenta").Text = dtBP.Rows(0)("NCuenta") & String.Empty
                '        oRpt.Formulas("DescBancoPropio").Text = dtBP.Rows(0)("DescBancoPropio") & String.Empty
                '        oRpt.Formulas("FechaNeg").Text = fwiFechaNeg.Value
                '        oRpt.Formulas("NRemesa").Text = lngIDRemesa

                '        oRpt.DataSource = mrcsInforme
                '        mstrReportFormulas = strFormCab

                '        Me.Close()
                '        '       oRpt.Filter.Add(New NumberFilterItem("NRemesa", lngIDRemesa))
                '        oRpt.OpenReport()
                '    End If
                '    '  ExpertisApp. .OpenReport("rptRemesaDefinitiva.rpt", , "Datos de la Remesa", rptCustom)
                'Else
                '    'Si la remesa no tiene cobros
                '    Me.Close()
                'End If

            Else
                Me.Close()
            End If
            intAccion = enumAccion.RemesaDefinitiva
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Function GenerarFicherosSEPA(ByVal IDRemesa As Integer) As DataTable
        If rbtCore.Checked OrElse rbtCOR1.Checked OrElse rbtB2B.Checked Then
            Dim i As Integer = 0
            Dim htCobros As New Hashtable
            For Each drCobro As DataRow In mdtCobros.Rows
                htCobros("IDEnlace" & i) = drCobro("IDCobro")
                i += 1
            Next
            Dim IDProcess As Guid = MarcarRegistro(htCobros, FilterType.Numeric)

            Dim dtFichero As New DataTable
            dtFichero.Columns.Add("Linea", GetType(String))
            Dim datFich As New DataGenerarFichero
            datFich.IDProcess = IDProcess
            datFich.IDBancoPropio = fwiBancoPropio.Text
            datFich.FechaEmision = Nz(fwiFechaNeg.Value, Today)
            datFich.FechaCargo = Nz(fwiFechaCargo.Value, Today)
            datFich.IDRemesa = IDRemesa
            datFich.SufijoRemesa = fwiSufijo.Text
            Select Case CInt(Me.CmbTipoFicheroSEPA.Value)
                Case enumFormatoFicheroSEPA.Plano
                    Dim lstRegsFich As List(Of String)
                    If rbtB2B.Checked Then
                        lstRegsFich = ExpertisApp.ExecuteTask(Of DataGenerarFichero, List(Of String))(AddressOf FicheroCSB19_44_B2B.GenerarFichero, datFich)
                    ElseIf rbtCore.Checked Then
                        lstRegsFich = ExpertisApp.ExecuteTask(Of DataGenerarFichero, List(Of String))(AddressOf FicheroCSB19_14_CORE.GenerarFichero, datFich)
                    ElseIf rbtCOR1.Checked Then
                        lstRegsFich = ExpertisApp.ExecuteTask(Of DataGenerarFichero, List(Of String))(AddressOf FicheroCSB19_15_COR1.GenerarFichero, datFich)
                    End If
                    DesmarcarRegistro(IDProcess, FilterType.Numeric)
                    If Not lstRegsFich Is Nothing Then
                        For Each Registro As String In lstRegsFich
                            Dim drNew As DataRow = dtFichero.NewRow
                            drNew("Linea") = Registro
                            dtFichero.Rows.Add(drNew)
                        Next
                    End If
                Case enumFormatoFicheroSEPA.XML
                    Dim lstRegsFich As Byte()
                    If rbtB2B.Checked Then
                        lstRegsFich = ExpertisApp.ExecuteTask(Of DataGenerarFichero, Byte())(AddressOf Fichero_PAIN_008_001_02.GenerarFicheroB2B, datFich)
                    ElseIf rbtCore.Checked Then
                        lstRegsFich = ExpertisApp.ExecuteTask(Of DataGenerarFichero, Byte())(AddressOf Fichero_PAIN_008_001_02.GenerarFicheroCORE, datFich)
                    ElseIf rbtCOR1.Checked Then
                        lstRegsFich = ExpertisApp.ExecuteTask(Of DataGenerarFichero, Byte())(AddressOf Fichero_PAIN_008_001_02.GenerarFicheroCOR1, datFich)
                    End If
                    DesmarcarRegistro(IDProcess, FilterType.Numeric)
                    If Not lstRegsFich Is Nothing AndAlso lstRegsFich.Length > 0 Then
                        If ERP.SEPA.General.GuardarFicheroXML(lstRegsFich, mstrRuta, IDRemesa, Nz(Me.fwiFechaNeg.Value, Today), False) Then
                            ExpertisApp.GenerateMessage("Fichero generado con éxito.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
            End Select
            Return dtFichero
        End If
    End Function

    Private Function GuardarFichero(ByVal dtFichero As DataTable) As Boolean
        Dim intFile As Integer
        Dim strNombreFichero As String
        Dim row As DataRow

        Try
            GuardarFichero = False

            If Len(mstrRuta) Then
                'Si existe el archivo en la ruta lo elimina
                strNombreFichero = Dir$(mstrRuta)
                If Len(strNombreFichero) Then
                    Kill(mstrRuta)
                End If
                'Abrimos el fichero
                intFile = FreeFile()

                FileOpen(intFile, mstrRuta, OpenMode.Output, OpenAccess.Write, OpenShare.LockReadWrite)

                With dtFichero
                    For Each row In dtFichero.Rows
                        Print(intFile, row("Linea"))
                        Print(intFile, vbNewLine)
                    Next row
                End With

                If Not IsNothing(dtFichero) Then dtFichero.Dispose()
                FileClose(intFile)
                GuardarFichero = True
            Else
                ExpertisApp.GenerateMessage("La Ruta no existe.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            GuardarFichero = False
            ExpertisApp.GenerateMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function ComprobarObligatorios() As Boolean
        If Engine.Length(fwiTipoRemesa.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe indicar el Tipo Remesa.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            fwiTipoRemesa.Focus()
            Exit Function
        ElseIf Engine.Length(fwiBancoPropio.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe indicar un Banco Propio.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            fwiBancoPropio.Focus()
            Exit Function
        ElseIf ((fwiGenFich19.Checked) AndAlso Engine.Length(fwiFechaCargo.Value) = 0) Then
            ExpertisApp.GenerateMessage("Debe indicar una Fecha de Cargo.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            fwiFechaCargo.Focus()
            Exit Function
        ElseIf Length(txtIDRemesa.Text) = 0 Then
            ExpertisApp.GenerateMessage("No hay ningun contador establecido para las Remesas.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Function
        Else
            ComprobarObligatorios = True
        End If

        If fwiGenFich19.Checked OrElse fwiGenFich58.Checked Then 'OrElse rbtCore.Checked OrElse rbtCOR1.Checked OrElse rbtB2B.Checked Then
            'Si se va a generar fichero, sera obligatorio el BancoRemesa
            If Engine.Length(fwiBancoPropio.Value) = 0 OrElse Engine.Length(fwiFechaNeg.Value) = 0 Then
                ExpertisApp.GenerateMessage("Debe indicar una Fecha de Emisión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                fwiFechaNeg.Focus()
                ComprobarObligatorios = False
            Else
                ComprobarObligatorios = True
            End If
        End If

        '//Ficheros SEPA
        'If rbtCore.Checked OrElse rbtCOR1.Checked OrElse rbtB2B.Checked Then
        '    'Dim CobrosSinCta As List(Of DataRow) = (From c In mdtCobros Where c.IsNull("IDClienteBanco")).ToList
        '    'If CobrosSinCta.Count > 0 Then
        '    '    ExpertisApp.GenerateMessage("La Cuenta Bancaria del Cliente es un dato obligatorio. Revise sus datos.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    '    Exit Function
        '    'End If

        '    Dim CobrosSinMdto As List(Of DataRow) = (From c In mdtCobros Where c.IsNull("IDMandato")).ToList
        '    If CobrosSinMdto.Count > 0 Then
        '        ExpertisApp.GenerateMessage("El mandato es un dato obligatorio. Revise sus datos.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        Return False
        '    End If

        '    If fwiTipoRemesa.Value = enumTipoRemesa.RemesaAlCobro Then
        '        If mdtCobros.Columns.Contains("IDMandato") Then
        '            Dim CobrosMdto As List(Of DataRow) = (From c In mdtCobros Where c.IsNull("IDMandato")).ToList
        '            If CobrosMdto.Count > 0 Then
        '                If ExpertisApp.GenerateMessage("En los cobros seleccionados existen Cobros sin Mandato. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
        '                    Return False
        '                End If
        '            End If

        '            Dim TiposMdtoDistintos As List(Of Object) = (From c In mdtCobros Where Not c.IsNull("IDTipoMandato") Select c("IDTipoMandato") Distinct).ToList
        '            If TiposMdtoDistintos.Count > 1 Then
        '                If ExpertisApp.GenerateMessage("En los cobros seleccionados existen Mandatos de Tipo Core y B2B. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
        '                    Return False
        '                End If
        '            End If
        '        End If
        '    End If
        'End If

    End Function

#End Region

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub chkGenerarAsientoConGastos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenerarAsientoConGastos.CheckedChanged
        If Not mblnLoading AndAlso Me.chkGenerarAsientoConGastos.Checked Then Me.fwiGenAsientos.Checked = False
    End Sub

    Private Sub fwiGenAsientos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiGenAsientos.CheckedChanged
        If Not mblnLoading AndAlso Me.fwiGenAsientos.Checked Then Me.chkGenerarAsientoConGastos.Checked = False
    End Sub

    Private Sub chkCore_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtCore.CheckedChanged
        If rbtCore.Checked Then
            fwiGenFich58.Checked = False
            fwiGenFich19.Checked = False
            rbtB2B.Checked = False
            rbtCOR1.Checked = False

            'fwiTexto58.Visible = False

            fwiFechaNeg.Value = IIf(Len(fwiFechaNeg.Value) > 0, fwiFechaNeg.Value, Date.Today)

            Dim cnEXT_FICHERO As String
            If Me.CmbTipoFicheroSEPA.Value = enumFormatoFicheroSEPA.XML Then
                cnEXT_FICHERO = ".xml"
                SaveFileDialog1.Filter = "Fichero XML |*" & cnEXT_FICHERO & ""
            Else
                cnEXT_FICHERO = ".txt"
                SaveFileDialog1.Filter = "Fichero TXT |*" & cnEXT_FICHERO & ""
            End If
            mstrRuta = String.Empty
            SaveFileDialog1.FileName = String.Empty
            SaveFileDialog1.ShowDialog()
            mstrRuta = SaveFileDialog1.FileName

            If Length(mstrRuta) = 0 Then
                'Si se ha cancelado el Save
                rbtCore.Checked = False
            Else
                fwiFechaCargo.Top = fwiGenFich58.Top
                fwiTexto58.Visible = True
            End If
        Else
            fwiTexto58.Visible = False
        End If
    End Sub

    Private Sub chkCor1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtCOR1.CheckedChanged
        If rbtCOR1.Checked Then
            fwiGenFich58.Checked = False
            fwiGenFich19.Checked = False
            rbtB2B.Checked = False
            rbtCore.Checked = False

            'fwiTexto58.Visible = False

            fwiFechaNeg.Value = IIf(Len(fwiFechaNeg.Value) > 0, fwiFechaNeg.Value, Date.Today)

            Dim cnEXT_FICHERO As String
            If Me.CmbTipoFicheroSEPA.Value = enumFormatoFicheroSEPA.XML Then
                cnEXT_FICHERO = ".xml"
                SaveFileDialog1.Filter = "Fichero XML |*" & cnEXT_FICHERO & ""
            Else
                cnEXT_FICHERO = ".txt"
                SaveFileDialog1.Filter = "Fichero TXT |*" & cnEXT_FICHERO & ""
            End If

            mstrRuta = String.Empty
            SaveFileDialog1.FileName = String.Empty
            SaveFileDialog1.ShowDialog()
            mstrRuta = SaveFileDialog1.FileName

            If Length(mstrRuta) = 0 Then
                'Si se ha cancelado el Save
                rbtCOR1.Checked = False
            Else
                fwiFechaCargo.Top = fwiGenFich58.Top
                fwiTexto58.Visible = True
            End If
        Else
            fwiTexto58.Visible = False
        End If
    End Sub

    Private Sub chkB2B_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtB2B.CheckedChanged
        If rbtB2B.Checked Then
            fwiGenFich58.Checked = False
            fwiGenFich19.Checked = False
            rbtCore.Checked = False
            rbtCOR1.Checked = False

            'fwiTexto58.Visible = False

            fwiFechaNeg.Value = IIf(Len(fwiFechaNeg.Value) > 0, fwiFechaNeg.Value, Date.Today)

            Dim cnEXT_FICHERO As String
            If Me.CmbTipoFicheroSEPA.Value = enumFormatoFicheroSEPA.XML Then
                cnEXT_FICHERO = ".xml"
                SaveFileDialog1.Filter = "Fichero XML |*" & cnEXT_FICHERO & ""
            Else
                cnEXT_FICHERO = ".txt"
                SaveFileDialog1.Filter = "Fichero TXT |*" & cnEXT_FICHERO & ""
            End If
            mstrRuta = String.Empty
            SaveFileDialog1.FileName = String.Empty
            SaveFileDialog1.ShowDialog()
            mstrRuta = SaveFileDialog1.FileName

            If Length(mstrRuta) = 0 Then
                'Si se ha cancelado el Save
                rbtB2B.Checked = False
            Else
                fwiFechaCargo.Top = fwiGenFich58.Top
                fwiTexto58.Visible = True
            End If
        Else
            fwiTexto58.Visible = False
        End If
    End Sub

End Class
