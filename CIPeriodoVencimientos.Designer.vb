﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIPeriodoVencimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIPeriodoVencimientos))
        Me.clbFechaFacturaD = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaFacturaH = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFactura1 = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbDiasVencimiento = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDiasVencimiento = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbFechaCobroHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.LblFechaCobroHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbFechaCobroDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.LblFechaCobro = New Solmicro.Expertis.Engine.UI.Label
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
        Me.FilterPanel.Controls.Add(Me.ClbFechaCobroHasta)
        Me.FilterPanel.Controls.Add(Me.LblFechaCobroHasta)
        Me.FilterPanel.Controls.Add(Me.ClbFechaCobroDesde)
        Me.FilterPanel.Controls.Add(Me.LblFechaCobro)
        Me.FilterPanel.Controls.Add(Me.ntbDiasVencimiento)
        Me.FilterPanel.Controls.Add(Me.lblDiasVencimiento)
        Me.FilterPanel.Controls.Add(Me.advIDCliente)
        Me.FilterPanel.Controls.Add(Me.lblIDCliente)
        Me.FilterPanel.Controls.Add(Me.clbFechaFacturaH)
        Me.FilterPanel.Controls.Add(Me.lblFechaFactura1)
        Me.FilterPanel.Controls.Add(Me.clbFechaFacturaD)
        Me.FilterPanel.Controls.Add(Me.lblFechaFactura)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 321)
        Me.FilterPanel.Size = New System.Drawing.Size(840, 89)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(840, 321)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Cobro"
        Me.Grid.Size = New System.Drawing.Size(840, 321)
        Me.Grid.ViewName = "frmPeriodoVencimientoCobros"
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
        Me.MainPanel.Size = New System.Drawing.Size(840, 410)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(840, 410)
        '
        'clbFechaFacturaD
        '
        Me.TryDataBinding(clbFechaFacturaD, New System.Windows.Forms.Binding("BindableValue", Me, "FechaFactura", True))
        Me.clbFechaFacturaD.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaFacturaD.Location = New System.Drawing.Point(95, 22)
        Me.clbFechaFacturaD.Name = "clbFechaFacturaD"
        Me.clbFechaFacturaD.Size = New System.Drawing.Size(121, 21)
        Me.clbFechaFacturaD.TabIndex = 0
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.Location = New System.Drawing.Point(8, 26)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(86, 13)
        Me.lblFechaFactura.TabIndex = 1
        Me.lblFechaFactura.Text = "Fecha Factura"
        '
        'clbFechaFacturaH
        '
        Me.clbFechaFacturaH.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaFacturaH.Location = New System.Drawing.Point(240, 22)
        Me.clbFechaFacturaH.Name = "clbFechaFacturaH"
        Me.clbFechaFacturaH.Size = New System.Drawing.Size(121, 21)
        Me.clbFechaFacturaH.TabIndex = 1
        '
        'lblFechaFactura1
        '
        Me.lblFechaFactura1.Location = New System.Drawing.Point(222, 26)
        Me.lblFechaFactura1.Name = "lblFechaFactura1"
        Me.lblFechaFactura1.Size = New System.Drawing.Size(12, 13)
        Me.lblFechaFactura1.TabIndex = 3
        Me.lblFechaFactura1.Text = "-"
        '
        'advIDCliente
        '
        Me.TryDataBinding(advIDCliente, New System.Windows.Forms.Binding("Text", Me, "IDCliente", True))
        Me.advIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCliente.EntityName = "Cliente"
        Me.advIDCliente.Location = New System.Drawing.Point(709, 21)
        Me.advIDCliente.Name = "advIDCliente"
        Me.advIDCliente.PrimaryDataFields = "IDCliente"
        Me.advIDCliente.SecondaryDataFields = "IDCliente"
        Me.advIDCliente.Size = New System.Drawing.Size(121, 23)
        Me.advIDCliente.TabIndex = 4
        '
        'lblIDCliente
        '
        Me.lblIDCliente.Location = New System.Drawing.Point(633, 26)
        Me.lblIDCliente.Name = "lblIDCliente"
        Me.lblIDCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblIDCliente.TabIndex = 5
        Me.lblIDCliente.Text = "Cliente"
        '
        'ntbDiasVencimiento
        '
        Me.ntbDiasVencimiento.DisabledBackColor = System.Drawing.Color.White
        Me.ntbDiasVencimiento.Location = New System.Drawing.Point(709, 55)
        Me.ntbDiasVencimiento.Name = "ntbDiasVencimiento"
        Me.ntbDiasVencimiento.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.ntbDiasVencimiento.Size = New System.Drawing.Size(121, 21)
        Me.ntbDiasVencimiento.TabIndex = 5
        '
        'lblDiasVencimiento
        '
        Me.lblDiasVencimiento.Location = New System.Drawing.Point(633, 59)
        Me.lblDiasVencimiento.Name = "lblDiasVencimiento"
        Me.lblDiasVencimiento.Size = New System.Drawing.Size(70, 13)
        Me.lblDiasVencimiento.TabIndex = 8
        Me.lblDiasVencimiento.Text = "Nº días >="
        '
        'ClbFechaCobroHasta
        '
        Me.ClbFechaCobroHasta.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaCobroHasta.Location = New System.Drawing.Point(240, 51)
        Me.ClbFechaCobroHasta.Name = "ClbFechaCobroHasta"
        Me.ClbFechaCobroHasta.Size = New System.Drawing.Size(121, 21)
        Me.ClbFechaCobroHasta.TabIndex = 3
        '
        'LblFechaCobroHasta
        '
        Me.LblFechaCobroHasta.Location = New System.Drawing.Point(222, 55)
        Me.LblFechaCobroHasta.Name = "LblFechaCobroHasta"
        Me.LblFechaCobroHasta.Size = New System.Drawing.Size(12, 13)
        Me.LblFechaCobroHasta.TabIndex = 12
        Me.LblFechaCobroHasta.Text = "-"
        '
        'ClbFechaCobroDesde
        '
        Me.ClbFechaCobroDesde.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaCobroDesde.Location = New System.Drawing.Point(95, 51)
        Me.ClbFechaCobroDesde.Name = "ClbFechaCobroDesde"
        Me.ClbFechaCobroDesde.Size = New System.Drawing.Size(121, 21)
        Me.ClbFechaCobroDesde.TabIndex = 2
        '
        'LblFechaCobro
        '
        Me.LblFechaCobro.Location = New System.Drawing.Point(8, 55)
        Me.LblFechaCobro.Name = "LblFechaCobro"
        Me.LblFechaCobro.Size = New System.Drawing.Size(79, 13)
        Me.LblFechaCobro.TabIndex = 10
        Me.LblFechaCobro.Text = "Fecha Cobro"
        '
        'CIPeriodoVencimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 498)
        Me.EntityName = "Cobro"
        Me.Name = "CIPeriodoVencimientos"
        Me.Text = "Consulta Vencimientos Excedidos de Período"
        Me.ViewName = "frmPeriodoVencimientoCobros"
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
    Friend WithEvents clbFechaFacturaH As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFactura1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaFacturaD As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbDiasVencimiento As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblDiasVencimiento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbFechaCobroHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents LblFechaCobroHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbFechaCobroDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents LblFechaCobro As Solmicro.Expertis.Engine.UI.Label
End Class
