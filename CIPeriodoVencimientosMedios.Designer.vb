<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIPeriodoVencimientosMedios
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIPeriodoVencimientosMedios))
        Me.advsCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescCliente = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.txtFechaFacturaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.txtFechaFacturaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtFechaVencimientoHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.txtFechaVencimientoDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.Label2)
        Me.FilterPanel.Controls.Add(Me.Label3)
        Me.FilterPanel.Controls.Add(Me.txtFechaVencimientoHasta)
        Me.FilterPanel.Controls.Add(Me.txtFechaVencimientoDesde)
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.lblFechaFactura)
        Me.FilterPanel.Controls.Add(Me.txtFechaFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.txtFechaFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.ulDescCliente)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.advsCliente)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 353)
        Me.FilterPanel.Size = New System.Drawing.Size(699, 83)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(699, 353)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Hierarchical = True
        Me.Grid.Size = New System.Drawing.Size(699, 353)
        Me.Grid.ViewName = "vfrmCIPeriodoVencimientosCobrosMedios"
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(699, 436)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(699, 436)
        '
        'advsCliente
        '
        Me.advsCliente.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCliente", ulDescCliente)})
        Me.advsCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advsCliente.EntityName = "Cliente"
        Me.advsCliente.Location = New System.Drawing.Point(61, 20)
        Me.advsCliente.Name = "advsCliente"
        Me.advsCliente.SecondaryDataFields = "IDCliente"
        Me.advsCliente.Size = New System.Drawing.Size(100, 23)
        Me.advsCliente.TabIndex = 0
        Me.advsCliente.ViewName = "tbMaestroCliente"
        '
        'ulDescCliente
        '
        Me.ulDescCliente.Location = New System.Drawing.Point(167, 20)
        Me.ulDescCliente.Name = "ulDescCliente"
        Me.ulDescCliente.Size = New System.Drawing.Size(353, 23)
        Me.ulDescCliente.TabIndex = 2
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(8, 25)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente"
        '
        'txtFechaFacturaDesde
        '
        Me.txtFechaFacturaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtFechaFacturaDesde.Location = New System.Drawing.Point(99, 49)
        Me.txtFechaFacturaDesde.Name = "txtFechaFacturaDesde"
        Me.txtFechaFacturaDesde.Size = New System.Drawing.Size(100, 21)
        Me.txtFechaFacturaDesde.TabIndex = 1
        '
        'txtFechaFacturaHasta
        '
        Me.txtFechaFacturaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtFechaFacturaHasta.Location = New System.Drawing.Point(223, 49)
        Me.txtFechaFacturaHasta.Name = "txtFechaFacturaHasta"
        Me.txtFechaFacturaHasta.Size = New System.Drawing.Size(100, 21)
        Me.txtFechaFacturaHasta.TabIndex = 2
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.Location = New System.Drawing.Point(8, 53)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(85, 13)
        Me.lblFechaFactura.TabIndex = 5
        Me.lblFechaFactura.Text = "Fecha Factura"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(205, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "-"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(573, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "-"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(348, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha Vencimiento"
        '
        'txtFechaVencimientoHasta
        '
        Me.txtFechaVencimientoHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtFechaVencimientoHasta.Location = New System.Drawing.Point(591, 49)
        Me.txtFechaVencimientoHasta.Name = "txtFechaVencimientoHasta"
        Me.txtFechaVencimientoHasta.Size = New System.Drawing.Size(100, 21)
        Me.txtFechaVencimientoHasta.TabIndex = 4
        '
        'txtFechaVencimientoDesde
        '
        Me.txtFechaVencimientoDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtFechaVencimientoDesde.Location = New System.Drawing.Point(467, 49)
        Me.txtFechaVencimientoDesde.Name = "txtFechaVencimientoDesde"
        Me.txtFechaVencimientoDesde.Size = New System.Drawing.Size(100, 21)
        Me.txtFechaVencimientoDesde.TabIndex = 3
        '
        'CIPeriodoVencimientosMedios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 524)
        Me.Name = "CIPeriodoVencimientosMedios"
        Me.ViewName = "vfrmCIPeriodoVencimientosCobrosMedios"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ulDescCliente As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advsCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFechaFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtFechaFacturaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents txtFechaFacturaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtFechaVencimientoHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents txtFechaVencimientoDesde As Solmicro.Expertis.Engine.UI.CalendarBox
End Class
