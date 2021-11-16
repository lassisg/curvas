unit Principal;

interface

uses
  {--------------------------------------------------------------------------}
  {  Aqui em "uses", é necessário adicionar "Math" para que se possa usar    }
  {  a função de potenciação "Power(x,y)".                                   }
  {  Por exemplo: Power(2,2) será igual a 4.                                 }
  {               Power(4,3) será igual a 64.                                }
  {--------------------------------------------------------------------------}
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, QStdCtrls, QControls, QForms, Math, QExtCtrls, QComCtrls, UrlMon;

type
  TForm1 = class(TForm)
    TabControl1: TTabControl;
    Panel1: TPanel;
    ComboBox1: TComboBox;
    GroupBox1: TGroupBox;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Button1: TButton;
    GroupBox2: TGroupBox;
    Edit5: TEdit;
    Edit6: TEdit;
    Edit7: TEdit;
    Label8: TLabel;
    Label9: TLabel;
    Label10: TLabel;
    Label11: TLabel;
    Label12: TLabel;
    Label13: TLabel;
    Button2: TButton;
    Panel2: TPanel;
    ComboBox2: TComboBox;
    GroupBox3: TGroupBox;
    Edit8: TEdit;
    Edit9: TEdit;
    Edit10: TEdit;
    Edit11: TEdit;
    Label14: TLabel;
    Label15: TLabel;
    Label16: TLabel;
    Label17: TLabel;
    Label18: TLabel;
    Label19: TLabel;
    Label20: TLabel;
    Button3: TButton;
    GroupBox4: TGroupBox;
    Edit12: TEdit;
    Edit13: TEdit;
    Edit14: TEdit;
    Label21: TLabel;
    Label22: TLabel;
    Label23: TLabel;
    Label24: TLabel;
    Label25: TLabel;
    Label26: TLabel;
    Button4: TButton;
    Panel3: TPanel;
    Label27: TLabel;
    Label28: TLabel;
    Label29: TLabel;
    Label30: TLabel;
    Label31: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure ComboBox1Change(Sender: TObject);
    procedure ComboBox2Change(Sender: TObject);
    procedure TabControl1Change(Sender: TObject);
    procedure Label29Click(Sender: TObject);
    procedure Label31Click(Sender: TObject);
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
  {--------------------------------------------------------------------------}
  {  Todas as fórmulas utulizadas abaixo foram retiradas dos manuais da      }
  {  Areva T&D. Verificar se ANSI=IEEE, pois é assim que consta nos manuais  }
  {  Os manuais pesquisados foram os dos seguintes relés: - P127             }
  {                                                       - P142             }
  {--------------------------------------------------------------------------}
  Case ComboBox1.ItemIndex of
        // ANSI/IEEE Extremely Inverse
        0: Tcalc:=Tdial*((28.2/((Power((Iap/Ipkp),2))-1))+0.1217);
        // ANSI/IEEE Very Inverse
        1: Tcalc:=Tdial*((19.61/((Power((Iap/Ipkp),2))-1))+0.491);
        // ANSI/IEEE Moderately Inverse
        2: Tcalc:=Tdial*((0.0515/((Power((Iap/Ipkp),0.02))-1))+0.114);
        // IEC Extremely Inverse
        3: Tcalc:=TDial*(80/((Power((Iap/Ipkp),2))-1));
        // IEC Very Inverse
        4: Tcalc:=TDial*(13.5/((Power((Iap/Ipkp),1))-1));
        // IEC Standard Inverse
        5: Tcalc:=TDial*(0.14/((Power((Iap/Ipkp),0.2))-1));
        // UK Long Time Inverse
        6: Tcalc:=TDial*(120/((Power((Iap/Ipkp),1))-1));
        // UK Rectifier
        7: Tcalc:=TDial*(45900/((Power((Iap/Ipkp),5.6))-1));
        // US Inverse
        8: Tcalc:=TDial*((5.95/((Power((Iap/Ipkp),2))-1))+0.18);
        // US Short Time Inverse
        9: Tcalc:=TDial*((0.16758/((Power((Iap/Ipkp),0.02))-1))+0.11858);
      End;
  Tmax:=Tcalc+(Tcalc*(Toler/100));
  Tmin:=Tcalc-(Tcalc*(Toler/100));
  If Tcalc < 1 Then
  Begin
    Tcalc:=Tcalc*1000;
    Label11.Caption:='ms';
  End
  Else  Label11.Caption:='s';
  If Tmax < 1 Then
  Begin
    Tmax:=Tmax*1000;
    Label12.Caption:='ms';
  End
  Else  Label12.Caption:='s';
  If Tmin < 1 Then
  Begin
    Tmin:=Tmin*1000;
    Label13.Caption:='ms';
  End
  Else  Label13.Caption:='s';
  //  Formatção dos "Edit Boxes"
  Edit5.Text:=formatfloat('###,###,##0.000', Tcalc);
  Edit6.Text:=formatfloat('###,###,##0.000', Tmax);
  Edit7.Text:=formatfloat('###,###,##0.000', Tmin);
