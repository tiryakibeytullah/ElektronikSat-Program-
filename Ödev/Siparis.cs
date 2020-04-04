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
    public partial class Siparis : UserControl
    {
        public Siparis()
        {
            InitializeComponent();
        }
        
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;
        OleDbDataReader dr;
 
        private void UserControl1_Load(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=Deneme11.accdb");
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from ürün ORDER BY id ASC ", baglanti);
            da.Fill(dt);
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "ürünler";
            comboBox1.DataSource = dt;
            textBox3.Enabled = false;
            textBox2.Enabled = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from marka where ürünler = " + comboBox1.SelectedValue, baglanti);
                da.Fill(dt);
                comboBox2.ValueMember = "id";
                comboBox2.DisplayMember = "marka";
                comboBox2.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text!="")&&(textBox2.Text!="")&&(textBox3.Text!=""))
            {
               
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                int toplamfiyat = 0;
                toplamfiyat = Convert.ToInt32(textBox1.Text)*Convert.ToInt32(textBox3.Text);
                komut.CommandText = "insert into siparis(urun,marka,adet,kilogram,renk,fiyat,gmail,odeme_durumu,tarih) values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox3.Text + "','" + toplamfiyat + "','"+ Giris.gecicimail + "','"+ "Bekleniyor"+ "','" + AnaMenü.tarih + "')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sepete ekleme işlemi tamamlandı ..!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Ürün ekleme yaparken hata oluştu.Boş alan bırakmayınız ..!");
            }
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=Deneme11.accdb");
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM ürünler where ürün='" + comboBox1.Text + "' AND marka='" + comboBox2.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["kilogram"].ToString();
                textBox3.Text = dr["fiyat"].ToString();
            }

            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            
        }
    }
}
