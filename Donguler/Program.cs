using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Programcılığa Giriş İçin Temel Kurs";
            string kurs2 = "Java";
            string kurs3 = "C++";
            string kurs4 = "Python";
            string kurs5 = "C#";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            // Bu kadar statik kod yerine "Dizi ve Döngü" den yararlanarak dinamik kodlar yazabiliriz.
            // array = dizi

            string[] kurslar = new string [] { "Programcılığa Giriş İçin Temel Kurs", "Java", "C++", "Python", "C#" };

            for (int i = 0; i < kurslar.Length; i++) // Lenght: Eleman sayısı demektir. Bu kod ile sayıya bağlı kalmaksızın kurslar dizisinde kaç eleman varsa onu yazdırır.  
            {
                Console.WriteLine (kurslar[i]);
            }

            Console.WriteLine("For döngüsü sonlandı");

            // "For" daha genel kullanımı varken "foreach" dizilere uygulanır. Foreach: Dizi temelli yapıları tek tek dönmeye / dolaşmaya yarar. 

            foreach (string kurs in kurslar)  // Buradaki "kurs" = alias. Her bir eleman için demektir. "Kurs" yerine herhangi bir şey yazılsa da çalışır.
            {
                Console.WriteLine (kurs);
            }

            Console.WriteLine ("Sayfa Sonu- Footer");


            // for (int i = 1; i <= 10; i+=2) // "i=i+2" ile "i+=2" aynıdır.
            // { Console.WriteLine(i);}
        }
    }
}
