<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReparteImporteCobrosCliente
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
        Dim cbxIDFormaPago_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReparteImporteCobrosCliente))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDFormaPago = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ntxImporte = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImporte = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Panel1.suspendlayout()
        CType(Me.cbxIDFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 38)
        Me.Panel1.TabIndex = 3
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(147, 5)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(94, 27)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(48, 5)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(94, 27)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(30, 19)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 54
        Me.lblCliente.Tag = "IdRec=4365;"
        Me.lblCliente.Text = "Cliente"
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Location = New System.Drawing.Point(30, 44)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(75, 13)
        Me.lblFormaPago.TabIndex = 60
        Me.lblFormaPago.Tag = "IdRec=4758;"
        Me.lblFormaPago.Text = "Forma Pago"
        '
        'cbxIDFormaPago
        '
        cbxIDFormaPago_DesignTimeLayout.LayoutString = resources.GetString("cbxIDFormaPago_DesignTimeLayout.LayoutString")
        Me.cbxIDFormaPago.DesignTimeLayout = cbxIDFormaPago_DesignTimeLayout
        Me.cbxIDFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDFormaPago.DisplayMember = "IDFormaPago"
        Me.cbxIDFormaPago.EntityName = "FormaPago"
        Me.cbxIDFormaPago.Location = New System.Drawing.Point(144, 40)
        Me.cbxIDFormaPago.Name = "cbxIDFormaPago"
        Me.cbxIDFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.cbxIDFormaPago.SelectedIndex = -1
        Me.cbxIDFormaPago.SelectedItem = Nothing
        Me.cbxIDFormaPago.Size = New System.Drawing.Size(113, 21)
        Me.cbxIDFormaPago.TabIndex = 1
        Me.cbxIDFormaPago.ValueMember = "IDFormaPago"
        Me.cbxIDFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'ntxImporte
        '
        Me.ntxImporte.DisabledBackColor = System.Drawing.Color.White
        Me.ntxImporte.Location = New System.Drawing.Point(145, 64)
        Me.ntxImporte.Name = "ntxImporte"
        Me.ntxImporte.Size = New System.Drawing.Size(113, 21)
        Me.ntxImporte.TabIndex = 2
        '
        'lblImporte
        '
        Me.lblImporte.Location = New System.Drawing.Point(30, 68)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(111, 13)
        Me.lblImporte.TabIndex = 62
        Me.lblImporte.Tag = ""
        Me.lblImporte.Text = "Importe a repartir"
        '
        'txtIDCliente
        '
        Me.txtIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDCliente.Enabled = False
        Me.txtIDCliente.Location = New System.Drawing.Point(144, 16)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(113, 21)
        Me.txtIDCliente.TabIndex = 63
        '
        'frmReparteImporteCobrosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 128)
        Me.Controls.Add(Me.txtIDCliente)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.ntxImporte)
        Me.Controls.Add(Me.lblFormaPago)
        Me.Controls.Add(Me.cbxIDFormaPago)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReparteImporteCobrosCliente"
        Me.Text = "Repartir Importes"
        Me.Panel1.ResumeLayout(False)
        CType(Me.cbxIDFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFormaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxIDFormaPago As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents ntxImporte As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblImporte As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtIDCliente As Solmicro.Expertis.Engine.UI.TextBox
End Class
