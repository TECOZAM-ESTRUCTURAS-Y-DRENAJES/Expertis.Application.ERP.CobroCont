Public Class frmSeguimientoCobro
    Inherits FormBase

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
    Public WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Public WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiTitulo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiNFactura As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents Label5 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiFechaVencimiento As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents Label6 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblIncidencias As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiIncidencias As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblFwiFacturaAceptadaClte As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFwiFacturaRecibidaClte As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiFacturaAceptadaClte As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents FwiFacturaRecibidaClte As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents FraReclamacionTel1 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FraDatosCobro As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FraDatosFactura As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FwiSituacion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents CmdMasiva As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents lblFwiTextoPrimerRcl As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiTextoPrimerRcl As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblFwiFechaPrimerRcl As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiFechaPrimerRcl As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents CmdPrimera As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents FraReclamacionTel2 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFwiTextoSegunRcl As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiTextoSegunRcl As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents cmdSegunda As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents FwiFechaSegunRcl As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents FraCartaReclamacion As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblFwiTextoCartaRcl As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiTextoCartaRcl As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblFwiFechaCartaRcl As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiFechaCartaRcl As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents cmdCarta As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents FraReclamacionJudicial As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblFwiTextoRclJudicial As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiTextoRclJudicial As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents FwiFechaRclJudicial As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFwiFechaRclJudicial As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cmdJudicial As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents FraOtrosDatos As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblFwiOtrasReclamaciones As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiOtrasReclamaciones As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblFwiFechaSeguimiento As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiFechaSeguimiento As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents cmdOtras As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents pnlBottom As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents SplitMain As System.Windows.Forms.SplitContainer
    Public WithEvents pnlReclamacionesNoTel As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlReclamacionesTel As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents FraAsientosCobro As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents GridAsientos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents fwiSituacionTexto As Solmicro.Expertis.Engine.UI.UnderLineLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeguimientoCobro))
        Dim GridAsientos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.FraReclamacionTel1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.CmdPrimera = New Solmicro.Expertis.Engine.UI.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblFwiFechaPrimerRcl = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaPrimerRcl = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFwiTextoPrimerRcl = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiTextoPrimerRcl = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraDatosCobro = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiSituacionTexto = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.Label6 = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiSituacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label5 = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaVencimiento = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiNFactura = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTitulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraDatosFactura = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFwiFacturaAceptadaClte = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiFacturaRecibidaClte = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFacturaAceptadaClte = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FwiFacturaRecibidaClte = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.CmdMasiva = New Solmicro.Expertis.Engine.UI.Button
        Me.lblIncidencias = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiIncidencias = New Solmicro.Expertis.Engine.UI.TextBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FraReclamacionTel2 = New Solmicro.Expertis.Engine.UI.Frame
        Me.cmdSegunda = New Solmicro.Expertis.Engine.UI.Button
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiTextoSegunRcl = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaSegunRcl = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FwiTextoSegunRcl = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraCartaReclamacion = New Solmicro.Expertis.Engine.UI.Frame
        Me.cmdCarta = New Solmicro.Expertis.Engine.UI.Button
        Me.lblFwiFechaCartaRcl = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiTextoCartaRcl = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaCartaRcl = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FwiTextoCartaRcl = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraReclamacionJudicial = New Solmicro.Expertis.Engine.UI.Frame
        Me.cmdJudicial = New Solmicro.Expertis.Engine.UI.Button
        Me.lblFwiFechaRclJudicial = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiTextoRclJudicial = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaRclJudicial = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FwiTextoRclJudicial = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwiFechaSeguimiento = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaSeguimiento = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cmdOtras = New Solmicro.Expertis.Engine.UI.Button
        Me.lblFwiOtrasReclamaciones = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiOtrasReclamaciones = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraOtrosDatos = New Solmicro.Expertis.Engine.UI.Frame
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.pnlBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.SplitMain = New System.Windows.Forms.SplitContainer
        Me.pnlReclamacionesNoTel = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlReclamacionesTel = New Solmicro.Expertis.Engine.UI.Panel
        Me.FraAsientosCobro = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridAsientos = New Solmicro.Expertis.Engine.UI.Grid
        Me.FraReclamacionTel1.SuspendLayout()
        Me.FraDatosCobro.SuspendLayout()
        Me.FraDatosFactura.SuspendLayout()
        Me.FraReclamacionTel2.SuspendLayout()
        Me.FraCartaReclamacion.SuspendLayout()
        Me.FraReclamacionJudicial.SuspendLayout()
        Me.FraOtrosDatos.SuspendLayout()
        Me.pnlBottom.suspendlayout()
        Me.SplitMain.Panel1.SuspendLayout()
        Me.SplitMain.Panel2.SuspendLayout()
        Me.SplitMain.SuspendLayout()
        Me.pnlReclamacionesNoTel.suspendlayout()
        Me.pnlReclamacionesTel.suspendlayout()
        Me.FraAsientosCobro.SuspendLayout()
        CType(Me.GridAsientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(455, 6)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(99, 29)
        Me.cmbCancelar.TabIndex = 1
        Me.cmbCancelar.Text = "Cancelar"
        '
        'FraReclamacionTel1
        '
        Me.FraReclamacionTel1.Controls.Add(Me.CmdPrimera)
        Me.FraReclamacionTel1.Controls.Add(Me.lblFwiFechaPrimerRcl)
        Me.FraReclamacionTel1.Controls.Add(Me.FwiFechaPrimerRcl)
        Me.FraReclamacionTel1.Controls.Add(Me.lblFwiTextoPrimerRcl)
        Me.FraReclamacionTel1.Controls.Add(Me.FwiTextoPrimerRcl)
        Me.FraReclamacionTel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FraReclamacionTel1.Location = New System.Drawing.Point(0, 0)
        Me.FraReclamacionTel1.Name = "FraReclamacionTel1"
        Me.FraReclamacionTel1.Size = New System.Drawing.Size(440, 135)
        Me.FraReclamacionTel1.TabIndex = 16
        Me.FraReclamacionTel1.TabStop = False
        Me.FraReclamacionTel1.Tag = ""
        Me.FraReclamacionTel1.Text = "1ª Reclamación Telefónica"
        '
        'CmdPrimera
        '
        Me.CmdPrimera.ImageIndex = 0
        Me.CmdPrimera.ImageList = Me.ImageList1
        Me.CmdPrimera.Location = New System.Drawing.Point(408, 40)
        Me.CmdPrimera.Name = "CmdPrimera"
        Me.CmdPrimera.Size = New System.Drawing.Size(25, 25)
        Me.CmdPrimera.TabIndex = 2
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder_edit.ico")
        '
        'lblFwiFechaPrimerRcl
        '
        Me.lblFwiFechaPrimerRcl.Location = New System.Drawing.Point(200, 19)
        Me.lblFwiFechaPrimerRcl.Name = "lblFwiFechaPrimerRcl"
        Me.lblFwiFechaPrimerRcl.Size = New System.Drawing.Size(144, 13)
        Me.lblFwiFechaPrimerRcl.TabIndex = 32
        Me.lblFwiFechaPrimerRcl.Tag = ""
        Me.lblFwiFechaPrimerRcl.Text = "Fª Primera Reclamación"
        '
        'FwiFechaPrimerRcl
        '
        Me.FwiFechaPrimerRcl.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaPrimerRcl.Location = New System.Drawing.Point(344, 15)
        Me.FwiFechaPrimerRcl.Name = "FwiFechaPrimerRcl"
        Me.FwiFechaPrimerRcl.Size = New System.Drawing.Size(89, 21)
        Me.FwiFechaPrimerRcl.TabIndex = 0
        '
        'lblFwiTextoPrimerRcl
        '
        Me.lblFwiTextoPrimerRcl.Location = New System.Drawing.Point(8, 19)
        Me.lblFwiTextoPrimerRcl.Name = "lblFwiTextoPrimerRcl"
        Me.lblFwiTextoPrimerRcl.Size = New System.Drawing.Size(163, 13)
        Me.lblFwiTextoPrimerRcl.TabIndex = 28
        Me.lblFwiTextoPrimerRcl.Tag = ""
        Me.lblFwiTextoPrimerRcl.Text = "Texto Primera Reclamación"
        '
        'FwiTextoPrimerRcl
        '
        Me.FwiTextoPrimerRcl.AcceptsReturn = True
        Me.FwiTextoPrimerRcl.DisabledBackColor = System.Drawing.Color.White
        Me.FwiTextoPrimerRcl.Location = New System.Drawing.Point(8, 40)
        Me.FwiTextoPrimerRcl.Multiline = True
        Me.FwiTextoPrimerRcl.Name = "FwiTextoPrimerRcl"
        Me.FwiTextoPrimerRcl.Size = New System.Drawing.Size(396, 88)
        Me.FwiTextoPrimerRcl.TabIndex = 1
        '
        'FraDatosCobro
        '
        Me.FraDatosCobro.Controls.Add(Me.fwiSituacionTexto)
        Me.FraDatosCobro.Controls.Add(Me.Label6)
        Me.FraDatosCobro.Controls.Add(Me.FwiSituacion)
        Me.FraDatosCobro.Controls.Add(Me.Label5)
        Me.FraDatosCobro.Controls.Add(Me.FwiFechaVencimiento)
        Me.FraDatosCobro.Controls.Add(Me.Label4)
        Me.FraDatosCobro.Controls.Add(Me.FwiNFactura)
        Me.FraDatosCobro.Controls.Add(Me.Label3)
        Me.FraDatosCobro.Controls.Add(Me.fwiTitulo)
        Me.FraDatosCobro.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraDatosCobro.Location = New System.Drawing.Point(0, 0)
        Me.FraDatosCobro.Name = "FraDatosCobro"
        Me.FraDatosCobro.Size = New System.Drawing.Size(884, 51)
        Me.FraDatosCobro.TabIndex = 19
        Me.FraDatosCobro.TabStop = False
        Me.FraDatosCobro.Tag = ""
        Me.FraDatosCobro.Text = "Datos del Cobro"
        '
        'fwiSituacionTexto
        '
        Me.fwiSituacionTexto.Location = New System.Drawing.Point(795, 23)
        Me.fwiSituacionTexto.Name = "fwiSituacionTexto"
        Me.fwiSituacionTexto.Size = New System.Drawing.Size(78, 21)
        Me.fwiSituacionTexto.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(689, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Tag = ""
        Me.Label6.Text = "Situación"
        '
        'FwiSituacion
        '
        Me.FwiSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.FwiSituacion.Enabled = False
        Me.FwiSituacion.Location = New System.Drawing.Point(751, 23)
        Me.FwiSituacion.Name = "FwiSituacion"
        Me.FwiSituacion.Size = New System.Drawing.Size(40, 21)
        Me.FwiSituacion.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(478, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Tag = ""
        Me.Label5.Text = "Fecha Vencimiento"
        '
        'FwiFechaVencimiento
        '
        Me.FwiFechaVencimiento.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaVencimiento.Enabled = False
        Me.FwiFechaVencimiento.Location = New System.Drawing.Point(595, 23)
        Me.FwiFechaVencimiento.Name = "FwiFechaVencimiento"
        Me.FwiFechaVencimiento.Size = New System.Drawing.Size(89, 21)
        Me.FwiFechaVencimiento.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(316, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Tag = ""
        Me.Label4.Text = "Factura"
        '
        'FwiNFactura
        '
        Me.FwiNFactura.DisabledBackColor = System.Drawing.Color.White
        Me.FwiNFactura.Enabled = False
        Me.FwiNFactura.Location = New System.Drawing.Point(369, 23)
        Me.FwiNFactura.Name = "FwiNFactura"
        Me.FwiNFactura.Size = New System.Drawing.Size(104, 21)
        Me.FwiNFactura.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Tag = ""
        Me.Label3.Text = "Título"
        '
        'fwiTitulo
        '
        Me.fwiTitulo.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTitulo.Enabled = False
        Me.fwiTitulo.Location = New System.Drawing.Point(48, 23)
        Me.fwiTitulo.Name = "fwiTitulo"
        Me.fwiTitulo.Size = New System.Drawing.Size(264, 21)
        Me.fwiTitulo.TabIndex = 0
        '
        'FraDatosFactura
        '
        Me.FraDatosFactura.Controls.Add(Me.lblFwiFacturaAceptadaClte)
        Me.FraDatosFactura.Controls.Add(Me.lblFwiFacturaRecibidaClte)
        Me.FraDatosFactura.Controls.Add(Me.FwiFacturaAceptadaClte)
        Me.FraDatosFactura.Controls.Add(Me.FwiFacturaRecibidaClte)
        Me.FraDatosFactura.Controls.Add(Me.CmdMasiva)
        Me.FraDatosFactura.Controls.Add(Me.lblIncidencias)
        Me.FraDatosFactura.Controls.Add(Me.FwiIncidencias)
        Me.FraDatosFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraDatosFactura.Location = New System.Drawing.Point(0, 51)
        Me.FraDatosFactura.Name = "FraDatosFactura"
        Me.FraDatosFactura.Size = New System.Drawing.Size(884, 96)
        Me.FraDatosFactura.TabIndex = 18
        Me.FraDatosFactura.TabStop = False
        Me.FraDatosFactura.Tag = ""
        Me.FraDatosFactura.Text = "Información Relacionada con la Factura"
        '
        'lblFwiFacturaAceptadaClte
        '
        Me.lblFwiFacturaAceptadaClte.Location = New System.Drawing.Point(8, 61)
        Me.lblFwiFacturaAceptadaClte.Name = "lblFwiFacturaAceptadaClte"
        Me.lblFwiFacturaAceptadaClte.Size = New System.Drawing.Size(148, 13)
        Me.lblFwiFacturaAceptadaClte.TabIndex = 30
        Me.lblFwiFacturaAceptadaClte.Tag = ""
        Me.lblFwiFacturaAceptadaClte.Text = "Fª Factura Aceptada Clte"
        '
        'lblFwiFacturaRecibidaClte
        '
        Me.lblFwiFacturaRecibidaClte.Location = New System.Drawing.Point(8, 36)
        Me.lblFwiFacturaRecibidaClte.Name = "lblFwiFacturaRecibidaClte"
        Me.lblFwiFacturaRecibidaClte.Size = New System.Drawing.Size(143, 13)
        Me.lblFwiFacturaRecibidaClte.TabIndex = 31
        Me.lblFwiFacturaRecibidaClte.Tag = ""
        Me.lblFwiFacturaRecibidaClte.Text = "Fª Factura Recibida Clte"
        '
        'FwiFacturaAceptadaClte
        '
        Me.FwiFacturaAceptadaClte.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFacturaAceptadaClte.Location = New System.Drawing.Point(160, 57)
        Me.FwiFacturaAceptadaClte.Name = "FwiFacturaAceptadaClte"
        Me.FwiFacturaAceptadaClte.Size = New System.Drawing.Size(89, 21)
        Me.FwiFacturaAceptadaClte.TabIndex = 1
        '
        'FwiFacturaRecibidaClte
        '
        Me.FwiFacturaRecibidaClte.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFacturaRecibidaClte.Location = New System.Drawing.Point(160, 32)
        Me.FwiFacturaRecibidaClte.Name = "FwiFacturaRecibidaClte"
        Me.FwiFacturaRecibidaClte.Size = New System.Drawing.Size(89, 21)
        Me.FwiFacturaRecibidaClte.TabIndex = 0
        '
        'CmdMasiva
        '
        Me.CmdMasiva.ImageIndex = 0
        Me.CmdMasiva.ImageList = Me.ImageList1
        Me.CmdMasiva.Location = New System.Drawing.Point(848, 32)
        Me.CmdMasiva.Name = "CmdMasiva"
        Me.CmdMasiva.Size = New System.Drawing.Size(25, 25)
        Me.CmdMasiva.TabIndex = 3
        '
        'lblIncidencias
        '
        Me.lblIncidencias.Location = New System.Drawing.Point(264, 13)
        Me.lblIncidencias.Name = "lblIncidencias"
        Me.lblIncidencias.Size = New System.Drawing.Size(71, 13)
        Me.lblIncidencias.TabIndex = 26
        Me.lblIncidencias.Tag = ""
        Me.lblIncidencias.Text = "Incidencias"
        '
        'FwiIncidencias
        '
        Me.FwiIncidencias.AcceptsReturn = True
        Me.FwiIncidencias.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIncidencias.Location = New System.Drawing.Point(264, 32)
        Me.FwiIncidencias.Multiline = True
        Me.FwiIncidencias.Name = "FwiIncidencias"
        Me.FwiIncidencias.Size = New System.Drawing.Size(580, 56)
        Me.FwiIncidencias.TabIndex = 2
        '
        'FraReclamacionTel2
        '
        Me.FraReclamacionTel2.Controls.Add(Me.cmdSegunda)
        Me.FraReclamacionTel2.Controls.Add(Me.Label1)
        Me.FraReclamacionTel2.Controls.Add(Me.lblFwiTextoSegunRcl)
        Me.FraReclamacionTel2.Controls.Add(Me.FwiFechaSegunRcl)
        Me.FraReclamacionTel2.Controls.Add(Me.FwiTextoSegunRcl)
        Me.FraReclamacionTel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.FraReclamacionTel2.Location = New System.Drawing.Point(444, 0)
        Me.FraReclamacionTel2.Name = "FraReclamacionTel2"
        Me.FraReclamacionTel2.Size = New System.Drawing.Size(440, 135)
        Me.FraReclamacionTel2.TabIndex = 20
        Me.FraReclamacionTel2.TabStop = False
        Me.FraReclamacionTel2.Tag = ""
        Me.FraReclamacionTel2.Text = "2ª Reclamación Telefónica"
        '
        'cmdSegunda
        '
        Me.cmdSegunda.ImageIndex = 0
        Me.cmdSegunda.ImageList = Me.ImageList1
        Me.cmdSegunda.Location = New System.Drawing.Point(408, 40)
        Me.cmdSegunda.Name = "cmdSegunda"
        Me.cmdSegunda.Size = New System.Drawing.Size(25, 25)
        Me.cmdSegunda.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(194, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Tag = ""
        Me.Label1.Text = "Fª Segunda Reclamación"
        '
        'lblFwiTextoSegunRcl
        '
        Me.lblFwiTextoSegunRcl.Location = New System.Drawing.Point(8, 19)
        Me.lblFwiTextoSegunRcl.Name = "lblFwiTextoSegunRcl"
        Me.lblFwiTextoSegunRcl.Size = New System.Drawing.Size(168, 13)
        Me.lblFwiTextoSegunRcl.TabIndex = 28
        Me.lblFwiTextoSegunRcl.Tag = ""
        Me.lblFwiTextoSegunRcl.Text = "Texto Segunda Reclamación"
        '
        'FwiFechaSegunRcl
        '
        Me.FwiFechaSegunRcl.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaSegunRcl.Location = New System.Drawing.Point(344, 15)
        Me.FwiFechaSegunRcl.Name = "FwiFechaSegunRcl"
        Me.FwiFechaSegunRcl.Size = New System.Drawing.Size(89, 21)
        Me.FwiFechaSegunRcl.TabIndex = 0
        '
        'FwiTextoSegunRcl
        '
        Me.FwiTextoSegunRcl.AcceptsReturn = True
        Me.FwiTextoSegunRcl.DisabledBackColor = System.Drawing.Color.White
        Me.FwiTextoSegunRcl.Location = New System.Drawing.Point(8, 40)
        Me.FwiTextoSegunRcl.Multiline = True
        Me.FwiTextoSegunRcl.Name = "FwiTextoSegunRcl"
        Me.FwiTextoSegunRcl.Size = New System.Drawing.Size(396, 88)
        Me.FwiTextoSegunRcl.TabIndex = 1
        '
        'FraCartaReclamacion
        '
        Me.FraCartaReclamacion.Controls.Add(Me.cmdCarta)
        Me.FraCartaReclamacion.Controls.Add(Me.lblFwiFechaCartaRcl)
        Me.FraCartaReclamacion.Controls.Add(Me.lblFwiTextoCartaRcl)
        Me.FraCartaReclamacion.Controls.Add(Me.FwiFechaCartaRcl)
        Me.FraCartaReclamacion.Controls.Add(Me.FwiTextoCartaRcl)
        Me.FraCartaReclamacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.FraCartaReclamacion.Location = New System.Drawing.Point(0, 0)
        Me.FraCartaReclamacion.Name = "FraCartaReclamacion"
        Me.FraCartaReclamacion.Size = New System.Drawing.Size(440, 138)
        Me.FraCartaReclamacion.TabIndex = 21
        Me.FraCartaReclamacion.TabStop = False
        Me.FraCartaReclamacion.Tag = ""
        Me.FraCartaReclamacion.Text = "Carta de Reclamación"
        '
        'cmdCarta
        '
        Me.cmdCarta.ImageIndex = 0
        Me.cmdCarta.ImageList = Me.ImageList1
        Me.cmdCarta.Location = New System.Drawing.Point(408, 40)
        Me.cmdCarta.Name = "cmdCarta"
        Me.cmdCarta.Size = New System.Drawing.Size(25, 25)
        Me.cmdCarta.TabIndex = 2
        '
        'lblFwiFechaCartaRcl
        '
        Me.lblFwiFechaCartaRcl.Location = New System.Drawing.Point(213, 20)
        Me.lblFwiFechaCartaRcl.Name = "lblFwiFechaCartaRcl"
        Me.lblFwiFechaCartaRcl.Size = New System.Drawing.Size(131, 13)
        Me.lblFwiFechaCartaRcl.TabIndex = 32
        Me.lblFwiFechaCartaRcl.Tag = ""
        Me.lblFwiFechaCartaRcl.Text = "Fª Carta Reclamación"
        '
        'lblFwiTextoCartaRcl
        '
        Me.lblFwiTextoCartaRcl.Location = New System.Drawing.Point(8, 20)
        Me.lblFwiTextoCartaRcl.Name = "lblFwiTextoCartaRcl"
        Me.lblFwiTextoCartaRcl.Size = New System.Drawing.Size(163, 13)
        Me.lblFwiTextoCartaRcl.TabIndex = 28
        Me.lblFwiTextoCartaRcl.Tag = ""
        Me.lblFwiTextoCartaRcl.Text = "Texto Primera Reclamación"
        '
        'FwiFechaCartaRcl
        '
        Me.FwiFechaCartaRcl.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaCartaRcl.Location = New System.Drawing.Point(344, 15)
        Me.FwiFechaCartaRcl.Name = "FwiFechaCartaRcl"
        Me.FwiFechaCartaRcl.Size = New System.Drawing.Size(89, 21)
        Me.FwiFechaCartaRcl.TabIndex = 0
        '
        'FwiTextoCartaRcl
        '
        Me.FwiTextoCartaRcl.AcceptsReturn = True
        Me.FwiTextoCartaRcl.DisabledBackColor = System.Drawing.Color.White
        Me.FwiTextoCartaRcl.Location = New System.Drawing.Point(8, 40)
        Me.FwiTextoCartaRcl.Multiline = True
        Me.FwiTextoCartaRcl.Name = "FwiTextoCartaRcl"
        Me.FwiTextoCartaRcl.Size = New System.Drawing.Size(396, 88)
        Me.FwiTextoCartaRcl.TabIndex = 1
        '
        'FraReclamacionJudicial
        '
        Me.FraReclamacionJudicial.Controls.Add(Me.cmdJudicial)
        Me.FraReclamacionJudicial.Controls.Add(Me.lblFwiFechaRclJudicial)
        Me.FraReclamacionJudicial.Controls.Add(Me.lblFwiTextoRclJudicial)
        Me.FraReclamacionJudicial.Controls.Add(Me.FwiFechaRclJudicial)
        Me.FraReclamacionJudicial.Controls.Add(Me.FwiTextoRclJudicial)
        Me.FraReclamacionJudicial.Dock = System.Windows.Forms.DockStyle.Right
        Me.FraReclamacionJudicial.Location = New System.Drawing.Point(444, 0)
        Me.FraReclamacionJudicial.Name = "FraReclamacionJudicial"
        Me.FraReclamacionJudicial.Size = New System.Drawing.Size(440, 138)
        Me.FraReclamacionJudicial.TabIndex = 22
        Me.FraReclamacionJudicial.TabStop = False
        Me.FraReclamacionJudicial.Tag = ""
        Me.FraReclamacionJudicial.Text = "Reclamación Judicial"
        '
        'cmdJudicial
        '
        Me.cmdJudicial.ImageIndex = 0
        Me.cmdJudicial.ImageList = Me.ImageList1
        Me.cmdJudicial.Location = New System.Drawing.Point(408, 40)
        Me.cmdJudicial.Name = "cmdJudicial"
        Me.cmdJudicial.Size = New System.Drawing.Size(25, 25)
        Me.cmdJudicial.TabIndex = 2
        '
        'lblFwiFechaRclJudicial
        '
        Me.lblFwiFechaRclJudicial.Location = New System.Drawing.Point(201, 19)
        Me.lblFwiFechaRclJudicial.Name = "lblFwiFechaRclJudicial"
        Me.lblFwiFechaRclJudicial.Size = New System.Drawing.Size(140, 13)
        Me.lblFwiFechaRclJudicial.TabIndex = 32
        Me.lblFwiFechaRclJudicial.Tag = ""
        Me.lblFwiFechaRclJudicial.Text = "Fª Reclamación Judicial"
        '
        'lblFwiTextoRclJudicial
        '
        Me.lblFwiTextoRclJudicial.Location = New System.Drawing.Point(8, 20)
        Me.lblFwiTextoRclJudicial.Name = "lblFwiTextoRclJudicial"
        Me.lblFwiTextoRclJudicial.Size = New System.Drawing.Size(159, 13)
        Me.lblFwiTextoRclJudicial.TabIndex = 28
        Me.lblFwiTextoRclJudicial.Tag = ""
        Me.lblFwiTextoRclJudicial.Text = "Texto Reclamación Judicial"
        '
        'FwiFechaRclJudicial
        '
        Me.FwiFechaRclJudicial.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaRclJudicial.Location = New System.Drawing.Point(344, 15)
        Me.FwiFechaRclJudicial.Name = "FwiFechaRclJudicial"
        Me.FwiFechaRclJudicial.Size = New System.Drawing.Size(89, 21)
        Me.FwiFechaRclJudicial.TabIndex = 0
        '
        'FwiTextoRclJudicial
        '
        Me.FwiTextoRclJudicial.AcceptsReturn = True
        Me.FwiTextoRclJudicial.DisabledBackColor = System.Drawing.Color.White
        Me.FwiTextoRclJudicial.Location = New System.Drawing.Point(8, 40)
        Me.FwiTextoRclJudicial.Multiline = True
        Me.FwiTextoRclJudicial.Name = "FwiTextoRclJudicial"
        Me.FwiTextoRclJudicial.Size = New System.Drawing.Size(396, 88)
        Me.FwiTextoRclJudicial.TabIndex = 1
        '
        'lblFwiFechaSeguimiento
        '
        Me.lblFwiFechaSeguimiento.Location = New System.Drawing.Point(666, 18)
        Me.lblFwiFechaSeguimiento.Name = "lblFwiFechaSeguimiento"
        Me.lblFwiFechaSeguimiento.Size = New System.Drawing.Size(115, 13)
        Me.lblFwiFechaSeguimiento.TabIndex = 31
        Me.lblFwiFechaSeguimiento.Tag = ""
        Me.lblFwiFechaSeguimiento.Text = "Fecha Seguimiento"
        '
        'FwiFechaSeguimiento
        '
        Me.FwiFechaSeguimiento.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaSeguimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FwiFechaSeguimiento.Location = New System.Drawing.Point(784, 14)
        Me.FwiFechaSeguimiento.Name = "FwiFechaSeguimiento"
        Me.FwiFechaSeguimiento.Size = New System.Drawing.Size(89, 21)
        Me.FwiFechaSeguimiento.TabIndex = 0
        '
        'cmdOtras
        '
        Me.cmdOtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdOtras.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOtras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.cmdOtras.ImageIndex = 0
        Me.cmdOtras.ImageList = Me.ImageList1
        Me.cmdOtras.Location = New System.Drawing.Point(848, 39)
        Me.cmdOtras.Name = "cmdOtras"
        Me.cmdOtras.Size = New System.Drawing.Size(25, 25)
        Me.cmdOtras.TabIndex = 2
        '
        'lblFwiOtrasReclamaciones
        '
        Me.lblFwiOtrasReclamaciones.Location = New System.Drawing.Point(8, 18)
        Me.lblFwiOtrasReclamaciones.Name = "lblFwiOtrasReclamaciones"
        Me.lblFwiOtrasReclamaciones.Size = New System.Drawing.Size(127, 13)
        Me.lblFwiOtrasReclamaciones.TabIndex = 26
        Me.lblFwiOtrasReclamaciones.Tag = ""
        Me.lblFwiOtrasReclamaciones.Text = "Otras Reclamaciones"
        '
        'FwiOtrasReclamaciones
        '
        Me.FwiOtrasReclamaciones.AcceptsReturn = True
        Me.FwiOtrasReclamaciones.DisabledBackColor = System.Drawing.Color.White
        Me.FwiOtrasReclamaciones.Location = New System.Drawing.Point(8, 39)
        Me.FwiOtrasReclamaciones.Multiline = True
        Me.FwiOtrasReclamaciones.Name = "FwiOtrasReclamaciones"
        Me.FwiOtrasReclamaciones.Size = New System.Drawing.Size(836, 40)
        Me.FwiOtrasReclamaciones.TabIndex = 1
        '
        'FraOtrosDatos
        '
        Me.FraOtrosDatos.Controls.Add(Me.lblFwiFechaSeguimiento)
        Me.FraOtrosDatos.Controls.Add(Me.FwiFechaSeguimiento)
        Me.FraOtrosDatos.Controls.Add(Me.cmdOtras)
        Me.FraOtrosDatos.Controls.Add(Me.lblFwiOtrasReclamaciones)
        Me.FraOtrosDatos.Controls.Add(Me.FwiOtrasReclamaciones)
        Me.FraOtrosDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraOtrosDatos.Location = New System.Drawing.Point(0, 420)
        Me.FraOtrosDatos.Name = "FraOtrosDatos"
        Me.FraOtrosDatos.Size = New System.Drawing.Size(884, 88)
        Me.FraOtrosDatos.TabIndex = 23
        Me.FraOtrosDatos.TabStop = False
        Me.FraOtrosDatos.Tag = ""
        Me.FraOtrosDatos.Text = "Otros Datos"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(334, 6)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(99, 29)
        Me.cmbAceptar.TabIndex = 0
        Me.cmbAceptar.Text = "Aceptar"
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.cmbAceptar)
        Me.pnlBottom.Controls.Add(Me.cmbCancelar)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 669)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(884, 44)
        Me.pnlBottom.TabIndex = 24
        '
        'SplitMain
        '
        Me.SplitMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitMain.Location = New System.Drawing.Point(0, 0)
        Me.SplitMain.Name = "SplitMain"
        Me.SplitMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitMain.Panel1
        '
        Me.SplitMain.Panel1.Controls.Add(Me.FraOtrosDatos)
        Me.SplitMain.Panel1.Controls.Add(Me.pnlReclamacionesNoTel)
        Me.SplitMain.Panel1.Controls.Add(Me.pnlReclamacionesTel)
        Me.SplitMain.Panel1.Controls.Add(Me.FraDatosFactura)
        Me.SplitMain.Panel1.Controls.Add(Me.FraDatosCobro)
        '
        'SplitMain.Panel2
        '
        Me.SplitMain.Panel2.Controls.Add(Me.FraAsientosCobro)
        Me.SplitMain.Size = New System.Drawing.Size(884, 669)
        Me.SplitMain.SplitterDistance = 500
        Me.SplitMain.TabIndex = 25
        '
        'pnlReclamacionesNoTel
        '
        Me.pnlReclamacionesNoTel.Controls.Add(Me.FraCartaReclamacion)
        Me.pnlReclamacionesNoTel.Controls.Add(Me.FraReclamacionJudicial)
        Me.pnlReclamacionesNoTel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlReclamacionesNoTel.Location = New System.Drawing.Point(0, 282)
        Me.pnlReclamacionesNoTel.Name = "pnlReclamacionesNoTel"
        Me.pnlReclamacionesNoTel.Size = New System.Drawing.Size(884, 138)
        Me.pnlReclamacionesNoTel.TabIndex = 25
        '
        'pnlReclamacionesTel
        '
        Me.pnlReclamacionesTel.Controls.Add(Me.FraReclamacionTel2)
        Me.pnlReclamacionesTel.Controls.Add(Me.FraReclamacionTel1)
        Me.pnlReclamacionesTel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlReclamacionesTel.Location = New System.Drawing.Point(0, 147)
        Me.pnlReclamacionesTel.Name = "pnlReclamacionesTel"
        Me.pnlReclamacionesTel.Size = New System.Drawing.Size(884, 135)
        Me.pnlReclamacionesTel.TabIndex = 24
        '
        'FraAsientosCobro
        '
        Me.FraAsientosCobro.Controls.Add(Me.GridAsientos)
        Me.FraAsientosCobro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraAsientosCobro.Location = New System.Drawing.Point(0, 0)
        Me.FraAsientosCobro.Name = "FraAsientosCobro"
        Me.FraAsientosCobro.Size = New System.Drawing.Size(884, 165)
        Me.FraAsientosCobro.TabIndex = 0
        Me.FraAsientosCobro.TabStop = False
        Me.FraAsientosCobro.Text = "Asientos Contables"
        '
        'GridAsientos
        '
        Me.GridAsientos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridAsientos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridAsientos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridAsientos_DesignTimeLayout.LayoutString = resources.GetString("GridAsientos_DesignTimeLayout.LayoutString")
        Me.GridAsientos.DesignTimeLayout = GridAsientos_DesignTimeLayout
        Me.GridAsientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAsientos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridAsientos.EntityName = "DiarioContable"
        Me.GridAsientos.FrozenColumns = 2
        Me.GridAsientos.Location = New System.Drawing.Point(3, 17)
        Me.GridAsientos.Name = "GridAsientos"
        Me.GridAsientos.PrimaryDataFields = Nothing
        Me.GridAsientos.RequeryManually = True
        Me.GridAsientos.SecondaryDataFields = ""
        Me.GridAsientos.Size = New System.Drawing.Size(878, 145)
        Me.GridAsientos.TabIndex = 2
        Me.GridAsientos.Tag = "IdRec=4595:4734:4596:4735:4736:4737:4738:4739:;"
        Me.GridAsientos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridAsientos.ViewName = "tbDiarioContable"
        '
        'frmSeguimientoCobro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 14)
        Me.ClientSize = New System.Drawing.Size(884, 713)
        Me.Controls.Add(Me.SplitMain)
        Me.Controls.Add(Me.pnlBottom)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeguimientoCobro"
        Me.Text = "Seguimiento del Cobro"
        Me.FraReclamacionTel1.ResumeLayout(False)
        Me.FraReclamacionTel1.PerformLayout()
        Me.FraDatosCobro.ResumeLayout(False)
        Me.FraDatosCobro.PerformLayout()
        Me.FraDatosFactura.ResumeLayout(False)
        Me.FraDatosFactura.PerformLayout()
        Me.FraReclamacionTel2.ResumeLayout(False)
        Me.FraReclamacionTel2.PerformLayout()
        Me.FraCartaReclamacion.ResumeLayout(False)
        Me.FraCartaReclamacion.PerformLayout()
        Me.FraReclamacionJudicial.ResumeLayout(False)
        Me.FraReclamacionJudicial.PerformLayout()
        Me.FraOtrosDatos.ResumeLayout(False)
        Me.FraOtrosDatos.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.SplitMain.Panel1.ResumeLayout(False)
        Me.SplitMain.Panel2.ResumeLayout(False)
        Me.SplitMain.ResumeLayout(False)
        Me.pnlReclamacionesNoTel.ResumeLayout(False)
        Me.pnlReclamacionesTel.ResumeLayout(False)
        Me.FraAsientosCobro.ResumeLayout(False)
        CType(Me.GridAsientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected mIDCobro As Integer

#Region " Carga del formulario "

    Public Overridable Sub MainFunction(ByVal IDCobro As Integer)
        mIDCobro = IDCobro
        LoadDatos()
        LoadAsientosContables()
        Me.ShowDialog()
    End Sub

#End Region

#Region " Botones"

    Protected Overridable Sub cmdCarta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCarta.Click
        Dim strTexto As String = Texto(FwiTextoCartaRcl.Text, lblFwiTextoCartaRcl.Text)
        If Len(strTexto) > 0 Then FwiTextoCartaRcl.Text = strTexto
    End Sub

    Protected Overridable Sub cmdJudicial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdJudicial.Click
        Dim strTexto As String = Texto(FwiTextoRclJudicial.Text, lblFwiTextoRclJudicial.Text)
        If Len(strTexto) > 0 Then FwiTextoRclJudicial.Text = strTexto
    End Sub

    Protected Overridable Sub btMasiva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdMasiva.Click
        Dim strTexto As String = Texto(FwiIncidencias.Text, lblIncidencias.Text)
        If Len(strTexto) > 0 Then FwiIncidencias.Text = strTexto
    End Sub

    Protected Overridable Sub cmdOtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOtras.Click
        Dim strTexto As String = Texto(FwiOtrasReclamaciones.Text, lblFwiOtrasReclamaciones.Text)
        If Len(strTexto) > 0 Then FwiOtrasReclamaciones.Text = strTexto
    End Sub

    Protected Overridable Sub CmdPrimera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrimera.Click
        Dim strTexto As String = Texto(FwiTextoPrimerRcl.Text, lblFwiTextoPrimerRcl.Text)
        If Len(strTexto & vbNullString) > 0 Then FwiTextoPrimerRcl.Text = strTexto
    End Sub

    Protected Overridable Sub cmdSegunda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSegunda.Click
        Dim strTexto As String = Texto(FwiTextoSegunRcl.Text, lblFwiTextoSegunRcl.Text)
        If Len(strTexto) > 0 Then FwiTextoSegunRcl.Text = strTexto
    End Sub

    Protected Overridable Function Texto(ByVal strValor As String, ByVal strCaption As String) As String
        Dim frm As New CommonClasses.FormularioTexto
        frm.Texto = strValor
        frm.Text = strCaption
        If frm.ShowDialog() = DialogResult.OK Then
            If strValor <> frm.Texto Then Texto = frm.Texto
        End If
        Return frm.Texto
    End Function

    Protected Overridable Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        GuardarDatos()
        Me.Close()
    End Sub

    Protected Overridable Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

#End Region

#Region " Funciones"

    Protected Overridable Sub LoadDatos()
        Dim dttCobro As DataTable = New Cobro().SelOnPrimaryKey(mIDCobro)
        If Not dttCobro Is Nothing AndAlso dttCobro.Rows.Count = 1 Then
            fwiTitulo.Text = dttCobro.Rows(0)("Titulo") & String.Empty
            FwiNFactura.Text = dttCobro.Rows(0)("NFactura") & String.Empty
            FwiFechaVencimiento.Value = dttCobro.Rows(0)("FechaVencimiento") & String.Empty
            FwiSituacion.Text = dttCobro.Rows(0)("Situacion") & String.Empty
            If Length(dttCobro.Rows(0)("Situacion")) > 0 Then
                Dim dttEstadoCobro As DataTable = New EstadoCobro().Filter(New StringFilterItem("IDEstado", dttCobro.Rows(0)("Situacion")))
                If Not dttEstadoCobro Is Nothing AndAlso dttEstadoCobro.Rows.Count > 0 Then
                    fwiSituacionTexto.Text = dttEstadoCobro.Rows(0)("Abreviatura") & String.Empty
                End If
            End If
            FwiFacturaRecibidaClte.Value = dttCobro.Rows(0)("FacturaRecibidaClte")
            FwiFacturaAceptadaClte.Value = dttCobro.Rows(0)("FacturaAceptadaClte")
            FwiIncidencias.Text = dttCobro.Rows(0)("Incidencias") & String.Empty
            FwiFechaSeguimiento.Value = dttCobro.Rows(0)("FechaSeguimiento")
            FwiFechaPrimerRcl.Value = dttCobro.Rows(0)("FechaPrimerRecl")
            FwiFechaSegunRcl.Value = dttCobro.Rows(0)("FechaSegunRecl")
            FwiTextoPrimerRcl.Text = dttCobro.Rows(0)("TextoPrimerRecl") & String.Empty
            FwiTextoSegunRcl.Text = dttCobro.Rows(0)("TextoSegunRecl") & String.Empty
            FwiFechaCartaRcl.Value = dttCobro.Rows(0)("FechaCartaRecl")
            FwiTextoCartaRcl.Text = dttCobro.Rows(0)("TextoCartaRecl") & String.Empty
            FwiOtrasReclamaciones.Text = dttCobro.Rows(0)("OtrasReclamaciones") & String.Empty
            FwiFechaRclJudicial.Value = dttCobro.Rows(0)("FechaReclJudicial")
            FwiTextoRclJudicial.Text = dttCobro.Rows(0)("TextoReclJudicial") & String.Empty
        End If
    End Sub

    Protected Overridable Sub GuardarDatos()
        Dim c As New Cobro
        Dim dtt As DataTable = c.SelOnPrimaryKey(mIDCobro)
        If Not dtt Is Nothing Then
            dtt.Rows(0)("FacturaRecibidaClte") = IIf(Engine.Length(FwiFacturaRecibidaClte.Value) > 0, FwiFacturaRecibidaClte.Value, System.DBNull.Value)
            dtt.Rows(0)("FacturaAceptadaClte") = IIf(Engine.Length(FwiFacturaAceptadaClte.Value) > 0, FwiFacturaAceptadaClte.Value, System.DBNull.Value)
            dtt.Rows(0)("Incidencias") = FwiIncidencias.Text & vbNullString
            dtt.Rows(0)("FechaSeguimiento") = IIf(Length(FwiFechaSeguimiento.Value) > 0, FwiFechaSeguimiento.Value, System.DBNull.Value)
            dtt.Rows(0)("FechaPrimerRecl") = IIf(Length(FwiFechaPrimerRcl.Value) > 0, FwiFechaPrimerRcl.Value, System.DBNull.Value)
            dtt.Rows(0)("FechaSegunRecl") = IIf(Length(FwiFechaSegunRcl.Value) > 0, FwiFechaSegunRcl.Value, System.DBNull.Value)
            dtt.Rows(0)("TextoPrimerRecl") = FwiTextoPrimerRcl.Text & vbNullString
            dtt.Rows(0)("TextoSegunRecl") = FwiTextoSegunRcl.Text & vbNullString
            dtt.Rows(0)("FechaCartaRecl") = IIf(Length(FwiFechaCartaRcl.Value) > 0, FwiFechaCartaRcl.Value, System.DBNull.Value)
            dtt.Rows(0)("TextoCartaRecl") = FwiTextoCartaRcl.Text & vbNullString
            dtt.Rows(0)("OtrasReclamaciones") = FwiOtrasReclamaciones.Text & vbNullString
            dtt.Rows(0)("FechaReclJudicial") = IIf(Length(FwiFechaRclJudicial.Value) > 0, FwiFechaRclJudicial.Value, System.DBNull.Value)
            dtt.Rows(0)("TextoReclJudicial") = FwiTextoRclJudicial.Text & vbNullString
            c.Update(dtt)
        End If
    End Sub

#End Region

#Region " Asientos del Cobro "

    Protected Overridable Sub LoadAsientosContables()
        Dim dtAsientosCobro As DataTable = ExpertisApp.ExecuteTask(Of Integer, DataTable)(AddressOf Cobro.GetAsientosCobro, mIDCobro)
        GridAsientos.DataSource = dtAsientosCobro
    End Sub

    Protected Overridable Sub GridAsientos_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridAsientos.FormattingRow
        Dim IDCContableBanco As String = "57"
        If e.Row.RowType = RowType.Record AndAlso e.Row.DataRow("IDDocumento") = mIDCobro AndAlso Strings.Left(e.Row.DataRow("IDCContable"), Length(IDCContableBanco)) <> IDCContableBanco Then
            e.Row.RowStyle = GridAsientos.FormatStyles("fmtApunteCobro")
        End If
    End Sub

#End Region

End Class
