//---------------------------------------------------------------------------

#ifndef SobrecorrenteH
#define SobrecorrenteH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ComCtrls.hpp>
#include <ExtCtrls.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
        TTabControl *TabControl1;
        TPanel *Panel1;
        TButton *Button1;
        TButton *Button2;
        TComboBox *ComboBox1;
        TGroupBox *GroupBox1;
        TGroupBox *GroupBox2;
        TEdit *Edit1;
        TEdit *Edit2;
        TEdit *Edit3;
        TEdit *Edit4;
        TLabel *Label1;
        TLabel *Label2;
        TLabel *Label3;
        TLabel *Label4;
        TLabel *Label5;
        TLabel *Label6;
        TLabel *Label7;
        TLabel *Label8;
        TEdit *Edit5;
        TLabel *Label11;
        TLabel *Label9;
        TEdit *Edit6;
        TLabel *Label12;
        TLabel *Label10;
        TEdit *Edit7;
        TLabel *Label13;
        TPanel *Panel2;
        TComboBox *ComboBox2;
        TGroupBox *GroupBox3;
        TLabel *Label14;
        TLabel *Label15;
        TLabel *Label16;
        TLabel *Label17;
        TLabel *Label18;
        TLabel *Label19;
        TLabel *Label20;
        TEdit *Edit8;
        TEdit *Edit9;
        TEdit *Edit10;
        TEdit *Edit11;
        TGroupBox *GroupBox4;
        TLabel *Label21;
        TLabel *Label24;
        TLabel *Label22;
        TLabel *Label25;
        TLabel *Label23;
        TLabel *Label26;
        TEdit *Edit12;
        TEdit *Edit13;
        TEdit *Edit14;
        TPanel *Panel3;
        TLabel *Label27;
        TLabel *Label28;
        void __fastcall Button2Click(TObject *Sender);
        void __fastcall TabControl1Change(TObject *Sender);
        void __fastcall Button1Click(TObject *Sender);
        void __fastcall ComboBox1Change(TObject *Sender);
        void __fastcall ComboBox2Change(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
