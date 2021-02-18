using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF_URETIMTAKIP_EntitiesLayer
{
    public class BARKOD
    {
        [Key]
        public string ISEMRINO { get; set; }
        public string BARKOD_2 { get; set; }
    }
}
