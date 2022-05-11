Public Class CICtlDevolucionCobro
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
    Public WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents FraDatosContab As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents chkAgruparBanco As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lbladvBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcadvBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advBancoPropio As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lbladvIdEjercicio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcadvIdEjercicio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advIdEjercicio As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lbltxtComentario As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtComentario As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents FraDatosFact As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents chkGenerarFact As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lbladvIdContador As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lbladvArticulo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcadvArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lbladvCContable As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcadvCContable As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advCContable As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lbltxtNFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lbladvIdProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcadvIdProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advIdProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lbladvIdTipoIVA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIdTipoIVA As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblnbxComisiones As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents nbxComisiones As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblcbxFecha As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblcbxSuFecha As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxSuFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lbltxtSuFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtSuFactura As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents jngConsulta As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents AdvIDContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents TxtNFactura As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngConsulta_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CICtlDevolucionCobro))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FraDatosContab = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkAgruparBanco = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lbladvBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcadvBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advBancoPropio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbladvIdEjercicio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcadvIdEjercicio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIdEjercicio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbltxtComentario = New Solmicro.Expertis.Engine.UI.Label
        Me.txtComentario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraDatosFact = New Solmicro.Expertis.Engine.UI.Frame
        Me.TxtNFactura = New Solmicro.Expertis.Engine.UI.TextBox
        Me.AdvIDContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.chkGenerarFact = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lbladvIdContador = New Solmicro.Expertis.Engine.UI.Label
        Me.lbladvArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcadvArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbladvCContable = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcadvCContable = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advCContable = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbltxtNFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.lbladvIdProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcadvIdProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIdProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbladvIdTipoIVA = New Solmicro.Expertis.Engine.UI.Label
        Me.advIdTipoIVA = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblnbxComisiones = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxComisiones = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblcbxFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblcbxSuFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxSuFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lbltxtSuFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSuFactura = New Solmicro.Expertis.Engine.UI.TextBox
        Me.jngConsulta = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        Me.FraDatosContab.SuspendLayout()
        Me.FraDatosFact.SuspendLayout()
        CType(Me.jngConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Controls.Add(Me.FraDatosContab)
        Me.Panel1.Controls.Add(Me.FraDatosFact)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 277)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 184)
        Me.Panel1.TabIndex = 14
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(560, 151)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(101, 26)
        Me.cmdCancelar.TabIndex = 23
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(456, 151)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(101, 26)
        Me.cmdAceptar.TabIndex = 22
        Me.cmdAceptar.Text = "Aceptar"
        '
        'FraDatosContab
        '
        Me.FraDatosContab.Controls.Add(Me.chkAgruparBanco)
        Me.FraDatosContab.Controls.Add(Me.lbladvBancoPropio)
        Me.FraDatosContab.Controls.Add(Me.lblcadvBancoPropio)
        Me.FraDatosContab.Controls.Add(Me.advBancoPropio)
        Me.FraDatosContab.Controls.Add(Me.lbladvIdEjercicio)
        Me.FraDatosContab.Controls.Add(Me.lblcadvIdEjercicio)
        Me.FraDatosContab.Controls.Add(Me.advIdEjercicio)
        Me.FraDatosContab.Controls.Add(Me.lbltxtComentario)
        Me.FraDatosContab.Controls.Add(Me.txtComentario)
        Me.FraDatosContab.Location = New System.Drawing.Point(421, 4)
        Me.FraDatosContab.Name = "FraDatosContab"
        Me.FraDatosContab.Size = New System.Drawing.Size(264, 142)
        Me.FraDatosContab.TabIndex = 18
        Me.FraDatosContab.TabStop = False
        Me.FraDatosContab.Text = "Datos de Contabilidad"
        '
        'chkAgruparBanco
        '
        Me.chkAgruparBanco.Location = New System.Drawing.Point(16, 16)
        Me.chkAgruparBanco.Name = "chkAgruparBanco"
        Me.chkAgruparBanco.Size = New System.Drawing.Size(88, 24)
        Me.chkAgruparBanco.TabIndex = 15
        Me.chkAgruparBanco.Text = "Agrupar"
        '
        'lbladvBancoPropio
        '
        Me.lbladvBancoPropio.Location = New System.Drawing.Point(12, 80)
        Me.lbladvBancoPropio.Name = "lbladvBancoPropio"
        Me.lbladvBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lbladvBancoPropio.TabIndex = 0
        Me.lbladvBancoPropio.Tag = "IdRec=4274;"
        Me.lbladvBancoPropio.Text = "Banco Propio"
        '
        'lblcadvBancoPropio
        '
        Me.lblcadvBancoPropio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblcadvBancoPropio.Location = New System.Drawing.Point(152, 75)
        Me.lblcadvBancoPropio.Name = "lblcadvBancoPropio"
        Me.lblcadvBancoPropio.Size = New System.Drawing.Size(104, 21)
        Me.lblcadvBancoPropio.TabIndex = 1
        '
        'advBancoPropio
        '
        Me.advBancoPropio.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescBancoPropio", lblcadvBancoPropio)})
        Me.advBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.advBancoPropio.EntityName = "BancoPropio"
        Me.advBancoPropio.Location = New System.Drawing.Point(96, 75)
        Me.advBancoPropio.Name = "advBancoPropio"
        Me.advBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.advBancoPropio.Size = New System.Drawing.Size(56, 23)
        Me.advBancoPropio.TabIndex = 11
        Me.advBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'lbladvIdEjercicio
        '
        Me.lbladvIdEjercicio.Location = New System.Drawing.Point(12, 48)
        Me.lbladvIdEjercicio.Name = "lbladvIdEjercicio"
        Me.lbladvIdEjercicio.Size = New System.Drawing.Size(55, 13)
        Me.lbladvIdEjercicio.TabIndex = 12
        Me.lbladvIdEjercicio.Tag = "IdRec=4274;"
        Me.lbladvIdEjercicio.Text = "Ejercicio"
        '
        'lblcadvIdEjercicio
        '
        Me.lblcadvIdEjercicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblcadvIdEjercicio.Location = New System.Drawing.Point(137, 43)
        Me.lblcadvIdEjercicio.Name = "lblcadvIdEjercicio"
        Me.lblcadvIdEjercicio.Size = New System.Drawing.Size(119, 21)
        Me.lblcadvIdEjercicio.TabIndex = 13
        '
        'advIdEjercicio
        '
        Me.advIdEjercicio.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescEjercicio", lblcadvIdEjercicio)})
        Me.advIdEjercicio.DisabledBackColor = System.Drawing.Color.White
        Me.advIdEjercicio.EntityName = "EjercicioContable"
        Me.advIdEjercicio.Location = New System.Drawing.Point(67, 43)
        Me.advIdEjercicio.Name = "advIdEjercicio"
        Me.advIdEjercicio.SecondaryDataFields = "IDEjercicio"
        Me.advIdEjercicio.Size = New System.Drawing.Size(70, 23)
        Me.advIdEjercicio.TabIndex = 10
        Me.advIdEjercicio.ViewName = "tbMaestroEjercicio"
        '
        'lbltxtComentario
        '
        Me.lbltxtComentario.Location = New System.Drawing.Point(12, 108)
        Me.lbltxtComentario.Name = "lbltxtComentario"
        Me.lbltxtComentario.Size = New System.Drawing.Size(39, 13)
        Me.lbltxtComentario.TabIndex = 14
        Me.lbltxtComentario.Tag = "IdRec=3204;"
        Me.lbltxtComentario.Text = "Texto"
        '
        'txtComentario
        '
        Me.txtComentario.DisabledBackColor = System.Drawing.Color.White
        Me.txtComentario.Location = New System.Drawing.Point(66, 108)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(189, 21)
        Me.txtComentario.TabIndex = 12
        '
        'FraDatosFact
        '
        Me.FraDatosFact.Controls.Add(Me.TxtNFactura)
        Me.FraDatosFact.Controls.Add(Me.AdvIDContador)
        Me.FraDatosFact.Controls.Add(Me.chkGenerarFact)
        Me.FraDatosFact.Controls.Add(Me.lbladvIdContador)
        Me.FraDatosFact.Controls.Add(Me.lbladvArticulo)
        Me.FraDatosFact.Controls.Add(Me.lblcadvArticulo)
        Me.FraDatosFact.Controls.Add(Me.advArticulo)
        Me.FraDatosFact.Controls.Add(Me.lbladvCContable)
        Me.FraDatosFact.Controls.Add(Me.lblcadvCContable)
        Me.FraDatosFact.Controls.Add(Me.advCContable)
        Me.FraDatosFact.Controls.Add(Me.lbltxtNFactura)
        Me.FraDatosFact.Controls.Add(Me.lbladvIdProveedor)
        Me.FraDatosFact.Controls.Add(Me.lblcadvIdProveedor)
        Me.FraDatosFact.Controls.Add(Me.advIdProveedor)
        Me.FraDatosFact.Controls.Add(Me.lbladvIdTipoIVA)
        Me.FraDatosFact.Controls.Add(Me.advIdTipoIVA)
        Me.FraDatosFact.Controls.Add(Me.lblnbxComisiones)
        Me.FraDatosFact.Controls.Add(Me.nbxComisiones)
        Me.FraDatosFact.Controls.Add(Me.lblcbxFecha)
        Me.FraDatosFact.Controls.Add(Me.cbxFecha)
        Me.FraDatosFact.Controls.Add(Me.lblcbxSuFecha)
        Me.FraDatosFact.Controls.Add(Me.cbxSuFecha)
        Me.FraDatosFact.Controls.Add(Me.lbltxtSuFactura)
        Me.FraDatosFact.Controls.Add(Me.txtSuFactura)
        Me.FraDatosFact.Location = New System.Drawing.Point(3, 4)
        Me.FraDatosFact.Name = "FraDatosFact"
        Me.FraDatosFact.Size = New System.Drawing.Size(420, 183)
        Me.FraDatosFact.TabIndex = 17
        Me.FraDatosFact.TabStop = False
        Me.FraDatosFact.Text = "Datos de la Factura"
        '
        'TxtNFactura
        '
        Me.TxtNFactura.DisabledBackColor = System.Drawing.Color.White
        Me.TxtNFactura.Enabled = False
        Me.TxtNFactura.Location = New System.Drawing.Point(96, 64)
        Me.TxtNFactura.Name = "TxtNFactura"
        Me.TxtNFactura.Size = New System.Drawing.Size(96, 21)
        Me.TxtNFactura.TabIndex = 34
        '
        'AdvIDContador
        '
        Me.AdvIDContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDContador.DisplayField = "IDContador"
        Me.AdvIDContador.Enabled = False
        Me.AdvIDContador.EntityName = "EntidadContador"
        Me.AdvIDContador.Location = New System.Drawing.Point(364, 133)
        Me.AdvIDContador.Name = "AdvIDContador"
        Me.AdvIDContador.SecondaryDataFields = "IDContador"
        Me.AdvIDContador.Size = New System.Drawing.Size(48, 23)
        Me.AdvIDContador.TabIndex = 33
        '
        'chkGenerarFact
        '
        Me.chkGenerarFact.Enabled = False
        Me.chkGenerarFact.Location = New System.Drawing.Point(14, 16)
        Me.chkGenerarFact.Name = "chkGenerarFact"
        Me.chkGenerarFact.Size = New System.Drawing.Size(186, 24)
        Me.chkGenerarFact.TabIndex = 32
        Me.chkGenerarFact.Text = "Generar Factura Compra"
        '
        'lbladvIdContador
        '
        Me.lbladvIdContador.Location = New System.Drawing.Point(304, 136)
        Me.lbladvIdContador.Name = "lbladvIdContador"
        Me.lbladvIdContador.Size = New System.Drawing.Size(60, 13)
        Me.lbladvIdContador.TabIndex = 0
        Me.lbladvIdContador.Tag = "IdRec=4318;"
        Me.lbladvIdContador.Text = "Contador"
        '
        'lbladvArticulo
        '
        Me.lbladvArticulo.Location = New System.Drawing.Point(10, 110)
        Me.lbladvArticulo.Name = "lbladvArticulo"
        Me.lbladvArticulo.Size = New System.Drawing.Size(69, 13)
        Me.lbladvArticulo.TabIndex = 19
        Me.lbladvArticulo.Tag = "IdRec=4321;"
        Me.lbladvArticulo.Text = "Art. Devol."
        '
        'lblcadvArticulo
        '
        Me.lblcadvArticulo.Location = New System.Drawing.Point(196, 110)
        Me.lblcadvArticulo.Name = "lblcadvArticulo"
        Me.lblcadvArticulo.Size = New System.Drawing.Size(216, 21)
        Me.lblcadvArticulo.TabIndex = 20
        '
        'advArticulo
        '
        Me.advArticulo.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescArticulo", lblcadvArticulo)})
        Me.advArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advArticulo.Enabled = False
        Me.advArticulo.EntityName = "Articulo"
        Me.advArticulo.Location = New System.Drawing.Point(96, 110)
        Me.advArticulo.Name = "advArticulo"
        Me.advArticulo.SecondaryDataFields = "IDArticulo"
        Me.advArticulo.Size = New System.Drawing.Size(96, 23)
        Me.advArticulo.TabIndex = 4
        Me.advArticulo.ViewName = "tbMaestroArticulo"
        '
        'lbladvCContable
        '
        Me.lbladvCContable.Location = New System.Drawing.Point(10, 155)
        Me.lbladvCContable.Name = "lbladvCContable"
        Me.lbladvCContable.Size = New System.Drawing.Size(75, 13)
        Me.lbladvCContable.TabIndex = 21
        Me.lbladvCContable.Tag = "IdRec=4269;"
        Me.lbladvCContable.Text = "C. Contable"
        '
        'lblcadvCContable
        '
        Me.TryDataBinding(lblcadvCContable, New System.Windows.Forms.Binding("Text", Me.advCContable, "DescCContable", True))
        Me.lblcadvCContable.Location = New System.Drawing.Point(204, 155)
        Me.lblcadvCContable.Name = "lblcadvCContable"
        Me.lblcadvCContable.Size = New System.Drawing.Size(208, 21)
        Me.lblcadvCContable.TabIndex = 22
        '
        'advCContable
        '
        Me.advCContable.DisabledBackColor = System.Drawing.Color.White
        Me.advCContable.Enabled = False
        Me.advCContable.EntityName = "PlanContable"
        Me.advCContable.Location = New System.Drawing.Point(96, 155)
        Me.advCContable.Name = "advCContable"
        Me.advCContable.SecondaryDataFields = "IDCContable"
        Me.advCContable.Size = New System.Drawing.Size(104, 23)
        Me.advCContable.TabIndex = 6
        Me.advCContable.ViewName = "tbPlanContable"
        '
        'lbltxtNFactura
        '
        Me.lbltxtNFactura.Location = New System.Drawing.Point(10, 64)
        Me.lbltxtNFactura.Name = "lbltxtNFactura"
        Me.lbltxtNFactura.Size = New System.Drawing.Size(67, 13)
        Me.lbltxtNFactura.TabIndex = 23
        Me.lbltxtNFactura.Tag = "IdRec=4261;"
        Me.lbltxtNFactura.Text = "Nº Factura"
        '
        'lbladvIdProveedor
        '
        Me.lbladvIdProveedor.Location = New System.Drawing.Point(10, 87)
        Me.lbladvIdProveedor.Name = "lbladvIdProveedor"
        Me.lbladvIdProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lbladvIdProveedor.TabIndex = 24
        Me.lbladvIdProveedor.Tag = "IdRec=4320;"
        Me.lbladvIdProveedor.Text = "Proveedor"
        '
        'lblcadvIdProveedor
        '
        Me.lblcadvIdProveedor.Location = New System.Drawing.Point(196, 87)
        Me.lblcadvIdProveedor.Name = "lblcadvIdProveedor"
        Me.lblcadvIdProveedor.Size = New System.Drawing.Size(212, 21)
        Me.lblcadvIdProveedor.TabIndex = 25
        '
        'advIdProveedor
        '
        Me.advIdProveedor.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescProveedor", lblcadvIdProveedor)})
        Me.advIdProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.advIdProveedor.Enabled = False
        Me.advIdProveedor.EntityName = "Proveedor"
        Me.advIdProveedor.Location = New System.Drawing.Point(96, 87)
        Me.advIdProveedor.Name = "advIdProveedor"
        Me.advIdProveedor.SecondaryDataFields = "IDProveedor"
        Me.advIdProveedor.Size = New System.Drawing.Size(96, 23)
        Me.advIdProveedor.TabIndex = 3
        Me.advIdProveedor.ViewName = "tbMaestroProveedor"
        '
        'lbladvIdTipoIVA
        '
        Me.lbladvIdTipoIVA.Location = New System.Drawing.Point(10, 133)
        Me.lbladvIdTipoIVA.Name = "lbladvIdTipoIVA"
        Me.lbladvIdTipoIVA.Size = New System.Drawing.Size(56, 13)
        Me.lbladvIdTipoIVA.TabIndex = 26
        Me.lbladvIdTipoIVA.Tag = "IdRec=4319;"
        Me.lbladvIdTipoIVA.Text = "Tipo IVA"
        '
        'advIdTipoIVA
        '
        Me.advIdTipoIVA.DisabledBackColor = System.Drawing.Color.White
        Me.advIdTipoIVA.Enabled = False
        Me.advIdTipoIVA.EntityName = "TipoIva"
        Me.advIdTipoIVA.Location = New System.Drawing.Point(96, 133)
        Me.advIdTipoIVA.Name = "advIdTipoIVA"
        Me.advIdTipoIVA.SecondaryDataFields = "IDtipoIva"
        Me.advIdTipoIVA.Size = New System.Drawing.Size(64, 23)
        Me.advIdTipoIVA.TabIndex = 5
        Me.advIdTipoIVA.ViewName = "tbMaestroTipoIva"
        '
        'lblnbxComisiones
        '
        Me.lblnbxComisiones.Location = New System.Drawing.Point(199, 17)
        Me.lblnbxComisiones.Name = "lblnbxComisiones"
        Me.lblnbxComisiones.Size = New System.Drawing.Size(123, 13)
        Me.lblnbxComisiones.TabIndex = 28
        Me.lblnbxComisiones.Tag = "IdRec=4317;"
        Me.lblnbxComisiones.Text = "Importe Comisiones"
        '
        'nbxComisiones
        '
        Me.nbxComisiones.DisabledBackColor = System.Drawing.Color.White
        Me.nbxComisiones.Enabled = False
        Me.nbxComisiones.Location = New System.Drawing.Point(327, 13)
        Me.nbxComisiones.Name = "nbxComisiones"
        Me.nbxComisiones.Size = New System.Drawing.Size(85, 21)
        Me.nbxComisiones.TabIndex = 16
        '
        'lblcbxFecha
        '
        Me.lblcbxFecha.Location = New System.Drawing.Point(10, 41)
        Me.lblcbxFecha.Name = "lblcbxFecha"
        Me.lblcbxFecha.Size = New System.Drawing.Size(86, 13)
        Me.lblcbxFecha.TabIndex = 29
        Me.lblcbxFecha.Tag = "IdRec=3727;"
        Me.lblcbxFecha.Text = "Fecha Factura"
        '
        'cbxFecha
        '
        Me.cbxFecha.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFecha.Enabled = False
        Me.cbxFecha.Location = New System.Drawing.Point(96, 41)
        Me.cbxFecha.Name = "cbxFecha"
        Me.cbxFecha.Size = New System.Drawing.Size(96, 21)
        Me.cbxFecha.TabIndex = 1
        '
        'lblcbxSuFecha
        '
        Me.lblcbxSuFecha.Location = New System.Drawing.Point(201, 41)
        Me.lblcbxSuFecha.Name = "lblcbxSuFecha"
        Me.lblcbxSuFecha.Size = New System.Drawing.Size(105, 13)
        Me.lblcbxSuFecha.TabIndex = 30
        Me.lblcbxSuFecha.Tag = "IdRec=3727;"
        Me.lblcbxSuFecha.Text = "Su Fecha Factura"
        '
        'cbxSuFecha
        '
        Me.cbxSuFecha.DisabledBackColor = System.Drawing.Color.White
        Me.cbxSuFecha.Enabled = False
        Me.cbxSuFecha.Location = New System.Drawing.Point(310, 41)
        Me.cbxSuFecha.Name = "cbxSuFecha"
        Me.cbxSuFecha.Size = New System.Drawing.Size(98, 21)
        Me.cbxSuFecha.TabIndex = 7
        '
        'lbltxtSuFactura
        '
        Me.lbltxtSuFactura.Location = New System.Drawing.Point(201, 65)
        Me.lbltxtSuFactura.Name = "lbltxtSuFactura"
        Me.lbltxtSuFactura.Size = New System.Drawing.Size(86, 13)
        Me.lbltxtSuFactura.TabIndex = 31
        Me.lbltxtSuFactura.Tag = "IdRec=4320;"
        Me.lbltxtSuFactura.Text = "Su Nº Factura"
        '
        'txtSuFactura
        '
        Me.txtSuFactura.DisabledBackColor = System.Drawing.Color.White
        Me.txtSuFactura.Enabled = False
        Me.txtSuFactura.Location = New System.Drawing.Point(310, 65)
        Me.txtSuFactura.Name = "txtSuFactura"
        Me.txtSuFactura.Size = New System.Drawing.Size(98, 21)
        Me.txtSuFactura.TabIndex = 8
        '
        'jngConsulta
        '
        Me.jngConsulta.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngConsulta.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngConsulta_DesignTimeLayout.LayoutString = resources.GetString("jngConsulta_DesignTimeLayout.LayoutString")
        Me.jngConsulta.DesignTimeLayout = jngConsulta_DesignTimeLayout
        Me.jngConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngConsulta.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngConsulta.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngConsulta.EntityName = ""
        Me.jngConsulta.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngConsulta.Location = New System.Drawing.Point(0, 0)
        Me.jngConsulta.Name = "jngConsulta"
        Me.jngConsulta.PrimaryDataFields = ""
        Me.jngConsulta.SecondaryDataFields = ""
        Me.jngConsulta.Size = New System.Drawing.Size(688, 277)
        Me.jngConsulta.TabIndex = 15
        Me.jngConsulta.Tag = "IdRec=3481:3482:4261:4283:4256:3486:4306:4307:4308:4309:4310:4311:4312:4002:4313:" & _
            "4314:4315:4263:;"
        Me.jngConsulta.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngConsulta.ViewName = ""
        '
        'CICtlDevolucionCobro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(688, 461)
        Me.Controls.Add(Me.jngConsulta)
        Me.Controls.Add(Me.Panel1)
        Me.EntityName = "CobroDevolucion"
        Me.Name = "CICtlDevolucionCobro"
        Me.Text = "Devolución de Cobros"
        Me.ViewName = "vCTLCICobroDevolucion"
        Me.Panel1.ResumeLayout(False)
        Me.FraDatosContab.ResumeLayout(False)
        Me.FraDatosContab.PerformLayout()
        Me.FraDatosFact.ResumeLayout(False)
        Me.FraDatosFact.PerformLayout()
        CType(Me.jngConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
   
    Protected mdtContadores As DataTable
    Protected mIDProcess As Guid
    Protected mblnContabilidad As Boolean

#Region " Carga del formulario "

    Protected Overridable Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            advIdEjercicio.Text = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, Today)
            Dim oFilter As New Filter
            Dim HT As Hashtable = Me.Params
            If Not HT Is Nothing Then
                mIDProcess = HT("Guid")
            End If
            Dim f As New Filter
            f.Add(New GuidFilterItem("IDProcess", mIDProcess))
            jngConsulta.Filter = f
            jngConsulta.DataSource = New BE.DataEngine().Filter("vCTLCICobroDevolucion", f)
            mblnContabilidad = New Parametro().Contabilidad
            Me.FraDatosContab.Visible = mblnContabilidad
            Me.lbladvCContable.Visible = mblnContabilidad
            Me.advCContable.Visible = mblnContabilidad
            Me.lblcadvCContable.Visible = mblnContabilidad
        End If
    End Sub

