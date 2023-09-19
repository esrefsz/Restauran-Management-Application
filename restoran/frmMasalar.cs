/*
Novelty Yazılım Bilişim Teknolojileri Ltd. Şti. - www.noveltybilisim.com.tr
- Coder by Muhammed POLAT - Copyright (c) 2021 -

05.07.2021 - 06.09.2021 Tarihleri arasında yazılmış staj projesidir.

İletişim için: kurumsal@noveltybilisim.com.tr
https://www.muhammedpolat.com.tr/
info@muhammedpolat.com.tr
*/
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace restoran
{
    public partial class frmMasalar : Form
    {
        public frmMasalar()
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

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa1.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa1.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa1.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa2.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa2.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa2.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa3.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa3.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa3.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa4.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa4.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa4.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa5.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa5.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa5.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }
        private void btnMasa6_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa6.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa6.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa6.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa7.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa7.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa7.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa8.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa8.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa8.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa9.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa9.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa9.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }

        private void btnMasa10_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa10.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa10.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa10.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }

        private void btnMasa11_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa11.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa11.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa11.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp

        }

        private void btnMasa12_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa12.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa12.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa12.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp

        }

        private void btnMasa13_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa13.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa13.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa13.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp

        }

        private void btnMasa14_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa14.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa14.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa14.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp

        }

        private void btnMasa15_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa15.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa15.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa15.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp

        }
        private void btnMasa16_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa16.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa16.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa16.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }

        private void btnMasa17_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa17.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa17.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa17.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }

        private void btnMasa18_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa18.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa18.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa18.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }

        private void btnMasa19_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa19.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa19.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa19.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }

        private void btnMasa20_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa20.Text.Length;//Bastığımız butonun textini alıp uzunluğu hesapladık

            cGenel._ButtonValue = btnMasa20.Text.Substring(uzunluk - 6, 6);//Gelen text'ten 6 karakter çıkar ve 6 karakter kadarını al
            cGenel._ButtonName = btnMasa20.Name;//Buton ismini aldık
            frm.ShowDialog();//Sipariş kısmını açacağız
            this.Close();//Formu kapatıp
        }
        cGenel gnl = new cGenel();
        private void frmMasalar_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select DURUM, ID from Masalar", con);
            SqlDataReader dr = null;
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {   //Masaboş ise boş arkaplanı yerleştir
                        if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "1")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.MasaBos);
                        }
                        //Masa dolu ise dolu arkaplanı yerleştir
                        else if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "2")
                        {
                            cMasalar ms = new cMasalar();
                            DateTime dtl = Convert.ToDateTime(ms.SessionSum(2, dr["ID"].ToString()));
                            DateTime dt2 = DateTime.Now;
                            string st1 = Convert.ToDateTime(ms.SessionSum(2, dr["ID"].ToString())).ToShortTimeString();
                            string st2 = DateTime.Now.ToShortDateString();

                            DateTime t1 = dtl.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                            DateTime t2 = dt2.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);

                            var fark = t2 - t1;//Masa da kaç dk'dır oturuyor.
                            item.Text = String.Format("{0}{1}{2}",
                                fark.Days > 0 ? string.Format("{0} Gün", fark.Days) : "",
                                fark.Hours > 0 ? string.Format("{0} Saat", fark.Hours) : "",
                                fark.Minutes > 0 ? string.Format("\n{0} Dakika", fark.Minutes) : "").Trim() + "\nMasa" + dr["ID"].ToString();
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.MasaDolu);
                        }
                        //Masa açıkrezerve ise açıkrezerve arkaplanını. 
                        // Rezerve ama daha musteri daha siparis vermemis ya da gelmemiş...
                        else if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "3")
                        {
                            
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.MasaAcikRezerve);
                        }
                        //Masa eğer rezerve edilmişse rezerve arkaplanı.
                        //Rezerve edilmiş ve musteri gelmis.
                        else if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "4")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.MasaRezerve);
                        }
                    }

                }

            }
        }


    }
}