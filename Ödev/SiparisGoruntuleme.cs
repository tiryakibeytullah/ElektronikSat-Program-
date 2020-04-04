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
    public partial class SiparisGoruntuleme : UserControl
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;

        public SiparisGoruntuleme()
        {
            InitializeComponent();
        }
        public void griddoldur3()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=Deneme11.accdb");
            da = new OleDbDataAdapter("Select * from siparis",baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds,"siparis");
            dataGridView1.DataSource = ds.Tables["siparis"];
            baglanti.Close();
        }
        private void UserControl8_Load(object sender, EventArgs e)
        {
            griddoldur3();
        }
    }
}
