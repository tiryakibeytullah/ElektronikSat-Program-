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
    public partial class NakitOdeme : UserControl
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;
        OleDbDataReader dr;
        public NakitOdeme()
        {
            InitializeComponent();
        }
        Nakit nakitsiparis = new Nakit();
        public void BaglantiYolu()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=Deneme11.accdb");
            komut = new OleDbCommand();
        }
        string odeme_durumu = "";
        public void toplampara()
        {
            int toplamtutar = 0;
            BaglantiYolu();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM siparis where gmail='" + Giris.gecicimail + "'";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                odeme_durumu = dr["odeme_durumu"].ToString();
                if (odeme_durumu == "Bekleniyor")
                {
                    toplamtutar += Convert.ToInt32(dr["fiyat"]);
                }

            }

            nakitsiparis.Miktar = toplamtutar;
            baglanti.Close();
        }
        private void UserControl3_Load(object sender, EventArgs e)
        {
            toplampara();    
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;

            BaglantiYolu();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM kullanicibilgileri where gmail='" + Giris.gecicimail+"'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["ad"].ToString();
                textBox2.Text = dr["soyad"].ToString();
                textBox3.Text = dr["gmail"].ToString();  
            }

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nakitsiparis.odenenmiktar = Convert.ToDouble(textBox5.Text);     
            nakitsiparis.Adres = textBox4.Text;
            toplampara();
            Sipariss newtarih = new Sipariss();
                   
            if(nakitsiparis.Adres!= "")
            {               
                BaglantiYolu();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into nakit_odeme(gmail,adres,miktar) values ('"+ textBox3.Text + "','" + nakitsiparis.Adres + "','" + nakitsiparis.Miktar+ "')";
                komut.ExecuteNonQuery();
                komut.Dispose();            
                textBox4.Clear();               
                MessageBox.Show(nakitsiparis.Kontrol());
                this.Hide();
                baglanti.Close();

                string urun = "", marka = "", renk = "", gmail = "", odeme_durumu = "";
                int id = 0, adet = 0, kilogram = 0, fiyat = 0;
                BaglantiYolu();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM siparis where gmail='" + Giris.gecicimail + "'";
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["id"]);
                    urun = dr["urun"].ToString();
                    marka = dr["marka"].ToString();
                    adet = Convert.ToInt32(dr["adet"]);
                    kilogram = Convert.ToInt32(dr["kilogram"]);
                    renk = dr["renk"].ToString();
                    fiyat = Convert.ToInt32(dr["fiyat"]);
                    gmail = dr["gmail"].ToString();
                    odeme_durumu = dr["odeme_durumu"].ToString();
                    newtarih.Tarih = dr["tarih"].ToString();

                    if(odeme_durumu=="Bekleniyor" && (nakitsiparis.odenenmiktar> nakitsiparis.Miktar))
                    {
                        komut = new OleDbCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "Update siparis set urun='" + urun + "',marka='" + marka + "',adet='" + adet + "',kilogram='" + kilogram + "',renk='" + renk + "',fiyat='" + fiyat + "',gmail='" + Giris.gecicimail + "',odeme_durumu='" + "Nakit Ödendi" + "',tarih='" + newtarih.Tarih + "'where id=" + id + "";
                        komut.ExecuteNonQuery();
                    }                 
                }
            }
            
            else
            {
                MessageBox.Show("Boş alan bırakmayınız ..!");
            }          
            baglanti.Close();

            
        }
    }
}
