using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //bu alttaki satırlar banklacının ekranı gibi düşün //ekrandaki açılır kutudan seçiçek adam müşterinin talebini
            ICrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            
            ICrediManager tasitKrediManager = new TasitKrediManager();
         
            ICrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);//adam ekranda neyi seçse parametre olarak gönül rahatlığıyla yolla çünkü ıkredi manageri implemente eden konu taşıt ihtiyac kredisinden istediğini gönderebilrsin
            //ve hangisini yollarsan hangi krediyi yolluyosan onun hesapla fonksyionu çalışıyo interfaceden dolayı
            //basvuruManager.BasvuruYap(konutKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager); 
            //çoooook önemliii!!!! sektörde seni uçuracak bilgidir.


            List<ICrediManager> krediler = new List<ICrediManager>() {ihtiyacKrediManager,tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
