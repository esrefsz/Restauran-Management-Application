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
    partial class frmRaporlar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.grpMenuBaslik = new System.Windows.Forms.GroupBox();
            this.btnArasicak = new System.Windows.Forms.Button();
            this.btnAnaYemekler = new System.Windows.Forms.Button();
            this.btnSalatalar = new System.Windows.Forms.Button();
            this.btnTatlilar = new System.Windows.Forms.Button();
            this.btnCorbalar = new System.Windows.Forms.Button();
            this.btnFastFood = new System.Windows.Forms.Button();
            this.btnIcecekler = new System.Windows.Forms.Button();
            this.btnMakarnalar = new System.Windows.Forms.Button();
            this.gbIstatistik = new System.Windows.Forms.GroupBox();
            this.lvIstatistik = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRapor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnTumUrunler = new System.Windows.Forms.Button();
            this.grpMenuBaslik.SuspendLayout();
            this.gbIstatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1016, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1140, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "BitişTarihi:";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtBaslangic.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Location = new System.Drawing.Point(1418, 30);
            this.dtBaslangic.Margin = new System.Windows.Forms.Padding(4);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(509, 41);
            this.dtBaslangic.TabIndex = 1;
            // 
            // dtBitis
            // 
            this.dtBitis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtBitis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Location = new System.Drawing.Point(1418, 110);
            this.dtBitis.Margin = new System.Windows.Forms.Padding(4);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(509, 41);
            this.dtBitis.TabIndex = 1;
            // 
            // grpMenuBaslik
            // 
            this.grpMenuBaslik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpMenuBaslik.BackColor = System.Drawing.Color.Transparent;
            this.grpMenuBaslik.Controls.Add(this.btnArasicak);
            this.grpMenuBaslik.Controls.Add(this.btnAnaYemekler);
            this.grpMenuBaslik.Controls.Add(this.btnSalatalar);
            this.grpMenuBaslik.Controls.Add(this.btnTatlilar);
            this.grpMenuBaslik.Controls.Add(this.btnCorbalar);
            this.grpMenuBaslik.Controls.Add(this.btnFastFood);
            this.grpMenuBaslik.Controls.Add(this.btnIcecekler);
            this.grpMenuBaslik.Controls.Add(this.btnMakarnalar);
            this.grpMenuBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMenuBaslik.Location = new System.Drawing.Point(12, 110);
            this.grpMenuBaslik.Margin = new System.Windows.Forms.Padding(4);
            this.grpMenuBaslik.Name = "grpMenuBaslik";
            this.grpMenuBaslik.Padding = new System.Windows.Forms.Padding(4);
            this.grpMenuBaslik.Size = new System.Drawing.Size(456, 630);
            this.grpMenuBaslik.TabIndex = 2;
            this.grpMenuBaslik.TabStop = false;
            this.grpMenuBaslik.Text = "Menü";
            // 
            // btnArasicak
            // 
            this.btnArasicak.BackgroundImage = global::restoran.Properties.Resources.arasicak;
            this.btnArasicak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArasicak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArasicak.Location = new System.Drawing.Point(235, 484);
            this.btnArasicak.Margin = new System.Windows.Forms.Padding(4);
            this.btnArasicak.Name = "btnArasicak";
            this.btnArasicak.Size = new System.Drawing.Size(211, 139);
            this.btnArasicak.TabIndex = 1;
            this.btnArasicak.UseVisualStyleBackColor = true;
            this.btnArasicak.Click += new System.EventHandler(this.btnArasicak_Click);
            // 
            // btnAnaYemekler
            // 
            this.btnAnaYemekler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnaYemekler.BackgroundImage = global::restoran.Properties.Resources.anayemek;
            this.btnAnaYemekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaYemekler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnaYemekler.Location = new System.Drawing.Point(8, 47);
            this.btnAnaYemekler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnaYemekler.Name = "btnAnaYemekler";
            this.btnAnaYemekler.Size = new System.Drawing.Size(211, 139);
            this.btnAnaYemekler.TabIndex = 2;
            this.btnAnaYemekler.UseVisualStyleBackColor = false;
            this.btnAnaYemekler.Click += new System.EventHandler(this.btnAnaYemekler_Click);
            // 
            // btnSalatalar
            // 
            this.btnSalatalar.BackgroundImage = global::restoran.Properties.Resources.salata;
            this.btnSalatalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalatalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalatalar.Location = new System.Drawing.Point(235, 192);
            this.btnSalatalar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalatalar.Name = "btnSalatalar";
            this.btnSalatalar.Size = new System.Drawing.Size(211, 139);
            this.btnSalatalar.TabIndex = 3;
            this.btnSalatalar.UseVisualStyleBackColor = true;
            this.btnSalatalar.Click += new System.EventHandler(this.btnSalatalar_Click);
            // 
            // btnTatlilar
            // 
            this.btnTatlilar.BackgroundImage = global::restoran.Properties.Resources.tatli;
            this.btnTatlilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTatlilar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTatlilar.Location = new System.Drawing.Point(8, 192);
            this.btnTatlilar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTatlilar.Name = "btnTatlilar";
            this.btnTatlilar.Size = new System.Drawing.Size(211, 139);
            this.btnTatlilar.TabIndex = 4;
            this.btnTatlilar.UseVisualStyleBackColor = true;
            this.btnTatlilar.Click += new System.EventHandler(this.btnTatlilar_Click);
            // 
            // btnCorbalar
            // 
            this.btnCorbalar.BackgroundImage = global::restoran.Properties.Resources.corbalar;
            this.btnCorbalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorbalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorbalar.Location = new System.Drawing.Point(235, 338);
            this.btnCorbalar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCorbalar.Name = "btnCorbalar";
            this.btnCorbalar.Size = new System.Drawing.Size(211, 139);
            this.btnCorbalar.TabIndex = 5;
            this.btnCorbalar.UseVisualStyleBackColor = true;
            this.btnCorbalar.Click += new System.EventHandler(this.btnCorbalar_Click);
            // 
            // btnFastFood
            // 
            this.btnFastFood.BackgroundImage = global::restoran.Properties.Resources.fastfood;
            this.btnFastFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFastFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFastFood.Location = new System.Drawing.Point(8, 338);
            this.btnFastFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnFastFood.Name = "btnFastFood";
            this.btnFastFood.Size = new System.Drawing.Size(211, 139);
            this.btnFastFood.TabIndex = 6;
            this.btnFastFood.UseVisualStyleBackColor = true;
            this.btnFastFood.Click += new System.EventHandler(this.btnFastFood_Click);
            // 
            // btnIcecekler
            // 
            this.btnIcecekler.BackgroundImage = global::restoran.Properties.Resources.icecekler;
            this.btnIcecekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIcecekler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIcecekler.Location = new System.Drawing.Point(235, 46);
            this.btnIcecekler.Margin = new System.Windows.Forms.Padding(4);
            this.btnIcecekler.Name = "btnIcecekler";
            this.btnIcecekler.Size = new System.Drawing.Size(211, 139);
            this.btnIcecekler.TabIndex = 7;
            this.btnIcecekler.UseVisualStyleBackColor = true;
            this.btnIcecekler.Click += new System.EventHandler(this.btnIcecekler_Click);
            // 
            // btnMakarnalar
            // 
            this.btnMakarnalar.BackgroundImage = global::restoran.Properties.Resources.makarna;
            this.btnMakarnalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMakarnalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakarnalar.Location = new System.Drawing.Point(8, 485);
            this.btnMakarnalar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakarnalar.Name = "btnMakarnalar";
            this.btnMakarnalar.Size = new System.Drawing.Size(211, 139);
            this.btnMakarnalar.TabIndex = 8;
            this.btnMakarnalar.UseVisualStyleBackColor = true;
            this.btnMakarnalar.Click += new System.EventHandler(this.btnMakarnalar_Click);
            // 
            // gbIstatistik
            // 
            this.gbIstatistik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbIstatistik.BackColor = System.Drawing.Color.Transparent;
            this.gbIstatistik.Controls.Add(this.lvIstatistik);
            this.gbIstatistik.Controls.Add(this.chRapor);
            this.gbIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbIstatistik.Location = new System.Drawing.Point(756, 156);
            this.gbIstatistik.Margin = new System.Windows.Forms.Padding(4);
            this.gbIstatistik.Name = "gbIstatistik";
            this.gbIstatistik.Padding = new System.Windows.Forms.Padding(4);
            this.gbIstatistik.Size = new System.Drawing.Size(1401, 630);
            this.gbIstatistik.TabIndex = 2;
            this.gbIstatistik.TabStop = false;
            // 
            // lvIstatistik
            // 
            this.lvIstatistik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvIstatistik.HideSelection = false;
            this.lvIstatistik.Location = new System.Drawing.Point(1376, 38);
            this.lvIstatistik.Margin = new System.Windows.Forms.Padding(4);
            this.lvIstatistik.Name = "lvIstatistik";
            this.lvIstatistik.Size = new System.Drawing.Size(16, 29);
            this.lvIstatistik.TabIndex = 1;
            this.lvIstatistik.UseCompatibleStateImageBehavior = false;
            this.lvIstatistik.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı:";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet:";
            // 
            // chRapor
            // 
            this.chRapor.BackColor = System.Drawing.Color.Transparent;
            this.chRapor.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chRapor.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chRapor.Legends.Add(legend2);
            this.chRapor.Location = new System.Drawing.Point(8, 75);
            this.chRapor.Margin = new System.Windows.Forms.Padding(4);
            this.chRapor.Name = "chRapor";
            series2.ChartArea = "ChartArea1";
            series2.Label = "#LEGENDTEXT";
            series2.Legend = "Legend1";
            series2.Name = "Satışlar";
            this.chRapor.Series.Add(series2);
            this.chRapor.Size = new System.Drawing.Size(1385, 548);
            this.chRapor.TabIndex = 0;
            this.chRapor.Text = "chart1";
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
            this.btnCikis.Location = new System.Drawing.Point(1706, 793);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(150, 150);
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
            this.btnGeriDon.Location = new System.Drawing.Point(24, 793);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(131, 112);
            this.btnGeriDon.TabIndex = 13;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnTumUrunler
            // 
            this.btnTumUrunler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTumUrunler.BackColor = System.Drawing.Color.Transparent;
            this.btnTumUrunler.BackgroundImage = global::restoran.Properties.Resources.tumurunler;
            this.btnTumUrunler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTumUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTumUrunler.Location = new System.Drawing.Point(491, 693);
            this.btnTumUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.btnTumUrunler.Name = "btnTumUrunler";
            this.btnTumUrunler.Size = new System.Drawing.Size(257, 118);
            this.btnTumUrunler.TabIndex = 3;
            this.btnTumUrunler.UseVisualStyleBackColor = false;
            this.btnTumUrunler.Click += new System.EventHandler(this.btnTumUrunler_Click);
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 920);
            this.ControlBox = false;
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnTumUrunler);
            this.Controls.Add(this.gbIstatistik);
            this.Controls.Add(this.grpMenuBaslik);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRaporlar";
            this.Text = "frmRaporlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRaporlar_Load);
            this.grpMenuBaslik.ResumeLayout(false);
            this.gbIstatistik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.GroupBox grpMenuBaslik;
        private System.Windows.Forms.GroupBox gbIstatistik;
        private System.Windows.Forms.Button btnArasicak;
        private System.Windows.Forms.Button btnAnaYemekler;
        private System.Windows.Forms.Button btnSalatalar;
        private System.Windows.Forms.Button btnTatlilar;
        private System.Windows.Forms.Button btnCorbalar;
        private System.Windows.Forms.Button btnFastFood;
        private System.Windows.Forms.Button btnIcecekler;
        private System.Windows.Forms.Button btnMakarnalar;
        private System.Windows.Forms.ListView lvIstatistik;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chRapor;
        private System.Windows.Forms.Button btnTumUrunler;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
    }
}