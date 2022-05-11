Public Class CICobrosMasivos
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblfwiTipoCobro As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFechaUltimaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaFinal As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFinal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpHasta As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtImpDesde As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblDescripcion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPeriodo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblUnidad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaFinDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaFinHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaIniDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaIniHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImpHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImpDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaUltimaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaUltimaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescripcion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtPeriodo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cbxUnidad As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbxFechaFinDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaFinHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaIniDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaIniHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaUltimaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaUltimaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxTipoCobro As Solmicro.Expertis.Engine.UI.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoCobro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxUnidad_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CICobrosMasivos))
        Me.cbxTipoCobro = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiTipoCobro = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxFechaFinal = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFinal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpHasta = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtImpDesde = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDescripcion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblUnidad = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaFinDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaFinHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaIniDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaIniHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaUltimaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaUltimaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescripcion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtPeriodo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cbxUnidad = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cbxFechaFinDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaFinHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaIniDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaIniHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaUltimaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaUltimaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxTipoCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        CType(Me.cbxUnidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.txtImpHasta)
        Me.FilterPanel.Controls.Add(Me.txtImpDesde)
        Me.FilterPanel.Controls.Add(Me.lblDescripcion)
        Me.FilterPanel.Controls.Add(Me.lblPeriodo)
        Me.FilterPanel.Controls.Add(Me.lblUnidad)
        Me.FilterPanel.Controls.Add(Me.lblFechaFinDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaFinHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaIniDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaIniHasta)
        Me.FilterPanel.Controls.Add(Me.lblImpHasta)
        Me.FilterPanel.Controls.Add(Me.lblImpDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaUltimaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaUltimaHasta)
        Me.FilterPanel.Controls.Add(Me.txtDescripcion)
        Me.FilterPanel.Controls.Add(Me.txtPeriodo)
        Me.FilterPanel.Controls.Add(Me.cbxUnidad)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFinDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFinHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaIniDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaIniHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaUltimaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaUltimaHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiTipoCobro)
        Me.FilterPanel.Controls.Add(Me.cbxTipoCobro)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 309)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 112)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Location = New System.Drawing.Point(0, 32)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 277)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "CobroPeriodico"
        Me.Grid.KeyField = "Id"
        Me.Grid.Size = New System.Drawing.Size(688, 277)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "frmCobrosMasivos"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(320, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Size = New System.Drawing.Size(688, 421)
        Me.MainPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.FilterPanel, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.CIMntoGridPanel, 0)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(688, 421)
        '
        'cbxTipoCobro
        '
        cbxTipoCobro_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoCobro_DesignTimeLayout.LayoutString")
        Me.cbxTipoCobro.DesignTimeLayout = cbxTipoCobro_DesignTimeLayout
        Me.cbxTipoCobro.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoCobro.DisplayMember = "DescTipo"
        Me.cbxTipoCobro.EntityName = "TipoCobro"
        Me.cbxTipoCobro.Location = New System.Drawing.Point(440, 18)
        Me.cbxTipoCobro.Name = "cbxTipoCobro"
        Me.cbxTipoCobro.PrimaryDataFields = "IdTipoCobro"
        Me.cbxTipoCobro.SecondaryDataFields = "IdTipoCobro"
        Me.cbxTipoCobro.SelectedIndex = -1
        Me.cbxTipoCobro.SelectedItem = Nothing
        Me.cbxTipoCobro.Size = New System.Drawing.Size(120, 21)
        Me.cbxTipoCobro.TabIndex = 9
        Me.cbxTipoCobro.ValueMember = "IdTipoCobro"
        Me.cbxTipoCobro.ViewName = "tbMaestroTipoCobro"
        '
        'lblfwiTipoCobro
        '
        Me.lblfwiTipoCobro.Location = New System.Drawing.Point(368, 18)
        Me.lblfwiTipoCobro.Name = "lblfwiTipoCobro"
        Me.lblfwiTipoCobro.Size = New System.Drawing.Size(70, 13)
        Me.lblfwiTipoCobro.TabIndex = 0
        Me.lblfwiTipoCobro.Text = "Tipo Cobro"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbxFechaFinal)
        Me.Panel1.Controls.Add(Me.lblFechaFinal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 32)
        Me.Panel1.TabIndex = 1
        '
        'cbxFechaFinal
        '
        Me.cbxFechaFinal.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFinal.Location = New System.Drawing.Point(94, 6)
        Me.cbxFechaFinal.Name = "cbxFechaFinal"
        Me.cbxFechaFinal.Size = New System.Drawing.Size(104, 21)
        Me.cbxFechaFinal.TabIndex = 0
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(14, 7)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaFinal.TabIndex = 3
        Me.lblFechaFinal.Text = "Fecha Final"
        '
        'txtImpHasta
        '
        Me.txtImpHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpHasta.Location = New System.Drawing.Point(96, 90)
        Me.txtImpHasta.Name = "txtImpHasta"
        Me.txtImpHasta.Size = New System.Drawing.Size(88, 21)
        Me.txtImpHasta.TabIndex = 4
        Me.txtImpHasta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'txtImpDesde
        '
        Me.txtImpDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpDesde.Location = New System.Drawing.Point(96, 66)
        Me.txtImpDesde.Name = "txtImpDesde"
        Me.txtImpDesde.Size = New System.Drawing.Size(88, 21)
        Me.txtImpDesde.TabIndex = 3
        Me.txtImpDesde.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(368, 90)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(73, 13)
        Me.lblDescripcion.TabIndex = 37
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(368, 66)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(50, 13)
        Me.lblPeriodo.TabIndex = 38
        Me.lblPeriodo.Text = "Periodo"
        '
        'lblUnidad
        '
        Me.lblUnidad.Location = New System.Drawing.Point(368, 42)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(46, 13)
        Me.lblUnidad.TabIndex = 39
        Me.lblUnidad.Text = "Unidad"
        '
        'lblFechaFinDesde
        '
        Me.lblFechaFinDesde.Location = New System.Drawing.Point(192, 66)
        Me.lblFechaFinDesde.Name = "lblFechaFinDesde"
        Me.lblFechaFinDesde.Size = New System.Drawing.Size(59, 13)
        Me.lblFechaFinDesde.TabIndex = 40
        Me.lblFechaFinDesde.Text = "F. Fin >="
        '
        'lblFechaFinHasta
        '
        Me.lblFechaFinHasta.Location = New System.Drawing.Point(192, 90)
        Me.lblFechaFinHasta.Name = "lblFechaFinHasta"
        Me.lblFechaFinHasta.Size = New System.Drawing.Size(59, 13)
        Me.lblFechaFinHasta.TabIndex = 41
        Me.lblFechaFinHasta.Text = "F. Fin <="
        '
        'lblFechaIniDesde
        '
        Me.lblFechaIniDesde.Location = New System.Drawing.Point(192, 18)
        Me.lblFechaIniDesde.Name = "lblFechaIniDesde"
        Me.lblFechaIniDesde.Size = New System.Drawing.Size(74, 13)
        Me.lblFechaIniDesde.TabIndex = 42
        Me.lblFechaIniDesde.Text = "F. Inicio >="
        '
        'lblFechaIniHasta
        '
        Me.lblFechaIniHasta.Location = New System.Drawing.Point(192, 42)
        Me.lblFechaIniHasta.Name = "lblFechaIniHasta"
        Me.lblFechaIniHasta.Size = New System.Drawing.Size(74, 13)
        Me.lblFechaIniHasta.TabIndex = 43
        Me.lblFechaIniHasta.Text = "F. Inicio <="
        '
        'lblImpHasta
        '
        Me.lblImpHasta.Location = New System.Drawing.Point(4, 90)
        Me.lblImpHasta.Name = "lblImpHasta"
        Me.lblImpHasta.Size = New System.Drawing.Size(75, 13)
        Me.lblImpHasta.TabIndex = 44
        Me.lblImpHasta.Text = "Importe <="
        '
        'lblImpDesde
        '
        Me.lblImpDesde.Location = New System.Drawing.Point(4, 66)
        Me.lblImpDesde.Name = "lblImpDesde"
        Me.lblImpDesde.Size = New System.Drawing.Size(75, 13)
        Me.lblImpDesde.TabIndex = 45
        Me.lblImpDesde.Text = "Importe >="
        '
        'lblFechaUltimaDesde
        '
        Me.lblFechaUltimaDesde.Location = New System.Drawing.Point(4, 18)
        Me.lblFechaUltimaDesde.Name = "lblFechaUltimaDesde"
        Me.lblFechaUltimaDesde.Size = New System.Drawing.Size(88, 13)
        Me.lblFechaUltimaDesde.TabIndex = 46
        Me.lblFechaUltimaDesde.Text = "F. Ult. Act. >="
        '
        'lblFechaUltimaHasta
        '
        Me.lblFechaUltimaHasta.Location = New System.Drawing.Point(4, 42)
        Me.lblFechaUltimaHasta.Name = "lblFechaUltimaHasta"
        Me.lblFechaUltimaHasta.Size = New System.Drawing.Size(88, 13)
        Me.lblFechaUltimaHasta.TabIndex = 47
        Me.lblFechaUltimaHasta.Text = "F. Ult. Act. <="
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescripcion.Location = New System.Drawing.Point(440, 90)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(240, 21)
        Me.txtDescripcion.TabIndex = 12
        '
        'txtPeriodo
        '
        Me.txtPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.txtPeriodo.Location = New System.Drawing.Point(440, 66)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(120, 21)
        Me.txtPeriodo.TabIndex = 11
        '
        'cbxUnidad
        '
        cbxUnidad_DesignTimeLayout.LayoutString = resources.GetString("cbxUnidad_DesignTimeLayout.LayoutString")
        Me.cbxUnidad.DesignTimeLayout = cbxUnidad_DesignTimeLayout
        Me.cbxUnidad.DisabledBackColor = System.Drawing.Color.White
        Me.cbxUnidad.Location = New System.Drawing.Point(440, 42)
        Me.cbxUnidad.Name = "cbxUnidad"
        Me.cbxUnidad.SelectedIndex = -1
        Me.cbxUnidad.SelectedItem = Nothing
        Me.cbxUnidad.Size = New System.Drawing.Size(120, 21)
        Me.cbxUnidad.TabIndex = 10
        '
        'cbxFechaFinDesde
        '
        Me.cbxFechaFinDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFinDesde.Location = New System.Drawing.Point(272, 66)
        Me.cbxFechaFinDesde.Name = "cbxFechaFinDesde"
        Me.cbxFechaFinDesde.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaFinDesde.TabIndex = 7
        '
        'cbxFechaFinHasta
        '
        Me.cbxFechaFinHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFinHasta.Location = New System.Drawing.Point(272, 90)
        Me.cbxFechaFinHasta.Name = "cbxFechaFinHasta"
        Me.cbxFechaFinHasta.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaFinHasta.TabIndex = 8
        '
        'cbxFechaIniDesde
        '
        Me.cbxFechaIniDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaIniDesde.Location = New System.Drawing.Point(272, 18)
        Me.cbxFechaIniDesde.Name = "cbxFechaIniDesde"
        Me.cbxFechaIniDesde.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaIniDesde.TabIndex = 5
        '
        'cbxFechaIniHasta
        '
        Me.cbxFechaIniHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaIniHasta.Location = New System.Drawing.Point(272, 42)
        Me.cbxFechaIniHasta.Name = "cbxFechaIniHasta"
        Me.cbxFechaIniHasta.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaIniHasta.TabIndex = 6
        '
        'cbxFechaUltimaDesde
        '
        Me.cbxFechaUltimaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaUltimaDesde.Location = New System.Drawing.Point(96, 18)
        Me.cbxFechaUltimaDesde.Name = "cbxFechaUltimaDesde"
        Me.cbxFechaUltimaDesde.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaUltimaDesde.TabIndex = 1
        '
        'cbxFechaUltimaHasta
        '
        Me.cbxFechaUltimaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaUltimaHasta.Location = New System.Drawing.Point(96, 42)
        Me.cbxFechaUltimaHasta.Name = "cbxFechaUltimaHasta"
        Me.cbxFechaUltimaHasta.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaUltimaHasta.TabIndex = 2
        '
        'CICobrosMasivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "CobroPeriodico"
        Me.KeyField = "Id"
        Me.Name = "CICobrosMasivos"
        Me.UseCheck = True
        Me.ViewName = "frmCobrosMasivos"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxTipoCobro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cbxUnidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub CICobrosMasivos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
        LoadToolbarActions()
    End Sub

    Private Sub LoadEnums()
        cbxUnidad.DataSource = New EnumData("enumcpPeriodo")
        EnumData.PopulateValueList("enumcpPeriodo", Grid.Columns("Unidad"))
    End Sub

    Private Sub LoadToolbarActions()
        'Me.FormActions.Add("-", AddressOf "-")
        Me.FormActions.Add("Cobros masivos", AddressOf AccionCobrosMasivos)
    End Sub
