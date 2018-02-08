using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sinema

{
    public partial class Form1 : Form
    {
        StreamReader sr;
        string line;
        public Form1()
        {

            InitializeComponent();

        }

        int a1 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, b1 = 0, b3 = 0, b4 = 0, b5 = 0, b6 = 0, c1 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0;
        private void label2_Click(object sender, EventArgs e)
        {


            a1 = 2;
            label2.BackColor = Color.Yellow;

        }
        public void A1Kayit()
        {
            label2.Enabled = false;
            label2.BackColor = Color.Red;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { label2.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
        }
        public void A1iptal()
        {
            label2.Enabled = true;
            label2.BackColor = Color.White;
        }
        private void label3_Click(object sender, EventArgs e)
        {

            a3 = 1;
            label3.BackColor = Color.Yellow;

        }

        public void A3Kayit()

        {
            label3.BackColor = Color.Red;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { label3.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
            label3.Enabled = false;
        }
        public void A3iptal()
        {
            label3.Enabled = true;
            label3.BackColor = Color.White;
        }


        private void label4_Click(object sender, EventArgs e)
        {


            a4 = 1;
            label4.BackColor = Color.Yellow;




        }


        public void A4Kayit()

        {
            label4.BackColor = Color.Red;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { label4.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
            label4.Enabled = false;
        }
        public void A4iptal()
        {
            label4.Enabled = true;
            label4.BackColor = Color.White;
        }


        private void label5_Click(object sender, EventArgs e)
        {

            a5 = 1;
            label5.BackColor = Color.Yellow;



        }


        public void A5Kayit()

        {
            label5.BackColor = Color.Red;

            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { label5.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);

            label5.Enabled = false;
        }
        public void A5iptal()
        {
            label5.Enabled = true;
            label5.BackColor = Color.White;
        }


        private void label6_Click(object sender, EventArgs e)
        {
            a6 = 1;
            label6.BackColor = Color.Yellow;
            label6.Enabled = false;
        }


        public void A6Kayit()
        {
            label6.BackColor = Color.Red;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { label6.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
        }
        public void A6iptal()
        {
            label6.Enabled = true;
            label6.BackColor = Color.White;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //b1-b2
            b1 = 2;
            label7.BackColor = Color.Yellow;
            label7.Enabled = false;
        }


        public void B1Kayit()
        {
            label7.BackColor = Color.Red;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { label7.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
        }
        public void B1iptal()
        {
            label7.Enabled = true;
            label7.BackColor = Color.White;
        }

        private void lblb3_Click(object sender, EventArgs e)
        {
            b3 = 1;
            lblb3.BackColor = Color.Yellow;
            lblb3.Enabled = false;
        }


        public void B3Kayit()
        {
            lblb3.BackColor = Color.Red;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { lblb3.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
        }
        public void B3iptal()
        {
            lblb3.Enabled = true;
            lblb3.BackColor = Color.White;
        }

        private void lblb4_Click(object sender, EventArgs e)
        {
            b4 = 1;
            lblb4.BackColor = Color.Yellow;
            lblb4.Enabled = false;
        }


        public void B4Kayit()
        {
            lblb4.BackColor = Color.Red;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { lblb4.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
        }
        public void B4iptal()
        {
            lblb4.Enabled = true;
            lblb4.BackColor = Color.White;
        }

        private void lblb5_Click(object sender, EventArgs e)
        {
            b5 = 1;
            lblb5.BackColor = Color.Yellow;
            lblb5.Enabled = false;
        }


        public void B5Kayit()
        {
            lblb5.BackColor = Color.Red;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { lblb5.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
            lblb5.Enabled = false;
        }
        public void B5iptal()
        {
            lblb5.Enabled = true;
            lblb5.BackColor = Color.White;
        }

        private void lblb6_Click(object sender, EventArgs e)
        {
            b6 = 1;
            lblb6.BackColor = Color.Yellow;
            lblb6.Enabled = false;
        }


        public void B6Kayit()
        {
            lblb6.BackColor = Color.Red;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { lblb6.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
        }
        public void B6iptal()
        {
            lblb6.Enabled = true;
            lblb6.BackColor = Color.White;
        }

        private void lblc12_Click(object sender, EventArgs e)
        {
            c1 = 2;
            lblc12.BackColor = Color.Yellow;
            lblc12.Enabled = false;
        }


        public void C1C2Kayit()
        {
            lblc12.BackColor = Color.Red;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { lblc12.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
        }
        public void C1C2iptal()
        {
            lblc12.Enabled = true;
            lblc12.BackColor = Color.White;
        }

        private void lblc3_Click(object sender, EventArgs e)
        {
            c3 = 1;
            lblc3.BackColor = Color.Yellow;
            lblc3.Enabled = false;
        }


        public void C3Kayit()
        {
            lblc3.BackColor = Color.Red;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { lblc3.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
        }
        public void C3iptal()
        {
            lblc3.Enabled = true;
            lblc3.BackColor = Color.White;
        }

        private void lblc4_Click(object sender, EventArgs e)
        {
            c4 = 1;
            lblc4.BackColor = Color.Yellow;
            lblc4.Enabled = false;
        }


        public void C4Kayit()
        {
            lblc4.BackColor = Color.Red;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { lblc4.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
        }
        public void C4iptal()
        {
            lblc4.Enabled = true;
            lblc4.BackColor = Color.White;
        }

        private void lblc5_Click(object sender, EventArgs e)
        {
            c5 = 1;
            lblc5.BackColor = Color.Yellow;
            lblc5.Enabled = false;
        }


        public void C5Kayit()
        {
            lblc5.BackColor = Color.Red;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { lblc5.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
        }
        public void C5iptal()
        {
            lblc5.Enabled = true;
            lblc5.BackColor = Color.White;
        }

        private void lblc6_Click(object sender, EventArgs e)
        {
            c6 = 1;
            lblc6.BackColor = Color.Yellow;
            lblc6.Enabled = false;
        }


        public void C6Kayit()
        {
            lblc6.BackColor = Color.Red;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] kayit = { lblc6.Text.ToString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", kayit);
        }
        public void C6iptal()
        {
            lblc6.Enabled = true;
            lblc6.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int toplam;
            toplam = a1 + a3 + a4 + a5 + a6 + b1 + b3 + b4 + b5 + b6 + c1 + c3 + c4 + c5 + c6;
            HesapAlma hesap = new HesapAlma(this, toplam, a1, a3, a4, a5, a6, b1, b3, b4, b5, b6, c1, c3, c4, c5, c6);
            hesap.ShowDialog();
            toplam = 0;
            a1 = 0; a3 = 0; a4 = 0; a5 = 0; a6 = 0; b1 = 0; b3 = 0; b4 = 0; b5 = 0; b6 = 0; c1 = 0; c3 = 0; c4 = 0; c5 = 0; c6 = 0;
        }
    }
}
