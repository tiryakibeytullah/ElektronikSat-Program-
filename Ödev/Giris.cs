using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Ödev
{
    public partial class Giris : Form
    {

        public static string text;
        public static string durum;

        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;
        OleDbDataReader dr;

        public Giris()
        {
            InitializeComponent();
        }
        
        Kullanıcı_Bilgileri kullanıcı1 = new Kullanıcı_Bilgileri();    
        public static string gecicimail;
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcı1.Eposta = textBox1.Text;
            kullanıcı1.Sifre = textBox2.Text;
            Giris.durum = comboBox1.Text;

            string eposta = "0", sifre = "0",durum="0";
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Deneme11.accdb");
            baglanti.Open();
            komut = new OleDbCommand("SELECT * FROM kullanicibilgileri where gmail='" + kullanıcı1.Eposta + "' AND sifre='" + kullanıcı1.Sifre + "'", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                eposta = dr["gmail"].ToString();
                sifre = dr["sifre"].ToString();
                durum = dr["durum"].ToString();
            }
            if (textBox1.Text == eposta && textBox2.Text == sifre && comboBox1.Text==durum)
            {
                gecicimail = textBox1.Text;
                Giris formkapa = new Giris();
                formkapa.Close();
                AnaMenü f3 = new AnaMenü();
                f3.Show();
                this.Hide();
            }
            else if (textBox1.Text != eposta || textBox2.Text != sifre || comboBox1.Text != durum)
            {
                MessageBox.Show("E-Posta bilginiz ya da şifrenizi yanlış girdiniz !");
                textBox1.Clear();
                textBox2.Clear();
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayıtOlma f2 = new KayıtOlma();
            f2.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
