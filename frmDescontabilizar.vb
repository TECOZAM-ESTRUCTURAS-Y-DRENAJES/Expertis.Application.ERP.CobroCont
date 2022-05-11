Public Class frmDescontabilizar
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
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents jngCobrosPagos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents jngDiario As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblfwiCobrosPagos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiApuntes As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblfwiSituacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcfwiSituacion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngCobrosPagos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescontabilizar))
        Dim jngDiario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.jngCobrosPagos = New Solmicro.Expertis.Engine.UI.Grid
        Me.jngDiario = New Solmicro.Expertis.Engine.UI.Grid
        Me.lblfwiCobrosPagos = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiApuntes = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiSituacion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        CType(Me.jngCobrosPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fwiSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(480, 442)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(79, 26)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAceptar.Location = New System.Drawing.Point(391, 442)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(79, 26)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'jngCobrosPagos
        '
        Me.jngCobrosPagos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngCobrosPagos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngCobrosPagos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngCobrosPagos_DesignTimeLayout.LayoutString = resources.GetString("jngCobrosPagos_DesignTimeLayout.LayoutString")
        Me.jngCobrosPagos.DesignTimeLayout = jngCobrosPagos_DesignTimeLayout
        Me.jngCobrosPagos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngCobrosPagos.EntityName = "Cobro"
        Me.jngCobrosPagos.FrozenColumns = 5
        Me.jngCobrosPagos.Location = New System.Drawing.Point(5, 29)
        Me.jngCobrosPagos.Name = "jngCobrosPagos"
        Me.jngCobrosPagos.PrimaryDataFields = Nothing
        Me.jngCobrosPagos.RequeryManually = True
        Me.jngCobrosPagos.SecondaryDataFields = Nothing
        Me.jngCobrosPagos.Size = New System.Drawing.Size(555, 133)
        Me.jngCobrosPagos.TabIndex = 0
        Me.jngCobrosPagos.Tag = "IdRec=4732:4361:4362:4710:4719:4629:4733:4713:4715:;"
        Me.jngCobrosPagos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngCobrosPagos.ViewName = "frmCobroDescont"
        '
        'jngDiario
        '
        Me.jngDiario.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngDiario.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngDiario.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngDiario_DesignTimeLayout.LayoutString = resources.GetString("jngDiario_DesignTimeLayout.LayoutString")
        Me.jngDiario.DesignTimeLayout = jngDiario_DesignTimeLayout
        Me.jngDiario.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngDiario.EntityName = "DiarioContable"
        Me.jngDiario.FrozenColumns = 2
        Me.jngDiario.Location = New System.Drawing.Point(5, 192)
        Me.jngDiario.Name = "jngDiario"
        Me.jngDiario.PrimaryDataFields = Nothing
        Me.jngDiario.RequeryManually = True
        Me.jngDiario.SecondaryDataFields = ""
        Me.jngDiario.Size = New System.Drawing.Size(555, 231)
        Me.jngDiario.TabIndex = 1
        Me.jngDiario.Tag = "IdRec=4595:4734:4596:4735:4736:4737:4738:4739:;"
        Me.jngDiario.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngDiario.ViewName = "tbDiarioContable"
        '
        'lblfwiCobrosPagos
        '
        Me.lblfwiCobrosPagos.Location = New System.Drawing.Point(6, 6)
        Me.lblfwiCobrosPagos.Name = "lblfwiCobrosPagos"
        Me.lblfwiCobrosPagos.Size = New System.Drawing.Size(204, 13)
        Me.lblfwiCobrosPagos.TabIndex = 4
        Me.lblfwiCobrosPagos.Tag = "IdRec=4740;"
        Me.lblfwiCobrosPagos.Text = "Cobros y Pagos a Descontabilizar:"
        '
        'lblfwiApuntes
        '
        Me.lblfwiApuntes.Location = New System.Drawing.Point(7, 171)
        Me.lblfwiApuntes.Name = "lblfwiApuntes"
        Me.lblfwiApuntes.Size = New System.Drawing.Size(160, 13)
        Me.lblfwiApuntes.TabIndex = 5
        Me.lblfwiApuntes.Tag = "IdRec=4741;"
        Me.lblfwiApuntes.Text = "Apuntes a Descontabilizar:"
        '
        'fwiSituacion
        '
        fwiSituacion_DesignTimeLayout.LayoutString = resources.GetString("fwiSituacion_DesignTimeLayout.LayoutString")
        Me.fwiSituacion.DesignTimeLayout = fwiSituacion_DesignTimeLayout
        Me.fwiSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiSituacion.EntityName = "EstadoCobro"
        Me.fwiSituacion.Location = New System.Drawing.Point(90, 447)
        Me.fwiSituacion.Name = "fwiSituacion"
        Me.fwiSituacion.PrimaryDataFields = "IDEstado"
        Me.fwiSituacion.SecondaryDataFields = "IDEstado"
        Me.fwiSituacion.SelectedIndex = -1
        Me.fwiSituacion.SelectedItem = Nothing
        Me.fwiSituacion.Size = New System.Drawing.Size(83, 21)
        Me.fwiSituacion.TabIndex = 6
        Me.fwiSituacion.ViewName = "cmbEstadoCobro"
        '
        'lblfwiSituacion
        '
        Me.lblfwiSituacion.Location = New System.Drawing.Point(10, 447)
        Me.lblfwiSituacion.Name = "lblfwiSituacion"
        Me.lblfwiSituacion.Size = New System.Drawing.Size(79, 13)
        Me.lblfwiSituacion.TabIndex = 6
        Me.lblfwiSituacion.Tag = "IdRec=4742;"
        Me.lblfwiSituacion.Text = "Cambiar a..."
        '
        'lblcfwiSituacion
        '
        Me.TryDataBinding(lblcfwiSituacion, New System.Windows.Forms.Binding("Text", Me.fwiSituacion, "DescEstado", True))
        Me.lblcfwiSituacion.Location = New System.Drawing.Point(178, 447)
        Me.lblcfwiSituacion.Name = "lblcfwiSituacion"
        Me.lblcfwiSituacion.Size = New System.Drawing.Size(206, 22)
        Me.lblcfwiSituacion.TabIndex = 7
        '
        'frmDescontabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(568, 480)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.jngCobrosPagos)
        Me.Controls.Add(Me.jngDiario)
        Me.Controls.Add(Me.lblfwiCobrosPagos)
        Me.Controls.Add(Me.lblfwiApuntes)
        Me.Controls.Add(Me.lblfwiSituacion)
        Me.Controls.Add(Me.lblcfwiSituacion)
        Me.Controls.Add(Me.fwiSituacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDescontabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descontabilización"
        CType(Me.jngCobrosPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngDiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fwiSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mIDProcess As System.Guid
    Private mContabilidadMultiple As Boolean
    Public Property IDProcess() As Guid
        Get
            Return mIDProcess
        End Get
        Set(ByVal value As Guid)
            mIDProcess = value
        End Set
    End Property

    Private mRecibidoEfectosCliente As Boolean
    Public Property RecibidoEfectosCliente() As Boolean
        Get
            Return mRecibidoEfectosCliente
        End Get
        Set(ByVal value As Boolean)
            mRecibidoEfectosCliente = value
        End Set
    End Property


#Region " Load "

    Private Sub frmDescontabilizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            Dim objNegParametro As New Parametro
            Me.fwiSituacion.Value = objNegParametro.CobroDescontSituacion
            mContabilidadMultiple = objNegParametro.ContabilidadMultiple
            FiltrarGridCobrosPagos()
            FiltrarGridDiario()
        End If
    End Sub

    Private Sub FiltrarGridCobrosPagos()
        'Inicializar Grid de Cobros
        Dim clsFilter As New Filter
        clsFilter.Add(New StringFilterItem("IdProcess", FilterOperator.Equal, mIDProcess.ToString))
        If mRecibidoEfectosCliente Then
            jngCobrosPagos.ViewName = "frmCobroDescontRecibidoEfecto"
        End If
        jngCobrosPagos.ReQuery(clsFilter)
    End Sub

    Private Sub FiltrarGridDiario()
        Dim oFilterOR As New Filter(FilterUnionOperator.Or)
        Dim fTipoApunte As New Filter(FilterUnionOperator.Or)
        If Not IsNothing(jngCobrosPagos.DataSource) Then
            For Each drCobro As DataRow In CType(jngCobrosPagos.DataSource, DataTable).Rows
                Dim oFilter As New Filter
                ' oFilter.Add("IDEjercicio", FilterOperator.Equal, drCobro("IDEjercicio"))

                Dim fEjercicio As New Filter(FilterUnionOperator.Or)
                fEjercicio.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, drCobro("IDEjercicio")))
                If mContabilidadMultiple Then
                    If drCobro.Table.Columns.Contains("IDEjercicioTributario") AndAlso Length(drCobro("IDEjercicioTributario")) > 0 Then fEjercicio.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, drCobro("IDEjercicioTributario")))
                End If

                oFilter.Add(fEjercicio)

                oFilter.Add("IDDocumento", FilterOperator.Equal, drCobro("IDCobroPago"))
                fTipoApunte = New Filter(FilterUnionOperator.Or)
                If mRecibidoEfectosCliente Then
                    fTipoApunte.Add("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.RecibidoEfectoClte)
                Else
                    fTipoApunte.Add("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.Cobro)
                    fTipoApunte.Add("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.Compensacion)
                End If
                oFilter.Add(fTipoApunte)
                oFilterOR.Add(oFilter)
            Next
        End If
        jngDiario.ReQuery(oFilterOR)
    End Sub

#End Region

#Region " Aceptar "

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        '//Validamos si se puede hacer la descontabilización
        Dim objFilter As New Filter
        objFilter.Add(New IsNullFilterItem("MesCierre", False))
        Dim dvApuntesCobro As DataView = New DataView(jngDiario.DataSource, objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.CurrentRows)
        If Not IsNothing(dvApuntesCobro) AndAlso dvApuntesCobro.Count > 0 Then
            ExpertisApp.GenerateMessage("Algun cobro está contabilizado en un periodo cerrado. Debe deshacer el cierre de ese periodo para descontabilizar el cobro.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            '//Comprobamos si algun cobro de los que se va a descontabilizar esta agrupado por banco
            '//con otro que no se va a descontabilizar. En ese caso habrá un descuadre en el grid y 
            '//se descontabilizará el cobro, pero se le avisa al usuario que debe modificar manualmente 
            '//el asiento, para descontabilizar el cobro.
            If ComprobarDescuadreAsiento() Then
                If Engine.Length(fwiSituacion.Value) = 0 Then
                    lngNuevaSituacion = -1
                Else
                    lngNuevaSituacion = fwiSituacion.Value
                End If
                Dim datDescont As New DataDescontabilizacion(mIDProcess, lngNuevaSituacion)
                If mRecibidoEfectosCliente Then
                    ExpertisApp.ExecuteTask(Of DataDescontabilizacion)(AddressOf ContabilizacionCobroEfectoRdo.Descontabilizar, datDescont)
                Else
                    ExpertisApp.ExecuteTask(Of DataDescontabilizacion)(AddressOf ContabilizacionCobro.Descontabilizar, datDescont)
                End If
            End If
        End If

        Me.Close()
    End Sub

    Private Function ComprobarDescuadreAsiento() As Boolean
        '//Comprueba que todos los apuntes del grid pertenecientes a un mismo asiento estan cuadrados.
        '//Tendremos asientos descuadrados en el grid cuando no se van a descontabilizar todos los cobros
        '//que se han contabilizado agrupados por banco

        ComprobarDescuadreAsiento = False

        Dim strAsientosDescuadrados As String = String.Empty
        Dim dblDebeAsiento, dblHaberAsiento As Decimal
        Dim intAsientoAnt As Integer = -1
        Dim IDEjercicioAnt As String
        If Not IsNothing(jngDiario.DataSource) Then
            For Each drApunte As DataRow In CType(jngDiario.DataSource, DataTable).Select(Nothing, "IDEjercicio ASC, NAsiento ASC")
                If drApunte("IDEjercicio") <> IDEjercicioAnt OrElse drApunte("NAsiento") <> intAsientoAnt Then

                    'If drApunte("NAsiento") <> intAsientoAnt Then
                    If dblHaberAsiento <> dblDebeAsiento Then
                        strAsientosDescuadrados = strAsientosDescuadrados & intAsientoAnt & ", "
                    End If
                    'dblDebeAsiento = CDec(drApunte("ImpDebeA"))
                    'dblHaberAsiento = CDec(drApunte("ImpHaberA"))
                    'End If

                    dblDebeAsiento = 0 : dblHaberAsiento = 0
                    intAsientoAnt = drApunte("NAsiento")
                    IDEjercicioAnt = drApunte("IDEjercicio")
                End If
                dblDebeAsiento = dblDebeAsiento + CDec(drApunte("ImpDebeA"))
                dblHaberAsiento = dblHaberAsiento + CDec(drApunte("ImpHaberA"))


            Next
        End If
        If dblHaberAsiento <> dblDebeAsiento Then
            strAsientosDescuadrados = strAsientosDescuadrados & intAsientoAnt & ", "
        End If
        If Engine.Length(strAsientosDescuadrados) > 0 Then
            strAsientosDescuadrados = Strings.Left(strAsientosDescuadrados, Engine.Length(strAsientosDescuadrados) - Engine.Length(", "))
        End If

        Dim blnContinuar As Boolean
        If Engine.Length(strAsientosDescuadrados) > 0 Then
            'Si hay asientos descuadrados
            ExpertisApp.GenerateMessage("No se pueden borrar de forma automática algunos asientos porque se crearian asientos descuadrados. Debe descontabilizar de manera conjunta todos los cobros agrupados en los asientos: " & strAsientosDescuadrados & vbCrLf, MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnContinuar = False
            'If ExpertisApp.GenerateMessage("No se pueden borrar de forma automática algunos asientos porque se crearian asientos descuadrados. Después de terminar este proceso se deben modificar manualmente los siguientes asientos: " & strAsientosDescuadrados & vbCrLf & "¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            '    blnContinuar = True
            '    blnBorrable = AsientosBorrables()
            'Else
            '    '//En este caso no se descontabilizaran los cobros
            '    blnContinuar = False
            'End If
        Else
            '//No hay asientos descuadrados
            blnContinuar = True
        End If

        If blnContinuar Then
            'Dim strMensaje As String
            'If blnBorrable Then    '// SI hay asientos descuadrados.
            ' strMensaje = "Se eliminarán todos los apuntes contables que no provocan descuadres. ¿Desea continuar?"
            'Else                    '// NO hay asientos descuadrados o sí los hay pero no se pueden borrar.
            '    If Engine.Length(strAsientosDescuadrados) > 0 Then
            '        strMensaje = "Se eliminarán todos los apuntes contables que no provocan descuadres. ¿Desea continuar?"
            '    Else
            '        strMensaje = "Se eliminarán todos los apuntes contables de los cobros contabilizados seleccionados."
            '    End If
            'End If
            If ExpertisApp.GenerateMessage("Se eliminarán todos los apuntes contables que no provocan descuadres. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                blnContinuar = False
            Else
                blnContinuar = True
                'If Engine.Length(strAsientosDescuadrados) > 0 Then
                '    '// En el caso q haya un descuadre, se ponen a 'No Contabilizado' los cobros que
                '    '// se quieren descontabilizar.
                '    CobrosDescuadradosPasarNoContabilizados()
                'End If
            End If
        End If

        ComprobarDescuadreAsiento = blnContinuar
    End Function

    Private Function AsientosBorrables() As Boolean
        AsientosBorrables = False
        Dim intIDDocumento As Integer = 0
        Dim intNDocumentos As Integer '//Contador de IDDocumento

        If Not IsNothing(jngDiario.DataSource) Then
            '//Guardamos los IDDocumento en un array
            For Each drApunte As DataRow In CType(jngDiario.DataSource, DataTable).Select(Nothing, "IDDocumento ASC")
                If intIDDocumento <> drApunte("IDDocumento") Then
                    intIDDocumento = drApunte("IDDocumento")
                    intNDocumentos = intNDocumentos + 1
                    ReDim Preserve ListaIdDocumento(intNDocumentos - 1)
                    ListaIdDocumento(intNDocumentos - 1) = intIDDocumento
                End If
            Next

            Dim intNAsiento As Integer
            '//Guardamos los NAsiento en un array
            ReDim ListaNAsiento(intNDocumentos - 1)
            For i As Integer = 0 To intNDocumentos - 1
                Dim objFilter As New Filter
                objFilter.Add(New NumberFilterItem("IDDocumento", ListaIdDocumento(i)))
                intNAsiento = 0
                For Each drApunte As DataRow In CType(jngDiario.DataSource, DataTable).Select(objFilter.Compose(New AdoFilterComposer), "NAsiento ASC")
                    If intNAsiento <> drApunte("NAsiento") Then
                        intNAsiento = drApunte("NAsiento")
                        ListaNAsiento(i).tam = ListaNAsiento(i).tam + 1
                        ReDim Preserve ListaNAsiento(i).LNAsiento(ListaNAsiento(i).tam - 1)
                        ListaNAsiento(i).LNAsiento(ListaNAsiento(i).tam - 1) = intNAsiento
                    End If
                Next
            Next i

            '//Comprobamos si podemos borrar cada uno de los asientos, si se borran completos.
            Dim dblDebeAsiento, dblHaberAsiento As Double
            For i As Integer = 0 To ListaIdDocumento.Length - 1
                For j As Integer = 0 To ListaNAsiento(i).tam - 1
                    Dim objFilter As New Filter
                    objFilter.Add(New NumberFilterItem("NAsiento", ListaNAsiento(i).LNAsiento(j)))
                    dblDebeAsiento = 0 : dblHaberAsiento = 0
                    For Each drApunte As DataRow In CType(jngDiario.DataSource, DataTable).Select(objFilter.Compose(New AdoFilterComposer), "NAsiento ASC")
                        dblDebeAsiento = dblDebeAsiento + drApunte("ImpDebeA")
                        dblHaberAsiento = dblHaberAsiento + drApunte("ImpHaberA")
                    Next
                    If dblDebeAsiento <> dblHaberAsiento Then
                        Exit For
                    Else
                        If j = ListaNAsiento(i).tam Then AsientosBorrables = True
                    End If
                Next j
            Next i
        End If
    End Function

    'Private Sub CobrosDescuadradosPasarNoContabilizados()
    '    If Not IsNothing(jngCobrosPagos.DataSource) Then
    '        Dim oFilter As New Filter
    '        Dim oFilterOR As New Filter(FilterUnionOperator.Or)
    '        For Each drCobro As DataRow In CType(jngCobrosPagos.DataSource, DataTable).Rows
    '            oFilter.Clear()
    '            oFilter.Add("IDCobro", FilterOperator.Equal, drCobro("IDCobroPago"))
    '            oFilter.Add("IDEjercicio", FilterOperator.Equal, drCobro("IDEjercicio"))
    '            oFilterOR.Add(oFilter)
    '        Next

    '        Dim objNegCobro As New Cobro
    '        Dim dtCobrosDesCont As DataTable = objNegCobro.Filter(oFilterOR)
    '        For Each drCobro As DataRow In dtCobrosDesCont.Select
    '            drCobro("Contabilizado") = enumCobroContabilizado.CobroNoContabilizado
    '            drCobro("IDEjercicio") = Nothing
    '        Next
    '        objNegCobro.Update(dtCobrosDesCont)
    '    End If
    'End Sub

#End Region

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

End Class
