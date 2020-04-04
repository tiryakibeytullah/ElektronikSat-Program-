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
    public partial class KrediKartıOdeme : UserControl
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;
        OleDbDataReader dr;

        public KrediKartıOdeme()
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
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=Deneme11.accdb");
            komut = new OleDbCommand();
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
            textBox5.Text = toplamtutar.ToString();
            baglanti.Close();           
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            FiyatGoster();
          

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox5.Enabled = false;

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
            Kredi_Kartı kartlisiparis = new Kredi_Kartı();
            Sipariss newtarih = new Sipariss();
            
            kartlisiparis.KrediKartiNo = Convert.ToInt64(textBox4.Text);
            kartlisiparis.KartTipi = comboBox1.Text;
            kartlisiparis.Miktar = Convert.ToInt32(textBox5.Text);
            int uzunluk = textBox4.Text.Length;
            if (kartlisiparis.KrediKartiNo != 0)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into kredikartı_odeme(gmail,kredikartı_no,kredikartı_turu,miktar) values ('" + textBox3.Text + "','" + kartlisiparis.KrediKartiNo + "','" + kartlisiparis.KartTipi + "','" + kartlisiparis.Miktar + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                kartlisiparis.Kontrol();
                MessageBox.Show(kartlisiparis.Kontrol());
                textBox4.Clear();

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
                    
                    if((odeme_durumu=="Bekleniyor") && (uzunluk==10))
                    {
                        komut = new OleDbCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "Update siparis set urun='" + urun + "',marka='" + marka + "',adet='" + adet + "',kilogram='" + kilogram + "',renk='" + renk + "',fiyat='" + fiyat + "',gmail='" + Giris.gecicimail + "',odeme_durumu='" + "Kredi Karti Ödendi" + "',tarih='" + newtarih.Tarih + "'where id=" + id + "";
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
