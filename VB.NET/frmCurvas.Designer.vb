<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCurvas
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmbCurvas As System.Windows.Forms.ComboBox
    Public WithEvents frmAreva_Curvas As System.Windows.Forms.GroupBox
    Public WithEvents txtTime_dial As System.Windows.Forms.TextBox
    Public WithEvents txtTolerancia As System.Windows.Forms.TextBox
    Public WithEvents txtCorrente_aplicada As System.Windows.Forms.TextBox
    Public WithEvents txtCorrente_pickup As System.Windows.Forms.TextBox
    Public WithEvents lblCorrente_aplicada_unidade As System.Windows.Forms.Label
    Public WithEvents lblCorrente_pickup_unidade As System.Windows.Forms.Label
    Public WithEvents lblTime_dial As System.Windows.Forms.Label
    Public WithEvents lblTolerancia_unidade As System.Windows.Forms.Label
    Public WithEvents lblTolerancia As System.Windows.Forms.Label
    Public WithEvents lblCorrente_aplicada As System.Windows.Forms.Label
    Public WithEvents lblCorrente_pickup As System.Windows.Forms.Label
    Public WithEvents frmAreva_Dados As System.Windows.Forms.GroupBox
    Public WithEvents txtTempo_maximo As System.Windows.Forms.TextBox
    Public WithEvents txtTempo_minimo As System.Windows.Forms.TextBox
    Public WithEvents txtTempo_calculado As System.Windows.Forms.TextBox
    Public WithEvents lblTempo_maximo_unidade As System.Windows.Forms.Label
    Public WithEvents lblTempo_minimo_unidade As System.Windows.Forms.Label
    Public WithEvents lblTempo_calculado_unidade As System.Windows.Forms.Label
    Public WithEvents lblTempo_maximo As System.Windows.Forms.Label
    Public WithEvents lblTempo_minimo As System.Windows.Forms.Label
    Public WithEvents lblTempo_calculado As System.Windows.Forms.Label
    Public WithEvents frmAreva_Resultados As System.Windows.Forms.GroupBox
    Public WithEvents _tabEmpresa_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents txtTempo_calculado_ge As System.Windows.Forms.TextBox
    Public WithEvents txtTempo_minimo_ge As System.Windows.Forms.TextBox
    Public WithEvents txtTempo_maximo_ge As System.Windows.Forms.TextBox
    Public WithEvents lblTempo_calculado_ge As System.Windows.Forms.Label
    Public WithEvents lblTempo_minimo_ge As System.Windows.Forms.Label
    Public WithEvents lblTempo_maximo_ge As System.Windows.Forms.Label
    Public WithEvents lblTempo_calculado_unidade_ge As System.Windows.Forms.Label
    Public WithEvents lblTempo_minimo_unidade_ge As System.Windows.Forms.Label
    Public WithEvents lblTempo_maximo_unidade_ge As System.Windows.Forms.Label
    Public WithEvents frmGE_Resultados As System.Windows.Forms.GroupBox
    Public WithEvents txtCorrente_pickup_ge As System.Windows.Forms.TextBox
    Public WithEvents txtCorrente_aplicada_ge As System.Windows.Forms.TextBox
    Public WithEvents txtTolerancia_ge As System.Windows.Forms.TextBox
    Public WithEvents txtTime_dial_ge As System.Windows.Forms.TextBox
    Public WithEvents lblCorrente_pickup_ge As System.Windows.Forms.Label
    Public WithEvents lblCorrente_aplicada_ge As System.Windows.Forms.Label
    Public WithEvents lblTolerancia_ge As System.Windows.Forms.Label
    Public WithEvents lblTolerancia_unidade_ge As System.Windows.Forms.Label
    Public WithEvents lblTime_dial_ge As System.Windows.Forms.Label
    Public WithEvents lblCorrente_pickup_unidade_ge As System.Windows.Forms.Label
    Public WithEvents lblCorrente_aplicada_unidade_ge As System.Windows.Forms.Label
    Public WithEvents frmGE_Dados As System.Windows.Forms.GroupBox
    Public WithEvents cmbCurvas_ge As System.Windows.Forms.ComboBox
    Public WithEvents frmGE_Curvas As System.Windows.Forms.GroupBox
    Public WithEvents _tabEmpresa_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents lblSobre_01 As System.Windows.Forms.Label
    Public WithEvents lblSobre_02 As System.Windows.Forms.Label
    Public WithEvents lblSite As System.Windows.Forms.Label
    Public WithEvents lblSobre_03 As System.Windows.Forms.Label
    Public WithEvents lblEmail As System.Windows.Forms.Label
    Public WithEvents _tabEmpresa_TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents tabEmpresa As System.Windows.Forms.TabControl
    Public WithEvents btnCalcular As System.Windows.Forms.Button
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabEmpresa = New System.Windows.Forms.TabControl
        Me._tabEmpresa_TabPage0 = New System.Windows.Forms.TabPage
        Me.frmAreva_Curvas = New System.Windows.Forms.GroupBox
        Me.cmbCurvas = New System.Windows.Forms.ComboBox
        Me.frmAreva_Dados = New System.Windows.Forms.GroupBox
        Me.txtTime_dial = New System.Windows.Forms.TextBox
        Me.txtTolerancia = New System.Windows.Forms.TextBox
        Me.txtCorrente_aplicada = New System.Windows.Forms.TextBox
        Me.txtCorrente_pickup = New System.Windows.Forms.TextBox
        Me.lblCorrente_aplicada_unidade = New System.Windows.Forms.Label
        Me.lblCorrente_pickup_unidade = New System.Windows.Forms.Label
        Me.lblTime_dial = New System.Windows.Forms.Label
        Me.lblTolerancia_unidade = New System.Windows.Forms.Label
        Me.lblTolerancia = New System.Windows.Forms.Label
        Me.lblCorrente_aplicada = New System.Windows.Forms.Label
        Me.lblCorrente_pickup = New System.Windows.Forms.Label
        Me.frmAreva_Resultados = New System.Windows.Forms.GroupBox
        Me.txtTempo_maximo = New System.Windows.Forms.TextBox
        Me.txtTempo_minimo = New System.Windows.Forms.TextBox
        Me.txtTempo_calculado = New System.Windows.Forms.TextBox
        Me.lblTempo_maximo_unidade = New System.Windows.Forms.Label
        Me.lblTempo_minimo_unidade = New System.Windows.Forms.Label
        Me.lblTempo_calculado_unidade = New System.Windows.Forms.Label
        Me.lblTempo_maximo = New System.Windows.Forms.Label
        Me.lblTempo_minimo = New System.Windows.Forms.Label
        Me.lblTempo_calculado = New System.Windows.Forms.Label
        Me._tabEmpresa_TabPage1 = New System.Windows.Forms.TabPage
        Me.frmGE_Resultados = New System.Windows.Forms.GroupBox
        Me.txtTempo_calculado_ge = New System.Windows.Forms.TextBox
        Me.txtTempo_minimo_ge = New System.Windows.Forms.TextBox
        Me.txtTempo_maximo_ge = New System.Windows.Forms.TextBox
        Me.lblTempo_calculado_ge = New System.Windows.Forms.Label
        Me.lblTempo_minimo_ge = New System.Windows.Forms.Label
        Me.lblTempo_maximo_ge = New System.Windows.Forms.Label
        Me.lblTempo_calculado_unidade_ge = New System.Windows.Forms.Label
        Me.lblTempo_minimo_unidade_ge = New System.Windows.Forms.Label
        Me.lblTempo_maximo_unidade_ge = New System.Windows.Forms.Label
        Me.frmGE_Dados = New System.Windows.Forms.GroupBox
        Me.txtCorrente_pickup_ge = New System.Windows.Forms.TextBox
        Me.txtCorrente_aplicada_ge = New System.Windows.Forms.TextBox
        Me.txtTolerancia_ge = New System.Windows.Forms.TextBox
        Me.txtTime_dial_ge = New System.Windows.Forms.TextBox
        Me.lblCorrente_pickup_ge = New System.Windows.Forms.Label
        Me.lblCorrente_aplicada_ge = New System.Windows.Forms.Label
        Me.lblTolerancia_ge = New System.Windows.Forms.Label
        Me.lblTolerancia_unidade_ge = New System.Windows.Forms.Label
        Me.lblTime_dial_ge = New System.Windows.Forms.Label
        Me.lblCorrente_pickup_unidade_ge = New System.Windows.Forms.Label
        Me.lblCorrente_aplicada_unidade_ge = New System.Windows.Forms.Label
        Me.frmGE_Curvas = New System.Windows.Forms.GroupBox
        Me.cmbCurvas_ge = New System.Windows.Forms.ComboBox
        Me._tabEmpresa_TabPage2 = New System.Windows.Forms.TabPage
        Me.lblSobre_01 = New System.Windows.Forms.Label
        Me.lblSobre_02 = New System.Windows.Forms.Label
        Me.lblSite = New System.Windows.Forms.Label
        Me.lblSobre_03 = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.btnCalcular = New System.Windows.Forms.Button
        Me.btnFechar = New System.Windows.Forms.Button
        Me.tabEmpresa.SuspendLayout()
        Me._tabEmpresa_TabPage0.SuspendLayout()
        Me.frmAreva_Curvas.SuspendLayout()
        Me.frmAreva_Dados.SuspendLayout()
        Me.frmAreva_Resultados.SuspendLayout()
        Me._tabEmpresa_TabPage1.SuspendLayout()
        Me.frmGE_Resultados.SuspendLayout()
        Me.frmGE_Dados.SuspendLayout()
        Me.frmGE_Curvas.SuspendLayout()
        Me._tabEmpresa_TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabEmpresa
        '
        Me.tabEmpresa.Controls.Add(Me._tabEmpresa_TabPage0)
        Me.tabEmpresa.Controls.Add(Me._tabEmpresa_TabPage1)
        Me.tabEmpresa.Controls.Add(Me._tabEmpresa_TabPage2)
        Me.tabEmpresa.ItemSize = New System.Drawing.Size(42, 18)
        Me.tabEmpresa.Location = New System.Drawing.Point(8, 8)
        Me.tabEmpresa.Name = "tabEmpresa"
        Me.tabEmpresa.SelectedIndex = 0
        Me.tabEmpresa.Size = New System.Drawing.Size(305, 257)
        Me.tabEmpresa.TabIndex = 2
        '
        '_tabEmpresa_TabPage0
        '
        Me._tabEmpresa_TabPage0.Controls.Add(Me.frmAreva_Curvas)
        Me._tabEmpresa_TabPage0.Controls.Add(Me.frmAreva_Dados)
        Me._tabEmpresa_TabPage0.Controls.Add(Me.frmAreva_Resultados)
        Me._tabEmpresa_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._tabEmpresa_TabPage0.Name = "_tabEmpresa_TabPage0"
        Me._tabEmpresa_TabPage0.Size = New System.Drawing.Size(297, 231)
        Me._tabEmpresa_TabPage0.TabIndex = 0
        Me._tabEmpresa_TabPage0.Text = "Areva"
        '
        'frmAreva_Curvas
        '
        Me.frmAreva_Curvas.BackColor = System.Drawing.SystemColors.Control
        Me.frmAreva_Curvas.Controls.Add(Me.cmbCurvas)
        Me.frmAreva_Curvas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmAreva_Curvas.Location = New System.Drawing.Point(3, 4)
        Me.frmAreva_Curvas.Name = "frmAreva_Curvas"
        Me.frmAreva_Curvas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmAreva_Curvas.Size = New System.Drawing.Size(289, 57)
        Me.frmAreva_Curvas.TabIndex = 3
        Me.frmAreva_Curvas.TabStop = False
        Me.frmAreva_Curvas.Text = "Selecione uma Curva"
        '
        'cmbCurvas
        '
        Me.cmbCurvas.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCurvas.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCurvas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurvas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCurvas.Items.AddRange(New Object() {"ANSI/IEEE Extremely Inverse", "ANSI/IEEE Very Inverse", "ANSI/IEEE Moderately Inverse", "IEC Extremely Inverse", "IEC Very Inverse", "IEC Standard Inverse", "UK Long Time Inverse", "UK Rectifier", "US Inverse", "US Short Time Inverse"})
        Me.cmbCurvas.Location = New System.Drawing.Point(8, 24)
        Me.cmbCurvas.Name = "cmbCurvas"
        Me.cmbCurvas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCurvas.Size = New System.Drawing.Size(273, 21)
        Me.cmbCurvas.TabIndex = 6
        '
        'frmAreva_Dados
        '
        Me.frmAreva_Dados.BackColor = System.Drawing.SystemColors.Control
        Me.frmAreva_Dados.Controls.Add(Me.txtTime_dial)
        Me.frmAreva_Dados.Controls.Add(Me.txtTolerancia)
        Me.frmAreva_Dados.Controls.Add(Me.txtCorrente_aplicada)
        Me.frmAreva_Dados.Controls.Add(Me.txtCorrente_pickup)
        Me.frmAreva_Dados.Controls.Add(Me.lblCorrente_aplicada_unidade)
        Me.frmAreva_Dados.Controls.Add(Me.lblCorrente_pickup_unidade)
        Me.frmAreva_Dados.Controls.Add(Me.lblTime_dial)
        Me.frmAreva_Dados.Controls.Add(Me.lblTolerancia_unidade)
        Me.frmAreva_Dados.Controls.Add(Me.lblTolerancia)
        Me.frmAreva_Dados.Controls.Add(Me.lblCorrente_aplicada)
        Me.frmAreva_Dados.Controls.Add(Me.lblCorrente_pickup)
        Me.frmAreva_Dados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmAreva_Dados.Location = New System.Drawing.Point(3, 68)
        Me.frmAreva_Dados.Name = "frmAreva_Dados"
        Me.frmAreva_Dados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmAreva_Dados.Size = New System.Drawing.Size(289, 73)
        Me.frmAreva_Dados.TabIndex = 4
        Me.frmAreva_Dados.TabStop = False
        Me.frmAreva_Dados.Text = "Dados"
        '
        'txtTime_dial
        '
        Me.txtTime_dial.AcceptsReturn = True
        Me.txtTime_dial.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime_dial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime_dial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTime_dial.Location = New System.Drawing.Point(208, 16)
        Me.txtTime_dial.MaxLength = 0
        Me.txtTime_dial.Name = "txtTime_dial"
        Me.txtTime_dial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTime_dial.Size = New System.Drawing.Size(49, 20)
        Me.txtTime_dial.TabIndex = 9
        Me.txtTime_dial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTolerancia
        '
        Me.txtTolerancia.AcceptsReturn = True
        Me.txtTolerancia.BackColor = System.Drawing.SystemColors.Window
        Me.txtTolerancia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTolerancia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTolerancia.Location = New System.Drawing.Point(208, 40)
        Me.txtTolerancia.MaxLength = 0
        Me.txtTolerancia.Name = "txtTolerancia"
        Me.txtTolerancia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTolerancia.Size = New System.Drawing.Size(49, 20)
        Me.txtTolerancia.TabIndex = 10
        Me.txtTolerancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCorrente_aplicada
        '
        Me.txtCorrente_aplicada.AcceptsReturn = True
        Me.txtCorrente_aplicada.BackColor = System.Drawing.SystemColors.Window
        Me.txtCorrente_aplicada.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorrente_aplicada.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCorrente_aplicada.Location = New System.Drawing.Point(56, 40)
        Me.txtCorrente_aplicada.MaxLength = 0
        Me.txtCorrente_aplicada.Name = "txtCorrente_aplicada"
        Me.txtCorrente_aplicada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCorrente_aplicada.Size = New System.Drawing.Size(49, 20)
        Me.txtCorrente_aplicada.TabIndex = 8
        Me.txtCorrente_aplicada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCorrente_pickup
        '
        Me.txtCorrente_pickup.AcceptsReturn = True
        Me.txtCorrente_pickup.BackColor = System.Drawing.SystemColors.Window
        Me.txtCorrente_pickup.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorrente_pickup.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCorrente_pickup.Location = New System.Drawing.Point(56, 16)
        Me.txtCorrente_pickup.MaxLength = 0
        Me.txtCorrente_pickup.Name = "txtCorrente_pickup"
        Me.txtCorrente_pickup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCorrente_pickup.Size = New System.Drawing.Size(49, 20)
        Me.txtCorrente_pickup.TabIndex = 7
        Me.txtCorrente_pickup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCorrente_aplicada_unidade
        '
        Me.lblCorrente_aplicada_unidade.AutoSize = True
        Me.lblCorrente_aplicada_unidade.BackColor = System.Drawing.SystemColors.Control
        Me.lblCorrente_aplicada_unidade.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCorrente_aplicada_unidade.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCorrente_aplicada_unidade.Location = New System.Drawing.Point(112, 43)
        Me.lblCorrente_aplicada_unidade.Name = "lblCorrente_aplicada_unidade"
        Me.lblCorrente_aplicada_unidade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCorrente_aplicada_unidade.Size = New System.Drawing.Size(14, 13)
        Me.lblCorrente_aplicada_unidade.TabIndex = 31
        Me.lblCorrente_aplicada_unidade.Text = "A"
        '
        'lblCorrente_pickup_unidade
        '
        Me.lblCorrente_pickup_unidade.AutoSize = True
        Me.lblCorrente_pickup_unidade.BackColor = System.Drawing.SystemColors.Control
        Me.lblCorrente_pickup_unidade.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCorrente_pickup_unidade.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCorrente_pickup_unidade.Location = New System.Drawing.Point(112, 19)
        Me.lblCorrente_pickup_unidade.Name = "lblCorrente_pickup_unidade"
        Me.lblCorrente_pickup_unidade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCorrente_pickup_unidade.Size = New System.Drawing.Size(14, 13)
        Me.lblCorrente_pickup_unidade.TabIndex = 30
        Me.lblCorrente_pickup_unidade.Text = "A"
        '
        'lblTime_dial
        '
        Me.lblTime_dial.AutoSize = True
        Me.lblTime_dial.BackColor = System.Drawing.SystemColors.Control
        Me.lblTime_dial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTime_dial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTime_dial.Location = New System.Drawing.Point(186, 19)
        Me.lblTime_dial.Name = "lblTime_dial"
        Me.lblTime_dial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTime_dial.Size = New System.Drawing.Size(25, 13)
        Me.lblTime_dial.TabIndex = 29
        Me.lblTime_dial.Text = "TD:"
        '
        'lblTolerancia_unidade
        '
        Me.lblTolerancia_unidade.AutoSize = True
        Me.lblTolerancia_unidade.BackColor = System.Drawing.SystemColors.Control
        Me.lblTolerancia_unidade.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTolerancia_unidade.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTolerancia_unidade.Location = New System.Drawing.Point(262, 43)
        Me.lblTolerancia_unidade.Name = "lblTolerancia_unidade"
        Me.lblTolerancia_unidade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTolerancia_unidade.Size = New System.Drawing.Size(15, 13)
        Me.lblTolerancia_unidade.TabIndex = 28
        Me.lblTolerancia_unidade.Text = "%"
        '
        'lblTolerancia
        '
        Me.lblTolerancia.AutoSize = True
        Me.lblTolerancia.BackColor = System.Drawing.SystemColors.Control
        Me.lblTolerancia.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTolerancia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTolerancia.Location = New System.Drawing.Point(182, 43)
        Me.lblTolerancia.Name = "lblTolerancia"
        Me.lblTolerancia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTolerancia.Size = New System.Drawing.Size(29, 13)
        Me.lblTolerancia.TabIndex = 27
        Me.lblTolerancia.Text = "Erro:"
        '
        'lblCorrente_aplicada
        '
        Me.lblCorrente_aplicada.AutoSize = True
        Me.lblCorrente_aplicada.BackColor = System.Drawing.SystemColors.Control
        Me.lblCorrente_aplicada.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCorrente_aplicada.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCorrente_aplicada.Location = New System.Drawing.Point(6, 43)
        Me.lblCorrente_aplicada.Name = "lblCorrente_aplicada"
        Me.lblCorrente_aplicada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCorrente_aplicada.Size = New System.Drawing.Size(53, 13)
        Me.lblCorrente_aplicada.TabIndex = 26
        Me.lblCorrente_aplicada.Text = "Iaplicada:"
        '
        'lblCorrente_pickup
        '
        Me.lblCorrente_pickup.AutoSize = True
        Me.lblCorrente_pickup.BackColor = System.Drawing.SystemColors.Control
        Me.lblCorrente_pickup.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCorrente_pickup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCorrente_pickup.Location = New System.Drawing.Point(14, 19)
        Me.lblCorrente_pickup.Name = "lblCorrente_pickup"
        Me.lblCorrente_pickup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCorrente_pickup.Size = New System.Drawing.Size(45, 13)
        Me.lblCorrente_pickup.TabIndex = 25
        Me.lblCorrente_pickup.Text = "Ipickup:"
        '
        'frmAreva_Resultados
        '
        Me.frmAreva_Resultados.BackColor = System.Drawing.SystemColors.Control
        Me.frmAreva_Resultados.Controls.Add(Me.txtTempo_maximo)
        Me.frmAreva_Resultados.Controls.Add(Me.txtTempo_minimo)
        Me.frmAreva_Resultados.Controls.Add(Me.txtTempo_calculado)
        Me.frmAreva_Resultados.Controls.Add(Me.lblTempo_maximo_unidade)
        Me.frmAreva_Resultados.Controls.Add(Me.lblTempo_minimo_unidade)
        Me.frmAreva_Resultados.Controls.Add(Me.lblTempo_calculado_unidade)
        Me.frmAreva_Resultados.Controls.Add(Me.lblTempo_maximo)
        Me.frmAreva_Resultados.Controls.Add(Me.lblTempo_minimo)
        Me.frmAreva_Resultados.Controls.Add(Me.lblTempo_calculado)
        Me.frmAreva_Resultados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmAreva_Resultados.Location = New System.Drawing.Point(3, 148)
        Me.frmAreva_Resultados.Name = "frmAreva_Resultados"
        Me.frmAreva_Resultados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmAreva_Resultados.Size = New System.Drawing.Size(289, 81)
        Me.frmAreva_Resultados.TabIndex = 5
        Me.frmAreva_Resultados.TabStop = False
        Me.frmAreva_Resultados.Text = "Resultado obtido"
        '
        'txtTempo_maximo
        '
        Me.txtTempo_maximo.AcceptsReturn = True
        Me.txtTempo_maximo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTempo_maximo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTempo_maximo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTempo_maximo.Location = New System.Drawing.Point(208, 48)
        Me.txtTempo_maximo.MaxLength = 5
        Me.txtTempo_maximo.Name = "txtTempo_maximo"
        Me.txtTempo_maximo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTempo_maximo.Size = New System.Drawing.Size(57, 20)
        Me.txtTempo_maximo.TabIndex = 13
        Me.txtTempo_maximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTempo_minimo
        '
        Me.txtTempo_minimo.AcceptsReturn = True
        Me.txtTempo_minimo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTempo_minimo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTempo_minimo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTempo_minimo.Location = New System.Drawing.Point(8, 48)
        Me.txtTempo_minimo.MaxLength = 5
        Me.txtTempo_minimo.Name = "txtTempo_minimo"
        Me.txtTempo_minimo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTempo_minimo.Size = New System.Drawing.Size(57, 20)
        Me.txtTempo_minimo.TabIndex = 11
        Me.txtTempo_minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTempo_calculado
        '
        Me.txtTempo_calculado.AcceptsReturn = True
        Me.txtTempo_calculado.BackColor = System.Drawing.SystemColors.Window
        Me.txtTempo_calculado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTempo_calculado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTempo_calculado.Location = New System.Drawing.Point(104, 48)
        Me.txtTempo_calculado.MaxLength = 5
        Me.txtTempo_calculado.Name = "txtTempo_calculado"
        Me.txtTempo_calculado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTempo_calculado.Size = New System.Drawing.Size(57, 20)
        Me.txtTempo_calculado.TabIndex = 12
        Me.txtTempo_calculado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTempo_maximo_unidade
        '
        Me.lblTempo_maximo_unidade.AutoSize = True
        Me.lblTempo_maximo_unidade.BackColor = System.Drawing.SystemColors.Control
        Me.lblTempo_maximo_unidade.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempo_maximo_unidade.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempo_maximo_unidade.Location = New System.Drawing.Point(266, 51)
        Me.lblTempo_maximo_unidade.Name = "lblTempo_maximo_unidade"
        Me.lblTempo_maximo_unidade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo_maximo_unidade.Size = New System.Drawing.Size(20, 13)
        Me.lblTempo_maximo_unidade.TabIndex = 37
        Me.lblTempo_maximo_unidade.Text = "ms"
        '
        'lblTempo_minimo_unidade
        '
        Me.lblTempo_minimo_unidade.AutoSize = True
        Me.lblTempo_minimo_unidade.BackColor = System.Drawing.SystemColors.Control
        Me.lblTempo_minimo_unidade.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempo_minimo_unidade.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempo_minimo_unidade.Location = New System.Drawing.Point(66, 51)
        Me.lblTempo_minimo_unidade.Name = "lblTempo_minimo_unidade"
        Me.lblTempo_minimo_unidade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo_minimo_unidade.Size = New System.Drawing.Size(20, 13)
        Me.lblTempo_minimo_unidade.TabIndex = 36
        Me.lblTempo_minimo_unidade.Text = "ms"
        '
        'lblTempo_calculado_unidade
        '
        Me.lblTempo_calculado_unidade.AutoSize = True
        Me.lblTempo_calculado_unidade.BackColor = System.Drawing.SystemColors.Control
        Me.lblTempo_calculado_unidade.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempo_calculado_unidade.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempo_calculado_unidade.Location = New System.Drawing.Point(162, 51)
        Me.lblTempo_calculado_unidade.Name = "lblTempo_calculado_unidade"
        Me.lblTempo_calculado_unidade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo_calculado_unidade.Size = New System.Drawing.Size(20, 13)
        Me.lblTempo_calculado_unidade.TabIndex = 35
        Me.lblTempo_calculado_unidade.Text = "ms"
        '
        'lblTempo_maximo
        '
        Me.lblTempo_maximo.AutoSize = True
        Me.lblTempo_maximo.BackColor = System.Drawing.SystemColors.Control
        Me.lblTempo_maximo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempo_maximo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempo_maximo.Location = New System.Drawing.Point(200, 24)
        Me.lblTempo_maximo.Name = "lblTempo_maximo"
        Me.lblTempo_maximo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo_maximo.Size = New System.Drawing.Size(79, 13)
        Me.lblTempo_maximo.TabIndex = 34
        Me.lblTempo_maximo.Text = "Tempo Máximo"
        '
        'lblTempo_minimo
        '
        Me.lblTempo_minimo.AutoSize = True
        Me.lblTempo_minimo.BackColor = System.Drawing.SystemColors.Control
        Me.lblTempo_minimo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempo_minimo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempo_minimo.Location = New System.Drawing.Point(2, 24)
        Me.lblTempo_minimo.Name = "lblTempo_minimo"
        Me.lblTempo_minimo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo_minimo.Size = New System.Drawing.Size(78, 13)
        Me.lblTempo_minimo.TabIndex = 33
        Me.lblTempo_minimo.Text = "Tempo Mínimo"
        '
        'lblTempo_calculado
        '
        Me.lblTempo_calculado.AutoSize = True
        Me.lblTempo_calculado.BackColor = System.Drawing.SystemColors.Control
        Me.lblTempo_calculado.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempo_calculado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempo_calculado.Location = New System.Drawing.Point(93, 24)
        Me.lblTempo_calculado.Name = "lblTempo_calculado"
        Me.lblTempo_calculado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo_calculado.Size = New System.Drawing.Size(90, 13)
        Me.lblTempo_calculado.TabIndex = 32
        Me.lblTempo_calculado.Text = "Tempo Calculado"
        '
        '_tabEmpresa_TabPage1
        '
        Me._tabEmpresa_TabPage1.Controls.Add(Me.frmGE_Resultados)
        Me._tabEmpresa_TabPage1.Controls.Add(Me.frmGE_Dados)
        Me._tabEmpresa_TabPage1.Controls.Add(Me.frmGE_Curvas)
        Me._tabEmpresa_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._tabEmpresa_TabPage1.Name = "_tabEmpresa_TabPage1"
        Me._tabEmpresa_TabPage1.Size = New System.Drawing.Size(297, 231)
        Me._tabEmpresa_TabPage1.TabIndex = 1
        Me._tabEmpresa_TabPage1.Text = "GE"
        '
        'frmGE_Resultados
        '
        Me.frmGE_Resultados.BackColor = System.Drawing.SystemColors.Control
        Me.frmGE_Resultados.Controls.Add(Me.txtTempo_calculado_ge)
        Me.frmGE_Resultados.Controls.Add(Me.txtTempo_minimo_ge)
        Me.frmGE_Resultados.Controls.Add(Me.txtTempo_maximo_ge)
        Me.frmGE_Resultados.Controls.Add(Me.lblTempo_calculado_ge)
        Me.frmGE_Resultados.Controls.Add(Me.lblTempo_minimo_ge)
        Me.frmGE_Resultados.Controls.Add(Me.lblTempo_maximo_ge)
        Me.frmGE_Resultados.Controls.Add(Me.lblTempo_calculado_unidade_ge)
        Me.frmGE_Resultados.Controls.Add(Me.lblTempo_minimo_unidade_ge)
        Me.frmGE_Resultados.Controls.Add(Me.lblTempo_maximo_unidade_ge)
        Me.frmGE_Resultados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmGE_Resultados.Location = New System.Drawing.Point(3, 148)
        Me.frmGE_Resultados.Name = "frmGE_Resultados"
        Me.frmGE_Resultados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmGE_Resultados.Size = New System.Drawing.Size(289, 81)
        Me.frmGE_Resultados.TabIndex = 16
        Me.frmGE_Resultados.TabStop = False
        Me.frmGE_Resultados.Text = "Resultado obtido"
        '
        'txtTempo_calculado_ge
        '
        Me.txtTempo_calculado_ge.AcceptsReturn = True
        Me.txtTempo_calculado_ge.BackColor = System.Drawing.SystemColors.Window
        Me.txtTempo_calculado_ge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTempo_calculado_ge.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTempo_calculado_ge.Location = New System.Drawing.Point(104, 48)
        Me.txtTempo_calculado_ge.MaxLength = 5
        Me.txtTempo_calculado_ge.Name = "txtTempo_calculado_ge"
        Me.txtTempo_calculado_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTempo_calculado_ge.Size = New System.Drawing.Size(57, 20)
        Me.txtTempo_calculado_ge.TabIndex = 23
        Me.txtTempo_calculado_ge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTempo_minimo_ge
        '
        Me.txtTempo_minimo_ge.AcceptsReturn = True
        Me.txtTempo_minimo_ge.BackColor = System.Drawing.SystemColors.Window
        Me.txtTempo_minimo_ge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTempo_minimo_ge.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTempo_minimo_ge.Location = New System.Drawing.Point(8, 48)
        Me.txtTempo_minimo_ge.MaxLength = 5
        Me.txtTempo_minimo_ge.Name = "txtTempo_minimo_ge"
        Me.txtTempo_minimo_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTempo_minimo_ge.Size = New System.Drawing.Size(57, 20)
        Me.txtTempo_minimo_ge.TabIndex = 22
        Me.txtTempo_minimo_ge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTempo_maximo_ge
        '
        Me.txtTempo_maximo_ge.AcceptsReturn = True
        Me.txtTempo_maximo_ge.BackColor = System.Drawing.SystemColors.Window
        Me.txtTempo_maximo_ge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTempo_maximo_ge.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTempo_maximo_ge.Location = New System.Drawing.Point(208, 48)
        Me.txtTempo_maximo_ge.MaxLength = 5
        Me.txtTempo_maximo_ge.Name = "txtTempo_maximo_ge"
        Me.txtTempo_maximo_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTempo_maximo_ge.Size = New System.Drawing.Size(57, 20)
        Me.txtTempo_maximo_ge.TabIndex = 24
        Me.txtTempo_maximo_ge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTempo_calculado_ge
        '
        Me.lblTempo_calculado_ge.AutoSize = True
        Me.lblTempo_calculado_ge.BackColor = System.Drawing.SystemColors.Control
        Me.lblTempo_calculado_ge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempo_calculado_ge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempo_calculado_ge.Location = New System.Drawing.Point(93, 24)
        Me.lblTempo_calculado_ge.Name = "lblTempo_calculado_ge"
        Me.lblTempo_calculado_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo_calculado_ge.Size = New System.Drawing.Size(90, 13)
        Me.lblTempo_calculado_ge.TabIndex = 43
        Me.lblTempo_calculado_ge.Text = "Tempo Calculado"
        '
        'lblTempo_minimo_ge
        '
        Me.lblTempo_minimo_ge.AutoSize = True
        Me.lblTempo_minimo_ge.BackColor = System.Drawing.SystemColors.Control
        Me.lblTempo_minimo_ge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempo_minimo_ge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempo_minimo_ge.Location = New System.Drawing.Point(2, 24)
        Me.lblTempo_minimo_ge.Name = "lblTempo_minimo_ge"
        Me.lblTempo_minimo_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo_minimo_ge.Size = New System.Drawing.Size(78, 13)
        Me.lblTempo_minimo_ge.TabIndex = 42
        Me.lblTempo_minimo_ge.Text = "Tempo Mínimo"
        '
        'lblTempo_maximo_ge
        '
        Me.lblTempo_maximo_ge.AutoSize = True
        Me.lblTempo_maximo_ge.BackColor = System.Drawing.SystemColors.Control
        Me.lblTempo_maximo_ge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempo_maximo_ge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempo_maximo_ge.Location = New System.Drawing.Point(200, 24)
        Me.lblTempo_maximo_ge.Name = "lblTempo_maximo_ge"
        Me.lblTempo_maximo_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo_maximo_ge.Size = New System.Drawing.Size(79, 13)
        Me.lblTempo_maximo_ge.TabIndex = 41
        Me.lblTempo_maximo_ge.Text = "Tempo Máximo"
        '
        'lblTempo_calculado_unidade_ge
        '
        Me.lblTempo_calculado_unidade_ge.AutoSize = True
        Me.lblTempo_calculado_unidade_ge.BackColor = System.Drawing.SystemColors.Control
        Me.lblTempo_calculado_unidade_ge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempo_calculado_unidade_ge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempo_calculado_unidade_ge.Location = New System.Drawing.Point(162, 51)
        Me.lblTempo_calculado_unidade_ge.Name = "lblTempo_calculado_unidade_ge"
        Me.lblTempo_calculado_unidade_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo_calculado_unidade_ge.Size = New System.Drawing.Size(20, 13)
        Me.lblTempo_calculado_unidade_ge.TabIndex = 40
        Me.lblTempo_calculado_unidade_ge.Text = "ms"
        '
        'lblTempo_minimo_unidade_ge
        '
        Me.lblTempo_minimo_unidade_ge.AutoSize = True
        Me.lblTempo_minimo_unidade_ge.BackColor = System.Drawing.SystemColors.Control
        Me.lblTempo_minimo_unidade_ge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempo_minimo_unidade_ge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempo_minimo_unidade_ge.Location = New System.Drawing.Point(66, 51)
        Me.lblTempo_minimo_unidade_ge.Name = "lblTempo_minimo_unidade_ge"
        Me.lblTempo_minimo_unidade_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo_minimo_unidade_ge.Size = New System.Drawing.Size(20, 13)
        Me.lblTempo_minimo_unidade_ge.TabIndex = 39
        Me.lblTempo_minimo_unidade_ge.Text = "ms"
        '
        'lblTempo_maximo_unidade_ge
        '
        Me.lblTempo_maximo_unidade_ge.AutoSize = True
        Me.lblTempo_maximo_unidade_ge.BackColor = System.Drawing.SystemColors.Control
        Me.lblTempo_maximo_unidade_ge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempo_maximo_unidade_ge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempo_maximo_unidade_ge.Location = New System.Drawing.Point(266, 51)
        Me.lblTempo_maximo_unidade_ge.Name = "lblTempo_maximo_unidade_ge"
        Me.lblTempo_maximo_unidade_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo_maximo_unidade_ge.Size = New System.Drawing.Size(20, 13)
        Me.lblTempo_maximo_unidade_ge.TabIndex = 38
        Me.lblTempo_maximo_unidade_ge.Text = "ms"
        '
        'frmGE_Dados
        '
        Me.frmGE_Dados.BackColor = System.Drawing.SystemColors.Control
        Me.frmGE_Dados.Controls.Add(Me.txtCorrente_pickup_ge)
        Me.frmGE_Dados.Controls.Add(Me.txtCorrente_aplicada_ge)
        Me.frmGE_Dados.Controls.Add(Me.txtTolerancia_ge)
        Me.frmGE_Dados.Controls.Add(Me.txtTime_dial_ge)
        Me.frmGE_Dados.Controls.Add(Me.lblCorrente_pickup_ge)
        Me.frmGE_Dados.Controls.Add(Me.lblCorrente_aplicada_ge)
        Me.frmGE_Dados.Controls.Add(Me.lblTolerancia_ge)
        Me.frmGE_Dados.Controls.Add(Me.lblTolerancia_unidade_ge)
        Me.frmGE_Dados.Controls.Add(Me.lblTime_dial_ge)
        Me.frmGE_Dados.Controls.Add(Me.lblCorrente_pickup_unidade_ge)
        Me.frmGE_Dados.Controls.Add(Me.lblCorrente_aplicada_unidade_ge)
        Me.frmGE_Dados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmGE_Dados.Location = New System.Drawing.Point(3, 68)
        Me.frmGE_Dados.Name = "frmGE_Dados"
        Me.frmGE_Dados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmGE_Dados.Size = New System.Drawing.Size(289, 73)
        Me.frmGE_Dados.TabIndex = 15
        Me.frmGE_Dados.TabStop = False
        Me.frmGE_Dados.Text = "Dados"
        '
        'txtCorrente_pickup_ge
        '
        Me.txtCorrente_pickup_ge.AcceptsReturn = True
        Me.txtCorrente_pickup_ge.BackColor = System.Drawing.SystemColors.Window
        Me.txtCorrente_pickup_ge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorrente_pickup_ge.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCorrente_pickup_ge.Location = New System.Drawing.Point(56, 16)
        Me.txtCorrente_pickup_ge.MaxLength = 0
        Me.txtCorrente_pickup_ge.Name = "txtCorrente_pickup_ge"
        Me.txtCorrente_pickup_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCorrente_pickup_ge.Size = New System.Drawing.Size(49, 20)
        Me.txtCorrente_pickup_ge.TabIndex = 18
        Me.txtCorrente_pickup_ge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCorrente_aplicada_ge
        '
        Me.txtCorrente_aplicada_ge.AcceptsReturn = True
        Me.txtCorrente_aplicada_ge.BackColor = System.Drawing.SystemColors.Window
        Me.txtCorrente_aplicada_ge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorrente_aplicada_ge.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCorrente_aplicada_ge.Location = New System.Drawing.Point(56, 40)
        Me.txtCorrente_aplicada_ge.MaxLength = 0
        Me.txtCorrente_aplicada_ge.Name = "txtCorrente_aplicada_ge"
        Me.txtCorrente_aplicada_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCorrente_aplicada_ge.Size = New System.Drawing.Size(49, 20)
        Me.txtCorrente_aplicada_ge.TabIndex = 19
        Me.txtCorrente_aplicada_ge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTolerancia_ge
        '
        Me.txtTolerancia_ge.AcceptsReturn = True
        Me.txtTolerancia_ge.BackColor = System.Drawing.SystemColors.Window
        Me.txtTolerancia_ge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTolerancia_ge.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTolerancia_ge.Location = New System.Drawing.Point(208, 40)
        Me.txtTolerancia_ge.MaxLength = 0
        Me.txtTolerancia_ge.Name = "txtTolerancia_ge"
        Me.txtTolerancia_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTolerancia_ge.Size = New System.Drawing.Size(49, 20)
        Me.txtTolerancia_ge.TabIndex = 21
        Me.txtTolerancia_ge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTime_dial_ge
        '
        Me.txtTime_dial_ge.AcceptsReturn = True
        Me.txtTime_dial_ge.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime_dial_ge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime_dial_ge.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTime_dial_ge.Location = New System.Drawing.Point(208, 16)
        Me.txtTime_dial_ge.MaxLength = 0
        Me.txtTime_dial_ge.Name = "txtTime_dial_ge"
        Me.txtTime_dial_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTime_dial_ge.Size = New System.Drawing.Size(49, 20)
        Me.txtTime_dial_ge.TabIndex = 20
        Me.txtTime_dial_ge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCorrente_pickup_ge
        '
        Me.lblCorrente_pickup_ge.AutoSize = True
        Me.lblCorrente_pickup_ge.BackColor = System.Drawing.SystemColors.Control
        Me.lblCorrente_pickup_ge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCorrente_pickup_ge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCorrente_pickup_ge.Location = New System.Drawing.Point(14, 19)
        Me.lblCorrente_pickup_ge.Name = "lblCorrente_pickup_ge"
        Me.lblCorrente_pickup_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCorrente_pickup_ge.Size = New System.Drawing.Size(45, 13)
        Me.lblCorrente_pickup_ge.TabIndex = 50
        Me.lblCorrente_pickup_ge.Text = "Ipickup:"
        '
        'lblCorrente_aplicada_ge
        '
        Me.lblCorrente_aplicada_ge.AutoSize = True
        Me.lblCorrente_aplicada_ge.BackColor = System.Drawing.SystemColors.Control
        Me.lblCorrente_aplicada_ge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCorrente_aplicada_ge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCorrente_aplicada_ge.Location = New System.Drawing.Point(6, 43)
        Me.lblCorrente_aplicada_ge.Name = "lblCorrente_aplicada_ge"
        Me.lblCorrente_aplicada_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCorrente_aplicada_ge.Size = New System.Drawing.Size(53, 13)
        Me.lblCorrente_aplicada_ge.TabIndex = 49
        Me.lblCorrente_aplicada_ge.Text = "Iaplicada:"
        '
        'lblTolerancia_ge
        '
        Me.lblTolerancia_ge.AutoSize = True
        Me.lblTolerancia_ge.BackColor = System.Drawing.SystemColors.Control
        Me.lblTolerancia_ge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTolerancia_ge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTolerancia_ge.Location = New System.Drawing.Point(182, 43)
        Me.lblTolerancia_ge.Name = "lblTolerancia_ge"
        Me.lblTolerancia_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTolerancia_ge.Size = New System.Drawing.Size(29, 13)
        Me.lblTolerancia_ge.TabIndex = 48
        Me.lblTolerancia_ge.Text = "Erro:"
        '
        'lblTolerancia_unidade_ge
        '
        Me.lblTolerancia_unidade_ge.AutoSize = True
        Me.lblTolerancia_unidade_ge.BackColor = System.Drawing.SystemColors.Control
        Me.lblTolerancia_unidade_ge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTolerancia_unidade_ge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTolerancia_unidade_ge.Location = New System.Drawing.Point(262, 43)
        Me.lblTolerancia_unidade_ge.Name = "lblTolerancia_unidade_ge"
        Me.lblTolerancia_unidade_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTolerancia_unidade_ge.Size = New System.Drawing.Size(15, 13)
        Me.lblTolerancia_unidade_ge.TabIndex = 47
        Me.lblTolerancia_unidade_ge.Text = "%"
        '
        'lblTime_dial_ge
        '
        Me.lblTime_dial_ge.AutoSize = True
        Me.lblTime_dial_ge.BackColor = System.Drawing.SystemColors.Control
        Me.lblTime_dial_ge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTime_dial_ge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTime_dial_ge.Location = New System.Drawing.Point(186, 19)
        Me.lblTime_dial_ge.Name = "lblTime_dial_ge"
        Me.lblTime_dial_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTime_dial_ge.Size = New System.Drawing.Size(25, 13)
        Me.lblTime_dial_ge.TabIndex = 46
        Me.lblTime_dial_ge.Text = "TD:"
        '
        'lblCorrente_pickup_unidade_ge
        '
        Me.lblCorrente_pickup_unidade_ge.AutoSize = True
        Me.lblCorrente_pickup_unidade_ge.BackColor = System.Drawing.SystemColors.Control
        Me.lblCorrente_pickup_unidade_ge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCorrente_pickup_unidade_ge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCorrente_pickup_unidade_ge.Location = New System.Drawing.Point(112, 19)
        Me.lblCorrente_pickup_unidade_ge.Name = "lblCorrente_pickup_unidade_ge"
        Me.lblCorrente_pickup_unidade_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCorrente_pickup_unidade_ge.Size = New System.Drawing.Size(14, 13)
        Me.lblCorrente_pickup_unidade_ge.TabIndex = 45
        Me.lblCorrente_pickup_unidade_ge.Text = "A"
        '
        'lblCorrente_aplicada_unidade_ge
        '
        Me.lblCorrente_aplicada_unidade_ge.AutoSize = True
        Me.lblCorrente_aplicada_unidade_ge.BackColor = System.Drawing.SystemColors.Control
        Me.lblCorrente_aplicada_unidade_ge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCorrente_aplicada_unidade_ge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCorrente_aplicada_unidade_ge.Location = New System.Drawing.Point(112, 43)
        Me.lblCorrente_aplicada_unidade_ge.Name = "lblCorrente_aplicada_unidade_ge"
        Me.lblCorrente_aplicada_unidade_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCorrente_aplicada_unidade_ge.Size = New System.Drawing.Size(14, 13)
        Me.lblCorrente_aplicada_unidade_ge.TabIndex = 44
        Me.lblCorrente_aplicada_unidade_ge.Text = "A"
        '
        'frmGE_Curvas
        '
        Me.frmGE_Curvas.BackColor = System.Drawing.SystemColors.Control
        Me.frmGE_Curvas.Controls.Add(Me.cmbCurvas_ge)
        Me.frmGE_Curvas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmGE_Curvas.Location = New System.Drawing.Point(3, 4)
        Me.frmGE_Curvas.Name = "frmGE_Curvas"
        Me.frmGE_Curvas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmGE_Curvas.Size = New System.Drawing.Size(289, 57)
        Me.frmGE_Curvas.TabIndex = 14
        Me.frmGE_Curvas.TabStop = False
        Me.frmGE_Curvas.Text = "Selecione uma Curva"
        '
        'cmbCurvas_ge
        '
        Me.cmbCurvas_ge.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCurvas_ge.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCurvas_ge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurvas_ge.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCurvas_ge.Items.AddRange(New Object() {"ANSI Extremely Inverse", "ANSI Very Inverse", "ANSI Normaly Inverse", "ANSI Moderately Inverse", "IEC Extremely Inverse (Curve C)", "IEC Very Inverse (Curve B)", "IEC Standard Inverse (Curve A)", "IEC Short Time Inverse", "IEEE Extremely Inverse", "IEEE Very Inverse", "IEEE Moderately Inverse", "IAC Extremely Inverse", "IAC Very Inverse", "IAC Inverse", "IAC Short Inverse", "i2t"})
        Me.cmbCurvas_ge.Location = New System.Drawing.Point(8, 24)
        Me.cmbCurvas_ge.Name = "cmbCurvas_ge"
        Me.cmbCurvas_ge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCurvas_ge.Size = New System.Drawing.Size(273, 21)
        Me.cmbCurvas_ge.TabIndex = 17
        '
        '_tabEmpresa_TabPage2
        '
        Me._tabEmpresa_TabPage2.Controls.Add(Me.lblSobre_01)
        Me._tabEmpresa_TabPage2.Controls.Add(Me.lblSobre_02)
        Me._tabEmpresa_TabPage2.Controls.Add(Me.lblSite)
        Me._tabEmpresa_TabPage2.Controls.Add(Me.lblSobre_03)
        Me._tabEmpresa_TabPage2.Controls.Add(Me.lblEmail)
        Me._tabEmpresa_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._tabEmpresa_TabPage2.Name = "_tabEmpresa_TabPage2"
        Me._tabEmpresa_TabPage2.Size = New System.Drawing.Size(297, 231)
        Me._tabEmpresa_TabPage2.TabIndex = 2
        Me._tabEmpresa_TabPage2.Text = "Sobre"
        '
        'lblSobre_01
        '
        Me.lblSobre_01.BackColor = System.Drawing.SystemColors.Control
        Me.lblSobre_01.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSobre_01.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSobre_01.Location = New System.Drawing.Point(16, 32)
        Me.lblSobre_01.Name = "lblSobre_01"
        Me.lblSobre_01.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSobre_01.Size = New System.Drawing.Size(273, 41)
        Me.lblSobre_01.TabIndex = 51
        Me.lblSobre_01.Text = "Este software foi desenvolvido pela equipe técnica da Know-how Info System."
        '
        'lblSobre_02
        '
        Me.lblSobre_02.AutoSize = True
        Me.lblSobre_02.BackColor = System.Drawing.SystemColors.Control
        Me.lblSobre_02.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSobre_02.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSobre_02.Location = New System.Drawing.Point(16, 112)
        Me.lblSobre_02.Name = "lblSobre_02"
        Me.lblSobre_02.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSobre_02.Size = New System.Drawing.Size(154, 13)
        Me.lblSobre_02.TabIndex = 52
        Me.lblSobre_02.Text = "Visite nossa página na internet:"
        '
        'lblSite
        '
        Me.lblSite.AutoSize = True
        Me.lblSite.BackColor = System.Drawing.SystemColors.Control
        Me.lblSite.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSite.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSite.Location = New System.Drawing.Point(16, 128)
        Me.lblSite.Name = "lblSite"
        Me.lblSite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSite.Size = New System.Drawing.Size(119, 13)
        Me.lblSite.TabIndex = 53
        Me.lblSite.Text = "http://www.khis.com.br"
        '
        'lblSobre_03
        '
        Me.lblSobre_03.AutoSize = True
        Me.lblSobre_03.BackColor = System.Drawing.SystemColors.Control
        Me.lblSobre_03.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSobre_03.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSobre_03.Location = New System.Drawing.Point(16, 160)
        Me.lblSobre_03.Name = "lblSobre_03"
        Me.lblSobre_03.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSobre_03.Size = New System.Drawing.Size(124, 13)
        Me.lblSobre_03.TabIndex = 54
        Me.lblSobre_03.Text = "Ou envie um e-mail para:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.SystemColors.Control
        Me.lblEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblEmail.Location = New System.Drawing.Point(16, 176)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEmail.Size = New System.Drawing.Size(107, 13)
        Me.lblEmail.TabIndex = 55
        Me.lblEmail.Text = "suporte@khis.com.br"
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.SystemColors.Control
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCalcular.Enabled = False
        Me.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalcular.Location = New System.Drawing.Point(15, 272)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalcular.Size = New System.Drawing.Size(81, 33)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(223, 272)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(81, 33)
        Me.btnFechar.TabIndex = 3
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frmCurvas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(322, 309)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.tabEmpresa)
        Me.Controls.Add(Me.btnCalcular)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCurvas"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cáculo do Tempo de Atuação da Função 51"
        Me.tabEmpresa.ResumeLayout(False)
        Me._tabEmpresa_TabPage0.ResumeLayout(False)
        Me.frmAreva_Curvas.ResumeLayout(False)
        Me.frmAreva_Dados.ResumeLayout(False)
        Me.frmAreva_Dados.PerformLayout()
        Me.frmAreva_Resultados.ResumeLayout(False)
        Me.frmAreva_Resultados.PerformLayout()
        Me._tabEmpresa_TabPage1.ResumeLayout(False)
        Me.frmGE_Resultados.ResumeLayout(False)
        Me.frmGE_Resultados.PerformLayout()
        Me.frmGE_Dados.ResumeLayout(False)
        Me.frmGE_Dados.PerformLayout()
        Me.frmGE_Curvas.ResumeLayout(False)
        Me._tabEmpresa_TabPage2.ResumeLayout(False)
        Me._tabEmpresa_TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFechar As System.Windows.Forms.Button
#End Region
End Class