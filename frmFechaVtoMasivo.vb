Public Class frmFechaVtoMasivo
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
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents fwiFechaVencimiento As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblfwiFechaVencimiento As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.fwiFechaVencimiento = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaVencimiento = New Solmicro.Expertis.Engine.UI.Label
        Me.SuspendLayout()
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(159, 55)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 25)
        Me.cmbCancelar.TabIndex = 2
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(65, 55)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 25)
        Me.cmbAceptar.TabIndex = 1
        Me.cmbAceptar.Text = "Aceptar"
        '
        'fwiFechaVencimiento
        '
        Me.fwiFechaVencimiento.Location = New System.Drawing.Point(90, 17)
        Me.fwiFechaVencimiento.Name = "fwiFechaVencimiento"
        Me.fwiFechaVencimiento.Size = New System.Drawing.Size(80, 21)
        Me.fwiFechaVencimiento.TabIndex = 0
        '
        'lblfwiFechaVencimiento
        '
        Me.lblfwiFechaVencimiento.Location = New System.Drawing.Point(30, 17)
        Me.lblfwiFechaVencimiento.Name = "lblfwiFechaVencimiento"
        Me.lblfwiFechaVencimiento.Size = New System.Drawing.Size(37, 17)
        Me.lblfwiFechaVencimiento.TabIndex = 3
        Me.lblfwiFechaVencimiento.Text = "Fecha"
        '
        'frmFechaVtoMasivo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(256, 85)
        Me.Controls.Add(Me.cmbCancelar)
        Me.Controls.Add(Me.cmbAceptar)
        Me.Controls.Add(Me.lblfwiFechaVencimiento)
        Me.Controls.Add(Me.fwiFechaVencimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFechaVtoMasivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = """Nueva Fecha de Vencimiento"""
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public dtFechaVencimiento As Date

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Engine.Length(fwiFechaVencimiento.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe introducir la nueva fecha de vencimiento.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
            dtFechaVencimiento = fwiFechaVencimiento.Value
            Me.Close()
        End If
    End Sub

End Class
