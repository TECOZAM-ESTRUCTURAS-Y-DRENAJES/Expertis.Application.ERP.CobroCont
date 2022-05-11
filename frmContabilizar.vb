Public Class frmContabilizar
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
    Protected WithEvents FraOpcionesFactoring As Solmicro.Expertis.Engine.UI.Frame
    Protected WithEvents chkGenerarAsientoFactoring As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents chkGenerarFichero As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents chkContabilizacionFactoring As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents cbxFechaApunte As Solmicro.Expertis.Engine.UI.CalendarBox
    Protected WithEvents cboIDEjercicio As Solmicro.Expertis.Engine.UI.ComboBox
    Protected WithEvents lblcboIDEjercicio As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents ulblcboIDEjercicio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Protected WithEvents lblcbxFechaApunte As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents cboBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Protected WithEvents lblcboBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents ulblcboBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Protected WithEvents txtCContable As Solmicro.Expertis.Engine.UI.TextBox
    Protected WithEvents lbltxtCContable As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents cboSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Protected WithEvents lblcboSituacion As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents ulblcboSituacion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Protected WithEvents txtDescApunte As Solmicro.Expertis.Engine.UI.TextBox
    Protected WithEvents lbltxtDescApunte As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents chkAgruparBanco As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents lblcbxFechaVAlor As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents cbxFechaValor As Solmicro.Expertis.Engine.UI.CalendarBox
    Protected WithEvents lbltxtNDocumento As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents txtNDocumento As Solmicro.Expertis.Engine.UI.TextBox
    Protected WithEvents FraComisiones As Solmicro.Expertis.Engine.UI.Frame
    Protected WithEvents nbxComision As Solmicro.Expertis.Engine.UI.NumericTextBox
    Protected WithEvents nbxImporteBanco As Solmicro.Expertis.Engine.UI.NumericTextBox
    Protected WithEvents lblnbxComision As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Protected WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Protected WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Protected WithEvents chkGenerarAsientoCobro As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents chkGenerarAsientoEfectoRdo As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents ulblIDDivisa As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Protected WithEvents chkGenerarDifCambio As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents lblnbxImporteBanco As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cboBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContabilizar))
        Dim cboIDEjercicio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.txtDescApunte = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltxtDescApunte = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCContable = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltxtCContable = New Solmicro.Expertis.Engine.UI.Label
        Me.cboBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblcboBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.ulblcboBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cboIDEjercicio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblcboIDEjercicio = New Solmicro.Expertis.Engine.UI.Label
        Me.ulblcboIDEjercicio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxFechaApunte = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblcbxFechaApunte = New Solmicro.Expertis.Engine.UI.Label
        Me.chkAgruparBanco = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.cboSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblcboSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.ulblcboSituacion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lbltxtNDocumento = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcbxFechaVAlor = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNDocumento = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cbxFechaValor = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FraComisiones = New Solmicro.Expertis.Engine.UI.Frame
        Me.ulblIDDivisa = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.nbxComision = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.nbxImporteBanco = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblnbxComision = New Solmicro.Expertis.Engine.UI.Label
        Me.lblnbxImporteBanco = New Solmicro.Expertis.Engine.UI.Label
        Me.FraOpcionesFactoring = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkContabilizacionFactoring = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkGenerarFichero = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkGenerarAsientoFactoring = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.chkGenerarAsientoCobro = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkGenerarAsientoEfectoRdo = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkGenerarDifCambio = New Solmicro.Expertis.Engine.UI.CheckBox
        CType(Me.cboBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIDEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraComisiones.SuspendLayout()
        Me.FraOpcionesFactoring.SuspendLayout()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'txtDescApunte
        '
        Me.txtDescApunte.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescApunte.Location = New System.Drawing.Point(104, 124)
        Me.txtDescApunte.Name = "txtDescApunte"
        Me.txtDescApunte.Size = New System.Drawing.Size(308, 21)
        Me.txtDescApunte.TabIndex = 5
        '
        'lbltxtDescApunte
        '
        Me.lbltxtDescApunte.Location = New System.Drawing.Point(7, 124)
        Me.lbltxtDescApunte.Name = "lbltxtDescApunte"
        Me.lbltxtDescApunte.Size = New System.Drawing.Size(83, 13)
        Me.lbltxtDescApunte.TabIndex = 7
        Me.lbltxtDescApunte.Tag = "IdRec=4596;"
        Me.lbltxtDescApunte.Text = "Desc. Apunte"
        '
        'txtCContable
        '
        Me.txtCContable.DisabledBackColor = System.Drawing.Color.White
        Me.txtCContable.Enabled = False
        Me.txtCContable.Location = New System.Drawing.Point(104, 76)
        Me.txtCContable.Name = "txtCContable"
        Me.txtCContable.Size = New System.Drawing.Size(104, 21)
        Me.txtCContable.TabIndex = 3
        '
        'lbltxtCContable
        '
        Me.lbltxtCContable.Location = New System.Drawing.Point(8, 76)
        Me.lbltxtCContable.Name = "lbltxtCContable"
        Me.lbltxtCContable.Size = New System.Drawing.Size(67, 13)
        Me.lbltxtCContable.TabIndex = 9
        Me.lbltxtCContable.Tag = "IdRec=6586;"
        Me.lbltxtCContable.Text = "CContable"
        '
        'cboBancoPropio
        '
        cboBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("cboBancoPropio_DesignTimeLayout.LayoutString")
        Me.cboBancoPropio.DesignTimeLayout = cboBancoPropio_DesignTimeLayout
        Me.cboBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.cboBancoPropio.EntityName = "BancoPropio"
        Me.cboBancoPropio.Location = New System.Drawing.Point(104, 52)
        Me.cboBancoPropio.Name = "cboBancoPropio"
        Me.cboBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.cboBancoPropio.SelectedIndex = -1
        Me.cboBancoPropio.SelectedItem = Nothing
        Me.cboBancoPropio.Size = New System.Drawing.Size(104, 21)
        Me.cboBancoPropio.TabIndex = 2
        Me.cboBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'lblcboBancoPropio
        '
        Me.lblcboBancoPropio.Location = New System.Drawing.Point(8, 52)
        Me.lblcboBancoPropio.Name = "lblcboBancoPropio"
        Me.lblcboBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblcboBancoPropio.TabIndex = 10
        Me.lblcboBancoPropio.Tag = "IdRec=4613;"
        Me.lblcboBancoPropio.Text = "Banco Propio"
        '
        'ulblcboBancoPropio
        '
        Me.TryDataBinding(ulblcboBancoPropio, New System.Windows.Forms.Binding("Text", Me.cboBancoPropio, "DescBancoPropio", True))
        Me.ulblcboBancoPropio.Location = New System.Drawing.Point(208, 52)
        Me.ulblcboBancoPropio.Name = "ulblcboBancoPropio"
        Me.ulblcboBancoPropio.Size = New System.Drawing.Size(204, 22)
        Me.ulblcboBancoPropio.TabIndex = 11
        '
        'cboIDEjercicio
        '
        cboIDEjercicio_DesignTimeLayout.LayoutString = resources.GetString("cboIDEjercicio_DesignTimeLayout.LayoutString")
        Me.cboIDEjercicio.DesignTimeLayout = cboIDEjercicio_DesignTimeLayout
        Me.cboIDEjercicio.DisabledBackColor = System.Drawing.Color.White
        Me.cboIDEjercicio.EntityName = "EjercicioContable"
        Me.cboIDEjercicio.Location = New System.Drawing.Point(104, 29)
        Me.cboIDEjercicio.Name = "cboIDEjercicio"
        Me.cboIDEjercicio.SecondaryDataFields = "IDEjercicio"
        Me.cboIDEjercicio.SelectedIndex = -1
        Me.cboIDEjercicio.SelectedItem = Nothing
        Me.cboIDEjercicio.Size = New System.Drawing.Size(104, 21)
        Me.cboIDEjercicio.TabIndex = 1
        Me.cboIDEjercicio.ViewName = "tbMaestroEjercicio"
        '
        'lblcboIDEjercicio
        '
        Me.lblcboIDEjercicio.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.lblcboIDEjercicio.Location = New System.Drawing.Point(8, 29)
        Me.lblcboIDEjercicio.Name = "lblcboIDEjercicio"
        Me.lblcboIDEjercicio.Size = New System.Drawing.Size(55, 13)
        Me.lblcboIDEjercicio.TabIndex = 12
        Me.lblcboIDEjercicio.Tag = "IdRec=6583;"
        Me.lblcboIDEjercicio.Text = "Ejercicio"
        '
        'ulblcboIDEjercicio
        '
        Me.TryDataBinding(ulblcboIDEjercicio, New System.Windows.Forms.Binding("Text", Me.cboIDEjercicio, "DescEjercicio", True))
        Me.ulblcboIDEjercicio.Location = New System.Drawing.Point(208, 29)
        Me.ulblcboIDEjercicio.Name = "ulblcboIDEjercicio"
        Me.ulblcboIDEjercicio.Size = New System.Drawing.Size(204, 21)
        Me.ulblcboIDEjercicio.TabIndex = 13
        '
        'cbxFechaApunte
        '
        Me.cbxFechaApunte.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaApunte.Location = New System.Drawing.Point(104, 6)
        Me.cbxFechaApunte.Name = "cbxFechaApunte"
        Me.cbxFechaApunte.Size = New System.Drawing.Size(104, 21)
        Me.cbxFechaApunte.TabIndex = 0
        '
        'lblcbxFechaApunte
        '
        Me.lblcbxFechaApunte.Location = New System.Drawing.Point(8, 6)
        Me.lblcbxFechaApunte.Name = "lblcbxFechaApunte"
        Me.lblcbxFechaApunte.Size = New System.Drawing.Size(84, 13)
        Me.lblcbxFechaApunte.TabIndex = 14
        Me.lblcbxFechaApunte.Tag = "IdRec=4771;"
        Me.lblcbxFechaApunte.Text = "Fecha Apunte"
        '
        'chkAgruparBanco
        '
        Me.chkAgruparBanco.Location = New System.Drawing.Point(8, 179)
        Me.chkAgruparBanco.Name = "chkAgruparBanco"
        Me.chkAgruparBanco.Size = New System.Drawing.Size(181, 21)
        Me.chkAgruparBanco.TabIndex = 6
        Me.chkAgruparBanco.Text = "Agrupar apunte de Banco"
        '
        'cboSituacion
        '
        cboSituacion_DesignTimeLayout.LayoutString = resources.GetString("cboSituacion_DesignTimeLayout.LayoutString")
        Me.cboSituacion.DesignTimeLayout = cboSituacion_DesignTimeLayout
        Me.cboSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.cboSituacion.EntityName = "EstadoCobro"
        Me.cboSituacion.Location = New System.Drawing.Point(104, 100)
        Me.cboSituacion.Name = "cboSituacion"
        Me.cboSituacion.SecondaryDataFields = "IDEstado"
        Me.cboSituacion.SelectedIndex = -1
        Me.cboSituacion.SelectedItem = Nothing
        Me.cboSituacion.Size = New System.Drawing.Size(104, 21)
        Me.cboSituacion.TabIndex = 4
        Me.cboSituacion.ViewName = "tbMaestroEstadoCobro"
        '
        'lblcboSituacion
        '
        Me.lblcboSituacion.Location = New System.Drawing.Point(8, 100)
        Me.lblcboSituacion.Name = "lblcboSituacion"
        Me.lblcboSituacion.Size = New System.Drawing.Size(79, 13)
        Me.lblcboSituacion.TabIndex = 15
        Me.lblcboSituacion.Tag = "IdRec=4742;"
        Me.lblcboSituacion.Text = "Cambiar a..."
        '
        'ulblcboSituacion
        '
        Me.TryDataBinding(ulblcboSituacion, New System.Windows.Forms.Binding("Text", Me.cboSituacion, "DescEstado", True))
        Me.ulblcboSituacion.Location = New System.Drawing.Point(208, 100)
        Me.ulblcboSituacion.Name = "ulblcboSituacion"
        Me.ulblcboSituacion.Size = New System.Drawing.Size(204, 22)
        Me.ulblcboSituacion.TabIndex = 16
        '
        'lbltxtNDocumento
        '
        Me.lbltxtNDocumento.Location = New System.Drawing.Point(8, 234)
        Me.lbltxtNDocumento.Name = "lbltxtNDocumento"
        Me.lbltxtNDocumento.Size = New System.Drawing.Size(72, 13)
        Me.lbltxtNDocumento.TabIndex = 19
        Me.lbltxtNDocumento.Tag = "IdRec=4739;"
        Me.lbltxtNDocumento.Text = "Documento"
        '
        'lblcbxFechaVAlor
        '
        Me.lblcbxFechaVAlor.Location = New System.Drawing.Point(8, 210)
        Me.lblcbxFechaVAlor.Name = "lblcbxFechaVAlor"
        Me.lblcbxFechaVAlor.Size = New System.Drawing.Size(73, 13)
        Me.lblcbxFechaVAlor.TabIndex = 20
        Me.lblcbxFechaVAlor.Tag = "IdRec=5024;"
        Me.lblcbxFechaVAlor.Text = "Fecha Valor"
        '
        'txtNDocumento
        '
        Me.txtNDocumento.DisabledBackColor = System.Drawing.Color.White
        Me.txtNDocumento.Location = New System.Drawing.Point(104, 234)
        Me.txtNDocumento.Name = "txtNDocumento"
        Me.txtNDocumento.Size = New System.Drawing.Size(104, 21)
        Me.txtNDocumento.TabIndex = 8
        '
        'cbxFechaValor
        '
        Me.cbxFechaValor.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaValor.Location = New System.Drawing.Point(104, 210)
        Me.cbxFechaValor.Name = "cbxFechaValor"
        Me.cbxFechaValor.Size = New System.Drawing.Size(104, 21)
        Me.cbxFechaValor.TabIndex = 7
        '
        'FraComisiones
        '
        Me.FraComisiones.Controls.Add(Me.chkGenerarDifCambio)
        Me.FraComisiones.Controls.Add(Me.ulblIDDivisa)
        Me.FraComisiones.Controls.Add(Me.nbxComision)
        Me.FraComisiones.Controls.Add(Me.nbxImporteBanco)
        Me.FraComisiones.Controls.Add(Me.lblnbxComision)
        Me.FraComisiones.Controls.Add(Me.lblnbxImporteBanco)
        Me.FraComisiones.Location = New System.Drawing.Point(5, 268)
        Me.FraComisiones.Name = "FraComisiones"
        Me.FraComisiones.Size = New System.Drawing.Size(240, 102)
        Me.FraComisiones.TabIndex = 9
        Me.FraComisiones.TabStop = False
        Me.FraComisiones.Tag = "47474"
        Me.FraComisiones.Text = "Diferencias de importe y comisiones"
        '
        'ulblIDDivisa
        '
        Me.ulblIDDivisa.Location = New System.Drawing.Point(209, 53)
        Me.ulblIDDivisa.Name = "ulblIDDivisa"
        Me.ulblIDDivisa.Size = New System.Drawing.Size(27, 19)
        Me.ulblIDDivisa.TabIndex = 29
        '
        'nbxComision
        '
        Me.nbxComision.DisabledBackColor = System.Drawing.Color.White
        Me.nbxComision.Location = New System.Drawing.Point(96, 51)
        Me.nbxComision.Name = "nbxComision"
        Me.nbxComision.Size = New System.Drawing.Size(110, 21)
        Me.nbxComision.TabIndex = 1
        '
        'nbxImporteBanco
        '
        Me.nbxImporteBanco.DisabledBackColor = System.Drawing.Color.White
        Me.nbxImporteBanco.Location = New System.Drawing.Point(96, 24)
        Me.nbxImporteBanco.Name = "nbxImporteBanco"
        Me.nbxImporteBanco.Size = New System.Drawing.Size(110, 21)
        Me.nbxImporteBanco.TabIndex = 0
        '
        'lblnbxComision
        '
        Me.lblnbxComision.Location = New System.Drawing.Point(4, 55)
        Me.lblnbxComision.Name = "lblnbxComision"
        Me.lblnbxComision.Size = New System.Drawing.Size(73, 13)
        Me.lblnbxComision.TabIndex = 23
        Me.lblnbxComision.Tag = "IdRec=47476;"
        Me.lblnbxComision.Text = "Comisiones"
        '
        'lblnbxImporteBanco
        '
        Me.lblnbxImporteBanco.Location = New System.Drawing.Point(4, 28)
        Me.lblnbxImporteBanco.Name = "lblnbxImporteBanco"
        Me.lblnbxImporteBanco.Size = New System.Drawing.Size(92, 13)
        Me.lblnbxImporteBanco.TabIndex = 21
        Me.lblnbxImporteBanco.Tag = "IdRec=47475;"
        Me.lblnbxImporteBanco.Text = "Importe Banco"
        '
        'FraOpcionesFactoring
        '
        Me.FraOpcionesFactoring.Controls.Add(Me.chkContabilizacionFactoring)
        Me.FraOpcionesFactoring.Controls.Add(Me.chkGenerarFichero)
        Me.FraOpcionesFactoring.Controls.Add(Me.chkGenerarAsientoFactoring)
        Me.FraOpcionesFactoring.Location = New System.Drawing.Point(248, 268)
        Me.FraOpcionesFactoring.Name = "FraOpcionesFactoring"
        Me.FraOpcionesFactoring.Size = New System.Drawing.Size(164, 102)
        Me.FraOpcionesFactoring.TabIndex = 10
        Me.FraOpcionesFactoring.TabStop = False
        Me.FraOpcionesFactoring.Text = "Opciones de Factoring"
        '
        'chkContabilizacionFactoring
        '
        Me.chkContabilizacionFactoring.Location = New System.Drawing.Point(18, 21)
        Me.chkContabilizacionFactoring.Name = "chkContabilizacionFactoring"
        Me.chkContabilizacionFactoring.Size = New System.Drawing.Size(138, 16)
        Me.chkContabilizacionFactoring.TabIndex = 0
        Me.chkContabilizacionFactoring.Text = "Contabilización"
        '
        'chkGenerarFichero
        '
        Me.chkGenerarFichero.Location = New System.Drawing.Point(18, 63)
        Me.chkGenerarFichero.Name = "chkGenerarFichero"
        Me.chkGenerarFichero.Size = New System.Drawing.Size(146, 16)
        Me.chkGenerarFichero.TabIndex = 2
        Me.chkGenerarFichero.Text = "Generar Fichero"
        '
        'chkGenerarAsientoFactoring
        '
        Me.chkGenerarAsientoFactoring.Location = New System.Drawing.Point(18, 42)
        Me.chkGenerarAsientoFactoring.Name = "chkGenerarAsientoFactoring"
        Me.chkGenerarAsientoFactoring.Size = New System.Drawing.Size(146, 16)
        Me.chkGenerarAsientoFactoring.TabIndex = 1
        Me.chkGenerarAsientoFactoring.Text = "Generar Asiento"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 376)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 40)
        Me.Panel1.TabIndex = 37
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(117, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 25)
        Me.cmbAceptar.TabIndex = 12
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(213, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 25)
        Me.cmbCancelar.TabIndex = 13
        Me.cmbCancelar.Text = "Cancelar"
        '
        'chkGenerarAsientoCobro
        '
        Me.chkGenerarAsientoCobro.Checked = True
        Me.chkGenerarAsientoCobro.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGenerarAsientoCobro.Location = New System.Drawing.Point(8, 156)
        Me.chkGenerarAsientoCobro.Name = "chkGenerarAsientoCobro"
        Me.chkGenerarAsientoCobro.Size = New System.Drawing.Size(200, 17)
        Me.chkGenerarAsientoCobro.TabIndex = 38
        Me.chkGenerarAsientoCobro.Text = "Generar Asiento Contabilización"
        '
        'chkGenerarAsientoEfectoRdo
        '
        Me.chkGenerarAsientoEfectoRdo.Location = New System.Drawing.Point(216, 156)
        Me.chkGenerarAsientoEfectoRdo.Name = "chkGenerarAsientoEfectoRdo"
        Me.chkGenerarAsientoEfectoRdo.Size = New System.Drawing.Size(199, 16)
        Me.chkGenerarAsientoEfectoRdo.TabIndex = 39
        Me.chkGenerarAsientoEfectoRdo.Text = "Generar Asiento Efec. Recibido"
        '
        'chkGenerarDifCambio
        '
        Me.chkGenerarDifCambio.Enabled = False
        Me.chkGenerarDifCambio.Location = New System.Drawing.Point(5, 80)
        Me.chkGenerarDifCambio.Name = "chkGenerarDifCambio"
        Me.chkGenerarDifCambio.Size = New System.Drawing.Size(196, 16)
        Me.chkGenerarDifCambio.TabIndex = 2
        Me.chkGenerarDifCambio.Text = "Generar Diferencia Cambio"
        '
        'frmContabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(418, 416)
        Me.Controls.Add(Me.chkGenerarAsientoEfectoRdo)
        Me.Controls.Add(Me.chkGenerarAsientoCobro)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FraOpcionesFactoring)
        Me.Controls.Add(Me.FraComisiones)
        Me.Controls.Add(Me.lbltxtNDocumento)
        Me.Controls.Add(Me.lblcbxFechaVAlor)
        Me.Controls.Add(Me.txtNDocumento)
        Me.Controls.Add(Me.cbxFechaValor)
        Me.Controls.Add(Me.lbltxtDescApunte)
        Me.Controls.Add(Me.lbltxtCContable)
        Me.Controls.Add(Me.lblcboBancoPropio)
        Me.Controls.Add(Me.lblcboIDEjercicio)
        Me.Controls.Add(Me.lblcbxFechaApunte)
        Me.Controls.Add(Me.lblcboSituacion)
        Me.Controls.Add(Me.txtDescApunte)
        Me.Controls.Add(Me.txtCContable)
        Me.Controls.Add(Me.ulblcboBancoPropio)
        Me.Controls.Add(Me.cboBancoPropio)
        Me.Controls.Add(Me.ulblcboIDEjercicio)
        Me.Controls.Add(Me.cboIDEjercicio)
        Me.Controls.Add(Me.cbxFechaApunte)
        Me.Controls.Add(Me.chkAgruparBanco)
        Me.Controls.Add(Me.ulblcboSituacion)
        Me.Controls.Add(Me.cboSituacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmContabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilización"
        CType(Me.cboBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIDEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraComisiones.ResumeLayout(False)
        Me.FraComisiones.PerformLayout()
        Me.FraOpcionesFactoring.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Propiedades "

    Protected mblnContabilizarFactoring As Boolean
    Public ReadOnly Property ContabilizacionFactoring() As Boolean
        Get
            Return mblnContabilizarFactoring
        End Get
    End Property

    Protected mblnGenerarFicheroFactoring As Boolean
    Public ReadOnly Property FicheroFactoring() As Boolean
        Get
            Return mblnGenerarFicheroFactoring
        End Get
    End Property

    Protected mblnGenerarAsientoFactoring As Boolean
    Public ReadOnly Property AsientoFactoring() As Boolean
        Get
            Return mblnGenerarAsientoFactoring
        End Get
    End Property

    Protected mblnGenerarAsientoEfectoRdo As Boolean
    Public ReadOnly Property AsientoEfectoRdo() As Boolean
        Get
            Return mblnGenerarAsientoEfectoRdo
        End Get
    End Property

    Protected mblnGenerarAsientoCobro As Boolean
    Public ReadOnly Property AsientoCobro() As Boolean
        Get
            Return mblnGenerarAsientoCobro
        End Get
    End Property

    Public ReadOnly Property Comision() As Double
        Get
            Return Me.nbxComision.Value
        End Get
    End Property

    Public ReadOnly Property ImporteBanco() As Double
        Get
            Return Me.nbxImporteBanco.Value
        End Get
    End Property

    Public ReadOnly Property GenerarDiferenciaCambio() As Boolean
        Get
            Return Me.chkGenerarDifCambio.Checked
        End Get
    End Property

#End Region

    Protected mdtCobros As DataTable
    Protected mblnEspecial As Boolean

#Region " Carga/Descarga del formulario "

    Public Function AbrirContabilizacion(ByVal dtCobrosSeleccionados As DataTable, _
                                         Optional ByVal blnCambioSitAuto As Boolean = True, _
                                         Optional ByVal blnCambioSitManual As Boolean = True, _
                                         Optional ByVal strIdBPropio As String = "", _
                                         Optional ByVal blnEspecial As Boolean = False) As DialogResult

        mdtCobros = dtCobrosSeleccionados
        mblnEspecial = blnEspecial
        cboBancoPropio.Value = strIdBPropio
        If Not blnCambioSitManual Then
            cboSituacion.Value = New Parametro().CobroContSituacion
        Else
            'Si blnCambioSituacionManual=True implica una contabilizacion por cambio de
            'situacion a "Cobrado" sin estar contabilizado
            cboSituacion.Enabled = False
            cboSituacion.Value = enumCobroSituacion.Cobrado
        End If

        Me.ShowDialog()

        Return Me.DialogResult
    End Function

    Protected Overridable Sub frmCobroCont_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            intAccion = 0
            dtFechaApunte = Date.Today
            cbxFechaApunte.Value = dtFechaApunte
            cbxFechaApunte_Validated(cbxFechaApunte, New EventArgs)
            Dim oFilter As New Filter
            oFilter.Add(New BooleanFilterItem("EjercicioCerrado", FilterOperator.Equal, False))
            oFilter.Add(New BooleanFilterItem("AIva", FilterOperator.Equal, Not mblnEspecial))
            cboIDEjercicio.Filter = oFilter
            If Engine.Length(cboBancoPropio.Value) > 0 Then
                cboBancoPropio_Validated(cboBancoPropio, New EventArgs)
            End If
            If Engine.Length(cboSituacion.Value) > 0 Then
                cboSituacion_Validated(cboSituacion, New EventArgs)
            End If

            chkGenerarAsientoCobro.Checked = True
            chkGenerarAsientoEfectoRdo.Checked = False

            SettingFactoring()
        End If
    End Sub

    Protected Overridable Sub frmCobroCont_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        '     Me.DialogResult = Windows.Forms.DialogResult.Cancel
        e.Cancel = mblnCancel
        mblnCancel = False
    End Sub

#End Region

#Region " Eventos de los controles "

    Protected Overridable Sub cboIDEjercicio_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIDEjercicio.Validated
        mstrEjercicioActual = cboIDEjercicio.Value
    End Sub

    Protected Overridable Sub cboBancoPropio_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBancoPropio.Validated
        'Muestra la CContable asociada al Banco Propio
        If Engine.Length(cboBancoPropio.Value) > 0 Then
            Dim dtBP As DataTable = New BancoPropio().SelOnPrimaryKey(cboBancoPropio.Value)
            If Not dtBP Is Nothing AndAlso dtBP.Rows.Count > 0 Then
                txtCContable.Text = dtBP.Rows(0)("CContable") & String.Empty
                ulblcboBancoPropio.Text = dtBP.Rows(0)("DescBancoPropio") & String.Empty
            Else
                txtCContable.Text = String.Empty
                cboBancoPropio.Value = String.Empty
                ulblcboBancoPropio.Text = String.Empty
            End If
            ValidarBancoPropioFactoring()
        Else
            txtCContable.Text = String.Empty
            ulblcboBancoPropio.Text = String.Empty
        End If
    End Sub

    Protected Overridable Sub cboSituacion_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSituacion.Validated
        If Engine.Length(cboSituacion.Value) > 0 Then
            Dim dtSituacion As DataTable = New EstadoCobro().SelOnPrimaryKey(cboSituacion.Value)
            If Not IsNothing(dtSituacion) AndAlso dtSituacion.Rows.Count > 0 Then
                lngNuevaSituacion = cboSituacion.Value
                ulblcboSituacion.Text = dtSituacion.Rows(0)("DescEstado") & String.Empty
            Else
                lngNuevaSituacion = -1
                ulblcboSituacion.Text = String.Empty
            End If
        Else
            lngNuevaSituacion = -1
            ulblcboSituacion.Text = String.Empty
        End If
    End Sub

    Protected Overridable Sub cbxFechaApunte_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFechaApunte.Validated
        If Engine.Length(cbxFechaApunte.Value) > 0 Then
            dtFechaApunte = cbxFechaApunte.Value
            If mblnEspecial Then
                cboIDEjercicio.Value = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.PredeterminadoB, dtFechaApunte)
            Else
                cboIDEjercicio.Value = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, dtFechaApunte)
            End If
        Else
            cboIDEjercicio.Value = System.DBNull.Value
        End If
        cboIDEjercicio_Validated(cboIDEjercicio, New System.EventArgs)
    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Protected Overridable Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Engine.Length(cboIDEjercicio.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe introducir un Ejercicio Contable.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cboIDEjercicio.Focus()
        ElseIf Engine.Length(Me.cbxFechaApunte.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe introducir una Fecha de Apunte.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbxFechaApunte.Focus()
        ElseIf (Not Me.chkGenerarAsientoEfectoRdo.Checked) AndAlso Engine.Length(Me.cboBancoPropio.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe introducir un Banco Propio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cboBancoPropio.Focus()
        Else
            If (Not Me.chkGenerarAsientoEfectoRdo.Checked) AndAlso Me.nbxImporteBanco.Value > 0 AndAlso Not Me.chkAgruparBanco.Checked Then
                If Not mdtCobros Is Nothing AndAlso mdtCobros.Rows.Count > 1 Then
                    ExpertisApp.GenerateMessage("Si introduce Importe de Banco, debe agrupar los apuntes por banco.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.chkAgruparBanco.Focus()
                    Exit Sub
                End If
            End If

            Dim dtDesde As Date
            Dim dtHasta As Date
            Dim dtEjercicio As DataTable = New EjercicioContable().SelOnPrimaryKey(mstrEjercicioActual)
            If Not IsNothing(dtEjercicio) AndAlso dtEjercicio.Rows.Count > 0 Then
                dtDesde = dtEjercicio.Rows(0)("FechaDesde")
                dtHasta = dtEjercicio.Rows(0)("FechaHasta")
            Else
                ExpertisApp.GenerateMessage("Debe introducir un Ejercicio Contable correcto.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cboIDEjercicio.Focus()
                Exit Sub
            End If

            If cbxFechaApunte.Value < dtDesde Or cbxFechaApunte.Value > dtHasta Then
                ExpertisApp.GenerateMessage("La fecha introducida no pertenece al Ejercicio Seleccionado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            mstrIDBancoPropio = cboBancoPropio.Value
            If Me.chkGenerarAsientoEfectoRdo.Checked Then
                chkAgruparBanco.Checked = False
            End If
            mblnAgruparBanco = chkAgruparBanco.Checked
            mstrDescApunte = txtDescApunte.Text
            mstrNDocumento = txtNDocumento.Text
            If Engine.Length(cbxFechaValor.Value) > 0 Then
                mdtFechaValor = cbxFechaValor.Value
            End If

            intAccion = enumAccion.Contabilizar
            If Engine.Length(cboSituacion.Value) = 0 Then
                lngNuevaSituacion = -1
            Else
                lngNuevaSituacion = cboSituacion.Value
            End If

            ComprobarContabilidaEnVto(mblnCancel)

            If Not mblnCancel Then
                '//FACTORING
                mblnContabilizarFactoring = chkContabilizacionFactoring.Checked
                mblnGenerarFicheroFactoring = chkGenerarFichero.Checked
                mblnGenerarAsientoFactoring = chkGenerarAsientoFactoring.Checked

                mblnGenerarAsientoCobro = chkGenerarAsientoCobro.Checked
                mblnGenerarAsientoEfectoRdo = chkGenerarAsientoEfectoRdo.Checked

                If Not mblnGenerarAsientoFactoring AndAlso Not mblnGenerarAsientoCobro AndAlso Not mblnGenerarAsientoEfectoRdo AndAlso Not mblnGenerarFicheroFactoring Then
                    ExpertisApp.GenerateMessage("Debe indicar el tipo de Contabilización que quiere realizar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub


    Protected Overridable Sub ComprobarContabilidaEnVto(ByRef blnCancel As Boolean)
        blnCancel = False
        If chkAgruparBanco.Checked Then
            '//Debemos comprobar que la forma de pago de los distintos cobros seleccionados no tengan la marca de Contabilidad en Vto.  activada, ya que 
            '//en este caso no podemos agrupar por Banco, salvo que tengan el mismo ejercicio entre ellos y/o el mismo que el que ha introducido el usuario.
            Dim objFilterOR As New Filter(FilterUnionOperator.Or)
            Dim objFilter As New Filter
            objFilter.Add(New BooleanFilterItem("ContabilidadEnVto", True))
            For Each drCobrosVto As DataRow In mdtCobros.Select(objFilter.Compose(New AdoFilterComposer))
                objFilterOR.Add(New NumberFilterItem("IDCobro", drCobrosVto("IDCobro")))
            Next

            '//Miramos el ejercicio de los Cobros con Contabilidad en Vto.
            Dim dt As DataTable = New BE.DataEngine().Filter("vCobrosContabilidadEnVto", objFilterOR)
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                Dim strIDEjercicioCont As String = String.Empty
                Dim strIDEjercicioAnt As String = String.Empty
                Dim dFechaVto, dFechaAnt As Date
                Dim adr() As DataRow
                For Each drCobrosSel As DataRow In mdtCobros.Select(Nothing, "FechaVencimiento")
                    If Nz(drCobrosSel("ContabilidadEnVto"), False) Then
                        objFilter.Clear()
                        objFilter.Add(New NumberFilterItem("IDCobro", drCobrosSel("IDCobro")))
                        adr = dt.Select(objFilter.Compose(New AdoFilterComposer))
                        If Not IsNothing(adr) AndAlso adr.Length > 0 Then
                            strIDEjercicioCont = adr(0)("IDEjercicio") & String.Empty
                        Else
                            strIDEjercicioCont = cboIDEjercicio.Value
                        End If
                        dFechaVto = CDate(Nz(drCobrosSel("FechaVencimiento"), cnMinDate))
                    Else
                        strIDEjercicioCont = cboIDEjercicio.Value
                        dFechaVto = CDate(cbxFechaApunte.Value)
                    End If

                    If Engine.Length(strIDEjercicioAnt) = 0 Then strIDEjercicioAnt = strIDEjercicioCont
                    If dFechaAnt = cnMinDate Then dFechaAnt = dFechaVto
                    If (strIDEjercicioCont <> strIDEjercicioAnt OrElse dFechaVto <> dFechaAnt) AndAlso dt.Rows.Count > 1 Then
                        blnCancel = True
                        ExpertisApp.GenerateMessage("Los cobros seleccionados no se pueden contabilizar agrupando por Banco. Compruebe su Forma de Pago.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit For
                    End If
                    strIDEjercicioAnt = strIDEjercicioCont
                    dFechaAnt = dFechaVto
                Next
            End If
        End If
    End Sub


    Protected Overridable Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        intAccion = enumAccion.Cancelar
        Me.Close()
    End Sub

#End Region

#Region " FACTORING "

    Private Sub chkContabilizacionFactoring_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkContabilizacionFactoring.CheckedChanged
        If chkContabilizacionFactoring.Checked Then
            chkGenerarAsientoFactoring.Checked = True : chkGenerarAsientoFactoring.Enabled = True
            chkGenerarFichero.Checked = True : chkGenerarFichero.Enabled = True
            cboSituacion.Enabled = False
            cboSituacion.Value = New Parametro().EstadoCobroFactoringPredeterminado
            ValidarBancoPropioFactoring()
        Else
            chkGenerarAsientoFactoring.Checked = True : chkGenerarAsientoFactoring.Enabled = False
            chkGenerarFichero.Checked = False : chkGenerarFichero.Enabled = False
            cboSituacion.Enabled = True
            cboSituacion.Value = New Parametro().CobroContSituacion
        End If
    End Sub

    Private Function ValidarBancoPropioFactoring() As Boolean
        If chkContabilizacionFactoring.Checked AndAlso Engine.Length(cboBancoPropio.Value) > 0 Then
            '//Comprobamos si el Banco Propio es de Factoring
            If Not ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf BancoPropio.BancoFactoring, cboBancoPropio.Value) Then
                ExpertisApp.GenerateMessage("El Banco Propio seleccionado no está marcado como Factoring.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboBancoPropio.Value = String.Empty
            End If
        End If
    End Function

    Private Sub SettingFactoring()
        chkGenerarAsientoFactoring.Enabled = False
        chkGenerarFichero.Enabled = False
        chkGenerarAsientoFactoring.Checked = False
    End Sub


    Private Sub ControlExclusivoAsientos(ByVal blnAsientoFactoring As Boolean, ByVal blnAsientoCobro As Boolean, ByVal blnAsientoEfectoRdo As Boolean)
        If blnAsientoFactoring Then
            cboSituacion.Value = enumCobroSituacion.Factoring

            chkGenerarAsientoCobro.Checked = False
            chkGenerarAsientoEfectoRdo.Checked = False
        ElseIf blnAsientoCobro Then
            cboSituacion.Value = enumCobroSituacion.Cobrado

            chkGenerarAsientoFactoring.Checked = False
            chkGenerarAsientoEfectoRdo.Checked = False
        ElseIf blnAsientoEfectoRdo Then
            cboSituacion.Value = enumCobroSituacion.RecibidoClte
            chkGenerarAsientoFactoring.Checked = False
            chkGenerarAsientoCobro.Checked = False
        End If
    End Sub

#End Region

    Private Sub chkGenerarAsientoCobro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGenerarAsientoCobro.CheckedChanged
        ControlExclusivoAsientos(False, chkGenerarAsientoCobro.Checked, False)
    End Sub

    Private Sub chkGenerarAsientoEfectoRdo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGenerarAsientoEfectoRdo.CheckedChanged
        ControlExclusivoAsientos(False, False, chkGenerarAsientoEfectoRdo.Checked)
    End Sub
    Private Sub chkGenerarAsientoFactoring_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGenerarAsientoFactoring.CheckedChanged
        ControlExclusivoAsientos(chkGenerarAsientoFactoring.Checked, False, False)
    End Sub



    Private Sub txtCContable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCContable.TextChanged
        GetMonedaDivisa()
    End Sub

    Protected Overridable Sub GetMonedaDivisa()
        If Length(Me.txtCContable.Text) > 0 AndAlso Length(Me.cboIDEjercicio.Value) > 0 Then
            Dim datDivisa As New FinancieroGeneral.DataGetDivisaCuenta(Me.cboIDEjercicio.Value, Me.txtCContable.Text)
            Me.ulblIDDivisa.Text = ExpertisApp.ExecuteTask(Of FinancieroGeneral.DataGetDivisaCuenta, String)(AddressOf FinancieroGeneral.GetDivisaCuenta, datDivisa)
        End If
    End Sub

    Private Sub cboIDEjercicio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboIDEjercicio.ValueChanged
        GetMonedaDivisa()
    End Sub

    Private Sub ulblIDDivisa_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ulblIDDivisa.TextChanged
        nbxImporteBanco.Enabled = (Length(ulblIDDivisa.Text) = 0)
        chkGenerarDifCambio.Enabled = (Length(ulblIDDivisa.Text) > 0)
        If Not nbxImporteBanco.Enabled Then Me.nbxImporteBanco.Text = 0
        If Not chkGenerarDifCambio.Enabled Then chkGenerarDifCambio.Checked = False
    End Sub

    Private Sub nbxComision_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbxComision.Validated
        If Nz(nbxComision.Value, 0) <> 0 Then
            Me.chkAgruparBanco.Checked = True
        End If
    End Sub

    Private Sub chkGenerarDifCambio_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGenerarDifCambio.CheckedChanged
        If chkGenerarDifCambio.Checked Then
            Me.chkAgruparBanco.Checked = True
        End If
    End Sub
End Class
