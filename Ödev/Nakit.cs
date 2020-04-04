using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    public class Nakit : Odeme
    {
        public string Adres { get; set; }
        public double odenenmiktar { get; set; }
        public override string Kontrol()
        {
            if (odenenmiktar > Miktar)
            {
               
                return "İslem basarili ..! Para üstünüz: "+(odenenmiktar - Miktar);

            }
            else if (odenenmiktar == Miktar)
            {
                return "İslem basarili ..!";
            }
            else
            {
                return "Odeme isleminde hata oluştur ..!";
            }
        }   
    }
}
