namespace INF_URETIMTAKIP_WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgw_Ekran = new DevExpress.XtraGrid.GridControl();
            this.dgvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKayipZaman = new System.Windows.Forms.TextBox();
            this.cmbUrtAsama = new System.Windows.Forms.ComboBox();
            this.btnCalisanKilit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnEngelKaldir = new System.Windows.Forms.Button();
            this.cmbMusteriTipi = new System.Windows.Forms.ComboBox();
            this.cmbHatBilgi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIsemriNo = new System.Windows.Forms.TextBox();
            this.txtVoltaj = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCalisan = new System.Windows.Forms.ComboBox();
            this.txtGercekSure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Ekran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_Ekran
            // 
            this.dgw_Ekran.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgw_Ekran.Location = new System.Drawing.Point(0, 159);
            this.dgw_Ekran.MainView = this.dgvListe;
            this.dgw_Ekran.Name = "dgw_Ekran";
            this.dgw_Ekran.Size = new System.Drawing.Size(1175, 587);
            this.dgw_Ekran.TabIndex = 2;
            this.dgw_Ekran.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvListe});
            // 
            // dgvListe
            // 
            this.dgvListe.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dgvListe.GridControl = this.dgw_Ekran;
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.OptionsBehavior.Editable = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtKayipZaman);
            this.groupControl1.Controls.Add(this.cmbUrtAsama);
            this.groupControl1.Controls.Add(this.btnCalisanKilit);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Controls.Add(this.txtAciklama);
            this.groupControl1.Controls.Add(this.btnEngelKaldir);
            this.groupControl1.Controls.Add(this.cmbMusteriTipi);
            this.groupControl1.Controls.Add(this.cmbHatBilgi);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txtIsemriNo);
            this.groupControl1.Controls.Add(this.txtVoltaj);
            this.groupControl1.Controls.Add(this.txtMiktar);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.cmbCalisan);
            this.groupControl1.Controls.Add(this.txtGercekSure);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1175, 211);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "Bilgi Girişi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İşemri No / Seri No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(960, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Kayıp Zaman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hat Bilgisi";
            // 
            // txtKayipZaman
            // 
            this.txtKayipZaman.Location = new System.Drawing.Point(963, 40);
            this.txtKayipZaman.Name = "txtKayipZaman";
            this.txtKayipZaman.Size = new System.Drawing.Size(100, 21);
            this.txtKayipZaman.TabIndex = 21;
            this.txtKayipZaman.Text = "0";
            // 
            // cmbUrtAsama
            // 
            this.cmbUrtAsama.FormattingEnabled = true;
            this.cmbUrtAsama.Location = new System.Drawing.Point(242, 37);
            this.cmbUrtAsama.Name = "cmbUrtAsama";
            this.cmbUrtAsama.Size = new System.Drawing.Size(163, 21);
            this.cmbUrtAsama.TabIndex = 5;
            this.cmbUrtAsama.SelectedValueChanged += new System.EventHandler(this.cmbUrtAsama_SelectedValueChanged);
            // 
            // btnCalisanKilit
            // 
            this.btnCalisanKilit.Location = new System.Drawing.Point(414, 63);
            this.btnCalisanKilit.Name = "btnCalisanKilit";
            this.btnCalisanKilit.Size = new System.Drawing.Size(173, 42);
            this.btnCalisanKilit.TabIndex = 20;
            this.btnCalisanKilit.Text = "Çalışan Kilit Kaldır";
            this.btnCalisanKilit.UseVisualStyleBackColor = true;
            this.btnCalisanKilit.Click += new System.EventHandler(this.btnCalisanKilit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Üretim Aşama veya İstasyon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Açıklama";
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(593, 63);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(121, 42);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(8, 107);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(215, 21);
            this.txtAciklama.TabIndex = 18;
            // 
            // btnEngelKaldir
            // 
            this.btnEngelKaldir.Location = new System.Drawing.Point(242, 63);
            this.btnEngelKaldir.Name = "btnEngelKaldir";
            this.btnEngelKaldir.Size = new System.Drawing.Size(163, 42);
            this.btnEngelKaldir.TabIndex = 7;
            this.btnEngelKaldir.Text = "Aşama Kilit Kaldır";
            this.btnEngelKaldir.UseVisualStyleBackColor = true;
            this.btnEngelKaldir.Click += new System.EventHandler(this.btnEngelKaldir_Click);
            // 
            // cmbMusteriTipi
            // 
            this.cmbMusteriTipi.FormattingEnabled = true;
            this.cmbMusteriTipi.Items.AddRange(new object[] {
            "IHRACAT",
            "PAZARLAMA"});
            this.cmbMusteriTipi.Location = new System.Drawing.Point(730, 39);
            this.cmbMusteriTipi.Name = "cmbMusteriTipi";
            this.cmbMusteriTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbMusteriTipi.TabIndex = 17;
            // 
            // cmbHatBilgi
            // 
            this.cmbHatBilgi.FormattingEnabled = true;
            this.cmbHatBilgi.Location = new System.Drawing.Point(593, 37);
            this.cmbHatBilgi.Name = "cmbHatBilgi";
            this.cmbHatBilgi.Size = new System.Drawing.Size(121, 21);
            this.cmbHatBilgi.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(854, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Voltaj Bilgisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(889, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açık İşemri Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(732, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Müşteri Tipi";
            // 
            // txtIsemriNo
            // 
            this.txtIsemriNo.Location = new System.Drawing.Point(8, 38);
            this.txtIsemriNo.Name = "txtIsemriNo";
            this.txtIsemriNo.Size = new System.Drawing.Size(215, 21);
            this.txtIsemriNo.TabIndex = 0;
            this.txtIsemriNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIsemri_KeyDown);
            // 
            // txtVoltaj
            // 
            this.txtVoltaj.Location = new System.Drawing.Point(857, 39);
            this.txtVoltaj.Name = "txtVoltaj";
            this.txtVoltaj.Size = new System.Drawing.Size(100, 21);
            this.txtVoltaj.TabIndex = 14;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(8, 81);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(33, 21);
            this.txtMiktar.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(52, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gerçekleşen Süre";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(164, 61);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(59, 42);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(5, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Miktar";
            // 
            // cmbCalisan
            // 
            this.cmbCalisan.FormattingEnabled = true;
            this.cmbCalisan.Location = new System.Drawing.Point(414, 37);
            this.cmbCalisan.Name = "cmbCalisan";
            this.cmbCalisan.Size = new System.Drawing.Size(173, 21);
            this.cmbCalisan.TabIndex = 8;
            // 
            // txtGercekSure
            // 
            this.txtGercekSure.Location = new System.Drawing.Point(82, 81);
            this.txtGercekSure.Name = "txtGercekSure";
            this.txtGercekSure.Size = new System.Drawing.Size(33, 21);
            this.txtGercekSure.TabIndex = 3;
            this.txtGercekSure.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Çalışan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 746);
            this.Controls.Add(this.dgw_Ekran);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Ekran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl dgw_Ekran;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvListe;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKayipZaman;
        private System.Windows.Forms.ComboBox cmbUrtAsama;
        private System.Windows.Forms.Button btnCalisanKilit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnEngelKaldir;
        private System.Windows.Forms.ComboBox cmbMusteriTipi;
        private System.Windows.Forms.ComboBox cmbHatBilgi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIsemriNo;
        private System.Windows.Forms.TextBox txtVoltaj;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCalisan;
        private System.Windows.Forms.TextBox txtGercekSure;
        private System.Windows.Forms.Label label5;
    }
}

