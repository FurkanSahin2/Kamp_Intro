using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // class lar ikiye ayrılır: 1) İçerisinde özellik barındıran, 2) İçerisinde operasyon (methods) barındıran class lar

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 3; // Arkada '3' mobilya grubuna karşılık geliyor olsun
            product1.ProductName = "Masa";
            product1.UnitPrice = 600;
            product1.UnitsInStock = 10;

            Product product2 = new Product();
            product2.Id = 2;
            product2.CategoryId = 5;
            product2.ProductName = "Kalem";
            product2.UnitPrice = 25;
            product2.UnitsInStock = 100;

            Console.WriteLine("------Veya------");

            Product product3 = new Product { Id = 3, CategoryId = 8, UnitsInStock = 250, ProductName = "Saat", UnitPrice = 100 };

            // Not1: Java - C# gibi diller büyük-küçük harfe duyarlı (case sensitive) dillerdendir. 
            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product2);

            int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi);


        }
    }
}
