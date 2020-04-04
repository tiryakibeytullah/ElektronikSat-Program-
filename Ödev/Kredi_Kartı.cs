using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    public class Kredi_Kartı:Odeme
    {
        public long KrediKartiNo { get; set; }
        public string KartTipi { get; set; }     

        public override string Kontrol()
        {
            
            if (Convert.ToString(KrediKartiNo).Length != 10)
            {
                return "Islem başarısız ..!";
            }
            else if (Convert.ToString(KrediKartiNo).Length == 10)
            {
                return "Odeme islemi başarılı ..!";
            }
            else
            {
                return "HATA";
            }

        }
        
    }
}
