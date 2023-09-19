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
    class cMusteriler
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _musteriId;
        private string _musteriad;
        private string _musterisoyad;
        private string _telefon;
        private string _adres;
        private string _email;
        #endregion
        #region Properties
        public int MusteriId { get => _musteriId; set => _musteriId = value; }
        public string Musteriad { get => _musteriad; set => _musteriad = value; }
        public string Musterisoyad { get => _musterisoyad; set => _musterisoyad = value; }
        public string Telefon { get => _telefon; set => _telefon = value; }
        public string Adres { get => _adres; set => _adres = value; }
        public string Email { get => _email; set => _email = value; }
        #endregion
        public bool MusteriVarMi(string tlf)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "MusteriVarMi";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = tlf;
            cmd.Parameters.Add("@sonuc", SqlDbType.Int);
            cmd.Parameters["@sonuc"].Direction = ParameterDirection.Output;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                cmd.ExecuteNonQuery();
                sonuc = Convert.ToBoolean(cmd.Parameters["@sonuc"].Value);
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
        public int MusteriEkle(cMusteriler m)
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into musteriler(AD,SOYAD,TELEFON,ADRES,EMAIL) values(@ad,@soyad,@telefon,@adres,@email); Select SCOPE_IDENTITY()", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = m._musteriad;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = m._musterisoyad;
                cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = m._telefon;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = m._adres;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = m._email;
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
        }//Veritabanına müşteri ekleme
        public bool MusteriBilgileriGuncelle(cMusteriler m)//Seçili müşteri bilgisini güncelleme
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update musteriler set AD=@ad,SOYAD=@soyad,TELEFON=@telefon,ADRES=@adres,EMAIL=@email where ID=@musteriId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = m._musteriad;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = m._musterisoyad;
                cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = m._telefon;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = m._adres;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = m._email;
                cmd.Parameters.Add("@musteriId", SqlDbType.VarChar).Value = m._musteriId;
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
        public void MusterileriGetir(ListView lv)//Veritabanından gelen verileri listview'e ekleme
        {

            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select *from musteriler", con);
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
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
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
        public void MusterileriGetirID(int musteriId, TextBox ad, TextBox soyad, TextBox telefon, TextBox adres, TextBox email)//ID'ye göre müşterileri getir
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select *from musteriler where ID=@musteriId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ad.Text = dr["AD"].ToString();
                    soyad.Text = dr["SOYAD"].ToString();
                    telefon.Text = dr["TELEFON"].ToString();
                    adres.Text = dr["ADRES"].ToString();
                    email.Text = dr["EMAIL"].ToString();
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
        public void MusterileriGetirAD(ListView lv, string musteriAd)//Ad'a göre müşteri getir
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select *from musteriler where AD like @musteriAd + '%' ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@musteriAd", SqlDbType.VarChar).Value = musteriAd;
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
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
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
        public void MusterileriGetirSOYAD(ListView lv, string musteriSoyad)//Soyad'a göre müşteri getir
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select *from musteriler where SOYAD like @musteriSoyad + '%' ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@musteriSoyad", SqlDbType.VarChar).Value = musteriSoyad;
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
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
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
        public void MusterileriGetirTELEFON(ListView lv, string musteriTelefon)//Telefona göre müşteri getir
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select *from musteriler where TELEFON like @musteriTelefon + '%' ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@musteriTelefon", SqlDbType.VarChar).Value = musteriTelefon;
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
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
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
        public void MusterileriGetirADRES(ListView lv, string musteriAdres)//Adrese göre müşteri getir
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select *from musteriler where ADRES like @musteriAdres + '%' ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@musteriAdres", SqlDbType.VarChar).Value = musteriAdres;
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
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
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
