Imports Janus.Windows.GridEX

Public Class frmConsultaRemesa
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
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents jngCobros As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents fwiFechaNeg As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiFechaNeg As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiTipoNeg As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiTipoNeg As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFichero As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiFichero As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiBancoPropio As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblfwiTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiNRemesa As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiNRemesa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlTop As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlBottom As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlDatosAnticipo As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraDatosAnticipo As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents nbxImporteInicial As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImporteInicial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaAbono As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtFechaAbono As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents nbxInteresRenov As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblInteresRenovacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxInteresInicial As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblInteresInicial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtReferenciaAbono As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblRefAbono As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaRenov As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtFechaRenov As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiTitulo As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngCobros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaRemesa))
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.jngCobros = New Solmicro.Expertis.Engine.UI.Grid
        Me.fwiFechaNeg = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiFechaNeg = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTipoNeg = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiTipoNeg = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFichero = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiFichero = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiBancoPropio = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiNRemesa = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiNRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiTitulo = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlDatosAnticipo = New Solmicro.Expertis.Engine.UI.Panel
        Me.FraDatosAnticipo = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFechaRenov = New Solmicro.Expertis.Engine.UI.Label
        Me.txtFechaRenov = New Solmicro.Expertis.Engine.UI.TextBox
        Me.nbxInteresRenov = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblInteresRenovacion = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxInteresInicial = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblInteresInicial = New Solmicro.Expertis.Engine.UI.Label
        Me.txtReferenciaAbono = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblRefAbono = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaAbono = New Solmicro.Expertis.Engine.UI.Label
        Me.txtFechaAbono = New Solmicro.Expertis.Engine.UI.TextBox
        Me.nbxImporteInicial = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImporteInicial = New Solmicro.Expertis.Engine.UI.Label
        CType(Me.jngCobros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.suspendlayout()
        Me.pnlBottom.suspendlayout()
        Me.pnlDatosAnticipo.suspendlayout()
        Me.FraDatosAnticipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Location = New System.Drawing.Point(643, 50)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(88, 28)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'jngCobros
        '
        Me.jngCobros.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngCobros.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngCobros.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngCobros_DesignTimeLayout.LayoutString = resources.GetString("jngCobros_DesignTimeLayout.LayoutString")
        Me.jngCobros.DesignTimeLayout = jngCobros_DesignTimeLayout
        Me.jngCobros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngCobros.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngCobros.EntityName = "Cobro"
        Me.jngCobros.FrozenColumns = 2
        Me.jngCobros.KeyField = "IDCobro"
        Me.jngCobros.Location = New System.Drawing.Point(0, 34)
        Me.jngCobros.Name = "jngCobros"
        Me.jngCobros.PrimaryDataFields = ""
        Me.jngCobros.RequeryManually = True
        Me.jngCobros.SecondaryDataFields = Nothing
        Me.jngCobros.Size = New System.Drawing.Size(743, 163)
        Me.jngCobros.TabIndex = 3
        Me.jngCobros.Tag = "IdRec=4711:4719:4394:4712:4713:4764:4715:4756:4749:4429:;"
        Me.jngCobros.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngCobros.ViewName = "vCtlCICobroContConsultaRemesa"
        '
        'fwiFechaNeg
        '
        Me.fwiFechaNeg.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaNeg.Enabled = False
        Me.fwiFechaNeg.Location = New System.Drawing.Point(119, 13)
        Me.fwiFechaNeg.Name = "fwiFechaNeg"
        Me.fwiFechaNeg.ReadOnly = True
        Me.fwiFechaNeg.Size = New System.Drawing.Size(100, 21)
        Me.fwiFechaNeg.TabIndex = 0
        '
        'lblfwiFechaNeg
        '
        Me.lblfwiFechaNeg.Location = New System.Drawing.Point(3, 17)
        Me.lblfwiFechaNeg.Name = "lblfwiFechaNeg"
        Me.lblfwiFechaNeg.Size = New System.Drawing.Size(112, 13)
        Me.lblfwiFechaNeg.TabIndex = 4
        Me.lblfwiFechaNeg.Tag = "IdRec=5468;"
        Me.lblfwiFechaNeg.Text = "Fecha Negociación"
        '
        'fwiTipoNeg
        '
        Me.fwiTipoNeg.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTipoNeg.Enabled = False
        Me.fwiTipoNeg.Location = New System.Drawing.Point(346, 13)
        Me.fwiTipoNeg.Name = "fwiTipoNeg"
        Me.fwiTipoNeg.ReadOnly = True
        Me.fwiTipoNeg.Size = New System.Drawing.Size(96, 21)
        Me.fwiTipoNeg.TabIndex = 1
        '
        'lblfwiTipoNeg
        '
        Me.lblfwiTipoNeg.Location = New System.Drawing.Point(237, 17)
        Me.lblfwiTipoNeg.Name = "lblfwiTipoNeg"
        Me.lblfwiTipoNeg.Size = New System.Drawing.Size(103, 13)
        Me.lblfwiTipoNeg.TabIndex = 5
        Me.lblfwiTipoNeg.Text = "Tipo Negociación"
        '
        'fwiFichero
        '
        Me.fwiFichero.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFichero.Enabled = False
        Me.fwiFichero.Location = New System.Drawing.Point(119, 63)
        Me.fwiFichero.Name = "fwiFichero"
        Me.fwiFichero.ReadOnly = True
        Me.fwiFichero.Size = New System.Drawing.Size(362, 21)
        Me.fwiFichero.TabIndex = 4
        '
        'lblfwiFichero
        '
        Me.lblfwiFichero.Location = New System.Drawing.Point(3, 67)
        Me.lblfwiFichero.Name = "lblfwiFichero"
        Me.lblfwiFichero.Size = New System.Drawing.Size(48, 13)
        Me.lblfwiFichero.TabIndex = 6
        Me.lblfwiFichero.Tag = "IdRec=4768;"
        Me.lblfwiFichero.Text = "Fichero"
        '
        'fwiBancoPropio
        '
        Me.fwiBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.fwiBancoPropio.Enabled = False
        Me.fwiBancoPropio.Location = New System.Drawing.Point(119, 38)
        Me.fwiBancoPropio.Name = "fwiBancoPropio"
        Me.fwiBancoPropio.ReadOnly = True
        Me.fwiBancoPropio.Size = New System.Drawing.Size(362, 21)
        Me.fwiBancoPropio.TabIndex = 5
        '
        'lblfwiBancoPropio
        '
        Me.lblfwiBancoPropio.Location = New System.Drawing.Point(3, 42)
        Me.lblfwiBancoPropio.Name = "lblfwiBancoPropio"
        Me.lblfwiBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblfwiBancoPropio.TabIndex = 7
        Me.lblfwiBancoPropio.Tag = "IdRec=5470;"
        Me.lblfwiBancoPropio.Text = "Banco Propio"
        '
        'fwiTotal
        '
        Me.fwiTotal.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTotal.Enabled = False
        Me.fwiTotal.Location = New System.Drawing.Point(489, 14)
        Me.fwiTotal.Name = "fwiTotal"
        Me.fwiTotal.ReadOnly = True
        Me.fwiTotal.Size = New System.Drawing.Size(100, 21)
        Me.fwiTotal.TabIndex = 6
        '
        'lblfwiTotal
        '
        Me.lblfwiTotal.Location = New System.Drawing.Point(453, 18)
        Me.lblfwiTotal.Name = "lblfwiTotal"
        Me.lblfwiTotal.Size = New System.Drawing.Size(35, 13)
        Me.lblfwiTotal.TabIndex = 8
        Me.lblfwiTotal.Tag = "IdRec=4664;"
        Me.lblfwiTotal.Text = "Total"
        '
        'fwiNRemesa
        '
        Me.fwiNRemesa.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNRemesa.Enabled = False
        Me.fwiNRemesa.Location = New System.Drawing.Point(398, 6)
        Me.fwiNRemesa.Name = "fwiNRemesa"
        Me.fwiNRemesa.ReadOnly = True
        Me.fwiNRemesa.Size = New System.Drawing.Size(60, 21)
        Me.fwiNRemesa.TabIndex = 7
        Me.fwiNRemesa.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'lblfwiNRemesa
        '
        Me.lblfwiNRemesa.Location = New System.Drawing.Point(374, 10)
        Me.lblfwiNRemesa.Name = "lblfwiNRemesa"
        Me.lblfwiNRemesa.Size = New System.Drawing.Size(21, 13)
        Me.lblfwiNRemesa.TabIndex = 9
        Me.lblfwiNRemesa.Tag = "IdRec=4770;"
        Me.lblfwiNRemesa.Text = "Nº"
        '
        'lblfwiTitulo
        '
        Me.lblfwiTitulo.Location = New System.Drawing.Point(221, 10)
        Me.lblfwiTitulo.Name = "lblfwiTitulo"
        Me.lblfwiTitulo.Size = New System.Drawing.Size(147, 13)
        Me.lblfwiTitulo.TabIndex = 10
        Me.lblfwiTitulo.Tag = "IdRec=4769;"
        Me.lblfwiTitulo.Text = "COBROS DE LA REMESA"
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.lblfwiTitulo)
        Me.pnlTop.Controls.Add(Me.fwiNRemesa)
        Me.pnlTop.Controls.Add(Me.lblfwiNRemesa)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(743, 34)
        Me.pnlTop.TabIndex = 11
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.cmdAceptar)
        Me.pnlBottom.Controls.Add(Me.lblfwiFechaNeg)
        Me.pnlBottom.Controls.Add(Me.fwiTotal)
        Me.pnlBottom.Controls.Add(Me.lblfwiTipoNeg)
        Me.pnlBottom.Controls.Add(Me.lblfwiTotal)
        Me.pnlBottom.Controls.Add(Me.fwiBancoPropio)
        Me.pnlBottom.Controls.Add(Me.fwiFichero)
        Me.pnlBottom.Controls.Add(Me.lblfwiFichero)
        Me.pnlBottom.Controls.Add(Me.fwiTipoNeg)
        Me.pnlBottom.Controls.Add(Me.lblfwiBancoPropio)
        Me.pnlBottom.Controls.Add(Me.fwiFechaNeg)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 267)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(743, 88)
        Me.pnlBottom.TabIndex = 12
        '
        'pnlDatosAnticipo
        '
        Me.pnlDatosAnticipo.Controls.Add(Me.FraDatosAnticipo)
        Me.pnlDatosAnticipo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlDatosAnticipo.Location = New System.Drawing.Point(0, 197)
        Me.pnlDatosAnticipo.Name = "pnlDatosAnticipo"
        Me.pnlDatosAnticipo.Size = New System.Drawing.Size(743, 70)
        Me.pnlDatosAnticipo.TabIndex = 13
        '
        'FraDatosAnticipo
        '
        Me.FraDatosAnticipo.Controls.Add(Me.lblFechaRenov)
        Me.FraDatosAnticipo.Controls.Add(Me.txtFechaRenov)
        Me.FraDatosAnticipo.Controls.Add(Me.nbxInteresRenov)
        Me.FraDatosAnticipo.Controls.Add(Me.lblInteresRenovacion)
        Me.FraDatosAnticipo.Controls.Add(Me.nbxInteresInicial)
        Me.FraDatosAnticipo.Controls.Add(Me.lblInteresInicial)
        Me.FraDatosAnticipo.Controls.Add(Me.txtReferenciaAbono)
        Me.FraDatosAnticipo.Controls.Add(Me.lblRefAbono)
        Me.FraDatosAnticipo.Controls.Add(Me.lblFechaAbono)
        Me.FraDatosAnticipo.Controls.Add(Me.txtFechaAbono)
        Me.FraDatosAnticipo.Controls.Add(Me.nbxImporteInicial)
        Me.FraDatosAnticipo.Controls.Add(Me.lblImporteInicial)
        Me.FraDatosAnticipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraDatosAnticipo.Location = New System.Drawing.Point(0, 0)
        Me.FraDatosAnticipo.Name = "FraDatosAnticipo"
        Me.FraDatosAnticipo.Size = New System.Drawing.Size(743, 70)
        Me.FraDatosAnticipo.TabIndex = 0
        Me.FraDatosAnticipo.TabStop = False
        '
        'lblFechaRenov
        '
        Me.lblFechaRenov.Location = New System.Drawing.Point(545, 44)
        Me.lblFechaRenov.Name = "lblFechaRenov"
        Me.lblFechaRenov.Size = New System.Drawing.Size(84, 13)
        Me.lblFechaRenov.TabIndex = 20
        Me.lblFechaRenov.Tag = ""
        Me.lblFechaRenov.Text = "Fecha Renov."
        Me.lblFechaRenov.Visible = False
        '
        'txtFechaRenov
        '
        Me.txtFechaRenov.DisabledBackColor = System.Drawing.Color.White
        Me.txtFechaRenov.Enabled = False
        Me.txtFechaRenov.Location = New System.Drawing.Point(631, 40)
        Me.txtFechaRenov.Name = "txtFechaRenov"
        Me.txtFechaRenov.ReadOnly = True
        Me.txtFechaRenov.Size = New System.Drawing.Size(100, 21)
        Me.txtFechaRenov.TabIndex = 19
        Me.txtFechaRenov.Visible = False
        '
        'nbxInteresRenov
        '
        Me.nbxInteresRenov.DisabledBackColor = System.Drawing.Color.White
        Me.nbxInteresRenov.Enabled = False
        Me.nbxInteresRenov.Location = New System.Drawing.Point(475, 40)
        Me.nbxInteresRenov.Name = "nbxInteresRenov"
        Me.nbxInteresRenov.ReadOnly = True
        Me.nbxInteresRenov.Size = New System.Drawing.Size(58, 21)
        Me.nbxInteresRenov.TabIndex = 17
        Me.nbxInteresRenov.Visible = False
        '
        'lblInteresRenovacion
        '
        Me.lblInteresRenovacion.Location = New System.Drawing.Point(382, 44)
        Me.lblInteresRenovacion.Name = "lblInteresRenovacion"
        Me.lblInteresRenovacion.Size = New System.Drawing.Size(92, 13)
        Me.lblInteresRenovacion.TabIndex = 18
        Me.lblInteresRenovacion.Tag = ""
        Me.lblInteresRenovacion.Text = "Interés Renov."
        Me.lblInteresRenovacion.Visible = False
        '
        'nbxInteresInicial
        '
        Me.nbxInteresInicial.DisabledBackColor = System.Drawing.Color.White
        Me.nbxInteresInicial.Enabled = False
        Me.nbxInteresInicial.Location = New System.Drawing.Point(321, 40)
        Me.nbxInteresInicial.Name = "nbxInteresInicial"
        Me.nbxInteresInicial.ReadOnly = True
        Me.nbxInteresInicial.Size = New System.Drawing.Size(58, 21)
        Me.nbxInteresInicial.TabIndex = 15
        Me.nbxInteresInicial.Visible = False
        '
        'lblInteresInicial
        '
        Me.lblInteresInicial.Location = New System.Drawing.Point(241, 44)
        Me.lblInteresInicial.Name = "lblInteresInicial"
        Me.lblInteresInicial.Size = New System.Drawing.Size(86, 13)
        Me.lblInteresInicial.TabIndex = 16
        Me.lblInteresInicial.Tag = ""
        Me.lblInteresInicial.Text = "Interés Inicial"
        Me.lblInteresInicial.Visible = False
        '
        'txtReferenciaAbono
        '
        Me.txtReferenciaAbono.DisabledBackColor = System.Drawing.Color.White
        Me.txtReferenciaAbono.Enabled = False
        Me.txtReferenciaAbono.Location = New System.Drawing.Point(321, 15)
        Me.txtReferenciaAbono.Name = "txtReferenciaAbono"
        Me.txtReferenciaAbono.ReadOnly = True
        Me.txtReferenciaAbono.Size = New System.Drawing.Size(410, 21)
        Me.txtReferenciaAbono.TabIndex = 13
        '
        'lblRefAbono
        '
        Me.lblRefAbono.Location = New System.Drawing.Point(241, 19)
        Me.lblRefAbono.Name = "lblRefAbono"
        Me.lblRefAbono.Size = New System.Drawing.Size(74, 13)
        Me.lblRefAbono.TabIndex = 14
        Me.lblRefAbono.Tag = ""
        Me.lblRefAbono.Text = "Ref. Abono "
        '
        'lblFechaAbono
        '
        Me.lblFechaAbono.Location = New System.Drawing.Point(3, 19)
        Me.lblFechaAbono.Name = "lblFechaAbono"
        Me.lblFechaAbono.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaAbono.TabIndex = 12
        Me.lblFechaAbono.Tag = ""
        Me.lblFechaAbono.Text = "Fecha Abono"
        '
        'txtFechaAbono
        '
        Me.txtFechaAbono.DisabledBackColor = System.Drawing.Color.White
        Me.txtFechaAbono.Enabled = False
        Me.txtFechaAbono.Location = New System.Drawing.Point(119, 15)
        Me.txtFechaAbono.Name = "txtFechaAbono"
        Me.txtFechaAbono.ReadOnly = True
        Me.txtFechaAbono.Size = New System.Drawing.Size(100, 21)
        Me.txtFechaAbono.TabIndex = 11
        '
        'nbxImporteInicial
        '
        Me.nbxImporteInicial.DisabledBackColor = System.Drawing.Color.White
        Me.nbxImporteInicial.Enabled = False
        Me.nbxImporteInicial.Location = New System.Drawing.Point(119, 40)
        Me.nbxImporteInicial.Name = "nbxImporteInicial"
        Me.nbxImporteInicial.ReadOnly = True
        Me.nbxImporteInicial.Size = New System.Drawing.Size(100, 21)
        Me.nbxImporteInicial.TabIndex = 9
        '
        'lblImporteInicial
        '
        Me.lblImporteInicial.Location = New System.Drawing.Point(3, 44)
        Me.lblImporteInicial.Name = "lblImporteInicial"
        Me.lblImporteInicial.Size = New System.Drawing.Size(91, 13)
        Me.lblImporteInicial.TabIndex = 10
        Me.lblImporteInicial.Tag = ""
        Me.lblImporteInicial.Text = "Importe Inicial"
        '
        'frmConsultaRemesa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(743, 355)
        Me.Controls.Add(Me.jngCobros)
        Me.Controls.Add(Me.pnlDatosAnticipo)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaRemesa"
        Me.Text = "Consulta de Remesa"
        CType(Me.jngCobros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.pnlDatosAnticipo.ResumeLayout(False)
        Me.FraDatosAnticipo.ResumeLayout(False)
        Me.FraDatosAnticipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Propiedades "

    Private mIDRemesa As Integer
    Public WriteOnly Property IDRemesa() As Integer
        Set(ByVal Value As Integer)
            mIDRemesa = Value
        End Set
    End Property

#End Region

    Private mstrAbvA As String
    Private mDecimalesA As Integer
    Private mstrAbvB As String
    Private mDecimalesB As Integer

#Region " Carga del formulario "

    Private Sub frmConsultaRemesa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadDefaultCurrency()
            LoadERPData()
        End If
    End Sub

    Private Sub LoadDefaultCurrency()
        Dim dtMoneda As DataTable = ExpertisApp.ExecuteTask(Of String, DataTable)(AddressOf Moneda.ObtenerMonedas, String.Empty)
        If Not IsNothing(dtMoneda) AndAlso dtMoneda.Rows.Count > 0 Then
            mstrAbvA = Nz(dtMoneda.Rows(0)("AbreviaturaA"), String.Empty)
            mDecimalesA = Nz(dtMoneda.Rows(0)("NDecimalesImpA"), 0)
            mstrAbvB = Nz(dtMoneda.Rows(0)("AbreviaturaB"), String.Empty)
            mDecimalesB = Nz(dtMoneda.Rows(0)("NDecimalesImpB"), 0)
        End If
    End Sub

    Private Sub LoadERPData()
        fwiNRemesa.Text = mIDRemesa
        pnlDatosAnticipo.Visible = False
        Dim objNegRemesa As New Remesa
        Dim dtRemesa As DataTable = objNegRemesa.SelOnPrimaryKey(mIDRemesa)
        If Not dtRemesa Is Nothing AndAlso dtRemesa.Rows.Count > 0 Then
            fwiFechaNeg.Text = dtRemesa.Rows(0)("FechaNegociacion")
            fwiTipoNeg.Text = dtRemesa.Rows(0)("IdTipoNegociacion")
            If dtRemesa.Rows(0)("IdTipoNegociacion") = enumTipoRemesa.RemesaAlCobro Then
                fwiTipoNeg.Text = "Al Cobro"
            ElseIf dtRemesa.Rows(0)("IdTipoNegociacion") = enumTipoRemesa.RemesaAnticipo Then
                fwiTipoNeg.Text = "Anticipo"
                pnlDatosAnticipo.Visible = True
                If Length(dtRemesa.Rows(0)("FechaCargo")) > 0 Then Me.txtFechaAbono.Text = dtRemesa.Rows(0)("FechaCargo")
                Me.nbxImporteInicial.Value = Nz(dtRemesa.Rows(0)("ImporteInicial"), 0)
                Me.txtReferenciaAbono.Text = dtRemesa.Rows(0)("ReferenciaAbonoAnticipo") & String.Empty
                Me.nbxInteresInicial.Value = Nz(dtRemesa.Rows(0)("TipoInteresInicial"), 0)
                Me.nbxInteresRenov.Value = Nz(dtRemesa.Rows(0)("TipoInteresRenovacion"), 0)
                If Length(dtRemesa.Rows(0)("FechaRenovacion")) > 0 Then Me.txtFechaRenov.Text = dtRemesa.Rows(0)("FechaRenovacion")
            Else
                fwiTipoNeg.Text = "Al Descuento"
            End If
            fwiFichero.Text = dtRemesa.Rows(0)("Ruta") & String.Empty

            Dim objNegBancoPropio As New BancoPropio
            Dim dtBancoPropio As DataTable = objNegBancoPropio.SelOnPrimaryKey(dtRemesa.Rows(0)("IdBancopropio"))
            If Not IsNothing(dtBancoPropio) AndAlso dtBancoPropio.Rows.Count > 0 Then
                fwiBancoPropio.Text = dtBancoPropio.Rows(0)("DescBancoPropio") & String.Empty
            End If

            '//Datos del Grid
            Dim fRemesa As New Filter
            If dtRemesa.Rows(0)("IdTipoNegociacion") = enumTipoRemesa.RemesaAnticipo Then
                jngCobros.Columns("ImporteRemesaAnticipo").Visible = True
                jngCobros.Columns("ImporteRemesaAnticipoA").Visible = True
                jngCobros.Columns("ImporteRemesaAnticipoB").Visible = True

                fRemesa.Add(New StringFilterItem("IDRemesaAnticipo", FilterOperator.Equal, mIDRemesa))
            Else
                fRemesa.Add(New StringFilterItem("IDRemesa", FilterOperator.Equal, mIDRemesa))
            End If

            jngCobros.Filter = fRemesa
            jngCobros.ReQuery()

            '//Resto de campos
            fwiTotal.Text = CalcularTotal()
        End If
    End Sub

    Private Function CalcularTotal() As Double
        CalcularTotal = xRound(jngCobros.GetTotal(jngCobros.Columns("ImpVencimientoA"), AggregateFunction.Sum), mDecimalesA)
    End Function

#End Region

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub

End Class
