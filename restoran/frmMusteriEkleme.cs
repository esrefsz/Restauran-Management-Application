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
    public partial class frmMusteriEkleme : Form
    {
        public frmMusteriEkleme()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTelefon.Text.Length > 6)
            {
                if (txtMusteriAd.Text == "" || txtMusteriSoyad.Text == "")
                {
                    MessageBox.Show("Lütfen Ad Soyad Bilgisini Giriniz!");
                }
                else
                {
                    cMusteriler c = new cMusteriler();
                    bool sonuc = c.MusteriVarMi(txtTelefon.Text);
                    if (!sonuc)//Müşteri yoksa
                    {
                        c.Musteriad = txtMusteriAd.Text;
                        c.Musterisoyad = txtMusteriSoyad.Text;
                        c.Telefon = txtTelefon.Text;
                        c.Adres = txtAdres.Text;
                        c.Email = txtEmail.Text;
                        txtMusteriNo.Text = c.MusteriEkle(c).ToString();
                        if (txtMusteriNo.Text != "")
                        {
                            MessageBox.Show("Müşteri Eklendi!");
                        }
                        else
                        {
                            MessageBox.Show("HATA ! Müşteri Eklenemedi!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu isimde bir müşteri bulunmakta!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az 10 haneli telefon numarası giriniz ! Örnek: 5331234567");
            }
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            if (cGenel._musteriEkleme == 0)
            {
                frmRezervasyon frm = new frmRezervasyon();
                cGenel._musteriEkleme = 1;
                frm.Show();
                this.Close();
            }
            else if (cGenel._musteriEkleme == 1)
            {
                frmPaketSiparis frm = new frmPaketSiparis();
                cGenel._musteriEkleme = 0;
                frm.Show();
                this.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTelefon.Text.Length > 6)
            {
                if (txtMusteriAd.Text == "" || txtMusteriSoyad.Text == "")
                {
                    MessageBox.Show("Lütfen Ad Soyad Bilgisini Giriniz!");
                }
                else
                {
                    cMusteriler c = new cMusteriler();
                    c.Musteriad = txtMusteriAd.Text;
                    c.Musterisoyad = txtMusteriSoyad.Text;
                    c.Telefon = txtTelefon.Text;
                    c.Adres = txtAdres.Text;
                    c.Email = txtEmail.Text;
                    c.MusteriId = Convert.ToInt32(txtMusteriNo.Text);
                    bool sonuc = c.MusteriBilgileriGuncelle(c);
                    if (sonuc)//Müşteri yoksa
                    {

                        if (txtMusteriNo.Text != "")
                        {
                            MessageBox.Show("Müşteri Bilgileri Başarıyla Güncellendi!");
                        }
                        else
                        {
                            MessageBox.Show("HATA ! Müşteri Bilgileri Güncellenemedi!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu isimde bir müşteri bulunmakta!");
                    }
                }
            }

            else
            {
                MessageBox.Show("Lütfen en az 10 haneli telefon numarası giriniz ! Örnek: 5331234567");
            }
        }

        private void frmMusteriEkleme_Load(object sender, EventArgs e)
        {
            if (cGenel._musteriId > 0)
            {
                cMusteriler c = new cMusteriler();
                txtMusteriNo.Text = cGenel._musteriId.ToString();
                c.MusterileriGetirID(Convert.ToInt32(txtMusteriNo.Text), txtMusteriAd, txtMusteriSoyad, txtTelefon, txtAdres, txtEmail);
            }
        }

    }
}
