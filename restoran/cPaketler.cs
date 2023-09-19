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

namespace restoran
{
    class cPaketler
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _ID;
        private int _AdditionId;
        private int _ClientId;
        private string _Description;
        private int _State;
        private int _PayTypeId;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int AdditionId { get => _AdditionId; set => _AdditionId = value; }
        public int ClientId { get => _ClientId; set => _ClientId = value; }
        public string Description { get => _Description; set => _Description = value; }
        public int State { get => _State; set => _State = value; }
        public int PayTypeId { get => _PayTypeId; set => _PayTypeId = value; }
        #endregion
        public bool OrderServiceOpen(cPaketler order)//Paket servisi ekleme
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into paketSiparis(ADISYONID,MUSTERIID,ODEMETURUID,ACIKLAMA) values (@ADISYONID,@MUSTERIID,@ODEMETURUID,@ACIKLAMA)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ADISYONID", SqlDbType.Int).Value = order._AdditionId;
                cmd.Parameters.Add("@MUSTERIID", SqlDbType.Int).Value = order._ClientId;
                cmd.Parameters.Add("@ODEMETURUID", SqlDbType.Int).Value = order._PayTypeId;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = order._Description;
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
        public void OrderServiceClose(int AdditionId)//Paket servisi kapatma
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("UPDATE paketSiparis SET paketSiparis.DURUM=1 WHERE paketSiparis.ADISYONID=@AdditionId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdditionId", SqlDbType.Int).Value = AdditionId;
                Convert.ToBoolean(cmd.ExecuteNonQuery());
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
        public int OdemeTurIdGetir(int adisyonId)//Açılan adisyon ve paket siparişe ait ön girilen ödeme tür id
        {
            int odemeTurId = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select paketSiparis.ODEMETURUID from paketSiparis Inner Join adisyon on paketSiparis.ADISYONID=adisyon.ID Where adisyon.ID=@adisyonId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;
                odemeTurId = Convert.ToInt32(cmd.ExecuteScalar());
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
            return odemeTurId;
        }
        public int musteriSonAdisyonIdGetir(int musteriId)//Sipariş kontrol için müşteriye ait açık olan en son adisyon no'sunu getirme
                                                          //Bir müşteriye ait 2 tane siparişin açık olmaması için
        {
            int no = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select adisyon.ID from adisyon Inner Join paketSiparis on paketSiparis.ADISYONID=adisyon.ID Where (adisyon.DURUM=0) and (paketSiparis.DURUM=0) AND paketSiparis.MUSTERIID=@musteriId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;
                no = Convert.ToInt32(cmd.ExecuteScalar());
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
            return no;
        }
        public bool getCheckOpenAdditionID(int additionId)//Müşteri arama ekranında adisyon bul butonu adisyon açık mı değil mi kontrol ediyor.
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select *from adisyon where DURUM=0 and ID=@additionId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@additionId", SqlDbType.Int).Value = additionId;
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
    }
}
