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
using System.IO;
namespace restoran
{
    public partial class frmBill : Form
    {
        public frmBill()
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
        cSiparis cs = new cSiparis();
        int odemeTurId = 0;
        private void frmBill_Load(object sender, EventArgs e)
        {
            // 1 = Masa
            // 2 = Paket Servis
            if (cGenel._servisTurNo == 1)//Eğer servis türü Masa ise
            {
                lblAdisyonId.Text = cGenel._adisyonId;
                txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));
                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                }
                txtIndirimTutari.Clear();
                decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;//Ödeme ekranı ilk açıldığında kdv tutarını göstermesi için
                lblKdv.Text = string.Format("{0:0.000}", kdv);
            }
            else if (cGenel._servisTurNo == 2)//Eğer Paket Servis ise
            {
                lblAdisyonId.Text = cGenel._adisyonId;
                cPaketler pc = new cPaketler();
                odemeTurId = pc.OdemeTurIdGetir(Convert.ToInt32(lblAdisyonId.Text));
                txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));
                if (odemeTurId == 1)
                {
                    rbNakit.Checked = true;
                }
                else if (odemeTurId == 2)
                {
                    rbKrediKarti.Checked = true;
                }
                else if (odemeTurId == 3)
                {
                    rbTicket.Checked = true;
                }
                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                }
                txtIndirimTutari.Clear();
                decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;//Ödeme ekranı ilk açıldığında kdv tutarını göstermesi için
                lblKdv.Text = string.Format("{0:0.000}", kdv);
            }
        }

        private void txtIndirimTutari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(lblIndirim.Text) < Convert.ToDecimal(lblToplamTutar.Text))
                {
                    try
                    {
                        lblIndirim.Text = string.Format("{0:0.000}", Convert.ToDecimal(txtIndirimTutari.Text));

                    }
                    catch (Exception)
                    {

                        lblIndirim.Text = string.Format("{0:0.000}", 0);
                    }
                }
                else
                {
                    MessageBox.Show("İndirim Tutarı Toplam Tutardan Fazla Olamaz !");
                    txtIndirimTutari.Clear();

                }
            }
            catch (Exception)
            {

                lblIndirim.Text = string.Format("{0:0.000}", 0);
            }
        }

        private void chkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndirim.Checked)
            {
                gbIndirim.Visible = true;
            }
            else
            {
                gbIndirim.Visible = false;
            }
        }
        private void lblIndirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblIndirim.Text) >= 0)
            {
                decimal odenecek = 0;
                lblOdenecek.Text = lblToplamTutar.Text;
                odenecek = Convert.ToDecimal(lblOdenecek.Text) - Convert.ToDecimal(lblIndirim.Text);
                lblOdenecek.Text = string.Format("{0:0.000}", odenecek);
            }
            decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
            lblKdv.Text = string.Format("{0:0.000}", kdv);
        }

        cMasalar masalar = new cMasalar();
        cRezervasyon rezerve = new cRezervasyon();

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            string messageHesap = "HESAP ÇIKTISI ALDINIZ MI?";
            DialogResult resultHesap;
            resultHesap = MessageBox.Show(messageHesap, "Confirm", MessageBoxButtons.YesNo);
            if (resultHesap==DialogResult.Yes)
            {
                if (cGenel._servisTurNo == 1)
                {
                    int masaId = masalar.TableGetbyNumber(cGenel._ButtonName);

                    int musteriId = 0;
                    if (masalar.TableGetbyState(masaId, 4) == true)//Eğer masa rezervasyon ise ona göre işlem yap
                    {
                        musteriId = rezerve.getByClientIdFromRezervasyon(masaId);
                    }
                    else
                    {
                        musteriId = 1;//Standar müşteri
                    }
                    int odemeTurId = 0;//Ödeme türünü kontrol et
                    if (rbNakit.Checked)
                    {
                        odemeTurId = 1;
                    }
                    if (rbKrediKarti.Checked)
                    {
                        odemeTurId = 2;
                    }
                    if (rbTicket.Checked)
                    {
                        odemeTurId = 3;
                    }
                    cOdeme odeme = new cOdeme();
                    odeme.AdisyonId = Convert.ToInt32(lblAdisyonId.Text);
                    odeme.OdemeTurId = odemeTurId;
                    odeme.MusteriId = musteriId;
                    odeme.AraToplam = Convert.ToDecimal(lblOdenecek.Text);
                    odeme.KvdTutari = Convert.ToDecimal(lblKdv.Text);
                    odeme.Indirim = Convert.ToDecimal(lblIndirim.Text);
                    odeme.GenelToplam = Convert.ToDecimal(lblToplamTutar.Text);
                    bool result = odeme.billClose(odeme);
                    if (result)
                    {
                        saveHesapCiktisi(lvUrunler, masaId, odemeTurId);
                        MessageBox.Show("Hesap Kapatıldı.");
                        masalar.setChangeTableState(Convert.ToString(masaId), 1);//Hesap kapatıldıktan sonra masayı boşalt.
                        cRezervasyon c = new cRezervasyon();
                        c.rezervationClose(Convert.ToInt32(lblAdisyonId.Text));//Rezervasyon kapat
                        cAdisyon a = new cAdisyon();
                        a.additionClose(Convert.ToInt32(lblAdisyonId.Text));//Adisyon kapat
                        frmMasalar frm = new frmMasalar();
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hesap Kapatılırken Bir Hata Oluştu. Lütfen Yetkililere Bildiriniz!");
                    }
                }
                else if (cGenel._servisTurNo == 2)//Paket sipariş
                {
                    cOdeme odeme = new cOdeme();
                    odeme.AdisyonId = Convert.ToInt32(lblAdisyonId.Text);
                    odeme.OdemeTurId = odemeTurId;
                    odeme.MusteriId = 1;//Paket sipariş ID
                    odeme.AraToplam = Convert.ToDecimal(lblOdenecek.Text);
                    odeme.KvdTutari = Convert.ToDecimal(lblKdv.Text);
                    odeme.Indirim = Convert.ToDecimal(lblIndirim.Text);
                    odeme.GenelToplam = Convert.ToDecimal(lblToplamTutar.Text);
                    bool result = odeme.billClose(odeme);
                    if (result)
                    {
                        cAdisyon a = new cAdisyon();
                        a.additionClose(Convert.ToInt32(lblAdisyonId.Text));//Adisyon kapat
                        cPaketler p = new cPaketler();
                        p.OrderServiceClose(Convert.ToInt32(lblAdisyonId.Text));
                        MessageBox.Show("Adisyon Kapatıldı.");

                        frmMasalar frm = new frmMasalar();
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hesap Kapatılırken Bir Hata Oluştu. Lütfen Yetkililere Bildiriniz!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce HESAP ÖZETİNİ çıkartınız!");
            }
        }

        /// <summary>
        /// 
        /// Hesap çıktısını bir dosyaya kaydetmek için kullanılır. 
        /// İnput olarak lvUrunler alır.
        /// Hangi zamanda çağırıldığıysa o isimle kaydedilir.
        /// </summary>
        private void saveHesapCiktisi(ListView lvUrunler, int masaId, int odemeTurId)
        {
            string filePath = "bills\\";            
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            DateTime timeNow        = DateTime.Now;
            string FileName         = timeNow.ToString().Replace(":", "") + " Masa" + masaId.ToString() + ".txt";
            string baslikMessage    = ("APOLET KAFE RİVA");
            string ayracCizgi       = "----------------------------------------------------------------------";
            string urunlerStr       = "Ürün Adı:                                    Adet:           Fiyat:";
            string indirimStr       = "İndirim Tutarı   : ";
            //string KDVStr           = "KDV Tutarı       :------------- ";
            string toplamStr        = "Toplam Tutar     : ";
            string odemetTuruStr       = "Odeme Turu: %ODEMETURU%";
            string allMessages      = "";
            string emptyLine        = "\n";


            allMessages += "MASA " + masaId.ToString() + emptyLine;
            allMessages += ayracCizgi + emptyLine;
            allMessages += timeNow.ToString() + emptyLine; 
            allMessages += baslikMessage + emptyLine;
            allMessages += ayracCizgi + emptyLine;
            allMessages += urunlerStr + emptyLine;

            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                int lengthUrunAdi = lvUrunler.Items[i].SubItems[0].Text.Length;
                int lengthUrunAdet = lvUrunler.Items[i].SubItems[1].Text.Length;
                string deservedEmptyChar1 = "";
                string deservedEmptyChar2 = "";

                try
                {

                    deservedEmptyChar1 = new string(' ', 45-lengthUrunAdi);      // 45: Ü(Ürün) harfi ile A(Adet) harfi arasındaki boşluk sayısı.
                    deservedEmptyChar2 = new string(' ', 15-lengthUrunAdet);     // 15: A(Adet) harfi ile F(Fiyat) harfi arasındaki boşluk sayısı.

                }
                catch
                {
                    deservedEmptyChar1 = "\t";
                    deservedEmptyChar2 = "\t";
                }
                allMessages += lvUrunler.Items[i].SubItems[0].Text ;
                allMessages += deservedEmptyChar1;
                allMessages += lvUrunler.Items[i].SubItems[1].Text ;
                allMessages += deservedEmptyChar2;

                allMessages += lvUrunler.Items[i].SubItems[3].Text + emptyLine;
            }
            allMessages += ayracCizgi + emptyLine;
            if (lblIndirim.Text != "0")
            {
                allMessages += indirimStr + lblIndirim.Text + "₺" + emptyLine;
            }
            //allMessages += KDVStr + lblKdv.Text + "₺" + emptyLine;
            //allMessages += toplamStr + lblToplamTutar.Text + "₺" + emptyLine;
            allMessages += toplamStr + lblOdenecek.Text + "₺" + emptyLine;  // Toplam tutar olarak sadece odenecek tutar yazılıyor. 
            allMessages += odemetTuruStr + emptyLine;
            switch(odemeTurId)
            {
                case 1:
                    allMessages = allMessages.Replace("%ODEMETURU%", "Nakit");
                    break;
                case 2:
                    allMessages = allMessages.Replace("%ODEMETURU%", "Kreadi Kartı");
                    break;
                case 3:
                    allMessages = allMessages.Replace("%ODEMETURU%", "Ticket");
                    break;
                default:
                    break;
            }

            //allMessages += odenecekTutarStr + lblOdenecek.Text + "₺" + emptyLine;
            File.WriteAllText(filePath + FileName, allMessages);

        }

        private string baslikMessage = ("APOLET KAFE RİVA");
        private string ayracCizgi = "--------------------------";
        private string urunlerStr = "Ürün Adı:    Adet:   Fiyat:";
        private string indirimStr       = "İndirim Tutarı : ";
        //private string KDVStr = "KDV Tutarı       :------------- "; //TODO KDV HESAPLANMASIN.
        private string toplamStr        = "Toplam Tutar   : ";
        //private string odenecekTutarStr = "Odenecek Tutar : ";
        private string lastMessageStr = "TEKRAR BEKLERİZ";


        private void btnHesapOzeti_Click(object sender, EventArgs e)//Hesap özetini ekrana getir
        {
            printPreviewDialog1.ShowDialog();
        }

        Font baslik = new Font("Verdana", 8, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 10, FontStyle.Regular);
        Font icerik = new Font("Verdana", 6);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)//Hesap özetinin ekrana çıktısı
        {
            DateTime timeNow = DateTime.Now;
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;

            e.Graphics.DrawString(timeNow.ToString(), baslik, sb, 30, 5, st);
            e.Graphics.DrawString(baslikMessage, baslik, sb, 30, 20, st);
            e.Graphics.DrawString(ayracCizgi, altBaslik, sb, 10, 40, st);
            e.Graphics.DrawString(urunlerStr, altBaslik, sb, 10, 55, st);
            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[0].Text, icerik, sb, 10, 80 + i * 15, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[1].Text, icerik, sb, 135, 80 + i * 15, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[3].Text.ToString().Substring(0, lvUrunler.Items[i].SubItems[3].Text.ToString().Length - 2), icerik, sb, 155, 80 + i * 15, st);
            }
            //e.Graphics.DrawString(ayracCizgi, altBaslik, sb, 10, 300 + 15 * lvUrunler.Items.Count, st);

            if (lblIndirim.Text != "0")
            {
                e.Graphics.DrawString(indirimStr + lblIndirim.Text.ToString().Substring(0, lblIndirim.Text.ToString().Length - 1) + "₺", altBaslik, sb, 0, 80 + 20 * (lvUrunler.Items.Count + 1), st);
            }
            //e.Graphics.DrawString(KDVStr + lblKdv.Text + "₺", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 2), st);
            //e.Graphics.DrawString(toplamStr + lblToplamTutar.Text + "₺", altBaslik, sb, 0, 80 + 20 * (lvUrunler.Items.Count + 3), st);
            //e.Graphics.DrawString(odenecekTutarStr + lblOdenecek.Text + "₺", altBaslik, sb, 10, 80 + 20 * (lvUrunler.Items.Count + 4), st);
            e.Graphics.DrawString(toplamStr + lblOdenecek.Text.ToString().Substring(0, lblOdenecek.Text.ToString().Length - 1) + "₺", altBaslik, sb, 0, 80 + 20 * (lvUrunler.Items.Count + 2), st);
            e.Graphics.DrawString(lastMessageStr, altBaslik, sb, 30, 200 + 20 * (lvUrunler.Items.Count + 3), st);
        }

    }
}
