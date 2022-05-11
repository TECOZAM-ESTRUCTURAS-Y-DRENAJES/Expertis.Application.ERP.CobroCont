<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelarAnticipo
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
        Dim cboSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCancelarAnticipo))
        Dim cboBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.FraCancelacion = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblcboSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblccboSituacion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cboSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblDescApunteAnticipo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescApunteAnticipo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblRefCancelacion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtRefCancelacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCancelacionAnt = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaCancelacion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.chkAgruparBanco = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.pnlBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FraContabilizarCobros = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkGenerarAsientoConGastos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lbltxtDescApunte = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescApunte = New Solmicro.Expertis.Engine.UI.TextBox
        Me.chkContabilizarCobros = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblcboBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.ulblcboBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cboBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        CType(Me.cboSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.suspendlayout()
        CType(Me.cboBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FraCancelacion
        '
        Me.FraCancelacion.Controls.Add(Me.lblcboSituacion)
        Me.FraCancelacion.Controls.Add(Me.lblccboSituacion)
        Me.FraCancelacion.Controls.Add(Me.cboSituacion)
        Me.FraCancelacion.Controls.Add(Me.lblDescApunteAnticipo)
        Me.FraCancelacion.Controls.Add(Me.txtDescApunteAnticipo)
        Me.FraCancelacion.Controls.Add(Me.lblRefCancelacion)
        Me.FraCancelacion.Controls.Add(Me.txtRefCancelacion)
        Me.FraCancelacion.Controls.Add(Me.lblCancelacionAnt)
        Me.FraCancelacion.Controls.Add(Me.cbxFechaCancelacion)
        Me.FraCancelacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraCancelacion.Location = New System.Drawing.Point(0, 0)
        Me.FraCancelacion.Name = "FraCancelacion"
        Me.FraCancelacion.Size = New System.Drawing.Size(391, 179)
        Me.FraCancelacion.TabIndex = 0
        Me.FraCancelacion.TabStop = False
        Me.FraCancelacion.Text = "Cancelación Anticipo"
        '
        'lblcboSituacion
        '
        Me.lblcboSituacion.Location = New System.Drawing.Point(24, 28)
        Me.lblcboSituacion.Name = "lblcboSituacion"
        Me.lblcboSituacion.Size = New System.Drawing.Size(79, 13)
        Me.lblcboSituacion.TabIndex = 16
        Me.lblcboSituacion.Tag = ""
        Me.lblcboSituacion.Text = "Cambiar a..."
        '
        'lblccboSituacion
        '
        Me.lblccboSituacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cboSituacion, "DescEstado", True))
        Me.lblccboSituacion.Location = New System.Drawing.Point(197, 24)
        Me.lblccboSituacion.Name = "lblccboSituacion"
        Me.lblccboSituacion.Size = New System.Drawing.Size(133, 22)
        Me.lblccboSituacion.TabIndex = 17
        '
        'cboSituacion
        '
        cboSituacion_DesignTimeLayout.LayoutString = resources.GetString("cboSituacion_DesignTimeLayout.LayoutString")
        Me.cboSituacion.DesignTimeLayout = cboSituacion_DesignTimeLayout
        Me.cboSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.cboSituacion.EntityName = "EstadoCobro"
        Me.cboSituacion.Location = New System.Drawing.Point(142, 24)
        Me.cboSituacion.Name = "cboSituacion"
        Me.cboSituacion.PrimaryDataFields = "IDEstado"
        Me.cboSituacion.SecondaryDataFields = "IDEstado"
        Me.cboSituacion.SelectedIndex = -1
        Me.cboSituacion.SelectedItem = Nothing
        Me.cboSituacion.Size = New System.Drawing.Size(53, 21)
        Me.cboSituacion.TabIndex = 15
        Me.cboSituacion.ViewName = "tbMaestroEstadoCobro"
        '
        'lblDescApunteAnticipo
        '
        Me.lblDescApunteAnticipo.Location = New System.Drawing.Point(24, 136)
        Me.lblDescApunteAnticipo.Name = "lblDescApunteAnticipo"
        Me.lblDescApunteAnticipo.Size = New System.Drawing.Size(83, 13)
        Me.lblDescApunteAnticipo.TabIndex = 14
        Me.lblDescApunteAnticipo.Tag = ""
        Me.lblDescApunteAnticipo.Text = "Desc. Apunte"
        '
        'txtDescApunteAnticipo
        '
        Me.txtDescApunteAnticipo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescApunteAnticipo.Location = New System.Drawing.Point(27, 152)
        Me.txtDescApunteAnticipo.Name = "txtDescApunteAnticipo"
        Me.txtDescApunteAnticipo.Size = New System.Drawing.Size(341, 21)
        Me.txtDescApunteAnticipo.TabIndex = 2
        '
        'lblRefCancelacion
        '
        Me.lblRefCancelacion.Location = New System.Drawing.Point(24, 91)
        Me.lblRefCancelacion.Name = "lblRefCancelacion"
        Me.lblRefCancelacion.Size = New System.Drawing.Size(103, 13)
        Me.lblRefCancelacion.TabIndex = 11
        Me.lblRefCancelacion.Tag = ""
        Me.lblRefCancelacion.Text = "Ref. Cancelación"
        '
        'txtRefCancelacion
        '
        Me.txtRefCancelacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtRefCancelacion.Location = New System.Drawing.Point(27, 107)
        Me.txtRefCancelacion.Name = "txtRefCancelacion"
        Me.txtRefCancelacion.Size = New System.Drawing.Size(341, 21)
        Me.txtRefCancelacion.TabIndex = 1
        '
        'lblCancelacionAnt
        '
        Me.lblCancelacionAnt.Location = New System.Drawing.Point(24, 58)
        Me.lblCancelacionAnt.Name = "lblCancelacionAnt"
        Me.lblCancelacionAnt.Size = New System.Drawing.Size(113, 13)
        Me.lblCancelacionAnt.TabIndex = 9
        Me.lblCancelacionAnt.Tag = ""
        Me.lblCancelacionAnt.Text = "Fecha Cancelación"
        '
        'cbxFechaCancelacion
        '
        Me.cbxFechaCancelacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaCancelacion.Location = New System.Drawing.Point(142, 55)
        Me.cbxFechaCancelacion.Name = "cbxFechaCancelacion"
        Me.cbxFechaCancelacion.Size = New System.Drawing.Size(112, 21)
        Me.cbxFechaCancelacion.TabIndex = 0
        '
        'chkAgruparBanco
        '
        Me.chkAgruparBanco.Location = New System.Drawing.Point(27, 121)
        Me.chkAgruparBanco.Name = "chkAgruparBanco"
        Me.chkAgruparBanco.Size = New System.Drawing.Size(178, 23)
        Me.chkAgruparBanco.TabIndex = 2
        Me.chkAgruparBanco.Text = "Agrupar apunte de Banco"
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.cmbCancelar)
        Me.pnlBottom.Controls.Add(Me.cmbAceptar)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 330)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(391, 55)
        Me.pnlBottom.TabIndex = 2
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCancelar.Location = New System.Drawing.Point(199, 12)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 31)
        Me.cmbCancelar.TabIndex = 1
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAceptar.Location = New System.Drawing.Point(103, 12)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 31)
        Me.cmbAceptar.TabIndex = 0
        Me.cmbAceptar.Text = "Aceptar"
        '
        'FraContabilizarCobros
        '
        Me.FraContabilizarCobros.Controls.Add(Me.lblcboBancoPropio)
        Me.FraContabilizarCobros.Controls.Add(Me.ulblcboBancoPropio)
        Me.FraContabilizarCobros.Controls.Add(Me.cboBancoPropio)
        Me.FraContabilizarCobros.Controls.Add(Me.chkGenerarAsientoConGastos)
        Me.FraContabilizarCobros.Controls.Add(Me.chkAgruparBanco)
        Me.FraContabilizarCobros.Controls.Add(Me.lbltxtDescApunte)
        Me.FraContabilizarCobros.Controls.Add(Me.txtDescApunte)
        Me.FraContabilizarCobros.Controls.Add(Me.chkContabilizarCobros)
        Me.FraContabilizarCobros.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraContabilizarCobros.Location = New System.Drawing.Point(0, 179)
        Me.FraContabilizarCobros.Name = "FraContabilizarCobros"
        Me.FraContabilizarCobros.Size = New System.Drawing.Size(391, 151)
        Me.FraContabilizarCobros.TabIndex = 1
        Me.FraContabilizarCobros.TabStop = False
        '
        'chkGenerarAsientoConGastos
        '
        Me.chkGenerarAsientoConGastos.Location = New System.Drawing.Point(175, 16)
        Me.chkGenerarAsientoConGastos.Name = "chkGenerarAsientoConGastos"
        Me.chkGenerarAsientoConGastos.Size = New System.Drawing.Size(209, 23)
        Me.chkGenerarAsientoConGastos.TabIndex = 42
        Me.chkGenerarAsientoConGastos.Text = "Contabilizar Cobros + Gastos"
        '
        'lbltxtDescApunte
        '
        Me.lbltxtDescApunte.Location = New System.Drawing.Point(24, 78)
        Me.lbltxtDescApunte.Name = "lbltxtDescApunte"
        Me.lbltxtDescApunte.Size = New System.Drawing.Size(83, 13)
        Me.lbltxtDescApunte.TabIndex = 18
        Me.lbltxtDescApunte.Tag = "IdRec=4596;"
        Me.lbltxtDescApunte.Text = "Desc. Apunte"
        '
        'txtDescApunte
        '
        Me.txtDescApunte.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescApunte.Location = New System.Drawing.Point(27, 94)
        Me.txtDescApunte.Name = "txtDescApunte"
        Me.txtDescApunte.Size = New System.Drawing.Size(341, 21)
        Me.txtDescApunte.TabIndex = 1
        '
        'chkContabilizarCobros
        '
        Me.chkContabilizarCobros.Checked = True
        Me.chkContabilizarCobros.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkContabilizarCobros.Location = New System.Drawing.Point(27, 16)
        Me.chkContabilizarCobros.Name = "chkContabilizarCobros"
        Me.chkContabilizarCobros.Size = New System.Drawing.Size(136, 23)
        Me.chkContabilizarCobros.TabIndex = 0
        Me.chkContabilizarCobros.Text = "Contabilizar Cobros"
        '
        'lblcboBancoPropio
        '
        Me.lblcboBancoPropio.Location = New System.Drawing.Point(25, 49)
        Me.lblcboBancoPropio.Name = "lblcboBancoPropio"
        Me.lblcboBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblcboBancoPropio.TabIndex = 44
        Me.lblcboBancoPropio.Tag = "IdRec=4613;"
        Me.lblcboBancoPropio.Text = "Banco Propio"
        '
        'ulblcboBancoPropio
        '
        Me.ulblcboBancoPropio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cboBancoPropio, "DescBancoPropio", True))
        Me.ulblcboBancoPropio.Location = New System.Drawing.Point(195, 45)
        Me.ulblcboBancoPropio.Name = "ulblcboBancoPropio"
        Me.ulblcboBancoPropio.Size = New System.Drawing.Size(187, 22)
        Me.ulblcboBancoPropio.TabIndex = 45
        '
        'cboBancoPropio
        '
        cboBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("cboBancoPropio_DesignTimeLayout.LayoutString")
        Me.cboBancoPropio.DesignTimeLayout = cboBancoPropio_DesignTimeLayout
        Me.cboBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.cboBancoPropio.EntityName = "BancoPropio"
        Me.cboBancoPropio.Location = New System.Drawing.Point(108, 45)
        Me.cboBancoPropio.Name = "cboBancoPropio"
        Me.cboBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.cboBancoPropio.SelectedIndex = -1
        Me.cboBancoPropio.SelectedItem = Nothing
        Me.cboBancoPropio.Size = New System.Drawing.Size(84, 21)
        Me.cboBancoPropio.TabIndex = 43
        Me.cboBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'frmCancelarAnticipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 385)
        Me.Controls.Add(Me.FraCancelacion)
        Me.Controls.Add(Me.FraContabilizarCobros)
        Me.Controls.Add(Me.pnlBottom)
        Me.Name = "frmCancelarAnticipo"
        Me.Text = "Cancelar Anticipo"
        CType(Me.cboSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        CType(Me.cboBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FraCancelacion As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblDescApunteAnticipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescApunteAnticipo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblRefCancelacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtRefCancelacion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCancelacionAnt As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaCancelacion As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents pnlBottom As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents chkAgruparBanco As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents FraContabilizarCobros As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents chkContabilizarCobros As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lbltxtDescApunte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescApunte As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents chkGenerarAsientoConGastos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblcboSituacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblccboSituacion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cboSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblcboBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulblcboBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cboBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
End Class
