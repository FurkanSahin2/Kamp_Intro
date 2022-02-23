using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }

        // Note: TcNo ve VergiNo özelliklerinin veri türünü 'long' yapmak yerine 'string' yapmamızın sebebi: Eğer bir veri üzerinde
        // matematiksel operasyon yapmıyorsan yani ona sayı görevi vermiyorsan bunları metinsel olarak planlaman daha iyi sonuç verir. 
        // Note2: Eğer ki bir nesnede bir değeri kullanmak zorunda değilsen (o nesneye ait değilmiş gibiyse) orada soyutlama hatası yapıyorsun.
    }
}
