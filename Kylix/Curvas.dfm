object Form1: TForm1
  Left = 190
  Top = 120
  Width = 185
  Height = 334
  HorzScrollBar.Range = 185
  VertScrollBar.Range = 333
  ActiveControl = ComboBox1
  Caption = 'Curvas 50/51'
  Color = clButton
  Font.Color = clText
  Font.Height = 11
  Font.Name = 'MS Sans Serif'
  Font.Pitch = fpVariable
  Font.Style = []
  Font.Weight = 0
  ParentFont = False
  PixelsPerInch = 96
  TextHeight = 18
  TextWidth = 5
  object Label2: TLabel
    Left = 23
    Top = 102
    Width = 52
    Height = 20
    Caption = 'Iaplicada'
    Font.Color = clText
    Font.Height = 13
    Font.Name = 'MS Sans Serif'
    Font.Pitch = fpVariable
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label1: TLabel
    Left = 38
    Top = 78
    Width = 42
    Height = 20
    Caption = 'Ipickup'
    Font.Color = clText
    Font.Height = 13
    Font.Name = 'MS Sans Serif'
    Font.Pitch = fpVariable
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label6: TLabel
    Left = 21
    Top = 126
    Width = 55
    Height = 20
    Caption = 'Time Dial'
    Font.Color = clText
    Font.Height = 13
    Font.Name = 'MS Sans Serif'
    Font.Pitch = fpVariable
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label7: TLabel
    Left = 13
    Top = 150
    Width = 61
    Height = 20
    Caption = 'Toler'#226'ncia'
    Font.Color = clText
    Font.Height = 13
    Font.Name = 'MS Sans Serif'
    Font.Pitch = fpVariable
    Font.Style = [fsBold]
    ParentFont = False
  end
  object GroupBox1: TGroupBox
    Left = 0
    Top = 213
    Width = 185
    Height = 120
    Caption = 'Resultados'
    Font.Color = clText
    Font.Height = 13
    Font.Name = 'MS Sans Serif'
    Font.Pitch = fpVariable
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 5
    object Label3: TLabel
      Left = 16
      Top = 33
      Width = 60
      Height = 20
      Caption = 'tcalculado'
      Font.Color = clText
      Font.Height = 13
      Font.Name = 'MS Sans Serif'
      Font.Pitch = fpVariable
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label4: TLabel
      Left = 35
      Top = 61
      Width = 47
      Height = 20
      Caption = 'Limite +'
      Font.Color = clText
      Font.Height = 13
      Font.Name = 'MS Sans Serif'
      Font.Pitch = fpVariable
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label5: TLabel
      Left = 38
      Top = 89
      Width = 45
      Height = 20
      Caption = 'Limite -'
      Font.Color = clText
      Font.Height = 13
      Font.Name = 'MS Sans Serif'
      Font.Pitch = fpVariable
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Edit5: TEdit
      Left = 96
      Top = 31
      Width = 81
      Height = 28
      ReadOnly = True
      TabOrder = 0
    end
    object Edit6: TEdit
      Left = 96
      Top = 59
      Width = 81
      Height = 28
      ReadOnly = True
      TabOrder = 1
    end
    object Edit7: TEdit
      Left = 96
      Top = 87
      Width = 81
      Height = 28
      ReadOnly = True
      TabOrder = 2
    end
  end
  object ComboBox1: TComboBox
    Left = 8
    Top = 5
    Width = 169
    Height = 28
    Font.Color = clText
    Font.Height = 13
    Font.Name = 'MS Sans Serif'
    Font.Pitch = fpVariable
    Font.Style = [fsBold]
    ItemHeight = 22
    Items.Strings = (
      'ANSI'
      'IAC'
      'IEC'
      'IEEE'
      'UK'
      'US')
    ParentFont = False
    TabOrder = 0
    Text = '(Escolha uma curva)'
    OnChange = ComboBox1Change
  end
  object Edit1: TEdit
    Left = 96
    Top = 76
    Width = 81
    Height = 26
    TabOrder = 1
    Text = '5'
  end
  object Edit2: TEdit
    Left = 96
    Top = 100
    Width = 81
    Height = 26
    TabOrder = 2
    Text = '10'
  end
  object Edit3: TEdit
    Left = 96
    Top = 124
    Width = 81
    Height = 26
    TabOrder = 3
    Text = '1'
  end
  object Button1: TButton
    Left = 54
    Top = 176
    Width = 81
    Height = 33
    Caption = 'Calcular'
    Font.Color = clText
    Font.Height = 13
    Font.Name = 'MS Sans Serif'
    Font.Pitch = fpVariable
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 4
    OnClick = Button1Click
  end
  object ComboBox2: TComboBox
    Left = 8
    Top = 41
    Width = 169
    Height = 28
    Font.Color = clText
    Font.Height = 13
    Font.Name = 'MS Sans Serif'
    Font.Pitch = fpVariable
    Font.Style = [fsBold]
    ItemHeight = 22
    Items.Strings = (
      '')
    ParentFont = False
    TabOrder = 6
    Text = '(Escolha uma curva)'
    OnChange = ComboBox2Change
  end
  object Edit4: TEdit
    Left = 96
    Top = 148
    Width = 81
    Height = 26
    TabOrder = 7
    Text = '10'
  end
end
