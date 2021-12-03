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
            // Açıklama 1: Bellekte iki yer vardır. İlki stack'tır. İkincisi ise heap'tır. Değer tipleri yalnızca stackta gerçekleşiyor. Örneğin 'sayi1 = 10' ifadesini "sayi1 eşittir 10" diye okuruz vb. 'sayi1 = sayi2' ifadesini ise "sayi1 in değeri eşittir sayi2 ye" diye okuruz. Burada (stackta) sadece değeri aktarırız (kopyalıyor ve işi bitiyor) ve "sayi2" ile olan bütün irtibat kopar.
            // Açıklama 2: 'new int[]' ifadesine kadar stack'te bir değişken tanımlamış oluruz. 'new' deyince "sayilar1 için heap bellekte yeni bir alan oluştur ve o değerleri oraya yaz" demiş oluruz. 'sayilar1 = sayilar2' dediğimizde ise "sayilar1 in referans numarası sayilar2 nin referans numarasına eşittir" demiş oluruz. İkisi de referans tip olduğu için adres kopyalaması yapar. Örneğin 'sayilar2' nin referans adresi "101" olsun. 'sayilar1 = sayilar2' dediğimizde sayilar2' nin referans adresi olan "101" artık 'sayilar1' in de referans adresi olmuş olur. Alt satırda "sayilar2[0] = 999;" dediğimizde ise "sayilar2 nin referans numarasının (101) in 0. elemanı artık 999 dur." Soruda "sayilar1[0]" sorulunca sayilar1 in referans adresi 101 olduğu için cevap 999 olur.    
            // Note 1: Değer tiplerde değer atıyoruz. Referans tiplerde adresi atıyoruz.  

        }
    }
}
