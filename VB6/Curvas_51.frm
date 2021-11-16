VERSION 5.00
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "tabctl32.ocx"
Begin VB.Form Curva_51 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Cáculo doTempo de Atuação da Função 51"
   ClientHeight    =   4635
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4830
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4635
   ScaleWidth      =   4830
   StartUpPosition =   3  'Windows Default
   Begin TabDlg.SSTab tabEmpresa 
      Height          =   3855
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   4575
      _ExtentX        =   8070
      _ExtentY        =   6800
      _Version        =   393216
      Style           =   1
      TabHeight       =   520
      TabCaption(0)   =   "Areva"
      TabPicture(0)   =   "Curvas_51.frx":0000
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "frmAreva_Curvas"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).Control(1)=   "frmAreva_Dados"
      Tab(0).Control(1).Enabled=   0   'False
      Tab(0).Control(2)=   "frmAreva_Resultados"
      Tab(0).Control(2).Enabled=   0   'False
      Tab(0).ControlCount=   3
      TabCaption(1)   =   "GE"
      TabPicture(1)   =   "Curvas_51.frx":001C
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "frmGE_Resultados"
      Tab(1).Control(0).Enabled=   0   'False
      Tab(1).Control(1)=   "frmGE_Dados"
      Tab(1).Control(1).Enabled=   0   'False
      Tab(1).Control(2)=   "frmGE_Curvas"
      Tab(1).Control(2).Enabled=   0   'False
      Tab(1).ControlCount=   3
      TabCaption(2)   =   "Sobre"
      TabPicture(2)   =   "Curvas_51.frx":0038
      Tab(2).ControlEnabled=   0   'False
      Tab(2).Control(0)=   "lblSobre_01"
      Tab(2).Control(0).Enabled=   0   'False
      Tab(2).Control(1)=   "lblSobre_02"
      Tab(2).Control(1).Enabled=   0   'False
      Tab(2).Control(2)=   "lblSite"
      Tab(2).Control(2).Enabled=   0   'False
      Tab(2).Control(3)=   "lblSobre_03"
      Tab(2).Control(3).Enabled=   0   'False
      Tab(2).Control(4)=   "lblEmail"
      Tab(2).Control(4).Enabled=   0   'False
      Tab(2).ControlCount=   5
      Begin VB.Frame frmGE_Curvas 
         Caption         =   "Selecione uma Curva"
         Height          =   855
         Left            =   -74880
         TabIndex        =   14
         Top             =   360
         Width           =   4335
         Begin VB.ComboBox cmbCurvas_ge 
            Height          =   315
            ItemData        =   "Curvas_51.frx":0054
            Left            =   120
            List            =   "Curvas_51.frx":0088
            Style           =   2  'Dropdown List
            TabIndex        =   17
            Top             =   360
            Width           =   4095
         End
      End
      Begin VB.Frame frmGE_Dados 
         Caption         =   "Dados"
         Height          =   1095
         Left            =   -74880
         TabIndex        =   15
         Top             =   1320
         Width           =   4335
         Begin VB.TextBox txtCorrente_pickup_ge 
            Alignment       =   1  'Right Justify
            Height          =   285
            Left            =   840
            TabIndex        =   18
            Top             =   240
            Width           =   735
         End
         Begin VB.TextBox txtCorrente_aplicada_ge 
            Alignment       =   1  'Right Justify
            Height          =   285
            Left            =   840
            TabIndex        =   19
            Top             =   600
            Width           =   735
         End
         Begin VB.TextBox txtTolerancia_ge 
            Alignment       =   1  'Right Justify
            Height          =   285
            Left            =   3120
            TabIndex        =   21
            Top             =   600
            Width           =   735
         End
         Begin VB.TextBox txtTime_dial_ge 
            Alignment       =   1  'Right Justify
            Height          =   285
            Left            =   3120
            TabIndex        =   20
            Top             =   240
            Width           =   735
         End
         Begin VB.Label lblCorrente_pickup_ge 
            AutoSize        =   -1  'True
            Caption         =   "Ipickup:"
            Height          =   195
            Left            =   120
            TabIndex        =   50
            Top             =   285
            Width           =   570
         End
         Begin VB.Label lblCorrente_aplicada_ge 
            AutoSize        =   -1  'True
            Caption         =   "Iaplicada:"
            Height          =   195
            Left            =   120
            TabIndex        =   49
            Top             =   645
            Width           =   690
         End
         Begin VB.Label lblTolerancia_ge 
            AutoSize        =   -1  'True
            Caption         =   "Erro:"
            Height          =   195
            Left            =   2760
            TabIndex        =   48
            Top             =   645
            Width           =   330
         End
         Begin VB.Label lblTolerancia_unidade_ge 
            AutoSize        =   -1  'True
            Caption         =   "%"
            Height          =   195
            Left            =   3930
            TabIndex        =   47
            Top             =   645
            Width           =   120
         End
         Begin VB.Label lblTime_dial_ge 
            AutoSize        =   -1  'True
            Caption         =   "TD:"
            Height          =   195
            Left            =   2760
            TabIndex        =   46
            Top             =   285
            Width           =   270
         End
         Begin VB.Label lblCorrente_pickup_unidade_ge 
            AutoSize        =   -1  'True
            Caption         =   "A"
            Height          =   195
            Left            =   1680
            TabIndex        =   45
            Top             =   285
            Width           =   105
         End
         Begin VB.Label lblCorrente_aplicada_unidade_ge 
            AutoSize        =   -1  'True
            Caption         =   "A"
            Height          =   195
            Left            =   1680
            TabIndex        =   44
            Top             =   645
            Width           =   105
         End
      End
      Begin VB.Frame frmGE_Resultados 
         Caption         =   "Resultado obtido"
         Height          =   1215
         Left            =   -74880
         TabIndex        =   16
         Top             =   2520
         Width           =   4335
         Begin VB.TextBox txtTempo_calculado_ge 
            Alignment       =   1  'Right Justify
            BeginProperty DataFormat 
               Type            =   1
               Format          =   "0,000"
               HaveTrueFalseNull=   0
               FirstDayOfWeek  =   0
               FirstWeekOfYear =   0
               LCID            =   1046
               SubFormatType   =   1
            EndProperty
            Height          =   285
            Left            =   1560
            MaxLength       =   5
            TabIndex        =   23
            Top             =   720
            Width           =   855
         End
         Begin VB.TextBox txtTempo_minimo_ge 
            Alignment       =   1  'Right Justify
            BeginProperty DataFormat 
               Type            =   1
               Format          =   "0,000"
               HaveTrueFalseNull=   0
               FirstDayOfWeek  =   0
               FirstWeekOfYear =   0
               LCID            =   1046
               SubFormatType   =   1
            EndProperty
            Height          =   285
            Left            =   120
            MaxLength       =   5
            TabIndex        =   22
            Top             =   720
            Width           =   855
         End
         Begin VB.TextBox txtTempo_maximo_ge 
            Alignment       =   1  'Right Justify
            BeginProperty DataFormat 
               Type            =   1
               Format          =   "0,000"
               HaveTrueFalseNull=   0
               FirstDayOfWeek  =   0
               FirstWeekOfYear =   0
               LCID            =   1046
               SubFormatType   =   1
            EndProperty
            Height          =   285
            Left            =   3120
            MaxLength       =   5
            TabIndex        =   24
            Top             =   720
            Width           =   855
         End
         Begin VB.Label lblTempo_calculado_ge 
            AutoSize        =   -1  'True
            Caption         =   "Tempo Calculado"
            Height          =   195
            Left            =   1560
            TabIndex        =   43
            Top             =   360
            Width           =   1245
         End
         Begin VB.Label lblTempo_minimo_ge 
            AutoSize        =   -1  'True
            Caption         =   "Tempo Mínimo"
            Height          =   195
            Left            =   120
            TabIndex        =   42
            Top             =   360
            Width           =   1065
         End
         Begin VB.Label lblTempo_maximo_ge 
            AutoSize        =   -1  'True
            Caption         =   "Tempo Máximo"
            Height          =   195
            Left            =   3120
            TabIndex        =   41
            Top             =   360
            Width           =   1080
         End
         Begin VB.Label lblTempo_calculado_unidade_ge 
            AutoSize        =   -1  'True
            Caption         =   "ms"
            Height          =   195
            Left            =   2430
            TabIndex        =   40
            Top             =   765
            Width           =   195
         End
         Begin VB.Label lblTempo_minimo_unidade_ge 
            AutoSize        =   -1  'True
            Caption         =   "ms"
            Height          =   195
            Left            =   990
            TabIndex        =   39
            Top             =   765
            Width           =   195
         End
         Begin VB.Label lblTempo_maximo_unidade_ge 
            AutoSize        =   -1  'True
            Caption         =   "ms"
            Height          =   195
            Left            =   3990
            TabIndex        =   38
            Top             =   765
            Width           =   195
         End
      End
      Begin VB.Frame frmAreva_Resultados 
         Caption         =   "Resultado obtido"
         Height          =   1215
         Left            =   120
         TabIndex        =   5
         Top             =   2520
         Width           =   4335
         Begin VB.TextBox txtTempo_maximo 
            Alignment       =   1  'Right Justify
            BeginProperty DataFormat 
               Type            =   1
               Format          =   "0,000"
               HaveTrueFalseNull=   0
               FirstDayOfWeek  =   0
               FirstWeekOfYear =   0
               LCID            =   1046
               SubFormatType   =   1
            EndProperty
            Height          =   285
            Left            =   3120
            MaxLength       =   5
            TabIndex        =   13
            Top             =   720
            Width           =   855
         End
         Begin VB.TextBox txtTempo_minimo 
            Alignment       =   1  'Right Justify
            BeginProperty DataFormat 
               Type            =   1
               Format          =   "0,000"
               HaveTrueFalseNull=   0
               FirstDayOfWeek  =   0
               FirstWeekOfYear =   0
               LCID            =   1046
               SubFormatType   =   1
            EndProperty
            Height          =   285
            Left            =   120
            MaxLength       =   5
            TabIndex        =   11
            Top             =   720
            Width           =   855
         End
         Begin VB.TextBox txtTempo_calculado 
            Alignment       =   1  'Right Justify
            BeginProperty DataFormat 
               Type            =   1
               Format          =   "0,000"
               HaveTrueFalseNull=   0
               FirstDayOfWeek  =   0
               FirstWeekOfYear =   0
               LCID            =   1046
               SubFormatType   =   1
            EndProperty
            Height          =   285
            Left            =   1560
            MaxLength       =   5
            TabIndex        =   12
            Top             =   720
            Width           =   855
         End
         Begin VB.Label lblTempo_maximo_unidade 
            AutoSize        =   -1  'True
            Caption         =   "ms"
            Height          =   195
            Left            =   3990
            TabIndex        =   37
            Top             =   765
            Width           =   195
         End
         Begin VB.Label lblTempo_minimo_unidade 
            AutoSize        =   -1  'True
            Caption         =   "ms"
            Height          =   195
            Left            =   990
            TabIndex        =   36
            Top             =   765
            Width           =   195
         End
         Begin VB.Label lblTempo_calculado_unidade 
            AutoSize        =   -1  'True
            Caption         =   "ms"
            Height          =   195
            Left            =   2430
            TabIndex        =   35
            Top             =   765
            Width           =   195
         End
         Begin VB.Label lblTempo_maximo 
            AutoSize        =   -1  'True
            Caption         =   "Tempo Máximo"
            Height          =   195
            Left            =   3120
            TabIndex        =   34
            Top             =   360
            Width           =   1080
         End
         Begin VB.Label lblTempo_minimo 
            AutoSize        =   -1  'True
            Caption         =   "Tempo Mínimo"
            Height          =   195
            Left            =   120
            TabIndex        =   33
            Top             =   360
            Width           =   1065
         End
         Begin VB.Label lblTempo_calculado 
            AutoSize        =   -1  'True
            Caption         =   "Tempo Calculado"
            Height          =   195
            Left            =   1560
            TabIndex        =   32
            Top             =   360
            Width           =   1245
         End
      End
      Begin VB.Frame frmAreva_Dados 
         Caption         =   "Dados"
         Height          =   1095
         Left            =   120
         TabIndex        =   4
         Top             =   1320
         Width           =   4335
         Begin VB.TextBox txtTime_dial 
            Alignment       =   1  'Right Justify
            Height          =   285
            Left            =   3120
            TabIndex        =   9
            Top             =   240
            Width           =   735
         End
         Begin VB.TextBox txtTolerancia 
            Alignment       =   1  'Right Justify
            Height          =   285
            Left            =   3120
            TabIndex        =   10
            Top             =   600
            Width           =   735
         End
         Begin VB.TextBox txtCorrente_aplicada 
            Alignment       =   1  'Right Justify
            Height          =   285
            Left            =   840
            TabIndex        =   8
            Top             =   600
            Width           =   735
         End
         Begin VB.TextBox txtCorrente_pickup 
            Alignment       =   1  'Right Justify
            Height          =   285
            Left            =   840
            TabIndex        =   7
            Top             =   240
            Width           =   735
         End
         Begin VB.Label lblCorrente_aplicada_unidade 
            AutoSize        =   -1  'True
            Caption         =   "A"
            Height          =   195
            Left            =   1680
            TabIndex        =   31
            Top             =   645
            Width           =   105
         End
         Begin VB.Label lblCorrente_pickup_unidade 
            AutoSize        =   -1  'True
            Caption         =   "A"
            Height          =   195
            Left            =   1680
            TabIndex        =   30
            Top             =   285
            Width           =   105
         End
         Begin VB.Label lblTime_dial 
            AutoSize        =   -1  'True
            Caption         =   "TD:"
            Height          =   195
            Left            =   2760
            TabIndex        =   29
            Top             =   285
            Width           =   270
         End
         Begin VB.Label lblTolerancia_unidade 
            AutoSize        =   -1  'True
            Caption         =   "%"
            Height          =   195
            Left            =   3930
            TabIndex        =   28
            Top             =   645
            Width           =   120
         End
         Begin VB.Label lblTolerancia 
            AutoSize        =   -1  'True
            Caption         =   "Erro:"
            Height          =   195
            Left            =   2760
            TabIndex        =   27
            Top             =   645
            Width           =   330
         End
         Begin VB.Label lblCorrente_aplicada 
            AutoSize        =   -1  'True
            Caption         =   "Iaplicada:"
            Height          =   195
            Left            =   120
            TabIndex        =   26
            Top             =   645
            Width           =   690
         End
         Begin VB.Label lblCorrente_pickup 
            AutoSize        =   -1  'True
            Caption         =   "Ipickup:"
            Height          =   195
            Left            =   120
            TabIndex        =   25
            Top             =   285
            Width           =   570
         End
      End
      Begin VB.Frame frmAreva_Curvas 
         Caption         =   "Selecione uma Curva"
         Height          =   855
         Left            =   120
         TabIndex        =   3
         Top             =   360
         Width           =   4335
         Begin VB.ComboBox cmbCurvas 
            Height          =   315
            ItemData        =   "Curvas_51.frx":01ED
            Left            =   120
            List            =   "Curvas_51.frx":020F
            Style           =   2  'Dropdown List
            TabIndex        =   6
            Top             =   360
            Width           =   4095
         End
      End
      Begin VB.Label lblEmail 
         Caption         =   "suporte@khis.com.br"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000002&
         Height          =   375
         Left            =   -74760
         TabIndex        =   55
         Top             =   3240
         Width           =   4095
      End
      Begin VB.Label lblSobre_03 
         Caption         =   "Ou envie um e-mail para:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   -74760
         TabIndex        =   54
         Top             =   3000
         Width           =   4095
      End
      Begin VB.Label lblSite 
         Caption         =   "http://www.khis.com.br"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   -1  'True
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000002&
         Height          =   375
         Left            =   -74760
         TabIndex        =   53
         Top             =   2520
         Width           =   4095
      End
      Begin VB.Label lblSobre_02 
         Caption         =   "Visite nossa página na internet:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   -74760
         TabIndex        =   52
         Top             =   2280
         Width           =   4095
      End
      Begin VB.Label lblSobre_01 
         Caption         =   "Este software foi desenvolvido pela equipe técnica da Know-how Info System."
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   -74760
         TabIndex        =   51
         Top             =   480
         Width           =   4095
      End
   End
   Begin VB.CommandButton btnFechar 
      Caption         =   "&Fechar"
      Height          =   495
      Left            =   3000
      TabIndex        =   1
      Top             =   4080
      Width           =   1215
   End
   Begin VB.CommandButton btnCalcular 
      Caption         =   "&Calcular"
      Enabled         =   0   'False
      Height          =   495
      Left            =   600
      TabIndex        =   0
      Top             =   4080
      Width           =   1215
   End
