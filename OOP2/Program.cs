using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Furkan Şahin
            GercekMusteri gercekMusteri1 = new GercekMusteri();
            gercekMusteri1.Id = 1;
            gercekMusteri1.MusteriNo = "12345";
            gercekMusteri1.Adi = "Furkan";
            gercekMusteri1.Soyadi = "Şahin";
            gercekMusteri1.TcNo = "22222222222";

            // Kodlama.io

            TuzelMusteri tuzelMusteri1 = new TuzelMusteri();
            tuzelMusteri1.Id = 2;
            tuzelMusteri1.MusteriNo = "54321";
            tuzelMusteri1.SirketAdi = "Kodlama.io";
            tuzelMusteri1.VergiNo = "1234567890";

            Musteri musteri1 = new GercekMusteri();
            Musteri musteri2 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(gercekMusteri1);
            musteriManager.Ekle(tuzelMusteri1);
            


            // Gerçek Müşteri - Tüzel Müşteri
            // SO'L'ID
        }
    }
}
