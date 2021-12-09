using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        // Property = Açıklama
        public int Id { get; set; } // "Id" = Bir data'yı diğerlerinden ayırt etmek için kullandığımız alandır (eşsiz değeri anlatır).

        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}

// public (Erişim bildirgeci)
