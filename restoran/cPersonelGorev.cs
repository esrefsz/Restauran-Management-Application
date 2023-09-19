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
    class cPersonelGorev
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _personelGorevId;
        private string _tanim;
        #endregion
        #region Properties
        public int PersonelGorevId { get => _personelGorevId; set => _personelGorevId = value; }
        public string Tanim { get => _tanim; set => _tanim = value; }
        #endregion
        public void PersonelGorevGetir(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT *FROM personelGorevleri", con);//Personel bilgileri getir
            SqlDataReader dr = null;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())//Combobox'a verileri gönder
                {
                    cPersonelGorev c = new cPersonelGorev();
                    c._personelGorevId = Convert.ToInt32(dr["ID"].ToString());
                    c._tanim = dr["GOREV"].ToString();
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
        public string PersonelGorevTanim(int personelId)
        {
            string sonuc = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT GOREV FROM personelGorevleri WHERE ID=@personelId", con);//Personel bilgileri getir
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
        public override string ToString()//Personel görev getir'de ki tanımı ezdik.
        {
            return _tanim;
        }
    }
}
