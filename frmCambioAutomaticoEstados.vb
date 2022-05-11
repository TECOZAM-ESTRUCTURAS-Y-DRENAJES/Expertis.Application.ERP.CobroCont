Public Class frmCambioAutomaticoEstados
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
    Friend WithEvents cmdNoNoNegociado As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdSiNoNegociado As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblNoNegociado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxNoNegociado As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents pnlBottom As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlMain As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlNegociado As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmdSiNegociado As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdNoNegociado As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblNegociado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxNegociado As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents pnlVencido As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmdSiVencido As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdNoVencido As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblVencido As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxVencido As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents GridNoNegociado As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlNoNegTop As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents GridNegociado As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlNegTop As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents GridVencido As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlVencidoTop As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlNoNegociado As Solmicro.Expertis.Engine.UI.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridNoNegociado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVencido_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridNegociado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambioAutomaticoEstados))
        Me.cmdNoNoNegociado = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdSiNoNegociado = New Solmicro.Expertis.Engine.UI.Button
        Me.lblNoNegociado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxNoNegociado = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.pnlBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlMain = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlNoNegociado = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlNegociado = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdSiNegociado = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdNoNegociado = New Solmicro.Expertis.Engine.UI.Button
        Me.lblNegociado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxNegociado = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.pnlVencido = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdSiVencido = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdNoVencido = New Solmicro.Expertis.Engine.UI.Button
        Me.lblVencido = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxVencido = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.pnlNoNegTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridNoNegociado = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlVencidoTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridVencido = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlNegTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridNegociado = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlBottom.suspendlayout()
        Me.pnlMain.suspendlayout()
        Me.pnlNoNegociado.suspendlayout()
        Me.pnlNegociado.suspendlayout()
        Me.pnlVencido.suspendlayout()
        Me.pnlNoNegTop.suspendlayout()
        CType(Me.GridNoNegociado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVencidoTop.suspendlayout()
        CType(Me.GridVencido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNegTop.suspendlayout()
        CType(Me.GridNegociado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdNoNoNegociado
        '
        Me.cmdNoNoNegociado.Location = New System.Drawing.Point(26, 21)
        Me.cmdNoNoNegociado.Name = "cmdNoNoNegociado"
        Me.cmdNoNoNegociado.Size = New System.Drawing.Size(24, 19)
        Me.cmdNoNoNegociado.TabIndex = 1
        Me.cmdNoNoNegociado.Text = "No"
        '
        'cmdSiNoNegociado
        '
        Me.cmdSiNoNegociado.Location = New System.Drawing.Point(3, 21)
        Me.cmdSiNoNegociado.Name = "cmdSiNoNegociado"
        Me.cmdSiNoNegociado.Size = New System.Drawing.Size(24, 19)
        Me.cmdSiNoNegociado.TabIndex = 0
        Me.cmdSiNoNegociado.Text = "Si"
        '
        'lblNoNegociado
        '
        Me.lblNoNegociado.Location = New System.Drawing.Point(71, 17)
        Me.lblNoNegociado.Name = "lblNoNegociado"
        Me.lblNoNegociado.Size = New System.Drawing.Size(465, 13)
        Me.lblNoNegociado.TabIndex = 15
        Me.lblNoNegociado.Tag = "IdRec=4790;"
        Me.lblNoNegociado.Text = "Pasarán de No Negociado a Vencido todos los Cobros con Fecha Vencimiento < "
        '
        'cbxNoNegociado
        '
        Me.cbxNoNegociado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxNoNegociado.Location = New System.Drawing.Point(538, 13)
        Me.cbxNoNegociado.Name = "cbxNoNegociado"
        Me.cbxNoNegociado.Size = New System.Drawing.Size(120, 21)
        Me.cbxNoNegociado.TabIndex = 16
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(240, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(91, 26)
        Me.cmdAceptar.TabIndex = 19
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(336, 12)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(91, 26)
        Me.cmdCancelar.TabIndex = 20
        Me.cmdCancelar.Text = "Cancelar"
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.cmdAceptar)
        Me.pnlBottom.Controls.Add(Me.cmdCancelar)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 467)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(667, 45)
        Me.pnlBottom.TabIndex = 21
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlNegociado)
        Me.pnlMain.Controls.Add(Me.pnlVencido)
        Me.pnlMain.Controls.Add(Me.pnlNoNegociado)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(667, 467)
        Me.pnlMain.TabIndex = 22
        '
        'pnlNoNegociado
        '
        Me.pnlNoNegociado.Controls.Add(Me.GridNoNegociado)
        Me.pnlNoNegociado.Controls.Add(Me.pnlNoNegTop)
        Me.pnlNoNegociado.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNoNegociado.Location = New System.Drawing.Point(0, 0)
        Me.pnlNoNegociado.Name = "pnlNoNegociado"
        Me.pnlNoNegociado.Size = New System.Drawing.Size(667, 162)
        Me.pnlNoNegociado.TabIndex = 0
        '
        'pnlNegociado
        '
        Me.pnlNegociado.Controls.Add(Me.GridNegociado)
        Me.pnlNegociado.Controls.Add(Me.pnlNegTop)
        Me.pnlNegociado.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNegociado.Location = New System.Drawing.Point(0, 316)
        Me.pnlNegociado.Name = "pnlNegociado"
        Me.pnlNegociado.Size = New System.Drawing.Size(667, 152)
        Me.pnlNegociado.TabIndex = 5
        Me.pnlNegociado.Visible = False
        '
        'cmdSiNegociado
        '
        Me.cmdSiNegociado.Location = New System.Drawing.Point(2, 21)
        Me.cmdSiNegociado.Name = "cmdSiNegociado"
        Me.cmdSiNegociado.Size = New System.Drawing.Size(24, 19)
        Me.cmdSiNegociado.TabIndex = 7
        Me.cmdSiNegociado.Text = "Si"
        '
        'cmdNoNegociado
        '
        Me.cmdNoNegociado.Location = New System.Drawing.Point(25, 21)
        Me.cmdNoNegociado.Name = "cmdNoNegociado"
        Me.cmdNoNegociado.Size = New System.Drawing.Size(24, 19)
        Me.cmdNoNegociado.TabIndex = 8
        Me.cmdNoNegociado.Text = "No"
        '
        'lblNegociado
        '
        Me.lblNegociado.Location = New System.Drawing.Point(51, 13)
        Me.lblNegociado.Name = "lblNegociado"
        Me.lblNegociado.Size = New System.Drawing.Size(480, 13)
        Me.lblNegociado.TabIndex = 12
        Me.lblNegociado.Tag = "IdRec=4788;"
        Me.lblNegociado.Text = "Pasarán de Negociado/Descontado a Cobrado todos los Cobros con Fecha Venc. <"
        '
        'cbxNegociado
        '
        Me.cbxNegociado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxNegociado.Location = New System.Drawing.Point(533, 9)
        Me.cbxNegociado.Name = "cbxNegociado"
        Me.cbxNegociado.Size = New System.Drawing.Size(120, 21)
        Me.cbxNegociado.TabIndex = 18
        '
        'pnlVencido
        '
        Me.pnlVencido.Controls.Add(Me.GridVencido)
        Me.pnlVencido.Controls.Add(Me.pnlVencidoTop)
        Me.pnlVencido.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVencido.Location = New System.Drawing.Point(0, 162)
        Me.pnlVencido.Name = "pnlVencido"
        Me.pnlVencido.Size = New System.Drawing.Size(667, 154)
        Me.pnlVencido.TabIndex = 4
        Me.pnlVencido.Visible = False
        '
        'cmdSiVencido
        '
        Me.cmdSiVencido.Location = New System.Drawing.Point(2, 20)
        Me.cmdSiVencido.Name = "cmdSiVencido"
        Me.cmdSiVencido.Size = New System.Drawing.Size(24, 19)
        Me.cmdSiVencido.TabIndex = 4
        Me.cmdSiVencido.Text = "Si"
        '
        'cmdNoVencido
        '
        Me.cmdNoVencido.Location = New System.Drawing.Point(25, 20)
        Me.cmdNoVencido.Name = "cmdNoVencido"
        Me.cmdNoVencido.Size = New System.Drawing.Size(24, 19)
        Me.cmdNoVencido.TabIndex = 5
        Me.cmdNoVencido.Text = "No"
        '
        'lblVencido
        '
        Me.lblVencido.Location = New System.Drawing.Point(90, 14)
        Me.lblVencido.Name = "lblVencido"
        Me.lblVencido.Size = New System.Drawing.Size(441, 13)
        Me.lblVencido.TabIndex = 14
        Me.lblVencido.Tag = ""
        Me.lblVencido.Text = "Pasarán de Vencido a Impagado todos los Cobros con Fecha Vencimiento <"
        '
        'cbxVencido
        '
        Me.cbxVencido.DisabledBackColor = System.Drawing.Color.White
        Me.cbxVencido.Location = New System.Drawing.Point(537, 10)
        Me.cbxVencido.Name = "cbxVencido"
        Me.cbxVencido.Size = New System.Drawing.Size(120, 21)
        Me.cbxVencido.TabIndex = 17
        '
        'pnlNoNegTop
        '
        Me.pnlNoNegTop.Controls.Add(Me.lblNoNegociado)
        Me.pnlNoNegTop.Controls.Add(Me.cmdSiNoNegociado)
        Me.pnlNoNegTop.Controls.Add(Me.cbxNoNegociado)
        Me.pnlNoNegTop.Controls.Add(Me.cmdNoNoNegociado)
        Me.pnlNoNegTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNoNegTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlNoNegTop.Name = "pnlNoNegTop"
        Me.pnlNoNegTop.Size = New System.Drawing.Size(667, 40)
        Me.pnlNoNegTop.TabIndex = 17
        '
        'GridNoNegociado
        '
        Me.GridNoNegociado.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridNoNegociado.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridNoNegociado_DesignTimeLayout.LayoutString = resources.GetString("GridNoNegociado_DesignTimeLayout.LayoutString")
        Me.GridNoNegociado.DesignTimeLayout = GridNoNegociado_DesignTimeLayout
        Me.GridNoNegociado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridNoNegociado.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridNoNegociado.EntityName = "Cobro"
        Me.GridNoNegociado.FrozenColumns = 2
        Me.GridNoNegociado.Location = New System.Drawing.Point(0, 40)
        Me.GridNoNegociado.Name = "GridNoNegociado"
        Me.GridNoNegociado.PrimaryDataFields = Nothing
        Me.GridNoNegociado.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridNoNegociado.SecondaryDataFields = Nothing
        Me.GridNoNegociado.Size = New System.Drawing.Size(667, 122)
        Me.GridNoNegociado.TabIndex = 18
        Me.GridNoNegociado.Tag = "IdRec=4787:4711:4719:4713:4715:4712:4710:;"
        Me.GridNoNegociado.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridNoNegociado.ViewName = "vCtlCICobroContCambioEstadoAutom"
        '
        'pnlVencidoTop
        '
        Me.pnlVencidoTop.Controls.Add(Me.lblVencido)
        Me.pnlVencidoTop.Controls.Add(Me.cmdSiVencido)
        Me.pnlVencidoTop.Controls.Add(Me.cbxVencido)
        Me.pnlVencidoTop.Controls.Add(Me.cmdNoVencido)
        Me.pnlVencidoTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVencidoTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlVencidoTop.Name = "pnlVencidoTop"
        Me.pnlVencidoTop.Size = New System.Drawing.Size(667, 40)
        Me.pnlVencidoTop.TabIndex = 18
        '
        'GridVencido
        '
        Me.GridVencido.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridVencido.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridVencido_DesignTimeLayout.LayoutString = resources.GetString("GridVencido_DesignTimeLayout.LayoutString")
        Me.GridVencido.DesignTimeLayout = GridVencido_DesignTimeLayout
        Me.GridVencido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVencido.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridVencido.EntityName = "Cobro"
        Me.GridVencido.FrozenColumns = 2
        Me.GridVencido.Location = New System.Drawing.Point(0, 40)
        Me.GridVencido.Name = "GridVencido"
        Me.GridVencido.PrimaryDataFields = Nothing
        Me.GridVencido.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridVencido.SecondaryDataFields = Nothing
        Me.GridVencido.Size = New System.Drawing.Size(667, 114)
        Me.GridVencido.TabIndex = 19
        Me.GridVencido.Tag = "IdRec=4787:4711:4719:4713:4715:4712:4710:;"
        Me.GridVencido.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridVencido.ViewName = "vCtlCICobroContCambioEstadoAutom"
        '
        'pnlNegTop
        '
        Me.pnlNegTop.Controls.Add(Me.lblNegociado)
        Me.pnlNegTop.Controls.Add(Me.cmdSiNegociado)
        Me.pnlNegTop.Controls.Add(Me.cbxNegociado)
        Me.pnlNegTop.Controls.Add(Me.cmdNoNegociado)
        Me.pnlNegTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNegTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlNegTop.Name = "pnlNegTop"
        Me.pnlNegTop.Size = New System.Drawing.Size(667, 40)
        Me.pnlNegTop.TabIndex = 19
        '
        'GridNegociado
        '
        Me.GridNegociado.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridNegociado_DesignTimeLayout.LayoutString = resources.GetString("GridNegociado_DesignTimeLayout.LayoutString")
        Me.GridNegociado.DesignTimeLayout = GridNegociado_DesignTimeLayout
        Me.GridNegociado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridNegociado.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridNegociado.EntityName = "Cobro"
        Me.GridNegociado.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridNegociado.FrozenColumns = 2
        Me.GridNegociado.Location = New System.Drawing.Point(0, 40)
        Me.GridNegociado.Name = "GridNegociado"
        Me.GridNegociado.PrimaryDataFields = Nothing
        Me.GridNegociado.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridNegociado.SecondaryDataFields = Nothing
        Me.GridNegociado.Size = New System.Drawing.Size(667, 112)
        Me.GridNegociado.TabIndex = 20
        Me.GridNegociado.Tag = "IdRec=4787:4711:4719:4713:4715:4712:4710:;"
        Me.GridNegociado.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridNegociado.ViewName = "vCtlCICobroContCambioEstadoAutom"
        '
        'frmCambioAutomaticoEstados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(667, 512)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCambioAutomaticoEstados"
        Me.Text = "Aviso"
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlNoNegociado.ResumeLayout(False)
        Me.pnlNegociado.ResumeLayout(False)
        Me.pnlVencido.ResumeLayout(False)
        Me.pnlNoNegTop.ResumeLayout(False)
        Me.pnlNoNegTop.PerformLayout()
        CType(Me.GridNoNegociado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVencidoTop.ResumeLayout(False)
        Me.pnlVencidoTop.PerformLayout()
        CType(Me.GridVencido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNegTop.ResumeLayout(False)
        Me.pnlNegTop.PerformLayout()
        CType(Me.GridNegociado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mblnAutoNoNeg As Boolean    'Indica si el cambio No Negociado a Vencido es Automatico
    Private mblnAutoVenc As Boolean     'Indica si el cambio Vencido a Impagado es Automatico
    Private mblnAutoNeg As Boolean      'Indica si el cambio Negociado/Descontado a Cobrado es Automatico
    Private mblnOrdenDesc As Boolean     'Indica si el grid se ha ordenado ascendentemente o descendentemente
    Private mintDiasSeg1 As Integer
    Private mintDiasSeg2 As Integer
    Private mintDiasSeg3 As Integer
    Private mblnLoad As Boolean = True

    Public mstrComentarioRemesa As String
    Private mIDCobros(-1) As Integer
    Public ReadOnly Property IDCobros() As Integer()
        Get
            Return mIDCobros
        End Get
    End Property

#Region " Load "

    Private Sub frmCamAutEstados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mblnLoad = False
    End Sub

    Public Function AbrirCambioAutomaticoEstados() As DialogResult
        'Comprueba si se permite el cambio automatico, en ese caso se colocan los grids;
        'en caso contrario, no se carga el formulario y se muestra un mensaje de error
        mblnLoad = True
        LoadERPData()
        Dim intNumGrids As Integer = ComprobarPermisos()
        If intNumGrids > 0 Then
            ColocarGrids(intNumGrids)
            CargarGrids()

            Me.ShowDialog()
            Return Me.DialogResult
        Else
            ExpertisApp.GenerateMessage("No se permiten cambios automaticos de estado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return Windows.Forms.DialogResult.Cancel
        End If
    End Function

    Public Function ComprobarPermisos() As Integer
        Dim intNumGrids As Integer

        If mblnAutoNoNeg Then intNumGrids = intNumGrids + 1
        If mblnAutoVenc Then intNumGrids = intNumGrids + 1
        If mblnAutoNeg Then intNumGrids = intNumGrids + 1

        Return intNumGrids
    End Function

    Private Sub LoadERPData()
        Dim P As New Parametro
        Dim StCambios As Parametro.StCambiosAut = P.CambiosAutomaticos
        Dim StDias As Parametro.StDiasSeg = P.DiasSeguridad

        mblnAutoNoNeg = StCambios.CambioAut1
        mblnAutoVenc = StCambios.CambioAut2
        mblnAutoNeg = StCambios.CambioAut3

        mintDiasSeg1 = StDias.DiasSeg1
        mintDiasSeg2 = StDias.DiasSeg2
        mintDiasSeg3 = StDias.DiasSeg3
    End Sub

    Private Sub ColocarGrids(ByVal intNumGrids As Integer)
        If intNumGrids = 2 Then
            If mblnAutoNoNeg And mblnAutoVenc Then
                cmdSiNegociado.Enabled = False
                cmdNoNegociado.Enabled = False
            End If
            If mblnAutoNeg And mblnAutoVenc Then
                cmdSiNoNegociado.Enabled = False
                cmdNoNoNegociado.Enabled = False
            End If
            If mblnAutoNoNeg And mblnAutoNeg Then
                cmdSiVencido.Enabled = False
                cmdNoVencido.Enabled = False
            End If
        End If
    End Sub

    Private Sub CargarGrids(Optional ByVal DteFechaNoNeg As Date = cnMinDate, Optional ByVal DteFechaVenc As Date = cnMinDate, Optional ByVal DteFechaNeg As Date = cnMinDate)
        'Inicializamos los grid y cargamos los datos de cada uno
        Dim dtmFechaSeg As Date

        Dim Cont As Integer = 0
        If mblnAutoNeg Then Cont += 1
        If mblnAutoVenc Then Cont += 1
        If mblnAutoNoNeg Then Cont += 1

        Dim Altura As Double
        If Cont > 0 Then
            Altura = Me.pnlMain.Height / Cont
        End If

        If mblnAutoNoNeg Then
            If DteFechaNoNeg <> cnMinDate Then
                dtmFechaSeg = DteFechaNoNeg
            Else
                dtmFechaSeg = DateAdd(DateInterval.Day, -mintDiasSeg1, Date.Today)
                cbxNoNegociado.Value = dtmFechaSeg
            End If

            With GridNoNegociado
                Dim filNoNegociado As New Filter

                filNoNegociado.Add(New DateFilterItem("FechaVencimiento", FilterOperator.LessThan, dtmFechaSeg))
                filNoNegociado.Add(New NumberFilterItem("Situacion", enumCobroSituacion.NoNegociado))

                Dim DtNeg As DataTable = New BE.DataEngine().Filter("vCtlCICobroContCambioEstadoAutom", filNoNegociado)
                .DataSource = DtNeg
                .Filter = filNoNegociado
            End With
            'MarcarTodos(GridNoNegociado)
        End If
        Me.pnlNoNegociado.Visible = mblnAutoNoNeg
        If mblnAutoNoNeg Then Me.pnlNoNegociado.Height = Altura

        If mblnAutoVenc Then
            If DteFechaVenc <> cnMinDate Then
                dtmFechaSeg = DteFechaVenc
            Else
                dtmFechaSeg = DateAdd(DateInterval.Day, -mintDiasSeg2, Date.Today)
                cbxVencido.Value = dtmFechaSeg
            End If

            With GridVencido
                Dim filVencido As New Filter
                filVencido.Add(New DateFilterItem("FechaVencimiento", FilterOperator.LessThan, dtmFechaSeg))
                filVencido.Add(New NumberFilterItem("Situacion", enumCobroSituacion.Vencido))


                Dim DtNeg As DataTable = New BE.DataEngine().Filter("vCtlCICobroContCambioEstadoAutom", filVencido)
                .DataSource = DtNeg
                .Filter = filVencido

            End With
            '  MarcarTodos(GridVencido)
        End If
        Me.pnlVencido.Visible = mblnAutoVenc
        If mblnAutoVenc Then Me.pnlVencido.Height = Altura


        If mblnAutoNeg Then
            If DteFechaNeg <> cnMinDate Then
                dtmFechaSeg = DteFechaNeg
            Else
                dtmFechaSeg = DateAdd(DateInterval.Day, -mintDiasSeg3, Date.Today)
                cbxNegociado.Value = dtmFechaSeg
            End If

            With GridNegociado
                Dim filNegociado As New Filter
                filNegociado.Add(New DateFilterItem("FechaVencimiento", FilterOperator.LessThan, dtmFechaSeg))
                filNegociado.Add(New BooleanFilterItem("Contabilizado", True))
                filNegociado.Add(New BooleanFilterItem("Liquidado", False))

                Dim oFilterOR As New Filter(FilterUnionOperator.Or)
                oFilterOR.Add(New NumberFilterItem("Situacion", enumCobroSituacion.Negociado))
                oFilterOR.Add(New NumberFilterItem("Situacion", enumCobroSituacion.Descontado))

                filNegociado.Add(oFilterOR)

                Dim DtNeg As DataTable = New BE.DataEngine().Filter("vCtlCICobroContCambioEstadoAutom", filNegociado)
                .DataSource = DtNeg
                .Filter = filNegociado
            End With

            ' MarcarTodos(GridNegociado)
        End If
        Me.pnlNegociado.Visible = mblnAutoNeg
        If mblnAutoNeg Then Me.pnlNegociado.Height = Altura
    End Sub

    Private Sub MarcarTodos(ByRef jngGrid As Solmicro.Expertis.Engine.UI.Grid, Optional ByVal blnDesmarcar As Boolean = False)
        'Si recibe blnDesMarcar=True, desmarca todas las filas del grid;
        'Si no lo recibe o lo recibe a True, las marca
        If jngGrid.RowCount > 0 Then
            Dim dtGrid As DataTable = jngGrid.DataSource
            If Not dtGrid Is Nothing AndAlso dtGrid.Rows.Count > 0 Then
                For Each row As DataRow In dtGrid.Rows
                    If blnDesmarcar Then
                        row("MarcaCambioAutomatico") = False
                    Else
                        row("MarcaCambioAutomatico") = True
                    End If
                Next
            End If
        End If
    End Sub


#End Region

    Private Sub cmdSiNoNegociado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSiNoNegociado.Click
        MarcarTodos(GridNoNegociado)
    End Sub

    Private Sub cmdSiVencido_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSiVencido.Click
        MarcarTodos(GridVencido)
    End Sub

    Private Sub cmdSiNegociado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSiNegociado.Click
        MarcarTodos(GridNegociado)
    End Sub


    Private Sub cmdNoNoNegociado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNoNoNegociado.Click
        MarcarTodos(GridNoNegociado, True)
    End Sub

    Private Sub cmdNoVencido_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNoVencido.Click
        MarcarTodos(GridVencido, True)
    End Sub

    Private Sub cmdNoNegociado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNoNegociado.Click
        MarcarTodos(GridNegociado, True)
    End Sub


    Private Sub cbxNegociado_cbxVencido_cbxNoNegociado_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxNoNegociado.ValueChanged, cbxVencido.ValueChanged, cbxNegociado.ValueChanged
        If Not mblnLoad Then
            CargarGrids(Nz(cbxNoNegociado.Value, cnMinDate), Nz(cbxVencido.Value, cnMinDate), Nz(cbxNegociado.Value, cnMinDate))
        End If
    End Sub

#Region " Aceptar / Cancelar "

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim dtCobros As New DataTable
        dtCobros.Columns.Add("IdCobro", GetType(Integer))

        If mblnAutoNoNeg Then dtCobros = InsertCobrosMarcados(GridNoNegociado, dtCobros)
        If mblnAutoVenc Then dtCobros = InsertCobrosMarcados(GridVencido, dtCobros)
        If mblnAutoNeg Then dtCobros = InsertCobrosMarcados(GridNegociado, dtCobros)

        'metemos en un array los registros marcados
        If Not dtCobros Is Nothing AndAlso dtCobros.Rows.Count > 0 Then
            For Each dr As DataRow In dtCobros.Select
                ReDim Preserve mIDCobros(UBound(mIDCobros) + 1)
                mIDCobros(UBound(mIDCobros)) = dr("IDCobro")
            Next
        End If

        Dim blnOK As Boolean = ExpertisApp.ExecuteTask(Of Integer(), Boolean)(AddressOf Cobro.CambioSituacionAutomatico, mIDCobros)
        If Not blnOK Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        Me.Close()
    End Sub

    Private Function InsertCobrosMarcados(ByVal jngGrid As Solmicro.Expertis.Engine.UI.Grid, ByVal dt As DataTable) As DataTable
        'Inserta en un rcs los cobros marcados en el grid
        Dim DtGrid As DataTable = jngGrid.DataSource
        If Not DtGrid Is Nothing AndAlso DtGrid.Rows.Count > 0 Then
            For Each Dr As DataRow In DtGrid.Select
                If Dr("MarcaCambioAutomatico") Then
                    Dim drNew As DataRow = dt.NewRow
                    drNew("IDCobro") = Dr("IDCobro")

                    dt.Rows.Add(drNew)
                End If
            Next
        End If

        Return dt
    End Function

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

#End Region

End Class
