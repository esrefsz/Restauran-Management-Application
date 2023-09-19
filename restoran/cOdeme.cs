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
    class cOdeme
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _odemeId;
        private int _adisyonId;
        private int _odemeTurId;
        private decimal _araToplam;
        private decimal _indirim;
        private decimal _kvdTutari;
        private decimal _genelToplam;
        private DateTime _tarih;
        private int _musteriId;
        #endregion
        #region Properties
        public int OdemeId { get => _odemeId; set => _odemeId = value; }
        public int AdisyonId { get => _adisyonId; set => _adisyonId = value; }
        public int OdemeTurId { get => _odemeTurId; set => _odemeTurId = value; }
        public decimal AraToplam { get => _araToplam; set => _araToplam = value; }
        public decimal Indirim { get => _indirim; set => _indirim = value; }
        public decimal KvdTutari { get => _kvdTutari; set => _kvdTutari = value; }
        public decimal GenelToplam { get => _genelToplam; set => _genelToplam = value; }
        public DateTime Tarih { get => _tarih; set => _tarih = value; }
        public int MusteriId { get => _musteriId; set => _musteriId = value; }
        #endregion
        public bool billClose(cOdeme bill)//Müşterinin masa hesap kapatma
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into hesapOdemeleri(ADISYONID,ODEMETURUID,MUSTERIID,ARATOPLAM,KDVTUTARI,INDIRIM,TOPLAMTUTAR) values (@ADISYONID,@ODEMETURUID,@MUSTERIID,@ARATOPLAM,@KDVTUTARI,@INDIRIM,@TOPLAMTUTAR)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("ADISYONID", SqlDbType.Int).Value = bill._adisyonId;
                cmd.Parameters.Add("ODEMETURUID", SqlDbType.Int).Value = bill._odemeTurId;
                cmd.Parameters.Add("MUSTERIID", SqlDbType.Int).Value = bill._musteriId;
                cmd.Parameters.Add("ARATOPLAM", SqlDbType.Money).Value = bill._araToplam;
                cmd.Parameters.Add("KDVTUTARI", SqlDbType.Int).Value = bill._kvdTutari;
                cmd.Parameters.Add("INDIRIM", SqlDbType.Int).Value = bill._indirim;
                cmd.Parameters.Add("TOPLAMTUTAR", SqlDbType.Int).Value = bill._genelToplam;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz.", "Dikkat !  //Coder: Eşrefhan Kadıoğlu");
                //throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }
        public decimal sumTotalforClientId(int clientId) //Müşterinin toplam harcamasını buluyoruz.
        {
            decimal total = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select sum(TOPLAMTUTAR) as total from hesapOdemeleri Where MUSTERIID=@clientId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("clientId", SqlDbType.Int).Value = clientId;
                total = Convert.ToDecimal(cmd.ExecuteScalar());
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
            return total;
        }
    }
}
