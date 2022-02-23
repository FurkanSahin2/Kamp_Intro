using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Coorporate
    class TuzelMusteri:Musteri // Bu işleme miras / inheritance denir. Manası: 'Musteri'nin içerisindeki tüm özellikler 'TuzelMusteri'de de var kabul edilsin.  
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
