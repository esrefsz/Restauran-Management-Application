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
    partial class frmKasaIslemleri
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTableAylikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReport = new restoran.DataSetReport();
            this.dataTableGunlukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rpvAylik = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvGunluk = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnZRaporu = new System.Windows.Forms.Button();
            this.btnAylikRapor = new System.Windows.Forms.Button();
            this.dataTableGunlukTableAdapter = new restoran.DataSetReportTableAdapters.DataTableGunlukTableAdapter();
            this.dataTableAylikTableAdapter = new restoran.DataSetReportTableAdapters.DataTableAylikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAylikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableGunlukBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableAylikBindingSource
            // 
            this.dataTableAylikBindingSource.DataMember = "DataTableAylik";
            this.dataTableAylikBindingSource.DataSource = this.dataSetReport;
            // 
            // dataSetReport
            // 
            this.dataSetReport.DataSetName = "DataSetReport";
            this.dataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableGunlukBindingSource
            // 
            this.dataTableGunlukBindingSource.DataMember = "DataTableGunluk";
            this.dataTableGunlukBindingSource.DataSource = this.dataSetReport;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(873, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "AYLIK RAPOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rpvAylik
            // 
            this.rpvAylik.Anchor = System.Windows.Forms.AnchorStyles.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTableAylikBindingSource;
            this.rpvAylik.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvAylik.LocalReport.ReportEmbeddedResource = "restoran.ReportAylik.rdlc";
            this.rpvAylik.Location = new System.Drawing.Point(417, 257);
            this.rpvAylik.Margin = new System.Windows.Forms.Padding(4);
            this.rpvAylik.Name = "rpvAylik";
            this.rpvAylik.ServerReport.BearerToken = null;
            this.rpvAylik.Size = new System.Drawing.Size(1307, 530);
            this.rpvAylik.TabIndex = 1;
            this.rpvAylik.Load += new System.EventHandler(this.rpvAylik_Load);
            // 
            // rpvGunluk
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dataTableGunlukBindingSource;
            this.rpvGunluk.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvGunluk.LocalReport.ReportEmbeddedResource = "restoran.ReportGunluk.rdlc";
            this.rpvGunluk.Location = new System.Drawing.Point(407, 302);
            this.rpvGunluk.Margin = new System.Windows.Forms.Padding(4);
            this.rpvGunluk.Name = "rpvGunluk";
            this.rpvGunluk.ServerReport.BearerToken = null;
            this.rpvGunluk.Size = new System.Drawing.Size(1317, 530);
            this.rpvGunluk.TabIndex = 3;
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
            this.btnCikis.Location = new System.Drawing.Point(1749, 757);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(144, 150);
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
            this.btnGeriDon.Location = new System.Drawing.Point(32, 757);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(150, 150);
            this.btnGeriDon.TabIndex = 15;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnZRaporu
            // 
            this.btnZRaporu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZRaporu.BackColor = System.Drawing.Color.Transparent;
            this.btnZRaporu.BackgroundImage = global::restoran.Properties.Resources.zraporu;
            this.btnZRaporu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZRaporu.Location = new System.Drawing.Point(42, 470);
            this.btnZRaporu.Margin = new System.Windows.Forms.Padding(4);
            this.btnZRaporu.Name = "btnZRaporu";
            this.btnZRaporu.Size = new System.Drawing.Size(300, 120);
            this.btnZRaporu.TabIndex = 0;
            this.btnZRaporu.UseVisualStyleBackColor = false;
            this.btnZRaporu.Click += new System.EventHandler(this.btnZRaporu_Click);
            // 
            // btnAylikRapor
            // 
            this.btnAylikRapor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAylikRapor.BackColor = System.Drawing.Color.Transparent;
            this.btnAylikRapor.BackgroundImage = global::restoran.Properties.Resources.aylikrapor;
            this.btnAylikRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAylikRapor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAylikRapor.Location = new System.Drawing.Point(42, 302);
            this.btnAylikRapor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAylikRapor.Name = "btnAylikRapor";
            this.btnAylikRapor.Size = new System.Drawing.Size(300, 120);
            this.btnAylikRapor.TabIndex = 0;
            this.btnAylikRapor.UseVisualStyleBackColor = false;
            this.btnAylikRapor.Click += new System.EventHandler(this.btnAylikRapor_Click);
            // 
            // dataTableGunlukTableAdapter
            // 
            this.dataTableGunlukTableAdapter.ClearBeforeFill = true;
            // 
            // dataTableAylikTableAdapter
            // 
            this.dataTableAylikTableAdapter.ClearBeforeFill = true;
            // 
            // frmKasaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 920);
            this.Controls.Add(this.rpvGunluk);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpvAylik);
            this.Controls.Add(this.btnZRaporu);
            this.Controls.Add(this.btnAylikRapor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKasaIslemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKasaIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAylikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableGunlukBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAylikRapor;
        private System.Windows.Forms.Button btnZRaporu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private Microsoft.Reporting.WinForms.ReportViewer rpvAylik;
        private Microsoft.Reporting.WinForms.ReportViewer rpvGunluk;
        private DataSetReport dataSetReport;
        private System.Windows.Forms.BindingSource dataTableGunlukBindingSource;
        private DataSetReportTableAdapters.DataTableGunlukTableAdapter dataTableGunlukTableAdapter;
        private System.Windows.Forms.BindingSource dataTableAylikBindingSource;
        private DataSetReportTableAdapters.DataTableAylikTableAdapter dataTableAylikTableAdapter;
    }
}