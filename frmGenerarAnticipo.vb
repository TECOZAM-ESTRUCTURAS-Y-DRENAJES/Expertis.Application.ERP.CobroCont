Public Class frmGenerarAnticipo

#Region " Variables globales y Propiedades "

    Private mblnEspecial As Boolean
    Private mblnModificacion As Boolean
    Private mIDRemesa As Integer
    Private mblnContabilidad As Boolean

    Public Property Modificacion() As Boolean
        Get
            Return mblnModificacion
        End Get
        Set(ByVal value As Boolean)
            mblnModificacion = value
        End Set
    End Property

    ReadOnly Property GenerarAsientoAnticipo() As Boolean
        Get
            Return chkGenAsientos.Checked
        End Get
    End Property

    ReadOnly Property Imprimir() As Boolean
        Get
            Return chkImprimir.Checked
        End Get
    End Property

    Public ReadOnly Property FechaAbono() As Date
        Get
            Return Nz(cbxFechaCargoAnticipo.Value, cnMinDate)
        End Get

    End Property

    Public ReadOnly Property ReferenciaAbono() As String
        Get
            Return txtRefAbonoAnticipo.Text
        End Get

    End Property

    Public ReadOnly Property TextoAsientoAnticipo() As String
        Get
            Return txtTextoAsiento.Text
        End Get

    End Property

    ReadOnly Property TipoNegociacion() As enumTipoRemesa
        Get
            Return enumTipoRemesa.RemesaAnticipo
        End Get
    End Property

    Public ReadOnly Property Ejercicio() As String
        Get
            Return cboEjercicio.Value
        End Get
    End Property

    Public ReadOnly Property BancoPropio() As String
        Get
            Return cboBancoPropio.Value
        End Get
    End Property

    Public Property IDAnticipo() As Integer
        Get
            Return CInt(txtIDAnticipo.Text)
        End Get
        Set(ByVal value As Integer)
            mIDRemesa = value
            txtIDAnticipo.Text = value
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


#End Region


