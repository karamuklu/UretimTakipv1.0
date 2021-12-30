using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF_URETIMTAKIP_EntitiesLayer
{
    public class MEKANIK_CIZIMLER_MKA
    {
        [Key]
        public string ISEMRINO { get; set; }
        public string STOK_KODU { get; set; }
        public string STOK_ADI { get; set; }
        public decimal MIKTAR { get; set; }
        public string INF_KODU { get; set; }
    }
}
