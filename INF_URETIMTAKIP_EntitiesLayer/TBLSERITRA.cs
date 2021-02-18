using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF_URETIMTAKIP_EntitiesLayer
{
    public class TBLSERITRA
    {
        [Key]
        public string STOK_KODU { get; set; }

        public string SERI_NO { get; set; }
        public int ADET { get; set; }
    }
}