End
Attribute VB_Name = "Curva_51"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'---------------------------------------------------------------------------------------------------
'                                   Declaração das variáveis
'---------------------------------------------------------------------------------------------------
Dim corrente_pickup As Long         'Corrente de Pickup ajustada no relé
Dim corrente_aplicada As Long       'Corrente aplicada no teste
Dim time_dial As Long               'Multiplicador da curva inversa
Dim tempo_calculado As Double       'Tempo calculado através da fórmula da curva selecionada
Dim tempo_maximo As Double          'Tempo máximo aceitável
Dim tempo_minimo As Double          'Tempo mínimo aceitável
Dim tolerancia As Long              'Toleranciaância dada pelo fabricante do Relé
Dim teste As Integer
'---------------------------------------------------------------------------------------------------
Public Sub corrige_unidade()
'---------------------------------------------------------------------------------------------------
'                               Ajuste na unidade de tempo do resultado
'---------------------------------------------------------------------------------------------------
Select Case tabEmpresa.Tab
    'Areva
    Case Is = 0
        If tempo_calculado < 1 Then
            tempo_calculado = tempo_calculado * 1000
            lblTempo_calculado_unidade.Caption = "ms"
        Else
            lblTempo_calculado_unidade.Caption = "s"
        End If
        If tempo_minimo < 1 Then
            tempo_minimo = tempo_minimo * 1000
            lblTempo_minimo_unidade.Caption = "ms"
        Else
            lblTempo_minimo_unidade.Caption = "s"
        End If
        If tempo_maximo < 1 Then
            tempo_maximo = tempo_maximo * 1000
            lblTempo_maximo_unidade.Caption = "ms"
        Else
            lblTempo_maximo_unidade.Caption = "s"
        End If
    'GE
    Case Is = 1
        If tempo_calculado < 1 Then
            tempo_calculado = tempo_calculado * 1000
            lblTempo_calculado_unidade_ge.Caption = "ms"
        Else
            lblTempo_calculado_unidade_ge.Caption = "s"
        End If
        If tempo_minimo < 1 Then
            tempo_minimo = tempo_minimo * 1000
            lblTempo_minimo_unidade_ge.Caption = "ms"
        Else
            lblTempo_minimo_unidade_ge.Caption = "s"
        End If
        If tempo_maximo < 1 Then
            tempo_maximo = tempo_maximo * 1000
            lblTempo_maximo_unidade_ge.Caption = "ms"
        Else
            lblTempo_maximo_unidade_ge.Caption = "s"
        End If
