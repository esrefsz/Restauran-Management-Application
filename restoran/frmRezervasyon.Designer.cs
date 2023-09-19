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
    partial class frmRezervasyon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.cbMasa = new System.Windows.Forms.ComboBox();
            this.cbKisiSayisi = new System.Windows.Forms.ComboBox();
            this.txtMasaNo = new System.Windows.Forms.TextBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnRezervasyonKontrol = new System.Windows.Forms.Button();
            this.btnRezervasyonAc = new System.Windows.Forms.Button();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Masa Seç:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kişi Sayısı:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 398);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Açıklama:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(900, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Müşteri:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1225, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1551, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Adres:";
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.GridLines = true;
            this.lvMusteriler.HideSelection = false;
            this.lvMusteriler.Location = new System.Drawing.Point(907, 192);
            this.lvMusteriler.Margin = new System.Windows.Forms.Padding(4);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(1112, 464);
            this.lvMusteriler.TabIndex = 1;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri Np:";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad:";
            this.columnHeader2.Width = 251;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad:";
            this.columnHeader3.Width = 222;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon:";
            this.columnHeader4.Width = 173;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email:";
            this.columnHeader5.Width = 185;
            // 
            // txtTarih
            // 
            this.txtTarih.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.Location = new System.Drawing.Point(225, 231);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(4);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(247, 46);
            this.txtTarih.TabIndex = 2;
            // 
            // txtMasa
            // 
            this.txtMasa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMasa.Location = new System.Drawing.Point(225, 283);
            this.txtMasa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.ReadOnly = true;
            this.txtMasa.Size = new System.Drawing.Size(247, 46);
            this.txtMasa.TabIndex = 2;
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKisiSayisi.Location = new System.Drawing.Point(225, 337);
            this.txtKisiSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.ReadOnly = true;
            this.txtKisiSayisi.Size = new System.Drawing.Size(247, 46);
            this.txtKisiSayisi.TabIndex = 2;
            // 
            // cbMasa
            // 
            this.cbMasa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMasa.FormattingEnabled = true;
            this.cbMasa.Location = new System.Drawing.Point(481, 282);
            this.cbMasa.Margin = new System.Windows.Forms.Padding(4);
            this.cbMasa.Name = "cbMasa";
            this.cbMasa.Size = new System.Drawing.Size(250, 47);
            this.cbMasa.TabIndex = 3;
            this.cbMasa.Text = "Masa Numara";
            this.cbMasa.SelectedIndexChanged += new System.EventHandler(this.cbMasa_SelectedIndexChanged);
            // 
            // cbKisiSayisi
            // 
            this.cbKisiSayisi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbKisiSayisi.Enabled = false;
            this.cbKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKisiSayisi.FormattingEnabled = true;
            this.cbKisiSayisi.Location = new System.Drawing.Point(481, 337);
            this.cbKisiSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.cbKisiSayisi.Name = "cbKisiSayisi";
            this.cbKisiSayisi.Size = new System.Drawing.Size(250, 47);
            this.cbKisiSayisi.TabIndex = 3;
            this.cbKisiSayisi.SelectedIndexChanged += new System.EventHandler(this.cbKisiSayisi_SelectedIndexChanged);
            // 
            // txtMasaNo
            // 
            this.txtMasaNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMasaNo.Location = new System.Drawing.Point(731, 283);
            this.txtMasaNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasaNo.Name = "txtMasaNo";
            this.txtMasaNo.ReadOnly = true;
            this.txtMasaNo.Size = new System.Drawing.Size(118, 46);
            this.txtMasaNo.TabIndex = 2;
            this.txtMasaNo.Visible = false;
            // 
            // dtTarih
            // 
            this.dtTarih.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTarih.Location = new System.Drawing.Point(481, 233);
            this.dtTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(250, 46);
            this.dtTarih.TabIndex = 4;
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMusteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAd.Location = new System.Drawing.Point(908, 138);
            this.txtMusteriAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(316, 46);
            this.txtMusteriAd.TabIndex = 2;
            this.txtMusteriAd.TextChanged += new System.EventHandler(this.txtMusteriAd_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(1233, 138);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(316, 46);
            this.txtTelefon.TabIndex = 2;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(1559, 138);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(461, 46);
            this.txtAdres.TabIndex = 2;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(225, 412);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(247, 265);
            this.txtAciklama.TabIndex = 7;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::restoran.Properties.Resources.cikis;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnCikis.Location = new System.Drawing.Point(1757, 757);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(150, 150);
            this.btnCikis.TabIndex = 12;
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
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnGeriDon.Location = new System.Drawing.Point(14, 757);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(150, 150);
            this.btnGeriDon.TabIndex = 11;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMusteriGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnMusteriGuncelle.BackgroundImage = global::restoran.Properties.Resources.musteriguncelle;
            this.btnMusteriGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(1464, 727);
            this.btnMusteriGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(260, 84);
            this.btnMusteriGuncelle.TabIndex = 6;
            this.btnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnRezervasyonKontrol
            // 
            this.btnRezervasyonKontrol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRezervasyonKontrol.BackColor = System.Drawing.Color.Transparent;
            this.btnRezervasyonKontrol.BackgroundImage = global::restoran.Properties.Resources.rezervasyonlar;
            this.btnRezervasyonKontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRezervasyonKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervasyonKontrol.Location = new System.Drawing.Point(1196, 727);
            this.btnRezervasyonKontrol.Margin = new System.Windows.Forms.Padding(4);
            this.btnRezervasyonKontrol.Name = "btnRezervasyonKontrol";
            this.btnRezervasyonKontrol.Size = new System.Drawing.Size(260, 84);
            this.btnRezervasyonKontrol.TabIndex = 6;
            this.btnRezervasyonKontrol.UseVisualStyleBackColor = false;
            this.btnRezervasyonKontrol.Click += new System.EventHandler(this.btnRezervasyonKontrol_Click);
            // 
            // btnRezervasyonAc
            // 
            this.btnRezervasyonAc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRezervasyonAc.BackColor = System.Drawing.Color.Transparent;
            this.btnRezervasyonAc.BackgroundImage = global::restoran.Properties.Resources.rezervasyonac;
            this.btnRezervasyonAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRezervasyonAc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervasyonAc.Location = new System.Drawing.Point(928, 727);
            this.btnRezervasyonAc.Margin = new System.Windows.Forms.Padding(4);
            this.btnRezervasyonAc.Name = "btnRezervasyonAc";
            this.btnRezervasyonAc.Size = new System.Drawing.Size(260, 84);
            this.btnRezervasyonAc.TabIndex = 6;
            this.btnRezervasyonAc.UseVisualStyleBackColor = false;
            this.btnRezervasyonAc.Click += new System.EventHandler(this.btnRezervasyonAc_Click);
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYeniMusteri.BackColor = System.Drawing.Color.Transparent;
            this.btnYeniMusteri.BackgroundImage = global::restoran.Properties.Resources.yenimusteri;
            this.btnYeniMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeniMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeniMusteri.Location = new System.Drawing.Point(660, 727);
            this.btnYeniMusteri.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(260, 84);
            this.btnYeniMusteri.TabIndex = 6;
            this.btnYeniMusteri.UseVisualStyleBackColor = false;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 920);
            this.ControlBox = false;
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.btnRezervasyonKontrol);
            this.Controls.Add(this.btnRezervasyonAc);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.cbKisiSayisi);
            this.Controls.Add(this.cbMasa);
            this.Controls.Add(this.txtKisiSayisi);
            this.Controls.Add(this.txtMasaNo);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRezervasyon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRezervasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.TextBox txtKisiSayisi;
        private System.Windows.Forms.ComboBox cbMasa;
        private System.Windows.Forms.ComboBox cbKisiSayisi;
        private System.Windows.Forms.TextBox txtMasaNo;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        public System.Windows.Forms.Button btnYeniMusteri;
        public System.Windows.Forms.Button btnRezervasyonAc;
        public System.Windows.Forms.Button btnRezervasyonKontrol;
        public System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
    }
}