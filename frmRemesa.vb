
Public Class frmRemesa
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
    Friend WithEvents FwiIDRemesa As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFwiIDRemesa As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FwiIDRemesa = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFwiIDRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(185, 39)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(90, 27)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(186, 6)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(90, 27)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "Aceptar"
        '
        'FwiIDRemesa
        '
        Me.FwiIDRemesa.EntityName = "Remesa"
        Me.FwiIDRemesa.Location = New System.Drawing.Point(68, 23)
        Me.FwiIDRemesa.Name = "FwiIDRemesa"
        Me.FwiIDRemesa.SecondaryDataFields = "IDRemesa"
        Me.FwiIDRemesa.Size = New System.Drawing.Size(75, 21)
        Me.FwiIDRemesa.TabIndex = 0
        Me.FwiIDRemesa.ViewName = "tbRemesa"
        '
        'lblFwiIDRemesa
        '
        Me.lblFwiIDRemesa.Location = New System.Drawing.Point(14, 23)
        Me.lblFwiIDRemesa.Name = "lblFwiIDRemesa"
        Me.lblFwiIDRemesa.Size = New System.Drawing.Size(49, 17)
        Me.lblFwiIDRemesa.TabIndex = 3
        Me.lblFwiIDRemesa.Text = "Remesa"
        '
        'frmRemesa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(280, 77)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.lblFwiIDRemesa)
        Me.Controls.Add(Me.FwiIDRemesa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRemesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elige la Remesa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Propiedades "

    Private mlngIDRemesa As Integer
    Public ReadOnly Property IDRemesa() As Integer
        Get
            Return mlngIDRemesa
        End Get
    End Property


    Private mblnAnticipo As Boolean = False
    Public WriteOnly Property Anticipo() As Boolean
        Set(ByVal Value As Boolean)
            mblnAnticipo = Value
        End Set
    End Property


#End Region


    Private Sub FwiIDRemesa_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles FwiIDRemesa.SetPredefinedFilter
        If mblnAnticipo Then
            e.Filter.Add("IdTipoNegociacion", FilterOperator.Equal, enumTipoRemesa.RemesaAnticipo, FilterType.Numeric)
        Else
            e.Filter.Add("IdTipoNegociacion", FilterOperator.NotEqual, enumTipoRemesa.RemesaAnticipo, FilterType.Numeric)
        End If
    End Sub


    Private Sub FwiIDRemesa_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles FwiIDRemesa.Validating
        If Length(FwiIDRemesa.Value) > 0 Then
            Dim BEDataEngine As New DataEngine
            Dim dtRemesa As DataTable = BEDataEngine.Filter("tbRemesa", New FilterItem("IDRemesa", FilterOperator.Equal, FwiIDRemesa.Value))
            If IsNothing(dtRemesa) OrElse dtRemesa.Rows.Count = 0 Then
                FwiIDRemesa.Text = String.Empty
                e.Cancel = True
            Else
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Length(FwiIDRemesa.Value) > 0 Then
            mlngIDRemesa = FwiIDRemesa.Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            If mblnAnticipo Then
                ExpertisApp.GenerateMessage("El Anticipo indicado no existe.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ExpertisApp.GenerateMessage("La Remesa indicada no existe.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        mlngIDRemesa = 0
        Me.Close()
    End Sub

End Class
