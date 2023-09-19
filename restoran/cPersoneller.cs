/*
Novelty Yazılım Bilişim Teknolojileri Ltd. Şti. - www.noveltybilisim.com.tr
- Coder by Muhammed POLAT - Copyright (c) 2021 -

05.07.2021 - 06.09.2021 Tarihleri arasında yazılmış staj projesidir.

İletişim için: kurumsal@noveltybilisim.com.tr
https://www.muhammedpolat.com.tr/
info@muhammedpolat.com.tr
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//
namespace restoran
{
    class cPersoneller
    {
        cGenel gnl = new cGenel();//SQL bağlantısını yapabilmek için genel sınıfından bir nesne ürettik.
        //Alanlar
        #region Fields
        private int _PersonelId;
        private int _PersonelGorevID;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private bool _PersonelDurum;
        #endregion
        //Özellikler
        #region Properties
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int PersonelGorevID { get => _PersonelGorevID; set => _PersonelGorevID = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelSoyad { get => _PersonelSoyad; set => _PersonelSoyad = value; }
        public string PersonelParola { get => _PersonelParola; set => _PersonelParola = value; }
        public string PersonelKullaniciAdi { get => _PersonelKullaniciAdi; set => _PersonelKullaniciAdi = value; }
        public bool PersonelDurum { get => _PersonelDurum; set => _PersonelDurum = value; }
        #endregion

        public bool personelEntryControl(string password, int UserId)
        {
            bool result = false; //Herhangi bir işlem yanlış giderse direkt false dönecek.

            SqlConnection con = new SqlConnection(gnl.conString);//Veritabanına bağlan
            SqlCommand cmd = new SqlCommand("Select * from Personeller where ID=@Id and PAROLA=@password", con);//Gelen ID ve şifreyi kontrol et var mı?
            cmd.Parameters.Add("@Id", System.Data.SqlDbType.VarChar).Value = UserId;//Değerleri ata*gönder
            cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = password;

            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

                throw;
            }
            return result;
        }
        public void personelGetByInformation(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);//Veritabanına bağlan
            SqlCommand cmd = new SqlCommand("Select * from Personeller Where DURUM=0", con);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();//SQL'den bilgi okuyacağız

            while (dr.Read())//Bilgi varsa sürekli okuma yap.
            {
                cPersoneller p = new cPersoneller();
                p._PersonelId = Convert.ToInt32(dr["ID"]);
                p._PersonelGorevID = Convert.ToInt32(dr["GOREVID"]);
                p._PersonelAd = Convert.ToString(dr["AD"]);
                p._PersonelSoyad = Convert.ToString(dr["SOYAD"]);
                p._PersonelParola = Convert.ToString(dr["PAROLA"]);
                p._PersonelKullaniciAdi = Convert.ToString(dr["KULLANICIADI"]);
                p._PersonelDurum = Convert.ToBoolean(dr["DURUM"]);
                cb.Items.Add(p);

            }
            dr.Close();
            con.Close();
        }
        public override string ToString()//Combobox'a yani kullanıcı listesinde tüm isimler görünmesi için
        {
            return PersonelAd + " " + PersonelSoyad; //Combobox'ta isim ve soyisim görünmesi için
        }
        public void personelGetByInformationLV(ListView lv)//Personel Bilgisini Listview'e gönder
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);//Veritabanına bağlan
            SqlCommand cmd = new SqlCommand("Select personeller.*, personelGorevleri.GOREV FROM personeller INNER JOIN personelGorevleri on personelGorevleri.ID=personeller.GOREVID WHERE Personeller.DURUM=0 ", con);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["GOREVID"].ToString());
                lv.Items[i].SubItems.Add(dr["GOREV"].ToString());
                lv.Items[i].SubItems.Add(dr["AD"].ToString());
                lv.Items[i].SubItems.Add(dr["SOYAD"].ToString());
                lv.Items[i].SubItems.Add(dr["KULLANICIADI"].ToString());
                i++;
            }
            dr.Close();
            con.Close();
        }
        public void personelGetByInformationFromIDLV(ListView lv, int personelId)//Personel Bilgisini Listview'e gönder ID
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);//Veritabanına bağlan
            SqlCommand cmd = new SqlCommand("Select Personeller.*, personelGorevleri.GOREV FROM Personeller INNER JOIN PersonelGorevleri on personelGorevleri.ID=Personeller.GOREVID WHERE Personeller.DURUM=0 AND Personeller.ID=@personelId ", con);
            cmd.Parameters.Add("@personelId", SqlDbType.Int).Value = personelId;
            SqlDataReader dr = null;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[i].SubItems.Add(dr["GOREVID"].ToString());
                    lv.Items[i].SubItems.Add(dr["GOREV"].ToString());
                    lv.Items[i].SubItems.Add(dr["AD"].ToString());
                    lv.Items[i].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[i].SubItems.Add(dr["KULLANICIADI"].ToString());
                    i++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.ToString();
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public string personelGetByName(int personelId)//Personel ismini getir
        {
            string sonuc = "";
            SqlConnection con = new SqlConnection(gnl.conString);//Veritabanına bağlan
            SqlCommand cmd = new SqlCommand("Select AD + SOYAD from Personeller WHERE Personeller.DURUM=0 AND Personeller.ID=@personelId ", con);
            cmd.Parameters.Add("@personelId", SqlDbType.Int).Value = personelId;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                string hata = ex.ToString();
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();

            }
            return sonuc;
        }
        public bool personelChangePassword(int personelId, string password)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);//Veritabanına bağlan
            SqlCommand cmd = new SqlCommand("UPDATE Personeller SET PAROLA=@password WHERE ID=@personelId", con);
            cmd.Parameters.Add("@personelId", SqlDbType.Int).Value = personelId;
            cmd.Parameters.Add("@password", SqlDbType.Int).Value = password;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.ToString();
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }
        public bool personelAdd(cPersoneller cp)//Personel ekle
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);//Veritabanına bağlan
            SqlCommand cmd = new SqlCommand("INSERT INTO personeller (AD,SOYAD,PAROLA,GOREVID) VALUES (@AD,@SOYAD,@PAROLA,@GOREVID) ", con);
            cmd.Parameters.Add("@AD", SqlDbType.VarChar).Value = _PersonelAd;
            cmd.Parameters.Add("@SOYAD", SqlDbType.VarChar).Value = _PersonelSoyad;
            cmd.Parameters.Add("@PAROLA", SqlDbType.VarChar).Value = _PersonelParola;
            cmd.Parameters.Add("@GOREVID", SqlDbType.Int).Value = _PersonelGorevID;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.ToString();
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }
        public bool personelUpdate(cPersoneller cp, int personelId)//Personel Güncelle
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);//Veritabanına bağlan
            SqlCommand cmd = new SqlCommand("UPDATE Personeller SET AD=@AD,SOYAD=@SOYAD,PAROLA=@PAROLA,GOREVID=@GOREVID WHERE ID=@personelId", con);
            cmd.Parameters.Add("@personelId", SqlDbType.Int).Value = personelId;
            cmd.Parameters.Add("@AD", SqlDbType.VarChar).Value = _PersonelAd;
            cmd.Parameters.Add("@SOYAD", SqlDbType.VarChar).Value = _PersonelSoyad;
            cmd.Parameters.Add("@PAROLA", SqlDbType.VarChar).Value = _PersonelParola;
            cmd.Parameters.Add("@GOREVID", SqlDbType.Int).Value = _PersonelGorevID;
            sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.ToString();
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }
        public bool personelDelete(int personelId)//Personel Silme
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);//Veritabanına bağlan
            SqlCommand cmd = new SqlCommand("UPDATE personeller SET DURUM=1 WHERE ID=@personelId", con);
            cmd.Parameters.Add("@personelId", SqlDbType.Int).Value = personelId;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.ToString();
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }
    }
}
