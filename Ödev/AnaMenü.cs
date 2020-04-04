using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev
{
    public partial class AnaMenü : Form
    {
        public AnaMenü()
        {
            InitializeComponent();
        }
        public string girisdurumu;
        public static string tarih = "";
        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (Giris.durum=="Kullanıcı")
            {
                button6.Visible = false;
                button2.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
            }
            else if(Giris.durum=="Yönetici")
            {
                button1.Visible = false;
                button3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Siparis sayfa1 = new Siparis();
            panel1.Controls.Add(sayfa1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Sepet sayfa2 = new Sepet();
            panel1.Controls.Add(sayfa2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult sor;
            sor = MessageBox.Show("Çıkış Yapmak İstiyor Musunuz ?", "Çık", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                Giris ac = new Giris();
                ac.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            BilgiGuncelleme sayfa6 = new BilgiGuncelleme();
            panel1.Controls.Add(sayfa6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            KullanıcıGoruntuleme sayfa7 = new KullanıcıGoruntuleme();
            panel1.Controls.Add(sayfa7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SiparisGoruntuleme sayfa8 = new SiparisGoruntuleme();
            panel1.Controls.Add(sayfa8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ÜrünEkleme sayfa9 = new ÜrünEkleme();
            panel1.Controls.Add(sayfa9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ÜrünSilmeveGüncelleme sayfa10 = new ÜrünSilmeveGüncelleme();
            panel1.Controls.Add(sayfa10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tarih= DateTime.Now.ToShortDateString();
            label1.Text= DateTime.Now.ToShortDateString();
            label2.Text= DateTime.Now.ToLongTimeString();
        }
    }
}