End Select
'---------------------------------------------------------------------------------------------------
End Sub
Public Sub GE()
'---------------------------------------------------------------------------------------------------
'                            Leitura dos valores apresentados pelo usuário
'---------------------------------------------------------------------------------------------------
corrente_pickup = txtCorrente_pickup_ge.Text       'Lendo valor da Corrente de pickup
corrente_aplicada = txtCorrente_aplicada_ge.Text   'Lendo valor da Corrente aplicada
time_dial = txtTime_dial_ge.Text                   'Lendo valor do Time Dial
If txtTolerancia_ge.Text = "" Then                 'Lendo valor da tolerância
    tolerancia = 10
Else
    tolerancia = txtTolerancia_ge.Text
End If
'---------------------------------------------------------------------------------------------------
'                               Cálculo do tempo de atuação da função 51
'---------------------------------------------------------------------------------------------------
Select Case cmbCurvas_ge.ListIndex
    'ANSI Extremely Inverse
    Case Is = 0
        tempo_calculado = 0.0399 + (0.2294 / ((corrente_aplicada / corrente_pickup) - 0.5))
        tempo_calculado = tempo_calculado + (3.0094 / ((corrente_aplicada / corrente_pickup) - 0.5) ^ 2)
        tempo_calculado = tempo_calculado + (0.7222 / ((corrente_aplicada / corrente_pickup) - 0.5) ^ 3)
        tempo_calculado = time_dial * tempo_calculado
    'ANSI Very Inverse
    Case Is = 1
        tempo_calculado = time_dial * (0.0615 + (0.7989 / ((corrente_aplicada / corrente_pickup) - 0.34)) + (-0.284 / ((corrente_aplicada / corrente_pickup) - 0.34) ^ 2) + (4.0505 / ((corrente_aplicada / corrente_pickup) - 0.34) ^ 3))
    'ANSI Normaly Inverse
    Case Is = 2
        tempo_calculado = time_dial * (0.0274 + (2.2614 / ((corrente_aplicada / corrente_pickup) - 0.3)) + (-4.1899 / ((corrente_aplicada / corrente_pickup) - 0.3) ^ 2) + (9.1272 / ((corrente_aplicada / corrente_pickup) - 0.3) ^ 3))
    'ANSI Moderately Inverse
    Case Is = 3
        tempo_calculado = time_dial * (0.1735 + (0.6791 / ((corrente_aplicada / corrente_pickup) - 0.8)) + (-0.08 / ((corrente_aplicada / corrente_pickup) - 0.8) ^ 2) + (0.1271 / ((corrente_aplicada / corrente_pickup) - 0.8) ^ 3))
    'IEC Extremely Inverse (Curve C)
    Case Is = 4
        tempo_calculado = time_dial * (80 / (((corrente_aplicada / corrente_pickup) ^ 2) - 1))
    'IEC Very Inverse (Curve B)
    Case Is = 5
        tempo_calculado = time_dial * (13.5 / (((corrente_aplicada / corrente_pickup) ^ 1) - 1))
    'IEC Standard Inverse (Curve A)
    Case Is = 6
        tempo_calculado = time_dial * (0.14 / (((corrente_aplicada / corrente_pickup) ^ 0.02) - 1))
    'IEC Short Time Inverse
    Case Is = 7
        tempo_calculado = time_dial * (0.05 / (((corrente_aplicada / corrente_pickup) ^ 0.04) - 1))
    'IEEE Extremely Inverse
    Case Is = 8
        tempo_calculado = time_dial * ((28.2 / (((corrente_aplicada / corrente_pickup) ^ 2) - 1)) + 0.1217)
    'IEEE Very Inverse
    Case Is = 9
        tempo_calculado = time_dial * ((19.61 / (((corrente_aplicada / corrente_pickup) ^ 2) - 1)) + 0.491)
    'IEEE Moderately Inverse
    Case Is = 10
        tempo_calculado = time_dial * ((0.0515 / (((corrente_aplicada / corrente_pickup) ^ 0.02) - 1)) + 0.114)
    'IAC Extremely Inverse
    Case Is = 11
        tempo_calculado = time_dial * (0.004 + (0.6379 / ((corrente_aplicada / corrente_pickup) - 0.62)) + (1.7872 / ((corrente_aplicada / corrente_pickup) - 0.62) ^ 2) + (0.2461 / ((corrente_aplicada / corrente_pickup) - 0.62) ^ 3))
    'IAC Very Inverse
    Case Is = 12
        tempo_calculado = time_dial * (0.09 + (0.7955 / ((corrente_aplicada / corrente_pickup) - 0.1)) + (-1.2885 / ((corrente_aplicada / corrente_pickup) - 0.1) ^ 2) + (7.9586 / ((corrente_aplicada / corrente_pickup) - 0.1) ^ 3))
    'IAC Inverse
    Case Is = 13
        tempo_calculado = time_dial * (0.2078 + (0.863 / ((corrente_aplicada / corrente_pickup) - 0.8)) + (-0.418 / ((corrente_aplicada / corrente_pickup) - 0.8) ^ 2) + (0.1947 / ((corrente_aplicada / corrente_pickup) - 0.8) ^ 3))
    'IAC Short Inverse
    Case Is = 14
        tempo_calculado = time_dial * (0.0428 + (0.0609 / ((corrente_aplicada / corrente_pickup) - 0.62)) + (-0.001 / ((corrente_aplicada / corrente_pickup) - 0.62) ^ 2) + (0.0221 / ((corrente_aplicada / corrente_pickup) - 0.62) ^ 3))
    'i2t
    Case Is = 15
        tempo_calculado = time_dial * (100 / (corrente_aplicada / corrente_pickup) ^ 2)
