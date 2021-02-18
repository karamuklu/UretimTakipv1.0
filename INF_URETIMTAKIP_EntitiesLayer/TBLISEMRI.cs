using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF_URETIMTAKIP_EntitiesLayer
{
    public class TBLISEMRI
    {
        [Key]
        public string ISEMRINO { get; set; }
        public string STOK_KODU { get; set; }
        public double MIKTAR { get; set; }
    }
}
