using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety: Tip Güvenligi
            // Do not repeat yourself: Kendini tekrarlama

            string kategoriEtiketi = "Kategoriler"; // C# dilide bu tek tırnakla yapılmaz.
            int ogrenciSayisi = 32000;
            double faizOrani = 1.47;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.55;

            if (dolarDun < dolarBugun) 
            {
                Console.WriteLine("Artış Oku");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else 
            {
                Console.WriteLine("Değişmedi Oku");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            
        }
    }
}
