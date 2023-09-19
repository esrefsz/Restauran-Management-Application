/*
Novelty Yazılım Bilişim Teknolojileri Ltd. Şti. - www.noveltybilisim.com.tr
- Coder by Muhammed POLAT - Copyright (c) 2021 -

05.07.2021 - 06.09.2021 Tarihleri arasında yazılmış staj projesidir.

İletişim için: kurumsal@noveltybilisim.com.tr
https://www.muhammedpolat.com.tr/
info@muhammedpolat.com.tr
*/
using System;
using System.Windows.Forms;

namespace restoran
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMasaSiparis_Click(object sender, EventArgs e)
        {
            //Masalar butonuna tıklandığında menü ekranı kapansın ve masalar formu ekranı gelsin.
            frmMasalar frm = new frmMasalar();
            frm.Show();
            this.Close();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            //Rezervasyon butonuna tıklandığında menü ekranı kapansın ve rezervasyon ekranı gelsin.
            frmRezervasyon frm = new frmRezervasyon();
            frm.Show();
            this.Close();
        }

        private void btnPaketServis_Click(object sender, EventArgs e)
        {
            //Sipariş butonuna tıklandığında menü ekranı kapansın ve paket sipariş ekranı gelsin.
            frmPaketSiparis frm = new frmPaketSiparis();
            frm.Show();
            this.Close();

        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            //Müşteriler butonuna tıklandığında menü ekranı kapansın ve müşteriler ekranı gelsin.
            frmMusteriAra frm = new frmMusteriAra();
            frm.Show();
            this.Close();
        }

        private void btnKasaIslemleri_Click(object sender, EventArgs e)
        {
            //Kasa butonuna tıklandığında menü ekranı kapansın ve kasa ekranı gelsin.
            frmKasaIslemleri frm = new frmKasaIslemleri();
            frm.Show();
            this.Close();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            //Mutfak butonuna tıklandığında menü ekranı kapansın ve mutfak ekranı gelsin.
            frmMutfak frm = new frmMutfak();
            frm.Show();
            this.Close();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            //Raporlar butonuna tıklandığında menü ekranı kapansın ve raporlar ekranı gelsin.
            frmRaporlar frm = new frmRaporlar();
            frm.Show();
            this.Close();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            //Ayarlar butonuna tıklandığında menü ekranı kapansın ve ayarlar ekranı gelsin.
            frmSetting frm = new frmSetting();
            frm.Show();
            this.Close();
        }

        private void btnKilit_Click(object sender, EventArgs e)
        {
            //Kilit butonuna tıklandığında menü ekranı kapansın ve kilit ekranı gelsin.
            frmLock frm = new frmLock();
            frm.Show();
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            //Çıkış butonuna basıldığında ekrana uyarı verecek ve eğer evet derse kullanıcı uygulama kapanacak.
            if (MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "Dikkat !  //Coder: Eşrefhan Kadıoğlu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();//Uyarı veriyoruz eğer Evet'e basarsa kullanıcı uygulamadan çıkacak.
            }
        }


    }
}
