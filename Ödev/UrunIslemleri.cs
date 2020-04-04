using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace Ödev
{
    class UrunIslemleri
    {
        OleDbConnection baglanti;
        OleDbCommand komut;      
        public void BaglantiYolu()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=Deneme11.accdb");
            komut = new OleDbCommand();
        }
        public void UrunEkle(Urun c)
        {
            BaglantiYolu();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "insert into ürünler(marka,ürün,fiyat,kilogram) values ('" + c.Marka + "','" + c.Ürün + "','" + c.Birimfiyat + "','" + c.Kilogram +"')";
            komut.ExecuteNonQuery();
            baglanti.Close();        
        }
        public void UrunGuncelle(Urun a)
        {
            BaglantiYolu();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Update ürünler set fiyat='" + a.Birimfiyat + "',kilogram='" + a.Kilogram + "'where id=" + a.numara + "";
            komut.ExecuteNonQuery();
            baglanti.Close();                     
        }
        public void UrunSilme(Urun b)
        {
            BaglantiYolu();
            baglanti.Open();
            komut.Connection = baglanti;           
            komut.CommandText = "delete from ürünler where id=" + b.numara + "";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
        }
    }
}
