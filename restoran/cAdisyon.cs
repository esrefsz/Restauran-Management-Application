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
    class cAdisyon
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _ID;
        private int _ServisTurNo;
        private decimal _Tutar;
        private DateTime _Tarih;
        private int _PersonelId;
        private int _Durum;
        private int _MasaId;
        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int ServisTurNo { get => _ServisTurNo; set => _ServisTurNo = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int MasaId { get => _MasaId; set => _MasaId = value; }
        #endregion

        public int getByAddition(int MasaId)
        {//Adisyon bilgini almak için bir fonksiyon yazdık.
            SqlConnection con = new SqlConnection(gnl.conString);
            //Veritabanından masaid gönderdiğim masaid'si ile eşit olanı getir ve sırala ama tersten sırala ve sadece bir kayıt getir.
            SqlCommand cmd = new SqlCommand("Select top 1 ID From adisyon Where MASAID=@MasaId Order by ID desc", con);

            cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = MasaId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MasaId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return MasaId;
        }//Açık olan masanın adisyon numarası
        public bool setByAdditionNew(cAdisyon Bilgiler)
        {//Yeni müşteri yeni adisyon açılıyor
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into adisyon(SERVISTURNO,TARIH,PERSONELID,MASAID,DURUM) values(@ServisTurNo,@Tarih,@PersonelID,@MasaId,@Durum)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = Bilgiler.ServisTurNo;
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Bilgiler.Tarih;
                cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = Bilgiler.PersonelId;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = Bilgiler.MasaId;
                cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = 0;
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
        public void additionClose(int adisyonId)//Adisyonu kapatma
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("UPDATE adisyon set DURUM=1 where ID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;
                //cmd.Parameters.Add("@durum", SqlDbType.Int).Value = durum;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }
        public int paketAdisyonAdetBul()//Kaç tane paket sipariş var onu bul
        {
            int miktar = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select count(*) as Sayi from adisyon Where (DURUM=0) AND (SERVISTURNO=2)", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                miktar = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return miktar;
        }
        public void acikPaketAdisyonlar(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select paketSiparis.MUSTERIID,Musteriler.Ad + '' + musteriler.Soyad as Musteri, Adisyon.ID as adisyonID from paketSiparis Inner Join musteriler on musteriler.ID=paketSiparis.MUSTERIID Inner Join adisyon ON adisyon.Id=paketSiparis.ADISYONID where adisyon.DURUM=0", con);
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
                    lv.Items.Add(dr["MUSTERIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Musteri"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adisyonID"].ToString());
                    sayac++;
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public int musteriSonAdisyonId(int musteriId)
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select adisyon.ID from adisyon Inner Join paketSiparis on paketSiparis.ADISYONID=adisyon.ID where (paketSiparis.DURUM=0) AND (adisyon.DURUM=0) AND (paketSiparis.MUSTERIID=@musteriId)", con);
            cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }
        public void musteriDetaylar(ListView lv, int musteriId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select paketSiparis.MUSTERIID, paketSiparis.ADISYONID,musteriler.AD,musteriler.SOYAD,CONVERT(varchar(10), adisyon.TARIH,104) as Tarih from adisyon INNER Join paketSiparis on paketSiparis.ADISYONID=adisyon.ID Inner Join musteriler on musteriler.ID=paketSiparis.MUSTERIID where (adisyon.SERVISTURNO=2)  and (paketSiparis.MUSTERIID=@musteriId)", con);
            cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;
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
                    lv.Items.Add(dr["MUSTERIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Tarih"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADISYONID"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }
        public int rezervasyonAdisyonAc(cAdisyon Bilgiler)
        {//Yeni müşteri yeni adisyon açılıyor
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into adisyon(SERVISTURNO,TARIH,PERSONELID,MASAID,DURUM) values (@ServisTurNo,@Tarih,@PersonelID,@MasaId,0); Select SCOPE_IDENTITY()", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = Bilgiler.ServisTurNo;
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Bilgiler.Tarih;
                cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = Bilgiler.PersonelId;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = Bilgiler.MasaId;
                sonuc = Convert.ToInt32(cmd.ExecuteScalar());
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
        public void setDeleteAdition(int adisyonId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Delete From adisyon Where ID=@ADISYONID", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ADISYONID", SqlDbType.Int).Value = adisyonId;
                //cmd.Parameters.Add("@durum", SqlDbType.Int).Value = durum;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        } // TODO slinebilir.
    }
}
