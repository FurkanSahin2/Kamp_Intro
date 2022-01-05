using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double Fiyati = 15;
            string Aciklama = "Amasya Elması";

            string[] meyveler = new string[] {"Elma","Karpuz"};

            Urun urun1 = new Urun(); // Bunu yaparak class ı tanımlıyoruz. Buna "class'ın örneği" denir. 

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 18;

            Urun urun2 = new Urun();

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 5;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 21;

            Urun[] urunler = new Urun[] {urun1,urun2};

            // type - safe = Tip güvenli (c# ve java dilleri type - safe'dir. Bu sebeple veri-tipini görmek istediği için "Urunler/var" yazıyoruz.

            foreach (Urun urun in urunler) // "Urun"ın yerine "var" da yazabiliriz. Çünkü kodlar derlenirken otomatik olarak class (veri-tipi) adını alır.  İkinci "urun" ün (lokal değişken) yerine herhangi bir şey yazabiliriz. Örneğin "x" vb.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("-------------Metotlar-------------");

            // Metotlar bize bir şeyi tekrar tekrar kullanabilme imkanı verir.
            // encapsulation
            SepetManager sepetManager = new SepetManager(); // Bu yazdığımız kod: instance = Class örneği oluşturmak
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 7);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 10, 3);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 5);
            sepetManager.Ekle2("Çilek", "Taze Çilek", 22,9);


        }
    }
}


// Don't repeat yourself (Kendini tekrarlama!) - DRY - Clean Code - Best Practice (Doğru uygulama teknikleri)