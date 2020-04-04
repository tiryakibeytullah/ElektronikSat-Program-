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
    public partial class ÜrünSilmeveGüncelleme : UserControl
    {

        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;

        public ÜrünSilmeveGüncelleme()
        {
            InitializeComponent();
        }
        UrunIslemleri yeniurunislemleri = new UrunIslemleri();
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

       

        private void ÜrünSilmeveGüncelleme_Load(object sender, EventArgs e)
        {
            griddoldur();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox5.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urun yeniurun1 = new Urun();
            yeniurun1.numara = Convert.ToInt32(textBox5.Text);
            yeniurun1.Ürün = textBox1.Text;
            yeniurun1.Marka = textBox2.Text;
            yeniurun1.Birimfiyat = Convert.ToInt32(textBox3.Text);
            yeniurun1.Kilogram = Convert.ToInt32(textBox4.Text);
            yeniurunislemleri.UrunGuncelle(yeniurun1);
            MessageBox.Show("Ürün güncelleme işleminiz gerçekleşmiştir ..!");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            griddoldur();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urun yeniurun2 = new Urun();
            yeniurun2.numara = Convert.ToInt32(textBox6.Text);
            yeniurunislemleri.UrunSilme(yeniurun2);
            MessageBox.Show("Ürün silme işleminiz gerçekleşmiştir ..!");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            griddoldur();
        }
    }
}
