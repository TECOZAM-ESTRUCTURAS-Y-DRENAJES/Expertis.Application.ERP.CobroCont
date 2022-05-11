<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CICartaProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CICartaProveedores))
        Me.LblProveedorDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvProveedorDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvProveedorHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblProveedorHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTipoProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblTipoProv = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvMercado = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblMercado = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvPais = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblPais = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIdioma = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblIdioma = New Solmicro.Expertis.Engine.UI.Label
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
        Me.FilterPanel.Controls.Add(Me.AdvIdioma)
        Me.FilterPanel.Controls.Add(Me.LblIdioma)
        Me.FilterPanel.Controls.Add(Me.AdvPais)
        Me.FilterPanel.Controls.Add(Me.LblPais)
        Me.FilterPanel.Controls.Add(Me.AdvMercado)
        Me.FilterPanel.Controls.Add(Me.LblMercado)
        Me.FilterPanel.Controls.Add(Me.AdvTipoProveedor)
        Me.FilterPanel.Controls.Add(Me.LblTipoProv)
        Me.FilterPanel.Controls.Add(Me.AdvProveedorHasta)
        Me.FilterPanel.Controls.Add(Me.LblProveedorHasta)
        Me.FilterPanel.Controls.Add(Me.AdvProveedorDesde)
        Me.FilterPanel.Controls.Add(Me.LblProveedorDesde)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 327)
        Me.FilterPanel.Size = New System.Drawing.Size(699, 109)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(699, 327)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Proveedor"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.KeyField = "IDProveedor"
        Me.Grid.Size = New System.Drawing.Size(699, 327)
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vCICartaProveedores"
        '
        'CheckAll
        '
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
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
        Me.MainPanel.Size = New System.Drawing.Size(699, 436)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(699, 436)
        '
        'LblProveedorDesde
        '
        Me.LblProveedorDesde.Location = New System.Drawing.Point(8, 27)
        Me.LblProveedorDesde.Name = "LblProveedorDesde"
        Me.LblProveedorDesde.Size = New System.Drawing.Size(88, 13)
        Me.LblProveedorDesde.TabIndex = 0
        Me.LblProveedorDesde.Text = "Proveedor >="
        '
        'AdvProveedorDesde
        '
        Me.AdvProveedorDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvProveedorDesde.EntityName = "Proveedor"
        Me.AdvProveedorDesde.Location = New System.Drawing.Point(102, 22)
        Me.AdvProveedorDesde.Name = "AdvProveedorDesde"
        Me.AdvProveedorDesde.SecondaryDataFields = "IDProveedor"
        Me.AdvProveedorDesde.Size = New System.Drawing.Size(100, 23)
        Me.AdvProveedorDesde.TabIndex = 1
        '
        'AdvProveedorHasta
        '
        Me.AdvProveedorHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvProveedorHasta.EntityName = "Proveedor"
        Me.AdvProveedorHasta.Location = New System.Drawing.Point(239, 22)
        Me.AdvProveedorHasta.Name = "AdvProveedorHasta"
        Me.AdvProveedorHasta.SecondaryDataFields = "IDProveedor"
        Me.AdvProveedorHasta.Size = New System.Drawing.Size(100, 23)
        Me.AdvProveedorHasta.TabIndex = 2
        '
        'LblProveedorHasta
        '
        Me.LblProveedorHasta.Location = New System.Drawing.Point(208, 27)
        Me.LblProveedorHasta.Name = "LblProveedorHasta"
        Me.LblProveedorHasta.Size = New System.Drawing.Size(25, 13)
        Me.LblProveedorHasta.TabIndex = 2
        Me.LblProveedorHasta.Text = "<="
        '
        'AdvTipoProveedor
        '
        Me.AdvTipoProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoProveedor.EntityName = "TipoProveedor"
        Me.AdvTipoProveedor.Location = New System.Drawing.Point(102, 51)
        Me.AdvTipoProveedor.Name = "AdvTipoProveedor"
        Me.AdvTipoProveedor.SecondaryDataFields = "IDTipoProveedor"
        Me.AdvTipoProveedor.Size = New System.Drawing.Size(100, 23)
        Me.AdvTipoProveedor.TabIndex = 3
        '
        'LblTipoProv
        '
        Me.LblTipoProv.Location = New System.Drawing.Point(8, 56)
        Me.LblTipoProv.Name = "LblTipoProv"
        Me.LblTipoProv.Size = New System.Drawing.Size(64, 13)
        Me.LblTipoProv.TabIndex = 4
        Me.LblTipoProv.Text = "Tipo Prov."
        '
        'AdvMercado
        '
        Me.AdvMercado.DisabledBackColor = System.Drawing.Color.White
        Me.AdvMercado.EntityName = "Mercado"
        Me.AdvMercado.Location = New System.Drawing.Point(102, 79)
        Me.AdvMercado.Name = "AdvMercado"
        Me.AdvMercado.SecondaryDataFields = "IDMercado"
        Me.AdvMercado.Size = New System.Drawing.Size(100, 23)
        Me.AdvMercado.TabIndex = 4
        '
        'LblMercado
        '
        Me.LblMercado.Location = New System.Drawing.Point(8, 84)
        Me.LblMercado.Name = "LblMercado"
        Me.LblMercado.Size = New System.Drawing.Size(55, 13)
        Me.LblMercado.TabIndex = 6
        Me.LblMercado.Text = "Mercado"
        '
        'AdvPais
        '
        Me.AdvPais.DisabledBackColor = System.Drawing.Color.White
        Me.AdvPais.EntityName = "Pais"
        Me.AdvPais.Location = New System.Drawing.Point(423, 22)
        Me.AdvPais.Name = "AdvPais"
        Me.AdvPais.SecondaryDataFields = "IDPais"
        Me.AdvPais.Size = New System.Drawing.Size(100, 23)
        Me.AdvPais.TabIndex = 5
        '
        'LblPais
        '
        Me.LblPais.Location = New System.Drawing.Point(360, 27)
        Me.LblPais.Name = "LblPais"
        Me.LblPais.Size = New System.Drawing.Size(30, 13)
        Me.LblPais.TabIndex = 8
        Me.LblPais.Text = "País"
        '
        'AdvIdioma
        '
        Me.AdvIdioma.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIdioma.EntityName = "Idioma"
        Me.AdvIdioma.Location = New System.Drawing.Point(423, 51)
        Me.AdvIdioma.Name = "AdvIdioma"
        Me.AdvIdioma.SecondaryDataFields = "IDIdioma"
        Me.AdvIdioma.Size = New System.Drawing.Size(100, 23)
        Me.AdvIdioma.TabIndex = 6
        '
        'LblIdioma
        '
        Me.LblIdioma.Location = New System.Drawing.Point(360, 56)
        Me.LblIdioma.Name = "LblIdioma"
        Me.LblIdioma.Size = New System.Drawing.Size(47, 13)
        Me.LblIdioma.TabIndex = 10
        Me.LblIdioma.Text = "Idioma"
        '
        'CICartaProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 524)
        Me.EntityName = "Proveedor"
        Me.KeyField = "IDProveedor"
        Me.Name = "CICartaProveedores"
        Me.UseCheck = True
        Me.ViewName = "vCICartaProveedores"
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
    Friend WithEvents AdvIdioma As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblIdioma As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvPais As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblPais As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvMercado As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblMercado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvTipoProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblTipoProv As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvProveedorHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblProveedorHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvProveedorDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblProveedorDesde As Solmicro.Expertis.Engine.UI.Label
End Class
