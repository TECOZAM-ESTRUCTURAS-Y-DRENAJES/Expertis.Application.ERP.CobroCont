Public Class frmCancelarAnticipo

#Region " Propiedades "


    Public ReadOnly Property ContabilizarCobros() As Boolean
        Get
            Return Me.chkContabilizarCobros.Checked
        End Get
    End Property


    'Private mintSituacion As Integer
    'Private mintSituacion As Integer
    Public ReadOnly Property Situacion() As Integer
        Get
            Return cboSituacion.Value
        End Get
    End Property


    Private mIDBancoPropio As String
    Public Property IDBancoPropio() As String
        Get
            Return cboBancoPropio.Value
        End Get
        Set(ByVal value As String)
            mIDBancoPropio = value
        End Set
    End Property

    'Private mstrDescripcion As String
    'Public ReadOnly Property Descripcion() As String
    '    Get
    '        Return mstrDescripcion
    '    End Get
    'End Property

    'Private mdtFechaApunte As Date
    'Public ReadOnly Property FechaApunte() As Date
    '    Get
    '        Return mdtFechaApunte
    '    End Get
    'End Property

    'Private mdtFechaCancelacion As Date
    Public ReadOnly Property FechaCancelacion() As Date
        Get
            Return Nz(Me.cbxFechaCancelacion.Value, cnMinDate)
        End Get
    End Property


    Public ReadOnly Property RefCancelacion() As String
        Get
            Return txtRefCancelacion.Text & String.Empty
        End Get
    End Property


    Public ReadOnly Property DescApunteAnticipo() As String
        Get
            Return Me.txtDescApunteAnticipo.Text
        End Get
    End Property

    Public ReadOnly Property DescApunteCobros() As String
        Get
            Return Me.txtDescApunte.Text
        End Get
    End Property

    Public ReadOnly Property AgruparPorBanco() As Boolean
        Get
            Return chkAgruparBanco.Checked
        End Get
    End Property

    Public ReadOnly Property ContabilizarGastosAsociados() As Boolean
        Get
            Return Me.chkGenerarAsientoConGastos.Checked
        End Get
    End Property

#End Region

    Private mblnContabilidad As Boolean
    Private mblnLoading As Boolean

#Region " Carga del formulario "

    Private Sub frmCancelarAnticipo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            mblnLoading = True

            SettingForm()
            LoadERPData()
            mblnLoading = False
        End If
    End Sub

    Private Sub SettingForm()
        mblnContabilidad = New Parametro().Contabilidad
        Me.lblDescApunteAnticipo.Visible = mblnContabilidad
        Me.txtDescApunteAnticipo.Visible = mblnContabilidad
        Me.chkAgruparBanco.Visible = mblnContabilidad
        Me.FraContabilizarCobros.Visible = mblnContabilidad
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

    Private Sub LoadERPData()
        Dim f As New Filter(FilterUnionOperator.Or)
        f.Add(New NumberFilterItem("IDEstado", enumCobroSituacion.Anticipado))
        f.Add(New NumberFilterItem("IDEstado", enumCobroSituacion.NoNegociado))
        f.Add(New NumberFilterItem("IDEstado", enumCobroSituacion.Cobrado))

        CType(cboSituacion.DataSource, DataView).RowFilter = f.Compose(New AdoFilterComposer)
        'cboSituacion.Value = enumCobroSituacion.Cobrado
        cboBancoPropio.Value = mIDBancoPropio
        cboBancoPropio_Validated(cboBancoPropio, Nothing)
    End Sub

#End Region


    Private Sub chkGenerarAsientoConGastos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenerarAsientoConGastos.CheckedChanged
        If Not mblnLoading And Me.chkGenerarAsientoConGastos.Checked Then
            Me.chkContabilizarCobros.Checked = Not Me.chkGenerarAsientoConGastos.Checked
            If Length(cboBancoPropio.Value) = 0 Then cboBancoPropio.Value = mIDBancoPropio
        End If
    End Sub

    Private Sub chkContabilizarCobros_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkContabilizarCobros.CheckedChanged
        If Not mblnLoading AndAlso Me.chkContabilizarCobros.Checked Then
            Me.chkGenerarAsientoConGastos.Checked = Not Me.chkContabilizarCobros.Checked
            If Length(cboBancoPropio.Value) = 0 Then cboBancoPropio.Value = mIDBancoPropio
        End If
        If Not mblnLoading AndAlso Not Me.chkContabilizarCobros.Checked AndAlso Not Me.chkGenerarAsientoConGastos.Checked Then
            Me.cboBancoPropio.Value = String.Empty
        End If
    End Sub


#Region " Aceptar/Cancelar "


    Private Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        Me.Close()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If Length(cboSituacion.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe introducir un Estado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cboSituacion.Focus()
            Me.DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        End If

        If (Me.chkContabilizarCobros.Checked OrElse Me.chkGenerarAsientoConGastos.Checked) AndAlso Length(cboBancoPropio.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe introducir un Banco Propio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cboBancoPropio.Focus()
            Me.DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        End If

        If Length(cbxFechaCancelacion.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe introducir una fecha de cancelación.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbxFechaCancelacion.Focus()
            Me.DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

#End Region

    Private Sub cboSituacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSituacion.ValueChanged
        If Me.cboSituacion.Value <> enumCobroSituacion.Cobrado Then
            Me.chkContabilizarCobros.Checked = False
            Me.chkGenerarAsientoConGastos.Checked = False
            Me.chkAgruparBanco.Checked = False
            Me.txtDescApunte.Text = String.Empty
            Me.FraContabilizarCobros.Enabled = False
        Else
            Me.FraContabilizarCobros.Enabled = True
        End If
    End Sub

    Private Sub cboBancoPropio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBancoPropio.Validated
        If Length(cboBancoPropio.Value) > 0 AndAlso Not cboBancoPropio.DataSource Is Nothing Then
            Dim dv As DataView = CType(cboBancoPropio.DataSource, DataView)
            Dim Filter As String = dv.RowFilter
            dv.RowFilter = "IDBancoPropio = " & Quoted(cboBancoPropio.Value)
            ' Dim BP As List(Of Object) = (From c In CType(cboBancoPropio.DataSource, DataView) Where Not c.isnull("IDBancoPropio") AndAlso c("IDBancoPropio") = cboBancoPropio.Value Select c).ToList
            If dv.Count > 0 Then
                Me.ulblcboBancoPropio.Text = dv(0)("DescBancoPropio") & String.Empty
            End If

            dv.RowFilter = Filter

        End If
    End Sub

End Class