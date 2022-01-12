using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    // snippet: Hazır kodlar
    // Not: Class oluştururken isimlerin ilk harfi büyük olur. 
    // Not2: Buradaki class gibilerinde sadece özellik olur. 
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; } // Ürün Adı
        public double UnitPrice { get; set; } // Birim Fiyat
        public int UnitsInStock { get; set; } // Stok adedi 
    }
}
