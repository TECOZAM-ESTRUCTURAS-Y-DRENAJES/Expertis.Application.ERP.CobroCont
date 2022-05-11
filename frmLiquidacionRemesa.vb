
Public Class frmLiquidacionRemesa
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
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents fwiDescApunte As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiDescApunte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblfwiSituacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcfwiSituacion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents FraFechaAsiento As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents fwiFechaRemesa As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents fwiFechaVencimiento As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents fwiFechaApunte As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents fwiAgruparBanco As Solmicro.Expertis.Engine.UI.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim fwiSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLiquidacionRemesa))
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.fwiDescApunte = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiDescApunte = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiSituacion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiAgruparBanco = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FraFechaAsiento = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiFechaApunte = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.fwiFechaVencimiento = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.fwiFechaRemesa = New Solmicro.Expertis.Engine.UI.RadioButton
        CType(Me.fwiSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraFechaAsiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(208, 192)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 25)
        Me.cmbCancelar.TabIndex = 7
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmbAceptar.Location = New System.Drawing.Point(112, 192)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(88, 25)
        Me.cmbAceptar.TabIndex = 6
        Me.cmbAceptar.Text = "Aceptar"
        '
        'fwiDescApunte
        '
        Me.fwiDescApunte.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDescApunte.Location = New System.Drawing.Point(99, 36)
        Me.fwiDescApunte.Name = "fwiDescApunte"
        Me.fwiDescApunte.Size = New System.Drawing.Size(192, 21)
        Me.fwiDescApunte.TabIndex = 1
        '
        'lblfwiDescApunte
        '
        Me.lblfwiDescApunte.Location = New System.Drawing.Point(10, 40)
        Me.lblfwiDescApunte.Name = "lblfwiDescApunte"
        Me.lblfwiDescApunte.Size = New System.Drawing.Size(83, 13)
        Me.lblfwiDescApunte.TabIndex = 7
        Me.lblfwiDescApunte.Tag = "IdRec=4596;"
        Me.lblfwiDescApunte.Text = "Desc. Apunte"
        '
        'fwiSituacion
        '
        fwiSituacion_DesignTimeLayout.LayoutString = resources.GetString("fwiSituacion_DesignTimeLayout.LayoutString")
        Me.fwiSituacion.DesignTimeLayout = fwiSituacion_DesignTimeLayout
        Me.fwiSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiSituacion.EntityName = "EstadoCobro"
        Me.fwiSituacion.Location = New System.Drawing.Point(101, 9)
        Me.fwiSituacion.Name = "fwiSituacion"
        Me.fwiSituacion.PrimaryDataFields = "IDEstado"
        Me.fwiSituacion.SecondaryDataFields = "IDEstado"
        Me.fwiSituacion.SelectedIndex = -1
        Me.fwiSituacion.SelectedItem = Nothing
        Me.fwiSituacion.Size = New System.Drawing.Size(53, 21)
        Me.fwiSituacion.TabIndex = 0
        Me.fwiSituacion.ViewName = "tbMaestroEstadoCobro"
        '
        'lblfwiSituacion
        '
        Me.lblfwiSituacion.Location = New System.Drawing.Point(10, 13)
        Me.lblfwiSituacion.Name = "lblfwiSituacion"
        Me.lblfwiSituacion.Size = New System.Drawing.Size(79, 13)
        Me.lblfwiSituacion.TabIndex = 8
        Me.lblfwiSituacion.Tag = "IdRec=4742;"
        Me.lblfwiSituacion.Text = "Cambiar a..."
        '
        'lblcfwiSituacion
        '
        Me.TryDataBinding(lblcfwiSituacion, New System.Windows.Forms.Binding("Text", Me.fwiSituacion, "DescEstado", True))
        Me.lblcfwiSituacion.Location = New System.Drawing.Point(156, 9)
        Me.lblcfwiSituacion.Name = "lblcfwiSituacion"
        Me.lblcfwiSituacion.Size = New System.Drawing.Size(133, 22)
        Me.lblcfwiSituacion.TabIndex = 9
        '
        'fwiAgruparBanco
        '
        Me.fwiAgruparBanco.Location = New System.Drawing.Point(27, 160)
        Me.fwiAgruparBanco.Name = "fwiAgruparBanco"
        Me.fwiAgruparBanco.Size = New System.Drawing.Size(240, 23)
        Me.fwiAgruparBanco.TabIndex = 5
        Me.fwiAgruparBanco.Text = "Agrupar apunte de Banco"
        '
        'FraFechaAsiento
        '
        Me.FraFechaAsiento.Controls.Add(Me.fwiFechaRemesa)
        Me.FraFechaAsiento.Controls.Add(Me.fwiFechaVencimiento)
        Me.FraFechaAsiento.Controls.Add(Me.fwiFechaApunte)
        Me.FraFechaAsiento.Location = New System.Drawing.Point(9, 66)
        Me.FraFechaAsiento.Name = "FraFechaAsiento"
        Me.FraFechaAsiento.Size = New System.Drawing.Size(287, 89)
        Me.FraFechaAsiento.TabIndex = 10
        Me.FraFechaAsiento.TabStop = False
        Me.FraFechaAsiento.Text = "Fecha Asiento"
        '
        'fwiFechaApunte
        '
        Me.fwiFechaApunte.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaApunte.Location = New System.Drawing.Point(82, 22)
        Me.fwiFechaApunte.Name = "fwiFechaApunte"
        Me.fwiFechaApunte.Size = New System.Drawing.Size(112, 21)
        Me.fwiFechaApunte.TabIndex = 3
        '
        'fwiFechaVencimiento
        '
        Me.fwiFechaVencimiento.Location = New System.Drawing.Point(11, 54)
        Me.fwiFechaVencimiento.Name = "fwiFechaVencimiento"
        Me.fwiFechaVencimiento.Size = New System.Drawing.Size(128, 19)
        Me.fwiFechaVencimiento.TabIndex = 4
        Me.fwiFechaVencimiento.Text = "Fecha Vencimiento"
        '
        'fwiFechaRemesa
        '
        Me.fwiFechaRemesa.Location = New System.Drawing.Point(164, 54)
        Me.fwiFechaRemesa.Name = "fwiFechaRemesa"
        Me.fwiFechaRemesa.Size = New System.Drawing.Size(104, 19)
        Me.fwiFechaRemesa.TabIndex = 5
        Me.fwiFechaRemesa.Text = "Fecha Remesa"
        '
        'frmLiquidacionRemesa
        '
        Me.AcceptButton = Me.cmbAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.cmbCancelar
        Me.ClientSize = New System.Drawing.Size(306, 223)
        Me.Controls.Add(Me.FraFechaAsiento)
        Me.Controls.Add(Me.fwiAgruparBanco)
        Me.Controls.Add(Me.cmbCancelar)
        Me.Controls.Add(Me.cmbAceptar)
        Me.Controls.Add(Me.lblfwiDescApunte)
        Me.Controls.Add(Me.lblfwiSituacion)
        Me.Controls.Add(Me.fwiDescApunte)
        Me.Controls.Add(Me.lblcfwiSituacion)
        Me.Controls.Add(Me.fwiSituacion)
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLiquidacionRemesa"
        Me.Text = "Contabilización"
        CType(Me.fwiSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraFechaAsiento.ResumeLayout(False)
        Me.FraFechaAsiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Propiedades "

    Private mlngSituacion As Long
    Public ReadOnly Property Situacion() As Long
        Get
            Return mlngSituacion
        End Get
    End Property

    Private mstrDescripcion As String
    Public ReadOnly Property Descripcion() As String
        Get
            Return mstrDescripcion
        End Get
    End Property

    Private mdtFechaApunte As Date
    Public ReadOnly Property FechaApunte() As Date
        Get
            Return mdtFechaApunte
        End Get
    End Property

    Private mblnEnFechaVto As Boolean
    Public ReadOnly Property EnFechaVto() As Boolean
        Get
            Return mblnEnFechaVto
        End Get
    End Property

    Private mblnEnFechaRemesa As Boolean
    Public ReadOnly Property EnFechaRemesa() As Boolean
        Get
            Return mblnEnFechaRemesa
        End Get
    End Property

#End Region

    Private mblnContabilidad As Boolean

#Region " Carga del formulario "

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            fwiSituacion.Text = enumCobroSituacion.Cobrado

            fwiFechaVencimiento.Checked = True
            mblnContabilidad = New Parametro().Contabilidad
            Me.lblfwiDescApunte.Visible = mblnContabilidad
            Me.fwiDescApunte.Visible = mblnContabilidad
            Me.FraFechaAsiento.Visible = mblnContabilidad
            Me.fwiAgruparBanco.Visible = mblnContabilidad
            If Not mblnContabilidad Then
                Me.Text = "Liquidacíón de Remesa"
                Me.Height = (Me.fwiSituacion.Top + Me.fwiSituacion.Height + Me.cmbAceptar.Height + 50)
            End If
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        End If
    End Sub

#End Region

#Region " Validaciones y operaciones con controles del formulario "

    Private Sub fwiSituacion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiSituacion.TextChanged
        lngNuevaSituacion = fwiSituacion.Text
    End Sub

    Private Sub fwiFechaVencimiento_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not fwiFechaVencimiento.Checked Then

            Me.fwiFechaApunte.Value = DBNull.Value
        End If
    End Sub

    Private Sub fwiFechaRemesa_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not fwiFechaRemesa.Checked Then
            Me.fwiFechaApunte.Value = DBNull.Value
        End If
    End Sub

    Private Sub fwiFechaApunte_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        If Engine.Length(fwiFechaApunte.Value) > 0 Then
            fwiFechaRemesa.Checked = False
            fwiFechaVencimiento.Checked = False
        End If
    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        intAccion = enumAccion.Cancelar
        Me.Close()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If Engine.Length(fwiSituacion.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe introducir el nuevo estado del cobro.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.fwiSituacion.Focus()
            intAccion = enumAccion.Cancelar
            Exit Sub
        End If

        If Engine.Length(fwiFechaApunte.Value) = 0 AndAlso Not fwiFechaVencimiento.Checked AndAlso Not fwiFechaRemesa.Checked Then
            ExpertisApp.GenerateMessage("Debe introducir una fecha para la fecha de asiento o indicar que la fecha de asiento sea la fecha de vencimiento o la fecha de la remesa.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.fwiFechaApunte.Focus()
            intAccion = enumAccion.Cancelar
            Exit Sub
        ElseIf Engine.Length(fwiFechaApunte.Value) > 0 Then
            mdtFechaApunte = fwiFechaApunte.Value
            mblnEnFechaVto = False
            mblnEnFechaRemesa = False
        Else
            If fwiFechaVencimiento.Checked Then
                mdtFechaApunte = Date.MinValue
                mblnEnFechaVto = True
                mblnEnFechaRemesa = False
            Else
                mdtFechaApunte = Date.MinValue
                mblnEnFechaVto = False
                mblnEnFechaRemesa = True
            End If
        End If

        mblnAgruparBancoLiquidacion = fwiAgruparBanco.Checked  '''

        mlngSituacion = fwiSituacion.Value
        mstrDescripcion = fwiDescApunte.Text
        intAccion = enumAccion.CambioSituacionAutomatica

        Me.Close()
    End Sub

#End Region

End Class
