Public Class MntoTipoCobro
    Inherits Solmicro.Expertis.Engine.UI.GridMnto

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 26)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(696, 24)
        '
        'Toolbar
        '
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(412, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Location = New System.Drawing.Point(0, 50)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(696, 459)
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAgrupacion", "Agrupacion", "IDAgrupacion")})
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IdTipoCobro""" & _
        "><Caption>Tipo Cobro</Caption><DataMember>IdTipoCobro</DataMember><Key>IdTipoCob" & _
        "ro</Key><Position>0</Position><TextAlignment>Far</TextAlignment></Column0><Colum" & _
        "n1 ID=""DescTipo""><Caption>Desc. Tipo</Caption><DataMember>DescTipo</DataMember><" & _
        "Key>DescTipo</Key><Position>1</Position><TextAlignment>Near</TextAlignment><Widt" & _
        "h>267</Width></Column1><Column2 ID=""Abreviatura""><Caption>Abreviatura</Caption><" & _
        "DataMember>Abreviatura</DataMember><Key>Abreviatura</Key><Position>2</Position><" & _
        "TextAlignment>Near</TextAlignment></Column2><Column3 ID=""Sistema""><Caption>Siste" & _
        "ma</Caption><DataMember>Sistema</DataMember><EditType>CheckBox</EditType><Key>Si" & _
        "stema</Key><Position>3</Position><TextAlignment>Near</TextAlignment><Visible>Fal" & _
        "se</Visible></Column3><Column4 ID=""FechaCreacionAudi""><Caption>FechaCreacionAudi" & _
        "</Caption><DataMember>FechaCreacionAudi</DataMember><Key>FechaCreacionAudi</Key>" & _
        "<Position>4</Position><TextAlignment>Near</TextAlignment><Visible>False</Visible" & _
        "></Column4><Column5 ID=""FechaModificacionAudi""><Caption>FechaModificacionAudi</C" & _
        "aption><DataMember>FechaModificacionAudi</DataMember><Key>FechaModificacionAudi<" & _
        "/Key><Position>5</Position><TextAlignment>Near</TextAlignment><Visible>False</Vi" & _
        "sible></Column5><Column6 ID=""UsuarioAudi""><Caption>UsuarioAudi</Caption><DataMem" & _
        "ber>UsuarioAudi</DataMember><Key>UsuarioAudi</Key><Position>6</Position><TextAli" & _
        "gnment>Near</TextAlignment><Visible>False</Visible></Column6><Column7 ID=""Especi" & _
        "al""><Caption>Especial</Caption><ColumnType>CheckBox</ColumnType><DataMember>Espe" & _
        "cial</DataMember><EditType>CheckBox</EditType><Key>Especial</Key><Position>7</Po" & _
        "sition><TextAlignment>Far</TextAlignment><Width>60</Width></Column7><Column8 ID=" & _
        """IDAgrupacion""><Caption>Cód.Agrupación</Caption><DataMember>IDAgrupacion</DataMe" & _
        "mber><Key>IDAgrupacion</Key><Position>8</Position><TextAlignment>Near</TextAlign" & _
        "ment><Width>87</Width></Column8></Columns><GroupCondition ID="""" /></RootTable></" & _
        "GridEXLayoutData>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.EntityName = "TipoCobro"
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(696, 459)
        Me.Grid.ViewName = "vfrmMntoTipoCobro"
        '
        'MntoTipoCobro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "TipoCobro"
        Me.Name = "MntoTipoCobro"
        Me.ViewName = "vfrmMntoTipoCobro"
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        With Grid
            Select Case e.Column.Key
                Case "IDTipoCobro"
                    If Engine.Length(Grid.Value("IDTipoCobro")) > 0 Then
                        e.Cancel = (.Row <> Grid.newTopRowPosition)
                    End If
            End Select
        End With
    End Sub

End Class



