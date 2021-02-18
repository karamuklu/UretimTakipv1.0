using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF_URETIMTAKIP_EntitiesLayer
{
    public class TBLCIHAZTEST
    {
        [Key]
        public string ISEMRINO { get; set; }
        public string STOK_KODU { get; set; }
        public string MUSTERI_TIPI { get; set; }
        public string VOLTAJ_BILGISI { get; set; }
        public string CALISAN { get; set; }
        public string SERINO { get; set; }
        public DateTime TEST_TARIHI { get; set; }
        public double KAYIPZAMAN { get; set; }
    }
}
