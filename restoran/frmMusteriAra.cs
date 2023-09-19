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
    public partial class frmMusteriAra : Form
    {
        public frmMusteriAra()
        {
            InitializeComponent();
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
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Close();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmMusteriEkleme m = new frmMusteriEkleme();
            cGenel._musteriEkleme = 1;
            m.btnGuncelle.Visible = false;
            m.btnEkle.Visible = true;
            m.Show();
        }

        private void frmMusteriAra_Load(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.MusterileriGetir(lvMusteriler);
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count > 0)
            {
                frmMusteriEkleme frm = new frmMusteriEkleme();
                cGenel._musteriEkleme = 1;
                cGenel._musteriId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
                frm.btnEkle.Visible = false;
                frm.btnMusteriSec.Visible = false;
                frm.btnGuncelle.Visible = true;
                frm.Show();
                this.Close();
            }
        }


        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.MusterileriGetirAD(lvMusteriler, txtAd.Text);
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.MusterileriGetirSOYAD(lvMusteriler, txtSoyad.Text);
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.MusterileriGetirTELEFON(lvMusteriler, txtTelefon.Text);
        }
        private void btnAdisyonBul_Click(object sender, EventArgs e)
        {
            if (txtAdisyonId.Text != "")
            {
                cGenel._adisyonId = txtAdisyonId.Text;
                cPaketler c = new cPaketler();
                bool sonuc = c.getCheckOpenAdditionID(Convert.ToInt32(txtAdisyonId.Text));
                if (sonuc)
                {
                    frmBill frm = new frmBill();
                    cGenel._servisTurNo = 2;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Adisyon ID: " + txtAdisyonId.Text + "\nBöyle bir adisyon bulunamadı!");
                }
            }
            else
            {
                MessageBox.Show("Adisyon ID kısmı boş bırakılamaz! Lütfen Adisyon ID'sini yazınız!");
            }
        }

        private void txtAd_Click(object sender, EventArgs e)
        {
            txtSoyad.Clear();
            txtTelefon.Clear();
        }

        private void txtSoyad_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtTelefon.Clear();
        }

        private void txtTelefon_Click(object sender, EventArgs e)
        {
            txtSoyad.Clear();
            txtAd.Clear();
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            frmSiparisKontrol frm = new frmSiparisKontrol();
            frm.Show();
            this.Close();
        }
    }
}
