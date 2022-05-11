<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGastosAsociados
    Inherits Solmicro.Expertis.Engine.UI.FormBase

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
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGastosAsociados))
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCerrar = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = ""
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = ""
        Me.Grid.SecondaryDataFields = ""
        Me.Grid.Size = New System.Drawing.Size(865, 342)
        Me.Grid.TabIndex = 5
        Me.Grid.ViewName = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 342)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(865, 40)
        Me.Panel1.TabIndex = 4
        '
        'cmbCerrar
        '
        Me.cmbCerrar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmbCerrar.Location = New System.Drawing.Point(389, 6)
        Me.cmbCerrar.Name = "cmbCerrar"
        Me.cmbCerrar.Size = New System.Drawing.Size(90, 28)
        Me.cmbCerrar.TabIndex = 1
        Me.cmbCerrar.Text = "Cerrar"
        '
        'frmGastosAsociados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 382)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmGastosAsociados"
        Me.Text = "Facturas de Compra relacionadas"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbCerrar As Solmicro.Expertis.Engine.UI.Button
End Class
