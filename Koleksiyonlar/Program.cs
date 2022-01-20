using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Furkan", "Ali", "Abdullah", "Mehmet" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Bedir";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            // Note1: İlk yazdığımız 4 elemanlı "isimler" değişkenin heapte bellek alanı örneğin 100 olsun. Yeni elemanlar eklemek    
            // istediğimiz zaman tekrar tanımlayıp ekleme yaparız. Bu durumda "isimler" değişkenin referans numarası olan 100 değişir ve yeni değeri
            // olan 101 numarasını alır. Bu örnekte 6 eleman alma potansiyeli bulunup yalnızca 5. elemanı girilip diğerleri boş bırakılmış oldu.
            // Sonra 5. elemanı yazdırmak istediğimizde yazdı fakat 1. elemanı yazdırmak istediğimizde yazdırmadı. Çünkü "isimler" değişkeninin referans
            // numarası 101 olunca 100 ile bütün irtibatı koptu ve artık yalnızca 101 deki elemanları yazdırabilir. 1. elemanda olmadığı için boşluk yazacaktır.
            // Bu gibi sonradan ekleme durumlarında problem çıkmaması için genelde yazılımcılar C# ve Java dillerinde array yapısı yerine koleksiyonlar yapısını kullanmayı tercih ederler.

            List<string> isimler2 = new List<string> { "Furkan", "Ali", "Abdullah", "Mehmet" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Bedir");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

          
        }
    }
}
