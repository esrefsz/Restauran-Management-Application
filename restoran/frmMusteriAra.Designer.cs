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
    partial class frmMusteriAra
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdisyonId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnSiparisler = new System.Windows.Forms.Button();
            this.btnAdisyonBul = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic);
            this.txtAd.Location = new System.Drawing.Point(173, 199);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(300, 50);
            this.txtAd.TabIndex = 0;
            this.txtAd.Click += new System.EventHandler(this.txtAd_Click);
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(173, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Adı:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(484, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteri Soyadı:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic);
            this.txtSoyad.Location = new System.Drawing.Point(484, 199);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(300, 50);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.Click += new System.EventHandler(this.txtSoyad_Click);
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(791, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Müşteri Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic);
            this.txtTelefon.Location = new System.Drawing.Point(791, 199);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(300, 50);
            this.txtTelefon.TabIndex = 4;
            this.txtTelefon.Click += new System.EventHandler(this.txtTelefon_Click);
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1098, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adisyon ID:";
            // 
            // txtAdisyonId
            // 
            this.txtAdisyonId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdisyonId.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic);
            this.txtAdisyonId.Location = new System.Drawing.Point(1098, 199);
            this.txtAdisyonId.Multiline = true;
            this.txtAdisyonId.Name = "txtAdisyonId";
            this.txtAdisyonId.Size = new System.Drawing.Size(300, 50);
            this.txtAdisyonId.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1410, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 46);
            this.label5.TabIndex = 9;
            this.label5.Text = "Müşteri Adresi:";
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdres.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic);
            this.txtAdres.Location = new System.Drawing.Point(1410, 286);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(356, 313);
            this.txtAdres.TabIndex = 8;
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvMusteriler.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.GridLines = true;
            this.lvMusteriler.HideSelection = false;
            this.lvMusteriler.Location = new System.Drawing.Point(173, 266);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(1228, 333);
            this.lvMusteriler.TabIndex = 10;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri No:";
            this.columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı:";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı:";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon:";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres:";
            this.columnHeader5.Width = 380;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "E-Mail:";
            this.columnHeader6.Width = 180;
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYeniMusteri.BackColor = System.Drawing.Color.Transparent;
            this.btnYeniMusteri.BackgroundImage = global::restoran.Properties.Resources.yenimusteri;
            this.btnYeniMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeniMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeniMusteri.Location = new System.Drawing.Point(173, 605);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(261, 83);
            this.btnYeniMusteri.TabIndex = 11;
            this.btnYeniMusteri.UseVisualStyleBackColor = false;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMusteriSec.BackColor = System.Drawing.Color.Transparent;
            this.btnMusteriSec.BackgroundImage = global::restoran.Properties.Resources.musterisec;
            this.btnMusteriSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriSec.Location = new System.Drawing.Point(440, 605);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(261, 83);
            this.btnMusteriSec.TabIndex = 12;
            this.btnMusteriSec.UseVisualStyleBackColor = false;
            this.btnMusteriSec.Click += new System.EventHandler(this.btnMusteriSec_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMusteriGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnMusteriGuncelle.BackgroundImage = global::restoran.Properties.Resources.musteriguncelle;
            this.btnMusteriGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(708, 605);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(261, 83);
            this.btnMusteriGuncelle.TabIndex = 11;
            this.btnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnSiparisler
            // 
            this.btnSiparisler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSiparisler.BackColor = System.Drawing.Color.Transparent;
            this.btnSiparisler.BackgroundImage = global::restoran.Properties.Resources.siparisler;
            this.btnSiparisler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiparisler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiparisler.Location = new System.Drawing.Point(975, 605);
            this.btnSiparisler.Name = "btnSiparisler";
            this.btnSiparisler.Size = new System.Drawing.Size(261, 83);
            this.btnSiparisler.TabIndex = 12;
            this.btnSiparisler.UseVisualStyleBackColor = false;
            this.btnSiparisler.Click += new System.EventHandler(this.btnSiparisler_Click);
            // 
            // btnAdisyonBul
            // 
            this.btnAdisyonBul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdisyonBul.BackColor = System.Drawing.Color.Transparent;
            this.btnAdisyonBul.BackgroundImage = global::restoran.Properties.Resources.adisyonbul;
            this.btnAdisyonBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdisyonBul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdisyonBul.Location = new System.Drawing.Point(1242, 605);
            this.btnAdisyonBul.Name = "btnAdisyonBul";
            this.btnAdisyonBul.Size = new System.Drawing.Size(261, 83);
            this.btnAdisyonBul.TabIndex = 14;
            this.btnAdisyonBul.UseVisualStyleBackColor = false;
            this.btnAdisyonBul.Click += new System.EventHandler(this.btnAdisyonBul_Click);
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
            this.btnCikis.Location = new System.Drawing.Point(1616, 739);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(150, 150);
            this.btnCikis.TabIndex = 16;
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
            this.btnGeriDon.Location = new System.Drawing.Point(51, 753);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(121, 118);
            this.btnGeriDon.TabIndex = 15;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // frmMusteriAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 920);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnAdisyonBul);
            this.Controls.Add(this.btnSiparisler);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.btnMusteriSec);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdisyonId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusteriAra";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMusteriAra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdisyonId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnSiparisler;
        private System.Windows.Forms.Button btnAdisyonBul;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
    }
}