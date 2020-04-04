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
    public partial class SenetOdeme : UserControl
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;
        OleDbDataReader dr;

        public SenetOdeme()
        {
            InitializeComponent();
        }
        public void BaglantiYolu()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=Deneme11.accdb");
            komut = new OleDbCommand();
        }
        public void FiyatGoster()
        {
            int toplamtutar = 0;
            string odeme_durumu = "";
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
            textBox6.Text = toplamtutar.ToString();
            baglanti.Close();
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            FiyatGoster();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox6.Enabled = false;

            BaglantiYolu();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM kullanicibilgileri where gmail='" + Giris.gecicimail + "'";
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

            Sipariss newtarih = new Sipariss();
            Cek ceksiparis = new Cek();
            ceksiparis.AdSoyad = textBox4.Text;
            ceksiparis.BankaId = Convert.ToInt32(textBox5.Text);
            ceksiparis.Miktar = Convert.ToInt32(textBox6.Text);
            int uzunluk = textBox5.TextLength;
            if ((ceksiparis.AdSoyad != "") && (ceksiparis.BankaId != 0))
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into cek_odeme(gmail,ad_soyad,banka_ıd,miktar) values ('" + textBox3.Text +"','"+ ceksiparis.AdSoyad + "','" + ceksiparis.BankaId + "','" + ceksiparis.Miktar + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show(ceksiparis.Kontrol());
                textBox4.Clear();
                textBox5.Clear();

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
                    if (odeme_durumu == "Bekleniyor" && (uzunluk==10))
                    {
                        komut = new OleDbCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "Update siparis set urun='" + urun + "',marka='" + marka + "',adet='" + adet + "',kilogram='" + kilogram + "',renk='" + renk + "',fiyat='" + fiyat + "',gmail='" + Giris.gecicimail + "',odeme_durumu='" + "Senet Ödendi"+ "',tarih='" + newtarih.Tarih + "'where id=" + id + "";
                        komut.ExecuteNonQuery();
                    }
                }

            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız ..!");
            }
        }
    }
}
