
Public Class FrmAgrupaCobros
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
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents chkFechaVto As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCambioA As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCambioB As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkFPago As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkDireccion As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkBancoCliente As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkMoneda As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCliente As Solmicro.Expertis.Engine.UI.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkFechaVto = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCambioA = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCambioB = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkFPago = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkDireccion = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkBancoCliente = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkMoneda = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCliente = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkFechaVto
        '
        Me.chkFechaVto.Location = New System.Drawing.Point(22, 33)
        Me.chkFechaVto.Name = "chkFechaVto"
        Me.chkFechaVto.Size = New System.Drawing.Size(98, 20)
        Me.chkFechaVto.TabIndex = 0
        Me.chkFechaVto.Text = "Fecha Vto."
        '
        'chkCambioA
        '
        Me.chkCambioA.Location = New System.Drawing.Point(22, 72)
        Me.chkCambioA.Name = "chkCambioA"
        Me.chkCambioA.Size = New System.Drawing.Size(98, 20)
        Me.chkCambioA.TabIndex = 2
        Me.chkCambioA.Text = "Cambio A"
        '
        'chkCambioB
        '
        Me.chkCambioB.Location = New System.Drawing.Point(126, 14)
        Me.chkCambioB.Name = "chkCambioB"
        Me.chkCambioB.Size = New System.Drawing.Size(98, 20)
        Me.chkCambioB.TabIndex = 3
        Me.chkCambioB.Text = "Cambio B"
        '
        'chkFPago
        '
        Me.chkFPago.Location = New System.Drawing.Point(126, 33)
        Me.chkFPago.Name = "chkFPago"
        Me.chkFPago.Size = New System.Drawing.Size(98, 20)
        Me.chkFPago.TabIndex = 4
        Me.chkFPago.Text = "Forma Pago"
        '
        'chkDireccion
        '
        Me.chkDireccion.Location = New System.Drawing.Point(126, 53)
        Me.chkDireccion.Name = "chkDireccion"
        Me.chkDireccion.Size = New System.Drawing.Size(98, 20)
        Me.chkDireccion.TabIndex = 5
        Me.chkDireccion.Text = "Dirección"
        '
        'chkBancoCliente
        '
        Me.chkBancoCliente.Location = New System.Drawing.Point(126, 72)
        Me.chkBancoCliente.Name = "chkBancoCliente"
        Me.chkBancoCliente.Size = New System.Drawing.Size(98, 20)
        Me.chkBancoCliente.TabIndex = 6
        Me.chkBancoCliente.Text = "Banco Cliente"
        '
        'chkMoneda
        '
        Me.chkMoneda.Location = New System.Drawing.Point(22, 53)
        Me.chkMoneda.Name = "chkMoneda"
        Me.chkMoneda.Size = New System.Drawing.Size(98, 20)
        Me.chkMoneda.TabIndex = 1
        Me.chkMoneda.Text = "Moneda"
        '
        'chkCliente
        '
        Me.chkCliente.Enabled = False
        Me.chkCliente.Location = New System.Drawing.Point(22, 14)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(98, 20)
        Me.chkCliente.TabIndex = 7
        Me.chkCliente.Text = "Cliente"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(238, Byte), CType(238, Byte))
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 40)
        Me.Panel1.TabIndex = 10
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(32, 6)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(85, 28)
        Me.cmbAceptar.TabIndex = 11
        Me.cmbAceptar.Text = "&Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(131, 6)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(85, 28)
        Me.cmbCancelar.TabIndex = 10
        Me.cmbCancelar.Text = "&Cancelar"
        '
        'FrmAgrupaCobros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(248, 141)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chkFechaVto)
        Me.Controls.Add(Me.chkCambioA)
        Me.Controls.Add(Me.chkCambioB)
        Me.Controls.Add(Me.chkFPago)
        Me.Controls.Add(Me.chkDireccion)
        Me.Controls.Add(Me.chkBancoCliente)
        Me.Controls.Add(Me.chkMoneda)
        Me.Controls.Add(Me.chkCliente)
        Me.Name = "FrmAgrupaCobros"
        Me.Text = "Selección de la agrupación"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Const cntCobrosBancoCli As String = "CO_GR_BCLE"
    Private Const cntCobrosCambioA As String = "CO_GR_CAMA"
    Private Const cntCobrosCambioB As String = "CO_GR_CAMB"
    Private Const cntCobrosCliente As String = "CO_GR_CLTE"
    Private Const cntCobrosDirEnv As String = "CO_GR_DIRE"
    Private Const cntCobrosFPago As String = "CO_GR_FP"
    Private Const cntCobrosFechaV As String = "CO_GR_FVTO"
    Private Const cntCobrosMoneda As String = "CO_GR_MONE"

    Private dtParametro As DataTable
    Private p As New Parametro
    Private mblnGrabar As Boolean

    Private Sub CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaVto.CheckedChanged, chkCambioA.CheckedChanged, chkCambioB.CheckedChanged, chkFPago.CheckedChanged, chkDireccion.CheckedChanged, chkBancoCliente.CheckedChanged, chkMoneda.CheckedChanged, chkCliente.CheckedChanged
        mblnGrabar = True
    End Sub

    Private Sub FrmAgrupaCobros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtParametro = p.ConfiguracionAgrupacionCobros

        For Each dr As DataRow In dtParametro.Rows
            If dr("IdParametro") = cntCobrosCliente Then
                chkCliente.Checked = dr("Valor")
            ElseIf dr("IdParametro") = cntCobrosFechaV Then
                chkFechaVto.Checked = dr("Valor")
            ElseIf dr("IdParametro") = cntCobrosMoneda Then
                chkMoneda.Checked = dr("Valor")
            ElseIf dr("IdParametro") = cntCobrosCambioA Then
                chkCambioA.Checked = dr("Valor")
            ElseIf dr("IdParametro") = cntCobrosCambioB Then
                chkCambioB.Checked = dr("Valor")
            ElseIf dr("IdParametro") = cntCobrosFPago Then
                chkFPago.Checked = dr("Valor")
            ElseIf dr("IdParametro") = cntCobrosDirEnv Then
                chkDireccion.Checked = dr("Valor")
            ElseIf dr("IdParametro") = cntCobrosBancoCli Then
                chkBancoCliente.Checked = dr("Valor")
            End If
        Next

    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Try
            If mblnGrabar Then
                For Each dr As DataRow In dtParametro.Rows
                    If dr("IdParametro") = cntCobrosCliente Then
                        dr("Valor") = CInt(chkCliente.Checked)
                    ElseIf dr("IdParametro") = cntCobrosFechaV Then
                        dr("Valor") = CInt(chkFechaVto.Checked)
                    ElseIf dr("IdParametro") = cntCobrosMoneda Then
                        dr("Valor") = CInt(chkMoneda.Checked)
                    ElseIf dr("IdParametro") = cntCobrosCambioA Then
                        dr("Valor") = CInt(chkCambioA.Checked)
                    ElseIf dr("IdParametro") = cntCobrosCambioB Then
                        dr("Valor") = CInt(chkCambioB.Checked)
                    ElseIf dr("IdParametro") = cntCobrosFPago Then
                        dr("Valor") = CInt(chkFPago.Checked)
                    ElseIf dr("IdParametro") = cntCobrosDirEnv Then
                        dr("Valor") = CInt(chkDireccion.Checked)
                    ElseIf dr("IdParametro") = cntCobrosBancoCli Then
                        dr("Valor") = CInt(chkBancoCliente.Checked)
                    End If
                Next

                p.Update(dtParametro)
            End If
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
