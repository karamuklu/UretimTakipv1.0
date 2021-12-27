using INF_OTO_SUSK_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF_URETIMTAKIP_EntitiesLayer
{
    public class INF_SUSK_Context:DbContext
    {
        public DbSet<TBLDEPHAR> TBLDEPHAR { get; set; }
        public DbSet<TBLSTHAR> TBLSTHAR { get; set; }
        public DbSet<TBLSERITRA> TBLSERITRA { get; set; }
        public DbSet<TBLISEMRI> TBLISEMRI { get; set; }
        public DbSet<TBLSTSABIT> TBLSTSABIT { get; set; }
        
        public DbSet<DEPOLOKASYONDURUM_MKA> DEPOLOKASYONDURUM_MKA { get; set; }
        //Tabloların sonuna s eklememesi için OnModelCreating metodunu ezdik
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBLDEPHAR>().ToTable("TBLDEPHAR");
            modelBuilder.Entity<TBLSTHAR>().ToTable("TBLSTHAR");
            modelBuilder.Entity<TBLSERITRA>().ToTable("TBLSERITRA");
            modelBuilder.Entity<TBLISEMRI>().ToTable("TBLISEMRI");
            modelBuilder.Entity<TBLSTSABIT>().ToTable("TBLSTSABIT");
            modelBuilder.Entity<DEPOLOKASYONDURUM_MKA>().ToTable("DEPOLOKASYONDURUM_MKA");
        }
    }
}
