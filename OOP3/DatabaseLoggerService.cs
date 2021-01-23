using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService: ILoggerService //sen aslında bi iloggerservice alternatifisin
    {
        public void Log()
        {
            Console.WriteLine("veritabanına loglandı");
        }
        
    }
}
