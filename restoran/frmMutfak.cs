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
    public partial class frmMutfak : Form
    {
        public frmMutfak()
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

        private void frmMutfak_Load(object sender, EventArgs e)
        {
            cUrunCesitleri Anakategori = new cUrunCesitleri();
            cUrunler c = new cUrunler();
            Anakategori.urunCesitleriniGetirCB(cbKategoriler);
            cbKategoriler.Items.Insert(0, "Tüm Kategoriler");
            cbKategoriler.SelectedIndex = 0;//Form load olurken tüm kategoriler seçili olsun
            lblAra.Visible = false;
            txtAra.Visible = false;
            c.urunleriListele(lvGidaListesi);
            yenile();
            Temizle();
        }
        private void Temizle()
        {
            txtGidaAdi.Clear();
            txtGidaFiyati.Clear();
            txtGidaFiyati.Text = string.Format("{0:##0.00}", 0);
            txtKategoriAd.Clear();
            txtAciklama.Clear();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (rbAltKategori.Checked)
            {
                if (txtGidaAdi.Text.Trim() == "" || txtGidaFiyati.Text.Trim() == "" || cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Gida Adı, Fiyatı ve Kategori Seçilmemiştir!", "Dikkat ! Bilgiler Eksik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunler c = new cUrunler();
                    c.Fiyat = Convert.ToDecimal(txtGidaFiyati.Text);
                    c.UrunAd = txtGidaAdi.Text;
                    c.Aciklama = "Açıklama eklenecek";
                    c.UrunTurNo = urunTurNo;
                    int sonuc = c.urunEkle(c);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün başarıyla eklenmiştir!");
                        yenile();
                        Temizle();
                    }
                }
            }
            else
            {
                if (txtKategoriAd.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori adı giriniz!", "Dikkat ! Bilgiler Eksik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunCesitleri gida = new cUrunCesitleri();
                    gida.KategoriAd = txtKategoriAd.Text;
                    gida.Aciklama = txtAciklama.Text;
                    //gida.UrunTurNo = Convert.ToInt32(txtKategoriId.Text);
                    int sonuc = gida.urunCesitleriniEkle(gida);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Kategori başarıyla eklenmiştir!");
                        yenile();
                        Temizle();
                    }
                }
            }
        }
        int urunTurNo = 0;
        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cUrunler u = new cUrunler();
            if (cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
            {

                u.urunleriListele(lvGidaListesi);
            }
            else
            {
                cUrunCesitleri uc = (cUrunCesitleri)cbKategoriler.SelectedItem;
                urunTurNo = uc.UrunTurNo;
                //uc.urunCesitleriniGetirCB(cbKategoriler);                
                u.urunleriListeleUrunId(lvGidaListesi, urunTurNo);

            }
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (rbAltKategori.Checked)
            {
                if (txtGidaAdi.Text.Trim() == "" || txtGidaFiyati.Text.Trim() == "" || cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Gida Adı, Fiyatı ve Kategori Seçilmemiştir!", "Dikkat ! Bilgiler Eksik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunler c = new cUrunler();
                    c.Fiyat = Convert.ToDecimal(txtGidaFiyati.Text);
                    c.UrunAd = txtGidaAdi.Text;
                    c.UrunId = Convert.ToInt32(txtUrunId.Text);
                    c.UrunTurNo = urunTurNo;
                    c.Aciklama = "Açıklama güncellenecek";
                    int sonuc = c.urunleriGuncelle(c);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün başarıyla güncellenmiştir!");
                        yenile();
                        Temizle();
                    }
                }
            }
            else
            {
                if (txtKategoriId.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori seçiniz!", "Dikkat ! Bilgiler Eksik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunCesitleri gida = new cUrunCesitleri();
                    gida.KategoriAd = txtKategoriAd.Text;
                    gida.Aciklama = txtAciklama.Text;
                    gida.UrunTurNo = Convert.ToInt32(txtKategoriId.Text);
                    int sonuc = gida.urunCesitleriniGuncelle(gida);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Kategori başarıyla güncellenmiştir!");
                        yenile();
                        Temizle();
                    }
                }
            }
        }
        private void lvGidaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGidaListesi.SelectedItems.Count > 0)
            {
                txtUrunId.Text = lvGidaListesi.SelectedItems[0].SubItems[0].Text;
                txtGidaAdi.Text = lvGidaListesi.SelectedItems[0].SubItems[3].Text;
                txtGidaFiyati.Text = lvGidaListesi.SelectedItems[0].SubItems[5].Text;
                //cbKategoriler.SelectedIndex = Convert.ToInt32(txtUrunId.Text);
            }
        }
        private void lvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGidaListesi.SelectedItems.Count > 0)
            {
                txtKategoriAd.Text = lvKategoriler.SelectedItems[0].SubItems[1].Text;
                txtKategoriId.Text = lvKategoriler.SelectedItems[0].SubItems[0].Text;
                txtAciklama.Text = lvKategoriler.SelectedItems[0].SubItems[2].Text;
                //cbKategoriler.SelectedIndex = Convert.ToInt32(txtUrunId.Text);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (rbAltKategori.Checked)
            {
                if (lvGidaListesi.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Ürün silinecek emin misiniz?", "Dikkat ! Ürün Siliniyor!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cUrunler c = new cUrunler();
                        c.UrunId = Convert.ToInt32(txtUrunId.Text);
                        int sonuc = c.urunSil(c, 1);
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Ürün başarıyla silinmiştir!");
                            yenile();
                            //cbKategoriler_SelectedIndexChanged(sender, e);
                            Temizle();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek için bir ürün seçiniz!", "Dikkat ! Ürün Seçilmedi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (lvKategoriler.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Kategori silinecek emin misiniz?", "Dikkat ! Ürün Siliniyor!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cUrunCesitleri uc = new cUrunCesitleri();
                        int sonuc = uc.urunCesitleriniSil(Convert.ToInt32(txtKategoriId.Text));
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Kategori başarıyla silinmiştir!");
                            cUrunler c = new cUrunler();
                            c.UrunId = Convert.ToInt32(txtKategoriId.Text);
                            c.urunSil(c, 0);
                            yenile();
                            //cbKategoriler_SelectedIndexChanged(sender, e);
                            Temizle();
                        }
                    }
                }
            }
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            lblAra.Visible = true;
            txtAra.Visible = true;
            yenile();
            Temizle();
        }
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (rbAltKategori.Checked)
            {
                cUrunler u = new cUrunler();
                u.urunleriListeleUrunAd(lvGidaListesi, txtAra.Text);
            }
            else
            {
                cUrunCesitleri uc = new cUrunCesitleri();
                uc.urunCesitleriniAra(lvKategoriler, txtAra.Text);
            }
        }
        private void rbAltKategori_CheckedChanged(object sender, EventArgs e)
        {
            panelUrun.Visible = true;
            panelAnaKategori.Visible = false;
            lvKategoriler.Visible = false;
            lvGidaListesi.Visible = true;
            yenile();
            Temizle();
        }
        private void rbAnaKategori_CheckedChanged(object sender, EventArgs e)
        {
            panelUrun.Visible = false;
            panelAnaKategori.Visible = true;
            lvKategoriler.Visible = true;
            lvGidaListesi.Visible = false;
            cUrunCesitleri uc = new cUrunCesitleri();
            uc.urunCesitleriniGetirLV(lvKategoriler);
            Temizle();
            yenile();
        }
        private void yenile()
        {
            cUrunCesitleri uc = new cUrunCesitleri();
            uc.urunCesitleriniGetirCB(cbKategoriler);
            cbKategoriler.Items.Insert(0, "Tüm Kategoriler");
            cbKategoriler.SelectedIndex = 0;
            uc.urunCesitleriniGetirLV(lvKategoriler);
            cUrunler u = new cUrunler();
            u.urunleriListele(lvGidaListesi);
        }
    }
}
