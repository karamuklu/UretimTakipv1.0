using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF_URETIMTAKIP_EntitiesLayer
{
    public class TBLSTSABIT
    { 
        [Key]
        public string STOK_KODU { get; set; }
        public string STOK_ADI { get; set; }
        public string GRUP_KODU { get; set; }
    }
}
