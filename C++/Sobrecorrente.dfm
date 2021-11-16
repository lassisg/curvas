object Form1: TForm1
  Left = 190
  Top = 99
  Width = 420
  Height = 284
  Caption = 'Sobrecorrente'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object TabControl1: TTabControl
    Left = 0
    Top = 0
    Width = 412
    Height = 257
    TabOrder = 0
    Tabs.Strings = (
      'Areva'
      'GE'
      'Sobre')
    TabIndex = 0
    OnChange = TabControl1Change
    object Panel3: TPanel
      Left = 0
      Top = 20
      Width = 410
      Height = 197
      TabOrder = 4
      object Label27: TLabel
        Left = 72
        Top = 24
        Width = 283
        Height = 13
        Caption = 'Este Software foi desenvolvido pela Know-how Info System.'
      end
      object Label28: TLabel
        Left = 72
        Top = 40
        Width = 112
        Height = 13
        Caption = 'http://www.khis.com.br'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clBlue
        Font.Height = -11
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsUnderline]
        ParentFont = False
      end
    end
    object Panel2: TPanel
      Left = 0
      Top = 20
      Width = 410
      Height = 197
      TabOrder = 3
      Visible = False
      object ComboBox2: TComboBox
        Left = 8
        Top = 8
        Width = 201
        Height = 21
        ItemHeight = 13
        TabOrder = 0
        Text = 'Escolha uma Curva'
        OnChange = ComboBox2Change
        Items.Strings = (
          'ANSI Extremely Inverse'
          'ANSI Very Inverse'
          'ANSI Normaly Inverse'
          'ANSI Moderately Inverse'
          'IEC Extremely Inverse (Curve C)'
          'IEC Very Inverse (Curve B)'
          'IEC Standard Inverse (Curve A)'
          'IEC Short Time Inverse'
          'IEEE Extremely Inverse'
          'IEEE Very Inverse'
          'IEEE Moderately Inverse'
          'IAC Extremely Inverse'
          'IAC Very Inverse'
          'IAC Inverse'
          'IAC Short Inverse'
          'i2t')
      end
      object GroupBox3: TGroupBox
        Left = 8
        Top = 40
        Width = 185
        Height = 145
        Caption = 'Dados'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 1
        object Label14: TLabel
          Left = 60
          Top = 20
          Width = 26
          Height = 13
          Caption = 'Ipkp'
        end
        object Label15: TLabel
          Left = 67
          Top = 52
          Width = 19
          Height = 13
          Caption = 'Iap'
        end
        object Label16: TLabel
          Left = 57
          Top = 84
          Width = 29
          Height = 13
          Caption = 'Tdial'
        end
        object Label17: TLabel
          Left = 62
          Top = 116
          Width = 24
          Height = 13
          Caption = 'Erro'
        end
        object Label18: TLabel
          Left = 155
          Top = 20
          Width = 9
          Height = 13
          Caption = 'A'
        end
        object Label19: TLabel
          Left = 155
          Top = 52
          Width = 9
          Height = 13
          Caption = 'A'
        end
        object Label20: TLabel
          Left = 155
          Top = 116
          Width = 10
          Height = 13
          Caption = '%'
        end
        object Edit8: TEdit
          Left = 88
          Top = 16
          Width = 65
          Height = 21
          TabOrder = 0
          Text = '5'
        end
        object Edit9: TEdit
          Left = 88
          Top = 48
          Width = 65
          Height = 21
          TabOrder = 1
          Text = '10'
        end
        object Edit10: TEdit
          Left = 88
          Top = 80
          Width = 65
          Height = 21
          TabOrder = 2
          Text = '1'
        end
        object Edit11: TEdit
          Left = 88
          Top = 112
          Width = 65
          Height = 21
          TabOrder = 3
          Text = '10'
        end
      end
      object GroupBox4: TGroupBox
        Left = 208
        Top = 40
        Width = 185
        Height = 145
        Caption = 'Resultados'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 2
        object Label21: TLabel
          Left = 53
          Top = 36
          Width = 33
          Height = 13
          Caption = 'Tcalc'
        end
        object Label24: TLabel
          Left = 155
          Top = 36
          Width = 7
          Height = 13
          Caption = 's'
        end
        object Label22: TLabel
          Left = 58
          Top = 68
          Width = 28
          Height = 13
          Caption = 'Tmin'
        end
        object Label25: TLabel
          Left = 155
          Top = 68
          Width = 7
          Height = 13
          Caption = 's'
        end
        object Label23: TLabel
          Left = 55
          Top = 100
          Width = 31
          Height = 13
          Caption = 'Tmax'
        end
        object Label26: TLabel
          Left = 155
          Top = 100
          Width = 7
          Height = 13
          Caption = 's'
        end
        object Edit12: TEdit
          Left = 88
          Top = 32
          Width = 65
          Height = 21
          Enabled = False
          TabOrder = 0
        end
        object Edit13: TEdit
          Left = 88
          Top = 64
          Width = 65
          Height = 21
          Enabled = False
          TabOrder = 1
        end
        object Edit14: TEdit
          Left = 88
          Top = 96
          Width = 65
          Height = 21
          Enabled = False
          TabOrder = 2
        end
      end
    end
    object Panel1: TPanel
      Left = 0
      Top = 20
      Width = 410
      Height = 197
      TabOrder = 0
      object ComboBox1: TComboBox
        Left = 8
        Top = 8
        Width = 201
        Height = 21
        ItemHeight = 13
        TabOrder = 0
        Text = 'Escolha uma Curva'
        OnChange = ComboBox1Change
        Items.Strings = (
          'ANSI/IEEE Extremely Inverse'
          'ANSI/IEEE Very Inverse'
          'ANSI/IEEE Moderately Inverse'
          'IEC Extremely Inverse'
          'IEC Very Inverse'
          'IEC Standard Inverse'
          'UK Long Time Inverse'
          'UK Rectifier'
          'US Inverse'
          'US Short Time Inverse')
      end
      object GroupBox1: TGroupBox
        Left = 8
        Top = 40
        Width = 185
        Height = 145
        Caption = 'Dados'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 1
        object Label1: TLabel
          Left = 60
          Top = 20
          Width = 26
          Height = 13
          Caption = 'Ipkp'
        end
        object Label2: TLabel
          Left = 67
          Top = 52
          Width = 19
          Height = 13
          Caption = 'Iap'
        end
        object Label3: TLabel
          Left = 57
          Top = 84
          Width = 29
          Height = 13
          Caption = 'Tdial'
        end
        object Label4: TLabel
          Left = 62
          Top = 116
          Width = 24
          Height = 13
          Caption = 'Erro'
        end
        object Label5: TLabel
          Left = 155
          Top = 20
          Width = 9
          Height = 13
          Caption = 'A'
        end
        object Label6: TLabel
          Left = 155
          Top = 52
          Width = 9
          Height = 13
          Caption = 'A'
        end
        object Label7: TLabel
          Left = 155
          Top = 116
          Width = 10
          Height = 13
          Caption = '%'
        end
        object Edit1: TEdit
          Left = 88
          Top = 16
          Width = 65
          Height = 21
          TabOrder = 0
          Text = '5'
        end
        object Edit2: TEdit
          Left = 88
          Top = 48
          Width = 65
          Height = 21
          TabOrder = 1
          Text = '10'
        end
        object Edit3: TEdit
          Left = 88
          Top = 80
          Width = 65
          Height = 21
          TabOrder = 2
          Text = '1'
        end
        object Edit4: TEdit
          Left = 88
          Top = 112
          Width = 65
          Height = 21
          TabOrder = 3
          Text = '10'
        end
      end
      object GroupBox2: TGroupBox
        Left = 208
        Top = 40
        Width = 185
        Height = 145
        Caption = 'Resultados'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'MS Sans Serif'
        Font.Style = [fsBold]
        ParentFont = False
        TabOrder = 2
        object Label8: TLabel
          Left = 53
          Top = 36
          Width = 33
          Height = 13
          Caption = 'Tcalc'
        end
        object Label11: TLabel
          Left = 155
          Top = 36
          Width = 7
          Height = 13
          Caption = 's'
        end
        object Label9: TLabel
          Left = 58
          Top = 68
          Width = 28
          Height = 13
          Caption = 'Tmin'
        end
        object Label12: TLabel
          Left = 155
          Top = 68
          Width = 7
          Height = 13
          Caption = 's'
        end
        object Label10: TLabel
          Left = 55
          Top = 100
          Width = 31
          Height = 13
          Caption = 'Tmax'
        end
        object Label13: TLabel
          Left = 155
          Top = 100
          Width = 7
          Height = 13
          Caption = 's'
        end
        object Edit5: TEdit
          Left = 88
          Top = 32
          Width = 65
          Height = 21
          Enabled = False
          TabOrder = 0
        end
        object Edit6: TEdit
          Left = 88
          Top = 64
          Width = 65
          Height = 21
          Enabled = False
          TabOrder = 1
        end
        object Edit7: TEdit
          Left = 88
          Top = 96
          Width = 65
          Height = 21
          Enabled = False
          TabOrder = 2
        end
      end
    end
    object Button1: TButton
      Left = 56
      Top = 224
      Width = 75
      Height = 25
      Caption = 'Calcular'
      Enabled = False
      TabOrder = 1
      OnClick = Button1Click
    end
    object Button2: TButton
      Left = 264
      Top = 224
      Width = 75
      Height = 25
      Caption = 'Fechar'
      TabOrder = 2
      OnClick = Button2Click
    end
  end
end
