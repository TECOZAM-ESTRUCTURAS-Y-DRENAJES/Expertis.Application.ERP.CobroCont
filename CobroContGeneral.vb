Public Module CobroContGeneral
    Public Enum IconIndex
        NoContabilizado = 0
        Contabilizado = 1
    End Enum

    Public Structure tarray
        Public tam As Long
        Public LNAsiento() As String
    End Structure

    Public ListaIdDocumento() As Long
    Public ListaNAsiento() As tarray

    Public mstrEjercicioActual As String
    Public dtFechaApunte As Date
    Public mdtFechaValor As Date
    Public mstrCuentaBanco As String
    Public mstrIDBancoPropio As String
    Public mblnAgruparBanco As Boolean
    Public mblnAgruparBancoLiquidacion As Boolean
    Public mstrDescApunte As String
    Public mstrNDocumento As String

    Public intAccion As Integer
    Public mblnCancel As Boolean
    'Public mIDProcess As System.Guid
    Public mstrIDProcess As String

    Public lngNuevaSituacion As Long

    Public mstrReportFormulas As String
    Public mdtInforme As DataTable
    Public mdtCobros As DataTable

    Public Enum enumAccion
        'Separador = 1000
        Cancelar = 1001
        Contabilizar = 1002
        Descontabilizar = 1003
        RemesaProvisional = 1004
        RemesaDefinitiva = 1005
        'RemesaLiquidacion = 1006
        'CobrosAgrupables = 1007
        'DesagrupacionCobros = 1008
        'DesgloseCobros = 1009
        'CambioSituacion = 1010
        CambioSituacionAutomatica = 1011
        ModificacionCobros = 1012
        'Devolucioncobros = 1013
        'CobroManual = 1014
        'VerRemesa = 1015
        'EliminarRemesa = 1016
        'EliminarCobros = 1017
        'ComparacionSaldos = 1018
        FechaVtoMasivo = 1016
        'AñadirRemesa = 1019
        'RetirarRemesa = 1020
        'ConsultarAgrupacion = 1021
    End Enum

    Public Enum enumFecha
        FechaMayor = 0
        FechaMenor = 1
        FechaIgual = 2
    End Enum

    '---------------------------------------------------------------------------------
    '                             INFORMES
    '---------------------------------------------------------------------------------

    Public Function CrearRsInformeLineas(ByVal dtmFechaNeg As Date, ByVal strIdBancoPropio As String, _
                                         ByVal intIdTipoRemesa As Integer) As Boolean
        Dim DtMonedaA As DataTable = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Moneda.ObtenerMonedaA, New Object)
        Dim IntNDecA As Integer
        If Not DtMonedaA Is Nothing AndAlso DtMonedaA.Rows.Count > 0 Then IntNDecA = DtMonedaA.Rows(0)("NDecimalesImp")
        If Not mdtCobros Is Nothing AndAlso mdtCobros.Rows.Count > 0 Then
            Dim DtInforLineas As New DataTable
            DtInforLineas.Columns.Add("IdCliente", GetType(String))
            DtInforLineas.Columns.Add("NFactura", GetType(String))
            DtInforLineas.Columns.Add("Librado", GetType(String))
            DtInforLineas.Columns.Add("Titulo", GetType(String))
            DtInforLineas.Columns.Add("Provincia", GetType(String))
            DtInforLineas.Columns.Add("ImporteVto", GetType(Double))
            DtInforLineas.Columns.Add("InteresDto", GetType(Double))
            DtInforLineas.Columns.Add("Comisiones", GetType(Double))
            DtInforLineas.Columns.Add("TotalGastos", GetType(Double))
            DtInforLineas.Columns.Add("ImporteNeto", GetType(Double))
            DtInforLineas.Columns.Add("FechaVto", GetType(Date))
            DtInforLineas.Columns.Add("Dias", GetType(Integer))
            DtInforLineas.Columns.Add("NDecimales", GetType(Integer))
            DtInforLineas.Columns.Add("NCuenta", GetType(String))
            DtInforLineas.Columns.Add("IDClienteBanco", GetType(Integer))
            DtInforLineas.Columns.Add("ARepercutirA", GetType(Double))

            Dim StrCuenta, StrBanco, StrSucursal, StrDC, StrNCuenta As String
            Dim DblImpTotalVto, DblImpTotalIntereses, DblImpTotalComisiones As Double
            Dim DblComisiones As Double
            Dim DblInteresDto As Double
            Dim DblImporteVto As Double
            Dim DblImpRepercutir As Double
            Dim IntDias As Integer

            For Each Dr As DataRow In mdtCobros.Select
                StrCuenta = String.Empty
                If Engine.Length(Dr("IDClienteBanco")) > 0 Then
                    Dim DtBancoClie As DataTable = New ClienteBanco().SelOnPrimaryKey(Dr("IDClienteBanco"))
                    If Not DtBancoClie Is Nothing AndAlso DtBancoClie.Rows.Count > 0 Then
                        StrBanco = IIf(Engine.Length(DtBancoClie.Rows(0)("IDBanco")) <> 0, Format$(DtBancoClie.Rows(0)("IDBanco") & String.Empty, "0000"), "0000")
                        StrSucursal = IIf(Engine.Length(DtBancoClie.Rows(0)("Sucursal")) <> 0, Format$(DtBancoClie.Rows(0)("Sucursal") & String.Empty, "0000"), "0000")
                        StrDC = IIf(Engine.Length(DtBancoClie.Rows(0)("DigitoControl")) <> 0, Format$(DtBancoClie.Rows(0)("DigitoControl") & String.Empty, "00"), "00")
                        StrNCuenta = IIf(Engine.Length(DtBancoClie.Rows(0)("NCuenta")) <> 0, Format$(DtBancoClie.Rows(0)("NCuenta") & String.Empty, "0000000000"), "0000000000")
                        StrCuenta = StrBanco & StrSucursal & StrDC & StrNCuenta
                    End If
                End If
                If CalcularImportes(Dr("IdCobro"), dtmFechaNeg, strIdBancoPropio, DblImporteVto, DblInteresDto, IntDias, DblComisiones, intIdTipoRemesa, DblImpRepercutir) Then
                    Dim DrNew As DataRow = DtInforLineas.NewRow
                    If Engine.Length(Dr("NFactura")) <> 0 Then DrNew("NFactura") = Dr("NFactura")
                    If Engine.Length(Dr("IdCliente")) <> 0 Then DrNew("IdCliente") = Dr("IdCliente")
                    '//Cogemos el Título, la Población y la Provincia de la Dirección de giro del cliente.
                    Dim objFilterDirGiroClte As New Filter
                    objFilterDirGiroClte.Add(New NumberFilterItem("IDDireccion", Dr("IDDireccion")))
                    Dim objNegDirClte As New ClienteDireccion
                    Dim dtDireccionesGiro As DataTable = objNegDirClte.Filter(objFilterDirGiroClte)
                    If Not IsNothing(dtDireccionesGiro) AndAlso dtDireccionesGiro.Rows.Count > 0 Then
                        DrNew("Librado") = dtDireccionesGiro.Rows(0)("RazonSocial")
                        DrNew("Titulo") = dtDireccionesGiro.Rows(0)("Poblacion")
                        DrNew("Provincia") = dtDireccionesGiro.Rows(0)("Provincia")
                    End If
                    If Len(StrCuenta) > 0 Then DrNew("NCuenta") = StrCuenta

                    DrNew("ImporteVto") = DblImporteVto
                    DrNew("ARepercutirA") = DblImpRepercutir
                    DrNew("InteresDto") = DblInteresDto
                    DrNew("Comisiones") = DblComisiones
                    DrNew("TotalGastos") = DblInteresDto + DblComisiones
                    DrNew("ImporteNeto") = DblImporteVto - DrNew("TotalGastos")
                    DrNew("FechaVto") = Dr("FechaVencimiento")
                    DrNew("Dias") = IntDias
                    DtInforLineas.Rows.Add(DrNew)

                    'CALCULO DE LOS ACUMULADOS
                    DblImpTotalVto = xRound(DblImpTotalVto + DblImporteVto, IntNDecA)
                    DblImpTotalIntereses = xRound(DblImpTotalIntereses + DblInteresDto, IntNDecA)
                    DblImpTotalComisiones = xRound(DblImpTotalComisiones + DblComisiones, IntNDecA)
                End If
            Next
            mstrReportFormulas &= ";NDecimales=" & IntNDecA
            mdtInforme = DtInforLineas
        End If
        Return True
    End Function

    Private Function CalcularImportes(ByVal IntIdCobro As Integer, ByVal dtmFechaNeg As Date, _
                                      ByVal strIdBP As String, ByRef dblImporteVto As Double, ByRef dblInteresDto As Double, _
                                      ByRef intDias As Integer, ByRef dblComisiones As Double, ByRef intIDTipoNegociacion As Integer, _
                                      ByRef dblImpRepercutir As Double) As Boolean
        'Funcion que calcula datos que se mostraran en el intorme
        Dim dblPorcentaje As Double

        Dim DtCobro As DataTable = New Cobro().SelOnPrimaryKey(IntIdCobro)
        Dim DtMonedaA As DataTable = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Moneda.ObtenerMonedaA, New Object)
        Dim IntNDecA As Integer
        If DtMonedaA.Rows.Count > 0 Then IntNDecA = DtMonedaA.Rows(0)("NDecimalesImp")

        'CALCULO DEL IMPORTEVTO
        If Not DtCobro Is Nothing AndAlso DtCobro.Rows.Count > 0 Then
            dblImporteVto = xRound(DtCobro.Rows(0)("ImpVencimientoA"), IntNDecA)
            dblImpRepercutir = xRound(DtCobro.Rows(0)("ARepercutirA"), IntNDecA)
        End If

        'CALCULO DE LOS DIAS
        Dim enFecha As enumFecha
        CompararFecha(dtmFechaNeg, DtCobro.Rows(0)("FechaVencimiento"), enFecha)
        If enFecha = enumFecha.FechaMayor Or enFecha = enumFecha.FechaIgual Then
            intDias = 0
        Else
            intDias = Math.Abs(DateDiff(DateInterval.Day, DtCobro.Rows(0)("FechaVencimiento"), dtmFechaNeg))
        End If

        'CALCULO DEL INTERESDTO
        Dim DtBancoPropio As DataTable = New BancoPropio().SelOnPrimaryKey(strIdBP)

        'Miro si es una remesa al descuento o al cobro
        If intIDTipoNegociacion = enumTipoRemesa.RemesaAlDescuento Then
            Dim FilBanco As New Filter
            FilBanco.Add("IDBancoPropio", FilterOperator.Equal, strIdBP, FilterType.String)
            FilBanco.Add("NDiasDesde", FilterOperator.LessThanOrEqual, intDias)
            FilBanco.Add("NDiasHasta", FilterOperator.GreaterThanOrEqual, intDias)
            Dim DtBPIntereses As DataTable = New BancoPropioIntereses().Filter(FilBanco)
            If Not DtBPIntereses Is Nothing Then
                If DtBPIntereses.Rows.Count = 0 Then 'Si no hay lineas en ese BancoPropio, se coge el interes minimo
                    dblPorcentaje = DtBancoPropio.Rows(0)("InteresMinimo") / 100
                Else   'Si hay lineas el InteresMinimo es el porcentaje de la linea
                    If DtBPIntereses.Rows(0)("Porcentaje") >= DtBancoPropio.Rows(0)("InteresMinimo") Then
                        dblPorcentaje = DtBPIntereses.Rows(0)("Porcentaje") / 100
                    Else
                        dblPorcentaje = DtBancoPropio.Rows(0)("InteresMinimo") / 100
                    End If
                End If
                dblInteresDto = dblImporteVto * dblPorcentaje
                'Si Porcentaje < GastoMinimo del BancoPropio, se toma este GastoMinimo(que esta en MonedaA) como interesDto
                If dblInteresDto < DtBancoPropio.Rows(0)("GastoMinimo") Then
                    dblInteresDto = DtBancoPropio.Rows(0)("GastoMinimo")
                End If
                dblInteresDto = xRound(dblInteresDto, IntNDecA)
            End If
        End If
        'CALCULO  DE LAS COMISIONES
        dblComisiones = DtBancoPropio.Rows(0)("GastoFijo")
        Return True
    End Function

    Private Function CompararFecha(ByVal dtmFecha1 As Date, ByVal dtmFecha2 As Date, ByRef enFecha As enumFecha) As Long
        'Declaración de constantes, variables u objetos locales

        CompararFecha = False

        'Comienzo del Cuerpo de la Función
        If DatePart("yyyy", dtmFecha1) < DatePart("yyyy", dtmFecha2) Then
            enFecha = enumFecha.FechaMenor
        ElseIf DatePart("yyyy", dtmFecha1) > DatePart("yyyy", dtmFecha2) Then
            enFecha = enumFecha.FechaMayor
        ElseIf DatePart("yyyy", dtmFecha1) = DatePart("yyyy", dtmFecha2) Then
            If DatePart("m", dtmFecha1) < DatePart("m", dtmFecha2) Then
                enFecha = enumFecha.FechaMenor
            ElseIf DatePart("m", dtmFecha1) > DatePart("m", dtmFecha2) Then
                enFecha = enumFecha.FechaMayor
            ElseIf DatePart("m", dtmFecha1) = DatePart("m", dtmFecha2) Then
                If DatePart("d", dtmFecha1) < DatePart("d", dtmFecha2) Then
                    enFecha = enumFecha.FechaMenor
                ElseIf DatePart("d", dtmFecha1) > DatePart("d", dtmFecha2) Then
                    enFecha = enumFecha.FechaMayor
                ElseIf DatePart("d", dtmFecha1) = DatePart("d", dtmFecha2) Then
                    enFecha = enumFecha.FechaIgual
                End If
            End If
        End If

        'Fin del Cuerpo de la Función

        CompararFecha = True

    End Function

    '
    Private Function ObtenerClientes() As DataTable
        If Not mdtCobros Is Nothing AndAlso mdtCobros.Rows.Count > 0 Then
            Dim StrClientes(-1) As String
            Dim i As Integer = 0
            For Each Dr As DataRow In mdtCobros.Select
                ReDim Preserve StrClientes(i)
                StrClientes(i) = Dr("IDCliente")
                i += 1
            Next
            If StrClientes.Length > 0 Then
                Return New Cliente().Filter(New InListFilterItem("IDCliente", StrClientes, FilterType.Numeric))
            End If
        End If
        Return Nothing
    End Function

End Module
