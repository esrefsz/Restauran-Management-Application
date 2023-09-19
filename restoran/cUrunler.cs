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

namespace restoran
{
    class cUrunler
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _urunId;
        private int _urunTurNo;
        private string _urunAd;
        private decimal _fiyat;
        private string _aciklama;
        #endregion
        #region Properties
        public int UrunId { get => _urunId; set => _urunId = value; }
        public int UrunTurNo { get => _urunTurNo; set => _urunTurNo = value; }
        public string UrunAd { get => _urunAd; set => _urunAd = value; }
        public decimal Fiyat { get => _fiyat; set => _fiyat = value; }
        public string Aciklama { get => _aciklama; set => _aciklama = value; }
        #endregion
        public void urunleriListeleUrunAd(ListView lv, string urunAdi)//Ürün adına göre ürün listele
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select urunler.*, KATEGORIADI From urunler INNER JOIN kategoriler on kategoriler.ID=urunler.KATEGORIID WHERE (urunler.DURUM=0) AND (URUNADI like '%' + @urunAdi + '%') ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@urunAdi", SqlDbType.VarChar).Value = urunAdi;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public int urunEkle(cUrunler u)//Ürün ekleme
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into urunler (KATEGORIID,URUNADI,ACIKLAMA,FIYAT) values(@KATEGORIID,@URUNADI,@ACIKLAMA,@FIYAT)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@URUNADI", SqlDbType.VarChar).Value = u._urunAd;
                cmd.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = u._urunTurNo;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = u._aciklama;
                cmd.Parameters.Add("@FIYAT", SqlDbType.Money).Value = u._fiyat;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }
        public void urunleriListele(ListView lv)//Ürünleri ve kategorileri listeleyecek
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select urunler.*, KATEGORIADI From urunler INNER JOIN kategoriler on kategoriler.ID=urunler.KATEGORIID WHERE urunler.DURUM=0", con);
            SqlDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public int urunleriGuncelle(cUrunler u)//Ürünleri güncelleme
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update urunler set URUNADI=@URUNADI,KATEGORIID=@KATEGORIID,ACIKLAMA=@ACIKLAMA,FIYAT=@FIYAT where ID=@URUNID", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@URUNID", SqlDbType.Int).Value = u._urunId;
                cmd.Parameters.Add("@URUNADI", SqlDbType.VarChar).Value = u._urunAd;
                cmd.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = u._urunTurNo;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = u._aciklama;
                cmd.Parameters.Add("@FIYAT", SqlDbType.Money).Value = u._fiyat;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }
        public int urunSil(cUrunler u, int kategoriId)//Ürünleri silme
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            string sql = "Update urunler set DURUM=1 where ";
            if (kategoriId == 0)
            {
                sql += "KATEGORIID=@urunId";//Kategoriye ait ürünleri de sil
            }
            else
            {
                sql += "ID=@urunId";
            }
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@urunId", SqlDbType.Int).Value = u._urunId;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }
        public void urunleriListeleUrunId(ListView lv, int urunId)//Ürün ID'sine göre ürün listele
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select urunler.*, KATEGORIADI From urunler INNER JOIN kategoriler on kategoriler.ID=urunler.KATEGORIID WHERE urunler.DURUM=0 AND urunler.KATEGORIID=@urunId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@urunId", SqlDbType.Int).Value = urunId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public void urunleriListeleIstatistiklereGore(ListView lv, DateTimePicker Baslangic, DateTimePicker Bitis)//İki tarih arası tüm ürünleri getirir
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT TOP 10 dbo.urunler.URUNADI, SUM(dbo.satislar.ADET) as adeti FROM dbo.kategoriler INNER JOIN dbo.urunler ON dbo.kategoriler.ID=dbo.urunler.KATEGORIID INNER JOIN dbo.satislar ON dbo.urunler.ID=dbo.satislar.URUNID INNER JOIN dbo.adisyon ON dbo.satislar.ADISYONID=dbo.adisyon.ID WHERE (CONVERT(datetime,TARIH,104) BETWEEN CONVERT (datetime,@Baslangic,104) AND CONVERT(datetime,@Bitis,104)) GROUP BY dbo.urunler.URUNADI ORDER BY adeti DESC", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@Baslangic", SqlDbType.VarChar).Value = Baslangic.Value.ToShortDateString();
            cmd.Parameters.Add("@Bitis", SqlDbType.VarChar).Value = Bitis.Value.ToShortDateString();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["URUNADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adeti"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public void urunleriListeleIstatistiklereGoreUrunId(ListView lv, DateTimePicker Baslangic, DateTimePicker Bitis, int urunKategoriId)//İki tarih arası belirli kategoride ki ürünleri getirir
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT TOP 10 dbo.urunler.URUNADI, SUM(dbo.satislar.ADET) as adeti FROM dbo.kategoriler INNER JOIN dbo.urunler ON dbo.kategoriler.ID=dbo.urunler.KATEGORIID INNER JOIN dbo.satislar ON dbo.urunler.ID=dbo.satislar.URUNID INNER JOIN dbo.adisyon ON dbo.satislar.ADISYONID=dbo.adisyon.ID WHERE (CONVERT(datetime,TARIH,104) BETWEEN CONVERT (datetime,@Baslangic,104) AND CONVERT(datetime,@Bitis,104)) AND (dbo.urunler.KATEGORIID=@urunKategoriId) GROUP BY dbo.urunler.URUNADI ORDER BY adeti DESC", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@Baslangic", SqlDbType.VarChar).Value = Baslangic.Value.ToShortDateString();
            cmd.Parameters.Add("@Bitis", SqlDbType.VarChar).Value = Bitis.Value.ToShortDateString();
            cmd.Parameters.Add("@urunKategoriId", SqlDbType.Int).Value = urunKategoriId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["URUNADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adeti"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
    }
}