end;

procedure TForm1.Button3Click(Sender: TObject);
begin
  Ipkp:=StrToFloat(Edit8.Text);       // Lendo valor da Edit8
  Iap:=StrToFloat(Edit9.Text);        // Lendo valor da Edit9
  Tdial:=StrToFloat(Edit10.Text);      // Lendo valor da Edit10
  Toler:=StrToFloat(Edit11.Text);      // Lendo valor da Edit11
  {--------------------------------------------------------------------------}
  {  Todas as fórmulas utulizadas abaixo foram retiradas dos manuais da      }
  {  Areva T&D. Verificar se ANSI=IEEE, pois é assim que consta nos manuais  }
  {  Os manuais pesquisados foram os dos seguintes relés: - P127             }
  {                                                       - P142             }
  {--------------------------------------------------------------------------}
    //  Rever curvas Flex Curves
  Case ComboBox2.ItemIndex of
        // ANSI Extremely Inverse
        0: Tcalc:=TDial*(0.0399+(0.2294/((Iap/Ipkp)-0.5))+(3.0094/Power(((Iap/Ipkp)-0.5),2))+(0.7222/Power(((Iap/Ipkp)-0.5),3)));
        // ANSI Very Inverse
        1: Tcalc:=TDial*(0.0615+(0.7989/((Iap/Ipkp)-0.34))+(-0.2840/Power(((Iap/Ipkp)-0.34),2))+(4.0505/Power(((Iap/Ipkp)-0.34),3)));
        // ANSI Normaly Inverse
        2: Tcalc:=TDial*(0.0274+(2.2614/((Iap/Ipkp)-0.3))+(-4.1899/Power(((Iap/Ipkp)-0.3),2))+(9.1272/Power(((Iap/Ipkp)-0.3),3)));
        // ANSI Moderately Inverse
        3: Tcalc:=TDial*(0.1735+(0.6791/((Iap/Ipkp)-0.8))+(-0.0800/Power(((Iap/Ipkp)-0.8),2))+(0.1271/Power(((Iap/Ipkp)-0.8),3)));
        // IEC Extremely Inverse (Curve C)
        4: Tcalc:=TDial*(80/((Power((Iap/Ipkp),2))-1));
        // IEC Very Inverse (Curve B)
        5: Tcalc:=TDial*(13.5/((Power((Iap/Ipkp),1))-1));
        // IEC Standard Inverse (Curve A)
        6: Tcalc:=TDial*(0.14/((Power((Iap/Ipkp),0.02))-1));
        // IEC Short Time Inverse
        7: Tcalc:=TDial*(0.05/((Power((Iap/Ipkp),0.04))-1));
        // IEEE Extremely Inverse
        8: Tcalc:=TDial*((28.2/((Power((Iap/Ipkp),2))-1))+0.1217);
        // IEEE Very Inverse
        9: Tcalc:=TDial*((19.61/((Power((Iap/Ipkp),2))-1))+0.491);
        // IEEE Moderately Inverse
        10: Tcalc:=TDial*((0.0515/((Power((Iap/Ipkp),0.02))-1))+0.114);
        // IAC Extremely Inverse
        11: Tcalc:=TDial*(0.0040+(0.6379/((Iap/Ipkp)-0.62))+(1.7872/Power(((Iap/Ipkp)-0.62),2))+(0.2461/Power(((Iap/Ipkp)-0.62),3)));
        // IAC Very Inverse
        12: Tcalc:=TDial*(0.0900+(0.7955/((Iap/Ipkp)-0.1))+(-1.2885/Power(((Iap/Ipkp)-0.10),2))+(7.9586/Power(((Iap/Ipkp)-0.10),3)));
        // IAC Inverse
        13: Tcalc:=TDial*(0.2078+(0.8630/((Iap/Ipkp)-0.8))+(-0.4180/Power(((Iap/Ipkp)-0.80),2))+(0.1947/Power(((Iap/Ipkp)-0.80),3)));
        // IAC Short Inverse
        14: Tcalc:=TDial*(0.0428+(0.0609/((Iap/Ipkp)-0.62))+(-0.001/Power(((Iap/Ipkp)-0.62),2))+(0.0221/Power(((Iap/Ipkp)-0.62),3)));
        // i2t
        15: Tcalc:=Tdial*(100/Power((Iap/Ipkp),2));
      End;
  Tmax:=Tcalc+(Tcalc*(Toler/100));
  Tmin:=Tcalc-(Tcalc*(Toler/100));
  If Tcalc < 1 Then
  Begin
    Tcalc:=Tcalc*1000;
    Label24.Caption:='ms';
  End
  Else  Label24.Caption:='s';
  If Tmax < 1 Then
  Begin
    Tmax:=Tmax*1000;
    Label25.Caption:='ms';
  End
  Else  Label25.Caption:='s';
  If Tmin < 1 Then
  Begin
    Tmin:=Tmin*1000;
    Label26.Caption:='ms';
  End
  Else  Label26.Caption:='s';
  //  Formatção dos "Edit Boxes"
  Edit12.Text:=formatfloat('###,###,##0.000', Tcalc);
  Edit13.Text:=formatfloat('###,###,##0.000', Tmax);
  Edit14.Text:=formatfloat('###,###,##0.000', Tmin);
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
  Close;
