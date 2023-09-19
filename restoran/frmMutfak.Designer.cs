/*
Novelty Yazılım Bilişim Teknolojileri Ltd. Şti. - www.noveltybilisim.com.tr
- Coder by Muhammed POLAT - Copyright (c) 2021 -

05.07.2021 - 06.09.2021 Tarihleri arasında yazılmış staj projesidir.

İletişim için: kurumsal@noveltybilisim.com.tr
https://www.muhammedpolat.com.tr/
info@muhammedpolat.com.tr
*/
namespace restoran
{
    partial class frmMutfak
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
            this.lvKategoriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGidaListesi = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.panelUrun = new System.Windows.Forms.Panel();
            this.txtGidaFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.txtGidaAdi = new System.Windows.Forms.TextBox();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAnaKategori = new System.Windows.Forms.Panel();
            this.txtKategoriId = new System.Windows.Forms.TextBox();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbAltKategori = new System.Windows.Forms.RadioButton();
            this.rbAnaKategori = new System.Windows.Forms.RadioButton();
            this.lblAra = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.panelUrun.SuspendLayout();
            this.panelAnaKategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvKategoriler
            // 
            this.lvKategoriler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvKategoriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvKategoriler.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lvKategoriler.FullRowSelect = true;
            this.lvKategoriler.GridLines = true;
            this.lvKategoriler.HideSelection = false;
            this.lvKategoriler.Location = new System.Drawing.Point(689, 526);
            this.lvKategoriler.Name = "lvKategoriler";
            this.lvKategoriler.Size = new System.Drawing.Size(548, 359);
            this.lvKategoriler.TabIndex = 0;
            this.lvKategoriler.UseCompatibleStateImageBehavior = false;
            this.lvKategoriler.View = System.Windows.Forms.View.Details;
            this.lvKategoriler.SelectedIndexChanged += new System.EventHandler(this.lvKategoriler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tür ID:";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori:";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Açıklama:";
            this.columnHeader3.Width = 180;
            // 
            // lvGidaListesi
            // 
            this.lvGidaListesi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvGidaListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader8});
            this.lvGidaListesi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lvGidaListesi.FullRowSelect = true;
            this.lvGidaListesi.GridLines = true;
            this.lvGidaListesi.HideSelection = false;
            this.lvGidaListesi.Location = new System.Drawing.Point(689, 526);
            this.lvGidaListesi.Name = "lvGidaListesi";
            this.lvGidaListesi.Size = new System.Drawing.Size(803, 359);
            this.lvGidaListesi.TabIndex = 0;
            this.lvGidaListesi.UseCompatibleStateImageBehavior = false;
            this.lvGidaListesi.View = System.Windows.Forms.View.Details;
            this.lvGidaListesi.SelectedIndexChanged += new System.EventHandler(this.lvGidaListesi_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ürün ID:";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ürün Tür No:";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kategori:";
            this.columnHeader6.Width = 250;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ürün Adı:";
            this.columnHeader7.Width = 300;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Açıklama:";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fiyatı:";
            this.columnHeader8.Width = 250;
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BackgroundImage = global::restoran.Properties.Resources.ekle;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(1250, 208);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(273, 84);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDegistir.BackColor = System.Drawing.Color.Transparent;
            this.btnDegistir.BackgroundImage = global::restoran.Properties.Resources.degistir;
            this.btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDegistir.Location = new System.Drawing.Point(1530, 208);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(273, 84);
            this.btnDegistir.TabIndex = 4;
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnBul
            // 
            this.btnBul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBul.BackColor = System.Drawing.Color.Transparent;
            this.btnBul.BackgroundImage = global::restoran.Properties.Resources.bul;
            this.btnBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBul.Location = new System.Drawing.Point(1250, 314);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(273, 84);
            this.btnBul.TabIndex = 4;
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImage = global::restoran.Properties.Resources.sil2;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(1530, 314);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(273, 84);
            this.btnSil.TabIndex = 4;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // panelUrun
            // 
            this.panelUrun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUrun.BackColor = System.Drawing.Color.Transparent;
            this.panelUrun.Controls.Add(this.txtGidaFiyati);
            this.panelUrun.Controls.Add(this.txtUrunId);
            this.panelUrun.Controls.Add(this.txtGidaAdi);
            this.panelUrun.Controls.Add(this.cbKategoriler);
            this.panelUrun.Controls.Add(this.label3);
            this.panelUrun.Controls.Add(this.label2);
            this.panelUrun.Controls.Add(this.label1);
            this.panelUrun.Location = new System.Drawing.Point(101, 124);
            this.panelUrun.Name = "panelUrun";
            this.panelUrun.Size = new System.Drawing.Size(591, 311);
            this.panelUrun.TabIndex = 5;
            this.panelUrun.Visible = false;
            // 
            // txtGidaFiyati
            // 
            this.txtGidaFiyati.Location = new System.Drawing.Point(172, 195);
            this.txtGidaFiyati.Multiline = true;
            this.txtGidaFiyati.Name = "txtGidaFiyati";
            this.txtGidaFiyati.Size = new System.Drawing.Size(244, 45);
            this.txtGidaFiyati.TabIndex = 2;
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(467, 124);
            this.txtUrunId.Multiline = true;
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(49, 45);
            this.txtUrunId.TabIndex = 2;
            // 
            // txtGidaAdi
            // 
            this.txtGidaAdi.Location = new System.Drawing.Point(172, 124);
            this.txtGidaAdi.Multiline = true;
            this.txtGidaAdi.Name = "txtGidaAdi";
            this.txtGidaAdi.Size = new System.Drawing.Size(279, 45);
            this.txtGidaAdi.TabIndex = 2;
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.ItemHeight = 16;
            this.cbKategoriler.Location = new System.Drawing.Point(269, 37);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(300, 24);
            this.cbKategoriler.TabIndex = 1;
            this.cbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cbKategoriler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gıda Fiyatı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gıda Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gıda Kategorisi:";
            // 
            // panelAnaKategori
            // 
            this.panelAnaKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAnaKategori.BackColor = System.Drawing.Color.Transparent;
            this.panelAnaKategori.Controls.Add(this.txtKategoriId);
            this.panelAnaKategori.Controls.Add(this.txtKategoriAd);
            this.panelAnaKategori.Controls.Add(this.txtAciklama);
            this.panelAnaKategori.Controls.Add(this.label5);
            this.panelAnaKategori.Controls.Add(this.label6);
            this.panelAnaKategori.Location = new System.Drawing.Point(101, 450);
            this.panelAnaKategori.Name = "panelAnaKategori";
            this.panelAnaKategori.Size = new System.Drawing.Size(591, 311);
            this.panelAnaKategori.TabIndex = 6;
            this.panelAnaKategori.Visible = false;
            // 
            // txtKategoriId
            // 
            this.txtKategoriId.Location = new System.Drawing.Point(477, 52);
            this.txtKategoriId.Multiline = true;
            this.txtKategoriId.Name = "txtKategoriId";
            this.txtKategoriId.Size = new System.Drawing.Size(39, 45);
            this.txtKategoriId.TabIndex = 2;
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(216, 52);
            this.txtKategoriAd.Multiline = true;
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(243, 45);
            this.txtKategoriAd.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(216, 120);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(243, 45);
            this.txtAciklama.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 41);
            this.label5.TabIndex = 0;
            this.label5.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kategori Adı:";
            // 
            // rbAltKategori
            // 
            this.rbAltKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAltKategori.AutoSize = true;
            this.rbAltKategori.BackColor = System.Drawing.Color.Transparent;
            this.rbAltKategori.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbAltKategori.ForeColor = System.Drawing.Color.Red;
            this.rbAltKategori.Location = new System.Drawing.Point(830, 124);
            this.rbAltKategori.Name = "rbAltKategori";
            this.rbAltKategori.Size = new System.Drawing.Size(160, 41);
            this.rbAltKategori.TabIndex = 7;
            this.rbAltKategori.TabStop = true;
            this.rbAltKategori.Text = "Ürün Ekle";
            this.rbAltKategori.UseVisualStyleBackColor = false;
            this.rbAltKategori.CheckedChanged += new System.EventHandler(this.rbAltKategori_CheckedChanged);
            // 
            // rbAnaKategori
            // 
            this.rbAnaKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAnaKategori.AutoSize = true;
            this.rbAnaKategori.BackColor = System.Drawing.Color.Transparent;
            this.rbAnaKategori.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbAnaKategori.ForeColor = System.Drawing.Color.Red;
            this.rbAnaKategori.Location = new System.Drawing.Point(1021, 124);
            this.rbAnaKategori.Name = "rbAnaKategori";
            this.rbAnaKategori.Size = new System.Drawing.Size(299, 41);
            this.rbAnaKategori.TabIndex = 7;
            this.rbAnaKategori.TabStop = true;
            this.rbAnaKategori.Text = "Ürün Kategorisi Ekle";
            this.rbAnaKategori.UseVisualStyleBackColor = false;
            this.rbAnaKategori.CheckedChanged += new System.EventHandler(this.rbAnaKategori_CheckedChanged);
            // 
            // lblAra
            // 
            this.lblAra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAra.AutoSize = true;
            this.lblAra.BackColor = System.Drawing.Color.Transparent;
            this.lblAra.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAra.Location = new System.Drawing.Point(848, 277);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(369, 41);
            this.lblAra.TabIndex = 0;
            this.lblAra.Text = "Aramak İstediğiniz Ürün:";
            // 
            // txtAra
            // 
            this.txtAra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAra.Location = new System.Drawing.Point(848, 314);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(354, 84);
            this.txtAra.TabIndex = 2;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::restoran.Properties.Resources.cikis;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnCikis.Location = new System.Drawing.Point(1743, 767);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(150, 150);
            this.btnCikis.TabIndex = 22;
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGeriDon.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriDon.BackgroundImage = global::restoran.Properties.Resources.geri;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.FlatAppearance.BorderSize = 0;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnGeriDon.Location = new System.Drawing.Point(27, 767);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(150, 150);
            this.btnGeriDon.TabIndex = 21;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // frmMutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 920);
            this.ControlBox = false;
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.rbAnaKategori);
            this.Controls.Add(this.rbAltKategori);
            this.Controls.Add(this.panelAnaKategori);
            this.Controls.Add(this.panelUrun);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lvGidaListesi);
            this.Controls.Add(this.lvKategoriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMutfak";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMutfak_Load);
            this.panelUrun.ResumeLayout(false);
            this.panelUrun.PerformLayout();
            this.panelAnaKategori.ResumeLayout(false);
            this.panelAnaKategori.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvKategoriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvGidaListesi;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel panelUrun;
        private System.Windows.Forms.TextBox txtGidaFiyati;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.TextBox txtGidaAdi;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAnaKategori;
        private System.Windows.Forms.TextBox txtKategoriId;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbAltKategori;
        private System.Windows.Forms.RadioButton rbAnaKategori;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}