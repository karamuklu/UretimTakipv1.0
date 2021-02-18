using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF_URETIMTAKIP_EntitiesLayer
{
    public class URETIMDURUMOZET_MKA
    {
        [Key]
        public string ISEMRINO { get; set; }
        public string STOK_KODU { get; set; }
        public string STOK_ADI { get; set; }
        public string HAT_NO { get; set; }
        public double ISEMRIMIKTAR { get; set; }
        public int MONTAJ_BASLAMA { get; set; }
        public int MONTAJ_BITIS { get; set; }
        public int AKU { get; set; }
        public int TEST { get; set; }
        public int KAPAMA { get; set; }
        public int TAMAMLANAN { get; set; }
    }
}
