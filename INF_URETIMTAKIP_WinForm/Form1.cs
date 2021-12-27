using INF_URETIMTAKIP_Business;
using INF_URETIMTAKIP_EntitiesLayer;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using static INF_URETIMTAKIP_Business.INF_URETIMTAKIP_Manager;


namespace INF_URETIMTAKIP_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int siraNo = 1;
        private TBLISEMRI isemriBilgi = new TBLISEMRI();
        private int miktar = 1;
        private void txtIsemri_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string seriNo = txtIsemriNo.Text;
                    //string seridenIsemri = txtIsemriNo.Text.Substring(0, 9);
                    //cmbCalisan.Enabled = false;
                    ////string seriNo=seridenIsemri.Substring
                    //var cihaz = new BARKOD();

                    string seridenIsemri = txtIsemriNo.Text.Substring(0, 9);
                    string isemriKisa = seridenIsemri.Substring(4);
                    string seriSonu = seriNo.Substring(9,3);//yeni kontrol

                    string kontrolSeriNo = seriNo.Substring(4,8);


                        //isemriKisa + "%" + seriSonu;


                    string ilkHarf = isemriKisa.Substring(0, 1);
                    string isemriSonu = isemriKisa.Substring(1);

                    string kisaIsemri = ilkHarf + "%" + isemriSonu;
                    var cihaz = infUrttkp_Manager.CIHAZBUL(kisaIsemri);

                    //label2.Text = cihaz.ISEMRINO;
                    if (txtIsemriNo.Text.Length < 15)
                    {
                        //var isemriNo = infUrttkp_Manager.SERIDEN_ISEMRIBUL(seridenIsemri).ISEMRINO;
                        isemriBilgi = infUrttkp_Manager.ISEMRIGETIR(cihaz.ISEMRINO);//geçen yıldan açılan işemirleri için sorgu genişletecek.

                        if (cmbUrtAsama.Text == "TEST")
                        {
                            if (cmbMusteriTipi.Text == "")
                            {
                                MessageBox.Show("Müşteri Tipi boş olamaz..!");
                            }

                            else if (infUrttkp_Manager.SERINO_CIHAZKONTROL(seriNo) == 1)
                            {
                                MessageBox.Show("Bu seri daha önceden okutulmuştur");
                                txtIsemriNo.Clear();
                                txtIsemriNo.Focus();
                            }
                            else
                            {
                                TBLCIHAZTEST yeniCihaz = new TBLCIHAZTEST
                                {
                                    ISEMRINO = isemriBilgi.ISEMRINO,
                                    SERINO = seriNo,
                                    CALISAN = cmbCalisan.Text,
                                    MUSTERI_TIPI = cmbMusteriTipi.Text,
                                    STOK_KODU = isemriBilgi.STOK_KODU,
                                    VOLTAJ_BILGISI = txtVoltaj.Text,
                                    TEST_TARIHI = DateTime.Now,
                                    KAYIPZAMAN = Convert.ToDouble(txtKayipZaman.Text)
                                };

                                //burada Test edilen cihaz için detay bilgiler ekleniyor. Sonrasında Test aşamasındaki işlem kayıt edilecek.
                                if (infUrttkp_Manager.TESTCIHAZEKLE(yeniCihaz) == 0)
                                {
                                    AutoClosingMessageBox.Show("Bir hata oluştu.", "Ekleme İşlemi Hatası", 2000);
                                }
                                cmbUrtAsama.Enabled = false;
                                dgvListe.Columns.Clear();

                                txtIsemriNo.Clear();
                                txtIsemriNo.Focus();
                                cmbMusteriTipi.Text = "";
                                txtVoltaj.Clear();


                                TBLURTDURUM urun = new TBLURTDURUM()
                                {
                                    ISEMRINO = isemriBilgi.ISEMRINO,
                                    STOK_KODU = isemriBilgi.STOK_KODU,
                                    SIRA = siraNo,
                                    HAT_NO = cmbHatBilgi.Text,
                                    MIKTAR = 1,
                                    URETIM_ASAMA = cmbUrtAsama.Text,
                                    BASLAMA_TARIH = DateTime.Now.Date,
                                    BASLAMA_SAAT = DateTime.Now.TimeOfDay,
                                    CALISAN = cmbCalisan.Text
                                };
                                dgvListe.Columns.Clear();
                                if (infUrttkp_Manager.URUNEKLE(urun) == 0)
                                {
                                    //AutoClosingMessageBox.Show("Satır eklenmiştir.", "Ekleme İşlemi", 2000);

                                    dgvListe.DataSource = infUrttkp_Manager.TESTCIHAZLIST();
                                    txtIsemriNo.Clear();
                                    txtIsemriNo.Focus();
                                }
                            }
                        }
                        else if (cmbUrtAsama.Text == "KAPAMA")
                        {
                            if (infUrttkp_Manager.SERINO_NETSISTEVARMI(kontrolSeriNo) == 0)
                            {
                                if (infUrttkp_Manager.SERINO_URETIMKONTROL(seriNo) == 0)
                                {
                                    TBLURTDURUM urun = new TBLURTDURUM()
                                    {
                                        ISEMRINO = isemriBilgi.ISEMRINO,
                                        STOK_KODU = isemriBilgi.STOK_KODU,
                                        SIRA = siraNo,
                                        HAT_NO = cmbHatBilgi.Text,
                                        MIKTAR = 1,
                                        URETIM_ASAMA = cmbUrtAsama.Text,
                                        BASLAMA_TARIH = DateTime.Now.Date,
                                        BASLAMA_SAAT = DateTime.Now.TimeOfDay,
                                        CALISAN = cmbCalisan.Text,
                                        SERI_NO = seriNo
                                    };
                                    if (infUrttkp_Manager.URUNEKLE(urun) == 0)
                                    {
                                        //AutoClosingMessageBox.Show("Satır eklenmiştir. SUSK işlemine başlanıyor, Lütfen Bekleyiniz", "Ekleme İşlemi", 2000);
                                        dgvListe.Columns.Clear();
                                        dgvListe.DataSource = infUrttkp_Manager.TESTCIHAZLIST();
                                        label2.Text = "İşlemde olan İşemri Sayısı: " + dgvListe.RowCount.ToString();

                                        txtIsemriNo.Clear();
                                        txtIsemriNo.Focus();

                                    }
                                }
                            }
                            txtIsemriNo.Clear();
                            txtIsemriNo.Focus();
                        }
                    }

                    else if (txtIsemriNo.Text.Substring(0, 1) == "T")
                    {

                        //Buraya işemri miktar kontrolü koyulacak
                        int uretimMiktar = infUrttkp_Manager.URUNOKUTULANMIKTAR(txtIsemriNo.Text, cmbUrtAsama.Text);
                        isemriBilgi = infUrttkp_Manager.ISEMRIGETIR(txtIsemriNo.Text);

                        TBLURTDURUM urun = new TBLURTDURUM()
                        {
                            ISEMRINO = isemriBilgi.ISEMRINO,
                            STOK_KODU = isemriBilgi.STOK_KODU,
                            SIRA = siraNo,
                            HAT_NO = cmbHatBilgi.Text,
                            MIKTAR = 1,
                            URETIM_ASAMA = cmbUrtAsama.Text,
                            BASLAMA_TARIH = DateTime.Now.Date,
                            BASLAMA_SAAT = DateTime.Now.TimeOfDay,
                            CALISAN = cmbCalisan.Text
                        };
                        dgvListe.Columns.Clear();
                        if (infUrttkp_Manager.URUNEKLE(urun) == 0)
                        {
                            //AutoClosingMessageBox.Show("Satır eklenmiştir.", "Ekleme İşlemi", 2000);
                            //dgvListe.DataSource = infUrttkp_Manager.URETIMDURUMOZET_MKA();
                            txtIsemriNo.Clear();
                            txtIsemriNo.Focus();
                        }
                    }
                    else
                    {
                        isemriBilgi = infUrttkp_Manager.ISEMRIGETIR(txtIsemriNo.Text);
                        var isemriNo = isemriBilgi.ISEMRINO;
                        var stokKodu = isemriBilgi.STOK_KODU;
                        var isemriSonHarf = isemriBilgi.STOK_KODU.Substring( stokKodu.Length - 2);
                        if (isemriBilgi == null)
                        {
                            AutoClosingMessageBox.Show("İşemri kapalı veya tanımsız", "İşemri Durum Kontrol", 2000);
                            txtIsemriNo.Clear();
                            txtMiktar.Visible = false;
                        }
                        //Paketleme işemirleri için yazılan kısım
                        else if (isemriBilgi.ISEMRINO.Substring(0, 1) == "E" && (stokKodu.Substring(0, 2) == "98" || stokKodu.Substring(0, 2) == "98" || isemriSonHarf == "-Y"))
                        {
                            txtMiktar.Visible = true;
                            txtMiktar.Enabled = true;
                            txtGercekSure.Visible = true;
                            label6.Visible = true;
                            label7.Visible = true;
                            label10.Visible = true;
                            txtAciklama.Visible = true;
                            miktar = Convert.ToInt32(isemriBilgi.MIKTAR);
                            txtMiktar.Text = miktar.ToString();
                            btnKaydet.Visible = true;
                        }

                        else  //ilk harfine göre yapılan işlemler
                        {
                            ilkHarf = txtIsemriNo.Text.Substring(0, 1).ToUpper();
                            if (ilkHarf == "S" || ilkHarf == "N" || ilkHarf == "U" || ilkHarf == "H" || ilkHarf == "K" || ilkHarf == "G" || ilkHarf == "B")
                            {
                                txtMiktar.Visible = true;
                                txtMiktar.Enabled = true;
                                txtGercekSure.Visible = true;
                                label6.Visible = true;
                                label7.Visible = true;
                                label10.Visible = true;
                                txtAciklama.Visible = true;

                                miktar = Convert.ToInt32(isemriBilgi.MIKTAR);
                                txtMiktar.Text = miktar.ToString();
                                btnKaydet.Visible = true;

                                //cmbUrtAsama.Text = "TAMAMLANDI";
                            }
                            else
                            {
                                string uretim_asama = cmbUrtAsama.Text;
                                string hatNo = cmbHatBilgi.Text;

                                if (infUrttkp_Manager.URUNSIRANO(txtIsemriNo.Text, uretim_asama) == 0)
                                    siraNo = 1;
                                else
                                    siraNo = infUrttkp_Manager.URUNSIRANO(txtIsemriNo.Text, uretim_asama) + 1;


                                cmbUrtAsama.Enabled = false;

                                if (isemriBilgi == null)
                                    AutoClosingMessageBox.Show("İşemri kapalı veya tanımsız", "İşemri Durum Kontrol", 2000);
                                else
                                {
                                    if (siraNo <= isemriBilgi.MIKTAR)
                                    {
                                        TBLURTDURUM urun = new TBLURTDURUM();
                                        urun.ISEMRINO = isemriBilgi.ISEMRINO;
                                        urun.STOK_KODU = isemriBilgi.STOK_KODU;
                                        urun.SIRA = siraNo;
                                        urun.HAT_NO = hatNo;
                                        urun.MIKTAR = 1;
                                        urun.URETIM_ASAMA = uretim_asama;
                                        urun.BASLAMA_TARIH = DateTime.Now.Date;
                                        urun.BASLAMA_SAAT = DateTime.Now.TimeOfDay;
                                        urun.CALISAN = cmbCalisan.Text;

                                        if (infUrttkp_Manager.URUNEKLE(urun) == 0)
                                        {
                                            AutoClosingMessageBox.Show("Satır eklenmiştir.", "Ekleme İşlemi", 1000);
                                            dgvListe.Columns.Clear();
                                            dgvListe.DataSource = infUrttkp_Manager.URETIMDURUMOZET_MKA();
                                            label2.Text = "İşlemde olan İşemri Sayısı: " + dgvListe.RowCount.ToString();
                                            txtIsemriNo.Focus();
                                        }
                                    }
                                    else
                                    {
                                        AutoClosingMessageBox.Show(uretim_asama + " aşaması için okutma işlemleri tamamlanmıştır. İşemri Miktarından fazla okutulamaz...!!!", "İşemri Miktar Kontrol", 2000);
                                        txtIsemriNo.Focus();
                                    }
                                }
                                txtIsemriNo.Clear();
                                txtMiktar.Visible = false;
                                txtAciklama.Visible = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //AutoClosingMessageBox.Show("İşemri kapalı veya tanımsız", "İşemri Durum Kontrol", 2000);
                txtIsemriNo.Clear();
                txtIsemriNo.Focus();
                MessageBox.Show(ex.Message);
            }
        }

        private INF_URETIMTAKIP_Manager infUrttkp_Manager = new INF_URETIMTAKIP_Manager();
        private void Form1_Load(object sender, EventArgs e)
        {
            //cmbUrtAsama.Enabled = false;
            label5.Visible = false;
            cmbCalisan.Visible = true;
            txtMiktar.Visible = false;
            btnKaydet.Visible = false;
            cmbHatBilgi.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label10.Visible = false;
            txtGercekSure.Visible = false;
            cmbMusteriTipi.Visible = false;
            txtVoltaj.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            txtAciklama.Visible = false;
            txtKayipZaman.Visible = false;
            label11.Visible = false;


            var asamaList = infUrttkp_Manager.URT_ASAMALIST();
            cmbUrtAsama.DataSource = asamaList;
            cmbUrtAsama.DisplayMember = "ASAMA_ACIKLAMA";
            cmbUrtAsama.ValueMember = "URETIM_ASAMA";

            var hatList = infUrttkp_Manager.URTHATBILGISI();
            cmbHatBilgi.DataSource = hatList;
            cmbHatBilgi.DisplayMember = "HAT_BILGISI";
            cmbHatBilgi.ValueMember = "ID";



            dgvListe.DataSource = infUrttkp_Manager.URETIMDURUMOZET_MKA();
            label2.Text = "İşlemde olan İşemri Sayısı: " + dgvListe.RowCount.ToString();

        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            dgvListe.Columns.Clear();
            dgvListe.DataSource = infUrttkp_Manager.URETIMDURUMOZET_MKA();

            //if (ilkHarf == "S" || ilkHarf == "N" || ilkHarf == "U" || ilkHarf == "H" || ilkHarf == "K" || ilkHarf == "G")
            //    dgvListe.DataSource = infUrttkp_Manager.URETIMDURUMOZET_COKLU();
            //else
            //    dgvListe.DataSource = infUrttkp_Manager.URETIMDURUMOZET();

            //dgvListe.DataSource = infUrttkp_Manager.URETIMDURUMOZET();
        }
        private void btnEngelKaldir_Click(object sender, EventArgs e)
        {
            cmbUrtAsama.Enabled = true;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string uretim_asama = cmbUrtAsama.SelectedValue.ToString();//cmbUrtAsama.Text;
            string hatNo = cmbHatBilgi.Text;

            int uretimMiktar = infUrttkp_Manager.URUNOKUTULANMIKTAR(txtIsemriNo.Text, uretim_asama);
            miktar = Convert.ToInt32(txtMiktar.Text);

            //if (infUrttkp_Manager.URUNOKUTULANMIKTAR(txtIsemriNo.Text, uretim_asama) == 0)

            //else
            //    siraNo = infUrttkp_Manager.URUNSIRANO(txtIsemriNo.Text, uretim_asama) + 1;

            cmbUrtAsama.Enabled = false;
            var isemriIlkHarf = isemriBilgi.ISEMRINO.Substring(0, 1).ToUpper();
            var isemriNo = isemriBilgi.ISEMRINO;
            var stokKodu = isemriBilgi.STOK_KODU;
            var isemriSonHarf = isemriBilgi.STOK_KODU.Substring( stokKodu.Length - 2);


            if (isemriBilgi == null)
            {
                AutoClosingMessageBox.Show("İşemri kapalı veya tanımsız...!", "İşemri Durum Kontrol", 2000);
                txtIsemriNo.Focus();
            }
            else
            {
                if (uretimMiktar + miktar <= isemriBilgi.MIKTAR)//işemri miktarına bakılacak, fazla miktarda okutmaların önüne geçilecek
                {
                    if ((isemriIlkHarf == "S" || isemriIlkHarf == "N" || isemriIlkHarf == "U" || isemriIlkHarf == "H" || isemriIlkHarf == "G") && (cmbUrtAsama.Text.Substring(0, 2) == "00") || cmbUrtAsama.Text.Substring(0, 2) == "10")
                    {
                        TBLURTDURUM urun = new TBLURTDURUM();
                        urun.ISEMRINO = isemriBilgi.ISEMRINO;
                        urun.STOK_KODU = isemriBilgi.STOK_KODU;
                        urun.SIRA = siraNo;
                        urun.HAT_NO = hatNo;
                        urun.MIKTAR = Convert.ToInt32(txtMiktar.Text);
                        urun.URETIM_ASAMA = uretim_asama;
                        urun.BASLAMA_TARIH = DateTime.Now.Date;
                        urun.BASLAMA_SAAT = DateTime.Now.TimeOfDay;
                        urun.CALISAN = cmbCalisan.Text;
                        urun.GERCEKLESENSURE = Convert.ToDecimal(txtGercekSure.Text);
                        urun.ACIKLAMA = txtAciklama.Text;
                        if (infUrttkp_Manager.URUNEKLE(urun) == 0)
                        {
                            AutoClosingMessageBox.Show("Satır eklenmiştir.", "Ekleme İşlemi", 1000);
                            txtIsemriNo.Focus();
                        }
                    }
                    else if (isemriIlkHarf == "K")
                    {
                        TBLURTDURUM urun = new TBLURTDURUM();
                        urun.ISEMRINO = isemriBilgi.ISEMRINO;
                        urun.STOK_KODU = isemriBilgi.STOK_KODU;
                        urun.SIRA = siraNo;
                        urun.HAT_NO = hatNo;
                        urun.MIKTAR = Convert.ToInt32(txtMiktar.Text);
                        urun.URETIM_ASAMA = "TAMAMLANDI";
                        urun.BASLAMA_TARIH = DateTime.Now.Date;
                        urun.BASLAMA_SAAT = DateTime.Now.TimeOfDay;
                        urun.CALISAN = cmbCalisan.Text;
                        if (infUrttkp_Manager.URUNEKLE(urun) == 0)
                        {
                            AutoClosingMessageBox.Show("Satır eklenmiştir.", "Ekleme İşlemi", 1000);
                            txtIsemriNo.Focus();
                        }
                    }
                    else if (isemriBilgi.ISEMRINO.Substring(0, 1) == "E" && (stokKodu.Substring(0, 2) == "98" || stokKodu.Substring(0, 2) == "98" || isemriSonHarf == "-Y"))
                    {
                        TBLURTDURUM urun = new TBLURTDURUM()
                        {
                            ISEMRINO = isemriBilgi.ISEMRINO,
                            STOK_KODU = isemriBilgi.STOK_KODU,
                            SIRA = siraNo,
                            HAT_NO = cmbHatBilgi.Text,
                            MIKTAR = Convert.ToInt32(txtMiktar.Text),
                            URETIM_ASAMA = cmbUrtAsama.Text,
                            BASLAMA_TARIH = DateTime.Now.Date,
                            BASLAMA_SAAT = DateTime.Now.TimeOfDay,
                            CALISAN = cmbCalisan.Text
                        };
                        dgvListe.Columns.Clear();
                        if (infUrttkp_Manager.URUNEKLE(urun) == 0)
                        {
                            //AutoClosingMessageBox.Show("Satır eklenmiştir.", "Ekleme İşlemi", 2000);

                            dgvListe.DataSource = infUrttkp_Manager.URETIMDURUMOZET_MKA();
                            txtIsemriNo.Clear();
                            txtIsemriNo.Focus();
                        }
                    }
                    else
                    {
                        AutoClosingMessageBox.Show(" İstasyon seçimi Yanlış...! Kayıt yapılamadı", "İşemri İstasyon Kontrol", 2000);
                        txtIsemriNo.Focus();
                    }
                }
                else
                {
                    AutoClosingMessageBox.Show(" İşemri Miktarından fazla okutulamaz...!", "İşemri Miktar Kontrol", 2000);
                    txtIsemriNo.Focus();
                }

                txtIsemriNo.Clear();
                txtGercekSure.Text = "0";
                txtMiktar.Visible = false;
                txtGercekSure.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label10.Visible = false;
                btnKaydet.Visible = false;
                txtAciklama.Visible = false;
                var ilkHarf = isemriBilgi.ISEMRINO.Substring(0, 1).ToUpper();

                if (ilkHarf == "S" || ilkHarf == "N" || ilkHarf == "U" || ilkHarf == "H" || ilkHarf == "K" || ilkHarf == "G" || ilkHarf == "B")
                {
                    dgvListe.Columns.Clear();
                    dgvListe.DataSource = null;
                    var list = infUrttkp_Manager.URETIMDURUMOZET_COKLU();
                    dgvListe.DataSource = infUrttkp_Manager.URETIMDURUMOZET_COKLU();
                    label2.Text = "İşlemde olan İşemri Sayısı: " + dgvListe.RowCount.ToString();
                }
                else
                {
                    dgvListe.Columns.Clear();
                    dgvListe.DataSource = infUrttkp_Manager.URETIMDURUMOZET_MKA();

                    label2.Text = "İşlemde olan İşemri Sayısı: " + dgvListe.RowCount.ToString();
                }
            }
        }
        private void cmbUrtAsama_SelectedValueChanged(object sender, EventArgs e)
        {
            var calisanList = infUrttkp_Manager.CALISAN_LIST(cmbUrtAsama.SelectedValue.ToString());
            cmbCalisan.DataSource = calisanList;
            cmbCalisan.DisplayMember = "ADISOYADI";
            cmbCalisan.ValueMember = "ID";

            if (cmbUrtAsama.Text == "TEST")
            {
                label8.Visible = true;
                label9.Visible = true;
                label11.Visible = true;
                cmbMusteriTipi.Visible = true;
                txtVoltaj.Visible = true;
                txtKayipZaman.Visible = true;
            }
            else
            {
                label8.Visible = false;
                label9.Visible = false;
                label11.Visible = false;
                cmbMusteriTipi.Visible = false;
                txtVoltaj.Visible = false;
                txtKayipZaman.Visible = false;
                //cmbCalisan.Text = "";
            }
        }
        private void btnCalisanKilit_Click(object sender, EventArgs e)
        {
            cmbCalisan.Enabled = true;
        }
    }
}
