using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    class Urun
    {
        public int numara { get; set; }

        string marka;
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        string ürün;
        public string Ürün
        {
            get { return ürün; }
            set { ürün = value; }
        }
        int kilogram;
        public int Kilogram
        {
            get { return kilogram; }
            set { kilogram = value; }
        }
        int birimfiyat;
        public int Birimfiyat
        {
            get { return birimfiyat; }
            set { birimfiyat = value; }
        }
    }
}
