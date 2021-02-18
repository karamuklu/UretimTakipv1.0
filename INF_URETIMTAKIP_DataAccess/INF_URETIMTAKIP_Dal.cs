
using INF_OTO_SUSK_Entities;
using INF_URETIMTAKIP_EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace INF_URETIMTAKIP_DataAccess
{
    public class INF_URETIMTAKIP_Dal
    {
        public List<TBLURTDURUM> URTDURUM_LIST()
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                return context.TBLURTDURUM.ToList();
            }
        }
        public URETIMDURUMOZET_MKA URUN_URTDURUM(string isemrino, int sira, string uretim_asama)
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                return context.URETIMDURUMOZET_MKA.Where(i => i.ISEMRINO == isemrino).FirstOrDefault();
            }
        }

        public List<TBLURT_ASAMA> URT_ASAMALIST()
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                return context.TBLURT_ASAMA.ToList();
            }
        }
        public List<TBLHATBILGI> URTHATBILGISI()
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                return context.TBLHATBILGI.ToList();
            }
        }
        public List<TBLCALISAN> TBLCALISAN(string istasyon)
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                return context.TBLCALISAN.Where(i => i.ISTASYON == istasyon).ToList();
            }
        }

        public List<URETIMDURUMOZET_MKA> URETIMDURUMOZET_MKA()
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                string sqlCumle = "SELECT * FROM URETIMDURUMOZET_MKA";
                return context.Database.SqlQuery<URETIMDURUMOZET_MKA>(sqlCumle).ToList();
            }
        }
        public List<URETIMDURUMOZET_COKLU> URETIMDURUMOZET_COKLU()
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                string sqlCumle = "SELECT * FROM URETIMDURUMOZET_COKLU";
                return context.Database.SqlQuery<URETIMDURUMOZET_COKLU>(sqlCumle).ToList();

            }
        }
        public int URUNSIRANO(string isemrino, string uretim_asama)
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                var urun = from p in context.TBLURTDURUM
                           where p.ISEMRINO == isemrino && p.URETIM_ASAMA == uretim_asama
                           group p by p.ISEMRINO into g
                           select new URUNSIRA
                           {
                               ISEMRINO = g.Key,
                               ADET = g.Count()
                           };

                if (urun.Count() == 0)
                    return 0;
                else return urun.FirstOrDefault().ADET;
            }
        }
        public int URUNOKUTULANMIKTAR(string isemrino, string uretim_asama)
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                var urun = from p in context.TBLURTDURUM
                           where p.ISEMRINO == isemrino && p.URETIM_ASAMA == uretim_asama
                           group p by p.ISEMRINO into g
                           select new URUNSIRA
                           {
                               ISEMRINO = g.Key,
                               MIKTAR = g.Sum(i => i.MIKTAR)
                           };

                if (urun.Count() == 0)
                    return 0;
                else return urun.FirstOrDefault().MIKTAR;

            }
        }
        public TBLISEMRI ISEMRIGETIR(string isemrino)
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                //var isemri= context.TBLISEMRI.Where(i => i.ISEMRINO == isemrino).FirstOrDefault();
                //if (isemri!=null)
                //    return isemri;

                return context.TBLISEMRI.Where(i => i.ISEMRINO == isemrino).FirstOrDefault();
            }
        }
        public BARKOD SERIDEN_ISEMRIBUL(string seriNo)
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                return context.BARKOD.Where(i => i.BARKOD_2 == seriNo).First();
            }
        }
        public int TESTCIHAZEKLE(TBLCIHAZTEST testcihaz)
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                context.TBLCIHAZTEST.Add(testcihaz);
                if (context.SaveChanges() == 1)
                    return 1;
                else
                    return 0;
            }
        }
        public int HUCREHAREKETKAYIT(string stok_kodu, decimal miktar, string fisno)
        {
            INF_SUSK_Context context = new INF_SUSK_Context();
            var depUrun = context.DEPOLOKASYONDURUM_MKA.Where(a => a.STOKKODU == stok_kodu && a.DEPO_KODU == 114 && a.NETBAKIYE > 0).FirstOrDefault();
            var urun = new TBLDEPHAR();
            urun.STOKKODU = depUrun.STOKKODU;
            urun.HUCREKODU = depUrun.HUCREKODU;
            urun.NETMIKTAR = miktar;
            urun.HTUR = "B";
            urun.GC = "C";
            urun.DEPOHARFISNO = fisno;
            urun.TARIH = DateTime.Now.Date;
            urun.KAYITTARIHI = DateTime.Now.Date;
            urun.KAYITYAPANKUL = "KARAMUKLU";
            urun.STHARINC = INCKEYBUL(fisno, depUrun.STOKKODU);
            context.TBLDEPHAR.Add(urun);

            if (context.SaveChanges() == 1)
            {
                //MessageBox.Show("İşlem başarılı");
                var depDurum = context.DEPOLOKASYONDURUM_MKA.Where(a => a.STOKKODU == stok_kodu && a.DEPO_KODU == 114 && a.NETBAKIYE > 0).ToList();
            }
            return 1;
        }
        public int INCKEYBUL(string fisno, string stok_kodu)
        {
            using (INF_SUSK_Context inf_context = new INF_SUSK_Context())
            {
                var inckey = inf_context.TBLSTHAR.Where(i => i.FISNO == fisno && i.STOK_KODU == stok_kodu && i.DEPO_KODU == 114).FirstOrDefault();
                return inckey.INCKEYNO;
            }
        }
        public int URUNEKLE(TBLURTDURUM urun)
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                context.TBLURTDURUM.Add(urun);
                context.SaveChanges();
                if (context.SaveChanges() == 0)
                    return 0;
                else
                    return 1;
            }
        }
        public List<TBLCIHAZTEST> TESTCIHAZLIST()
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                string sqlCumle = "SELECT t.STOK_KODU, t.ISEMRINO, t.MUSTERI_TIPI, t.VOLTAJ_BILGISI, t.CALISAN, t.SERINO, CASE WHEN t.TEST_TARIHI IS NULL THEN '2021-01-07' ELSE t.TEST_TARIHI END TEST_TARIHI, isnull(t.KAYIPZAMAN, 0)KAYIPZAMAN FROM MKA..TBLCIHAZTEST t ORDER BY TEST_TARIHI DESC";
                return context.Database.SqlQuery<TBLCIHAZTEST>(sqlCumle).ToList();
            }

        }
        public int SERINO_CIHAZKONTROL(string seriNo)
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                var seri = context.TBLCIHAZTEST.Where(i => i.SERINO == seriNo).FirstOrDefault();
                if (seri == null)
                    return 0;
                else
                    return 1;
            }
        }
        public int SERINO_URETIMKONTROL(string seriNo)
        {
            using (URETIM_DbContext context = new URETIM_DbContext())
            {
                string sqlCumle = "SELECT * FROM TBLURTDURUM where SERI_NO='"+seriNo+"'";
                var sonuc = context.Database.SqlQuery<TBLSERITRA>(sqlCumle).FirstOrDefault();
                if (sonuc == null)
                    return 0;
                else
                    return 1;
            }
        }
        public int SERINO_NETSISTEVARMI(string seriNo)
        {
            using (INF_SUSK_Context context = new INF_SUSK_Context())
            {
                string sqlCumle = "SELECT STOK_KODU,SERI_NO,count(*)ADET FROM TBLSERITRA where SERI_NO like '" + seriNo + "' GROUP BY STOK_KODU,SERI_NO";
                var sonuc = context.Database.SqlQuery<TBLSERITRA>(sqlCumle).FirstOrDefault();
                if (sonuc == null)
                    return 0;
                else
                    return 1;
            }
        }

    }
}
