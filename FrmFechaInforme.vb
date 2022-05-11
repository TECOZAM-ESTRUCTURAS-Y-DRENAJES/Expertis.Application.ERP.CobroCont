Public Class FrmFechaInforme
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
    Friend WithEvents LblFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.SuspendLayout()
        '
        'LblFecha
        '
        Me.LblFecha.Location = New System.Drawing.Point(24, 23)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(37, 17)
        Me.LblFecha.TabIndex = 0
        Me.LblFecha.Text = "Fecha"
        Me.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClbFecha
        '
        Me.ClbFecha.Location = New System.Drawing.Point(72, 23)
        Me.ClbFecha.Name = "ClbFecha"
        Me.ClbFecha.Size = New System.Drawing.Size(144, 21)
        Me.ClbFecha.TabIndex = 0
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(33, 71)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(88, 32)
        Me.BtnAceptar.TabIndex = 1
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(129, 71)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(88, 32)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'FrmFechaInforme
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(250, 127)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.ClbFecha)
        Me.Controls.Add(Me.LblFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFechaInforme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmFechaInforme"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private DtFecha As Date

    Public Property FechaInforme() As Date
        Get
            Return DtFecha
        End Get
        Set(ByVal Value As Date)
            DtFecha = Value
        End Set
    End Property

    Private Sub FrmFechaInforme_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClbFecha.Value = Today.Date
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Engine.Length(ClbFecha.Value) > 0 Then
            DtFecha = ClbFecha.Value
            Me.DialogResult = DialogResult.OK
        Else
            ExpertisApp.GenerateMessage("Debe Introducir una Fecha para el Informe.", MessageBoxButtons.OK, MessageBoxIcon.Information, "Introducir Fecha")
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class
