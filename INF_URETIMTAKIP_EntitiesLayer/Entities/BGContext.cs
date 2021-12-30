using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF_URETIMTAKIP_EntitiesLayer.Entities
{
    public class BGContext : DbContext
    {
        public DbSet<MEKANIK_CIZIMLER_MKA> MEKANIK_CIZIMLER_MKA { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MEKANIK_CIZIMLER_MKA>().ToTable("MEKANIK_CIZIMLER_MKA");
        }
    }
}
