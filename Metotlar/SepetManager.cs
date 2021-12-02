using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
        // Naming convention = İsimlendirme kuralı
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + urun.Adi);
            Console.WriteLine("Urun Fiyatı: " + urun.Fiyati);
        }
        //Aşağıda yaptığımız yeni metotta şöyle de yazabiliriz ama bu syntax'a uygun değildir. Çünkü örneğin burauya eklenecek herbir şey için bütün sayfaların da ona göre düzenlenmesi gerekir. (Buradaki sonradan eklenen stokAdedi olsun. Böyle yapınca bütün sayfaları da düzenlemem gerekti)  
        public void Ekle2(string urunAdi, string aciklama, double Fiyati, int stokAdedi)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi: " + urunAdi);
            Console.WriteLine("Urun Fiyatı: " + Fiyati);
        }
    }
}
