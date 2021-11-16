
Friend Class frmCurvas
  Inherits System.Windows.Forms.Form
  '---------------------------------------------------------------------------------------------------
  '                                   Declaração das variáveis
  '---------------------------------------------------------------------------------------------------
  Dim corrente_pickup As Integer              'Corrente de Pickup ajustada no relé
  Dim corrente_aplicada As Integer            'Corrente aplicada no teste
  Dim time_dial As Integer                    'Multiplicador da curva inversa
  Dim tempo_calculado As Double               'Tempo calculado através da fórmula da curva selecionada
  Dim tempo_maximo As Double                  'Tempo máximo aceitável
  Dim tempo_minimo As Double                  'Tempo mínimo aceitável
  Dim tolerancia As Integer                   'Toleranciaância dada pelo fabricante do Relé
  Dim teste As Short
  Private IsInitializing As Boolean
  '---------------------------------------------------------------------------------------------------
  Public Sub corrige_unidade()
    '---------------------------------------------------------------------------------------------------
    '                               Ajuste na unidade de tempo do resultado
    '---------------------------------------------------------------------------------------------------
    Select Case tabEmpresa.SelectedIndex
      'Areva
      Case Is = 0
        If tempo_calculado < 1 Then
          tempo_calculado = tempo_calculado * 1000
          lblTempo_calculado_unidade.Text = "ms"
        Else
          lblTempo_calculado_unidade.Text = "s"
        End If
        If tempo_minimo < 1 Then
          tempo_minimo = tempo_minimo * 1000
          lblTempo_minimo_unidade.Text = "ms"
        Else
          lblTempo_minimo_unidade.Text = "s"
        End If
        If tempo_maximo < 1 Then
          tempo_maximo = tempo_maximo * 1000
          lblTempo_maximo_unidade.Text = "ms"
        Else
          lblTempo_maximo_unidade.Text = "s"
        End If
        'GE
      Case Is = 1
        If tempo_calculado < 1 Then
          tempo_calculado = tempo_calculado * 1000
          lblTempo_calculado_unidade_ge.Text = "ms"
        Else
          lblTempo_calculado_unidade_ge.Text = "s"
        End If
        If tempo_minimo < 1 Then
          tempo_minimo = tempo_minimo * 1000
          lblTempo_minimo_unidade_ge.Text = "ms"
        Else
          lblTempo_minimo_unidade_ge.Text = "s"
        End If
        If tempo_maximo < 1 Then
          tempo_maximo = tempo_maximo * 1000
          lblTempo_maximo_unidade_ge.Text = "ms"
        Else
          lblTempo_maximo_unidade_ge.Text = "s"
        End If
    End Select
    '---------------------------------------------------------------------------------------------------
  End Sub
  Public Sub GE()
    '---------------------------------------------------------------------------------------------------
    '                            Leitura dos valores apresentados pelo usuário
    '---------------------------------------------------------------------------------------------------
    corrente_pickup = CInt(txtCorrente_pickup_ge.Text)            'Lendo valor da Corrente de pickup
    corrente_aplicada = CInt(txtCorrente_aplicada_ge.Text)        'Lendo valor da Corrente aplicada
    time_dial = CInt(txtTime_dial_ge.Text)                        'Lendo valor do Time Dial
    If txtTolerancia_ge.Text = "" Then                            'Lendo valor da tolerância
      tolerancia = 10
    Else
      tolerancia = CInt(txtTolerancia_ge.Text)
    End If
    '---------------------------------------------------------------------------------------------------
    '                               Cálculo do tempo de atuação da função 51
    '---------------------------------------------------------------------------------------------------
    Select Case cmbCurvas_ge.SelectedIndex

      Case Is = 0     'ANSI Extremely Inverse
        tempo_calculado = 0.0399 + (0.2294 / ((corrente_aplicada / corrente_pickup) - 0.5))
        tempo_calculado = tempo_calculado + (3.0094 / ((corrente_aplicada / corrente_pickup) - 0.5) ^ 2)
        tempo_calculado = tempo_calculado + (0.7222 / ((corrente_aplicada / corrente_pickup) - 0.5) ^ 3)
        tempo_calculado = time_dial * tempo_calculado

      Case Is = 1     'ANSI Very Inverse
        tempo_calculado = time_dial * (0.0615 + (0.7989 / ((corrente_aplicada / corrente_pickup) - 0.34)) + (-0.284 / ((corrente_aplicada / corrente_pickup) - 0.34) ^ 2) + (4.0505 / ((corrente_aplicada / corrente_pickup) - 0.34) ^ 3))

      Case Is = 2     'ANSI Normaly Inverse
        tempo_calculado = time_dial * (0.0274 + (2.2614 / ((corrente_aplicada / corrente_pickup) - 0.3)) + (-4.1899 / ((corrente_aplicada / corrente_pickup) - 0.3) ^ 2) + (9.1272 / ((corrente_aplicada / corrente_pickup) - 0.3) ^ 3))

      Case Is = 3     'ANSI Moderately Inverse
        tempo_calculado = time_dial * (0.1735 + (0.6791 / ((corrente_aplicada / corrente_pickup) - 0.8)) + (-0.08 / ((corrente_aplicada / corrente_pickup) - 0.8) ^ 2) + (0.1271 / ((corrente_aplicada / corrente_pickup) - 0.8) ^ 3))

      Case Is = 4     'IEC Extremely Inverse (Curve C)
        tempo_calculado = time_dial * (80 / (((corrente_aplicada / corrente_pickup) ^ 2) - 1))

      Case Is = 5     'IEC Very Inverse (Curve B)
        tempo_calculado = time_dial * (13.5 / (((corrente_aplicada / corrente_pickup) ^ 1) - 1))

      Case Is = 6     'IEC Standard Inverse (Curve A)
        tempo_calculado = time_dial * (0.14 / (((corrente_aplicada / corrente_pickup) ^ 0.02) - 1))

      Case Is = 7     'IEC Short Time Inverse
        tempo_calculado = time_dial * (0.05 / (((corrente_aplicada / corrente_pickup) ^ 0.04) - 1))

      Case Is = 8     'IEEE Extremely Inverse
        tempo_calculado = time_dial * ((28.2 / (((corrente_aplicada / corrente_pickup) ^ 2) - 1)) + 0.1217)

      Case Is = 9     'IEEE Very Inverse
        tempo_calculado = time_dial * ((19.61 / (((corrente_aplicada / corrente_pickup) ^ 2) - 1)) + 0.491)

      Case Is = 10    'IEEE Moderately Inverse
        tempo_calculado = time_dial * ((0.0515 / (((corrente_aplicada / corrente_pickup) ^ 0.02) - 1)) + 0.114)

      Case Is = 11    'IAC Extremely Inverse
        tempo_calculado = time_dial * (0.004 + (0.6379 / ((corrente_aplicada / corrente_pickup) - 0.62)) + (1.7872 / ((corrente_aplicada / corrente_pickup) - 0.62) ^ 2) + (0.2461 / ((corrente_aplicada / corrente_pickup) - 0.62) ^ 3))

      Case Is = 12    'IAC Very Inverse
        tempo_calculado = time_dial * (0.09 + (0.7955 / ((corrente_aplicada / corrente_pickup) - 0.1)) + (-1.2885 / ((corrente_aplicada / corrente_pickup) - 0.1) ^ 2) + (7.9586 / ((corrente_aplicada / corrente_pickup) - 0.1) ^ 3))

      Case Is = 13    'IAC Inverse
        tempo_calculado = time_dial * (0.2078 + (0.863 / ((corrente_aplicada / corrente_pickup) - 0.8)) + (-0.418 / ((corrente_aplicada / corrente_pickup) - 0.8) ^ 2) + (0.1947 / ((corrente_aplicada / corrente_pickup) - 0.8) ^ 3))

      Case Is = 14    'IAC Short Inverse
        tempo_calculado = time_dial * (0.0428 + (0.0609 / ((corrente_aplicada / corrente_pickup) - 0.62)) + (-0.001 / ((corrente_aplicada / corrente_pickup) - 0.62) ^ 2) + (0.0221 / ((corrente_aplicada / corrente_pickup) - 0.62) ^ 3))

      Case Is = 15    'i2t
        tempo_calculado = time_dial * (100 / (corrente_aplicada / corrente_pickup) ^ 2)
    End Select
    '---------------------------------------------------------------------------------------------------
  End Sub
  Public Sub escreve_resultados()
    '---------------------------------------------------------------------------------------------------
    '                              Escrita nas caixas  de texto de resultados Areva
    '---------------------------------------------------------------------------------------------------
    Select Case tabEmpresa.SelectedIndex

      Case Is = 0     'Areva
        txtTempo_calculado.Text = CStr(tempo_calculado)
        txtTempo_minimo.Text = CStr(tempo_minimo)
        txtTempo_maximo.Text = CStr(tempo_maximo)

      Case Is = 1     'GE
        txtTempo_calculado_ge.Text = CStr(tempo_calculado)
        txtTempo_minimo_ge.Text = CStr(tempo_minimo)
        txtTempo_maximo_ge.Text = CStr(tempo_maximo)
    End Select
    '---------------------------------------------------------------------------------------------------
  End Sub
  Public Sub Areva()
    '---------------------------------------------------------------------------------------------------
    '                            Leitura dos valores apresentados pelo usuário
    '---------------------------------------------------------------------------------------------------
    corrente_pickup = CInt(txtCorrente_pickup.Text) 'Lendo valor da Corrente de pickup
    corrente_aplicada = CInt(txtCorrente_aplicada.Text) 'Lendo valor da Corrente aplicada
    time_dial = CInt(txtTime_dial.Text) 'Lendo valor do Time Dial
    If txtTolerancia.Text = "" Then 'Lendo valor da tolerância
      tolerancia = 10
    Else
      tolerancia = CInt(txtTolerancia.Text)
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
    Select Case cmbCurvas.SelectedIndex

      Case Is = 0     'ANSI/IEEE Extremely Inverse
        tempo_calculado = time_dial * ((28.2 / (((corrente_aplicada / corrente_pickup) ^ 2) - 1)) + 0.1217)

      Case Is = 1     'ANSI/IEEE Very Inverse
        tempo_calculado = time_dial * ((19.61 / (((corrente_aplicada / corrente_pickup) ^ 2) - 1)) + 0.491)

      Case Is = 2     'ANSI/IEEE Moderately Inverse
        tempo_calculado = time_dial * ((0.0515 / (((corrente_aplicada / corrente_pickup) ^ 0.02) - 1)) + 0.114)

      Case Is = 3     'IEC Extremely Inverse
        tempo_calculado = time_dial * (80 / (((corrente_aplicada / corrente_pickup) ^ 2) - 1))

      Case Is = 4     'IEC Very Inverse
        tempo_calculado = time_dial * (13.5 / (((corrente_aplicada / corrente_pickup) ^ 1) - 1))

      Case Is = 5     'IEC Standard Inverse
        tempo_calculado = time_dial * (0.14 / (((corrente_aplicada / corrente_pickup) ^ 0.2) - 1))

      Case Is = 6     'UK Long Time Inverse
        tempo_calculado = time_dial * (120 / (((corrente_aplicada / corrente_pickup) ^ 1) - 1))

      Case Is = 7     'UK Rectifier
        tempo_calculado = time_dial * (45900 / (((corrente_aplicada / corrente_pickup) ^ 5.6) - 1))

      Case Is = 8     'US Inverse
        tempo_calculado = time_dial * ((5.95 / (((corrente_aplicada / corrente_pickup) ^ 2) - 1)) + 0.18)

      Case Is = 9     'US Short Time Inverse
        tempo_calculado = time_dial * ((0.16758 / (((corrente_aplicada / corrente_pickup) ^ 0.02) - 1)) + 0.11858)
    End Select
    '---------------------------------------------------------------------------------------------------
  End Sub
  Public Sub mensagens_de_erro()
    '---------------------------------------------------------------------------------------------------
    '                              Definindo qual mensagen mostrar
    '---------------------------------------------------------------------------------------------------
    Select Case tabEmpresa.SelectedIndex

      Case Is = 0     'Areva
        If txtCorrente_pickup.Text = "" Then
          MsgBox("Digite o valor da corrente de 'pickup'!", MsgBoxStyle.OkOnly, "Aviso!")
        ElseIf txtCorrente_aplicada.Text = "" Then
          MsgBox("Digite o valor da corrente aplicada!", MsgBoxStyle.OkOnly, "Aviso!")
        ElseIf txtTime_dial.Text = "" Then
          MsgBox("Digite o valor do multiplicador 'Time Dial'!", MsgBoxStyle.OkOnly, "Aviso!")
        End If

      Case Is = 1     'GE
        If txtCorrente_pickup_ge.Text = "" Then
          MsgBox("Digite o valor da corrente de 'pickup'!", MsgBoxStyle.OkOnly, "Aviso!")
        ElseIf txtCorrente_aplicada_ge.Text = "" Then
          MsgBox("Digite o valor da corrente aplicada!", MsgBoxStyle.OkOnly, "Aviso!")
        ElseIf txtTime_dial_ge.Text = "" Then
          MsgBox("Digite o valor do multiplicador 'Time Dial'!", MsgBoxStyle.OkOnly, "Aviso!")
        End If
    End Select
    '---------------------------------------------------------------------------------------------------
  End Sub
  Private Sub btnCalcular_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCalcular.Click
    '---------------------------------------------------------------------------------------------------
    '                                     Seleção do fabricante
    '---------------------------------------------------------------------------------------------------
    Select Case tabEmpresa.SelectedIndex
      Case Is = 0
        If txtCorrente_pickup.Text = "" Or txtCorrente_aplicada.Text = "" Or txtTime_dial.Text = "" Then
          Call mensagens_de_erro()
          Exit Sub
        Else
          Call Areva()
        End If
      Case Is = 1
        If txtCorrente_pickup_ge.Text = "" Or txtCorrente_aplicada_ge.Text = "" Or txtTime_dial_ge.Text = "" Then
          Call mensagens_de_erro()
          Exit Sub
        Else
          Call GE()
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
    Call corrige_unidade()
    '---------------------------------------------------------------------------------------------------
    '                              Escrita nas caixas  de texto de resultados
    '---------------------------------------------------------------------------------------------------
    Call escreve_resultados()
    '---------------------------------------------------------------------------------------------------
  End Sub
  Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
    Me.Close()
  End Sub
  Private Sub cmbCurvas_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCurvas.SelectedIndexChanged
    If Me.IsInitializing = True Then
      Exit Sub
    Else
      txtTempo_calculado.Text = ""
      txtTempo_minimo.Text = ""
      txtTempo_maximo.Text = ""
      btnCalcular.Enabled = True
    End If
  End Sub
  Private Sub cmbCurvas_ge_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCurvas_ge.SelectedIndexChanged
    If Me.IsInitializing = True Then
      Exit Sub
    Else
      txtTempo_calculado_ge.Text = ""
      txtTempo_minimo_ge.Text = ""
      txtTempo_maximo_ge.Text = ""
      btnCalcular.Enabled = True
    End If
  End Sub
  Private Sub tabEmpresa_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabEmpresa.SelectedIndexChanged
    Static PreviousTab As Short = tabEmpresa.SelectedIndex()
    '---------------------------------------------------------------------------------------------------
    '                                       Seleção de Abas
    '---------------------------------------------------------------------------------------------------
    btnCalcular.Enabled = True
    If tabEmpresa.SelectedIndex = 0 And cmbCurvas.SelectedIndex < 0 Then
      btnCalcular.Enabled = False
    ElseIf tabEmpresa.SelectedIndex = 1 And cmbCurvas_ge.SelectedIndex < 0 Then
      btnCalcular.Enabled = False
    ElseIf tabEmpresa.SelectedIndex = 2 Then
      btnCalcular.Enabled = False
    End If
    '---------------------------------------------------------------------------------------------------
    PreviousTab = tabEmpresa.SelectedIndex()
  End Sub
  Private Sub txtCorrente_aplicada_ge_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCorrente_aplicada_ge.KeyPress
    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '---------------------------------------------------------------------------------------------------
    '                               Verificação dos dados numéricos
    '---------------------------------------------------------------------------------------------------
    If KeyAscii < System.Windows.Forms.Keys.D0 Or KeyAscii > System.Windows.Forms.Keys.D9 Then
      KeyAscii = 0
      MsgBox("Digite um valor numérico!", MsgBoxStyle.OkOnly, "Aviso!")
    End If
    '---------------------------------------------------------------------------------------------------
    eventArgs.KeyChar = Chr(KeyAscii)
    If KeyAscii = 0 Then
      eventArgs.Handled = True
    End If
  End Sub
  Private Sub txtCorrente_aplicada_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCorrente_aplicada.KeyPress
    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '---------------------------------------------------------------------------------------------------
    '                               Verificação dos dados numéricos
    '---------------------------------------------------------------------------------------------------
    If KeyAscii < System.Windows.Forms.Keys.D0 Or KeyAscii > System.Windows.Forms.Keys.D9 Then
      KeyAscii = 0
      MsgBox("Digite um valor numérico!", MsgBoxStyle.OkOnly, "Aviso!")
    End If
    '---------------------------------------------------------------------------------------------------
    eventArgs.KeyChar = Chr(KeyAscii)
    If KeyAscii = 0 Then
      eventArgs.Handled = True
    End If
  End Sub
  Private Sub txtCorrente_pickup_ge_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCorrente_pickup_ge.KeyPress
    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '---------------------------------------------------------------------------------------------------
    '                               Verificação dos dados numéricos
    '---------------------------------------------------------------------------------------------------
    If KeyAscii < System.Windows.Forms.Keys.D0 Or KeyAscii > System.Windows.Forms.Keys.D9 Then
      KeyAscii = 0
      MsgBox("Digite um valor numérico!", MsgBoxStyle.OkOnly, "Aviso!")
    End If
    '---------------------------------------------------------------------------------------------------
    eventArgs.KeyChar = Chr(KeyAscii)
    If KeyAscii = 0 Then
      eventArgs.Handled = True
    End If
  End Sub
  Private Sub txtCorrente_pickup_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCorrente_pickup.KeyPress
    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '---------------------------------------------------------------------------------------------------
    '                               Verificação dos dados numéricos
    '---------------------------------------------------------------------------------------------------
    If KeyAscii < System.Windows.Forms.Keys.D0 Or KeyAscii > System.Windows.Forms.Keys.D9 Then
      KeyAscii = 0
      MsgBox("Digite um valor numérico!", MsgBoxStyle.OkOnly, "Aviso!")
    End If
    '---------------------------------------------------------------------------------------------------
    eventArgs.KeyChar = Chr(KeyAscii)
    If KeyAscii = 0 Then
      eventArgs.Handled = True
    End If
  End Sub
  Private Sub txtTime_dial_ge_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime_dial_ge.KeyPress
    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '---------------------------------------------------------------------------------------------------
    '                               Verificação dos dados numéricos
    '---------------------------------------------------------------------------------------------------
    If KeyAscii < System.Windows.Forms.Keys.D0 Or KeyAscii > System.Windows.Forms.Keys.D9 Then
      KeyAscii = 0
      MsgBox("Digite um valor numérico!", MsgBoxStyle.OkOnly, "Aviso!")
    End If
    '---------------------------------------------------------------------------------------------------
    eventArgs.KeyChar = Chr(KeyAscii)
    If KeyAscii = 0 Then
      eventArgs.Handled = True
    End If
  End Sub
  Private Sub txtTime_dial_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime_dial.KeyPress
    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '---------------------------------------------------------------------------------------------------
    '                               Verificação dos dados numéricos
    '---------------------------------------------------------------------------------------------------
    If KeyAscii < System.Windows.Forms.Keys.D0 Or KeyAscii > System.Windows.Forms.Keys.D9 Then
      If Not KeyAscii = 46 Then
        KeyAscii = 0
        MsgBox("Digite um valor numérico!", MsgBoxStyle.OkOnly, "Aviso!")
      End If
    End If
    '---------------------------------------------------------------------------------------------------
    eventArgs.KeyChar = Chr(KeyAscii)
    If KeyAscii = 0 Then
      eventArgs.Handled = True
    End If
  End Sub
  Private Sub txtTolerancia_ge_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTolerancia_ge.KeyPress
    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '---------------------------------------------------------------------------------------------------
    '                               Verificação dos dados numéricos
    '---------------------------------------------------------------------------------------------------
    If KeyAscii < System.Windows.Forms.Keys.D0 Or KeyAscii > System.Windows.Forms.Keys.D9 Then
      KeyAscii = 0
      MsgBox("Digite um valor numérico!", MsgBoxStyle.OKOnly, "Aviso!")
    End If
    '---------------------------------------------------------------------------------------------------
    eventArgs.KeyChar = Chr(KeyAscii)
    If KeyAscii = 0 Then
      eventArgs.Handled = True
    End If
  End Sub
  Private Sub txtTolerancia_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTolerancia.KeyPress
    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '---------------------------------------------------------------------------------------------------
    '                               Verificação dos dados numéricos
    '---------------------------------------------------------------------------------------------------
    If KeyAscii < System.Windows.Forms.Keys.D0 Or KeyAscii > System.Windows.Forms.Keys.D9 Then
      If Not KeyAscii = 46 Then
        KeyAscii = 0
        MsgBox("Digite um valor numérico!", MsgBoxStyle.OKOnly, "Aviso!")
      End If
    End If
    '---------------------------------------------------------------------------------------------------
    eventArgs.KeyChar = Chr(KeyAscii)
    If KeyAscii = 0 Then
      eventArgs.Handled = True
    End If
  End Sub
  Private Sub frmCurvas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub
End Class