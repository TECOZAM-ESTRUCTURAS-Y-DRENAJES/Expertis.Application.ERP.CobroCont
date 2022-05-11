Option Compare Text

Public Class MntoCobroPeriodico
    Inherits Solmicro.Expertis.Engine.UI.GridMnto

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoCobroPeriodico))
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(465, 28)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 28)
        Me.MenuBar.Size = New System.Drawing.Size(696, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(448, 421)
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCliente", "Cliente", "IDCliente"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCContable", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoCobro", "TipoCobro", "IDTipoCobro"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBancoPropio", "BancoPropio", "IDBancoPropio"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMoneda", "Moneda", "IDMoneda"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDClienteBanco", "ClienteBanco", "IDClienteBanco"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NMandato", "Mandato", "NMandato", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDMandato", "IDMandato")}))})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "CobroPeriodico"
        Me.Grid.Size = New System.Drawing.Size(448, 421)
        Me.Grid.ViewName = "vfrmMntoCobroPeriodico"
        '
        'MntoCobroPeriodico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "CobroPeriodico"
        Me.Name = "MntoCobroPeriodico"
        Me.ViewName = "vfrmMntoCobroPeriodico"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mintDigitosAuxiliar As Integer
    Private mstrEjercicioActual As String
    Private mblnContabilidad As Boolean

#Region " Load "

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadERPSettings()
            LoadEnums()
            SettingContabilidad()
        End If
    End Sub

    Private Sub LoadERPData()
        mblnContabilidad = New Parametro().Contabilidad
    End Sub

    Private Sub LoadERPSettings()
        If mblnContabilidad Then
            mstrEjercicioActual = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, Today)
            If Length(mstrEjercicioActual) > 0 Then
                Dim dtEjercicio As DataTable = New EjercicioContable().SelOnPrimaryKey(mstrEjercicioActual)
                If Not dtEjercicio Is Nothing AndAlso dtEjercicio.Rows.Count > 0 Then
                    mintDigitosAuxiliar = Nz(dtEjercicio.Rows(0)("DigitosAuxiliar"), 0)
                End If
            End If
        End If
    End Sub

    Private Sub SettingContabilidad()
        Grid.Columns("IDCContable").Visible = mblnContabilidad
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumcpPeriodo", Grid.Columns("Unidad"))
    End Sub

#End Region

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Select Case e.Column.Key
            Case "IDCContable"
                'NOTA: Esta conversión se debe hacer aquí, el valor con el que llega al BusinessCalling es que retorna después.
                If mblnContabilidad AndAlso Engine.Length(e.Value) > 0 Then
                    e.Value = PuntoPorCero(e.Value, mintDigitosAuxiliar, mstrEjercicioActual)
                End If
        End Select
    End Sub

    Private Sub Grid_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
        With Grid
            Select Case e.Key
                Case "IDCContable"
                    If mblnContabilidad Then e.Filter.Add(New StringFilterItem("IdEjercicio", mstrEjercicioActual))
                Case "IDClienteBanco"
                    e.Filter.Add(New StringFilterItem("IDCliente", Grid.Value("IDCliente")))
                Case "NMandato"
                    If Length(Grid.Value("IDCliente")) > 0 Then
                        e.Filter.Add(New StringFilterItem("IDCliente", Grid.Value("IDCliente")))
                    End If
                    If Nz(Grid.Value("IDClienteBanco"), 0) <> 0 Then
                        e.Filter.Add(New NumberFilterItem("IDClienteBanco", Grid.Value("IDClienteBanco")))
                    End If
                    If Length(Grid.Value("IDFormaPago")) = 0 OrElse Not Nz(Grid.Value("CobroRemesable"), False) Then
                        e.Filter.Add(New NoRowsFilterItem)
                    End If
                    e.Filter.Add(New BooleanFilterItem("Caducado", False))
                    e.Filter.Add(New NumberFilterItem("Estado", CInt(Business.SEPA.BusinessEnum.MandatoEstado.Aceptado)))
            End Select
        End With
    End Sub

End Class
