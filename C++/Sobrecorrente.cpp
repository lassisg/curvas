//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Sobrecorrente.h"
#include "Math.h"       // Possibilita utilizar a função "pow(x,y)"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
//      Declaração de Variáveis Globais
float Ipkp;          //  Corrente de Pickup ajustada no relé
float Iap;           //  Corrente aplicada no teste
float Tdial;         //  Multiplicador da curva inversa
float Tcalc;         //  Tempo calculado através da fórmula da curva selecionada
float Tmax;          //  Tempo máximo aceitável
float Tmin;          //  Tempo mínimo aceitável
float Toler;         //  Tolerância dada pelo fabricante do Relé
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button2Click(TObject *Sender)
{
Form1->Close();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::TabControl1Change(TObject *Sender)
{
        if (TabControl1->TabIndex==0)
        {
                Panel1->Visible=True;
                Panel2->Visible=False;
                Panel3->Visible=False;
                Button1->Visible=True;
                Button1->Enabled=False;
                Button2->Visible=True;
        }
        else if (TabControl1->TabIndex==1)
        {
                Panel1->Visible=False;
                Panel2->Visible=True;
                Panel3->Visible=False;
                Button1->Visible=True;
                Button1->Enabled=False;
                Button2->Visible=True;
        }
        else if (TabControl1->TabIndex==2)
        {
                Panel1->Visible=False;
                Panel2->Visible=False;
                Panel3->Visible=True;
                Button1->Visible=False;
                Button2->Visible=True;
        }
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
//**************************************************************************/
//  Todas as fórmulas utulizadas abaixo foram retiradas dos manuais da      /
//  Areva T&D. Verificar se ANSI=IEEE, pois é assim que consta nos manuais  /
//  Os manuais pesquisados foram os dos seguintes relés: - P127             /
//                                                       - P142             /
//**************************************************************************/
        if (TabControl1->TabIndex==0)
        {
                Ipkp=StrToFloat(Edit1->Text);       // Lendo valor da Edit1
                Iap=StrToFloat(Edit2->Text);        // Lendo valor da Edit2
                Tdial=StrToFloat(Edit3->Text);      // Lendo valor da Edit3
                Toler=StrToFloat(Edit4->Text);      // Lendo valor da Edit4
                switch (ComboBox1->ItemIndex)
                {
                        // ANSI/IEEE Extremely Inverse
                        case 0:
                                Tcalc=Tdial*((28.2/((pow((Iap/Ipkp),2))-1))+0.1217);
                                break;
                        // ANSI/IEEE Very Inverse
                        case 1:
                                Tcalc=Tdial*((19.61/((pow((Iap/Ipkp),2))-1))+0.491);
                                break;
                        // ANSI/IEEE Moderately Inverse
                        case 2:
                                Tcalc=Tdial*((0.0515/((pow((Iap/Ipkp),0.02))-1))+0.114);
                                break;
                        // IEC Extremely Inverse
                        case 3:
                                Tcalc=Tdial*(80/((pow((Iap/Ipkp),2))-1));
                                break;
                        // IEC Very Inverse
                        case 4:
                                Tcalc=Tdial*(13.5/((pow((Iap/Ipkp),1))-1));
                                break;
                        // IEC Standard Inverse
                        case 5:
                                Tcalc=Tdial*(0.14/((pow((Iap/Ipkp),0.2))-1));
                                break;
                        // UK Long Time Inverse
                        case 6:
                                Tcalc=Tdial*(120/((pow((Iap/Ipkp),1))-1));
                                break;
                        // UK Rectifier
                        case 7: Tcalc=Tdial*(45900/((pow((Iap/Ipkp),5.6))-1));
                                break;
                        // US Inverse
                        case 8:
                                Tcalc=Tdial*((5.95/((pow((Iap/Ipkp),2))-1))+0.18);
                                break;
                        // US Short Time Inverse
                        case 9:
                                Tcalc=Tdial*((0.16758/((pow((Iap/Ipkp),0.02))-1))+0.11858);
                                break;
                }
                Tmax=Tcalc+(Tcalc*(Toler/100));
                Tmin=Tcalc-(Tcalc*(Toler/100));
                if (Tcalc < 1)
                {
                        Tcalc*=1000;
                        Label11->Caption="ms";
                }
                else { Label11->Caption="s";}
                if (Tmin < 1)
                {
                        Tmin*=1000;
                        Label12->Caption="ms";
                }
                else { Label12->Caption="s";}
                if (Tmax < 1)
                {
                        Tmax*=1000;
                        Label13->Caption="ms";
                }
                else { Label13->Caption="s";}
                //  Formatção dos "Edit Boxes"
                Edit5->Text=FormatFloat("###,###,##0.000", Tcalc);
                Edit6->Text=FormatFloat("###,###,##0.000", Tmin);
                Edit7->Text=FormatFloat("###,###,##0.000", Tmax);
        }
        else if (TabControl1->TabIndex==1)
        {
                Ipkp=StrToFloat(Edit8->Text);        // Lendo valor da Edit1
                Iap=StrToFloat(Edit9->Text);         // Lendo valor da Edit2
                Tdial=StrToFloat(Edit10->Text);      // Lendo valor da Edit3
                Toler=StrToFloat(Edit11->Text);      // Lendo valor da Edit4
switch (ComboBox1->ItemIndex)
                {
                        // ANSI Extremely Inverse
                        case 0:
                                Tcalc=Tdial*(0.0399+(0.2294/((Iap/Ipkp)-0.5))+(3.0094/pow(((Iap/Ipkp)-0.5),2))+(0.7222/pow(((Iap/Ipkp)-0.5),3)));
                                break;
                        // ANSI Very Inverse
                        case 1:
                                Tcalc=Tdial*(0.0615+(0.7989/((Iap/Ipkp)-0.34))+(-0.2840/pow(((Iap/Ipkp)-0.34),2))+(4.0505/pow(((Iap/Ipkp)-0.34),3)));
                                break;
                        // ANSI Normaly Inverse
                        case 2:
                                Tcalc=Tdial*(0.0274+(2.2614/((Iap/Ipkp)-0.3))+(-4.1899/pow(((Iap/Ipkp)-0.3),2))+(9.1272/pow(((Iap/Ipkp)-0.3),3)));
                                break;
                        // ANSI Moderately Inverse
                        case 3:
                                Tcalc=Tdial*(0.1735+(0.6791/((Iap/Ipkp)-0.8))+(-0.0800/pow(((Iap/Ipkp)-0.8),2))+(0.1271/pow(((Iap/Ipkp)-0.8),3)));
                                break;
                        // IEC Extremely Inverse (Curve C)
                        case 4:
                                Tcalc=Tdial*(80/((pow((Iap/Ipkp),2))-1));
                                break;
                        // IEC Very Inverse (Curve B)
                        case 5:
                                Tcalc=Tdial*(13.5/((pow((Iap/Ipkp),1))-1));
                                break;
                        // IEC Standard Inverse (Curve A)
                        case 6:
                                Tcalc=Tdial*(0.14/((pow((Iap/Ipkp),0.02))-1));
                                break;
                        // IEC Short Time Inverse
                        case 7: Tcalc=Tdial*(0.05/((pow((Iap/Ipkp),0.04))-1));
                                break;
                        // IEEE Extremely Inverse
                        case 8:
                                Tcalc=Tdial*((28.2/((pow((Iap/Ipkp),2))-1))+0.1217);
                                break;
                        // IEEE Very Inverse
                        case 9:
                                Tcalc=Tdial*((19.61/((pow((Iap/Ipkp),2))-1))+0.491);
                                break;
                        // IEEE Moderately Inverse
                        case 10:
                                Tcalc=Tdial*((0.0515/((pow((Iap/Ipkp),0.02))-1))+0.114);
                                break;
                        // IAC Extremely Inverse
                        case 11:
                                Tcalc=Tdial*(0.0040+(0.6379/((Iap/Ipkp)-0.62))+(1.7872/pow(((Iap/Ipkp)-0.62),2))+(0.2461/pow(((Iap/Ipkp)-0.62),3)));
                                break;
                        // IAC Very Inverse
                        case 12:
                                Tcalc=Tdial*(0.0900+(0.7955/((Iap/Ipkp)-0.1))+(-1.2885/pow(((Iap/Ipkp)-0.10),2))+(7.9586/pow(((Iap/Ipkp)-0.10),3)));
                                break;
                        // IAC Inverse
                        case 13:
                                Tcalc=Tdial*(0.2078+(0.8630/((Iap/Ipkp)-0.8))+(-0.4180/pow(((Iap/Ipkp)-0.80),2))+(0.1947/pow(((Iap/Ipkp)-0.80),3)));
                                break;
                        // IAC Short Inverse
                        case 14:
                                Tcalc=Tdial*(0.0428+(0.0609/((Iap/Ipkp)-0.62))+(-0.001/pow(((Iap/Ipkp)-0.62),2))+(0.0221/pow(((Iap/Ipkp)-0.62),3)));
                                break;
                        // i2t
                        case 15:
                                Tcalc=Tdial*(100/pow((Iap/Ipkp),2));
                                break;
                }
                Tmax=Tcalc+(Tcalc*(Toler/100));
                Tmin=Tcalc-(Tcalc*(Toler/100));
                if (Tcalc < 1)
                {
                        Tcalc*=1000;
                        Label24->Caption="ms";
                }
                else { Label24->Caption="s";}
                if (Tmin < 1)
                {
                        Tmin*=1000;
                        Label25->Caption="ms";
                }
                else { Label25->Caption="s";}
                if (Tmax < 1)
                {
                        Tmax*=1000;
                        Label26->Caption="ms";
                }
                else { Label26->Caption="s";}
                //  Formatção dos "Edit Boxes"
                Edit12->Text=FormatFloat("###,###,##0.000", Tcalc);
                Edit13->Text=FormatFloat("###,###,##0.000", Tmin);
                Edit14->Text=FormatFloat("###,###,##0.000", Tmax);
        }
}
//---------------------------------------------------------------------------
void __fastcall TForm1::ComboBox1Change(TObject *Sender)
{
        Edit5->Clear();
        Edit6->Clear();
        Edit7->Clear();
        Button1->Enabled=True;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::ComboBox2Change(TObject *Sender)
{
        Edit12->Clear();
        Edit13->Clear();
        Edit14->Clear();
        Button1->Enabled=True;
}
//---------------------------------------------------------------------------
