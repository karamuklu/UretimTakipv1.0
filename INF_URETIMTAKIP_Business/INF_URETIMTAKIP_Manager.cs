using INF_OTO_SUSK_Entities;
using INF_URETIMTAKIP_DataAccess;
using INF_URETIMTAKIP_EntitiesLayer;
using NetOpenX50;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace INF_URETIMTAKIP_Business
{
    public class INF_URETIMTAKIP_Manager
    {
        private INF_URETIMTAKIP_Dal inf_UrtmTkp_Dal = new INF_URETIMTAKIP_Dal();

        public TBLISEMRI ISEMRIGETIR(string isemrino)
        {
            return inf_UrtmTkp_Dal.ISEMRIGETIR(isemrino);
        }

        public URETIMDURUMOZET_MKA URUN_URTDURUM(string isemrino, int sira, string uretim_asama)
        {
            return inf_UrtmTkp_Dal.URUN_URTDURUM(isemrino, sira, uretim_asama);
        }
        public List<TBLURTDURUM> URTDURUM_LIST()
        {
            return inf_UrtmTkp_Dal.URTDURUM_LIST();
        }
        public List<TBLURT_ASAMA> URT_ASAMALIST()
        {
            return inf_UrtmTkp_Dal.URT_ASAMALIST();
        }
        public List<TBLCALISAN> CALISAN_LIST(string istasyon)
        {
            return inf_UrtmTkp_Dal.TBLCALISAN(istasyon);
        }
        public List<URETIMDURUMOZET_MKA> URETIMDURUMOZET_MKA()
        {
            return inf_UrtmTkp_Dal.URETIMDURUMOZET_MKA();
        }
        public List<URETIMDURUMOZET_COKLU> URETIMDURUMOZET_COKLU()
        {
            return inf_UrtmTkp_Dal.URETIMDURUMOZET_COKLU();
        }
        public List<TBLHATBILGI> URTHATBILGISI()
        {
            return inf_UrtmTkp_Dal.URTHATBILGISI();
        }

        public int URUNSIRANO(string isemrino, string uretim_asama)
        {

            return inf_UrtmTkp_Dal.URUNSIRANO(isemrino, uretim_asama);
        }
        public int URUNOKUTULANMIKTAR(string isemrino, string uretim_asama)
        {

            return inf_UrtmTkp_Dal.URUNOKUTULANMIKTAR(isemrino, uretim_asama);
        }

        public int URUNEKLE(TBLURTDURUM urun)
        {
            if (inf_UrtmTkp_Dal.URUNEKLE(urun) == 0)
                return 0;
            else
                return 1;
        }
        public int TESTCIHAZEKLE(TBLCIHAZTEST testcihaz)
        {
            if (inf_UrtmTkp_Dal.TESTCIHAZEKLE(testcihaz) == 1)
                return 1;
            else
                return 0;
        }
        public BARKOD SERIDEN_ISEMRIBUL(string seriNo)
        {
            return inf_UrtmTkp_Dal.SERIDEN_ISEMRIBUL(seriNo);
        }
        public List<TBLCIHAZTEST> TESTCIHAZLIST()
        {
            return inf_UrtmTkp_Dal.TESTCIHAZLIST();
        }
        public void LokalDepolarArasiTransferBelgesi(List<CIHAZ_TRANSFER> transferList)
        {
            //aktarım için lazım olan kalemler, hammadde kodu, transfer miktar
            //Üst bilgiler sabit, kalem bilgilerini foreach ile dönüp aktarımı yaptırabiliriz.

            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFile = System.IO.Path.Combine(appPath, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".exe.config");

            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            Kernel kernel = new Kernel();
            Sirket sirket = default(Sirket);
            Fatura fatura = default(Fatura);
            FatUst fatUst = default(FatUst);
            FatKalem fatKalem = default(FatKalem);
            try
            {
                sirket = kernel.yeniSirket(TVTTipi.vtMSSQL,
                                              ConfigurationManager.AppSettings["SIRKET"],
                                              "TEMELSET",
                                              "",
                                              "karamuklu",
                                              "12qw",
                                              1);
                fatura = kernel.yeniFatura(sirket, TFaturaTip.ftLokalDepo);
                fatUst = fatura.Ust();
                fatUst.FATIRS_NO = fatura.YeniNumara("X");
                fatUst.KOD2 = "D";
                //fatUst.CariKod = "1";
                fatUst.CARI_KOD2 = "1";
                fatUst.TIPI = TFaturaTipi.ft_Bos;
                fatUst.AMBHARTUR = TAmbarHarTur.htDepolar;
                fatUst.Tarih = DateTime.Now.Date;
                fatUst.FiiliTarih = DateTime.Now.Date;
                fatUst.PLA_KODU = "D";
                fatUst.Proje_Kodu = "G";
                fatUst.Aciklama = "OTO. AKTARIM";
                fatUst.EFatOzelKod = 'D';
                fatUst.KDV_DAHILMI = true;
                fatUst.EKACK1 = "CIHAZ ANAMAMUL - Otomatik Aktarım - Depo Transfer Fişi";

                //string inc_HAMKODU = "";
                //decimal inc_ILKTRANSFERMIKTAR = 0;
                //string inc_FISNO = "";

                var depharList = new List<TBLDEPHAR>();

                foreach (var item in transferList)
                {
                    if ((double)item.ILKTRANSFERMIKTAR != 0)
                    {
                        fatKalem = fatura.kalemYeni(item.HAM_KODU);//stok kodu lazım
                        fatKalem.Gir_Depo_Kodu = 115;               //Depo Kodu lazım Giriş
                        fatKalem.DEPO_KODU = item.ILKTRANSFER_DEPO;                   //Depo Kodu lazım Çıkış
                        fatKalem.STra_GCMIK = (double)item.ILKTRANSFERMIKTAR;
                        fatKalem.ProjeKodu = "G";
                        fatKalem.ReferansKodu = "1U1151";// Bu kısımda önemli.Bağlı siparişe bakıp çekilebilir

                        TBLDEPHAR dephar = new TBLDEPHAR();
                        dephar.STOKKODU = item.HAM_KODU;
                        dephar.NETMIKTAR = item.ILKTRANSFERMIKTAR;
                        dephar.DEPOHARFISNO = fatUst.FATIRS_NO;
                        depharList.Add(dephar);

                        //inc_HAMKODU = item.HAM_KODU;
                        //inc_ILKTRANSFERMIKTAR = item.ILKTRANSFERMIKTAR;
                        //inc_FISNO = fatUst.FATIRS_NO;
                    }

                    if ((double)item.IKINCITRANSFER != 0)
                    {
                        fatKalem = fatura.kalemYeni(item.HAM_KODU);//stok kodu lazım
                        fatKalem.Gir_Depo_Kodu = 115;               //Depo Kodu lazım Giriş
                        fatKalem.DEPO_KODU = item.IKINCITRANSFER_DEPO;
                        fatKalem.STra_GCMIK = (double)item.IKINCITRANSFER;
                        fatKalem.ProjeKodu = "G";
                        fatKalem.ReferansKodu = "1U1151";// Bu kısımda önemli.Bağlı siparişe bakıp çekilebilir


                    }//Depo Kodu lazım Çıkış

                    if ((double)item.UCUNCUTRANSFER != 0)
                    {
                        fatKalem = fatura.kalemYeni(item.HAM_KODU);
                        fatKalem.Gir_Depo_Kodu = 115;
                        fatKalem.DEPO_KODU = item.UCUNCUTRANSFER_DEPO;
                        fatKalem.STra_GCMIK = (double)item.UCUNCUTRANSFER;
                        fatKalem.ProjeKodu = "G";
                        fatKalem.ReferansKodu = "1U1151";
                        //fatKalem.Irsaliyeno = "OTO AKTARIM";
                    }

                    if ((double)item.DORDUNCUTRANSFER != 0)
                    {
                        fatKalem = fatura.kalemYeni(item.HAM_KODU);//stok kodu lazım
                        fatKalem.Gir_Depo_Kodu = 115; //Depo Kodu lazım Giriş
                        fatKalem.DEPO_KODU = item.DORDUNCUTRANSFER_DEPO; //Depo Kodu lazım Çıkış
                        fatKalem.STra_GCMIK = (double)item.DORDUNCUTRANSFER;
                        fatKalem.ProjeKodu = "G";
                        fatKalem.ReferansKodu = "1U1151";// Bu kısımda önemli.Bağlı siparişe bakıp çekilebilir
                        //fatKalem.Irsaliyeno = "OTO AKTARIM";
                    }
                }


                if (fatura.KalemAdedi != 0)
                {
                    fatura.kayitYeni();
                    //Dinamik Depo Hareketi atan kod
                    if (depharList.Count != 0)
                    {
                        foreach (var item in depharList)
                        {
                            inf_UrtmTkp_Dal.HUCREHAREKETKAYIT(item.STOKKODU, item.NETMIKTAR, item.DEPOHARFISNO);
                        }
                    }
                    MailGonder("Cihaz - Otomatik oluşturulan " + fatUst.FATIRS_NO + " no'lu Depo Transfer Fişi", "Cihaz - " + fatUst.FATIRS_NO + " numaralı Depo Transfer Fişi sistemde oluşturulmuştur. Cihazlar için SUSK işlemine başlayabilirsiniz...", ConfigurationManager.AppSettings["CihazTransferEmail"]);
                }
            }
            finally
            {
                try
                {
                    Marshal.ReleaseComObject(fatKalem);
                    Marshal.ReleaseComObject(fatUst);
                    Marshal.ReleaseComObject(fatura);
                    Marshal.ReleaseComObject(sirket);
                    kernel.FreeNetsisLibrary();
                    Marshal.ReleaseComObject(kernel);
                }
                catch (Exception)
                {
                    AutoClosingMessageBox.Show("Transfer edilecek kayıt bulunamadı, Sonraki işleme geçilecektir.", "Depo Transfer Kontrol", 2000);
                }
            }
        }
        public void SUSK_Kaydet(CIHAZ_SUSK suskCihaz)
        {
            Kernel kernel = new Kernel();
            Sirket sirket = default(Sirket);
            SerbestUSK susk = default(SerbestUSK);
            try
            {
                sirket = kernel.yeniSirket(TVTTipi.vtMSSQL,
                     "INFORM20",
                     "TEMELSET",
                     "",
                     "karamuklu",
                     "12qw",
                     1);

                susk = kernel.yeniSerbestUSK(sirket);
                susk.UretSon_FisNo = susk.SonFisNumarasi("M");
                susk.UretSon_Mamul = suskCihaz.STOK_KODU;
                susk.UretSon_Depo = suskCihaz.SUSKDEPOGIRIS; //giriş depo
                susk.I_Yedek1 = suskCihaz.SUSKDEPOCIKIS;   //çıkış depo
                susk.UretSon_Miktar = (double)suskCihaz.MIKTAR;
                susk.UretSon_Tarih = DateTime.Now.Date;
                susk.BelgeTipi = TBelgeTipi.btIsEmri;
                susk.UretSon_SipNo = suskCihaz.ISEMRINO;
                susk.DepoOnceligi = TDepoOnceligi.doStokDepo;
                //susk.F_Yedek1 = (double)suskList.MIKTAR; //miktar2
                susk.Aciklama = "OTO. SUSK";
                susk.Proje_Kodu = "G";
                //susk.S_Yedek1 = "ekalan1 örneği";
                //susk.S_Yedek2 = "ekalan2 örneği";
                susk.OTO_YMAM_GIRDI_CIKTI = true;
                susk.OTO_YMAM_STOK_KULLAN = false;
                susk.BAKIYE_DEPO = 0;  //0:verilen_depo 1:tüm_depolar
                susk.SeriEkle(suskCihaz.SERINO, "SERI1", "Açıklama1", "Açıklama2", 1);

                if (susk.FisUret() != true)
                {
                    MailGonder("Uyarı... Eksik Malzeme - SUSK YAPILAMAYAN İŞEMRİ " + suskCihaz.ISEMRINO + "  " + suskCihaz.STOK_KODU, suskCihaz.STOK_KODU + " stok kodu için açılmış olan " + suskCihaz.ISEMRINO + " nolu işemri " + susk.UretSon_FisNo + " fiş numarası ile SUSK fiş numarası ile SUSK yapılırken eksik malzemeden dolayı TAMAMLANAMAMIŞTIR..." + " " + "" +
                       susk.HataMesaji, ConfigurationManager.AppSettings["InformSUSKEmail"]);
                    //MessageBox.Show(susk.HataKodu.ToString() + ' ' + susk.HataMesaji);
                    //inf_UrtmTkp_Dal.IsEmriUSK_STATUSGuncelle(suskList.ISEMRINO);
                    //inf_UrtmTkp_Dal.IsemriKapat(suskList.ISEMRINO);
                }

                if (susk.Kaydet() != true)
                {
                    MailGonder("Uyarı... Eksik Malzeme - SUSK YAPILAMAYAN İŞEMRİ " + suskCihaz.ISEMRINO + "  " + suskCihaz.STOK_KODU, suskCihaz.STOK_KODU + " stok kodu için açılmış olan " + suskCihaz.ISEMRINO + " nolu işemri " + susk.UretSon_FisNo + " fiş numarası ile SUSK fiş numarası ile SUSK yapılırken eksik malzemeden dolayı TAMAMLANAMAMIŞTIR..." + " " + "" + susk.HataMesaji, ConfigurationManager.AppSettings["InformSUSKEmail"]);
                    //inf_UrtmTkp_Dal.IsEmriUSK_STATUSGuncelle(suskList.ISEMRINO);
                }

                else
                {
                    MailGonder("Bilgi... SUSK Yapılan İşemri " + suskCihaz.ISEMRINO + "  " + suskCihaz.STOK_KODU, suskCihaz.STOK_KODU + " stok kodu için açılmış olan " + suskCihaz.ISEMRINO + " nolu işemri " + susk.UretSon_FisNo + " fiş numarası ile  otomatik olarak SUSK yapılmıştır.", ConfigurationManager.AppSettings["InformSUSKEmail"]);
                }
            }
            catch (Exception ex)
            {
                MailGonder("Uyarı... Eksik Malzeme - SUSK YAPILAMAYAN İŞEMRİ " + suskCihaz.ISEMRINO + "  " + suskCihaz.STOK_KODU, suskCihaz.STOK_KODU + " stok kodu için açılmış olan " + suskCihaz.ISEMRINO + " nolu işemri " + susk.UretSon_FisNo + " fiş numarası ile SUSK fiş numarası ile SUSK yapılırken eksik malzemeden dolayı TAMAMLANAMAMIŞTIR..." + " " + "" +
                   ex.Message, ConfigurationManager.AppSettings["InformSUSKEmail"]);
                //inf_UrtmTkp_Dal.IsEmriUSK_STATUSGuncelle(suskList.ISEMRINO);
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                Marshal.ReleaseComObject(susk);
                Marshal.ReleaseComObject(sirket);
                kernel.FreeNetsisLibrary();
                Marshal.ReleaseComObject(kernel);
            }
        }
        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }
        public static bool MailGonder(string konu, string aciklama, string kime)
        {
            SmtpClient smtpClient = new SmtpClient();
            NetworkCredential basicCredential = new NetworkCredential("mustafa.karamuklu@inform.com.tr", "Password19");
            MailMessage message = new MailMessage();
            MailAddress fromAddress = new MailAddress("noreply@legrand.com");
            smtpClient.Host = "SMTP.LIMOUSIN.FR.GRPLEG.COM";
            smtpClient.Port = 25; //Gönderici portudur.
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = basicCredential;
            smtpClient.EnableSsl = false;
            message.From = fromAddress;
            message.Subject = konu;
            message.IsBodyHtml = true; // HTML içeriğine izin verir
            message.Body = aciklama; // İçeriği oluşturmaktadır.
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            message.To.Add(kime);
            message.Bcc.Add("mustafa.karamuklu@inform.com.tr");
            smtpClient.Send(message);
            return true;
        }
        public int SERINO_CIHAZKONTROL(string seriNo)
        {
            return inf_UrtmTkp_Dal.SERINO_CIHAZKONTROL(seriNo);
        }
        public int SERINO_URETIMKONTROL(string seriNo)
        {
            return inf_UrtmTkp_Dal.SERINO_URETIMKONTROL(seriNo);
        }
        public int SERINO_NETSISTEVARMI(string seriNo)
        {
            return inf_UrtmTkp_Dal.SERINO_NETSISTEVARMI(seriNo);
        }
    }
}