End Select
'---------------------------------------------------------------------------------------------------
End Sub
Public Sub escreve_resultados()
'---------------------------------------------------------------------------------------------------
'                              Escrita nas caixas  de texto de resultados Areva
'---------------------------------------------------------------------------------------------------
Select Case tabEmpresa.Tab
    'Areva
    Case Is = 0
        txtTempo_calculado.Text = tempo_calculado
        txtTempo_minimo.Text = tempo_minimo
        txtTempo_maximo.Text = tempo_maximo
    'GE
    Case Is = 1
        txtTempo_calculado_ge.Text = tempo_calculado
        txtTempo_minimo_ge.Text = tempo_minimo
        txtTempo_maximo_ge.Text = tempo_maximo
End Select
'---------------------------------------------------------------------------------------------------
End Sub

Public Sub Areva()
'---------------------------------------------------------------------------------------------------
'                            Leitura dos valores apresentados pelo usuário
'---------------------------------------------------------------------------------------------------
corrente_pickup = txtCorrente_pickup.Text       'Lendo valor da Corrente de pickup
corrente_aplicada = txtCorrente_aplicada.Text   'Lendo valor da Corrente aplicada
time_dial = txtTime_dial.Text                   'Lendo valor do Time Dial
If txtTolerancia.Text = "" Then                 'Lendo valor da tolerância
    tolerancia = 10
