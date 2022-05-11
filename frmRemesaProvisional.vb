Public Class frmRemesaProvisional
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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents WLFrame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents fwiFechaNeg As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblfwiFechaNeg As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblcfwiBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblfwiNRemesa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtIDRemesa As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiTipoRemesa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiTipoRemesa As Solmicro.Expertis.Engine.UI.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim fwiTipoRemesa_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemesaProvisional))
        Dim fwiBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblfwiNRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDRemesa = New Solmicro.Expertis.Engine.UI.TextBox
        Me.WLFrame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiTipoRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTipoRemesa = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.fwiFechaNeg = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaNeg = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblcfwiBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.Panel1.suspendlayout()
        Me.Panel2.suspendlayout()
        Me.WLFrame1.SuspendLayout()
        CType(Me.fwiTipoRemesa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fwiBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 40)
        Me.Panel1.TabIndex = 12
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(86, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 25)
        Me.cmbAceptar.TabIndex = 3
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(186, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 25)
        Me.cmbCancelar.TabIndex = 0
        Me.cmbCancelar.Text = "Cancelar"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblfwiNRemesa)
        Me.Panel2.Controls.Add(Me.txtIDRemesa)
        Me.Panel2.Controls.Add(Me.WLFrame1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(352, 134)
        Me.Panel2.TabIndex = 13
        '
        'lblfwiNRemesa
        '
        Me.lblfwiNRemesa.Location = New System.Drawing.Point(92, 11)
        Me.lblfwiNRemesa.Name = "lblfwiNRemesa"
        Me.lblfwiNRemesa.Size = New System.Drawing.Size(76, 13)
        Me.lblfwiNRemesa.TabIndex = 22
        Me.lblfwiNRemesa.Tag = "IdRec=4792;"
        Me.lblfwiNRemesa.Text = "Nº Remesa:"
        '
        'txtIDRemesa
        '
        Me.txtIDRemesa.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDRemesa.Enabled = False
        Me.txtIDRemesa.Location = New System.Drawing.Point(170, 11)
        Me.txtIDRemesa.Name = "txtIDRemesa"
        Me.txtIDRemesa.Size = New System.Drawing.Size(80, 21)
        Me.txtIDRemesa.TabIndex = 21
        '
        'WLFrame1
        '
        Me.WLFrame1.Controls.Add(Me.lblfwiTipoRemesa)
        Me.WLFrame1.Controls.Add(Me.fwiTipoRemesa)
        Me.WLFrame1.Controls.Add(Me.fwiFechaNeg)
        Me.WLFrame1.Controls.Add(Me.lblfwiFechaNeg)
        Me.WLFrame1.Controls.Add(Me.lblfwiBancoPropio)
        Me.WLFrame1.Controls.Add(Me.fwiBancoPropio)
        Me.WLFrame1.Controls.Add(Me.lblcfwiBancoPropio)
        Me.WLFrame1.Location = New System.Drawing.Point(7, 32)
        Me.WLFrame1.Name = "WLFrame1"
        Me.WLFrame1.Size = New System.Drawing.Size(341, 96)
        Me.WLFrame1.TabIndex = 13
        Me.WLFrame1.TabStop = False
        Me.WLFrame1.Tag = "IdRec=0;"
        '
        'lblfwiTipoRemesa
        '
        Me.lblfwiTipoRemesa.Location = New System.Drawing.Point(5, 17)
        Me.lblfwiTipoRemesa.Name = "lblfwiTipoRemesa"
        Me.lblfwiTipoRemesa.Size = New System.Drawing.Size(81, 13)
        Me.lblfwiTipoRemesa.TabIndex = 25
        Me.lblfwiTipoRemesa.Tag = ""
        Me.lblfwiTipoRemesa.Text = "Tipo Remesa"
        '
        'fwiTipoRemesa
        '
        fwiTipoRemesa_DesignTimeLayout.LayoutString = resources.GetString("fwiTipoRemesa_DesignTimeLayout.LayoutString")
        Me.fwiTipoRemesa.DesignTimeLayout = fwiTipoRemesa_DesignTimeLayout
        Me.fwiTipoRemesa.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTipoRemesa.Location = New System.Drawing.Point(123, 16)
        Me.fwiTipoRemesa.Name = "fwiTipoRemesa"
        Me.fwiTipoRemesa.SelectedIndex = -1
        Me.fwiTipoRemesa.SelectedItem = Nothing
        Me.fwiTipoRemesa.Size = New System.Drawing.Size(121, 21)
        Me.fwiTipoRemesa.TabIndex = 0
        '
        'fwiFechaNeg
        '
        Me.fwiFechaNeg.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaNeg.Location = New System.Drawing.Point(123, 64)
        Me.fwiFechaNeg.Name = "fwiFechaNeg"
        Me.fwiFechaNeg.Size = New System.Drawing.Size(112, 21)
        Me.fwiFechaNeg.TabIndex = 2
        '
        'lblfwiFechaNeg
        '
        Me.lblfwiFechaNeg.Location = New System.Drawing.Point(5, 65)
        Me.lblfwiFechaNeg.Name = "lblfwiFechaNeg"
        Me.lblfwiFechaNeg.Size = New System.Drawing.Size(112, 13)
        Me.lblfwiFechaNeg.TabIndex = 22
        Me.lblfwiFechaNeg.Tag = ""
        Me.lblfwiFechaNeg.Text = "Fecha Negociación"
        '
        'lblfwiBancoPropio
        '
        Me.lblfwiBancoPropio.Location = New System.Drawing.Point(5, 41)
        Me.lblfwiBancoPropio.Name = "lblfwiBancoPropio"
        Me.lblfwiBancoPropio.Size = New System.Drawing.Size(92, 13)
        Me.lblfwiBancoPropio.TabIndex = 23
        Me.lblfwiBancoPropio.Tag = ""
        Me.lblfwiBancoPropio.Text = "Banco Remesa"
        '
        'fwiBancoPropio
        '
        fwiBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("fwiBancoPropio_DesignTimeLayout.LayoutString")
        Me.fwiBancoPropio.DesignTimeLayout = fwiBancoPropio_DesignTimeLayout
        Me.fwiBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.fwiBancoPropio.EntityName = "BancoPropio"
        Me.fwiBancoPropio.Location = New System.Drawing.Point(123, 40)
        Me.fwiBancoPropio.Name = "fwiBancoPropio"
        Me.fwiBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.fwiBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.fwiBancoPropio.SelectedIndex = -1
        Me.fwiBancoPropio.SelectedItem = Nothing
        Me.fwiBancoPropio.Size = New System.Drawing.Size(53, 21)
        Me.fwiBancoPropio.TabIndex = 1
        Me.fwiBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'lblcfwiBancoPropio
        '
        Me.TryDataBinding(lblcfwiBancoPropio, New System.Windows.Forms.Binding("Text", Me.fwiBancoPropio, "DescBancoPropio", True))
        Me.lblcfwiBancoPropio.Location = New System.Drawing.Point(179, 40)
        Me.lblcfwiBancoPropio.Name = "lblcfwiBancoPropio"
        Me.lblcfwiBancoPropio.Size = New System.Drawing.Size(157, 21)
        Me.lblcfwiBancoPropio.TabIndex = 24
        '
        'frmRemesaProvisional
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(352, 174)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmRemesaProvisional"
        Me.Text = "Datos de la Remesa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.WLFrame1.ResumeLayout(False)
        Me.WLFrame1.PerformLayout()
        CType(Me.fwiTipoRemesa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fwiBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Public Sub AbrirRemesaProvisional(ByVal dtCobro As DataTable, Optional ByVal blnEspecial As Boolean = False)
        mdtCobros = dtCobro
        Me.ShowDialog()
    End Sub

    Private Sub frmRemesaProvisional_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intIDRemesa As Integer = ExpertisApp.ExecuteTask(Of Object, Integer)(AddressOf Cobro.NuevoIdRemesa, Nothing)
        txtIDRemesa.Text = IIf(intIDRemesa = -1, String.Empty, intIDRemesa)

        Me.fwiTipoRemesa.DataSource = New EnumData("enumTipoRemesa")
        fwiTipoRemesa.Value = CInt(enumTipoRemesa.RemesaAlCobro)
    End Sub

#End Region

    Private Function ComprobarObligatorios() As Boolean
        If Engine.Length(fwiTipoRemesa.Value) = 0 Or Engine.Length(fwiFechaNeg.Value) = 0 Or Engine.Length(fwiBancoPropio.Value) = 0 Then
            ExpertisApp.GenerateMessage("Hay campos obligatorios sin rellenar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComprobarObligatorios = False
        ElseIf Engine.Length(txtIDRemesa.Text) = 0 Then
            ExpertisApp.GenerateMessage("No hay ningun contador establecido para las Remesas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComprobarObligatorios = True
        Else
            ComprobarObligatorios = True
        End If
    End Function

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If ComprobarObligatorios() Then
            Me.Cursor = Cursors.WaitCursor

            'Creamos la cadena con los datos de la cabecera
            Dim dtBP As DataTable = New BancoPropio().SelOnPrimaryKey(fwiBancoPropio.Value)
            If Not dtBP Is Nothing AndAlso dtBP.Rows.Count > 0 Then
                If Engine.Length(dtBP.Rows(0)("NCuenta")) > 0 Then
                    Dim strFormCab As String = "NomCedente=" & ExpertisApp.EnterpriseName & "; "
                    strFormCab = strFormCab & "TipoRemesa=" & fwiTipoRemesa.Value & ";"
                    strFormCab = strFormCab & "NCuenta=" & dtBP.Rows(0)("NCuenta") & "; "
                    strFormCab = strFormCab & "DescBancoPropio=" & dtBP.Rows(0)("DescBancoPropio") & "; "
                    strFormCab = strFormCab & "FechaNeg=" & fwiFechaNeg.Value & "; "
                    strFormCab = strFormCab & "NRemesa=" & txtIDRemesa.Text

                    mstrReportFormulas = strFormCab

                    'Creamos el rcs con los datos de las lineas de Cobro
                    CrearRsInformeLineas(fwiFechaNeg.Value, fwiBancoPropio.Value, fwiTipoRemesa.Value)

                    'ABRIMOS EL INFORME
                    Dim rp As New Report("REMPR")
                    rp.Formulas("NomCedente").Text = ExpertisApp.EnterpriseName
                    rp.Formulas("TipoRemesa").Text = fwiTipoRemesa.Value
                    rp.Formulas("NCuenta").Text = dtBP.Rows(0)("NCuenta")
                    rp.Formulas("DescBancoPropio").Text = dtBP.Rows(0)("DescBancoPropio") & String.Empty
                    rp.Formulas("FechaNeg").Text = fwiFechaNeg.Value
                    rp.Formulas("NRemesa").Text = txtIDRemesa.Text

                    rp.DataSource = mdtInforme
                    ExpertisApp.OpenReport(rp)

                    Me.Close()
                    Me.Cursor = Cursors.Arrow
                Else
                    ExpertisApp.GenerateMessage("El Número de Cuenta del Banco Propio: |, no se ha configurado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, dtBP.Rows(0)("DescBancoPropio") & String.Empty)
                End If
            End If
        End If

        intAccion = enumAccion.RemesaProvisional

        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

End Class
