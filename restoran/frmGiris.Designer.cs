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
    partial class frmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbKullanici = new System.Windows.Forms.ComboBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKullanici
            // 
            this.cbKullanici.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbKullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbKullanici.FormattingEnabled = true;
            this.cbKullanici.Location = new System.Drawing.Point(1547, 456);
            this.cbKullanici.Name = "cbKullanici";
            this.cbKullanici.Size = new System.Drawing.Size(280, 37);
            this.cbKullanici.TabIndex = 0;
            this.cbKullanici.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSifre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtSifre.Location = new System.Drawing.Point(1547, 513);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(280, 30);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1350, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1439, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.BackgroundImage = global::restoran.Properties.Resources.Apolet_logo;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1586, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 197);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCikis.BackColor = System.Drawing.Color.Teal;
            this.btnCikis.BackgroundImage = global::restoran.Properties.Resources.Varlık_5;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ForeColor = System.Drawing.Color.Teal;
            this.btnCikis.Location = new System.Drawing.Point(1694, 599);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(134, 52);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGiris.BackColor = System.Drawing.Color.Teal;
            this.btnGiris.BackgroundImage = global::restoran.Properties.Resources.Varlık_1;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.ForeColor = System.Drawing.Color.Teal;
            this.btnGiris.Location = new System.Drawing.Point(1547, 599);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(135, 52);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::restoran.Properties.Resources.EnterangeBackground1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 920);
            this.Controls.Add(this.cbKullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili Girişi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

