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
    class cMasalar
    {
        #region Fields
        private int _ID;
        private int _KAPASITE;
        private int _SERVISTURU;
        private int _DURUM;
        private int _ONAY;
        private string _MASABILGI;
        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int KAPASITE { get => _KAPASITE; set => _KAPASITE = value; }
        public int SERVISTURU { get => _SERVISTURU; set => _SERVISTURU = value; }
        public int DURUM { get => _DURUM; set => _DURUM = value; }
        public int ONAY { get => _ONAY; set => _ONAY = value; }
        public string MASABILGI { get => _MASABILGI; set => _MASABILGI = value; }
        #endregion

        cGenel gnl = new cGenel();
        public string SessionSum(int state, string masaId)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select TARIH, MasaId From adisyon Right Join Masalar on adisyon.MasaId=Masalar.ID Where Masalar.Durum=@durum and adisyon.Durum=0 and masalar.ID=@masaId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = Convert.ToInt32(masaId);

            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["TARIH"]).ToString();
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
            return dt;
        }

        public int TableGetbyNumber(string TableValue)
        {
            //Bu fonkiyonlar masa numarasını alıyoruz, yani MASA 1 yazısının sonda 1'ini alıyoruz.
            string aa = TableValue;
            int length = aa.Length;
            if (length > 8)
            {
                return Convert.ToInt32(aa.Substring(length - 2, 2));
            }
            else
            {
                return Convert.ToInt32(aa.Substring(length - 1, 1));
            }

        }
        public bool TableGetbyState(int ButtonName, int state)//State masalarda ki durumlar yani 1,2,3,4 durumları dolu, boş, rezerve vs.
        {
            //Masanın durumunu öğrenmek için yazdığımız fonksiyon.
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            //Veritabanında masaların durumunu alıyoruz yani id ve masa durumunu.
            SqlCommand cmd = new SqlCommand("Select durum From Masalar Where ID=@TableId and DURUM=@State", con);

            cmd.Parameters.Add("@TableID", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());

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

            return result;
        }
        public void setChangeTableState(string ButonName, int state)
        {//Masa durumunu değiştiriyoruz
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update masalar Set DURUM=@Durum where ID=@MasaNo", con);//Masa/ların durumunu değiştir dolu yap.
            string masaNo = "";
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string aa = ButonName;
                int uzunluk = aa.Length;
                cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;
                //masaNo = aa.Substring(uzunluk - 1, 1);
                if (uzunluk > 8)
                {
                    masaNo = aa.Substring(uzunluk - 2, 2);
                }
                else if (uzunluk == 2)
                {
                    masaNo = aa;
                }
                else
                {
                    masaNo = aa.Substring(uzunluk - 1, 1);
                }
                cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = Convert.ToInt32(masaNo);
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
        public void masaKapasiteDurumGetir(ComboBox cb)
        {
            cb.Items.Clear();
            string durum = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM masalar ", con);
            SqlDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cMasalar c = new cMasalar();
                    if (c._DURUM == 2)
                    {
                        durum = "DOLU";
                    }
                    else if (c._DURUM == 3)
                    {
                        durum = "REZERVE";
                    }
                    c._KAPASITE = Convert.ToInt32(dr["KAPASITE"]);
                    c._MASABILGI = "Masa No: " + dr["ID"].ToString() + " Kapasitesi: " + dr["KAPASITE"].ToString();
                    c._ID = Convert.ToInt32(dr["ID"]);
                    cb.Items.Add(c);
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
        public override string ToString()
        {
            return MASABILGI;
        }
    }
}
