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
    class cRezervasyon
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _ID;
        private int _tableId;
        private int _clientId;
        private DateTime _date;
        private int _clientCount;
        private string _description;
        private int _additionId;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int TableId { get => _tableId; set => _tableId = value; }
        public int ClientId { get => _clientId; set => _clientId = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public int ClientCount { get => _clientCount; set => _clientCount = value; }
        public string Description { get => _description; set => _description = value; }
        public int AdditionId { get => _additionId; set => _additionId = value; }
        #endregion

        public int getByClientIdFromRezervasyon(int tableId)//Müşeteri ID masa numarasına göre
        {
            int clientId = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 rezervasyonlar.MUSTERIID from rezervasyonlar where MASAID=@tableId order by MUSTERIID Desc", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("tableId", SqlDbType.Int).Value = tableId;
                clientId = Convert.ToInt32(cmd.ExecuteScalar());
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
            return clientId;
        }
        public bool rezervationClose(int adisyonId)//Rezervasyonlu masayı kapatma
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("UPDATE rezervasyonlar set durum=0 where ADISYONID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;
                result = Convert.ToBoolean(cmd.ExecuteScalar());
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
            return result;
        }
        public void musteriIdGetirFromRezervasyon(ListView lv, int musteriNo)//Rezervasyonları getir
        {
            lv.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select rezervasyonlar.MUSTERIID,(AD + SOYAD) AS musteri FROM rezervasyonlar INNER JOIN musteriler ON rezervasyonlar.MUSTERIID=musteriler.ID WHERE rezervasyonlar.DURUM=0", conn);
            SqlDataReader dr = null;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["MUSTERIID"].ToString());
                    lv.Items[i].SubItems.Add(dr["musteri"].ToString());
                    i++;
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
                conn.Dispose();
                conn.Close();
            }

        }
        public void eskiRezervasyonlariGetir(ListView lv, int musteriNo)//Eski rezervasyonları getir
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select rezervasyonlar.MUSTERIID,AD,SOYAD,ADISYONID,TARIH AS musteri FROM rezervasyonlar INNER JOIN musteriler ON rezervasyonlar.MUSTERIID=musteriler.IS WHERE rezervasyonlar.MUSTERIID=@musteriNo AND rezervasyonlar.DURUM=0 ORDER BY rezervasyonlar.ID DESC", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("musteriNo", SqlDbType.Int).Value = musteriNo;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["MUSTERIID"].ToString());
                    lv.Items[i].SubItems.Add(dr["AD"].ToString());
                    lv.Items[i].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[i].SubItems.Add(dr["TARIH"].ToString());
                    lv.Items[i].SubItems.Add(dr["ADISYONID"].ToString());

                    i++;
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
        public DateTime enSonRezervasyonTarihi(int musteriNo)//En son rezervasyon tarihini getirir
        {
            DateTime tarih = new DateTime();
            tarih = DateTime.Now; ;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select TARIH AS musteri FROM rezervasyonlar WHERE rezervasyonlar.MUSTERIID=@musteriNo AND rezervasyonlar.DURUM=1 ORDER BY rezervasyonlar.ID DESC", con);
            cmd.Parameters.Add("musteriNo", SqlDbType.Int).Value = musteriNo;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                tarih = Convert.ToDateTime(cmd.ExecuteReader());
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
            return tarih;
        }
        public int acikRezervasyonSayisi(int musteriNo)//Açık rezervasyon sayısını getir
        {
            int sonuc = 0;
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select count(*) FROM rezervasyonlar WHERE rezervasyonlar.DURUM=0", conn);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                sonuc = Convert.ToInt32(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                conn.Dispose();
                conn.Close();
            }
            return sonuc;
        }
        public bool rezervasyonAcikMiKontrol(int musteriNo)//Rezervasyon açık mı kontrolü
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT top 1 rezervasyonlar.ID FROM rezervasyonlar WHERE (MUSTERIID=@musteriNo) AND (DURUM=1) ORDER BY ID DESC", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("musteriNo", SqlDbType.Int).Value = musteriNo;
                result = Convert.ToBoolean(cmd.ExecuteScalar());
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
            return result;
        }
        public bool rezervasyonAc(cRezervasyon r)//Rezervasyon aç
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("INSERT INTO rezervasyonlar (MUSTERIID,MASAID,ADISYONID,KISISAYISI,TARIH,ACIKLAMA,DURUM) values (@MUSTERIID,@MASAID,@ADISYONID,@KISISAYISI,@TARIH,@ACIKLAMA,1)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("MUSTERIID", SqlDbType.Int).Value = r._clientId;
                cmd.Parameters.Add("MASAID", SqlDbType.Int).Value = r._tableId;
                cmd.Parameters.Add("ADISYONID", SqlDbType.Int).Value = r._additionId;
                cmd.Parameters.Add("KISISAYISI", SqlDbType.Int).Value = r._clientCount;
                cmd.Parameters.Add("TARIH", SqlDbType.DateTime).Value = r._date;
                cmd.Parameters.Add("ACIKLAMA", SqlDbType.VarChar).Value = r._description;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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
            return result;
        }
        public int rezerveMasaIdGetir(int musteriNo)//Rezerve masa id'sini getirir
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select rezervasyonlar.MASAID FROM rezervasyonlar INNER JOIN adisyon on rezervasyonlar.ADISYONID=adisyon.ID WHERE (rezervasyonlar.DURUM=1 AND adisyon.DURUM=0 and rezervasyonlar.MUSTERIID=@musteriNo)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("musteriNo", SqlDbType.Int).Value = musteriNo;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
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
    }
}