#End Region

    Private Sub AccionCobrosMasivos()
        If Grid.CheckedRecordsCount > 0 Then
            If Engine.Length(cbxFechaFinal.Value) > 0 Then
                Dim dtMarcados As DataTable = Me.CheckedRecords
                If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                    If ExpertisApp.GenerateMessage("Se generarán Cobros de forma Masiva a partir de las líneas seleccionadas. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then 'Se generarán Cobros de forma Masiva a partir de las líneas seleccionadas. ¿Desea continuar?.
                        Me.Cursor = Cursors.WaitCursor
                        Dim datos As New Cobro.DataAddCobroPeriodico(dtMarcados, cbxFechaFinal.Value)
                        ExpertisApp.ExecuteTask(Of Cobro.DataAddCobroPeriodico, DataTable)(AddressOf Cobro.AddCobroPeriodico, datos)
                        Me.UnCheckAllRecords()
                        Me.Execute()
                        Me.Cursor = Cursors.Default
                    End If
                End If
            Else
                ExpertisApp.GenerateMessage("La Fecha final es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub CICobrosMasivos_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("FechaUltimaActualizacion", FilterOperator.GreaterThanOrEqual, cbxFechaUltimaDesde.Text, FilterType.DateTime)
        e.Filter.Add("FechaUltimaActualizacion", FilterOperator.LessThanOrEqual, cbxFechaUltimaHasta.Text, FilterType.DateTime)
        e.Filter.Add("FechaInicio", FilterOperator.GreaterThanOrEqual, cbxFechaIniDesde.Text, FilterType.DateTime)
        e.Filter.Add("FechaInicio", FilterOperator.LessThanOrEqual, cbxFechaIniHasta.Text, FilterType.DateTime)
        e.Filter.Add("FechaFin", FilterOperator.GreaterThanOrEqual, cbxFechaFinDesde.Text, FilterType.DateTime)
        e.Filter.Add("FechaFin", FilterOperator.LessThanOrEqual, cbxFechaFinHasta.Text, FilterType.DateTime)
        e.Filter.Add("Importe", FilterOperator.GreaterThanOrEqual, txtImpDesde.Text, FilterType.Numeric)
        e.Filter.Add("Importe", FilterOperator.LessThanOrEqual, txtImpHasta.Text, FilterType.Numeric)
        e.Filter.Add("IdTipoCobro", FilterOperator.Equal, cbxTipoCobro.Value, FilterType.String)
        e.Filter.Add("Unidad", FilterOperator.Equal, cbxUnidad.Value, FilterType.String)
        e.Filter.Add("Periodo", FilterOperator.Equal, txtPeriodo.Text, FilterType.Numeric)
    End Sub

End Class
