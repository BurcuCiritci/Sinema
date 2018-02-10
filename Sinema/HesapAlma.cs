using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema
{
    public partial class HesapAlma : Form
    {
        Form1 AnaKayit;
        int adet;
        int a1 =0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, b1 = 0, b3 = 0, b4 = 0, b5 = 0, b6 = 0, c1 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0;
        int toplam = 0;
        
        public HesapAlma(Form1 frm,int sayi,int A1,int A3,int A4,int A5,int A6,int B1,int B3,int B4,int B5, int B6, int C1,int C3,int C4, int C5, int C6)
        {
            AnaKayit = frm;
            adet = sayi;
            a1=A1;
            a3=A3;
            a4=A4;
            a5=A5;
            a6=A6;
            b1 = B1;
            b3 = B3;
            b4 = B4;
            b5 = B5;
            b6 = B6;
            c1 = C1;
            c3 = C3;
            c4 = C4;
            c5 = C5;
            c6 = C6;

            InitializeComponent();
        }
       
        

        private void btnHsp_Click(object sender, EventArgs e)
        {
            int ogr =0;
            int gozluk=0;
            int menu=0;
            Int32.TryParse(txtOgr.Text, out ogr);
            Int32.TryParse(txtGozluk.Text, out gozluk);
            Int32.TryParse(txtMenu.Text, out menu);
            while (ogr > adet)
            {
                MessageBox.Show("Seçilen koltuk sayısına göre öğrenci sayısı belirleyin.");
                txtOgr.Text =" ";
                ogr = 0;
            }
            
            toplam = ((adet - ogr) * 20) + (ogr * 15) + (gozluk * 6) + (menu * 10);
            lblToplam.Text = toplam.ToString();
            
            
            
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            
            
            if (a1 == 2)
            {
                AnaKayit.A1Kayit();
            }
            if (a3 == 1)
            {
                AnaKayit.A3Kayit();
            }
            if (a4==1)
            {
                AnaKayit.A4Kayit();
            }
            if (a5==1)
            {
                AnaKayit.A5Kayit();
            }
            if (a6==1)
            {
                AnaKayit.A6Kayit();
            }
            if (b1==2)
            {
                AnaKayit.B1Kayit();
            }
            if (b3==1)
            {
                AnaKayit.B3Kayit();
            }
            if (b4==1)
            {
                AnaKayit.B4Kayit();
            }
            if (b5==1)
            {
                AnaKayit.B5Kayit();
            }
            if (b6==1)
            {
                AnaKayit.B6Kayit();
            }
            if (c1==2)
            {
                AnaKayit.C1C2Kayit();
            }
            if (c3==1)
            {
                AnaKayit.C3Kayit();
            }
            if (c4==1)
            {
                AnaKayit.C4Kayit();
            }
            if (c5==1)
            {
                AnaKayit.C5Kayit();
            }
            if (c6==1)
            {
                AnaKayit.C6Kayit();
            }
            this.Close();
        }


        private void btnIptal_Click(object sender, EventArgs e)
        {
            
            if (a1 == 2)
            {
                AnaKayit.A1iptal();
            }
            if (a3 == 1)
            {
                AnaKayit.A3iptal();
            }
            if (a4 == 1)
            {
                AnaKayit.A4iptal();
            }
            if (a5 == 1)
            {
                AnaKayit.A5iptal();
            }
            if (a6 == 1)
            {
                AnaKayit.A6iptal();
            }
            if (b1 == 2)
            {
                AnaKayit.B1iptal();
            }
            if (b3 == 1)
            {
                AnaKayit.B3iptal();
            }
            if (b4 == 1)
            {
                AnaKayit.B4iptal();
            }
            if (b5 == 1)
            {
                AnaKayit.B5iptal();
            }
            if (b6 == 1)
            {
                AnaKayit.B6iptal();
            }
            if (c1 == 2)
            {
                AnaKayit.C1C2iptal();
            }
            if (c3 == 1)
            {
                AnaKayit.C3iptal();
            }
            if (c4 == 1)
            {
                AnaKayit.C4iptal();
            }
            if (c5 == 1)
            {
                AnaKayit.C5iptal();
            }
            if (c6 == 1)
            {
                AnaKayit.C6iptal();
            }
            
            this.Close();
        }


        private void lblGozluk_Click(object sender, EventArgs e)
        {

        }
    }
}
