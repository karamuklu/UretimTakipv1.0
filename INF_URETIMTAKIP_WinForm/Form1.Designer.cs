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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İşemri No / Seri No";
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1016, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Kayıp Zaman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hat Bilgisi";
            // 
            // txtKayipZaman
            // 
            this.txtKayipZaman.Location = new System.Drawing.Point(1019, 47);
            this.txtKayipZaman.Name = "txtKayipZaman";
            this.txtKayipZaman.Size = new System.Drawing.Size(32, 20);
            this.txtKayipZaman.TabIndex = 21;
            this.txtKayipZaman.Text = "0";
            // 
            // cmbUrtAsama
            // 
            this.cmbUrtAsama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrtAsama.FormattingEnabled = true;
            this.cmbUrtAsama.Location = new System.Drawing.Point(247, 44);
            this.cmbUrtAsama.Name = "cmbUrtAsama";
            this.cmbUrtAsama.Size = new System.Drawing.Size(216, 24);
            this.cmbUrtAsama.TabIndex = 5;
            this.cmbUrtAsama.SelectedValueChanged += new System.EventHandler(this.cmbUrtAsama_SelectedValueChanged);
            // 
            // btnCalisanKilit
            // 
            this.btnCalisanKilit.Location = new System.Drawing.Point(470, 70);
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
            this.label3.Location = new System.Drawing.Point(244, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Üretim Aşama veya İstasyon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Açıklama";
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(649, 70);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(121, 42);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(13, 114);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(215, 20);
            this.txtAciklama.TabIndex = 18;
            // 
            // btnEngelKaldir
            // 
            this.btnEngelKaldir.Location = new System.Drawing.Point(247, 70);
            this.btnEngelKaldir.Name = "btnEngelKaldir";
            this.btnEngelKaldir.Size = new System.Drawing.Size(216, 42);
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
            this.cmbMusteriTipi.Location = new System.Drawing.Point(786, 46);
            this.cmbMusteriTipi.Name = "cmbMusteriTipi";
            this.cmbMusteriTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbMusteriTipi.TabIndex = 17;
            // 
            // cmbHatBilgi
            // 
            this.cmbHatBilgi.FormattingEnabled = true;
            this.cmbHatBilgi.Location = new System.Drawing.Point(649, 44);
            this.cmbHatBilgi.Name = "cmbHatBilgi";
            this.cmbHatBilgi.Size = new System.Drawing.Size(121, 21);
            this.cmbHatBilgi.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(910, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Voltaj Bilgisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(945, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açık İşemri Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(788, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Müşteri Tipi";
            // 
            // txtIsemriNo
            // 
            this.txtIsemriNo.Location = new System.Drawing.Point(13, 45);
            this.txtIsemriNo.Name = "txtIsemriNo";
            this.txtIsemriNo.Size = new System.Drawing.Size(215, 20);
            this.txtIsemriNo.TabIndex = 0;
            this.txtIsemriNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIsemri_KeyDown);
            // 
            // txtVoltaj
            // 
            this.txtVoltaj.Location = new System.Drawing.Point(913, 46);
            this.txtVoltaj.Name = "txtVoltaj";
            this.txtVoltaj.Size = new System.Drawing.Size(100, 20);
            this.txtVoltaj.TabIndex = 14;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(13, 88);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(33, 20);
            this.txtMiktar.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(57, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gerçekleşen Süre";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(169, 68);
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
            this.label6.Location = new System.Drawing.Point(10, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Miktar";
            // 
            // cmbCalisan
            // 
            this.cmbCalisan.FormattingEnabled = true;
            this.cmbCalisan.Location = new System.Drawing.Point(470, 44);
            this.cmbCalisan.Name = "cmbCalisan";
            this.cmbCalisan.Size = new System.Drawing.Size(173, 21);
            this.cmbCalisan.TabIndex = 8;
            // 
            // txtGercekSure
            // 
            this.txtGercekSure.Location = new System.Drawing.Point(87, 88);
            this.txtGercekSure.Name = "txtGercekSure";
            this.txtGercekSure.Size = new System.Drawing.Size(33, 20);
            this.txtGercekSure.TabIndex = 3;
            this.txtGercekSure.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Çalışan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbHatBilgi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtIsemriNo);
            this.groupBox1.Controls.Add(this.cmbMusteriTipi);
            this.groupBox1.Controls.Add(this.txtKayipZaman);
            this.groupBox1.Controls.Add(this.txtVoltaj);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnEngelKaldir);
            this.groupBox1.Controls.Add(this.cmbUrtAsama);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.txtGercekSure);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.btnCalisanKilit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbCalisan);
            this.groupBox1.Controls.Add(this.btnYenile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 157);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Girişi";
            // 
            // dgvListe
            // 
            this.dgvListe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListe.Location = new System.Drawing.Point(0, 153);
            this.dgvListe.Name = "dgvListe";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListe.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListe.Size = new System.Drawing.Size(1175, 593);
            this.dgvListe.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 746);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İnform Üretim Takip v.1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListe;
    }
}

