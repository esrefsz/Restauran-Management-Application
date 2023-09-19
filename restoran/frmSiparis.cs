/*
Novelty Yazılım Bilişim Teknolojileri Ltd. Şti. - www.noveltybilisim.com.tr
- Coder by Muhammed POLAT - Copyright (c) 2021 -

05.07.2021 - 06.09.2021 Tarihleri arasında yazılmış staj projesidir.

İletişim için: kurumsal@noveltybilisim.com.tr
https://www.muhammedpolat.com.tr/
info@muhammedpolat.com.tr
*/
using System;
using System.Collections;
using System.Windows.Forms;

namespace restoran
{
    public partial class frmSiparis : Form
    {

        public frmSiparis()
        {
            InitializeComponent();
        }

        //Hesap makinesinin butonlarını birbirine bağlamak için fonksiyon yazıyoruz. Buton tıklama olaylarını aynı event'a bağlayacağız.
        void islem(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btn1":
                    txtAdet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtAdet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtAdet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtAdet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtAdet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtAdet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtAdet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtAdet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtAdet.Text += (9).ToString();
                    break;
                case "btn0":
                    txtAdet.Text += (0).ToString();
                    break;
                case "btnVirgul":
                    txtAdet.Text += ",";
                    break;
                case "btnTemizle":
                    txtAdet.Text = "";
                    break;

                default:
                    MessageBox.Show("Sayı Gir ");
                    break;
            }
        }
        int tableID, AdditionId;
        private void frmSiparis_Load(object sender, EventArgs e)
        {
            //Tıkladığımız masanın ismi olan btnMasa1, btnMasa2'nin sonunda ki 1 ve 2'leri alıyor.
            lblMasaNo.Text = cGenel._ButtonValue;
            cMasalar ms = new cMasalar();
            tableID = ms.TableGetbyNumber(cGenel._ButtonName);
            if (ms.TableGetbyState(tableID, 2) == true || ms.TableGetbyState(tableID, 4) == true)
            {
                cAdisyon Ad = new cAdisyon();
                AdditionId = Ad.getByAddition(tableID);
                cSiparis orders = new cSiparis();
                orders.getByOrder(lvSiparisler, AdditionId);
            }

            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);
            btnVirgul.Click += new EventHandler(islem);
            btnTemizle.Click += new EventHandler(islem);

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
            if (lvYeniEklenenler.Items.Count > 0)
            {
                string messageSiparisButtonCheck = "Yeni eklenen siparisleri kaydetmek istiyor musunuz?";
                DialogResult resultMessageCheck;
                resultMessageCheck = MessageBox.Show(messageSiparisButtonCheck, "Confirm", MessageBoxButtons.YesNo);
                if (resultMessageCheck == DialogResult.Yes)
                {
                    MessageBox.Show("Lütfen yeni siparişleri kaydetmek için SİPARİŞ butonuna tıklayınız.!");
                }
                else
                {
                    frmMenu frm = new frmMenu();
                    frm.Show();
                    this.Close();
                }
            }
            else
            {
                frmMenu frm = new frmMenu();
                frm.Show();
                this.Close();
            }


        }
        cUrunCesitleri Uc = new cUrunCesitleri();
        private void btnAnaYemek3_Click(object sender, EventArgs e)
        {

            Uc.getByProductTypes(lvMenu, btnAnaYemek3);
        }



        private void btnTatlilar7_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnTatlilar7);
        }

        private void btnSalatalar6_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnSalatalar6);
        }

        private void btnFastFood5_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnFastFood5);
        }

        private void btnCorbalar1_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnCorbalar1);
        }

        private void btnKahveler8_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnKahveler8);

        }

        private void btnKahvalti4_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnKahvalti4);

        }

        private void btnArasicak2_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnArasicak2);
        }

        int sayac = 0, sayac2 = 0;



        ArrayList silinler = new ArrayList();
        private void lvSiparisler_DoubleClick(object sender, EventArgs e)//Siparişlerin silinmesi için Listview'de ürüne çift tıklandığında silinmesi
        {
            if (lvSiparisler.Items.Count > 0)
            {
                if (lvSiparisler.SelectedItems[0].SubItems[4].Text != "0") // "0" SatısID yok demek oluyor. Siparis butonuna basmadan eklediklerimiz ( kayıt olmamışlar).
                {
                    cSiparis saveOrder = new cSiparis();
                    saveOrder.setDeleteOrder(Convert.ToInt32(lvSiparisler.SelectedItems[0].SubItems[4].Text));
                }
                else
                {
                    for (int i = 0; i < lvYeniEklenenler.Items.Count; i++)
                    {
                        if (lvYeniEklenenler.Items[i].SubItems[4].Text == lvSiparisler.SelectedItems[0].SubItems[5].Text)
                        {
                            lvYeniEklenenler.Items.RemoveAt(i);
                        }
                    }
                }
                lvSiparisler.Items.RemoveAt(lvSiparisler.SelectedItems[0].Index);
            }

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text == "")
            {
                txtAra.Text = "";
            }
            else
            {
                cUrunCesitleri cu = new cUrunCesitleri();
                cu.getByProductSearch(lvMenu, Convert.ToInt32(txtAra.Text));
            }
        }
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            /*
            1 - Masa Boş
            2 - Masa Dolu
            3 - Masa Rezerve
            4 - Masa Açıkrezerve
            */
            if (lvSiparisler.Items.Count == 0)
            {
                MessageBox.Show("Lütfen sipariş için önce ürün ekleyiniz!");
            }
            else
            {
                cMasalar masa = new cMasalar();
                cAdisyon newAddition = new cAdisyon();
                cSiparis saveOrder = new cSiparis();
                frmMasalar ms = new frmMasalar();
                bool sonuc = false;
                if (masa.TableGetbyState(tableID, 1) == true)
                {
                    newAddition.ServisTurNo = 1;

                    newAddition.PersonelId = 1;
                    newAddition.MasaId = tableID;
                    newAddition.Tarih = DateTime.Now;
                    sonuc = newAddition.setByAdditionNew(newAddition);
                    masa.setChangeTableState(cGenel._ButtonName, 2);
                    //Adisyon açıldı ve masa bilgileri gönderildi.
                    if (lvSiparisler.Items.Count > 0)
                    {
                        for (int i = 0; i < lvSiparisler.Items.Count; i++)
                        {
                            saveOrder.MasaId = tableID;
                            saveOrder.UrunId = Convert.ToInt32(lvSiparisler.Items[i].SubItems[2].Text);
                            saveOrder.AdisyonID = newAddition.getByAddition(tableID);
                            saveOrder.Adet = float.Parse(lvSiparisler.Items[i].SubItems[1].Text);
                            saveOrder.setSaveOrder(saveOrder);
                        }
                        ms.Show();
                        this.Close();
                    }
                }
                else if (masa.TableGetbyState(tableID, 2) == true || masa.TableGetbyState(tableID, 4) == true)//Masa doluysa yeni eklenen siparişleri adisyona eklemek için
                {
                    if (lvSiparisler.Items.Count == 0)
                    {
                        MessageBox.Show("Lütfen sipariş için önce ürün ekleyiniz!");
                    }
                    else
                    {
                        if (lvYeniEklenenler.Items.Count > 0)
                        {


                            for (int i = 0; i < lvYeniEklenenler.Items.Count; i++)
                            {
                                saveOrder.MasaId = tableID;
                                saveOrder.UrunId = Convert.ToInt32(lvYeniEklenenler.Items[i].SubItems[1].Text);
                                saveOrder.AdisyonID = newAddition.getByAddition(tableID);
                                saveOrder.Adet = float.Parse(lvYeniEklenenler.Items[i].SubItems[2].Text);
                                saveOrder.setSaveOrder(saveOrder);
                            }


                        }
                        if (silinler.Count > 0)
                        {
                            foreach (string item in silinler)
                            {
                                saveOrder.setDeleteOrder(Convert.ToInt32(item));
                            }
                        }
                        ms.Show();
                        this.Close();
                    }

                }
                else if (masa.TableGetbyState(tableID, 3) == true)
                {

                    //newAddition.ServisTurNo = 1;
                    //newAddition.PersonelId = 1;
                    //newAddition.MasaId = tableID;
                    //newAddition.Tarih = DateTime.Now;
                    //sonuc = newAddition.setByAdditionNew(newAddition);
                    masa.setChangeTableState(cGenel._ButtonName, 4);
                    //Adisyon açıldı ve masa bilgileri gönderildi.
                    if (lvSiparisler.Items.Count > 0)
                    {
                        for (int i = 0; i < lvSiparisler.Items.Count; i++)
                        {
                            saveOrder.MasaId = tableID;
                            saveOrder.UrunId = Convert.ToInt32(lvSiparisler.Items[i].SubItems[2].Text);
                            saveOrder.AdisyonID = newAddition.getByAddition(tableID);
                            saveOrder.Adet = float.Parse(lvSiparisler.Items[i].SubItems[1].Text);
                            saveOrder.setSaveOrder(saveOrder);
                        }
                        ms.Show();
                        this.Close();
                    }
                }
            }
        }
        /// <summary>
        ///  Siparisleri İptal etmek için bu butona basılıyor.
        /// </summary>
        private void btnIptal_Click(object sender, EventArgs e)
        {
            string messageIptal = "Masanın tüm bilgileri SİLİNECEK!!  Emin misiniz?";
            DialogResult resultIptal;
            resultIptal = MessageBox.Show(messageIptal, "Confirm", MessageBoxButtons.YesNo);
            if (resultIptal == DialogResult.Yes)
            {
                cMasalar masa = new cMasalar();
                cAdisyon newAddition = new cAdisyon();
                frmMasalar ms = new frmMasalar();
                if (lvSiparisler.Items.Count > 0)
                {
                    cSiparis saveOrder = new cSiparis();
                    while (lvSiparisler.Items.Count > 0)
                    {

                        saveOrder.setDeleteOrder(Convert.ToInt32(lvSiparisler.Items[0].SubItems[4].Text));
                        //lvYeniEklenenler.Items.RemoveAt(0);
                        lvSiparisler.Items.RemoveAt(lvSiparisler.Items[0].Index);
                    }
                }
                if (masa.TableGetbyState(tableID, 2) == true || masa.TableGetbyState(tableID, 3) == true || masa.TableGetbyState(tableID, 4) == true )
                {
                    cRezervasyon c = new cRezervasyon();
                    c.rezervationClose(newAddition.getByAddition(tableID));
                    //newAddition.setDeleteAdition(newAddition.getByAddition(tableID));
                    masa.setChangeTableState(cGenel._ButtonName, 1);

                }
                ms.Show();
                this.Close();
            }
        }

        private void btnMesrubatlar28_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnMesrubatlar28);

        }


        private void lvMenu_DoubleClick(object sender, EventArgs e)//Menüde tıklanan ürünleri sipariş listview'e aktarmak için
        {
            if (txtAdet.Text == "")
            {
                txtAdet.Text = "1";
            }
            if (lvMenu.Items.Count > 0)
            {
                //lvMenu.SelectedItems[0].Text. // TODO
                sayac = lvSiparisler.Items.Count;
                lvSiparisler.Items.Add(lvMenu.SelectedItems[0].Text);
                lvSiparisler.Items[sayac].SubItems.Add(txtAdet.Text);
                lvSiparisler.Items[sayac].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvSiparisler.Items[sayac].SubItems.Add(((Convert.ToDecimal(lvMenu.SelectedItems[0].SubItems[1].Text)) * (Convert.ToDecimal(txtAdet.Text))).ToString());
                lvSiparisler.Items[sayac].SubItems.Add("0");
                sayac2 = lvYeniEklenenler.Items.Count;
                lvSiparisler.Items[sayac].SubItems.Add(sayac2.ToString());

                lvYeniEklenenler.Items.Add(AdditionId.ToString());
                lvYeniEklenenler.Items[sayac2].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvYeniEklenenler.Items[sayac2].SubItems.Add(txtAdet.Text);
                lvYeniEklenenler.Items[sayac2].SubItems.Add(tableID.ToString());
                lvYeniEklenenler.Items[sayac2].SubItems.Add(sayac2.ToString());
                sayac2++;

                    txtAdet.Text = "";
            }
        }
        private void btnOdeme_Click(object sender, EventArgs e)
        {
            cGenel._servisTurNo = 1;
            cGenel._adisyonId = AdditionId.ToString();//Ödeme butonuna bastığında adisyon ID'sini alıyoruz.
            frmBill frm = new frmBill();
            frm.Show();
            this.Close();
        }
    }
}
