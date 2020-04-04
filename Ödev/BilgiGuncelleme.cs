using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ödev
{
    public partial class BilgiGuncelleme : UserControl
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;
        OleDbDataReader dr;

        public BilgiGuncelleme()
        {
            InitializeComponent();
        }

        private void UserControl6_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox7.Enabled = false;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=Deneme11.accdb");
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM kullanicibilgileri where gmail='" + Giris.gecicimail + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["id"].ToString();
                textBox2.Text = dr["ad"].ToString();
                textBox3.Text = dr["soyad"].ToString();
                textBox4.Text = dr["telefon"].ToString();
                textBox5.Text = dr["gmail"].ToString();
                textBox6.Text = dr["sifre"].ToString();
                textBox7.Text = dr["durum"].ToString();
            }

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" || textBox2.Text!="" || textBox3.Text!="" || textBox4.Text!="" || textBox5.Text!="" || textBox6.Text != "")
            {
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Update kullanicibilgileri set ad='" + textBox2.Text + "',soyad='" + textBox3.Text + "',telefon='" + textBox4.Text + "',gmail='" + textBox5.Text + "',sifre='" + textBox6.Text + "',durum='" + textBox7.Text + "'where id=" + textBox1.Text + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme işleminiz gerçekleşmiştir ..!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız ..!");
            }
            
        }
    }
}
