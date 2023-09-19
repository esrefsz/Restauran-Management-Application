/*
Novelty Yazılım Bilişim Teknolojileri Ltd. Şti. - www.noveltybilisim.com.tr
- Coder by Muhammed POLAT - Copyright (c) 2021 -

05.07.2021 - 06.09.2021 Tarihleri arasında yazılmış staj projesidir.

İletişim için: kurumsal@noveltybilisim.com.tr
https://www.muhammedpolat.com.tr/
info@muhammedpolat.com.tr
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace restoran
{
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            //Çıkış butonuna basıldığında ekrana uyarı verecek ve eğer evet derse kullanıcı uygulama kapanacak.
            if (MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "Dikkat !  //Coder:Eşrefhan Kadıoğlu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();//Uyarı veriyoruz eğer Evet'e basarsa kullanıcı uygulamadan çıkacak.
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Close();
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {

        }

        private void btnAnaYemekler_Click(object sender, EventArgs e)
        {
            istatistik("Anayemekler Grafiği", 3, Color.Red);
        }
        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            istatistik("İçecekler Grafiği", 8, Color.Blue);
        }
        private void btnTatlilar_Click(object sender, EventArgs e)
        {
            istatistik("Tatlılar Grafiği", 7, Color.Orange);
        }
        private void btnSalatalar_Click(object sender, EventArgs e)
        {
            istatistik("Salatalar Grafiği", 6, Color.Green);
        }
        private void btnFastFood_Click(object sender, EventArgs e)
        {
            istatistik("FastFood Grafiği", 5, Color.Yellow);
        }
        private void btnCorbalar_Click(object sender, EventArgs e)
        {
            istatistik("Çorbalar Grafiği", 1, Color.Brown);
        }
        private void btnMakarnalar_Click(object sender, EventArgs e)
        {
            istatistik("Makarnalar Grafiği", 4, Color.DarkBlue);
        }
        private void btnArasicak_Click(object sender, EventArgs e)
        {
            istatistik("Arascak Grafiği", 2, Color.LightPink);
        }
        private void istatistik(string gfName, int kategoriId, Color renk)
        {
            chRapor.Controls.Clear();
            lvIstatistik.Items.Clear();
            gbIstatistik.Text = gfName;
            chRapor.Palette = ChartColorPalette.None;
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].Color = renk;
            cUrunler u = new cUrunler();
            u.urunleriListeleIstatistiklereGoreUrunId(lvIstatistik, dtBaslangic, dtBitis, kategoriId);
            chRapor.Series["Satışlar"].Points.Clear();//Chart'ı temizliyoruz
            if (lvIstatistik.Items.Count > 0)
            {
                for (int i = 0; i < lvIstatistik.Items.Count; i++)
                {
                    chRapor.Series["Satışlar"].Points.AddXY(lvIstatistik.Items[i].SubItems[0].Text, lvIstatistik.Items[i].SubItems[1].Text);

                }
            }
            else
            {
                MessageBox.Show("Gösterilecek bir istatistik yok, lütfen farklı bir ürün/tarih seçiniz!");
            }
        }
        private void btnTumUrunler_Click(object sender, EventArgs e)
        {
            chRapor.Controls.Clear();
            lvIstatistik.Items.Clear();
            chRapor.Series["Satışlar"].Points.Clear();//Chart'ı temizliyoruz
            gbIstatistik.Text = "Tüm Ürünlerin Grafiği";
            chRapor.Palette = ChartColorPalette.None;
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].Color = Color.GreenYellow;
            cUrunler u = new cUrunler();
            u.urunleriListeleIstatistiklereGore(lvIstatistik, dtBaslangic, dtBitis);
            if (lvIstatistik.Items.Count > 0)
            {
                for (int i = 0; i < lvIstatistik.Items.Count; i++)
                {
                    chRapor.Series["Satışlar"].Points.AddXY(lvIstatistik.Items[i].SubItems[0].Text, lvIstatistik.Items[i].SubItems[1].Text);

                }
            }
            else
            {
                MessageBox.Show("Gösterilecek bir istatistik yok, lütfen farklı bir ürün/tarih seçiniz!");
            }
        }
    }
}
