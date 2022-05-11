
Public Class frmConsultaAsientoRemesa
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
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents fwiTodosAsientos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblfwiAsiento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiAsiento As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents jngDiario As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngDiario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaAsientoRemesa))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.fwiTodosAsientos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblfwiAsiento = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiAsiento = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.jngDiario = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.jngDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.fwiTodosAsientos)
        Me.Panel1.Controls.Add(Me.lblfwiAsiento)
        Me.Panel1.Controls.Add(Me.fwiAsiento)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 315)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 48)
        Me.Panel1.TabIndex = 7
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(385, 10)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(96, 30)
        Me.cmdAceptar.TabIndex = 8
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(489, 10)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(96, 30)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "Cancelar"
        '
        'fwiTodosAsientos
        '
        Me.fwiTodosAsientos.Location = New System.Drawing.Point(136, 9)
        Me.fwiTodosAsientos.Name = "fwiTodosAsientos"
        Me.fwiTodosAsientos.Size = New System.Drawing.Size(136, 32)
        Me.fwiTodosAsientos.TabIndex = 10
        Me.fwiTodosAsientos.Text = "Todos los Asientos"
        Me.fwiTodosAsientos.Visible = False
        '
        'lblfwiAsiento
        '
        Me.lblfwiAsiento.Location = New System.Drawing.Point(8, 16)
        Me.lblfwiAsiento.Name = "lblfwiAsiento"
        Me.lblfwiAsiento.Size = New System.Drawing.Size(49, 13)
        Me.lblfwiAsiento.TabIndex = 11
        Me.lblfwiAsiento.Text = "Asiento"
        Me.lblfwiAsiento.Visible = False
        '
        'fwiAsiento
        '
        Me.fwiAsiento.DisabledBackColor = System.Drawing.Color.White
        Me.fwiAsiento.Location = New System.Drawing.Point(56, 16)
        Me.fwiAsiento.Name = "fwiAsiento"
        Me.fwiAsiento.Size = New System.Drawing.Size(58, 23)
        Me.fwiAsiento.TabIndex = 9
        Me.fwiAsiento.Visible = False
        '
        'jngDiario
        '
        Me.jngDiario.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngDiario.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngDiario.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngDiario_DesignTimeLayout.LayoutString = resources.GetString("jngDiario_DesignTimeLayout.LayoutString")
        Me.jngDiario.DesignTimeLayout = jngDiario_DesignTimeLayout
        Me.jngDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngDiario.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngDiario.EntityName = ""
        Me.jngDiario.FrozenColumns = 2
        Me.jngDiario.Location = New System.Drawing.Point(0, 0)
        Me.jngDiario.Name = "jngDiario"
        Me.jngDiario.PrimaryDataFields = Nothing
        Me.jngDiario.SecondaryDataFields = Nothing
        Me.jngDiario.Size = New System.Drawing.Size(606, 315)
        Me.jngDiario.TabIndex = 8
        Me.jngDiario.Tag = "IdRec=4595:4734:4596:4735:4736:4737:4738:4739:;"
        Me.jngDiario.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngDiario.ViewName = ""
        '
        'frmConsultaAsientoRemesa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(606, 363)
        Me.Controls.Add(Me.jngDiario)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaAsientoRemesa"
        Me.Text = "Asiento"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.jngDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Propiedades "

    Private mintIdRemesa As Integer
    Public WriteOnly Property IDRemesa() As Integer
        Set(ByVal Value As Integer)
            mintIdRemesa = Value
        End Set
    End Property

    Private mTipoAsiento As enumDiarioTipoApunte
    Public WriteOnly Property TipoAsiento() As enumDiarioTipoApunte
        Set(ByVal Value As enumDiarioTipoApunte)
            mTipoAsiento = Value
        End Set
    End Property

    Private mlngAccion As enumTipoAccion
    Public WriteOnly Property Accion() As enumTipoAccion
        Set(ByVal Value As enumTipoAccion)
            mlngAccion = Value
        End Set
    End Property

    Private mdtAsientos As DataTable
    Public Property Asientos() As DataTable
        Get
            Return mdtAsientos
        End Get
        Set(ByVal Value As DataTable)
            mdtAsientos = Value
        End Set
    End Property

    Private mdtNAsientos As DataTable
    Public Property NAsientos() As DataTable
        Get
            Return mdtNAsientos
        End Get
        Set(ByVal Value As DataTable)
            mdtNAsientos = Value
        End Set
    End Property

    Private mTipoNegociacion As enumTipoRemesa
    Public Property TipoNegociacion() As enumTipoRemesa
        Get
            Return mTipoNegociacion
        End Get
        Set(ByVal value As enumTipoRemesa)
            mTipoNegociacion = value
        End Set
    End Property

