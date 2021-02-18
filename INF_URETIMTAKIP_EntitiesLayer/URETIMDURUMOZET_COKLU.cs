using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF_URETIMTAKIP_EntitiesLayer
{
    public class URETIMDURUMOZET_COKLU
    {
        [Key]
        public string ISEMRINO { get; set; }
        public string STOK_KODU { get; set; }
        public string STOK_ADI { get; set; }
        public string URETIM_ASAMA { get; set; }
        public int ISEMRIMIKTAR { get; set; }
        public int OKUTULAN { get; set; }
        public int BAKIYE { get; set; }
        public int ISLEMSURESI { get; set; }
        public decimal GERCEKLESENSURE { get; set; }
        public int SUSKMIKTAR { get; set; }
    }
}
