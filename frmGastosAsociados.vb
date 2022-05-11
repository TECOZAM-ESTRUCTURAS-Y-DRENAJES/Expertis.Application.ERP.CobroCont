Public Class frmGastosAsociados

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Grid.RelationMode = RelationMode.NoRelation
    End Sub

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property


    Public Sub AbrirFormularioCobro(ByVal IDCobro As Integer)
        Grid.EntityName = "CobroFacturaCompra"
        Grid.PrimaryDataFields = "IDCobro"
        Grid.SecondaryDataFields = "IDCobro"
        Grid.ViewName = "vfrmCICobroGasto"

        Dim f As New Filter
        f.Add(New NumberFilterItem("IDCobro", IDCobro))
        Grid.Filter = f

        Me.ShowDialog()
    End Sub


    Public Sub AbrirFormularioRemesa(ByVal IDRemesa As Integer)
        Grid.EntityName = "RemesaCobroFacturaCompra"
        Grid.PrimaryDataFields = "IDRemesa"
        Grid.SecondaryDataFields = "IDRemesa"
        Grid.ViewName = "vfrmCIRemesaCobroFacturaCompra"

        Dim f As New Filter
        f.Add(New NumberFilterItem("IDRemesa", IDRemesa))
        Grid.Filter = f

        Me.ShowDialog()
    End Sub

    Private Sub frmFacturasCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            Grid.Actions.Add("Abrir Factura Compra", AddressOf AbrirFacturaCompra, ExpertisApp.GetIcon("xFacturaCompra.ico"))
            'Grid.AllowDelete = InheritableBoolean.True
        End If
    End Sub

    Private Sub AbrirFacturaCompra()
        ExpertisApp.OpenForm("MFACC", New NumberFilterItem("IDFactura", Grid.Value("IDFactura")))
        Me.Close()
    End Sub

    Private Sub cmbCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCerrar.Click
        Dim dtGrid As DataTable = Grid.DataSource
        dtGrid.TableName = Me.Grid.EntityName
        'BusinessHelper.UpdateTable(dtGrid)
        Dim upd As New UpdateData
        upd.EntityName = dtGrid.TableName
        upd.Data = dtGrid
        Dim BEDataEngine As New BE.DataEngine
        BEDataEngine.Update(upd, Nothing)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class