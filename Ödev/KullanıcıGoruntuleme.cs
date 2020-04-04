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
    public partial class KullanıcıGoruntuleme : UserControl
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;

        public KullanıcıGoruntuleme()
        {
            InitializeComponent();
        }
        public void griddoldur1()
        {

            textBox1.Visible = false;
            textBox1.Text = "Kullanıcı";

            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=Deneme11.accdb");
            da = new OleDbDataAdapter("Select * from kullanicibilgileri where durum='" + textBox1.Text + "'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kullanicibilgileri");
            dataGridView1.DataSource = ds.Tables["kullanicibilgileri"];
            baglanti.Close();
        }
        private void UserControl7_Load(object sender, EventArgs e)
        {
            griddoldur1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sor;
            sor = MessageBox.Show("Kullanıcıyı silmek istiyor musunuz ?", "Soru", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "delete from kullanicibilgileri where id=" + textBox2.Text + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
                griddoldur1();
                MessageBox.Show("Kullanıcı silme işlemi başarılı ..!");
            }
            
        }
    }
}
