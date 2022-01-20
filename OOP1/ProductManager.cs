using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    // Not1: "...Manager" tarzında bir class görünce anlamalıyız ki içerisinde ürünle ilgili operasyonlar vardır. (Temelinde 'CRUD' denilen operasyonlar: Create, Read, Upload, Delete. Bunun dışında arama, ekleme vs.)        
    class ProductManager
    {
        // encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }

        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }
    }

}
