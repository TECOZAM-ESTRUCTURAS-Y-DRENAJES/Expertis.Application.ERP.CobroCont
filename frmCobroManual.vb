Public Class frmCobroManual
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.Grid.RelationMode = RelationMode.NoRelation
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
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCobroManual))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 285)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 48)
        Me.Panel1.TabIndex = 3
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(388, 11)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 29)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(280, 11)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(100, 29)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Aceptar"
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NFactura", "FacturaVentaCabecera", "NFactura", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDFactura", "IDFactura"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("CambioA", "CambioA"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("CambioB", "CambioB")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IdTipoCobro", "TipoCobro", "IdTipoCobro"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCliente", "Cliente", "IDCliente"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDDireccion", "ClienteDireccion", "IDDireccion"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCContable", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescFormaPago", "DescFormaPago")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMoneda", "Moneda", "IDMoneda"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("Situacion", "EstadoCobro", "IDEstado"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBancoPropio", "BancoPropio", "IDBancoPropio")})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = "Cobro"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(768, 285)
        Me.Grid.TabIndex = 4
        Me.Grid.Tag = ""
        Me.Grid.ViewName = ""
        '
        'frmCobroManual
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(768, 333)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCobroManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir Registros de Cobro"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    Public Function AbrirCobroManual(ByVal OwnerForm As FormBase) As DialogResult

        Grid.EntityName = "Cobro"
        Grid.ViewName = "frmCobros"
        Dim f As New Filter

        f.Add(New IsNullFilterItem("IDCobro"))

        Grid.Filter = f
        Grid.Columns("Situacion").DefaultValue = enumCobroSituacion.NoNegociado

        Me.ShowDialog(OwnerForm)

        Return Me.DialogResult
    End Function

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Grid.RecordCount > 0 Then
            Try
                Me.UpdateData()
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Catch ex As Exception
                ExpertisApp.GenerateMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub Grid_AdvSearchNotInList(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchNotInListEventArgs) Handles Grid.AdvSearchNotInList
        Select Case e.Key
            Case "NFactura"
                e.Cancel = False
        End Select
    End Sub

    Private Sub Grid_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
        With Grid
            If Engine.Length(.Value("IDCliente")) > 0 Then
                Select Case e.Key
                    Case "IDFactura", "NFactura", "ClienteBanco", "IDDireccion"
                        e.Filter.Add("IDCliente", FilterOperator.Equal, .Value("IDCliente"))
                        If e.Key = "IDDireccion" Then
                            'Comprobamos si el cliene tiene grupo.
                            Dim C As New Cliente
                            Dim StData As New Cliente.DataGrupoCliente
                            StData.IDCliente = .Value("IDCliente") : StData.TipoGrupo = "Direccion"
                            Dim strIDGrupoDireccion As String = ExpertisApp.ExecuteTask(Of Cliente.DataGrupoCliente, String)(AddressOf Cliente.Grupo, StData)
                            If Engine.Length(strIDGrupoDireccion) > 0 Then
                                e.Filter.Add(New StringFilterItem("IDCliente", strIDGrupoDireccion))
                            Else
                                e.Filter.Add(New StringFilterItem("IDCliente", .Value("IDCliente")))
                            End If
                            e.Filter.Add(New BooleanFilterItem("Giro", True))
                        End If
                End Select
            End If
        End With
    End Sub
    'Private mstrEjerPredet As String
    'Private dtEjercicio As DataTable
    'Private intDigitosAuxiliar As Integer

    'Private Sub frmAñadirCobros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Dim f As New BE.DataEngine
    '    Dim dt As DataTable = f.Filter("vFrmNuevoCobro", "*", "1=2")
    '    jngCobros.DataSource = dt
    '    jngCobros.ReQuery()

    '    jngCobros.Columns("Situacion").DefaultValue = enumCobroSituacion.NoNegociado

    '    Dim ej As New EjercicioContable
    '    dtEjercicio = ej.PredeterminadoDT
    '    If Not IsNothing(dtEjercicio) AndAlso dtEjercicio.Rows.Count > 0 Then
    '        mstrEjerPredet = dtEjercicio.Rows(0)("IDEjercicio")
    '        intDigitosAuxiliar = dtEjercicio.Rows(0)("DigitosAuxiliar")
    '    End If
    'End Sub

    'Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
    '    Me.DialogResult = DialogResult.Cancel
    '    Me.Close()
    'End Sub

    'Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
    '    Dim dtCobros As DataTable = jngCobros.DataSource
    '    If Not dtCobros Is Nothing AndAlso dtCobros.Rows.Count > 0 Then
    '        Dim c As New Cobro
    '        Me.Cursor = Cursors.WaitCursor

    '        c.InsertCobros(dtCobros)

    '        Me.Cursor = Cursors.Default
    '        Me.DialogResult = DialogResult.OK
    '        Me.Close()
    '    End If
    'End Sub

    'Private Sub jngCobros_Adding_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngCobros.AddingRecord, jngCobros.UpdatingRecord

    '    With jngCobros
    '        'Comprobamos que no haya dejado ningun campo obligatorio vacio
    ''        If length(.GetValue("IdTipoCobro")) = 0 Then
    ''            MsgBox("El tipo de cobro es obligatorio.", MsgBoxStyle.Exclamation, ExpertisApp.Title) '900
    ''            e.Cancel = True
    ''        ElseIf length(.GetValue("IdCliente")) = 0 Then
    ''            MsgBox("El cliente es obligatorio.", MsgBoxStyle.Exclamation, ExpertisApp.Title)
    ''            e.Cancel = True
    ''        ElseIf length(.GetValue("CContable")) = 0 Then
    ''            MsgBox("La cuenta es obligatoria.", MsgBoxStyle.Exclamation, ExpertisApp.Title)
    ''            e.Cancel = True
    ''        ElseIf length(.GetValue("IdFormaPago")) = 0 Then
    ''            MsgBox("La forma de pago es obligatorio.", MsgBoxStyle.Exclamation, ExpertisApp.Title) '1177
    ''            e.Cancel = True
    ''        ElseIf length(.GetValue("FechaVencimiento")) = 0 Then
    ''            MsgBox("La fecha de vencimiento es obligatoria.", MsgBoxStyle.Exclamation, ExpertisApp.Title) '3050
    ''            e.Cancel = True
    '        ElseIf length(.GetValue("ImpVencimiento")) = 0 Then
    '            .SetValue("ImpVencimiento", 0)
    '        ElseIf length(.GetValue("IdMoneda")) = 0 Then
    '            MsgBox("La moneda es obligatoria.", MsgBoxStyle.Exclamation, ExpertisApp.Title) '1182
    '            e.Cancel = True
    '        ElseIf length(.GetValue("Situacion")) = 0 Then
    '            MsgBox("La situación es obligatoria.", MsgBoxStyle.Exclamation, ExpertisApp.Title) '6040
    '            e.Cancel = True
    '        ElseIf length(.GetValue("CambioA")) = 0 Or length(.GetValue("CambioB")) = 0 Then
    '            MsgBox("El cambio es obligatorio.", MsgBoxStyle.Exclamation, ExpertisApp.Title) '6042
    '            e.Cancel = True
    '        Else
    '            Dim CC As New AltaPlanContable
    '            e.Cancel = Not CC.ValidaCuentaContable(.GetValue("CContable"), mstrEjerPredet)
    '        End If

    '        If Not e.Cancel Then
    '            If .Columns("NFactura").EditType = Janus.Windows.GridEX.EditType.Combo Then
    '                '5483
    '                MsgBox("Hay más de una factura para ese Nº Factura. Seleccione la factura deseada.", MsgBoxStyle.Exclamation, ExpertisApp.Title)
    '                e.Cancel = True
    '            End If
    '        End If
    '    End With
    'End Sub

    'Private Sub jngCobros_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles jngCobros.UpdatingCell
    '    With jngCobros
    '        Select Case e.Column.Index
    '            Case .Columns("CContable").Index
    '                If length(e.Value) > 0 Then
    '                    e.Value = PuntoPorCero(e.Value, intDigitosAuxiliar, mstrEjerPredet)
    '                End If
    '        End Select
    '    End With
    'End Sub

    'Private Sub jngCobros_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles jngCobros.AdvSearchSetPredefinedFilter
    '    With jngCobros
    '        If length(.Value("IDCliente")) > 0 Then
    '            Select Case e.Key
    '                Case "IDFactura", "NFactura", "IDClienteBanco"
    '                    e.Filter.Add(New StringFilterItem("IdCliente", .Value("IDCliente")))
    '                Case "IDDireccion"
    '                    'Comprobamos si el cliene tiene grupo.
    '                    Dim C As New Cliente
    '                    Dim strIDGrupoDireccion As String = C.Grupo(.Value("IDCliente"), "Direccion")
    '                    If length(strIDGrupoDireccion) > 0 Then
    '                        e.Filter.Add(New StringFilterItem("IDCliente", strIDGrupoDireccion))
    '                    Else
    '                        e.Filter.Add(New StringFilterItem("IDCliente", .Value("IDCliente")))
    '                    End If
    '                    e.Filter.Add(New BooleanFilterItem("Giro", True))
    '            End Select
    '        End If
    '    End With
    'End Sub

    'Private Sub frmAñadirCobros_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
    '    Select Case e.EntityName
    '        Case "Cobro"
    '            e.Data.Context("IDEjercicio") = mstrEjerPredet
    '    End Select
    'End Sub

End Class
