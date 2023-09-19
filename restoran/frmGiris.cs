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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cbKullanici.SelectedItem;
            cGenel._personelId = p.PersonelId;
            cGenel._gorevId = p.PersonelGorevID;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cGenel gnl = new cGenel();
            cPersoneller p = new cPersoneller();
            bool result = p.personelEntryControl(txtSifre.Text, cGenel._personelId);

            if (result)
            {//Eğer sonuç doğru dönerse giriş formunu kaldırıp menü formunu getiriyoruz
                cPersonelHareketleri ch = new cPersonelHareketleri();
                ch.PersonelId = cGenel._personelId;
                ch.Islem = "Giriş Yaptı";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);
                this.Hide();//Giriş formunu gizle
                frmMenu menu = new frmMenu();
                menu.Show();//Menü formunu göster
            }
            else
            {
                MessageBox.Show("Şifreniz Yanlış!", "Uyarı !  //Coder Eşrefhan Kadıoğlu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personelGetByInformation(cbKullanici);
        }

        private void btnCikis_Click(object sender, EventArgs e)//Çıkış butonu fonksiyonu
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "Dikkat !  //Coder: Eşrefhan Kadıoğlu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();//Uyarı veriyoruz eğer Evet'e basarsa kullanıcı uygulamadan çıkacak.
            }
        }

    }
}