end;

procedure TForm1.ComboBox1Change(Sender: TObject);
begin
  Edit5.Clear;
  Edit6.Clear;
  Edit7.Clear;
  Button1.Enabled := True;
end;

procedure TForm1.ComboBox2Change(Sender: TObject);
begin
  Edit12.Clear;
  Edit13.Clear;
  Edit14.Clear;
  Button3.Enabled := True;
end;

procedure TForm1.TabControl1Change(Sender: TObject);
begin
  If TabControl1.TabIndex = 0 Then
  Begin
    Panel1.Visible := True;
    Panel2.Visible := False;
    Panel3.Visible := False;
  End
  Else If TabControl1.TabIndex = 1 Then
  Begin
    Panel1.Visible := False;
    Panel2.Visible := True;
    Panel3.Visible := False;
  End
  Else If TabControl1.TabIndex = 2 Then
  Begin
    Panel1.Visible := False;
    Panel2.Visible := False;
    Panel3.Visible := True;
  End;
end;

procedure TForm1.Label29Click(Sender: TObject);
begin
  HlinkNavigateString(nil,'http://www.khis.com.br');
end;

procedure TForm1.Label31Click(Sender: TObject);
begin
  HlinkNavigateString(nil,'mailto:suporte@khis.com.br');
end;

end.

