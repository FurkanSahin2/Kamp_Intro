using System;

namespace ClassIntroOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.urunTuru = "Teknoloji";
            urun1.urunAdi = "Telefon";
            urun1.markaAdi = "Samsung";
            urun1.urunFiyati = 3500;
            urun1.indirimOrani = 7.5;

            Product urun2 = new Product();
            urun2.urunTuru = "Mobilya";
            urun2.urunAdi = "L Koltuk";
            urun2.markaAdi = "Merinos";
            urun2.urunFiyati = 7850;
            urun2.indirimOrani = 0;

            Product urun3 = new Product();
            urun3.urunTuru = "Kırtasiye";
            urun3.urunAdi = "Uçlu Kalem";
            urun3.markaAdi = "Faber Castell";
            urun3.urunFiyati = 34;
            urun3.indirimOrani = 10;

            Product urun4 = new Product();
            urun4.urunTuru = "Giyim";
            urun4.urunAdi = "Kaban";
            urun4.markaAdi = "DeFacto";
            urun4.urunFiyati = 399;
            urun4.indirimOrani = 8.5;

            Product[] urunler = new Product[] { urun1, urun2, urun3, urun4 };

            for (int sayac = 0; sayac < urunler.Length; sayac++)
            {
                Console.WriteLine(urunler[sayac].urunTuru + " / " + urunler[sayac].urunAdi + " - " + urunler[sayac].markaAdi + " : " + urunler[sayac].urunFiyati + " " + "(" + urunler[sayac].indirimOrani + ")");
            }

            Console.WriteLine(" "); ;
            Console.WriteLine("For döngüsü bitti...");
            Console.WriteLine(" "); ;

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.urunTuru + " / " + urun.urunAdi + " - " + urun.markaAdi + " : " + urun.urunFiyati + " " + "(" + urun.indirimOrani + ")");
            }

            Console.WriteLine(" "); ;
            Console.WriteLine("Foreach döngüsü bitti...");
            Console.WriteLine(" "); ;

            int sayac2 = 0;
            while(sayac2 < urunler.Length)
            {
                Console.WriteLine(urunler[sayac2].urunTuru + " / " + urunler[sayac2].urunAdi + " - " + urunler[sayac2].markaAdi + " : " + urunler[sayac2].urunFiyati + " " + "(" + urunler[sayac2].indirimOrani + ")");
                sayac2++;
            }

            Console.WriteLine(" "); ;
            Console.WriteLine("While döngüsü bitti...");
        }











            class Product
        {
            public string urunTuru { get; set; }
            public string urunAdi { get; set; }
            public string markaAdi { get; set; }
            public int urunFiyati { get; set; }
            public double indirimOrani { get; set; }
        }
            
        }
    }

