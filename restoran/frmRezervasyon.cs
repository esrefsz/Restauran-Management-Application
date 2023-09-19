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
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
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
        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.MusterileriGetir(lvMusteriler);
            cMasalar masa = new cMasalar();
            masa.masaKapasiteDurumGetir(cbMasa);
            dtTarih.MinDate = DateTime.Today;
            dtTarih.Format = DateTimePickerFormat.Time;
        }
        private void txtMusteriAd_TextChanged(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.MusterileriGetirAD(lvMusteriler, txtMusteriAd.Text);
        }
        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.MusterileriGetirTELEFON(lvMusteriler, txtTelefon.Text);
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.MusterileriGetirADRES(lvMusteriler, txtAdres.Text);
        }
        void Temizle()//Textleri temizler
        {
            txtAdres.Clear();
            txtKisiSayisi.Clear();
            txtMasa.Clear();
            txtMusteriAd.Clear();
            txtAdres.Clear();
        }
        private void btnRezervasyonAc_Click(object sender, EventArgs e)
        {
            cRezervasyon r = new cRezervasyon();
            if (lvMusteriler.SelectedItems.Count > 0)
            {
                bool sonuc = r.rezervasyonAcikMiKontrol(Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text));
                if (!sonuc)
                {
                    if (txtTarih.Text != "" && txtKisiSayisi.Text != "" && txtMasaNo.Text != "")
                    {
                        cMasalar masa = new cMasalar();
                        if (masa.TableGetbyState(Convert.ToInt32(txtMasaNo.Text), 1))
                        {
                            cAdisyon a = new cAdisyon();
                            a.Tarih = Convert.ToDateTime(txtTarih.Text);
                            a.PersonelId = cGenel._personelId;
                            a.ServisTurNo = 1;
                            a.MasaId = Convert.ToInt32(txtMasaNo.Text);
                            r.ClientId = Convert.ToInt32(Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text));
                            r.TableId = Convert.ToInt32(txtMasaNo.Text);
                            r.Date = Convert.ToDateTime(txtTarih.Text);
                            r.ClientCount = Convert.ToInt32(txtKisiSayisi.Text);
                            r.Description = txtAciklama.Text;
                            r.AdditionId = a.rezervasyonAdisyonAc(a);//Adisyonu açıyoruz
                            sonuc = r.rezervasyonAc(r);//Rezervasyonu açıyoruz                                                        
                            masa.setChangeTableState(txtMasaNo.Text, 3);
                            if (sonuc)
                            {
                                MessageBox.Show("Rezervasyon başarıyla açılmıştır!");
                                Temizle();
                            }
                            else
                            {
                                MessageBox.Show("Rezervasyon açılırken bir hata oluştu!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Rezervasyon yapılan masa şuan DOLU !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen gerekli yerleri doldurunuz !");
                    }
                }
                else
                {
                    MessageBox.Show("Bu müşteri adına açık bir rezervasyon bulunmaktadır !");
                }
            }
            else
            {
                MessageBox.Show("Lütfen rezervasyon için müşteri seçin !");
            }
        }
        private void dtTarih_MouseEnter(object sender, EventArgs e)
        {
            dtTarih.Width = 300;//Genişliğini ayarlar
        }
        private void dtTarih_Enter(object sender, EventArgs e)
        {
            dtTarih.Width = 300;
        }
        private void dtTarih_MouseLeave(object sender, EventArgs e)
        {
            dtTarih.Width = 25;
        }
        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtTarih.Value.ToString();
        }
        private void cbKisiSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKisiSayisi.Text = cbKisiSayisi.SelectedItem.ToString();
        }
        private void cbMasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKisiSayisi.Enabled = true;
            txtMasa.Text = cbMasa.SelectedItem.ToString();
            cMasalar kapasitesi = (cMasalar)cbMasa.SelectedItem;
            int kapasite = kapasitesi.KAPASITE;
            txtMasaNo.Text = Convert.ToString(kapasitesi.ID);
            cbKisiSayisi.Items.Clear();
            for (int i = 0; i < kapasite; i++)
            {
                cbKisiSayisi.Items.Add(i + 1);
            }
        }
        private void cbMasa_MouseEnter(object sender, EventArgs e)
        {
            cbMasa.Width = 350;
        }
        private void cbMasa_MouseLeave(object sender, EventArgs e)
        {
            cbMasa.Width = 25;
        }
        private void cbKisiSayisi_MouseLeave(object sender, EventArgs e)
        {
            cbKisiSayisi.Width = 25;
        }
        private void cbKisiSayisi_MouseEnter(object sender, EventArgs e)
        {
            cbKisiSayisi.Width = 100;
        }
        private void btnRezervasyonKontrol_Click(object sender, EventArgs e)
        {
            frmSiparisKontrol frm = new frmSiparisKontrol();
            frm.Show();
            this.Close();
        }
        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmMusteriEkleme frm = new frmMusteriEkleme();
            cGenel._musteriEkleme = 0;
            frm.btnGuncelle.Visible = false;
            frm.btnEkle.Visible = true;
            frm.Show();
            this.Close();
        }
        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count > 0)
            {
                frmMusteriEkleme me = new frmMusteriEkleme();
                cGenel._musteriEkleme = 0;
                cGenel._musteriId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
                me.btnGuncelle.Visible = true;
                me.btnEkle.Visible = false;
                me.Show();
                this.Close();
            }
        }

    }
}
