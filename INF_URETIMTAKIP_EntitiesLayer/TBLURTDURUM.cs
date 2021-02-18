using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF_URETIMTAKIP_EntitiesLayer
{
    public class TBLURTDURUM
    {
        [Key]
        public string ISEMRINO { get; set; }
        public string STOK_KODU { get; set; }
        public int SIRA { get; set; }
        public string HAT_NO { get; set; }
        public int MIKTAR { get; set; }
        public string URETIM_ASAMA { get; set; }
        public DateTime BASLAMA_TARIH { get; set; }
        public TimeSpan BASLAMA_SAAT{ get; set; }
        public DateTime BITIS_TARIH { get; set; }
        public TimeSpan BITIS_SAAT { get; set; }
        public string CALISAN { get; set; }
        public decimal GERCEKLESENSURE { get; set; }
        public string ACIKLAMA { get; set; }
        public string SERI_NO { get; set; }
        public string SUSK_DURUMU { get; set; }

    }
}
