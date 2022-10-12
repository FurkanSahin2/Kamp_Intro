using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // Not: İmzanın aynı olduğu fakat içerisinin farklı olduğu durumlarda "interface" yapısını kullanırız. Yani, "interface" yapısını birbirinin alternatifi olan fakat kod içerikleri farklı olan durumlar için kullanırız. 
    interface IKrediManager
    {
        void Hesapla();
        void BirşeyYap();
    }
}
