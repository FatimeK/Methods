﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : ICrediManager
    {
        //CrediManagerdeki fonksiyonları miras aldı
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("taşıt kredisi hesaplandı");
        }
    }
}
