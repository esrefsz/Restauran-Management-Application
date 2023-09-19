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

namespace restoran
{
    public partial class frmSiparisKontrol : Form
    {
        public frmSiparisKontrol()
        {
            InitializeComponent();
        }
        private void frmSiparisKontrol_Load(object sender, EventArgs e)//Paket sipariş müşterileri için birer buton oluştur ve üzerine gelince listele
        {
            cAdisyon c = new cAdisyon();
            int butonSayisi = c.paketAdisyonAdetBul();
            c.acikPaketAdisyonlar(lvMusteriler);
            int alt = 1, sol = 50, bol = Convert.ToInt32(Math.Ceiling(Math.Sqrt(butonSayisi)));
            for (int i = 1; i <= butonSayisi; i++)
            {
                Button btn = new Button();
                btn.AutoSize = false;
                btn.Size = new Size(179, 80);
                btn.FlatStyle = FlatStyle.Popup;
                btn.Name = lvMusteriler.Items[i - 1].SubItems[0].Text;
                btn.Text = lvMusteriler.Items[i - 1].SubItems[1].Text;
                btn.Font = new Font(btn.Font.FontFamily.Name, 18);
                btn.Location = new Point(sol, alt);
                this.Controls.Add(btn);
                sol += btn.Width + 5;
                if (i == 2)
                {
                    sol = 1;
                    alt += 50;
                }
                btn.Click += new EventHandler(dinamikMetod);
                btn.MouseEnter += new EventHandler(dinamikMetod2);
            }
        }
        protected void dinamikMetod(object sender, EventArgs e)
        {
            cAdisyon c = new cAdisyon();
            Button dinamikButon = (sender as Button);
            frmBill frm = new frmBill();
            cGenel._servisTurNo = 2;
            cGenel._adisyonId = Convert.ToString(c.musteriSonAdisyonId(Convert.ToInt32(dinamikButon.Name)));
            frm.Show();
        }
        protected void dinamikMetod2(object sender, EventArgs e)
        {
            cAdisyon c = new cAdisyon();
            cSiparis s = new cSiparis();
            Button dinamikButon = (sender as Button);
            c.musteriDetaylar(lvMusteriDetaylari, Convert.ToInt32(dinamikButon.Name));
            sonSiparisTarihi();
            lvSatisDetaylari.Items.Clear();
            cGenel._servisTurNo = 2;
            cGenel._adisyonId = Convert.ToString(c.musteriSonAdisyonId(Convert.ToInt32(dinamikButon.Name)));
            lblToplamSiparis.Text = "";
            lblGenelToplam.Text = s.genelToplamBul(Convert.ToInt32(dinamikButon.Name)).ToString() + " ₺";
        }
        void sonSiparisTarihi()//Son sipariş tarihi hesapla
        {
            if (lvMusteriDetaylari.Items.Count > 0)
            {
                int s = lvMusteriDetaylari.Items.Count;
                lblSonSiparisTarihi.Text = lvMusteriDetaylari.Items[s - 1].SubItems[3].Text;
                txtToplamTutar.Text = s + "Adet";

            }
        }
        void toplam()//Toplam tutarı hesapla
        {
            int kayitSayisi = lvSatisDetaylari.Items.Count;
            decimal toplam = 0;
            for (int i = 0; i < kayitSayisi; i++)
            {
                toplam += (Convert.ToDecimal(lvSatisDetaylari.Items[i].SubItems[2].Text)) * (Convert.ToDecimal(lvSatisDetaylari.Items[i].SubItems[3].Text));
            }
            lblToplamSiparis.Text = toplam.ToString() + "₺";
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            //Çıkış butonuna basıldığında ekrana uyarı verecek ve eğer evet derse kullanıcı uygulama kapanacak.
            if (MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "Dikkat !  //Coder: Eşrefhan Kadıoğlu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();//Uyarı veriyoruz eğer Evet'e basarsa kullanıcı uygulamadan çıkacak.
            }
        }
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMusteriAra frm = new frmMusteriAra();
            frm.Show();
            this.Close();
        }
        private void lvMusteriDetaylari_SelectedIndexChanged(object sender, EventArgs e)//Müşteri seçilince topltam tutarı getir
        {
            if (lvMusteriDetaylari.SelectedItems.Count > 0)//Eğer herhangi bir satır seçilmişse
            {
                cSiparis c = new cSiparis();
                c.adisyonPaketSiparisDetaylari(lvSatisDetaylari, Convert.ToInt32(lvMusteriDetaylari.SelectedItems[0].SubItems[4].Text));
                toplam();
                lblGenelToplam.Text = c.genelToplamBul(Convert.ToInt32(lvMusteriDetaylari.SelectedItems[0].SubItems[0].Text)).ToString() + " ₺";
            }
        }
        private void lvSatisDetaylari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lvMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
