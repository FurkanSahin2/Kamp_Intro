using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(" >--< Tebrikler Müşteri Eklendi >--< ");
            Console.WriteLine("Ad: " + musteri.MusteriAd);
            Console.WriteLine("Soyad: " + musteri.MusteriSoyad);
            Console.WriteLine("Yas: " + musteri.Yas);
            Console.WriteLine("Cinsiyet: " + musteri.Cinsiyet);
        }
    }
}
