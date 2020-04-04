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
    public partial class KayıtOlma : Form
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;

        public KayıtOlma()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (textBox5.Text != ""))
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=Deneme11.accdb");
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into kullanicibilgileri(ad,soyad,telefon,gmail,sifre,durum) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+"Kullanıcı"+ "')";
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kaydınız Başarıyla Tamamlandı !");
                
                Giris fr1 = new Giris();
                fr1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı işlem yaptınız, Boş alan bırakmayınız");
            }
        }
    }
}
