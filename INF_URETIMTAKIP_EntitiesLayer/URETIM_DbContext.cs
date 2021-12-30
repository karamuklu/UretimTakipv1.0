using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF_URETIMTAKIP_EntitiesLayer
{
    public class URETIM_DbContext:DbContext
    {
        public DbSet<TBLURTDURUM> TBLURTDURUM { get; set; }
        public DbSet<TBLURT_ASAMA> TBLURT_ASAMA { get; set; }
        public DbSet<URETIMDURUMOZET_MKA> URETIMDURUMOZET_MKA { get; set; }
        public DbSet<URETIMDURUMOZET_COKLU> URETIMDURUMOZET_COKLU { get; set; }
        public DbSet<TBLHATBILGI> TBLHATBILGI { get; set; }
        public DbSet<TBLCALISAN> TBLCALISAN { get; set; }
        public DbSet<BARKOD> BARKOD { get; set; }
        public DbSet<TBLCIHAZTEST> TBLCIHAZTEST { get; set; }
        public DbSet<URETIMASAMAACIKLAMA> URETIMASAMAACIKLAMA { get; set; }
        

        //Tabloların sonuna s eklememesi için OnModelCreating metodunu ezdik
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBLURTDURUM>().ToTable("TBLURTDURUM");
            modelBuilder.Entity<TBLURT_ASAMA>().ToTable("TBLURT_ASAMA");
            modelBuilder.Entity<TBLHATBILGI>().ToTable("TBLHATBILGI");
            modelBuilder.Entity<URETIMDURUMOZET_MKA>().ToTable("URETIMDURUMOZET_MKA");
            modelBuilder.Entity<URETIMDURUMOZET_COKLU>().ToTable("URETIMDURUMOZET_COKLU");
            modelBuilder.Entity<TBLCALISAN>().ToTable("TBLCALISAN");
            modelBuilder.Entity<BARKOD>().ToTable("BARKOD");
            modelBuilder.Entity<TBLCIHAZTEST>().ToTable("TBLCIHAZTEST");
            modelBuilder.Entity<URETIMASAMAACIKLAMA>().ToTable("URETIMASAMAACIKLAMA");
            


        }

    }
}
