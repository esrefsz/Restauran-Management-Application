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
    partial class frmSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.txtPersonelId = new System.Windows.Forms.TextBox();
            this.cbPersonel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtMevcutSifre = new System.Windows.Forms.TextBox();
            this.lvPersoneller = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBilgiDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtGorevId2 = new System.Windows.Forms.TextBox();
            this.txtPersonelId2 = new System.Windows.Forms.TextBox();
            this.cbGorevi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDegistir3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYeniSifreTekrar3 = new System.Windows.Forms.TextBox();
            this.txtYeniSifre3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnDegistir);
            this.groupBox1.Controls.Add(this.txtPersonelId);
            this.groupBox1.Controls.Add(this.cbPersonel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtYeniSifreTekrar);
            this.groupBox1.Controls.Add(this.txtYeniSifre);
            this.groupBox1.Controls.Add(this.txtMevcutSifre);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.groupBox1.Location = new System.Drawing.Point(115, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackgroundImage = global::restoran.Properties.Resources.degistir;
            this.btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegistir.Location = new System.Drawing.Point(190, 394);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(273, 84);
            this.btnDegistir.TabIndex = 3;
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // txtPersonelId
            // 
            this.txtPersonelId.Location = new System.Drawing.Point(464, 64);
            this.txtPersonelId.Name = "txtPersonelId";
            this.txtPersonelId.Size = new System.Drawing.Size(53, 47);
            this.txtPersonelId.TabIndex = 16;
            this.txtPersonelId.Text = "ID";
            // 
            // cbPersonel
            // 
            this.cbPersonel.FormattingEnabled = true;
            this.cbPersonel.Location = new System.Drawing.Point(146, 62);
            this.cbPersonel.Name = "cbPersonel";
            this.cbPersonel.Size = new System.Drawing.Size(273, 49);
            this.cbPersonel.TabIndex = 0;
            this.cbPersonel.Text = "PERSONEL";
            this.cbPersonel.SelectedIndexChanged += new System.EventHandler(this.cbPersonel_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 41);
            this.label10.TabIndex = 1;
            this.label10.Text = "Yeni Şifre Tekrar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeni Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mevcut Şifre:";
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(244, 257);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(273, 47);
            this.txtYeniSifreTekrar.TabIndex = 2;
            this.txtYeniSifreTekrar.UseSystemPasswordChar = true;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(244, 201);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(273, 47);
            this.txtYeniSifre.TabIndex = 2;
            this.txtYeniSifre.UseSystemPasswordChar = true;
            // 
            // txtMevcutSifre
            // 
            this.txtMevcutSifre.Location = new System.Drawing.Point(244, 151);
            this.txtMevcutSifre.Name = "txtMevcutSifre";
            this.txtMevcutSifre.Size = new System.Drawing.Size(273, 47);
            this.txtMevcutSifre.TabIndex = 1;
            this.txtMevcutSifre.UseSystemPasswordChar = true;
            // 
            // lvPersoneller
            // 
            this.lvPersoneller.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvPersoneller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvPersoneller.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lvPersoneller.FullRowSelect = true;
            this.lvPersoneller.GridLines = true;
            this.lvPersoneller.HideSelection = false;
            this.lvPersoneller.Location = new System.Drawing.Point(5, 13);
            this.lvPersoneller.Name = "lvPersoneller";
            this.lvPersoneller.Size = new System.Drawing.Size(642, 163);
            this.lvPersoneller.TabIndex = 17;
            this.lvPersoneller.UseCompatibleStateImageBehavior = false;
            this.lvPersoneller.View = System.Windows.Forms.View.Details;
            this.lvPersoneller.SelectedIndexChanged += new System.EventHandler(this.lvPersoneller_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Personel ID:";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Personel Gorev ID:";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Görevi:";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ad:";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Soyad:";
            this.columnHeader5.Width = 180;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnBilgiDegistir);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.btnYeni);
            this.groupBox2.Controls.Add(this.txtGorevId2);
            this.groupBox2.Controls.Add(this.txtPersonelId2);
            this.groupBox2.Controls.Add(this.cbGorevi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSoyad);
            this.groupBox2.Controls.Add(this.txtSifreTekrar);
            this.groupBox2.Controls.Add(this.txtAd);
            this.groupBox2.Controls.Add(this.txtSifre);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.groupBox2.Location = new System.Drawing.Point(660, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 482);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnBilgiDegistir
            // 
            this.btnBilgiDegistir.BackgroundImage = global::restoran.Properties.Resources.degistir;
            this.btnBilgiDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBilgiDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilgiDegistir.Location = new System.Drawing.Point(410, 371);
            this.btnBilgiDegistir.Name = "btnBilgiDegistir";
            this.btnBilgiDegistir.Size = new System.Drawing.Size(214, 93);
            this.btnBilgiDegistir.TabIndex = 12;
            this.btnBilgiDegistir.UseVisualStyleBackColor = true;
            this.btnBilgiDegistir.Click += new System.EventHandler(this.btnBilgiDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::restoran.Properties.Resources.sil;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(190, 371);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(214, 93);
            this.btnSil.TabIndex = 11;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImage = global::restoran.Properties.Resources.kaydet;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(410, 268);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(214, 97);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackgroundImage = global::restoran.Properties.Resources.yeni;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Location = new System.Drawing.Point(190, 268);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(214, 97);
            this.btnYeni.TabIndex = 9;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtGorevId2
            // 
            this.txtGorevId2.Location = new System.Drawing.Point(469, 219);
            this.txtGorevId2.Name = "txtGorevId2";
            this.txtGorevId2.Size = new System.Drawing.Size(154, 47);
            this.txtGorevId2.TabIndex = 18;
            // 
            // txtPersonelId2
            // 
            this.txtPersonelId2.Location = new System.Drawing.Point(469, 29);
            this.txtPersonelId2.Name = "txtPersonelId2";
            this.txtPersonelId2.Size = new System.Drawing.Size(154, 47);
            this.txtPersonelId2.TabIndex = 17;
            // 
            // cbGorevi
            // 
            this.cbGorevi.FormattingEnabled = true;
            this.cbGorevi.Location = new System.Drawing.Point(190, 219);
            this.cbGorevi.Name = "cbGorevi";
            this.cbGorevi.Size = new System.Drawing.Size(273, 49);
            this.cbGorevi.TabIndex = 8;
            this.cbGorevi.SelectedIndexChanged += new System.EventHandler(this.cbGorevi_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 41);
            this.label6.TabIndex = 1;
            this.label6.Text = "Soyad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 41);
            this.label7.TabIndex = 1;
            this.label7.Text = "Görevi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 41);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şifre:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(190, 75);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(273, 47);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(190, 171);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(273, 47);
            this.txtSifreTekrar.TabIndex = 7;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(190, 27);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(273, 47);
            this.txtAd.TabIndex = 4;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(190, 123);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(273, 47);
            this.txtSifre.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnDegistir3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtYeniSifreTekrar3);
            this.groupBox3.Controls.Add(this.txtYeniSifre3);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.groupBox3.Location = new System.Drawing.Point(1309, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 484);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btnDegistir3
            // 
            this.btnDegistir3.BackgroundImage = global::restoran.Properties.Resources.degistir;
            this.btnDegistir3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegistir3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegistir3.Location = new System.Drawing.Point(190, 394);
            this.btnDegistir3.Name = "btnDegistir3";
            this.btnDegistir3.Size = new System.Drawing.Size(273, 84);
            this.btnDegistir3.TabIndex = 15;
            this.btnDegistir3.UseVisualStyleBackColor = true;
            this.btnDegistir3.Click += new System.EventHandler(this.btnDegistir3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 41);
            this.label8.TabIndex = 1;
            this.label8.Text = "Yeni Şifre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 41);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mevcut Şifre:";
            // 
            // txtYeniSifreTekrar3
            // 
            this.txtYeniSifreTekrar3.Location = new System.Drawing.Point(201, 204);
            this.txtYeniSifreTekrar3.Name = "txtYeniSifreTekrar3";
            this.txtYeniSifreTekrar3.Size = new System.Drawing.Size(273, 47);
            this.txtYeniSifreTekrar3.TabIndex = 14;
            // 
            // txtYeniSifre3
            // 
            this.txtYeniSifre3.Location = new System.Drawing.Point(201, 151);
            this.txtYeniSifre3.Name = "txtYeniSifre3";
            this.txtYeniSifre3.Size = new System.Drawing.Size(273, 47);
            this.txtYeniSifre3.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.lvPersoneller);
            this.groupBox4.Location = new System.Drawing.Point(660, 698);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(656, 182);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // lblBilgi
            // 
            this.lblBilgi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.BackColor = System.Drawing.Color.Transparent;
            this.lblBilgi.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblBilgi.ForeColor = System.Drawing.Color.Red;
            this.lblBilgi.Location = new System.Drawing.Point(878, 143);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(198, 46);
            this.lblBilgi.TabIndex = 19;
            this.lblBilgi.Text = "Giriş Yapan";
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::restoran.Properties.Resources.cikis;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnCikis.Location = new System.Drawing.Point(1514, 764);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(150, 150);
            this.btnCikis.TabIndex = 20;
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
            this.btnGeriDon.Location = new System.Drawing.Point(7, 770);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(150, 150);
            this.btnGeriDon.TabIndex = 19;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 920);
            this.ControlBox = false;
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.TextBox txtPersonelId;
        private System.Windows.Forms.ComboBox cbPersonel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtMevcutSifre;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.ListView lvPersoneller;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBilgiDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtPersonelId2;
        private System.Windows.Forms.ComboBox cbGorevi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDegistir3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar3;
        private System.Windows.Forms.TextBox txtYeniSifre3;
        private System.Windows.Forms.TextBox txtGorevId2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
    }
}