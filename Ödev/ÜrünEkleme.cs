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
    public partial class ÜrünEkleme : UserControl
    {

        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;

        UrunIslemleri islemler = new UrunIslemleri();

        public ÜrünEkleme()
        {
            InitializeComponent();
        }
        public void griddoldur()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=Deneme11.accdb");
            da = new OleDbDataAdapter("Select * from ürünler", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "ürünler");
            dataGridView1.DataSource = ds.Tables["ürünler"];
            baglanti.Close();
        }
        private void ÜrünEkleme_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urun yeniurun = new Urun();
            yeniurun.Ürün = comboBox1.Text;
            yeniurun.Marka = textBox1.Text;
            yeniurun.Birimfiyat = Convert.ToInt32(textBox2.Text);
            yeniurun.Kilogram = Convert.ToInt32(textBox3.Text);
            islemler.UrunEkle(yeniurun);
            MessageBox.Show("Ürün ekleme işleminiz tamamlanmıştır ..!");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            griddoldur();
        }
    }
}
