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
//Giriş bilgilerinde hangi personel ne yaptı bilmek için bu class'ı oluşturduk.
namespace restoran
{
    class cPersonelHareketleri
    {
        cGenel gnl = new cGenel();
        #region Field
        private int _ID;
        private int _PersonelId;
        private string _Islem;
        private DateTime _Tarih;
        private bool _Durum;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public string Islem { get => _Islem; set => _Islem = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public bool Durum { get => _Durum; set => _Durum = value; }
        public object Sqlconnection { get; private set; }
        #endregion
        public bool PersonelActionSave(cPersonelHareketleri ph)
        {
            bool result = false;
            //Durumları kaydetmek için veritabanına bağlanıyoruz.
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert  Into personelHareketleri(PERSONELID,ISLEM,TARIH)Values(@personelId,@islem,@tarih)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();//SQL Kapalıysa önce onu aç.
                }
                cmd.Parameters.Add("@personelId", System.Data.SqlDbType.Int).Value = ph._PersonelId;
                cmd.Parameters.Add("@islem", System.Data.SqlDbType.VarChar).Value = ph._Islem;
                cmd.Parameters.Add("@tarih", System.Data.SqlDbType.DateTime).Value = ph._Tarih;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return result;
        }
    }
}
