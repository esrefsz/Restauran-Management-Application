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
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIndirim = new System.Windows.Forms.CheckBox();
            this.gbIndirim = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIndirimTutari = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblOdenecek = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblKdv = new System.Windows.Forms.Label();
            this.lblIndirim = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbTicket = new System.Windows.Forms.RadioButton();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAdisyonId = new System.Windows.Forms.Label();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.btnHesapOzeti = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbIndirim.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkIndirim);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(1342, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Özel İndirim";
            // 
            // chkIndirim
            // 
            this.chkIndirim.AutoSize = true;
            this.chkIndirim.Location = new System.Drawing.Point(6, 68);
            this.chkIndirim.Name = "chkIndirim";
            this.chkIndirim.Size = new System.Drawing.Size(252, 45);
            this.chkIndirim.TabIndex = 0;
            this.chkIndirim.Text = "İndirim Uygula";
            this.chkIndirim.UseVisualStyleBackColor = true;
            this.chkIndirim.CheckedChanged += new System.EventHandler(this.chkIndirim_CheckedChanged);
            // 
            // gbIndirim
            // 
            this.gbIndirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbIndirim.BackColor = System.Drawing.Color.Transparent;
            this.gbIndirim.Controls.Add(this.label10);
            this.gbIndirim.Controls.Add(this.txtIndirimTutari);
            this.gbIndirim.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gbIndirim.Location = new System.Drawing.Point(1621, 50);
            this.gbIndirim.Name = "gbIndirim";
            this.gbIndirim.Size = new System.Drawing.Size(307, 156);
            this.gbIndirim.TabIndex = 1;
            this.gbIndirim.TabStop = false;
            this.gbIndirim.Text = "Özel İndirim";
            this.gbIndirim.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(6, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(314, 37);
            this.label10.TabIndex = 12;
            this.label10.Text = "İndirim Tutarını Giriniz:";
            // 
            // txtIndirimTutari
            // 
            this.txtIndirimTutari.Location = new System.Drawing.Point(16, 81);
            this.txtIndirimTutari.Name = "txtIndirimTutari";
            this.txtIndirimTutari.Size = new System.Drawing.Size(225, 47);
            this.txtIndirimTutari.TabIndex = 0;
            this.txtIndirimTutari.TextChanged += new System.EventHandler(this.txtIndirimTutari_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblOdenecek);
            this.groupBox3.Controls.Add(this.lblToplamTutar);
            this.groupBox3.Controls.Add(this.lblKdv);
            this.groupBox3.Controls.Add(this.lblIndirim);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(1342, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 236);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Özel İndirim";
            // 
            // lblOdenecek
            // 
            this.lblOdenecek.AutoSize = true;
            this.lblOdenecek.Location = new System.Drawing.Point(189, 191);
            this.lblOdenecek.Name = "lblOdenecek";
            this.lblOdenecek.Size = new System.Drawing.Size(35, 41);
            this.lblOdenecek.TabIndex = 11;
            this.lblOdenecek.Text = "0";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(189, 121);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(35, 41);
            this.lblToplamTutar.TabIndex = 10;
            this.lblToplamTutar.Text = "0";
            // 
            // lblKdv
            // 
            this.lblKdv.AutoSize = true;
            this.lblKdv.Location = new System.Drawing.Point(189, 78);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(35, 41);
            this.lblKdv.TabIndex = 9;
            this.lblKdv.Text = "0";
            // 
            // lblIndirim
            // 
            this.lblIndirim.AutoSize = true;
            this.lblIndirim.Location = new System.Drawing.Point(189, 35);
            this.lblIndirim.Name = "lblIndirim";
            this.lblIndirim.Size = new System.Drawing.Size(35, 41);
            this.lblIndirim.TabIndex = 8;
            this.lblIndirim.Text = "0";
            this.lblIndirim.TextChanged += new System.EventHandler(this.lblIndirim_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 41);
            this.label5.TabIndex = 7;
            this.label5.Text = "₺";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 41);
            this.label6.TabIndex = 6;
            this.label6.Text = "₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 41);
            this.label7.TabIndex = 5;
            this.label7.Text = "₺";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 41);
            this.label8.TabIndex = 4;
            this.label8.Text = "₺";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ara Toplam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "KDV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "İndirim:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rbTicket);
            this.groupBox4.Controls.Add(this.rbKrediKarti);
            this.groupBox4.Controls.Add(this.rbNakit);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(1755, 327);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 236);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ödeme";
            // 
            // rbTicket
            // 
            this.rbTicket.AutoSize = true;
            this.rbTicket.Location = new System.Drawing.Point(7, 188);
            this.rbTicket.Name = "rbTicket";
            this.rbTicket.Size = new System.Drawing.Size(125, 45);
            this.rbTicket.TabIndex = 2;
            this.rbTicket.TabStop = true;
            this.rbTicket.Text = "Ticket";
            this.rbTicket.UseVisualStyleBackColor = true;
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Location = new System.Drawing.Point(7, 129);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(191, 45);
            this.rbKrediKarti.TabIndex = 1;
            this.rbKrediKarti.TabStop = true;
            this.rbKrediKarti.Text = "Kredi Kartı";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(7, 60);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(117, 45);
            this.rbNakit.TabIndex = 0;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label9.Location = new System.Drawing.Point(12, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 41);
            this.label9.TabIndex = 12;
            this.label9.Text = "Adisyon ID:";
            // 
            // lblAdisyonId
            // 
            this.lblAdisyonId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdisyonId.AutoSize = true;
            this.lblAdisyonId.BackColor = System.Drawing.Color.Transparent;
            this.lblAdisyonId.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAdisyonId.ForeColor = System.Drawing.Color.Red;
            this.lblAdisyonId.Location = new System.Drawing.Point(235, 201);
            this.lblAdisyonId.Name = "lblAdisyonId";
            this.lblAdisyonId.Size = new System.Drawing.Size(50, 41);
            this.lblAdisyonId.TabIndex = 17;
            this.lblAdisyonId.Text = "ID";
            // 
            // lvUrunler
            // 
            this.lvUrunler.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvUrunler.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lvUrunler.HideSelection = false;
            this.lvUrunler.Location = new System.Drawing.Point(19, 256);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(757, 402);
            this.lvUrunler.TabIndex = 18;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı:";
            this.columnHeader1.Width = 284;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet:";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün ID:";
            this.columnHeader3.Width = 153;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat:";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Satış ID:";
            this.columnHeader5.Width = 130;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHesapKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHesapKapat.BackgroundImage = global::restoran.Properties.Resources.hesap_kapat;
            this.btnHesapKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHesapKapat.Location = new System.Drawing.Point(1621, 686);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(195, 87);
            this.btnHesapKapat.TabIndex = 16;
            this.btnHesapKapat.UseVisualStyleBackColor = false;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // btnHesapOzeti
            // 
            this.btnHesapOzeti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHesapOzeti.BackColor = System.Drawing.Color.GreenYellow;
            this.btnHesapOzeti.BackgroundImage = global::restoran.Properties.Resources.hesap_özeti;
            this.btnHesapOzeti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapOzeti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHesapOzeti.Location = new System.Drawing.Point(1372, 686);
            this.btnHesapOzeti.Name = "btnHesapOzeti";
            this.btnHesapOzeti.Size = new System.Drawing.Size(194, 87);
            this.btnHesapOzeti.TabIndex = 15;
            this.btnHesapOzeti.UseVisualStyleBackColor = false;
            this.btnHesapOzeti.Click += new System.EventHandler(this.btnHesapOzeti_Click);
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
            this.btnCikis.Location = new System.Drawing.Point(1149, 772);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(123, 124);
            this.btnCikis.TabIndex = 14;
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
            this.btnGeriDon.Location = new System.Drawing.Point(12, 756);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(150, 150);
            this.btnGeriDon.TabIndex = 13;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // frmBill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 920);
            this.ControlBox = false;
            this.Controls.Add(this.lvUrunler);
            this.Controls.Add(this.lblAdisyonId);
            this.Controls.Add(this.btnHesapKapat);
            this.Controls.Add(this.btnHesapOzeti);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbIndirim);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBill";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbIndirim.ResumeLayout(false);
            this.gbIndirim.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIndirim;
        private System.Windows.Forms.GroupBox gbIndirim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblOdenecek;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblKdv;
        private System.Windows.Forms.Label lblIndirim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbTicket;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHesapOzeti;
        private System.Windows.Forms.Button btnHesapKapat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIndirimTutari;
        private System.Windows.Forms.Label lblAdisyonId;
        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}