Else
    tolerancia = txtTolerancia.Text
End If
'---------------------------------------------------------------------------------------------------
'                               Cálculo do tempo de atuação da função 51
'---------------------------------------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------
'             Todas as fórmulas utulizadas abaixo foram retiradas dos manuais da
'             Areva T&D. Verificar se ANSI=IEEE, pois é assim que consta nos manuais
'             Os manuais pesquisados foram os dos seguintes relés: - P127
'                                                                  - P142
'---------------------------------------------------------------------------------------------------
Select Case cmbCurvas.ListIndex
    'ANSI/IEEE Extremely Inverse
    Case Is = 0
        tempo_calculado = time_dial * ((28.2 / (((corrente_aplicada / corrente_pickup) ^ 2) - 1)) + 0.1217)
    'ANSI/IEEE Very Inverse
    Case Is = 1
        tempo_calculado = time_dial * ((19.61 / (((corrente_aplicada / corrente_pickup) ^ 2) - 1)) + 0.491)
    'ANSI/IEEE Moderately Inverse
    Case Is = 2
        tempo_calculado = time_dial * ((0.0515 / (((corrente_aplicada / corrente_pickup) ^ 0.02) - 1)) + 0.114)
    'IEC Extremely Inverse
    Case Is = 3
        tempo_calculado = time_dial * (80 / (((corrente_aplicada / corrente_pickup) ^ 2) - 1))
    'IEC Very Inverse
    Case Is = 4
        tempo_calculado = time_dial * (13.5 / (((corrente_aplicada / corrente_pickup) ^ 1) - 1))
    'IEC Standard Inverse
    Case Is = 5
        tempo_calculado = time_dial * (0.14 / (((corrente_aplicada / corrente_pickup) ^ 0.2) - 1))
    'UK Long Time Inverse
    Case Is = 6
        tempo_calculado = time_dial * (120 / (((corrente_aplicada / corrente_pickup) ^ 1) - 1))
    'UK Rectifier
     Case Is = 7
        tempo_calculado = time_dial * (45900 / (((corrente_aplicada / corrente_pickup) ^ 5.6) - 1))
    'US Inverse
    Case Is = 8
        tempo_calculado = time_dial * ((5.95 / (((corrente_aplicada / corrente_pickup) ^ 2) - 1)) + 0.18)
    'US Short Time Inverse
    Case Is = 9
        tempo_calculado = time_dial * ((0.16758 / (((corrente_aplicada / corrente_pickup) ^ 0.02) - 1)) + 0.11858)
