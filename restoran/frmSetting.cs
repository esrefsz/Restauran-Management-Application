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
    public partial class frmSetting : Form
    {
        public frmSetting()
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
        private void frmSetting_Load(object sender, EventArgs e)
        {
            cPersoneller cp = new cPersoneller();
            cPersonelGorev cpg = new cPersonelGorev();
            string gorev = cpg.PersonelGorevTanim(cGenel._gorevId);
            if (gorev == "Müdür" || gorev == "Yazılımcı")
            {
                cp.personelGetByInformation(cbPersonel);
                cpg.PersonelGorevGetir(cbGorevi);
                cp.personelGetByInformationLV(lvPersoneller);
                btnYeni.Enabled = true;
                btnSil.Enabled = false;
                btnBilgiDegistir.Enabled = false;
                btnEkle.Enabled = false;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
                txtSifre.ReadOnly = true;
                txtSifreTekrar.ReadOnly = true;
                lblBilgi.Text = "Mevki:" + gorev + " / Yetki Sınırsız / Kullanıcı: " + cp.personelGetByName(cGenel._personelId);
            }

            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                lblBilgi.Text = "Mevki:" + gorev + "/ Yetki Sınırlı / Kullanıcı: " + cp.personelGetByName(cGenel._personelId);
            }
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            if (txtMevcutSifre.Text.Trim() != "" && p.personelEntryControl(txtMevcutSifre.Text, Convert.ToInt32(txtPersonelId.Text)))
            {
                if (txtYeniSifre.Text.Trim() == txtYeniSifreTekrar.Text.Trim())
                {
                    if (txtPersonelId.Text.Trim() != "")
                    {
                        cPersoneller c = new cPersoneller();
                        bool sonuc = c.personelChangePassword(Convert.ToInt32(txtPersonelId.Text), txtYeniSifre.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre değiştime işlemi başarıyla tamamlandı!");
                            txtMevcutSifre.Clear();
                            txtYeniSifre.Clear();
                            txtYeniSifreTekrar.Clear();
                            txtPersonelId.Clear();
                            cbPersonel.Controls.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen işlem yapılacak personeli seçiniz !");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil !!");
                }
            }
            else
            {
                MessageBox.Show("Mevcut şifrenizi lütfen doğru giriniz!\nLütfen şifre alanını boş bırakmayınız !");
            }
        }
        private void cbGorevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersonelGorev c = (cPersonelGorev)cbGorevi.SelectedItem;
            txtGorevId2.Text = Convert.ToString(c.PersonelGorevId);
        }
        private void cbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller c = (cPersoneller)cbPersonel.SelectedItem;
            txtPersonelId.Text = Convert.ToString(c.PersonelId);
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnEkle.Enabled = true;
            btnBilgiDegistir.Enabled = false;
            btnSil.Enabled = false;
            txtSifre.ReadOnly = false;
            txtSifreTekrar.ReadOnly = false;
            txtAd.Clear();
            txtSoyad.Clear();
            txtSifre.Clear();
            txtSifreTekrar.Clear();
            txtPersonelId2.Clear();
            txtGorevId2.Clear();
            cbGorevi.Controls.Clear();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Silmek istediğinize emin misiniz ?", "DİKKAT !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cPersoneller c = new cPersoneller();
                    bool sonuc = c.personelDelete(Convert.ToInt32(lvPersoneller.SelectedItems[0].Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Silme işlemi başarıyla tamamlandı !");
                        c.personelGetByInformationLV(lvPersoneller);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinirken bir sorun oluştu!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz!");
                }
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != "" && txtSifre.Text.Trim() != "" && txtSifreTekrar.Text.Trim() != "" && txtGorevId2.Text.Trim() != "")
            {
                if ((txtSifre.Text.Trim() == txtSifreTekrar.Text.Trim()) && (txtSifre.Text.Length > 5 || txtSifreTekrar.Text.Length > 5))
                {//Şifre veya yeni şifre uzunluğu da 5 haneden büyük olsun
                    cPersoneller c = new cPersoneller();
                    c.PersonelAd = txtAd.Text.Trim();
                    c.PersonelSoyad = txtSoyad.Text.Trim();
                    c.PersonelParola = txtSifre.Text.Trim();
                    c.PersonelGorevID = Convert.ToInt32(txtGorevId2.Text);
                    bool sonuc = c.personelAdd(c);
                    if (sonuc)
                    {
                        MessageBox.Show("Personel başarıyla eklenmiştir!");
                        c.personelGetByInformationLV(lvPersoneller);
                    }
                    else
                    {
                        MessageBox.Show("Personel eklenirken bir hata oluştu!");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil! Lütfen iki kutucuğa da aynı şifreyi yazın ve şfireniz 5 haneden uzun olsun !");
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz doldurun !");
            }
        }
        private void btnBilgiDegistir_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                if (txtAd.Text != "" && txtSoyad.Text != "" && txtSifre.Text != "" && txtSifreTekrar.Text != "" && txtGorevId2.Text != "")
                {
                    if ((txtSifreTekrar.Text.Trim() == txtSifreTekrar.Text.Trim()) && (txtSifre.Text.Length > 5 || txtSifreTekrar.Text.Length > 5))
                    {//Şifre veya yeni şifre uzunluğu da 5 haneden büyük olsun
                        cPersoneller c = new cPersoneller();
                        c.PersonelAd = txtAd.Text.Trim();
                        c.PersonelSoyad = txtSoyad.Text.Trim();
                        c.PersonelParola = txtSifre.Text.Trim();
                        c.PersonelGorevID = Convert.ToInt32(txtGorevId2.Text);
                        bool sonuc = c.personelUpdate(c, Convert.ToInt32(txtPersonelId2.Text));
                        if (sonuc)
                        {
                            MessageBox.Show("Personel başarıyla güncellendi!");
                            c.personelGetByInformationLV(lvPersoneller);
                        }
                        else
                        {
                            MessageBox.Show("Personel güncellenirken bir hata oluştu!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler aynı değil! Lütfen iki kutucuğa da aynı şifreyi yazın ve şfireniz 5 haneden uzun olsun !");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm bilgileri eksiksiz doldurun !");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek personeli seçiniz!");
            }
        }
        private void btnDegistir3_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre3.Text.Trim() != "" || txtYeniSifreTekrar3.Text.Trim() != "")
            {
                if (txtYeniSifre3.Text == txtYeniSifreTekrar3.Text)
                {
                    if (cGenel._personelId.ToString() != "")
                    {
                        cPersoneller c = new cPersoneller();
                        bool sonuc = c.personelChangePassword(Convert.ToInt32(cGenel._personelId), txtYeniSifre3.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre değiştime işlemi başarıyla tamamlandı!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen işlem yapılacak personeli seçiniz !");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil !!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen şifre alanını boş bırakmayınız !");
            }
        }
        private void lvPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                btnSil.Enabled = true;
                txtPersonelId.Text = lvPersoneller.SelectedItems[0].SubItems[0].Text;
                //txtGorevId2.Text= lvPersoneller.SelectedItems[1].SubItems[1].Text;
                cbGorevi.SelectedIndex = Convert.ToInt32(lvPersoneller.SelectedItems[0].SubItems[1].Text) - 1;
                txtAd.Text = lvPersoneller.SelectedItems[0].SubItems[3].Text;
                txtSoyad.Text = lvPersoneller.SelectedItems[0].SubItems[4].Text;
            }
        }

    }
}
