Imports Janus.Windows.GridEX
Public Class FrmCambioSituacion
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.Grid.RelationMode = RelationMode.NoRelation
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
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblFwIFPagoNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaCobro As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaCobro As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CbxNuevaSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim CbxNuevaSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCambioSituacion))
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxFechaCobro = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaCobro = New Solmicro.Expertis.Engine.UI.Label
        Me.CbxNuevaSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFwIFPagoNew = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.CbxNuevaSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbxFechaCobro)
        Me.Panel1.Controls.Add(Me.lblFechaCobro)
        Me.Panel1.Controls.Add(Me.CbxNuevaSituacion)
        Me.Panel1.Controls.Add(Me.lblFwIFPagoNew)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 248)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 40)
        Me.Panel1.TabIndex = 4
        '
        'cbxFechaCobro
        '
        Me.cbxFechaCobro.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaCobro.Location = New System.Drawing.Point(356, 10)
        Me.cbxFechaCobro.Name = "cbxFechaCobro"
        Me.cbxFechaCobro.Size = New System.Drawing.Size(104, 21)
        Me.cbxFechaCobro.TabIndex = 33
        '
        'lblFechaCobro
        '
        Me.lblFechaCobro.Location = New System.Drawing.Point(275, 10)
        Me.lblFechaCobro.Name = "lblFechaCobro"
        Me.lblFechaCobro.Size = New System.Drawing.Size(79, 13)
        Me.lblFechaCobro.TabIndex = 32
        Me.lblFechaCobro.Text = "Fecha Cobro"
        '
        'CbxNuevaSituacion
        '
        CbxNuevaSituacion_DesignTimeLayout.LayoutString = resources.GetString("CbxNuevaSituacion_DesignTimeLayout.LayoutString")
        Me.CbxNuevaSituacion.DesignTimeLayout = CbxNuevaSituacion_DesignTimeLayout
        Me.CbxNuevaSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.CbxNuevaSituacion.DisplayMember = "DescEstado"
        Me.CbxNuevaSituacion.Location = New System.Drawing.Point(153, 10)
        Me.CbxNuevaSituacion.Name = "CbxNuevaSituacion"
        Me.CbxNuevaSituacion.SelectedIndex = -1
        Me.CbxNuevaSituacion.SelectedItem = Nothing
        Me.CbxNuevaSituacion.Size = New System.Drawing.Size(112, 21)
        Me.CbxNuevaSituacion.TabIndex = 29
        Me.CbxNuevaSituacion.ValueMember = "IDEstado"
        '
        'lblFwIFPagoNew
        '
        Me.lblFwIFPagoNew.Location = New System.Drawing.Point(9, 10)
        Me.lblFwIFPagoNew.Name = "lblFwIFPagoNew"
        Me.lblFwIFPagoNew.Size = New System.Drawing.Size(138, 13)
        Me.lblFwIFPagoNew.TabIndex = 28
        Me.lblFwIFPagoNew.Text = "Nueva Situación Cobro"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(596, 6)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(90, 28)
        Me.cmbCancelar.TabIndex = 8
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(500, 6)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(90, 28)
        Me.cmbAceptar.TabIndex = 7
        Me.cmbAceptar.Text = "Aceptar"
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = Nothing
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageSource = Janus.Windows.GridEX.ImageSource.InternalImageList
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(697, 248)
        Me.Grid.TabIndex = 5
        Me.Grid.Tag = ""
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = Nothing
        '
        'FrmCambioSituacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(697, 288)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCambioSituacion"
        Me.Text = "Cambio Situación Cobros"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CbxNuevaSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mblnContabilidad As Boolean
    Private mblnContabilizar As Boolean
    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    Public ReadOnly Property BlnContabilizar() As Boolean
        Get
            Return mblnContabilizar
        End Get
    End Property

    Public Function AbrirCambioSituacion(ByVal dtCobros As DataTable, ByVal OwnerForm As FormBase) As System.Windows.Forms.DialogResult

        mblnContabilidad = New ParametroContabilidad().Contabilidad

        With Grid
            .EntityName = "Cobro"
            .ViewName = "tbCobro"

            Dim f As New Filter
            f.Add(New NumberFilterItem("IDEstado", FilterOperator.NotEqual, enumCobroSituacion.Negociado))
            f.Add(New NumberFilterItem("IDEstado", FilterOperator.NotEqual, enumCobroSituacion.Descontado))
            f.Add(New NumberFilterItem("IDEstado", FilterOperator.NotEqual, enumCobroSituacion.GeneradoPago))

            Dim dt As DataTable = New EstadoCobro().Filter(f, "Abreviatura")

            .Columns("AbrvSituacion").DropDown.SetDataBinding(dt, String.Empty)

            CbxNuevaSituacion.DataSource = dt

            f.Clear()
            f.UnionOperator = FilterUnionOperator.Or
            For Each dr As DataRowView In dtCobros.DefaultView
                f.Add(New NumberFilterItem("IDCobro", FilterOperator.Equal, dr("IDCobro")))
            Next
            If f.Count = 0 Then f.Add(New NoRowsFilterItem)
            .Filter = f

            Return Me.ShowDialog(OwnerForm)
        End With
    End Function

    Private Sub txtNuevaSituacion_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs)
        e.Filter.Add(New NumberFilterItem("IDEstado", FilterOperator.NotEqual, enumCobroSituacion.Negociado))
        e.Filter.Add(New NumberFilterItem("IDEstado", FilterOperator.NotEqual, enumCobroSituacion.Descontado))
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If e.Row.Cells("Contabilizado").Value Then
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.Contabilizado
            Else
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.NoContabilizado
            End If
        End If
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Dim dt As DataTable = Grid.DataSource
        Dim datosCambio As New Cobro.DataCambioSituacionManual
        datosCambio.Cobros = Grid.DataSource
        If Length(CbxNuevaSituacion.Value) > 0 Then datosCambio.NuevaSituacion = CInt(CbxNuevaSituacion.Value)
        If Length(cbxFechaCobro.Value) > 0 Then datosCambio.NuevaFechaCobro = cbxFechaCobro.Value
        Dim Errores As ClassErrors() = ExpertisApp.ExecuteTask(Of Cobro.DataCambioSituacionManual, ClassErrors())(AddressOf Cobro.CambioSituacionManual, datosCambio)

        If Not Errores Is Nothing AndAlso Errores.Length > 0 Then
            Dim strExisteCNC As String = String.Empty
            Dim strExisteCNCR As String = String.Empty
            For i As Integer = 0 To Errores.Length - 1
                If Errores(i).MessageError = CStr(Cobro.enumResultadoCambioCobros.CobradoNoContabilizado) Then
                    If Len(strExisteCNC) > 0 Then strExisteCNC = strExisteCNC & ","
                    Dim DrEr() As DataRow = dt.Select("IDCobro = " & CInt(Errores(i).Elements))
                    If DrEr.Length > 0 Then
                        If Len(strExisteCNC) > 0 Then strExisteCNC = strExisteCNC & ","
                        strExisteCNC = strExisteCNC & DrEr(0)("NFactura")
                    End If
                    'strExisteCNC = strExisteCNC & Errores("IDCobro" & i)
                Else
                    If Len(strExisteCNCR) > 0 Then strExisteCNCR = strExisteCNCR & ","
                    Dim DrEr() As DataRow = dt.Select("IDCobro = " & CInt(Errores(i).Elements))
                    If DrEr.Length > 0 Then
                        If Len(strExisteCNC) > 0 Then strExisteCNC = strExisteCNC & ","
                        strExisteCNC = strExisteCNC & DrEr(0)("NFactura")
                    End If
                    'strExisteCNCR = strExisteCNCR & Errores("IDCobro" & i)
                End If
            Next

            If mblnContabilidad Then
                If Len(strExisteCNC) > 0 Then
                    If ExpertisApp.GenerateMessage("Los Cobros de las Facturas:{0} están Cobrados y No Contabilizados.{1} ¿Desea contabilizarlos?", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, Quoted(strExisteCNC), vbNewLine) = DialogResult.Yes Then

                        mblnContabilizar = True
                    End If
                End If
                If Len(strExisteCNCR) > 0 Then
                    If Len(strExisteCNC) > 0 Then
                        If ExpertisApp.GenerateMessage("Los Cobros de las Facturas:{0} están Cobrados y No Contabilizados. ¿Desea contabilizarlos?{1}Los Cobros {2} están Cobrados, No Contabilizado y son remesables. ¿Desea contabilizarlos?", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, Quoted(strExisteCNC), vbNewLine, Quoted(strExisteCNCR)) = DialogResult.Yes Then

                            mblnContabilizar = True
                        End If
                    Else
                        If ExpertisApp.GenerateMessage("Los Cobros de las Facturas:{0} están Cobrados, No Contabilizado y son remesables. ¿Desea contabilizarlos?", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, strExisteCNCR) = DialogResult.Yes Then

                            mblnContabilizar = True
                        End If
                    End If
                End If
            End If
        End If
        If mblnContabilizar Then
            Me.DialogResult = DialogResult.OK
        Else : Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub CbxNuevaSituacion_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxNuevaSituacion.Validated
        If Length(Me.CbxNuevaSituacion.Value) > 0 AndAlso Me.CbxNuevaSituacion.Value = enumCobroSituacion.Cobrado Then
            Me.lblFechaCobro.Visible = True
            Me.cbxFechaCobro.Visible = True
        Else
            Me.lblFechaCobro.Visible = False
            Me.cbxFechaCobro.Visible = False
        End If
    End Sub

    Private Sub FrmCambioSituacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CbxNuevaSituacion_Validated(Nothing, Nothing)
    End Sub
End Class