End Select
'---------------------------------------------------------------------------------------------------
End Sub
Public Sub mensagens_de_erro()
'---------------------------------------------------------------------------------------------------
'                              Definindo qual mensagen mostrar
'---------------------------------------------------------------------------------------------------
Select Case tabEmpresa.Tab
    'Areva
    Case Is = 0
        If txtCorrente_pickup.Text = "" Then
            Print MsgBox("Digite o valor da corrente de 'pickup'!", vbOKOnly, "Aviso!")
        ElseIf txtCorrente_aplicada.Text = "" Then
            Print MsgBox("Digite o valor da corrente aplicada!", vbOKOnly, "Aviso!")
        ElseIf txtTime_dial.Text = "" Then
            Print MsgBox("Digite o valor do multiplicador 'Time Dial'!", vbOKOnly, "Aviso!")
        End If
    'GE
    Case Is = 1
        If txtCorrente_pickup_ge.Text = "" Then
            Print MsgBox("Digite o valor da corrente de 'pickup'!", vbOKOnly, "Aviso!")
        ElseIf txtCorrente_aplicada_ge.Text = "" Then
            Print MsgBox("Digite o valor da corrente aplicada!", vbOKOnly, "Aviso!")
        ElseIf txtTime_dial_ge.Text = "" Then
            Print MsgBox("Digite o valor do multiplicador 'Time Dial'!", vbOKOnly, "Aviso!")
        End If
