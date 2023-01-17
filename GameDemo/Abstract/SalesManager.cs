using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    class SalesManager : ISalesService
    {
        public void Add(Sales sales)
        {
            Console.WriteLine("Satın alma işlemi eklendi.");
        }

        public void Delete(Sales sales)
        {
            Console.WriteLine("Satın alma işlemi silindi.");
        }

        public void Updade(Sales sales)
        {
            Console.WriteLine("Satın alma işlemi güncellendi.");
        }
    }
}
