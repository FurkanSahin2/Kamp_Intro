using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "M. Furkan ";
            int yas = 23;

            Console.WriteLine(adi);
            Console.WriteLine(yas);


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 54;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Javascript";
            kurs2.Egitmen = "Furkan Işık";
            kurs2.İzlenmeOrani = 81;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "Murat Arslan";
            kurs3.İzlenmeOrani = 15;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Java";
            kurs4.Egitmen = "Hasan Sarı";
            kurs4.İzlenmeOrani = 100;


            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (Kurs kurs in kurslar) // Buradaki "kurs" alias'tır. Yani; takma isimdir. Herhangibir şey koyabiliriz.
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }  

            // Console.WriteLine("Hello World!");
        }
    }

    class  Kurs // Biz burada "Kurs" u class yaparak onu aslında 'string-int vb.' gibi bir veri türü (değişken) yaptık.  
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; } 
        public int İzlenmeOrani { get; set; }
        public int Furkan { get; }
    }
}
