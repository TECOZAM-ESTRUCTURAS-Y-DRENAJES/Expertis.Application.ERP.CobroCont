Public Class FrmDesagrupaCobros
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
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents frmCloseForm As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDesagrupaCobros))
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.frmCloseForm = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = "Cobro"
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.RequeryManually = True
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(674, 220)
        Me.Grid.TabIndex = 2
        Me.Grid.ViewName = "VFrmMntoCobroConCobrosAgrupables"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.frmCloseForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 220)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(674, 43)
        Me.Panel1.TabIndex = 3
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(249, 7)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(85, 28)
        Me.cmbAceptar.TabIndex = 3
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(341, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(85, 28)
        Me.cmbCancelar.TabIndex = 4
        Me.cmbCancelar.Text = "Cancelar"
        '
        'frmCloseForm
        '
        Me.frmCloseForm.Location = New System.Drawing.Point(294, 7)
        Me.frmCloseForm.Name = "frmCloseForm"
        Me.frmCloseForm.Size = New System.Drawing.Size(85, 28)
        Me.frmCloseForm.TabIndex = 5
        Me.frmCloseForm.Text = "Aceptar"
        '
        'FrmDesagrupaCobros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(674, 263)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDesagrupaCobros"
        Me.Text = "Cobros Agrupados"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mdtCobrosAgrupados As DataTable
    Private mblnConsulta As Boolean

#Region " Load "

    Public Sub AbrirFormulario(ByVal dtCobros As DataTable, Optional ByVal blnConsulta As Boolean = False)

        If blnConsulta Then Me.Text = "Cobros Agrupados"

        cmbAceptar.Visible = Not blnConsulta
        cmbCancelar.Visible = Not blnConsulta
        frmCloseForm.Visible = blnConsulta
        mdtCobrosAgrupados = dtCobros

        If dtCobros.Rows.Count > 0 Then
            Dim f As New Filter
            f.UnionOperator = FilterUnionOperator.Or

            For Each dr As DataRow In dtCobros.Select
                f.Add("IdCobroAgrupado", FilterOperator.Equal, dr("IDCobro"), FilterType.Numeric)
            Next
            Dim dt As DataTable = New BE.DataEngine().Filter("frmDesagrupaCobros", f) 'New Cobro().Filter(f)
            Grid.DataSource = dt
        Else
            cmbAceptar.Enabled = False
        End If

        Me.ShowDialog()
    End Sub

    'Private Sub FrmDesagrupaCobros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Grid.DataSource = Me.CurrentData
    'End Sub

#End Region

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If ExpertisApp.GenerateMessage("Se van a desagrupar los Cobros seleccionados. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim elimCobroAgrup As New Cobro.DataDesagruparCobros
            elimCobroAgrup.CobrosAgrupados = mdtCobrosAgrupados.Copy
            elimCobroAgrup.CobrosDesagrupados = CType(Grid.DataSource, DataTable).Copy
            ExpertisApp.ExecuteTask(Of Cobro.DataDesagruparCobros)(AddressOf Cobro.EliminarCobroAgrupado, elimCobroAgrup)
            ExpertisApp.GenerateMessage("Los cobros se han desagrupado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub frmCloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmCloseForm.Click
        Me.Close()
    End Sub
End Class