#Region " Carga del formulario "


    Public Function AbrirRemesaAnticipo(Optional ByVal blnModificacion As Boolean = True, _
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
        Me.cboEjercicio.Filter = FilEjer

        Me.ShowDialog()

        Return Me.DialogResult
    End Function

    Private Sub SettingGastoAnticipo(ByVal mdtCobros As DataTable, ByVal mIDRemesa As Integer)
        FraGastosAnticipo.Visible = True
        pnlGastosTop.Enabled = True
        chkCrearFacturaGastos.Enabled = True
        chkGenerarAsientoConGastos.Visible = True
        Dim dtGastosEnCobros As DataTable

        ' If Not blnModificacion Then 'Si se va a crear una remesa nueva dtCobros que contiene los cobros que se veran en el informe
        If Not mdtCobros Is Nothing AndAlso mdtCobros.Rows.Count > 0 Then
            Dim IDCobros() As Object = (From c In mdtCobros Select c("IDCobro") Distinct).ToArray
            If IDCobros.Length > 0 Then
                dtGastosEnCobros = New CobroFacturaCompra().Filter(New InListFilterItem("IDCobro", IDCobros, FilterType.Numeric), Nothing, "TOP 1 *")
                If dtGastosEnCobros.Rows.Count > 0 Then
                    chkCrearFacturaGastos.Checked = False
                    FraGastosAnticipo.Visible = False
                End If
            End If
        End If
        'End If

        If dtGastosEnCobros Is Nothing OrElse dtGastosEnCobros.Rows.Count = 0 Then
            FraGastosAnticipo.Visible = True
            If mIDRemesa > 0 Then
                Dim dtGastosEnAnticipo As DataTable = New BE.DataEngine().Filter("vfrmAnticipoFacturaCompra", New NumberFilterItem("IDRemesa", mIDRemesa), "TOP 1 *")
                If dtGastosEnAnticipo.Rows.Count > 0 Then
                    chkCrearFacturaGastos.Checked = False
                    chkCrearFacturaGastos.Enabled = False
                    GridGastosAnticipo.Enabled = False
                    pnlGastosTop.Enabled = False

                    If Nz(dtGastosEnAnticipo.Rows(0)("IncluirEnAsientoAnticipo"), False) Then
                        Me.txtFacturaGasto.Text = dtGastosEnAnticipo.Rows(0)("NFactura")
                    End If
                End If
            End If

        End If

        If FraGastosAnticipo.Visible Then
            Me.chkGenerarAsientoConGastos.Checked = False
            Me.chkGenerarAsientoConGastos.Visible = False

            Me.GridGastosAnticipo.DataSource = CrearDtGastosAnticipo()
            Me.AdvIDContador.Value = LoadContadorPorDefecto()
        Else
            Me.Height = Me.Height - Me.FraGastosAnticipo.Height
        End If
    End Sub

    Private mblnLoading As Boolean
    Private Sub frmGenerarAnticipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then

            mblnLoading = True
            'Comprobamos si se va a crear una remesa nueva o modificar una que ya existe
            Dim p As New Parametro
            mblnContabilidad = p.Contabilidad
            Me.chkGenAsientos.Visible = mblnContabilidad
            Me.chkGenAsientos.Checked = mblnContabilidad
            Me.FraContabilizacion.Visible = mblnContabilidad
            SettingGastoAnticipo(mdtCobros, mIDRemesa)

            If Not mblnModificacion Then 'Si se va a crear una remesa nueva
                chkGenAsientos.Checked = p.GenerarAsientoCobro()

                mIDRemesa = ExpertisApp.ExecuteTask(Of String, Integer)(AddressOf Cobro.NuevoIdRemesaAnticipo, Nothing)

                txtIDAnticipo.Text = IIf(mIDRemesa = -1, String.Empty, mIDRemesa)

            Else    ' Si se va a modificar una remesa
                'fwiSufijo.Enabled = False
                cboBancoPropio.Enabled = False
                'Recuperamos los datos de la remesa
                Dim dtRemesa As DataTable = New Remesa().SelOnPrimaryKey(mIDRemesa)
                If Not IsNothing(dtRemesa) AndAlso dtRemesa.Rows.Count > 0 Then
                    txtIDAnticipo.Text = dtRemesa.Rows(0)("IDRemesa")
                    txtIDAnticipo.Enabled = False
                    cboBancoPropio.Value = dtRemesa.Rows(0)("IdBancopropio")
                    cboBancoPropio.Enabled = False
                    cbxFechaAnticipo.Value = dtRemesa.Rows(0)("FechaNegociacion")
                    cbxFechaAnticipo.Enabled = False

                    'cbxFechaCancPrev.Value = dtRemesa.Rows(0)("FechaCancelacionPrev")
                    nbxTipoInteresInicial.Value = dtRemesa.Rows(0)("TipoInteresInicial")

                    Dim dtBPropio As DataTable = New BancoPropio().SelOnPrimaryKey(dtRemesa.Rows(0)("IdBancopropio"))
                    'If Not IsNothing(dtBPropio) AndAlso dtBPropio.Rows.Count > 0 Then
                    '    txtSufijo.Text = dtBPropio.Rows(0)("Sufijoremesas") & String.Empty
                    'End If
                    If Length(dtRemesa.Rows(0)("FechaCargo")) > 0 Then
                        cbxFechaCargoAnticipo.Value = dtRemesa.Rows(0)("FechaCargo")
                    End If

                End If

                'Cargamos en un dt los cobros que se verán en el informe
                mdtCobros = New DataEngine().Filter("frmCobros", New NumberFilterItem("IDRemesa", mIDRemesa))
            End If
            mblnLoading = False
        End If
    End Sub

#End Region


#Region " Validaciones controles formulario "

    Private Sub fwiEjercicio_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEjercicio.DropDown
        Dim f As New Filter
        f.Add("AIva", FilterOperator.NotEqual, mblnEspecial)
        CType(cboEjercicio.DataSource, DataView).RowFilter = String.Empty
        CType(cboEjercicio.DataSource, DataView).RowFilter = f.Compose(New AdoFilterComposer)
    End Sub

    Private Sub cboBancoPropio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBancoPropio.ValueChanged
        '// Se carga el SufijoRemesas del Banco Propio seleccionado.
        If Not IsNothing(cboBancoPropio.SelectedItem) Then
            txtProveedor.Text = Nz(cboBancoPropio.SelectedItem("IDProveedor"), String.Empty)
        Else
            txtProveedor.Text = String.Empty
        End If
    End Sub

    Private Sub cboBancoPropio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboBancoPropio.Validating
        'Se comprueba que el banco existe.
        e.Cancel = False

        If Length(cboBancoPropio.Value) > 0 Then
            Dim objNegBP As New BancoPropio
            Dim dtBP As DataTable = objNegBP.SelOnPrimaryKey(cboBancoPropio.Value)
            If IsNothing(dtBP) OrElse dtBP.Rows.Count = 0 Then
                ExpertisApp.GenerateMessage("El Banco Propio no existe.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
            End If
        End If
    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        Dim p As New Parametro
        Dim intSituacion As Integer = enumCobroSituacion.Anticipado

        If ComprobarObligatorios() Then
            If chkGenAsientos.Checked Then
                If Length(cboEjercicio.Value) = 0 Then
                    ExpertisApp.GenerateMessage("Debe introducir un Ejercicio Contable.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.cboEjercicio.Focus()
                    Exit Sub
                ElseIf Length(cbxFechaCargoAnticipo.Value) = 0 Then
                    ExpertisApp.GenerateMessage("Debe introducir una Fecha de Abono.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.cbxFechaCargoAnticipo.Focus()
                    Exit Sub
                ElseIf Length(cboBancoPropio.Value) = 0 Then
                    ExpertisApp.GenerateMessage("El Banco Propio es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.cboBancoPropio.Focus()
                    Exit Sub
                End If

                Dim dtDesde, dtHasta As Date
                Dim dtEjercicio As DataTable = New EjercicioContable().SelOnPrimaryKey(cboEjercicio.Value)
                If Not IsNothing(dtEjercicio) AndAlso dtEjercicio.Rows.Count > 0 Then
                    dtDesde = dtEjercicio.Rows(0)("FechaDesde")
                    dtHasta = dtEjercicio.Rows(0)("FechaHasta")
                Else
                    ExpertisApp.GenerateMessage("Debe introducir un Ejercicio Contable correcto.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.cboEjercicio.Focus()
                    Exit Sub
                End If

                If Me.cbxFechaCargoAnticipo.Value < dtDesde OrElse Me.cbxFechaCargoAnticipo.Value > dtHasta Then
                    ExpertisApp.GenerateMessage("La Fecha de Abono introducida no pertenece al Ejercicio Seleccionado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Me.Cursor = Cursors.WaitCursor
            End If


            'Si se esta generando una remesa nueva
            Dim dtRemesa As DataTable
            Dim blnInsertado As Boolean
            If Not mblnModificacion OrElse (mIDRemesa <> 0 AndAlso mblnModificacion) Then
                If Not mblnModificacion Then mIDRemesa = 0
                Dim objNegCobro As New Cobro
                'Insertamos la remesa y actualizamos los cobros remesados
                Dim ur As New Cobro.DataUpdateRemesa
                ur.IDBancoPropio = cboBancoPropio.Value
                ur.TipoNegociacion = enumTipoRemesa.RemesaAnticipo
                ur.FechaEmision = cbxFechaAnticipo.Value
                ur.Cobros = mdtCobros
                ur.Situacion = intSituacion
                ur.IDRemesa = mIDRemesa

                If Length(cbxFechaCancPrev.Value) > 0 Then ur.FechaCancelacionAnticipoPrev = cbxFechaCancPrev.Value
                ur.TipoInteresInicial = Me.nbxTipoInteresInicial.Value

                dtRemesa = ExpertisApp.ExecuteTask(Of Cobro.DataUpdateRemesa, DataTable)(AddressOf Cobro.UpdateRemesa, ur)

                blnInsertado = True
            End If

            Dim intIDRemesa As Integer = txtIDAnticipo.Text
            If Not dtRemesa Is Nothing AndAlso dtRemesa.Rows.Count > 0 Then
                intIDRemesa = dtRemesa.Rows(0)("IDRemesa")
            End If

            If Me.chkCrearFacturaGastos.Checked AndAlso GridGastosAnticipo.RowCount > 0 Then
                Dim data As New DataPrcFacturacionNuevoGasto
                data.IDContador = AdvIDContador.Value
                data.FechaFactura = cbxFechaAnticipo.Value
                data.IDProveedor = txtProveedor.Text
                Dim dtProveedor As DataTable = New Proveedor().SelOnPrimaryKey(data.IDProveedor)
                If dtProveedor.Rows.Count > 0 Then
                    data.RazonSocial = dtProveedor.Rows(0)("RazonSocial") & String.Empty
                    data.CIF = dtProveedor.Rows(0)("CifProveedor") & String.Empty
                    data.IDMoneda = dtProveedor.Rows(0)("IDMoneda") & String.Empty
                    data.IDDiaPago = dtProveedor.Rows(0)("IDDiaPago") & String.Empty
                    data.IDFormaPago = dtProveedor.Rows(0)("IDFormaPago") & String.Empty
                    data.IDCondicionPago = dtProveedor.Rows(0)("IDCondicionPago") & String.Empty
                End If

                data.IDBancoPropio = cboBancoPropio.Value
                data.IDTipoAsiento = enumTipoAsiento.taBancoSinPago

                For Each drLinea As DataRow In CType(GridGastosAnticipo.DataSource, DataTable).AsEnumerable
                    Dim lin As New DataPrcFacturacionLineaNuevoGasto
                    lin.IDArticulo = drLinea("IDArticulo") & String.Empty
                    lin.DescArticulo = drLinea("DescArticulo") & String.Empty

                    lin.IDCContable = drLinea("IDCContable") & String.Empty
                    lin.IDTipoIVA = drLinea("IDTipoIVA") & String.Empty
                    lin.Importe = Nz(drLinea("Importe"), 0)
                    If Nz(drLinea("IDObra"), 0) > 0 Then lin.IDObra = Nz(drLinea("IDObra"), 0)
                    'If Length(AdvTrabajo.Value) > 0 Then lin.IDTrabajo = AdvTrabajo.Value
                    'lin.Analitica = mdtAnalitica
                    data.Lineas.Add(lin)
                Next

                Dim Fra As CreateElement = New BE.DataEngine().RunProcess(GetType(PrcFacturacionNuevoGasto), data)
                If Not e Is Nothing AndAlso Fra.IDElement > 0 Then
                    Dim RCFC As New RemesaCobroFacturaCompra
                    Dim dtRCFC As DataTable = RCFC.AddNewForm
                    dtRCFC.Rows(0)("IDRemesa") = intIDRemesa
                    dtRCFC.Rows(0)("IDFacturaCompra") = Fra.IDElement
                    dtRCFC.Rows(0)("IncluirEnAsientoAnticipo") = True
                    RCFC.Update(dtRCFC)
                Else
                    Dim strMessage As String = ExpertisApp.Traslate("No se ha podido crear la Factura de Gasto.")
                    If Me.chkGenAsientos.Checked Then strMessage &= ExpertisApp.Traslate(" Por lo que no se realizará el Abono del Anticipo.")

                    ExpertisApp.GenerateMessage(strMessage, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.chkGenAsientos.Checked = False
                    Exit Sub
                End If
            End If

            If chkImprimir.Checked Then
                Dim fCobros As New Filter(FilterUnionOperator.Or)
                Dim dtCobros As DataTable = New Cobro().Filter(New NumberFilterItem("IDRemesaAnticipo", mIDRemesa))
                If dtCobros.Rows.Count > 0 Then
                    For Each drCobro As DataRow In dtCobros.Rows
                        fCobros.Add(New NumberFilterItem("IDCobro", drCobro("IDCobro")))
                    Next
                Else
                    fCobros.Add(New NoRowsFilterItem)
                End If
                Dim oRpt As New Report("ANTFV")
                oRpt.Filter.Add(fCobros)
                ExpertisApp.OpenReport(oRpt)
                Me.Close()
            Else
                Me.Close()
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub



    Private Function ComprobarObligatorios() As Boolean
        If Engine.Length(cboBancoPropio.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe indicar un Banco Propio.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboBancoPropio.Focus()
            Exit Function
        ElseIf Length(txtIDAnticipo.Text) = 0 Then
            ExpertisApp.GenerateMessage("No hay ningun contador establecido para las Remesas.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Function
        ElseIf Length(cbxFechaAnticipo.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe indicar la Fecha del Anticipo.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Function
        Else
            If Me.chkGenAsientos.Checked Then
                If Length(Me.cbxFechaCargoAnticipo.Value) = 0 Then
                    ExpertisApp.GenerateMessage("Debe indicar la Fecha de Abono.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Function
                End If
                If Length(Me.txtRefAbonoAnticipo.Text) = 0 Then
                    ExpertisApp.GenerateMessage("Debe indicar la Referencia de Abono.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Function
                End If
            End If


            If Me.chkCrearFacturaGastos.Checked Then
                If Length(Me.AdvIDContador.Value) = 0 Then
                    ExpertisApp.GenerateMessage("Debe indicar el contador para la Factura.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Function
                End If

                If Length(Me.txtProveedor.Text) = 0 Then
                    ExpertisApp.GenerateMessage("El Banco Propio seleccionado no tiene un Proveedor asociado.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Function
                End If
            End If

            ComprobarObligatorios = True
        End If

    End Function

    Private Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

#End Region

    Private Sub chkGenerarAsientoConGastos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenerarAsientoConGastos.CheckedChanged
        If Not mblnLoading AndAlso Me.chkGenerarAsientoConGastos.Checked Then
            Me.chkGenAsientos.Checked = Not Me.chkGenerarAsientoConGastos.Checked
        End If
    End Sub

    Private Sub fwiGenAsientos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGenAsientos.CheckedChanged
        If Not mblnLoading AndAlso Me.chkGenAsientos.Checked Then
            Me.chkGenerarAsientoConGastos.Checked = Not Me.chkGenAsientos.Checked
        End If
    End Sub

#Region " Gastos Incluidos en el Anticipo "

    Private Sub AdvIDContador_SetPredefinedFilter(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDContador.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("Entidad", "FacturaCompraCabecera"))
    End Sub

    Private Function CrearDtGastosAnticipo() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("IDArticulo", GetType(String))
        dt.Columns.Add("DescArticulo", GetType(String))
        dt.Columns.Add("Importe", GetType(Double))
        dt.Columns.Add("IDTipoIVA", GetType(String))
        dt.Columns.Add("IDCContable", GetType(String))
        dt.Columns.Add("IDObra", GetType(Integer))
        dt.Columns.Add("NObra", GetType(String))
        Return dt
    End Function

    Public Function LoadContadorPorDefecto() As String
        Return ExpertisApp.ExecuteTask(Of CentroGestion.ContadorEntidad, String)(AddressOf CentroGestion.GetContadorPredeterminadoCGestionUsuario, CentroGestion.ContadorEntidad.FacturaCompra)
    End Function


    Private Sub GridGastosAnticipo_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridGastosAnticipo.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "IDArticulo"
                e.Filter.Add(New BooleanFilterItem("Compra", True))
            Case "IDCContable"
                Dim IDEjercicio As String = cboEjercicio.Value & String.Empty
                If Length(IDEjercicio) = 0 AndAlso Nz(cbxFechaAnticipo.Value, cnMinDate) <> cnMinDate Then IDEjercicio = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, cbxFechaAnticipo.Value)
                e.Filter.Add(New StringFilterItem("IDEjercicio", IDEjercicio))
        End Select
    End Sub

#End Region

   
End Class