End Select
'---------------------------------------------------------------------------------------------------
End Sub
Private Sub btnCalcular_Click()
'---------------------------------------------------------------------------------------------------
'                                     Seleção do fabricante
'---------------------------------------------------------------------------------------------------
Select Case tabEmpresa.Tab
Case Is = 0
    If txtCorrente_pickup.Text = "" Or txtCorrente_aplicada.Text = "" _
    Or txtTime_dial.Text = "" Then
        Call mensagens_de_erro
        Exit Sub
    Else
        Call Areva
    End If
Case Is = 1
    If txtCorrente_pickup_ge.Text = "" Or txtCorrente_aplicada_ge.Text = "" _
    Or txtTime_dial_ge.Text = "" Then
        Call mensagens_de_erro
        Exit Sub
    Else
        Call GE
    End If
End Select
'---------------------------------------------------------------------------------------------------
'                                 Cálculo dos tempos máximo e mínimo
'---------------------------------------------------------------------------------------------------
tempo_maximo = tempo_calculado + (tempo_calculado * (tolerancia / 100))
tempo_minimo = tempo_calculado - (tempo_calculado * (tolerancia / 100))
'---------------------------------------------------------------------------------------------------
'                               Ajuste na unidade de tempo do resultado
'---------------------------------------------------------------------------------------------------
Call corrige_unidade
'---------------------------------------------------------------------------------------------------
'                              Escrita nas caixas  de texto de resultados
'---------------------------------------------------------------------------------------------------
Call escreve_resultados
'---------------------------------------------------------------------------------------------------
End Sub
Private Sub btnFechar_Click()
    Unload Curva_51
End Sub
Private Sub cmbCurvas_Click()
txtTempo_calculado.Text = ""
txtTempo_minimo.Text = ""
txtTempo_maximo.Text = ""
btnCalcular.Enabled = True
End Sub
Private Sub cmbCurvas_ge_Click()
txtTempo_calculado_ge.Text = ""
txtTempo_minimo_ge.Text = ""
txtTempo_maximo_ge.Text = ""
btnCalcular.Enabled = True
End Sub

