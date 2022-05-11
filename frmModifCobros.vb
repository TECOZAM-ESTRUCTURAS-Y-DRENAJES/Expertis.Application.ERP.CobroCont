
Public Class frmModifCobros
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.grid.RelationMode = RelationMode.NoRelation
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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblFwIDBancoNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFwIFPagoNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFwiFechaVtoNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiNFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiTitulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents FwIDBancoNew As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FwIFPagoNew As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FwiFechaVtoNew As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents fwiNFactura As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents fwiTitulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTexto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents grid As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifCobros))
        Dim grid_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim grid_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage")
        Dim grid_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column12.ButtonImage")
        Dim grid_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column13.ButtonImage")
        Dim grid_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column14.ButtonImage")
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtTexto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwIDBancoNew = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwIFPagoNew = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiFechaVtoNew = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiNFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiTitulo = New Solmicro.Expertis.Engine.UI.Label
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FwIDBancoNew = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FwIFPagoNew = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FwiFechaVtoNew = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.fwiNFactura = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiTitulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtTexto)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblFwIDBancoNew)
        Me.Panel1.Controls.Add(Me.lblFwIFPagoNew)
        Me.Panel1.Controls.Add(Me.lblFwiFechaVtoNew)
        Me.Panel1.Controls.Add(Me.lblfwiNFactura)
        Me.Panel1.Controls.Add(Me.lblfwiTitulo)
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Controls.Add(Me.FwIDBancoNew)
        Me.Panel1.Controls.Add(Me.FwIFPagoNew)
        Me.Panel1.Controls.Add(Me.FwiFechaVtoNew)
        Me.Panel1.Controls.Add(Me.fwiNFactura)
        Me.Panel1.Controls.Add(Me.fwiTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(658, 133)
        Me.Panel1.TabIndex = 18
        '
        'txtTexto
        '
        Me.txtTexto.DisabledBackColor = System.Drawing.Color.White
        Me.txtTexto.Location = New System.Drawing.Point(536, 80)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(104, 21)
        Me.txtTexto.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(379, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Nuevo Texto"
        '
        'lblFwIDBancoNew
        '
        Me.lblFwIDBancoNew.Location = New System.Drawing.Point(376, 31)
        Me.lblFwIDBancoNew.Name = "lblFwIDBancoNew"
        Me.lblFwIDBancoNew.Size = New System.Drawing.Size(122, 13)
        Me.lblFwIDBancoNew.TabIndex = 24
        Me.lblFwIDBancoNew.Text = "Nuevo Banco Propio"
        '
        'lblFwIFPagoNew
        '
        Me.lblFwIFPagoNew.Location = New System.Drawing.Point(376, 55)
        Me.lblFwIFPagoNew.Name = "lblFwIFPagoNew"
        Me.lblFwIFPagoNew.Size = New System.Drawing.Size(133, 13)
        Me.lblFwIFPagoNew.TabIndex = 26
        Me.lblFwIFPagoNew.Text = "Nueva Forma de Pago"
        '
        'lblFwiFechaVtoNew
        '
        Me.lblFwiFechaVtoNew.Location = New System.Drawing.Point(376, 7)
        Me.lblFwiFechaVtoNew.Name = "lblFwiFechaVtoNew"
        Me.lblFwiFechaVtoNew.Size = New System.Drawing.Size(153, 13)
        Me.lblFwiFechaVtoNew.TabIndex = 27
        Me.lblFwiFechaVtoNew.Text = "Nueva Fecha Vencimiento"
        '
        'lblfwiNFactura
        '
        Me.lblfwiNFactura.Location = New System.Drawing.Point(7, 11)
        Me.lblfwiNFactura.Name = "lblfwiNFactura"
        Me.lblfwiNFactura.Size = New System.Drawing.Size(82, 13)
        Me.lblfwiNFactura.TabIndex = 28
        Me.lblfwiNFactura.Tag = "IdRec=4763;"
        Me.lblfwiNFactura.Text = "Núm. Factura"
        '
        'lblfwiTitulo
        '
        Me.lblfwiTitulo.Location = New System.Drawing.Point(7, 36)
        Me.lblfwiTitulo.Name = "lblfwiTitulo"
        Me.lblfwiTitulo.Size = New System.Drawing.Size(38, 13)
        Me.lblfwiTitulo.TabIndex = 29
        Me.lblfwiTitulo.Tag = "IdRec=4711;"
        Me.lblfwiTitulo.Text = "Título"
        Me.lblfwiTitulo.Visible = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(191, 97)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(104, 27)
        Me.cmdCancelar.TabIndex = 20
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(79, 97)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(104, 27)
        Me.cmdAceptar.TabIndex = 19
        Me.cmdAceptar.Text = "Aceptar"
        '
        'FwIDBancoNew
        '
        Me.FwIDBancoNew.DisabledBackColor = System.Drawing.Color.White
        Me.FwIDBancoNew.EntityName = "BancoPropio"
        Me.FwIDBancoNew.Location = New System.Drawing.Point(536, 31)
        Me.FwIDBancoNew.Name = "FwIDBancoNew"
        Me.FwIDBancoNew.SecondaryDataFields = "IDBancoPropio"
        Me.FwIDBancoNew.Size = New System.Drawing.Size(104, 23)
        Me.FwIDBancoNew.TabIndex = 25
        Me.FwIDBancoNew.ViewName = "tbMaestroBancoPropio"
        '
        'FwIFPagoNew
        '
        Me.FwIFPagoNew.DisabledBackColor = System.Drawing.Color.White
        Me.FwIFPagoNew.EntityName = "FormaPago"
        Me.FwIFPagoNew.Location = New System.Drawing.Point(536, 55)
        Me.FwIFPagoNew.Name = "FwIFPagoNew"
        Me.FwIFPagoNew.SecondaryDataFields = "IDFormaPago"
        Me.FwIFPagoNew.Size = New System.Drawing.Size(104, 23)
        Me.FwIFPagoNew.TabIndex = 23
        Me.FwIFPagoNew.ViewName = "tbMaestroFormaPago"
        '
        'FwiFechaVtoNew
        '
        Me.FwiFechaVtoNew.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaVtoNew.Location = New System.Drawing.Point(536, 7)
        Me.FwiFechaVtoNew.Name = "FwiFechaVtoNew"
        Me.FwiFechaVtoNew.Size = New System.Drawing.Size(104, 21)
        Me.FwiFechaVtoNew.TabIndex = 18
        '
        'fwiNFactura
        '
        Me.fwiNFactura.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNFactura.Enabled = False
        Me.fwiNFactura.Location = New System.Drawing.Point(89, 11)
        Me.fwiNFactura.Name = "fwiNFactura"
        Me.fwiNFactura.Size = New System.Drawing.Size(89, 21)
        Me.fwiNFactura.TabIndex = 21
        '
        'fwiTitulo
        '
        Me.fwiTitulo.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTitulo.Enabled = False
        Me.fwiTitulo.Location = New System.Drawing.Point(89, 36)
        Me.fwiTitulo.Name = "fwiTitulo"
        Me.fwiTitulo.Size = New System.Drawing.Size(279, 21)
        Me.fwiTitulo.TabIndex = 22
        Me.fwiTitulo.Visible = False
        '
        'grid
        '
        Me.grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMoneda", "Moneda", "IDMoneda"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDClienteBanco", "ClienteBanco", "IDClienteBanco"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescFormaPago", "DescFormaPago")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IdDireccion", "ClienteDireccion", "IdDireccion"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBancoPropio", "BancoPropio", "IDBancoPropio"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CContable", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NFactura", "FacturaVentaCabecera", "NFactura", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDFactura", "IDFactura")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NMandato", "Mandato", "NMandato", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDMandato", "IDMandato")}))})
        Me.grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grid_DesignTimeLayout_Reference_0.Instance"), Object)
        grid_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grid_DesignTimeLayout_Reference_1.Instance"), Object)
        grid_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grid_DesignTimeLayout_Reference_2.Instance"), Object)
        grid_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grid_DesignTimeLayout_Reference_3.Instance"), Object)
        grid_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("grid_DesignTimeLayout_Reference_4.Instance"), Object)
        grid_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("grid_DesignTimeLayout_Reference_5.Instance"), Object)
        grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grid_DesignTimeLayout_Reference_0, grid_DesignTimeLayout_Reference_1, grid_DesignTimeLayout_Reference_2, grid_DesignTimeLayout_Reference_3, grid_DesignTimeLayout_Reference_4, grid_DesignTimeLayout_Reference_5})
        grid_DesignTimeLayout.LayoutString = resources.GetString("grid_DesignTimeLayout.LayoutString")
        Me.grid.DesignTimeLayout = grid_DesignTimeLayout
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grid.EntityName = Nothing
        Me.grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.grid.Location = New System.Drawing.Point(0, 0)
        Me.grid.Name = "grid"
        Me.grid.PrimaryDataFields = Nothing
        Me.grid.SecondaryDataFields = Nothing
        Me.grid.Size = New System.Drawing.Size(658, 226)
        Me.grid.TabIndex = 19
        Me.grid.Tag = "IdRec=4394:4712:4713:4715:4756:4429:4410:4696:4602:4373:4710:4765:6267:4711:4719:" & _
            "4395:4399:4766:4766:4362:5433:4725:10533:;"
        Me.grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grid.ViewName = Nothing
        '
        'frmModifCobros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(658, 359)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmModifCobros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificación de Cobros"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property


    Protected mFormasPagoSEPA As List(Of String)

    Public Function AbrirModificacionCobros(ByVal strIDProcess As String, ByVal OwnerForm As FormBase) As DialogResult
        mFormasPagoSEPA = New Parametro().FormaPagoMandatoSEPA

        With grid
            .EntityName = "Cobro"
            .ViewName = "frmCobrosNeg"

            Dim f As New Filter
            f.Add(New StringFilterItem("IdProcess", FilterOperator.Equal, strIDProcess))
            f.Add(New NumberFilterItem("Contabilizado", enumContabilizado.NoContabilizado))
            .Filter = f

            Me.ShowDialog(OwnerForm)

            Return Me.DialogResult
        End With
    End Function

    Private Sub ActualizaNuevaFechaVencimiento()

        Dim dt As DataTable = grid.DataSource
        If Not dt Is Nothing Then
            For Each dr As DataRow In dt.Rows
                If Engine.Length(FwiFechaVtoNew.Value) > 0 Then dr("FechaVencimiento") = FwiFechaVtoNew.Value
                If Engine.Length(FwIDBancoNew.Text) > 0 Then dr("IdBancopropio") = FwIDBancoNew.Text
                If Engine.Length(FwIFPagoNew.Text) > 0 Then dr("IdFormaPago") = FwIFPagoNew.Text
                If Engine.Length(txtTexto.Text) > 0 Then dr("Texto") = txtTexto.Text
                'If Engine.Length(FwiFechaCobroNew.Value) > 0 Then dr("FechaCobro") = FwiFechaCobroNew.Value
                'If Engine.Length(cbxNuevaFechaCancelacion.Value) > 0 Then dr("FechaCancelacion") = cbxNuevaFechaCancelacion.Value
            Next

            grid.DataSource = dt
        End If

    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If grid.RecordCount > 0 Then
            If Engine.Length(FwiFechaVtoNew.Value) > 0 Or Engine.Length(FwIDBancoNew.Text) > 0 Or Engine.Length(FwIFPagoNew.Text) > 0 Or Engine.Length(txtTexto.Text) > 0 Then
                ActualizaNuevaFechaVencimiento()
            End If
            If ValidarMandatosSEPA() Then
                Me.DialogResult = DialogResult.OK
                Me.UpdateData()
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Protected Overridable Function ValidarMandatosSEPA() As Boolean
        ValidarMandatosSEPA = True

        If Not mFormasPagoSEPA Is Nothing AndAlso Not grid.DataSource Is Nothing Then
            'Dim FormasPagoSEPA As List(Of String) = mFormaPagoSEPA.Split(";").ToList
            Dim FPRemesables As DataTable = New FormaPago().Filter(New FilterItem("CobroRemesable", True))
            If FPRemesables.Rows.Count > 0 AndAlso mFormasPagoSEPA.Count > 0 Then
                Dim CobrosRemesables As List(Of DataRow) = (From c In CType(grid.DataSource, DataTable) Join fp In FPRemesables On UCase(c("IDFormaPago") & String.Empty) Equals UCase(fp("IDFormaPago")) Select c).ToList
                If CobrosRemesables.Count > 0 Then
                    Dim CobrosRemesablesSinInfoSEPA As List(Of DataRow) = (From c In CobrosRemesables _
                                                                           Where (Nz(c("IDClienteBanco"), 0) = 0 OrElse Length(c("IDMandato")) = 0) AndAlso _
                                                                                 Length(c("IDFormaPago")) > 0 AndAlso mFormasPagoSEPA.Contains(UCase(c("IDFormaPago"))) _
                                                                           Select c).ToList
                    If Not CobrosRemesablesSinInfoSEPA Is Nothing AndAlso CobrosRemesablesSinInfoSEPA.Count > 0 Then
                        ValidarMandatosSEPA = False
                        ExpertisApp.GenerateMessage("Algunos cobros deben llevar la información para el Mandato SEPA. Revise sus datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        End If

    End Function

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles grid.EditingCell
        'Dim blnNoEditar As Boolean = Nz(grid.Value("Contabilizado"), enumContabilizado.NoContabilizado) <> enumContabilizado.NoContabilizado OrElse _
        '                             Nz(grid.Value("Situacion"), enumCobroSituacion.NoNegociado) <> enumCobroSituacion.NoNegociado OrElse _
        '                             Length(grid.Value("IDRemesa")) > 0

        Dim blnNoEditar As Boolean = Nz(grid.Value("Contabilizado"), enumContabilizado.NoContabilizado) <> enumContabilizado.NoContabilizado OrElse _
                                                                   Length(grid.Value("IDRemesa")) > 0

        Select Case e.Column.Key
            Case "IdMoneda", "IDFormaPago", "IDDireccion", "IDBancoPropio", "IDClienteBanco", "NFactura", "NMandato"
                If blnNoEditar Then
                    e.Cancel = True
                    e.Column.ButtonStyle = ButtonStyle.NoButton
                Else
                    e.Column.ButtonStyle = ButtonStyle.Image
                End If
            Case "CContable"
                'If blnNoEditar OrElse Length(grid.GetValue("NFactura")) > 0 Then
                If blnNoEditar Then
                    e.Cancel = True
                    e.Column.ButtonStyle = ButtonStyle.NoButton
                Else
                    e.Column.ButtonStyle = ButtonStyle.Image
                End If
            Case "ImpVencimiento", "ImpVencimientoA", "ImpVencimientoB", "ARepercutir", "ImporteRemesaAnticipo", "Titulo", "CambioA", "CambioB", "Situacion"
                If blnNoEditar Then
                    e.Cancel = True
                End If
            Case "FechaVencimiento", "FechaVencimientoFactura", "FechaANegociar", "FechaCancelacion"
                If blnNoEditar Then
                    e.Cancel = True
                End If
        End Select
    End Sub

    Private Sub grid_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid.SelectionChanged
        fwiNFactura.Text = grid.Value("NFactura") & String.Empty
        fwiTitulo.Text = grid.Value("Titulo") & String.Empty
    End Sub

    Private Sub grid_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles grid.AdvSearchSetPredefinedFilter
        With grid
            Select Case e.Key
                Case "IdClienteBanco"
                    If Engine.Length(grid.GetValue("IDCliente")) > 0 Then
                        e.Filter.Add("IDCliente", FilterOperator.Equal, .Value("IDCliente"), FilterType.String)
                    Else
                        ExpertisApp.GenerateMessage("El Cobro seleccionado no tiene un cliente configurado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Filter.Add(New IsNullFilterItem("IDCliente"))
                    End If
                Case "IDDireccion"
                    If Engine.Length(grid.GetValue("IDCliente")) > 0 Then
                        e.Filter.Add("IDCliente", FilterOperator.Equal, .Value("IDCliente"), FilterType.String)
                        e.Filter.Add("Giro", FilterOperator.Equal, True, FilterType.Boolean)
                    Else
                        ExpertisApp.GenerateMessage("El Cobro seleccionado no tiene un cliente configurado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Filter.Add(New IsNullFilterItem("IDCliente"))
                    End If
                Case "CContable"
                    e.Filter.Add("Auxiliar", FilterOperator.Equal, True, FilterType.Boolean)
                    Dim IDEjercicio As String = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, Nz(grid.Value("FechaVencimiento"), Today))
                    If Length(IDEjercicio) > 0 Then
                        e.Filter.Add(New StringFilterItem("IDEjercicio", IDEjercicio))
                    End If
                Case "NMandato"
                    If Length(grid.Value("IDCliente")) > 0 Then
                        e.Filter.Add(New StringFilterItem("IDCliente", grid.Value("IDCliente")))
                    End If
                    If Nz(grid.Value("IDClienteBanco"), 0) <> 0 Then
                        e.Filter.Add(New NumberFilterItem("IDClienteBanco", grid.Value("IDClienteBanco")))
                    End If
                    If Length(grid.Value("IDFormaPago")) = 0 OrElse Not Nz(grid.Value("CobroRemesable"), False) Then
                        e.Filter.Add(New NoRowsFilterItem)
                    End If
                    e.Filter.Add(New BooleanFilterItem("Caducado", False))
                    e.Filter.Add(New NumberFilterItem("Estado", CInt(Business.SEPA.BusinessEnum.MandatoEstado.Aceptado)))
            End Select
        End With
    End Sub


    Protected Overridable Sub HabilitarControlesCambios()
        Dim blnEnabled As Boolean = True

        If Not grid.DataSource Is Nothing Then

            'Dim VtosNoModificables As List(Of DataRow) = (From c In CType(grid.DataSource, DataTable) _
            '                                              Where (Not c.IsNull("Contabilizado") AndAlso Nz(grid.Value("Contabilizado"), enumContabilizado.NoContabilizado) <> enumContabilizado.NoContabilizado) OrElse _
            '                                                    (Not c.IsNull("Situacion") AndAlso Nz(grid.Value("Situacion"), enumCobroSituacion.NoNegociado) <> enumCobroSituacion.NoNegociado) OrElse _
            '                                                    (Not c.IsNull("IDRemesa")) _
            '                                                    Select c).ToList


            Dim VtosNoModificables As List(Of DataRow) = (From c In CType(grid.DataSource, DataTable) _
                                                          Where (Not c.IsNull("Contabilizado") AndAlso Nz(grid.Value("Contabilizado"), enumContabilizado.NoContabilizado) <> enumContabilizado.NoContabilizado) OrElse _
                                                                                                                                (Not c.IsNull("IDRemesa")) _
                                                                Select c).ToList

            blnEnabled = Not (Not VtosNoModificables Is Nothing AndAlso VtosNoModificables.Count > 0)
        End If

        'fwiNFactura.Enabled = blnEnabled
        'fwiTitulo.Enabled = blnEnabled
        FwiFechaVtoNew.Enabled = blnEnabled
        FwIDBancoNew.Enabled = blnEnabled
        FwIFPagoNew.Enabled = blnEnabled
        txtTexto.Enabled = blnEnabled
        'FwiFechaCobroNew.Enabled = blnEnabled
        'cbxNuevaFechaCancelacion.Enabled = blnEnabled
    End Sub

    Protected Overridable Sub frmModifCobros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            HabilitarControlesCambios()
        End If
    End Sub

End Class
