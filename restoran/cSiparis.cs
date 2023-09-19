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
    class cSiparis
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _Id;
        private int _adisyonID;
        private int _urunId;
        private float _adet;
        private int _masaId;
        #endregion

        #region Properties
        public int Id { get => _Id; set => _Id = value; }
        public int AdisyonID { get => _adisyonID; set => _adisyonID = value; }
        public int UrunId { get => _urunId; set => _urunId = value; }
        public float Adet { get => _adet; set => _adet = value; }
        public int MasaId { get => _masaId; set => _masaId = value; }
        #endregion
        //Siparişleri getir
        public void getByOrder(ListView lv, int AdisyonId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select URUNADI,FIYAT,satislar.ID, Satislar.URUNID, satislar.ADET from satislar Inner Join urunler on satislar.URUNID=Urunler.ID Where ADISYONID=@AdisyonId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = AdisyonId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {//List view'e bilgileri dolduruyoruz.
                    lv.Items.Add(dr["URUNADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["FIYAT"]) * Convert.ToDecimal(dr["ADET"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());

                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Close();
                con.Dispose();
                con.Close();
            }
        }
        public bool setSaveOrder(cSiparis Bilgiler)
        {//Sipariş bilgilerini veritabanına işle
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into satislar(ADISYONID,URUNID,ADET,MASAID) values(@AdisyonNo,@UrunId,@Adet,@MasaId)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdisyonNo", SqlDbType.Int).Value = Bilgiler._adisyonID;
                cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = Bilgiler._urunId;
                cmd.Parameters.Add("@Adet", SqlDbType.Float).Value = Bilgiler._adet;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = Bilgiler._masaId;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
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
        public void setDeleteOrder(int satisId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Delete From Satislar Where ID=@SatisId", con);
            cmd.Parameters.Add("@SatisId", SqlDbType.Int).Value = satisId;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
        public decimal genelToplamBul(int musteriId)
        {
            decimal genelToplam = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT SUM(dbo.satislar.ADET * dbo.urunler.FIYAT) AS Fiyat FROM dbo.musteriler INNER JOIN dbo.paketSiparis ON dbo.musteriler.ID=paketSiparis.MUSTERIID INNER JOIN  adisyon on adisyon.ID=paketSiparis.ADISYONID INNER JOIN dbo.satislar ON dbo.adisyon.ID = dbo.satislar.ADISYONID INNER JOIN dbo.urunler ON dbo.satislar.URUNID=dbo.urunler.ID WHERE (dbo.paketSiparis.MUSTERIID=@musteriId) AND (dbo.paketSiparis.DURUM=0)", con);
            cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                genelToplam = Convert.ToDecimal(cmd.ExecuteScalar());
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
            return genelToplam;
        }
        public void adisyonPaketSiparisDetaylari(ListView lv, int adisyonId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select satislar.ID as satisID, urunler.URUNADI, urunler.FIYAT, satislar.ADET FROM satislar INNER JOIN adisyon ON adisyon.ID=satislar.ADISYONID INNER JOIN urunler ON urunler.ID=satislar.URUNID WHERE satislar.ADISYONID=@adisyonId", con);
            cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;
            SqlDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int i = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lv.Items.Add(dr["satisID"].ToString());
                    lv.Items[i].SubItems.Add(dr["URUNADI"].ToString());
                    lv.Items[i].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                    i++;
                }
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
        }
    }


}
