using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService //sen aslında bi iloggerservice alternatifisin
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }

    }
}
