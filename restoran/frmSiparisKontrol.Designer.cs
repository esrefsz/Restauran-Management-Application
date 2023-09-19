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
    partial class frmSiparisKontrol
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
            this.lvMusteriDetaylari = new System.Windows.Forms.ListView();
            this.MusteriId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MusteriAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Musterisoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdisyonId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSatisDetaylari = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamSiparis = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.lblSonSiparisTarihi = new System.Windows.Forms.Label();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvMusteriDetaylari
            // 
            this.lvMusteriDetaylari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvMusteriDetaylari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MusteriId,
            this.MusteriAd,
            this.Musterisoyad,
            this.Tarih,
            this.AdisyonId});
            this.lvMusteriDetaylari.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lvMusteriDetaylari.FullRowSelect = true;
            this.lvMusteriDetaylari.HideSelection = false;
            this.lvMusteriDetaylari.Location = new System.Drawing.Point(524, 86);
            this.lvMusteriDetaylari.Name = "lvMusteriDetaylari";
            this.lvMusteriDetaylari.Size = new System.Drawing.Size(769, 520);
            this.lvMusteriDetaylari.TabIndex = 0;
            this.lvMusteriDetaylari.UseCompatibleStateImageBehavior = false;
            this.lvMusteriDetaylari.View = System.Windows.Forms.View.Details;
            this.lvMusteriDetaylari.SelectedIndexChanged += new System.EventHandler(this.lvMusteriDetaylari_SelectedIndexChanged);
            // 
            // MusteriId
            // 
            this.MusteriId.Text = "Musteri ID:";
            this.MusteriId.Width = 0;
            // 
            // MusteriAd
            // 
            this.MusteriAd.Text = "MÜŞTERİ ADI";
            this.MusteriAd.Width = 198;
            // 
            // Musterisoyad
            // 
            this.Musterisoyad.Text = "MÜŞTERİ SOYADI";
            this.Musterisoyad.Width = 186;
            // 
            // Tarih
            // 
            this.Tarih.Text = "TARİH";
            this.Tarih.Width = 153;
            // 
            // AdisyonId
            // 
            this.AdisyonId.Text = "Ald:";
            this.AdisyonId.Width = 0;
            // 
            // lvSatisDetaylari
            // 
            this.lvSatisDetaylari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvSatisDetaylari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvSatisDetaylari.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lvSatisDetaylari.FullRowSelect = true;
            this.lvSatisDetaylari.GridLines = true;
            this.lvSatisDetaylari.HideSelection = false;
            this.lvSatisDetaylari.Location = new System.Drawing.Point(1357, 86);
            this.lvSatisDetaylari.Name = "lvSatisDetaylari";
            this.lvSatisDetaylari.Size = new System.Drawing.Size(452, 520);
            this.lvSatisDetaylari.TabIndex = 1;
            this.lvSatisDetaylari.UseCompatibleStateImageBehavior = false;
            this.lvSatisDetaylari.View = System.Windows.Forms.View.Details;
            this.lvSatisDetaylari.SelectedIndexChanged += new System.EventHandler(this.lvSatisDetaylari_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Satış ID:";
            this.columnHeader6.Width = 132;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ürün Adı:";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Adet:";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Fiyat:";
            this.columnHeader9.Width = 130;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtToplamTutar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtToplamTutar.Location = new System.Drawing.Point(1016, 612);
            this.txtToplamTutar.Multiline = true;
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(277, 55);
            this.txtToplamTutar.TabIndex = 2;
            this.txtToplamTutar.Text = "______";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(837, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toplam Adet: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1050, 689);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1050, 734);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Genel Toplam:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1050, 773);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "En Son Sipariş:";
            // 
            // lblToplamSiparis
            // 
            this.lblToplamSiparis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToplamSiparis.AutoSize = true;
            this.lblToplamSiparis.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamSiparis.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblToplamSiparis.Location = new System.Drawing.Point(1335, 689);
            this.lblToplamSiparis.Name = "lblToplamSiparis";
            this.lblToplamSiparis.Size = new System.Drawing.Size(84, 32);
            this.lblToplamSiparis.TabIndex = 3;
            this.lblToplamSiparis.Text = "_______";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblGenelToplam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblGenelToplam.ForeColor = System.Drawing.Color.Red;
            this.lblGenelToplam.Location = new System.Drawing.Point(1335, 734);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(94, 32);
            this.lblGenelToplam.TabIndex = 3;
            this.lblGenelToplam.Text = "________";
            // 
            // lblSonSiparisTarihi
            // 
            this.lblSonSiparisTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSonSiparisTarihi.AutoSize = true;
            this.lblSonSiparisTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblSonSiparisTarihi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSonSiparisTarihi.Location = new System.Drawing.Point(1335, 773);
            this.lblSonSiparisTarihi.Name = "lblSonSiparisTarihi";
            this.lblSonSiparisTarihi.Size = new System.Drawing.Size(64, 32);
            this.lblSonSiparisTarihi.TabIndex = 3;
            this.lblSonSiparisTarihi.Text = "_____";
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvMusteriler.GridLines = true;
            this.lvMusteriler.HideSelection = false;
            this.lvMusteriler.Location = new System.Drawing.Point(1579, 635);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(210, 195);
            this.lvMusteriler.TabIndex = 4;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.Visible = false;
            this.lvMusteriler.SelectedIndexChanged += new System.EventHandler(this.lvMusteriler_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Müşteri ID:";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Müşteri:";
            this.columnHeader11.Width = 59;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "AdisyonID:";
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::restoran.Properties.Resources.cikis;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnCikis.Location = new System.Drawing.Point(225, 754);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 100);
            this.btnCikis.TabIndex = 18;
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
            this.btnGeriDon.Location = new System.Drawing.Point(24, 754);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(150, 150);
            this.btnGeriDon.TabIndex = 17;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // frmSiparisKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 920);
            this.ControlBox = false;
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.lblSonSiparisTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.lblToplamSiparis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.lvSatisDetaylari);
            this.Controls.Add(this.lvMusteriDetaylari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSiparisKontrol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSiparisKontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMusteriDetaylari;
        private System.Windows.Forms.ColumnHeader MusteriId;
        private System.Windows.Forms.ColumnHeader MusteriAd;
        private System.Windows.Forms.ColumnHeader Musterisoyad;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ColumnHeader AdisyonId;
        private System.Windows.Forms.ListView lvSatisDetaylari;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamSiparis;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label lblSonSiparisTarihi;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
    }
}