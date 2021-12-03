using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            // Not: int, decimal, float, double, bool (arkada 0,1 tutar) = değer tip
            // Not2: array, class, interface = referans tip

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // Soru 1: sayi1 = ? Cevap: 30


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // Soru 2: sayilar1[0] = ? Cevap: 999



        }
    }
}