Private Sub tabEmpresa_Click(PreviousTab As Integer)
'---------------------------------------------------------------------------------------------------
'                                       Seleção de Abas
'---------------------------------------------------------------------------------------------------
btnCalcular.Enabled = True
If tabEmpresa.Tab = 0 And cmbCurvas.ListIndex < 0 Then
    btnCalcular.Enabled = False
ElseIf tabEmpresa.Tab = 1 And cmbCurvas_ge.ListIndex < 0 Then
    btnCalcular.Enabled = False
ElseIf tabEmpresa.Tab = 2 Then
    btnCalcular.Enabled = False
End If
'---------------------------------------------------------------------------------------------------
End Sub
Private Sub txtCorrente_aplicada_ge_KeyPress(KeyAscii As Integer)
'---------------------------------------------------------------------------------------------------
'                               Verificação dos dados numéricos
'---------------------------------------------------------------------------------------------------
If KeyAscii < vbKey0 Or KeyAscii > vbKey9 Then
    KeyAscii = 0
    Print MsgBox("Digite um valor numérico!", vbOKOnly, "Aviso!")
End If
'---------------------------------------------------------------------------------------------------
End Sub
Private Sub txtCorrente_aplicada_KeyPress(KeyAscii As Integer)
'---------------------------------------------------------------------------------------------------
'                               Verificação dos dados numéricos
'---------------------------------------------------------------------------------------------------
If KeyAscii < vbKey0 Or KeyAscii > vbKey9 Then
    KeyAscii = 0
    Print MsgBox("Digite um valor numérico!", vbOKOnly, "Aviso!")
End If
'---------------------------------------------------------------------------------------------------
End Sub
Private Sub txtCorrente_pickup_ge_KeyPress(KeyAscii As Integer)
'---------------------------------------------------------------------------------------------------
'                               Verificação dos dados numéricos
'---------------------------------------------------------------------------------------------------
If KeyAscii < vbKey0 Or KeyAscii > vbKey9 Then
    KeyAscii = 0
    Print MsgBox("Digite um valor numérico!", vbOKOnly, "Aviso!")
End If
'---------------------------------------------------------------------------------------------------
End Sub
Private Sub txtCorrente_pickup_KeyPress(KeyAscii As Integer)
'---------------------------------------------------------------------------------------------------
'                               Verificação dos dados numéricos
'---------------------------------------------------------------------------------------------------
If KeyAscii < vbKey0 Or KeyAscii > vbKey9 Then
    KeyAscii = 0
    Print MsgBox("Digite um valor numérico!", vbOKOnly, "Aviso!")
End If
'---------------------------------------------------------------------------------------------------
End Sub
Private Sub txtTime_dial_ge_KeyPress(KeyAscii As Integer)
'---------------------------------------------------------------------------------------------------
'                               Verificação dos dados numéricos
'---------------------------------------------------------------------------------------------------
If KeyAscii < vbKey0 Or KeyAscii > vbKey9 Then
    KeyAscii = 0
    Print MsgBox("Digite um valor numérico!", vbOKOnly, "Aviso!")
End If
'---------------------------------------------------------------------------------------------------
End Sub
Private Sub txtTime_dial_KeyPress(KeyAscii As Integer)
'---------------------------------------------------------------------------------------------------
'                               Verificação dos dados numéricos
'---------------------------------------------------------------------------------------------------
If KeyAscii < vbKey0 Or KeyAscii > vbKey9 Then
    If Not KeyAscii = 46 Then
        KeyAscii = 0
        Print MsgBox("Digite um valor numérico!", vbOKOnly, "Aviso!")
    End If
End If
'---------------------------------------------------------------------------------------------------
End Sub
Private Sub txtTolerancia_ge_KeyPress(KeyAscii As Integer)
'---------------------------------------------------------------------------------------------------
'                               Verificação dos dados numéricos
'---------------------------------------------------------------------------------------------------
If KeyAscii < vbKey0 Or KeyAscii > vbKey9 Then
    KeyAscii = 0
    Print MsgBox("Digite um valor numérico!", vbOKOnly, "Aviso!")
End If
'---------------------------------------------------------------------------------------------------
End Sub
Private Sub txtTolerancia_KeyPress(KeyAscii As Integer)
'---------------------------------------------------------------------------------------------------
'                               Verificação dos dados numéricos
'---------------------------------------------------------------------------------------------------
If KeyAscii < vbKey0 Or KeyAscii > vbKey9 Then
    If Not KeyAscii = 46 Then
        KeyAscii = 0
        Print MsgBox("Digite um valor numérico!", vbOKOnly, "Aviso!")
    End If
End If
'---------------------------------------------------------------------------------------------------
End Sub
