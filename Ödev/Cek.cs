using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    class Cek:Odeme
    {
        public string AdSoyad { get; set; }
        public long BankaId { get; set; }
      
        public override string Kontrol()
        {
            if (Convert.ToString(BankaId).Length != 10) // Çek numarasının 10 hane olup olmadığını kontrol ettik.
            {
                return "Islem basarısız ..!";

            }         
            else
            {
                return "Islem başarılı ..!";
            }

        }


    }
}
