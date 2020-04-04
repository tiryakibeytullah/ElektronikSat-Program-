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
    public partial class OdemeMenu : Form
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;
        OleDbDataReader dr;

        public OdemeMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int toplamtutar = 0;
            string odeme_durumu = "";
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=Deneme11.accdb");
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM siparis where gmail='" + Giris.gecicimail +"'";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                odeme_durumu = dr["odeme_durumu"].ToString();
                if (odeme_durumu=="Bekleniyor")
                {
                    toplamtutar += Convert.ToInt32(dr["fiyat"]);
                }
                
            }
            label4.Text = toplamtutar.ToString();
            baglanti.Close();
            if(toplamtutar==0)
            {
                comboBox1.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {      
            if (comboBox1.Text=="Nakit")
            {
                panel1.Controls.Clear();
                NakitOdeme sayfa3 = new NakitOdeme();
                panel1.Controls.Add(sayfa3);             
            }
            else if (comboBox1.Text == "Kredi Kartı")
            {
                panel1.Controls.Clear();
                KrediKartıOdeme sayfa4 = new KrediKartıOdeme();
                panel1.Controls.Add(sayfa4);
            }
            else if (comboBox1.Text == "Senet/Çek")
            {
                panel1.Controls.Clear();
                SenetOdeme sayfa5 = new SenetOdeme();
                panel1.Controls.Add(sayfa5);
            }
        }
    }
}
