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
using System.Text.RegularExpressions;

namespace restoran
{
    class cUrunCesitleri
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _UrunTurNo;
        private string _KategoriAd;
        private string _Aciklama;
        #endregion
        #region Properties
        public int UrunTurNo { get => _UrunTurNo; set => _UrunTurNo = value; }
        public string KategoriAd { get => _KategoriAd; set => _KategoriAd = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        #endregion
        public void getByProductTypes(ListView Cesitler, Button btn)
        {
            Cesitler.Items.Clear();//Kullandığımız kontrolü temizlememik gerek her çağırdığımız zaman.
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select URUNADI,FIYAT,urunler.ID From kategoriler Inner Join urunler on kategoriler.ID=urunler.KATEGORIID where urunler.KATEGORIID=@KATEGORIID", conn);
            SqlDataReader dr = null;
            string aa = btn.Name;
            int uzunluk = aa.Length;
            string[] number = Regex.Split(aa, @"\D+");
            comm.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = number[1];
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {//ürün adı:  Fiyat:   Ürün id:  //Bunları yazacak listview'a
                Cesitler.Items.Add(dr["URUNADI"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }//Bağlatıları kapat ve bitir.
        public void getByProductSearch(ListView Cesitler, int txt)//Ürün aramak için
        {
            Cesitler.Items.Clear();//Kullandığımız kontrolü temizlememik gerek her çağırdığımız zaman.
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select *from urunler where ID=@ID", conn);
            SqlDataReader dr = null;
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = txt;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {//ürün adı:  Fiyat:   Ürün id:  //Bunları yazacak listview'a
                Cesitler.Items.Add(dr["URUNADI"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }//Bağlatıları kapat ve bitir.
        public void urunCesitleriniGetirCB(ComboBox cb)//Ürün çeşitlerini getir Combobox
        {
            cb.Controls.Clear();
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * FROM kategoriler Where DURUM=0", con);
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
                    cUrunCesitleri uc = new cUrunCesitleri();
                    uc._UrunTurNo = Convert.ToInt32(dr["ID"]);
                    uc._KategoriAd = (dr["KATEGORIADI"]).ToString();
                    uc._Aciklama = (dr["ACIKLAMA"]).ToString();
                    cb.Items.Add(uc);//Overload işlemi yapıyoruz
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
        public void urunCesitleriniGetirLV(ListView lv)//Ürün çeşitlerini getir Listview
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * FROM kategoriler WHERE DURUM=0", con);
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
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());
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
        public void urunCesitleriniAra(ListView lv, string arama)//Ürün çeşitlerini getir Listview Arama
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * FROM kategoriler WHERE (DURUM=0) AND (KATEGORIADI like '%' + @arama+'%')", con);
            cmd.Parameters.Add("arama", SqlDbType.VarChar).Value = arama;
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
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());
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
        public int urunCesitleriniEkle(cUrunCesitleri u)//Ürün çeşitleri ekleme
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into kategoriler (KATEGORIADI,ACIKLAMA) values(@KATEGORIADI,@ACIKLAMA)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@KATEGORIADI", SqlDbType.VarChar).Value = u._KategoriAd;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = u._Aciklama;
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
        public int urunCesitleriniGuncelle(cUrunCesitleri u)//Ürün çeşitleri güncelleme
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update kategoriler set KATEGORIADI=@KATEGORIADI,ACIKLAMA=@ACIKLAMA where ID=@KATEGORIID", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = u._UrunTurNo;
                cmd.Parameters.Add("@KATEGORIADI", SqlDbType.VarChar).Value = u._KategoriAd;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = u._Aciklama;
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
        public int urunCesitleriniSil(int id)//Ürün çeşitleri silme
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update kategoriler set DURUM=1 where ID=@id", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public override string ToString()
        {
            return KategoriAd;
        }
    }
}
