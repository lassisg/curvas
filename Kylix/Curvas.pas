unit Curvas;

interface

uses
  {--------------------------------------------------------------------------}
  {  Aqui em "uses", é necessário adicionar "Math" para que se possa usar    }
  {  a função de potenciação "Power(x,y)".                                   }
  {  Por exemplo: Power(2,2) será igual a 4.                                 }
  {               Power(4,3) será igual a 64.                                }
  {--------------------------------------------------------------------------}
  SysUtils, Types, Classes, Variants, QTypes, QGraphics, QControls, QForms,
  QDialogs, QStdCtrls, Math;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Label1: TLabel;
    ComboBox1: TComboBox;
    Label2: TLabel;
    Edit2: TEdit;
    GroupBox1: TGroupBox;
    Edit5: TEdit;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Edit6: TEdit;
    Edit7: TEdit;
    Label6: TLabel;
    Edit3: TEdit;
    Button1: TButton;
    ComboBox2: TComboBox;
    Label7: TLabel;
    Edit4: TEdit;
    procedure Button1Click(Sender: TObject);
    procedure ComboBox1Change(Sender: TObject);
    procedure ComboBox2Change(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
    Ipkp: Real;          //  Corrente de Pickup ajustada no relé
    Iap: Real;           //  Corrente aplicada no teste
    Tdial: Real;         //  Multiplicador da curva inversa
    Tcalc: Real;         //  Tempo calculado através da fórmula da curva selecionada
    Tmax: Real;          //  Tempo máximo aceitável
    Tmin: Real;          //  Tempo mínimo aceitável
    Toler: Real;         //  Tolerância dada pelo fabricante do Relé
  end;

var
  Form1: TForm1;

implementation

{$R *.xfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
  Ipkp:=StrToFloat(Edit1.Text);       // Lendo valor da Edit1
  Iap:=StrToFloat(Edit2.Text);        // Lendo valor da Edit2
  Tdial:=StrToFloat(Edit3.Text);      // Lendo valor da Edit3
  Toler:=StrToFloat(Edit4.Text);      // Lendo valor da Edit4
  Case ComboBox1.ItemIndex of
    // Curvas ANSI
    0:Case ComboBox2.ItemIndex of
        // Extremely Inverse
        0: Tcalc:=Tdial*((28.2/((Power((Iap/Ipkp),2))-1))+0.1217);
        // Very Inverse
        1: Tcalc:=Tdial*((19.61/((Power((Iap/Ipkp),2))-1))+0.491);
        // Normaly Inverse
        2: Tcalc:=Tdial*((28.2/((Power((Iap/Ipkp),2))-1))+0.1217);
        // Moderately Inverse
        3: Tcalc:=Tdial*((0.0515/((Power((Iap/Ipkp),0.02))-1))+0.114);
      End;
    // Curvas IAC
    1:Case ComboBox2.ItemIndex of
        // Extremely Inverse
        0: Tcalc:=Tdial*((28.2/((Power((Iap/Ipkp),2))-1))+0.1217);
        // Very Inverse
        1: Tcalc:=Tdial*((19.61/((Power((Iap/Ipkp),2))-1))+0.491);
        // Inverse
        2: Tcalc:=Tdial*((28.2/((Power((Iap/Ipkp),2))-1))+0.1217);
        // Short Inverse
        3: Tcalc:=Tdial*((0.0515/((Power((Iap/Ipkp),0.02))-1))+0.114);
      End;
    // Curvas IEC
    2:Case ComboBox2.ItemIndex of
        // Curve A
        0: Tcalc:=TDial*(80/((Power((Iap/Ipkp),2))-1));
        // Curve B
        1: Tcalc:=TDial*(13.5/((Power((Iap/Ipkp),1))-1));
        // Curve C
        2: Tcalc:=TDial*(0.14/((Power((Iap/Ipkp),0.2))-1));
        // IEC Short Inverse
        3: Tcalc:=TDial*(0.14/((Power((Iap/Ipkp),0.2))-1));
      End;
    // Curvas IEEE                  Estas fórmulas estão incorretas
    3:Case ComboBox2.ItemIndex of
        // Extremely Inverse
        0: Tcalc:=TDial*((10/((Power((Iap/Ipkp),1))-1))+1);
        // Very Inverse
        1: Tcalc:=TDial*((10/((Power((Iap/Ipkp),1))-1))+1);
        // Normaly Inverse
        2: Tcalc:=TDial*((10/((Power((Iap/Ipkp),1))-1))+1);
        // Moderately Inverse
        3: Tcalc:=TDial*((10/((Power((Iap/Ipkp),1))-1))+1);
      End;
    // Curvas UK
    4:Case ComboBox2.ItemIndex of
        // Long Time Inverse
        0: Tcalc:=TDial*(120/((Power((Iap/Ipkp),1))-1));
        // Rectifier
        1: Tcalc:=TDial*(45900/((Power((Iap/Ipkp),5.6))-1));
      End;
    // Curvas US
    5:Case ComboBox2.ItemIndex of
        // Inverse
        0: Tcalc:=TDial*((5.95/((Power((Iap/Ipkp),2))-1))+0.18);
        // Short Time Inverse
        1: Tcalc:=TDial*((0.16758/((Power((Iap/Ipkp),0.02))-1))+0.11858);
      End;
  End;
  Tmax:=Tcalc+(Tcalc*(Toler/100));
  Tmin:=Tcalc-(Tcalc*(Toler/100));
  Edit5.Text:=VarToStr(Tcalc);
  Edit6.Text:=VarToStr(Tmax);
  Edit7.Text:=VarToStr(Tmin);
end;

procedure TForm1.ComboBox1Change(Sender: TObject);
begin
  ComboBox2.Clear;
  ComboBox2.Text:='(Tipo de curva)';
  Edit5.Clear;
  Edit6.Clear;
  Edit7.Clear;
  Case ComboBox1.ItemIndex of
    0:  Begin
          ComboBox2.Items.Add('Extremely Inverse');
          ComboBox2.Items.Add('Very Inverse');
          ComboBox2.Items.Add('Normaly Inverse');
          ComboBox2.Items.Add('Moderately Inverse');
        End;
    1:  Begin
          ComboBox2.Items.Add('Extremely Inverse');
          ComboBox2.Items.Add('Very Inverse');
          ComboBox2.Items.Add('Inverse');
          ComboBox2.Items.Add('Short Inverse');
        End;
    2:  Begin
          ComboBox2.Items.Add('Curve A');
          ComboBox2.Items.Add('Curve B');
          ComboBox2.Items.Add('Curve C');
          ComboBox2.Items.Add('IEC Short Inverse');
        End;
    3:  Begin
          ComboBox2.Items.Add('Extremely Inverse');
          ComboBox2.Items.Add('Very Inverse');
          ComboBox2.Items.Add('Normaly Inverse');
          ComboBox2.Items.Add('Moderately Inverse');
        End;
    4:  Begin
          ComboBox2.Items.Add('Long Time Inverse');
          ComboBox2.Items.Add('Rectifier');
        End;
    5:  Begin
          ComboBox2.Items.Add('Inverse');
          ComboBox2.Items.Add('Short Time Inverse');
        End;
    End;
end;

procedure TForm1.ComboBox2Change(Sender: TObject);
begin
  Edit5.Clear;
  Edit6.Clear;
  Edit7.Clear;
end;

end.

