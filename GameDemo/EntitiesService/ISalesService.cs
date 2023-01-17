using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface ISalesService
    {
        void Add(Sales sales);
        void Delete(Sales sales);
        void Updade(Sales sales);
    }
}
