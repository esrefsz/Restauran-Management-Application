/*
Novelty Yazılım Bilişim Teknolojileri Ltd. Şti. - www.noveltybilisim.com.tr
- Coder by Muhammed POLAT - Copyright (c) 2021 -

05.07.2021 - 06.09.2021 Tarihleri arasında yazılmış staj projesidir.

İletişim için: kurumsal@noveltybilisim.com.tr
https://www.muhammedpolat.com.tr/
info@muhammedpolat.com.tr
*/
//Veritabanına bağlanmak için genel bir class sınıf oluşturdum.
using System.IO;
namespace restoran
{
  
    class cGenel
    {
        public cGenel()
        {
            getSqlPath(); // server adresini direkt koda gömmektense dosyadan okuyoruz.
                            // Ama bu yöntem her defasında dosya açıp kapattığı için yorucu bir işlem.
        }
        public static int _personelId;
        public static int _gorevId;
        public static int _musteriEkleme;
        public static string _ButtonValue;
        public static int _musteriId;
        public static string _ButtonName;
        public static int _servisTurNo;
        public static string _adisyonId;
        public string conString { get; set; }
        //public string conString = ("Server=esrefcasper;Database=Restorant; Trusted_Connection=true");
        public void getSqlPath()
        {
            try
            {
                conString = File.ReadAllText("sqlPath.txt");
            }
            catch
            {
                throw;
            }
        }
    }

}

