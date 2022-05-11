Public Class frmCamAutEstadosCont
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
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents AdvIDEjercicio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblEjercicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescEjercicio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents txtTextoAsiento As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTextoAsiento As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.AdvIDEjercicio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblEjercicio = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescEjercicio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.txtTextoAsiento = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTextoAsiento = New Solmicro.Expertis.Engine.UI.Label
        Me.SuspendLayout()
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(64, 72)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 25)
        Me.cmbAceptar.TabIndex = 2
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(168, 72)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 25)
        Me.cmbCancelar.TabIndex = 3
        Me.cmbCancelar.Text = "Cancelar"
        '
        'AdvIDEjercicio
        '
        Me.AdvIDEjercicio.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDEjercicio.Location = New System.Drawing.Point(123, 16)
        Me.AdvIDEjercicio.Name = "AdvIDEjercicio"
        Me.AdvIDEjercicio.Size = New System.Drawing.Size(72, 23)
        Me.AdvIDEjercicio.TabIndex = 0
        '
        'lblEjercicio
        '
        Me.lblEjercicio.Location = New System.Drawing.Point(7, 16)
        Me.lblEjercicio.Name = "lblEjercicio"
        Me.lblEjercicio.Size = New System.Drawing.Size(110, 13)
        Me.lblEjercicio.TabIndex = 4
        Me.lblEjercicio.Tag = ""
        Me.lblEjercicio.Text = "Ejercicio Contable"
        '
        'ulDescEjercicio
        '
        Me.TryDataBinding(ulDescEjercicio, New System.Windows.Forms.Binding("Text", Me.AdvIDEjercicio, "DescEjercicio", True))
        Me.ulDescEjercicio.Location = New System.Drawing.Point(200, 16)
        Me.ulDescEjercicio.Name = "ulDescEjercicio"
        Me.ulDescEjercicio.Size = New System.Drawing.Size(144, 21)
        Me.ulDescEjercicio.TabIndex = 5
        '
        'txtTextoAsiento
        '
        Me.txtTextoAsiento.DisabledBackColor = System.Drawing.Color.White
        Me.txtTextoAsiento.Location = New System.Drawing.Point(123, 40)
        Me.txtTextoAsiento.Name = "txtTextoAsiento"
        Me.txtTextoAsiento.Size = New System.Drawing.Size(221, 21)
        Me.txtTextoAsiento.TabIndex = 1
        '
        'lblTextoAsiento
        '
        Me.lblTextoAsiento.Location = New System.Drawing.Point(7, 40)
        Me.lblTextoAsiento.Name = "lblTextoAsiento"
        Me.lblTextoAsiento.Size = New System.Drawing.Size(106, 13)
        Me.lblTextoAsiento.TabIndex = 6
        Me.lblTextoAsiento.Tag = ""
        Me.lblTextoAsiento.Text = "Texto del Asiento"
        '
        'frmCamAutEstadosCont
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(352, 109)
        Me.Controls.Add(Me.cmbAceptar)
        Me.Controls.Add(Me.cmbCancelar)
        Me.Controls.Add(Me.lblEjercicio)
        Me.Controls.Add(Me.ulDescEjercicio)
        Me.Controls.Add(Me.AdvIDEjercicio)
        Me.Controls.Add(Me.lblTextoAsiento)
        Me.Controls.Add(Me.txtTextoAsiento)
        Me.Name = "frmCamAutEstadosCont"
        Me.Text = "Contabilización por cambio automático"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public mstrEjercicio, mTextoAsiento As String

    Private Sub frmCamAutEstadosCont_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AdvIDEjercicio.Text = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, dtFechaApunte)
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Engine.Length(Me.AdvIDEjercicio.Text) > 0 Then
            ExpertisApp.GenerateMessage("Debe introducir un Ejercicio Contable.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.AdvIDEjercicio.Focus()
        Else
            mstrEjercicioActual = Me.AdvIDEjercicio.Text
            mTextoAsiento = txtTextoAsiento.Text & String.Empty
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