#End Region

#Region " Enumerado (Tipo) "

    Public Enum enumTipoAccion
        Consulta = 0
        Eliminacion = 1
        Descontablizacion = 2
    End Enum

#End Region

#Region " Carga del formulario "

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            '// Cambiar el título dependiendo de la acción que se vaya a realizar.
            If mTipoAsiento = enumDiarioTipoApunte.Remesa Then
                If mlngAccion = enumTipoAccion.Eliminacion Then
                    Me.Text = "Eliminación de Asiento de Remesa"
                ElseIf mlngAccion = enumTipoAccion.Descontablizacion Then
                    Me.Text = "Descontabilización de Asiento de Remesa"
                Else
                    Me.Text = "Consulta de Asiento de Remesa"
                End If
            ElseIf mTipoAsiento = enumDiarioTipoApunte.Anticipo Then
                If mlngAccion = enumTipoAccion.Eliminacion Then
                    Me.Text = "Eliminación de Asiento de Anticipo"
                ElseIf mlngAccion = enumTipoAccion.Descontablizacion Then
                    Me.Text = "Descontabilización de Asiento de Anticipo"
                Else
                    Me.Text = "Consulta de Asiento de Anticipo"
                End If
            ElseIf mTipoAsiento = enumDiarioTipoApunte.LiquidacionRemesa Then
                If mlngAccion = enumTipoAccion.Eliminacion Then
                    Me.Text = "Eliminación de Asiento de Liquidación de Remesa"
                Else
                    Me.Text = "Consulta de Asiento de Liquidación de Remesa"
                End If
            ElseIf mTipoAsiento = enumDiarioTipoApunte.CancelacionAnticipo Then
                If mlngAccion = enumTipoAccion.Eliminacion Then
                    Me.Text = "Eliminación de Asiento de Cancelación de Anticipo"
                Else
                    Me.Text = "Consulta de Asiento de Cancelación de Anticipo"
                End If
            End If

            If mlngAccion <> enumTipoAccion.Consulta Then
                lblfwiAsiento.Visible = False
                fwiAsiento.Visible = False
                fwiTodosAsientos.Visible = False
            Else
                fwiTodosAsientos.Checked = False
                If Not IsNothing(mdtNAsientos) AndAlso mdtNAsientos.Rows.Count = 1 Then
                    fwiAsiento.Text = mdtNAsientos.Rows(0)("NAsiento")
                End If
            End If

            If Not IsNothing(mdtNAsientos) Then
                jngDiario.DataSource = mdtAsientos
            End If
        End If

    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim objNegCobro As Cobro
        'Dim strAsiento As String = String.Empty
        'Dim strEjercicio As String = String.Empty

        If Not IsNothing(mdtNAsientos) AndAlso mdtNAsientos.Rows.Count > 0 Then
            Dim DiagResul As DialogResult
            Dim IDEjercicioAnt As String
            Dim Ejercicios As New Hashtable
            Dim NAsientoEj(-1) As String
            For Each row As DataRow In mdtNAsientos.Select(Nothing, "IDEjercicio, NAsiento")
                'strAsiento = strAsiento & row("NAsiento") & ","

                If IDEjercicioAnt <> row("IDEjercicio") Then
                    ReDim NAsientoEj(-1)
                    'strEjercicio = row("IdEjercicio")
                    IDEjercicioAnt = row("IDEjercicio")
                End If

                ReDim Preserve NAsientoEj(NAsientoEj.Length)
                NAsientoEj(NAsientoEj.Length - 1) = row("NAsiento")

                Ejercicios(row("IDEjercicio")) = NAsientoEj
            Next

            If mlngAccion = enumTipoAccion.Descontablizacion Then
                If mTipoAsiento = enumDiarioTipoApunte.Remesa Then
                    DiagResul = ExpertisApp.GenerateMessage("Va a descontabilizar la Remesa. {0} ¿Desea continuar?", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine)
                End If
                If mTipoAsiento = enumDiarioTipoApunte.Anticipo Then
                    DiagResul = ExpertisApp.GenerateMessage("Va a descontabilizar el Anticipo. {0} ¿Desea continuar?", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine)
                End If
            End If

            If mlngAccion = enumTipoAccion.Eliminacion Then
                Dim Info As String
                For Each key As String In Ejercicios.Keys
                    Dim strAsientos As String = Strings.Join(Ejercicios(key), ",")
                    Info = Info & vbNewLine & strAsientos & ExpertisApp.Traslate(" del Ejercicio ") & Quoted(key)
                Next

                If mTipoAsiento = enumDiarioTipoApunte.Remesa Then
                    DiagResul = ExpertisApp.GenerateMessage("Al eliminar la remesa también se eliminan los siguientes asientos contables: {0} {1}¿Desea continuar?", _
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question, Info, vbNewLine)
                ElseIf mTipoAsiento = enumDiarioTipoApunte.Anticipo Then
                    DiagResul = ExpertisApp.GenerateMessage("Al eliminar el anticipo también se eliminan los siguientes asientos contables: {0} {1}¿Desea continuar?", _
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question, Info, vbNewLine)
                Else
                    DiagResul = ExpertisApp.GenerateMessage("Se eliminan los siguientes asientos contables: {0} {1}¿Desea continuar?", _
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question, Info, vbNewLine)
                End If
            End If

            If mlngAccion <> enumTipoAccion.Consulta Then
                If DiagResul = DialogResult.Yes Then
                    If Not IsNothing(mdtNAsientos) AndAlso mdtNAsientos.Rows.Count > 0 Then
                        If mTipoAsiento = enumDiarioTipoApunte.Remesa OrElse mTipoAsiento = enumDiarioTipoApunte.Anticipo Then
                            ''llamada al negocio actual
                            objNegCobro = New Cobro
                            For Each row As DataRow In mdtNAsientos.Rows
                                If mlngAccion = enumTipoAccion.Eliminacion Then
                                    Dim delRem As New Cobro.DataDeleteRemesa
                                    delRem.IDRemesa = mintIdRemesa
                                    delRem.TodosAsientos = False
                                    delRem.NAsiento = row("NAsiento")
                                    delRem.IDEjercicio = row("IdEjercicio")
                                    delRem.TipoNegociacion = mTipoNegociacion
                                    ExpertisApp.ExecuteTask(Of Cobro.DataDeleteRemesa, Boolean)(AddressOf Cobro.DeleteRemesa, delRem)
                                ElseIf mlngAccion = enumTipoAccion.Descontablizacion Then
                                    Dim descRem As New Cobro.DataDescontabilizarRemesa
                                    descRem.IDRemesa = mintIdRemesa
                                    descRem.TodosAsientos = False
                                    descRem.NAsiento = row("NAsiento")
                                    descRem.IDEjercicio = row("IdEjercicio")
                                    descRem.TipoNegociacion = mTipoNegociacion
                                    ExpertisApp.ExecuteTask(Of Cobro.DataDescontabilizarRemesa, Boolean)(AddressOf Cobro.DescontabilizarRemesa, descRem)
                                End If
                            Next row
                        Else
                            If mTipoAsiento = enumDiarioTipoApunte.CancelacionAnticipo Then
                                ''llamada al negocio actual
                                For Each row As DataRow In mdtNAsientos.Rows
                                    Dim delLiq As New Cobro.DataDeleteLiquidacionRemesaAnticipo
                                    delLiq.NAsiento = row("NAsiento")
                                    delLiq.IDEjercicio = row("IdEjercicio")
                                    ExpertisApp.ExecuteTask(Of Cobro.DataDeleteLiquidacionRemesaAnticipo, Boolean)(AddressOf Cobro.DeleteLiquidacionRemesaAnticipo, delLiq)
                                Next row
                            Else
                                ''llamada al negocio actual
                                For Each row As DataRow In mdtNAsientos.Rows
                                    Dim delLiq As New Cobro.DataDeleteLiquidacionRemesa
                                    delLiq.IDRemesa = mintIdRemesa
                                    delLiq.TodosAsientos = False
                                    delLiq.NAsiento = row("NAsiento")
                                    delLiq.IDEjercicio = row("IdEjercicio")
                                    ExpertisApp.ExecuteTask(Of Cobro.DataDeleteLiquidacionRemesa, Boolean)(AddressOf Cobro.DeleteLiquidacionRemesa, delLiq)
                                Next row
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

#End Region

End Class