#End Region

#Region " Generar Factura "

    Protected Overridable Sub chkGenerarFact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGenerarFact.CheckedChanged
        If chkGenerarFact.Checked Then
            HabilitarInputs(True)
            Dim Cont As Contador.DefaultCounter = ExpertisApp.ExecuteTask(Of String, Contador.DefaultCounter)(AddressOf Contador.GetDefaultCounterValue, GetType(FacturaCompraCabecera).Name)
            If Not IsNothing(Cont) Then
                TxtNFactura.Text = Cont.CounterValue
                AdvIDContador.Text = Cont.CounterID
            End If
            CargarContadores()
            If Not IsNothing(jngConsulta.DataSource) AndAlso CType(jngConsulta.DataSource, DataTable).Rows.Count > 0 Then
                advBancoPropio.Text = CType(jngConsulta.DataSource, DataTable).Rows(0)("IDBancopropio") & String.Empty
                If Engine.Length(advBancoPropio.Text) > 0 Then
                    Dim dtBanco As DataTable = New BancoPropio().SelOnPrimaryKey(advBancoPropio.Text)
                    If Not IsNothing(dtBanco) AndAlso dtBanco.Rows.Count > 0 Then
                        advIdProveedor.Text = dtBanco.Rows(0)("IDProveedor") & String.Empty
                    End If
                End If
            End If
        Else
            HabilitarInputs(False)
        End If
    End Sub

    Protected Overridable Sub HabilitarInputs(ByVal blnHabilitar As Boolean)
        TxtNFactura.Enabled = blnHabilitar
        AdvIDContador.Enabled = blnHabilitar
        cbxFecha.Enabled = blnHabilitar
        txtSuFactura.Enabled = blnHabilitar
        cbxSuFecha.Enabled = blnHabilitar
        advIdProveedor.Enabled = blnHabilitar
        advIdTipoIVA.Enabled = blnHabilitar
        advArticulo.Enabled = blnHabilitar
        advCContable.Enabled = False
        ' If blnHabilitar And Nz(fwiFactor.Text, 0) = 0 Then advIdTipoIVA.Text = String.Empty
    End Sub

    Private Sub CargarContadores()
        Dim dtConts As DataTable = New EntidadContador().Filter(New FilterItem("Entidad", GetType(FacturaCompraCabecera).Name))
        If Not dtConts Is Nothing AndAlso dtConts.Rows.Count > 0 Then
            Dim FilOr As New Filter(FilterUnionOperator.Or)
            For Each Dr As DataRow In dtConts.Select
                FilOr.Add("IDContador", Dr("IDContador"))
            Next
            mdtContadores = New Contador().Filter(FilOr)
        End If
    End Sub

    Protected Overridable Sub nbxComisiones_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nbxComisiones.ValueChanged
        If Length(nbxComisiones.Value) > 0 Then
            If nbxComisiones.Value <> 0 Then
                chkGenerarFact.Enabled = True
            Else
                chkGenerarFact.Checked = False
                chkGenerarFact.Enabled = False
            End If
        End If
    End Sub

    Protected Overridable Sub advCContable_SetPredefinedFilter(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advCContable.SetPredefinedFilter
        If Length(advIdEjercicio.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDEjercicio", advIdEjercicio.Text))
        End If
    End Sub

    Protected Overridable Sub advArticulo_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advArticulo.SelectionChanged
        If Not IsNothing(e.Selected) Then
            advIdTipoIVA.Text = e.Selected.Rows(0)("IDTipoIVA") & String.Empty
            advCContable.Text = e.Selected.Rows(0)("CCCompra") & String.Empty
        Else
            advIdTipoIVA.Text = String.Empty
            advCContable.Text = String.Empty
        End If
    End Sub

    Protected Overridable Sub advArticulo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advArticulo.SetPredefinedFilter
        e.Filter.Add(New BooleanFilterItem("Compra", True))
    End Sub

    Protected Overridable Sub advArticulo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles advArticulo.Validating
        If Length(advArticulo.Text) = 0 Then
            advIdTipoIVA.Text = String.Empty
            advCContable.Text = String.Empty
        End If
    End Sub

    Protected Overridable Sub AdvIDContador_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDContador.SetPredefinedFilter
        e.Filter.Add("Entidad", GetType(FacturaCompraCabecera).Name)
    End Sub

    Protected Overridable Sub AdvIDContador_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDContador.SelectionChanged
        CargarContador(AdvIDContador.Value)
    End Sub

    Private Sub CargarContador(ByVal StrContador As String)
        If Not mdtContadores Is Nothing AndAlso mdtContadores.Rows.Count > 0 Then
            Dim drContador() As DataRow = mdtContadores.Select("IDContador = '" & StrContador & "'")
            If drContador.Length > 0 Then
                TxtNFactura.Text = FormatCounter(drContador(0))
            End If
        End If
    End Sub

    Protected Overridable Function FormatCounter(ByVal rwCounter As DataRow) As String
        Dim EsNumerico As Boolean = rwCounter("Numerico")
        Dim ValorContador As Integer = rwCounter("Contador")

        Dim longitud As Integer
        If Not rwCounter.IsNull("Longitud") Then
            longitud = rwCounter("Longitud")
        End If

        Dim texto As String
        If rwCounter.IsNull("Texto") Then
            texto = String.Empty
        Else
            texto = rwCounter("Texto")
        End If

        Return FormatCounter(EsNumerico, ValorContador, longitud, texto)
    End Function

    Protected Overridable Function FormatCounter(ByVal Numeric As Boolean, ByVal Counter As Integer, ByVal mLen As Integer, ByVal strText As String) As String
        Dim strCounter As String = CStr(Counter)
        If Not Numeric Then
            Dim intPad As Integer = mLen - Len(strCounter) - Len(strText)
            If intPad > 0 Then
                strCounter = strText & New String("0", intPad) & strCounter
            Else
                strCounter = strText & strCounter
            End If
        End If
        Return strCounter
    End Function

    Protected Overridable Sub cbxFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxFecha.ValueChanged
        If Engine.Length(cbxFecha.Value) > 0 AndAlso IsDate(cbxFecha.Value) Then advIdEjercicio.Value = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, cbxFecha.Value)
    End Sub

#End Region

#Region " Grid "

    Protected Overridable Sub jngConsulta_CellUpdated(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngConsulta.CellUpdated
        Select Case e.Column.Key
            Case "ComisionA", "GastoA", "ARepercutirA"
                Dim dr As DataRowView = jngConsulta.GetRows(jngConsulta.Row).DataRow
                Dim CobroDevol As New CobroDevolucion
                Dim Current As New BusinessData(dr.Row)
                Current = CobroDevol.ApplyBusinessRule(e.Column.Key, jngConsulta.GetValue(e.Column.Key), New BusinessData(dr.Row), Nothing)
                For Each col As GridEXColumn In jngConsulta.Columns
                    jngConsulta.SetValue(col.Key, Current(col.Key))
                Next
                Dim MonInfoA As MonedaInfo = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate)
                jngConsulta.SetValue(e.Column.Key, xRound(jngConsulta.Value(e.Column.Key), MonInfoA.NDecimalesImporte))
        End Select
    End Sub

    Protected Overridable Sub jngConsulta_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngConsulta.UpdatingRecord
        With jngConsulta
            If Length(.Value("FechaDevolucion")) = 0 Then
                ExpertisApp.GenerateMessage("La fecha devolucion es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                nbxComisiones.Text = jngConsulta.GetTotal(jngConsulta.Columns("ComisionA"), Janus.Windows.GridEX.AggregateFunction.Sum)
            End If
        End With
    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Protected Overridable Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If mblnContabilidad AndAlso Length(advIdEjercicio.Text) = 0 Then
            ExpertisApp.GenerateMessage("Debe seleccionar el Ejercicio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf mblnContabilidad AndAlso Length(advBancoPropio.Text) = 0 Then
            ExpertisApp.GenerateMessage("Debe introducir un Banco Propio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf ExisteFechaDevolucionVacia() Then
            'Es obligatorio introducir la Fecha de Devolución
            ExpertisApp.GenerateMessage("Es obligatorio introducir la Fecha de Devolución de los cobros.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If chkAgruparBanco.Checked AndAlso ExistenFechasDevolucionDistintas() Then
                ExpertisApp.GenerateMessage("Las fechas de devolución son diferentes. No se realizará la agrupación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            If chkGenerarFact.Checked Then
                'Comprobamos que se han introducido todos los campos obligatorios
                If Length(advIdProveedor.Text) = 0 OrElse Length(advIdTipoIVA.Text) = 0 OrElse _
                   (mblnContabilidad AndAlso Length(advCContable.Text) = 0) OrElse Length(TxtNFactura.Text) = 0 OrElse _
                   Length(AdvIDContador.Text) = 0 OrElse Length(cbxFecha.Value) = 0 Then
                    ExpertisApp.GenerateMessage("Faltan campos obligatorios por informar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    If mblnContabilidad Then
                        Dim dFechaInicio, dFechaFin As Date
                        Dim dtEjercicio As DataTable = New EjercicioContable().SelOnPrimaryKey(advIdEjercicio.Text)
                        If dtEjercicio.Rows.Count > 0 Then
                            dFechaInicio = dtEjercicio.Rows(0)("FechaDesde")
                            dFechaFin = dtEjercicio.Rows(0)("FechaHasta")
                        End If
                        If cbxFecha.Value < dFechaInicio OrElse cbxFecha.Value > dFechaFin Then
                            ExpertisApp.GenerateMessage("La Fecha {0} no pertenece al Ejercicio {1}.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Quoted(Format(CStr(cbxFecha.Value), "dd/MM/yyyy")), Quoted(advIdEjercicio.Text))
                            Exit Sub
                        End If
                    End If

                    GenerarDatosDevolucion()
                    Exit Sub
                End If
            End If
            GenerarDatosDevolucion()
        End If
    End Sub

    Protected Overridable Sub GenerarDatosDevolucion()
        Dim datosFra As New DataPrcFacturacionDevolucion

        If chkGenerarFact.Checked Then
            datosFra = New DataPrcFacturacionDevolucion
            datosFra.IDContador = AdvIDContador.Text
            datosFra.NFactura = TxtNFactura.Text
            datosFra.FechaFactura = cbxFecha.Value
            datosFra.SuFactura = txtSuFactura.Text
            datosFra.SuFechaFactura = IIf(Engine.Length(cbxSuFecha.Value) <> 0, cbxSuFecha.Value, cbxFecha.Value)
            datosFra.IDProveedor = advIdProveedor.Text
            datosFra.IDArticulo = advArticulo.Text
            If mblnContabilidad Then datosFra.CContable = advCContable.Text
            datosFra.IDTipoIVA = advIdTipoIVA.Text
            datosFra.Precio = Nz(nbxComisiones.Value, 0)
        End If

        jngConsulta.DataSource = AddColumnExtra(jngConsulta.DataSource)
        If mblnContabilidad Then
            Dim SimInfo As New DataSimulacionContableInfoCobroDevol
            SimInfo.Caption = ExpertisApp.Traslate("Simulación Contable - DEVOLUCION DE COBROS -")
            SimInfo.IDEjercicio = advIdEjercicio.Text
            SimInfo.GuidSimulacion = mIDProcess
            SimInfo.IDBancoPropio = advBancoPropio.Text
            SimInfo.DescApunte = txtComentario.Text
            SimInfo.AgruparPorBanco = chkAgruparBanco.Checked
            SimInfo.GenerarFactura = chkGenerarFact.Checked
            SimInfo.NDocumento = TxtNFactura.Text
            SimInfo.FechaApunte = Nz(cbxFecha.Value, Today) 'FechaFactura 
            SimInfo.TipoIVA = advIdTipoIVA.Text
            SimInfo.DatosDevolucion = jngConsulta.DataSource
            If Not datosFra Is Nothing Then SimInfo.DatosFactura = datosFra
            Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
            AddHandler oFrm.Disposed, AddressOf FrmActionClosed
        Else
            Dim IDDevoluciones() As Integer = ExpertisApp.ExecuteTask(Of DataTable, Integer())(AddressOf Cobro.DevolucionCobros, jngConsulta.DataSource)
            If chkGenerarFact.Checked Then
                If Not IDDevoluciones Is Nothing AndAlso IDDevoluciones.Length > 0 Then datosFra.IDDevoluciones = IDDevoluciones
                Dim e As CreateElement = ExpertisApp.ExecuteTask(Of DataPrcFacturacionDevolucion, CreateElement)(AddressOf ProcesoContabilizacionCobroDevol.InsertarFraCompra, datosFra)
                If Not e Is Nothing Then
                    If ExpertisApp.GenerateMessage("Se ha generado la factura {0}. ¿Desea abrir su Mantenimiento?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, Quoted(e.NElement)) = Windows.Forms.DialogResult.Yes Then
                        ExpertisApp.OpenForm("MFACC", New NumberFilterItem("IDFactura", e.IDElement))
                        Me.RecordsState = RecordsState.Saved
                        ExpertisApp.CloseForm(Me.Name)
                    End If
                Else
                    ExpertisApp.GenerateMessage("No se ha generado la factura. Revise los datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Protected Overridable Function AddColumnExtra(ByVal dt As DataTable) As DataTable
        If Not dt.Columns.Contains("IDEjercicio") Then
            dt.Columns.Add("IDEjercicio", GetType(String))
            dt.Columns("IDEjercicio").ReadOnly = False
        End If
        If Not dt.Columns.Contains("NAsiento") Then
            dt.Columns.Add("NAsiento", GetType(Integer))
            dt.Columns("NAsiento").ReadOnly = False
        End If

        If Not dt.Columns.Contains("IDEjercicioTributario") Then
            dt.Columns.Add("IDEjercicioTributario", GetType(String))
            dt.Columns("IDEjercicioTributario").ReadOnly = False
        End If
        If Not dt.Columns.Contains("NAsientoTributario") Then
            dt.Columns.Add("NAsientoTributario", GetType(Integer))
            dt.Columns("NAsientoTributario").ReadOnly = False
        End If

        If Not dt.Columns.Contains("IDFacturaCompra") Then
            dt.Columns.Add("IDFacturaCompra", GetType(Integer))
            dt.Columns("IDFacturaCompra").ReadOnly = False
        End If
        Return dt
    End Function


    Protected Overridable Function ExisteFechaDevolucionVacia() As Boolean
        Dim f As New Filter
        f.Add(New IsNullFilterItem("FechaDevolucion"))
        Dim aSinFecha() As DataRow = CType(jngConsulta.DataSource, DataTable).Select(f.Compose(New AdoFilterComposer))
        Return (Not aSinFecha Is Nothing AndAlso aSinFecha.Length > 0)
    End Function

    Protected Overridable Function ExistenFechasDevolucionDistintas() As Boolean
        Dim FechaAnt As Date?
        For Each dr As DataRow In CType(jngConsulta.DataSource, DataTable).Select(Nothing, "FechaDevolucion")
            If FechaAnt Is Nothing Then FechaAnt = dr("FechaDevolucion")
            If FechaAnt <> dr("FechaDevolucion") Then
                Return True
            End If
        Next
    End Function

    Protected Overridable Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim blnDoit As Boolean = True
        If Not sender Is Nothing Then
            RemoveHandler CType(sender, Form).Disposed, AddressOf FrmActionClosed
            blnDoit = CType(sender, Form).DialogResult = DialogResult.OK
        End If
        If blnDoit Then
            Me.RecordsState = RecordsState.Saved
            ExpertisApp.CloseForm(Me.Name)
        End If
    End Sub


    Protected Overridable Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        ExpertisApp.CloseForm(Me.Name)
    End Sub


#End Region


End Class