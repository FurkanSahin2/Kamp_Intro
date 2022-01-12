using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAd = "Ahmet";
            musteri1.MusteriSoyad = "Yıldız";
            musteri1.Yas = 25;
            musteri1.Cinsiyet = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAd = "Merve";
            musteri2.MusteriSoyad = "Korkmaz";
            musteri2.Yas = 45;
            musteri2.Cinsiyet = "Kadın";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAd = "Veli";
            musteri3.MusteriSoyad = "Şahin";
            musteri3.Yas = 18;
            musteri3.Cinsiyet = "Erkek";

            Console.WriteLine("--------------- Müşteri Ekleme ---------------" + "\n");

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            Console.WriteLine(" ");
            musterimanager.Ekle(musteri2);
            Console.WriteLine(" ");
            musterimanager.Ekle(musteri3);
            Console.WriteLine(" ");

            Console.WriteLine("--------------- Müşteri Listeleme ---------------" + "\n");


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musterimanager.Listeleme(musteriler);



        }
    }
}
