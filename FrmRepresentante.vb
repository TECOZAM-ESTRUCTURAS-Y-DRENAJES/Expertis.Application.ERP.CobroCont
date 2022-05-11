Public Class FrmRepresentante
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
    Friend WithEvents lblTitulo2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvRepresentante As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTitulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblRepresentante As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmdOk As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdCancel As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblTitulo2 = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvRepresentante = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cmdOk = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.lblTitulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblRepresentante = New Solmicro.Expertis.Engine.UI.Label
        Me.SuspendLayout()
        '
        'lblTitulo2
        '
        Me.lblTitulo2.Location = New System.Drawing.Point(8, 32)
        Me.lblTitulo2.Name = "lblTitulo2"
        Me.lblTitulo2.Size = New System.Drawing.Size(468, 17)
        Me.lblTitulo2.TabIndex = 0
        Me.lblTitulo2.Text = "Si desea un listado completo de todos los representantes  no seleccione ninguno."
        '
        'AdvRepresentante
        '
        Me.AdvRepresentante.EntityName = "Representante"
        Me.AdvRepresentante.Location = New System.Drawing.Point(240, 64)
        Me.AdvRepresentante.Name = "AdvRepresentante"
        Me.AdvRepresentante.PrimaryDataFields = "IDRepresentante"
        Me.AdvRepresentante.SecondaryDataFields = "IDRepresentante"
        Me.AdvRepresentante.Size = New System.Drawing.Size(75, 21)
        Me.AdvRepresentante.TabIndex = 1
        Me.AdvRepresentante.ViewName = "tbMaestroRepresentante"
        '
        'cmdOk
        '
        Me.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOk.Location = New System.Drawing.Point(160, 96)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Text = "Aceptar"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(232, 96)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Cancelar"
        '
        'lblTitulo
        '
        Me.lblTitulo.Location = New System.Drawing.Point(8, 8)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(358, 17)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Seleccione el representante del que desea obtener el informe."
        '
        'lblRepresentante
        '
        Me.lblRepresentante.Location = New System.Drawing.Point(144, 64)
        Me.lblRepresentante.Name = "lblRepresentante"
        Me.lblRepresentante.Size = New System.Drawing.Size(87, 17)
        Me.lblRepresentante.TabIndex = 5
        Me.lblRepresentante.Text = "Representante"
        '
        'FrmRepresentante
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(480, 133)
        Me.Controls.Add(Me.lblRepresentante)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.AdvRepresentante)
        Me.Controls.Add(Me.lblTitulo2)
        Me.EntityName = "Representante"
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRepresentante"
        Me.NavigationFields = "IDRepresentante"
        Me.Text = "Representante"
        Me.ViewName = "tbMaestroRepresentante"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mstrIDRepresentante As String

    Public ReadOnly Property Representante() As String
        Get
            Return mstrIDRepresentante
        End Get
    End Property
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        mstrIDRepresentante = AdvRepresentante.Value & String.Empty
        Me.Dispose()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Dispose()
    End Sub

    
End Class
