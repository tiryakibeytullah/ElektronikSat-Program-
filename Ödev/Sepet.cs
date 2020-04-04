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
    public partial class Sepet : UserControl
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;
        OleDbDataReader dr;
        public Sepet()
        {
            InitializeComponent();
        }
        public void griddoldur()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=Deneme11.accdb");
            da = new OleDbDataAdapter("Select * from siparis where gmail = '" + Giris.gecicimail + "'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "siparis");
            dataGridView1.DataSource = ds.Tables["siparis"];
            baglanti.Close();
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {
            griddoldur();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from siparis where id=" + textBox1.Text + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            griddoldur();
            textBox1.Clear();
            MessageBox.Show("Ürünününüz başarılı bir şekilde silinmiştir ..!");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdemeMenu fr4 = new OdemeMenu();
            fr4.Show();                    
        }
    }
}
