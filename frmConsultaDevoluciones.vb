Public Class frmConsultaDevoluciones
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
    Public WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents BtnBorrarDev As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents CmbSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents FrmDevolucion As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents advRemesa As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblNumRemesa As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents LblSituacion As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim CmbSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaDevoluciones))
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.FrmDevolucion = New Solmicro.Expertis.Engine.UI.Frame
        Me.advRemesa = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblNumRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.BtnBorrarDev = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        Me.FrmDevolucion.SuspendLayout()
        CType(Me.CmbSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FrmDevolucion)
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 289)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 84)
        Me.Panel1.TabIndex = 4
        '
        'FrmDevolucion
        '
        Me.FrmDevolucion.Controls.Add(Me.advRemesa)
        Me.FrmDevolucion.Controls.Add(Me.lblNumRemesa)
        Me.FrmDevolucion.Controls.Add(Me.CmbSituacion)
        Me.FrmDevolucion.Controls.Add(Me.LblSituacion)
        Me.FrmDevolucion.Controls.Add(Me.BtnBorrarDev)
        Me.FrmDevolucion.Location = New System.Drawing.Point(6, 0)
        Me.FrmDevolucion.Name = "FrmDevolucion"
        Me.FrmDevolucion.Size = New System.Drawing.Size(569, 79)
        Me.FrmDevolucion.TabIndex = 8
        Me.FrmDevolucion.TabStop = False
        Me.FrmDevolucion.Text = "Devolución de Cobros"
        '
        'advRemesa
        '
        Me.advRemesa.DisabledBackColor = System.Drawing.Color.White
        Me.advRemesa.EntityName = "Remesa"
        Me.advRemesa.Location = New System.Drawing.Point(191, 47)
        Me.advRemesa.Name = "advRemesa"
        Me.advRemesa.SecondaryDataFields = "IDRemesa"
        Me.advRemesa.Size = New System.Drawing.Size(116, 23)
        Me.advRemesa.TabIndex = 11
        '
        'lblNumRemesa
        '
        Me.lblNumRemesa.Location = New System.Drawing.Point(8, 52)
        Me.lblNumRemesa.Name = "lblNumRemesa"
        Me.lblNumRemesa.Size = New System.Drawing.Size(71, 13)
        Me.lblNumRemesa.TabIndex = 10
        Me.lblNumRemesa.Text = "Nº Remesa"
        Me.lblNumRemesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbSituacion
        '
        Me.CmbSituacion.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        CmbSituacion_DesignTimeLayout.LayoutString = resources.GetString("CmbSituacion_DesignTimeLayout.LayoutString")
        Me.CmbSituacion.DesignTimeLayout = CmbSituacion_DesignTimeLayout
        Me.CmbSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.CmbSituacion.DisplayMember = "DescEstado"
        Me.CmbSituacion.Location = New System.Drawing.Point(192, 17)
        Me.CmbSituacion.Name = "CmbSituacion"
        Me.CmbSituacion.SelectedIndex = -1
        Me.CmbSituacion.SelectedItem = Nothing
        Me.CmbSituacion.Size = New System.Drawing.Size(160, 21)
        Me.CmbSituacion.TabIndex = 9
        Me.CmbSituacion.ValueMember = "IDEstado"
        '
        'LblSituacion
        '
        Me.LblSituacion.Location = New System.Drawing.Point(8, 21)
        Me.LblSituacion.Name = "LblSituacion"
        Me.LblSituacion.Size = New System.Drawing.Size(178, 13)
        Me.LblSituacion.TabIndex = 8
        Me.LblSituacion.Text = "Cambiar Situación Cobro a ..."
        Me.LblSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnBorrarDev
        '
        Me.BtnBorrarDev.Location = New System.Drawing.Point(446, 39)
        Me.BtnBorrarDev.Name = "BtnBorrarDev"
        Me.BtnBorrarDev.Size = New System.Drawing.Size(112, 32)
        Me.BtnBorrarDev.TabIndex = 7
        Me.BtnBorrarDev.Text = "&Borrar Ultima Devolución"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(697, 48)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 29)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(585, 48)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(100, 29)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Aceptar"
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = ""
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(808, 289)
        Me.Grid.TabIndex = 5
        Me.Grid.Tag = ""
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = ""
        '
        'frmConsultaDevoluciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(808, 373)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaDevoluciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devoluciones"
        Me.Panel1.ResumeLayout(False)
        Me.FrmDevolucion.ResumeLayout(False)
        Me.FrmDevolucion.PerformLayout()
        CType(Me.CmbSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    Public Function AbrirDevoluciones(ByVal intIdCobro As Integer, ByVal IntEstado As Integer) As DialogResult

        With Grid
            .EntityName = "CobroDevolucion"
            .ViewName = "frmConsultaDevoluciones"
            Dim f As New Filter

            f.Add(New NumberFilterItem("IDCobro", intIdCobro))
            .Filter = f

            '.RequeryManually = False
            '.ReQuery(f)
            '    If IntEstado <> 7 Then FrmDevolucion.Enabled = False

            LoadComboBox()
            .RequeryManually = False
            Return Me.ShowDialog()

        End With

        Return Me.DialogResult
    End Function

    Protected Overridable Sub LoadComboBox()
        Dim FilEstado As New Filter
        FilEstado.Add(New NumberFilterItem("IDEstado", FilterOperator.NotEqual, enumCobroSituacion.Negociado))
        'FilEstado.Add(New NumberFilterItem("IDEstado", FilterOperator.NotEqual, enumCobroSituacion.Descontado))
        FilEstado.Add(New NumberFilterItem("IDEstado", FilterOperator.NotEqual, enumCobroSituacion.GeneradoPago))
        FilEstado.Add(New NumberFilterItem("IDEstado", FilterOperator.NotEqual, enumCobroSituacion.Devuelto))
        Dim DtEstados As DataTable = New EstadoCobro().Filter(FilEstado, "Abreviatura")
        CmbSituacion.DataSource = DtEstados
        ' CmbSituacion.Value = CInt(enumCobroSituacion.NoNegociado)
    End Sub

    Protected Overridable Sub BorrarDevolucion()
        If Length(CmbSituacion.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe indicar el Estado al que pasar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim dtGrid As DataTable = Grid.DataSource
            If dtGrid Is Nothing OrElse dtGrid.Rows.Count = 0 Then
                ExpertisApp.GenerateMessage("No hay Devoluciones a eliminar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If ExpertisApp.GenerateMessage("¿Desea eliminar la última devolución con todos sus datos y pasar el Cobro a estado:{0}?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, CmbSituacion.Text) = DialogResult.Yes Then
                    Dim adr() As DataRow = dtGrid.Select(Nothing, "FechaDevolucion DESC, IDDevolucion DESC")
                    Dim datos As New CobroDevolucion.DataBorrarDevolucion
                    datos.IDCobroDevolucion = adr(0)("IDDevolucion")
                    datos.IDEstado = CmbSituacion.Value
                    If Length(advRemesa.Value) Then datos.IDRemesa = advRemesa.Value
                    datos.IDFacturaCompra = ExpertisApp.ExecuteTask(Of CobroDevolucion.DataBorrarDevolucion, Integer)(AddressOf CobroDevolucion.ComprobarFacturaDevolucionABorrar, datos)
                    Dim BlnAceptar As Boolean = True
                    If datos.IDFacturaCompra > 0 Then
                        If ExpertisApp.GenerateMessage("La Factura de Gastos:{0} , que se va a eliminar incluye más de una devolución. Se eliminarán todas las devoluciones asociadas a dicha Factura. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, adr(0)("NFactura")) = DialogResult.No Then
                            BlnAceptar = False
                        End If
                    End If
                    If BlnAceptar Then
                        Dim BlnEliminado As Boolean = ExpertisApp.ExecuteTask(Of CobroDevolucion.DataBorrarDevolucion, Boolean)(AddressOf CobroDevolucion.BorrarDevolucion, datos)
                        If BlnEliminado Then Me.DialogResult = DialogResult.OK
                    End If
                End If
            End If
        End If
    End Sub

    Protected Overridable Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.DialogResult = DialogResult.OK
        Me.UpdateData()
        Me.Close()
    End Sub

    Protected Overridable Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Protected Overridable Sub BtnBorrarDev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrarDev.Click
        BorrarDevolucion()
    End Sub

End Class